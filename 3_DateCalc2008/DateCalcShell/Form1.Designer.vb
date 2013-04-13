<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.EndDate = New System.Windows.Forms.Label()
        Me.StartDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'EndDate
        '
        Me.EndDate.AutoSize = True
        Me.EndDate.Location = New System.Drawing.Point(84, 68)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(39, 13)
        Me.EndDate.TabIndex = 0
        Me.EndDate.Text = "Label1"
        '
        'StartDatePicker
        '
        Me.StartDatePicker.Location = New System.Drawing.Point(40, 117)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.Size = New System.Drawing.Size(200, 20)
        Me.StartDatePicker.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.StartDatePicker)
        Me.Controls.Add(Me.EndDate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EndDate As System.Windows.Forms.Label
    Friend WithEvents StartDatePicker As System.Windows.Forms.DateTimePicker

End Class
