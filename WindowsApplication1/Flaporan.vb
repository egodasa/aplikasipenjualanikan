Public Class Flaporan
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If jenis_pengguna = "Admin" Then
            main_form.Show()
        Else
            Flogin.Show()
        End If
        Me.Close()
    End Sub
End Class