Public Class Fmenu

    Private Sub Fmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call setKoneksi()
        If jenis_pengguna = "Admin" Then
            Bobat.Visible = True
            Bjobat.Visible = True
            Bpemasok.Visible = True
            Bstok.Visible = True
            Bpengguna.Visible = True
            Beoq.Visible = False
            Btransaksi.Visible = False
        Else
            Beoq.Visible = True
            Btransaksi.Visible = True
            Bobat.Visible = False
            Bjobat.Visible = False
            Bpemasok.Visible = False
            Bstok.Visible = False
            Bpengguna.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bobat.Click
        Fkelola_produk.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btransaksi.Click
        Fpenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bjobat.Click
        Fjenis_produk.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Flogin.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bpemasok.Click
        Fpemasok.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bstok.Click
        Fpembelian.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Feoq.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bpengguna.Click
        Fpengguna.Show()
        Me.Hide()
    End Sub
End Class