Public Class Form1

    Private idTerpilih As Integer = 0
    Private fotoPathTerpilih As String = ""

    Private Sub Kosong()
        idTerpilih = 0
        fotoPathTerpilih = ""
        txtNamaTanaman.Clear()
        cboJenisTanaman.SelectedIndex = -1
        txtLokasiLahan.Clear()
        txtHargaBeli.Clear()
        txtHargaJual.Clear()
        txtKeterangan.Clear()
        txtKeuntungan.Clear()
        picFotoTanaman.Image = Nothing
        txtPathFoto.Clear()
        epValidasi.Clear()
        lblStatusInfo.Text = "Status : Siap"
        txtNamaTanaman.Focus()
    End Sub

    Private Sub TampilData()
        dgvTanaman.DataSource = GetAllTanaman()
        lblJumlahData.Text = "Total Data : " & dgvTanaman.RowCount
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtJenis As DataTable = DataModule.GetAllJenis()
        cboJenisTanaman.DataSource = dtJenis
        cboJenisTanaman.DisplayMember = "namaJenis"
        cboJenisTanaman.ValueMember = "idJenis"
        dgvTanaman.AutoGenerateColumns = False
        dgvTanaman.BackgroundColor = Color.FromArgb(14, 22, 10)
        TampilData()
        dgvTanaman.Columns("colID").Visible = False
        Kosong()
    End Sub

    Private Sub HitungKeuntungan()
        Dim beli As Long = 0
        Dim jual As Long = 0
        Long.TryParse(txtHargaBeli.Text.Trim(), beli)
        Long.TryParse(txtHargaJual.Text.Trim(), jual)
        txtKeuntungan.Text = (jual - beli).ToString()
    End Sub

    Private Sub mnuTambah_Click(sender As Object, e As EventArgs) Handles mnuTambah.Click
        Kosong()
        lblStatusInfo.Text = "Status : Mode Tambah Data"
    End Sub

    Private Sub mnuSimpan_Click(sender As Object, e As EventArgs) Handles mnuSimpan.Click
        epValidasi.Clear()
        If Not ValidasiDataTanaman(epValidasi, txtNamaTanaman, cboJenisTanaman, txtLokasiLahan, txtHargaBeli, txtHargaJual) Then Exit Sub

        Dim nama As String = txtNamaTanaman.Text.Trim()
        Dim jenis As String = cboJenisTanaman.SelectedValue.ToString()
        Dim lokasi As String = txtLokasiLahan.Text.Trim()
        Dim hargaBeli As Long = Convert.ToInt64(txtHargaBeli.Text.Trim())
        Dim hargaJual As Long = Convert.ToInt64(txtHargaJual.Text.Trim())
        Dim keterangan As String = txtKeterangan.Text.Trim()
        Dim foto As String = fotoPathTerpilih

        If idTerpilih = 0 Then
            If SimpanTanaman(nama, jenis, lokasi, hargaBeli, hargaJual, keterangan, foto) Then
                MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        Else
            If UbahTanaman(idTerpilih, nama, jenis, lokasi, hargaBeli, hargaJual, keterangan, foto) Then
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            Else
                MessageBox.Show("Data tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If idTerpilih = 0 Then
            MessageBox.Show("Pilih data yang akan dihapus terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah data ini ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If HapusTanaman(idTerpilih) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub mnuBersihkan_Click(sender As Object, e As EventArgs) Handles mnuBersihkan.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub mnuDetail_Click(sender As Object, e As EventArgs) Handles mnuDetail.Click
        If idTerpilih = 0 Then
            MessageBox.Show("Pilih data terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim f2 As New form2(idTerpilih)
        f2.ShowDialog()
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub dgvTanaman_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTanaman.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvTanaman.Rows(e.RowIndex)

            If row.Cells("colID").Value Is Nothing OrElse row.Cells("colID").Value.ToString() = "" Then
                Exit Sub
            End If

            idTerpilih = Convert.ToInt32(row.Cells("colID").Value)
            txtNamaTanaman.Text = row.Cells("colNama").Value.ToString()
            cboJenisTanaman.Text = row.Cells("colJenis").Value.ToString()
            txtLokasiLahan.Text = row.Cells("colLokasi").Value.ToString()
            txtHargaBeli.Text = row.Cells("colHargaBeli").Value.ToString()
            txtHargaJual.Text = row.Cells("colHargaJual").Value.ToString()

            Dim dt As DataTable = GetTanamanByID(idTerpilih)
            If dt.Rows.Count > 0 Then
                txtKeterangan.Text = dt.Rows(0)("keterangan").ToString()
                fotoPathTerpilih = dt.Rows(0)("fotoPath").ToString()

                If fotoPathTerpilih <> "" AndAlso IO.File.Exists(fotoPathTerpilih) Then
                    picFotoTanaman.Image = Image.FromFile(fotoPathTerpilih)
                Else
                    picFotoTanaman.Image = Nothing
                End If
            End If

            HitungKeuntungan()
            lblStatusInfo.Text = "Status : Data dipilih - " & txtNamaTanaman.Text
        End If
    End Sub

    Private Sub btnBrowseFoto_Click(sender As Object, e As EventArgs) Handles btnBrowseFoto.Click
        If ofdFotoTanaman.ShowDialog() = DialogResult.OK Then
            fotoPathTerpilih = ofdFotoTanaman.FileName
            txtPathFoto.Text = fotoPathTerpilih
            picFotoTanaman.Image = Image.FromFile(fotoPathTerpilih)
        End If
    End Sub

    Private Sub txtHargaBeli_TextChanged(sender As Object, e As EventArgs) Handles txtHargaBeli.TextChanged
        HitungKeuntungan()
    End Sub

    Private Sub txtHargaJual_TextChanged(sender As Object, e As EventArgs) Handles txtHargaJual.TextChanged
        HitungKeuntungan()
    End Sub

    Private Sub txtHargaBeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaBeli.KeyPress
        HanyaAngka(e)
        If IsEnterKey(e) Then
            e.Handled = True
            txtHargaJual.Focus()
        End If
    End Sub

    Private Sub txtHargaJual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaJual.KeyPress
        HanyaAngka(e)
        If IsEnterKey(e) Then
            e.Handled = True
            txtKeterangan.Focus()
        End If
    End Sub

    Private Sub txtNamaTanaman_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaTanaman.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True
            cboJenisTanaman.Focus()
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvTanaman.DataSource = SearchTanaman(txtCari.Text.Trim())
            lblJumlahData.Text = "Total Data : " & dgvTanaman.RowCount
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text.Trim() = "" Then
            MessageBox.Show("Masukkan kata kunci pencarian", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCari.Focus()
            Exit Sub
        End If
        dgvTanaman.DataSource = SearchTanaman(txtCari.Text.Trim())
        lblJumlahData.Text = "Total Data : " & dgvTanaman.RowCount
        If dgvTanaman.RowCount = 0 Then
            MessageBox.Show("Data tidak ditemukan", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
        End If
    End Sub

    Private Sub btnResetCari_Click(sender As Object, e As EventArgs) Handles btnResetCari.Click
        txtCari.Clear()
        TampilData()
    End Sub
End Class