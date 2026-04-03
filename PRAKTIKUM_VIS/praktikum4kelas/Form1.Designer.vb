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
        MenuStrip1 = New MenuStrip()
        MenuInput = New ToolStripMenuItem()
        NomorToolStripMenuItem = New ToolStripMenuItem()
        NamaToolStripMenuItem = New ToolStripMenuItem()
        MenuBukaFile = New ToolStripMenuItem()
        MenuKeluar = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        tcIdentitas = New TabPage()
        mtbNoHP = New MaskedTextBox()
        txtAlamat = New TextBox()
        txtNama = New TextBox()
        tcRingkasan = New TabPage()
        lblRingkas = New Label()
        btnSimpan = New Button()
        btnReset = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        tcIdentitas.SuspendLayout()
        tcRingkasan.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuInput, MenuBukaFile, MenuKeluar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuInput
        ' 
        MenuInput.DropDownItems.AddRange(New ToolStripItem() {NomorToolStripMenuItem, NamaToolStripMenuItem})
        MenuInput.Name = "MenuInput"
        MenuInput.Size = New Size(70, 29)
        MenuInput.Text = "Input"
        ' 
        ' NomorToolStripMenuItem
        ' 
        NomorToolStripMenuItem.Name = "NomorToolStripMenuItem"
        NomorToolStripMenuItem.Size = New Size(270, 34)
        NomorToolStripMenuItem.Text = "Nomor"
        ' 
        ' NamaToolStripMenuItem
        ' 
        NamaToolStripMenuItem.Name = "NamaToolStripMenuItem"
        NamaToolStripMenuItem.Size = New Size(270, 34)
        NamaToolStripMenuItem.Text = "Nama"
        ' 
        ' MenuBukaFile
        ' 
        MenuBukaFile.Name = "MenuBukaFile"
        MenuBukaFile.Size = New Size(97, 29)
        MenuBukaFile.Text = "Buka File"
        ' 
        ' MenuKeluar
        ' 
        MenuKeluar.Name = "MenuKeluar"
        MenuKeluar.Size = New Size(76, 29)
        MenuKeluar.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tcIdentitas)
        TabControl1.Controls.Add(tcRingkasan)
        TabControl1.Location = New Point(12, 36)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(645, 339)
        TabControl1.TabIndex = 1
        ' 
        ' tcIdentitas
        ' 
        tcIdentitas.Controls.Add(mtbNoHP)
        tcIdentitas.Controls.Add(txtAlamat)
        tcIdentitas.Controls.Add(txtNama)
        tcIdentitas.Location = New Point(4, 34)
        tcIdentitas.Name = "tcIdentitas"
        tcIdentitas.Padding = New Padding(3)
        tcIdentitas.Size = New Size(637, 301)
        tcIdentitas.TabIndex = 0
        tcIdentitas.Text = "Identitas"
        tcIdentitas.UseVisualStyleBackColor = True
        ' 
        ' mtbNoHP
        ' 
        mtbNoHP.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals
        mtbNoHP.Location = New Point(6, 118)
        mtbNoHP.Mask = "0000-0000-0000"
        mtbNoHP.Name = "mtbNoHP"
        mtbNoHP.Size = New Size(150, 31)
        mtbNoHP.TabIndex = 2
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(6, 68)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat"
        txtAlamat.Size = New Size(150, 31)
        txtAlamat.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(6, 18)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 0
        ' 
        ' tcRingkasan
        ' 
        tcRingkasan.Controls.Add(lblRingkas)
        tcRingkasan.Location = New Point(4, 34)
        tcRingkasan.Name = "tcRingkasan"
        tcRingkasan.Padding = New Padding(3)
        tcRingkasan.Size = New Size(637, 301)
        tcRingkasan.TabIndex = 1
        tcRingkasan.Text = "Ringkasan"
        tcRingkasan.UseVisualStyleBackColor = True
        ' 
        ' lblRingkas
        ' 
        lblRingkas.AutoSize = True
        lblRingkas.Location = New Point(15, 25)
        lblRingkas.Name = "lblRingkas"
        lblRingkas.Size = New Size(63, 25)
        lblRingkas.TabIndex = 0
        lblRingkas.Text = "Label1"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(405, 455)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 2
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(186, 430)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(180, 84)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 530)
        Controls.Add(btnReset)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        Controls.Add(btnSimpan)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        tcIdentitas.ResumeLayout(False)
        tcIdentitas.PerformLayout()
        tcRingkasan.ResumeLayout(False)
        tcRingkasan.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuInput As ToolStripMenuItem
    Friend WithEvents NomorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NamaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuKeluar As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tcIdentitas As TabPage
    Friend WithEvents tcRingkasan As TabPage
    Friend WithEvents mtbNoHP As MaskedTextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblRingkas As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents MenuBukaFile As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog

End Class
