Public Class Note
    Private IDValue As Integer
    Private ObjectIDValue As Integer
    Private ObjectTypeValue As String
    Private MessageValue As String
    Private DateValue As String
    Private CustomerReference As Customer
    Private SaleReference As Sale
    Private SupplierReference As Supplier
    Private UserReference As User

    Public ReadOnly Property ID() As Integer
        Get
            Return IDValue
        End Get
    End Property

    Public Property ObjectID() As Integer
        Get
            Return ObjectIDValue
        End Get
        Set(value As Integer)
            ObjectIDValue = value
        End Set
    End Property

    Public Property ObjectType() As String
        Get
            Return ObjectTypeValue
        End Get
        Set(value As String)
            ObjectTypeValue = value
        End Set
    End Property

    Public Property DateMade() As String
        Get
            Return DateValue
        End Get
        Set(value As String)
            DateValue = value
        End Set
    End Property

    Public Property Message() As String
        Get
            Return MessageValue
        End Get
        Set(value As String)
            MessageValue = value
        End Set
    End Property

    'TODO method or property that returns correct reference object
End Class
