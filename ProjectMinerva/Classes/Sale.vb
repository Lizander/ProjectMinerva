Public Class Sale
    Private IDValue As Integer
    Private CustomerReference As Customer
    Private SubtotalValue As Double
    Private TotalValue As Double
    Private DiscountValue As Double
    Private StateTaxValue As Double
    Private MunicipalTaxValue As Double
    Private DateValue As String
    Private TimeValue As String
    Private UserReference As User
    Private WarrantyValue As String
    Private PaymentTypeValue As String


    Public ReadOnly Property ID() As Integer
        Get
            Return IDValue
        End Get
    End Property

    Friend Property Customer() As Customer
        Get
            Return CustomerReference
        End Get
        Set(value As Customer)
            CustomerReference = value
        End Set
    End Property

    Public ReadOnly Property Subotal() As Double
        Get
            Return SubtotalValue
        End Get
    End Property

    Public ReadOnly Property Total() As Double
        Get
            Return TotalValue
        End Get
    End Property

    Public ReadOnly Property Discount() As Double
        Get
            Return DiscountValue
        End Get
    End Property

    Public ReadOnly Property StateTax() As Double
        Get
            Return StateTaxValue
        End Get
    End Property

    Public ReadOnly Property MunicipalTax() As Double
        Get
            Return MunicipalTaxValue
        End Get
    End Property

    Public Property DateMade() As String
        Get
            Return DateValue
        End Get
        Set(value As String)
            DateValue = value
        End Set
    End Property

    Public Property TimeMade() As String
        Get
            Return TimeValue
        End Get
        Set(value As String)
            TimeValue = value
        End Set
    End Property

    Friend Property Employee() As User
        Get
            Return UserReference
        End Get
        Set(value As User)
            UserReference = value
        End Set
    End Property

    Public ReadOnly Property Warranty() As String
        Get
            Return WarrantyValue
        End Get
    End Property

    Public Property PaymentType() As String
        Get
            Return PaymentTypeValue
        End Get
        Set(value As String)
            PaymentTypeValue = value
        End Set
    End Property
End Class
