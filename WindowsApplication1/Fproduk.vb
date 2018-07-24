Public Class Fkelola_produk
    Dim produk As New SqlHelper.DataQuery
    Dim current_id As Integer
    Private Sub SetFormData()
        produk.formData = New List(Of SqlHelper.Query) From {
            New SqlHelper.Query("id_produk", "DEFAULT", "Id_Produk", False),
            New SqlHelper.Query("nm_produk", SqlHelper.Query.SqlString(Tnm_produk.Text), "Nama_Produk"),
            New SqlHelper.Query("stok", Tstok.Value.ToString(), "Stok"),
            New SqlHelper.Query("harga_produk", Thrg_produk.Value.ToString().Replace(",", "."), "Harga_Produk"),
            New SqlHelper.Query("id_sat_produk", Csatuan.SelectedValue.ToString, "Id_Sat_Produk"),
            New SqlHelper.Query(Nothing, Nothing, "Satuan", False)
            }
    End Sub
    Private Sub LoadForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetKoneksi()
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
        Bsave.Enabled = True
        Tnm_produk.Focus()
        Tnm_produk.Clear()
        Thrg_produk.ResetText()
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
    Private Sub GetDetail(ByVal x As Integer)
        Bedit.Enabled = True
        Bsave.Enabled = False
        Tnm_produk.Text = DGproduk.Rows(x).Cells("Nama_Produk").Value
        Tstok.Value = DGproduk.Rows(x).Cells("Stok").Value
        Csatuan.Text = DGproduk.Rows(x).Cells("Satuan").Value
        Thrg_produk.Value = DGproduk.Rows(x).Cells("Harga_Produk").Value
    End Sub
    Private Sub DeleteData(ByVal x As Integer)
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            runQuery(produk.Delete(DGproduk.Rows(x).Cells(0).Value))
            DGproduk.DataSource = fetchData(produk.SelectAll())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub EditData(sender As Object, e As EventArgs) Handles Bedit.Click
        SetFormData()
        runQuery(produk.Update(DGproduk.Rows(current_id).Cells(0).Value.ToString()))
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

    Private Sub DGsatuan_MouseClick(sender As Object, e As MouseEventArgs) Handles DGproduk.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim pos = DGproduk.HitTest(e.X, e.Y).RowIndex
            If pos >= 0 Then
                MenuAksi.Show(DGproduk, New Point(e.X, e.Y))
                current_id = pos
            End If
        End If
    End Sub

    Private Sub Medit_Click(sender As Object, e As EventArgs) Handles Medit.Click
        GetDetail(current_id)
    End Sub
    Private Sub Mhapus_Click(sender As Object, e As EventArgs) Handles Mhapus.Click
        DeleteData(current_id)
    End Sub
End Class