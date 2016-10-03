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

    Public ReadOnly Property ID() As Integer
        Get
            Return IDValue
        End Get
    End Property

    Public Property BusinessName() As String
        Get
            Return BusinessNameValue
        End Get
        Set(value As String)
            BusinessNameValue = value
        End Set
    End Property

    Public Property ContactName() As String
        Get
            Return ContactNameValue
        End Get
        Set(value As String)
            ContactNameValue = value
        End Set
    End Property

    Public Property ContactFirstLastName() As String
        Get
            Return ContactFirstLastNameValue
        End Get
        Set(value As String)
            ContactFirstLastNameValue = value
        End Set
    End Property

    Public Property ContactSecondLastName() As String
        Get
            Return ContactSecondLastNameValue
        End Get
        Set(value As String)
            ContactSecondLastNameValue = value
        End Set
    End Property

    Public Property BusinessPhone() As String
        Get
            Return BusinessPhoneValue
        End Get
        Set(value As String)
            BusinessPhoneValue = value
        End Set
    End Property

    Public Property ContactPhone() As String
        Get
            Return ContactPhoneValue
        End Get
        Set(value As String)
            ContactPhoneValue = value
        End Set
    End Property

    Public Property BusinessEmail() As String
        Get
            Return BusinessEmailValue
        End Get
        Set(value As String)
            BusinessEmailValue = value
        End Set
    End Property

    Public Property AddressLineOne() As String
        Get
            Return AddressLineOneValue
        End Get
        Set(value As String)
            AddressLineOneValue = value
        End Set
    End Property

    Public Property AddressLineTwo() As String
        Get
            Return AddressLineTwoValue
        End Get
        Set(value As String)
            AddressLineTwoValue = value
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

    Public Property Country() As String
        Get
            Return CountryValue
        End Get
        Set(value As String)
            CountryValue = value
        End Set
    End Property

    Public Property Zipcode() As String
        Get
            Return ZipcodeValue
        End Get
        Set(value As String)
            ZipcodeValue = value
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
End Class
