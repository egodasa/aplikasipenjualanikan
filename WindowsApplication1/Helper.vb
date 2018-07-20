Imports MySql.Data.MySqlClient
Imports System.Text
Module helper
    Public kon As MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As New DataSet
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public str As String
    Public username As String
    Public jenis_pengguna As String
    Public main_form As Form
    Public _DIR As String = "F:\Program\visual_basic\skripsitia\WindowsApplication1\"
    Sub setKoneksi()
        str = "Server=localhost;uid=root;pwd=;database=dblaporan_penjualan;port=3306"
        kon = New MySqlConnection(str)
        If kon.State = ConnectionState.Closed Then
            Try
                kon.Open()
            Catch ex As Exception
                MsgBox("Tidak dapat terhubung kedatabase" & vbCrLf & "Pesan error : " & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error")
                main_form.Close()
            End Try
        Else
            MsgBox("Tidak dapat terhubung kedatabase.", MsgBoxStyle.Critical, "Error")
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
            Return New DataSet
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
        End Try

    End Sub
    Sub successMessage()
        MessageBox.Show("Data berhasil disimpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Sub editMessage()
        MessageBox.Show("Data berhasil diubah", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Sub fetchComboboxData(ByVal sql As String, ByVal name As ComboBox, ByVal caption As String, ByVal value As String)
        name.DataSource = fetchData(sql)
        name.ValueMember = value
        name.DisplayMember = caption
        name.ResetText()
        name.Refresh()
    End Sub
End Module
