Public Class User
    Private IDValue As Integer
    Private UsernameValue As String
    Private PasswordValue As String
    Private PositionValue As String
    Private AvatarValue As Image

    Public ReadOnly Property ID() As Integer
        Get
            Return IDValue
        End Get
    End Property

    Public Property Username() As String
        Get
            Return UsernameValue
        End Get
        Set(value As String)
            UsernameValue = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return PasswordValue
        End Get
        Set(value As String)
            PasswordValue = value
        End Set
    End Property

    Public Property Position() As String
        Get
            Return PositionValue
        End Get
        Set(value As String)
            PositionValue = value
        End Set
    End Property

    Public Property Avatar() As Image
        Get
            Return AvatarValue
        End Get
        Set(value As Image)
            AvatarValue = value
        End Set
    End Property
End Class
