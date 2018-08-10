Public Class Fsatuan
    Dim satuan As New SqlHelper.DataQuery
    Dim current_id As Integer
    Private Function FormValidation()
        Return Tnm_satuan.TextLength <> 0
    End Function
    Private Sub SetFormData()
        satuan.formData = New List(Of SqlHelper.SqlManipulation) From {
            New SqlHelper.SqlManipulation("nm_sat", SqlHelper.Query.SqlString(Tnm_satuan.Text))
            }
    End Sub
    Private Sub LoadForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        satuan.table = "tbl_satuan"
        satuan.view = Nothing
        satuan.primary_key = "id_sat"
        satuan.primary_key_caption = "Id_Sat"
        satuan.viewData = New List(Of SqlHelper.SqlView) From {
            New SqlHelper.SqlView("id_sat", "Id_Sat"),
            New SqlHelper.SqlView("nm_sat", "Nama_Satuan")
            }
        DGsatuan.DataSource = FetchData(satuan.SelectMultiple())
        DGsatuan.Columns(satuan.primary_key_caption).Visible = False
    End Sub
    Private Sub GetDetail(ByVal x As Integer)
        Bedit.Enabled = True
        Bsave.Enabled = False
        Tnm_satuan.Text = DGsatuan.Rows(x).Cells(1).Value
    End Sub
    Private Sub EditData(sender As Object, e As EventArgs) Handles Bedit.Click
        If FormValidaton() = True Then
            SetFormData()
        RunQuery(satuan.Update(DGsatuan.Rows(current_id).Cells(0).Value.ToString()))
        Call editMessage()
        Bcancel.PerformClick()
            DGsatuan.DataSource = FetchData(satuan.SelectMultiple())
        End If
    End Sub
    Private Sub DeleteData(ByVal x As Integer)
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            RunQuery(satuan.Delete(DGsatuan.Rows(x).Cells(0).Value))
            DGsatuan.DataSource = FetchData(satuan.SelectMultiple())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub SaveData(sender As Object, e As EventArgs) Handles Bsave.Click
        If FormValidaton() = True Then
            SetFormData()
        RunQuery(satuan.Insert())
        Call successMessage()
        DGsatuan.DataSource = FetchData(satuan.SelectMultiple())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub CloseForm(sender As Object, e As EventArgs) Handles Bexit.Click
        If Fkelola_produk.Visible = True Then
            Call FetchComboboxData("select * from daftar_satuan", Fkelola_produk.Csatuan, "Nama_Satuan", "Id_Sat")
        End If
        If Fpembelian_produk.Visible = True Then
            Call FetchComboboxData("select * from daftar_satuan", Fpembelian_produk.Csatuan, "Nama_Satuan", "Id_Sat")
        End If
        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If Fkelola_produk.Visible = True Or Fpembelian_produk.Visible = True Then
                Me.Close()
            Else
                main_form.Show()
                Me.Close()
            End If
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