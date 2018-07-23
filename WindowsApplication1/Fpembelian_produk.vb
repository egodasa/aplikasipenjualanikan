Public Class Fpembelian_produk
    Dim id_pembelian As String
    Dim tgl_pembelian As String
    Dim current_id As Integer
    Dim detail_pembelian As New SqlHelper.DataQuery
    Private Sub LoadForm(sender As Object, e As EventArgs) Handles MyBase.Load
        SetTransactionValue()
        detail_pembelian.table = "tbl_detail_pembelian"
        detail_pembelian.view = "laporan_detail_pembelian"
        detail_pembelian.primary_key = "Id_Dpembelian"
        detail_pembelian.primary_key_caption = "Id_Dpembelian"
        SetProductValue()
        DGproduk.DataSource = fetchData(detail_pembelian.SelectAll("id_pembelian", "=", id_pembelian))
        DGproduk.Columns("id_produk").Visible = False
        DGproduk.Columns("id_dpembelian").Visible = False
        DGproduk.Columns("id_pemasok").Visible = False
        DGproduk.Columns("id_pembelian").Visible = False
        DGproduk.Columns("tgl_pembelian").Visible = False
        fetchComboboxData(SqlHelper.Query.SelectAll("daftar_produk"), Cproduk, "Nama_Produk", "Id_Produk")
        fetchComboboxData(SqlHelper.Query.SelectAll("laporan_pemasok"), Cpemasok, "Nama_Pemasok", "Id_Pemasok")
        fetchComboboxData("select * from daftar_satuan", Csatuan, "Nama_Satuan", "Id_Sat")
        Tbayar.Value = 0
        Tjumlah.Value = 0
    End Sub
    Private Sub SetProductValue()
        detail_pembelian.formData = New List(Of SqlHelper.Query) From {
            New SqlHelper.Query("id_produk", Cproduk.SelectedValue, "id_produk"),
            New SqlHelper.Query("id_dpembelian", "DEFAULT", "id_Dpembelian"),
            New SqlHelper.Query("id_pemasok", Cpemasok.SelectedValue, "id_pemasok"),
            New SqlHelper.Query("id_pembelian", id_pembelian, "id_pembelian"),
            New SqlHelper.Query(Nothing, Nothing, "Nama_Produk", False),
            New SqlHelper.Query("jumlah", Tjumlah.Value, "jumlah"),
            New SqlHelper.Query("total_harga", Tbayar.Value, "total_harga"),
            New SqlHelper.Query("harga_satuan", Convert.ToDecimal((Tbayar.Value / Tjumlah.Value)).ToString.Replace(",", "."), "harga_satuan"),
            New SqlHelper.Query(Nothing, Nothing, "Satuan", False),
            New SqlHelper.Query(Nothing, Nothing, "Nama_Pemasok", False)
            }
    End Sub
    Private Sub SetTransactionValue()
        id_pembelian = DateTime.Now.ToString("ddMMyyhhmmssffff")
        tgl_pembelian = DateTime.Now.ToString("yyyy-MM-dd")
        GroupBox1.Text = "Form Pembelian Produk (No Faktur :  " & id_pembelian & ")"
    End Sub

    Private Sub AddProduk(sender As Object, e As EventArgs) Handles Badd.Click
        If is_baru.Checked = True And Cproduk.SelectedIndex = -1 Then
            Dim data = New List(Of SqlHelper.Query) From {
            New SqlHelper.Query("nm_produk", SqlHelper.Query.SqlString(Cproduk.Text), "Nama_Produk"),
            New SqlHelper.Query("stok", Tjumlah.Value.ToString(), "Stok"),
            New SqlHelper.Query("harga_produk", Thrg_jual.Value.ToString().Replace(",", "."), "Harga_Produk"),
            New SqlHelper.Query("id_sat_produk", Csatuan.SelectedValue.ToString, "Id_Sat_Produk")
            }
            Dim last_id As DataTable = fetchData(SqlHelper.Query.Insert("tbl_produk", data) & "SELECT LAST_INSERT_ID() AS ID;")
            fetchComboboxData(SqlHelper.Query.SelectAll("daftar_produk"), Cproduk, "Nama_Produk", "Id_Produk")
            Cproduk.SelectedValue = last_id.Rows(0).Item(0)
        End If
        SetProductValue()
        runQuery(detail_pembelian.Insert())
        DGproduk.DataSource = fetchData(detail_pembelian.SelectAll("id_pembelian", "=", id_pembelian))
        TotalBayar()
        ResetForm()
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
        runQuery(SqlHelper.Query.Delete("tbl_detail_pembelian", "id_pembelian", id_pembelian))
        SetTransactionValue()
        DGproduk.DataSource = fetchData(detail_pembelian.SelectAll("id_pembelian", "=", id_pembelian))
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
        runQuery("DELETE FROM tbl_detail_pembelian WHERE id_pembelian = '" + id_pembelian + "' AND id_produk = " & DGproduk.Rows(x).Cells("id_produk").Value.ToString)
        DGproduk.DataSource = fetchData(detail_pembelian.SelectAll("id_pembelian", "=", id_pembelian))
        ResetForm()
        TotalBayar()
    End Sub

    Private Sub SaveTransaction(sender As Object, e As EventArgs) Handles Bsave.Click
        runQuery("INSERT INTO tbl_pembelian VALUES ('" & id_pembelian & "','" & tgl_pembelian & "')")
        Call successMessage()
        SetTransactionValue()
        ResetForm()
        DGproduk.DataSource = fetchData(detail_pembelian.SelectAll("id_pembelian", "=", id_pembelian))
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
End Class