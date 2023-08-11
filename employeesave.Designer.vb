<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employeesave
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btnsavemployee = New System.Windows.Forms.Button()
        Me.txtemployee_name = New System.Windows.Forms.TextBox()
        Me.txtemployee_number = New System.Windows.Forms.TextBox()
        Me.txtemployee_id = New System.Windows.Forms.TextBox()
        Me.BtnSearchE = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.midtermedp.My.Resources.Resources._12
        Me.PictureBox1.Location = New System.Drawing.Point(167, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 99)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(32, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Contact #"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(32, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(32, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ID"
        '
        'Btnsavemployee
        '
        Me.Btnsavemployee.Font = New System.Drawing.Font("Georgia", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btnsavemployee.Location = New System.Drawing.Point(291, 328)
        Me.Btnsavemployee.Name = "Btnsavemployee"
        Me.Btnsavemployee.Size = New System.Drawing.Size(104, 33)
        Me.Btnsavemployee.TabIndex = 14
        Me.Btnsavemployee.Text = "Save"
        Me.Btnsavemployee.UseVisualStyleBackColor = True
        '
        'txtemployee_name
        '
        Me.txtemployee_name.Location = New System.Drawing.Point(103, 215)
        Me.txtemployee_name.Name = "txtemployee_name"
        Me.txtemployee_name.Size = New System.Drawing.Size(292, 31)
        Me.txtemployee_name.TabIndex = 12
        '
        'txtemployee_number
        '
        Me.txtemployee_number.Location = New System.Drawing.Point(103, 271)
        Me.txtemployee_number.Name = "txtemployee_number"
        Me.txtemployee_number.Size = New System.Drawing.Size(292, 31)
        Me.txtemployee_number.TabIndex = 11
        '
        'txtemployee_id
        '
        Me.txtemployee_id.Location = New System.Drawing.Point(103, 167)
        Me.txtemployee_id.Name = "txtemployee_id"
        Me.txtemployee_id.Size = New System.Drawing.Size(76, 31)
        Me.txtemployee_id.TabIndex = 10
        '
        'BtnSearchE
        '
        Me.BtnSearchE.Font = New System.Drawing.Font("Georgia", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSearchE.Location = New System.Drawing.Point(103, 167)
        Me.BtnSearchE.Name = "BtnSearchE"
        Me.BtnSearchE.Size = New System.Drawing.Size(112, 34)
        Me.BtnSearchE.TabIndex = 20
        Me.BtnSearchE.Text = "Search"
        Me.BtnSearchE.UseVisualStyleBackColor = True
        '
        'employeesave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(459, 405)
        Me.Controls.Add(Me.BtnSearchE)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnsavemployee)
        Me.Controls.Add(Me.txtemployee_name)
        Me.Controls.Add(Me.txtemployee_number)
        Me.Controls.Add(Me.txtemployee_id)
        Me.Name = "employeesave"
        Me.Text = "employeesave"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnsavemployee As Button
    Friend WithEvents txtemployee_name As TextBox
    Friend WithEvents txtemployee_number As TextBox
    Friend WithEvents txtemployee_id As TextBox
    Friend WithEvents BtnSearchE As Button
End Class
