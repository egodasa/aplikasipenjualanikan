Public Class Fkelola_obat
    Dim getData As String = "select * from daftar_obat"
    Sub resetForm()
        Tnm_obat.Focus()
        Tnm_obat.Clear()
        Tstok.ResetText()
        Tstok.Enabled = True
        Tstok_ubah.Minimum = 1000000000
        Tstok_ubah.ResetText()
        Cjns_obat.SelectedIndex = -1
        Thrg_obat.Clear()
        Csatuan.SelectedIndex = -1
        DGobat.DataSource = fetchData(getData)
        Call fetchComboboxData("select * from tbl_jenis_obat", Cjns_obat, "nm_jobat", "id_jobat")
        Call fetchComboboxData("select * from daftar_satuan where `Id_Jsat` = 4", Csatuan, "Nama_Satuan", "Id_Sat")
        DGobat.Columns("Id_Obat").Visible = False
        DGobat.Columns("Id_Sat_Obat").Visible = False
        DGobat.Columns("Id_Jobat").Visible = False
    End Sub
    Private Sub Fkelola_obat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call setKoneksi()
        Call resetForm()
    End Sub

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Fmenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsave.Click
        runQuery("insert into tbl_obat (nm_obat, stok, id_jobat, hrg_obat, id_sat_obat) values ('" & Tnm_obat.Text & "', " & Tstok.Value & ", " & Cjns_obat.SelectedValue & ", " & Thrg_obat.Text & "," & Csatuan.SelectedValue & ")")
        Call successMessage()
        DGobat.DataSource = fetchData(getData)
        Call resetForm()
    End Sub

    Private Sub DGobat_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGobat.CellDoubleClick
        Tnm_obat.Text = DGobat.CurrentRow.Cells("Nama_Obat").Value
        Cjns_obat.Text = DGobat.CurrentRow.Cells("Jenis_Obat").Value
        Tstok.Value = DGobat.CurrentRow.Cells("Stok").Value
        Thrg_obat.Text = DGobat.CurrentRow.Cells("Harga_Obat").Value
        Csatuan.Text = DGobat.CurrentRow.Cells("Satuan").Value
        Tstok_ubah.Minimum = Tstok.Value * -1
        Tstok.Enabled = False
        Bedit.Enabled = True
        Bcancel.Enabled = True
        Bdelete.Enabled = True
        Bsave.Enabled = False
    End Sub

    Private Sub Bcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancel.Click
        Bedit.Enabled = False
        Bcancel.Enabled = False
        Bdelete.Enabled = False
        Bsave.Enabled = True
        Call resetForm()
    End Sub

    Private Sub Bdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bdelete.Click
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            runQuery(deleteSql("tbl_obat", "id_obat", DGobat.CurrentRow.Cells("Id_Obat").Value))
            DGobat.DataSource = fetchData(getData)
            Bcancel.PerformClick()
        End If
    End Sub

    Private Sub Bedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bedit.Click
        runQuery("update tbl_obat set nm_obat = '" & Tnm_obat.Text &
                 "', id_jobat = " & Cjns_obat.SelectedValue &
                 ", hrg_obat = " & Thrg_obat.Text &
                 ", stok = " & (Tstok.Value + Tstok_ubah.Value) &
                 ", id_sat_obat = " & Csatuan.SelectedValue &
                 " where id_obat = " & DGobat.CurrentRow.Cells("Id_Obat").Value)
        Call editMessage()
        Bcancel.PerformClick()
        DGobat.DataSource = fetchData(getData)
    End Sub

    Private Sub Tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tcari.TextChanged
        If Tcari.Text.Length <> 0 Then
            DGobat.DataSource = fetchData("select * from daftar_obat where `Nama_Obat` like '%" & Tcari.Text & "%'")
        Else
            DGobat.DataSource = fetchData(getData)
        End If
    End Sub

    Private Sub Tstok_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tstok.EnabledChanged
        If Tstok.Enabled = False Then
            Tstok_ubah.Enabled = True
        Else : Tstok_ubah.Enabled = False
        End If
    End Sub

    Private Sub DGobat_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGobat.CellContentClick

    End Sub
End Class