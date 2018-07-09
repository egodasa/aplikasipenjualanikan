<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRlaporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRlaporan))
        Me.CRlaporan = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRlaporan
        '
        Me.CRlaporan.ActiveViewIndex = -1
        Me.CRlaporan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRlaporan.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRlaporan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRlaporan.Location = New System.Drawing.Point(0, 0)
        Me.CRlaporan.Name = "CRlaporan"
        Me.CRlaporan.Size = New System.Drawing.Size(840, 429)
        Me.CRlaporan.TabIndex = 0
        '
        'FRlaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 429)
        Me.Controls.Add(Me.CRlaporan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRlaporan"
        Me.Text = "Laporan"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRlaporan As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
