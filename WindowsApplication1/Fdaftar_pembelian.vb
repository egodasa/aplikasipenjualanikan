Public Class Fdaftar_pembelian

    Private Sub Fdatar_pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGtransaksi.DataSource = FetchData("select * from daftar_pembelian")
    End Sub

    Private Sub DGtransaksi_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGtransaksi.CellContentDoubleClick
        Lid_transaksi.Text = "ID Pembelian : " & DGtransaksi.CurrentRow.Cells("Id_Pembelian").Value
        Ltgl_transaksi.Text = "Tanggal Pembelian : " & DGtransaksi.CurrentRow.Cells("Tanggal_Pembelian").Value
        Ltotal.Text = "Total Harga : " & Format(DGtransaksi.CurrentRow.Cells("total_harga").Value, "Rp,   ##,##0")
        DGdetail.DataSource = FetchData("select * from laporan_detail_pembelian where Id_Pembelian = '" & DGtransaksi.CurrentRow.Cells("Id_Pembelian").Value & "'")
        DGdetail.Columns("id_pemasok").Visible = False
        DGdetail.Columns("id_produk").Visible = False
        DGdetail.Columns("id_dpembelian").Visible = False
        DGdetail.Columns("id_pembelian").Visible = False
        DGdetail.Columns("tgl_pembelian").Visible = False
    End Sub

    Private Sub Tcari_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tcari.KeyUp
        If Tcari.TextLength > 0 Then
            DGtransaksi.DataSource = FetchData("select * from daftar_pembelian where Tanggal_Pembelian like '%" & Tcari.Text & "%' or Id_Pembelian like '%" & Tcari.Text & "%'")
        Else
            DGtransaksi.DataSource = FetchData("select * from daftar_pembelian")
        End If
    End Sub
End Class