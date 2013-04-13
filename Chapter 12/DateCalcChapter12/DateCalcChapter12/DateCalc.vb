Public Class DateCalc

    Dim DateInterval As Integer = 7

    Private Sub DateChooser_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateChooser.ValueChanged
        If DateNumber.Text.Length > 0 Then
            DateInterval = CInt(DateNumber.Text)
        End If
        NextWeek.Text = DateChooser.Value.Add(TimeSpan.FromDays(DateInterval)).ToShortDateString()
    End Sub


    Private Sub DateCalc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UserStrip.Text = My.User.Name
        dateStrip.Text = Now.Date.ToShortDateString
        Me.MainMenuStrip = primaryMenuStrip
        DateNumber.ContextMenuStrip = primaryContextMenu
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CalculateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateToolStripMenuItem.Click
        If DateNumber.Text.Length > 0 Then
            DateInterval = CInt(DateNumber.Text)
        End If
        NextWeek.Text = DateChooser.Value.Add(TimeSpan.FromDays(DateInterval)).ToShortDateString()
    End Sub
End Class
