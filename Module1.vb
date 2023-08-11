Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public data As New DataSet
    Public table As New DataTable
    Public table2 As New DataTable
    Public table3 As New DataTable
    Public table4 As New DataTable
    Public table5 As New DataTable

    Sub Opencon()
        con.ConnectionString = "server=localhost; username=root;password=;database=info_sys"
        con.Open()

    End Sub

    Public Sub ApplyDataGridViewStyling(dgv As DataGridView)
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black

        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        'Row style
        dgv.RowsDefaultCellStyle.BackColor = Color.Tan
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Tan
        dgv.RowHeadersVisible = False

        'Cell style
        dgv.DefaultCellStyle.SelectionBackColor = Color.DarkSeaGreen
        dgv.DefaultCellStyle.SelectionForeColor = Color.White

        'Border style
        dgv.BorderStyle = BorderStyle.None
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

    End Sub

End Module
