<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        PictureBox1 = New PictureBox()
        lblNama = New Label()
        lblNim = New Label()
        lblTLahir = New Label()
        lblJK = New Label()
        lblHobi = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 34)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(203, 264)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(252, 59)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(63, 25)
        lblNama.TabIndex = 1
        lblNama.Text = "Label1"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(252, 101)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(63, 25)
        lblNim.TabIndex = 2
        lblNim.Text = "Label2"
        ' 
        ' lblTLahir
        ' 
        lblTLahir.AutoSize = True
        lblTLahir.Location = New Point(252, 152)
        lblTLahir.Name = "lblTLahir"
        lblTLahir.Size = New Size(63, 25)
        lblTLahir.TabIndex = 3
        lblTLahir.Text = "Label3"
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.Location = New Point(252, 201)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(63, 25)
        lblJK.TabIndex = 4
        lblJK.Text = "Label4"
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.Location = New Point(252, 257)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(63, 25)
        lblHobi.TabIndex = 5
        lblHobi.Text = "Label5"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblHobi)
        Controls.Add(lblJK)
        Controls.Add(lblTLahir)
        Controls.Add(lblNim)
        Controls.Add(lblNama)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents lblTLahir As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents lblHobi As Label
End Class
