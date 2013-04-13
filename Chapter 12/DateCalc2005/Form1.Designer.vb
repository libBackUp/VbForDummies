Partial Public Class CalculatorMain
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.EarlyDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.LateDate = New System.Windows.Forms.DateTimePicker
        Me.NumberOfDays = New System.Windows.Forms.TextBox
        Me.DaysLabel = New System.Windows.Forms.Label
        Me.NumberChecker = New System.Windows.Forms.ErrorProvider
        Me.SavedSearchesView = New System.Windows.Forms.DataGridView
        Me.DateSearchesDataConnector = New System.Windows.Forms.DataConnector(Me.components)
        Me.SaveSearch = New System.Windows.Forms.Button
        Me.MenuBar = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        CType(Me.NumberChecker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateSearchesDataConnector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EarlyDate
        '
        Me.EarlyDate.Location = New System.Drawing.Point(13, 69)
        Me.EarlyDate.Name = "EarlyDate"
        Me.EarlyDate.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "The Date Calculator 2005"
        '
        'LateDate
        '
        Me.LateDate.Location = New System.Drawing.Point(311, 69)
        Me.LateDate.Name = "LateDate"
        Me.LateDate.TabIndex = 2
        '
        'NumberOfDays
        '
        Me.NumberOfDays.Location = New System.Drawing.Point(246, 69)
        Me.NumberOfDays.Name = "NumberOfDays"
        Me.NumberOfDays.Size = New System.Drawing.Size(29, 20)
        Me.NumberOfDays.TabIndex = 5
        '
        'DaysLabel
        '
        Me.DaysLabel.AutoSize = True
        Me.DaysLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DaysLabel.Location = New System.Drawing.Point(246, 96)
        Me.DaysLabel.Name = "DaysLabel"
        Me.DaysLabel.Size = New System.Drawing.Size(29, 14)
        Me.DaysLabel.TabIndex = 6
        Me.DaysLabel.Text = "Days"
        '
        'NumberChecker
        '
        Me.NumberChecker.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.NumberChecker.ContainerControl = Me
        '
        'SavedSearchesView
        '
        Me.SavedSearchesView.AllowUserToAddRows = False
        Me.SavedSearchesView.AllowUserToDeleteRows = False
        Me.SavedSearchesView.AutoGenerateColumns = False
        Me.SavedSearchesView.BackgroundColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Courier New", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.SavedSearchesView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewTextBoxColumn1.HeaderText = "Early Date"
        DataGridViewTextBoxColumn1.Name = "EarlyDate"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewTextBoxColumn2.HeaderText = "Late Date"
        DataGridViewTextBoxColumn2.Name = "LateDate"
        DataGridViewTextBoxColumn2.ReadOnly = True
        DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewTextBoxColumn3.HeaderText = "Number of Days"
        DataGridViewTextBoxColumn3.Name = "NumberOfDays"
        DataGridViewTextBoxColumn3.ReadOnly = True
        DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SavedSearchesView.Columns.Add(DataGridViewTextBoxColumn1)
        Me.SavedSearchesView.Columns.Add(DataGridViewTextBoxColumn2)
        Me.SavedSearchesView.Columns.Add(DataGridViewTextBoxColumn3)
        Me.SavedSearchesView.DataSource = Me.DateSearchesDataConnector
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Courier New", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SavedSearchesView.DefaultCellStyle = DataGridViewCellStyle3
        Me.SavedSearchesView.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.SavedSearchesView.GridColor = System.Drawing.Color.DarkGray
        Me.SavedSearchesView.Location = New System.Drawing.Point(14, 132)
        Me.SavedSearchesView.Name = "SavedSearchesView"
        Me.SavedSearchesView.ReadOnly = True
        Me.SavedSearchesView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.SavedSearchesView.Size = New System.Drawing.Size(496, 150)
        Me.SavedSearchesView.TabIndex = 7
        '
        'DateSearchesDataConnector
        '
        Me.DateSearchesDataConnector.DataSource = GetType(DateCalc2005.DateSearches)
        '
        'SaveSearch
        '
        Me.SaveSearch.Location = New System.Drawing.Point(12, 102)
        Me.SaveSearch.Name = "SaveSearch"
        Me.SaveSearch.Size = New System.Drawing.Size(199, 23)
        Me.SaveSearch.TabIndex = 8
        Me.SaveSearch.Text = "Save this Search"
        '
        'MenuBar
        '
        Me.MenuBar.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        Me.MenuBar.Name = "MenuBar"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Name = "MenuItem1"
        Me.MenuItem1.Text = "File"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Name = "MenuItem2"
        Me.MenuItem2.Text = "Exit"
        '
        'CalculatorMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(524, 298)
        Me.Controls.Add(Me.SaveSearch)
        Me.Controls.Add(Me.SavedSearchesView)
        Me.Controls.Add(Me.DaysLabel)
        Me.Controls.Add(Me.NumberOfDays)
        Me.Controls.Add(Me.LateDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EarlyDate)
        Me.Menu = Me.MenuBar
        Me.Name = "CalculatorMain"
        Me.Text = "The Date Calculator 2005"
        CType(Me.NumberChecker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateSearchesDataConnector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EarlyDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LateDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents NumberOfDays As System.Windows.Forms.TextBox
    Friend WithEvents DaysLabel As System.Windows.Forms.Label
    Friend WithEvents NumberChecker As System.Windows.Forms.ErrorProvider
    Friend WithEvents SavedSearchesView As System.Windows.Forms.DataGridView
    Friend WithEvents SaveSearch As System.Windows.Forms.Button
    Friend WithEvents DateSearchesDataConnector As System.Windows.Forms.DataConnector
    Friend WithEvents MenuBar As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem

End Class
