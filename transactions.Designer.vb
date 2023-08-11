<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transactions
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
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.PrintButton3 = New System.Windows.Forms.Button()
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView4
        '
        Me.DataGridView4.BackgroundColor = System.Drawing.Color.Tan
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.GridColor = System.Drawing.Color.Tan
        Me.DataGridView4.Location = New System.Drawing.Point(31, 54)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 62
        Me.DataGridView4.RowTemplate.Height = 33
        Me.DataGridView4.Size = New System.Drawing.Size(631, 518)
        Me.DataGridView4.TabIndex = 0
        '
        'PrintButton3
        '
        Me.PrintButton3.Font = New System.Drawing.Font("Georgia", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PrintButton3.Location = New System.Drawing.Point(550, 14)
        Me.PrintButton3.Name = "PrintButton3"
        Me.PrintButton3.Size = New System.Drawing.Size(112, 34)
        Me.PrintButton3.TabIndex = 1
        Me.PrintButton3.Text = "Print"
        Me.PrintButton3.UseVisualStyleBackColor = True
        '
        'transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(800, 607)
        Me.Controls.Add(Me.PrintButton3)
        Me.Controls.Add(Me.DataGridView4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "transactions"
        Me.Text = "transactions"
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents PrintButton3 As Button
    Friend WithEvents PrintDocument3 As Printing.PrintDocument
End Class
