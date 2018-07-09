Public Class Fpemasok
    Sub getDataPemasok()
        DGpemasok.DataSource = fetchData("select * from laporan_pemasok")
        DGpemasok.Columns("id_pemasok").Visible = False
    End Sub
    Sub cariPemasok()
        DGpemasok.DataSource = fetchData("select * from laporan_pemasok where Nama_Pemasok like '%" & Tcari.Text & "%' or Alamat like '%" & Tcari.Text & "%' or Nomor_Telepon like '%" & Tcari.Text & "%'")
        DGpemasok.Columns("id_pemasok").Visible = False
    End Sub
    Sub resetPemasok()
        Tnm_pemasok.Clear()
        Talamat.Clear()
        Tno_telp.Clear()
        Bsave.Enabled = True
        Bedit.Enabled = False
        Bdelete.Enabled = False
        Call getDataPemasok()
    End Sub
    Private Sub Fpemasok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call getDataPemasok()
    End Sub

    Private Sub Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsave.Click
        runQuery("insert into tbl_pemasok (nm_pemasok, alamat, no_telpon) values ('" & Tnm_pemasok.Text & "', '" & Talamat.Text & "', '" & Tno_telp.Text & "')")
        Call resetPemasok()
        Tnm_pemasok.Focus()
    End Sub

    Private Sub DGpemasok_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGpemasok.CellContentDoubleClick
        Tnm_pemasok.Text = DGpemasok.CurrentRow.Cells("Nama_Pemasok").Value
        Talamat.Text = DGpemasok.CurrentRow.Cells("Alamat").Value
        Tno_telp.Text = DGpemasok.CurrentRow.Cells("Nomor_Telepon").Value
        Bsave.Enabled = False
        Bedit.Enabled = True
        Bdelete.Enabled = True
        Bcancel.Enabled = True
    End Sub

    Private Sub Bcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancel.Click
        Call resetPemasok()
    End Sub

    Private Sub Bdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bdelete.Click
        runQuery("delete from tbl_pemasok where id_pemasok = " & DGpemasok.CurrentRow.Cells("id_pemasok").Value.ToString)
        Call resetPemasok()
    End Sub

    Private Sub Tcari_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tcari.KeyUp
        Call cariPemasok()
    End Sub

    Private Sub Bedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bedit.Click
        runQuery("update tbl_pemasok set nm_pemasok = '" & Tnm_pemasok.Text & "',alamat = '" & Talamat.Text & "',no_telpon = '" & Tno_telp.Text & "' where id_pemasok = " & DGpemasok.CurrentRow.Cells("id_pemasok").Value.ToString)
        Call resetPemasok()
    End Sub

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Fmenu.Show()
        Me.Close()
    End Sub
End Class