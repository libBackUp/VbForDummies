<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.DateChooser = New System.Windows.Forms.DateTimePicker
        Me.DateSpan = New System.Windows.Forms.TextBox
        Me.NextWeek = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'DateChooser
        '
        Me.DateChooser.Location = New System.Drawing.Point(152, 114)
        Me.DateChooser.Name = "DateChooser"
        Me.DateChooser.Size = New System.Drawing.Size(200, 20)
        Me.DateChooser.TabIndex = 0
        '
        'DateSpan
        '
        Me.DateSpan.Location = New System.Drawing.Point(152, 74)
        Me.DateSpan.Name = "DateSpan"
        Me.DateSpan.Size = New System.Drawing.Size(100, 20)
        Me.DateSpan.TabIndex = 1
        '
        'NextWeek
        '
        Me.NextWeek.AutoSize = True
        Me.NextWeek.Location = New System.Drawing.Point(312, 74)
        Me.NextWeek.Name = "NextWeek"
        Me.NextWeek.Size = New System.Drawing.Size(39, 13)
        Me.NextWeek.TabIndex = 2
        Me.NextWeek.Text = "Label1"
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 266)
        Me.Controls.Add(Me.NextWeek)
        Me.Controls.Add(Me.DateSpan)
        Me.Controls.Add(Me.DateChooser)
        Me.Name = "Calculator"
        Me.Text = "Date Calculator Shell"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateChooser As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateSpan As System.Windows.Forms.TextBox
    Friend WithEvents NextWeek As System.Windows.Forms.Label

End Class
