Imports SqlHelper
Public Class Fpengguna
    Dim pengguna As New DataQuery
    Dim current_id As Integer
    Private Function FormValidation()
        Return Tusername.TextLength <> 0 And Tpassword.TextLength <> 0 And Cjenis.Text.Length <> 0
    End Function
    Private Sub SetFormData()
        pengguna.formData = New List(Of SqlManipulation) From {
            New SqlManipulation("username", Query.SqlString(Tusername.Text)),
            New SqlManipulation("password", "md5(" & Query.SqlString(Tpassword.Text) & ")"),
            New SqlManipulation("nm_lengkap", Query.SqlString(Tnm_lengkap.Text)),
            New SqlManipulation("jenis", Query.SqlString(Cjenis.Text))
            }
    End Sub
    Private Sub LoadForm(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        pengguna.table = "tbl_pengguna"
        pengguna.view = Nothing
        pengguna.primary_key = "id_pengguna"
        pengguna.primary_key_caption = pengguna.primary_key
        pengguna.viewData = New List(Of SqlView) From {
            New SqlView("id_pengguna", "id_pengguna"),
            New SqlView("username", "Username"),
            New SqlView("password", "Password"),
            New SqlView("nm_lengkap", "Nama Lengkap"),
            New SqlView("jenis", "Jenis Pengguna")
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
        If FormValidation() = True Then
            SetFormData()
            RunQuery(pengguna.Update(DGpengguna.Rows(current_id).Cells(0).Value.ToString()))
            Call editMessage()
            Bcancel.PerformClick()
            DGpengguna.DataSource = FetchData(pengguna.SelectMultiple())
        End If
    End Sub
    Private Sub DeleteData(ByVal x As Integer)
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            RunQuery(pengguna.Delete(DGpengguna.Rows(x).Cells(0).Value))
            DGpengguna.DataSource = FetchData(pengguna.SelectMultiple())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub SaveData(ByVal sender As Object, ByVal e As EventArgs) Handles Bsave.Click
        If FormValidation() = True Then
            SetFormData()
            RunQuery(pengguna.Insert())
            Call successMessage()
            DGpengguna.DataSource = FetchData(pengguna.SelectMultiple())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub CloseForm(ByVal sender As Object, ByVal e As EventArgs) Handles Bexit.Click
        main_form.Show()
        Me.Close()
    End Sub
    Private Sub CancelAction(ByVal sender As System.Object, ByVal e As EventArgs) Handles Bcancel.Click
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