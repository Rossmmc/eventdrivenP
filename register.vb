Public Class register

    Private Sub Btnregisteruser_Click(sender As Object, e As EventArgs) Handles Btnregisteruser.Click
        Opencon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO users( `username`, `password` )
            VALUES ('" & registerusernamebox.Text & "','" & registerpasswordbox.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Added Record!")
            con.Close()
            registerusernamebox.Clear()
            registerpasswordbox.Clear()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Class