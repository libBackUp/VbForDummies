Public Class DateCalc2008

    Private _startDate As DateTime
    Private _endDate As DateTime
    Private _span As Integer

    Public Property StartDate() As DateTime
        Get
            StartDate = _startDate
        End Get
        Set(ByVal value As DateTime)
            _startDate = value
        End Set
    End Property

    Public Property EndDate() As DateTime
        Get
            EndDate = _endDate
        End Get
        Set(ByVal value As DateTime)
            _endDate = value
        End Set
    End Property

    Public Property Span() As Integer
        Get
            Span = _span
        End Get
        Set(ByVal value As Integer)
            _span = value
        End Set
    End Property

    Public Sub IncreaseDate()
        Dim dblSpan As Double = CDbl(Span)
        EndDate = StartDate.AddDays(dblSpan)
    End Sub

End Class
