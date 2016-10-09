Imports ProjectMinerva.JupiterDataSetTableAdapters

Class Supplier
    Private IDValue As Integer
    Private BusinessNameValue As String
    Private ContactNameValue As String
    Private ContactFirstLastNameValue As String
    Private ContactSecondLastNameValue As String
    Private BusinessPhoneValue As String
    Private ContactPhoneValue As String
    Private BusinessEmailValue As String
    Private AddressLineOneValue As String
    Private AddressLineTwoValue As String
    Private CityValue As String
    Private CountryValue As String
    Private ZipcodeValue As String
    Private SavedValue As Boolean

    Public Property ID() As Integer
        Get
            Return IDValue
        End Get
        Set(value As Integer)
            IDValue = value
        End Set
    End Property

    Public Property BusinessName() As String
        Get
            Return BusinessNameValue
        End Get
        Set(value As String)
            BusinessNameValue = Trim(value)
        End Set
    End Property

    Public Property ContactName() As String
        Get
            Return ContactNameValue
        End Get
        Set(value As String)
            ContactNameValue = Trim(value)
        End Set
    End Property

    Public Property ContactFirstLastName() As String
        Get
            Return ContactFirstLastNameValue
        End Get
        Set(value As String)
            ContactFirstLastNameValue = Trim(value)
        End Set
    End Property

    Public Property ContactSecondLastName() As String
        Get
            Return ContactSecondLastNameValue
        End Get
        Set(value As String)
            ContactSecondLastNameValue = Trim(value)
        End Set
    End Property

    Public Property BusinessPhone() As String
        Get
            Return BusinessPhoneValue
        End Get
        Set(value As String)
            BusinessPhoneValue = Trim(value)
        End Set
    End Property

    Public Property ContactPhone() As String
        Get
            Return ContactPhoneValue
        End Get
        Set(value As String)
            ContactPhoneValue = Trim(value)
        End Set
    End Property

    Public Property BusinessEmail() As String
        Get
            Return BusinessEmailValue
        End Get
        Set(value As String)
            BusinessEmailValue = Trim(value)
        End Set
    End Property

    Public Property AddressLineOne() As String
        Get
            Return AddressLineOneValue
        End Get
        Set(value As String)
            AddressLineOneValue = Trim(value)
        End Set
    End Property

    Public Property AddressLineTwo() As String
        Get
            Return AddressLineTwoValue
        End Get
        Set(value As String)
            AddressLineTwoValue = Trim(value)
        End Set
    End Property

    Public Property City() As String
        Get
            Return CityValue
        End Get
        Set(value As String)
            CityValue = Trim(value)
        End Set
    End Property

    Public Property Country() As String
        Get
            Return CountryValue
        End Get
        Set(value As String)
            CountryValue = Trim(value)
        End Set
    End Property

    Public Property Zipcode() As String
        Get
            Return ZipcodeValue
        End Get
        Set(value As String)
            ZipcodeValue = Trim(value)
        End Set
    End Property

    Public Sub Create(Table As SuppliersTableAdapter)
        Dim Result As Integer
        Result = Table.InsertSupplier(BusinessNameValue, ContactNameValue, ContactFirstLastNameValue, ContactSecondLastNameValue, BusinessPhoneValue, ContactPhoneValue, BusinessEmailValue,
                                      AddressLineOneValue, AddressLineTwoValue, CityValue, CountryValue, ZipcodeValue)
        If Result = 1 Then
            SavedValue = True
        Else
            SavedValue = False
        End If
    End Sub

    Public Sub SetSupplierFromRow(Row As DataGridViewRow)
        Dim Cells = Row.Cells
        BusinessNameValue = Cells(0).Value
        BusinessPhoneValue = Cells(4).Value
        BusinessEmailValue = Cells(6).Value
        ContactNameValue = Cells(1).Value
        ContactFirstLastNameValue = Cells(2).Value
        ContactSecondLastNameValue = Cells(3).Value
        ContactPhoneValue = Cells(5).Value
        AddressLineOneValue = Cells(7).Value
        AddressLineTwoValue = Cells(8).Value
        CityValue = Cells(9).Value
        CountryValue = Cells(10).Value
        ZipcodeValue = Cells(11).Value
        IDValue = Cells(12).Value
    End Sub

    Public Sub Update(Table As SuppliersTableAdapter)
        Dim Result As Integer
        Result = Table.UpdateSupplier(BusinessNameValue, ContactNameValue, ContactFirstLastNameValue, ContactSecondLastNameValue, BusinessPhoneValue, ContactPhoneValue, BusinessEmailValue,
                                      AddressLineOneValue, AddressLineTwoValue, CityValue, CountryValue, ZipcodeValue, IDValue)
        If Result = 1 Then
            SavedValue = True
        Else
            SavedValue = False
        End If
    End Sub

    Public Function IsSame(SupplierTwo As Supplier)
        Dim SupplierOneArray = Me.ToArray()
        Dim SupplierTwoArray = SupplierTwo.ToArray()
        Dim Same As Boolean

        For index = 0 To SupplierOneArray.GetUpperBound(0)
            If SupplierOneArray(index).Equals(SupplierTwoArray(index)) Then
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
            Trim(Me.BusinessName.ToString),
            Trim(Me.BusinessPhone.ToString),
            Trim(Me.BusinessEmail.ToString),
            Trim(Me.ContactName.ToString),
            Trim(Me.ContactFirstLastName.ToString),
            Trim(Me.ContactSecondLastName.ToString),
            Trim(Me.ContactPhone.ToString),
            Trim(Me.AddressLineOne.ToString),
            Trim(Me.AddressLineTwo.ToString),
            Trim(Me.City.ToString),
            Trim(Me.Country.ToString),
            Trim(Me.Zipcode.ToString)
            }
        Return Attributes
    End Function

    Public Function Saved()
        Return SavedValue
    End Function
End Class
