<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ftransaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ftransaksi))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Lstok = New System.Windows.Forms.Label()
        Me.Tjumlah = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Btambah = New System.Windows.Forms.Button()
        Me.Cobat = New System.Windows.Forms.ComboBox()
        Me.Bhapus_obat = New System.Windows.Forms.Button()
        Me.DGobat_beli = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Ttotal_harga = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.Bsimpan = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bbatal = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tkembalian = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Tdibayarkan = New System.Windows.Forms.NumericUpDown()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Lharga_obat = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Tjumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGobat_beli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tdibayarkan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox4.Controls.Add(Me.Lharga_obat)
        Me.GroupBox4.Controls.Add(Me.Lstok)
        Me.GroupBox4.Controls.Add(Me.Tjumlah)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Btambah)
        Me.GroupBox4.Controls.Add(Me.Cobat)
        Me.GroupBox4.Controls.Add(Me.Bhapus_obat)
        Me.GroupBox4.Controls.Add(Me.DGobat_beli)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(443, 244)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TRANSAKSI"
        '
        'Lstok
        '
        Me.Lstok.AutoSize = True
        Me.Lstok.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lstok.Location = New System.Drawing.Point(156, 50)
        Me.Lstok.Name = "Lstok"
        Me.Lstok.Size = New System.Drawing.Size(118, 15)
        Me.Lstok.TabIndex = 33
        Me.Lstok.Text = "                                     "
        '
        'Tjumlah
        '
        Me.Tjumlah.Location = New System.Drawing.Point(79, 48)
        Me.Tjumlah.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.Tjumlah.Name = "Tjumlah"
        Me.Tjumlah.Size = New System.Drawing.Size(57, 23)
        Me.Tjumlah.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 15)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Jumlah"
        '
        'Btambah
        '
        Me.Btambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btambah.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Btambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btambah.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btambah.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btambah.Location = New System.Drawing.Point(303, 77)
        Me.Btambah.Name = "Btambah"
        Me.Btambah.Size = New System.Drawing.Size(127, 22)
        Me.Btambah.TabIndex = 15
        Me.Btambah.Text = "TAMBAH OBAT"
        Me.Btambah.UseVisualStyleBackColor = False
        '
        'Cobat
        '
        Me.Cobat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cobat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cobat.DisplayMember = "Nama Obat"
        Me.Cobat.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cobat.FormattingEnabled = True
        Me.Cobat.Location = New System.Drawing.Point(79, 19)
        Me.Cobat.Name = "Cobat"
        Me.Cobat.Size = New System.Drawing.Size(351, 23)
        Me.Cobat.TabIndex = 14
        Me.Cobat.ValueMember = "id_obat"
        '
        'Bhapus_obat
        '
        Me.Bhapus_obat.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bhapus_obat.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bhapus_obat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bhapus_obat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bhapus_obat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bhapus_obat.Location = New System.Drawing.Point(9, 77)
        Me.Bhapus_obat.Name = "Bhapus_obat"
        Me.Bhapus_obat.Size = New System.Drawing.Size(127, 22)
        Me.Bhapus_obat.TabIndex = 13
        Me.Bhapus_obat.Text = "HAPUS OBAT"
        Me.Bhapus_obat.UseVisualStyleBackColor = False
        '
        'DGobat_beli
        '
        Me.DGobat_beli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGobat_beli.Location = New System.Drawing.Point(9, 105)
        Me.DGobat_beli.Name = "DGobat_beli"
        Me.DGobat_beli.ReadOnly = True
        Me.DGobat_beli.Size = New System.Drawing.Size(421, 130)
        Me.DGobat_beli.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 15)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Cari Obat"
        '
        'Ttotal_harga
        '
        Me.Ttotal_harga.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ttotal_harga.Location = New System.Drawing.Point(88, 25)
        Me.Ttotal_harga.Name = "Ttotal_harga"
        Me.Ttotal_harga.ReadOnly = True
        Me.Ttotal_harga.Size = New System.Drawing.Size(342, 23)
        Me.Ttotal_harga.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 15)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Total Bayar"
        '
        'Bexit
        '
        Me.Bexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bexit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bexit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bexit.Location = New System.Drawing.Point(370, 495)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(85, 23)
        Me.Bexit.TabIndex = 7
        Me.Bexit.Text = "KELUAR"
        Me.Bexit.UseVisualStyleBackColor = False
        '
        'Bsimpan
        '
        Me.Bsimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bsimpan.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bsimpan.Location = New System.Drawing.Point(258, 152)
        Me.Bsimpan.Name = "Bsimpan"
        Me.Bsimpan.Size = New System.Drawing.Size(172, 28)
        Me.Bsimpan.TabIndex = 13
        Me.Bsimpan.Text = "SIMPAN TRANSAKSI"
        Me.Bsimpan.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MintCream
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(463, 24)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarTransaksiToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'DaftarTransaksiToolStripMenuItem
        '
        Me.DaftarTransaksiToolStripMenuItem.Name = "DaftarTransaksiToolStripMenuItem"
        Me.DaftarTransaksiToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.DaftarTransaksiToolStripMenuItem.Text = "Daftar Transaksi"
        '
        'Bbatal
        '
        Me.Bbatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bbatal.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bbatal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bbatal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bbatal.Location = New System.Drawing.Point(9, 152)
        Me.Bbatal.Name = "Bbatal"
        Me.Bbatal.Size = New System.Drawing.Size(203, 28)
        Me.Bbatal.TabIndex = 30
        Me.Bbatal.Text = "BATALKAN TRANSAKSI"
        Me.Bbatal.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox1.Controls.Add(Me.Tkembalian)
        Me.GroupBox1.Controls.Add(Me.Bbatal)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Tdibayarkan)
        Me.GroupBox1.Controls.Add(Me.Bsimpan)
        Me.GroupBox1.Controls.Add(Me.Ttotal_harga)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 290)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 199)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PEMBAYARAN"
        '
        'Tkembalian
        '
        Me.Tkembalian.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tkembalian.Location = New System.Drawing.Point(88, 101)
        Me.Tkembalian.Name = "Tkembalian"
        Me.Tkembalian.ReadOnly = True
        Me.Tkembalian.Size = New System.Drawing.Size(342, 23)
        Me.Tkembalian.TabIndex = 35
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(5, 101)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(63, 15)
        Me.Label25.TabIndex = 34
        Me.Label25.Text = "Kembalian"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(208, 51)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(0, 15)
        Me.Label23.TabIndex = 33
        '
        'Tdibayarkan
        '
        Me.Tdibayarkan.Location = New System.Drawing.Point(88, 62)
        Me.Tdibayarkan.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        Me.Tdibayarkan.Name = "Tdibayarkan"
        Me.Tdibayarkan.Size = New System.Drawing.Size(342, 23)
        Me.Tdibayarkan.TabIndex = 32
        Me.Tdibayarkan.ThousandsSeparator = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(6, 64)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 15)
        Me.Label26.TabIndex = 16
        Me.Label26.Text = "Dibayar"
        '
        'Lharga_obat
        '
        Me.Lharga_obat.AutoSize = True
        Me.Lharga_obat.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lharga_obat.Location = New System.Drawing.Point(300, 50)
        Me.Lharga_obat.Name = "Lharga_obat"
        Me.Lharga_obat.Size = New System.Drawing.Size(118, 15)
        Me.Lharga_obat.TabIndex = 34
        Me.Lharga_obat.Text = "                                     "
        '
        'Ftransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(463, 523)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Bexit)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ftransaksi"
        Me.Text = "Form Transaksi"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Tjumlah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGobat_beli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tdibayarkan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Bhapus_obat As System.Windows.Forms.Button
    Friend WithEvents Bexit As System.Windows.Forms.Button
    Friend WithEvents DGobat_beli As System.Windows.Forms.DataGridView
    Friend WithEvents Bsimpan As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Cobat As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Btambah As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bbatal As System.Windows.Forms.Button
    Friend WithEvents Ttotal_harga As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Tjumlah As System.Windows.Forms.NumericUpDown
    Friend WithEvents Lstok As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Tkembalian As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Tdibayarkan As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents DaftarTransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Lharga_obat As System.Windows.Forms.Label
End Class
