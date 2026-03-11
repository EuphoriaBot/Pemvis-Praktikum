Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl1.Text = DataModule.Nama
        lbl2.Text = DataModule.Umur
        lbl3.Text = DataModule.TanggalLahir
        lbl4.Text = DataModule.JK
        lbl5.Text = DataModule.NoTelepon
        lbl6.Text = DataModule.Hobi
        lbl7.Text = DataModule.Alamat

        If DataModule.Foto <> "" Then
            PictureBox1.Image = Image.FromFile(DataModule.Foto)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
End Class