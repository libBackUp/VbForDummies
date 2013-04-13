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
        Me.Title = New System.Windows.Forms.Label
        Me.SalesButton = New System.Windows.Forms.Button
        Me.AccountingButton = New System.Windows.Forms.Button
        Me.ManagementButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(33, 13)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(226, 24)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Our Company Application"
        '
        'SalesButton
        '
        Me.SalesButton.Location = New System.Drawing.Point(87, 83)
        Me.SalesButton.Name = "SalesButton"
        Me.SalesButton.Size = New System.Drawing.Size(116, 25)
        Me.SalesButton.TabIndex = 1
        Me.SalesButton.Text = "Sales Menu"
        Me.SalesButton.UseVisualStyleBackColor = True
        Me.SalesButton.Visible = False
        '
        'AccountingButton
        '
        Me.AccountingButton.Location = New System.Drawing.Point(87, 114)
        Me.AccountingButton.Name = "AccountingButton"
        Me.AccountingButton.Size = New System.Drawing.Size(116, 25)
        Me.AccountingButton.TabIndex = 2
        Me.AccountingButton.Text = "Accounting Menu"
        Me.AccountingButton.UseVisualStyleBackColor = True
        Me.AccountingButton.Visible = False
        '
        'ManagementButton
        '
        Me.ManagementButton.Location = New System.Drawing.Point(87, 145)
        Me.ManagementButton.Name = "ManagementButton"
        Me.ManagementButton.Size = New System.Drawing.Size(116, 25)
        Me.ManagementButton.TabIndex = 3
        Me.ManagementButton.Text = "Management Menu"
        Me.ManagementButton.UseVisualStyleBackColor = True
        Me.ManagementButton.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 201)
        Me.Controls.Add(Me.ManagementButton)
        Me.Controls.Add(Me.AccountingButton)
        Me.Controls.Add(Me.SalesButton)
        Me.Controls.Add(Me.Title)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents SalesButton As System.Windows.Forms.Button
    Friend WithEvents AccountingButton As System.Windows.Forms.Button
    Friend WithEvents ManagementButton As System.Windows.Forms.Button

End Class
