Imports System.Threading

Public Class Form1

    Private Sub StartThread_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartThread.Click
        Dim NetworkEmulator As New Timer(New TimerCallback(AddressOf FakeNetworkCall), Nothing, 0, 4000)
    End Sub
    Public Sub FakeNetworkCall(ByVal state As Object)
        MessageBox.Show("This is a network call!!")
    End Sub

    Dim TestNumber As Integer = 0
    Private Sub TextLocking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextLocking.Click
        TestNumber = TestNumber + 1
        Me.Text = Me.Text + TestNumber.ToString
    End Sub

    Private Sub NetworkEmulator_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetworkEmulator.Tick

    End Sub
End Class
