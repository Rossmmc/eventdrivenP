<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Me.btnregisteruser = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.passwordID = New System.Windows.Forms.Label()
        Me.registerpasswordbox = New System.Windows.Forms.TextBox()
        Me.registerusernamebox = New System.Windows.Forms.TextBox()
        Me.usernameID = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnregisteruser
        '
        Me.btnregisteruser.Font = New System.Drawing.Font("Georgia", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnregisteruser.Location = New System.Drawing.Point(131, 299)
        Me.btnregisteruser.Name = "btnregisteruser"
        Me.btnregisteruser.Size = New System.Drawing.Size(104, 28)
        Me.btnregisteruser.TabIndex = 12
        Me.btnregisteruser.Text = "Register"
        Me.btnregisteruser.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.midtermedp.My.Resources.Resources._12
        Me.PictureBox1.Location = New System.Drawing.Point(120, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 99)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'passwordID
        '
        Me.passwordID.AutoSize = True
        Me.passwordID.BackColor = System.Drawing.Color.Transparent
        Me.passwordID.Font = New System.Drawing.Font("Georgia", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.passwordID.Location = New System.Drawing.Point(321, 236)
        Me.passwordID.Name = "passwordID"
        Me.passwordID.Size = New System.Drawing.Size(60, 15)
        Me.passwordID.TabIndex = 10
        Me.passwordID.Text = "Password"
        '
        'registerpasswordbox
        '
        Me.registerpasswordbox.Font = New System.Drawing.Font("Georgia", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.registerpasswordbox.Location = New System.Drawing.Point(24, 231)
        Me.registerpasswordbox.Multiline = True
        Me.registerpasswordbox.Name = "registerpasswordbox"
        Me.registerpasswordbox.Size = New System.Drawing.Size(291, 31)
        Me.registerpasswordbox.TabIndex = 9
        '
        'registerusernamebox
        '
        Me.registerusernamebox.Font = New System.Drawing.Font("Georgia", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.registerusernamebox.Location = New System.Drawing.Point(24, 188)
        Me.registerusernamebox.Multiline = True
        Me.registerusernamebox.Name = "registerusernamebox"
        Me.registerusernamebox.Size = New System.Drawing.Size(291, 31)
        Me.registerusernamebox.TabIndex = 8
        '
        'usernameID
        '
        Me.usernameID.AutoSize = True
        Me.usernameID.BackColor = System.Drawing.Color.Transparent
        Me.usernameID.Font = New System.Drawing.Font("Georgia", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.usernameID.Location = New System.Drawing.Point(321, 193)
        Me.usernameID.Name = "usernameID"
        Me.usernameID.Size = New System.Drawing.Size(66, 15)
        Me.usernameID.TabIndex = 7
        Me.usernameID.Text = "Username"
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 344)
        Me.Controls.Add(Me.btnregisteruser)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.passwordID)
        Me.Controls.Add(Me.registerpasswordbox)
        Me.Controls.Add(Me.registerusernamebox)
        Me.Controls.Add(Me.usernameID)
        Me.Name = "register"
        Me.Text = "register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnregisteruser As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents passwordID As Label
    Friend WithEvents registerpasswordbox As TextBox
    Friend WithEvents registerusernamebox As TextBox
    Friend WithEvents usernameID As Label
End Class
