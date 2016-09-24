Imports ProjectMinerva.JupiterDataSetTableAdapters

Public Class Customer
    Private IDValue As Integer
    Private FirstNameValue As String
    Private FirstLastNameValue As String
    Private SecondLastNameValue As String
    Private PhoneNumberValue As String
    Private EmailAddressValue As String
    Private GenderValue As String
    Private CityValue As String
    Private StateExemptValue As String
    Private MunicipalExemptValue As String
    Private DiscountValue As Double
    Private LatestVisitValue As String
    Private SavedValue As Boolean

    Public ReadOnly Property ID() As Integer
        Get
            Return IDValue
        End Get
    End Property

    Public Property FirstName() As String
        Get
            Return FirstNameValue
        End Get
        Set(value As String)
            FirstNameValue = value
        End Set
    End Property

    Public Property FirstLastName() As String
        Get
            Return FirstLastNameValue
        End Get
        Set(value As String)
            FirstLastNameValue = value
        End Set
    End Property

    Public Property SecondLastName() As String
        Get
            Return SecondLastNameValue
        End Get
        Set(value As String)
            SecondLastNameValue = value
        End Set
    End Property

    Public Property PhoneNumber() As String
        Get
            Return PhoneNumberValue
        End Get
        Set(value As String)
            PhoneNumberValue = value
        End Set
    End Property

    Public Property EmailAddress() As String
        Get
            Return EmailAddressValue
        End Get
        Set(value As String)
            EmailAddressValue = value
        End Set
    End Property

    Public Property Gender() As String
        Get
            Return GenderValue
        End Get
        Set(value As String)
            GenderValue = value
        End Set
    End Property

    Public Property City() As String
        Get
            Return CityValue
        End Get
        Set(value As String)
            CityValue = value
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

    Public Property Discount() As Double
        Get
            Return DiscountValue
        End Get
        Set(value As Double)
            DiscountValue = value
        End Set
    End Property

    Public Property LatestVisit() As String
        Get
            Return LatestVisitValue
        End Get
        Set(value As String)
            LatestVisitValue = value
        End Set
    End Property

    Public ReadOnly Property Saved() As Boolean
        Get
            Return SavedValue
        End Get
    End Property

    Public Sub Find(Table As CustomersTableAdapter, ID As Integer)
        Dim Result = Table.GetDataBySearchingID(ID)
        If Result.Count = 1 Then
            Dim Row = Result.Rows(0)
            IDValue = Row.Item(0)
            FirstNameValue = Row.Item(1)
            FirstLastNameValue = Row.Item(2)
            SecondLastNameValue = Row.Item(3)
            PhoneNumberValue = Row.Item(4)
            EmailAddressValue = Row.Item(5)
            GenderValue = Row.Item(6)
            CityValue = Row.Item(7)
            StateExemptValue = Row.Item(8)
            MunicipalExemptValue = Row.Item(9)
            DiscountValue = Row.Item(10)
            LatestVisitValue = Row.Item(11)
        End If
    End Sub
    Public Sub Create(Table As CustomersTableAdapter)
        Dim Result As Integer
        Result = Table.InsertCustomer(FirstNameValue, FirstLastNameValue, SecondLastNameValue, PhoneNumberValue, EmailAddressValue, GenderValue, CityValue, StateExemptValue, MunicipalExemptValue,
                             DiscountValue, LatestVisitValue)
        If Result = 1 Then
            SavedValue = True
        Else
            SavedValue = False
        End If
    End Sub
End Class
