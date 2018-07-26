<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fpenjualan_produk
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fpenjualan_produk))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ttotal_bayar = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Badd = New System.Windows.Forms.Button()
        Me.Tharga_jual = New System.Windows.Forms.NumericUpDown()
        Me.Tjumlah = New System.Windows.Forms.NumericUpDown()
        Me.Cproduk = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Charga_jual = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGproduk = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bcancel = New System.Windows.Forms.Button()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.Bsave = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DaftarPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarSatuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAksi = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Mhapus = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Ttotal_bayar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tharga_jual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tjumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGproduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuAksi.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox1.Controls.Add(Me.Ttotal_bayar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Badd)
        Me.GroupBox1.Controls.Add(Me.Tharga_jual)
        Me.GroupBox1.Controls.Add(Me.Tjumlah)
        Me.GroupBox1.Controls.Add(Me.Cproduk)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Charga_jual)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DGproduk)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(593, 298)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORM PENJUALAN PRODUK"
        '
        'Ttotal_bayar
        '
        Me.Ttotal_bayar.Location = New System.Drawing.Point(125, 262)
        Me.Ttotal_bayar.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.Ttotal_bayar.Name = "Ttotal_bayar"
        Me.Ttotal_bayar.Size = New System.Drawing.Size(454, 23)
        Me.Ttotal_bayar.TabIndex = 24
        Me.Ttotal_bayar.ThousandsSeparator = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 15)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Total Pembayaran"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Produk yang Dibeli"
        '
        'Badd
        '
        Me.Badd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Badd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Badd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Badd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Badd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Badd.Location = New System.Drawing.Point(452, 116)
        Me.Badd.Name = "Badd"
        Me.Badd.Size = New System.Drawing.Size(127, 23)
        Me.Badd.TabIndex = 6
        Me.Badd.Text = "Tambah Produk"
        Me.Badd.UseVisualStyleBackColor = False
        '
        'Tharga_jual
        '
        Me.Tharga_jual.DecimalPlaces = 2
        Me.Tharga_jual.Increment = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.Tharga_jual.Location = New System.Drawing.Point(405, 53)
        Me.Tharga_jual.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Tharga_jual.Name = "Tharga_jual"
        Me.Tharga_jual.Size = New System.Drawing.Size(174, 23)
        Me.Tharga_jual.TabIndex = 21
        Me.Tharga_jual.ThousandsSeparator = True
        Me.Tharga_jual.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Tjumlah
        '
        Me.Tjumlah.Location = New System.Drawing.Point(125, 53)
        Me.Tjumlah.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Tjumlah.Name = "Tjumlah"
        Me.Tjumlah.Size = New System.Drawing.Size(157, 23)
        Me.Tjumlah.TabIndex = 20
        Me.Tjumlah.ThousandsSeparator = True
        '
        'Cproduk
        '
        Me.Cproduk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Cproduk.FormattingEnabled = True
        Me.Cproduk.Items.AddRange(New Object() {"1"})
        Me.Cproduk.Location = New System.Drawing.Point(125, 19)
        Me.Cproduk.Name = "Cproduk"
        Me.Cproduk.Size = New System.Drawing.Size(454, 23)
        Me.Cproduk.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nama Produk"
        '
        'Charga_jual
        '
        Me.Charga_jual.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Charga_jual.FormattingEnabled = True
        Me.Charga_jual.Items.AddRange(New Object() {"1"})
        Me.Charga_jual.Location = New System.Drawing.Point(125, 87)
        Me.Charga_jual.Name = "Charga_jual"
        Me.Charga_jual.Size = New System.Drawing.Size(454, 23)
        Me.Charga_jual.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(336, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Harga Jual"
        '
        'DGproduk
        '
        Me.DGproduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGproduk.Location = New System.Drawing.Point(11, 163)
        Me.DGproduk.Name = "DGproduk"
        Me.DGproduk.ReadOnly = True
        Me.DGproduk.Size = New System.Drawing.Size(568, 93)
        Me.DGproduk.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah Beli"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Harga Beli Produk"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox2.Controls.Add(Me.Bcancel)
        Me.GroupBox2.Controls.Add(Me.Bexit)
        Me.GroupBox2.Controls.Add(Me.Bsave)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 331)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(593, 49)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PROSES"
        '
        'Bcancel
        '
        Me.Bcancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bcancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bcancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bcancel.Location = New System.Drawing.Point(206, 18)
        Me.Bcancel.Name = "Bcancel"
        Me.Bcancel.Size = New System.Drawing.Size(183, 23)
        Me.Bcancel.TabIndex = 5
        Me.Bcancel.Text = "BATALKAN PEMBELIAN"
        Me.Bcancel.UseVisualStyleBackColor = False
        '
        'Bexit
        '
        Me.Bexit.BackColor = System.Drawing.Color.Gray
        Me.Bexit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bexit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bexit.Location = New System.Drawing.Point(512, 18)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(75, 23)
        Me.Bexit.TabIndex = 2
        Me.Bexit.Text = "KELUAR"
        Me.Bexit.UseVisualStyleBackColor = False
        '
        'Bsave
        '
        Me.Bsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bsave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bsave.Location = New System.Drawing.Point(21, 18)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(160, 23)
        Me.Bsave.TabIndex = 1
        Me.Bsave.Text = "SIMPAN PEMBELIAN"
        Me.Bsave.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Khaki
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarPembelianToolStripMenuItem, Me.DaftarProdukToolStripMenuItem, Me.DaftarSatuanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(617, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DaftarPembelianToolStripMenuItem
        '
        Me.DaftarPembelianToolStripMenuItem.Name = "DaftarPembelianToolStripMenuItem"
        Me.DaftarPembelianToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.DaftarPembelianToolStripMenuItem.Text = "Daftar Penjualan"
        '
        'DaftarProdukToolStripMenuItem
        '
        Me.DaftarProdukToolStripMenuItem.Name = "DaftarProdukToolStripMenuItem"
        Me.DaftarProdukToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.DaftarProdukToolStripMenuItem.Text = "Daftar Produk"
        '
        'DaftarSatuanToolStripMenuItem
        '
        Me.DaftarSatuanToolStripMenuItem.Name = "DaftarSatuanToolStripMenuItem"
        Me.DaftarSatuanToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.DaftarSatuanToolStripMenuItem.Text = "Daftar Satuan"
        '
        'MenuAksi
        '
        Me.MenuAksi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mhapus})
        Me.MenuAksi.Name = "MenuAksi"
        Me.MenuAksi.Size = New System.Drawing.Size(109, 26)
        '
        'Mhapus
        '
        Me.Mhapus.Image = CType(resources.GetObject("Mhapus.Image"), System.Drawing.Image)
        Me.Mhapus.Name = "Mhapus"
        Me.Mhapus.Size = New System.Drawing.Size(108, 22)
        Me.Mhapus.Text = "Hapus"
        '
        'Fpenjualan_produk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(617, 392)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fpenjualan_produk"
        Me.Text = "Form Penjualan Produk"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Ttotal_bayar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tharga_jual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tjumlah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGproduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuAksi.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Ttotal_bayar As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Badd As Button
    Friend WithEvents Tharga_jual As NumericUpDown
    Friend WithEvents Tjumlah As NumericUpDown
    Friend WithEvents Cproduk As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Charga_jual As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DGproduk As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Bcancel As Button
    Friend WithEvents Bexit As Button
    Friend WithEvents Bsave As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DaftarPembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuAksi As ContextMenuStrip
    Friend WithEvents Mhapus As ToolStripMenuItem
    Friend WithEvents DaftarProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarSatuanToolStripMenuItem As ToolStripMenuItem
End Class
