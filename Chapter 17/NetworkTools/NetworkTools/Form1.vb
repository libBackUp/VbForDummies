Imports System.Net

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If NetworkInformation.NetworkInterface.GetIsNetworkAvailable Then
            ToolStripStatusLabel1.Text = "Connected"
        Else
            ToolStripStatusLabel1.Text = "Disconnected"
        End If
    End Sub

End Class
