Public Class Fdaftar_transaksi

    Private Sub Fdaftar_transaksi_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        DGtransaksi.DataSource = FetchData("select * from daftar_transaksi")
    End Sub

    Private Sub DGtransaksi_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGtransaksi.CellContentDoubleClick
        Lid_transaksi.Text = "ID Transaksi : " & DGtransaksi.CurrentRow.Cells("Id_Transaksi").Value
        Ltgl_transaksi.Text = "Tanggal Transaksi : " & DGtransaksi.CurrentRow.Cells("Tanggal_Transaksi").Value
        Ltotal.Text = "Total Harga : " & Format(DGtransaksi.CurrentRow.Cells("Total_Harga").Value, "Rp,   ##,##0")
        DGdetail.DataSource = FetchData("select * from laporan_detail_transaksi where Id_Transaksi = '" & DGtransaksi.CurrentRow.Cells("Id_Transaksi").Value & "'")
        DGdetail.Columns("Id_Transaksi").Visible = False
        DGdetail.Columns("id_dtransaksi").Visible = False
        DGdetail.Columns("id_dpembelian").Visible = False
        DGdetail.Columns("Id_Produk").Visible = False
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tcari.KeyUp
        If Tcari.TextLength > 0 Then
            DGtransaksi.DataSource = FetchData("select * from daftar_transaksi where Tanggal_Transaksi like '%" & Tcari.Text & "%' or Id_Transaksi like '%" & Tcari.Text & "%'")
        Else
            DGtransaksi.DataSource = FetchData("select * from daftar_transaksi")
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class