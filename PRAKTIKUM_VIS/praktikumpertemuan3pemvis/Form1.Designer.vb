<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DTPLahir = New DateTimePicker()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        GroupBox1 = New GroupBox()
        picProfil = New PictureBox()
        Nama = New Label()
        rbcowo = New RadioButton()
        nim = New Label()
        Label3 = New Label()
        TxtNim = New TextBox()
        txtNama = New TextBox()
        gbhobi = New GroupBox()
        cbgame = New CheckBox()
        cbbaca = New CheckBox()
        cbmancing = New CheckBox()
        gbjk = New GroupBox()
        rbcewe = New RadioButton()
        GroupBox3 = New GroupBox()
        RadioButton5 = New RadioButton()
        btnCetak = New Button()
        btnGambar = New Button()
        GroupBox1.SuspendLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        gbhobi.SuspendLayout()
        gbjk.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' DTPLahir
        ' 
        DTPLahir.Location = New Point(488, 40)
        DTPLahir.Name = "DTPLahir"
        DTPLahir.Size = New Size(300, 31)
        DTPLahir.TabIndex = 1
        DTPLahir.Value = New Date(2026, 7, 22, 0, 0, 0, 0)
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(6, 30)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(98, 29)
        RadioButton1.TabIndex = 6
        RadioButton1.TabStop = True
        RadioButton1.Text = "Laki laki"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(6, 66)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(126, 29)
        RadioButton2.TabIndex = 7
        RadioButton2.TabStop = True
        RadioButton2.Text = "Perempuan"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Location = New Point(298, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(300, 150)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' picProfil
        ' 
        picProfil.Location = New Point(12, 90)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(216, 237)
        picProfil.SizeMode = PictureBoxSizeMode.StretchImage
        picProfil.TabIndex = 9
        picProfil.TabStop = False
        ' 
        ' Nama
        ' 
        Nama.AutoSize = True
        Nama.Location = New Point(68, 9)
        Nama.Name = "Nama"
        Nama.Size = New Size(59, 25)
        Nama.TabIndex = 8
        Nama.Text = "Nama"
        ' 
        ' rbcowo
        ' 
        rbcowo.AutoSize = True
        rbcowo.Location = New Point(54, 30)
        rbcowo.Name = "rbcowo"
        rbcowo.Size = New Size(80, 29)
        rbcowo.TabIndex = 16
        rbcowo.TabStop = True
        rbcowo.Text = "cowo"
        rbcowo.UseVisualStyleBackColor = True
        ' 
        ' nim
        ' 
        nim.AutoSize = True
        nim.Location = New Point(68, 40)
        nim.Name = "nim"
        nim.Size = New Size(46, 25)
        nim.TabIndex = 17
        nim.Text = "NIM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(367, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 25)
        Label3.TabIndex = 18
        Label3.Text = "Tanggal Lahir"
        ' 
        ' TxtNim
        ' 
        TxtNim.Location = New Point(183, 53)
        TxtNim.Name = "TxtNim"
        TxtNim.Size = New Size(150, 31)
        TxtNim.TabIndex = 19
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(183, 9)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 20
        ' 
        ' gbhobi
        ' 
        gbhobi.Controls.Add(cbgame)
        gbhobi.Controls.Add(cbbaca)
        gbhobi.Controls.Add(cbmancing)
        gbhobi.Controls.Add(GroupBox1)
        gbhobi.Location = New Point(488, 177)
        gbhobi.Name = "gbhobi"
        gbhobi.Size = New Size(300, 150)
        gbhobi.TabIndex = 21
        gbhobi.TabStop = False
        gbhobi.Text = "Hobi"
        ' 
        ' cbgame
        ' 
        cbgame.AutoSize = True
        cbgame.Location = New Point(133, 105)
        cbgame.Name = "cbgame"
        cbgame.Size = New Size(84, 29)
        cbgame.TabIndex = 11
        cbgame.Text = "Game"
        cbgame.UseVisualStyleBackColor = True
        ' 
        ' cbbaca
        ' 
        cbbaca.AutoSize = True
        cbbaca.Location = New Point(154, 41)
        cbbaca.Name = "cbbaca"
        cbbaca.Size = New Size(74, 29)
        cbbaca.TabIndex = 10
        cbbaca.Text = "Baca"
        cbbaca.UseVisualStyleBackColor = True
        ' 
        ' cbmancing
        ' 
        cbmancing.AutoSize = True
        cbmancing.Location = New Point(24, 41)
        cbmancing.Name = "cbmancing"
        cbmancing.Size = New Size(106, 29)
        cbmancing.TabIndex = 9
        cbmancing.Text = "Mancing"
        cbmancing.UseVisualStyleBackColor = True
        ' 
        ' gbjk
        ' 
        gbjk.Controls.Add(rbcewe)
        gbjk.Controls.Add(GroupBox3)
        gbjk.Controls.Add(rbcowo)
        gbjk.Location = New Point(252, 177)
        gbjk.Name = "gbjk"
        gbjk.Size = New Size(195, 150)
        gbjk.TabIndex = 22
        gbjk.TabStop = False
        gbjk.Text = "Jenis Kelamin"
        ' 
        ' rbcewe
        ' 
        rbcewe.AutoSize = True
        rbcewe.Location = New Point(54, 83)
        rbcewe.Name = "rbcewe"
        rbcewe.Size = New Size(76, 29)
        rbcewe.TabIndex = 23
        rbcewe.TabStop = True
        rbcewe.Text = "cewe"
        rbcewe.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(RadioButton5)
        GroupBox3.Location = New Point(298, 0)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(300, 150)
        GroupBox3.TabIndex = 8
        GroupBox3.TabStop = False
        GroupBox3.Text = "GroupBox3"
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(6, 66)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(126, 29)
        RadioButton5.TabIndex = 7
        RadioButton5.TabStop = True
        RadioButton5.Text = "Perempuan"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(252, 345)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(526, 34)
        btnCetak.TabIndex = 23
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' btnGambar
        ' 
        btnGambar.Location = New Point(-3, 345)
        btnGambar.Name = "btnGambar"
        btnGambar.Size = New Size(249, 34)
        btnGambar.TabIndex = 24
        btnGambar.Text = "Pilih Gambar"
        btnGambar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnGambar)
        Controls.Add(btnCetak)
        Controls.Add(gbjk)
        Controls.Add(gbhobi)
        Controls.Add(txtNama)
        Controls.Add(TxtNim)
        Controls.Add(Label3)
        Controls.Add(nim)
        Controls.Add(Nama)
        Controls.Add(picProfil)
        Controls.Add(DTPLahir)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        gbhobi.ResumeLayout(False)
        gbhobi.PerformLayout()
        gbjk.ResumeLayout(False)
        gbjk.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DTPLahir As DateTimePicker
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents picProfil As PictureBox
    Friend WithEvents Nama As Label
    Friend WithEvents rbcowo As RadioButton
    Friend WithEvents nim As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNim As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents gbhobi As GroupBox
    Friend WithEvents gbjk As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents cbgame As CheckBox
    Friend WithEvents cbbaca As CheckBox
    Friend WithEvents cbmancing As CheckBox
    Friend WithEvents rbcewe As RadioButton
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnGambar As Button

End Class
