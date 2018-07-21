<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fpembelian_produk
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bcancel = New System.Windows.Forms.Button()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.Bsave = New System.Windows.Forms.Button()
        Me.Bdelete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ttotal_bayar = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Badd = New System.Windows.Forms.Button()
        Me.Tbayar = New System.Windows.Forms.NumericUpDown()
        Me.Tjumlah = New System.Windows.Forms.NumericUpDown()
        Me.Cproduk = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cpemasok = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGproduk = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DaftarPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Ttotal_bayar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbayar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tjumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGproduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox2.Controls.Add(Me.Bcancel)
        Me.GroupBox2.Controls.Add(Me.Bexit)
        Me.GroupBox2.Controls.Add(Me.Bsave)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 300)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(593, 49)
        Me.GroupBox2.TabIndex = 6
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
        'Bdelete
        '
        Me.Bdelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bdelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bdelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bdelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bdelete.Location = New System.Drawing.Point(460, 214)
        Me.Bdelete.Name = "Bdelete"
        Me.Bdelete.Size = New System.Drawing.Size(127, 25)
        Me.Bdelete.TabIndex = 4
        Me.Bdelete.Text = "Hapus Produk"
        Me.Bdelete.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox1.Controls.Add(Me.Ttotal_bayar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Bdelete)
        Me.GroupBox1.Controls.Add(Me.Badd)
        Me.GroupBox1.Controls.Add(Me.Tbayar)
        Me.GroupBox1.Controls.Add(Me.Tjumlah)
        Me.GroupBox1.Controls.Add(Me.Cproduk)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Cpemasok)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DGproduk)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(593, 248)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form Pembelian Produk"
        '
        'Ttotal_bayar
        '
        Me.Ttotal_bayar.Location = New System.Drawing.Point(125, 216)
        Me.Ttotal_bayar.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.Ttotal_bayar.Name = "Ttotal_bayar"
        Me.Ttotal_bayar.Size = New System.Drawing.Size(286, 23)
        Me.Ttotal_bayar.TabIndex = 24
        Me.Ttotal_bayar.ThousandsSeparator = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 15)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Total Pembayaran"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 90)
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
        Me.Badd.Location = New System.Drawing.Point(460, 86)
        Me.Badd.Name = "Badd"
        Me.Badd.Size = New System.Drawing.Size(127, 23)
        Me.Badd.TabIndex = 6
        Me.Badd.Text = "Tambah Produk"
        Me.Badd.UseVisualStyleBackColor = False
        '
        'Tbayar
        '
        Me.Tbayar.Increment = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.Tbayar.Location = New System.Drawing.Point(405, 53)
        Me.Tbayar.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Tbayar.Name = "Tbayar"
        Me.Tbayar.Size = New System.Drawing.Size(182, 23)
        Me.Tbayar.TabIndex = 21
        Me.Tbayar.ThousandsSeparator = True
        Me.Tbayar.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Tjumlah
        '
        Me.Tjumlah.Location = New System.Drawing.Point(125, 53)
        Me.Tjumlah.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Tjumlah.Name = "Tjumlah"
        Me.Tjumlah.Size = New System.Drawing.Size(157, 23)
        Me.Tjumlah.TabIndex = 20
        Me.Tjumlah.ThousandsSeparator = True
        Me.Tjumlah.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Cproduk
        '
        Me.Cproduk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Cproduk.FormattingEnabled = True
        Me.Cproduk.Items.AddRange(New Object() {"1"})
        Me.Cproduk.Location = New System.Drawing.Point(405, 24)
        Me.Cproduk.Name = "Cproduk"
        Me.Cproduk.Size = New System.Drawing.Size(182, 23)
        Me.Cproduk.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nama Produk"
        '
        'Cpemasok
        '
        Me.Cpemasok.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Cpemasok.FormattingEnabled = True
        Me.Cpemasok.Items.AddRange(New Object() {"1"})
        Me.Cpemasok.Location = New System.Drawing.Point(125, 24)
        Me.Cpemasok.Name = "Cpemasok"
        Me.Cpemasok.Size = New System.Drawing.Size(157, 23)
        Me.Cpemasok.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(309, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Total Bayar"
        '
        'DGproduk
        '
        Me.DGproduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGproduk.Location = New System.Drawing.Point(6, 115)
        Me.DGproduk.Name = "DGproduk"
        Me.DGproduk.ReadOnly = True
        Me.DGproduk.Size = New System.Drawing.Size(581, 93)
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
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Pemasok"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarPembelianToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(603, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DaftarPembelianToolStripMenuItem
        '
        Me.DaftarPembelianToolStripMenuItem.Name = "DaftarPembelianToolStripMenuItem"
        Me.DaftarPembelianToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.DaftarPembelianToolStripMenuItem.Text = "Daftar Pembelian"
        '
        'Fpembelian_produk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 358)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Fpembelian_produk"
        Me.Text = "Pembelian Produk"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Ttotal_bayar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbayar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tjumlah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGproduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Bcancel As Button
    Friend WithEvents Bdelete As Button
    Friend WithEvents Bexit As Button
    Friend WithEvents Bsave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DGproduk As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Badd As Button
    Friend WithEvents Tbayar As NumericUpDown
    Friend WithEvents Tjumlah As NumericUpDown
    Friend WithEvents Cproduk As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Cpemasok As ComboBox
    Friend WithEvents Ttotal_bayar As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DaftarPembelianToolStripMenuItem As ToolStripMenuItem
End Class
