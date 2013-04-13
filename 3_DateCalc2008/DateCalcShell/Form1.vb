Public Class Form1

    Private Sub StartDatePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartDatePicker.ValueChanged
        Dim myCalc As New DateCalc2008.DateCalc2008() 'According to the book, it should be "Dim myCalc As New 2008DateCalcClassChapter6.CalcClass2008()"
        myCalc.StartDate = StartDatePicker.Value
        myCalc.Span = 7
        myCalc.IncreaseDate()
        EndDate.Text = myCalc.EndDate.ToString()

    End Sub
End Class
