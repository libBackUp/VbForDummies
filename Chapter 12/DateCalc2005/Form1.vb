Option Strict On
Option Explicit On
Imports DateCalc2005.DateMath
Public Class CalculatorMain

    Private Sub EarlyDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EarlyDate.ValueChanged
        NumberOfDays.Text = CStr(DateCalc2005.DateMath.FindDateDiff(EarlyDate.Value, LateDate.Value))
    End Sub

    Private Sub LateDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LateDate.ValueChanged
        NumberOfDays.Text = CStr(FindDateDiff(EarlyDate.Value, LateDate.Value))
    End Sub


    Private Sub NumberOfDays_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumberOfDays.TextChanged
        NumberChecker.Clear()
        'If NumberOfDays.Text.Length <> 0 Then
        '    Try
        '        LateDate.Value = EarlyDate.Value.AddDays(CDbl(NumberOfDays.Text))
        '    Catch ice As System.InvalidCastException
        '        NumberChecker.SetError(NumberOfDays, "This value must be a whole number")
        '    Catch ex As Exception
        '        MessageBox.Show("A big ugly error happened.", "Big Ugly Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Me.Close()
        '    End Try
        'End If
    End Sub
    Friend MyDateSearches As DateSearches

    Private Sub SaveSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveSearch.Click
        Dim myDateSearch As New DateSearch
        With myDateSearch
            .EarlyDate = EarlyDate.Value
            .LateDate = LateDate.Value
            .NumberOfDays = CInt(NumberOfDays.Text)
        End With
        MyDateSearches.AddSearch(myDateSearch)
        SavedSearchesView.Refresh()
    End Sub
End Class
