' Imports Microsoft.Office.Interop

Public Class frmMainMenu

    Private Sub MaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaintenanceToolStripMenuItem.Click
        ' frmCustomer.ShowDialog()
        ' frmAddCustomer.ShowDialog()
    End Sub

    Private Sub LookupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookupToolStripMenuItem.Click
        frmStreetLookup.ShowDialog()
    End Sub

    Private Sub ManualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualToolStripMenuItem.Click
        ' FormInvoiceAdd.ShowDialog()

    End Sub

    Private Sub PayInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayInvoiceToolStripMenuItem.Click
        ' frmPayInvoice.ShowDialog()
        ' PayInvoice.ShowDialog()
        frmPayments.ShowDialog()
    End Sub

    Private Sub RecurringInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecurringInvoicesToolStripMenuItem.Click
        frmMonthlyStatements.ShowDialog()
    End Sub

    Private Sub AccessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim oExcel As New Excel.Application
        ' oExcel.Visible = True
        ' oExcel.Workbooks.Add()
    End Sub

    Private Sub Word2003ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Word2003ToolStripMenuItem.Click
        ' Dim objWord As New Word.Application
        ' objWord.Visible = True
        ' objWord.Documents.Add()
    End Sub

    Private Sub Excel2003ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Excel2003ToolStripMenuItem.Click
        ' Dim oExcel As New Excel.Application
        ' oExcel.Visible = True
        ' oExcel.Workbooks.Add()
    End Sub

    Private Sub ExpensesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpensesToolStripMenuItem.Click
        Shell("c:\Databases\Invoices\Exp2004.mdb")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GoogleMapsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleMapsToolStripMenuItem.Click
        frmGoogleMaps.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        ' FrmRecycling.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        ' FrmRecycRpt.ShowDialog()
        ' Form2.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        frmLateFees.ShowDialog()
    End Sub

    Private Sub MainFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmLogin.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        FrmLogin.ShowDialog()
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackupToolStripMenuItem.Click
        frmBackup.ShowDialog()
    End Sub

    Private Sub InvoicesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InvoicesToolStripMenuItem.Click

    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomerToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem5.Click
        frmQuickInvoice.ShowDialog()
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RestoreToolStripMenuItem.Click
        frmRestore.ShowDialog()
    End Sub

    Private Sub AddInvoiceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddInvoiceToolStripMenuItem.Click
        frmAddInvoice.ShowDialog()
    End Sub

    Private Sub EditDeleteInvoiceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditDeleteInvoiceToolStripMenuItem.Click
        frmEditInvoice.ShowDialog()
    End Sub

    Private Sub RecyclingTonageToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RecyclingTonageToolStripMenuItem.Click

    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddToolStripMenuItem.Click
        frmAddCustomer.ShowDialog()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditToolStripMenuItem.Click
        editCustomer.ShowDialog()
    End Sub
End Class