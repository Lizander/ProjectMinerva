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

    Public Property Original() As Boolean
        Get
            Return OriginalValue
        End Get
        Set(value As Boolean)
            OriginalValue = value
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
        ChosenTire.RemoveStock(Quantity, TireTable)
        Me.Quantity = Quantity
        Me.SaveChanges(LITable)
    End Sub

    Public Function ValidQuantity(ChosenTire As Tire, Quantity As Integer)
        Return ChosenTire.Stock >= Quantity
    End Function

    Public Sub SaveChanges(Table As LineItemsTableAdapter)
        Dim Result As Integer
        If Me.Original Then
            Result = Table.AddLineItem(ItemID, ItemType, Price, Quantity, SaleID, Description, Category, ExtendedPrice, SubtotalOne, SubtotalTwo, DiscountPrice,
                              StateTax, MunicipalTax, Cost)
            If Result >= 1 Then
                SavedValue = True
            Else
                SavedValue = False
            End If
        End If
    End Sub
End Class
