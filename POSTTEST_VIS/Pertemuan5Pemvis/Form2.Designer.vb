<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        txtKodeBuku = New TextBox()
        txtJudul = New TextBox()
        txtPengarang = New TextBox()
        txtPenerbit = New TextBox()
        txtJumlah = New TextBox()
        txtCari = New TextBox()
        txtDeskripsi = New TextBox()
        dgvBuku = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        cbJenis = New ComboBox()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 25)
        Label1.TabIndex = 0
        Label1.Text = "Kode buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(285, 7)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 25)
        Label2.TabIndex = 1
        Label2.Text = "Jenis Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(620, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 25)
        Label3.TabIndex = 2
        Label3.Text = "Deskripsi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 52)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 25)
        Label4.TabIndex = 3
        Label4.Text = "Juduk"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 104)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 25)
        Label5.TabIndex = 4
        Label5.Text = "Pengarang"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 155)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 25)
        Label6.TabIndex = 5
        Label6.Text = "Penerbit"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 201)
        Label7.Name = "Label7"
        Label7.Size = New Size(111, 25)
        Label7.TabIndex = 6
        Label7.Text = "Jumlah Buku"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(12, 248)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 7
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(184, 248)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(112, 34)
        btnUbah.TabIndex = 8
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(354, 248)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 9
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(523, 238)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(112, 34)
        btnBatal.TabIndex = 10
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(118, 7)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(150, 31)
        txtKodeBuku.TabIndex = 11
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(105, 52)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(150, 31)
        txtJudul.TabIndex = 13
        ' 
        ' txtPengarang
        ' 
        txtPengarang.Location = New Point(128, 104)
        txtPengarang.Name = "txtPengarang"
        txtPengarang.Size = New Size(150, 31)
        txtPengarang.TabIndex = 14
        ' 
        ' txtPenerbit
        ' 
        txtPenerbit.Location = New Point(128, 155)
        txtPenerbit.Name = "txtPenerbit"
        txtPenerbit.Size = New Size(150, 31)
        txtPenerbit.TabIndex = 15
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Location = New Point(146, 201)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(150, 31)
        txtJumlah.TabIndex = 16
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(12, 302)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(284, 31)
        txtCari.TabIndex = 17
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.Location = New Point(596, 102)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(150, 124)
        txtDeskripsi.TabIndex = 18
        ' 
        ' dgvBuku
        ' 
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Location = New Point(18, 350)
        dgvBuku.Name = "dgvBuku"
        dgvBuku.RowHeadersWidth = 62
        dgvBuku.Size = New Size(360, 225)
        dgvBuku.TabIndex = 19
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' cbJenis
        ' 
        cbJenis.FormattingEnabled = True
        cbJenis.Location = New Point(393, 7)
        cbJenis.Name = "cbJenis"
        cbJenis.Size = New Size(182, 33)
        cbJenis.TabIndex = 20
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 588)
        Controls.Add(cbJenis)
        Controls.Add(dgvBuku)
        Controls.Add(txtDeskripsi)
        Controls.Add(txtCari)
        Controls.Add(txtJumlah)
        Controls.Add(txtPenerbit)
        Controls.Add(txtPengarang)
        Controls.Add(txtJudul)
        Controls.Add(txtKodeBuku)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtPengarang As TextBox
    Friend WithEvents txtPenerbit As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cbJenis As ComboBox
End Class