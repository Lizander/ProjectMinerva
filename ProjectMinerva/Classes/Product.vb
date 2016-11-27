Imports ProjectMinerva.JupiterDataSetTableAdapters

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
    Private SupplierIDValue As Integer
    Private SavedValue As Boolean

    Public Property ID() As Integer
        Get
            Return IDValue
        End Get
        Set(value As Integer)
            IDValue = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return NameValue
        End Get
        Set(value As String)
            NameValue = Trim(value)
        End Set
    End Property

    Public Property Category() As String
        Get
            Return CategoryValue
        End Get
        Set(value As String)
            CategoryValue = Trim(value)
        End Set
    End Property

    Public Property Description() As String
        Get
            Return DescriptionValue
        End Get
        Set(value As String)
            If value = Nothing Then
                value = "N/A"
            End If
            DescriptionValue = Trim(value)
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

    Public Property Warranty() As String
        Get
            Return WarrantyValue
        End Get
        Set(value As String)
            If value = Nothing Then
                value = "N/A"
            End If
            WarrantyValue = Trim(value)
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

    Public Sub Create(Table As ProductsTableAdapter)
        Dim Result As Integer
        Result = Table.InsertProduct(NameValue, CategoryValue, DescriptionValue, ReorderPointValue, SupplierIDValue, StateExemptValue, MunicipalExemptValue, WarrantyValue, StockValue,
                                     PriceValue, CostValue, Markup)
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
        NameValue = Trim(Cells.Item(1).Value)
        CategoryValue = Trim(Cells.Item(2).Value)
        DescriptionValue = Trim(Cells.Item(3).Value)
        ReorderPointValue = Cells.Item(4).Value
        SupplierIDValue = Cells.Item(5).Value
        StateExemptValue = Trim(Cells.Item(6).Value)
        MunicipalExemptValue = Trim(Cells.Item(7).Value)
        WarrantyValue = Trim(Cells.Item(8).Value)
        StockValue = Cells.Item(9).Value
        PriceValue = Cells.Item(10).Value
        CostValue = Cells.Item(11).Value
        MarkupValue = Cells.Item(12).Value
    End Sub

    Public Overloads Sub SetFromRow(Row As DataRow)
        Dim Cells = Row
        IDValue = Cells.Item(0)
        NameValue = Trim(Cells.Item(1))
        CategoryValue = Trim(Cells.Item(2))
        DescriptionValue = Trim(Cells.Item(3))
        ReorderPointValue = Cells.Item(4)
        SupplierIDValue = Cells.Item(5)
        StateExemptValue = Trim(Cells.Item(6))
        MunicipalExemptValue = Trim(Cells.Item(7))
        WarrantyValue = Trim(Cells.Item(8))
        StockValue = Cells.Item(9)
        PriceValue = Cells.Item(10)
        CostValue = Cells.Item(11)
        MarkupValue = Cells.Item(12)
    End Sub

    Public Function IsSame(ProductTwo As Product)
        Dim ProductOneArray = Me.ToArray()
        Dim ProductTwoArray = ProductTwo.ToArray()
        Dim Same As Boolean

        For index = 0 To ProductOneArray.GetUpperBound(0)
            If ProductOneArray(index).Equals(ProductTwoArray(index)) Then
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
            Trim(Me.Name.ToString),
            Trim(Me.Category.ToString),
            Trim(Me.Description.ToString),
            Trim(Me.ReorderPoint.ToString),
            Trim(Me.SupplierID.ToString),
            Trim(Me.StateExempt.ToString),
            Trim(Me.MunicipalExempt.ToString),
            Trim(Me.Stock.ToString),
            Trim(Me.Price.ToString),
            Trim(Me.Cost.ToString)
            }
        Return Attributes
    End Function

    Public Sub Update(Table As ProductsTableAdapter)
        Dim Result As Integer
        Result = Table.UpdateProduct(NameValue, CategoryValue, DescriptionValue, ReorderPointValue, SupplierIDValue, StateExemptValue, MunicipalExemptValue, WarrantyValue, StockValue,
                                     PriceValue, CostValue, Markup, IDValue)
        If Result = 1 Then
            SavedValue = True
        Else
            SavedValue = False
        End If
    End Sub

    Public Function RemoveStock(Quantity As Integer, Table As ProductsTableAdapter)
        If Quantity <= Me.Stock Then
            Me.Stock -= Quantity
            Me.Update(Table)
            Return True
        Else
            Return False
        End If
    End Function
End Class
