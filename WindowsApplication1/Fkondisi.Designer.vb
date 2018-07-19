<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fkondisi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tkondisi = New System.Windows.Forms.TextBox()
        Me.DGkondisi = New System.Windows.Forms.DataGridView()
        Me.Bsimpan = New System.Windows.Forms.Button()
        Me.Bkeluar = New System.Windows.Forms.Button()
        CType(Me.DGkondisi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kondisi bayi saat lahir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Daftar kondisi bayi saat lahir"
        '
        'Tkondisi
        '
        Me.Tkondisi.Location = New System.Drawing.Point(126, 9)
        Me.Tkondisi.Name = "Tkondisi"
        Me.Tkondisi.Size = New System.Drawing.Size(202, 20)
        Me.Tkondisi.TabIndex = 2
        '
        'DGkondisi
        '
        Me.DGkondisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGkondisi.Location = New System.Drawing.Point(12, 60)
        Me.DGkondisi.Name = "DGkondisi"
        Me.DGkondisi.Size = New System.Drawing.Size(446, 156)
        Me.DGkondisi.TabIndex = 3
        '
        'Bsimpan
        '
        Me.Bsimpan.Location = New System.Drawing.Point(334, 9)
        Me.Bsimpan.Name = "Bsimpan"
        Me.Bsimpan.Size = New System.Drawing.Size(59, 23)
        Me.Bsimpan.TabIndex = 4
        Me.Bsimpan.Text = "Simpan"
        Me.Bsimpan.UseVisualStyleBackColor = True
        '
        'Bkeluar
        '
        Me.Bkeluar.Location = New System.Drawing.Point(399, 9)
        Me.Bkeluar.Name = "Bkeluar"
        Me.Bkeluar.Size = New System.Drawing.Size(59, 23)
        Me.Bkeluar.TabIndex = 5
        Me.Bkeluar.Text = "Tutup"
        Me.Bkeluar.UseVisualStyleBackColor = True
        '
        'Fkondisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 225)
        Me.Controls.Add(Me.Bkeluar)
        Me.Controls.Add(Me.Bsimpan)
        Me.Controls.Add(Me.DGkondisi)
        Me.Controls.Add(Me.Tkondisi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Fkondisi"
        Me.Text = "Form Kondisi bayi saat lahir"
        CType(Me.DGkondisi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tkondisi As System.Windows.Forms.TextBox
    Friend WithEvents DGkondisi As System.Windows.Forms.DataGridView
    Friend WithEvents Bsimpan As System.Windows.Forms.Button
    Friend WithEvents Bkeluar As System.Windows.Forms.Button
End Class
