<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditEmployee
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_EE_Schooling = New System.Windows.Forms.ComboBox()
        Me.DTP_EE_dateStarted = New System.Windows.Forms.DateTimePicker()
        Me.TB_EE_Salary = New System.Windows.Forms.TextBox()
        Me.TB_EE_SIN = New System.Windows.Forms.TextBox()
        Me.TB_EE_EmployeeNo = New System.Windows.Forms.TextBox()
        Me.TB_EE_Provience = New System.Windows.Forms.TextBox()
        Me.TB_EE_City = New System.Windows.Forms.TextBox()
        Me.TB_EE_Address = New System.Windows.Forms.TextBox()
        Me.LBL_NewEmployee = New System.Windows.Forms.Label()
        Me.LBL_EE_Telephone = New System.Windows.Forms.Label()
        Me.LBL_EE_PostalCode = New System.Windows.Forms.Label()
        Me.LBL_EE_Provience = New System.Windows.Forms.Label()
        Me.DTP_EE_DOB = New System.Windows.Forms.DateTimePicker()
        Me.LBL_EE_Employee = New System.Windows.Forms.Label()
        Me.LBL_EE_City = New System.Windows.Forms.Label()
        Me.LBL_EE_Address = New System.Windows.Forms.Label()
        Me.BTN_EE_Search = New System.Windows.Forms.Button()
        Me.TB_EE_SearchEmp = New System.Windows.Forms.TextBox()
        Me.GB_EE_PrimaryInformation = New System.Windows.Forms.GroupBox()
        Me.Tb_EE_Cellphone = New System.Windows.Forms.MaskedTextBox()
        Me.TB_EE_Telephone = New System.Windows.Forms.MaskedTextBox()
        Me.TB_EE_PostalCode = New System.Windows.Forms.MaskedTextBox()
        Me.TB_EE_Age = New System.Windows.Forms.TextBox()
        Me.TB_EE_LastName = New System.Windows.Forms.TextBox()
        Me.TB_EE_FirstName = New System.Windows.Forms.TextBox()
        Me.LBL_EE_Age = New System.Windows.Forms.Label()
        Me.LBL_EE_DOB = New System.Windows.Forms.Label()
        Me.LBL_EE_LastName = New System.Windows.Forms.Label()
        Me.LBL_EE_FirstName = New System.Windows.Forms.Label()
        Me.LBL_EE_Schooling = New System.Windows.Forms.Label()
        Me.GB_EE_HumanResources = New System.Windows.Forms.GroupBox()
        Me.LBL_EE_DateStarted = New System.Windows.Forms.Label()
        Me.LBL_EE_Salary = New System.Windows.Forms.Label()
        Me.LBL_EE_SIN = New System.Windows.Forms.Label()
        Me.LBL_EE_EmployeeNo = New System.Windows.Forms.Label()
        Me.RB_EE_high = New System.Windows.Forms.RadioButton()
        Me.RB_EE_medium = New System.Windows.Forms.RadioButton()
        Me.TB_EE_Password = New System.Windows.Forms.TextBox()
        Me.TB_EE_UserName = New System.Windows.Forms.TextBox()
        Me.LBL_EE_Password = New System.Windows.Forms.Label()
        Me.GB_EE_SystemInformation = New System.Windows.Forms.GroupBox()
        Me.RB_EE_low = New System.Windows.Forms.RadioButton()
        Me.LBL_EE_UserName = New System.Windows.Forms.Label()
        Me.LBL_EE_AccessLevel = New System.Windows.Forms.Label()
        Me.GB_EE_ChooseEmployee = New System.Windows.Forms.GroupBox()
        Me.BTN_EE_cancel = New System.Windows.Forms.Button()
        Me.BTN_EE_Edit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GB_EE_PrimaryInformation.SuspendLayout()
        Me.GB_EE_HumanResources.SuspendLayout()
        Me.GB_EE_SystemInformation.SuspendLayout()
        Me.GB_EE_ChooseEmployee.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 375)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Cellphone :"
        '
        'CB_EE_Schooling
        '
        Me.CB_EE_Schooling.ForeColor = System.Drawing.Color.Black
        Me.CB_EE_Schooling.FormattingEnabled = True
        Me.CB_EE_Schooling.Items.AddRange(New Object() {"DES", "AEC", "DEC", "Certificate", "BAC", "Master", "Doc"})
        Me.CB_EE_Schooling.Location = New System.Drawing.Point(131, 156)
        Me.CB_EE_Schooling.Name = "CB_EE_Schooling"
        Me.CB_EE_Schooling.Size = New System.Drawing.Size(200, 24)
        Me.CB_EE_Schooling.TabIndex = 20
        '
        'DTP_EE_dateStarted
        '
        Me.DTP_EE_dateStarted.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_EE_dateStarted.Location = New System.Drawing.Point(131, 123)
        Me.DTP_EE_dateStarted.Name = "DTP_EE_dateStarted"
        Me.DTP_EE_dateStarted.Size = New System.Drawing.Size(200, 22)
        Me.DTP_EE_dateStarted.TabIndex = 19
        Me.DTP_EE_dateStarted.Value = New Date(2019, 10, 23, 11, 28, 6, 0)
        '
        'TB_EE_Salary
        '
        Me.TB_EE_Salary.ForeColor = System.Drawing.Color.Black
        Me.TB_EE_Salary.Location = New System.Drawing.Point(131, 92)
        Me.TB_EE_Salary.Name = "TB_EE_Salary"
        Me.TB_EE_Salary.Size = New System.Drawing.Size(200, 22)
        Me.TB_EE_Salary.TabIndex = 15
        '
        'TB_EE_SIN
        '
        Me.TB_EE_SIN.ForeColor = System.Drawing.Color.Black
        Me.TB_EE_SIN.Location = New System.Drawing.Point(131, 60)
        Me.TB_EE_SIN.Name = "TB_EE_SIN"
        Me.TB_EE_SIN.Size = New System.Drawing.Size(200, 22)
        Me.TB_EE_SIN.TabIndex = 14
        '
        'TB_EE_EmployeeNo
        '
        Me.TB_EE_EmployeeNo.Enabled = False
        Me.TB_EE_EmployeeNo.ForeColor = System.Drawing.Color.Black
        Me.TB_EE_EmployeeNo.Location = New System.Drawing.Point(131, 29)
        Me.TB_EE_EmployeeNo.Name = "TB_EE_EmployeeNo"
        Me.TB_EE_EmployeeNo.Size = New System.Drawing.Size(200, 22)
        Me.TB_EE_EmployeeNo.TabIndex = 13
        '
        'TB_EE_Provience
        '
        Me.TB_EE_Provience.ForeColor = System.Drawing.Color.Black
        Me.TB_EE_Provience.Location = New System.Drawing.Point(119, 259)
        Me.TB_EE_Provience.Name = "TB_EE_Provience"
        Me.TB_EE_Provience.Size = New System.Drawing.Size(200, 22)
        Me.TB_EE_Provience.TabIndex = 26
        '
        'TB_EE_City
        '
        Me.TB_EE_City.ForeColor = System.Drawing.Color.Black
        Me.TB_EE_City.Location = New System.Drawing.Point(119, 219)
        Me.TB_EE_City.Name = "TB_EE_City"
        Me.TB_EE_City.Size = New System.Drawing.Size(200, 22)
        Me.TB_EE_City.TabIndex = 25
        '
        'TB_EE_Address
        '
        Me.TB_EE_Address.ForeColor = System.Drawing.Color.Black
        Me.TB_EE_Address.Location = New System.Drawing.Point(119, 180)
        Me.TB_EE_Address.Name = "TB_EE_Address"
        Me.TB_EE_Address.Size = New System.Drawing.Size(200, 22)
        Me.TB_EE_Address.TabIndex = 24
        '
        'LBL_NewEmployee
        '
        Me.LBL_NewEmployee.AutoSize = True
        Me.LBL_NewEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NewEmployee.ForeColor = System.Drawing.Color.Gold
        Me.LBL_NewEmployee.Location = New System.Drawing.Point(267, 19)
        Me.LBL_NewEmployee.Name = "LBL_NewEmployee"
        Me.LBL_NewEmployee.Size = New System.Drawing.Size(201, 31)
        Me.LBL_NewEmployee.TabIndex = 24
        Me.LBL_NewEmployee.Text = "Edit Employee"
        '
        'LBL_EE_Telephone
        '
        Me.LBL_EE_Telephone.AutoSize = True
        Me.LBL_EE_Telephone.ForeColor = System.Drawing.Color.White
        Me.LBL_EE_Telephone.Location = New System.Drawing.Point(23, 340)
        Me.LBL_EE_Telephone.Name = "LBL_EE_Telephone"
        Me.LBL_EE_Telephone.Size = New System.Drawing.Size(80, 16)
        Me.LBL_EE_Telephone.TabIndex = 23
        Me.LBL_EE_Telephone.Text = "Telephone :"
        '
        'LBL_EE_PostalCode
        '
        Me.LBL_EE_PostalCode.AutoSize = True
        Me.LBL_EE_PostalCode.ForeColor = System.Drawing.Color.White
        Me.LBL_EE_PostalCode.Location = New System.Drawing.Point(23, 301)
        Me.LBL_EE_PostalCode.Name = "LBL_EE_PostalCode"
        Me.LBL_EE_PostalCode.Size = New System.Drawing.Size(88, 16)
        Me.LBL_EE_PostalCode.TabIndex = 22
        Me.LBL_EE_PostalCode.Text = "Postal Code :"
        '
        'LBL_EE_Provience
        '
        Me.LBL_EE_Provience.AutoSize = True
        Me.LBL_EE_Provience.ForeColor = System.Drawing.Color.White
        Me.LBL_EE_Provience.Location = New System.Drawing.Point(23, 262)
        Me.LBL_EE_Provience.Name = "LBL_EE_Provience"
        Me.LBL_EE_Provience.Size = New System.Drawing.Size(67, 16)
        Me.LBL_EE_Provience.TabIndex = 21
        Me.LBL_EE_Provience.Text = "Province :"
        '
        'DTP_EE_DOB
        '
        Me.DTP_EE_DOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_EE_DOB.Location = New System.Drawing.Point(119, 106)
        Me.DTP_EE_DOB.Name = "DTP_EE_DOB"
        Me.DTP_EE_DOB.Size = New System.Drawing.Size(200, 22)
        Me.DTP_EE_DOB.TabIndex = 18
        Me.DTP_EE_DOB.Value = New Date(2019, 10, 23, 11, 28, 6, 0)
        '
        'LBL_EE_Employee
        '
        Me.LBL_EE_Employee.AutoSize = True
        Me.LBL_EE_Employee.Location = New System.Drawing.Point(23, 23)
        Me.LBL_EE_Employee.Name = "LBL_EE_Employee"
        Me.LBL_EE_Employee.Size = New System.Drawing.Size(90, 16)
        Me.LBL_EE_Employee.TabIndex = 0
        Me.LBL_EE_Employee.Text = "Employee id :"
        '
        'LBL_EE_City
        '
        Me.LBL_EE_City.AutoSize = True
        Me.LBL_EE_City.ForeColor = System.Drawing.Color.White
        Me.LBL_EE_City.Location = New System.Drawing.Point(23, 222)
        Me.LBL_EE_City.Name = "LBL_EE_City"
        Me.LBL_EE_City.Size = New System.Drawing.Size(36, 16)
        Me.LBL_EE_City.TabIndex = 20
        Me.LBL_EE_City.Text = "City :"
        '
        'LBL_EE_Address
        '
        Me.LBL_EE_Address.AutoSize = True
        Me.LBL_EE_Address.ForeColor = System.Drawing.Color.White
        Me.LBL_EE_Address.Location = New System.Drawing.Point(23, 183)
        Me.LBL_EE_Address.Name = "LBL_EE_Address"
        Me.LBL_EE_Address.Size = New System.Drawing.Size(65, 16)
        Me.LBL_EE_Address.TabIndex = 19
        Me.LBL_EE_Address.Text = "Address :"
        '
        'BTN_EE_Search
        '
        Me.BTN_EE_Search.ForeColor = System.Drawing.Color.Black
        Me.BTN_EE_Search.Location = New System.Drawing.Point(638, 20)
        Me.BTN_EE_Search.Name = "BTN_EE_Search"
        Me.BTN_EE_Search.Size = New System.Drawing.Size(75, 23)
        Me.BTN_EE_Search.TabIndex = 2
        Me.BTN_EE_Search.Text = "Search"
        Me.BTN_EE_Search.UseVisualStyleBackColor = True
        '
        'TB_EE_SearchEmp
        '
        Me.TB_EE_SearchEmp.ForeColor = System.Drawing.Color.Black
        Me.TB_EE_SearchEmp.Location = New System.Drawing.Point(119, 20)
        Me.TB_EE_SearchEmp.Name = "TB_EE_SearchEmp"
        Me.TB_EE_SearchEmp.Size = New System.Drawing.Size(502, 22)
        Me.TB_EE_SearchEmp.TabIndex = 1
        '
        'GB_EE_PrimaryInformation
        '
        Me.GB_EE_PrimaryInformation.BackColor = System.Drawing.Color.Transparent
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.Tb_EE_Cellphone)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.TB_EE_Telephone)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.TB_EE_PostalCode)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.Label1)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.TB_EE_Provience)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.TB_EE_City)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.TB_EE_Address)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.LBL_EE_Telephone)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.LBL_EE_PostalCode)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.LBL_EE_Provience)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.LBL_EE_City)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.LBL_EE_Address)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.DTP_EE_DOB)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.TB_EE_Age)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.TB_EE_LastName)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.TB_EE_FirstName)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.LBL_EE_Age)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.LBL_EE_DOB)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.LBL_EE_LastName)
        Me.GB_EE_PrimaryInformation.Controls.Add(Me.LBL_EE_FirstName)
        Me.GB_EE_PrimaryInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_EE_PrimaryInformation.ForeColor = System.Drawing.Color.White
        Me.GB_EE_PrimaryInformation.Location = New System.Drawing.Point(23, 139)
        Me.GB_EE_PrimaryInformation.Name = "GB_EE_PrimaryInformation"
        Me.GB_EE_PrimaryInformation.Size = New System.Drawing.Size(346, 427)
        Me.GB_EE_PrimaryInformation.TabIndex = 26
        Me.GB_EE_PrimaryInformation.TabStop = False
        Me.GB_EE_PrimaryInformation.Text = "1. Primary Information"
        '
        'Tb_EE_Cellphone
        '
        Me.Tb_EE_Cellphone.Location = New System.Drawing.Point(119, 372)
        Me.Tb_EE_Cellphone.Mask = "999-999-9999"
        Me.Tb_EE_Cellphone.Name = "Tb_EE_Cellphone"
        Me.Tb_EE_Cellphone.Size = New System.Drawing.Size(200, 22)
        Me.Tb_EE_Cellphone.TabIndex = 33
        '
        'TB_EE_Telephone
        '
        Me.TB_EE_Telephone.Location = New System.Drawing.Point(119, 337)
        Me.TB_EE_Telephone.Mask = "999-999-9999"
        Me.TB_EE_Telephone.Name = "TB_EE_Telephone"
        Me.TB_EE_Telephone.Size = New System.Drawing.Size(200, 22)
        Me.TB_EE_Telephone.TabIndex = 32
        '
        'TB_EE_PostalCode
        '
        Me.TB_EE_PostalCode.Location = New System.Drawing.Point(119, 298)
        Me.TB_EE_PostalCode.Mask = "?0? 0?0"
        Me.TB_EE_PostalCode.Name = "TB_EE_PostalCode"
        Me.TB_EE_PostalCode.Size = New System.Drawing.Size(200, 22)
        Me.TB_EE_PostalCode.TabIndex = 31
        '
        'TB_EE_Age
        '
        Me.TB_EE_Age.ForeColor = System.Drawing.Color.Black
        Me.TB_EE_Age.Location = New System.Drawing.Point(119, 143)
        Me.TB_EE_Age.Name = "TB_EE_Age"
        Me.TB_EE_Age.Size = New System.Drawing.Size(200, 22)
        Me.TB_EE_Age.TabIndex = 12
        '
        'TB_EE_LastName
        '
        Me.TB_EE_LastName.ForeColor = System.Drawing.Color.Black
        Me.TB_EE_LastName.Location = New System.Drawing.Point(119, 69)
        Me.TB_EE_LastName.Name = "TB_EE_LastName"
        Me.TB_EE_LastName.Size = New System.Drawing.Size(200, 22)
        Me.TB_EE_LastName.TabIndex = 10
        '
        'TB_EE_FirstName
        '
        Me.TB_EE_FirstName.ForeColor = System.Drawing.Color.Black
        Me.TB_EE_FirstName.Location = New System.Drawing.Point(119, 36)
        Me.TB_EE_FirstName.Name = "TB_EE_FirstName"
        Me.TB_EE_FirstName.Size = New System.Drawing.Size(200, 22)
        Me.TB_EE_FirstName.TabIndex = 9
        '
        'LBL_EE_Age
        '
        Me.LBL_EE_Age.AutoSize = True
        Me.LBL_EE_Age.ForeColor = System.Drawing.Color.White
        Me.LBL_EE_Age.Location = New System.Drawing.Point(23, 146)
        Me.LBL_EE_Age.Name = "LBL_EE_Age"
        Me.LBL_EE_Age.Size = New System.Drawing.Size(39, 16)
        Me.LBL_EE_Age.TabIndex = 3
        Me.LBL_EE_Age.Text = "Age :"
        '
        'LBL_EE_DOB
        '
        Me.LBL_EE_DOB.AutoSize = True
        Me.LBL_EE_DOB.ForeColor = System.Drawing.Color.White
        Me.LBL_EE_DOB.Location = New System.Drawing.Point(23, 110)
        Me.LBL_EE_DOB.Name = "LBL_EE_DOB"
        Me.LBL_EE_DOB.Size = New System.Drawing.Size(86, 16)
        Me.LBL_EE_DOB.TabIndex = 2
        Me.LBL_EE_DOB.Text = "Date of Birth :"
        '
        'LBL_EE_LastName
        '
        Me.LBL_EE_LastName.AutoSize = True
        Me.LBL_EE_LastName.ForeColor = System.Drawing.Color.White
        Me.LBL_EE_LastName.Location = New System.Drawing.Point(23, 72)
        Me.LBL_EE_LastName.Name = "LBL_EE_LastName"
        Me.LBL_EE_LastName.Size = New System.Drawing.Size(79, 16)
        Me.LBL_EE_LastName.TabIndex = 1
        Me.LBL_EE_LastName.Text = "Last Name :"
        '
        'LBL_EE_FirstName
        '
        Me.LBL_EE_FirstName.AutoSize = True
        Me.LBL_EE_FirstName.ForeColor = System.Drawing.Color.White
        Me.LBL_EE_FirstName.Location = New System.Drawing.Point(23, 39)
        Me.LBL_EE_FirstName.Name = "LBL_EE_FirstName"
        Me.LBL_EE_FirstName.Size = New System.Drawing.Size(79, 16)
        Me.LBL_EE_FirstName.TabIndex = 0
        Me.LBL_EE_FirstName.Text = "First Name :"
        '
        'LBL_EE_Schooling
        '
        Me.LBL_EE_Schooling.AutoSize = True
        Me.LBL_EE_Schooling.Location = New System.Drawing.Point(31, 159)
        Me.LBL_EE_Schooling.Name = "LBL_EE_Schooling"
        Me.LBL_EE_Schooling.Size = New System.Drawing.Size(74, 16)
        Me.LBL_EE_Schooling.TabIndex = 4
        Me.LBL_EE_Schooling.Text = "Schooling :"
        '
        'GB_EE_HumanResources
        '
        Me.GB_EE_HumanResources.BackColor = System.Drawing.Color.Transparent
        Me.GB_EE_HumanResources.Controls.Add(Me.CB_EE_Schooling)
        Me.GB_EE_HumanResources.Controls.Add(Me.DTP_EE_dateStarted)
        Me.GB_EE_HumanResources.Controls.Add(Me.TB_EE_Salary)
        Me.GB_EE_HumanResources.Controls.Add(Me.TB_EE_SIN)
        Me.GB_EE_HumanResources.Controls.Add(Me.TB_EE_EmployeeNo)
        Me.GB_EE_HumanResources.Controls.Add(Me.LBL_EE_Schooling)
        Me.GB_EE_HumanResources.Controls.Add(Me.LBL_EE_DateStarted)
        Me.GB_EE_HumanResources.Controls.Add(Me.LBL_EE_Salary)
        Me.GB_EE_HumanResources.Controls.Add(Me.LBL_EE_SIN)
        Me.GB_EE_HumanResources.Controls.Add(Me.LBL_EE_EmployeeNo)
        Me.GB_EE_HumanResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_EE_HumanResources.ForeColor = System.Drawing.Color.White
        Me.GB_EE_HumanResources.Location = New System.Drawing.Point(396, 139)
        Me.GB_EE_HumanResources.Name = "GB_EE_HumanResources"
        Me.GB_EE_HumanResources.Size = New System.Drawing.Size(358, 200)
        Me.GB_EE_HumanResources.TabIndex = 27
        Me.GB_EE_HumanResources.TabStop = False
        Me.GB_EE_HumanResources.Text = "2. Human Resources "
        '
        'LBL_EE_DateStarted
        '
        Me.LBL_EE_DateStarted.AutoSize = True
        Me.LBL_EE_DateStarted.Location = New System.Drawing.Point(31, 129)
        Me.LBL_EE_DateStarted.Name = "LBL_EE_DateStarted"
        Me.LBL_EE_DateStarted.Size = New System.Drawing.Size(89, 16)
        Me.LBL_EE_DateStarted.TabIndex = 3
        Me.LBL_EE_DateStarted.Text = "Date Started :"
        '
        'LBL_EE_Salary
        '
        Me.LBL_EE_Salary.AutoSize = True
        Me.LBL_EE_Salary.Location = New System.Drawing.Point(31, 95)
        Me.LBL_EE_Salary.Name = "LBL_EE_Salary"
        Me.LBL_EE_Salary.Size = New System.Drawing.Size(53, 16)
        Me.LBL_EE_Salary.TabIndex = 2
        Me.LBL_EE_Salary.Text = "Salary :"
        '
        'LBL_EE_SIN
        '
        Me.LBL_EE_SIN.AutoSize = True
        Me.LBL_EE_SIN.Location = New System.Drawing.Point(31, 63)
        Me.LBL_EE_SIN.Name = "LBL_EE_SIN"
        Me.LBL_EE_SIN.Size = New System.Drawing.Size(36, 16)
        Me.LBL_EE_SIN.TabIndex = 1
        Me.LBL_EE_SIN.Text = "SIN :"
        '
        'LBL_EE_EmployeeNo
        '
        Me.LBL_EE_EmployeeNo.AutoSize = True
        Me.LBL_EE_EmployeeNo.Location = New System.Drawing.Point(31, 32)
        Me.LBL_EE_EmployeeNo.Name = "LBL_EE_EmployeeNo"
        Me.LBL_EE_EmployeeNo.Size = New System.Drawing.Size(97, 16)
        Me.LBL_EE_EmployeeNo.TabIndex = 0
        Me.LBL_EE_EmployeeNo.Text = "Employee No :"
        '
        'RB_EE_high
        '
        Me.RB_EE_high.AutoSize = True
        Me.RB_EE_high.Location = New System.Drawing.Point(266, 60)
        Me.RB_EE_high.Name = "RB_EE_high"
        Me.RB_EE_high.Size = New System.Drawing.Size(54, 20)
        Me.RB_EE_high.TabIndex = 23
        Me.RB_EE_high.TabStop = True
        Me.RB_EE_high.Text = "High"
        Me.RB_EE_high.UseVisualStyleBackColor = True
        '
        'RB_EE_medium
        '
        Me.RB_EE_medium.AutoSize = True
        Me.RB_EE_medium.Location = New System.Drawing.Point(191, 60)
        Me.RB_EE_medium.Name = "RB_EE_medium"
        Me.RB_EE_medium.Size = New System.Drawing.Size(74, 20)
        Me.RB_EE_medium.TabIndex = 22
        Me.RB_EE_medium.TabStop = True
        Me.RB_EE_medium.Text = "Medium"
        Me.RB_EE_medium.UseVisualStyleBackColor = True
        '
        'TB_EE_Password
        '
        Me.TB_EE_Password.ForeColor = System.Drawing.Color.Black
        Me.TB_EE_Password.Location = New System.Drawing.Point(136, 137)
        Me.TB_EE_Password.Name = "TB_EE_Password"
        Me.TB_EE_Password.Size = New System.Drawing.Size(184, 22)
        Me.TB_EE_Password.TabIndex = 17
        '
        'TB_EE_UserName
        '
        Me.TB_EE_UserName.ForeColor = System.Drawing.Color.Black
        Me.TB_EE_UserName.Location = New System.Drawing.Point(136, 99)
        Me.TB_EE_UserName.Name = "TB_EE_UserName"
        Me.TB_EE_UserName.Size = New System.Drawing.Size(184, 22)
        Me.TB_EE_UserName.TabIndex = 16
        '
        'LBL_EE_Password
        '
        Me.LBL_EE_Password.AutoSize = True
        Me.LBL_EE_Password.Location = New System.Drawing.Point(38, 140)
        Me.LBL_EE_Password.Name = "LBL_EE_Password"
        Me.LBL_EE_Password.Size = New System.Drawing.Size(74, 16)
        Me.LBL_EE_Password.TabIndex = 7
        Me.LBL_EE_Password.Text = "Password :"
        '
        'GB_EE_SystemInformation
        '
        Me.GB_EE_SystemInformation.BackColor = System.Drawing.Color.Transparent
        Me.GB_EE_SystemInformation.Controls.Add(Me.RB_EE_high)
        Me.GB_EE_SystemInformation.Controls.Add(Me.RB_EE_medium)
        Me.GB_EE_SystemInformation.Controls.Add(Me.RB_EE_low)
        Me.GB_EE_SystemInformation.Controls.Add(Me.TB_EE_Password)
        Me.GB_EE_SystemInformation.Controls.Add(Me.TB_EE_UserName)
        Me.GB_EE_SystemInformation.Controls.Add(Me.LBL_EE_Password)
        Me.GB_EE_SystemInformation.Controls.Add(Me.LBL_EE_UserName)
        Me.GB_EE_SystemInformation.Controls.Add(Me.LBL_EE_AccessLevel)
        Me.GB_EE_SystemInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_EE_SystemInformation.ForeColor = System.Drawing.Color.White
        Me.GB_EE_SystemInformation.Location = New System.Drawing.Point(396, 347)
        Me.GB_EE_SystemInformation.Name = "GB_EE_SystemInformation"
        Me.GB_EE_SystemInformation.Size = New System.Drawing.Size(358, 219)
        Me.GB_EE_SystemInformation.TabIndex = 28
        Me.GB_EE_SystemInformation.TabStop = False
        Me.GB_EE_SystemInformation.Text = "3. System Information "
        '
        'RB_EE_low
        '
        Me.RB_EE_low.AutoSize = True
        Me.RB_EE_low.Location = New System.Drawing.Point(138, 60)
        Me.RB_EE_low.Name = "RB_EE_low"
        Me.RB_EE_low.Size = New System.Drawing.Size(50, 20)
        Me.RB_EE_low.TabIndex = 21
        Me.RB_EE_low.TabStop = True
        Me.RB_EE_low.Text = "Low"
        Me.RB_EE_low.UseVisualStyleBackColor = True
        '
        'LBL_EE_UserName
        '
        Me.LBL_EE_UserName.AutoSize = True
        Me.LBL_EE_UserName.Location = New System.Drawing.Point(38, 102)
        Me.LBL_EE_UserName.Name = "LBL_EE_UserName"
        Me.LBL_EE_UserName.Size = New System.Drawing.Size(83, 16)
        Me.LBL_EE_UserName.TabIndex = 6
        Me.LBL_EE_UserName.Text = "User Name :"
        '
        'LBL_EE_AccessLevel
        '
        Me.LBL_EE_AccessLevel.AutoSize = True
        Me.LBL_EE_AccessLevel.Location = New System.Drawing.Point(38, 62)
        Me.LBL_EE_AccessLevel.Name = "LBL_EE_AccessLevel"
        Me.LBL_EE_AccessLevel.Size = New System.Drawing.Size(95, 16)
        Me.LBL_EE_AccessLevel.TabIndex = 5
        Me.LBL_EE_AccessLevel.Text = "Access Level :"
        '
        'GB_EE_ChooseEmployee
        '
        Me.GB_EE_ChooseEmployee.Controls.Add(Me.BTN_EE_Search)
        Me.GB_EE_ChooseEmployee.Controls.Add(Me.TB_EE_SearchEmp)
        Me.GB_EE_ChooseEmployee.Controls.Add(Me.LBL_EE_Employee)
        Me.GB_EE_ChooseEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_EE_ChooseEmployee.ForeColor = System.Drawing.Color.White
        Me.GB_EE_ChooseEmployee.Location = New System.Drawing.Point(23, 78)
        Me.GB_EE_ChooseEmployee.Name = "GB_EE_ChooseEmployee"
        Me.GB_EE_ChooseEmployee.Size = New System.Drawing.Size(731, 55)
        Me.GB_EE_ChooseEmployee.TabIndex = 25
        Me.GB_EE_ChooseEmployee.TabStop = False
        Me.GB_EE_ChooseEmployee.Text = "Choose an employee"
        '
        'BTN_EE_cancel
        '
        Me.BTN_EE_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_EE_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EE_cancel.ForeColor = System.Drawing.Color.Black
        Me.BTN_EE_cancel.Location = New System.Drawing.Point(282, 597)
        Me.BTN_EE_cancel.Name = "BTN_EE_cancel"
        Me.BTN_EE_cancel.Size = New System.Drawing.Size(92, 32)
        Me.BTN_EE_cancel.TabIndex = 30
        Me.BTN_EE_cancel.Text = "Cancel"
        Me.BTN_EE_cancel.UseVisualStyleBackColor = False
        '
        'BTN_EE_Edit
        '
        Me.BTN_EE_Edit.BackColor = System.Drawing.Color.Yellow
        Me.BTN_EE_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EE_Edit.Location = New System.Drawing.Point(401, 597)
        Me.BTN_EE_Edit.Name = "BTN_EE_Edit"
        Me.BTN_EE_Edit.Size = New System.Drawing.Size(92, 32)
        Me.BTN_EE_Edit.TabIndex = 29
        Me.BTN_EE_Edit.Text = "Edit"
        Me.BTN_EE_Edit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LBL_NewEmployee)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 67)
        Me.Panel1.TabIndex = 32
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(27, 576)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(151, 22)
        Me.CheckBox1.TabIndex = 31
        Me.CheckBox1.Text = "InActive Account"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'EditEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(781, 643)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GB_EE_PrimaryInformation)
        Me.Controls.Add(Me.GB_EE_HumanResources)
        Me.Controls.Add(Me.GB_EE_SystemInformation)
        Me.Controls.Add(Me.GB_EE_ChooseEmployee)
        Me.Controls.Add(Me.BTN_EE_cancel)
        Me.Controls.Add(Me.BTN_EE_Edit)
        Me.Name = "EditEmployee"
        Me.Text = "EditEmployee"
        Me.GB_EE_PrimaryInformation.ResumeLayout(False)
        Me.GB_EE_PrimaryInformation.PerformLayout()
        Me.GB_EE_HumanResources.ResumeLayout(False)
        Me.GB_EE_HumanResources.PerformLayout()
        Me.GB_EE_SystemInformation.ResumeLayout(False)
        Me.GB_EE_SystemInformation.PerformLayout()
        Me.GB_EE_ChooseEmployee.ResumeLayout(False)
        Me.GB_EE_ChooseEmployee.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_EE_Schooling As ComboBox
    Friend WithEvents DTP_EE_dateStarted As DateTimePicker
    Friend WithEvents TB_EE_Salary As TextBox
    Friend WithEvents TB_EE_SIN As TextBox
    Friend WithEvents TB_EE_EmployeeNo As TextBox
    Friend WithEvents TB_EE_Provience As TextBox
    Friend WithEvents TB_EE_City As TextBox
    Friend WithEvents TB_EE_Address As TextBox
    Friend WithEvents LBL_NewEmployee As Label
    Friend WithEvents LBL_EE_Telephone As Label
    Friend WithEvents LBL_EE_PostalCode As Label
    Friend WithEvents LBL_EE_Provience As Label
    Friend WithEvents DTP_EE_DOB As DateTimePicker
    Friend WithEvents LBL_EE_Employee As Label
    Friend WithEvents LBL_EE_City As Label
    Friend WithEvents LBL_EE_Address As Label
    Friend WithEvents BTN_EE_Search As Button
    Friend WithEvents TB_EE_SearchEmp As TextBox
    Friend WithEvents GB_EE_PrimaryInformation As GroupBox
    Friend WithEvents TB_EE_Age As TextBox
    Friend WithEvents TB_EE_LastName As TextBox
    Friend WithEvents TB_EE_FirstName As TextBox
    Friend WithEvents LBL_EE_Age As Label
    Friend WithEvents LBL_EE_DOB As Label
    Friend WithEvents LBL_EE_LastName As Label
    Friend WithEvents LBL_EE_FirstName As Label
    Friend WithEvents LBL_EE_Schooling As Label
    Friend WithEvents GB_EE_HumanResources As GroupBox
    Friend WithEvents LBL_EE_DateStarted As Label
    Friend WithEvents LBL_EE_Salary As Label
    Friend WithEvents LBL_EE_SIN As Label
    Friend WithEvents LBL_EE_EmployeeNo As Label
    Friend WithEvents RB_EE_high As RadioButton
    Friend WithEvents RB_EE_medium As RadioButton
    Friend WithEvents TB_EE_Password As TextBox
    Friend WithEvents TB_EE_UserName As TextBox
    Friend WithEvents LBL_EE_Password As Label
    Friend WithEvents GB_EE_SystemInformation As GroupBox
    Friend WithEvents RB_EE_low As RadioButton
    Friend WithEvents LBL_EE_UserName As Label
    Friend WithEvents LBL_EE_AccessLevel As Label
    Friend WithEvents GB_EE_ChooseEmployee As GroupBox
    Friend WithEvents BTN_EE_cancel As Button
    Friend WithEvents BTN_EE_Edit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TB_EE_PostalCode As MaskedTextBox
    Friend WithEvents Tb_EE_Cellphone As MaskedTextBox
    Friend WithEvents TB_EE_Telephone As MaskedTextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
