Imports System.Data
Public Class frmPayments
    Dim inc As Integer
    Dim MaxRows As Integer
    Dim Con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim idate As Date
    Dim iRef As String
    Dim iPay As Decimal = 0.0
    Dim iBal As Decimal
    Dim iAmtPaid As Decimal
    Dim cAmtPaid As Decimal
    Dim AmtApply As Decimal = 0.0
    Dim iBalance As Decimal
    Dim pinvoice As String
    Dim pdatepaid As Date
    Dim pinvdate As Date
    Dim pservice As String
    Dim pref As String
    Dim pitemcode As String
    Dim pcustno As String
    Dim pcredit As Decimal
    Dim ioc As Decimal
    Dim creditpay As Decimal
    Dim extrapay As Decimal
    Dim ds1 As New DataSet
    Dim ds2 As New DataSet
    Dim ds3 As New DataSet
    Dim da1 As OleDb.OleDbDataAdapter
    Dim da2 As OleDb.OleDbDataAdapter
    Dim da3 As OleDb.OleDbDataAdapter
    Dim Sql1 As String
    Dim sql2 As String
    Dim sql3 As String
    Dim item As String

    Private Sub frmPayments_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Me.CustomersTableAdapter.Fill(Me.PayInvoiceDataSet.Customers)
        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source = C:\databases\Invoices\Invoices.mdb"
        Con.ConnectionString = dbProvider & dbSource
        ' Con.Open()
        ' sql3 = "SELECT * FROM Invoices WHERE (Customer = ?) AND (BalDue <> 0.00) ORDER BY Customer, Invoice"
        sql3 = "SELECT * FROM Invoices WHERE BalDue > 0.00 ORDER BY Customer, InvDate, Invoice"
        Sql1 = "SELECT * FROM Customers"
        sql2 = "SELECT * FROM Payments"
        ' sql3 = "SELECT * FROM Invoices"
    End Sub

    Private Sub NavigateRecords()
        ' txtCustno.Text = CStr(dset.Tables("Invoices").Rows(inc).Item("Customer"))
        ' txtInvoice.Text = CStr(dset.Tables("Invoices").Rows(inc).Item("Invoice"))
        ' TxtService.Text = CStr(dset.Tables("Invoices").Rows(inc).Item("Service"))
    End Sub

    Public Sub txtCustomer_TextChanged(sender As System.Object, e As System.EventArgs)
        ' Dim custno As String
        ' custno = txtCustomer.Text
    End Sub

    Private Sub InvoicesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles InvoicesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InvoicesBindingSource.EndEdit()
        Me.CustomersBindingSource.EndEdit()
        Dim deleteOrders As PayInvoiceDataSet.InvoicesDataTable = CType(PayInvoiceDataSet.Invoices.GetChanges(Data.DataRowState.Deleted), PayInvoiceDataSet.InvoicesDataTable)
        Dim newOrders As PayInvoiceDataSet.InvoicesDataTable = CType(PayInvoiceDataSet.Invoices.GetChanges(Data.DataRowState.Added), PayInvoiceDataSet.InvoicesDataTable)
        Dim modifiedOrders As PayInvoiceDataSet.InvoicesDataTable = CType(PayInvoiceDataSet.Invoices.GetChanges(Data.DataRowState.Modified), PayInvoiceDataSet.InvoicesDataTable)
        Try
            If Not deleteOrders Is Nothing Then
                InvoicesTableAdapter.Update(deleteOrders)
            End If
            CustomersTableAdapter.Update(PayInvoiceDataSet.Customers)
            If Not newOrders Is Nothing Then
                InvoicesTableAdapter.Update(newOrders)
            End If
            If Not modifiedOrders Is Nothing Then
                InvoicesTableAdapter.Update(modifiedOrders)
            End If
            PayInvoiceDataSet.AcceptChanges()
        Catch ex As Exception
            MsgBox("Update/Save Failed...")
        Finally
            If Not deleteOrders Is Nothing Then
                deleteOrders.Dispose()
            End If
            If Not newOrders Is Nothing Then
                newOrders.Dispose()
            End If
            If Not modifiedOrders Is Nothing Then
                modifiedOrders.Dispose()
            End If
            MsgBox("Record Updated/Saved...")
        End Try
    End Sub

    Private Sub FillToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillToolStripButton.Click
        If CustomerToolStripTextBox.Text = "" Then
            MsgBox("Customer Number not entered... Please try again")
            CustomerToolStripTextBox.Text = ""
            Return
        End If
        Try
            Me.InvoicesTableAdapter.Fill(Me.PayInvoiceDataSet.Invoices, CustomerToolStripTextBox.Text)
            Me.CustomersTableAdapter.Fill(Me.PayInvoiceDataSet.Customers, CustomerToolStripTextBox.Text)
            iRef = RefTextBox.Text
            item = ItemCodeTextBox.Text
            'idate = DatePaidTextBox.Text
            ' iPay = txtPayment.Text
            iAmtPaid = AmtPaidTextBox.Text
            pcustno = CustomerTextBox.Text
            pinvoice = InvoiceTextBox.Text
            pitemcode = ItemCodeTextBox.Text
            pservice = ServiceTextBox.Text
            pdatepaid = InvDateTextBox.Text
            pref = RefTextBox.Text
            iBal = BalDueTextBox.Text
            iAmtPaid = iAmtPaid + iPay


            CustomerToolStripTextBox.Text = ""
        Catch ex As System.Exception
            ' System.Windows.Forms.MessageBox.Show(ex.Message)
            MsgBox("Customer Number not Found... Please try again")
            CustomerToolStripTextBox.Text = ""
            Return
        End Try
        ChangeCustomer()
    End Sub

    Public Sub btnApplyPayment_Click(sender As System.Object, e As System.EventArgs) Handles btnApplyPayment.Click
        ' iRef = RefTextBox.Text
        ' item = ItemCodeTextBox.Text
        ' idate = DatePaidTextBox.Text
        ' iPay = txtPayment.Text
        ' iAmtPaid = AmtPaidTextBox.Text
        ' pcustno = CustomerTextBox.Text
        ' pinvoice = InvoiceTextBox.Text
        ' pitemcode = ItemCodeTextBox.Text
        ' pservice = ServiceTextBox.Text
        ' pdatepaid = InvDateTextBox.Text
        ' pref = RefTextBox.Text
        ' iBal = BalDueTextBox.Text
        ' iAmtPaid = iAmtPaid + iPay


        If iPay > iBal Then
            AmtApply = iBal
            AmtApplyTextBox.Text = AmtApply
            iBal = iBal - AmtApply
        Else
            AmtApply = iPay
            AmtApplyTextBox.Text = AmtApply
            iBal = iBal - iPay
        End If
        ' AmtApplyTextBox.Text = AmtApply

        ' iBal = FormatNumber(BalDueTextBox.Text, 2)

        BalDueTextBox.Text = (BalDueTextBox.Text - txtPayment.Text)
        iBal = FormatNumber(BalDueTextBox.Text, 2)

        ' iAmtPaid = AmtPaidTextBox.Text + txtPayment.Text
        AmtPaidTextBox.Text = iAmtPaid + iPay
        ioc = FormatNumber(CreditTextBox.Text, 2)
        LastPaymentDateTextBox.Text = idate
        LastPaymentTextBox.Text = FormatNumber(iPay, 2)
        ' iBalance = Val(BalanceTextBox.Text)
        ' iBalance = FormatNumber(iBalance, 2) - FormatNumber(iPay, 2)
        ' BalanceTextBox.Text = FormatNumber(iBalance, 2)
        ' If iPay > iBal Then
        'ioc = ioc + (iPay - iBal)
        'CreditTextBox.Text = FormatNumber(ioc, 2)
        'End If
        'If iPay > iBal Then
        'AmtApply = iBal
        'Else
        'AmtApply = iPay
        'End If
        'AmtApplyTextBox.Text = AmtApply


        Dim button As DialogResult =
        MessageBox.Show("Save this payment?", "Payment", MessageBoxButtons.YesNo)
    End Sub
    Private Sub Post()
        Me.Validate()
        Me.InvoicesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PayInvoiceDataSet)
        AddPay()
        UpdateCustomer()
        UpdateDatabase()

        ' While CustomerToolStripTextBox.Text = pcustno
    End Sub

    Public Sub AddPay()
        Con.Open()
        'pinvdate = Date
        ' da1 = New OleDb.OleDbDataAdapter(Sql1, Con)
        da2 = New OleDb.OleDbDataAdapter(sql2, Con)
        da3 = New OleDb.OleDbDataAdapter(sql3, Con)
        ' da1.Fill(ds1, "Customers")
        da2.Fill(ds2, "Payments")
        da3.Fill(ds3, "Invoices")
        MaxRows = ds3.Tables("Invoices").Rows.Count
        ' inc = -1       
        ' MsgBox("Database is now open")
        'Dim cb1 As New OleDb.OleDbCommandBuilder(da1)
        Dim cb2 As New OleDb.OleDbCommandBuilder(da2)
        Dim dsNewRow As DataRow
        dsNewRow = ds2.Tables("Payments").NewRow()
        dsNewRow("Invoice") = pinvoice
        dsNewRow("invDate") = pdatepaid
        dsNewRow("Customer") = pcustno
        dsNewRow("Service") = pservice
        dsNewRow("AmtPaid") = FormatNumber(iPay, 2)
        dsNewRow("DatePaid") = idate
        dsNewRow("Ref") = iRef
        dsNewRow("ItemCode") = pitemcode
        ds2.Tables("Payments").Rows.Add(dsNewRow)
        da2.InsertCommand = cb2.GetInsertCommand()
    End Sub

    Public Sub UpdateCustomer()
        ioc = FormatNumber(CreditTextBox.Text, 2)
        LastPaymentDateTextBox.Text = idate
        LastPaymentTextBox.Text = FormatNumber(iPay, 2)
        iBalance = FormatNumber(iBalance, 2) - FormatNumber(iPay, 2)
        BalanceTextBox.Text = FormatNumber(iBalance, 2)
        ' BalanceTextBox.Text = iBalance
        ' If iPay > iBal Then
        ' ioc = +(iPay - iBal)
        ' CreditTextBox.Text = FormatNumber(ioc, 2)
        ' End If
        ' Me.Validate()
        ' Me.CustomersBindingSource.EndEdit()
        ' Me.TableAdapterManager.UpdateAll(Me.PayInvoiceDataSet)
    End Sub

    Private Sub btnX_Click(sender As System.Object, e As System.EventArgs) Handles btnX.Click
        Con.Close()
        Me.Close()
    End Sub

    Public Sub UpdateDatabase()
        Me.Validate()
        Me.InvoicesBindingSource.EndEdit()
        Me.CustomersBindingSource.EndEdit()
        Dim deleteOrders As PayInvoiceDataSet.InvoicesDataTable = CType(PayInvoiceDataSet.Invoices.GetChanges(Data.DataRowState.Deleted), PayInvoiceDataSet.InvoicesDataTable)
        Dim newOrders As PayInvoiceDataSet.InvoicesDataTable = CType(PayInvoiceDataSet.Invoices.GetChanges(Data.DataRowState.Added), PayInvoiceDataSet.InvoicesDataTable)
        Dim modifiedOrders As PayInvoiceDataSet.InvoicesDataTable = CType(PayInvoiceDataSet.Invoices.GetChanges(Data.DataRowState.Modified), PayInvoiceDataSet.InvoicesDataTable)
        Try
            If Not deleteOrders Is Nothing Then
                InvoicesTableAdapter.Update(deleteOrders)
            End If
            CustomersTableAdapter.Update(PayInvoiceDataSet.Customers)
            If Not newOrders Is Nothing Then
                InvoicesTableAdapter.Update(newOrders)
            End If
            If Not modifiedOrders Is Nothing Then
                InvoicesTableAdapter.Update(modifiedOrders)
            End If
            PayInvoiceDataSet.AcceptChanges()
        Catch ex As Exception
            MsgBox("Update/Save Failed...")
        Finally
            If Not deleteOrders Is Nothing Then
                deleteOrders.Dispose()
            End If
            If Not newOrders Is Nothing Then
                newOrders.Dispose()
            End If
            If Not modifiedOrders Is Nothing Then
                modifiedOrders.Dispose()
            End If
            MsgBox("Record Updated/Saved...")
        End Try
        'Dim cb1 As New OleDb.OleDbCommandBuilder(da1)
        Dim cb2 As New OleDb.OleDbCommandBuilder(da2)
        'da1.Update(ds1, "Customers")
        da2.InsertCommand = cb2.GetInsertCommand()
        da2.Update(ds2, "Payments")
        ' MsgBox("Database Updated")
        Con.Close()
        MsgBox("Database is Closed")
    End Sub

    Public Sub btnPay_Click(sender As System.Object, e As System.EventArgs) Handles btnPay.Click
        iRef = RefTextBox.Text
        item = ItemCodeTextBox.Text
        idate = DatePaidTextBox.Text
        iPay = txtPayment.Text
        iAmtPaid = FormatNumber(iPay)
        ' iAmtPaid = FormatNumber(iPay, 2)
        pcustno = CustomerTextBox.Text
        pinvoice = InvoiceTextBox.Text
        pitemcode = ItemCodeTextBox.Text
        pservice = ServiceTextBox.Text
        pdatepaid = InvDateTextBox.Text
        pref = RefTextBox.Text
        ioc = CreditTextBox.Text
        ' pcredit = CreditTextBox.Text
        BalDueTextBox.Text = (BalDueTextBox.Text - txtPayment.Text)
        iBal = BalDueTextBox.Text
        iAmtPaid = FormatNumber(AmtPaidTextBox.Text, 2) + FormatNumber(txtPayment.Text, 2)
        AmtPaidTextBox.Text = FormatNumber(AmtPaidTextBox.Text, 2) + FormatNumber(iPay, 2)
        ' ioc = FormatNumber(CreditTextBox.Text)
        LastPaymentDateTextBox.Text = idate
        LastPaymentTextBox.Text = FormatNumber(iPay, 2)
        ' iBalance = Val(BalanceTextBox.Text)
        iBalance = FormatNumber(iBalance, 2) - FormatNumber(iPay, 2)
        BalanceTextBox.Text = FormatNumber(iBalance, 2)
        If iPay > iBal Then
            ioc = ioc + (iPay - iBal)
            CreditTextBox.Text = FormatNumber(ioc, 2)
        End If
        Me.CustomersTableAdapter.Fill(Me.PayInvoiceDataSet.Customers, CustomerToolStripTextBox.Text)
        ioc = FormatNumber(CreditTextBox.Text, 2)
        ' ioc = Val(CreditTextBox.Text)
        LastPaymentDateTextBox.Text = idate
        LastPaymentTextBox.Text = FormatNumber(iPay, 2)
        ' iBalance = Val(BalanceTextBox.Text)
        iBalance = (FormatNumber(iBalance, 2) - FormatNumber(iPay, 2))
        BalanceTextBox.Text = FormatNumber(iBalance, 2)
        ' BalanceTextBox.Text = iBalance
        If iPay > iBal Then
            ioc = ioc + (iPay - iBal)
        End If
        CreditTextBox.Text = FormatNumber(ioc, 2)
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.InvoicesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PayInvoiceDataSet)
        AddPay()
        UpdateCustomer1()
        UpdateDatabase()
    End Sub

    Public Sub UpdateCustomer1()
        Me.CustomersTableAdapter.Fill(Me.PayInvoiceDataSet.Customers, CustomerToolStripTextBox.Text)
        ioc = FormatNumber(CreditTextBox.Text)
        ' ioc = Val(CreditTextBox.Text)
        LastPaymentDateTextBox.Text = idate
        LastPaymentTextBox.Text = FormatNumber(iPay, 2)
        ' iBalance = Val(BalanceTextBox.Text)
        iBalance = (FormatNumber(iBalance, 2) - FormatNumber(iPay, 2))
        BalanceTextBox.Text = FormatNumber(iBalance, 2)
        ' BalanceTextBox.Text = iBalance
        If iPay > iBal Then
            ioc = ioc + (iPay - iBal)
        End If
        CreditTextBox.Text = FormatNumber(ioc, 2)
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PayInvoiceDataSet)
    End Sub

    Public Sub ChangeCustomer()
        '   Dim ioc As Decimal
        ioc = FormatNumber(CreditTextBox.Text, 2)
        If ioc >= 0.01 Then
            btnApplyCr.Visible = True
        Else
            btnApplyCr.Visible = False
        End If
    End Sub

    Private Sub btnApplyCr_Click(sender As System.Object, e As System.EventArgs) Handles btnApplyCr.Click
        iRef = RefTextBox.Text
        item = ItemCodeTextBox.Text
        idate = DatePaidTextBox.Text
        iPay = 0.0
        iAmtPaid = AmtPaidTextBox.Text
        pcustno = CustomerTextBox.Text
        pinvoice = InvoiceTextBox.Text
        pitemcode = ItemCodeTextBox.Text
        pservice = ServiceTextBox.Text
        pdatepaid = InvDateTextBox.Text
        pref = RefTextBox.Text
        ioc = CreditTextBox.Text

        iBal = BalDueTextBox.Text


        If ioc < iBal Then
            iPay = ioc
            iBal = iBal - ioc
            ioc = 0.0
        End If
        If ioc > iBal Then
            iPay = iBal
            ioc = ioc - iBal
            iBal = 0.0
        End If

        txtPayment.Text = iPay
        CreditTextBox.Text = FormatNumber(ioc, 2)
        LastPaymentDateTextBox.Text = idate
        LastPaymentTextBox.Text = FormatNumber(iPay, 2)
        iBalance = (FormatNumber(iBalance, 2) - FormatNumber(iPay, 2))
        BalanceTextBox.Text = FormatNumber(iBalance, 2)
        BalDueTextBox.Text = (BalDueTextBox.Text - txtPayment.Text)
        ' iAmtPaid = FormatNumber(AmtPaidTextBox.Text, 2) + FormatNumber(txtPayment.Text, 2)
        ' AmtPaidTextBox.Text = FormatNumber(AmtPaidTextBox.Text, 2) + FormatNumber(iPay, 2)
        AmtPaidTextBox.Text = iAmtPaid + iPay
        LastPaymentDateTextBox.Text = idate
        LastPaymentTextBox.Text = FormatNumber(iPay, 2)
        iBalance = FormatNumber(iBalance, 2) - FormatNumber(iPay, 2)
        BalanceTextBox.Text = FormatNumber(iBalance, 2)

    End Sub


    Private Sub payme()
        Me.CustomersTableAdapter.Fill(Me.PayInvoiceDataSet.Customers, CustomerToolStripTextBox.Text)
        ioc = FormatNumber(CreditTextBox.Text, 2)
        ' ioc = Val(CreditTextBox.Text)

        If iPay > iBal Then
            ioc = ioc + (iPay - iBal)
        End If
        CreditTextBox.Text = FormatNumber(ioc, 2)
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.InvoicesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PayInvoiceDataSet)
        AddPay()
        UpdateCustomer1()
        UpdateDatabase()

        txtPayment.Text = iPay
        BalDueTextBox.Text = iBal
        CreditTextBox.Text = FormatNumber(ioc, 2)
    End Sub

    Private Sub txtPayment_ModifiedChanged(sender As Object, e As System.EventArgs) Handles txtPayment.ModifiedChanged
        If iPay > iBal Then
            AmtApply = iBal
            AmtApplyTextBox.Text = AmtApply
            iBal = iBal - AmtApply
        Else
            AmtApply = iPay
            AmtApplyTextBox.Text = AmtApply
            iBal = iBal - iPay
        End If
    End Sub

    

    ' Public Sub txtPayment_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPayment.TextChanged
    '     If iPay > iBal Then
    '       AmtApply = iBal
    '    Else
    '        AmtApply = iPay
    '    End If
    '    AmtApplyTextBox.Text = AmtApply
    ' End Sub

    Private Sub txtPayment_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPayment.TextChanged
        If iPay > iBal Then
            AmtApply = iBal
            AmtApplyTextBox.Text = AmtApply
            iBal = iBal - AmtApply
        Else
            AmtApply = iPay
            AmtApplyTextBox.Text = AmtApply
            iBal = iBal - iPay
        End If
    End Sub

End Class