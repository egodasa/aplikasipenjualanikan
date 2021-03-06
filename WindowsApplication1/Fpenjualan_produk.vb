﻿Imports SqlHelper
Public Class Fpenjualan_produk
    Dim id_transaksi As String
    Dim tgl_transaksi As String
    Dim current_id As Integer
    Dim detail_transaksi As New DataQuery
    Private Function FormValidation()
        Return Cproduk.Text.Length <> 0 And Tjumlah.Value <> 0 And Tharga_jual.Value <> 0 And Charga_jual.Text.Length <> 0
    End Function
    Private Sub LoadForm(sender As Object, e As EventArgs) Handles MyBase.Load
        If jenis_pengguna <> "Admin" Then
            MenuStrip1.Visible = False
        Else
            MenuStrip1.Visible = True
        End If
        SetTransactionValue()
        detail_transaksi.table = "tbl_detail_transaksi"
        detail_transaksi.view = "laporan_detail_transaksi"
        detail_transaksi.primary_key = "Id_dtransaksi"
        detail_transaksi.primary_key_caption = "Id_dtransaksi"
        detail_transaksi.viewData = New List(Of SqlView) From {
        New SqlView("id_produk", "id_Produk"),
        New SqlView("id_dpembelian", "id_dpembelian"),
        New SqlView("id_dtransaksi", "id_dtransaksi"),
        New SqlView("id_transaksi", "id_transaksi"),
        New SqlView(Nothing, "Nama_Produk"),
        New SqlView("jumlah", "Jumlah"),
        New SqlView("harga_jual", "Harga_Jual"),
        New SqlView(Nothing, "Total_Harga"),
        New SqlView(Nothing, "Satuan"),
        New SqlView(Nothing, "Harga_Jual")
        }
        DGproduk.DataSource = FetchData(detail_transaksi.SelectAll("id_transaksi", "=", id_transaksi))
        DGproduk.Columns("id_Produk").Visible = False
        DGproduk.Columns("id_Transaksi").Visible = False
        DGproduk.Columns("id_dtransaksi").Visible = False
        DGproduk.Columns("id_dpembelian").Visible = False
        FetchComboboxData(Query.SelectAll("daftar_produk"), Cproduk, "Nama_Produk", "Id_Produk")
    End Sub
    Private Sub SetProductValue()
        detail_transaksi.formData = New List(Of SqlManipulation) From {
        New SqlManipulation("id_produk", Cproduk.SelectedValue),
        New SqlManipulation("id_dpembelian", Charga_jual.SelectedValue),
        New SqlManipulation("id_transaksi", SqlHelper.Query.SqlString(id_transaksi)),
        New SqlManipulation("jumlah", Tjumlah.Value),
        New SqlManipulation("harga_jual", Tharga_jual.Value)
        }
    End Sub
    Private Sub SetTransactionValue()
        id_transaksi = DateTime.Now.ToString("ddMMyyhhmmssffff")
        tgl_transaksi = DateTime.Now.ToString("yyyy-MM-dd")
        GroupBox1.Text = "Form Penjualan Produk (No Faktur :  " & id_transaksi & ")"
    End Sub

    Private Sub AddProduk(sender As Object, e As EventArgs) Handles Badd.Click
        If FormValidation() = True Then
            SetProductValue()
            RunQuery(detail_transaksi.Insert())
            DGproduk.DataSource = FetchData(detail_transaksi.SelectAll("id_transaksi", "=", id_transaksi))
            TotalBayar()
            ResetForm()
        End If
    End Sub
    Private Sub ResetForm()
        Cproduk.SelectedIndex = -1
        Charga_jual.SelectedIndex = -1
        Tjumlah.ResetText()
        Tharga_jual.ResetText()
        Cproduk.Focus()
    End Sub
    Private Sub CancelAction(sender As Object, e As EventArgs) Handles Bcancel.Click
        RunQuery(Query.Delete("tbl_detail_transaksi", "id_transaksi", id_transaksi))
        SetTransactionValue()
        DGproduk.DataSource = FetchData(detail_transaksi.SelectAll("id_transaksi", "=", id_transaksi))
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
        RunQuery("DELETE FROM tbl_detail_transaksi WHERE id_transaksi = '" + id_transaksi + "' AND id_produk = " & DGproduk.Rows(x).Cells("id_produk").Value.ToString)
        DGproduk.DataSource = FetchData(detail_transaksi.SelectAll("id_transaksi", "=", id_transaksi))
        ResetForm()
        TotalBayar()
    End Sub

    Private Sub SaveTransaction(sender As Object, e As EventArgs) Handles Bsave.Click
        RunQuery("INSERT INTO tbl_transaksi VALUES ('" & id_transaksi & "','" & tgl_transaksi & "')")
        Call successMessage()
        SetTransactionValue()
        ResetForm()
        Ttotal_bayar.ResetText()
        DGproduk.DataSource = FetchData(detail_transaksi.SelectAll("id_transaksi", "=", id_transaksi))
    End Sub

    Private Sub CloseForm(sender As Object, e As EventArgs) Handles Bexit.Click
        Bcancel.PerformClick()
        main_form.Show()
        Me.Close()
    End Sub

    Private Sub DaftarPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarPembelianToolStripMenuItem.Click
        Fdaftar_transaksi.ShowDialog()
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
    Private Sub GetProductPrice(sender As Object, e As EventArgs) Handles Cproduk.SelectionChangeCommitted
        FetchComboboxData(Query.SelectAll("detail_pembelian", "id_produk", "=", Cproduk.SelectedValue.ToString), Charga_jual, "keterangan", "id_dpembelian")
        Dim tmp As DataTable = FetchData(Query.SelectAll("daftar_produk", "Id_Produk", "=", Cproduk.SelectedValue.ToString))
        Tharga_jual.Value = tmp.Rows(0).Item("Harga_Produk")
    End Sub
    Private Sub Mhapus_Click(sender As Object, e As EventArgs) Handles Mhapus.Click
        DeleteProduct(current_id)
    End Sub

    Private Sub DaftarProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarProdukToolStripMenuItem.Click
        Fkelola_produk.ShowDialog()
    End Sub

    Private Sub DaftarSatuanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarSatuanToolStripMenuItem.Click
        Fsatuan.ShowDialog()
    End Sub
End Class