<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fdaftar_transaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fdaftar_transaksi))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tcari = New System.Windows.Forms.TextBox()
        Me.DGtransaksi = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Ltotal = New System.Windows.Forms.Label()
        Me.Ltgl_transaksi = New System.Windows.Forms.Label()
        Me.Lid_transaksi = New System.Windows.Forms.Label()
        Me.DGdetail = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGtransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Tcari)
        Me.GroupBox1.Controls.Add(Me.DGtransaksi)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 376)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Daftar Transaksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pencarian"
        '
        'Tcari
        '
        Me.Tcari.Location = New System.Drawing.Point(88, 26)
        Me.Tcari.Name = "Tcari"
        Me.Tcari.Size = New System.Drawing.Size(389, 20)
        Me.Tcari.TabIndex = 1
        '
        'DGtransaksi
        '
        Me.DGtransaksi.AllowUserToAddRows = False
        Me.DGtransaksi.AllowUserToDeleteRows = False
        Me.DGtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGtransaksi.Location = New System.Drawing.Point(13, 54)
        Me.DGtransaksi.Name = "DGtransaksi"
        Me.DGtransaksi.ReadOnly = True
        Me.DGtransaksi.Size = New System.Drawing.Size(464, 310)
        Me.DGtransaksi.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox2.Controls.Add(Me.Ltotal)
        Me.GroupBox2.Controls.Add(Me.Ltgl_transaksi)
        Me.GroupBox2.Controls.Add(Me.Lid_transaksi)
        Me.GroupBox2.Controls.Add(Me.DGdetail)
        Me.GroupBox2.Location = New System.Drawing.Point(505, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(521, 376)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Transaksi"
        '
        'Ltotal
        '
        Me.Ltotal.AutoSize = True
        Me.Ltotal.Location = New System.Drawing.Point(10, 81)
        Me.Ltotal.Name = "Ltotal"
        Me.Ltotal.Size = New System.Drawing.Size(0, 13)
        Me.Ltotal.TabIndex = 3
        '
        'Ltgl_transaksi
        '
        Me.Ltgl_transaksi.AutoSize = True
        Me.Ltgl_transaksi.Location = New System.Drawing.Point(10, 54)
        Me.Ltgl_transaksi.Name = "Ltgl_transaksi"
        Me.Ltgl_transaksi.Size = New System.Drawing.Size(0, 13)
        Me.Ltgl_transaksi.TabIndex = 2
        '
        'Lid_transaksi
        '
        Me.Lid_transaksi.AutoSize = True
        Me.Lid_transaksi.Location = New System.Drawing.Point(10, 29)
        Me.Lid_transaksi.Name = "Lid_transaksi"
        Me.Lid_transaksi.Size = New System.Drawing.Size(0, 13)
        Me.Lid_transaksi.TabIndex = 1
        '
        'DGdetail
        '
        Me.DGdetail.AllowUserToAddRows = False
        Me.DGdetail.AllowUserToDeleteRows = False
        Me.DGdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGdetail.Location = New System.Drawing.Point(13, 113)
        Me.DGdetail.Name = "DGdetail"
        Me.DGdetail.ReadOnly = True
        Me.DGdetail.Size = New System.Drawing.Size(497, 251)
        Me.DGdetail.TabIndex = 0
        '
        'Fdaftar_transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(1033, 399)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fdaftar_transaksi"
        Me.Text = "Daftar Transaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGtransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGtransaksi As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Ltgl_transaksi As System.Windows.Forms.Label
    Friend WithEvents Lid_transaksi As System.Windows.Forms.Label
    Friend WithEvents DGdetail As System.Windows.Forms.DataGridView
    Friend WithEvents Ltotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tcari As System.Windows.Forms.TextBox
End Class
