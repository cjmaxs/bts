Public Class FrmLogin


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        frmMainMenu.Close()
        Me.Close()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim mUsername As String
        Dim mPassword As String
        mUsername = "juanita"
        mPassword = "bts301"

        If (UsernameTextBox.Text = mUsername) And (PasswordTextBox.Text = mPassword) Then
            ' frmMenu.Show()
            Me.Close()
        Else
            MsgBox("Username or password is incorrect, please try again!")
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
        End If
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

End Class
