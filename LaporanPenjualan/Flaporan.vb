Public Class Flaporan
    Public tipe_laporan As String
    Private Sub Flaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call fetchComboboxData("select Tanggal_Pembelian from daftar_pembelian order by Tanggal_Pembelian desc", Chari, "Tanggal_Pembelian", "Tanggal_pembelian")
        Chari.SelectedIndex = -1
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        tipe_laporan = "harian"
        FRlaporan.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tipe_laporan = "bulanan"
        FRlaporan.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tipe_laporan = "tahunan"
        FRlaporan.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        tipe_laporan = "pembelian"
        FRlaporan.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        tipe_laporan = "stok"
        FRlaporan.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Flogin.Show()
        Me.Close()
    End Sub
End Class