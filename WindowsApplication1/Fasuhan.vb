Public Class Fasuhan

    Private Sub Bsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsimpan.Click
        runQuery("insert into tbl_asuhan_bayi (nm_asuhan) values ('" & Tasuhan.Text & "')")
        Call successMessage()
        fetchData(DGasuhan, "select nm_asuhan as `Nama Asuhan Pada Bayi` from tbl_asuhan_bayi")
        Tasuhan.Focus()
        Tasuhan.Clear()
    End Sub

    Private Sub Bkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bkeluar.Click
        Me.Close()
    End Sub
End Class