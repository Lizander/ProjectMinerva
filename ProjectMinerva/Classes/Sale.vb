﻿Imports ProjectMinerva.JupiterDataSetTableAdapters
Public Class Sale
    Private IDValue As Integer
    Private CustomerReference As Customer
    Private CustomerIDValue As Integer
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
    Private ActiveValue As String
    Private DataSourceValue As SalesTableAdapter
    Private UserIDValue As Integer


    Public Property ID() As Integer
        Get
            Return IDValue
        End Get
        Set(value As Integer)
            IDValue = value
        End Set
    End Property

    Friend Property Customer() As Customer
        Get
            Return CustomerReference
        End Get
        Set(value As Customer)
            CustomerReference = value
        End Set
    End Property

    Public Property CustomerID() As Integer
        Get
            Return CustomerIDValue
        End Get
        Set(value As Integer)
            CustomerIDValue = value
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

    Public Property UserID() As Integer
        Get
            Return UserIDValue
        End Get
        Set(value As Integer)
            UserIDValue = value
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

    Public Property Active() As String
        Get
            Return ActiveValue
        End Get
        Set(value As String)
            If value = Nothing Then
                value = "YES"
            End If
            ActiveValue = Trim(value)
        End Set
    End Property

    Public Property DataSource() As SalesTableAdapter
        Get
            Return DataSourceValue
        End Get
        Set(value As SalesTableAdapter)
            DataSourceValue = value
        End Set
    End Property

    Private Function CountActiveSales()
        Return DataSourceValue.ActiveSalesCount()
    End Function

    'Private Function GetActiveSale()
    '    'Modify?  Maybe delete?
    '    Return DataSourceValue.GetDataWithActive.Rows(0)
    'End Function

    Private Sub MakeActive()
        If CountActiveSales() = 0 Then
            ActiveValue = "YES"
        Else
            DataSourceValue.DeactivateSales()
            ActiveValue = "YES"
        End If
    End Sub

    Public Sub SetFromRow(Row As DataRow)
        IDValue = Row.Item("Id")
        CustomerIDValue = Row.Item("CustomerID")
        SubtotalValue = Row.Item("Subtotal")
        TotalValue = Row.Item("Total")
        DiscountValue = Row.Item("Discount")
        StateTaxValue = Row.Item("StateTax")
        MunicipalTaxValue = Row.Item("MunicipalTax")
        DateValue = Row.Item("Date")
        TimeValue = Row.Item("Time")
        UserIDValue = Row.Item("UserID")
        WarrantyValue = Row.Item("Warranty")
        PaymentTypeValue = Row.Item("PaymentType")
        ActiveValue = Row.Item("Active")
    End Sub

    Public Overloads Function ValidLineItem(ChosenTire As Tire, Quantity As Integer)
        'TODO check for duplicates, add string for error messages to show the user
        Dim NewLineItem As New LineItem
        Return NewLineItem.ValidQuantity(ChosenTire, Quantity)
    End Function

    Public Overloads Function ValidLineItem(ChosenProduct As Product, Quantity As Integer)
        Dim NewLineItem As New LineItem
        Return NewLineItem.ValidQuantity(ChosenProduct, Quantity)
    End Function

    Public Overloads Sub AddLineItem(ChosenTire As Tire, Quantity As Integer, LineItemTable As LineItemsTableAdapter, TireTable As TiresTableAdapter)
        If Me.ValidLineItem(ChosenTire, Quantity) Then
            If Me.IsLineItemDuplicate(ChosenTire, LineItemTable) Then
                Dim DuplicateLineItem As New LineItem
                DuplicateLineItem.SetFromRow(LineItemTable.GetDataByDuplicates(ChosenTire.ID, "Tire", Me.ID).Rows(0))
                DuplicateLineItem.AddQuantity(ChosenTire, Quantity, TireTable)
                DuplicateLineItem.Update(LineItemTable)
            Else
                Dim NewLineItem As New LineItem
                NewLineItem.SaleID = IDValue
                NewLineItem.Original = True
                NewLineItem.AddTire(ChosenTire, Quantity, LineItemTable, TireTable)
            End If
        Else
            'Add Error Handling, Perhaps MessageBox?
        End If
    End Sub

    Public Overloads Sub AddLineItem(ChosenProduct As Product, Quantity As Integer, LineItemTable As LineItemsTableAdapter, ProductTable As ProductsTableAdapter)
        If Me.ValidLineItem(ChosenProduct, Quantity) Then
            If Me.IsLineItemDuplicate(ChosenProduct, LineItemTable) Then
                Dim DuplicateLineItem As New LineItem
                DuplicateLineItem.SetFromRow(LineItemTable.GetDataByDuplicates(ChosenProduct.ID, "Product", Me.ID).Rows(0))
                DuplicateLineItem.AddQuantity(ChosenProduct, Quantity, ProductTable)
                DuplicateLineItem.Update(LineItemTable)
            Else
                Dim NewLineItem As New LineItem
                NewLineItem.SaleID = IDValue
                NewLineItem.Original = True
                NewLineItem.AddProduct(ChosenProduct, Quantity, LineItemTable, ProductTable)
            End If
        Else
            'Add Error Handling, Perhaps MessageBox?
        End If
    End Sub

    Public Overloads Sub AddLineItem(ChosenService As Service, Quantity As Integer, LineItemTable As LineItemsTableAdapter, ServiceTable As ServicesTableAdapter)
        If Me.IsLineItemDuplicate(ChosenService, LineItemTable) Then
            Dim DuplicateLineItem As New LineItem
            DuplicateLineItem.SetFromRow(LineItemTable.GetDataByDuplicates(ChosenService.ID, "Service", Me.ID).Rows(0))
            DuplicateLineItem.AddQuantity(ChosenService, Quantity)
            DuplicateLineItem.Update(LineItemTable)
        Else
            Dim NewLineItem As New LineItem
            NewLineItem.SaleID = IDValue
            NewLineItem.Original = True
            NewLineItem.AddService(ChosenService, Quantity, LineItemTable, ServiceTable)
        End If
    End Sub

    Shared Function GetActiveSale(Table As SalesTableAdapter)
        Return Table.GetDataWithActive.Rows(0)
    End Function

    Public Overloads Function IsLineItemDuplicate(Tire As Tire, Table As LineItemsTableAdapter)
        Dim Result As Integer
        Result = Table.CountDuplicates(Tire.ID, "Tire", Me.ID)
        If Result > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Overloads Function IsLineItemDuplicate(Product As Product, Table As LineItemsTableAdapter)
        Dim Result As Integer
        Result = Table.CountDuplicates(Product.ID, "Product", Me.ID)
        If Result > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Overloads Function IsLineItemDuplicate(Service As Service, Table As LineItemsTableAdapter)
        Dim Result As Integer
        Result = Table.CountDuplicates(Service.ID, "Service", Me.ID)
        If Result > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
