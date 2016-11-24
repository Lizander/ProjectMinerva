Imports ProjectMinerva.JupiterDataSetTableAdapters
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
    Private SavedValue As Boolean
    Private LineItemSourceValue As LineItemsTableAdapter


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

    Public Property LineItemSource As LineItemsTableAdapter
        Get
            Return LineItemSourceValue
        End Get
        Set(value As LineItemsTableAdapter)
            LineItemSourceValue = value
        End Set
    End Property

    Public Property Saved() As Boolean
        Get
            Return SavedValue
        End Get
        Set(value As Boolean)
            SavedValue = value
        End Set
    End Property

    Private Function CountActiveSales()
        Return DataSourceValue.ActiveSalesCount()
    End Function

    'Private Function GetActiveSale()
    '    'Modify?  Maybe delete?
    '    Return DataSourceValue.GetDataWithActive.Rows(0)
    'End Function

    Public Sub MakeActive()
        If CountActiveSales() = 0 Then
            ActiveValue = "YES"
        Else
            DataSourceValue.DeactivateSales()
            ActiveValue = "YES"
        End If
    End Sub

    Public Overloads Sub SetFromRow(Row As DataRow)
        IDValue = Row.Item("Id")
        If IsDBNull(Row.Item("CustomerID")) Then
            CustomerIDValue = 0
        Else
            CustomerIDValue = Row.Item("CustomerID")
        End If
        SubtotalValue = Row.Item("Subtotal")
        TotalValue = Row.Item("Total")
        DiscountValue = Row.Item("Discount")
        StateTaxValue = Row.Item("StateTax")
        MunicipalTaxValue = Row.Item("MunicipalTax")
        DateValue = Row.Item("Date")
        TimeValue = Row.Item("Time")
        UserIDValue = Row.Item("UserID")
        If IsDBNull(Row.Item("Warranty")) Then
            WarrantyValue = ""
        Else
            WarrantyValue = Row.Item("Warranty")
        End If
        If IsDBNull(Row.Item("PaymentType")) Then
            PaymentTypeValue = ""
        Else
            PaymentTypeValue = Row.Item("PaymentType")
        End If
        ActiveValue = Row.Item("Active")
        If IsNothing(DataSource) Then
        Else
            Me.Calculations()
        End If
    End Sub

    Public Overloads Sub SetFromRow(Row As DataGridViewRow)
        'NOTE this method expects a row from the SalesFullInfo table

        IDValue = Row.Cells.Item(2).Value
        If IsDBNull(Row.Cells.Item(3).Value) Then
            CustomerIDValue = 0
        Else
            CustomerIDValue = Row.Cells.Item(3).Value
        End If
        SubtotalValue = Row.Cells.Item(5).Value
        TotalValue = Row.Cells.Item(8).Value
        DiscountValue = Row.Cells.Item(4).Value
        StateTaxValue = Row.Cells.Item(6).Value
        MunicipalTaxValue = Row.Cells.Item(7).Value
        DateValue = Row.Cells.Item(0).Value
        TimeValue = Row.Cells.Item(1).Value
        UserIDValue = Row.Cells.Item(9).Value
        If IsDBNull(Row.Cells.Item(10).Value) Then
            WarrantyValue = ""
        Else
            WarrantyValue = Row.Cells.Item(10).Value
        End If
        If IsDBNull(Row.Cells.Item(11).Value) Then
            PaymentTypeValue = ""
        Else
            PaymentTypeValue = Row.Cells.Item(11).Value
        End If
        ActiveValue = Row.Cells.Item(12).Value
        If IsNothing(DataSource) Then
        Else
            Me.Calculations()
        End If
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

    Public Sub AddCustomer(ChosenCustomer As Customer, Table As SalesTableAdapter)
        Me.CustomerID = ChosenCustomer.ID
        Me.Customer = ChosenCustomer
        Me.Update(Table)
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

    Public Sub Update(Table As SalesTableAdapter)
        Dim Result As Integer
        DataSource = Table
        Me.Calculations()
        Result = Table.UpdateEverything(CustomerIDValue, SubtotalValue, TotalValue, DiscountValue, StateTaxValue, MunicipalTaxValue, Date.Today, Date.Now.ToShortTimeString, UserIDValue,
                                        WarrantyValue, PaymentTypeValue, ActiveValue, Me.ID)
        If Result >= 1 Then
            SavedValue = True
        Else
            SavedValue = False
        End If
    End Sub

    Public Sub Calculations()
        Me.UserID = 1
        SubtotalValue = CalculateSubtotal()
        DiscountValue = CalculateDiscount()
        StateTaxValue = CalculateStateTax()
        MunicipalTaxValue = CalculateMunicipalTax()
        TotalValue = CalculateTotal()
    End Sub

    Public Overloads Sub SaveChanges(Table As SalesTableAdapter, HasCustomer As Boolean)
        Dim Result As Integer
        Me.DataSourceValue = Table
        Me.Calculations()
        Result = Table.AddSale(CustomerIDValue, SubtotalValue, TotalValue, DiscountValue, StateTaxValue, MunicipalTaxValue, Date.Today, TimeOfDay.ToString, UserIDValue,
                                        WarrantyValue, PaymentTypeValue, ActiveValue)
        If Result >= 1 Then
            SavedValue = True
        Else
            SavedValue = False
        End If
    End Sub

    Public Overloads Sub SaveChanges(Table As SalesTableAdapter)
        Dim Result As Integer
        Me.DataSourceValue = Table
        Me.Calculations()
        Result = Table.AddSaleWithoutCustomer(SubtotalValue, TotalValue, DiscountValue, StateTaxValue, MunicipalTaxValue, Date.Today, TimeOfDay.ToString, UserIDValue,
                                        WarrantyValue, PaymentTypeValue, ActiveValue)
        If Result >= 1 Then
            SavedValue = True
        Else
            SavedValue = False
        End If
    End Sub

    Private Function CalculateSubtotal()
        Return DataSource.CalculateSubtotal(IDValue)
    End Function

    Private Function CalculateTotal()
        Return SubtotalValue + StateTaxValue + MunicipalTaxValue
    End Function

    Private Function CalculateDiscount()
        Dim DiscountTotal = 0
        If IsNothing(LineItemSourceValue) Then
        Else
            Dim LineItems = LineItemSourceValue.GetDataByActiveSale().Rows
            For Each Row As DataRow In LineItems
                DiscountTotal += (Row.Item("DiscountPrice") * Row.Item("Quantity"))
            Next Row
        End If
        Return DiscountTotal
    End Function

    Private Function CalculateStateTax()
        Return DataSource.CalculateStateTax(IDValue)
    End Function

    Private Function CalculateMunicipalTax()
        Return DataSource.CalculateMunicipalTax(IDValue)
    End Function

    Public Function GetCustomerName(Table As CustomersTableAdapter)
        Dim SaleCustomer As New Customer
        SaleCustomer.SetFromRow(Table.GetDataByID(Me.CustomerID).Rows(0))
        Return SaleCustomer.FirstName + " " + SaleCustomer.FirstLastName
    End Function
End Class
