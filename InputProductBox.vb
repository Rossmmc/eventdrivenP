Public Class InputProductBox
    Public Overloads Property ProductName As String
    Public Property ProductPrice As Double
    Public Property Stocks As Object

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click


        Try ' Validate and assign user input to properties
            If Not String.IsNullOrWhiteSpace(TextBoxProductName.Text) AndAlso
                Double.TryParse(TextBoxProductPrice.Text, ProductPrice) AndAlso
                Integer.TryParse(TextBoxStocks.Text, Stocks) Then
                ProductName = TextBoxProductName.Text
                DialogResult = DialogResult.OK


            Else
                MessageBox.Show("Invalid input. Please enter valid product name and price.")


            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs)
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub TextBoxProductPrice_TextChanged(sender As Object, e As EventArgs) Handles TextBoxProductPrice.TextChanged

    End Sub

    Private Sub InputProductBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBoxProductName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxProductName.TextChanged

    End Sub

    Private Sub TextBoxStocks_TextChanged(sender As Object, e As EventArgs) Handles TextBoxStocks.TextChanged

    End Sub
End Class