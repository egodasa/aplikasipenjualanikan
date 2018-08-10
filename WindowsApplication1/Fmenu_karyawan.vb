Public Class Fmenu_karyawan
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Flogin.Show()
        main_form.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Fpenjualan_produk.Show()
        main_form.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Fpembelian_produk.Show()
        main_form.Hide()
    End Sub

    Private Sub Fmenu_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class