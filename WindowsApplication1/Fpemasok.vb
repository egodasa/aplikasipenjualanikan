Public Class Fpemasok
    Dim pemasok As New SqlHelper.DataQuery
    Private Sub SetFormData()
        pemasok.formData = New List(Of SqlHelper.Query) From {
            New SqlHelper.Query("id_pemasok", "DEFAULT", "id_pemasok"),
            New SqlHelper.Query("nm_pemasok", SqlHelper.Query.SqlString(Tnm_pemasok.Text), "Nama_Pemasok"),
            New SqlHelper.Query("no_telpon", SqlHelper.Query.SqlString(Ttelp.Text), "Nomor_Telepon"),
            New SqlHelper.Query("alamat", SqlHelper.Query.SqlString(Talamat.Text), "Alamat")
            }
    End Sub
    Private Sub LoadForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call setKoneksi()
        pemasok.table = "tbl_pemasok"
        pemasok.view = "laporan_pemasok"
        pemasok.primary_key = "id_pemasok"
        pemasok.primary_key_caption = "id_pemasok"
        DGproduk.DataSource = fetchData(pemasok.SelectAll())
        DGproduk.Columns(pemasok.primary_key_caption).Visible = False
        SetFormData()
        Bcancel.PerformClick()
    End Sub

    Private Sub CancelAction(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancel.Click
        Bedit.Enabled = False
        Bdelete.Enabled = False
        Bsave.Enabled = True
        Tnm_pemasok.Focus()
        Tnm_pemasok.Clear()
        Ttelp.Clear()
        Talamat.Clear()
    End Sub
    Private Sub CloseForm(sender As Object, e As EventArgs) Handles Bexit.Click
        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            main_form.Show()
            Me.Close()
        End If
    End Sub
    Private Sub SaveData(sender As Object, e As EventArgs) Handles Bsave.Click
        SetFormData()
        runQuery(pemasok.Insert())
        Call successMessage()
        DGproduk.DataSource = fetchData(pemasok.SelectAll())
        Bcancel.PerformClick()
    End Sub
    Private Sub GetDetail(sender As Object, e As DataGridViewCellEventArgs) Handles DGproduk.CellContentDoubleClick
        Bedit.Enabled = True
        Bdelete.Enabled = True
        Bsave.Enabled = False
        Tnm_pemasok.Text = DGproduk.CurrentRow.Cells("Nama_Pemasok").Value
        Ttelp.Text = DGproduk.CurrentRow.Cells("Nomor_Telepon").Value
        Talamat.Text = DGproduk.CurrentRow.Cells("Alamat").Value
    End Sub
    Private Sub DeleteData(sender As Object, e As EventArgs) Handles Bdelete.Click
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            runQuery(pemasok.Delete(DGproduk.CurrentRow.Cells(0).Value))
            DGproduk.DataSource = fetchData(pemasok.SelectAll())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub EditData(sender As Object, e As EventArgs) Handles Bedit.Click
        SetFormData()
        runQuery(pemasok.Update(DGproduk.CurrentRow.Cells(0).Value.ToString()))
        Call editMessage()
        Bcancel.PerformClick()
        DGproduk.DataSource = fetchData(pemasok.SelectAll())
    End Sub

    Private Sub FindData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tcari.TextChanged
        If Tcari.Text.Length <> 0 Then
            DGproduk.DataSource = fetchData("select * from daftar_pemasok where `Nama_Pemasok` like '%" & Tcari.Text & "%'")
        Else
            DGproduk.DataSource = fetchData(pemasok.SelectAll())
        End If
    End Sub
End Class