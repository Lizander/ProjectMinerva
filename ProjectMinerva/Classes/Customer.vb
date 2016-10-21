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

    Public Property ID() As Integer
        Get
            Return IDValue
        End Get
        Set(value As Integer)
            IDValue = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return FirstNameValue
        End Get
        Set(value As String)
            FirstNameValue = Trim(value)
        End Set
    End Property

    Public Property FirstLastName() As String
        Get
            Return FirstLastNameValue
        End Get
        Set(value As String)
            FirstLastNameValue = Trim(value)
        End Set
    End Property

    Public Property SecondLastName() As String
        Get
            Return SecondLastNameValue
        End Get
        Set(value As String)
            If value = Nothing Then
                value = "N/A"
            End If
            SecondLastNameValue = Trim(value)
        End Set
    End Property

    Public Property PhoneNumber() As String
        Get
            Return PhoneNumberValue
        End Get
        Set(value As String)
            PhoneNumberValue = Trim(value)
        End Set
    End Property

    Public Property EmailAddress() As String
        Get
            Return EmailAddressValue
        End Get
        Set(value As String)
            If value = Nothing Then
                value = "N/A"
            End If
            EmailAddressValue = Trim(value)
        End Set
    End Property

    Public Property Gender() As String
        Get
            Return GenderValue
        End Get
        Set(value As String)
            GenderValue = Trim(value)
        End Set
    End Property

    Public Property City() As String
        Get
            Return CityValue
        End Get
        Set(value As String)
            If value = Nothing Then
                value = "N/A"
            End If
            CityValue = Trim(value)
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

    Public Sub SetFromRow(Row As DataGridViewRow)
        Dim Cells = Row.Cells
        IDValue = Cells.Item(0).Value
        FirstNameValue = Trim(Cells.Item(1).Value)
        FirstLastNameValue = Trim(Cells.Item(2).Value)
        SecondLastNameValue = Trim(Cells.Item(3).Value)
        PhoneNumberValue = Trim(Cells.Item(4).Value)
        EmailAddressValue = Trim(Cells.Item(5).Value)
        GenderValue = Trim(Cells.Item(6).Value)
        CityValue = Trim(Cells.Item(7).Value)
        StateExemptValue = Trim(Cells.Item(8).Value)
        MunicipalExemptValue = Trim(Cells.Item(9).Value)
        DiscountValue = Cells.Item(10).Value
        LatestVisitValue = Trim(Cells.Item(11).Value)
    End Sub

    Public Function IsSame(CustomerTwo As Customer)
        Dim CustomerOneArray = Me.ToArray()
        Dim CustomerTwoArray = CustomerTwo.ToArray()
        Dim Same As Boolean

        For index = 0 To CustomerOneArray.GetUpperBound(0)
            If CustomerOneArray(index).Equals(CustomerTwoArray(index)) Then
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
            Trim(Me.FirstName.ToString),
            Trim(Me.FirstLastName.ToString),
            Trim(Me.SecondLastName.ToString),
            Trim(Me.PhoneNumber.ToString),
            Trim(Me.EmailAddress.ToString),
            Trim(Me.Gender.ToString),
            Trim(Me.City.ToString),
            Trim(Me.StateExempt.ToString),
            Trim(Me.MunicipalExempt.ToString),
            Trim(Me.Discount.ToString)
            }
        Return Attributes
    End Function

    Public Sub Update(Table As CustomersTableAdapter)
        Dim Result As Integer
        Result = Table.UpdateCustomer(FirstNameValue, FirstLastNameValue, SecondLastNameValue, PhoneNumberValue, EmailAddressValue, GenderValue, CityValue, StateExemptValue, MunicipalExemptValue,
                             DiscountValue, LatestVisitValue, IDValue)
        If Result = 1 Then
            SavedValue = True
        Else
            SavedValue = False
        End If
    End Sub
End Class
