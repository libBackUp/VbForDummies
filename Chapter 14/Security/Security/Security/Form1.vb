Imports System.Security.Principal

Public Class Form1
    Dim myIdentity As System.Security.Principal.WindowsIdentity = System.Security.Principal.WindowsIdentity.GetCurrent()
    Dim myPrincipal As WindowsPrincipal = New System.Security.Principal.WindowsPrincipal(myIdentity)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If myPrincipal.IsInRole("Accounting") Then
            AccountingButton.Visible = True
        ElseIf myPrincipal.IsInRole("Sales") Then
            SalesButton.Visible = True
        ElseIf myPrincipal.IsInRole("Management") Then
            ManagementButton.Visible = True
        End If

    End Sub
End Class
