

Partial Public Class CustomerDataSet
    Partial Class CustomersDataTable

        Private Sub CustomersDataTable_ColumnChanging(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CellPhoneColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
