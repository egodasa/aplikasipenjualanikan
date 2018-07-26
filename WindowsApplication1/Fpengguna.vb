Public Class Fpengguna
    Dim pengguna As New SqlHelper.DataQuery
    Dim current_id As Integer
    Private Sub SetFormData()
        pengguna.formData = New List(Of SqlHelper.SqlManipulation) From {
            New SqlHelper.SqlManipulation("username", SqlHelper.Query.SqlString(Tusername.Text)),
            New SqlHelper.SqlManipulation("password", "md5(" & SqlHelper.Query.SqlString(Tpassword.Text) & ")"),
            New SqlHelper.SqlManipulation("nm_lengkap", SqlHelper.Query.SqlString(Tnm_lengkap.Text)),
            New SqlHelper.SqlManipulation("jenis", SqlHelper.Query.SqlString(Cjenis.Text))
            }
    End Sub
    Private Sub LoadForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pengguna.table = "tbl_pengguna"
        pengguna.view = Nothing
        pengguna.primary_key = "id_pengguna"
        pengguna.primary_key_caption = pengguna.primary_key
        pengguna.viewData = New List(Of SqlHelper.SqlView) From {
            New SqlHelper.SqlView("id_pengguna", "id_pengguna"),
            New SqlHelper.SqlView("username", "Username"),
            New SqlHelper.SqlView("password", "Password"),
            New SqlHelper.SqlView("nm_lengkap", "Nama Lengkap"),
            New SqlHelper.SqlView("jenis", "Jenis Pengguna")
            }
        DGpengguna.DataSource = FetchData(pengguna.SelectMultiple())
        DGpengguna.Columns(pengguna.primary_key_caption).Visible = False
        DGpengguna.Columns(2).Visible = False
    End Sub
    Private Sub GetDetail(ByVal x As Integer)
        Bedit.Enabled = True
        Bsave.Enabled = False
        Tusername.Text = DGpengguna.Rows(x).Cells(1).Value
        Tpassword.Text = DGpengguna.Rows(x).Cells(2).Value
        Tnm_lengkap.Text = DGpengguna.Rows(x).Cells(3).Value
        Cjenis.Text = DGpengguna.Rows(x).Cells(4).Value
    End Sub
    Private Sub EditData(ByVal sender As Object, ByVal e As EventArgs) Handles Bedit.Click
        SetFormData()
        RunQuery(pengguna.Update(DGpengguna.Rows(current_id).Cells(0).Value.ToString()))
        Call editMessage()
        Bcancel.PerformClick()
        DGpengguna.DataSource = FetchData(pengguna.SelectMultiple())
    End Sub
    Private Sub DeleteData(ByVal x As Integer)
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            RunQuery(pengguna.Delete(DGpengguna.Rows(x).Cells(0).Value))
            DGpengguna.DataSource = FetchData(pengguna.SelectMultiple())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub SaveData(ByVal sender As Object, ByVal e As EventArgs) Handles Bsave.Click
        SetFormData()
        RunQuery(pengguna.Insert())
        Call successMessage()
        DGpengguna.DataSource = FetchData(pengguna.SelectMultiple())
        Bcancel.PerformClick()
    End Sub
    Private Sub CloseForm(ByVal sender As Object, ByVal e As EventArgs) Handles Bexit.Click
        main_form.Show()
        Me.Close()
    End Sub
    Private Sub CancelAction(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancel.Click
        Bedit.Enabled = False
        Bsave.Enabled = True
        Tusername.Clear()
        Tusername.Focus()
        Tpassword.Clear()
        Tnm_lengkap.Clear()
        Cjenis.SelectedIndex = -1
    End Sub

    Private Sub DGsatuan_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DGpengguna.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim pos = DGpengguna.HitTest(e.X, e.Y).RowIndex
            If pos >= 0 Then
                MenuAksi.Show(DGpengguna, New Point(e.X, e.Y))
                current_id = pos
            End If
        End If
    End Sub

    Private Sub Medit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Medit.Click
        GetDetail(current_id)
    End Sub
    Private Sub Mhapus_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Mhapus.Click
        DeleteData(current_id)
    End Sub
End Class