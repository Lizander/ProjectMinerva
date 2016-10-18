Imports ProjectMinerva.JupiterDataSetTableAdapters

Public Class Service
    Private IDValue As Integer
    Private NameValue As String
    Private DescriptionValue As String
    Private CategoryValue As String
    Private PriceValue As Double
    Private CostValue As Double
    Private MarkupValue As Double
    Private StateExemptValue As String
    Private MunicipalExemptValue As String
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
            NameValue = value
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

    Public Sub Create(Table As ServicesTableAdapter)
        Dim Result As Integer
        Result = Table.InsertService(NameValue, DescriptionValue, CategoryValue, PriceValue, CostValue, Markup, StateExemptValue, MunicipalExemptValue)
        If Result = 1 Then
            SavedValue = True
        Else
            SavedValue = False
        End If
    End Sub

    Public Function Saved()
        Return SavedValue
    End Function

    Public Sub SetFromRow(Row As DataGridViewRow)
        Dim Cells = Row.Cells
        IDValue = Cells.Item(0).Value
        NameValue = Trim(Cells.Item(1).Value)
        DescriptionValue = Trim(Cells.Item(2).Value)
        CategoryValue = Trim(Cells.Item(3).Value)
        PriceValue = Trim(Cells.Item(4).Value)
        CostValue = Trim(Cells.Item(5).Value)
        MarkupValue = Trim(Cells.Item(6).Value)
        StateExemptValue = Trim(Cells.Item(7).Value)
        MunicipalExemptValue = Trim(Cells.Item(8).Value)
    End Sub

    Public Function IsSame(ServiceTwo As Service)
        Dim ServiceOneArray = Me.ToArray()
        Dim ServiceTwoArray = ServiceTwo.ToArray()
        Dim Same As Boolean

        For index = 0 To ServiceOneArray.GetUpperBound(0)
            If ServiceOneArray(index).Equals(ServiceTwoArray(index)) Then
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
            Trim(Me.Description.ToString),
            Trim(Me.Category.ToString),
            Trim(Me.StateExempt.ToString),
            Trim(Me.MunicipalExempt.ToString),
            Trim(Me.Markup.ToString),
            Trim(Me.Price.ToString),
            Trim(Me.Cost.ToString)
            }
        Return Attributes
    End Function

    Public Sub Update(Table As ServicesTableAdapter)
        Dim Result As Integer
        Result = Table.UpdateService(NameValue, DescriptionValue, CategoryValue, PriceValue, CostValue, Markup, StateExemptValue, MunicipalExemptValue, IDValue)
        If Result = 1 Then
            SavedValue = True
        Else
            SavedValue = False
        End If
    End Sub
End Class
