Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Flaporan1
    Public CR As New ReportDocument()
    Public tipe_laporan As String
    Private Sub Flaporan1_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        If tipe_laporan = "penjualan" Then
            CRlaporan.SelectionFormula = "{tbl_transaksi1.tgl_transaksi} in Date(" & Flaporan.penjualan_awal.Value.ToString("yyyy,M,d") & ") to Date(" & Flaporan.penjualan_akhir.Value.ToString("yyyy,M,d") & ")"
        ElseIf tipe_laporan = "pembelian" Then
            CR.Load("laporan/Pembelian.rpt")
            CRlaporan.SelectionFormula = "{tbl_pembelian1.tgl_pembelian} in Date(" & Flaporan.pembelian_awal.Value.ToString("yyyy,M,d") & ") to Date(" & Flaporan.pembelian_akhir.Value.ToString("yyyy,M,d") & ")"
        ElseIf tipe_laporan = "laba" Then
            CR.Load("laporan/LabaRugi.rpt")
            CRlaporan.SelectionFormula = "{laporan_laba_rugi1.tgl_jual} in Date(" & Flaporan.laba_awal.Value.ToString("yyyy,M,d") & ") to Date(" & Flaporan.laba_akhir.Value.ToString("yyyy,M,d") & ")"
        ElseIf tipe_laporan = "produk" Then
            CR.Load("laporan/Produk.rpt")
        End If
        CRlaporan.ReportSource = CR
    End Sub
End Class