Namespace SqlHelper
    Public Class SqlView
        Public Name As String
        Public Caption As String
        Public Sub New(ByVal Name As String, ByVal Caption As String)
            Me.Name = Name
            Me.Caption = Caption
        End Sub
    End Class
    Public Class SqlManipulation
        Public Name As String
        Public Value As Object
        Public Sub New(ByVal Name As String, ByVal Value As String)
            Me.Name = Name
            Me.Value = Value
        End Sub
    End Class
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
        Public Shared Function SelectAll(ByVal table As String, Optional ByVal where As String = Nothing, Optional ByVal op As String = Nothing, Optional ByVal where_val As String = Nothing)
            If where <> Nothing Then
                Return "select * from " & table & " where " & String.Join(" ", where, op, where_val)
            Else
                Return "select * from " & table
            End If
        End Function
        Public Shared Function SelectMultiple(ByVal table As String, ByVal x As List(Of SqlView), Optional ByVal where As String = Nothing, Optional ByVal op As String = Nothing, Optional ByVal where_val As String = Nothing)
            Dim hasil As New List(Of String)
            For Each y As SqlView In x
                hasil.Add(y.Name + " AS `" + y.Caption + "`")
            Next
            If where <> Nothing Then
                Return "select " & String.Join(",", hasil) & " from " & table & "where " & String.Join(" ", where, op, where_val)
            Else
                Return "select " & String.Join(",", hasil) & " from " & table & ";"
            End If

        End Function
        Public Shared Function Insert(ByVal table As String, ByVal x As List(Of SqlManipulation))
            Dim kolom As New List(Of String)
            Dim nilai As New List(Of String)
            For Each y As SqlManipulation In x
                kolom.Add("`" + y.Name + "`")
                nilai.Add(y.Value.ToString())
            Next
            Return "insert into " & table & " (" & String.Join(",", kolom) & ") values(" & String.Join(",", nilai) & ");"
        End Function
        Public Shared Function Update(ByVal table As String, ByVal x As List(Of SqlManipulation), ByVal where As String, ByVal where_val As String)
            Dim hasil As New List(Of String)
            For Each y As SqlManipulation In x
                hasil.Add(y.Name + " = " + y.Value)
            Next
            Return "update " & table & " set " & String.Join(",", hasil) & " where " & where & " = " & where_val & ";"
        End Function
        Public Shared Function Delete(ByVal t As String, ByVal id As String, ByVal id_val As String)
            Return "delete from " & t & " where " & id & " = " & id_val
        End Function
    End Class
    Public Class DataQuery
        Public table As String
        Public view As String
        Public primary_key As String
        Public primary_key_caption As String
        Public formData As New List(Of SqlManipulation)
        Public viewData As New List(Of SqlView)
        Public Function SelectAll(Optional ByVal where As String = Nothing, Optional ByVal op As String = Nothing, Optional ByVal where_val As String = Nothing)
            Dim tabel = Me.table
            If Me.view <> Nothing Then
                tabel = Me.view
            End If
            If where <> Nothing Then
                Return Query.SelectAll(tabel, where, op, where_val)
            Else
                Return Query.SelectAll(tabel)
            End If

        End Function
        Public Function SelectMultiple(Optional ByVal where As String = Nothing, Optional ByVal op As String = Nothing, Optional ByVal where_val As String = Nothing)
            Dim tabel = Me.table
            If Me.view <> Nothing Then
                tabel = Me.view
            End If
            If where <> Nothing Then
                Return Query.SelectMultiple(tabel, Me.viewData, where, op, where_val)
            Else
                Return Query.SelectMultiple(tabel, Me.viewData)
            End If

        End Function
        Public Function Insert()
            Return Query.Insert(Me.table, Me.formData)
        End Function
        Public Function Update(ByVal val_where As String)
            Return Query.Update(Me.table, formData, Me.primary_key, val_where)
        End Function
        Public Function Delete(ByVal val_where As String)
            Return Query.Delete(Me.table, Me.primary_key, val_where)
        End Function
    End Class
    Public Class SqlMessages
        Public code As Integer
        Public message As String
        Public Sub New(ByVal kode As Integer, ByVal pesan As String)
            code = kode
            message = pesan
        End Sub
    End Class
End Namespace
