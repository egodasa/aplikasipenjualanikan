Public Class Fkelola_produk
    Dim produk As New SqlHelper.DataQuery
    Private Sub SetFormData()
        produk.formData = New List(Of SqlHelper.Query) From {
            New SqlHelper.Query("id_produk", "DEFAULT", "Id_Produk"),
            New SqlHelper.Query("nm_produk", SqlHelper.Query.SqlString(Tnm_produk.Text), "Nama_Produk"),
            New SqlHelper.Query("stok", Tstok.Value.ToString(), "Stok"),
            New SqlHelper.Query("id_sat_produk", Csatuan.SelectedValue.ToString, "Id_Sat_Produk"),
            New SqlHelper.Query(Nothing, Nothing, "Satuan", False)
            }
    End Sub
    Private Sub LoadForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call setKoneksi()
        Call fetchComboboxData("select * from daftar_satuan", Csatuan, "Nama_Satuan", "Id_Sat")
        produk.table = "tbl_produk"
        produk.view = "daftar_produk"
        produk.primary_key = "id_produk"
        produk.primary_key_caption = "Id_Produk"
        DGproduk.DataSource = fetchData(produk.SelectAll())
        DGproduk.Columns("Id_Produk").Visible = False
        DGproduk.Columns("Id_Sat_Produk").Visible = False
        DGproduk.Columns(produk.primary_key_caption).Visible = False
        SetFormData()
        Bcancel.PerformClick()
    End Sub

    Private Sub CancelAction(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancel.Click
        Bedit.Enabled = False
        Bdelete.Enabled = False
        Bsave.Enabled = True
        Tnm_produk.Focus()
        Tnm_produk.Clear()
        Tstok.ResetText()
        Tstok.Enabled = True
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
        DGproduk.DataSource = fetchData(produk.SelectAll())
        Bcancel.PerformClick()
    End Sub
    Private Sub GetDetail(sender As Object, e As DataGridViewCellEventArgs) Handles DGproduk.CellContentDoubleClick
        Bedit.Enabled = True
        Bdelete.Enabled = True
        Bsave.Enabled = False
        Tnm_produk.Text = DGproduk.CurrentRow.Cells("Nama_Produk").Value
        Tstok.Value = DGproduk.CurrentRow.Cells("Stok").Value
        Csatuan.Text = DGproduk.CurrentRow.Cells("Satuan").Value
    End Sub
    Private Sub DeleteData(sender As Object, e As EventArgs) Handles Bdelete.Click
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            runQuery(produk.Delete(DGproduk.CurrentRow.Cells(0).Value))
            DGproduk.DataSource = fetchData(produk.SelectAll())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub EditData(sender As Object, e As EventArgs) Handles Bedit.Click
        SetFormData()
        runQuery(produk.Update(DGproduk.CurrentRow.Cells(0).Value.ToString()))
        Call editMessage()
        Bcancel.PerformClick()
        DGproduk.DataSource = fetchData(produk.SelectAll())
    End Sub

    Private Sub FindData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tcari.TextChanged
        If Tcari.Text.Length <> 0 Then
            DGproduk.DataSource = fetchData("select * from daftar_produk where `Nama_Produk` like '%" & Tcari.Text & "%'")
        Else
            DGproduk.DataSource = fetchData(produk.SelectAll())
        End If
    End Sub

End Class