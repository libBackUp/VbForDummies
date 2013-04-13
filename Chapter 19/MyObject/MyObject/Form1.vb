'In order to use the My object, the program must know where to find it.
Imports Microsoft.VisualBasic.MyServices

Public Class Form1
    'Get a new instance of the Log
    Dim theLog As MyLog = My.Application.Log

    Private Sub TimeCheck_Elapsed(ByVal sender As System.Object, ByVal e As System.Timers.ElapsedEventArgs) Handles TimeCheck.Elapsed
        If My.Computer.Keyboard.CapsLock Then
            'Make a log entry!
            Dim logEntry As String
            logEntry = String.Format("{0} used the Caps Lock on {1}", _
                My.User.Identity.Name.ToString(), _
                My.Computer.Clock.LocalTime.Date.ToString())
            theLog.WriteEntry(logEntry)
        End If
    End Sub

End Class
