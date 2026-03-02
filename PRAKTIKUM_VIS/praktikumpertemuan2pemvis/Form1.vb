Public Class Form1
    Public Nama As String
    Public NIM As String
    Public index As Integer

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Nama = txtNama.Text
        NIM = txtNim.Text
        Module1.tambahMahasiswa(Nama, NIM)
        MessageBox.Show("Data mahasiswa berhasil ditambahkan.")
        Tampilkandata()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        index = dgvHasil.SelectedRows(0).Index
        Nama = txtNama.Text
        NIM = txtNim.Text
        Tampilkandata()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        index = dgvHasil.SelectedRows(0).Index
        Module1.hapusMahasiswa(index)
        MessageBox.Show("Data mahasiswa berhasil dihapus.")
        Tampilkandata()
    End Sub

    Private Sub Tampilkandata()
        dgvHasil.Rows.Clear()
        For i As Integer = 0 To Module1.jumlahMahasiswa - 1
            dgvHasil.Rows.Add(Module1.daftarMahasiswa(i, 0), Module1.daftarMahasiswa(i, 1))
        Next
    End Sub
End Class
