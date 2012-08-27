Imports System.Text

Public Class frmGoogleMaps

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMapIt.Click
        Try
            Dim street As String = String.Empty
            Dim city As String = String.Empty
            Dim state As String = String.Empty
            Dim zip As String = String.Empty

            Dim queryAddress As New StringBuilder()
            queryAddress.Append("http://maps.google.com/maps?q=")

            ' build street part of query string
            If txtStreet.Text <> String.Empty Then
                street = txtStreet.Text.Replace(" ", "+")
                queryAddress.Append(street + "," & "+")
            End If



            ' build city part of query string
            If txtCity.Text <> String.Empty Then
                city = txtCity.Text.Replace(" ", "+")
                queryAddress.Append(city + "," & "+")
            End If



            ' build state part of query string
            If txtState.Text <> String.Empty Then
                state = txtState.Text.Replace(" ", "+")
                queryAddress.Append(state + "," & "+")
            End If



            ' build zip code part of query string
            If txtZipCode.Text <> String.Empty Then
                zip = txtZipCode.Text.ToString()
                queryAddress.Append(zip)

            End If



            ' pass the url with the query string to web browser control
            WebBrowser1.Navigate(queryAddress.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Unable to Retrieve Map")
        End Try
    End Sub


    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub grpAddress_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpAddress.Enter

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub FormGoogleMap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
