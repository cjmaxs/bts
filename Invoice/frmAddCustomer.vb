Public Class frmAddCustomer
    Dim mMonth As String
    Dim TxtBoxData As String
    Dim newMonth As String
    Dim inc As Integer
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim ds2 As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim da2 As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim sql2 As String
    Dim MaxRows As Integer

    Private Sub frmAddCustomer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source = C:\Databases\Invoices\Invoices.mdb"
        con.ConnectionString = dbProvider & dbSource
        ' sql = "Select * from Customers"
        sql2 = "Select * from Master"
        con.Open()
        da2 = New OleDb.OleDbDataAdapter(sql2, con)
        ' da.Fill(ds, "Customers")
        da2.Fill(ds2, "Master")
        ' da.Update(ds, "Master")
        con.Close()
    End Sub

    Private Sub Addrec()
        ' If inc <> -1 Then
        Dim cb As New OleDb.OleDbCommandBuilder(da2)
        Dim dsNewRow As DataRow
        dsNewRow = ds2.Tables("Master").NewRow()
        dsNewRow.Item("Customer") = CustomerTextBox.Text
        dsNewRow.Item("Company") = CompanyTextBox.Text
        dsNewRow.Item("Address") = AddressTextBox.Text
        dsNewRow.Item("Suite/Apt") = Suite_AptTextBox.Text
        ds2.Tables("Master").Rows.Add(dsNewRow)
        ' da.Update(ds, "Customers")
        da2.Update(ds2, "Master")
        MsgBox("New Record added to the Database")
        ' btnCommit.Enabled = False
        ' btnAddNew.Enabled = True
        ' btnUpdate.Enabled = True
        ' btnDelete.Enabled = True
        ' End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        ' If txtCustomer.Text = "" Then
        ' LblCustomer.Show()
        ' Else
        ' LblCustomer.Hide()
        ' End If
        ' If txtCustomer.Text = "" Then
        ' Return
        ' End If
        ' Call Addrec()
    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da2)
        Dim dsNewRow As DataRow

        dsNewRow = ds2.Tables("Master").NewRow()
        dsNewRow.Item("Customer") = CustomerTextBox.Text
        dsNewRow.Item("Company") = CompanyTextBox.Text
        ' dsNewRow.Item("BalDue") = BalanceTextBox.Text
        ' dsNewRow.Item("Balance") = BalanceTextBox.Text
        dsNewRow.Item("ItemCode") = ItemCodeTextBox.Text
        dsNewRow.Item("Service") = ServiceTextBox.Text
        ' dsNewRow.Item("InvAmt") = MonthlyChargeTextBox.Text
        ' dsNewRow.Item("MonthlyCharge") = MonthlyChargeTextBox.Text

        ds2.Tables("Master").Rows.Add(dsNewRow)

        ' da.Update(ds, "Customers")
        da2.Update(ds2, "Master")
        MsgBox("Record Added/Updated")

        ' btnCommit.Enabled = False
        ' btnAddNew.Enabled = True
        ' btnUpdate.Enabled = True
        ' btnDelete.Enabled = True

        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustomerDataSet)

    End Sub

    Private Sub FillToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillToolStripButton.Click
        Try
            Me.CustomersTableAdapter.Fill(Me.CustomerDataSet.Customers, CustomerToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        CustomerToolStripTextBox.Text = ""

    End Sub

End Class