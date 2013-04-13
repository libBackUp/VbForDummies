<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DateCalc
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
        Me.DateChooser = New System.Windows.Forms.DateTimePicker
        Me.NextWeek = New System.Windows.Forms.Label
        Me.DateNumber = New System.Windows.Forms.TextBox
        Me.mainStatusStrip = New System.Windows.Forms.StatusStrip
        Me.dateStrip = New System.Windows.Forms.ToolStripStatusLabel
        Me.UserStrip = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.primaryMenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.primaryContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mainStatusStrip.SuspendLayout()
        Me.primaryMenuStrip.SuspendLayout()
        Me.primaryContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateChooser
        '
        Me.DateChooser.Location = New System.Drawing.Point(105, 140)
        Me.DateChooser.Name = "DateChooser"
        Me.DateChooser.Size = New System.Drawing.Size(200, 20)
        Me.DateChooser.TabIndex = 0
        '
        'NextWeek
        '
        Me.NextWeek.AutoSize = True
        Me.NextWeek.Location = New System.Drawing.Point(247, 93)
        Me.NextWeek.Name = "NextWeek"
        Me.NextWeek.Size = New System.Drawing.Size(58, 13)
        Me.NextWeek.TabIndex = 1
        Me.NextWeek.Text = "NextWeek"
        '
        'DateNumber
        '
        Me.DateNumber.Location = New System.Drawing.Point(105, 93)
        Me.DateNumber.Name = "DateNumber"
        Me.DateNumber.Size = New System.Drawing.Size(100, 20)
        Me.DateNumber.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.DateNumber, "Enter number of days here")
        '
        'mainStatusStrip
        '
        Me.mainStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dateStrip, Me.UserStrip})
        Me.mainStatusStrip.Location = New System.Drawing.Point(0, 244)
        Me.mainStatusStrip.Name = "mainStatusStrip"
        Me.mainStatusStrip.Size = New System.Drawing.Size(529, 22)
        Me.mainStatusStrip.TabIndex = 3
        '
        'dateStrip
        '
        Me.dateStrip.Name = "dateStrip"
        Me.dateStrip.Size = New System.Drawing.Size(257, 17)
        Me.dateStrip.Spring = True
        '
        'UserStrip
        '
        Me.UserStrip.Name = "UserStrip"
        Me.UserStrip.Size = New System.Drawing.Size(257, 17)
        Me.UserStrip.Spring = True
        '
        'primaryMenuStrip
        '
        Me.primaryMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.primaryMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.primaryMenuStrip.Name = "primaryMenuStrip"
        Me.primaryMenuStrip.Size = New System.Drawing.Size(529, 24)
        Me.primaryMenuStrip.TabIndex = 4
        Me.primaryMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'primaryContextMenu
        '
        Me.primaryContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem})
        Me.primaryContextMenu.Name = "primaryContextMenu"
        Me.primaryContextMenu.Size = New System.Drawing.Size(153, 48)
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CalculateToolStripMenuItem.Text = "Calculate"
        '
        'DateCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 266)
        Me.Controls.Add(Me.mainStatusStrip)
        Me.Controls.Add(Me.primaryMenuStrip)
        Me.Controls.Add(Me.DateNumber)
        Me.Controls.Add(Me.NextWeek)
        Me.Controls.Add(Me.DateChooser)
        Me.MainMenuStrip = Me.primaryMenuStrip
        Me.Name = "DateCalc"
        Me.Text = "Date Calculator"
        Me.mainStatusStrip.ResumeLayout(False)
        Me.mainStatusStrip.PerformLayout()
        Me.primaryMenuStrip.ResumeLayout(False)
        Me.primaryMenuStrip.PerformLayout()
        Me.primaryContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateChooser As System.Windows.Forms.DateTimePicker
    Friend WithEvents NextWeek As System.Windows.Forms.Label
    Friend WithEvents DateNumber As System.Windows.Forms.TextBox
    Friend WithEvents mainStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents dateStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UserStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents primaryMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents primaryContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CalculateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
