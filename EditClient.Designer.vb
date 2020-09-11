<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditClient
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
        Me.BTN_EC_Cancel = New System.Windows.Forms.Button()
        Me.BTN_EC_Edit = New System.Windows.Forms.Button()
        Me.TB_EC_Province = New System.Windows.Forms.TextBox()
        Me.TB_EC_city = New System.Windows.Forms.TextBox()
        Me.TB_EC_Address = New System.Windows.Forms.TextBox()
        Me.LBL_EC_PostalCode = New System.Windows.Forms.Label()
        Me.LBL_EC_Province = New System.Windows.Forms.Label()
        Me.LBL_EC_city = New System.Windows.Forms.Label()
        Me.LBL_EC_Address = New System.Windows.Forms.Label()
        Me.DTP_EC_DOB = New System.Windows.Forms.DateTimePicker()
        Me.LBL_EC_DOB = New System.Windows.Forms.Label()
        Me.TB_EC_Email = New System.Windows.Forms.TextBox()
        Me.LBL_EC_Email = New System.Windows.Forms.Label()
        Me.LBL_EC_Telephone = New System.Windows.Forms.Label()
        Me.TB_EC_LastName = New System.Windows.Forms.TextBox()
        Me.TB_EC_FirstName = New System.Windows.Forms.TextBox()
        Me.LBL_EC_LastName = New System.Windows.Forms.Label()
        Me.LBL_EC_FirstName = New System.Windows.Forms.Label()
        Me.LBL_EditClient = New System.Windows.Forms.Label()
        Me.GB_EC_ChooseClient = New System.Windows.Forms.GroupBox()
        Me.BTN_EC_Search = New System.Windows.Forms.Button()
        Me.TB_EC_Client = New System.Windows.Forms.TextBox()
        Me.LBL_EC_Client = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TB_EC_PostalCode = New System.Windows.Forms.MaskedTextBox()
        Me.TB_EC_Telephone = New System.Windows.Forms.MaskedTextBox()
        Me.GB_EC_ChooseClient.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_EC_Cancel
        '
        Me.BTN_EC_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_EC_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EC_Cancel.Location = New System.Drawing.Point(96, 530)
        Me.BTN_EC_Cancel.Name = "BTN_EC_Cancel"
        Me.BTN_EC_Cancel.Size = New System.Drawing.Size(92, 32)
        Me.BTN_EC_Cancel.TabIndex = 62
        Me.BTN_EC_Cancel.Text = "Cancel"
        Me.BTN_EC_Cancel.UseVisualStyleBackColor = False
        '
        'BTN_EC_Edit
        '
        Me.BTN_EC_Edit.BackColor = System.Drawing.Color.Yellow
        Me.BTN_EC_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EC_Edit.Location = New System.Drawing.Point(224, 530)
        Me.BTN_EC_Edit.Name = "BTN_EC_Edit"
        Me.BTN_EC_Edit.Size = New System.Drawing.Size(92, 32)
        Me.BTN_EC_Edit.TabIndex = 61
        Me.BTN_EC_Edit.Text = "Edit"
        Me.BTN_EC_Edit.UseVisualStyleBackColor = False
        '
        'TB_EC_Province
        '
        Me.TB_EC_Province.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_EC_Province.ForeColor = System.Drawing.Color.Black
        Me.TB_EC_Province.Location = New System.Drawing.Point(165, 445)
        Me.TB_EC_Province.Name = "TB_EC_Province"
        Me.TB_EC_Province.Size = New System.Drawing.Size(200, 22)
        Me.TB_EC_Province.TabIndex = 57
        '
        'TB_EC_city
        '
        Me.TB_EC_city.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_EC_city.ForeColor = System.Drawing.Color.Black
        Me.TB_EC_city.Location = New System.Drawing.Point(165, 403)
        Me.TB_EC_city.Name = "TB_EC_city"
        Me.TB_EC_city.Size = New System.Drawing.Size(200, 22)
        Me.TB_EC_city.TabIndex = 56
        '
        'TB_EC_Address
        '
        Me.TB_EC_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_EC_Address.ForeColor = System.Drawing.Color.Black
        Me.TB_EC_Address.Location = New System.Drawing.Point(165, 362)
        Me.TB_EC_Address.Name = "TB_EC_Address"
        Me.TB_EC_Address.Size = New System.Drawing.Size(200, 22)
        Me.TB_EC_Address.TabIndex = 55
        '
        'LBL_EC_PostalCode
        '
        Me.LBL_EC_PostalCode.AutoSize = True
        Me.LBL_EC_PostalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EC_PostalCode.ForeColor = System.Drawing.Color.White
        Me.LBL_EC_PostalCode.Location = New System.Drawing.Point(65, 490)
        Me.LBL_EC_PostalCode.Name = "LBL_EC_PostalCode"
        Me.LBL_EC_PostalCode.Size = New System.Drawing.Size(88, 16)
        Me.LBL_EC_PostalCode.TabIndex = 54
        Me.LBL_EC_PostalCode.Text = "Postal Code :"
        '
        'LBL_EC_Province
        '
        Me.LBL_EC_Province.AutoSize = True
        Me.LBL_EC_Province.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EC_Province.ForeColor = System.Drawing.Color.White
        Me.LBL_EC_Province.Location = New System.Drawing.Point(65, 448)
        Me.LBL_EC_Province.Name = "LBL_EC_Province"
        Me.LBL_EC_Province.Size = New System.Drawing.Size(67, 16)
        Me.LBL_EC_Province.TabIndex = 53
        Me.LBL_EC_Province.Text = "Province :"
        '
        'LBL_EC_city
        '
        Me.LBL_EC_city.AutoSize = True
        Me.LBL_EC_city.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EC_city.ForeColor = System.Drawing.Color.White
        Me.LBL_EC_city.Location = New System.Drawing.Point(65, 406)
        Me.LBL_EC_city.Name = "LBL_EC_city"
        Me.LBL_EC_city.Size = New System.Drawing.Size(36, 16)
        Me.LBL_EC_city.TabIndex = 52
        Me.LBL_EC_city.Text = "City :"
        '
        'LBL_EC_Address
        '
        Me.LBL_EC_Address.AutoSize = True
        Me.LBL_EC_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EC_Address.ForeColor = System.Drawing.Color.White
        Me.LBL_EC_Address.Location = New System.Drawing.Point(65, 365)
        Me.LBL_EC_Address.Name = "LBL_EC_Address"
        Me.LBL_EC_Address.Size = New System.Drawing.Size(65, 16)
        Me.LBL_EC_Address.TabIndex = 51
        Me.LBL_EC_Address.Text = "Address :"
        '
        'DTP_EC_DOB
        '
        Me.DTP_EC_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_EC_DOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_EC_DOB.Location = New System.Drawing.Point(165, 318)
        Me.DTP_EC_DOB.Name = "DTP_EC_DOB"
        Me.DTP_EC_DOB.Size = New System.Drawing.Size(200, 22)
        Me.DTP_EC_DOB.TabIndex = 50
        Me.DTP_EC_DOB.Value = New Date(2019, 10, 23, 11, 28, 6, 0)
        '
        'LBL_EC_DOB
        '
        Me.LBL_EC_DOB.AutoSize = True
        Me.LBL_EC_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EC_DOB.ForeColor = System.Drawing.Color.White
        Me.LBL_EC_DOB.Location = New System.Drawing.Point(65, 322)
        Me.LBL_EC_DOB.Name = "LBL_EC_DOB"
        Me.LBL_EC_DOB.Size = New System.Drawing.Size(86, 16)
        Me.LBL_EC_DOB.TabIndex = 49
        Me.LBL_EC_DOB.Text = "Date of Birth :"
        '
        'TB_EC_Email
        '
        Me.TB_EC_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_EC_Email.ForeColor = System.Drawing.Color.Black
        Me.TB_EC_Email.Location = New System.Drawing.Point(165, 232)
        Me.TB_EC_Email.Name = "TB_EC_Email"
        Me.TB_EC_Email.Size = New System.Drawing.Size(200, 22)
        Me.TB_EC_Email.TabIndex = 48
        '
        'LBL_EC_Email
        '
        Me.LBL_EC_Email.AutoSize = True
        Me.LBL_EC_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EC_Email.ForeColor = System.Drawing.Color.White
        Me.LBL_EC_Email.Location = New System.Drawing.Point(65, 235)
        Me.LBL_EC_Email.Name = "LBL_EC_Email"
        Me.LBL_EC_Email.Size = New System.Drawing.Size(48, 16)
        Me.LBL_EC_Email.TabIndex = 47
        Me.LBL_EC_Email.Text = "Email :"
        '
        'LBL_EC_Telephone
        '
        Me.LBL_EC_Telephone.AutoSize = True
        Me.LBL_EC_Telephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EC_Telephone.ForeColor = System.Drawing.Color.White
        Me.LBL_EC_Telephone.Location = New System.Drawing.Point(65, 277)
        Me.LBL_EC_Telephone.Name = "LBL_EC_Telephone"
        Me.LBL_EC_Telephone.Size = New System.Drawing.Size(80, 16)
        Me.LBL_EC_Telephone.TabIndex = 45
        Me.LBL_EC_Telephone.Text = "Telephone :"
        '
        'TB_EC_LastName
        '
        Me.TB_EC_LastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_EC_LastName.ForeColor = System.Drawing.Color.Black
        Me.TB_EC_LastName.Location = New System.Drawing.Point(165, 190)
        Me.TB_EC_LastName.Name = "TB_EC_LastName"
        Me.TB_EC_LastName.Size = New System.Drawing.Size(200, 22)
        Me.TB_EC_LastName.TabIndex = 44
        '
        'TB_EC_FirstName
        '
        Me.TB_EC_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_EC_FirstName.ForeColor = System.Drawing.Color.Black
        Me.TB_EC_FirstName.Location = New System.Drawing.Point(165, 151)
        Me.TB_EC_FirstName.Name = "TB_EC_FirstName"
        Me.TB_EC_FirstName.Size = New System.Drawing.Size(200, 22)
        Me.TB_EC_FirstName.TabIndex = 43
        '
        'LBL_EC_LastName
        '
        Me.LBL_EC_LastName.AutoSize = True
        Me.LBL_EC_LastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EC_LastName.ForeColor = System.Drawing.Color.White
        Me.LBL_EC_LastName.Location = New System.Drawing.Point(65, 193)
        Me.LBL_EC_LastName.Name = "LBL_EC_LastName"
        Me.LBL_EC_LastName.Size = New System.Drawing.Size(79, 16)
        Me.LBL_EC_LastName.TabIndex = 42
        Me.LBL_EC_LastName.Text = "Last Name :"
        '
        'LBL_EC_FirstName
        '
        Me.LBL_EC_FirstName.AutoSize = True
        Me.LBL_EC_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EC_FirstName.ForeColor = System.Drawing.Color.White
        Me.LBL_EC_FirstName.Location = New System.Drawing.Point(65, 154)
        Me.LBL_EC_FirstName.Name = "LBL_EC_FirstName"
        Me.LBL_EC_FirstName.Size = New System.Drawing.Size(79, 16)
        Me.LBL_EC_FirstName.TabIndex = 41
        Me.LBL_EC_FirstName.Text = "First Name :"
        '
        'LBL_EditClient
        '
        Me.LBL_EditClient.AutoSize = True
        Me.LBL_EditClient.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EditClient.ForeColor = System.Drawing.Color.Yellow
        Me.LBL_EditClient.Location = New System.Drawing.Point(132, 18)
        Me.LBL_EditClient.Name = "LBL_EditClient"
        Me.LBL_EditClient.Size = New System.Drawing.Size(176, 30)
        Me.LBL_EditClient.TabIndex = 40
        Me.LBL_EditClient.Text = "Edit Client"
        '
        'GB_EC_ChooseClient
        '
        Me.GB_EC_ChooseClient.Controls.Add(Me.BTN_EC_Search)
        Me.GB_EC_ChooseClient.Controls.Add(Me.TB_EC_Client)
        Me.GB_EC_ChooseClient.Controls.Add(Me.LBL_EC_Client)
        Me.GB_EC_ChooseClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_EC_ChooseClient.ForeColor = System.Drawing.Color.White
        Me.GB_EC_ChooseClient.Location = New System.Drawing.Point(12, 80)
        Me.GB_EC_ChooseClient.Name = "GB_EC_ChooseClient"
        Me.GB_EC_ChooseClient.Size = New System.Drawing.Size(408, 55)
        Me.GB_EC_ChooseClient.TabIndex = 63
        Me.GB_EC_ChooseClient.TabStop = False
        Me.GB_EC_ChooseClient.Text = "Choose an client"
        '
        'BTN_EC_Search
        '
        Me.BTN_EC_Search.ForeColor = System.Drawing.Color.Black
        Me.BTN_EC_Search.Location = New System.Drawing.Point(320, 21)
        Me.BTN_EC_Search.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_EC_Search.Name = "BTN_EC_Search"
        Me.BTN_EC_Search.Size = New System.Drawing.Size(71, 22)
        Me.BTN_EC_Search.TabIndex = 3
        Me.BTN_EC_Search.Text = "Search"
        Me.BTN_EC_Search.UseVisualStyleBackColor = True
        '
        'TB_EC_Client
        '
        Me.TB_EC_Client.ForeColor = System.Drawing.Color.Black
        Me.TB_EC_Client.Location = New System.Drawing.Point(92, 21)
        Me.TB_EC_Client.Name = "TB_EC_Client"
        Me.TB_EC_Client.Size = New System.Drawing.Size(210, 22)
        Me.TB_EC_Client.TabIndex = 1
        '
        'LBL_EC_Client
        '
        Me.LBL_EC_Client.AutoSize = True
        Me.LBL_EC_Client.Location = New System.Drawing.Point(27, 23)
        Me.LBL_EC_Client.Name = "LBL_EC_Client"
        Me.LBL_EC_Client.Size = New System.Drawing.Size(47, 16)
        Me.LBL_EC_Client.TabIndex = 0
        Me.LBL_EC_Client.Text = "Client :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LBL_EditClient)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 67)
        Me.Panel1.TabIndex = 64
        '
        'TB_EC_PostalCode
        '
        Me.TB_EC_PostalCode.Location = New System.Drawing.Point(165, 489)
        Me.TB_EC_PostalCode.Mask = "?0? 0?0"
        Me.TB_EC_PostalCode.Name = "TB_EC_PostalCode"
        Me.TB_EC_PostalCode.Size = New System.Drawing.Size(200, 20)
        Me.TB_EC_PostalCode.TabIndex = 65
        '
        'TB_EC_Telephone
        '
        Me.TB_EC_Telephone.Location = New System.Drawing.Point(165, 276)
        Me.TB_EC_Telephone.Mask = "999-999-9999"
        Me.TB_EC_Telephone.Name = "TB_EC_Telephone"
        Me.TB_EC_Telephone.Size = New System.Drawing.Size(200, 20)
        Me.TB_EC_Telephone.TabIndex = 66
        '
        'EditClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(432, 584)
        Me.Controls.Add(Me.TB_EC_Telephone)
        Me.Controls.Add(Me.TB_EC_PostalCode)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GB_EC_ChooseClient)
        Me.Controls.Add(Me.BTN_EC_Cancel)
        Me.Controls.Add(Me.BTN_EC_Edit)
        Me.Controls.Add(Me.TB_EC_Province)
        Me.Controls.Add(Me.TB_EC_city)
        Me.Controls.Add(Me.TB_EC_Address)
        Me.Controls.Add(Me.LBL_EC_PostalCode)
        Me.Controls.Add(Me.LBL_EC_Province)
        Me.Controls.Add(Me.LBL_EC_city)
        Me.Controls.Add(Me.LBL_EC_Address)
        Me.Controls.Add(Me.DTP_EC_DOB)
        Me.Controls.Add(Me.LBL_EC_DOB)
        Me.Controls.Add(Me.TB_EC_Email)
        Me.Controls.Add(Me.LBL_EC_Email)
        Me.Controls.Add(Me.LBL_EC_Telephone)
        Me.Controls.Add(Me.TB_EC_LastName)
        Me.Controls.Add(Me.TB_EC_FirstName)
        Me.Controls.Add(Me.LBL_EC_LastName)
        Me.Controls.Add(Me.LBL_EC_FirstName)
        Me.Name = "EditClient"
        Me.Text = "EditClient"
        Me.GB_EC_ChooseClient.ResumeLayout(False)
        Me.GB_EC_ChooseClient.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_EC_Cancel As Button
    Friend WithEvents BTN_EC_Edit As Button
    Friend WithEvents TB_EC_Province As TextBox
    Friend WithEvents TB_EC_city As TextBox
    Friend WithEvents TB_EC_Address As TextBox
    Friend WithEvents LBL_EC_PostalCode As Label
    Friend WithEvents LBL_EC_Province As Label
    Friend WithEvents LBL_EC_city As Label
    Friend WithEvents LBL_EC_Address As Label
    Friend WithEvents DTP_EC_DOB As DateTimePicker
    Friend WithEvents LBL_EC_DOB As Label
    Friend WithEvents TB_EC_Email As TextBox
    Friend WithEvents LBL_EC_Email As Label
    Friend WithEvents LBL_EC_Telephone As Label
    Friend WithEvents TB_EC_LastName As TextBox
    Friend WithEvents TB_EC_FirstName As TextBox
    Friend WithEvents LBL_EC_LastName As Label
    Friend WithEvents LBL_EC_FirstName As Label
    Friend WithEvents LBL_EditClient As Label
    Friend WithEvents GB_EC_ChooseClient As GroupBox
    Friend WithEvents TB_EC_Client As TextBox
    Friend WithEvents LBL_EC_Client As Label
    Friend WithEvents BTN_EC_Search As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TB_EC_PostalCode As MaskedTextBox
    Friend WithEvents TB_EC_Telephone As MaskedTextBox
End Class
