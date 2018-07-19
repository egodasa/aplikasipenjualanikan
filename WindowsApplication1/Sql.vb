Namespace SqlBuilder
    Public Class Sql
        Public Name As String
        Public Value As Object
        Public Sub New(ByVal Name As String, Value As String)
            Me.Name = Name
            Me.Value = Value
        End Sub
    End Class
End Namespace
