Imports SqlHelper
Public Class Fpembelian_produk
    Dim id_pembelian As String
    Dim tgl_pembelian As String
    Dim current_id As Integer
    Dim detail_pembelian As New DataQuery
    Private Function FormValidation()
        Dim a As Boolean = Cpemasok.Text.Length <> 0 And Cproduk.Text.Length <> 0 And Tjumlah.Value <> 0 And Tbayar.Value <> 0
        Dim b As Boolean = Thrg_jual.Value <> 0 And Csatuan.Text.Length <> 0
        If is_baru.CheckState = True Then
            Return a And b
        Else
            Return a
        End If
    End Function
    Private Sub LoadForm(sender As Object, e As EventArgs) Handles MyBase.Load
        If jenis_pengguna <> "Admin" Then
            MenuStrip1.Visible = False
        Else
            MenuStrip1.Visible = True
        End If
        SetTransactionValue()
        detail_pembelian.table = "tbl_detail_pembelian"
        detail_pembelian.view = "laporan_detail_pembelian"
        detail_pembelian.primary_key = "Id_Dpembelian"
        detail_pembelian.primary_key_caption = "Id_Dpembelian"
        detail_pembelian.viewData = New List(Of SqlView) From {
            New SqlView("id_produk", "id_produk"),
            New SqlView("id_dpembelian", "id_Dpembelian"),
            New SqlView("id_pemasok", "id_pemasok"),
            New SqlView("id_pembelian", "id_pembelian"),
            New SqlView(Nothing, "Nama_Produk"),
            New SqlView("jumlah", "jumlah"),
            New SqlView("total_harga", "total_harga"),
            New SqlView("harga_satuan", "harga_satuan"),
            New SqlView(Nothing, "Satuan"),
            New SqlView(Nothing, "Nama_Pemasok")
            }
        DGproduk.DataSource = FetchData(detail_pembelian.SelectAll("id_pembelian", "=", id_pembelian))
        DGproduk.Columns("id_produk").Visible = False
        DGproduk.Columns("id_dpembelian").Visible = False
        DGproduk.Columns("id_pemasok").Visible = False
        DGproduk.Columns("id_pembelian").Visible = False
        DGproduk.Columns("tgl_pembelian").Visible = False
        FetchComboboxData(Query.SelectAll("daftar_produk"), Cproduk, "Nama_Produk", "Id_Produk")
        FetchComboboxData(Query.SelectAll("laporan_pemasok"), Cpemasok, "Nama_Pemasok", "Id_Pemasok")
        FetchComboboxData("select * from daftar_satuan", Csatuan, "Nama_Satuan", "Id_Sat")
    End Sub
    Private Sub SetProductValue()
        detail_pembelian.formData = New List(Of SqlManipulation) From {
            New SqlManipulation("id_produk", Cproduk.SelectedValue),
            New SqlManipulation("id_pemasok", Cpemasok.SelectedValue),
            New SqlManipulation("id_pembelian", id_pembelian),
            New SqlManipulation("jumlah", Tjumlah.Value),
            New SqlManipulation("total_harga", Tbayar.Value),
            New SqlManipulation("harga_satuan", Convert.ToDecimal((Tbayar.Value / Tjumlah.Value)).ToString.Replace(",", "."))
            }
    End Sub
    Private Sub SetTransactionValue()
        id_pembelian = DateTime.Now.ToString("ddMMyyhhmmssffff")
        tgl_pembelian = DateTime.Now.ToString("yyyy-MM-dd")
        GroupBox1.Text = "Form Pembelian Produk (No Faktur :  " & id_pembelian & ")"
    End Sub

    Private Sub AddProduk(sender As Object, e As EventArgs) Handles Badd.Click
        If FormValidation() = True Then
            If is_baru.Checked = True And Cproduk.SelectedIndex = -1 Then
                Dim data = New List(Of SqlManipulation) From {
            New SqlManipulation("nm_produk", Query.SqlString(Cproduk.Text)),
            New SqlManipulation("stok", Tjumlah.Value.ToString()),
            New SqlManipulation("harga_produk", Thrg_jual.Value.ToString().Replace(",", ".")),
            New SqlManipulation("id_sat_produk", Csatuan.SelectedValue.ToString)
            }
                Dim last_id As DataTable = FetchData(Query.Insert("tbl_produk", data) & "SELECT LAST_INSERT_ID() AS ID;")
                FetchComboboxData(Query.SelectAll("daftar_produk"), Cproduk, "Nama_Produk", "Id_Produk")
                Cproduk.SelectedValue = last_id.Rows(0).Item(0)
            End If
            SetProductValue()
            RunQuery(detail_pembelian.Insert())
            DGproduk.DataSource = FetchData(detail_pembelian.SelectAll("id_pembelian", "=", id_pembelian))
            TotalBayar()
            ResetForm()
        End If
    End Sub
    Private Sub ResetForm()
        Cproduk.SelectedIndex = -1
        Cpemasok.SelectedIndex = -1
        Tjumlah.ResetText()
        Tbayar.ResetText()
        Cproduk.Focus()
        If is_baru.Checked = True Then
            is_baru.Checked = False
            Thrg_jual.Enabled = False
            Csatuan.Enabled = False
            Thrg_jual.ResetText()
            Csatuan.SelectedIndex = -1
        End If
    End Sub
    Private Sub CancelAction(sender As Object, e As EventArgs) Handles Bcancel.Click
        RunQuery(Query.Delete("tbl_detail_pembelian", "id_pembelian", id_pembelian))
        SetTransactionValue()
        DGproduk.DataSource = FetchData(detail_pembelian.SelectAll("id_pembelian", "=", id_pembelian))
        ResetForm()
        Ttotal_bayar.ResetText()
    End Sub
    Private Sub TotalBayar()
        Dim total_harga = 0
        For x As Integer = 0 To DGproduk.Rows.Count - 1
            total_harga += DGproduk.Rows(x).Cells("total_harga").Value
        Next
        Ttotal_bayar.Value = total_harga
    End Sub

    Private Sub DeleteProduct(ByVal x As Integer)
        RunQuery("DELETE FROM tbl_detail_pembelian WHERE id_pembelian = '" + id_pembelian + "' AND id_produk = " & DGproduk.Rows(x).Cells("id_produk").Value.ToString)
        DGproduk.DataSource = FetchData(detail_pembelian.SelectAll("id_pembelian", "=", id_pembelian))
        ResetForm()
        TotalBayar()
    End Sub

    Private Sub SaveTransaction(sender As Object, e As EventArgs) Handles Bsave.Click
        RunQuery("INSERT INTO tbl_pembelian VALUES ('" & id_pembelian & "','" & tgl_pembelian & "')")
        Call successMessage()
        SetTransactionValue()
        ResetForm()
        Ttotal_bayar.ResetText()
        DGproduk.DataSource = FetchData(detail_pembelian.SelectAll("id_pembelian", "=", id_pembelian))
    End Sub

    Private Sub CloseForm(sender As Object, e As EventArgs) Handles Bexit.Click
        Bcancel.PerformClick()
        main_form.Show()
        Me.Close()
    End Sub

    Private Sub DaftarPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarPembelianToolStripMenuItem.Click
        Fdaftar_pembelian.ShowDialog()
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

    Private Sub Mhapus_Click(sender As Object, e As EventArgs) Handles Mhapus.Click
        DeleteProduct(current_id)
    End Sub

    Private Sub is_baru_CheckedChanged(sender As Object, e As EventArgs) Handles is_baru.CheckedChanged
        Thrg_jual.Enabled = Not Thrg_jual.Enabled
        Csatuan.Enabled = Not Csatuan.Enabled
    End Sub

    Private Sub DaftarProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarProdukToolStripMenuItem.Click
        Fkelola_produk.ShowDialog()
    End Sub

    Private Sub DaftarSatuanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarSatuanToolStripMenuItem.Click
        Fsatuan.ShowDialog()
    End Sub

    Private Sub Cproduk_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cproduk.SelectionChangeCommitted
        Dim data As DataTable = FetchData(Query.SelectAll("daftar_produk", "Id_Produk", "=", Cproduk.SelectedValue))
        Thrg_jual.Value = data.Rows(0).Item("Harga_Produk")
        Csatuan.SelectedValue = data.Rows(0).Item("Id_Sat_Produk")
    End Sub
End Class