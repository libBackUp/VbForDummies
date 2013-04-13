Imports System.Net
Imports System.Net.Mail
Imports System.IO

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'DownloadFile("ftp://ftp.vbfordummies.com/sampleFile.bmp", "c:\sampleFile.bmp")
        DownloadWebFile("http://www.vbfordummies.com/sampleFile.bmp", "c:\sampleFile.bmp")
    End Sub

    Protected Sub DownloadWebFile(ByVal remoteFile As String, ByVal localFile As String)
        Dim localFileStream As New FileStream(localFile, FileMode.OpenOrCreate)
        Dim myRequest As WebRequest = WebRequest.Create(remoteFile)
        myRequest.Method = WebRequestMethods.Http.Get
        Dim myResponse As WebResponse = myRequest.GetResponse
        Dim myResponseStream As Stream = myResponse.GetResponseStream
        Dim buffer(1024) As Byte
        Dim bytesRead As Integer = myResponseStream.Read(buffer, 0, 1024)
        While bytesRead > 0
            localFileStream.Write(buffer, 0, bytesRead)
            bytesRead = myResponseStream.Read(buffer, 0, 1024)
        End While
        localFileStream.Close()
        myResponseStream.Close()
    End Sub

    Protected Sub DownloadFile(ByVal remoteFile As String, ByVal localFile As String)
        Dim localFileStream As New FileStream(localFile, FileMode.OpenOrCreate)
        Dim myRequest As FtpWebRequest = WebRequest.Create(remoteFile)
        myRequest.Method = WebRequestMethods.Ftp.DownloadFile
        myRequest.Credentials = New NetworkCredential("Anonymous", _
        "bill@sempf.net")
        Dim myResponse As WebResponse = myRequest.GetResponse
        Dim myResponseStream As Stream = myResponse.GetResponseStream
        Dim buffer(1024) As Byte
        Dim bytesRead As Integer = myResponseStream.Read(buffer, 0, 1024)
        While bytesRead > 0
            localFileStream.Write(buffer, 0, bytesRead)
            bytesRead = myResponseStream.Read(buffer, 0, 1024)
        End While
        localFileStream.Close()
        myResponseStream.Close()
    End Sub

End Class
