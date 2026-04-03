Imports System.IO

Public Class FormUtamaAkatsukiCoy

    Private fotoPath As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Akatsuki Community Card Maker"

        AturMaskedTextBox()
        AturFormAwal()

        ErrorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink
        ErrorProvider1.BlinkRate = 0
    End Sub

    Private Sub AturMaskedTextBox()
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.PromptChar = "_"c
        mtbTelepon.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
    End Sub

    Private Sub AturFormAwal()
        txtAlamat.Multiline = True
        txtNama.CharacterCasing = CharacterCasing.Upper
        TabControl1.SelectedIndex = 0

        If cmbKomunitas.Items.Count = 0 Then
            cmbKomunitas.Items.Add("Intelijen")
            cmbKomunitas.Items.Add("Strategi")
            cmbKomunitas.Items.Add("Multimedia")
            cmbKomunitas.Items.Add("Kreatif")
            cmbKomunitas.Items.Add("Event")
            cmbKomunitas.Items.Add("Dokumentasi")
            cmbKomunitas.Items.Add("Keamanan")
            cmbKomunitas.Items.Add("Publikasi")
        End If
    End Sub

    Private Function AmbilJenisKelamin() As String
        If rbLaki.Checked Then
            Return "Laki-Laki"
        ElseIf rbPerempuan.Checked Then
            Return "Perempuan"
        End If

        Return ""
    End Function

    Private Function AmbilPeran() As String
        If rbP.Checked Then Return "Pemimpin"
        If rbA.Checked Then Return "Administrasi"
        If rbO.Checked Then Return "Observasi"
        If rbDL.Checked Then Return "Divisi Lapangan"
        If rbDkreatif.Checked Then Return "Divisi Kreatif"
        If rbDkerajinan.Checked Then Return "Divisi Kerajinan"
        If rbDkeuangan.Checked Then Return "Divisi Keuangan"
        If rbDI.Checked Then Return "Divisi Informasi"
        Return ""
    End Function

    Private Function AmbilHobi() As String
        Dim hasil As String = ""

        If cbPS.Checked Then hasil &= "Strategi & Analisis, "
        If cbPC.Checked Then hasil &= "Origami & Paper Craft, "
        If cbA.Checked Then hasil &= "Seni Visual & Desain, "
        If cbR.Checked Then hasil &= "Crafting / Miniatur, "
        If cbD.Checked Then hasil &= "Renang & Ketahanan Fisik, "
        If cbMI.Checked Then hasil &= "Manajemen Uang & Koleksi, "
        If cbMA.Checked Then hasil &= "Observasi Alam & Eksplorasi, "
        If cbE.Checked Then hasil &= "Kepemimpinan & Public Speaking, "

        If hasil.EndsWith(", ") Then
            hasil = hasil.Substring(0, hasil.Length - 2)
        End If

        Return hasil
    End Function

    Private Sub SetPeranDariString(peran As String)
        rbP.Checked = False
        rbA.Checked = False
        rbO.Checked = False
        rbDL.Checked = False
        rbDkreatif.Checked = False
        rbDkerajinan.Checked = False
        rbDkeuangan.Checked = False
        rbDI.Checked = False

        Select Case peran.Trim()
            Case "Pemimpin"
                rbP.Checked = True
            Case "Administrasi"
                rbA.Checked = True
            Case "Observasi"
                rbO.Checked = True
            Case "Divisi Lapangan"
                rbDL.Checked = True
            Case "Divisi Kreatif"
                rbDkreatif.Checked = True
            Case "Divisi Kerajinan"
                rbDkerajinan.Checked = True
            Case "Divisi Keuangan"
                rbDkeuangan.Checked = True
            Case "Divisi Informasi"
                rbDI.Checked = True
        End Select
    End Sub

    Private Sub SetHobiDariString(hobi As String)
        cbPS.Checked = False
        cbPC.Checked = False
        cbA.Checked = False
        cbR.Checked = False
        cbD.Checked = False
        cbMI.Checked = False
        cbMA.Checked = False
        cbE.Checked = False

        Dim daftar() As String = hobi.Split(","c)

        For Each item As String In daftar
            Select Case item.Trim()
                Case "Public Speaking"
                    cbPS.Checked = True
                Case "Paper Craft"
                    cbPC.Checked = True
                Case "Analisis"
                    cbA.Checked = True
                Case "Renang"
                    cbR.Checked = True
                Case "Desain"
                    cbD.Checked = True
                Case "Miniatur"
                    cbMI.Checked = True
                Case "Manajemen"
                    cbMA.Checked = True
                Case "Eksplorasi"
                    cbE.Checked = True
            End Select
        Next
    End Sub

    Private Function ValidasiForm() As Boolean
        Dim valid As Boolean = ValidasiSemuaInput(
            ErrorProvider1,
            txtNama,
            txtId,
            mtbTelepon,
            txtEmail,
            txtAlamat,
            cmbKomunitas,
            gbJenisKelamin,
            grpPeran,
            grpHobi,
            picProfile
        )

        If Not valid Then
            MessageBox.Show(
                "Inputan tidak boleh kosong.",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
        End If

        Return valid
    End Function

    Private Sub TampilkanKartu()
        Dim frm As New FormKartu()
        Dim kontak As String = mtbTelepon.Text & " | " & txtEmail.Text

        frm.TampilkanData(
            txtNama.Text,
            txtId.Text,
            cmbKomunitas.Text,
            kontak,
            AmbilHobi(),
            picProfile.Image
        )

        frm.ShowDialog()
    End Sub

    Private Sub KosongkanForm()
        txtNama.Clear()
        txtId.Clear()
        dptTanggalLahir.Value = Today
        rbLaki.Checked = False
        rbPerempuan.Checked = False
        cmbKomunitas.SelectedIndex = -1
        mtbTelepon.Clear()
        txtEmail.Clear()
        txtAlamat.Clear()

        rbP.Checked = False
        rbA.Checked = False
        rbO.Checked = False
        rbDL.Checked = False
        rbDkreatif.Checked = False
        rbDkerajinan.Checked = False
        rbDkeuangan.Checked = False
        rbDI.Checked = False

        cbPS.Checked = False
        cbPC.Checked = False
        cbA.Checked = False
        cbR.Checked = False
        cbD.Checked = False
        cbMI.Checked = False
        cbMA.Checked = False
        cbE.Checked = False

        picProfile.Image = Nothing
        fotoPath = ""
        ErrorProvider1.Clear()
        TabControl1.SelectedIndex = 0
        txtNama.Focus()
    End Sub

    Private Sub IsiDataKeForm(data As Dictionary(Of String, String))
        txtNama.Text = AmbilNilai(data, "Nama")
        txtId.Text = AmbilNilai(data, "IDAnggota")

        Dim tgl As Date
        If Date.TryParse(AmbilNilai(data, "TanggalLahir"), tgl) Then
            dptTanggalLahir.Value = tgl
        End If

        Dim jk As String = AmbilNilai(data, "JenisKelamin")
        rbLaki.Checked = (jk = "Laki-Laki")
        rbPerempuan.Checked = (jk = "Perempuan")

        cmbKomunitas.Text = AmbilNilai(data, "Komunitas")
        mtbTelepon.Text = AmbilNilai(data, "Telepon")
        txtEmail.Text = AmbilNilai(data, "Email")
        txtAlamat.Text = AmbilNilai(data, "Alamat")

        SetPeranDariString(AmbilNilai(data, "Peran"))
        SetHobiDariString(AmbilNilai(data, "Hobi"))

        fotoPath = AmbilNilai(data, "FotoPath")

        If File.Exists(fotoPath) Then
            picProfile.Image = Image.FromFile(fotoPath)
        Else
            picProfile.Image = Nothing
        End If
    End Sub

    ' VALIDASI INPUT KARAKTER

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub mtbTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbTelepon.KeyPress
        HanyaAngka(e)
    End Sub

    ' VALIDASI LANGSUNG

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged
        ValidasiTextBox(ErrorProvider1, txtNama, "Inputan tidak boleh kosong")
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        ValidasiTextBox(ErrorProvider1, txtId, "Inputan tidak boleh kosong")
    End Sub

    Private Sub mtbTelepon_TextChanged(sender As Object, e As EventArgs) Handles mtbTelepon.TextChanged
        ValidasiMaskedTextBox(ErrorProvider1, mtbTelepon, "Inputan tidak boleh kosong")
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        ValidasiTextBox(ErrorProvider1, txtEmail, "Inputan tidak boleh kosong")
    End Sub

    Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtAlamat.TextChanged
        ValidasiTextBox(ErrorProvider1, txtAlamat, "Inputan tidak boleh kosong")
    End Sub

    Private Sub cmbKomunitas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKomunitas.SelectedIndexChanged
        ValidasiComboBox(ErrorProvider1, cmbKomunitas, "Inputan tidak boleh kosong")
    End Sub

    ' BROWSE FOTO

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog1.Title = "Pilih Foto Profil"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picProfile.Image = Image.FromFile(OpenFileDialog1.FileName)
            fotoPath = OpenFileDialog1.FileName
            ErrorProvider1.SetError(picProfile, "")
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

    ' MENU INPUT DATA

    Private Sub MenuInput_Click(sender As Object, e As EventArgs) Handles mnInputData.Click
        TabControl1.SelectedIndex = 0
        txtNama.Focus()
    End Sub

    ' MENU LIHAT KARTU

    Private Sub MenuLihatKartu_Click(sender As Object, e As EventArgs) Handles mnLihatKartu.Click
        If Not ValidasiForm() Then Exit Sub

        TampilkanKartu()
    End Sub

    ' MENU SIMPAN DATA

    Private Sub MenuSimpanData_Click(sender As Object, e As EventArgs) Handles mnSimpanData.Click
        If Not ValidasiForm() Then Exit Sub

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
                txtId.Text,
                dptTanggalLahir.Text,
                HitungUmur(dptTanggalLahir.Value).ToString(),
                AmbilJenisKelamin(),
                cmbKomunitas.Text,
                mtbTelepon.Text,
                txtEmail.Text,
                txtAlamat.Text,
                AmbilPeran(),
                AmbilHobi(),
                fotoPath
            )

            If SimpanDataKeFile(SaveFileDialog1, isi, "data_akatsuki.txt") Then
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
        Else
            MessageBox.Show(
                "Proses dibatalkan.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            )
        End If
    End Sub

    ' MENU BUKA DATA

    Private Sub MenuBukaData_Click(sender As Object, e As EventArgs) Handles mnBukaData.Click
        Dim data As Dictionary(Of String, String) = BukaDataDariFile(OpenFileDialog1)

        If data Is Nothing Then Exit Sub

        KosongkanForm()
        IsiDataKeForm(data)

        MessageBox.Show(
            "Data berhasil dibuka.",
            "Informasi",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub

    ' MENU KELUAR

    Private Sub MenuKeluar_Click(sender As Object, e As EventArgs) Handles mnKeluar.Click
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

    ' TOMBOL SIMPAN & CETAK KARTU

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If Not ValidasiForm() Then Exit Sub

        Dim hasilSimpan As DialogResult
        hasilSimpan = MessageBox.Show(
            "Apakah data ingin disimpan?",
            "Konfirmasi Simpan",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If hasilSimpan = DialogResult.Yes Then
            Dim isi As String = BuatIsiFile(
                txtNama.Text,
                txtId.Text,
                dptTanggalLahir.Text,
                HitungUmur(dptTanggalLahir.Value).ToString(),
                AmbilJenisKelamin(),
                cmbKomunitas.Text,
                mtbTelepon.Text,
                txtEmail.Text,
                txtAlamat.Text,
                AmbilPeran(),
                AmbilHobi(),
                fotoPath
            )

            If SimpanDataKeFile(SaveFileDialog1, isi, "data_akatsuki.txt") Then
                Dim hasilCetak As DialogResult
                hasilCetak = MessageBox.Show(
                    "Apakah kartu ingin ditampilkan / dicetak?",
                    "Konfirmasi Cetak",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                )

                If hasilCetak = DialogResult.Yes Then
                    TampilkanKartu()
                End If
            End If
        End If
    End Sub
End Class