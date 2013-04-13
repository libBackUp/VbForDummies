Partial Public Class Form1
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
        Dim AppTitle As System.Windows.Forms.Label
        Me.TimeCheck = New System.Timers.Timer
        AppTitle = New System.Windows.Forms.Label
        CType(Me.TimeCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AppTitle
        '
        AppTitle.AutoSize = True
        AppTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AppTitle.Location = New System.Drawing.Point(131, 64)
        AppTitle.Name = "AppTitle"
        AppTitle.Size = New System.Drawing.Size(298, 41)
        AppTitle.TabIndex = 0
        AppTitle.Text = "Caps Lock Checker"
        '
        'TimeCheck
        '
        Me.TimeCheck.Enabled = True
        Me.TimeCheck.Interval = 2000
        Me.TimeCheck.SynchronizingObject = Me
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(551, 183)
        Me.Controls.Add(AppTitle)
        Me.Name = "Form1"
        Me.Text = "CLC"
        CType(Me.TimeCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimeCheck As System.Timers.Timer

End Class
