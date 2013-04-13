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
        Me.leftRaftingContainer = New System.Windows.Forms.RaftingContainer
        Me.rightRaftingContainer = New System.Windows.Forms.RaftingContainer
        Me.topRaftingContainer = New System.Windows.Forms.RaftingContainer
        Me.bottomRaftingContainer = New System.Windows.Forms.RaftingContainer
        CType(Me.leftRaftingContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightRaftingContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.topRaftingContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bottomRaftingContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leftRaftingContainer
        '
        Me.leftRaftingContainer.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftRaftingContainer.Name = "leftRaftingContainer"
        '
        'rightRaftingContainer
        '
        Me.rightRaftingContainer.Dock = System.Windows.Forms.DockStyle.Right
        Me.rightRaftingContainer.Name = "rightRaftingContainer"
        '
        'topRaftingContainer
        '
        Me.topRaftingContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.topRaftingContainer.Name = "topRaftingContainer"
        '
        'bottomRaftingContainer
        '
        Me.bottomRaftingContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottomRaftingContainer.Name = "bottomRaftingContainer"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(344, 266)
        Me.Controls.Add(Me.leftRaftingContainer)
        Me.Controls.Add(Me.rightRaftingContainer)
        Me.Controls.Add(Me.topRaftingContainer)
        Me.Controls.Add(Me.bottomRaftingContainer)
        Me.Location = New System.Drawing.Point(12, 13)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.leftRaftingContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightRaftingContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.topRaftingContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bottomRaftingContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents leftRaftingContainer As System.Windows.Forms.RaftingContainer
    Friend WithEvents rightRaftingContainer As System.Windows.Forms.RaftingContainer
    Friend WithEvents topRaftingContainer As System.Windows.Forms.RaftingContainer
    Friend WithEvents bottomRaftingContainer As System.Windows.Forms.RaftingContainer

End Class
