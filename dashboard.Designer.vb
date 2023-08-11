<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.totalcustomersbtn = New System.Windows.Forms.Button()
        Me.totalemployeesbtn = New System.Windows.Forms.Button()
        Me.totalproductsbtn = New System.Windows.Forms.Button()
        Me.PanelD = New System.Windows.Forms.Panel()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.PanelD.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'totalcustomersbtn
        '
        Me.totalcustomersbtn.BackColor = System.Drawing.Color.Tan
        Me.totalcustomersbtn.Font = New System.Drawing.Font("Georgia", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.totalcustomersbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.totalcustomersbtn.Location = New System.Drawing.Point(43, 47)
        Me.totalcustomersbtn.Name = "totalcustomersbtn"
        Me.totalcustomersbtn.Size = New System.Drawing.Size(132, 126)
        Me.totalcustomersbtn.TabIndex = 0
        Me.totalcustomersbtn.Text = "Total Customers"
        Me.totalcustomersbtn.UseVisualStyleBackColor = False
        '
        'totalemployeesbtn
        '
        Me.totalemployeesbtn.BackColor = System.Drawing.Color.Tan
        Me.totalemployeesbtn.Font = New System.Drawing.Font("Georgia", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.totalemployeesbtn.Location = New System.Drawing.Point(43, 230)
        Me.totalemployeesbtn.Name = "totalemployeesbtn"
        Me.totalemployeesbtn.Size = New System.Drawing.Size(132, 126)
        Me.totalemployeesbtn.TabIndex = 1
        Me.totalemployeesbtn.Text = "Total Employees"
        Me.totalemployeesbtn.UseVisualStyleBackColor = False
        '
        'totalproductsbtn
        '
        Me.totalproductsbtn.BackColor = System.Drawing.Color.Tan
        Me.totalproductsbtn.Font = New System.Drawing.Font("Georgia", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.totalproductsbtn.Location = New System.Drawing.Point(43, 414)
        Me.totalproductsbtn.Name = "totalproductsbtn"
        Me.totalproductsbtn.Size = New System.Drawing.Size(132, 126)
        Me.totalproductsbtn.TabIndex = 2
        Me.totalproductsbtn.Text = "Total Products"
        Me.totalproductsbtn.UseVisualStyleBackColor = False
        '
        'PanelD
        '
        Me.PanelD.Controls.Add(Me.DataGridView5)
        Me.PanelD.Location = New System.Drawing.Point(0, 0)
        Me.PanelD.Name = "PanelD"
        Me.PanelD.Size = New System.Drawing.Size(801, 612)
        Me.PanelD.TabIndex = 3
        '
        'DataGridView5
        '
        Me.DataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView5.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.GridColor = System.Drawing.Color.DarkSlateGray
        Me.DataGridView5.Location = New System.Drawing.Point(332, 134)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.RowHeadersWidth = 62
        Me.DataGridView5.RowTemplate.Height = 33
        Me.DataGridView5.Size = New System.Drawing.Size(284, 296)
        Me.DataGridView5.TabIndex = 0
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(800, 613)
        Me.Controls.Add(Me.totalproductsbtn)
        Me.Controls.Add(Me.totalemployeesbtn)
        Me.Controls.Add(Me.totalcustomersbtn)
        Me.Controls.Add(Me.PanelD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dashboard"
        Me.Text = "dashboard"
        Me.PanelD.ResumeLayout(False)
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents totalcustomersbtn As Button
    Friend WithEvents totalemployeesbtn As Button
    Friend WithEvents totalproductsbtn As Button
    Friend WithEvents PanelD As Panel
    Friend WithEvents DataGridView5 As DataGridView
End Class
