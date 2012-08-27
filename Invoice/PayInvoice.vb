Imports System.Data.DataView
Imports System.Data

Public Class PayInvoice

    Dim iamt As Decimal = 0.0
    Dim ipay1 As Decimal = 0.0
    Dim ipay2 As Decimal = 0.0
    Dim ibal As Decimal = 0.0
    Dim sbal As Decimal = 0.0
    Dim ioc As Decimal = 0.0
    Dim tpay1 As Decimal = 0.0
    Dim tpay2 As Decimal = 0.0

    Private Sub InvoicesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles InvoicesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InvoicesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PayInvoiceDataSet)

    End Sub

    Private Sub FillToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillToolStripButton.Click
        If CustomerToolStripTextBox.Text = "" Then
            MsgBox("Customer Number not entered... Please try again")
            CustomerToolStripTextBox.Text = ""
            Return
        End If

        Try
            Me.InvoicesTableAdapter.Fill(Me.PayInvoiceDataSet.Invoices, CustomerToolStripTextBox.Text)
            Me.txtAcctBal.Text = PayInvoiceDataSet.Invoices.Compute("sum(BalDue)", String.Empty)
            
        Catch ex As System.Exception
            ' System.Windows.Forms.MessageBox.Show(ex.Message)
            MsgBox("Customer Number not Found... Please try again")
            CustomerToolStripTextBox.Text = ""
            Return
        End Try

    End Sub

    Private Sub PayInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Me.PaymentsTableAdapter.Fill(Me.PayInvoiceDataSet.Payments)
        ' Me.CustomersTableAdapter.Fill(Me.PayInvoiceDataSet.Customers)
        'CreditTextBox.Text = 0.0
    End Sub

    Public Sub CreditTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles CreditTextBox.TextChanged
        Dim ioc As Decimal = Val(CreditTextBox.Text)
        If ioc >= 0.01 Then
            lblCredit.Visible = False
            btnApplyCredit.Visible = True
        Else
            btnApplyCredit.Visible = False
            lblCredit.Visible = True
        End If
    End Sub

    Private Sub btnSavePayment_Click(sender As System.Object, e As System.EventArgs) Handles btnSavePayment.Click

        ' AmtPaidTextBox.Text = FormatNumber(ipay, 2)
        '  CreditTextBox.Text = FormatNumber(ioc, 2)
        ' txtPayment.Text = FormatNumber(tpay, 2)
        ' BalDueTextBox.Text = FormatNumber(ibal, 2)

        Me.Validate()
        Me.InvoicesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PayInvoiceDataSet)

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Public Sub txtPayment_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPay1.TextChanged
        iamt = 0.0
        ipay1 = Val(AmtPaidTextBox.Text)
        ipay2 = 0.0
        ibal = 0.0
        ioc = 0.0
        tpay1 = 0.0
        tpay2 = 0.0
        sbal = 0.0
        ' Me.txtAcctBal.Text = PayInvoiceDataSet.Invoices.Compute("sum(BalDue)", String.Empty)
        Me.txtAcctBal.Text = PayInvoiceDataSet.Invoices.Compute("sum(BalDue)", String.Empty)
        iamt = CDec(InvAmtTextBox.Text)
        ' ipay1 = CDbl(AmtPaidTextBox.Text) ' Amount from Invoice Table:AmtPaid
        ' ipay2 = CDec(TxtPay.Text)
        ' ipay1 = Val(AmtPaidTextBox.Text) ' Amount from Invoice Table:AmtPaid
        tpay2 = Val(TxtPay2.Text)
        ibal = Val(BalDueTextBox.Text)
        ioc = Val(CreditTextBox.Text)
        tpay1 = Val(txtPay1.Text)

        'FormatNumber(sbal, 2) = (ibal - tpay1)
        sbal = (ibal - tpay1)

        If sbal > 0.01 Then
            ipay2 = 0.0
            ibal = 0.0
            tpay2 = FormatNumber(tpay1, 2)
            ibal = sbal
            Me.TxtPay2.Text = FormatNumber(tpay2, 2)
            ' Me.BalDueTextBox.Text = FormatNumber(ibal, 2)
        End If

        If sbal < 0.0 Then
            ioc = 0.0
            ibal = 0.0

            ibal = sbal
            ioc = tpay1 - sbal
            ' Me.BalDueTextBox.Text = FormatNumber(ibal, 2)
            ' Me.AmtPaidTextBox.Text = FormatNumber(tpay, 2)
            Me.CreditTextBox.Text = FormatNumber(ioc, 2)
            ' ibal = 0.0
        End If
        If sbal = 0.0 Then

            Me.tpay2 = FormatNumber(tpay1, 2)
            '  Me.BalDueTextBox.Text = FormatNumber(ibal, 2)
        End If

    End Sub
    

End Class
