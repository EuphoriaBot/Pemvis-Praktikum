Imports System.IO

Public Class Form1
    Dim grupHobi() As CheckBox
    Dim grupJK() As RadioButton

    Private Function CekData() As Boolean
        grupHobi = {
            cbFotografi, cbSosialisasi, cbPublikasi, cbVideografi, cbCamping,
            cbKoleksi, cbHiking, cbMelukis, cbDonasi, cbTracking
        }

        grupJK = {rdbLaki, rdbPerempuan}

        If Not ValidasiPictureBox(pictureBox, "Gambar tidak boleh kosong") Then Return False
        If Not ValidasiTextBox(txtNama, "Nama tidak boleh kosong") Then Return False
        If Not ValidasiTextBox(txtUmur, "Umur tidak boleh kosong") Then Return False
        If Not ValidasiTextBox(txtTelpon, "Nomor telpon tidak boleh kosong") Then Return False
        If Not ValidasiTextBox(txtAlamat, "Alamat tidak boleh kosong") Then Return False
        If Not ValidasiDateTimePicker(dtpTLahir, "Tanggal lahir tidak boleh kosong") Then Return False
        If Not ValidasiRadioButton(grupJK, "Jenis kelamin tidak boleh kosong") Then Return False
        If Not ValidasiCheckBox(grupHobi, "Hobi tidak boleh kosong") Then Return False

        Return True
    End Function

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If ValidasiTextBox(txtNama, "Nama tidak boleh kosong") Then
            Dim namaFile As String = txtNama.Text.Trim()
            Dim openFileDialog As New OpenFileDialog()

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Pilih Gambar"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
                Dim fileName As String = namaFile & Path.GetExtension(openFileDialog.FileName)
                Dim destinationPath As String = Path.Combine(folderPath, fileName)

                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If

                File.Copy(openFileDialog.FileName, destinationPath, True)

                DataModule.Foto = destinationPath
                pictureBox.Image = Image.FromFile(destinationPath)
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage

                MessageBox.Show("Gambar berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If CekData() Then
            grupHobi = {
                cbFotografi, cbSosialisasi, cbPublikasi, cbVideografi, cbCamping,
                cbKoleksi, cbHiking, cbMelukis, cbDonasi, cbTracking
            }

            grupJK = {rdbLaki, rdbPerempuan}

            Dim Hobi_Selected As String = GetSelectedCheckBox(grupHobi)
            Dim jk_Selected As String = GetSelectedRadioButton(grupJK)

            DataModule.Nama = txtNama.Text
            DataModule.Umur = txtUmur.Text
            DataModule.NoTelepon = txtTelpon.Text
            DataModule.Alamat = txtAlamat.Text
            DataModule.TanggalLahir = dtpTLahir.Value.ToShortDateString
            DataModule.JK = jk_Selected
            DataModule.Hobi = Hobi_Selected

            Form2.Show()
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(sender, e)
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub txtTelpon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelpon.KeyPress
        HanyaAngka(sender, e)
    End Sub
End Class