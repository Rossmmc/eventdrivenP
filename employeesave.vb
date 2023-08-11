Public Class employeesave
    Private Sub employeesave_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtemployee_id.Visible = False
    End Sub
    Private Sub Btnsavemployee_Click(sender As Object, e As EventArgs) Handles Btnsavemployee.Click
        Opencon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO employee( `employee_name`, `employee_number` )
            VALUES ('" & txtemployee_name.Text & "','" & txtemployee_number.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Added Record!")
            con.Close()
            txtemployee_id.Clear()
            txtemployee_name.Clear()
            txtemployee_number.Clear()


            Dim parentForm As employees = DirectCast(Me.Owner, employees)
            parentForm.Load_table2()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnSearchE_Click(sender As Object, e As EventArgs) Handles BtnSearchE.Click
        ' Show the customer ID TextBox for searching
        txtemployee_id.Visible = True
        txtemployee_id.Focus()
        BtnSearchE.Visible = False ' Hide the search button
    End Sub

    Private Sub txtemployee_id_TextChanged(sender As Object, e As EventArgs) Handles txtemployee_id.TextChanged

        Opencon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM customer WHERE customer_id= '" & txtemployee_id.Text & "'"
            adapter.SelectCommand = cmd
            data.Clear()
            adapter.Fill(data, "list")


            txtemployee_name.DataBindings.Add("Text", data, "list.customer_name")
            txtemployee_name.DataBindings.Clear()
            txtemployee_number.DataBindings.Add("Text", data, "list.customer_number")
            txtemployee_number.DataBindings.Clear()

            If txtemployee_id.Text = "" Then
                txtemployee_name.Clear()
                txtemployee_number.Clear()


            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub



End Class
