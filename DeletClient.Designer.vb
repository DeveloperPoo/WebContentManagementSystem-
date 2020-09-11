<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteClient
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
        Me.GB_DC_ChooseClient = New System.Windows.Forms.GroupBox()
        Me.BTN_DC_Search = New System.Windows.Forms.Button()
        Me.TB_DC_Client = New System.Windows.Forms.TextBox()
        Me.LBL_DC_Client = New System.Windows.Forms.Label()
        Me.BTN_DC_Cancel = New System.Windows.Forms.Button()
        Me.TB_DC_PostalCode = New System.Windows.Forms.TextBox()
        Me.TB_DC_Province = New System.Windows.Forms.TextBox()
        Me.TB_DC_city = New System.Windows.Forms.TextBox()
        Me.TB_DC_Address = New System.Windows.Forms.TextBox()
        Me.LBL_DC_PostalCode = New System.Windows.Forms.Label()
        Me.LBL_DC_Province = New System.Windows.Forms.Label()
        Me.LBL_DC_city = New System.Windows.Forms.Label()
        Me.LBL_DC_Address = New System.Windows.Forms.Label()
        Me.DTP_DC_DOB = New System.Windows.Forms.DateTimePicker()
        Me.LBL_DC_DOB = New System.Windows.Forms.Label()
        Me.TB_DC_Email = New System.Windows.Forms.TextBox()
        Me.LBL_DC_Email = New System.Windows.Forms.Label()
        Me.TB_DC_Telephone = New System.Windows.Forms.TextBox()
        Me.LBL_DC_Telephone = New System.Windows.Forms.Label()
        Me.TB_DC_LastName = New System.Windows.Forms.TextBox()
        Me.TB_DC_FirstName = New System.Windows.Forms.TextBox()
        Me.LBL_DC_LastName = New System.Windows.Forms.Label()
        Me.LBL_DC_FirstName = New System.Windows.Forms.Label()
        Me.LBL_DeleteClient = New System.Windows.Forms.Label()
        Me.BTN_DC_Delete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GB_DC_ChooseClient.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_DC_ChooseClient
        '
        Me.GB_DC_ChooseClient.BackColor = System.Drawing.Color.Transparent
        Me.GB_DC_ChooseClient.Controls.Add(Me.BTN_DC_Search)
        Me.GB_DC_ChooseClient.Controls.Add(Me.TB_DC_Client)
        Me.GB_DC_ChooseClient.Controls.Add(Me.LBL_DC_Client)
        Me.GB_DC_ChooseClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_DC_ChooseClient.ForeColor = System.Drawing.Color.White
        Me.GB_DC_ChooseClient.Location = New System.Drawing.Point(20, 94)
        Me.GB_DC_ChooseClient.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GB_DC_ChooseClient.Name = "GB_DC_ChooseClient"
        Me.GB_DC_ChooseClient.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GB_DC_ChooseClient.Size = New System.Drawing.Size(523, 60)
        Me.GB_DC_ChooseClient.TabIndex = 87
        Me.GB_DC_ChooseClient.TabStop = False
        Me.GB_DC_ChooseClient.Text = "Choose an client"
        '
        'BTN_DC_Search
        '
        Me.BTN_DC_Search.ForeColor = System.Drawing.Color.Black
        Me.BTN_DC_Search.Location = New System.Drawing.Point(428, 21)
        Me.BTN_DC_Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_DC_Search.Name = "BTN_DC_Search"
        Me.BTN_DC_Search.Size = New System.Drawing.Size(85, 30)
        Me.BTN_DC_Search.TabIndex = 3
        Me.BTN_DC_Search.Text = "Search"
        Me.BTN_DC_Search.UseVisualStyleBackColor = True
        '
        'TB_DC_Client
        '
        Me.TB_DC_Client.ForeColor = System.Drawing.Color.Black
        Me.TB_DC_Client.Location = New System.Drawing.Point(132, 22)
        Me.TB_DC_Client.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_DC_Client.Name = "TB_DC_Client"
        Me.TB_DC_Client.Size = New System.Drawing.Size(279, 26)
        Me.TB_DC_Client.TabIndex = 1
        '
        'LBL_DC_Client
        '
        Me.LBL_DC_Client.AutoSize = True
        Me.LBL_DC_Client.Location = New System.Drawing.Point(44, 25)
        Me.LBL_DC_Client.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_DC_Client.Name = "LBL_DC_Client"
        Me.LBL_DC_Client.Size = New System.Drawing.Size(62, 20)
        Me.LBL_DC_Client.TabIndex = 0
        Me.LBL_DC_Client.Text = "Client :"
        '
        'BTN_DC_Cancel
        '
        Me.BTN_DC_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_DC_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DC_Cancel.ForeColor = System.Drawing.Color.Black
        Me.BTN_DC_Cancel.Location = New System.Drawing.Point(127, 640)
        Me.BTN_DC_Cancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_DC_Cancel.Name = "BTN_DC_Cancel"
        Me.BTN_DC_Cancel.Size = New System.Drawing.Size(123, 39)
        Me.BTN_DC_Cancel.TabIndex = 86
        Me.BTN_DC_Cancel.Text = "Cancel"
        Me.BTN_DC_Cancel.UseVisualStyleBackColor = False
        '
        'TB_DC_PostalCode
        '
        Me.TB_DC_PostalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_DC_PostalCode.ForeColor = System.Drawing.Color.Black
        Me.TB_DC_PostalCode.Location = New System.Drawing.Point(192, 583)
        Me.TB_DC_PostalCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_DC_PostalCode.Name = "TB_DC_PostalCode"
        Me.TB_DC_PostalCode.Size = New System.Drawing.Size(265, 26)
        Me.TB_DC_PostalCode.TabIndex = 82
        '
        'TB_DC_Province
        '
        Me.TB_DC_Province.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_DC_Province.ForeColor = System.Drawing.Color.Black
        Me.TB_DC_Province.Location = New System.Drawing.Point(192, 530)
        Me.TB_DC_Province.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_DC_Province.Name = "TB_DC_Province"
        Me.TB_DC_Province.Size = New System.Drawing.Size(265, 26)
        Me.TB_DC_Province.TabIndex = 81
        '
        'TB_DC_city
        '
        Me.TB_DC_city.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_DC_city.ForeColor = System.Drawing.Color.Black
        Me.TB_DC_city.Location = New System.Drawing.Point(192, 480)
        Me.TB_DC_city.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_DC_city.Name = "TB_DC_city"
        Me.TB_DC_city.Size = New System.Drawing.Size(265, 26)
        Me.TB_DC_city.TabIndex = 80
        '
        'TB_DC_Address
        '
        Me.TB_DC_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_DC_Address.ForeColor = System.Drawing.Color.Black
        Me.TB_DC_Address.Location = New System.Drawing.Point(192, 430)
        Me.TB_DC_Address.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_DC_Address.Name = "TB_DC_Address"
        Me.TB_DC_Address.Size = New System.Drawing.Size(265, 26)
        Me.TB_DC_Address.TabIndex = 79
        '
        'LBL_DC_PostalCode
        '
        Me.LBL_DC_PostalCode.AutoSize = True
        Me.LBL_DC_PostalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DC_PostalCode.ForeColor = System.Drawing.Color.White
        Me.LBL_DC_PostalCode.Location = New System.Drawing.Point(69, 587)
        Me.LBL_DC_PostalCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_DC_PostalCode.Name = "LBL_DC_PostalCode"
        Me.LBL_DC_PostalCode.Size = New System.Drawing.Size(110, 20)
        Me.LBL_DC_PostalCode.TabIndex = 78
        Me.LBL_DC_PostalCode.Text = "Postal Code :"
        '
        'LBL_DC_Province
        '
        Me.LBL_DC_Province.AutoSize = True
        Me.LBL_DC_Province.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DC_Province.ForeColor = System.Drawing.Color.White
        Me.LBL_DC_Province.Location = New System.Drawing.Point(69, 535)
        Me.LBL_DC_Province.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_DC_Province.Name = "LBL_DC_Province"
        Me.LBL_DC_Province.Size = New System.Drawing.Size(84, 20)
        Me.LBL_DC_Province.TabIndex = 77
        Me.LBL_DC_Province.Text = "Province :"
        '
        'LBL_DC_city
        '
        Me.LBL_DC_city.AutoSize = True
        Me.LBL_DC_city.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DC_city.ForeColor = System.Drawing.Color.White
        Me.LBL_DC_city.Location = New System.Drawing.Point(69, 484)
        Me.LBL_DC_city.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_DC_city.Name = "LBL_DC_city"
        Me.LBL_DC_city.Size = New System.Drawing.Size(48, 20)
        Me.LBL_DC_city.TabIndex = 76
        Me.LBL_DC_city.Text = "City :"
        '
        'LBL_DC_Address
        '
        Me.LBL_DC_Address.AutoSize = True
        Me.LBL_DC_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DC_Address.ForeColor = System.Drawing.Color.White
        Me.LBL_DC_Address.Location = New System.Drawing.Point(69, 433)
        Me.LBL_DC_Address.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_DC_Address.Name = "LBL_DC_Address"
        Me.LBL_DC_Address.Size = New System.Drawing.Size(81, 20)
        Me.LBL_DC_Address.TabIndex = 75
        Me.LBL_DC_Address.Text = "Address :"
        '
        'DTP_DC_DOB
        '
        Me.DTP_DC_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_DC_DOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_DC_DOB.Location = New System.Drawing.Point(192, 378)
        Me.DTP_DC_DOB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DTP_DC_DOB.Name = "DTP_DC_DOB"
        Me.DTP_DC_DOB.Size = New System.Drawing.Size(265, 26)
        Me.DTP_DC_DOB.TabIndex = 74
        Me.DTP_DC_DOB.Value = New Date(2019, 10, 23, 11, 28, 6, 0)
        '
        'LBL_DC_DOB
        '
        Me.LBL_DC_DOB.AutoSize = True
        Me.LBL_DC_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DC_DOB.ForeColor = System.Drawing.Color.White
        Me.LBL_DC_DOB.Location = New System.Drawing.Point(69, 380)
        Me.LBL_DC_DOB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_DC_DOB.Name = "LBL_DC_DOB"
        Me.LBL_DC_DOB.Size = New System.Drawing.Size(115, 20)
        Me.LBL_DC_DOB.TabIndex = 73
        Me.LBL_DC_DOB.Text = "Date of Birth :"
        '
        'TB_DC_Email
        '
        Me.TB_DC_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_DC_Email.ForeColor = System.Drawing.Color.Black
        Me.TB_DC_Email.Location = New System.Drawing.Point(192, 270)
        Me.TB_DC_Email.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_DC_Email.Name = "TB_DC_Email"
        Me.TB_DC_Email.Size = New System.Drawing.Size(265, 26)
        Me.TB_DC_Email.TabIndex = 72
        '
        'LBL_DC_Email
        '
        Me.LBL_DC_Email.AutoSize = True
        Me.LBL_DC_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DC_Email.ForeColor = System.Drawing.Color.White
        Me.LBL_DC_Email.Location = New System.Drawing.Point(69, 273)
        Me.LBL_DC_Email.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_DC_Email.Name = "LBL_DC_Email"
        Me.LBL_DC_Email.Size = New System.Drawing.Size(61, 20)
        Me.LBL_DC_Email.TabIndex = 71
        Me.LBL_DC_Email.Text = "Email :"
        '
        'TB_DC_Telephone
        '
        Me.TB_DC_Telephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_DC_Telephone.ForeColor = System.Drawing.Color.Black
        Me.TB_DC_Telephone.Location = New System.Drawing.Point(192, 321)
        Me.TB_DC_Telephone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_DC_Telephone.Name = "TB_DC_Telephone"
        Me.TB_DC_Telephone.Size = New System.Drawing.Size(265, 26)
        Me.TB_DC_Telephone.TabIndex = 70
        '
        'LBL_DC_Telephone
        '
        Me.LBL_DC_Telephone.AutoSize = True
        Me.LBL_DC_Telephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DC_Telephone.ForeColor = System.Drawing.Color.White
        Me.LBL_DC_Telephone.Location = New System.Drawing.Point(69, 325)
        Me.LBL_DC_Telephone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_DC_Telephone.Name = "LBL_DC_Telephone"
        Me.LBL_DC_Telephone.Size = New System.Drawing.Size(96, 20)
        Me.LBL_DC_Telephone.TabIndex = 69
        Me.LBL_DC_Telephone.Text = "Telephone :"
        '
        'TB_DC_LastName
        '
        Me.TB_DC_LastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_DC_LastName.ForeColor = System.Drawing.Color.Black
        Me.TB_DC_LastName.Location = New System.Drawing.Point(192, 218)
        Me.TB_DC_LastName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_DC_LastName.Name = "TB_DC_LastName"
        Me.TB_DC_LastName.Size = New System.Drawing.Size(265, 26)
        Me.TB_DC_LastName.TabIndex = 68
        '
        'TB_DC_FirstName
        '
        Me.TB_DC_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_DC_FirstName.ForeColor = System.Drawing.Color.Black
        Me.TB_DC_FirstName.Location = New System.Drawing.Point(192, 170)
        Me.TB_DC_FirstName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_DC_FirstName.Name = "TB_DC_FirstName"
        Me.TB_DC_FirstName.Size = New System.Drawing.Size(265, 26)
        Me.TB_DC_FirstName.TabIndex = 67
        '
        'LBL_DC_LastName
        '
        Me.LBL_DC_LastName.AutoSize = True
        Me.LBL_DC_LastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DC_LastName.ForeColor = System.Drawing.Color.White
        Me.LBL_DC_LastName.Location = New System.Drawing.Point(69, 222)
        Me.LBL_DC_LastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_DC_LastName.Name = "LBL_DC_LastName"
        Me.LBL_DC_LastName.Size = New System.Drawing.Size(101, 20)
        Me.LBL_DC_LastName.TabIndex = 66
        Me.LBL_DC_LastName.Text = "Last Name :"
        '
        'LBL_DC_FirstName
        '
        Me.LBL_DC_FirstName.AutoSize = True
        Me.LBL_DC_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DC_FirstName.ForeColor = System.Drawing.Color.White
        Me.LBL_DC_FirstName.Location = New System.Drawing.Point(69, 174)
        Me.LBL_DC_FirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_DC_FirstName.Name = "LBL_DC_FirstName"
        Me.LBL_DC_FirstName.Size = New System.Drawing.Size(102, 20)
        Me.LBL_DC_FirstName.TabIndex = 65
        Me.LBL_DC_FirstName.Text = "First Name :"
        '
        'LBL_DeleteClient
        '
        Me.LBL_DeleteClient.AutoSize = True
        Me.LBL_DeleteClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DeleteClient.ForeColor = System.Drawing.Color.Yellow
        Me.LBL_DeleteClient.Location = New System.Drawing.Point(156, 23)
        Me.LBL_DeleteClient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_DeleteClient.Name = "LBL_DeleteClient"
        Me.LBL_DeleteClient.Size = New System.Drawing.Size(226, 39)
        Me.LBL_DeleteClient.TabIndex = 64
        Me.LBL_DeleteClient.Text = "Delete Client"
        '
        'BTN_DC_Delete
        '
        Me.BTN_DC_Delete.BackColor = System.Drawing.Color.Yellow
        Me.BTN_DC_Delete.Enabled = False
        Me.BTN_DC_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DC_Delete.ForeColor = System.Drawing.Color.Black
        Me.BTN_DC_Delete.Location = New System.Drawing.Point(293, 640)
        Me.BTN_DC_Delete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_DC_Delete.Name = "BTN_DC_Delete"
        Me.BTN_DC_Delete.Size = New System.Drawing.Size(123, 39)
        Me.BTN_DC_Delete.TabIndex = 86
        Me.BTN_DC_Delete.Text = "Delete"
        Me.BTN_DC_Delete.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LBL_DeleteClient)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 82)
        Me.Panel1.TabIndex = 88
        '
        'DeleteClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(559, 705)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_DC_Delete)
        Me.Controls.Add(Me.GB_DC_ChooseClient)
        Me.Controls.Add(Me.BTN_DC_Cancel)
        Me.Controls.Add(Me.TB_DC_PostalCode)
        Me.Controls.Add(Me.TB_DC_Province)
        Me.Controls.Add(Me.TB_DC_city)
        Me.Controls.Add(Me.TB_DC_Address)
        Me.Controls.Add(Me.LBL_DC_PostalCode)
        Me.Controls.Add(Me.LBL_DC_Province)
        Me.Controls.Add(Me.LBL_DC_city)
        Me.Controls.Add(Me.LBL_DC_Address)
        Me.Controls.Add(Me.DTP_DC_DOB)
        Me.Controls.Add(Me.LBL_DC_DOB)
        Me.Controls.Add(Me.TB_DC_Email)
        Me.Controls.Add(Me.LBL_DC_Email)
        Me.Controls.Add(Me.TB_DC_Telephone)
        Me.Controls.Add(Me.LBL_DC_Telephone)
        Me.Controls.Add(Me.TB_DC_LastName)
        Me.Controls.Add(Me.TB_DC_FirstName)
        Me.Controls.Add(Me.LBL_DC_LastName)
        Me.Controls.Add(Me.LBL_DC_FirstName)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "DeleteClient"
        Me.Text = "DeletClient"
        Me.GB_DC_ChooseClient.ResumeLayout(False)
        Me.GB_DC_ChooseClient.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_DC_ChooseClient As GroupBox
    Friend WithEvents TB_DC_Client As TextBox
    Friend WithEvents LBL_DC_Client As Label
    Friend WithEvents BTN_DC_Cancel As Button
    Friend WithEvents TB_DC_PostalCode As TextBox
    Friend WithEvents TB_DC_Province As TextBox
    Friend WithEvents TB_DC_city As TextBox
    Friend WithEvents TB_DC_Address As TextBox
    Friend WithEvents LBL_DC_PostalCode As Label
    Friend WithEvents LBL_DC_Province As Label
    Friend WithEvents LBL_DC_city As Label
    Friend WithEvents LBL_DC_Address As Label
    Friend WithEvents DTP_DC_DOB As DateTimePicker
    Friend WithEvents LBL_DC_DOB As Label
    Friend WithEvents TB_DC_Email As TextBox
    Friend WithEvents LBL_DC_Email As Label
    Friend WithEvents TB_DC_Telephone As TextBox
    Friend WithEvents LBL_DC_Telephone As Label
    Friend WithEvents TB_DC_LastName As TextBox
    Friend WithEvents TB_DC_FirstName As TextBox
    Friend WithEvents LBL_DC_LastName As Label
    Friend WithEvents LBL_DC_FirstName As Label
    Friend WithEvents LBL_DeleteClient As Label
    Friend WithEvents BTN_DC_Delete As Button
    Friend WithEvents BTN_DC_Search As Button
    Friend WithEvents Panel1 As Panel
End Class
