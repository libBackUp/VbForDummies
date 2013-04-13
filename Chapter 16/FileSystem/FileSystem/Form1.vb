Imports System.IO

Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Openfile.Click
        'Open the dialog and make sure it was successful
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Open a streamreader with the file name from the dialog
            Dim myStreamReader As New StreamReader(OpenFileDialog1.FileName)
            'Read the file with the streamreader
            Dim myFileContents As String = myStreamReader.ReadToEnd()
            'Close the streamreader - it uses resources
            myStreamReader.Close()
            'Set the output fields
            FileName.Text = OpenFileDialog1.FileName.ToString
            FileContents.Text = myFileContents
        End If
    End Sub

    Private Sub SaveFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveFile.Click
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim myStreamWriter As New StreamWriter(SaveFileDialog1.FileName)
            If Not (myStreamWriter Is Nothing) Then
                'Then use the TextBox to get the contents.
                myStreamWriter.Write(FileContents.Text)
                'Inform the user 
                MessageBox.Show("File saved")
                'Close the StreamWriter - it uses resources
                myStreamWriter.Close()
            End If
        End If
    End Sub
End Class
