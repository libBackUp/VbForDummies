Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Debug.Write("Loading Form")
        Dim myDateCalc As New CalcClass2005.DateCalc
        NextWeek.Text = myDateCalc.IncreaseDate(Now, 7).ToString
    End Sub
End Class
