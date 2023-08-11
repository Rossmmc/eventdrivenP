<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.usernameID = New System.Windows.Forms.Label()
        Me.usernamebox = New System.Windows.Forms.TextBox()
        Me.passwordbox = New System.Windows.Forms.TextBox()
        Me.passwordID = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.registerbtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginbtn
        '
        Me.loginbtn.Font = New System.Drawing.Font("Georgia", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.loginbtn.Location = New System.Drawing.Point(293, 285)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(104, 28)
        Me.loginbtn.TabIndex = 0
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = True
        '
        'usernameID
        '
        Me.usernameID.AutoSize = True
        Me.usernameID.BackColor = System.Drawing.Color.Transparent
        Me.usernameID.Font = New System.Drawing.Font("Georgia", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.usernameID.Location = New System.Drawing.Point(485, 189)
        Me.usernameID.Name = "usernameID"
        Me.usernameID.Size = New System.Drawing.Size(66, 15)
        Me.usernameID.TabIndex = 1
        Me.usernameID.Text = "Username"
        '
        'usernamebox
        '
        Me.usernamebox.Font = New System.Drawing.Font("Georgia", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.usernamebox.Location = New System.Drawing.Point(188, 184)
        Me.usernamebox.Multiline = True
        Me.usernamebox.Name = "usernamebox"
        Me.usernamebox.Size = New System.Drawing.Size(291, 31)
        Me.usernamebox.TabIndex = 2
        '
        'passwordbox
        '
        Me.passwordbox.Font = New System.Drawing.Font("Georgia", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.passwordbox.Location = New System.Drawing.Point(188, 227)
        Me.passwordbox.Multiline = True
        Me.passwordbox.Name = "passwordbox"
        Me.passwordbox.Size = New System.Drawing.Size(291, 31)
        Me.passwordbox.TabIndex = 3
        '
        'passwordID
        '
        Me.passwordID.AutoSize = True
        Me.passwordID.BackColor = System.Drawing.Color.Transparent
        Me.passwordID.Font = New System.Drawing.Font("Georgia", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.passwordID.Location = New System.Drawing.Point(485, 232)
        Me.passwordID.Name = "passwordID"
        Me.passwordID.Size = New System.Drawing.Size(60, 15)
        Me.passwordID.TabIndex = 4
        Me.passwordID.Text = "Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.midtermedp.My.Resources.Resources._12
        Me.PictureBox1.Location = New System.Drawing.Point(273, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 99)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'registerbtn
        '
        Me.registerbtn.Font = New System.Drawing.Font("Georgia", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.registerbtn.Location = New System.Drawing.Point(293, 319)
        Me.registerbtn.Name = "registerbtn"
        Me.registerbtn.Size = New System.Drawing.Size(104, 28)
        Me.registerbtn.TabIndex = 6
        Me.registerbtn.Text = "Register"
        Me.registerbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.midtermedp.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(641, 405)
        Me.Controls.Add(Me.registerbtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.passwordID)
        Me.Controls.Add(Me.passwordbox)
        Me.Controls.Add(Me.usernamebox)
        Me.Controls.Add(Me.usernameID)
        Me.Controls.Add(Me.loginbtn)
        Me.Name = "Form1"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginbtn As Button
    Friend WithEvents usernameID As Label
    Friend WithEvents usernamebox As TextBox
    Friend WithEvents passwordbox As TextBox
    Friend WithEvents passwordID As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents registerbtn As Button
End Class
