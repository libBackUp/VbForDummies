<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.components = New System.ComponentModel.Container
        Me.StartThread = New System.Windows.Forms.Button
        Me.TextLocking = New System.Windows.Forms.Button
        Me.NetworkEmulator = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'StartThread
        '
        Me.StartThread.Location = New System.Drawing.Point(30, 34)
        Me.StartThread.Name = "StartThread"
        Me.StartThread.Size = New System.Drawing.Size(97, 41)
        Me.StartThread.TabIndex = 0
        Me.StartThread.Text = "Start the timer"
        Me.StartThread.UseVisualStyleBackColor = True
        '
        'TextLocking
        '
        Me.TextLocking.Location = New System.Drawing.Point(147, 38)
        Me.TextLocking.Name = "TextLocking"
        Me.TextLocking.Size = New System.Drawing.Size(110, 36)
        Me.TextLocking.TabIndex = 1
        Me.TextLocking.Text = "Test the Lock"
        Me.TextLocking.UseVisualStyleBackColor = True
        '
        'NetworkEmulator
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 112)
        Me.Controls.Add(Me.TextLocking)
        Me.Controls.Add(Me.StartThread)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StartThread As System.Windows.Forms.Button
    Friend WithEvents TextLocking As System.Windows.Forms.Button
    Friend WithEvents NetworkEmulator As System.Windows.Forms.Timer

End Class
