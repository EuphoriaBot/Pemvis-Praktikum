Imports System.IO
Imports System.Text

Module DataModule

    Public Function HitungUmur(tanggalLahir As Date) As Integer
        Dim umur As Integer = Today.Year - tanggalLahir.Year

        If tanggalLahir > Today.AddYears(-umur) Then
            umur -= 1
        End If

        Return umur
    End Function

    Public Function BuatIsiFile(
        nama As String,
        idAnggota As String,
        tanggalLahir As String,
        umur As String,
        jenisKelamin As String,
        komunitas As String,
        telepon As String,
        email As String,
        alamat As String,
        peran As String,
        hobi As String,
        fotoPath As String
    ) As String

        Dim sb As New StringBuilder()

        sb.AppendLine("Nama=" & nama.Trim())
        sb.AppendLine("IDAnggota=" & idAnggota.Trim())
        sb.AppendLine("TanggalLahir=" & tanggalLahir.Trim())
        sb.AppendLine("Umur=" & umur.Trim())
        sb.AppendLine("JenisKelamin=" & jenisKelamin.Trim())
        sb.AppendLine("Komunitas=" & komunitas.Trim())
        sb.AppendLine("Telepon=" & telepon.Trim())
        sb.AppendLine("Email=" & email.Trim())
        sb.AppendLine("Alamat=" & alamat.Trim())
        sb.AppendLine("Peran=" & peran.Trim())
        sb.AppendLine("Hobi=" & hobi.Trim())
        sb.Append("FotoPath=" & fotoPath.Trim())

        Return sb.ToString()
    End Function

    Public Function SimpanDataKeFile(
        sfd As SaveFileDialog,
        isi As String,
        namaFileDefault As String
    ) As Boolean

        sfd.Filter = "Text File|*.txt|CSV File|*.csv"
        sfd.Title = "Simpan Data"
        sfd.FileName = namaFileDefault

        If sfd.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(sfd.FileName, isi)
            Return True
        End If

        Return False
    End Function

    Public Function BukaDataDariFile(ofd As OpenFileDialog) As Dictionary(Of String, String)
        ofd.Filter = "Text File|*.txt|CSV File|*.csv"
        ofd.Title = "Buka Data"

        If ofd.ShowDialog() <> DialogResult.OK Then
            Return Nothing
        End If

        Dim hasil As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
        Dim barisFile() As String = File.ReadAllLines(ofd.FileName)

        For Each baris As String In barisFile
            If String.IsNullOrWhiteSpace(baris) Then Continue For

            Dim bagian() As String = baris.Split(New Char() {"="c}, 2)

            If bagian.Length = 2 Then
                hasil(bagian(0).Trim()) = bagian(1).Trim()
            End If
        Next

        Return hasil
    End Function

    Public Function AmbilNilai(data As Dictionary(Of String, String), key As String) As String
        If data IsNot Nothing AndAlso data.ContainsKey(key) Then
            Return data(key)
        End If

        Return ""
    End Function

End Module
