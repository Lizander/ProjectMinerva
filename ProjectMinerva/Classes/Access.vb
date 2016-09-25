Public Class Access
    Private IDValue As Integer
    Private UserReference As User
    Private AccessNameValue As String
    Private AllowedValue As String
    Private EditableValue As String

    Public ReadOnly Property ID() As String
        Get
            Return IDValue
        End Get
    End Property

    Public Property User() As User
        Get
            Return UserReference
        End Get
        Set(value As User)
            UserReference = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return AccessNameValue
        End Get
        Set(value As String)
            AccessNameValue = value
        End Set
    End Property

    Public Property Allowed() As String
        Get
            Return AllowedValue
        End Get
        Set(value As String)
            AllowedValue = value
        End Set
    End Property

    Public Property Editable() As String
        Get
            Return EditableValue
        End Get
        Set(value As String)
            EditableValue = value
        End Set
    End Property

End Class
