Public Class Form1
    Public buku As String
    Public genre As String
    Public index As Integer

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        buku = txtNama.Text
        genre = txtGenre.Text
        Module1.tambahBuku(buku, genre)
        MessageBox.Show("Data buku telah ditambahkan")
        Tampilkandata()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Module1.traversalBuku(txtHapus.Text)
        Module1.hapusBuku(index)
        MessageBox.Show("Data buku telah dihapus")
        Tampilkandata()
    End Sub

    Private Sub Tampilkandata()
        RichTextBox1.Clear()
        For i As Integer = 0 To Module1.jumlahBuku - 1
            RichTextBox1.Text &= daftarBuku(i, 0) & " "
            RichTextBox1.Text &= "(" & daftarBuku(i, 1) & ")" & vbCrLf
        Next
    End Sub
End Class