Public Class DateMath
    Public Shared Function FindDateDiff(ByRef startdate As Date, ByRef enddate As Date) As Integer
        Dim difference As Integer
        difference = (startdate - enddate).Days
        startdate.AddDays(1)
        enddate.AddMonths(1)
        Return difference
    End Function
End Class
