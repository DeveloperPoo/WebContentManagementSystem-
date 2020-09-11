<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewAdmin
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
        Me.LBL_AdminLogin = New System.Windows.Forms.Label()
        Me.LBL_AL_FirstName = New System.Windows.Forms.Label()
        Me.LBL_AL_Lastname = New System.Windows.Forms.Label()
        Me.LBL_AL_DOB = New System.Windows.Forms.Label()
        Me.LBL_AL_Address = New System.Windows.Forms.Label()
        Me.LBL_AL_City = New System.Windows.Forms.Label()
        Me.LBL_AL_Province = New System.Windows.Forms.Label()
        Me.LBL_AL_PostalCode = New System.Windows.Forms.Label()
        Me.LBL_AL_Homephone = New System.Windows.Forms.Label()
        Me.TB_AL_Firstname = New System.Windows.Forms.TextBox()
        Me.TB_AL_Lastname = New System.Windows.Forms.TextBox()
        Me.TB_AL_Address = New System.Windows.Forms.TextBox()
        Me.TB_AL_City = New System.Windows.Forms.TextBox()
        Me.TB_AL_Province = New System.Windows.Forms.TextBox()
        Me.TB_AL_Login = New System.Windows.Forms.Button()
        Me.DTP_AL_DOB = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TB_AL_Education = New System.Windows.Forms.TextBox()
        Me.TB_AL_Hourlypay = New System.Windows.Forms.TextBox()
        Me.LBL_AL_education = New System.Windows.Forms.Label()
        Me.LBL_AL_hourlypay = New System.Windows.Forms.Label()
        Me.LBL_AL_sin = New System.Windows.Forms.Label()
        Me.LBL_AL_startdate = New System.Windows.Forms.Label()
        Me.LBL_AL_cellphone = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TB_AL_Postalcode = New System.Windows.Forms.MaskedTextBox()
        Me.TB_AL_Homephone = New System.Windows.Forms.MaskedTextBox()
        Me.TB_AL_Cellphone = New System.Windows.Forms.MaskedTextBox()
        Me.TB_AL_Sin = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_AdminLogin
        '
        Me.LBL_AdminLogin.AutoSize = True
        Me.LBL_AdminLogin.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AdminLogin.ForeColor = System.Drawing.Color.Yellow
        Me.LBL_AdminLogin.Location = New System.Drawing.Point(137, 22)
        Me.LBL_AdminLogin.Name = "LBL_AdminLogin"
        Me.LBL_AdminLogin.Size = New System.Drawing.Size(171, 30)
        Me.LBL_AdminLogin.TabIndex = 9
        Me.LBL_AdminLogin.Text = "New Admin "
        '
        'LBL_AL_FirstName
        '
        Me.LBL_AL_FirstName.AutoSize = True
        Me.LBL_AL_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AL_FirstName.ForeColor = System.Drawing.Color.White
        Me.LBL_AL_FirstName.Location = New System.Drawing.Point(47, 122)
        Me.LBL_AL_FirstName.Name = "LBL_AL_FirstName"
        Me.LBL_AL_FirstName.Size = New System.Drawing.Size(82, 18)
        Me.LBL_AL_FirstName.TabIndex = 10
        Me.LBL_AL_FirstName.Text = "Firstname :"
        '
        'LBL_AL_Lastname
        '
        Me.LBL_AL_Lastname.AutoSize = True
        Me.LBL_AL_Lastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AL_Lastname.ForeColor = System.Drawing.Color.White
        Me.LBL_AL_Lastname.Location = New System.Drawing.Point(47, 168)
        Me.LBL_AL_Lastname.Name = "LBL_AL_Lastname"
        Me.LBL_AL_Lastname.Size = New System.Drawing.Size(81, 18)
        Me.LBL_AL_Lastname.TabIndex = 11
        Me.LBL_AL_Lastname.Text = "Lastname :"
        '
        'LBL_AL_DOB
        '
        Me.LBL_AL_DOB.AutoSize = True
        Me.LBL_AL_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AL_DOB.ForeColor = System.Drawing.Color.White
        Me.LBL_AL_DOB.Location = New System.Drawing.Point(47, 213)
        Me.LBL_AL_DOB.Name = "LBL_AL_DOB"
        Me.LBL_AL_DOB.Size = New System.Drawing.Size(98, 18)
        Me.LBL_AL_DOB.TabIndex = 12
        Me.LBL_AL_DOB.Text = "Date of Birth :"
        '
        'LBL_AL_Address
        '
        Me.LBL_AL_Address.AutoSize = True
        Me.LBL_AL_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AL_Address.ForeColor = System.Drawing.Color.White
        Me.LBL_AL_Address.Location = New System.Drawing.Point(47, 256)
        Me.LBL_AL_Address.Name = "LBL_AL_Address"
        Me.LBL_AL_Address.Size = New System.Drawing.Size(70, 18)
        Me.LBL_AL_Address.TabIndex = 13
        Me.LBL_AL_Address.Text = "Address :"
        '
        'LBL_AL_City
        '
        Me.LBL_AL_City.AutoSize = True
        Me.LBL_AL_City.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AL_City.ForeColor = System.Drawing.Color.White
        Me.LBL_AL_City.Location = New System.Drawing.Point(47, 302)
        Me.LBL_AL_City.Name = "LBL_AL_City"
        Me.LBL_AL_City.Size = New System.Drawing.Size(41, 18)
        Me.LBL_AL_City.TabIndex = 14
        Me.LBL_AL_City.Text = "City :"
        '
        'LBL_AL_Province
        '
        Me.LBL_AL_Province.AutoSize = True
        Me.LBL_AL_Province.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AL_Province.ForeColor = System.Drawing.Color.White
        Me.LBL_AL_Province.Location = New System.Drawing.Point(47, 344)
        Me.LBL_AL_Province.Name = "LBL_AL_Province"
        Me.LBL_AL_Province.Size = New System.Drawing.Size(74, 18)
        Me.LBL_AL_Province.TabIndex = 15
        Me.LBL_AL_Province.Text = "Province :"
        '
        'LBL_AL_PostalCode
        '
        Me.LBL_AL_PostalCode.AutoSize = True
        Me.LBL_AL_PostalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AL_PostalCode.ForeColor = System.Drawing.Color.White
        Me.LBL_AL_PostalCode.Location = New System.Drawing.Point(47, 388)
        Me.LBL_AL_PostalCode.Name = "LBL_AL_PostalCode"
        Me.LBL_AL_PostalCode.Size = New System.Drawing.Size(98, 18)
        Me.LBL_AL_PostalCode.TabIndex = 16
        Me.LBL_AL_PostalCode.Text = "Postal Code :"
        '
        'LBL_AL_Homephone
        '
        Me.LBL_AL_Homephone.AutoSize = True
        Me.LBL_AL_Homephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AL_Homephone.ForeColor = System.Drawing.Color.White
        Me.LBL_AL_Homephone.Location = New System.Drawing.Point(47, 438)
        Me.LBL_AL_Homephone.Name = "LBL_AL_Homephone"
        Me.LBL_AL_Homephone.Size = New System.Drawing.Size(98, 18)
        Me.LBL_AL_Homephone.TabIndex = 17
        Me.LBL_AL_Homephone.Text = "Homephone :"
        '
        'TB_AL_Firstname
        '
        Me.TB_AL_Firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AL_Firstname.ForeColor = System.Drawing.Color.Black
        Me.TB_AL_Firstname.Location = New System.Drawing.Point(151, 119)
        Me.TB_AL_Firstname.Name = "TB_AL_Firstname"
        Me.TB_AL_Firstname.Size = New System.Drawing.Size(240, 24)
        Me.TB_AL_Firstname.TabIndex = 18
        '
        'TB_AL_Lastname
        '
        Me.TB_AL_Lastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AL_Lastname.ForeColor = System.Drawing.Color.Black
        Me.TB_AL_Lastname.Location = New System.Drawing.Point(151, 165)
        Me.TB_AL_Lastname.Name = "TB_AL_Lastname"
        Me.TB_AL_Lastname.Size = New System.Drawing.Size(240, 24)
        Me.TB_AL_Lastname.TabIndex = 19
        '
        'TB_AL_Address
        '
        Me.TB_AL_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AL_Address.ForeColor = System.Drawing.Color.Black
        Me.TB_AL_Address.Location = New System.Drawing.Point(151, 253)
        Me.TB_AL_Address.Name = "TB_AL_Address"
        Me.TB_AL_Address.Size = New System.Drawing.Size(240, 24)
        Me.TB_AL_Address.TabIndex = 20
        '
        'TB_AL_City
        '
        Me.TB_AL_City.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AL_City.ForeColor = System.Drawing.Color.Black
        Me.TB_AL_City.Location = New System.Drawing.Point(151, 299)
        Me.TB_AL_City.Name = "TB_AL_City"
        Me.TB_AL_City.Size = New System.Drawing.Size(240, 24)
        Me.TB_AL_City.TabIndex = 21
        '
        'TB_AL_Province
        '
        Me.TB_AL_Province.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AL_Province.ForeColor = System.Drawing.Color.Black
        Me.TB_AL_Province.Location = New System.Drawing.Point(151, 341)
        Me.TB_AL_Province.Name = "TB_AL_Province"
        Me.TB_AL_Province.Size = New System.Drawing.Size(240, 24)
        Me.TB_AL_Province.TabIndex = 22
        '
        'TB_AL_Login
        '
        Me.TB_AL_Login.BackColor = System.Drawing.Color.Yellow
        Me.TB_AL_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AL_Login.Location = New System.Drawing.Point(299, 726)
        Me.TB_AL_Login.Name = "TB_AL_Login"
        Me.TB_AL_Login.Size = New System.Drawing.Size(92, 32)
        Me.TB_AL_Login.TabIndex = 25
        Me.TB_AL_Login.Text = "Login"
        Me.TB_AL_Login.UseVisualStyleBackColor = False
        '
        'DTP_AL_DOB
        '
        Me.DTP_AL_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_AL_DOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_AL_DOB.Location = New System.Drawing.Point(151, 208)
        Me.DTP_AL_DOB.Name = "DTP_AL_DOB"
        Me.DTP_AL_DOB.Size = New System.Drawing.Size(240, 24)
        Me.DTP_AL_DOB.TabIndex = 26
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(151, 531)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(240, 24)
        Me.DateTimePicker2.TabIndex = 42
        '
        'TB_AL_Education
        '
        Me.TB_AL_Education.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AL_Education.ForeColor = System.Drawing.Color.Black
        Me.TB_AL_Education.Location = New System.Drawing.Point(151, 672)
        Me.TB_AL_Education.Name = "TB_AL_Education"
        Me.TB_AL_Education.Size = New System.Drawing.Size(240, 24)
        Me.TB_AL_Education.TabIndex = 39
        '
        'TB_AL_Hourlypay
        '
        Me.TB_AL_Hourlypay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AL_Hourlypay.ForeColor = System.Drawing.Color.Black
        Me.TB_AL_Hourlypay.Location = New System.Drawing.Point(151, 622)
        Me.TB_AL_Hourlypay.Name = "TB_AL_Hourlypay"
        Me.TB_AL_Hourlypay.Size = New System.Drawing.Size(240, 24)
        Me.TB_AL_Hourlypay.TabIndex = 38
        '
        'LBL_AL_education
        '
        Me.LBL_AL_education.AutoSize = True
        Me.LBL_AL_education.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AL_education.ForeColor = System.Drawing.Color.White
        Me.LBL_AL_education.Location = New System.Drawing.Point(46, 675)
        Me.LBL_AL_education.Name = "LBL_AL_education"
        Me.LBL_AL_education.Size = New System.Drawing.Size(82, 18)
        Me.LBL_AL_education.TabIndex = 32
        Me.LBL_AL_education.Text = "Education :"
        '
        'LBL_AL_hourlypay
        '
        Me.LBL_AL_hourlypay.AutoSize = True
        Me.LBL_AL_hourlypay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AL_hourlypay.ForeColor = System.Drawing.Color.White
        Me.LBL_AL_hourlypay.Location = New System.Drawing.Point(45, 625)
        Me.LBL_AL_hourlypay.Name = "LBL_AL_hourlypay"
        Me.LBL_AL_hourlypay.Size = New System.Drawing.Size(84, 18)
        Me.LBL_AL_hourlypay.TabIndex = 31
        Me.LBL_AL_hourlypay.Text = "HourlyPay :"
        '
        'LBL_AL_sin
        '
        Me.LBL_AL_sin.AutoSize = True
        Me.LBL_AL_sin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AL_sin.ForeColor = System.Drawing.Color.White
        Me.LBL_AL_sin.Location = New System.Drawing.Point(46, 581)
        Me.LBL_AL_sin.Name = "LBL_AL_sin"
        Me.LBL_AL_sin.Size = New System.Drawing.Size(37, 18)
        Me.LBL_AL_sin.TabIndex = 30
        Me.LBL_AL_sin.Text = "Sin :"
        '
        'LBL_AL_startdate
        '
        Me.LBL_AL_startdate.AutoSize = True
        Me.LBL_AL_startdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AL_startdate.ForeColor = System.Drawing.Color.White
        Me.LBL_AL_startdate.Location = New System.Drawing.Point(42, 536)
        Me.LBL_AL_startdate.Name = "LBL_AL_startdate"
        Me.LBL_AL_startdate.Size = New System.Drawing.Size(86, 18)
        Me.LBL_AL_startdate.TabIndex = 29
        Me.LBL_AL_startdate.Text = " Start Date :"
        '
        'LBL_AL_cellphone
        '
        Me.LBL_AL_cellphone.AutoSize = True
        Me.LBL_AL_cellphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AL_cellphone.ForeColor = System.Drawing.Color.White
        Me.LBL_AL_cellphone.Location = New System.Drawing.Point(48, 488)
        Me.LBL_AL_cellphone.Name = "LBL_AL_cellphone"
        Me.LBL_AL_cellphone.Size = New System.Drawing.Size(82, 18)
        Me.LBL_AL_cellphone.TabIndex = 27
        Me.LBL_AL_cellphone.Text = "Cellphone :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LBL_AdminLogin)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 78)
        Me.Panel1.TabIndex = 43
        '
        'TB_AL_Postalcode
        '
        Me.TB_AL_Postalcode.Location = New System.Drawing.Point(151, 389)
        Me.TB_AL_Postalcode.Mask = "?0? 0?0"
        Me.TB_AL_Postalcode.Name = "TB_AL_Postalcode"
        Me.TB_AL_Postalcode.Size = New System.Drawing.Size(240, 20)
        Me.TB_AL_Postalcode.TabIndex = 44
        '
        'TB_AL_Homephone
        '
        Me.TB_AL_Homephone.Location = New System.Drawing.Point(151, 436)
        Me.TB_AL_Homephone.Mask = "999-999-9999"
        Me.TB_AL_Homephone.Name = "TB_AL_Homephone"
        Me.TB_AL_Homephone.Size = New System.Drawing.Size(240, 20)
        Me.TB_AL_Homephone.TabIndex = 45
        '
        'TB_AL_Cellphone
        '
        Me.TB_AL_Cellphone.Location = New System.Drawing.Point(151, 487)
        Me.TB_AL_Cellphone.Mask = "999-999-9999"
        Me.TB_AL_Cellphone.Name = "TB_AL_Cellphone"
        Me.TB_AL_Cellphone.Size = New System.Drawing.Size(240, 20)
        Me.TB_AL_Cellphone.TabIndex = 46
        '
        'TB_AL_Sin
        '
        Me.TB_AL_Sin.Location = New System.Drawing.Point(151, 578)
        Me.TB_AL_Sin.Mask = "999-999-999"
        Me.TB_AL_Sin.Name = "TB_AL_Sin"
        Me.TB_AL_Sin.Size = New System.Drawing.Size(240, 20)
        Me.TB_AL_Sin.TabIndex = 47
        '
        'NewAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(458, 782)
        Me.Controls.Add(Me.TB_AL_Sin)
        Me.Controls.Add(Me.TB_AL_Cellphone)
        Me.Controls.Add(Me.TB_AL_Homephone)
        Me.Controls.Add(Me.TB_AL_Postalcode)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.TB_AL_Education)
        Me.Controls.Add(Me.TB_AL_Hourlypay)
        Me.Controls.Add(Me.LBL_AL_education)
        Me.Controls.Add(Me.LBL_AL_hourlypay)
        Me.Controls.Add(Me.LBL_AL_sin)
        Me.Controls.Add(Me.LBL_AL_startdate)
        Me.Controls.Add(Me.LBL_AL_cellphone)
        Me.Controls.Add(Me.DTP_AL_DOB)
        Me.Controls.Add(Me.TB_AL_Login)
        Me.Controls.Add(Me.TB_AL_Province)
        Me.Controls.Add(Me.TB_AL_City)
        Me.Controls.Add(Me.TB_AL_Address)
        Me.Controls.Add(Me.TB_AL_Lastname)
        Me.Controls.Add(Me.TB_AL_Firstname)
        Me.Controls.Add(Me.LBL_AL_Homephone)
        Me.Controls.Add(Me.LBL_AL_PostalCode)
        Me.Controls.Add(Me.LBL_AL_Province)
        Me.Controls.Add(Me.LBL_AL_City)
        Me.Controls.Add(Me.LBL_AL_Address)
        Me.Controls.Add(Me.LBL_AL_DOB)
        Me.Controls.Add(Me.LBL_AL_Lastname)
        Me.Controls.Add(Me.LBL_AL_FirstName)
        Me.Name = "NewAdmin"
        Me.Text = "InstallationWizaed1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_AdminLogin As Label
    Friend WithEvents LBL_AL_FirstName As Label
    Friend WithEvents LBL_AL_Lastname As Label
    Friend WithEvents LBL_AL_DOB As Label
    Friend WithEvents LBL_AL_Address As Label
    Friend WithEvents LBL_AL_City As Label
    Friend WithEvents LBL_AL_Province As Label
    Friend WithEvents LBL_AL_PostalCode As Label
    Friend WithEvents LBL_AL_Homephone As Label
    Friend WithEvents TB_AL_Firstname As TextBox
    Friend WithEvents TB_AL_Lastname As TextBox
    Friend WithEvents TB_AL_Address As TextBox
    Friend WithEvents TB_AL_City As TextBox
    Friend WithEvents TB_AL_Province As TextBox
    Friend WithEvents TB_AL_Login As Button
    Friend WithEvents DTP_AL_DOB As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents TB_AL_Education As TextBox
    Friend WithEvents TB_AL_Hourlypay As TextBox
    Friend WithEvents LBL_AL_education As Label
    Friend WithEvents LBL_AL_hourlypay As Label
    Friend WithEvents LBL_AL_sin As Label
    Friend WithEvents LBL_AL_startdate As Label
    Friend WithEvents LBL_AL_cellphone As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TB_AL_Postalcode As MaskedTextBox
    Friend WithEvents TB_AL_Homephone As MaskedTextBox
    Friend WithEvents TB_AL_Cellphone As MaskedTextBox
    Friend WithEvents TB_AL_Sin As MaskedTextBox
End Class
