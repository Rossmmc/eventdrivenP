Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports MySql.Data.MySqlClient

Public Class dashboard
    Private buttonClicked As Boolean = False
    Public Sub ShowButtons()
        ' Show all buttons
        customers.Hide() ' Replace with the actual DataGridView control names you have
        employees.Hide()
        products.Hide()
        ' ... Hide other DataGridView controls ...

        ' Show all buttons
        totalcustomersbtn.Show()
        totalemployeesbtn.Show()
        totalproductsbtn.Show()

        ' Set the buttonClicked flag to false
        buttonClicked = False
        ' Set the buttonClicked flag to false
        buttonClicked = False
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opencon()
        Try
            con.Close()

            ' Count and display customer and employee counts
            UpdateCounts()
            Load5_table()
            ApplyDataGridViewStyling(DataGridView5)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub Load5_table()
        Opencon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM totalsalesbyproduct"
            adapter.SelectCommand = cmd
            table5.Clear()
            adapter.Fill(table5)
            DataGridView5.DataSource = table5
            con.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub dashboard_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If buttonClicked AndAlso Me.Visible Then
            ShowButtons()
            Load5_table()
        End If
    End Sub

    ' Custom method to count records and update counts
    Private Sub UpdateCounts()
        Dim connectionString As String = "server=localhost; username=root;password=;database=info_sys"

        Using con As New MySqlConnection(connectionString)
            Try
                con.Open()

                ' Count customers
                Dim customerCount As Integer
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM customer", con)
                    customerCount = CInt(cmd.ExecuteScalar())
                End Using
                totalcustomersbtn.Text = $"Total Customers ({customerCount})"

                Dim employeeCount As Integer
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM employee", con)
                    employeeCount = CInt(cmd.ExecuteScalar())
                End Using
                totalemployeesbtn.Text = $"Total Employees ({employeeCount})"

                Dim productCount As Integer
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM product", con)
                    productCount = CInt(cmd.ExecuteScalar())
                End Using
                totalproductsbtn.Text = $"Total Products ({productCount})"

            Catch ex As Exception
                MsgBox("Error updating counts: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub addform(frm As Form)
        PanelD.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        PanelD.Controls.Add(frm)
        frm.Show()

    End Sub

    Private Sub changeform(menu As String)
        Select Case menu
            Case "Customers"
                addform(customers)
            Case "Employees"
                addform(employees)
            Case "Products"
                addform(products)

        End Select
    End Sub

    Private Sub HideButtons()
        ' Hide all buttons
        totalcustomersbtn.Hide()
        totalemployeesbtn.Hide()
        totalproductsbtn.Hide()

        ' Set the buttonClicked flag to true
        buttonClicked = True
    End Sub


    Private Sub totalcustomersbtn_Click(sender As Object, e As EventArgs) Handles totalcustomersbtn.Click
        changeform("Customers")
        HideButtons()
    End Sub
    Private Sub totalemployeesbtn_Click(sender As Object, e As EventArgs) Handles totalemployeesbtn.Click
        changeform("Employees")
        HideButtons()
    End Sub

    Private Sub totalproductsbtn_Click(sender As Object, e As EventArgs) Handles totalproductsbtn.Click
        changeform("Products")
        HideButtons()
    End Sub

    Public Sub dashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If buttonClicked Then
            ShowButtons()
        End If
    End Sub

End Class