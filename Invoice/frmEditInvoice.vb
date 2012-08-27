Public Class frmEditInvoice

    Private Sub MasterBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles MasterBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MasterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AddInvoicesDataSet)

    End Sub

    Private Sub FillToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillToolStripButton.Click
        Try
            Me.MasterTableAdapter.Fill(Me.AddInvoicesDataSet.Master, CustomerToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class