Public Class Fkondisi

    Private Sub Fkondisi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call setKoneksi()
        fetchData(DGkondisi, "select nm_kondisi as `Nama Kondisi` from tbl_kondisi_lahir")
    End Sub

    Private Sub Bsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsimpan.Click
        runQuery("insert into tbl_kondisi_lahir (nm_kondisi) values ('" & Tkondisi.Text & "')")
        Call successMessage()
        fetchData(DGkondisi, "select nm_kondisi as `Nama Kondisi` from tbl_kondisi_lahir")
        Tkondisi.Focus()
        Tkondisi.Clear()
    End Sub

    Private Sub Bkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bkeluar.Click
        Me.Close()
    End Sub
End Class