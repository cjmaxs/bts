Public Class frmCustomer
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

    Private Sub frmCustomer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'da.Fill(ds, "Master")
    End Sub

    ' Private Sub CustomersBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '  Me.CustomersBindingSource.EndEdit()
    '  Me.TableAdapterManager.UpdateAll(Me.CustomerDataSet)
    ' end sub

    Private Sub Navigate()
        ' MaxRows = ds.Tables("Master").Rows.Count
        ' inc = -1
    End Sub

    Private Sub FillToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillToolStripButton.Click
        Try
            Me.CustomersTableAdapter.Fill(Me.CustomerDataSet.Customers, CustomerToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        frmAddCustomer.ShowDialog()
    End Sub


    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        inc = +1
        'Call getrec()
        If inc <> MaxRows - 1 Then
            inc = inc + 1
            getrec()
        Else
            MsgBox("No More Rows")
        End If

    End Sub
    Private Sub getrec()
        'txtPickup.Text = CStr(ds.Tables("Customer").Rows(inc).Item("Service"))

    End Sub
    Sub CustomerSearch()

        ' Dim CustNo As String
        ' Dim mySQL As String

        'CustNo = (TextBox1.Text)
        ' mySQL = "SELECT * FROM Customers WHERE (Customer =" & CustNo & ")"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        CustomerSearch()
    End Sub

    Private Sub btnModify_Click(sender As System.Object, e As System.EventArgs) Handles btnModify.Click

    End Sub
End Class
