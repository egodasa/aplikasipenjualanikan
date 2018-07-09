Public Class Fpenjualan
    Dim obat_beli, data_obat As New DataTable
    Dim id_periksa As String = DateTime.Now.ToString("ddMMyyhhmmssffff")
    Dim DTobat As New DataTable
    Dim cari_obat As DataTable
    Dim total_harga As Integer = 0
    Dim getDataBeli As String = "select * from daftar_obat_beli where `Id_Transaksi` = '" & id_periksa & "'"
    Dim waktu_kb As String
    Sub resetTerapi()
        Call fetchComboboxData("select * from daftar_obat", Cobat, "Nama_Obat", "Id_Obat")
        Cobat.SelectedIndex = -1
        data_obat = Cobat.DataSource
        Tjumlah.ResetText()
        Tjumlah.Maximum = 100000000
        DGobat_beli.DataSource = fetchData("select * from daftar_obat_beli where `Id_Transaksi` = '" & id_periksa & "'")
        DGobat_beli.Columns("Id_Obat").Visible = False
        DGobat_beli.Columns("Id_Transaksi").Visible = False
        DGobat_beli.Columns("Jumlah").ReadOnly = False
        Lstok.ResetText()
        If DGobat_beli.RowCount <> 0 Then
            For Each x As DataGridViewRow In DGobat_beli.Rows
                If Not x.IsNewRow Then
                    If x.Cells(2).Value <> 0 Then
                        runQuery("insert into tbl_detail_transaksi(id_obat, jumlah, id_transaksi) values (" & x.Cells("id_obat").Value & "," & x.Cells("Jumlah").Value & ", " & id_periksa & ")")
                    End If
                End If
            Next
        End If
    End Sub
    Sub resetId()
        id_periksa = DateTime.Now.ToString("ddMMyyhhmmssffff")
        getDataBeli = "select * from daftar_obat_beli where `Id_Transaksi` = '" & id_periksa & "'"
    End Sub
    Sub resetTransaksi()
        If DGobat_beli.Rows.Count <> 0 Then
            runQuery("delete from tbl_detail_transaksi where id_transaksi = '" & id_periksa & "'")
        End If
    End Sub
    Sub resetPembayaran()
        Ttotal_harga.Clear()
        Tdibayarkan.ResetText()
        Tkembalian.Clear()
    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Fperiksa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call setKoneksi()
        Call resetPembayaran()
        Call resetTerapi()
    End Sub

    Private Sub DGdaftar_obat_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    End Sub

    Private Sub DGdaftar_obat_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    End Sub

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Fmenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Bsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsimpan.Click
        runQuery("insert into tbl_transaksi values ('" & id_periksa & "','" & DateTime.Now.ToString("yy-MM-dd hh:mm:ss") & "')")
        Call resetId()
        Call resetPembayaran()
        Call resetTerapi()
    End Sub

    Private Sub Cobat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cobat.SelectedIndexChanged
        If data_obat.Rows.Count <> 0 And Cobat.SelectedIndex <> -1 Then
            Lstok.Text = "Stok " & data_obat.Rows(Cobat.SelectedIndex).Item("Stok") & " " & data_obat.Rows(Cobat.SelectedIndex).Item("Satuan")
            Tjumlah.Maximum = Val(data_obat.Rows(Cobat.SelectedIndex).Item("Stok"))
        End If
    End Sub

    Private Sub Btambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btambah.Click
        If Cobat.SelectedIndex <> -1 And Cobat.Text <> "" Then
            runQuery("insert into tbl_detail_transaksi (id_obat, id_transaksi, jumlah) values (" & Cobat.SelectedValue & ", '" & id_periksa & "', " & Tjumlah.Text & ")")
            DGobat_beli.DataSource = fetchData(getDataBeli)
            total_harga = 0
            For x As Integer = 0 To DGobat_beli.Rows.Count - 1
                total_harga += DGobat_beli.Rows(x).Cells("Total_Harga").Value
            Next
            Ttotal_harga.Text = Format(total_harga, "Rp,   ##,##0")
            Call fetchComboboxData("select * from daftar_obat", Cobat, "Nama_Obat", "Id_Obat")
            data_obat = Cobat.DataSource
            Tjumlah.ResetText()
            Lstok.ResetText()
        End If
    End Sub

    Private Sub Fperiksa_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If DGobat_beli.Rows.Count > 0 Then
            runQuery("delete from tbl_detail_transaksi where id_transaksi = '" & id_periksa & "'")
        End If
    End Sub

    Private Sub Bhapus_obat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bhapus_obat.Click
        Try
            runQuery("delete from tbl_detail_transaksi where id_obat = " & DGobat_beli.CurrentRow.Cells("Id_Obat").Value & " and id_transaksi = '" & id_periksa & "'")
            DGobat_beli.DataSource = fetchData(getDataBeli)
            total_harga = 0
            For x As Integer = 0 To DGobat_beli.Rows.Count - 1
                total_harga += DGobat_beli.Rows(x).Cells("Total_Harga").Value
            Next
            Ttotal_harga.Text = Format(total_harga, "Rp,   ##,##0")
            Call fetchComboboxData("select * from daftar_obat", Cobat, "Nama_Obat", "Id_Obat")
            data_obat = Cobat.DataSource
            Lstok.ResetText()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
        Fmenu.Show()
    End Sub

    Private Sub ObatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Fkelola_obat.ShowDialog()
    End Sub

    Private Sub Bbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bbatal.Click
        If MessageBox.Show("Apakah transaksi ini akan DIBATALKAN?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
            Call resetTransaksi()
            Call resetId()
            Call resetPembayaran()
            Call resetTerapi()
        End If
    End Sub

    Private Sub DGobat_beli_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGobat_beli.CellContentClick

    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tdibayarkan.ValueChanged

    End Sub

    Private Sub Tdibayarkan_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tdibayarkan.KeyUp
        If Ttotal_harga.Text <> "" Or Val(Ttotal_harga.Text) <> 0 Then
            Tkembalian.Text = Format(Val(Tdibayarkan.Text) - total_harga, "Rp,   ##,##0")
        End If
    End Sub

    Private Sub Ttgi_badan_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Fperiksa_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If DGobat_beli.Rows.Count > 0 Then
            runQuery("delete from tbl_detail_transaksi where id_transaksi = '" & id_periksa & "'")
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub JenisObatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Fjenis_produk.ShowDialog()
    End Sub

    Private Sub DaftarTransaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarTransaksiToolStripMenuItem.Click
        Fdaftar_transaksi.ShowDialog()
    End Sub
End Class