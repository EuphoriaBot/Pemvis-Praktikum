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
        btnBrowse = New Button()
        pictureBox = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblTLahir = New Label()
        lblNTelpon = New Label()
        lblAlamat = New Label()
        txtUmur = New TextBox()
        txtAlamat = New TextBox()
        txtTelpon = New TextBox()
        txtNama = New TextBox()
        dtpTLahir = New DateTimePicker()
        GroupBox1 = New GroupBox()
        rdbPerempuan = New RadioButton()
        rdbLaki = New RadioButton()
        GroupBox2 = New GroupBox()
        cbTracking = New CheckBox()
        cbDonasi = New CheckBox()
        cbMelukis = New CheckBox()
        cbHiking = New CheckBox()
        cbKoleksi = New CheckBox()
        cbCamping = New CheckBox()
        cbVideografi = New CheckBox()
        cbPublikasi = New CheckBox()
        cbSosialisasi = New CheckBox()
        cbFotografi = New CheckBox()
        btnCetak = New Button()
        PictureBox1 = New PictureBox()
        CType(pictureBox, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(12, 541)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(291, 46)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' pictureBox
        ' 
        pictureBox.Location = New Point(12, 12)
        pictureBox.Name = "pictureBox"
        pictureBox.Size = New Size(291, 523)
        pictureBox.TabIndex = 2
        pictureBox.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(309, 12)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(59, 25)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(309, 57)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(56, 25)
        lblUmur.TabIndex = 4
        lblUmur.Text = "Umur"
        ' 
        ' lblTLahir
        ' 
        lblTLahir.AutoSize = True
        lblTLahir.Location = New Point(309, 104)
        lblTLahir.Name = "lblTLahir"
        lblTLahir.Size = New Size(115, 25)
        lblTLahir.TabIndex = 5
        lblTLahir.Text = "Tanggal Lahir"
        ' 
        ' lblNTelpon
        ' 
        lblNTelpon.AutoSize = True
        lblNTelpon.Location = New Point(309, 155)
        lblNTelpon.Name = "lblNTelpon"
        lblNTelpon.Size = New Size(93, 25)
        lblNTelpon.TabIndex = 6
        lblNTelpon.Text = "No Telpon"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(309, 206)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(68, 25)
        lblAlamat.TabIndex = 7
        lblAlamat.Text = "Alamat"
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(462, 57)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(282, 31)
        txtUmur.TabIndex = 8
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(462, 203)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(282, 31)
        txtAlamat.TabIndex = 9
        ' 
        ' txtTelpon
        ' 
        txtTelpon.Location = New Point(462, 155)
        txtTelpon.Name = "txtTelpon"
        txtTelpon.Size = New Size(282, 31)
        txtTelpon.TabIndex = 10
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(462, 12)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(282, 31)
        txtNama.TabIndex = 11
        ' 
        ' dtpTLahir
        ' 
        dtpTLahir.Location = New Point(462, 104)
        dtpTLahir.Name = "dtpTLahir"
        dtpTLahir.Size = New Size(282, 31)
        dtpTLahir.TabIndex = 12
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rdbPerempuan)
        GroupBox1.Controls.Add(rdbLaki)
        GroupBox1.Location = New Point(309, 259)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(230, 276)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' rdbPerempuan
        ' 
        rdbPerempuan.AutoSize = True
        rdbPerempuan.Location = New Point(6, 130)
        rdbPerempuan.Name = "rdbPerempuan"
        rdbPerempuan.Size = New Size(126, 29)
        rdbPerempuan.TabIndex = 1
        rdbPerempuan.TabStop = True
        rdbPerempuan.Text = "Perempuan"
        rdbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rdbLaki
        ' 
        rdbLaki.AutoSize = True
        rdbLaki.Location = New Point(6, 51)
        rdbLaki.Name = "rdbLaki"
        rdbLaki.Size = New Size(114, 29)
        rdbLaki.TabIndex = 0
        rdbLaki.TabStop = True
        rdbLaki.Text = "Laki - Laki"
        rdbLaki.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbTracking)
        GroupBox2.Controls.Add(cbDonasi)
        GroupBox2.Controls.Add(cbMelukis)
        GroupBox2.Controls.Add(cbHiking)
        GroupBox2.Controls.Add(cbKoleksi)
        GroupBox2.Controls.Add(cbCamping)
        GroupBox2.Controls.Add(cbVideografi)
        GroupBox2.Controls.Add(cbPublikasi)
        GroupBox2.Controls.Add(cbSosialisasi)
        GroupBox2.Controls.Add(cbFotografi)
        GroupBox2.Location = New Point(562, 259)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(391, 276)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' cbTracking
        ' 
        cbTracking.AutoSize = True
        cbTracking.Location = New Point(246, 231)
        cbTracking.Name = "cbTracking"
        cbTracking.Size = New Size(102, 29)
        cbTracking.TabIndex = 9
        cbTracking.Text = "Tracking"
        cbTracking.UseVisualStyleBackColor = True
        ' 
        ' cbDonasi
        ' 
        cbDonasi.AutoSize = True
        cbDonasi.Location = New Point(246, 183)
        cbDonasi.Name = "cbDonasi"
        cbDonasi.Size = New Size(93, 29)
        cbDonasi.TabIndex = 8
        cbDonasi.Text = "Donasi"
        cbDonasi.UseVisualStyleBackColor = True
        ' 
        ' cbMelukis
        ' 
        cbMelukis.AutoSize = True
        cbMelukis.Location = New Point(246, 131)
        cbMelukis.Name = "cbMelukis"
        cbMelukis.Size = New Size(98, 29)
        cbMelukis.TabIndex = 7
        cbMelukis.Text = "Melukis"
        cbMelukis.UseVisualStyleBackColor = True
        ' 
        ' cbHiking
        ' 
        cbHiking.AutoSize = True
        cbHiking.Location = New Point(246, 80)
        cbHiking.Name = "cbHiking"
        cbHiking.Size = New Size(89, 29)
        cbHiking.TabIndex = 6
        cbHiking.Text = "Hiking"
        cbHiking.UseVisualStyleBackColor = True
        ' 
        ' cbKoleksi
        ' 
        cbKoleksi.AutoSize = True
        cbKoleksi.Location = New Point(246, 30)
        cbKoleksi.Name = "cbKoleksi"
        cbKoleksi.Size = New Size(93, 29)
        cbKoleksi.TabIndex = 5
        cbKoleksi.Text = "Koleksi"
        cbKoleksi.UseVisualStyleBackColor = True
        ' 
        ' cbCamping
        ' 
        cbCamping.AutoSize = True
        cbCamping.Location = New Point(17, 231)
        cbCamping.Name = "cbCamping"
        cbCamping.Size = New Size(110, 29)
        cbCamping.TabIndex = 4
        cbCamping.Text = "Camping"
        cbCamping.UseVisualStyleBackColor = True
        ' 
        ' cbVideografi
        ' 
        cbVideografi.AutoSize = True
        cbVideografi.Location = New Point(17, 183)
        cbVideografi.Name = "cbVideografi"
        cbVideografi.Size = New Size(120, 29)
        cbVideografi.TabIndex = 3
        cbVideografi.Text = "Videografi"
        cbVideografi.UseVisualStyleBackColor = True
        ' 
        ' cbPublikasi
        ' 
        cbPublikasi.AutoSize = True
        cbPublikasi.Location = New Point(17, 131)
        cbPublikasi.Name = "cbPublikasi"
        cbPublikasi.Size = New Size(107, 29)
        cbPublikasi.TabIndex = 2
        cbPublikasi.Text = "Publikasi"
        cbPublikasi.UseVisualStyleBackColor = True
        ' 
        ' cbSosialisasi
        ' 
        cbSosialisasi.AutoSize = True
        cbSosialisasi.Location = New Point(17, 80)
        cbSosialisasi.Name = "cbSosialisasi"
        cbSosialisasi.Size = New Size(117, 29)
        cbSosialisasi.TabIndex = 1
        cbSosialisasi.Text = "Sosialisasi"
        cbSosialisasi.UseVisualStyleBackColor = True
        ' 
        ' cbFotografi
        ' 
        cbFotografi.AutoSize = True
        cbFotografi.Location = New Point(17, 30)
        cbFotografi.Name = "cbFotografi"
        cbFotografi.Size = New Size(111, 29)
        cbFotografi.TabIndex = 0
        cbFotografi.Text = "Fotografi"
        cbFotografi.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(309, 541)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(644, 46)
        btnCetak.TabIndex = 15
        btnCetak.Text = "Cetal Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.gopnik_logo1
        PictureBox1.Location = New Point(644, -23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(400, 323)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(965, 599)
        Controls.Add(btnCetak)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(dtpTLahir)
        Controls.Add(txtNama)
        Controls.Add(txtTelpon)
        Controls.Add(txtAlamat)
        Controls.Add(txtUmur)
        Controls.Add(lblAlamat)
        Controls.Add(lblNTelpon)
        Controls.Add(lblTLahir)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(pictureBox)
        Controls.Add(btnBrowse)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(pictureBox, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnBrowse As Button
    Friend WithEvents pictureBox As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTLahir As Label
    Friend WithEvents lblNTelpon As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtTelpon As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents dtpTLahir As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbFotografi As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbSosialisasi As CheckBox
    Friend WithEvents cbTracking As CheckBox
    Friend WithEvents cbDonasi As CheckBox
    Friend WithEvents cbMelukis As CheckBox
    Friend WithEvents cbHiking As CheckBox
    Friend WithEvents cbKoleksi As CheckBox
    Friend WithEvents cbCamping As CheckBox
    Friend WithEvents cbVideografi As CheckBox
    Friend WithEvents cbPublikasi As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents rdbPerempuan As RadioButton
    Friend WithEvents rdbLaki As RadioButton
    Friend WithEvents PictureBox1 As PictureBox

End Class
