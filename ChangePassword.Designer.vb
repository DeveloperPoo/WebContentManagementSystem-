<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Me.LBL_ChangePass = New System.Windows.Forms.Label()
        Me.LBL_CP_CrntPassword = New System.Windows.Forms.Label()
        Me.LBL_CP_NewPassword = New System.Windows.Forms.Label()
        Me.LBL_CP_ConfirmPassword = New System.Windows.Forms.Label()
        Me.TB_currentPassword = New System.Windows.Forms.TextBox()
        Me.TB_newPassword = New System.Windows.Forms.TextBox()
        Me.tb_conformPassword = New System.Windows.Forms.TextBox()
        Me.BTN_CP_Submit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_ChangePass
        '
        Me.LBL_ChangePass.AutoSize = True
        Me.LBL_ChangePass.BackColor = System.Drawing.Color.Black
        Me.LBL_ChangePass.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ChangePass.ForeColor = System.Drawing.Color.Yellow
        Me.LBL_ChangePass.Location = New System.Drawing.Point(122, 24)
        Me.LBL_ChangePass.Name = "LBL_ChangePass"
        Me.LBL_ChangePass.Size = New System.Drawing.Size(276, 30)
        Me.LBL_ChangePass.TabIndex = 1
        Me.LBL_ChangePass.Text = "Change Password"
        '
        'LBL_CP_CrntPassword
        '
        Me.LBL_CP_CrntPassword.AutoSize = True
        Me.LBL_CP_CrntPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CP_CrntPassword.ForeColor = System.Drawing.Color.White
        Me.LBL_CP_CrntPassword.Location = New System.Drawing.Point(86, 126)
        Me.LBL_CP_CrntPassword.Name = "LBL_CP_CrntPassword"
        Me.LBL_CP_CrntPassword.Size = New System.Drawing.Size(136, 18)
        Me.LBL_CP_CrntPassword.TabIndex = 2
        Me.LBL_CP_CrntPassword.Text = "Current Password :"
        '
        'LBL_CP_NewPassword
        '
        Me.LBL_CP_NewPassword.AutoSize = True
        Me.LBL_CP_NewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CP_NewPassword.ForeColor = System.Drawing.Color.White
        Me.LBL_CP_NewPassword.Location = New System.Drawing.Point(86, 178)
        Me.LBL_CP_NewPassword.Name = "LBL_CP_NewPassword"
        Me.LBL_CP_NewPassword.Size = New System.Drawing.Size(117, 18)
        Me.LBL_CP_NewPassword.TabIndex = 3
        Me.LBL_CP_NewPassword.Text = "New Password :"
        '
        'LBL_CP_ConfirmPassword
        '
        Me.LBL_CP_ConfirmPassword.AutoSize = True
        Me.LBL_CP_ConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CP_ConfirmPassword.ForeColor = System.Drawing.Color.White
        Me.LBL_CP_ConfirmPassword.Location = New System.Drawing.Point(86, 231)
        Me.LBL_CP_ConfirmPassword.Name = "LBL_CP_ConfirmPassword"
        Me.LBL_CP_ConfirmPassword.Size = New System.Drawing.Size(140, 18)
        Me.LBL_CP_ConfirmPassword.TabIndex = 4
        Me.LBL_CP_ConfirmPassword.Text = "Confirm Password :"
        '
        'TB_currentPassword
        '
        Me.TB_currentPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_currentPassword.ForeColor = System.Drawing.Color.Black
        Me.TB_currentPassword.Location = New System.Drawing.Point(230, 123)
        Me.TB_currentPassword.Name = "TB_currentPassword"
        Me.TB_currentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_currentPassword.Size = New System.Drawing.Size(210, 24)
        Me.TB_currentPassword.TabIndex = 5
        '
        'TB_newPassword
        '
        Me.TB_newPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_newPassword.ForeColor = System.Drawing.Color.Black
        Me.TB_newPassword.Location = New System.Drawing.Point(230, 175)
        Me.TB_newPassword.Name = "TB_newPassword"
        Me.TB_newPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_newPassword.Size = New System.Drawing.Size(210, 24)
        Me.TB_newPassword.TabIndex = 6
        '
        'tb_conformPassword
        '
        Me.tb_conformPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_conformPassword.ForeColor = System.Drawing.Color.Black
        Me.tb_conformPassword.Location = New System.Drawing.Point(230, 228)
        Me.tb_conformPassword.Name = "tb_conformPassword"
        Me.tb_conformPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_conformPassword.Size = New System.Drawing.Size(210, 24)
        Me.tb_conformPassword.TabIndex = 7
        '
        'BTN_CP_Submit
        '
        Me.BTN_CP_Submit.BackColor = System.Drawing.Color.Yellow
        Me.BTN_CP_Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CP_Submit.Location = New System.Drawing.Point(348, 286)
        Me.BTN_CP_Submit.Name = "BTN_CP_Submit"
        Me.BTN_CP_Submit.Size = New System.Drawing.Size(92, 32)
        Me.BTN_CP_Submit.TabIndex = 8
        Me.BTN_CP_Submit.Text = "Submit"
        Me.BTN_CP_Submit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LBL_ChangePass)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 73)
        Me.Panel1.TabIndex = 9
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(515, 359)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_CP_Submit)
        Me.Controls.Add(Me.tb_conformPassword)
        Me.Controls.Add(Me.TB_newPassword)
        Me.Controls.Add(Me.TB_currentPassword)
        Me.Controls.Add(Me.LBL_CP_ConfirmPassword)
        Me.Controls.Add(Me.LBL_CP_NewPassword)
        Me.Controls.Add(Me.LBL_CP_CrntPassword)
        Me.Name = "ChangePassword"
        Me.Text = "ChangePassword"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_ChangePass As Label
    Friend WithEvents LBL_CP_CrntPassword As Label
    Friend WithEvents LBL_CP_NewPassword As Label
    Friend WithEvents LBL_CP_ConfirmPassword As Label
    Friend WithEvents TB_currentPassword As TextBox
    Friend WithEvents TB_newPassword As TextBox
    Friend WithEvents tb_conformPassword As TextBox
    Friend WithEvents BTN_CP_Submit As Button
    Friend WithEvents Panel1 As Panel
End Class
