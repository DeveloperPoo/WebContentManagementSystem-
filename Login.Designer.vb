<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.LBL_Login_username = New System.Windows.Forms.Label()
        Me.LBL_login_password = New System.Windows.Forms.Label()
        Me.TB_login_username = New System.Windows.Forms.TextBox()
        Me.TB_login_password = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_Login
        '
        Me.LBL_Login.AutoSize = True
        Me.LBL_Login.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Login.ForeColor = System.Drawing.Color.Yellow
        Me.LBL_Login.Location = New System.Drawing.Point(156, 8)
        Me.LBL_Login.Name = "LBL_Login"
        Me.LBL_Login.Size = New System.Drawing.Size(92, 30)
        Me.LBL_Login.TabIndex = 0
        Me.LBL_Login.Text = "Login"
        '
        'LBL_Login_username
        '
        Me.LBL_Login_username.AutoSize = True
        Me.LBL_Login_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Login_username.ForeColor = System.Drawing.Color.White
        Me.LBL_Login_username.Location = New System.Drawing.Point(53, 106)
        Me.LBL_Login_username.Name = "LBL_Login_username"
        Me.LBL_Login_username.Size = New System.Drawing.Size(85, 18)
        Me.LBL_Login_username.TabIndex = 1
        Me.LBL_Login_username.Text = "Username :"
        '
        'LBL_login_password
        '
        Me.LBL_login_password.AutoSize = True
        Me.LBL_login_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_login_password.ForeColor = System.Drawing.Color.White
        Me.LBL_login_password.Location = New System.Drawing.Point(53, 159)
        Me.LBL_login_password.Name = "LBL_login_password"
        Me.LBL_login_password.Size = New System.Drawing.Size(87, 18)
        Me.LBL_login_password.TabIndex = 2
        Me.LBL_login_password.Text = "Password  :"
        '
        'TB_login_username
        '
        Me.TB_login_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_login_username.ForeColor = System.Drawing.Color.Black
        Me.TB_login_username.Location = New System.Drawing.Point(147, 106)
        Me.TB_login_username.Name = "TB_login_username"
        Me.TB_login_username.Size = New System.Drawing.Size(213, 24)
        Me.TB_login_username.TabIndex = 3
        '
        'TB_login_password
        '
        Me.TB_login_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_login_password.ForeColor = System.Drawing.Color.Black
        Me.TB_login_password.Location = New System.Drawing.Point(147, 157)
        Me.TB_login_password.Name = "TB_login_password"
        Me.TB_login_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_login_password.Size = New System.Drawing.Size(213, 24)
        Me.TB_login_password.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(265, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 32)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Yellow
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(419, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitApplicationToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitApplicationToolStripMenuItem
        '
        Me.ExitApplicationToolStripMenuItem.Name = "ExitApplicationToolStripMenuItem"
        Me.ExitApplicationToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ExitApplicationToolStripMenuItem.Text = "Exit Application"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LBL_Login)
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(419, 48)
        Me.Panel1.TabIndex = 7
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(419, 275)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TB_login_password)
        Me.Controls.Add(Me.TB_login_username)
        Me.Controls.Add(Me.LBL_login_password)
        Me.Controls.Add(Me.LBL_Login_username)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Login"
        Me.Text = "Login"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_Login As Label
    Friend WithEvents LBL_Login_username As Label
    Friend WithEvents LBL_login_password As Label
    Friend WithEvents TB_login_username As TextBox
    Friend WithEvents TB_login_password As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
End Class
