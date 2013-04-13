Public Class Form1

    'Ok, ok, I added a few things.
    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.Text = "Mouse In"
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Text = "Mouse Out"
    End Sub

    Private Sub Timer1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Disposed
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
    End Sub

End Class
