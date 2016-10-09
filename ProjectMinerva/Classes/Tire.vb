Imports ProjectMinerva.JupiterDataSetTableAdapters

Public Class Tire
    Private IDValue As Integer
    Private BrandValue As String
    Private ModelValue As String
    Private WidthValue As String
    Private RazonAvAValue As String
    Private DiameterValue As String
    Private TractionValue As String
    Private TemperatureValue As String
    Private ConditionValue As String
    Private ReorderPointValue As Integer
    Private SupplierReference As Supplier
    Private SupplierIDValue As Integer
    Private StateExemptValue As String
    Private MunicipalExemptValue As String
    Private TreadwearValue As String
    Private StockValue As Integer
    Private PriceValue As Double
    Private CostValue As Double
    Private MarkupValue As Double
    Private SavedValue As Boolean

    Public ReadOnly Property ID() As Integer
        Get
            Return IDValue
        End Get
    End Property

    Public Property Brand() As String
        Get
            Return BrandValue
        End Get
        Set(value As String)
            BrandValue = value
        End Set
    End Property

    Public Property Model() As String
        Get
            Return ModelValue
        End Get
        Set(value As String)
            ModelValue = value
        End Set
    End Property

    Public Property Width() As String
        Get
            Return WidthValue
        End Get
        Set(value As String)
            WidthValue = value
        End Set
    End Property

    Public Property Razon() As String
        Get
            Return RazonAvAValue
        End Get
        Set(value As String)
            RazonAvAValue = value
        End Set
    End Property

    Public Property Diameter() As String
        Get
            Return DiameterValue
        End Get
        Set(value As String)
            DiameterValue = value
        End Set
    End Property

    Public Property Traction() As String
        Get
            Return TractionValue
        End Get
        Set(value As String)
            TractionValue = value
        End Set
    End Property

    Public Property Temperature() As String
        Get
            Return TemperatureValue
        End Get
        Set(value As String)
            TemperatureValue = value
        End Set
    End Property

    Public Property Condition() As String
        Get
            Return ConditionValue
        End Get
        Set(value As String)
            ConditionValue = value
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

    Public Property SupplierID() As Integer
        Get
            Return SupplierIDValue
        End Get
        Set(value As Integer)
            SupplierIDValue = value
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

    Public Property Treadwear() As String
        Get
            Return TreadwearValue
        End Get
        Set(value As String)
            TreadwearValue = value
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

    Public Sub Create(Table As TiresTableAdapter)
        Dim Result As Integer
        Result = Table.InsertTire(BrandValue, ModelValue, WidthValue, RazonAvAValue, DiameterValue, TractionValue, TemperatureValue, ConditionValue, ReorderPointValue,
                                  SupplierIDValue, StateExemptValue, MunicipalExemptValue, TreadwearValue, StockValue, PriceValue, CostValue, Markup)
        If Result = 1 Then
            SavedValue = True
        Else
            SavedValue = False
        End If
    End Sub

    Public Function Saved()
        Return SavedValue
    End Function
End Class
