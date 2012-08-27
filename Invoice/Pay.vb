Imports System.Data.DataTable
Imports System.Data.DataSet
Imports System.Data.DataView
Imports System.Data

Public Class Pay
    Dim DGV As System.Windows.Forms.DataGridView
    ' Dim Recno As Integer
    '  Dim mMonth As String
    Dim TxtBoxData As String
    '  Dim newMonth As String
    Dim inc As Integer
    Dim invNum As Integer
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds1 As New DataSet
    Dim ds2 As New DataSet
    Dim ds3 As New DataSet
    Dim da1 As OleDb.OleDbDataAdapter
    Dim da2 As OleDb.OleDbDataAdapter
    Dim da3 As OleDb.OleDbDataAdapter
    Dim sql1 As String
    Dim sql2 As String
    Dim sql3 As String
    Dim MaxRows As Integer
    Dim pDate As Date
    Dim iamt As Decimal = 0.0
    Dim ipay1 As Decimal = 0.0
    Dim ipay2 As Decimal = 0.0
    Dim ibal As Decimal = 0.0
    Dim sbal As Decimal = 0.0
    Dim ioc As Decimal = 0.0
    Dim tpay1 As Decimal = 0.0
    Dim tpay2 As Decimal = 0.0

    Private Sub InvoicesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.InvoicesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PayInvoiceDataSet)

    End Sub

    'Private Sub FillToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillToolStripButton.Click
    '   If CustomerToolStripTextBox.Text = "" Then
    '      MsgBox("Customer Number not entered... Please try again")
    '      CustomerToolStripTextBox.Text = ""
    '      Return
    '   End If

    '    Try

    '  .Rows
    '        Me.InvoicesTableAdapter.Fill(Me.PayInvoiceDataSet.Invoices, CustomerToolStripTextBox.Text)
    '       Me.CreditTextBox.Text = ds3.Tables("Invoices").Rows(inc).Item("Credit")
    '        Me.txtAcctBal.Text = PayInvoiceDataSet.Invoices.Compute("sum(BalDue)", String.Empty)

    '   Catch ex As System.Exception
    '' System.Windows.Forms.MessageBox.Show(ex.Message)
    '        MsgBox("Customer Number not Found... Please try again")
    '        CustomerToolStripTextBox.Text = ""
    '        Return
    '    End Try

    '  End Sub

    Private Sub PayInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' Me.PaymentsTableAdapter.Fill(Me.PayInvoiceDataSet.Payments)
        ' Me.CustomersTableAdapter.Fill(Me.PayInvoiceDataSet.Customers)
        ' CreditTextBox.Text = 0.0
    End Sub

    Public Sub CreditTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles CreditTextBox.TextChanged
        'CreditTextBox.Text = ds3.Tables("Invoices").Rows(inc).Item("Credit")
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
        ProcessPayment()
        ' AmtPaidTextBox.Text = FormatNumber(ipay, 2)
        '  CreditTextBox.Text = FormatNumber(ioc, 2)
        ' txtPayment.Text = FormatNumber(tpay, 2)
        ' BalDueTextBox.Text = FormatNumber(ibal, 2)

        ' Me.Validate()
        ' Me.InvoicesBindingSource.EndEdit()
        ' Me.TableAdapterManager.UpdateAll(Me.PayInvoiceDataSet)

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Public Sub txtPayment_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPay1.TextChanged
        ' CreditTextBox.Text = ds3.Tables("Invoices").Rows(inc).Item("Credit")
        '  CreditTextBox.Text = PayInvoiceDataSet.Invoices("Credit")
        ' CreditTextBox.Text = ds3.Tables("Invoices").Rows(inc).Item("Credit")
        'inc = ds3.Tables("Invoices").Rows().ToString
        iamt = 0.0
        ipay1 = Val(AmtPaidTextBox.Text)
        ipay2 = 0.0
        ibal = 0.0
        ioc = 0.0
        tpay1 = 0.0
        tpay2 = 0.0
        sbal = 0.0
        pDate = DatePaidDateTimePicker.Text
        ' Me.txtAcctBal.Text = PayInvoiceDataSet.Invoices.Compute("sum(BalDue)", String.Empty)
        Me.txtAcctBal.Text = PayInvoiceDataSet.Invoices.Compute("sum(BalDue)", String.Empty)
        ' iamt = CDec(InvAmtTextBox.Text)
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

    Public Sub ProcessPayment()
        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        ' dbSource = "Data Source = |DataDirectory|\Invoice.mdb"
        dbSource = "Data Source = C:\Databases\Invoices\Invoices.mdb"
        con.ConnectionString = dbProvider & dbSource
        sql1 = "Select * from Customers"
        sql2 = "Select * from Payments"
        sql3 = "Select * from Invoices"
        con.Open()
        MsgBox("Database is open")
        da1 = New OleDb.OleDbDataAdapter(sql1, con)
        da2 = New OleDb.OleDbDataAdapter(sql2, con)
        da3 = New OleDb.OleDbDataAdapter(sql3, con)
        da1.Fill(ds1, "Customers")
        da2.Fill(ds2, "Payments")
        da3.Fill(ds3, "Invoices")
        MaxRows = ds3.Tables("Invoices").Rows.Count
        ' inc = -1
        MsgBox("Processing Statements")
        ' Dim cb As New OleDb.OleDbCommandBuilder(da1)

        Call AddUpdatePayment()
        Call UpdateDatabase()
    End Sub

    Public Sub AddUpdatePayment()
        ' TxtBoxData = Trim(txtInvMonth.Text)
        Dim cb1 As New OleDb.OleDbCommandBuilder(da1)
        Dim cb2 As New OleDb.OleDbCommandBuilder(da2)
        Dim cb3 As New OleDb.OleDbCommandBuilder(da3)
        ' inc = CType(DGV.DataSource, DataTable).Rows.IndexOf(CType(DGV.CurrentRow.DataBoundItem, DataRowView).Row)
        Dim dsNewRow As DataRow
        ' Dim nmonthTmp As String
        ' Dim serviceTmp As String
        ' If inc <> 0 Then
        ' invNum = CInt(txtInvNum.Text)
        ' inc = 0
        ' NavigateRecords()
        ' End If
        ' ds.Tables("Master").Rows(inc).Item("nMnth") = txtInvMonth.Text
        ' ds.Tables("Master").Rows(inc).Item("Invoice") = invNum
        ' ds.Tables("Master").Rows(inc).Item("InvDate") = txtInvDate.Text
        Try
            '  Do Until inc = MaxRows

            ds1.Tables("Customers").Rows(inc).Item("LastPaymentDate") = pDate
            ds1.Tables("Customers").Rows(inc).Item("LastPayment") = tpay1
            ds1.Tables("Customers").Rows(inc).Item("Balance") = -tpay1
            ds1.Tables("Customers").Rows(inc).Item("Credit") = ioc

            dsNewRow = ds2.Tables("Payments").NewRow()
            dsNewRow("Invoice") = ds3.Tables("Invoices").Rows(inc).Item("Invoice")
            dsNewRow("invDate") = ds3.Tables("Invoices").Rows(inc).Item("invdate")
            dsNewRow("Customer") = ds3.Tables("Invoices").Rows(inc).Item("Customer")
            ' dsNewRow("InvAmt") = ds3.Tables("Invoices").Rows(inc).Item("InvAmt")
            dsNewRow("BalDue") = ds3.Tables("Payments").Rows(inc).Item("BalDue")
            dsNewRow("Service") = ds3.Tables("Invoices").Rows(inc).Item("Service").ToString
            dsNewRow("AmtPaid") = tpay1
            dsNewRow("DatePaid") = pDate
            dsNewRow("Ref") = ds3.Tables("Invoices").Rows(inc).Item("Ref")
            dsNewRow("ItemCode") = ds3.Tables("Invoices").Rows(inc).Item("ItemCode")
            ds2.Tables("Payments").Rows.Add(dsNewRow)
            da2.InsertCommand = cb2.GetInsertCommand()
            ' inc = inc + 1
            'invNum = invNum + 1
            ' da3.Update(ds3, "invoices")
            ' Loop
        Catch ex As Exception
            MsgBox("What Happened?? err in AddUpdatePayment, e: " + ex.Message)
        End Try
    End Sub

    Public Sub UpdateDatabase()
        Dim cb1 As New OleDb.OleDbCommandBuilder(da1)
        Dim cb2 As New OleDb.OleDbCommandBuilder(da2)
        Dim cb3 As New OleDb.OleDbCommandBuilder(da3)

        '  da1.Update(ds1, "Customers")
        ' MsgBox("Customers Updated")
        da2.InsertCommand = cb2.GetInsertCommand()
        da2.Update(ds2, "Payments")
        MsgBox("Payments Updated")
        da3.Update(ds3, "Invoices")
        MsgBox("Invoices Updated")
        con.Close()
        MsgBox("Databases Closed")


        AmtPaidTextBox.Text = 0.0  ' Amount from Invoice Table:AmtPaid
        txtPay1.Text = 0.0
        RefTextBox.Text = ""

        ' ipay1 = Val(AmtPaidTextBox.Text) ' Amount from Invoice Table:AmtPaid
        '  txtInvMonth.Text = ""
        ' txtInvDate.Text = ""
        ' txtInvNum.Text = ""
    End Sub


    Private Sub InvoicesBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs) Handles InvoicesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InvoicesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PayInvoiceDataSet)

    End Sub

    Private Sub FillToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillToolStripButton.Click
        Try
            Me.InvoicesTableAdapter.Fill(Me.PayInvoiceDataSet.Invoices, CustomerToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
