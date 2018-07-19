Public Class Fdatar_pembelian

    Private Sub Fdatar_pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGtransaksi.DataSource = fetchData("select * from daftar_pembelian")
    End Sub

    Private Sub DGtransaksi_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGtransaksi.CellContentDoubleClick
        Lid_transaksi.Text = "ID Pembelian : " & DGtransaksi.CurrentRow.Cells("Id_Pembelian").Value
        Ltgl_transaksi.Text = "Tanggal Pembelian : " & DGtransaksi.CurrentRow.Cells("Tanggal_Pembelian").Value
        Ltotal.Text = "Total Harga : " & Format(DGtransaksi.CurrentRow.Cells("Total_Harga").Value, "Rp,   ##,##0")
        DGdetail.DataSource = fetchData("select * from laporan_detail_pembelian where Id_Pembelian = '" & DGtransaksi.CurrentRow.Cells("Id_Pembelian").Value & "'")
        DGdetail.Columns("id_pemasok").Visible = False
        DGdetail.Columns("id_detail").Visible = False
        DGdetail.Columns("id_obat").Visible = False
        DGdetail.Columns("id_pembelian").Visible = False
    End Sub

    Private Sub Tcari_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tcari.KeyUp
        If Tcari.TextLength > 0 Then
            DGtransaksi.DataSource = fetchData("select * from daftar_pembelian where Tanggal_Pembelian like '%" & Tcari.Text & "%' or Id_Pembelian like '%" & Tcari.Text & "%'")
        Else
            DGtransaksi.DataSource = fetchData("select * from daftar_pembelian")
        End If
    End Sub
End Class