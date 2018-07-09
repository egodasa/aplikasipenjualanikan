<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fpembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fpembelian))
        Me.Bbatal = New System.Windows.Forms.Button()
        Me.Bsimpan = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Tharga = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Ttotal_harga = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Cpemasok = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lstok = New System.Windows.Forms.Label()
        Me.Tjumlah = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Btambah = New System.Windows.Forms.Button()
        Me.Cobat = New System.Windows.Forms.ComboBox()
        Me.Bhapus_obat = New System.Windows.Forms.Button()
        Me.DGobat_beli = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Tharga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tjumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGobat_beli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bbatal
        '
        Me.Bbatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bbatal.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bbatal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bbatal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bbatal.Location = New System.Drawing.Point(6, 328)
        Me.Bbatal.Name = "Bbatal"
        Me.Bbatal.Size = New System.Drawing.Size(203, 28)
        Me.Bbatal.TabIndex = 30
        Me.Bbatal.Text = "BATALKAN PEMBELIAN"
        Me.Bbatal.UseVisualStyleBackColor = False
        '
        'Bsimpan
        '
        Me.Bsimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bsimpan.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bsimpan.Location = New System.Drawing.Point(379, 328)
        Me.Bsimpan.Name = "Bsimpan"
        Me.Bsimpan.Size = New System.Drawing.Size(172, 28)
        Me.Bsimpan.TabIndex = 13
        Me.Bsimpan.Text = "SIMPAN PEMBELIAN"
        Me.Bsimpan.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MintCream
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(580, 24)
        Me.MenuStrip1.TabIndex = 37
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
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarPembelianToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'DaftarPembelianToolStripMenuItem
        '
        Me.DaftarPembelianToolStripMenuItem.Name = "DaftarPembelianToolStripMenuItem"
        Me.DaftarPembelianToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.DaftarPembelianToolStripMenuItem.Text = "Daftar Pembelian"
        '
        'Bexit
        '
        Me.Bexit.BackColor = System.Drawing.Color.Gray
        Me.Bexit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bexit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bexit.Location = New System.Drawing.Point(490, 408)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(85, 23)
        Me.Bexit.TabIndex = 36
        Me.Bexit.Text = "KELUAR"
        Me.Bexit.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox4.Controls.Add(Me.Tharga)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Ttotal_harga)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Bbatal)
        Me.GroupBox4.Controls.Add(Me.Cpemasok)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Lstok)
        Me.GroupBox4.Controls.Add(Me.Bsimpan)
        Me.GroupBox4.Controls.Add(Me.Tjumlah)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Btambah)
        Me.GroupBox4.Controls.Add(Me.Cobat)
        Me.GroupBox4.Controls.Add(Me.Bhapus_obat)
        Me.GroupBox4.Controls.Add(Me.DGobat_beli)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(10, 27)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(565, 375)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PEMBELIAN STOK OBAT"
        '
        'Tharga
        '
        Me.Tharga.Location = New System.Drawing.Point(363, 78)
        Me.Tharga.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.Tharga.Name = "Tharga"
        Me.Tharga.Size = New System.Drawing.Size(188, 23)
        Me.Tharga.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(318, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Harga"
        '
        'Ttotal_harga
        '
        Me.Ttotal_harga.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ttotal_harga.Location = New System.Drawing.Point(120, 289)
        Me.Ttotal_harga.Name = "Ttotal_harga"
        Me.Ttotal_harga.ReadOnly = True
        Me.Ttotal_harga.Size = New System.Drawing.Size(431, 23)
        Me.Ttotal_harga.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 288)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 15)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Total Harga"
        '
        'Cpemasok
        '
        Me.Cpemasok.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cpemasok.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cpemasok.DisplayMember = "Nama Obat"
        Me.Cpemasok.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cpemasok.FormattingEnabled = True
        Me.Cpemasok.Location = New System.Drawing.Point(120, 22)
        Me.Cpemasok.Name = "Cpemasok"
        Me.Cpemasok.Size = New System.Drawing.Size(431, 23)
        Me.Cpemasok.TabIndex = 35
        Me.Cpemasok.ValueMember = "id_obat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Nama Pemasok"
        '
        'Lstok
        '
        Me.Lstok.AutoSize = True
        Me.Lstok.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lstok.Location = New System.Drawing.Point(208, 51)
        Me.Lstok.Name = "Lstok"
        Me.Lstok.Size = New System.Drawing.Size(0, 15)
        Me.Lstok.TabIndex = 33
        '
        'Tjumlah
        '
        Me.Tjumlah.Location = New System.Drawing.Point(120, 80)
        Me.Tjumlah.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.Tjumlah.Name = "Tjumlah"
        Me.Tjumlah.Size = New System.Drawing.Size(118, 23)
        Me.Tjumlah.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 80)
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
        Me.Btambah.Location = New System.Drawing.Point(424, 125)
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
        Me.Cobat.Location = New System.Drawing.Point(120, 51)
        Me.Cobat.Name = "Cobat"
        Me.Cobat.Size = New System.Drawing.Size(431, 23)
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
        Me.Bhapus_obat.Location = New System.Drawing.Point(6, 125)
        Me.Bhapus_obat.Name = "Bhapus_obat"
        Me.Bhapus_obat.Size = New System.Drawing.Size(127, 22)
        Me.Bhapus_obat.TabIndex = 13
        Me.Bhapus_obat.Text = "HAPUS OBAT"
        Me.Bhapus_obat.UseVisualStyleBackColor = False
        '
        'DGobat_beli
        '
        Me.DGobat_beli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGobat_beli.Location = New System.Drawing.Point(6, 153)
        Me.DGobat_beli.Name = "DGobat_beli"
        Me.DGobat_beli.ReadOnly = True
        Me.DGobat_beli.Size = New System.Drawing.Size(545, 130)
        Me.DGobat_beli.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 15)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Nama Obat"
        '
        'Fpembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(580, 442)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Bexit)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fpembelian"
        Me.Text = "Pembelian Stok Obat"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Tharga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tjumlah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGobat_beli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bbatal As System.Windows.Forms.Button
    Friend WithEvents Bsimpan As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Lstok As System.Windows.Forms.Label
    Friend WithEvents Tjumlah As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Btambah As System.Windows.Forms.Button
    Friend WithEvents Cobat As System.Windows.Forms.ComboBox
    Friend WithEvents Bhapus_obat As System.Windows.Forms.Button
    Friend WithEvents DGobat_beli As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Cpemasok As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ttotal_harga As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Tharga As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DaftarPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
