Public Class Form2

    Private idTanaman As Integer

    Public Sub New(id As Integer)
        InitializeComponent()
        idTanaman = id
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilDetail()
    End Sub

    Private Sub TampilDetail()
        Dim dt As DataTable = GetTanamanByID(idTanaman)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("Data tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Exit Sub
        End If

        Dim row As DataRow = dt.Rows(0)

        lblDNamaVal.Text = row("namaTanaman").ToString()
        lblDJenisVal.Text = row("namaJenis").ToString()
        lblDLokasiVal.Text = row("lokasiLahan").ToString()
        lblDHargaBeliVal.Text = "Rp " & Convert.ToInt64(row("hargaBeli")).ToString("N0")
        lblDHargaJualVal.Text = "Rp " & Convert.ToInt64(row("hargaJual")).ToString("N0")
        txtDetailKeterangan.Text = row("keterangan").ToString()

        Dim foto As String = row("fotoPath").ToString()
        If foto <> "" AndAlso IO.File.Exists(foto) Then
            picDetailFoto.Image = Image.FromFile(foto)
        Else
            picDetailFoto.Image = Nothing
        End If
    End Sub

    Private Sub btnTutupF2_Click(sender As Object, e As EventArgs) Handles btnTutupF2.Click
        Me.Close()
    End Sub
End Class