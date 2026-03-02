Module Module1
    Public daftarMahasiswa(49, 1) As String
    Public jumlahMahasiswa As Integer = 0

    Public Sub tambahMahasiswa(nama As String, nim As String)
        If jumlahMahasiswa < 50 Then
            daftarMahasiswa(jumlahMahasiswa, 0) = nama
            daftarMahasiswa(jumlahMahasiswa, 1) = nim
            jumlahMahasiswa += 1
        Else
            Console.WriteLine("Kapasitas mahasiswa sudah penuh.")
        End If
    End Sub

    Public Sub editMahasiswa(index As Integer, nama As String, nim As String)
        If index >= 0 And index < jumlahMahasiswa Then
            daftarMahasiswa(index, 0) = nama
            daftarMahasiswa(index, 1) = nim
        Else
            Console.WriteLine("Indeks mahasiswa tidak valid.")
        End If
    End Sub

    Public Sub hapusMahasiswa(index As Integer)
        If index >= 0 And index < jumlahMahasiswa Then
            For i As Integer = index To jumlahMahasiswa - 2
                daftarMahasiswa(i, 0) = daftarMahasiswa(i + 1, 0)
                daftarMahasiswa(i, 1) = daftarMahasiswa(i + 1, 1)
            Next
            jumlahMahasiswa -= 1
            daftarMahasiswa(jumlahMahasiswa, 0) = Nothing
            daftarMahasiswa(jumlahMahasiswa, 1) = Nothing
        Else
            Console.WriteLine("Indeks mahasiswa tidak valid.")
        End If
    End Sub
End Module
