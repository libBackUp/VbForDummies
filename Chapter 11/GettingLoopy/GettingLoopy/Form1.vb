Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each myControl As System.Windows.Forms.Control In Me.Controls
            If myControl.GetType Is TextBox1.GetType Then
                myControl.Text = myControl.Location.ToString
            End If
        Next
    End Sub
End Class
