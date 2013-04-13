Public Class calculator

    Private Sub StartDatePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartDatePicker.ValueChanged
        Dim myCalc As New CalcClass2005.DateCalc()
        myCalc.StartDate = StartDatePicker.Value
        myCalc.Span = 7
        myCalc.IncreaseDate(
        EndDate.Text = myCalc.EndDate.ToString()
    End Sub
End Class
