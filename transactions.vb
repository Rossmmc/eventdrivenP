Imports System.Drawing.Printing

Public Class transactions
    Private Sub transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opencon()
        Try
            con.Close()
            Load4_table()
            ApplyDataGridViewStyling(DataGridView4)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub Load4_table()
        Opencon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM customerorderhistory"
            adapter.SelectCommand = cmd
            table4.Clear()
            adapter.Fill(table4)
            DataGridView4.DataSource = table4
            con.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim printFont As New Font("Arial", 12)
        Dim yPos As Single = 100
        Dim count As Integer = 1

        ' Loop through the DataGridView rows and print the data
        For Each row As DataGridViewRow In DataGridView4.Rows
            Dim rowData As String = $"CustomerName: {row.Cells("customer_name").Value}, Product: {row.Cells("product_Name").Value}, Quantity: {row.Cells("quantity").Value}, Amount: {row.Cells("amount").Value}"
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

    Private Sub PrintButton3_Click(sender As Object, e As EventArgs) Handles PrintButton3.Click
        If DataGridView4.Rows.Count = 0 Then
            MessageBox.Show("No data to print.")
            Exit Sub
        End If

        Dim printDialog As New PrintDialog()
        printDialog.Document = PrintDocument3
        If printDialog.ShowDialog() = DialogResult.OK Then
            PrintDocument3.Print()
        End If
    End Sub
End Class
