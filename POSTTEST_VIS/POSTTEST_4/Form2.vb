Public Class FormKartu

    Public Sub TampilkanData(
        nama As String,
        idAnggota As String,
        komunitas As String,
        kontak As String,
        hobi As String,
        foto As Image
    )
        lblNamaHasil.Text = nama
        lblIDHasil.Text = idAnggota
        lblKomunitasID.Text = komunitas
        lblKontakHasil.Text = kontak
        lblHobiHasil.Text = hobi

        If foto IsNot Nothing Then
            PicKartu.Image = foto
        Else
            PicKartu.Image = Nothing
        End If
    End Sub

End Class