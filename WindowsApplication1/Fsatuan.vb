Public Class Fsatuan
    Dim satuan As New SqlHelper.DataQuery
    Dim current_id As Integer
    Private Sub SetFormData()
        satuan.formData = New List(Of SqlHelper.Query) From {
            New SqlHelper.Query("id_sat", "DEFAULT", "Id_Sat"),
            New SqlHelper.Query("nm_sat", SqlHelper.Query.SqlString(Tnm_satuan.Text), "Nama_Satuan")
            }
    End Sub
    Private Sub LoadForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        satuan.table = "tbl_satuan"
        satuan.view = Nothing
        satuan.primary_key = "id_sat"
        satuan.primary_key_caption = "Id_Sat"
        SetFormData()
        DGsatuan.DataSource = fetchData(satuan.SelectMultiple())
        DGsatuan.Columns(satuan.primary_key_caption).Visible = False
    End Sub
    Private Sub GetDetail(ByVal x As Integer)
        Bedit.Enabled = True
        Bsave.Enabled = False
        Tnm_satuan.Text = DGsatuan.Rows(x).Cells(1).Value
    End Sub
    Private Sub EditData(sender As Object, e As EventArgs) Handles Bedit.Click
        SetFormData()
        runQuery(satuan.Update(DGsatuan.CurrentRow.Cells(0).Value.ToString()))
        Call editMessage()
        Bcancel.PerformClick()
        DGsatuan.DataSource = fetchData(satuan.SelectMultiple())
    End Sub
    Private Sub DeleteData(ByVal x As Integer)
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            runQuery(satuan.Delete(DGsatuan.Rows(x).Cells(0).Value))
            DGsatuan.DataSource = fetchData(satuan.SelectMultiple())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub SaveData(sender As Object, e As EventArgs) Handles Bsave.Click
        SetFormData()
        runQuery(satuan.Insert())
        Call successMessage()
        DGsatuan.DataSource = fetchData(satuan.SelectMultiple())
        Bcancel.PerformClick()
    End Sub
    Private Sub CloseForm(sender As Object, e As EventArgs) Handles Bexit.Click
        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            main_form.Show()
            Me.Close()
        End If
    End Sub
    Private Sub CancelAction(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancel.Click
        Bedit.Enabled = False
        Bsave.Enabled = True
        Tnm_satuan.Clear()
        Tnm_satuan.Focus()
    End Sub

    Private Sub DGsatuan_MouseClick(sender As Object, e As MouseEventArgs) Handles DGsatuan.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim pos = DGsatuan.HitTest(e.X, e.Y).RowIndex
            If pos >= 0 Then
                MenuAksi.Show(DGsatuan, New Point(e.X, e.Y))
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