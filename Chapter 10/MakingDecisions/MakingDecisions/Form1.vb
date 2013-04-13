Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'If TextBox1.Text = "Showered" Then
        '    MessageBox.Show("Brush Teeth!")
        'End If

        'If TextBox1.Text = "Showered" Or TextBox1.Text = "Took Bath" Then
        '    MessageBox.Show("Brush Teeth!")
        'End If

        'If TextBox1.Text = "Showered" Then
        '    MessageBox.Show("Brush Teeth!")
        'Else
        '    MessageBox.Show("Shower.")
        'End If

        'If TextBox1.Text = "Showered last night" Then
        '    MessageBox.Show("Brush teeth!")
        'ElseIf TextBox1.Text = "Showered two nights ago" Then
        '    MessageBox.Show("Shower again!")
        'Else
        '    MessageBox.Show("Shower!")
        'End If

        Select Case TextBox1.Text
            Case "Coffee Made"
                MessageBox.Show("Drink Coffee!")
            Case "TeaMade"
                MessageBox.Show("Drink Tea!")
            Case "How Chocolate Made"
                MessageBox.Show("Drink How Chocolate!")
            Case Else
                MessageBox.Show("Drink Cola!")
        End Select
    End Sub
End Class
