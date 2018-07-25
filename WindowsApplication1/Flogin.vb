Public Class Flogin
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim data_pengguna As DataTable = FetchData("select * from tbl_pengguna where username = '" & Tusername.Text & "' AND password=md5('" & Tpassword.Text & "')")
        If data_pengguna.Rows.Count = 1 Then
            username = Tusername.Text
            jenis_pengguna = data_pengguna.Rows(0).Item("jenis")
            Tusername.Clear()
            Tpassword.Clear()
            If data_pengguna.Rows(0).Item("jenis") = "Admin" Or data_pengguna.Rows(0).Item("jenis") = "Karyawan" Then
                main_form.Show()
            Else
                main_form.Show()
            End If
            Me.Hide()
        Else
            MessageBox.Show("Username atau password salah!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Tusername.Clear()
            Tpassword.Clear()
            Tusername.Focus()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click
        Fpengaturan.ShowDialog()
    End Sub
End Class
