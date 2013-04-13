<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FileName = New System.Windows.Forms.Label
        Me.Openfile = New System.Windows.Forms.Button
        Me.SaveFile = New System.Windows.Forms.Button
        Me.FileContents = New System.Windows.Forms.TextBox
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FileName
        '
        Me.FileName.AutoSize = True
        Me.FileName.Location = New System.Drawing.Point(55, 74)
        Me.FileName.Name = "FileName"
        Me.FileName.Size = New System.Drawing.Size(52, 13)
        Me.FileName.TabIndex = 0
        Me.FileName.Text = "File name"
        '
        'Openfile
        '
        Me.Openfile.Location = New System.Drawing.Point(55, 36)
        Me.Openfile.Name = "Openfile"
        Me.Openfile.Size = New System.Drawing.Size(75, 23)
        Me.Openfile.TabIndex = 2
        Me.Openfile.Text = "Open File"
        Me.Openfile.UseVisualStyleBackColor = True
        '
        'SaveFile
        '
        Me.SaveFile.Location = New System.Drawing.Point(152, 35)
        Me.SaveFile.Name = "SaveFile"
        Me.SaveFile.Size = New System.Drawing.Size(75, 23)
        Me.SaveFile.TabIndex = 3
        Me.SaveFile.Text = "Save File"
        Me.SaveFile.UseVisualStyleBackColor = True
        '
        'FileContents
        '
        Me.FileContents.Location = New System.Drawing.Point(55, 110)
        Me.FileContents.Multiline = True
        Me.FileContents.Name = "FileContents"
        Me.FileContents.Size = New System.Drawing.Size(172, 144)
        Me.FileContents.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.FileContents)
        Me.Controls.Add(Me.SaveFile)
        Me.Controls.Add(Me.Openfile)
        Me.Controls.Add(Me.FileName)
        Me.Name = "Form1"
        Me.Text = "File Managment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FileName As System.Windows.Forms.Label
    Friend WithEvents Openfile As System.Windows.Forms.Button
    Friend WithEvents SaveFile As System.Windows.Forms.Button
    Friend WithEvents FileContents As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
