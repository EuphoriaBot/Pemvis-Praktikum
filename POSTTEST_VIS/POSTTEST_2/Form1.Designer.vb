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
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        btnTambah = New Button()
        Label2 = New Label()
        txtNama = New TextBox()
        txtGenre = New TextBox()
        GroupBox2 = New GroupBox()
        txtHapus = New TextBox()
        btnHapus = New Button()
        Label3 = New Label()
        RichTextBox1 = New RichTextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtNama)
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Location = New Point(49, 65)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(373, 228)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 2
        Label1.Text = "Judul Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(238, 161)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 49)
        btnTambah.TabIndex = 8
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 25)
        Label2.TabIndex = 3
        Label2.Text = "Genre"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(168, 44)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 5
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(168, 91)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(150, 31)
        txtGenre.TabIndex = 6
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtHapus)
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(49, 359)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(373, 228)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(168, 50)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(150, 31)
        txtHapus.TabIndex = 7
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(238, 157)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 49)
        btnHapus.TabIndex = 9
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 25)
        Label3.TabIndex = 4
        Label3.Text = "Hapus"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = SystemColors.ButtonHighlight
        RichTextBox1.Location = New Point(509, 77)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(364, 510)
        RichTextBox1.TabIndex = 2
        RichTextBox1.Text = ""
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(927, 631)
        Controls.Add(RichTextBox1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents RichTextBox1 As RichTextBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
