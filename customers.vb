Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles
Imports MySql.Data.MySqlClient

Public Class customers
    Private Sub Customers_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opencon()
        Try
            con.Close()
            Load_table()
            ApplyDataGridViewStyling(DataGridView1)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim customerSaveForm As New customersave()
        customerSaveForm.Owner = Me
        customerSaveForm.Show()
    End Sub
    Sub Load_table()
        Opencon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM customer"
            adapter.SelectCommand = cmd
            table.Clear()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            con.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim columnName As String = DataGridView1.Columns(e.ColumnIndex).Name
            If columnName = "customer_name" OrElse columnName = "customer_address" OrElse columnName = "customer_number" Then
                Dim newValue As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
                Dim customerId As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells("customer_id").Value)

                UpdateCustomerDataInDatabase(customerId, columnName, newValue)
            End If
        End If
    End Sub

    Private Sub UpdateCustomerDataInDatabase(customerId As Integer, columnName As String, newValue As String)
        Dim connectionString As String = "server=localhost; username=root;password=;database=info_sys"

        Using con As New MySqlConnection(connectionString)
            Try
                con.Open()
                Dim updateQuery As String = $"UPDATE customer SET {columnName} = @newValue WHERE customer_id = @customerId"

                Using cmd As New MySqlCommand(updateQuery, con)
                    cmd.Parameters.AddWithValue("@newValue", newValue)
                    cmd.Parameters.AddWithValue("@customerId", customerId)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error updating {columnName}: {ex.Message}")
            End Try
        End Using
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim printFont As New Font("Arial", 12)
        Dim yPos As Single = 100
        Dim count As Integer = 1

        ' Loop through the DataGridView rows and print the data
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim rowData As String = $"Customer ID: {row.Cells("customer_id").Value}, Name: {row.Cells("customer_name").Value}, Address: {row.Cells("customer_address").Value}, Number: {row.Cells("customer_number").Value}"
            e.Graphics.DrawString(rowData, printFont, Brushes.Black, 100, yPos)
            yPos += printFont.GetHeight()
            count += 1

            ' Check if there's enough space left on the page
            If yPos + printFont.GetHeight() > e.PageBounds.Height Then
                e.HasMorePages = True
                Exit For
            Else
                e.HasMorePages = False
            End If
        Next
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("No data to print.")
            Exit Sub
        End If

        Dim printDialog As New PrintDialog()
        printDialog.Document = PrintDocument1

        If printDialog.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub


End Class


