Public Class frmAddInvoice
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

    ' Private Sub FillToolStripButton_Click(sender As System.Object, e As System.EventArgs)
    '    Try
    '        Me.MasterTableAdapter.Fill(Me.AddInvoicesDataSet.Master, CustomerToolStripTextBox.Text)
    '   Catch ex As System.Exception
    '       System.Windows.Forms.MessageBox.Show(ex.Message)
    '   End Try

    'End Sub

    Private Sub CustomerLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CompanyLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub InvAmtLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ServiceLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ItemCodeLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CodeLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub MasterBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles MasterBindingNavigatorSaveItem.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da2)
        Dim dsNewRow As DataRow

        dsNewRow = ds2.Tables("Master").NewRow()

        dsNewRow.Item("Customer") = CustomerTextBox.Text
        dsNewRow.Item("Company") = CompanyTextBox.Text
        dsNewRow.Item("BalDue") = InvAmtTextBox.Text
        dsNewRow.Item("ItemCode") = ItemCodeTextBox.Text
        dsNewRow.Item("Service") = ServiceTextBox.Text
        dsNewRow.Item("InvAmt") = InvAmtTextBox.Text
        dsNewRow.Item("Code") = CodeTextBox.Text
        ds2.Tables("Master").Rows.Add(dsNewRow)

        'da.Update(ds, "Customers")
        da2.Update(ds2, "Master")
        MsgBox("New Record added to the Database")

        ' btnCommit.Enabled = False
        ' btnAddNew.Enabled = True
        ' btnUpdate.Enabled = True
        'btnDelete.Enabled = True
    End Sub

    Private Sub frmAddInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
End Class