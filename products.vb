Imports MySql.Data.MySqlClient

Public Class products
    Private Sub products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opencon()
        Try
            con.Close()
            Load3_table()
            ApplyDataGridViewStyling(DataGridView3)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub Load3_table()
        Opencon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM product"
            adapter.SelectCommand = cmd
            table3.Clear()
            adapter.Fill(table3)
            DataGridView3.DataSource = table3
            con.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Using inputDialog As New InputProductBox()


            If inputDialog.ShowDialog() = DialogResult.OK Then
                Dim connectionString As String = "server=localhost; username=root;password=;database=info_sys"

                Try

                    Using con As New MySqlConnection(connectionString)
                        con.Open()

                        Using cmd As New MySqlCommand("AddNewProduct", con)
                            cmd.CommandType = CommandType.StoredProcedure

                            ' Set up parameters if needed
                            ' Set up parameters using user input
                            cmd.Parameters.AddWithValue("@product_Name", inputDialog.ProductName)
                            cmd.Parameters.AddWithValue("@product_Price", inputDialog.ProductPrice)
                            cmd.Parameters.AddWithValue("@stocks", inputDialog.Stocks)
                            cmd.ExecuteNonQuery()

                            MessageBox.Show("Successfully added a new product!")
                            Load3_table()
                        End Using
                    End Using
                    con.Close()

                Catch ex As Exception
                    MsgBox(ex.ToString)


                End Try
            End If

        End Using

    End Sub
    Private Sub DataGridView3_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellEndEdit
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim columnName As String = DataGridView3.Columns(e.ColumnIndex).Name
                If columnName = "product_name" OrElse columnName = "product_number" OrElse columnName = "stocks" Then
                    Dim newValue As String = DataGridView3.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
                    Dim productId As Integer = CInt(DataGridView3.Rows(e.RowIndex).Cells("product_id").Value)

                    UpdateProductDataInDatabase(productId, columnName, newValue)

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)


        End Try
    End Sub

    Private Sub UpdateProductDataInDatabase(productId As Integer, columnName As String, newValue As String)
        Dim connectionString As String = "server=localhost; username=root;password=;database=info_sys"

        Using con As New MySqlConnection(connectionString)
            Try
                con.Open()
                Dim updateQuery As String = $"UPDATE product SET {columnName} = @newValue WHERE product_id = @productId"

                Using cmd As New MySqlCommand(updateQuery, con)
                    cmd.Parameters.AddWithValue("@newValue", newValue)
                    cmd.Parameters.AddWithValue("@productId", productId)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using
    End Sub


End Class