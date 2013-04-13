Public Class Calculator

    Private Sub DateChooser_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateChooser.ValueChanged
        Dim myCalc As New DateCalcClassChapter6.CalcClass2005()
        myCalc.StartDate = DateChooser.Value
        myCalc.Span = 7
        myCalc.IncreaseDate()
        NextWeek.Text = myCalc.EndDate.ToString()
    End Sub
End Class
