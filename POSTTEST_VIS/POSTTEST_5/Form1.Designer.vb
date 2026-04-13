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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        Panel3 = New Panel()
        lblSub = New Label()
        lblJudul = New Label()
        pnlSidebar = New Panel()
        Panel4 = New Panel()
        picDecor = New PictureBox()
        lblPetunjuk = New Label()
        lblAppDesc = New Label()
        lblAppTitle = New Label()
        picProfile = New PictureBox()
        pnlKanan = New Panel()
        pnlKonten = New Panel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        pnlStatusBar = New Panel()
        lblJumlahData = New Label()
        lblStatusInfo = New Label()
        dgvTanaman = New DataGridView()
        pnlSearchBar = New Panel()
        btnResetCari = New Button()
        btnCari = New Button()
        cbKolomCari = New ComboBox()
        txtCari = New TextBox()
        lblCari = New Label()
        pnlAtas = New Panel()
        pnlFotoKanan = New Panel()
        txtPathFoto = New TextBox()
        btnBrowseFoto = New Button()
        picFotoTanaman = New PictureBox()
        lblFotoJudul = New Label()
        TabControl1 = New TabControl()
        tabPage1 = New TabPage()
        txtKeterangan = New TextBox()
        txtLokasiLahan = New TextBox()
        cboJenisTanaman = New ComboBox()
        lblKeterangan = New Label()
        lblLokasiLahan = New Label()
        lblJenisTanaman = New Label()
        lblNamaTanaman = New Label()
        txtNamaTanaman = New TextBox()
        TabPage2 = New TabPage()
        txtKeuntungan = New TextBox()
        txtHargaJual = New TextBox()
        txtHargaBeli = New TextBox()
        lblSelisihHarga = New Label()
        lblHargaJual = New Label()
        lblHargaTanaman = New Label()
        MenuStrip1 = New MenuStrip()
        mnuTambah = New ToolStripMenuItem()
        mnuSimpan = New ToolStripMenuItem()
        mnuHapus = New ToolStripMenuItem()
        mnuBersihkan = New ToolStripMenuItem()
        mnuDetail = New ToolStripMenuItem()
        mnuKeluar = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ofdFotoTanaman = New OpenFileDialog()
        epValidasi = New ErrorProvider(components)
        ttInfo = New ToolTip(components)
        colID = New DataGridViewTextBoxColumn()
        colNama = New DataGridViewTextBoxColumn()
        colJenis = New DataGridViewTextBoxColumn()
        colLokasi = New DataGridViewTextBoxColumn()
        colHargaBeli = New DataGridViewTextBoxColumn()
        colHargaJual = New DataGridViewTextBoxColumn()
        colKeuntungan = New DataGridViewTextBoxColumn()
        pnlHeader.SuspendLayout()
        pnlSidebar.SuspendLayout()
        CType(picDecor, ComponentModel.ISupportInitialize).BeginInit()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        pnlKanan.SuspendLayout()
        pnlKonten.SuspendLayout()
        pnlStatusBar.SuspendLayout()
        CType(dgvTanaman, ComponentModel.ISupportInitialize).BeginInit()
        pnlSearchBar.SuspendLayout()
        pnlAtas.SuspendLayout()
        pnlFotoKanan.SuspendLayout()
        CType(picFotoTanaman, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        tabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        MenuStrip1.SuspendLayout()
        CType(epValidasi, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(26), CByte(74), CByte(15))
        pnlHeader.Controls.Add(Panel3)
        pnlHeader.Controls.Add(lblSub)
        pnlHeader.Controls.Add(lblJudul)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(958, 95)
        pnlHeader.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Lime
        Panel3.Location = New Point(0, 92)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(972, 10)
        Panel3.TabIndex = 4
        ' 
        ' lblSub
        ' 
        lblSub.BackColor = Color.Transparent
        lblSub.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSub.ForeColor = Color.FromArgb(CByte(168), CByte(213), CByte(162))
        lblSub.Location = New Point(227, 63)
        lblSub.Name = "lblSub"
        lblSub.Size = New Size(509, 25)
        lblSub.TabIndex = 1
        lblSub.Text = "Kelola Data Inventaris Tanaman Anda"
        lblSub.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblJudul
        ' 
        lblJudul.BackColor = Color.Transparent
        lblJudul.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(140, 9)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(700, 54)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Sistem Manajemen Data Tanaman"
        lblJudul.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(14), CByte(36), CByte(9))
        pnlSidebar.Controls.Add(Panel4)
        pnlSidebar.Controls.Add(picDecor)
        pnlSidebar.Controls.Add(lblPetunjuk)
        pnlSidebar.Controls.Add(lblAppDesc)
        pnlSidebar.Controls.Add(lblAppTitle)
        pnlSidebar.Controls.Add(picProfile)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 95)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Padding = New Padding(8, 10, 8, 10)
        pnlSidebar.Size = New Size(165, 529)
        pnlSidebar.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Lime
        Panel4.Location = New Point(162, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(3, 528)
        Panel4.TabIndex = 3
        ' 
        ' picDecor
        ' 
        picDecor.BackColor = Color.Transparent
        picDecor.Cursor = Cursors.Hand
        picDecor.Image = My.Resources.Resources.flat_design_flower_pixel_art_illustration_23_2149279888__1_
        picDecor.Location = New Point(15, 391)
        picDecor.Name = "picDecor"
        picDecor.Size = New Size(135, 125)
        picDecor.SizeMode = PictureBoxSizeMode.StretchImage
        picDecor.TabIndex = 5
        picDecor.TabStop = False
        ' 
        ' lblPetunjuk
        ' 
        lblPetunjuk.BackColor = Color.Transparent
        lblPetunjuk.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPetunjuk.ForeColor = Color.FromArgb(CByte(120), CByte(170), CByte(112))
        lblPetunjuk.Location = New Point(10, 264)
        lblPetunjuk.Name = "lblPetunjuk"
        lblPetunjuk.Size = New Size(145, 113)
        lblPetunjuk.TabIndex = 4
        lblPetunjuk.Text = "Isi Form Data Tanaman Lalu Klik Simpan. Pilih Baris Tabel Untuk Edit Atau Hapus Data "
        lblPetunjuk.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAppDesc
        ' 
        lblAppDesc.BackColor = Color.Transparent
        lblAppDesc.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAppDesc.ForeColor = Color.FromArgb(CByte(136), CByte(187), CByte(128))
        lblAppDesc.Location = New Point(10, 212)
        lblAppDesc.Name = "lblAppDesc"
        lblAppDesc.Size = New Size(145, 52)
        lblAppDesc.TabIndex = 3
        lblAppDesc.Text = "Data Tanaman • Harga • Lokasi"
        lblAppDesc.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAppTitle
        ' 
        lblAppTitle.BackColor = Color.Transparent
        lblAppTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAppTitle.ForeColor = Color.White
        lblAppTitle.Location = New Point(10, 145)
        lblAppTitle.Name = "lblAppTitle"
        lblAppTitle.Size = New Size(145, 58)
        lblAppTitle.TabIndex = 2
        lblAppTitle.Text = "PLANT MANAGER"
        lblAppTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picProfile
        ' 
        picProfile.BackColor = Color.Transparent
        picProfile.Cursor = Cursors.Hand
        picProfile.Image = My.Resources.Resources.flat_design_flower_pixel_art_illustration_23_2149293691__1_
        picProfile.Location = New Point(15, 12)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(135, 125)
        picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        picProfile.TabIndex = 2
        picProfile.TabStop = False
        ' 
        ' pnlKanan
        ' 
        pnlKanan.BackColor = Color.FromArgb(CByte(18), CByte(22), CByte(16))
        pnlKanan.Controls.Add(pnlKonten)
        pnlKanan.Controls.Add(MenuStrip1)
        pnlKanan.Dock = DockStyle.Fill
        pnlKanan.Location = New Point(165, 95)
        pnlKanan.Name = "pnlKanan"
        pnlKanan.Size = New Size(793, 529)
        pnlKanan.TabIndex = 2
        ' 
        ' pnlKonten
        ' 
        pnlKonten.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlKonten.Controls.Add(Panel1)
        pnlKonten.Controls.Add(Panel2)
        pnlKonten.Controls.Add(pnlStatusBar)
        pnlKonten.Controls.Add(dgvTanaman)
        pnlKonten.Controls.Add(pnlSearchBar)
        pnlKonten.Controls.Add(pnlAtas)
        pnlKonten.Location = New Point(0, 33)
        pnlKonten.Name = "pnlKonten"
        pnlKonten.Padding = New Padding(10, 8, 10, 8)
        pnlKonten.Size = New Size(793, 496)
        pnlKonten.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Lime
        Panel1.Location = New Point(0, 264)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(793, 3)
        Panel1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Lime
        Panel2.Location = New Point(0, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(793, 3)
        Panel2.TabIndex = 3
        ' 
        ' pnlStatusBar
        ' 
        pnlStatusBar.BackColor = Color.FromArgb(CByte(10), CByte(20), CByte(8))
        pnlStatusBar.Controls.Add(lblJumlahData)
        pnlStatusBar.Controls.Add(lblStatusInfo)
        pnlStatusBar.Dock = DockStyle.Bottom
        pnlStatusBar.Location = New Point(10, 455)
        pnlStatusBar.Name = "pnlStatusBar"
        pnlStatusBar.Padding = New Padding(6, 0, 6, 0)
        pnlStatusBar.Size = New Size(773, 33)
        pnlStatusBar.TabIndex = 2
        ' 
        ' lblJumlahData
        ' 
        lblJumlahData.BackColor = Color.Transparent
        lblJumlahData.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJumlahData.ForeColor = Color.FromArgb(CByte(136), CByte(187), CByte(128))
        lblJumlahData.Location = New Point(657, 3)
        lblJumlahData.Name = "lblJumlahData"
        lblJumlahData.Size = New Size(113, 22)
        lblJumlahData.TabIndex = 1
        lblJumlahData.Text = "Total Data : 0"
        ' 
        ' lblStatusInfo
        ' 
        lblStatusInfo.BackColor = Color.Transparent
        lblStatusInfo.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatusInfo.ForeColor = Color.FromArgb(CByte(136), CByte(187), CByte(128))
        lblStatusInfo.Location = New Point(4, 3)
        lblStatusInfo.Name = "lblStatusInfo"
        lblStatusInfo.Size = New Size(300, 22)
        lblStatusInfo.TabIndex = 0
        lblStatusInfo.Text = "Status : Siap"
        ' 
        ' dgvTanaman
        ' 
        dgvTanaman.AllowUserToAddRows = False
        dgvTanaman.AllowUserToDeleteRows = False
        dgvTanaman.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(22), CByte(38), CByte(16))
        dgvTanaman.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvTanaman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTanaman.BackgroundColor = Color.FromArgb(CByte(14), CByte(22), CByte(10))
        dgvTanaman.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(26), CByte(74), CByte(15))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvTanaman.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvTanaman.ColumnHeadersHeight = 28
        dgvTanaman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvTanaman.Columns.AddRange(New DataGridViewColumn() {colID, colNama, colJenis, colLokasi, colHargaBeli, colHargaJual, colKeuntungan})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(18), CByte(30), CByte(14))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(200), CByte(230), CByte(196))
        DataGridViewCellStyle3.Padding = New Padding(4, 0, 4, 0)
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(40), CByte(100), CByte(30))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvTanaman.DefaultCellStyle = DataGridViewCellStyle3
        dgvTanaman.Dock = DockStyle.Fill
        dgvTanaman.GridColor = Color.FromArgb(CByte(40), CByte(70), CByte(30))
        dgvTanaman.Location = New Point(10, 307)
        dgvTanaman.MultiSelect = False
        dgvTanaman.Name = "dgvTanaman"
        dgvTanaman.ReadOnly = True
        dgvTanaman.RowHeadersVisible = False
        dgvTanaman.RowHeadersWidth = 62
        dgvTanaman.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTanaman.Size = New Size(773, 181)
        dgvTanaman.TabIndex = 0
        ' 
        ' pnlSearchBar
        ' 
        pnlSearchBar.BackColor = Color.FromArgb(CByte(14), CByte(22), CByte(10))
        pnlSearchBar.Controls.Add(btnResetCari)
        pnlSearchBar.Controls.Add(btnCari)
        pnlSearchBar.Controls.Add(cbKolomCari)
        pnlSearchBar.Controls.Add(txtCari)
        pnlSearchBar.Controls.Add(lblCari)
        pnlSearchBar.Dock = DockStyle.Top
        pnlSearchBar.Location = New Point(10, 271)
        pnlSearchBar.Name = "pnlSearchBar"
        pnlSearchBar.Padding = New Padding(6, 4, 6, 4)
        pnlSearchBar.Size = New Size(773, 36)
        pnlSearchBar.TabIndex = 1
        ' 
        ' btnResetCari
        ' 
        btnResetCari.BackColor = Color.FromArgb(CByte(60), CByte(30), CByte(10))
        btnResetCari.Cursor = Cursors.Hand
        btnResetCari.FlatAppearance.BorderColor = Color.FromArgb(CByte(160), CByte(100), CByte(50))
        btnResetCari.FlatStyle = FlatStyle.Flat
        btnResetCari.ForeColor = Color.FromArgb(CByte(220), CByte(180), CByte(140))
        btnResetCari.Location = New Point(655, 2)
        btnResetCari.Name = "btnResetCari"
        btnResetCari.Size = New Size(115, 34)
        btnResetCari.TabIndex = 3
        btnResetCari.Text = "Reset"
        btnResetCari.UseVisualStyleBackColor = False
        ' 
        ' btnCari
        ' 
        btnCari.BackColor = Color.FromArgb(CByte(26), CByte(74), CByte(15))
        btnCari.Cursor = Cursors.Hand
        btnCari.FlatAppearance.BorderColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnCari.FlatStyle = FlatStyle.Flat
        btnCari.Location = New Point(536, 1)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(115, 34)
        btnCari.TabIndex = 2
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = False
        ' 
        ' cbKolomCari
        ' 
        cbKolomCari.BackColor = Color.FromArgb(CByte(10), CByte(26), CByte(6))
        cbKolomCari.DropDownStyle = ComboBoxStyle.DropDownList
        cbKolomCari.FlatStyle = FlatStyle.Flat
        cbKolomCari.ForeColor = Color.FromArgb(CByte(200), CByte(230), CByte(196))
        cbKolomCari.FormattingEnabled = True
        cbKolomCari.Items.AddRange(New Object() {"- Semua Kolom", "- Nama Tanaman", "- Jenis Tanaman", "- Lokasi / Lahan"})
        cbKolomCari.Location = New Point(322, 1)
        cbKolomCari.Name = "cbKolomCari"
        cbKolomCari.Size = New Size(198, 33)
        cbKolomCari.TabIndex = 1
        ' 
        ' txtCari
        ' 
        txtCari.BackColor = Color.FromArgb(CByte(10), CByte(26), CByte(6))
        txtCari.BorderStyle = BorderStyle.FixedSingle
        txtCari.ForeColor = Color.FromArgb(CByte(200), CByte(230), CByte(196))
        txtCari.Location = New Point(118, 1)
        txtCari.MaxLength = 100
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(198, 31)
        txtCari.TabIndex = 0
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.BackColor = Color.Transparent
        lblCari.ForeColor = Color.FromArgb(CByte(136), CByte(187), CByte(128))
        lblCari.Location = New Point(19, 7)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(93, 25)
        lblCari.TabIndex = 2
        lblCari.Text = "Cari Data :"
        ' 
        ' pnlAtas
        ' 
        pnlAtas.BackColor = Color.Transparent
        pnlAtas.Controls.Add(pnlFotoKanan)
        pnlAtas.Controls.Add(TabControl1)
        pnlAtas.Dock = DockStyle.Top
        pnlAtas.Location = New Point(10, 8)
        pnlAtas.Name = "pnlAtas"
        pnlAtas.Padding = New Padding(0, 0, 0, 6)
        pnlAtas.Size = New Size(773, 263)
        pnlAtas.TabIndex = 0
        ' 
        ' pnlFotoKanan
        ' 
        pnlFotoKanan.Controls.Add(txtPathFoto)
        pnlFotoKanan.Controls.Add(btnBrowseFoto)
        pnlFotoKanan.Controls.Add(picFotoTanaman)
        pnlFotoKanan.Controls.Add(lblFotoJudul)
        pnlFotoKanan.Location = New Point(530, 0)
        pnlFotoKanan.Name = "pnlFotoKanan"
        pnlFotoKanan.Size = New Size(243, 254)
        pnlFotoKanan.TabIndex = 1
        ' 
        ' txtPathFoto
        ' 
        txtPathFoto.BackColor = Color.FromArgb(CByte(10), CByte(26), CByte(6))
        txtPathFoto.BorderStyle = BorderStyle.FixedSingle
        txtPathFoto.ForeColor = Color.FromArgb(CByte(200), CByte(230), CByte(196))
        txtPathFoto.Location = New Point(6, 213)
        txtPathFoto.Name = "txtPathFoto"
        txtPathFoto.ReadOnly = True
        txtPathFoto.Size = New Size(112, 31)
        txtPathFoto.TabIndex = 1
        ' 
        ' btnBrowseFoto
        ' 
        btnBrowseFoto.BackColor = Color.FromArgb(CByte(26), CByte(74), CByte(15))
        btnBrowseFoto.Cursor = Cursors.Hand
        btnBrowseFoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnBrowseFoto.FlatStyle = FlatStyle.Flat
        btnBrowseFoto.Location = New Point(121, 211)
        btnBrowseFoto.Name = "btnBrowseFoto"
        btnBrowseFoto.Size = New Size(115, 35)
        btnBrowseFoto.TabIndex = 0
        btnBrowseFoto.Text = "Browse Foto..."
        btnBrowseFoto.UseVisualStyleBackColor = False
        ' 
        ' picFotoTanaman
        ' 
        picFotoTanaman.BackColor = Color.FromArgb(CByte(10), CByte(25), CByte(6))
        picFotoTanaman.BorderStyle = BorderStyle.FixedSingle
        picFotoTanaman.Cursor = Cursors.Hand
        picFotoTanaman.Location = New Point(6, 27)
        picFotoTanaman.Name = "picFotoTanaman"
        picFotoTanaman.Size = New Size(230, 180)
        picFotoTanaman.SizeMode = PictureBoxSizeMode.StretchImage
        picFotoTanaman.TabIndex = 1
        picFotoTanaman.TabStop = False
        ' 
        ' lblFotoJudul
        ' 
        lblFotoJudul.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFotoJudul.ForeColor = Color.FromArgb(CByte(102), CByte(187), CByte(106))
        lblFotoJudul.Location = New Point(0, 0)
        lblFotoJudul.Name = "lblFotoJudul"
        lblFotoJudul.Size = New Size(240, 24)
        lblFotoJudul.TabIndex = 0
        lblFotoJudul.Text = "Foto Tanaman"
        lblFotoJudul.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(520, 254)
        TabControl1.TabIndex = 0
        ' 
        ' tabPage1
        ' 
        tabPage1.BackColor = Color.FromArgb(CByte(18), CByte(28), CByte(14))
        tabPage1.Controls.Add(txtKeterangan)
        tabPage1.Controls.Add(txtLokasiLahan)
        tabPage1.Controls.Add(cboJenisTanaman)
        tabPage1.Controls.Add(lblKeterangan)
        tabPage1.Controls.Add(lblLokasiLahan)
        tabPage1.Controls.Add(lblJenisTanaman)
        tabPage1.Controls.Add(lblNamaTanaman)
        tabPage1.Controls.Add(txtNamaTanaman)
        tabPage1.Location = New Point(4, 34)
        tabPage1.Name = "tabPage1"
        tabPage1.Padding = New Padding(3)
        tabPage1.Size = New Size(512, 216)
        tabPage1.TabIndex = 0
        tabPage1.Text = "Data Tanaman"
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.BackColor = Color.FromArgb(CByte(10), CByte(26), CByte(6))
        txtKeterangan.BorderStyle = BorderStyle.FixedSingle
        txtKeterangan.ForeColor = Color.FromArgb(CByte(200), CByte(230), CByte(196))
        txtKeterangan.Location = New Point(190, 175)
        txtKeterangan.MaxLength = 300
        txtKeterangan.Multiline = True
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.ScrollBars = ScrollBars.Vertical
        txtKeterangan.Size = New Size(316, 31)
        txtKeterangan.TabIndex = 3
        ' 
        ' txtLokasiLahan
        ' 
        txtLokasiLahan.BackColor = Color.FromArgb(CByte(10), CByte(26), CByte(6))
        txtLokasiLahan.BorderStyle = BorderStyle.FixedSingle
        txtLokasiLahan.ForeColor = Color.FromArgb(CByte(200), CByte(230), CByte(196))
        txtLokasiLahan.Location = New Point(190, 126)
        txtLokasiLahan.MaxLength = 150
        txtLokasiLahan.Name = "txtLokasiLahan"
        txtLokasiLahan.Size = New Size(316, 31)
        txtLokasiLahan.TabIndex = 2
        ' 
        ' cboJenisTanaman
        ' 
        cboJenisTanaman.BackColor = Color.FromArgb(CByte(10), CByte(26), CByte(6))
        cboJenisTanaman.DropDownStyle = ComboBoxStyle.DropDownList
        cboJenisTanaman.FlatStyle = FlatStyle.Flat
        cboJenisTanaman.ForeColor = Color.FromArgb(CByte(200), CByte(230), CByte(196))
        cboJenisTanaman.FormattingEnabled = True
        cboJenisTanaman.Items.AddRange(New Object() {"- Tanaman Hias", "- Tanaman Obat", "- Tanaman Buah", "- Tanaman Sayur", "- Sukulen / Kaktus", "- Tanaman Air", "- Bonsai", "- Tanaman Pangan"})
        cboJenisTanaman.Location = New Point(190, 70)
        cboJenisTanaman.Name = "cboJenisTanaman"
        cboJenisTanaman.Size = New Size(316, 33)
        cboJenisTanaman.TabIndex = 1
        ' 
        ' lblKeterangan
        ' 
        lblKeterangan.AutoSize = True
        lblKeterangan.ForeColor = Color.FromArgb(CByte(136), CByte(187), CByte(128))
        lblKeterangan.Location = New Point(15, 177)
        lblKeterangan.Name = "lblKeterangan"
        lblKeterangan.Size = New Size(101, 25)
        lblKeterangan.TabIndex = 4
        lblKeterangan.Text = "Keterangan"
        ' 
        ' lblLokasiLahan
        ' 
        lblLokasiLahan.AutoSize = True
        lblLokasiLahan.ForeColor = Color.FromArgb(CByte(136), CByte(187), CByte(128))
        lblLokasiLahan.Location = New Point(15, 128)
        lblLokasiLahan.Name = "lblLokasiLahan"
        lblLokasiLahan.Size = New Size(112, 25)
        lblLokasiLahan.TabIndex = 3
        lblLokasiLahan.Text = "Lokasi Lahan"
        ' 
        ' lblJenisTanaman
        ' 
        lblJenisTanaman.AutoSize = True
        lblJenisTanaman.ForeColor = Color.FromArgb(CByte(136), CByte(187), CByte(128))
        lblJenisTanaman.Location = New Point(15, 73)
        lblJenisTanaman.Name = "lblJenisTanaman"
        lblJenisTanaman.Size = New Size(124, 25)
        lblJenisTanaman.TabIndex = 2
        lblJenisTanaman.Text = "Jenis Tanaman"
        ' 
        ' lblNamaTanaman
        ' 
        lblNamaTanaman.AutoSize = True
        lblNamaTanaman.ForeColor = Color.FromArgb(CByte(136), CByte(197), CByte(128))
        lblNamaTanaman.Location = New Point(15, 20)
        lblNamaTanaman.Name = "lblNamaTanaman"
        lblNamaTanaman.Size = New Size(134, 25)
        lblNamaTanaman.TabIndex = 1
        lblNamaTanaman.Text = "Nama Tanaman"
        lblNamaTanaman.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtNamaTanaman
        ' 
        txtNamaTanaman.BackColor = Color.FromArgb(CByte(10), CByte(26), CByte(6))
        txtNamaTanaman.BorderStyle = BorderStyle.FixedSingle
        txtNamaTanaman.ForeColor = Color.FromArgb(CByte(200), CByte(230), CByte(196))
        txtNamaTanaman.Location = New Point(190, 18)
        txtNamaTanaman.MaxLength = 100
        txtNamaTanaman.Name = "txtNamaTanaman"
        txtNamaTanaman.Size = New Size(316, 31)
        txtNamaTanaman.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(18), CByte(28), CByte(14))
        TabPage2.Controls.Add(txtKeuntungan)
        TabPage2.Controls.Add(txtHargaJual)
        TabPage2.Controls.Add(txtHargaBeli)
        TabPage2.Controls.Add(lblSelisihHarga)
        TabPage2.Controls.Add(lblHargaJual)
        TabPage2.Controls.Add(lblHargaTanaman)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(512, 216)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Harga Tanaman"
        ' 
        ' txtKeuntungan
        ' 
        txtKeuntungan.BackColor = Color.FromArgb(CByte(10), CByte(26), CByte(6))
        txtKeuntungan.BorderStyle = BorderStyle.FixedSingle
        txtKeuntungan.ForeColor = Color.FromArgb(CByte(200), CByte(230), CByte(196))
        txtKeuntungan.Location = New Point(183, 150)
        txtKeuntungan.MaxLength = 100
        txtKeuntungan.Name = "txtKeuntungan"
        txtKeuntungan.Size = New Size(323, 31)
        txtKeuntungan.TabIndex = 5
        ' 
        ' txtHargaJual
        ' 
        txtHargaJual.BackColor = Color.FromArgb(CByte(10), CByte(26), CByte(6))
        txtHargaJual.BorderStyle = BorderStyle.FixedSingle
        txtHargaJual.ForeColor = Color.FromArgb(CByte(200), CByte(230), CByte(196))
        txtHargaJual.Location = New Point(183, 86)
        txtHargaJual.MaxLength = 100
        txtHargaJual.Name = "txtHargaJual"
        txtHargaJual.Size = New Size(323, 31)
        txtHargaJual.TabIndex = 4
        ' 
        ' txtHargaBeli
        ' 
        txtHargaBeli.BackColor = Color.FromArgb(CByte(10), CByte(26), CByte(6))
        txtHargaBeli.BorderStyle = BorderStyle.FixedSingle
        txtHargaBeli.ForeColor = Color.FromArgb(CByte(200), CByte(230), CByte(196))
        txtHargaBeli.Location = New Point(183, 20)
        txtHargaBeli.MaxLength = 100
        txtHargaBeli.Name = "txtHargaBeli"
        txtHargaBeli.Size = New Size(323, 31)
        txtHargaBeli.TabIndex = 3
        ' 
        ' lblSelisihHarga
        ' 
        lblSelisihHarga.AutoSize = True
        lblSelisihHarga.BackColor = Color.Transparent
        lblSelisihHarga.ForeColor = Color.FromArgb(CByte(136), CByte(197), CByte(128))
        lblSelisihHarga.Location = New Point(15, 150)
        lblSelisihHarga.Name = "lblSelisihHarga"
        lblSelisihHarga.Size = New Size(134, 25)
        lblSelisihHarga.TabIndex = 2
        lblSelisihHarga.Text = "Kentungan (Rp)"
        lblSelisihHarga.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblHargaJual
        ' 
        lblHargaJual.AutoSize = True
        lblHargaJual.BackColor = Color.Transparent
        lblHargaJual.ForeColor = Color.FromArgb(CByte(136), CByte(197), CByte(128))
        lblHargaJual.Location = New Point(15, 88)
        lblHargaJual.Name = "lblHargaJual"
        lblHargaJual.Size = New Size(131, 25)
        lblHargaJual.TabIndex = 1
        lblHargaJual.Text = "Harga Jual (Rp)"
        lblHargaJual.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblHargaTanaman
        ' 
        lblHargaTanaman.AutoSize = True
        lblHargaTanaman.BackColor = Color.Transparent
        lblHargaTanaman.ForeColor = Color.FromArgb(CByte(136), CByte(197), CByte(128))
        lblHargaTanaman.Location = New Point(15, 20)
        lblHargaTanaman.Name = "lblHargaTanaman"
        lblHargaTanaman.Size = New Size(129, 25)
        lblHargaTanaman.TabIndex = 0
        lblHargaTanaman.Text = "Harga Beli (Rp)"
        lblHargaTanaman.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(26), CByte(74), CByte(15))
        MenuStrip1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuTambah, mnuSimpan, mnuHapus, mnuBersihkan, mnuDetail, mnuKeluar, ToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(793, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuTambah
        ' 
        mnuTambah.ForeColor = Color.White
        mnuTambah.Name = "mnuTambah"
        mnuTambah.Size = New Size(132, 29)
        mnuTambah.Text = "Tambah Data"
        ' 
        ' mnuSimpan
        ' 
        mnuSimpan.ForeColor = Color.White
        mnuSimpan.Name = "mnuSimpan"
        mnuSimpan.Size = New Size(88, 29)
        mnuSimpan.Text = "Simpan"
        ' 
        ' mnuHapus
        ' 
        mnuHapus.ForeColor = Color.White
        mnuHapus.Name = "mnuHapus"
        mnuHapus.Size = New Size(79, 29)
        mnuHapus.Text = "Hapus"
        ' 
        ' mnuBersihkan
        ' 
        mnuBersihkan.ForeColor = Color.White
        mnuBersihkan.Name = "mnuBersihkan"
        mnuBersihkan.Size = New Size(103, 29)
        mnuBersihkan.Text = "Bersihkan"
        ' 
        ' mnuDetail
        ' 
        mnuDetail.ForeColor = Color.White
        mnuDetail.Name = "mnuDetail"
        mnuDetail.Size = New Size(73, 29)
        mnuDetail.Text = "Detail"
        ' 
        ' mnuKeluar
        ' 
        mnuKeluar.ForeColor = Color.White
        mnuKeluar.Name = "mnuKeluar"
        mnuKeluar.Size = New Size(76, 29)
        mnuKeluar.Text = "Keluar"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(16, 29)
        ' 
        ' ofdFotoTanaman
        ' 
        ofdFotoTanaman.FileName = "OpenFileDialog1"
        ofdFotoTanaman.RestoreDirectory = True
        ofdFotoTanaman.Title = "Pilih Foto Tanaman"
        ' 
        ' epValidasi
        ' 
        epValidasi.ContainerControl = Me
        ' 
        ' ttInfo
        ' 
        ttInfo.ShowAlways = True
        ' 
        ' colID
        ' 
        colID.DataPropertyName = "idTanaman"
        colID.HeaderText = "ID"
        colID.MinimumWidth = 8
        colID.Name = "colID"
        colID.ReadOnly = True
        colID.Visible = False
        ' 
        ' colNama
        ' 
        colNama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colNama.DataPropertyName = "namaTanaman"
        colNama.FillWeight = 25F
        colNama.HeaderText = "NamaTanaman"
        colNama.MinimumWidth = 8
        colNama.Name = "colNama"
        colNama.ReadOnly = True
        colNama.Visible = False
        ' 
        ' colJenis
        ' 
        colJenis.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colJenis.DataPropertyName = "jenisTanaman"
        colJenis.FillWeight = 18F
        colJenis.HeaderText = "Jenis"
        colJenis.MinimumWidth = 8
        colJenis.Name = "colJenis"
        colJenis.ReadOnly = True
        ' 
        ' colLokasi
        ' 
        colLokasi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colLokasi.DataPropertyName = "lokasiLahan"
        colLokasi.FillWeight = 22F
        colLokasi.HeaderText = "Lokasi/Lahan"
        colLokasi.MinimumWidth = 8
        colLokasi.Name = "colLokasi"
        colLokasi.ReadOnly = True
        ' 
        ' colHargaBeli
        ' 
        colHargaBeli.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colHargaBeli.DataPropertyName = "hargaBeli"
        colHargaBeli.FillWeight = 15F
        colHargaBeli.HeaderText = "Harga Beli"
        colHargaBeli.MinimumWidth = 8
        colHargaBeli.Name = "colHargaBeli"
        colHargaBeli.ReadOnly = True
        ' 
        ' colHargaJual
        ' 
        colHargaJual.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colHargaJual.DataPropertyName = "hargaJual"
        colHargaJual.FillWeight = 15F
        colHargaJual.HeaderText = "Harga Jual"
        colHargaJual.MinimumWidth = 8
        colHargaJual.Name = "colHargaJual"
        colHargaJual.ReadOnly = True
        ' 
        ' colKeuntungan
        ' 
        colKeuntungan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colKeuntungan.DataPropertyName = "keuntungan"
        colKeuntungan.FillWeight = 15F
        colKeuntungan.HeaderText = "Keuntungan"
        colKeuntungan.MinimumWidth = 8
        colKeuntungan.Name = "colKeuntungan"
        colKeuntungan.ReadOnly = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(18), CByte(28), CByte(14))
        ClientSize = New Size(958, 624)
        Controls.Add(pnlKanan)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(200), CByte(230), CByte(196))
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimumSize = New Size(893, 613)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Manajemen Data Tanaman"
        pnlHeader.ResumeLayout(False)
        pnlSidebar.ResumeLayout(False)
        CType(picDecor, ComponentModel.ISupportInitialize).EndInit()
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        pnlKanan.ResumeLayout(False)
        pnlKanan.PerformLayout()
        pnlKonten.ResumeLayout(False)
        pnlStatusBar.ResumeLayout(False)
        CType(dgvTanaman, ComponentModel.ISupportInitialize).EndInit()
        pnlSearchBar.ResumeLayout(False)
        pnlSearchBar.PerformLayout()
        pnlAtas.ResumeLayout(False)
        pnlFotoKanan.ResumeLayout(False)
        pnlFotoKanan.PerformLayout()
        CType(picFotoTanaman, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        tabPage1.ResumeLayout(False)
        tabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(epValidasi, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblSub As Label
    Friend WithEvents lblJudul As Label

    Private Sub lblJudul_Click(sender As Object, e As EventArgs) Handles lblJudul.Click

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents lblAppTitle As Label
    Friend WithEvents lblAppDesc As Label
    Friend WithEvents lblPetunjuk As Label
    Friend WithEvents picDecor As PictureBox
    Friend WithEvents pnlKanan As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents pnlKonten As Panel
    Friend WithEvents mnuTambah As ToolStripMenuItem
    Friend WithEvents mnuSimpan As ToolStripMenuItem
    Friend WithEvents mnuHapus As ToolStripMenuItem
    Friend WithEvents mnuBersihkan As ToolStripMenuItem
    Friend WithEvents mnuDetail As ToolStripMenuItem
    Friend WithEvents mnuKeluar As ToolStripMenuItem
    Friend WithEvents pnlAtas As Panel

    Private Sub pnlAtas_Paint(sender As Object, e As PaintEventArgs) Handles pnlAtas.Paint

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtNamaTanaman As TextBox
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents lblLokasiLahan As Label
    Friend WithEvents lblJenisTanaman As Label
    Friend WithEvents lblNamaTanaman As Label
    Friend WithEvents cboJenisTanaman As ComboBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents txtLokasiLahan As TextBox
    Friend WithEvents lblHargaTanaman As Label

    Private Sub tabPage1_Click(sender As Object, e As EventArgs) Handles tabPage1.Click

    End Sub

    Friend WithEvents lblSelisihHarga As Label
    Friend WithEvents lblHargaJual As Label
    Friend WithEvents txtHargaBeli As TextBox
    Friend WithEvents txtKeuntungan As TextBox
    Friend WithEvents txtHargaJual As TextBox

    Private Sub pnlKonten_Paint(sender As Object, e As PaintEventArgs) Handles pnlKonten.Paint

    End Sub

    Friend WithEvents pnlFotoKanan As Panel
    Friend WithEvents picFotoTanaman As PictureBox
    Friend WithEvents lblFotoJudul As Label
    Friend WithEvents btnBrowseFoto As Button
    Friend WithEvents pnlSearchBar As Panel
    Friend WithEvents lblCari As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents cbKolomCari As ComboBox
    Friend WithEvents btnCari As Button
    Friend WithEvents btnResetCari As Button
    Friend WithEvents dgvTanaman As DataGridView
    Friend WithEvents pnlStatusBar As Panel
    Friend WithEvents lblJumlahData As Label
    Friend WithEvents lblStatusInfo As Label
    Friend WithEvents ofdFotoTanaman As OpenFileDialog
    Friend WithEvents epValidasi As ErrorProvider
    Friend WithEvents ttInfo As ToolTip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtPathFoto As TextBox
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colNama As DataGridViewTextBoxColumn
    Friend WithEvents colJenis As DataGridViewTextBoxColumn
    Friend WithEvents colLokasi As DataGridViewTextBoxColumn
    Friend WithEvents colHargaBeli As DataGridViewTextBoxColumn
    Friend WithEvents colHargaJual As DataGridViewTextBoxColumn
    Friend WithEvents colKeuntungan As DataGridViewTextBoxColumn
End Class
