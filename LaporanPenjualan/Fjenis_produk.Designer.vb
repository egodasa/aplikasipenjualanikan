<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fjenis_produk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fjenis_produk))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGjobat = New System.Windows.Forms.DataGridView()
        Me.Tnm_jenis = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bcancel = New System.Windows.Forms.Button()
        Me.Bdelete = New System.Windows.Forms.Button()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.Bedit = New System.Windows.Forms.Button()
        Me.Bsave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGjobat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox1.Controls.Add(Me.DGjobat)
        Me.GroupBox1.Controls.Add(Me.Tnm_jenis)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 226)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ENTRI DATA JENIS OBAT"
        '
        'DGjobat
        '
        Me.DGjobat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGjobat.Location = New System.Drawing.Point(6, 64)
        Me.DGjobat.Name = "DGjobat"
        Me.DGjobat.Size = New System.Drawing.Size(450, 150)
        Me.DGjobat.TabIndex = 12
        '
        'Tnm_jenis
        '
        Me.Tnm_jenis.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tnm_jenis.Location = New System.Drawing.Point(125, 27)
        Me.Tnm_jenis.Name = "Tnm_jenis"
        Me.Tnm_jenis.Size = New System.Drawing.Size(331, 23)
        Me.Tnm_jenis.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Jenis Obat"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox2.Controls.Add(Me.Bcancel)
        Me.GroupBox2.Controls.Add(Me.Bdelete)
        Me.GroupBox2.Controls.Add(Me.Bexit)
        Me.GroupBox2.Controls.Add(Me.Bedit)
        Me.GroupBox2.Controls.Add(Me.Bsave)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(465, 53)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PROSES"
        '
        'Bcancel
        '
        Me.Bcancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bcancel.Enabled = False
        Me.Bcancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bcancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bcancel.Location = New System.Drawing.Point(291, 20)
        Me.Bcancel.Name = "Bcancel"
        Me.Bcancel.Size = New System.Drawing.Size(75, 23)
        Me.Bcancel.TabIndex = 5
        Me.Bcancel.Text = "BATAL"
        Me.Bcancel.UseVisualStyleBackColor = False
        '
        'Bdelete
        '
        Me.Bdelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bdelete.Enabled = False
        Me.Bdelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bdelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bdelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bdelete.Location = New System.Drawing.Point(199, 20)
        Me.Bdelete.Name = "Bdelete"
        Me.Bdelete.Size = New System.Drawing.Size(75, 23)
        Me.Bdelete.TabIndex = 4
        Me.Bdelete.Text = "HAPUS"
        Me.Bdelete.UseVisualStyleBackColor = False
        '
        'Bexit
        '
        Me.Bexit.BackColor = System.Drawing.Color.Gray
        Me.Bexit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bexit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bexit.Location = New System.Drawing.Point(381, 20)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(75, 23)
        Me.Bexit.TabIndex = 2
        Me.Bexit.Text = "KELUAR"
        Me.Bexit.UseVisualStyleBackColor = False
        '
        'Bedit
        '
        Me.Bedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bedit.Enabled = False
        Me.Bedit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bedit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bedit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bedit.Location = New System.Drawing.Point(103, 20)
        Me.Bedit.Name = "Bedit"
        Me.Bedit.Size = New System.Drawing.Size(75, 23)
        Me.Bedit.TabIndex = 3
        Me.Bedit.Text = "UBAH"
        Me.Bedit.UseVisualStyleBackColor = False
        '
        'Bsave
        '
        Me.Bsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bsave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bsave.Location = New System.Drawing.Point(12, 20)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(75, 23)
        Me.Bsave.TabIndex = 1
        Me.Bsave.Text = "SIMPAN"
        Me.Bsave.UseVisualStyleBackColor = False
        '
        'Fjenis_obat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(487, 300)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fjenis_obat"
        Me.Text = "Daftar Jenis Obat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGjobat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGjobat As System.Windows.Forms.DataGridView
    Friend WithEvents Tnm_jenis As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Bcancel As System.Windows.Forms.Button
    Friend WithEvents Bdelete As System.Windows.Forms.Button
    Friend WithEvents Bedit As System.Windows.Forms.Button
    Friend WithEvents Bexit As System.Windows.Forms.Button
    Friend WithEvents Bsave As System.Windows.Forms.Button
End Class
