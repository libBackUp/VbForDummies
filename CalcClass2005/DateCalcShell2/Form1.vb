Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dateCalculator As New CalcClass2005.DateCalc()
        Dim myDate As DateTime
        myDate = dateCalculator.IncreaseDate(System.DateTime.Now, 7)
    End Sub
End Class
