Namespace SqlHelper
    Public Class Query
        Public Name As String
        Public Value As Object
        Public Caption As String
        Public Insertable As Boolean
        Public Sub New(ByVal Name As String, Value As String, Caption As String, Optional ByVal Insertable As Boolean = True)
            Me.Name = Name
            Me.Value = Value
            Me.Caption = Caption
            Me.Insertable = Insertable
        End Sub
        Public Shared Function SqlString(x As String)
            Return "'" & x & "'"
        End Function
        Public Shared Function SelectAllSqlQuery(ByVal table As String)
            Return "select * from " & table
        End Function
        Public Shared Function SelectSqlQuery(ByVal table As String, ByVal x As List(Of Query))
            Dim hasil As New List(Of String)
            For Each y As Query In x
                hasil.Add(y.Name + " AS `" + y.Caption + "`")
            Next
            Return "select " & String.Join(",", hasil) & " from " & table & ";"
        End Function
        Public Shared Function InsertSqlQuery(ByVal table As String, ByVal x As List(Of Query))
            Dim kolom As New List(Of String)
            Dim nilai As New List(Of String)
            For Each y As Query In x
                If y.Insertable = True Then
                    kolom.Add("`" + y.Name + "`")
                    nilai.Add(y.Value.ToString())
                End If
            Next
            Return "insert into " & table & " (" & String.Join(",", kolom) & ") values(" & String.Join(",", nilai) & ");"
        End Function
        Public Shared Function UpdateSqlQuery(ByVal table As String, ByVal x As List(Of Query), ByVal where As String, ByVal where_val As String)
            Dim hasil As New List(Of String)
            For Each y As Query In x
                If y.Insertable = True Then
                    hasil.Add(y.Name + " = " + y.Value)
                End If
            Next
            Return "update " & table & " set " & String.Join(",", hasil) & " where " & where & " = " & where_val & ";"
        End Function
        Public Shared Function DeleteSqlQuery(ByVal t As String, ByVal id As String, ByVal id_val As String)
            Return "delete from " & t & " where " & id & " = " & id_val
        End Function
    End Class
    Public Class DataQuery
        Public table As String
        Public view As String
        Public primary_key As String
        Public primary_key_caption As String
        Public formData As New List(Of Query)
        Public Function SelectAll()
            If Me.view = Nothing Then
                Return Query.SelectAllSqlQuery(Me.table)
            Else
                Return Query.SelectAllSqlQuery(Me.view)
            End If
        End Function
        Public Function SelectMultiple()
            If Me.view = Nothing Then
                Return Query.SelectSqlQuery(Me.table, Me.formData)
            Else
                Return Query.SelectSqlQuery(Me.view, Me.formData)
            End If
        End Function
        Public Function Insert()
            Return Query.InsertSqlQuery(Me.table, Me.formData)
        End Function
        Public Function Update(ByVal val_where As String)
            Return Query.UpdateSqlQuery(Me.table, formData, Me.primary_key, val_where)
        End Function
        Public Function Delete(ByVal val_where As String)
            Return Query.DeleteSqlQuery(Me.table, Me.primary_key, val_where)
        End Function
    End Class
End Namespace
