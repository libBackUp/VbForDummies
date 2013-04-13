Imports System.net.Mail

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SendEmail(TextBox1.Text, TextBox1.Text, "Test Email", "This is a test email.")
    End Sub

    Sub SendEmail(ByVal fromAddress As String, ByVal toAddress As String, ByVal subject As String, ByVal body As String)
        Dim message As New MailMessage(fromAddress, toAddress, subject, body)
        Dim mailClient As New SmtpClient("localhost")
        mailClient.Send(message)
        message = Nothing
        mailClient = Nothing
    End Sub
End Class
