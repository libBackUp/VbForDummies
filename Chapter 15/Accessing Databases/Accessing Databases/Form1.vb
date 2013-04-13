Public Class Form1

    Private Sub bindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bindingNavigatorSaveItem.Click
        If Me.Validate Then
            Me.CustomersBindingSource.EndEdit()
            Me.CustomersTableAdapter.Update(Me.NorthwindDataSet.Customers)
        Else
            System.Windows.Forms.MessageBox.Show(Me, "Validation errors occurred.", "Save", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwindDataSet.CustomerCustomerDemo' table. You can move, or remove it, as needed.
        Me.CustomerCustomerDemoTableAdapter.Fill(Me.NorthwindDataSet.CustomerCustomerDemo)
        'TODO: This line of code loads data into the 'NorthwindDataSet.CustomerDemographics' table. You can move, or remove it, as needed.
        Me.CustomerDemographicsTableAdapter.Fill(Me.NorthwindDataSet.CustomerDemographics)
        'TODO: This line of code loads data into the 'NorthwindDataSet.CustomerCustomerDemo' table. You can move, or remove it, as needed.
        Me.CustomerCustomerDemoTableAdapter.Fill(Me.NorthwindDataSet.CustomerCustomerDemo)
        'TODO: This line of code loads data into the 'NorthwindDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.NorthwindDataSet.Customers)

    End Sub
End Class
