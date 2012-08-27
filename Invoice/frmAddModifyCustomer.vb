Public Class frmAddModifyCustomer
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
    Dim sqlCond As String
    Dim MaxRows As Integer


    Private Sub frmAddCustomer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        ' dbSource = "Data Source = |DataDirectory|\Invoice.mdb"
        dbSource = "Data Source = C:\Databases\Invoices\Invoices.mdb"
        con.ConnectionString = dbProvider & dbSource

        con.Open()
        sql = "Select * from Customers"
        ' sql2 = "Select * from Invoices"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Customer")
        ' da.Update(ds, "Master")

        con.Close()
        MaxRows = ds.Tables("Customer").Rows.Count
        inc = -1
    End Sub

    Private Sub Addrec()
        ' If inc <> -1 Then

        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dsNewRow As DataRow

        dsNewRow = ds.Tables("Customer").NewRow()

        dsNewRow.Item("Customer") = txtCustomer.Text
        dsNewRow.Item("Company") = txtCompany.Text
        dsNewRow.Item("Address") = txtAddress.Text
        dsNewRow.Item("Suite/Apt") = txtSuite.Text
        dsNewRow.Item("City") = txtCity.Text
        dsNewRow.Item("State") = txtState.Text
        dsNewRow.Item("Zip") = txtZip.Text

        ds.Tables("Customer").Rows.Add(dsNewRow)

        'da.Update(ds, "Customers")
        da.Update(ds, "Customer")
        MsgBox("New Record added to the Database")

        ' btnCommit.Enabled = False
        ' btnAddNew.Enabled = True
        ' btnUpdate.Enabled = True
        'btnDelete.Enabled = True

        'End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        '' If txtCustomer.Text = "" Then
        'LblCustomer.Show()
        'Else
        'LblCustomer.Hide()
        ' End If
        'If txtCustomer.Text = "" Then
        'Return
        'End If
        'Call Addrec()
        If inc <> -1 Then

            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow

            dsNewRow = ds.Tables("Customer").NewRow()

            dsNewRow.Item("Customer") = txtCustomer.Text
            dsNewRow.Item("Company") = txtCompany.Text
            dsNewRow.Item("Address") = txtAddress.Text
            dsNewRow.Item("Suite/Apt") = txtSuite.Text
            dsNewRow.Item("City") = txtCity.Text
            dsNewRow.Item("State") = txtState.Text
            dsNewRow.Item("Zip") = txtZip.Text

            ds.Tables("Customer").Rows.Add(dsNewRow)

            da.Update(ds, "Customer")

            MsgBox("Recorded Added")

            btnSave.Enabled = False
            btnAdd.Enabled = True
            btnModify.Enabled = True
            btnDelete.Enabled = True

        End If

    End Sub

    
    Private Sub btnGetCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnGetCustomer.Click
        Try
            sqlCond = "Select * from Customers where customer = " + txtCustNo.Text
            con.Open()
            da = New OleDb.OleDbDataAdapter(sqlCond, con)
            da.Fill(ds, "Customer")

            NavigateRecords()

        Catch ex As Exception
            MsgBox( ex.Message)
        End Try        
    End Sub

    Private Sub NavigateRecords()

        ' txtCompany.Text = ds.Tables("Customers").Rows(inc).Item(1)
        txtCustomer.Text = CStr(ds.Tables("Customer").Rows(inc).Item("Customer"))
        txtCompany.Text = CStr(ds.Tables("Customer").Rows(inc).Item("Company"))
        txtContact.Text = CStr(ds.Tables("Customer").Rows(inc).Item("Contact"))
        txtAddress.Text = CStr(ds.Tables("Customer").Rows(inc).Item("Address"))
        txtSuite.Text = CStr(ds.Tables("Customer").Rows(inc).Item("Suite/Apt"))
        txtCity.Text = CStr(ds.Tables("Customer").Rows(inc).Item("City"))
        txtState.Text = CStr(ds.Tables("Customer").Rows(inc).Item("State"))
        txtZip.Text = CStr(ds.Tables("Customer").Rows(inc).Item("Zip"))

    End Sub

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        If inc <> MaxRows - 1 Then
            inc = inc + 1
            NavigateRecords()
        Else
            MsgBox("Last Record")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
        If inc > 0 Then
            inc = inc - 1
            NavigateRecords()
        ElseIf inc = -1 Then
            MsgBox("First Record")
        ElseIf inc = 0 Then
            MsgBox("First Record")
        End If
    End Sub

    Private Sub btnLast_Click(sender As System.Object, e As System.EventArgs) Handles btnLast.Click
        If inc <> MaxRows - 1 Then
            inc = MaxRows - 1
            NavigateRecords()
        Else
            MsgBox("Last Record")
        End If
    End Sub

    Private Sub btnFirst_Click(sender As System.Object, e As System.EventArgs) Handles btnFirst.Click
        If inc <> 0 Then
            inc = 0
            NavigateRecords()
        Else
            MsgBox("First Record")
        End If
    End Sub

    Private Sub btnModify_Click(sender As System.Object, e As System.EventArgs) Handles btnModify.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        ds.Tables("Customer").Rows(inc).Item("Customer") = txtCustomer.Text
        ds.Tables("Customer").Rows(inc).Item("Company") = txtCompany.Text
        ds.Tables("Customer").Rows(inc).Item("Contact") = txtContact.Text
        ds.Tables("Customer").Rows(inc).Item("Address") = txtAddress.Text
        ds.Tables("Customer").Rows(inc).Item("Suite/Apt") = txtSuite.Text
        ds.Tables("Customer").Rows(inc).Item("City") = txtCity.Text
        ds.Tables("Customer").Rows(inc).Item("State") = txtState.Text
        ds.Tables("Customer").Rows(inc).Item("Zip") = txtZip.Text
        da.Update(ds, "Customer")

        MsgBox("Record Updated")

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        btnSave.Enabled = True
        btnAdd.Enabled = False
        btnModify.Enabled = False
        btnDelete.Enabled = False

        txtCustomer.Clear()
        txtCompany.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtState.ClearUndo()
        txtZip.Clear()

    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click

        If MessageBox.Show("Do you really want to Delete this Record?", _
          "Delete", MessageBoxButtons.YesNo, _
           MessageBoxIcon.Warning) = DialogResult.No Then
            MsgBox("Operation Cancelled")
            Exit Sub

        End If
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        ds.Tables("Customer").Rows(inc).Delete()
        MaxRows = MaxRows - 1

        inc = 0
        NavigateRecords()
        da.Update(ds, "Customer")
    End Sub
End Class