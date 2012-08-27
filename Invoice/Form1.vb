Public Class Form1

    Private Sub InvoicesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles InvoicesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InvoicesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TestDataSet)

    End Sub

    Private Sub FillToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillToolStripButton.Click
        Try
            Me.InvoicesTableAdapter.Fill(Me.TestDataSet.Invoices, CustomerToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.TestDataSet.Customers)

    End Sub
End Class