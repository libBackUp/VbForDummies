Public Class DateSearch

    Private _earlyDate As Date
    Private _lateDate As Date
    Private _numberOfDays As Integer

    Public Property EarlyDate() As Date
        Get
            Return _earlyDate
        End Get
        Set(ByVal value As Date)
            _earlyDate = value
        End Set
    End Property
    Public Property LateDate() As Date
        Get
            Return _lateDate
        End Get
        Set(ByVal value As Date)
            _lateDate = value
        End Set
    End Property
    Public Property NumberOfDays() As Integer
        Get
            Return _numberOfDays
        End Get
        Set(ByVal value As Integer)
            _numberOfDays = value
        End Set
    End Property

End Class
Public Class DateSearches
    Implements Collections.IEnumerable
    Private _dateSearchList As Hashtable
    Public Sub AddSearch(ByVal currentSearch As DateSearch)
        _dateSearchList.Add(System.Guid.NewGuid, currentSearch)
    End Sub
    Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
        Return CType(_dateSearchList, IEnumerator)
    End Function
End Class