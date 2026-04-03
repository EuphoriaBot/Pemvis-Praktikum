Imports System.Collections.Generic

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Data Tamu"

        AturMaskedTextBox()
        AturFormAwal()

        ErrorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink
        ErrorProvider1.BlinkRate = 0
    End Sub

    Private Sub AturMaskedTextBox()
        mtbNoHP.Mask = "0000-0000-0000"
        mtbNoHP.PromptChar = "_"c
        mtbNoHP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
    End Sub

    Private Sub AturFormAwal()
        txtNama.CharacterCasing = CharacterCasing.Upper
        txtAlamat.Multiline = True
        TabControl1.SelectedTab = tcIdentitas
        lblRingkas.Text = ""
    End Sub

    ' VALIDASI INPUT KARAKTER
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    ' VALIDASI LANGSUNG
    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged
        ValidasiTextBox(ErrorProvider1, txtNama, "Nama tidak boleh kosong")
    End Sub

    Private Sub mtbNoHP_TextChanged(sender As Object, e As EventArgs) Handles mtbNoHP.TextChanged
        ValidasiMaskedTextBox(ErrorProvider1, mtbNoHP, "Nomor HP belum lengkap")
    End Sub

    Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtAlamat.TextChanged
        ValidasiTextBox(ErrorProvider1, txtAlamat, "Alamat tidak boleh kosong")
    End Sub

    ' RINGKASAN
    Private Sub PerbaruiRingkasan()
        lblRingkas.Text = BuatRingkasan(
            txtNama.Text,
            mtbNoHP.Text,
            txtAlamat.Text
        )
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is tcRingkasan Then
            PerbaruiRingkasan()
        End If
    End Sub


    ' TOMBOL SIMPAN

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiSemuaInput(ErrorProvider1, txtNama, mtbNoHP, txtAlamat) Then
            MessageBox.Show(
                "Masih ada input yang belum valid.",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Exit Sub
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show(
            "Apakah data ingin disimpan?",
            "Konfirmasi Simpan",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            Dim isi As String = BuatIsiFile(
                txtNama.Text,
                mtbNoHP.Text,
                txtAlamat.Text
            )

            If SimpanDataKeFile(SaveFileDialog1, isi, "data_aslab.txt") Then
                PerbaruiRingkasan()
                TabControl1.SelectedTab = tcRingkasan

                MessageBox.Show(
                    "Data berhasil disimpan.",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )
            End If

        ElseIf hasil = DialogResult.No Then
            MessageBox.Show(
                "Data tidak jadi disimpan.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        ElseIf hasil = DialogResult.Cancel Then
            MessageBox.Show(
                "Proses dibatalkan.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            )
        End If
    End Sub

    ' TOMBOL RESET

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show(
            "Apakah data ingin direset?",
            "Konfirmasi Reset",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            KosongkanForm()
        End If
    End Sub

    Private Sub KosongkanForm()
        txtNama.Clear()
        mtbNoHP.Clear()
        txtAlamat.Clear()
        lblRingkas.Text = ""

        ErrorProvider1.Clear()

        TabControl1.SelectedTab = tcIdentitas
        txtNama.Focus()
    End Sub

    ' MENU

    Private Sub mnuInputData_Click(sender As Object, e As EventArgs) Handles MenuInput.Click
        TabControl1.SelectedTab = tcIdentitas
        txtNama.Focus()
    End Sub

    Private Sub mnuBukaFile_Click(sender As Object, e As EventArgs) Handles MenuBukaFile.Click
        Dim data As Dictionary(Of String, String) = BukaDataDariFile(OpenFileDialog1)

        If data Is Nothing Then Exit Sub

        KosongkanForm()
        IsiDataKeForm(data)
        PerbaruiRingkasan()
        TabControl1.SelectedTab = tcRingkasan

        MessageBox.Show(
            "File berhasil dibuka.",
            "Informasi",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub

    Private Sub mnuSimpanFile_Click(sender As Object, e As EventArgs) Handles tcIdentitas.Click
        btnSimpan.PerformClick()
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles MenuKeluar.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show(
            "Apakah yakin ingin keluar?",
            "Konfirmasi Keluar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    ' LOAD DATA KE FORM
    Private Sub IsiDataKeForm(data As Dictionary(Of String, String))
        txtNama.Text = AmbilNilai(data, "Nama")
        mtbNoHP.Text = AmbilNilai(data, "NoHP")
        txtAlamat.Text = AmbilNilai(data, "Alamat")
    End Sub

End Class