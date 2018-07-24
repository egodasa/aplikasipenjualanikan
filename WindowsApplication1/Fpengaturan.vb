Public Class Fpengaturan
    Private Sub Fpengaturan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tusername.Text = My.Settings.db_username
        Tpassword.Text = My.Settings.db_password
        Tserver.Text = My.Settings.db_server
        Tnm.Text = My.Settings.db_database
    End Sub

    Private Sub Bexit_Click(sender As Object, e As EventArgs) Handles Bexit.Click
        main_form.Show()
        Me.Close()
    End Sub

    Private Sub Bsave_Click(sender As Object, e As EventArgs) Handles Bsave.Click
        Dim hasil As SqlHelper.SqlMessages = TestKoneksi(Tusername.Text, Tpassword.Text, Tserver.Text)
        If hasil.code = 0 Then
            MessageBox.Show(hasil.message & " Username atau Password tidak cocok", "Error")
        ElseIf hasil.code = 1 Then
            MessageBox.Show(hasil.message & " Silahkan ketik nama database dan klik tombol BUAT DATABASE", "Pesan")
            My.Settings.db_username = Tusername.Text
            My.Settings.db_password = Tpassword.Text
            My.Settings.db_server = Tserver.Text
            My.Settings.Save()
        ElseIf hasil.code = 2 Then
            MessageBox.Show(hasil.message, "Error")
        End If
    End Sub
    Private Sub toggleShow()
        Tnm.Visible = Not Tnm.Visible
        Label1.Visible = Not Label1.Visible
        Label5.Visible = Not Label5.Visible
        Button1.Visible = Not Button1.Visible
        Button2.Visible = Not Button2.Visible
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        toggleShow()
        Dim hasil As SqlHelper.SqlMessages = TestKoneksi(Tusername.Text, Tpassword.Text, Tserver.Text)
        If hasil.code <> 1 Then
            MessageBox.Show("Tidak dapat terhubung ke database. Silahkan ganti pengaturan database")
        Else
            My.Settings.db_database = Nothing
            My.Settings.Save()
            runQuery("DROP DATABASE IF EXISTS " & Tnm.Text & "; CREATE DATABASE " & Tnm.Text & "; USE " & Tnm.Text & ";")
            My.Settings.db_database = Tnm.Text
            My.Settings.Save()
            runQuery(IO.File.OpenText("database/dblaporan_penjualanv2.sql").ReadToEnd())
            MessageBox.Show("Database berhasil dibuat", "Pesan")
        End If
        toggleShow()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.db_database = Tnm.Text
        MessageBox.Show("Database berhasil diatur", "Pesan")
    End Sub
End Class