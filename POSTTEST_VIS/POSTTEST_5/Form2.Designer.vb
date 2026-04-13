<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        pnlHeaderF2 = New Panel()
        Panel1 = New Panel()
        lblDetailJudul = New Label()
        picDetailFoto = New PictureBox()
        pnlDetailInfo = New Panel()
        lblDHargaJualVal = New Label()
        lblDHargaJual = New Label()
        lblDHargaBeliVal = New Label()
        lblDHargaBeli = New Label()
        lblDLokasiVal = New Label()
        lblDLokasi = New Label()
        lblDJenisVal = New Label()
        lblDJenis = New Label()
        lblDNama = New Label()
        lblDNamaVal = New Label()
        lblDKetJudul = New Label()
        txtDetailKeterangan = New TextBox()
        pnlTombolF2 = New Panel()
        btnTutupF2 = New Button()
        pdCetak = New Printing.PrintDocument()
        pdDialog = New PrintDialog()
        ppvPreview = New PrintPreviewDialog()
        Panel2 = New Panel()
        pnlHeaderF2.SuspendLayout()
        CType(picDetailFoto, ComponentModel.ISupportInitialize).BeginInit()
        pnlDetailInfo.SuspendLayout()
        pnlTombolF2.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeaderF2
        ' 
        pnlHeaderF2.BackColor = Color.FromArgb(CByte(26), CByte(74), CByte(15))
        pnlHeaderF2.Controls.Add(Panel1)
        pnlHeaderF2.Controls.Add(lblDetailJudul)
        pnlHeaderF2.Dock = DockStyle.Top
        pnlHeaderF2.Location = New Point(0, 0)
        pnlHeaderF2.Name = "pnlHeaderF2"
        pnlHeaderF2.Size = New Size(572, 52)
        pnlHeaderF2.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Lime
        Panel1.Location = New Point(0, 49)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(568, 3)
        Panel1.TabIndex = 10
        ' 
        ' lblDetailJudul
        ' 
        lblDetailJudul.BackColor = Color.Transparent
        lblDetailJudul.Dock = DockStyle.Fill
        lblDetailJudul.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDetailJudul.ForeColor = Color.White
        lblDetailJudul.Location = New Point(0, 0)
        lblDetailJudul.Name = "lblDetailJudul"
        lblDetailJudul.Size = New Size(572, 52)
        lblDetailJudul.TabIndex = 1
        lblDetailJudul.Text = "DETAIL DATA TANAMAN"
        lblDetailJudul.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picDetailFoto
        ' 
        picDetailFoto.BackColor = Color.FromArgb(CByte(10), CByte(25), CByte(6))
        picDetailFoto.BorderStyle = BorderStyle.FixedSingle
        picDetailFoto.Location = New Point(20, 64)
        picDetailFoto.Name = "picDetailFoto"
        picDetailFoto.Size = New Size(200, 201)
        picDetailFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picDetailFoto.TabIndex = 1
        picDetailFoto.TabStop = False
        ' 
        ' pnlDetailInfo
        ' 
        pnlDetailInfo.BackColor = Color.Transparent
        pnlDetailInfo.Controls.Add(lblDHargaJualVal)
        pnlDetailInfo.Controls.Add(lblDHargaJual)
        pnlDetailInfo.Controls.Add(lblDHargaBeliVal)
        pnlDetailInfo.Controls.Add(lblDHargaBeli)
        pnlDetailInfo.Controls.Add(lblDLokasiVal)
        pnlDetailInfo.Controls.Add(lblDLokasi)
        pnlDetailInfo.Controls.Add(lblDJenisVal)
        pnlDetailInfo.Controls.Add(lblDJenis)
        pnlDetailInfo.Controls.Add(lblDNama)
        pnlDetailInfo.Controls.Add(lblDNamaVal)
        pnlDetailInfo.Location = New Point(234, 64)
        pnlDetailInfo.Name = "pnlDetailInfo"
        pnlDetailInfo.Size = New Size(326, 201)
        pnlDetailInfo.TabIndex = 2
        ' 
        ' lblDHargaJualVal
        ' 
        lblDHargaJualVal.AutoSize = True
        lblDHargaJualVal.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDHargaJualVal.ForeColor = Color.FromArgb(CByte(200), CByte(230), CByte(196))
        lblDHargaJualVal.Location = New Point(167, 169)
        lblDHargaJualVal.Name = "lblDHargaJualVal"
        lblDHargaJualVal.Size = New Size(103, 21)
        lblDHargaJualVal.TabIndex = 9
        lblDHargaJualVal.Text = "(Harga Jual)"
        ' 
        ' lblDHargaJual
        ' 
        lblDHargaJual.AutoSize = True
        lblDHargaJual.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDHargaJual.ForeColor = Color.FromArgb(CByte(102), CByte(187), CByte(106))
        lblDHargaJual.Location = New Point(3, 169)
        lblDHargaJual.Name = "lblDHargaJual"
        lblDHargaJual.Size = New Size(103, 21)
        lblDHargaJual.TabIndex = 8
        lblDHargaJual.Text = "Harga Jual : "
        ' 
        ' lblDHargaBeliVal
        ' 
        lblDHargaBeliVal.AutoSize = True
        lblDHargaBeliVal.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDHargaBeliVal.ForeColor = Color.FromArgb(CByte(200), CByte(230), CByte(196))
        lblDHargaBeliVal.Location = New Point(167, 130)
        lblDHargaBeliVal.Name = "lblDHargaBeliVal"
        lblDHargaBeliVal.Size = New Size(101, 21)
        lblDHargaBeliVal.TabIndex = 7
        lblDHargaBeliVal.Text = "(Harga Beli)"
        ' 
        ' lblDHargaBeli
        ' 
        lblDHargaBeli.AutoSize = True
        lblDHargaBeli.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDHargaBeli.ForeColor = Color.FromArgb(CByte(102), CByte(187), CByte(106))
        lblDHargaBeli.Location = New Point(3, 130)
        lblDHargaBeli.Name = "lblDHargaBeli"
        lblDHargaBeli.Size = New Size(101, 21)
        lblDHargaBeli.TabIndex = 6
        lblDHargaBeli.Text = "Harga Beli : "
        ' 
        ' lblDLokasiVal
        ' 
        lblDLokasiVal.AutoSize = True
        lblDLokasiVal.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDLokasiVal.ForeColor = Color.FromArgb(CByte(200), CByte(230), CByte(196))
        lblDLokasiVal.Location = New Point(167, 88)
        lblDLokasiVal.Name = "lblDLokasiVal"
        lblDLokasiVal.Size = New Size(131, 21)
        lblDLokasiVal.TabIndex = 5
        lblDLokasiVal.Text = "(Lokasi / Lahan)"
        ' 
        ' lblDLokasi
        ' 
        lblDLokasi.AutoSize = True
        lblDLokasi.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDLokasi.ForeColor = Color.FromArgb(CByte(102), CByte(187), CByte(106))
        lblDLokasi.Location = New Point(3, 88)
        lblDLokasi.Name = "lblDLokasi"
        lblDLokasi.Size = New Size(131, 21)
        lblDLokasi.TabIndex = 4
        lblDLokasi.Text = "Lokasi / Lahan : "
        ' 
        ' lblDJenisVal
        ' 
        lblDJenisVal.AutoSize = True
        lblDJenisVal.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDJenisVal.ForeColor = Color.FromArgb(CByte(200), CByte(230), CByte(196))
        lblDJenisVal.Location = New Point(167, 47)
        lblDJenisVal.Name = "lblDJenisVal"
        lblDJenisVal.Size = New Size(134, 21)
        lblDJenisVal.TabIndex = 3
        lblDJenisVal.Text = "(Jenis Tanaman)"
        ' 
        ' lblDJenis
        ' 
        lblDJenis.AutoSize = True
        lblDJenis.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDJenis.ForeColor = Color.FromArgb(CByte(102), CByte(187), CByte(106))
        lblDJenis.Location = New Point(3, 47)
        lblDJenis.Name = "lblDJenis"
        lblDJenis.Size = New Size(134, 21)
        lblDJenis.TabIndex = 2
        lblDJenis.Text = "Jenis Tanaman : "
        ' 
        ' lblDNama
        ' 
        lblDNama.AutoSize = True
        lblDNama.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDNama.ForeColor = Color.FromArgb(CByte(102), CByte(187), CByte(106))
        lblDNama.Location = New Point(3, 9)
        lblDNama.Name = "lblDNama"
        lblDNama.Size = New Size(142, 21)
        lblDNama.TabIndex = 0
        lblDNama.Text = "Nama Tanaman : "
        ' 
        ' lblDNamaVal
        ' 
        lblDNamaVal.AutoSize = True
        lblDNamaVal.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDNamaVal.ForeColor = Color.FromArgb(CByte(220), CByte(255), CByte(215))
        lblDNamaVal.Location = New Point(167, 9)
        lblDNamaVal.Name = "lblDNamaVal"
        lblDNamaVal.Size = New Size(142, 21)
        lblDNamaVal.TabIndex = 1
        lblDNamaVal.Text = "(Nama Tanaman)"
        ' 
        ' lblDKetJudul
        ' 
        lblDKetJudul.AutoSize = True
        lblDKetJudul.BackColor = Color.Transparent
        lblDKetJudul.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDKetJudul.ForeColor = Color.FromArgb(CByte(102), CByte(187), CByte(106))
        lblDKetJudul.Location = New Point(20, 281)
        lblDKetJudul.Name = "lblDKetJudul"
        lblDKetJudul.Size = New Size(110, 21)
        lblDKetJudul.TabIndex = 3
        lblDKetJudul.Text = "Keterangan : "
        ' 
        ' txtDetailKeterangan
        ' 
        txtDetailKeterangan.BackColor = Color.FromArgb(CByte(10), CByte(26), CByte(6))
        txtDetailKeterangan.BorderStyle = BorderStyle.FixedSingle
        txtDetailKeterangan.ForeColor = Color.FromArgb(CByte(200), CByte(230), CByte(196))
        txtDetailKeterangan.Location = New Point(136, 281)
        txtDetailKeterangan.Multiline = True
        txtDetailKeterangan.Name = "txtDetailKeterangan"
        txtDetailKeterangan.ReadOnly = True
        txtDetailKeterangan.ScrollBars = ScrollBars.Vertical
        txtDetailKeterangan.Size = New Size(424, 80)
        txtDetailKeterangan.TabIndex = 4
        ' 
        ' pnlTombolF2
        ' 
        pnlTombolF2.BackColor = Color.FromArgb(CByte(14), CByte(22), CByte(10))
        pnlTombolF2.Controls.Add(btnTutupF2)
        pnlTombolF2.Dock = DockStyle.Bottom
        pnlTombolF2.Location = New Point(0, 472)
        pnlTombolF2.Name = "pnlTombolF2"
        pnlTombolF2.Size = New Size(572, 52)
        pnlTombolF2.TabIndex = 5
        ' 
        ' btnTutupF2
        ' 
        btnTutupF2.AutoSize = True
        btnTutupF2.BackColor = Color.FromArgb(CByte(60), CByte(20), CByte(20))
        btnTutupF2.Cursor = Cursors.Hand
        btnTutupF2.DialogResult = DialogResult.Cancel
        btnTutupF2.FlatAppearance.BorderColor = Color.FromArgb(CByte(180), CByte(60), CByte(60))
        btnTutupF2.FlatStyle = FlatStyle.Flat
        btnTutupF2.ForeColor = Color.FromArgb(CByte(255), CByte(180), CByte(180))
        btnTutupF2.Location = New Point(3, 12)
        btnTutupF2.Name = "btnTutupF2"
        btnTutupF2.Size = New Size(565, 37)
        btnTutupF2.TabIndex = 7
        btnTutupF2.Text = "Tutup"
        btnTutupF2.UseVisualStyleBackColor = False
        ' 
        ' pdCetak
        ' 
        pdCetak.DocumentName = "Laporan Data Tanaman"
        ' 
        ' pdDialog
        ' 
        pdDialog.UseEXDialog = True
        ' 
        ' ppvPreview
        ' 
        ppvPreview.AutoScrollMargin = New Size(0, 0)
        ppvPreview.AutoScrollMinSize = New Size(0, 0)
        ppvPreview.ClientSize = New Size(400, 300)
        ppvPreview.Enabled = True
        ppvPreview.Icon = CType(resources.GetObject("ppvPreview.Icon"), Icon)
        ppvPreview.Name = "ppvPreview"
        ppvPreview.UseAntiAlias = True
        ppvPreview.Visible = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Lime
        Panel2.Location = New Point(0, 472)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(568, 3)
        Panel2.TabIndex = 11
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(18), CByte(28), CByte(14))
        ClientSize = New Size(572, 524)
        Controls.Add(Panel2)
        Controls.Add(pnlTombolF2)
        Controls.Add(txtDetailKeterangan)
        Controls.Add(lblDKetJudul)
        Controls.Add(pnlDetailInfo)
        Controls.Add(picDetailFoto)
        Controls.Add(pnlHeaderF2)
        ForeColor = Color.FromArgb(CByte(200), CByte(230), CByte(196))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Detail Tanaman"
        TopMost = True
        pnlHeaderF2.ResumeLayout(False)
        CType(picDetailFoto, ComponentModel.ISupportInitialize).EndInit()
        pnlDetailInfo.ResumeLayout(False)
        pnlDetailInfo.PerformLayout()
        pnlTombolF2.ResumeLayout(False)
        pnlTombolF2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlHeaderF2 As Panel
    Friend WithEvents lblDetailJudul As Label
    Friend WithEvents picDetailFoto As PictureBox
    Friend WithEvents pnlDetailInfo As Panel
    Friend WithEvents lblDNama As Label
    Friend WithEvents lblDNamaVal As Label
    Friend WithEvents lblDLokasi As Label
    Friend WithEvents lblDJenisVal As Label
    Friend WithEvents lblDJenis As Label
    Friend WithEvents lblDHargaJualVal As Label
    Friend WithEvents lblDHargaJual As Label
    Friend WithEvents lblDHargaBeliVal As Label
    Friend WithEvents lblDHargaBeli As Label
    Friend WithEvents lblDLokasiVal As Label
    Friend WithEvents lblDKetJudul As Label
    Friend WithEvents txtDetailKeterangan As TextBox
    Friend WithEvents pnlTombolF2 As Panel
    Friend WithEvents btnTutupF2 As Button
    Friend WithEvents pdCetak As Printing.PrintDocument
    Friend WithEvents pdDialog As PrintDialog
    Friend WithEvents ppvPreview As PrintPreviewDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
