Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiMaskedTextBox(ep As ErrorProvider, mtb As MaskedTextBox, pesan As String) As Boolean
        If Not mtb.MaskCompleted Then
            ep.SetError(mtb, pesan)
            Return False
        Else
            ep.SetError(mtb, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cbo As ComboBox, pesan As String) As Boolean
        If cbo.SelectedIndex = -1 OrElse cbo.Text.Trim() = "" Then
            ep.SetError(cbo, pesan)
            Return False
        Else
            ep.SetError(cbo, "")
            Return True
        End If
    End Function

    Public Function ValidasiRadioButton(ep As ErrorProvider, grp As GroupBox, pesan As String) As Boolean
        For Each ctrl As Control In grp.Controls
            If TypeOf ctrl Is RadioButton Then
                If CType(ctrl, RadioButton).Checked Then
                    ep.SetError(grp, "")
                    Return True
                End If
            End If
        Next

        ep.SetError(grp, pesan)
        Return False
    End Function

    Public Function ValidasiCheckBox(ep As ErrorProvider, grp As GroupBox, pesan As String) As Boolean
        For Each ctrl As Control In grp.Controls
            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).Checked Then
                    ep.SetError(grp, "")
                    Return True
                End If
            End If
        Next

        ep.SetError(grp, pesan)
        Return False
    End Function

    Public Function ValidasiPictureBox(ep As ErrorProvider, pic As PictureBox, pesan As String) As Boolean
        If pic.Image Is Nothing Then
            ep.SetError(pic, pesan)
            Return False
        Else
            ep.SetError(pic, "")
            Return True
        End If
    End Function

    Public Function ValidasiSemuaInput(
        ep As ErrorProvider,
        txtNama As TextBox,
        txtID As TextBox,
        mtbTelepon As MaskedTextBox,
        txtEmail As TextBox,
        txtAlamat As TextBox,
        cboKomunitas As ComboBox,
        grpJenisKelamin As GroupBox,
        grpPeran As GroupBox,
        grpHobi As GroupBox,
        picFoto As PictureBox
    ) As Boolean

        Dim namaValid As Boolean = ValidasiTextBox(ep, txtNama, "Inputan tidak boleh kosong")
        Dim idValid As Boolean = ValidasiTextBox(ep, txtID, "Inputan tidak boleh kosong")
        Dim teleponValid As Boolean = ValidasiMaskedTextBox(ep, mtbTelepon, "Inputan tidak boleh kosong")
        Dim emailValid As Boolean = ValidasiTextBox(ep, txtEmail, "Inputan tidak boleh kosong")
        Dim alamatValid As Boolean = ValidasiTextBox(ep, txtAlamat, "Inputan tidak boleh kosong")
        Dim komunitasValid As Boolean = ValidasiComboBox(ep, cboKomunitas, "Inputan tidak boleh kosong")
        Dim jkValid As Boolean = ValidasiRadioButton(ep, grpJenisKelamin, "Inputan tidak boleh kosong")
        Dim peranValid As Boolean = ValidasiRadioButton(ep, grpPeran, "Inputan tidak boleh kosong")
        Dim hobiValid As Boolean = ValidasiCheckBox(ep, grpHobi, "Inputan tidak boleh kosong")
        Dim fotoValid As Boolean = ValidasiPictureBox(ep, picFoto, "Inputan tidak boleh kosong")

        Return namaValid And idValid And teleponValid And emailValid And alamatValid And
               komunitasValid And jkValid And peranValid And hobiValid And fotoValid
    End Function

End Module