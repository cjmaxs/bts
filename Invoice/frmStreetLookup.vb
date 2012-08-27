Public Class frmStreetLookup

    Private Sub FillToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillToolStripButton.Click
        Try
            Me.CustomersTableAdapter.Fill(Me.StreetDataSet.Customers, StreetNameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripBtnClose_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub
End Class
