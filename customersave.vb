Public Class customersave
    Private Sub customersave_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opencon()
        con.Close()

        txtcustomer_id.Visible = False

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Opencon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO customer (`customer_name`, `customer_address`, `customer_number` )
            VALUES ('" & txtcustomer_name.Text & "', '" & txtcustomer_address.Text & "','" & txtcustomer_number.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Added Record!")
            con.Close()
            txtcustomer_id.Clear()
            txtcustomer_name.Clear()
            txtcustomer_address.Clear()
            txtcustomer_number.Clear()

            Dim parentForm As customers = DirectCast(Me.Owner, customers)
            parentForm.Load_table()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Show the customer ID TextBox for searching
        txtcustomer_id.Visible = True
        txtcustomer_id.Focus()
        btnSearch.Visible = False ' Hide the search button
    End Sub

    Private Sub txtcustomer_id_TextChanged(sender As Object, e As EventArgs) Handles txtcustomer_id.TextChanged

        Opencon()
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM customer WHERE customer_id= '" & txtcustomer_id.Text & "'"
                adapter.SelectCommand = cmd
                data.Clear()
                adapter.Fill(data, "list")


                txtcustomer_name.DataBindings.Add("Text", data, "list.customer_name")
                txtcustomer_name.DataBindings.Clear()
                txtcustomer_address.DataBindings.Add("Text", data, "list.customer_address")
                txtcustomer_address.DataBindings.Clear()
                txtcustomer_number.DataBindings.Add("Text", data, "list.customer_number")
                txtcustomer_number.DataBindings.Clear()

                If txtcustomer_id.Text = "" Then
                    txtcustomer_name.Clear()
                    txtcustomer_address.Clear()
                    txtcustomer_number.Clear()



                End If
                con.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

    End Sub
End Class