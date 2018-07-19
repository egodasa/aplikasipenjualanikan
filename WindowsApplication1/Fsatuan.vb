Public Class Fsatuan
    Dim table As String = "tbl_satuan"
    Dim view As String = Nothing
    Dim primary_key As String = "id_sat"
    Dim primary_key_caption As String = "Id_Satuan"
    Dim getData As String = "select id_sat as Id_Satuan, nm_sat as 'Nama_Satuan' from " & table
    Dim formData As New List(Of SqlBuilder.Sql)
    Function SetFormValue()
        Return New List(Of SqlBuilder.Sql) From {
            New SqlBuilder.Sql("nm_sat", SqlString(Tnm_satuan.Text))
        }
    End Function
    Private Sub LoadForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGsatuan.DataSource = fetchData(getData)
        DGsatuan.Columns(primary_key_caption).Visible = False
    End Sub
    Private Sub GetDetail(sender As Object, e As DataGridViewCellEventArgs) Handles DGsatuan.CellContentDoubleClick
        Bedit.Enabled = True
        Bdelete.Enabled = True
        Bcancel.Enabled = True
        Bsave.Enabled = False
        Tnm_satuan.Text = DGsatuan.CurrentRow.Cells(1).Value
    End Sub
    Private Sub EditData(sender As Object, e As EventArgs) Handles Bedit.Click
        runQuery(UpdateSqlQuery(table, SetFormValue, primary_key, DGsatuan.CurrentRow.Cells(0).Value.ToString()))
        'runQuery("update " & table & " set nm_sat = '" & Tnm_satuan.Text & "' where " & primary_key & " = " & DGsatuan.CurrentRow.Cells(0).Value)
        Call editMessage()
        Bcancel.PerformClick()
        DGsatuan.DataSource = fetchData(getData)
    End Sub
    Private Sub DeleteData(sender As Object, e As EventArgs) Handles Bdelete.Click
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            runQuery(DeleteSqlQuery(table, primary_key, DGsatuan.CurrentRow.Cells(0).Value))
            DGsatuan.DataSource = fetchData(getData)
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub SaveData(sender As Object, e As EventArgs) Handles Bsave.Click
        runQuery(InsertSqlQuery(table, SetFormValue))
        'runQuery("insert into tbl_satuan (nm_sat) values ('" & Tnm_satuan.Text & "')")
        Call successMessage()
        Tnm_satuan.Clear()
        DGsatuan.DataSource = fetchData(getData)
        Tnm_satuan.Focus()
    End Sub
    Private Sub CloseForm(sender As Object, e As EventArgs) Handles Bexit.Click
        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            main_form.Show()
            Me.Close()
        End If
    End Sub
    Private Sub CancelAction(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancel.Click
        Bedit.Enabled = False
        Bdelete.Enabled = False
        Bcancel.Enabled = False
        Bsave.Enabled = True
        Tnm_satuan.Clear()
    End Sub
End Class