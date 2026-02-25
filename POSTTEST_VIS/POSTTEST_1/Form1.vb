Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Dim hasil As Double
    Dim jumlah As Double
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim angka As Double

        If Double.TryParse(TextBox1.Text, angka) And angka > 0 Then
            hasil += angka
            jumlah += 1
            Dim ipk As Double = hasil / jumlah
            TextBox2.Text = ipk
            TextBox1.Text = ""

            If ipk >= 3.01 Then
                Label3.Text = "Sangat Memuaskan"
            ElseIf ipk >= 2.76 Then
                Label3.Text = "Memuaskan"
            ElseIf ipk >= 2.0 Then
                Label3.Text = "Cukup"
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hasil = 0
        jumlah = 0
        TextBox2.Text = ""
        Label3.Text = ""
    End Sub
End Class
