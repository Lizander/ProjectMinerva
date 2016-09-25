Public Class Product
    Private IDValue As Integer
    Private NameValue As String
    Private CategoryValue As String
    Private DescriptionValue As String
    Private ReorderPointValue As Integer
    Private SupplierReference As Supplier
    Private StateExemptValue As String
    Private MunicipalExemptValue As String
    Private WarrantyValue As String
    Private StockValue As Integer
    Private PriceValue As Double
    Private CostValue As Double
    Private MarkupValue As Double

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

    Public Property Category() As String
        Get
            Return CategoryValue
        End Get
        Set(value As String)
            CategoryValue = value
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

    Public Property ReorderPoint() As Integer
        Get
            Return ReorderPointValue
        End Get
        Set(value As Integer)
            ReorderPointValue = value
        End Set
    End Property

    Friend Property Supplier() As Supplier
        Get
            Return SupplierReference
        End Get
        Set(value As Supplier)
            SupplierReference = value
        End Set
    End Property

    Public Property StateExempt() As String
        Get
            Return StateExemptValue
        End Get
        Set(value As String)
            StateExemptValue = value
        End Set
    End Property

    Public Property MunicipalExempt() As String
        Get
            Return MunicipalExemptValue
        End Get
        Set(value As String)
            MunicipalExemptValue = value
        End Set
    End Property

    Public Property Warranty() As String
        Get
            Return WarrantyValue
        End Get
        Set(value As String)
            WarrantyValue = value
        End Set
    End Property

    Public Property Stock() As Integer
        Get
            Return StockValue
        End Get
        Set(value As Integer)
            StockValue = value
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

    Public Property Cost() As Double
        Get
            Return CostValue
        End Get
        Set(value As Double)
            CostValue = value
        End Set
    End Property

    Public ReadOnly Property Markup() As Double
        Get
            Return PriceValue - CostValue
        End Get
    End Property
End Class
