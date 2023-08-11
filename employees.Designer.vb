<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employees
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
        Me.btnaddemployee = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PrintButton2 = New System.Windows.Forms.Button()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnaddemployee
        '
        Me.btnaddemployee.Font = New System.Drawing.Font("Georgia", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnaddemployee.Location = New System.Drawing.Point(436, 12)
        Me.btnaddemployee.Name = "btnaddemployee"
        Me.btnaddemployee.Size = New System.Drawing.Size(139, 34)
        Me.btnaddemployee.TabIndex = 0
        Me.btnaddemployee.Text = "Add Employee"
        Me.btnaddemployee.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.Tan
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(31, 54)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 33
        Me.DataGridView2.Size = New System.Drawing.Size(544, 548)
        Me.DataGridView2.TabIndex = 1
        '
        'PrintButton2
        '
        Me.PrintButton2.Font = New System.Drawing.Font("Georgia", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PrintButton2.Location = New System.Drawing.Point(318, 12)
        Me.PrintButton2.Name = "PrintButton2"
        Me.PrintButton2.Size = New System.Drawing.Size(112, 34)
        Me.PrintButton2.TabIndex = 2
        Me.PrintButton2.Text = "Print"
        Me.PrintButton2.UseVisualStyleBackColor = True
        '
        'PrintDocument2
        '
        '
        'employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(800, 639)
        Me.Controls.Add(Me.PrintButton2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.btnaddemployee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "employees"
        Me.Text = "employees"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnaddemployee As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents PrintButton2 As Button
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
End Class
