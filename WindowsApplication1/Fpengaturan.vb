Imports SqlHelper
Public Class Fpengaturan
    Private Sub Fpengaturan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tusername.Text = My.Settings.db_username
        Tpassword.Text = My.Settings.db_password
        Tserver.Text = My.Settings.db_server
        Tnm.Text = My.Settings.db_database
    End Sub

    Private Sub Bexit_Click(sender As Object, e As EventArgs) Handles Bexit.Click
        Flogin.Show()
        Me.Close()
    End Sub

    Private Sub Bsave_Click(sender As Object, e As EventArgs) Handles Bsave.Click
        Dim hasil As SqlMessages = TestKoneksi(Tusername.Text, Tpassword.Text, Tserver.Text)
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
    Private Sub StartShow()
        Tnm.Visible = False
        Label1.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Label5.Visible = True
        ProgressMysql.Visible = True
    End Sub
    Private Sub EndShow()
        Tnm.Visible = True
        Label1.Visible = True
        Button1.Visible = True
        Button2.Visible = True
        Label5.Visible = False
        ProgressMysql.Visible = False
        My.Settings.db_database = Tnm.Text
        My.Settings.Save()
        MessageBox.Show("Database Berhasil Dibuat!", "Pesan")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim hasil As SqlMessages = TestKoneksi(Tusername.Text, Tpassword.Text, Tserver.Text)
        If hasil.code <> 1 Then
            MessageBox.Show("Tidak dapat terhubung ke database. Silahkan ganti pengaturan database")
        Else
            My.Settings.db_database = Nothing
            My.Settings.Save()
            If MysqlWorker.IsBusy = False Then
                StartShow()
                MysqlWorker.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.db_database = Tnm.Text
        MessageBox.Show("Database berhasil diatur", "Pesan")
    End Sub

    Private Sub MysqlWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles MysqlWorker.DoWork
        RunQueryAsync("DROP DATABASE IF EXISTS " & Tnm.Text & "; CREATE DATABASE " & Tnm.Text & "; USE " & Tnm.Text & ";" & IO.File.OpenText("database/dblaporan_penjualanv2.sql").ReadToEnd())
    End Sub

    Private Sub MysqlWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles MysqlWorker.RunWorkerCompleted
        EndShow()
    End Sub

    Private Sub MysqlWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles MysqlWorker.ProgressChanged
        ProgressMysql.Value = Convert.ToDouble(e.ProgressPercentage)
    End Sub
End Class
