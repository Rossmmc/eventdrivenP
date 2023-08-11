Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Public Class employees
    Private Sub Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opencon()
        Try

            con.Close()
            Load_table2()
            ApplyDataGridViewStyling(DataGridView2)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Btnaddemployee_Click(sender As Object, e As EventArgs) Handles btnaddemployee.Click
        Dim employeeSaveForm As New employeesave()
        employeeSaveForm.Owner = Me ' Set the owner of the employeesave form
        employeeSaveForm.Show()
    End Sub
    Sub Load_table2()
        Opencon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM employee"
            adapter.SelectCommand = cmd
            table2.Clear()
            adapter.Fill(table2)
            DataGridView2.DataSource = table2
            con.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DataGridView2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim columnName As String = DataGridView2.Columns(e.ColumnIndex).Name
            If columnName = "employee_name" OrElse columnName = "employee_number" Then
                Dim newValue As String = DataGridView2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
                Dim employeeId As Integer = CInt(DataGridView2.Rows(e.RowIndex).Cells("employee_id").Value)

                UpdateEmployeeDataInDatabase(employeeId, columnName, newValue)
            End If
        End If
    End Sub

    Private Sub UpdateEmployeeDataInDatabase(employeeId As Integer, columnName As String, newValue As String)
        Dim connectionString As String = "server=localhost; username=root;password=;database=info_sys"

        Using con As New MySqlConnection(connectionString)
            Try
                con.Open()
                Dim updateQuery As String = $"UPDATE employee SET {columnName} = @newValue WHERE employee_id = @employeeId"

                Using cmd As New MySqlCommand(updateQuery, con)
                    cmd.Parameters.AddWithValue("@newValue", newValue)
                    cmd.Parameters.AddWithValue("@employeeId", employeeId)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim printFont As New Font("Arial", 12)
        Dim yPos As Single = 100
        Dim count As Integer = 1

        ' Loop through the DataGridView rows and print the data
        For Each row As DataGridViewRow In DataGridView2.Rows
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

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton2.Click
        If DataGridView2.Rows.Count = 0 Then
            MessageBox.Show("No data to print.")
            Exit Sub
        End If

        Dim printDialog As New PrintDialog()
        printDialog.Document = PrintDocument2

        If printDialog.ShowDialog() = DialogResult.OK Then
            PrintDocument2.Print()
        End If
    End Sub


End Class