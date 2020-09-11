<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUser
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
        Me.DTP_EU_StartDate = New System.Windows.Forms.DateTimePicker()
        Me.TB_EU_Education = New System.Windows.Forms.TextBox()
        Me.TB_EU_Hourlypay = New System.Windows.Forms.TextBox()
        Me.TB_EU_Sin = New System.Windows.Forms.TextBox()
        Me.TB_AU_Cellphone = New System.Windows.Forms.TextBox()
        Me.LBL_EU_education = New System.Windows.Forms.Label()
        Me.LBL_EU_hourlypay = New System.Windows.Forms.Label()
        Me.LBL_EU_sin = New System.Windows.Forms.Label()
        Me.LBL_EU_startdate = New System.Windows.Forms.Label()
        Me.LBL_EU_cellphone = New System.Windows.Forms.Label()
        Me.DTP_EU_DOB = New System.Windows.Forms.DateTimePicker()
        Me.BTN_EU_Edit = New System.Windows.Forms.Button()
        Me.TB_EU_Homephone = New System.Windows.Forms.TextBox()
        Me.TB_EU_Postalcode = New System.Windows.Forms.TextBox()
        Me.TB_EU_Province = New System.Windows.Forms.TextBox()
        Me.TB_EU_City = New System.Windows.Forms.TextBox()
        Me.TB_EU_Address = New System.Windows.Forms.TextBox()
        Me.TB_EU_Lastname = New System.Windows.Forms.TextBox()
        Me.TB_EU_Firstname = New System.Windows.Forms.TextBox()
        Me.LBL_EU_Homephone = New System.Windows.Forms.Label()
        Me.LBL_EU_PostalCode = New System.Windows.Forms.Label()
        Me.LBL_EU_Province = New System.Windows.Forms.Label()
        Me.LBL_EU_City = New System.Windows.Forms.Label()
        Me.LBL_EU_Address = New System.Windows.Forms.Label()
        Me.LBL_EU_DOB = New System.Windows.Forms.Label()
        Me.LBL_EU_Lastname = New System.Windows.Forms.Label()
        Me.LBL_EU_FirstName = New System.Windows.Forms.Label()
        Me.LBL_EditUser = New System.Windows.Forms.Label()
        Me.BTN_EU_Cancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DTP_EU_StartDate
        '
        Me.DTP_EU_StartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_EU_StartDate.Location = New System.Drawing.Point(139, 495)
        Me.DTP_EU_StartDate.Name = "DTP_EU_StartDate"
        Me.DTP_EU_StartDate.Size = New System.Drawing.Size(240, 22)
        Me.DTP_EU_StartDate.TabIndex = 70
        '
        'TB_EU_Education
        '
        Me.TB_EU_Education.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_EU_Education.ForeColor = System.Drawing.Color.Black
        Me.TB_EU_Education.Location = New System.Drawing.Point(139, 638)
        Me.TB_EU_Education.Name = "TB_EU_Education"
        Me.TB_EU_Education.Size = New System.Drawing.Size(240, 22)
        Me.TB_EU_Education.TabIndex = 69
        '
        'TB_EU_Hourlypay
        '
        Me.TB_EU_Hourlypay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_EU_Hourlypay.ForeColor = System.Drawing.Color.Black
        Me.TB_EU_Hourlypay.Location = New System.Drawing.Point(139, 588)
        Me.TB_EU_Hourlypay.Name = "TB_EU_Hourlypay"
        Me.TB_EU_Hourlypay.Size = New System.Drawing.Size(240, 22)
        Me.TB_EU_Hourlypay.TabIndex = 68
        '
        'TB_EU_Sin
        '
        Me.TB_EU_Sin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_EU_Sin.ForeColor = System.Drawing.Color.Black
        Me.TB_EU_Sin.Location = New System.Drawing.Point(139, 541)
        Me.TB_EU_Sin.Name = "TB_EU_Sin"
        Me.TB_EU_Sin.Size = New System.Drawing.Size(240, 22)
        Me.TB_EU_Sin.TabIndex = 67
        '
        'TB_AU_Cellphone
        '
        Me.TB_AU_Cellphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AU_Cellphone.ForeColor = System.Drawing.Color.Black
        Me.TB_AU_Cellphone.Location = New System.Drawing.Point(139, 447)
        Me.TB_AU_Cellphone.Name = "TB_AU_Cellphone"
        Me.TB_AU_Cellphone.Size = New System.Drawing.Size(240, 22)
        Me.TB_AU_Cellphone.TabIndex = 66
        '
        'LBL_EU_education
        '
        Me.LBL_EU_education.AutoSize = True
        Me.LBL_EU_education.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EU_education.ForeColor = System.Drawing.Color.White
        Me.LBL_EU_education.Location = New System.Drawing.Point(34, 638)
        Me.LBL_EU_education.Name = "LBL_EU_education"
        Me.LBL_EU_education.Size = New System.Drawing.Size(74, 16)
        Me.LBL_EU_education.TabIndex = 65
        Me.LBL_EU_education.Text = "Education :"
        '
        'LBL_EU_hourlypay
        '
        Me.LBL_EU_hourlypay.AutoSize = True
        Me.LBL_EU_hourlypay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EU_hourlypay.ForeColor = System.Drawing.Color.White
        Me.LBL_EU_hourlypay.Location = New System.Drawing.Point(33, 588)
        Me.LBL_EU_hourlypay.Name = "LBL_EU_hourlypay"
        Me.LBL_EU_hourlypay.Size = New System.Drawing.Size(77, 16)
        Me.LBL_EU_hourlypay.TabIndex = 64
        Me.LBL_EU_hourlypay.Text = "HourlyPay :"
        '
        'LBL_EU_sin
        '
        Me.LBL_EU_sin.AutoSize = True
        Me.LBL_EU_sin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EU_sin.ForeColor = System.Drawing.Color.White
        Me.LBL_EU_sin.Location = New System.Drawing.Point(34, 544)
        Me.LBL_EU_sin.Name = "LBL_EU_sin"
        Me.LBL_EU_sin.Size = New System.Drawing.Size(33, 16)
        Me.LBL_EU_sin.TabIndex = 63
        Me.LBL_EU_sin.Text = "Sin :"
        '
        'LBL_EU_startdate
        '
        Me.LBL_EU_startdate.AutoSize = True
        Me.LBL_EU_startdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EU_startdate.ForeColor = System.Drawing.Color.White
        Me.LBL_EU_startdate.Location = New System.Drawing.Point(30, 499)
        Me.LBL_EU_startdate.Name = "LBL_EU_startdate"
        Me.LBL_EU_startdate.Size = New System.Drawing.Size(76, 16)
        Me.LBL_EU_startdate.TabIndex = 62
        Me.LBL_EU_startdate.Text = " Start Date :"
        '
        'LBL_EU_cellphone
        '
        Me.LBL_EU_cellphone.AutoSize = True
        Me.LBL_EU_cellphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EU_cellphone.ForeColor = System.Drawing.Color.White
        Me.LBL_EU_cellphone.Location = New System.Drawing.Point(36, 451)
        Me.LBL_EU_cellphone.Name = "LBL_EU_cellphone"
        Me.LBL_EU_cellphone.Size = New System.Drawing.Size(75, 16)
        Me.LBL_EU_cellphone.TabIndex = 61
        Me.LBL_EU_cellphone.Text = "Cellphone :"
        '
        'DTP_EU_DOB
        '
        Me.DTP_EU_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_EU_DOB.Location = New System.Drawing.Point(139, 170)
        Me.DTP_EU_DOB.Name = "DTP_EU_DOB"
        Me.DTP_EU_DOB.Size = New System.Drawing.Size(240, 22)
        Me.DTP_EU_DOB.TabIndex = 60
        '
        'BTN_EU_Edit
        '
        Me.BTN_EU_Edit.BackColor = System.Drawing.Color.Yellow
        Me.BTN_EU_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EU_Edit.Location = New System.Drawing.Point(242, 691)
        Me.BTN_EU_Edit.Name = "BTN_EU_Edit"
        Me.BTN_EU_Edit.Size = New System.Drawing.Size(92, 32)
        Me.BTN_EU_Edit.TabIndex = 59
        Me.BTN_EU_Edit.Text = "Edit"
        Me.BTN_EU_Edit.UseVisualStyleBackColor = False
        '
        'TB_EU_Homephone
        '
        Me.TB_EU_Homephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_EU_Homephone.ForeColor = System.Drawing.Color.Black
        Me.TB_EU_Homephone.Location = New System.Drawing.Point(139, 398)
        Me.TB_EU_Homephone.Name = "TB_EU_Homephone"
        Me.TB_EU_Homephone.Size = New System.Drawing.Size(240, 22)
        Me.TB_EU_Homephone.TabIndex = 58
        '
        'TB_EU_Postalcode
        '
        Me.TB_EU_Postalcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_EU_Postalcode.ForeColor = System.Drawing.Color.Black
        Me.TB_EU_Postalcode.Location = New System.Drawing.Point(139, 348)
        Me.TB_EU_Postalcode.Name = "TB_EU_Postalcode"
        Me.TB_EU_Postalcode.Size = New System.Drawing.Size(240, 22)
        Me.TB_EU_Postalcode.TabIndex = 57
        '
        'TB_EU_Province
        '
        Me.TB_EU_Province.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_EU_Province.ForeColor = System.Drawing.Color.Black
        Me.TB_EU_Province.Location = New System.Drawing.Point(139, 304)
        Me.TB_EU_Province.Name = "TB_EU_Province"
        Me.TB_EU_Province.Size = New System.Drawing.Size(240, 22)
        Me.TB_EU_Province.TabIndex = 56
        '
        'TB_EU_City
        '
        Me.TB_EU_City.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_EU_City.ForeColor = System.Drawing.Color.Black
        Me.TB_EU_City.Location = New System.Drawing.Point(139, 262)
        Me.TB_EU_City.Name = "TB_EU_City"
        Me.TB_EU_City.Size = New System.Drawing.Size(240, 22)
        Me.TB_EU_City.TabIndex = 55
        '
        'TB_EU_Address
        '
        Me.TB_EU_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_EU_Address.ForeColor = System.Drawing.Color.Black
        Me.TB_EU_Address.Location = New System.Drawing.Point(139, 216)
        Me.TB_EU_Address.Name = "TB_EU_Address"
        Me.TB_EU_Address.Size = New System.Drawing.Size(240, 22)
        Me.TB_EU_Address.TabIndex = 54
        '
        'TB_EU_Lastname
        '
        Me.TB_EU_Lastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_EU_Lastname.ForeColor = System.Drawing.Color.Black
        Me.TB_EU_Lastname.Location = New System.Drawing.Point(139, 128)
        Me.TB_EU_Lastname.Name = "TB_EU_Lastname"
        Me.TB_EU_Lastname.Size = New System.Drawing.Size(240, 22)
        Me.TB_EU_Lastname.TabIndex = 53
        '
        'TB_EU_Firstname
        '
        Me.TB_EU_Firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_EU_Firstname.ForeColor = System.Drawing.Color.Black
        Me.TB_EU_Firstname.Location = New System.Drawing.Point(139, 82)
        Me.TB_EU_Firstname.Name = "TB_EU_Firstname"
        Me.TB_EU_Firstname.Size = New System.Drawing.Size(240, 22)
        Me.TB_EU_Firstname.TabIndex = 52
        '
        'LBL_EU_Homephone
        '
        Me.LBL_EU_Homephone.AutoSize = True
        Me.LBL_EU_Homephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EU_Homephone.ForeColor = System.Drawing.Color.White
        Me.LBL_EU_Homephone.Location = New System.Drawing.Point(35, 401)
        Me.LBL_EU_Homephone.Name = "LBL_EU_Homephone"
        Me.LBL_EU_Homephone.Size = New System.Drawing.Size(89, 16)
        Me.LBL_EU_Homephone.TabIndex = 51
        Me.LBL_EU_Homephone.Text = "Homephone :"
        '
        'LBL_EU_PostalCode
        '
        Me.LBL_EU_PostalCode.AutoSize = True
        Me.LBL_EU_PostalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EU_PostalCode.ForeColor = System.Drawing.Color.White
        Me.LBL_EU_PostalCode.Location = New System.Drawing.Point(35, 351)
        Me.LBL_EU_PostalCode.Name = "LBL_EU_PostalCode"
        Me.LBL_EU_PostalCode.Size = New System.Drawing.Size(88, 16)
        Me.LBL_EU_PostalCode.TabIndex = 50
        Me.LBL_EU_PostalCode.Text = "Postal Code :"
        '
        'LBL_EU_Province
        '
        Me.LBL_EU_Province.AutoSize = True
        Me.LBL_EU_Province.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EU_Province.ForeColor = System.Drawing.Color.White
        Me.LBL_EU_Province.Location = New System.Drawing.Point(35, 307)
        Me.LBL_EU_Province.Name = "LBL_EU_Province"
        Me.LBL_EU_Province.Size = New System.Drawing.Size(67, 16)
        Me.LBL_EU_Province.TabIndex = 49
        Me.LBL_EU_Province.Text = "Province :"
        '
        'LBL_EU_City
        '
        Me.LBL_EU_City.AutoSize = True
        Me.LBL_EU_City.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EU_City.ForeColor = System.Drawing.Color.White
        Me.LBL_EU_City.Location = New System.Drawing.Point(35, 265)
        Me.LBL_EU_City.Name = "LBL_EU_City"
        Me.LBL_EU_City.Size = New System.Drawing.Size(36, 16)
        Me.LBL_EU_City.TabIndex = 48
        Me.LBL_EU_City.Text = "City :"
        '
        'LBL_EU_Address
        '
        Me.LBL_EU_Address.AutoSize = True
        Me.LBL_EU_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EU_Address.ForeColor = System.Drawing.Color.White
        Me.LBL_EU_Address.Location = New System.Drawing.Point(35, 219)
        Me.LBL_EU_Address.Name = "LBL_EU_Address"
        Me.LBL_EU_Address.Size = New System.Drawing.Size(65, 16)
        Me.LBL_EU_Address.TabIndex = 47
        Me.LBL_EU_Address.Text = "Address :"
        '
        'LBL_EU_DOB
        '
        Me.LBL_EU_DOB.AutoSize = True
        Me.LBL_EU_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EU_DOB.ForeColor = System.Drawing.Color.White
        Me.LBL_EU_DOB.Location = New System.Drawing.Point(35, 176)
        Me.LBL_EU_DOB.Name = "LBL_EU_DOB"
        Me.LBL_EU_DOB.Size = New System.Drawing.Size(86, 16)
        Me.LBL_EU_DOB.TabIndex = 46
        Me.LBL_EU_DOB.Text = "Date of Birth :"
        '
        'LBL_EU_Lastname
        '
        Me.LBL_EU_Lastname.AutoSize = True
        Me.LBL_EU_Lastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EU_Lastname.ForeColor = System.Drawing.Color.White
        Me.LBL_EU_Lastname.Location = New System.Drawing.Point(35, 131)
        Me.LBL_EU_Lastname.Name = "LBL_EU_Lastname"
        Me.LBL_EU_Lastname.Size = New System.Drawing.Size(73, 16)
        Me.LBL_EU_Lastname.TabIndex = 45
        Me.LBL_EU_Lastname.Text = "Lastname :"
        '
        'LBL_EU_FirstName
        '
        Me.LBL_EU_FirstName.AutoSize = True
        Me.LBL_EU_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EU_FirstName.ForeColor = System.Drawing.Color.White
        Me.LBL_EU_FirstName.Location = New System.Drawing.Point(35, 85)
        Me.LBL_EU_FirstName.Name = "LBL_EU_FirstName"
        Me.LBL_EU_FirstName.Size = New System.Drawing.Size(73, 16)
        Me.LBL_EU_FirstName.TabIndex = 44
        Me.LBL_EU_FirstName.Text = "Firstname :"
        '
        'LBL_EditUser
        '
        Me.LBL_EditUser.AutoSize = True
        Me.LBL_EditUser.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EditUser.ForeColor = System.Drawing.Color.Yellow
        Me.LBL_EditUser.Location = New System.Drawing.Point(144, 18)
        Me.LBL_EditUser.Name = "LBL_EditUser"
        Me.LBL_EditUser.Size = New System.Drawing.Size(151, 30)
        Me.LBL_EditUser.TabIndex = 43
        Me.LBL_EditUser.Text = "Edit User"
        '
        'BTN_EU_Cancel
        '
        Me.BTN_EU_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_EU_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EU_Cancel.Location = New System.Drawing.Point(106, 691)
        Me.BTN_EU_Cancel.Name = "BTN_EU_Cancel"
        Me.BTN_EU_Cancel.Size = New System.Drawing.Size(92, 32)
        Me.BTN_EU_Cancel.TabIndex = 71
        Me.BTN_EU_Cancel.Text = "Cancel"
        Me.BTN_EU_Cancel.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LBL_EditUser)
        Me.Panel1.Location = New System.Drawing.Point(-3, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 67)
        Me.Panel1.TabIndex = 72
        '
        'EditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(432, 748)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_EU_Cancel)
        Me.Controls.Add(Me.DTP_EU_StartDate)
        Me.Controls.Add(Me.TB_EU_Education)
        Me.Controls.Add(Me.TB_EU_Hourlypay)
        Me.Controls.Add(Me.TB_EU_Sin)
        Me.Controls.Add(Me.TB_AU_Cellphone)
        Me.Controls.Add(Me.LBL_EU_education)
        Me.Controls.Add(Me.LBL_EU_hourlypay)
        Me.Controls.Add(Me.LBL_EU_sin)
        Me.Controls.Add(Me.LBL_EU_startdate)
        Me.Controls.Add(Me.LBL_EU_cellphone)
        Me.Controls.Add(Me.DTP_EU_DOB)
        Me.Controls.Add(Me.BTN_EU_Edit)
        Me.Controls.Add(Me.TB_EU_Homephone)
        Me.Controls.Add(Me.TB_EU_Postalcode)
        Me.Controls.Add(Me.TB_EU_Province)
        Me.Controls.Add(Me.TB_EU_City)
        Me.Controls.Add(Me.TB_EU_Address)
        Me.Controls.Add(Me.TB_EU_Lastname)
        Me.Controls.Add(Me.TB_EU_Firstname)
        Me.Controls.Add(Me.LBL_EU_Homephone)
        Me.Controls.Add(Me.LBL_EU_PostalCode)
        Me.Controls.Add(Me.LBL_EU_Province)
        Me.Controls.Add(Me.LBL_EU_City)
        Me.Controls.Add(Me.LBL_EU_Address)
        Me.Controls.Add(Me.LBL_EU_DOB)
        Me.Controls.Add(Me.LBL_EU_Lastname)
        Me.Controls.Add(Me.LBL_EU_FirstName)
        Me.Name = "EditUser"
        Me.Text = "AdminEdit"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DTP_EU_StartDate As DateTimePicker
    Friend WithEvents TB_EU_Education As TextBox
    Friend WithEvents TB_EU_Hourlypay As TextBox
    Friend WithEvents TB_EU_Sin As TextBox
    Friend WithEvents TB_AU_Cellphone As TextBox
    Friend WithEvents LBL_EU_education As Label
    Friend WithEvents LBL_EU_hourlypay As Label
    Friend WithEvents LBL_EU_sin As Label
    Friend WithEvents LBL_EU_startdate As Label
    Friend WithEvents LBL_EU_cellphone As Label
    Friend WithEvents DTP_EU_DOB As DateTimePicker
    Friend WithEvents BTN_EU_Edit As Button
    Friend WithEvents TB_EU_Homephone As TextBox
    Friend WithEvents TB_EU_Postalcode As TextBox
    Friend WithEvents TB_EU_Province As TextBox
    Friend WithEvents TB_EU_City As TextBox
    Friend WithEvents TB_EU_Address As TextBox
    Friend WithEvents TB_EU_Lastname As TextBox
    Friend WithEvents TB_EU_Firstname As TextBox
    Friend WithEvents LBL_EU_Homephone As Label
    Friend WithEvents LBL_EU_PostalCode As Label
    Friend WithEvents LBL_EU_Province As Label
    Friend WithEvents LBL_EU_City As Label
    Friend WithEvents LBL_EU_Address As Label
    Friend WithEvents LBL_EU_DOB As Label
    Friend WithEvents LBL_EU_Lastname As Label
    Friend WithEvents LBL_EU_FirstName As Label
    Friend WithEvents LBL_EditUser As Label
    Friend WithEvents BTN_EU_Cancel As Button
    Friend WithEvents Panel1 As Panel
End Class
