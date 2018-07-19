Public Class Fmenu

    Private Sub Fmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Activated, MyBase.GotFocus
        Call setKoneksi()
        If jenis_pengguna = "Admin" Then
            Me.Size = New Size(577, 370)
            Blaporan.Visible = True
            Bobat.Visible = True
            Bjobat.Visible = True
            Bpemasok.Visible = True
            Bstok.Visible = True
            Bpengguna.Visible = True
            Beoq.Visible = True
            Btransaksi.Visible = True
            Beoq.Location = New Point(12, 246)
            Btransaksi.Location = New Point(199, 246)
            Button7.Location = New Point(465, 290)
        Else
            Me.Size = New Size(577, 274)
            Button7.Location = New Point(465, 196)
            Beoq.Location = New Point(12, 63)
            Btransaksi.Location = New Point(199, 63)
            Beoq.Visible = True
            Btransaksi.Visible = True
            Bobat.Visible = False
            Bjobat.Visible = False
            Blaporan.Visible = False
            Bpemasok.Visible = False
            Bstok.Visible = False
            Bpengguna.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bobat.Click
        Fkelola_obat.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btransaksi.Click
        Ftransaksi.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bjobat.Click
        Fsatuan.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Flogin.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bpemasok.Click
        Fpemasok.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bstok.Click
        Fpembelian.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Beoq.Click
        Feoq.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bpengguna.Click
        Fpengguna.Show()
        Me.Hide()
    End Sub

    Private Sub Blaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blaporan.Click
        Flaporan.Show()
        Me.Hide()
    End Sub
End Class