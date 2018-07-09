Public Class Fpembelian
    Dim id_pembelian As String = DateTime.Now.ToString("ddMMyyhhmmssffff")
    Dim total_harga As Integer = 0
    Sub resetPembelian()
        Call fetchComboboxData("select * from daftar_obat", Cobat, "Nama_Obat", "Id_Obat")
        Call fetchComboboxData("select * from laporan_pemasok", Cpemasok, "Nama_Pemasok", "id_pemasok")
        Cobat.SelectedIndex = -1
        Cpemasok.SelectedIndex = -1
        Tjumlah.ResetText()
        Tharga.ResetText()
    End Sub
    Sub getPembelian()
        DGobat_beli.DataSource = fetchData("select * from laporan_detail_pembelian where id_pembelian = " & id_pembelian)
        DGobat_beli.Columns("id_pemasok").Visible = False
        DGobat_beli.Columns("id_detail").Visible = False
        DGobat_beli.Columns("id_obat").Visible = False
        DGobat_beli.Columns("id_pembelian").Visible = False
    End Sub
    Sub resetForm()
        Call resetPembelian()
        Ttotal_harga.Clear()
    End Sub
    Sub totalBayar()
        total_harga = 0
        For x As Integer = 0 To DGobat_beli.Rows.Count - 1
            total_harga += DGobat_beli.Rows(x).Cells("harga").Value
        Next
        Ttotal_harga.Text = Format(total_harga, "Rp,   ##,##0")
    End Sub
    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Fpembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        resetPembelian()
        getPembelian()
    End Sub

    Private Sub Bbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bbatal.Click
        If DGobat_beli.Rows.Count > 0 Then
            runQuery("delete from tbl_detail_pembelian where id_pembelian = " & id_pembelian)
        End If
        id_pembelian = DateTime.Now.ToString("ddMMyyhhmmssffff")
        Call resetPembelian()
        Call getPembelian()
        Cpemasok.Focus()
    End Sub

    Private Sub Bhapus_obat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bhapus_obat.Click
        runQuery("delete from tbl_detail_pembelian where id_pembelian = " & id_pembelian & " and id_obat = " & DGobat_beli.CurrentRow.Cells("id_obat").Value.ToString)
        Call getPembelian()
        Call totalBayar()
    End Sub

    Private Sub Bsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsimpan.Click
        runQuery("insert into tbl_pembelian values ('" & id_pembelian & "', '" & DateTime.Now.ToString("yy-MM-dd hh:mm:ss") & "')")
        Call resetPembelian()
        id_pembelian = DateTime.Now.ToString("ddMMyyhhmmssffff")
        Call getPembelian()
        Cpemasok.Focus()
    End Sub

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Bbatal.PerformClick()
        Fmenu.Show()
        Me.Close()
    End Sub

    Private Sub ObatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Fkelola_obat.ShowDialog()
    End Sub

    Private Sub JenisObatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Fjenis_produk.ShowDialog()
    End Sub

    Private Sub PemasokToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Fpemasok.ShowDialog()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Bexit.PerformClick()
    End Sub

    Private Sub Btambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btambah.Click
        runQuery("insert into tbl_detail_pembelian (id_pembelian,id_obat,jumlah,harga,id_pemasok) values ('" & id_pembelian & "', " & Cobat.SelectedValue & "," & Tjumlah.Value & "," & Tharga.Value & "," & Cpemasok.SelectedValue & ")")
        Call getPembelian()
        Call totalBayar()
        Cobat.SelectedIndex = -1
        Cpemasok.SelectedIndex = -1
        Tjumlah.ResetText()
    End Sub

    Private Sub DaftarPembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarPembelianToolStripMenuItem.Click
        Fdatar_pembelian.ShowDialog()
    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub
End Class