Imports MySqlConnector

Module DataModule

    Public Function GetAllTanaman() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT idTanaman, namaTanaman, jenisTanaman, lokasiLahan, " & "hargaBeli, hargaJual, (hargaJual - hargaBeli) AS keuntungan, " & "keterangan, fotoPath " & "FROM tbtanaman ORDER BY idTanaman ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchTanaman(keyword As String, kolom As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim kondisi As String = ""
            Dim kolomBersih As String = kolom.Replace("-", "").Trim().ToLower()

            If kolomBersih.Contains("nama") Then
                kondisi = "WHERE namaTanaman LIKE @keyword"
            ElseIf kolomBersih.Contains("jenis") Then
                kondisi = "WHERE jenisTanaman LIKE @keyword"
            ElseIf kolomBersih.Contains("lokasi") Then
                kondisi = "WHERE lokasiLahan LIKE @keyword"
            Else
                kondisi = "WHERE namaTanaman LIKE @keyword " & "OR jenisTanaman LIKE @keyword " & "OR lokasiLahan LIKE @keyword"
            End If

            Dim query As String = "SELECT idTanaman, namaTanaman, jenisTanaman, lokasiLahan, " & "hargaBeli, hargaJual, (hargaJual - hargaBeli) AS keuntungan " & "FROM tbtanaman " & kondisi & " ORDER BY idTanaman ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetTanamanByID(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tbtanaman WHERE idTanaman = @id"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SimpanTanaman(nama As String, jenis As String, lokasi As String, hargaBeli As Long, hargaJual As Long, keterangan As String, fotoPath As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbtanaman (namaTanaman, jenisTanaman, lokasiLahan, " & "hargaBeli, hargaJual, keterangan, fotoPath) " & "VALUES (@nama, @jenis, @lokasi, @hargaBeli, @hargaJual, @ket, @foto)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@jenis", jenis)
                    cmd.Parameters.AddWithValue("@lokasi", lokasi)
                    cmd.Parameters.AddWithValue("@hargaBeli", hargaBeli)
                    cmd.Parameters.AddWithValue("@hargaJual", hargaJual)
                    cmd.Parameters.AddWithValue("@ket", keterangan)
                    cmd.Parameters.AddWithValue("@foto", fotoPath)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahTanaman(id As Integer, nama As String, jenis As String, lokasi As String, hargaBeli As Long, hargaJual As Long, keterangan As String, fotoPath As String) As Boolean
        Try
            Dim query As String = "UPDATE tbtanaman SET namaTanaman=@nama, jenisTanaman=@jenis, " & "lokasiLahan=@lokasi, hargaBeli=@hargaBeli, hargaJual=@hargaJual, " & "keterangan=@ket, fotoPath=@foto WHERE idTanaman=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@jenis", jenis)
                    cmd.Parameters.AddWithValue("@lokasi", lokasi)
                    cmd.Parameters.AddWithValue("@hargaBeli", hargaBeli)
                    cmd.Parameters.AddWithValue("@hargaJual", hargaJual)
                    cmd.Parameters.AddWithValue("@ket", keterangan)
                    cmd.Parameters.AddWithValue("@foto", fotoPath)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusTanaman(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM tbtanaman WHERE idTanaman = @id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module