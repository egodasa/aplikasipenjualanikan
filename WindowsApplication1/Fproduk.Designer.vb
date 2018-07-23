<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fkelola_produk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fkelola_produk))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Thrg_produk = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tstok = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Csatuan = New System.Windows.Forms.ComboBox()
        Me.Tnm_produk = New System.Windows.Forms.TextBox()
        Me.DGproduk = New System.Windows.Forms.DataGridView()
        Me.Tcari = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Bsave = New System.Windows.Forms.Button()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bcancel = New System.Windows.Forms.Button()
        Me.Bedit = New System.Windows.Forms.Button()
        Me.MenuAksi = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Medit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mhapus = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Thrg_produk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tstok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGproduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.MenuAksi.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox1.Controls.Add(Me.Thrg_produk)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Tstok)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Csatuan)
        Me.GroupBox1.Controls.Add(Me.Tnm_produk)
        Me.GroupBox1.Controls.Add(Me.DGproduk)
        Me.GroupBox1.Controls.Add(Me.Tcari)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(593, 306)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "KELOLA DATA PRODUK"
        '
        'Thrg_produk
        '
        Me.Thrg_produk.DecimalPlaces = 2
        Me.Thrg_produk.Location = New System.Drawing.Point(125, 82)
        Me.Thrg_produk.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.Thrg_produk.Name = "Thrg_produk"
        Me.Thrg_produk.Size = New System.Drawing.Size(450, 23)
        Me.Thrg_produk.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Harga Jual"
        '
        'Tstok
        '
        Me.Tstok.Location = New System.Drawing.Point(125, 53)
        Me.Tstok.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.Tstok.Name = "Tstok"
        Me.Tstok.Size = New System.Drawing.Size(120, 23)
        Me.Tstok.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(278, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Satuan"
        '
        'Csatuan
        '
        Me.Csatuan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Csatuan.FormattingEnabled = True
        Me.Csatuan.Items.AddRange(New Object() {"q"})
        Me.Csatuan.Location = New System.Drawing.Point(343, 53)
        Me.Csatuan.Name = "Csatuan"
        Me.Csatuan.Size = New System.Drawing.Size(121, 23)
        Me.Csatuan.TabIndex = 14
        '
        'Tnm_produk
        '
        Me.Tnm_produk.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tnm_produk.Location = New System.Drawing.Point(125, 24)
        Me.Tnm_produk.Name = "Tnm_produk"
        Me.Tnm_produk.Size = New System.Drawing.Size(450, 23)
        Me.Tnm_produk.TabIndex = 13
        '
        'DGproduk
        '
        Me.DGproduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGproduk.Location = New System.Drawing.Point(16, 173)
        Me.DGproduk.Name = "DGproduk"
        Me.DGproduk.ReadOnly = True
        Me.DGproduk.Size = New System.Drawing.Size(559, 119)
        Me.DGproduk.TabIndex = 12
        '
        'Tcari
        '
        Me.Tcari.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tcari.Location = New System.Drawing.Point(125, 138)
        Me.Tcari.Name = "Tcari"
        Me.Tcari.Size = New System.Drawing.Size(450, 23)
        Me.Tcari.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Pencarian Produk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stok Produk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Produk"
        '
        'Bsave
        '
        Me.Bsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bsave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bsave.Location = New System.Drawing.Point(9, 18)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(75, 23)
        Me.Bsave.TabIndex = 1
        Me.Bsave.Text = "SIMPAN"
        Me.Bsave.UseVisualStyleBackColor = False
        '
        'Bexit
        '
        Me.Bexit.BackColor = System.Drawing.Color.Gray
        Me.Bexit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bexit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bexit.Location = New System.Drawing.Point(9, 129)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(75, 23)
        Me.Bexit.TabIndex = 2
        Me.Bexit.Text = "KELUAR"
        Me.Bexit.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox2.Controls.Add(Me.Bcancel)
        Me.GroupBox2.Controls.Add(Me.Bexit)
        Me.GroupBox2.Controls.Add(Me.Bedit)
        Me.GroupBox2.Controls.Add(Me.Bsave)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(611, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(95, 167)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "AKSI"
        '
        'Bcancel
        '
        Me.Bcancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bcancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bcancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bcancel.Location = New System.Drawing.Point(9, 91)
        Me.Bcancel.Name = "Bcancel"
        Me.Bcancel.Size = New System.Drawing.Size(75, 23)
        Me.Bcancel.TabIndex = 5
        Me.Bcancel.Text = "BATAL"
        Me.Bcancel.UseVisualStyleBackColor = False
        '
        'Bedit
        '
        Me.Bedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bedit.Enabled = False
        Me.Bedit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bedit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bedit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bedit.Location = New System.Drawing.Point(9, 47)
        Me.Bedit.Name = "Bedit"
        Me.Bedit.Size = New System.Drawing.Size(75, 23)
        Me.Bedit.TabIndex = 3
        Me.Bedit.Text = "UBAH"
        Me.Bedit.UseVisualStyleBackColor = False
        '
        'MenuAksi
        '
        Me.MenuAksi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Medit, Me.Mhapus})
        Me.MenuAksi.Name = "MenuAksi"
        Me.MenuAksi.Size = New System.Drawing.Size(109, 48)
        '
        'Medit
        '
        Me.Medit.Image = CType(resources.GetObject("Medit.Image"), System.Drawing.Image)
        Me.Medit.Name = "Medit"
        Me.Medit.Size = New System.Drawing.Size(108, 22)
        Me.Medit.Text = "Edit"
        '
        'Mhapus
        '
        Me.Mhapus.Image = CType(resources.GetObject("Mhapus.Image"), System.Drawing.Image)
        Me.Mhapus.Name = "Mhapus"
        Me.Mhapus.Size = New System.Drawing.Size(108, 22)
        Me.Mhapus.Text = "Hapus"
        '
        'Fkelola_produk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(717, 330)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fkelola_produk"
        Me.Text = "Kelola Produk"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Thrg_produk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tstok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGproduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuAksi.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGproduk As System.Windows.Forms.DataGridView
    Friend WithEvents Tcari As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Bsave As System.Windows.Forms.Button
    Friend WithEvents Bexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Tnm_produk As System.Windows.Forms.TextBox
    Friend WithEvents Bcancel As System.Windows.Forms.Button
    Friend WithEvents Bedit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Csatuan As System.Windows.Forms.ComboBox
    Friend WithEvents Tstok As System.Windows.Forms.NumericUpDown
    Friend WithEvents MenuAksi As ContextMenuStrip
    Friend WithEvents Medit As ToolStripMenuItem
    Friend WithEvents Mhapus As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Thrg_produk As NumericUpDown
End Class
