Imports System.Data.DataTable
Imports System.Data.DataSet
Imports System.Data

Public Class frmMonthlyStatements
    Dim mMonth As String
    Dim TxtBoxData As String
    Dim newMonth As String
    Dim inc As Integer
    Dim invNum As Integer
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

    Public Sub FrmProcessStatements_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source = C:\Databases\Invoices\Invoices.mdb"
        con.ConnectionString = dbProvider & dbSource
        sql = "Select * from Master"
        sql2 = "Select * from Invoices"
    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        con.Close()
        Me.Close()
    End Sub

    Private Sub ButtonProcess_Click(sender As System.Object, e As System.EventArgs) Handles ButtonProcess.Click
        TxtBoxData = Trim(txtInvMonth.Text)
        If txtInvNum.ToString = "" Then
            lblInvNum.Show()
        Else
            lblInvNum.Hide()
        End If
        If txtInvDate.Text = "" Then
            lblInvDate.Show()
        Else
            lblInvDate.Hide()
        End If
        If txtInvMonth.Text = "" Then
            lblInvMonth.Show()
        Else
            lblInvMonth.Hide()
        End If
        If txtInvDate.Text = "" Or txtInvMonth.Text = "" Or txtInvNum.Text = "" Then
            Return
        End If
        Call Processmonth()
    End Sub

    Public Sub Processmonth()
        con.Open()
        MsgBox("Database is open")
        da = New OleDb.OleDbDataAdapter(sql, con)
        da2 = New OleDb.OleDbDataAdapter(sql2, con)
        da.Fill(ds, "Master")
        da2.Fill(ds2, "Invoices")
        MaxRows = ds.Tables("Master").Rows.Count
        inc = -1
        MsgBox("Processing Statements")
        Call chgmonth()
        Call UpdateDatabase()
    End Sub

    Public Sub chgmonth()
        TxtBoxData = Trim(txtInvMonth.Text)
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim cb2 As New OleDb.OleDbCommandBuilder(da2)
        Dim dsNewRow As DataRow
        Dim nmonthTmp As String
        Dim serviceTmp As String
        'If inc <> 0 Then
        invNum = CInt(txtInvNum.Text)
        inc = 0
        Try
            Do Until inc = MaxRows
                ds.Tables("Master").Rows(inc).Item("nMnth") = txtInvMonth.Text
                ds.Tables("Master").Rows(inc).Item("Invoice") = invNum
                ds.Tables("Master").Rows(inc).Item("InvDate") = txtInvDate.Text
                dsNewRow = ds2.Tables("Invoices").NewRow()
                dsNewRow("idnum") = ds.Tables("Master").Rows(inc).Item("idnum")
                dsNewRow("Invoice") = invNum
                dsNewRow("invDate") = ds.Tables("Master").Rows(inc).Item("invdate")
                dsNewRow("Customer") = ds.Tables("Master").Rows(inc).Item("Customer")
                dsNewRow("Company") = ds.Tables("Master").Rows(inc).Item("Company")
                dsNewRow("InvAmt") = ds.Tables("Master").Rows(inc).Item("InvAmt")
                dsNewRow("BalDue") = ds.Tables("Master").Rows(inc).Item("BalDue")
                nmonthTmp = ds.Tables("Master").Rows(inc).Item("nMnth").ToString
                serviceTmp = ds.Tables("Master").Rows(inc).Item("Service").ToString
                dsNewRow("Service") = Trim(nmonthTmp) + " " + Trim(serviceTmp)
                dsNewRow("AmtPaid") = ds.Tables("Master").Rows(inc).Item("AmtPaid")
                dsNewRow("DatePaid") = ds.Tables("Master").Rows(inc).Item("DatePaid")
                dsNewRow("Ref") = ds.Tables("Master").Rows(inc).Item("Ref")
                dsNewRow("ItemCode") = ds.Tables("Master").Rows(inc).Item("ItemCode")
                ds2.Tables("Invoices").Rows.Add(dsNewRow)
                da2.InsertCommand = cb2.GetInsertCommand()
                inc = inc + 1
                invNum = invNum + 1
            Loop
        Catch ex As Exception
            MsgBox("What Happened?? err in chgmonth, e: " + ex.Message)
        End Try
    End Sub

    Public Sub UpdateDatabase()
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim cb2 As New OleDb.OleDbCommandBuilder(da2)        
        da.Update(ds, "Master")
        da2.InsertCommand = cb2.GetInsertCommand()
        da2.Update(ds2, "Invoices")
        MsgBox("Database Updated")
        con.Close()
        MsgBox("Database is Closed")
        txtInvMonth.Text = ""
        txtInvDate.Text = ""
        txtInvNum.Text = ""
        con.Close()
    End Sub

   
End Class