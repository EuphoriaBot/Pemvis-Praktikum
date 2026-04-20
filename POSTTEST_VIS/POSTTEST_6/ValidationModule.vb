Module ValidationModule

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cb As ComboBox, pesan As String) As Boolean
        If cb.SelectedIndex = -1 OrElse cb.Text.Trim() = "" Then
            ep.SetError(cb, pesan)
            Return False
        Else
            ep.SetError(cb, "")
            Return True
        End If
    End Function

    Public Function ValidasiDataTanaman(ep As ErrorProvider, txtNama As TextBox, cboJenis As ComboBox, txtLokasi As TextBox, txtHargaBeli As TextBox, txtHargaJual As TextBox) As Boolean
        Dim namaValid As Boolean = ValidasiTextBox(ep, txtNama, "Nama Tanaman wajib diisi")
        Dim jenisValid As Boolean = ValidasiComboBox(ep, cboJenis, "Silakan pilih Jenis Tanaman")
        Dim lokasiValid As Boolean = ValidasiTextBox(ep, txtLokasi, "Lokasi/Lahan wajib diisi")
        Dim beliValid As Boolean = ValidasiTextBox(ep, txtHargaBeli, "Harga Beli wajib diisi")
        Dim jualValid As Boolean = ValidasiTextBox(ep, txtHargaJual, "Harga Jual wajib diisi")
        Return namaValid And jenisValid And lokasiValid And beliValid And jualValid
    End Function

End Module