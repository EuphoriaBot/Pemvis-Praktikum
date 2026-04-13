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
        components = New ComponentModel.Container()
        Label2 = New Label()
        Label3 = New Label()
        txtKodeBuku = New TextBox()
        txtSearch = New TextBox()
        txtJenis = New TextBox()
        btnSImpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvJenis = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        Label1 = New Label()
        Button1 = New Button()
        CType(dgvJenis, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 25)
        Label2.TabIndex = 1
        Label2.Text = "Cari"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 25)
        Label3.TabIndex = 2
        Label3.Text = "Pengarang"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(124, 12)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(491, 31)
        txtKodeBuku.TabIndex = 3
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(124, 91)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(491, 31)
        txtSearch.TabIndex = 4
        ' 
        ' txtJenis
        ' 
        txtJenis.Location = New Point(124, 52)
        txtJenis.Name = "txtJenis"
        txtJenis.Size = New Size(491, 31)
        txtJenis.TabIndex = 5
        ' 
        ' btnSImpan
        ' 
        btnSImpan.Location = New Point(21, 160)
        btnSImpan.Name = "btnSImpan"
        btnSImpan.Size = New Size(112, 34)
        btnSImpan.TabIndex = 6
        btnSImpan.Text = "Simpan"
        btnSImpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(231, 160)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(112, 34)
        btnUbah.TabIndex = 7
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(441, 160)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(657, 160)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(112, 34)
        btnBatal.TabIndex = 9
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' dgvJenis
        ' 
        dgvJenis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJenis.Location = New Point(21, 213)
        dgvJenis.Name = "dgvJenis"
        dgvJenis.RowHeadersWidth = 62
        dgvJenis.Size = New Size(748, 225)
        dgvJenis.TabIndex = 10
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 25)
        Label1.TabIndex = 0
        Label1.Text = "Kode Jenis"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(803, 160)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 12
        Button1.Text = "pindah"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(943, 450)
        Controls.Add(Button1)
        Controls.Add(dgvJenis)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSImpan)
        Controls.Add(txtJenis)
        Controls.Add(txtSearch)
        Controls.Add(txtKodeBuku)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(dgvJenis, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtJenis As TextBox
    Friend WithEvents btnSImpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvJenis As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button

End Class
