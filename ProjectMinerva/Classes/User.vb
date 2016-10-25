Imports ProjectMinerva.JupiterDataSetTableAdapters

Public Class User
    Private IDValue As Integer
    Private UsernameValue As String
    Private PasswordValue As String
    Private PositionValue As String
    Private AvatarValue As Image
    Private SavedValue As Boolean

    Public Property ID() As Integer
        Get
            Return IDValue
        End Get
        Set(value As Integer)
            IDValue = value
        End Set
    End Property

    Public Property Username() As String
        Get
            Return UsernameValue
        End Get
        Set(value As String)
            UsernameValue = Trim(value)
        End Set
    End Property

    Public Property Password() As String
        Get
            Return PasswordValue
        End Get
        Set(value As String)
            PasswordValue = Trim(value)
        End Set
    End Property

    Public Property Position() As String
        Get
            Return PositionValue
        End Get
        Set(value As String)
            PositionValue = Trim(value)
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

    Public Sub Create(Table As UsersTableAdapter)
        Dim Result As Integer
        Result = Table.InsertUser(UsernameValue, PasswordValue, PositionValue)
        If Result = 1 Then
            SavedValue = True
        Else
            SavedValue = False
        End If
    End Sub

    Public Function Saved()
        Return SavedValue
    End Function

    Public Sub SetFromRow(Row As DataGridViewRow)
        Dim Cells = Row.Cells
        IDValue = Cells.Item(0).Value
        UsernameValue = Trim(Cells.Item(1).Value)
        PasswordValue = Trim(Cells.Item(2).Value)
        PositionValue = Trim(Cells.Item(3).Value)
        'AvatarValue = Cells.Item(4).Value
    End Sub

    Public Function IsSame(UserTwo As User)
        Dim UserOneArray = Me.ToArray()
        Dim UserTwoArray = UserTwo.ToArray()
        Dim Same As Boolean

        For index = 0 To UserOneArray.GetUpperBound(0)
            If UserOneArray(index).Equals(UserTwoArray(index)) Then
                Same = True
            Else
                Same = False
                Exit For
            End If
        Next
        Return Same
    End Function

    Public Function ToArray()
        Dim Attributes = {
            Trim(Me.Username.ToString),
            Trim(Me.Password.ToString),
            Trim(Me.Position.ToString),
            Trim(Me.Avatar.ToString)
            }
        Return Attributes
    End Function

    Public Sub Update(Table As UsersTableAdapter)
        Dim Result As Integer
        Result = Table.UpdateUser(UsernameValue, PasswordValue, PositionValue, IDValue)
        If Result = 1 Then
            SavedValue = True
        Else
            SavedValue = False
        End If
    End Sub
End Class
