Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1
    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the connection and close it immediately
        Opencon()
        con.Close()
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Opencon()

        Try
            Dim username As String = usernamebox.Text
            Dim password As String = passwordbox.Text  ' Get the password input

            ' Query the database to check if the username and password match
            Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                Dim userCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If userCount = 1 Then
                    MsgBox("Welcome " & username & ". Press 'OK' to continue to the admin dashboard.")
                    admindashboard.Show()

                    Me.Hide()
                Else
                    MsgBox("Invalid username or password.")
                End If
            End Using

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub registerbtn_Click(sender As Object, e As EventArgs) Handles registerbtn.Click
        register.Show()
    End Sub
End Class
