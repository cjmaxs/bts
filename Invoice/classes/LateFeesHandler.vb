Imports System.Data.DataRow
Imports System.Collections.Specialized
Imports System.Collections.Specialized.HybridDictionary
Imports Invoice.LateFees.RowInfo

Namespace LateFees

    Public Class LateFeesHandler

        Private Shared uniqueKey As String = "Customer"  'before was "Company".

        Public Shared Sub LateFeesMasterTableUpdate(ByRef dt2 As DataTable, ByRef coll As HybridDictionary, ByVal lateFeeRate As Decimal)
            'now, write out any new rows to dt2.   once its sent back, it will be updated via the dataadapter.
            'we have the rows to write in coll.  Use the lateFeerate, and baldue,  to calculate a single new (additional) balance for each client.
            'Dim row As System.Data.DataRow

            For Each entry As DictionaryEntry In coll
                Dim row = dt2.NewRow()
                row(uniqueKey) = entry.Key  'customer name
                row("Service") = "Late Fee"
                row("ItemCode") = "SVCCHG"
                Dim rowInfoEntry As RowInfo = entry.Value
                row("Company") = rowInfoEntry.company
                Dim invAmt As Decimal = rowInfoEntry.invAmt   'total original bal due in invoice (added up)
                Dim fee As Decimal = invAmt * lateFeeRate * 0.01
                row("BalDue") = fee
                row("InvAmt") = fee
                dt2.Rows.Add(row)
            Next
            'now, done adding rows of fees, one row per relevant customer.
            'Now need to write out to the master_test table.


        End Sub

        Public Shared Function LateFeesHandlerGo(ByVal dt1 As DataTable, ByVal lateFeeRate As Decimal, ByVal textBox1 As TextBox)

            Dim coll As New HybridDictionary
            Dim tempStr As String
            'Dim entry As DictionaryEntry

            Dim d, d2 As Decimal
            Dim dStr As String
            Dim feeStr As String
            Dim rowInfo As RowInfo
            textBox1.Text = ""
            coll.Clear()

            For Each row As DataRow In dt1.Rows
                'Item[String]
                'MsgBox("RowData customer: " & row.Item("Company"))
                If coll.Contains(row.Item(uniqueKey).ToString.Trim) Then
                    'do nothing
                Else
                    'add this item with total of 0
                    rowInfo = New RowInfo()
                    rowInfo.company = row.Item("Company")
                    rowInfo.invAmt = 0.0
                    coll.Add(row.Item(uniqueKey).ToString.Trim, rowInfo) 'used to be just d (the sum invamt), instead of rowInfo.
                End If
                'now add to total by reading it, and replacing the total  
                rowInfo = coll.Item(row.Item(uniqueKey).ToString.Trim)   'from collection list, has a Decimal in it. so cast.
                rowInfo.invAmt += row.Item("BalDue")  'hope all items in database are proper decimals (strings) coming out! else this throw exception
                'write it back
                coll.Item(row.Item(uniqueKey).ToString.Trim) = rowInfo

            Next

            'MsgBox("total entries: " & coll.Count)
            For Each entry As DictionaryEntry In coll
                Dim customerName = entry.Key
                Dim rowInfoEntry As RowInfo = entry.Value 
                d = rowInfoEntry.invAmt
                dStr = d.ToString("G29")
                feeStr = d * (lateFeeRate * 0.01) '
                tempStr = "Customer: " & customerName & ", Company: " & rowInfoEntry.company & ", baldue: " & dStr & ", fees: " & feeStr & Environment.NewLine
                textBox1.Text += tempStr
            Next

            Return coll



        End Function

        Public Shared Function ValidateLateFeeDate(ByVal myDate As String) As Boolean
            Dim f As Boolean
            If myDate = "" Then
                Return False
            End If
            'late fee needs to look like "1/5" of current year or "1/5/2012" of a given year
            Try
                f = True
                Dim datetime As DateTime = Convert.ToDateTime(myDate)
            Catch ex As Exception
                f = False
            End Try
            Return f
        End Function

        Shared Function ValidateLateFeeRate(ByVal lateFeeRateStr As String) As Boolean
            Dim f As Boolean
            If lateFeeRateStr = "" Then
                Return False
            End If
            'late fee rate needs to be a decimal num.  so regex it.
            Try
                f = True
                Dim rate As Decimal = Convert.ToDecimal(lateFeeRateStr)
                If (rate <= 0) Then
                    f = False
                End If

            Catch ex As Exception
                f = False
            End Try


            Return f
        End Function

    End Class

End Namespace

