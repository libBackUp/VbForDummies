Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myProcess As New Process()
        Dim searchString As String = System.Web.HttpUtility.UrlEncode(TextBox1.Text)
        Dim urlString As String = "http://www.google.com/search?q=" + searchString
        myProcess.StartInfo.FileName = urlString
        myProcess.Start()
    End Sub
End Class