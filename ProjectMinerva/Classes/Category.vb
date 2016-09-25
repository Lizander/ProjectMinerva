Public Class Category
    Private IDValue As Integer
    Private NameValue As String

    Public ReadOnly Property ID() As Integer
        Get
            Return IDValue
        End Get
    End Property

    Public Property Name() As String
        Get
            Return NameValue
        End Get
        Set(value As String)
            NameValue = value
        End Set
    End Property

End Class
