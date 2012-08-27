Imports System.IO.File
Public Class frmRestore

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim FileToCopy As String
        Dim NewCopy As String

        FileToCopy = "C:\Backup\Invoices\Invoices.bak"
        NewCopy = "C:\Databases\Invoices\Invoices.mdb"

        If System.IO.File.Exists(FileToCopy) = True Then
            System.IO.File.Copy(FileToCopy, NewCopy)
            MsgBox("File Restored")
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class