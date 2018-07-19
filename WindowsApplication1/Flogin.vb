Public Class Flogin
    Dim data_pengguna As DataTable
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Bedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bedit.Click
        data_pengguna = fetchData("select * from tbl_pengguna where username = '" & Tusername.Text & "' AND password=md5('" & Tpassword.Text & "')")
        If data_pengguna.Rows.Count = 1 Then
            username = Tusername.Text
            jenis_pengguna = data_pengguna.Rows(0).Item("jenis")
            Tusername.Clear()
            Tpassword.Clear()
            If data_pengguna.Rows(0).Item("jenis") = "Admin" Or data_pengguna.Rows(0).Item("jenis") = "Apoteker" Then
                Fmenu.Show()
            Else
                Flaporan.Show()
            End If
            Me.Hide()
        Else
            MessageBox.Show("Username atau password salah!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Tusername.Clear()
            Tpassword.Clear()
            Tusername.Focus()
        End If
    End Sub

    Private Sub Flogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call setKoneksi()
    End Sub
End Class