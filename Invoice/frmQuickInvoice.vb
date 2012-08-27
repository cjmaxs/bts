Public Class frmQuickInvoice

    Private Sub InvoicesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles InvoicesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InvoicesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QuickInvoiceDataSet)

    End Sub

    Private Sub frmQuickInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuickInvoiceDataSet.Invoices' table. You can move, or remove it, as needed.
        Me.InvoicesTableAdapter.Fill(Me.QuickInvoiceDataSet.Invoices)
    End Sub
End Class