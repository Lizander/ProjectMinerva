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

    Public Property ID() As Integer
        Get
            Return IDValue
        End Get
        Set(value As Integer)
            IDValue = value
        End Set
    End Property

    Public Property Brand() As String
        Get
            Return BrandValue
        End Get
        Set(value As String)
            If value = Nothing Then
                value = "N/A"
            End If
            BrandValue = Trim(value)
        End Set
    End Property

    Public Property Model() As String
        Get
            Return ModelValue
        End Get
        Set(value As String)
            If value = Nothing Then
                value = "N/A"
            End If
            ModelValue = Trim(value)
        End Set
    End Property

    Public Property Width() As String
        Get
            Return WidthValue
        End Get
        Set(value As String)
            WidthValue = Trim(value)
        End Set
    End Property

    Public Property Razon() As String
        Get
            Return RazonAvAValue
        End Get
        Set(value As String)
            RazonAvAValue = Trim(value)
        End Set
    End Property

    Public Property Diameter() As String
        Get
            Return DiameterValue
        End Get
        Set(value As String)
            DiameterValue = Trim(value)
        End Set
    End Property

    Public Property Traction() As String
        Get
            Return TractionValue
        End Get
        Set(value As String)
            If value = Nothing Then
                value = "N/A"
            End If
            TractionValue = Trim(value)
        End Set
    End Property

    Public Property Temperature() As String
        Get
            Return TemperatureValue
        End Get
        Set(value As String)
            If value = Nothing Then
                value = "N/A"
            End If
            TemperatureValue = Trim(value)
        End Set
    End Property

    Public Property Condition() As String
        Get
            Return ConditionValue
        End Get
        Set(value As String)
            ConditionValue = Trim(value)
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
            StateExemptValue = Trim(value)
        End Set
    End Property

    Public Property MunicipalExempt() As String
        Get
            Return MunicipalExemptValue
        End Get
        Set(value As String)
            MunicipalExemptValue = Trim(value)
        End Set
    End Property

    Public Property Treadwear() As String
        Get
            Return TreadwearValue
        End Get
        Set(value As String)
            If value = Nothing Then
                value = "N/A"
            End If
            TreadwearValue = Trim(value)
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

    Public Overloads Sub SetFromRow(Row As DataGridViewRow)
        Dim Cells = Row.Cells
        IDValue = Cells.Item(0).Value
        BrandValue = Trim(Cells.Item(1).Value)
        ModelValue = Trim(Cells.Item(2).Value)
        WidthValue = Trim(Cells.Item(3).Value)
        RazonAvAValue = Trim(Cells.Item(4).Value)
        DiameterValue = Trim(Cells.Item(5).Value)
        TractionValue = Trim(Cells.Item(6).Value)
        TemperatureValue = Trim(Cells.Item(7).Value)
        ConditionValue = Trim(Cells.Item(8).Value)
        ReorderPointValue = Cells.Item(9).Value
        SupplierIDValue = Cells.Item(10).Value
        StateExemptValue = Trim(Cells.Item(11).Value)
        MunicipalExemptValue = Trim(Cells.Item(12).Value)
        TreadwearValue = Trim(Cells.Item(13).Value)
        StockValue = Cells.Item(14).Value
        PriceValue = Cells.Item(15).Value
        CostValue = Cells.Item(16).Value
        MarkupValue = Cells.Item(17).Value
    End Sub

    Public Overloads Sub SetFromRow(Row As DataRow)
        Dim Cells = Row
        IDValue = Cells.Item(0)
        BrandValue = Trim(Cells.Item(1))
        ModelValue = Trim(Cells.Item(2))
        WidthValue = Trim(Cells.Item(3))
        RazonAvAValue = Trim(Cells.Item(4))
        DiameterValue = Trim(Cells.Item(5))
        TractionValue = Trim(Cells.Item(6))
        TemperatureValue = Trim(Cells.Item(7))
        ConditionValue = Trim(Cells.Item(8))
        ReorderPointValue = Cells.Item(9)
        SupplierIDValue = Cells.Item(10)
        StateExemptValue = Trim(Cells.Item(11))
        MunicipalExemptValue = Trim(Cells.Item(12))
        TreadwearValue = Trim(Cells.Item(13))
        StockValue = Cells.Item(14)
        PriceValue = Cells.Item(15)
        CostValue = Cells.Item(16)
        MarkupValue = Cells.Item(17)
    End Sub

    Public Function IsSame(TireTwo As Tire)
        Dim TireOneArray = Me.ToArray()
        Dim TireTwoArray = TireTwo.ToArray()
        Dim Same As Boolean

        For index = 0 To TireOneArray.GetUpperBound(0)
            If TireOneArray(index).Equals(TireTwoArray(index)) Then
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
            Trim(Me.Brand.ToString),
            Trim(Me.Model.ToString),
            Trim(Me.Width.ToString),
            Trim(Me.Razon.ToString),
            Trim(Me.Diameter.ToString),
            Trim(Me.Traction.ToString),
            Trim(Me.Temperature.ToString),
            Trim(Me.Condition.ToString),
            Trim(Me.ReorderPoint.ToString),
            Trim(Me.SupplierID.ToString),
            Trim(Me.StateExempt.ToString),
            Trim(Me.MunicipalExempt.ToString),
            Trim(Me.Treadwear.ToString),
            Trim(Me.Stock.ToString),
            Trim(Me.Price.ToString),
            Trim(Me.Cost.ToString)
            }
        Return Attributes
    End Function

    Public Sub Update(Table As TiresTableAdapter)
        Dim Result As Integer
        Result = Table.UpdateQuery(BrandValue, ModelValue, WidthValue, RazonAvAValue, DiameterValue, TractionValue, TemperatureValue, ConditionValue, ReorderPointValue, SupplierIDValue,
                                  StateExemptValue, MunicipalExemptValue, TreadwearValue, StockValue, PriceValue, CostValue, Markup, IDValue)
        If Result = 1 Then
            SavedValue = True
        Else
            SavedValue = False
        End If
    End Sub

    Public Function RemoveStock(Quantity As Integer, Table As TiresTableAdapter)
        If Quantity <= Me.Stock Then
            Me.Stock -= Quantity
            Me.Update(Table)
            Return True
        Else
            Return False
        End If
    End Function
End Class
