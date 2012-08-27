Public Class frmPayInvoice
    Dim iPayment As Integer
    Dim iCredit As Integer
    Dim iDatePaid As String
    Dim iRef As String

    Private Sub InvoicesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.InvoicesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PayInvoiceDataSet)

    End Sub

    Private Sub FillToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.InvoicesTableAdapter.Fill(Me.PayInvoiceDataSet.Invoices, CustomerToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub InvoicesBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs) Handles InvoicesBindingNavigatorSaveItem.Click
        '  iPayment = CInt(txtPayment.Text)
        ' iCredit = CInt(txtOpenCredit.Text)
        ' iDatePaid = DatePaidTextBox.Text
        ' iRef = RefTextBox.Text



        Me.Validate()
        Me.InvoicesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PayInvoiceDataSet)

    End Sub

    Private Sub FillToolStripButton_Click_1(sender As System.Object, e As System.EventArgs) Handles FillToolStripButton.Click
        Try
            Me.InvoicesTableAdapter.Fill(Me.PayInvoiceDataSet.Invoices, CustomerToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmPayInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PayInvoiceDataSet.Customers' table. You can move, or remove it, as needed.
        ' Me.CustomersTableAdapter.Fill(Me.PayInvoiceDataSet.Customers)

    End Sub

    Private Sub txtPayment_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPayment.TextChanged

    End Sub

    Private Sub btnPay_Click(sender As System.Object, e As System.EventArgs) Handles btnPay.Click
        ProcessPayment()
    End Sub

    Public Sub processPayment()

    End Sub


End Class