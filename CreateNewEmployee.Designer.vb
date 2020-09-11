<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewEmployee
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
        Me.BTN_NewEmployee_cancle = New System.Windows.Forms.Button()
        Me.LBL_NE_CellPhone = New System.Windows.Forms.Label()
        Me.LBL_NE_Telephone = New System.Windows.Forms.Label()
        Me.DTP_NE_DOB = New System.Windows.Forms.DateTimePicker()
        Me.TB_NE_Province = New System.Windows.Forms.TextBox()
        Me.TB_NE_city = New System.Windows.Forms.TextBox()
        Me.TB_NE_Address = New System.Windows.Forms.TextBox()
        Me.TB_NE_Age = New System.Windows.Forms.TextBox()
        Me.TB_NE_LastName = New System.Windows.Forms.TextBox()
        Me.TB_NE_FirstName = New System.Windows.Forms.TextBox()
        Me.LBL_NE_PostalCode = New System.Windows.Forms.Label()
        Me.LBL_NE_Province = New System.Windows.Forms.Label()
        Me.LBL_NE_city = New System.Windows.Forms.Label()
        Me.LBL_NE_Address = New System.Windows.Forms.Label()
        Me.LBL_NE_Age = New System.Windows.Forms.Label()
        Me.LBL_NE_DOB = New System.Windows.Forms.Label()
        Me.LBL_NE_LastName = New System.Windows.Forms.Label()
        Me.LBL_NE_FirstName = New System.Windows.Forms.Label()
        Me.BTN_NewEmployee_save = New System.Windows.Forms.Button()
        Me.GB_HumanResources = New System.Windows.Forms.GroupBox()
        Me.TB_NE_SIN = New System.Windows.Forms.MaskedTextBox()
        Me.CB_NE_Schooling = New System.Windows.Forms.ComboBox()
        Me.DTP_NE_DateStarted = New System.Windows.Forms.DateTimePicker()
        Me.TB_NE_Salary = New System.Windows.Forms.TextBox()
        Me.TB_NE_EmployeeNo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LBL_NE_DateStarted = New System.Windows.Forms.Label()
        Me.LBL_NE_Salary = New System.Windows.Forms.Label()
        Me.LBL_NE_SIN = New System.Windows.Forms.Label()
        Me.LBL_NE_EmployeeNo = New System.Windows.Forms.Label()
        Me.GB_PrimaryInformation = New System.Windows.Forms.GroupBox()
        Me.TB_NE_Cellphone = New System.Windows.Forms.MaskedTextBox()
        Me.TB_NE_Telephone = New System.Windows.Forms.MaskedTextBox()
        Me.TB_NE_PostalCode = New System.Windows.Forms.MaskedTextBox()
        Me.LBL_NewEmployee = New System.Windows.Forms.Label()
        Me.GB_SystemInformation = New System.Windows.Forms.GroupBox()
        Me.RB_NE_high = New System.Windows.Forms.RadioButton()
        Me.RB_NE_medium = New System.Windows.Forms.RadioButton()
        Me.RB_NE_low = New System.Windows.Forms.RadioButton()
        Me.TB_NE_Password = New System.Windows.Forms.TextBox()
        Me.TB_NE_UserName = New System.Windows.Forms.TextBox()
        Me.LBL_NE_Password = New System.Windows.Forms.Label()
        Me.LBL_NE_UserName = New System.Windows.Forms.Label()
        Me.LBL_NE_AccessLevel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GB_HumanResources.SuspendLayout()
        Me.GB_PrimaryInformation.SuspendLayout()
        Me.GB_SystemInformation.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_NewEmployee_cancle
        '
        Me.BTN_NewEmployee_cancle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_NewEmployee_cancle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NewEmployee_cancle.Location = New System.Drawing.Point(305, 540)
        Me.BTN_NewEmployee_cancle.Name = "BTN_NewEmployee_cancle"
        Me.BTN_NewEmployee_cancle.Size = New System.Drawing.Size(92, 32)
        Me.BTN_NewEmployee_cancle.TabIndex = 17
        Me.BTN_NewEmployee_cancle.Text = "Cancel"
        Me.BTN_NewEmployee_cancle.UseVisualStyleBackColor = False
        '
        'LBL_NE_CellPhone
        '
        Me.LBL_NE_CellPhone.AutoSize = True
        Me.LBL_NE_CellPhone.Location = New System.Drawing.Point(69, 197)
        Me.LBL_NE_CellPhone.Name = "LBL_NE_CellPhone"
        Me.LBL_NE_CellPhone.Size = New System.Drawing.Size(78, 16)
        Me.LBL_NE_CellPhone.TabIndex = 20
        Me.LBL_NE_CellPhone.Text = "Cell phone :"
        '
        'LBL_NE_Telephone
        '
        Me.LBL_NE_Telephone.AutoSize = True
        Me.LBL_NE_Telephone.Location = New System.Drawing.Point(69, 166)
        Me.LBL_NE_Telephone.Name = "LBL_NE_Telephone"
        Me.LBL_NE_Telephone.Size = New System.Drawing.Size(80, 16)
        Me.LBL_NE_Telephone.TabIndex = 19
        Me.LBL_NE_Telephone.Text = "Telephone :"
        '
        'DTP_NE_DOB
        '
        Me.DTP_NE_DOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_NE_DOB.Location = New System.Drawing.Point(156, 94)
        Me.DTP_NE_DOB.Name = "DTP_NE_DOB"
        Me.DTP_NE_DOB.Size = New System.Drawing.Size(200, 22)
        Me.DTP_NE_DOB.TabIndex = 18
        Me.DTP_NE_DOB.Value = New Date(2019, 10, 23, 11, 28, 6, 0)
        '
        'TB_NE_Province
        '
        Me.TB_NE_Province.ForeColor = System.Drawing.Color.Black
        Me.TB_NE_Province.Location = New System.Drawing.Point(518, 124)
        Me.TB_NE_Province.Name = "TB_NE_Province"
        Me.TB_NE_Province.Size = New System.Drawing.Size(191, 22)
        Me.TB_NE_Province.TabIndex = 15
        '
        'TB_NE_city
        '
        Me.TB_NE_city.ForeColor = System.Drawing.Color.Black
        Me.TB_NE_city.Location = New System.Drawing.Point(518, 84)
        Me.TB_NE_city.Name = "TB_NE_city"
        Me.TB_NE_city.Size = New System.Drawing.Size(191, 22)
        Me.TB_NE_city.TabIndex = 14
        '
        'TB_NE_Address
        '
        Me.TB_NE_Address.ForeColor = System.Drawing.Color.Black
        Me.TB_NE_Address.Location = New System.Drawing.Point(518, 45)
        Me.TB_NE_Address.Name = "TB_NE_Address"
        Me.TB_NE_Address.Size = New System.Drawing.Size(191, 22)
        Me.TB_NE_Address.TabIndex = 13
        '
        'TB_NE_Age
        '
        Me.TB_NE_Age.Enabled = False
        Me.TB_NE_Age.ForeColor = System.Drawing.Color.Black
        Me.TB_NE_Age.Location = New System.Drawing.Point(156, 127)
        Me.TB_NE_Age.Name = "TB_NE_Age"
        Me.TB_NE_Age.Size = New System.Drawing.Size(200, 22)
        Me.TB_NE_Age.TabIndex = 12
        '
        'TB_NE_LastName
        '
        Me.TB_NE_LastName.ForeColor = System.Drawing.Color.Black
        Me.TB_NE_LastName.Location = New System.Drawing.Point(156, 59)
        Me.TB_NE_LastName.Name = "TB_NE_LastName"
        Me.TB_NE_LastName.Size = New System.Drawing.Size(200, 22)
        Me.TB_NE_LastName.TabIndex = 10
        '
        'TB_NE_FirstName
        '
        Me.TB_NE_FirstName.ForeColor = System.Drawing.Color.Black
        Me.TB_NE_FirstName.Location = New System.Drawing.Point(156, 25)
        Me.TB_NE_FirstName.Name = "TB_NE_FirstName"
        Me.TB_NE_FirstName.Size = New System.Drawing.Size(200, 22)
        Me.TB_NE_FirstName.TabIndex = 9
        '
        'LBL_NE_PostalCode
        '
        Me.LBL_NE_PostalCode.AutoSize = True
        Me.LBL_NE_PostalCode.Location = New System.Drawing.Point(429, 167)
        Me.LBL_NE_PostalCode.Name = "LBL_NE_PostalCode"
        Me.LBL_NE_PostalCode.Size = New System.Drawing.Size(88, 16)
        Me.LBL_NE_PostalCode.TabIndex = 7
        Me.LBL_NE_PostalCode.Text = "Postal Code :"
        '
        'LBL_NE_Province
        '
        Me.LBL_NE_Province.AutoSize = True
        Me.LBL_NE_Province.Location = New System.Drawing.Point(429, 127)
        Me.LBL_NE_Province.Name = "LBL_NE_Province"
        Me.LBL_NE_Province.Size = New System.Drawing.Size(67, 16)
        Me.LBL_NE_Province.TabIndex = 6
        Me.LBL_NE_Province.Text = "Province :"
        '
        'LBL_NE_city
        '
        Me.LBL_NE_city.AutoSize = True
        Me.LBL_NE_city.Location = New System.Drawing.Point(429, 87)
        Me.LBL_NE_city.Name = "LBL_NE_city"
        Me.LBL_NE_city.Size = New System.Drawing.Size(36, 16)
        Me.LBL_NE_city.TabIndex = 5
        Me.LBL_NE_city.Text = "City :"
        '
        'LBL_NE_Address
        '
        Me.LBL_NE_Address.AutoSize = True
        Me.LBL_NE_Address.Location = New System.Drawing.Point(429, 48)
        Me.LBL_NE_Address.Name = "LBL_NE_Address"
        Me.LBL_NE_Address.Size = New System.Drawing.Size(65, 16)
        Me.LBL_NE_Address.TabIndex = 4
        Me.LBL_NE_Address.Text = "Address :"
        '
        'LBL_NE_Age
        '
        Me.LBL_NE_Age.AutoSize = True
        Me.LBL_NE_Age.Location = New System.Drawing.Point(69, 130)
        Me.LBL_NE_Age.Name = "LBL_NE_Age"
        Me.LBL_NE_Age.Size = New System.Drawing.Size(39, 16)
        Me.LBL_NE_Age.TabIndex = 3
        Me.LBL_NE_Age.Text = "Age :"
        '
        'LBL_NE_DOB
        '
        Me.LBL_NE_DOB.AutoSize = True
        Me.LBL_NE_DOB.Location = New System.Drawing.Point(67, 98)
        Me.LBL_NE_DOB.Name = "LBL_NE_DOB"
        Me.LBL_NE_DOB.Size = New System.Drawing.Size(86, 16)
        Me.LBL_NE_DOB.TabIndex = 2
        Me.LBL_NE_DOB.Text = "Date of Birth :"
        '
        'LBL_NE_LastName
        '
        Me.LBL_NE_LastName.AutoSize = True
        Me.LBL_NE_LastName.Location = New System.Drawing.Point(67, 62)
        Me.LBL_NE_LastName.Name = "LBL_NE_LastName"
        Me.LBL_NE_LastName.Size = New System.Drawing.Size(79, 16)
        Me.LBL_NE_LastName.TabIndex = 1
        Me.LBL_NE_LastName.Text = "Last Name :"
        '
        'LBL_NE_FirstName
        '
        Me.LBL_NE_FirstName.AutoSize = True
        Me.LBL_NE_FirstName.Location = New System.Drawing.Point(67, 28)
        Me.LBL_NE_FirstName.Name = "LBL_NE_FirstName"
        Me.LBL_NE_FirstName.Size = New System.Drawing.Size(79, 16)
        Me.LBL_NE_FirstName.TabIndex = 0
        Me.LBL_NE_FirstName.Text = "First Name :"
        '
        'BTN_NewEmployee_save
        '
        Me.BTN_NewEmployee_save.BackColor = System.Drawing.Color.Yellow
        Me.BTN_NewEmployee_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NewEmployee_save.Location = New System.Drawing.Point(433, 540)
        Me.BTN_NewEmployee_save.Name = "BTN_NewEmployee_save"
        Me.BTN_NewEmployee_save.Size = New System.Drawing.Size(92, 32)
        Me.BTN_NewEmployee_save.TabIndex = 16
        Me.BTN_NewEmployee_save.Text = "Save"
        Me.BTN_NewEmployee_save.UseVisualStyleBackColor = False
        '
        'GB_HumanResources
        '
        Me.GB_HumanResources.Controls.Add(Me.TB_NE_SIN)
        Me.GB_HumanResources.Controls.Add(Me.CB_NE_Schooling)
        Me.GB_HumanResources.Controls.Add(Me.DTP_NE_DateStarted)
        Me.GB_HumanResources.Controls.Add(Me.TB_NE_Salary)
        Me.GB_HumanResources.Controls.Add(Me.TB_NE_EmployeeNo)
        Me.GB_HumanResources.Controls.Add(Me.Label14)
        Me.GB_HumanResources.Controls.Add(Me.LBL_NE_DateStarted)
        Me.GB_HumanResources.Controls.Add(Me.LBL_NE_Salary)
        Me.GB_HumanResources.Controls.Add(Me.LBL_NE_SIN)
        Me.GB_HumanResources.Controls.Add(Me.LBL_NE_EmployeeNo)
        Me.GB_HumanResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_HumanResources.ForeColor = System.Drawing.Color.White
        Me.GB_HumanResources.Location = New System.Drawing.Point(29, 323)
        Me.GB_HumanResources.Name = "GB_HumanResources"
        Me.GB_HumanResources.Size = New System.Drawing.Size(368, 190)
        Me.GB_HumanResources.TabIndex = 14
        Me.GB_HumanResources.TabStop = False
        Me.GB_HumanResources.Text = "2. Human Resources "
        '
        'TB_NE_SIN
        '
        Me.TB_NE_SIN.Location = New System.Drawing.Point(142, 60)
        Me.TB_NE_SIN.Mask = "999 999 999"
        Me.TB_NE_SIN.Name = "TB_NE_SIN"
        Me.TB_NE_SIN.Size = New System.Drawing.Size(200, 22)
        Me.TB_NE_SIN.TabIndex = 21
        '
        'CB_NE_Schooling
        '
        Me.CB_NE_Schooling.ForeColor = System.Drawing.Color.Black
        Me.CB_NE_Schooling.FormattingEnabled = True
        Me.CB_NE_Schooling.Items.AddRange(New Object() {"DES", "AEC", "DEC", "Certificate", "BAC", "Master", "Doc"})
        Me.CB_NE_Schooling.Location = New System.Drawing.Point(142, 153)
        Me.CB_NE_Schooling.Name = "CB_NE_Schooling"
        Me.CB_NE_Schooling.Size = New System.Drawing.Size(200, 24)
        Me.CB_NE_Schooling.TabIndex = 20
        '
        'DTP_NE_DateStarted
        '
        Me.DTP_NE_DateStarted.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_NE_DateStarted.Location = New System.Drawing.Point(142, 120)
        Me.DTP_NE_DateStarted.Name = "DTP_NE_DateStarted"
        Me.DTP_NE_DateStarted.Size = New System.Drawing.Size(200, 22)
        Me.DTP_NE_DateStarted.TabIndex = 19
        Me.DTP_NE_DateStarted.Value = New Date(2019, 11, 6, 0, 0, 0, 0)
        '
        'TB_NE_Salary
        '
        Me.TB_NE_Salary.ForeColor = System.Drawing.Color.Black
        Me.TB_NE_Salary.Location = New System.Drawing.Point(142, 92)
        Me.TB_NE_Salary.Name = "TB_NE_Salary"
        Me.TB_NE_Salary.Size = New System.Drawing.Size(200, 22)
        Me.TB_NE_Salary.TabIndex = 15
        '
        'TB_NE_EmployeeNo
        '
        Me.TB_NE_EmployeeNo.Enabled = False
        Me.TB_NE_EmployeeNo.ForeColor = System.Drawing.Color.Black
        Me.TB_NE_EmployeeNo.Location = New System.Drawing.Point(142, 29)
        Me.TB_NE_EmployeeNo.Name = "TB_NE_EmployeeNo"
        Me.TB_NE_EmployeeNo.Size = New System.Drawing.Size(200, 22)
        Me.TB_NE_EmployeeNo.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(40, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 16)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Schooling :"
        '
        'LBL_NE_DateStarted
        '
        Me.LBL_NE_DateStarted.AutoSize = True
        Me.LBL_NE_DateStarted.Location = New System.Drawing.Point(40, 126)
        Me.LBL_NE_DateStarted.Name = "LBL_NE_DateStarted"
        Me.LBL_NE_DateStarted.Size = New System.Drawing.Size(89, 16)
        Me.LBL_NE_DateStarted.TabIndex = 3
        Me.LBL_NE_DateStarted.Text = "Date Started :"
        '
        'LBL_NE_Salary
        '
        Me.LBL_NE_Salary.AutoSize = True
        Me.LBL_NE_Salary.Location = New System.Drawing.Point(40, 95)
        Me.LBL_NE_Salary.Name = "LBL_NE_Salary"
        Me.LBL_NE_Salary.Size = New System.Drawing.Size(53, 16)
        Me.LBL_NE_Salary.TabIndex = 2
        Me.LBL_NE_Salary.Text = "Salary :"
        '
        'LBL_NE_SIN
        '
        Me.LBL_NE_SIN.AutoSize = True
        Me.LBL_NE_SIN.Location = New System.Drawing.Point(40, 63)
        Me.LBL_NE_SIN.Name = "LBL_NE_SIN"
        Me.LBL_NE_SIN.Size = New System.Drawing.Size(36, 16)
        Me.LBL_NE_SIN.TabIndex = 1
        Me.LBL_NE_SIN.Text = "SIN :"
        '
        'LBL_NE_EmployeeNo
        '
        Me.LBL_NE_EmployeeNo.AutoSize = True
        Me.LBL_NE_EmployeeNo.Location = New System.Drawing.Point(40, 32)
        Me.LBL_NE_EmployeeNo.Name = "LBL_NE_EmployeeNo"
        Me.LBL_NE_EmployeeNo.Size = New System.Drawing.Size(97, 16)
        Me.LBL_NE_EmployeeNo.TabIndex = 0
        Me.LBL_NE_EmployeeNo.Text = "Employee No :"
        '
        'GB_PrimaryInformation
        '
        Me.GB_PrimaryInformation.Controls.Add(Me.TB_NE_Cellphone)
        Me.GB_PrimaryInformation.Controls.Add(Me.TB_NE_Telephone)
        Me.GB_PrimaryInformation.Controls.Add(Me.TB_NE_PostalCode)
        Me.GB_PrimaryInformation.Controls.Add(Me.LBL_NE_CellPhone)
        Me.GB_PrimaryInformation.Controls.Add(Me.LBL_NE_Telephone)
        Me.GB_PrimaryInformation.Controls.Add(Me.DTP_NE_DOB)
        Me.GB_PrimaryInformation.Controls.Add(Me.TB_NE_Province)
        Me.GB_PrimaryInformation.Controls.Add(Me.TB_NE_city)
        Me.GB_PrimaryInformation.Controls.Add(Me.TB_NE_Address)
        Me.GB_PrimaryInformation.Controls.Add(Me.TB_NE_Age)
        Me.GB_PrimaryInformation.Controls.Add(Me.TB_NE_LastName)
        Me.GB_PrimaryInformation.Controls.Add(Me.TB_NE_FirstName)
        Me.GB_PrimaryInformation.Controls.Add(Me.LBL_NE_PostalCode)
        Me.GB_PrimaryInformation.Controls.Add(Me.LBL_NE_Province)
        Me.GB_PrimaryInformation.Controls.Add(Me.LBL_NE_city)
        Me.GB_PrimaryInformation.Controls.Add(Me.LBL_NE_Address)
        Me.GB_PrimaryInformation.Controls.Add(Me.LBL_NE_Age)
        Me.GB_PrimaryInformation.Controls.Add(Me.LBL_NE_DOB)
        Me.GB_PrimaryInformation.Controls.Add(Me.LBL_NE_LastName)
        Me.GB_PrimaryInformation.Controls.Add(Me.LBL_NE_FirstName)
        Me.GB_PrimaryInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_PrimaryInformation.ForeColor = System.Drawing.Color.White
        Me.GB_PrimaryInformation.Location = New System.Drawing.Point(29, 83)
        Me.GB_PrimaryInformation.Name = "GB_PrimaryInformation"
        Me.GB_PrimaryInformation.Size = New System.Drawing.Size(767, 232)
        Me.GB_PrimaryInformation.TabIndex = 13
        Me.GB_PrimaryInformation.TabStop = False
        Me.GB_PrimaryInformation.Text = "1. Primary Information"
        '
        'TB_NE_Cellphone
        '
        Me.TB_NE_Cellphone.Location = New System.Drawing.Point(156, 194)
        Me.TB_NE_Cellphone.Mask = "999-999-9999"
        Me.TB_NE_Cellphone.Name = "TB_NE_Cellphone"
        Me.TB_NE_Cellphone.Size = New System.Drawing.Size(200, 22)
        Me.TB_NE_Cellphone.TabIndex = 25
        '
        'TB_NE_Telephone
        '
        Me.TB_NE_Telephone.Location = New System.Drawing.Point(155, 163)
        Me.TB_NE_Telephone.Mask = "999-999-9999"
        Me.TB_NE_Telephone.Name = "TB_NE_Telephone"
        Me.TB_NE_Telephone.Size = New System.Drawing.Size(200, 22)
        Me.TB_NE_Telephone.TabIndex = 24
        '
        'TB_NE_PostalCode
        '
        Me.TB_NE_PostalCode.Location = New System.Drawing.Point(518, 165)
        Me.TB_NE_PostalCode.Mask = "?0? 0?0"
        Me.TB_NE_PostalCode.Name = "TB_NE_PostalCode"
        Me.TB_NE_PostalCode.Size = New System.Drawing.Size(191, 22)
        Me.TB_NE_PostalCode.TabIndex = 23
        '
        'LBL_NewEmployee
        '
        Me.LBL_NewEmployee.AutoSize = True
        Me.LBL_NewEmployee.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NewEmployee.ForeColor = System.Drawing.Color.Yellow
        Me.LBL_NewEmployee.Location = New System.Drawing.Point(304, 18)
        Me.LBL_NewEmployee.Name = "LBL_NewEmployee"
        Me.LBL_NewEmployee.Size = New System.Drawing.Size(222, 30)
        Me.LBL_NewEmployee.TabIndex = 12
        Me.LBL_NewEmployee.Text = "New Employee"
        '
        'GB_SystemInformation
        '
        Me.GB_SystemInformation.Controls.Add(Me.RB_NE_high)
        Me.GB_SystemInformation.Controls.Add(Me.RB_NE_medium)
        Me.GB_SystemInformation.Controls.Add(Me.RB_NE_low)
        Me.GB_SystemInformation.Controls.Add(Me.TB_NE_Password)
        Me.GB_SystemInformation.Controls.Add(Me.TB_NE_UserName)
        Me.GB_SystemInformation.Controls.Add(Me.LBL_NE_Password)
        Me.GB_SystemInformation.Controls.Add(Me.LBL_NE_UserName)
        Me.GB_SystemInformation.Controls.Add(Me.LBL_NE_AccessLevel)
        Me.GB_SystemInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_SystemInformation.ForeColor = System.Drawing.Color.White
        Me.GB_SystemInformation.Location = New System.Drawing.Point(433, 323)
        Me.GB_SystemInformation.Name = "GB_SystemInformation"
        Me.GB_SystemInformation.Size = New System.Drawing.Size(363, 190)
        Me.GB_SystemInformation.TabIndex = 15
        Me.GB_SystemInformation.TabStop = False
        Me.GB_SystemInformation.Text = "3. System Information "
        '
        'RB_NE_high
        '
        Me.RB_NE_high.AutoSize = True
        Me.RB_NE_high.Location = New System.Drawing.Point(272, 50)
        Me.RB_NE_high.Name = "RB_NE_high"
        Me.RB_NE_high.Size = New System.Drawing.Size(54, 20)
        Me.RB_NE_high.TabIndex = 20
        Me.RB_NE_high.TabStop = True
        Me.RB_NE_high.Text = "High"
        Me.RB_NE_high.UseVisualStyleBackColor = True
        '
        'RB_NE_medium
        '
        Me.RB_NE_medium.AutoSize = True
        Me.RB_NE_medium.Location = New System.Drawing.Point(196, 50)
        Me.RB_NE_medium.Name = "RB_NE_medium"
        Me.RB_NE_medium.Size = New System.Drawing.Size(74, 20)
        Me.RB_NE_medium.TabIndex = 19
        Me.RB_NE_medium.TabStop = True
        Me.RB_NE_medium.Text = "Medium"
        Me.RB_NE_medium.UseVisualStyleBackColor = True
        '
        'RB_NE_low
        '
        Me.RB_NE_low.AutoSize = True
        Me.RB_NE_low.Location = New System.Drawing.Point(140, 50)
        Me.RB_NE_low.Name = "RB_NE_low"
        Me.RB_NE_low.Size = New System.Drawing.Size(50, 20)
        Me.RB_NE_low.TabIndex = 18
        Me.RB_NE_low.TabStop = True
        Me.RB_NE_low.Text = "Low"
        Me.RB_NE_low.UseVisualStyleBackColor = True
        '
        'TB_NE_Password
        '
        Me.TB_NE_Password.ForeColor = System.Drawing.Color.Black
        Me.TB_NE_Password.Location = New System.Drawing.Point(140, 135)
        Me.TB_NE_Password.Name = "TB_NE_Password"
        Me.TB_NE_Password.Size = New System.Drawing.Size(186, 22)
        Me.TB_NE_Password.TabIndex = 17
        '
        'TB_NE_UserName
        '
        Me.TB_NE_UserName.ForeColor = System.Drawing.Color.Black
        Me.TB_NE_UserName.Location = New System.Drawing.Point(140, 90)
        Me.TB_NE_UserName.Name = "TB_NE_UserName"
        Me.TB_NE_UserName.Size = New System.Drawing.Size(186, 22)
        Me.TB_NE_UserName.TabIndex = 16
        '
        'LBL_NE_Password
        '
        Me.LBL_NE_Password.AutoSize = True
        Me.LBL_NE_Password.Location = New System.Drawing.Point(41, 138)
        Me.LBL_NE_Password.Name = "LBL_NE_Password"
        Me.LBL_NE_Password.Size = New System.Drawing.Size(74, 16)
        Me.LBL_NE_Password.TabIndex = 7
        Me.LBL_NE_Password.Text = "Password :"
        '
        'LBL_NE_UserName
        '
        Me.LBL_NE_UserName.AutoSize = True
        Me.LBL_NE_UserName.Location = New System.Drawing.Point(41, 93)
        Me.LBL_NE_UserName.Name = "LBL_NE_UserName"
        Me.LBL_NE_UserName.Size = New System.Drawing.Size(83, 16)
        Me.LBL_NE_UserName.TabIndex = 6
        Me.LBL_NE_UserName.Text = "User Name :"
        '
        'LBL_NE_AccessLevel
        '
        Me.LBL_NE_AccessLevel.AutoSize = True
        Me.LBL_NE_AccessLevel.Location = New System.Drawing.Point(41, 50)
        Me.LBL_NE_AccessLevel.Name = "LBL_NE_AccessLevel"
        Me.LBL_NE_AccessLevel.Size = New System.Drawing.Size(95, 16)
        Me.LBL_NE_AccessLevel.TabIndex = 5
        Me.LBL_NE_AccessLevel.Text = "Access Level :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LBL_NewEmployee)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(825, 67)
        Me.Panel1.TabIndex = 19
        '
        'CreateNewEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(824, 598)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_NewEmployee_cancle)
        Me.Controls.Add(Me.BTN_NewEmployee_save)
        Me.Controls.Add(Me.GB_HumanResources)
        Me.Controls.Add(Me.GB_PrimaryInformation)
        Me.Controls.Add(Me.GB_SystemInformation)
        Me.Name = "CreateNewEmployee"
        Me.Text = "CreateNewEmployee"
        Me.GB_HumanResources.ResumeLayout(False)
        Me.GB_HumanResources.PerformLayout()
        Me.GB_PrimaryInformation.ResumeLayout(False)
        Me.GB_PrimaryInformation.PerformLayout()
        Me.GB_SystemInformation.ResumeLayout(False)
        Me.GB_SystemInformation.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTN_NewEmployee_cancle As Button
    Friend WithEvents LBL_NE_CellPhone As Label
    Friend WithEvents LBL_NE_Telephone As Label
    Friend WithEvents DTP_NE_DOB As DateTimePicker
    Friend WithEvents TB_NE_Province As TextBox
    Friend WithEvents TB_NE_city As TextBox
    Friend WithEvents TB_NE_Address As TextBox
    Friend WithEvents TB_NE_Age As TextBox
    Friend WithEvents TB_NE_LastName As TextBox
    Friend WithEvents TB_NE_FirstName As TextBox
    Friend WithEvents LBL_NE_PostalCode As Label
    Friend WithEvents LBL_NE_Province As Label
    Friend WithEvents LBL_NE_city As Label
    Friend WithEvents LBL_NE_Address As Label
    Friend WithEvents LBL_NE_Age As Label
    Friend WithEvents LBL_NE_DOB As Label
    Friend WithEvents LBL_NE_LastName As Label
    Friend WithEvents LBL_NE_FirstName As Label
    Friend WithEvents BTN_NewEmployee_save As Button
    Friend WithEvents GB_HumanResources As GroupBox
    Friend WithEvents CB_NE_Schooling As ComboBox
    Friend WithEvents DTP_NE_DateStarted As DateTimePicker
    Friend WithEvents TB_NE_Salary As TextBox
    Friend WithEvents TB_NE_EmployeeNo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents LBL_NE_DateStarted As Label
    Friend WithEvents LBL_NE_Salary As Label
    Friend WithEvents LBL_NE_SIN As Label
    Friend WithEvents LBL_NE_EmployeeNo As Label
    Friend WithEvents GB_PrimaryInformation As GroupBox
    Friend WithEvents LBL_NewEmployee As Label
    Friend WithEvents GB_SystemInformation As GroupBox
    Friend WithEvents RB_NE_high As RadioButton
    Friend WithEvents RB_NE_medium As RadioButton
    Friend WithEvents RB_NE_low As RadioButton
    Friend WithEvents TB_NE_Password As TextBox
    Friend WithEvents TB_NE_UserName As TextBox
    Friend WithEvents LBL_NE_Password As Label
    Friend WithEvents LBL_NE_UserName As Label
    Friend WithEvents LBL_NE_AccessLevel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TB_NE_PostalCode As MaskedTextBox
    Friend WithEvents TB_NE_Cellphone As MaskedTextBox
    Friend WithEvents TB_NE_Telephone As MaskedTextBox
    Friend WithEvents TB_NE_SIN As MaskedTextBox
End Class
