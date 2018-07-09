Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FRlaporan
    Dim CR As New ReportDocument()
    Private Sub FRlaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Flaporan.tipe_laporan = "harian" Then
            CR.Load(_DIR & "laporan.rpt")
        ElseIf Flaporan.tipe_laporan = "bulanan" Then
            CR.Load(_DIR & "lap_bulanan.rpt")
        ElseIf Flaporan.tipe_laporan = "tahunan" Then
            CR.Load(_DIR & "lap_tahunan.rpt")
        ElseIf Flaporan.tipe_laporan = "pembelian" Then
            CR.Load(_DIR & "lap_pembelian.rpt")
            CR.SetParameterValue("tgl", Flaporan.Chari.Text)
            CRlaporan.SelectionFormula = "{daftar_pembelian1.Tanggal_Pembelian} = '" & Flaporan.Chari.Text & "'"
        ElseIf Flaporan.tipe_laporan = "stok" Then
            CR.Load(_DIR & "lap_stok.rpt")
        End If
        CRlaporan.ReportSource = CR
        Me.Show()
    End Sub
End Class