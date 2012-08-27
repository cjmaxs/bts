Imports System.Data
Imports System.Data.OleDb

Imports Invoice.LateFees.LateFeesHandler
Imports System.Collections.Specialized


Public Class frmLateFees
    Dim inc As Integer
    Dim MaxRows As Integer
    Dim Con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim idate As Date
    Dim dt1 As DataTable
    Dim dt2 As DataTable
    Dim ds2 As DataSet
    Dim dtx As DataTable
    Dim da1 As OleDb.OleDbDataAdapter
    Dim da2 As OleDb.OleDbDataAdapter
    Dim txtboxdata As String
    Dim tempStr As String
    Dim masterTableName As String = "Master" ' can use another table like "Master_test"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TextBox1.Multiline = True
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Dim lateFeeDateStr As String = Trim(txtLateFeeDate.Text)
        Dim lateFeeRateStr As String = Trim(txtLateFeeRate.Text)
        If LateFees.LateFeesHandler.ValidateLateFeeDate(lateFeeDateStr) = False Then
            lblInvDate.Show()
            Return
        Else
            lblInvDate.Hide()
        End If

        If LateFees.LateFeesHandler.ValidateLateFeeRate(lateFeeRateStr) = False Then
            lblInvRate.Show()
            Return
        Else
            lblInvRate.Hide()
            processLatefee()
        End If
    End Sub

    Private Sub frmLateFees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub processLatefee()
        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source = C:\databases\Invoices\Invoices.mdb"
        Con.ConnectionString = dbProvider & dbSource
        Con.Open()


        Latefee()
        If (Con.State = System.Data.ConnectionState.Open) Then
            Con.Close()
        End If


    End Sub

    Private Sub Latefee()

        Try
            '0. setup ds and da.
            '   get all relevant records from Invoices , <= the given date.

            '& txtLateFeeDate.Text &
            Dim Sql1 As String = "SELECT * FROM Invoices WHERE InvDate <=  @lateFeeDate and BalDue > 0   ORDER BY Customer, Invoice"
            Dim Sql2 As String = "SELECT * FROM " & masterTableName


            Using cmd1 As OleDb.OleDbCommand = New OleDbCommand(Sql1, Con)
                cmd1.CommandType = CommandType.Text
                Dim dt As DateTime = Convert.ToDateTime(txtLateFeeDate.Text)

                With cmd1.Parameters
                    .Add("@lateFeeDate", OleDbType.DBDate).Value = dt   'dbdate is mmmmyydd, and  maps to system.datetime
                End With

                dt1 = New DataTable
                dt2 = New DataTable
                da1 = New OleDb.OleDbDataAdapter(Sql1, Con)
                da2 = New OleDb.OleDbDataAdapter(Sql2, Con)
                da1.SelectCommand = cmd1


                da1.Fill(dt1) ' invoices
            End Using
            'so now dt2 has been updated. write it back out to the table. 
            'use dataadapter 2 :  da2.
            'first, must build the command for this:
            Using cmd2 As OleDb.OleDbCommand = New OleDbCommand(Sql2, Con)
                cmd2.CommandType = CommandType.Text
                da2.SelectCommand = cmd2

                Dim builder2 As OleDbCommandBuilder = New OleDbCommandBuilder(da2)
                ds2 = New DataSet()
                da2.Fill(ds2, masterTableName) '  we had filled the dt2 before, now changed to ds2.     mastertablename    table
                dt2 = ds2.Tables(masterTableName)
                Dim coll As HybridDictionary
                Dim lateFeeRate As Decimal = Convert.ToDecimal(Trim(txtLateFeeRate.Text))
                coll = LateFeesHandlerGo(dt1, lateFeeRate, TextBox1)
                LateFeesMasterTableUpdate(dt2, coll, lateFeeRate)
                'builder2.GetUpdateCommand().ExecuteNonQuery()
                da2.Update(ds2, masterTableName)
            End Using
        Catch ex As Exception
            MsgBox("exception caught: " & ex.Message)
        End Try

        ' Sql1 = "SELECT * FROM Invoices WHERE InvDate =< txtLateFeeDate.string ORDER BY Customer, Invoice"

    End Sub

    


End Class







' ''Using reader As OleDbDataReader = cmd1.ExecuteReader()
' ''    While reader.Read()

' ''    End While
'End Using




'[VB]  select:
'Dim ConnString As String = Utils.GetConnString()
'Dim SqlString As String = "Select * From Contacts Where FirstName = ? And LastName = ?"
'Using conn As New OleDbConnection(ConnString)
'  Using cmd As New OleDbCommand(SqlString, conn)
'    cmd.CommandType = CommandType.Text
'    cmd.Parameters.AddWithValue("FirstName", txtFirstName.Text)
'    cmd.Parameters.AddWithValue("LastName", txtLastName.Text)
'    conn.Open()
'    Using reader As OleDbDataReader = cmd.ExecuteReader()
'      While reader.Read()
'        Response.Write(reader("FirstName").ToString() + " " + reader("LastName").ToString())
'      End While
'    End Using
'  End Using
'End Using

