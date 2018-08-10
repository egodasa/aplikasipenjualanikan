Imports SqlHelper
Public Class Fkelola_produk
    Dim produk As New DataQuery
    Dim current_id As Integer
    Private Function FormValidation()
        Return Thrg_produk.Value <> 0 And Tnm_produk.TextLength <> 0 And Csatuan.Text.Length <> 0 And Tstok.Value <> 0
    End Function
    Private Sub SetFormData()
        produk.formData = New List(Of SqlManipulation) From {
            New SqlManipulation("nm_produk", Query.SqlString(Tnm_produk.Text)),
            New SqlManipulation("stok", Tstok.Value.ToString()),
            New SqlManipulation("harga_produk", Thrg_produk.Value.ToString().Replace(",", ".")),
            New SqlManipulation("id_sat_produk", Csatuan.SelectedValue.ToString)
            }
    End Sub
    Private Sub LoadForm(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        If jenis_pengguna <> "Admin" Then
            MenuStrip1.Visible = False
        Else
            MenuStrip1.Visible = True
        End If
        Call SetKoneksi()
        Call FetchComboboxData("select * from daftar_satuan", Csatuan, "Nama_Satuan", "Id_Sat")
        produk.table = "tbl_produk"
        produk.view = "daftar_produk"
        produk.primary_key = "id_produk"
        produk.primary_key_caption = "Id_Produk"
        produk.viewData = New List(Of SqlView) From {
            New SqlView("id_produk", "Id_Produk"),
            New SqlView("nm_produk", "Nama_Produk"),
            New SqlView("stok", "Stok"),
            New SqlView("harga_produk", "Harga_Produk"),
            New SqlView("id_sat_produk", "Id_Sat_Produk"),
            New SqlView(Nothing, "Satuan")
            }
        DGproduk.DataSource = FetchData(produk.SelectAll())
        DGproduk.Columns("Id_Produk").Visible = False
        DGproduk.Columns("Id_Sat_Produk").Visible = False
        DGproduk.Columns(produk.primary_key_caption).Visible = False
        Bcancel.PerformClick()
    End Sub

    Private Sub CancelAction(ByVal sender As System.Object, ByVal e As EventArgs) Handles Bcancel.Click
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
            If Fpenjualan_produk.Visible = True Then
                FetchComboboxData(Query.SelectAll("daftar_produk"), Fpenjualan_produk.Cproduk, "Nama_Produk", "Id_Produk")
            Else
                main_form.Show()
            End If
            If Fpembelian_produk.Visible = True Then
                FetchComboboxData(Query.SelectAll("daftar_produk"), Fpembelian_produk.Cproduk, "Nama_Produk", "Id_Produk")
            Else
                main_form.Show()
            End If
            Me.Close()
        End If
    End Sub
    Private Sub SaveData(sender As Object, e As EventArgs) Handles Bsave.Click
        If FormValidation() = True Then
            SetFormData()
            RunQuery(produk.Insert())
            Call successMessage()
            DGproduk.DataSource = FetchData(produk.SelectAll())
            Bcancel.PerformClick()
        End If
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
            RunQuery(produk.Delete(DGproduk.Rows(x).Cells(0).Value))
            DGproduk.DataSource = FetchData(produk.SelectAll())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub EditData(sender As Object, e As EventArgs) Handles Bedit.Click
        If FormValidation() = True Then
            SetFormData()
            RunQuery(produk.Update(DGproduk.Rows(current_id).Cells(0).Value.ToString()))
            Call editMessage()
            Bcancel.PerformClick()
            DGproduk.DataSource = FetchData(produk.SelectAll())
        End If
    End Sub

    Private Sub FindData(ByVal sender As System.Object, ByVal e As EventArgs) Handles Tcari.TextChanged
        If Tcari.Text.Length <> 0 Then
            DGproduk.DataSource = FetchData("select * from daftar_produk where `Nama_Produk` like '%" & Tcari.Text & "%'")
        Else
            DGproduk.DataSource = FetchData(produk.SelectAll())
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

    Private Sub DaftarSatuanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarSatuanToolStripMenuItem.Click
        Fsatuan.ShowDialog()
    End Sub
End Class