Public Class Fjenis_produk
    Dim getData As String = "select id_jobat, nm_jobat as 'Jenis Obat' from tbl_jenis_obat"
    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub jenis_obat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGjobat.DataSource = fetchData(getData)
        DGjobat.Columns("id_jobat").Visible = False
    End Sub

    Private Sub Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DGjobat_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGjobat.CellDoubleClick
        Bedit.Enabled = True
        Bdelete.Enabled = True
        Bcancel.Enabled = True
        Bsave.Enabled = False
        Tnm_jenis.Text = DGjobat.CurrentRow.Cells(1).Value
    End Sub

    Private Sub Bedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bedit.Click
        runQuery("update tbl_jenis_obat set nm_jobat = '" & Tnm_jenis.Text & "' where id_jobat = " & DGjobat.CurrentRow.Cells(0).Value)
        Call editMessage()
        Bcancel.PerformClick()
        DGjobat.DataSource = fetchData(getData)
    End Sub

    Private Sub Bcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancel.Click
        Bedit.Enabled = False
        Bdelete.Enabled = False
        Bcancel.Enabled = False
        Bsave.Enabled = True
        Tnm_jenis.Clear()
    End Sub

    Private Sub Bdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bdelete.Click
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            runQuery(deleteSql("tbl_jenis_obat", "id_jobat", DGjobat.CurrentRow.Cells("id_jobat").Value))
            DGjobat.DataSource = fetchData(getData)
            Bcancel.PerformClick()
        End If
    End Sub

    Private Sub Bsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsave.Click
        runQuery("insert into tbl_jenis_obat (nm_jobat) values ('" & Tnm_jenis.Text & "')")
        Call successMessage()
        Tnm_jenis.Clear()
        DGjobat.DataSource = fetchData(getData)
        Tnm_jenis.Focus()
    End Sub

    Private Sub Bexit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Fmenu.Show()
            Me.Close()
        End If
    End Sub
End Class