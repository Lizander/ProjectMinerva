Public Class Store
    Private IDValue As Integer
    Private NameValue As String
    Private AddressLineOneValue As String
    Private AddressLineTwoValue As String
    Private CityValue As String
    Private ZipcodeValue As String
    Private PhoneNumberValue As String
    Private EmailAddressValue As String
    Private StateTaxRateValue As Double
    Private MunicipalTaxRateValue As Double

    Public ReadOnly Property ID() As Integer
        Get
            Return IDValue
        End Get
    End Property

    Public Property Name() As String
        Get
            Return NameValue
        End Get
        Set(value As String)
            NameValue = value
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

    Public Property Zipcode() As String
        Get
            Return ZipcodeValue
        End Get
        Set(value As String)
            ZipcodeValue = value
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

    Public Property StateTaxRate() As Double
        Get
            Return StateTaxRateValue
        End Get
        Set(value As Double)
            StateTaxRateValue = value
        End Set
    End Property

    Public Property MunicipalTaxRate() As Double
        Get
            Return MunicipalTaxRateValue
        End Get
        Set(value As Double)
            MunicipalTaxRateValue = value
        End Set
    End Property
End Class
