Public Class Fpemasok
    Dim pemasok As New SqlHelper.DataQuery
    Dim current_id As Integer
    Private Function FormValidation()
        Return Tnm_pemasok.TextLength <> 0
    End Function
    Private Sub SetFormData()
        pemasok.formData = New List(Of SqlHelper.SqlManipulation) From {
            New SqlHelper.SqlManipulation("nm_pemasok", SqlHelper.Query.SqlString(Tnm_pemasok.Text)),
            New SqlHelper.SqlManipulation("no_telpon", SqlHelper.Query.SqlString(Ttelp.Text)),
            New SqlHelper.SqlManipulation("alamat", SqlHelper.Query.SqlString(Talamat.Text))
            }
    End Sub
    Private Sub LoadForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetKoneksi()
        pemasok.table = "tbl_pemasok"
        pemasok.view = "laporan_pemasok"
        pemasok.primary_key = "id_pemasok"
        pemasok.primary_key_caption = "id_pemasok"
        pemasok.viewData = New List(Of SqlHelper.SqlView) From {
            New SqlHelper.SqlView("id_pemasok", "id_pemasok"),
            New SqlHelper.SqlView("nm_pemasok", "Nama_Pemasok"),
            New SqlHelper.SqlView("no_telpon", "Nomor_Telepon"),
            New SqlHelper.SqlView("alamat", "Alamat")
            }
        DGpemasok.DataSource = FetchData(pemasok.SelectAll())
        DGpemasok.Columns(pemasok.primary_key_caption).Visible = False
        Bcancel.PerformClick()
    End Sub

    Private Sub CancelAction(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancel.Click
        Bedit.Enabled = False
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
        If FormValidaton() = True Then
            SetFormData()
            RunQuery(pemasok.Insert())
            Call successMessage()
            DGpemasok.DataSource = FetchData(pemasok.SelectAll())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub GetDetail(ByVal x As Integer)
        Bedit.Enabled = True
        Bsave.Enabled = False
        Tnm_pemasok.Text = DGpemasok.Rows(x).Cells("Nama_Pemasok").Value
        Ttelp.Text = DGpemasok.Rows(x).Cells("Nomor_Telepon").Value
        Talamat.Text = DGpemasok.Rows(x).Cells("Alamat").Value
    End Sub
    Private Sub DeleteData(ByVal x As Integer)
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            RunQuery(pemasok.Delete(DGpemasok.Rows(x).Cells(0).Value))
            DGpemasok.DataSource = FetchData(pemasok.SelectAll())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub EditData(sender As Object, e As EventArgs) Handles Bedit.Click
        If FormValidaton() = True Then
            SetFormData()
            RunQuery(pemasok.Update(DGpemasok.Rows(current_id).Cells(0).Value.ToString()))
            Call editMessage()
            Bcancel.PerformClick()
            DGpemasok.DataSource = FetchData(pemasok.SelectAll())
        End If
    End Sub

    Private Sub FindData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tcari.TextChanged
        If Tcari.Text.Length <> 0 Then
            DGpemasok.DataSource = FetchData("select * from daftar_pemasok where `Nama_Pemasok` like '%" & Tcari.Text & "%'")
        Else
            DGpemasok.DataSource = FetchData(pemasok.SelectAll())
        End If
    End Sub

    Private Sub DGsatuan_MouseClick(sender As Object, e As MouseEventArgs) Handles DGpemasok.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim pos = DGpemasok.HitTest(e.X, e.Y).RowIndex
            If pos >= 0 Then
                MenuAksi.Show(DGpemasok, New Point(e.X, e.Y))
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