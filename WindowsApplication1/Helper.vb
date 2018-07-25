Imports MySql.Data.MySqlClient
Module helper
    Public kon As MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As New DataSet
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public str As String
    Public username As String
    Public jenis_pengguna As String
    Public main_form As Form = Fmenu
    Public _DIR As String = My.Settings.apps_folder
    Function TestKoneksi(ByVal username As String, ByVal password As String, ByVal server As String, Optional ByVal db As String = Nothing)
        Dim str = "Server=" & server & ";uid=" & username & ";pwd=" & password & ";database=" & db & ";port=3306"
        kon = New MySqlConnection(str)
        If kon.State = ConnectionState.Closed Then
            Try
                kon.Open()
                kon.Close()
                Return New SqlHelper.SqlMessages(1, "Koneksi MYSQL berhasil!")
            Catch ex As Exception
                Return New SqlHelper.SqlMessages(2, "Tidak dapat terhubung ke MYSQL " & vbCrLf & "Pesan error : " & vbCrLf & ex.Message)
            End Try
        Else
            Return New SqlHelper.SqlMessages(0, "Tidak dapat terhubung ke MYSQL. Pastikan MYSQL sudah dihidupkan.")
        End If
    End Function
    Sub SetKoneksi()
        str = "Server=" & My.Settings.db_server & ";uid=" & My.Settings.db_username & ";pwd=" & My.Settings.db_password & ";database=" & My.Settings.db_database & ";port=3306"
        kon = New MySqlConnection(str)
        If kon.State = ConnectionState.Closed Then
            Try
                kon.Open()
            Catch ex As Exception
                MsgBox("Tidak dapat terhubung kedatabase" & vbCrLf & "Pesan error : " & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error")
                End
            End Try
        Else
            MsgBox("Tidak dapat terhubung kedatabase.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Function FetchData(ByVal q As String)
        Call SetKoneksi()
        Try
            da = New MySqlDataAdapter(q, kon)
            ds = New DataSet
            da.Fill(ds)
            kon.Close()
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox("Terdapat kesalahan pada eksekusi SQL." & vbCrLf & "Pesan error : " & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "Kesalahan")
            Return New DataSet
        End Try
    End Function
    Sub RunQuery(ByVal q As String)
        Call SetKoneksi()
        Try
            cmd = New MySqlCommand(q, kon)
            cmd.Connection = kon
            cmd.CommandType = CommandType.Text
            cmd.CommandText = q
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Terdapat kesalahan pada eksekusi SQL." & vbCrLf & "Pesan error : " & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "Kesalahan")
            End
        Finally
            kon.Close()
        End Try
    End Sub
    Sub RunQueryAsync(ByVal q As String)
        Call SetKoneksi()
        Dim rowsAffected As Int32
        Try
            cmd = New MySqlCommand(q, kon)
            cmd.Connection = kon
            cmd.CommandType = CommandType.Text
            cmd.CommandText = q
            Dim myResult As IAsyncResult = cmd.BeginExecuteNonQuery(Nothing, Nothing)
            rowsAffected = cmd.EndExecuteNonQuery(myResult)
            kon.Close()
        Catch ex As Exception
            MsgBox("Terdapat kesalahan pada eksekusi SQL." & vbCrLf & "Pesan error : " & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "Kesalahan")
            End
        Finally
            kon.Close()
        End Try
    End Sub
    Sub successMessage()
        MessageBox.Show("Data berhasil disimpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Sub editMessage()
        MessageBox.Show("Data berhasil diubah", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Sub FetchComboboxData(ByVal sql As String, ByVal name As ComboBox, ByVal caption As String, ByVal value As String)
        name.DataSource = FetchData(sql)
        name.ValueMember = value
        name.DisplayMember = caption
        name.ResetText()
        name.Refresh()
    End Sub
    Function rupiah(ByVal x As Integer)
        Return Format(x, "Rp,   ##,##0")
    End Function
End Module
