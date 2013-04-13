Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'The original code.  New math!
        'Label1.Text = TextBox1.Text + TextBox2.Text
        'The adjusted code
        Label1.Text = CType(TextBox1.Text, Integer) + CType(TextBox2.Text, Integer)
    End Sub

    Private Sub TextBox1_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Validated
        If (TextBox1.Text < "0" Or TextBox1.Text > "1000") Then
            MessageBox.Show("You must enter a number between 0 and 1000.")
        End If
    End Sub

    Private Sub TextBox2_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.VisibleChanged
        If (TextBox2.Text < "0" Or TextBox2.Text > "1000") Then
            MessageBox.Show("You must enter a number between 0 and 1000.")
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TitleString As String = "This is my sample program."
        Label2.Text = TitleString
        'Label2.Text = TitleString.ToUpper
        'Label2.Text = TitleString.Replace(“i”, “!”)
        MessageBox.Show(String.Format("The text in Label2 is {0}", Label2.Text))
    End Sub
End Class
