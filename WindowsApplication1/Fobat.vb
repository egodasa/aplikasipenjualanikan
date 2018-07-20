Public Class Fkelola_obat
    Dim produk As New SqlHelper.DataQuery
    Private Sub SetFormData()
        produk.formData = New List(Of SqlHelper.Query) From {
            New SqlHelper.Query("id_obat", "DEFAULT", "Id_Obat"),
            New SqlHelper.Query("nm_obat", SqlHelper.Query.SqlString(Tnm_obat.Text), "Nama_Obat"),
            New SqlHelper.Query("stok", Tstok.Value.ToString(), "Stok"),
            New SqlHelper.Query(Nothing, Nothing, "Jenis_Obat", False),
            New SqlHelper.Query("id_sat_obat", Csatuan.SelectedValue.ToString, "Id_Sat_Obat"),
            New SqlHelper.Query(Nothing, Nothing, "Satuan", False),
            New SqlHelper.Query("hrg_obat", SqlHelper.Query.SqlString(Thrg_jual.Text), "Harga_Obat"),
            New SqlHelper.Query("hrg_beli", SqlHelper.Query.SqlString(Thrg_beli.Text), "Harga_Beli")
            }
    End Sub
    Private Sub LoadForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call setKoneksi()
        produk.table = "tbl_obat"
        produk.view = "daftar_obat"
        produk.primary_key = "id_obat"
        produk.primary_key_caption = "Id_Obat"
        DGobat.DataSource = fetchData(produk.SelectAll())
        DGobat.Columns("Id_Obat").Visible = False
        DGobat.Columns("Id_Sat_Obat").Visible = False
        DGobat.Columns(produk.primary_key_caption).Visible = False
        Call fetchComboboxData("select * from daftar_satuan", Csatuan, "Nama_Satuan", "Id_Sat")
        Csatuan.SelectedIndex = 1
        SetFormData()
        Bcancel.PerformClick()
    End Sub

    Private Sub CancelAction(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancel.Click
        Bedit.Enabled = False
        Bdelete.Enabled = False
        Bsave.Enabled = True
        Tnm_obat.Focus()
        Tnm_obat.Clear()
        Tstok.ResetText()
        Tstok.Enabled = True
        Thrg_jual.ResetText()
        Thrg_beli.ResetText()
        Csatuan.SelectedIndex = -1
    End Sub
    Private Sub CloseForm(sender As Object, e As EventArgs) Handles Bexit.Click
        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            main_form.Show()
            Me.Close()
        End If
    End Sub
    Private Sub SaveData(sender As Object, e As EventArgs) Handles Bsave.Click
        SetFormData()
        runQuery(produk.Insert())
        Call successMessage()
        DGobat.DataSource = fetchData(produk.SelectAll())
        Bcancel.PerformClick()
    End Sub
    Private Sub GetDetail(sender As Object, e As DataGridViewCellEventArgs) Handles DGobat.CellContentDoubleClick
        Bedit.Enabled = True
        Bdelete.Enabled = True
        Bsave.Enabled = False
        Tnm_obat.Text = DGobat.CurrentRow.Cells("Nama_Obat").Value
        Tstok.Value = DGobat.CurrentRow.Cells("Stok").Value
        Thrg_jual.Text = DGobat.CurrentRow.Cells("Harga_Obat").Value
        Thrg_beli.Text = DGobat.CurrentRow.Cells("Harga_Beli").Value
        Csatuan.Text = DGobat.CurrentRow.Cells("Satuan").Value
    End Sub
    Private Sub DeleteData(sender As Object, e As EventArgs) Handles Bdelete.Click
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            runQuery(produk.Delete(DGobat.CurrentRow.Cells(0).Value))
            DGobat.DataSource = fetchData(produk.SelectAll())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub EditData(sender As Object, e As EventArgs) Handles Bedit.Click
        SetFormData()
        runQuery(produk.Update(DGobat.CurrentRow.Cells(0).Value.ToString()))
        Call editMessage()
        Bcancel.PerformClick()
        DGobat.DataSource = fetchData(produk.SelectAll())
    End Sub

    Private Sub FindData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tcari.TextChanged
        If Tcari.Text.Length <> 0 Then
            DGobat.DataSource = fetchData("select * from daftar_obat where `Nama_Obat` like '%" & Tcari.Text & "%'")
        Else
            DGobat.DataSource = fetchData(produk.SelectAll())
        End If
    End Sub

End Class