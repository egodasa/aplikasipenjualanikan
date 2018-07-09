Imports MySql.Data.MySqlClient
Module db
    Public kon As MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As New DataSet
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public str As String
    Public username As String
    Public jenis_pengguna As String
    Public _DIR As String = "F:\skripsitia\WindowsApplication1\"
    Sub setKoneksi()
        str = "Server=192.168.56.1;uid=root;pwd=12345s6;database=db_apotek;port=3306"
        kon = New MySqlConnection(str)
        If kon.State = ConnectionState.Closed Then
            Try
                kon.Open()
            Catch ex As Exception
                MsgBox("Tidak dapat terhubung kedatabase" & vbCrLf & "Pesan error : " & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error")
                Stop
            End Try
        Else
            MsgBox("Tidak dapat terhubung kedatabase.", MsgBoxStyle.Critical, "Error")
            Stop
        End If
    End Sub
    Function fetchData(ByVal q As String)
        Call setKoneksi()
        Try
            da = New MySqlDataAdapter(q, kon)
            ds = New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox("Terdapat kesalahan pada eksekusi SQL." & vbCrLf & "Pesan error : " & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "Kesalahan")
            Return Nothing
        End Try
    End Function
    Sub runQuery(ByVal q As String)
        Try
            cmd = New MySqlCommand(q, kon)
            cmd.Connection = kon
            cmd.CommandType = CommandType.Text
            cmd.CommandText = q
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Terdapat kesalahan pada eksekusi SQL." & vbCrLf & "Pesan error : " & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "Kesalahan")
            Stop
        End Try
        
    End Sub
    Sub successMessage()
        MessageBox.Show("Data berhasil disimpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Sub editMessage()
        MessageBox.Show("Data berhasil diubah", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Function deleteSql(ByVal t As String, ByVal id As String, ByVal id_val As String)
        Return "delete from " & t & " where " & id & " = " & id_val
    End Function
    Sub fetchComboboxData(ByVal sql As String, ByVal name As ComboBox, ByVal caption As String, ByVal value As String)
        name.DataSource = fetchData(sql)
        name.ValueMember = value
        name.DisplayMember = caption
        name.ResetText()
        name.Refresh()
    End Sub
End Module
