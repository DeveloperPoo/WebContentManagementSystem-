<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstallationWizard
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
        Me.LBL_Login = New System.Windows.Forms.Label()
        Me.BTN_AL_Submit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_cpswrd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_uname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_pswrd = New System.Windows.Forms.TextBox()
        Me.PNL_Loginadmin = New System.Windows.Forms.Panel()
        Me.login_admin = New System.Windows.Forms.Button()
        Me.PNL_admin_login = New System.Windows.Forms.Panel()
        Me.PNL_Loginadmin.SuspendLayout()
        Me.PNL_admin_login.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_Login
        '
        Me.LBL_Login.AutoSize = True
        Me.LBL_Login.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Login.ForeColor = System.Drawing.Color.Yellow
        Me.LBL_Login.Location = New System.Drawing.Point(149, 23)
        Me.LBL_Login.Name = "LBL_Login"
        Me.LBL_Login.Size = New System.Drawing.Size(223, 30)
        Me.LBL_Login.TabIndex = 8
        Me.LBL_Login.Text = "Create Admin "
        '
        'BTN_AL_Submit
        '
        Me.BTN_AL_Submit.BackColor = System.Drawing.Color.Yellow
        Me.BTN_AL_Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AL_Submit.Location = New System.Drawing.Point(362, 232)
        Me.BTN_AL_Submit.Name = "BTN_AL_Submit"
        Me.BTN_AL_Submit.Size = New System.Drawing.Size(92, 32)
        Me.BTN_AL_Submit.TabIndex = 9
        Me.BTN_AL_Submit.Text = "Submit"
        Me.BTN_AL_Submit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(68, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username :"
        '
        'TB_cpswrd
        '
        Me.TB_cpswrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_cpswrd.ForeColor = System.Drawing.Color.Black
        Me.TB_cpswrd.Location = New System.Drawing.Point(206, 184)
        Me.TB_cpswrd.Name = "TB_cpswrd"
        Me.TB_cpswrd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_cpswrd.Size = New System.Drawing.Size(248, 24)
        Me.TB_cpswrd.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(66, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Confirm password :"
        '
        'TB_uname
        '
        Me.TB_uname.Enabled = False
        Me.TB_uname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_uname.ForeColor = System.Drawing.Color.Black
        Me.TB_uname.Location = New System.Drawing.Point(206, 83)
        Me.TB_uname.Name = "TB_uname"
        Me.TB_uname.Size = New System.Drawing.Size(248, 24)
        Me.TB_uname.TabIndex = 3
        Me.TB_uname.Text = "admin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(68, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password :"
        '
        'TB_pswrd
        '
        Me.TB_pswrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_pswrd.ForeColor = System.Drawing.Color.Black
        Me.TB_pswrd.Location = New System.Drawing.Point(206, 133)
        Me.TB_pswrd.Name = "TB_pswrd"
        Me.TB_pswrd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_pswrd.Size = New System.Drawing.Size(248, 24)
        Me.TB_pswrd.TabIndex = 4
        '
        'PNL_Loginadmin
        '
        Me.PNL_Loginadmin.BackColor = System.Drawing.Color.Black
        Me.PNL_Loginadmin.Controls.Add(Me.login_admin)
        Me.PNL_Loginadmin.Location = New System.Drawing.Point(13, 12)
        Me.PNL_Loginadmin.Name = "PNL_Loginadmin"
        Me.PNL_Loginadmin.Size = New System.Drawing.Size(521, 69)
        Me.PNL_Loginadmin.TabIndex = 13
        '
        'login_admin
        '
        Me.login_admin.BackColor = System.Drawing.Color.Yellow
        Me.login_admin.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_admin.Location = New System.Drawing.Point(142, 12)
        Me.login_admin.Name = "login_admin"
        Me.login_admin.Size = New System.Drawing.Size(216, 46)
        Me.login_admin.TabIndex = 0
        Me.login_admin.Text = "Go To Login Page"
        Me.login_admin.UseVisualStyleBackColor = False
        '
        'PNL_admin_login
        '
        Me.PNL_admin_login.BackColor = System.Drawing.Color.Black
        Me.PNL_admin_login.Controls.Add(Me.LBL_Login)
        Me.PNL_admin_login.Controls.Add(Me.BTN_AL_Submit)
        Me.PNL_admin_login.Controls.Add(Me.Label2)
        Me.PNL_admin_login.Controls.Add(Me.TB_cpswrd)
        Me.PNL_admin_login.Controls.Add(Me.Label4)
        Me.PNL_admin_login.Controls.Add(Me.TB_uname)
        Me.PNL_admin_login.Controls.Add(Me.Label3)
        Me.PNL_admin_login.Controls.Add(Me.TB_pswrd)
        Me.PNL_admin_login.Location = New System.Drawing.Point(13, 87)
        Me.PNL_admin_login.Name = "PNL_admin_login"
        Me.PNL_admin_login.Size = New System.Drawing.Size(522, 301)
        Me.PNL_admin_login.TabIndex = 12
        '
        'InstallationWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(546, 400)
        Me.Controls.Add(Me.PNL_Loginadmin)
        Me.Controls.Add(Me.PNL_admin_login)
        Me.Name = "InstallationWizard"
        Me.Text = "InstallationWizard"
        Me.PNL_Loginadmin.ResumeLayout(False)
        Me.PNL_admin_login.ResumeLayout(False)
        Me.PNL_admin_login.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LBL_Login As Label
    Friend WithEvents BTN_AL_Submit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_cpswrd As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_uname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_pswrd As TextBox
    Friend WithEvents PNL_Loginadmin As Panel
    Friend WithEvents login_admin As Button
    Friend WithEvents PNL_admin_login As Panel
End Class
