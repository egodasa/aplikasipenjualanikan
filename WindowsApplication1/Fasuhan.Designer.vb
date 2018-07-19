<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fasuhan
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
        Me.Bkeluar = New System.Windows.Forms.Button()
        Me.Bsimpan = New System.Windows.Forms.Button()
        Me.Tasuhan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Bkeluar
        '
        Me.Bkeluar.Location = New System.Drawing.Point(398, 12)
        Me.Bkeluar.Name = "Bkeluar"
        Me.Bkeluar.Size = New System.Drawing.Size(59, 23)
        Me.Bkeluar.TabIndex = 11
        Me.Bkeluar.Text = "Tutup"
        Me.Bkeluar.UseVisualStyleBackColor = True
        '
        'Bsimpan
        '
        Me.Bsimpan.Location = New System.Drawing.Point(333, 12)
        Me.Bsimpan.Name = "Bsimpan"
        Me.Bsimpan.Size = New System.Drawing.Size(59, 23)
        Me.Bsimpan.TabIndex = 10
        Me.Bsimpan.Text = "Simpan"
        Me.Bsimpan.UseVisualStyleBackColor = True
        '
        'Tasuhan
        '
        Me.Tasuhan.Location = New System.Drawing.Point(125, 12)
        Me.Tasuhan.Name = "Tasuhan"
        Me.Tasuhan.Size = New System.Drawing.Size(202, 20)
        Me.Tasuhan.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Daftar asuhan pada bayi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Asuhan pada bayi"
        '
        'Fasuhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 228)
        Me.Controls.Add(Me.Bkeluar)
        Me.Controls.Add(Me.Bsimpan)
        Me.Controls.Add(Me.Tasuhan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Fasuhan"
        Me.Text = "Form asuhan pada bayi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bkeluar As System.Windows.Forms.Button
    Friend WithEvents Bsimpan As System.Windows.Forms.Button
    Friend WithEvents Tasuhan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
