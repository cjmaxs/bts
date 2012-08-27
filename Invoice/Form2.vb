Public Class Form2

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PayInvoiceDataSet)

    End Sub

    Private Sub FillToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillToolStripButton.Click
        Try
            Me.CustomersTableAdapter.Fill(Me.PayInvoiceDataSet.Customers, CustomerToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class