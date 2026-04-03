<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtamaAkatsukiCoy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUtamaAkatsukiCoy))
        PanelHeader = New Panel()
        PanelLineHeader = New Panel()
        lblSubJudul = New Label()
        lblJudul = New Label()
        lblSideBar = New Label()
        PicSidebarLogo = New PictureBox()
        Label1 = New Label()
        Label3 = New Label()
        PanelSidebar = New Panel()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        MenuStrip1 = New MenuStrip()
        mnInputData = New ToolStripMenuItem()
        mnLihatKartu = New ToolStripMenuItem()
        mnSimpanData = New ToolStripMenuItem()
        mnBukaData = New ToolStripMenuItem()
        mnKeluar = New ToolStripMenuItem()
        Panel3 = New Panel()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        lblFormSection = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        cmbKomunitas = New ComboBox()
        Label10 = New Label()
        gbJenisKelamin = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        dptTanggalLahir = New DateTimePicker()
        Label9 = New Label()
        txtId = New TextBox()
        label8 = New Label()
        txtNama = New TextBox()
        label7 = New Label()
        TabPage2 = New TabPage()
        txtAlamat = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        txtEmail = New TextBox()
        mtbTelepon = New MaskedTextBox()
        Label11 = New Label()
        TabPage3 = New TabPage()
        btnReset = New Button()
        btnCetak = New Button()
        GroupBox1 = New GroupBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        grpPeran = New GroupBox()
        dbDI = New RadioButton()
        rbDkeungan = New RadioButton()
        rbDkerajinan = New RadioButton()
        rbDkreatif = New RadioButton()
        rbDL = New RadioButton()
        rbO = New RadioButton()
        rbA = New RadioButton()
        rbP = New RadioButton()
        btnBrowse = New Button()
        Label14 = New Label()
        picProfile = New PictureBox()
        PanelKonten = New Panel()
        Panel4 = New Panel()
        PanelHeader.SuspendLayout()
        CType(PicSidebarLogo, ComponentModel.ISupportInitialize).BeginInit()
        PanelSidebar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        gbJenisKelamin.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        GroupBox1.SuspendLayout()
        grpPeran.SuspendLayout()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        PanelKonten.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(120), CByte(0), CByte(0))
        PanelHeader.Controls.Add(PanelLineHeader)
        PanelHeader.Controls.Add(lblSubJudul)
        PanelHeader.Controls.Add(lblJudul)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(1178, 95)
        PanelHeader.TabIndex = 0
        ' 
        ' PanelLineHeader
        ' 
        PanelLineHeader.BackColor = Color.Red
        PanelLineHeader.Dock = DockStyle.Bottom
        PanelLineHeader.Location = New Point(0, 92)
        PanelLineHeader.Name = "PanelLineHeader"
        PanelLineHeader.Size = New Size(1178, 3)
        PanelLineHeader.TabIndex = 1
        ' 
        ' lblSubJudul
        ' 
        lblSubJudul.AutoSize = True
        lblSubJudul.ForeColor = Color.Gainsboro
        lblSubJudul.Location = New Point(348, 54)
        lblSubJudul.Name = "lblSubJudul"
        lblSubJudul.Size = New Size(509, 25)
        lblSubJudul.TabIndex = 1
        lblSubJudul.Text = "Sistem pembuatan kartu anggota komunitas bertema Akatsuki"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblJudul.Location = New Point(277, 0)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(646, 54)
        lblJudul.TabIndex = 1
        lblJudul.Text = "Akatsuki Community Card Maker"
        ' 
        ' lblSideBar
        ' 
        lblSideBar.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSideBar.ForeColor = Color.White
        lblSideBar.Location = New Point(35, 212)
        lblSideBar.Name = "lblSideBar"
        lblSideBar.Size = New Size(209, 69)
        lblSideBar.TabIndex = 2
        lblSideBar.Text = "MEMBER IDENTIFICATION"
        lblSideBar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PicSidebarLogo
        ' 
        PicSidebarLogo.BorderStyle = BorderStyle.FixedSingle
        PicSidebarLogo.Image = CType(resources.GetObject("PicSidebarLogo.Image"), Image)
        PicSidebarLogo.Location = New Point(0, 445)
        PicSidebarLogo.Name = "PicSidebarLogo"
        PicSidebarLogo.Size = New Size(280, 204)
        PicSidebarLogo.SizeMode = PictureBoxSizeMode.StretchImage
        PicSidebarLogo.TabIndex = 2
        PicSidebarLogo.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.LightGray
        Label1.Location = New Point(40, 290)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 25)
        Label1.TabIndex = 2
        Label1.Text = "Dark • Elite • Organized"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(45, 249)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 32)
        Label3.TabIndex = 4
        ' 
        ' PanelSidebar
        ' 
        PanelSidebar.Controls.Add(PictureBox1)
        PanelSidebar.Controls.Add(Label6)
        PanelSidebar.Controls.Add(Panel2)
        PanelSidebar.Controls.Add(Label4)
        PanelSidebar.Controls.Add(Label5)
        PanelSidebar.Controls.Add(Panel1)
        PanelSidebar.Controls.Add(Label3)
        PanelSidebar.Controls.Add(Label2)
        PanelSidebar.Controls.Add(lblSideBar)
        PanelSidebar.Controls.Add(Label1)
        PanelSidebar.Controls.Add(PicSidebarLogo)
        PanelSidebar.Location = New Point(0, 95)
        PanelSidebar.Name = "PanelSidebar"
        PanelSidebar.Size = New Size(280, 649)
        PanelSidebar.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(280, 206)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.LightGray
        Label6.Location = New Point(3, 414)
        Label6.Name = "Label6"
        Label6.Size = New Size(270, 25)
        Label6.TabIndex = 7
        Label6.Text = "Gunakan foto profil terbaik anda"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Red
        Panel2.Location = New Point(0, 442)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(279, 3)
        Panel2.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.LightGray
        Label4.Location = New Point(45, 389)
        Label4.Name = "Label4"
        Label4.Size = New Size(176, 25)
        Label4.TabIndex = 6
        Label4.Text = "Tab di sebelah kanan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.LightGray
        Label5.Location = New Point(12, 364)
        Label5.Name = "Label5"
        Label5.Size = New Size(240, 25)
        Label5.TabIndex = 5
        Label5.Text = "Lengkapi data anggota pada"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Red
        Panel1.Location = New Point(3, 206)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(277, 3)
        Panel1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.LightGray
        Label2.Location = New Point(12, 315)
        Label2.Name = "Label2"
        Label2.Size = New Size(254, 25)
        Label2.TabIndex = 3
        Label2.Text = "Input data anggota komunitas"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.AutoSize = False
        MenuStrip1.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnInputData, mnLihatKartu, mnSimpanData, mnBukaData, mnKeluar})
        MenuStrip1.Location = New Point(283, 95)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(895, 35)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnInputData
        ' 
        mnInputData.ForeColor = Color.White
        mnInputData.Name = "mnInputData"
        mnInputData.Size = New Size(124, 31)
        mnInputData.Text = "Input Data"
        ' 
        ' mnLihatKartu
        ' 
        mnLihatKartu.ForeColor = Color.White
        mnLihatKartu.Name = "mnLihatKartu"
        mnLihatKartu.Size = New Size(127, 31)
        mnLihatKartu.Text = "Lihat Kartu"
        ' 
        ' mnSimpanData
        ' 
        mnSimpanData.ForeColor = Color.White
        mnSimpanData.Name = "mnSimpanData"
        mnSimpanData.Size = New Size(143, 31)
        mnSimpanData.Text = "Simpan Data"
        ' 
        ' mnBukaData
        ' 
        mnBukaData.ForeColor = Color.White
        mnBukaData.Name = "mnBukaData"
        mnBukaData.Size = New Size(120, 31)
        mnBukaData.Text = "Buka Data"
        ' 
        ' mnKeluar
        ' 
        mnKeluar.ForeColor = Color.White
        mnKeluar.Name = "mnKeluar"
        mnKeluar.Size = New Size(85, 31)
        mnKeluar.Text = "Keluar"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Red
        Panel3.Location = New Point(281, 131)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(897, 3)
        Panel3.TabIndex = 3
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' lblFormSection
        ' 
        lblFormSection.AutoSize = True
        lblFormSection.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFormSection.ForeColor = Color.White
        lblFormSection.Location = New Point(13, 14)
        lblFormSection.Name = "lblFormSection"
        lblFormSection.Size = New Size(466, 38)
        lblFormSection.TabIndex = 0
        lblFormSection.Text = "FORM DATA ANGGOTA AKATSUKI"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(24, 66)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(823, 530)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        TabPage1.Controls.Add(cmbKomunitas)
        TabPage1.Controls.Add(Label10)
        TabPage1.Controls.Add(gbJenisKelamin)
        TabPage1.Controls.Add(dptTanggalLahir)
        TabPage1.Controls.Add(Label9)
        TabPage1.Controls.Add(txtId)
        TabPage1.Controls.Add(label8)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(label7)
        TabPage1.Location = New Point(4, 37)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(815, 489)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Location = New Point(252, 185)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(198, 36)
        cmbKomunitas.TabIndex = 10
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(3, 188)
        Label10.Name = "Label10"
        Label10.Size = New Size(240, 28)
        Label10.TabIndex = 9
        Label10.Text = "Jenis Komunitas / Divisi"
        ' 
        ' gbJenisKelamin
        ' 
        gbJenisKelamin.BackColor = Color.Transparent
        gbJenisKelamin.Controls.Add(rbPerempuan)
        gbJenisKelamin.Controls.Add(rbLaki)
        gbJenisKelamin.ForeColor = Color.Red
        gbJenisKelamin.Location = New Point(467, 21)
        gbJenisKelamin.Name = "gbJenisKelamin"
        gbJenisKelamin.Size = New Size(342, 207)
        gbJenisKelamin.TabIndex = 8
        gbJenisKelamin.TabStop = False
        gbJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbPerempuan.ForeColor = Color.White
        rbPerempuan.Location = New Point(6, 131)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(135, 32)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbLaki.ForeColor = Color.White
        rbLaki.Location = New Point(6, 70)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(123, 32)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki - Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' dptTanggalLahir
        ' 
        dptTanggalLahir.CalendarMonthBackground = Color.Transparent
        dptTanggalLahir.CustomFormat = "dd MMMM yyyy"
        dptTanggalLahir.Format = DateTimePickerFormat.Custom
        dptTanggalLahir.Location = New Point(170, 134)
        dptTanggalLahir.Name = "dptTanggalLahir"
        dptTanggalLahir.Size = New Size(280, 34)
        dptTanggalLahir.TabIndex = 7
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 134)
        Label9.Name = "Label9"
        Label9.Size = New Size(139, 28)
        Label9.TabIndex = 4
        Label9.Text = "Tanggal Lahir"
        ' 
        ' txtId
        ' 
        txtId.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        txtId.BorderStyle = BorderStyle.FixedSingle
        txtId.ForeColor = Color.White
        txtId.Location = New Point(170, 75)
        txtId.Name = "txtId"
        txtId.Size = New Size(280, 34)
        txtId.TabIndex = 3
        ' 
        ' label8
        ' 
        label8.AutoSize = True
        label8.Location = New Point(6, 75)
        label8.Name = "label8"
        label8.Size = New Size(120, 28)
        label8.TabIndex = 2
        label8.Text = "ID Anggota"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.ForeColor = Color.White
        txtNama.Location = New Point(170, 21)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(280, 34)
        txtNama.TabIndex = 1
        ' 
        ' label7
        ' 
        label7.AutoSize = True
        label7.Location = New Point(6, 21)
        label7.Name = "label7"
        label7.Size = New Size(153, 28)
        label7.TabIndex = 0
        label7.Text = "Nama Lengkap"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(Label13)
        TabPage2.Controls.Add(Label12)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(mtbTelepon)
        TabPage2.Controls.Add(Label11)
        TabPage2.Location = New Point(4, 37)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(815, 489)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        txtAlamat.BorderStyle = BorderStyle.FixedSingle
        txtAlamat.ForeColor = Color.White
        txtAlamat.Location = New Point(186, 120)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(320, 100)
        txtAlamat.TabIndex = 6
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(3, 122)
        Label13.Name = "Label13"
        Label13.Size = New Size(80, 28)
        Label13.TabIndex = 5
        Label13.Text = "Alamat"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(6, 75)
        Label12.Name = "Label12"
        Label12.Size = New Size(64, 28)
        Label12.TabIndex = 4
        Label12.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.ForeColor = Color.White
        txtEmail.Location = New Point(186, 72)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(320, 34)
        txtEmail.TabIndex = 3
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        mtbTelepon.BorderStyle = BorderStyle.FixedSingle
        mtbTelepon.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals
        mtbTelepon.ForeColor = Color.White
        mtbTelepon.Location = New Point(186, 23)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(320, 34)
        mtbTelepon.TabIndex = 2
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(6, 23)
        Label11.Name = "Label11"
        Label11.Size = New Size(158, 28)
        Label11.TabIndex = 0
        Label11.Text = "Nomor Telepon"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        TabPage3.Controls.Add(btnReset)
        TabPage3.Controls.Add(btnCetak)
        TabPage3.Controls.Add(GroupBox1)
        TabPage3.Controls.Add(grpPeran)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(Label14)
        TabPage3.Controls.Add(picProfile)
        TabPage3.Location = New Point(4, 37)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(815, 489)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.DarkRed
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Location = New Point(228, 403)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(268, 65)
        btnReset.TabIndex = 7
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.DarkRed
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.Location = New Point(511, 403)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(281, 65)
        btnCetak.TabIndex = 6
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(CheckBox8)
        GroupBox1.Controls.Add(CheckBox7)
        GroupBox1.Controls.Add(CheckBox6)
        GroupBox1.Controls.Add(CheckBox5)
        GroupBox1.Controls.Add(CheckBox4)
        GroupBox1.Controls.Add(CheckBox3)
        GroupBox1.Controls.Add(CheckBox2)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.ForeColor = Color.Red
        GroupBox1.Location = New Point(511, 23)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(281, 358)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Minat Dalam Komunitas"
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(6, 312)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(133, 32)
        CheckBox8.TabIndex = 7
        CheckBox8.Text = "Eksplorasi"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(6, 274)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(149, 32)
        CheckBox7.TabIndex = 6
        CheckBox7.Text = "Manajemen"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(6, 236)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(120, 32)
        CheckBox6.TabIndex = 5
        CheckBox6.Text = "Miniatur"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(6, 197)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(102, 32)
        CheckBox5.TabIndex = 4
        CheckBox5.Text = "Desain"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(6, 157)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(109, 32)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Renang"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(6, 119)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(111, 32)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Analisis"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(6, 77)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(145, 32)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Paper Craft"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(6, 34)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(188, 32)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Public Speaking"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' grpPeran
        ' 
        grpPeran.Controls.Add(dbDI)
        grpPeran.Controls.Add(rbDkeungan)
        grpPeran.Controls.Add(rbDkerajinan)
        grpPeran.Controls.Add(rbDkreatif)
        grpPeran.Controls.Add(rbDL)
        grpPeran.Controls.Add(rbO)
        grpPeran.Controls.Add(rbA)
        grpPeran.Controls.Add(rbP)
        grpPeran.ForeColor = Color.Red
        grpPeran.Location = New Point(228, 23)
        grpPeran.Name = "grpPeran"
        grpPeran.Size = New Size(268, 358)
        grpPeran.TabIndex = 3
        grpPeran.TabStop = False
        grpPeran.Text = "Peran Dalam Komunitas"
        ' 
        ' dbDI
        ' 
        dbDI.AutoSize = True
        dbDI.Location = New Point(6, 311)
        dbDI.Name = "dbDI"
        dbDI.Size = New Size(186, 32)
        dbDI.TabIndex = 7
        dbDI.TabStop = True
        dbDI.Text = "Divisi Informasi"
        dbDI.UseVisualStyleBackColor = True
        ' 
        ' rbDkeungan
        ' 
        rbDkeungan.AutoSize = True
        rbDkeungan.Location = New Point(6, 273)
        rbDkeungan.Name = "rbDkeungan"
        rbDkeungan.Size = New Size(190, 32)
        rbDkeungan.TabIndex = 6
        rbDkeungan.TabStop = True
        rbDkeungan.Text = "Divisi Keuangan"
        rbDkeungan.UseVisualStyleBackColor = True
        ' 
        ' rbDkerajinan
        ' 
        rbDkerajinan.AutoSize = True
        rbDkerajinan.Location = New Point(6, 235)
        rbDkerajinan.Name = "rbDkerajinan"
        rbDkerajinan.Size = New Size(186, 32)
        rbDkerajinan.TabIndex = 5
        rbDkerajinan.TabStop = True
        rbDkerajinan.Text = "Divisi Kerajinan"
        rbDkerajinan.UseVisualStyleBackColor = True
        ' 
        ' rbDkreatif
        ' 
        rbDkreatif.AutoSize = True
        rbDkreatif.Location = New Point(6, 197)
        rbDkreatif.Name = "rbDkreatif"
        rbDkreatif.Size = New Size(161, 32)
        rbDkreatif.TabIndex = 4
        rbDkreatif.TabStop = True
        rbDkreatif.Text = "Divisi Kreatif"
        rbDkreatif.UseVisualStyleBackColor = True
        ' 
        ' rbDL
        ' 
        rbDL.AutoSize = True
        rbDL.Location = New Point(6, 156)
        rbDL.Name = "rbDL"
        rbDL.Size = New Size(187, 32)
        rbDL.TabIndex = 3
        rbDL.TabStop = True
        rbDL.Text = "Divisi Lapangan"
        rbDL.UseVisualStyleBackColor = True
        ' 
        ' rbO
        ' 
        rbO.AutoSize = True
        rbO.Location = New Point(6, 118)
        rbO.Name = "rbO"
        rbO.Size = New Size(140, 32)
        rbO.TabIndex = 2
        rbO.TabStop = True
        rbO.Text = "Obersevasi"
        rbO.UseVisualStyleBackColor = True
        ' 
        ' rbA
        ' 
        rbA.AutoSize = True
        rbA.Location = New Point(6, 78)
        rbA.Name = "rbA"
        rbA.Size = New Size(156, 32)
        rbA.TabIndex = 1
        rbA.TabStop = True
        rbA.Text = "Administrasi"
        rbA.UseVisualStyleBackColor = True
        ' 
        ' rbP
        ' 
        rbP.AutoSize = True
        rbP.Location = New Point(6, 40)
        rbP.Name = "rbP"
        rbP.Size = New Size(131, 32)
        rbP.TabIndex = 0
        rbP.TabStop = True
        rbP.Text = "Pemimpin"
        rbP.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.DarkRed
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.Location = New Point(12, 403)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(199, 65)
        btnBrowse.TabIndex = 2
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(12, 23)
        Label14.Name = "Label14"
        Label14.Size = New Size(199, 28)
        Label14.TabIndex = 1
        Label14.Text = "Foto Profil Anggota"
        ' 
        ' picProfile
        ' 
        picProfile.BackColor = Color.Black
        picProfile.BorderStyle = BorderStyle.FixedSingle
        picProfile.Location = New Point(12, 63)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(199, 318)
        picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        picProfile.TabIndex = 0
        picProfile.TabStop = False
        ' 
        ' PanelKonten
        ' 
        PanelKonten.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        PanelKonten.BorderStyle = BorderStyle.FixedSingle
        PanelKonten.Controls.Add(TabControl1)
        PanelKonten.Controls.Add(lblFormSection)
        PanelKonten.Location = New Point(286, 140)
        PanelKonten.Name = "PanelKonten"
        PanelKonten.Size = New Size(884, 604)
        PanelKonten.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Red
        Panel4.Location = New Point(0, 743)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1200, 4)
        Panel4.TabIndex = 3
        ' 
        ' FormUtamaAkatsukiCoy
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        ClientSize = New Size(1178, 749)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(PanelKonten)
        Controls.Add(PanelSidebar)
        Controls.Add(PanelHeader)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 9.0F)
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "FormUtamaAkatsukiCoy"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Akatsuki Community Card Maker"
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        CType(PicSidebarLogo, ComponentModel.ISupportInitialize).EndInit()
        PanelSidebar.ResumeLayout(False)
        PanelSidebar.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        gbJenisKelamin.ResumeLayout(False)
        gbJenisKelamin.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        grpPeran.ResumeLayout(False)
        grpPeran.PerformLayout()
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        PanelKonten.ResumeLayout(False)
        PanelKonten.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblSubJudul As Label
    Friend WithEvents PanelLineHeader As Panel
    Friend WithEvents lblSideBar As Label

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Friend WithEvents PicSidebarLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelSidebar As Panel

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnInputData As ToolStripMenuItem
    Friend WithEvents mnLihatKartu As ToolStripMenuItem
    Friend WithEvents mnSimpanData As ToolStripMenuItem
    Friend WithEvents mnBukaData As ToolStripMenuItem
    Friend WithEvents mnKeluar As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel

    Private Sub lblFormSection_Click(sender As Object, e As EventArgs) Handles lblFormSection.Click, lblFormSection.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles label8.Click, label8.Click

    End Sub

    Private Sub rbLaki_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged, CheckBox3.CheckedChanged

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged, CheckBox4.CheckedChanged

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents lblFormSection As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents gbJenisKelamin As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dptTanggalLahir As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents label8 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents label7 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents grpPeran As GroupBox
    Friend WithEvents dbDI As RadioButton
    Friend WithEvents rbDkeungan As RadioButton
    Friend WithEvents rbDkerajinan As RadioButton
    Friend WithEvents rbDkreatif As RadioButton
    Friend WithEvents rbDL As RadioButton
    Friend WithEvents rbO As RadioButton
    Friend WithEvents rbA As RadioButton
    Friend WithEvents rbP As RadioButton
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents PanelKonten As Panel
    Friend WithEvents PictureBox1 As PictureBox

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PanelSidebar_Paint(sender As Object, e As PaintEventArgs) Handles PanelSidebar.Paint

    End Sub

    Friend WithEvents Panel4 As Panel

    Private Sub FormUtamaAkatsukiCoy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
