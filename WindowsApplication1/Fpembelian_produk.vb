Public Class Fpembelian_produk
    Dim id_pembelian As String
    Dim tgl_pembelian As String
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
        fetchComboboxData(SqlHelper.Query.SelectAll("daftar_produk"), Cproduk, "Nama_Produk", "Id_Produk")
        fetchComboboxData(SqlHelper.Query.SelectAll("laporan_pemasok"), Cpemasok, "Nama_Pemasok", "Id_Pemasok")
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

    Private Sub DeleteProduct(sender As Object, e As EventArgs) Handles Bdelete.Click
        runQuery("DELETE FROM tbl_detail_pembelian WHERE id_pembelian = '" + id_pembelian + "' AND id_produk = " & DGproduk.CurrentRow.Cells("id_produk").Value.ToString)
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
End Class