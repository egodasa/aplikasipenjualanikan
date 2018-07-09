<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fpemasok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fpemasok))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bcancel = New System.Windows.Forms.Button()
        Me.Bdelete = New System.Windows.Forms.Button()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.Bedit = New System.Windows.Forms.Button()
        Me.Bsave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Talamat = New System.Windows.Forms.TextBox()
        Me.Tnm_pemasok = New System.Windows.Forms.TextBox()
        Me.DGpemasok = New System.Windows.Forms.DataGridView()
        Me.Tcari = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tno_telp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGpemasok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 287)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(593, 49)
        Me.GroupBox2.TabIndex = 5
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
        Me.Bcancel.Location = New System.Drawing.Point(370, 18)
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
        Me.Bdelete.Location = New System.Drawing.Point(247, 18)
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
        Me.Bexit.Location = New System.Drawing.Point(498, 18)
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
        Me.Bedit.Location = New System.Drawing.Point(137, 18)
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
        Me.Bsave.Location = New System.Drawing.Point(21, 18)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(75, 23)
        Me.Bsave.TabIndex = 1
        Me.Bsave.Text = "SIMPAN"
        Me.Bsave.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox1.Controls.Add(Me.Talamat)
        Me.GroupBox1.Controls.Add(Me.Tnm_pemasok)
        Me.GroupBox1.Controls.Add(Me.DGpemasok)
        Me.GroupBox1.Controls.Add(Me.Tcari)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Tno_telp)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(593, 269)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ENTRI DATA PEMASOK"
        '
        'Talamat
        '
        Me.Talamat.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Talamat.Location = New System.Drawing.Point(125, 53)
        Me.Talamat.Name = "Talamat"
        Me.Talamat.Size = New System.Drawing.Size(462, 23)
        Me.Talamat.TabIndex = 14
        '
        'Tnm_pemasok
        '
        Me.Tnm_pemasok.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tnm_pemasok.Location = New System.Drawing.Point(125, 24)
        Me.Tnm_pemasok.Name = "Tnm_pemasok"
        Me.Tnm_pemasok.Size = New System.Drawing.Size(462, 23)
        Me.Tnm_pemasok.TabIndex = 13
        '
        'DGpemasok
        '
        Me.DGpemasok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGpemasok.Location = New System.Drawing.Point(11, 142)
        Me.DGpemasok.Name = "DGpemasok"
        Me.DGpemasok.ReadOnly = True
        Me.DGpemasok.Size = New System.Drawing.Size(577, 115)
        Me.DGpemasok.TabIndex = 12
        '
        'Tcari
        '
        Me.Tcari.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tcari.Location = New System.Drawing.Point(125, 113)
        Me.Tcari.Name = "Tcari"
        Me.Tcari.Size = New System.Drawing.Size(462, 23)
        Me.Tcari.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Pencarian Pemasok"
        '
        'Tno_telp
        '
        Me.Tno_telp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tno_telp.Location = New System.Drawing.Point(125, 84)
        Me.Tno_telp.Name = "Tno_telp"
        Me.Tno_telp.Size = New System.Drawing.Size(462, 23)
        Me.Tno_telp.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nomor Telepon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
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
        'Fpemasok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(613, 343)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fpemasok"
        Me.Text = "Kelola Pemasok"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGpemasok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Bcancel As System.Windows.Forms.Button
    Friend WithEvents Bdelete As System.Windows.Forms.Button
    Friend WithEvents Bexit As System.Windows.Forms.Button
    Friend WithEvents Bedit As System.Windows.Forms.Button
    Friend WithEvents Bsave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Tnm_pemasok As System.Windows.Forms.TextBox
    Friend WithEvents DGpemasok As System.Windows.Forms.DataGridView
    Friend WithEvents Tcari As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Tno_telp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Talamat As System.Windows.Forms.TextBox
End Class
