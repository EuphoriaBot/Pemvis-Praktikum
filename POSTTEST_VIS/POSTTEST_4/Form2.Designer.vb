<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKartu))
        PanelKartu = New Panel()
        Label9 = New Label()
        lblHobiHasil = New Label()
        lblKontakHasil = New Label()
        lblKomunitasID = New Label()
        lblIDHasil = New Label()
        lblNamaHasil = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        PicKartu = New PictureBox()
        PanelHeaderKartu = New Panel()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PanelKartu.SuspendLayout()
        CType(PicKartu, ComponentModel.ISupportInitialize).BeginInit()
        PanelHeaderKartu.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelKartu
        ' 
        PanelKartu.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        PanelKartu.BorderStyle = BorderStyle.FixedSingle
        PanelKartu.Controls.Add(Label9)
        PanelKartu.Controls.Add(lblHobiHasil)
        PanelKartu.Controls.Add(lblKontakHasil)
        PanelKartu.Controls.Add(lblKomunitasID)
        PanelKartu.Controls.Add(lblIDHasil)
        PanelKartu.Controls.Add(lblNamaHasil)
        PanelKartu.Controls.Add(Label8)
        PanelKartu.Controls.Add(Label7)
        PanelKartu.Controls.Add(Label6)
        PanelKartu.Controls.Add(Label5)
        PanelKartu.Controls.Add(Label4)
        PanelKartu.Controls.Add(Label3)
        PanelKartu.Controls.Add(PicKartu)
        PanelKartu.Location = New Point(0, 82)
        PanelKartu.Name = "PanelKartu"
        PanelKartu.Size = New Size(565, 360)
        PanelKartu.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.White
        Label9.Location = New Point(254, 312)
        Label9.Name = "Label9"
        Label9.Size = New Size(197, 25)
        Label9.TabIndex = 12
        Label9.Text = "Dark • Elite • Organized"
        ' 
        ' lblHobiHasil
        ' 
        lblHobiHasil.AutoSize = True
        lblHobiHasil.ForeColor = Color.White
        lblHobiHasil.Location = New Point(388, 260)
        lblHobiHasil.Name = "lblHobiHasil"
        lblHobiHasil.Size = New Size(73, 25)
        lblHobiHasil.TabIndex = 11
        lblHobiHasil.Text = "Label13"
        ' 
        ' lblKontakHasil
        ' 
        lblKontakHasil.AutoSize = True
        lblKontakHasil.ForeColor = Color.White
        lblKontakHasil.Location = New Point(388, 194)
        lblKontakHasil.Name = "lblKontakHasil"
        lblKontakHasil.Size = New Size(73, 25)
        lblKontakHasil.TabIndex = 10
        lblKontakHasil.Text = "Label12"
        ' 
        ' lblKomunitasID
        ' 
        lblKomunitasID.AutoSize = True
        lblKomunitasID.ForeColor = Color.White
        lblKomunitasID.Location = New Point(388, 136)
        lblKomunitasID.Name = "lblKomunitasID"
        lblKomunitasID.Size = New Size(73, 25)
        lblKomunitasID.TabIndex = 9
        lblKomunitasID.Text = "Label11"
        ' 
        ' lblIDHasil
        ' 
        lblIDHasil.AutoSize = True
        lblIDHasil.ForeColor = SystemColors.Control
        lblIDHasil.Location = New Point(388, 78)
        lblIDHasil.Name = "lblIDHasil"
        lblIDHasil.Size = New Size(73, 25)
        lblIDHasil.TabIndex = 8
        lblIDHasil.Text = "Label10"
        ' 
        ' lblNamaHasil
        ' 
        lblNamaHasil.AutoSize = True
        lblNamaHasil.ForeColor = Color.White
        lblNamaHasil.Location = New Point(388, 19)
        lblNamaHasil.Name = "lblNamaHasil"
        lblNamaHasil.Size = New Size(63, 25)
        lblNamaHasil.TabIndex = 7
        lblNamaHasil.Text = "Label9"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.Red
        Label8.Location = New Point(218, 260)
        Label8.Name = "Label8"
        Label8.Size = New Size(149, 25)
        Label8.TabIndex = 6
        Label8.Text = "Hobi / Aktivitas : "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(218, 194)
        Label7.Name = "Label7"
        Label7.Size = New Size(146, 25)
        Label7.TabIndex = 5
        Label7.Text = "Kontak               :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(218, 136)
        Label6.Name = "Label6"
        Label6.Size = New Size(150, 25)
        Label6.TabIndex = 4
        Label6.Text = "Komunitas         : "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(218, 78)
        Label5.Name = "Label5"
        Label5.Size = New Size(149, 25)
        Label5.TabIndex = 3
        Label5.Text = "ID Anggota       : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(218, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 25)
        Label4.TabIndex = 2
        Label4.Text = "Nama                 :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(10, 312)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 25)
        Label3.TabIndex = 1
        Label3.Text = "Verified Member"
        ' 
        ' PicKartu
        ' 
        PicKartu.BorderStyle = BorderStyle.FixedSingle
        PicKartu.Location = New Point(11, 19)
        PicKartu.Name = "PicKartu"
        PicKartu.Size = New Size(150, 266)
        PicKartu.SizeMode = PictureBoxSizeMode.StretchImage
        PicKartu.TabIndex = 0
        PicKartu.TabStop = False
        ' 
        ' PanelHeaderKartu
        ' 
        PanelHeaderKartu.BackColor = Color.DarkRed
        PanelHeaderKartu.Controls.Add(Panel1)
        PanelHeaderKartu.Controls.Add(Label2)
        PanelHeaderKartu.Controls.Add(Label1)
        PanelHeaderKartu.Controls.Add(PictureBox1)
        PanelHeaderKartu.Dock = DockStyle.Top
        PanelHeaderKartu.Location = New Point(0, 0)
        PanelHeaderKartu.Name = "PanelHeaderKartu"
        PanelHeaderKartu.Size = New Size(566, 82)
        PanelHeaderKartu.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Red
        Panel1.Location = New Point(0, 79)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(801, 3)
        Panel1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(179, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(249, 25)
        Label2.TabIndex = 0
        Label2.Text = "Elite Community Identity Card"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(105, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(420, 45)
        Label1.TabIndex = 1
        Label1.Text = "AKATSUKI MEMBER CARD"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(99, 79)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        ClientSize = New Size(566, 444)
        Controls.Add(PanelHeaderKartu)
        Controls.Add(PanelKartu)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "FormKartu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kartu Anggota Akatsuki Coy"
        PanelKartu.ResumeLayout(False)
        PanelKartu.PerformLayout()
        CType(PicKartu, ComponentModel.ISupportInitialize).EndInit()
        PanelHeaderKartu.ResumeLayout(False)
        PanelHeaderKartu.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelKartu As Panel
    Friend WithEvents PanelHeaderKartu As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PicKartu As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblHobiHasil As Label
    Friend WithEvents lblKontakHasil As Label
    Friend WithEvents lblKomunitasID As Label
    Friend WithEvents lblIDHasil As Label
    Friend WithEvents lblNamaHasil As Label
    Friend WithEvents Label9 As Label
End Class
