Partial Public Class calculator
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

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
        Me.StartDatePicker = New System.Windows.Forms.DateTimePicker
        Me.EndDate = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'StartDatePicker
        '
        Me.StartDatePicker.Location = New System.Drawing.Point(42, 41)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.TabIndex = 0
        '
        'EndDate
        '
        Me.EndDate.AutoSize = True
        Me.EndDate.Location = New System.Drawing.Point(89, 119)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(0, 0)
        Me.EndDate.TabIndex = 1
        '
        'calculator
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.EndDate)
        Me.Controls.Add(Me.StartDatePicker)
        Me.Name = "calculator"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EndDate As System.Windows.Forms.Label

End Class
