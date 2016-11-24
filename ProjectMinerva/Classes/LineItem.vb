Imports ProjectMinerva.JupiterDataSetTableAdapters

Public Class LineItem
    Private IDValue As Integer
    Private ItemIDValue As Integer
    Private ItemTypeValue As String
    Private PriceValue As Double
    Private QuantityValue As Integer
    Private SaleReference As Sale
    Private SaleIDValue As Integer
    Private DescriptionValue As String
    Private CategoryValue As String
    Private ExtendedPriceValue As Double
    Private SubtotalOneValue As Double
    Private SubtotalTwoValue As Double
    Private DiscountPriceValue As Double
    Private StateTaxValue As Double
    Private MunicipalTaxValue As Double
    Private CostValue As Double
    Private SavedValue As Double
    Private OriginalVAlue As Boolean
    Private DiscountAmountValue As Double
    Private DiscountTypeValue As String

    Public Property ID() As Integer
        Get
            Return IDValue
        End Get
        Set(value As Integer)
            IDValue = value
        End Set
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

    Public Property SaleID() As Integer
        Get
            Return SaleIDValue
        End Get
        Set(value As Integer)
            SaleIDValue = value
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

    Public Property DiscountPrice() As Double
        'TODO introduce method that calculates this
        Get
            Return DiscountPriceValue
        End Get
        Set(value As Double)
            DiscountPriceValue = value
        End Set
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

    Public Property Original() As Boolean
        Get
            Return OriginalValue
        End Get
        Set(value As Boolean)
            OriginalValue = value
        End Set
    End Property

    Public Property DiscountAmount() As Double
        Get
            Return DiscountAmountValue
        End Get
        Set(value As Double)
            DiscountAmountValue = value
        End Set
    End Property

    Public Property DiscountType() As String
        Get
            Return DiscountTypeValue
        End Get
        Set(value As String)
            DiscountTypeValue = value
        End Set
    End Property


    Public Sub AddTire(ChosenTire As Tire, Quantity As Integer, LITable As LineItemsTableAdapter, TireTable As TiresTableAdapter)
        Me.Description = ChosenTire.Brand + " " + ChosenTire.Width + "-" +
          ChosenTire.Razon + "-" + ChosenTire.Diameter + " " + ChosenTire.Condition
        Me.Category = ChosenTire.Condition + " Tire"
        Me.ItemID = ChosenTire.ID
        Me.ItemType = "Tire"
        Me.Price = ChosenTire.Price
        Me.Cost = ChosenTire.Cost
        Me.AddQuantity(ChosenTire, Quantity, TireTable)
        Me.SaveChanges(LITable)
    End Sub

    Public Sub AddProduct(ChosenProduct As Product, Quantity As Integer, LITable As LineItemsTableAdapter, ProductTable As ProductsTableAdapter)
        Me.Description = ChosenProduct.Name
        Me.Category = ChosenProduct.Category
        Me.ItemID = ChosenProduct.ID
        Me.ItemType = "Product"
        Me.Price = ChosenProduct.Price
        Me.Cost = ChosenProduct.Cost
        Me.AddQuantity(ChosenProduct, Quantity, ProductTable)
        Me.SaveChanges(LITable)
    End Sub

    Public Sub AddService(ChosenService As Service, Quantity As Integer, LITable As LineItemsTableAdapter, ServiceTable As ServicesTableAdapter)
        Me.Description = ChosenService.Name
        Me.Category = ChosenService.Category
        Me.ItemID = ChosenService.ID
        Me.ItemType = "Service"
        Me.Price = ChosenService.Price
        Me.Cost = ChosenService.Cost
        Me.AddQuantity(ChosenService, Quantity)
        Me.SaveChanges(LITable)
    End Sub

    Public Overloads Function ValidQuantity(ChosenTire As Tire, Quantity As Integer)
        Return ChosenTire.Stock >= Quantity
    End Function

    Public Overloads Function ValidQuantity(ChosenProduct As Product, Quantity As Integer)
        Return ChosenProduct.Stock >= Quantity
    End Function

    Public Sub SaveChanges(Table As LineItemsTableAdapter)
        Dim Result As Integer
        Me.Calculations()
        Result = Table.AddLineItem(ItemID, ItemType, Price, Quantity, SaleID, Description, Category, ExtendedPrice, SubtotalOne, SubtotalTwo, DiscountPrice,
                          StateTax, MunicipalTax, Cost, DiscountAmount, DiscountType)
        If Result >= 1 Then
            SavedValue = True
        Else
            SavedValue = False
        End If
    End Sub

    Public Overloads Sub SetFromRow(Row As DataRow)
        Me.ID = Integer.Parse(Row.Item("ID"))
        Me.ItemID = Integer.Parse(Row.Item("ItemID"))
        Me.ItemType = Row.Item("ItemType")
        Me.Price = Double.Parse(Row.Item("Price"))
        Me.Quantity = Integer.Parse(Row.Item("Quantity"))
        Me.SaleID = Integer.Parse(Row.Item("SaleID"))
        Me.Description = Row.Item("Description")
        Me.Category = Row.Item("Category")
        Me.Cost = Double.Parse(Row.Item("Cost"))
        If IsDBNull(Row.Item("DiscountAmount")) Then
            Me.DiscountAmount = 0
        Else
            Me.DiscountAmount = Double.Parse(Row.Item("DiscountAmount"))
        End If
        If IsDBNull(Row.Item("DiscountType")) Then
            Me.DiscountType = "Dollars"
        Else
            Me.DiscountType = Row.Item("DiscountType")
        End If
        Me.Calculations()
    End Sub

    Public Overloads Sub SetFromRow(Row As DataGridViewRow)
        Dim Cells = Row.Cells
        Me.ID = Integer.Parse(Cells.Item(0).Value)
        Me.ItemID = Integer.Parse(Cells.Item(1).Value)
        Me.ItemType = Trim(Cells.Item(2).Value)
        Me.Price = Double.Parse(Cells.Item(3).Value)
        Me.SaleID = Integer.Parse(Cells.Item(4).Value)
        Me.Description = Trim(Cells.Item(5).Value)
        Me.Quantity = Integer.Parse(Cells.Item(6).Value)
        Me.Category = Trim(Cells.Item(7).Value)
        Me.Cost = Double.Parse(Cells.Item(14).Value)
        If IsDBNull(Cells.Item(15).Value) Then
            DiscountAmount = 0
        Else
            Me.DiscountAmount = Double.Parse(Cells.Item(15).Value)
        End If
        If IsDBNull(Cells.Item(16).Value) Then
            Me.DiscountType = "Dollars"
        Else
            Me.DiscountType = Cells.Item(16).Value
        End If
        Me.Calculations()
    End Sub

    Public Overloads Sub AddQuantity(ChosenTire As Tire, Quantity As Integer, TireTable As TiresTableAdapter)
        ChosenTire.RemoveStock(Quantity, TireTable)
        Me.Quantity += Quantity
    End Sub

    Public Overloads Sub AddQuantity(ChosenProduct As Product, Quantity As Integer, ProductTable As ProductsTableAdapter)
        ChosenProduct.RemoveStock(Quantity, ProductTable)
        Me.Quantity += Quantity
    End Sub

    Public Overloads Sub AddQuantity(ChosenService As Service, Quantity As Integer)
        Me.Quantity += Quantity
    End Sub

    Public Sub Update(Table As LineItemsTableAdapter)
        Dim Result As Integer
        Me.Calculations()
        Result = Table.UpdateEverything(ItemID, ItemType, Price, Quantity, SaleID, Description, Category, ExtendedPrice, SubtotalOne, SubtotalTwo, DiscountPrice,
                          StateTax, MunicipalTax, Cost, DiscountAmount, DiscountType, Me.ID)
        If Result >= 1 Then
            SavedValue = True
        Else
            SavedValue = False
        End If
    End Sub

    Private Sub Calculations()
        DiscountPriceValue = CalculateDiscount()
        SubtotalOneValue = CalculateSubtotalOne()
        SubtotalTwoValue = CalculateSubtotalTwo()
        StateTaxValue = CalculateStateTax(GetStateTaxRate())
        MunicipalTaxValue = CalculateMunicipalTax(GetMunicipalTaxRate())
        ExtendedPriceValue = CalculateExtendedPrice()
    End Sub

    Private Function CalculateDiscount()
        If DiscountType = "Dollars" Then
            Return DiscountAmount
        ElseIf DiscountType = "Percentage" Then
            Return PriceValue * (DiscountAmount / 100)
        Else
            Return 0
        End If
    End Function

    Private Function CalculateSubtotalOne()
        Return PriceValue - DiscountPriceValue
    End Function

    Private Function CalculateSubtotalTwo()
        Return SubtotalOneValue * QuantityValue
    End Function

    Private Function CalculateStateTax(StateTaxRate As Double)
        Return SubtotalTwoValue * StateTaxRate
    End Function

    Private Function CalculateMunicipalTax(MunicipalTaxRate As Double)
        Return SubtotalTwoValue * MunicipalTaxRate
    End Function

    Private Function CalculateExtendedPrice()
        Return SubtotalTwoValue + StateTaxValue + MunicipalTaxValue
    End Function

    Private Function GetStateTaxRate()
        Dim Table As New StoresTableAdapter
        Return Double.Parse(Table.GetData().Rows(0).Item("StateTaxRate"))
    End Function

    Private Function GetMunicipalTaxRate()
        Dim Table As New StoresTableAdapter
        Return Double.Parse(Table.GetData().Rows(0).Item("MunicipalTaxRate"))
    End Function

    Public Overloads Sub ReturnStock(ChosenTire As Tire, TireTable As TiresTableAdapter)
        ChosenTire.Stock += Me.Quantity
        ChosenTire.Update(TireTable)
    End Sub

    Public Overloads Sub ReturnStock(ChosenProduct As Product, ProductTable As ProductsTableAdapter)
        ChosenProduct.Stock += Me.Quantity
        ChosenProduct.Update(ProductTable)
    End Sub
End Class
