Imports System.Security.Cryptography.X509Certificates

Module Module1
    Public daftarBuku(49, 1) As String
    Public jumlahBuku As Integer = 0

    Public Sub tambahBuku(judul As String, genre As String)
        If jumlahBuku < 50 Then
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre
            jumlahBuku += 1
        Else
            MessageBox.Show("Buku sudah penuh")
        End If
    End Sub

    Public Sub hapusBuku(ByVal index As Integer)
        If index >= 0 And index < jumlahBuku Then
            For i As Integer = index To jumlahBuku - 2
                daftarBuku(i, 0) = daftarBuku(i + 1, 0)
                daftarBuku(i, 0) = daftarBuku(i + 1, 1)
            Next
            jumlahBuku -= 1
            daftarBuku(jumlahBuku, 0) = Nothing
            daftarBuku(jumlahBuku, 1) = Nothing
        Else
            MessageBox.Show("Indeks buku tidak valid")
        End If
    End Sub

    Public Function traversalBuku(buku As String) As Integer
        For i As Integer = 0 To jumlahBuku
            If daftarBuku(i, 0) = buku Then
                Return i
            End If
        Next
        Return Nothing
    End Function
End Module
