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
    Public main_form As Form = Flogin
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
    Function SqlString(x As String)
        Return "'" & x & "'"
    End Function
    Function SelectSqlQuery(ByVal table As String, ByVal x As List(Of SqlBuilder.Sql))
        Dim hasil As New List(Of String)
        For Each y As SqlBuilder.Sql In x
            hasil.Add(y.Name)
        Next
        Return "select " & String.Join(",", hasil) & " from " & table & ";"
    End Function
    Function InsertSqlQuery(ByVal table As String, ByVal x As List(Of SqlBuilder.Sql))
        Dim kolom As New List(Of String)
        Dim nilai As New List(Of String)
        For Each y As SqlBuilder.Sql In x
            kolom.Add("`" + y.Name + "`")
            nilai.Add(y.Value.ToString())
        Next
        Return "insert into " & table & " (" & String.Join(",", kolom) & ") values(" & String.Join(",", nilai) & ");"
    End Function
    Function UpdateSqlQuery(ByVal table As String, ByVal x As List(Of SqlBuilder.Sql), ByVal where As String, ByVal where_val As String)
        Dim hasil As New List(Of String)
        For Each y As SqlBuilder.Sql In x
            hasil.Add(y.Name + " = " + y.Value)
        Next
        Return "update " & table & " set " & String.Join(",", hasil) & " where " & where & " = " & where_val & ";"
    End Function
    Function DeleteSqlQuery(ByVal t As String, ByVal id As String, ByVal id_val As String)
        Return "delete from " & t & " where " & id & " = " & id_val
    End Function
End Module
