Imports System.IO.File
Public Class frmBackup

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim FileToCopy As String
        Dim NewCopy As String

        FileToCopy = "C:\Databases\Invoices\Invoices.mdb"
        NewCopy = "C:\Backup\Invoices\Invoices.bak"

        If System.IO.File.Exists(FileToCopy) = True Then
            System.IO.File.Copy(FileToCopy, NewCopy)
            MsgBox("File Backed Up")
        End If
    End Sub
End Class