Public Class LineItem
    Private IDValue As Integer
    Private ItemIDValue As Integer
    Private ItemTypeValue As String
    Private PriceValue As Double
    Private QuantityValue As Integer
    Private SaleReference As Sale
    Private DescriptionValue As String
    Private CategoryValue As String
    Private ExtendedPriceValue As Double
    Private SubtotalOneValue As Double
    Private SubtotalTwoValue As Double
    Private DiscountPriceValue As Double
    Private StateTaxValue As Double
    Private MunicipalTaxValue As Double
    Private CostValue As Double

    Public ReadOnly Property ID() As Integer
        Get
            Return IDValue
        End Get
    End Property

    Public Property ItemID() As Integer
        Get
            Return ItemIDValue
        End Get
        Set(value As Integer)
            ItemIDValue = value
        End Set
    End Property

    Public Property ItemType() As String
        Get
            Return ItemTypeValue
        End Get
        Set(value As String)
            ItemTypeValue = value
        End Set
    End Property

    Public Property Price() As Double
        Get
            Return PriceValue
        End Get
        Set(value As Double)
            PriceValue = value
        End Set
    End Property

    Public Property Quantity() As Integer
        Get
            Return QuantityValue
        End Get
        Set(value As Integer)
            QuantityValue = value
        End Set
    End Property

    Public Property Sale() As Sale
        Get
            Return SaleReference
        End Get
        Set(value As Sale)
            SaleReference = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return DescriptionValue
        End Get
        Set(value As String)
            DescriptionValue = value
        End Set
    End Property

    Public Property Category() As String
        Get
            Return CategoryValue
        End Get
        Set(value As String)
            CategoryValue = value
        End Set
    End Property

    Public ReadOnly Property ExtendedPrice() As Double
        'TODO introduce method that calculates this
        Get
            Return ExtendedPriceValue
        End Get
    End Property

    Public ReadOnly Property SubtotalOne() As Double
        'TODO introduce method that calculates this
        Get
            Return SubtotalOneValue
        End Get
    End Property

    Public ReadOnly Property SubtotalTwo() As Double
        'TODO introduce method that calculates this
        Get
            Return SubtotalTwoValue
        End Get
    End Property

    Public ReadOnly Property DiscountPrice() As Double
        'TODO introduce method that calculates this
        Get
            Return DiscountPriceValue
        End Get
    End Property

    Public ReadOnly Property StateTax() As Double
        'TODO introduce method that calculates this
        Get
            Return StateTaxValue
        End Get
    End Property

    Public ReadOnly Property MunicipalTax() As Double
        'TODO introduce method that calculates this
        Get
            Return MunicipalTaxValue
        End Get
    End Property

    Public Property Cost() As Double
        Get
            Return CostValue
        End Get
        Set(value As Double)
            CostValue = value
        End Set
    End Property
End Class
