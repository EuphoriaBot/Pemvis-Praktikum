Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = DataModule.Nama
        lblUmur.Text = DataModule.Umur
        lblNoTelp.Text = DataModule.NoTelepon
        lblTanggalLahir.Text = DataModule.TanggalLahir
        lblJK.Text = DataModule.JK
        lblHobi.Text = DataModule.Hobi
        lblAlamat.Text = DataModule.Alamat

        If DataModule.Foto <> "" Then
            PictureBox1.Image = Image.FromFile(DataModule.Foto)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
    End ClassPublic Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = DataModule.Nama
        lblUmur.Text = DataModule.Umur
        lblNoTelp.Text = DataModule.NoTelepon
        lblTanggalLahir.Text = DataModule.TanggalLahir
        lblJK.Text = DataModule.JK
        lblHobi.Text = DataModule.Hobi
        lblAlamat.Text = DataModule.Alamat

        If DataModule.Foto <> "" Then
            PictureBox1.Image = Image.FromFile(DataModule.Foto)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
End Class