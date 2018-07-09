Public Class Fpengguna
    Sub resetPengguna()
        Tusername.Clear()
        Tpassword.Clear()
        Tnm_lengkap.Clear()
        Cjenis.SelectedIndex = -1
        Bsave.Enabled = True
        Bedit.Enabled = False
        Bdelete.Enabled = False
    End Sub
    Sub getPengguna()
        DGpengguna.DataSource = fetchData("select * from tbl_pengguna")
        DGpengguna.Columns("id_pengguna").Visible = False
        DGpengguna.Columns("password").Visible = False
    End Sub
    Private Sub Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsave.Click
        runQuery("insert into tbl_pengguna(username,password,jenis,nm_lengkap) values ('" & Tusername.Text & "',md5('" & Tpassword.Text & "'),'" & Cjenis.Text & "','" & Tnm_lengkap.Text & "')")
        Call resetPengguna()
        Call getPengguna()
    End Sub

    Private Sub Fpengguna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call getPengguna()
    End Sub

    Private Sub DGpengguna_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGpengguna.CellContentDoubleClick
        Tusername.Text = DGpengguna.CurrentRow.Cells("username").Value
        Tpassword.Text = DGpengguna.CurrentRow.Cells("password").Value
        Cjenis.Text = DGpengguna.CurrentRow.Cells("jenis").Value
        Tnm_lengkap.Text = DGpengguna.CurrentRow.Cells("nm_lengkap").Value
        Bsave.Enabled = False
        Bedit.Enabled = True
        Bdelete.Enabled = True
    End Sub

    Private Sub Bcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancel.Click
        Call resetPengguna()
        Call getPengguna()
    End Sub

    Private Sub Bdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bdelete.Click
        runQuery("delete from tbl_pengguna where id_pengguna = " & DGpengguna.CurrentRow.Cells("id_pengguna").Value)
        Call resetPengguna()
        Call getPengguna()
    End Sub

    Private Sub Bedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bedit.Click
        runQuery("update tbl_pengguna set username='" & Tusername.Text & "', password=md5('" & Tpassword.Text & "'), jenis='" & Cjenis.Text & "', nm_lengkap='" & Tnm_lengkap.Text & "' where id_pengguna = " & DGpengguna.CurrentRow.Cells("id_pengguna").Value)
        Call resetPengguna()
        Call getPengguna()
    End Sub

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Fmenu.Show()
        Me.Close()
    End Sub
End Class