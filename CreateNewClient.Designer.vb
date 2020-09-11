<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateNewClient
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
        Me.LBL_NewClient = New System.Windows.Forms.Label()
        Me.TB_NC_LastName = New System.Windows.Forms.TextBox()
        Me.TB_NC_FirstName = New System.Windows.Forms.TextBox()
        Me.LBL_NC_LastName = New System.Windows.Forms.Label()
        Me.LBL_NC_FirstName = New System.Windows.Forms.Label()
        Me.LBL_NC_Telephone = New System.Windows.Forms.Label()
        Me.LBL_NC_Email = New System.Windows.Forms.Label()
        Me.TB_NC_Email = New System.Windows.Forms.TextBox()
        Me.DTP_NC_DOB = New System.Windows.Forms.DateTimePicker()
        Me.LBL_NC_DOB = New System.Windows.Forms.Label()
        Me.TB_NC_Province = New System.Windows.Forms.TextBox()
        Me.TB_NC_city = New System.Windows.Forms.TextBox()
        Me.TB_NC_Address = New System.Windows.Forms.TextBox()
        Me.LBL_NC_PostalCode = New System.Windows.Forms.Label()
        Me.LBL_NC_Province = New System.Windows.Forms.Label()
        Me.LBL_NC_city = New System.Windows.Forms.Label()
        Me.LBL_NC_Address = New System.Windows.Forms.Label()
        Me.BTN_NC_cancle = New System.Windows.Forms.Button()
        Me.BTN_NC_save = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TB_NC_PostalCode = New System.Windows.Forms.MaskedTextBox()
        Me.TB_NC_telephone = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_NewClient
        '
        Me.LBL_NewClient.AutoSize = True
        Me.LBL_NewClient.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NewClient.ForeColor = System.Drawing.Color.Yellow
        Me.LBL_NewClient.Location = New System.Drawing.Point(107, 19)
        Me.LBL_NewClient.Name = "LBL_NewClient"
        Me.LBL_NewClient.Size = New System.Drawing.Size(172, 30)
        Me.LBL_NewClient.TabIndex = 17
        Me.LBL_NewClient.Text = "New Client"
        '
        'TB_NC_LastName
        '
        Me.TB_NC_LastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NC_LastName.ForeColor = System.Drawing.Color.Black
        Me.TB_NC_LastName.Location = New System.Drawing.Point(137, 125)
        Me.TB_NC_LastName.Name = "TB_NC_LastName"
        Me.TB_NC_LastName.Size = New System.Drawing.Size(200, 22)
        Me.TB_NC_LastName.TabIndex = 21
        '
        'TB_NC_FirstName
        '
        Me.TB_NC_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NC_FirstName.ForeColor = System.Drawing.Color.Black
        Me.TB_NC_FirstName.Location = New System.Drawing.Point(137, 86)
        Me.TB_NC_FirstName.Name = "TB_NC_FirstName"
        Me.TB_NC_FirstName.Size = New System.Drawing.Size(200, 22)
        Me.TB_NC_FirstName.TabIndex = 20
        '
        'LBL_NC_LastName
        '
        Me.LBL_NC_LastName.AutoSize = True
        Me.LBL_NC_LastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NC_LastName.ForeColor = System.Drawing.Color.White
        Me.LBL_NC_LastName.Location = New System.Drawing.Point(47, 128)
        Me.LBL_NC_LastName.Name = "LBL_NC_LastName"
        Me.LBL_NC_LastName.Size = New System.Drawing.Size(79, 16)
        Me.LBL_NC_LastName.TabIndex = 19
        Me.LBL_NC_LastName.Text = "Last Name :"
        '
        'LBL_NC_FirstName
        '
        Me.LBL_NC_FirstName.AutoSize = True
        Me.LBL_NC_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NC_FirstName.ForeColor = System.Drawing.Color.White
        Me.LBL_NC_FirstName.Location = New System.Drawing.Point(47, 89)
        Me.LBL_NC_FirstName.Name = "LBL_NC_FirstName"
        Me.LBL_NC_FirstName.Size = New System.Drawing.Size(79, 16)
        Me.LBL_NC_FirstName.TabIndex = 18
        Me.LBL_NC_FirstName.Text = "First Name :"
        '
        'LBL_NC_Telephone
        '
        Me.LBL_NC_Telephone.AutoSize = True
        Me.LBL_NC_Telephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NC_Telephone.ForeColor = System.Drawing.Color.White
        Me.LBL_NC_Telephone.Location = New System.Drawing.Point(47, 212)
        Me.LBL_NC_Telephone.Name = "LBL_NC_Telephone"
        Me.LBL_NC_Telephone.Size = New System.Drawing.Size(80, 16)
        Me.LBL_NC_Telephone.TabIndex = 22
        Me.LBL_NC_Telephone.Text = "Telephone :"
        '
        'LBL_NC_Email
        '
        Me.LBL_NC_Email.AutoSize = True
        Me.LBL_NC_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NC_Email.ForeColor = System.Drawing.Color.White
        Me.LBL_NC_Email.Location = New System.Drawing.Point(47, 170)
        Me.LBL_NC_Email.Name = "LBL_NC_Email"
        Me.LBL_NC_Email.Size = New System.Drawing.Size(48, 16)
        Me.LBL_NC_Email.TabIndex = 24
        Me.LBL_NC_Email.Text = "Email :"
        '
        'TB_NC_Email
        '
        Me.TB_NC_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NC_Email.ForeColor = System.Drawing.Color.Black
        Me.TB_NC_Email.Location = New System.Drawing.Point(137, 167)
        Me.TB_NC_Email.Name = "TB_NC_Email"
        Me.TB_NC_Email.Size = New System.Drawing.Size(200, 22)
        Me.TB_NC_Email.TabIndex = 25
        '
        'DTP_NC_DOB
        '
        Me.DTP_NC_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_NC_DOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_NC_DOB.Location = New System.Drawing.Point(137, 253)
        Me.DTP_NC_DOB.Name = "DTP_NC_DOB"
        Me.DTP_NC_DOB.Size = New System.Drawing.Size(200, 22)
        Me.DTP_NC_DOB.TabIndex = 27
        Me.DTP_NC_DOB.Value = New Date(2019, 10, 23, 11, 28, 6, 0)
        '
        'LBL_NC_DOB
        '
        Me.LBL_NC_DOB.AutoSize = True
        Me.LBL_NC_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NC_DOB.ForeColor = System.Drawing.Color.White
        Me.LBL_NC_DOB.Location = New System.Drawing.Point(47, 257)
        Me.LBL_NC_DOB.Name = "LBL_NC_DOB"
        Me.LBL_NC_DOB.Size = New System.Drawing.Size(86, 16)
        Me.LBL_NC_DOB.TabIndex = 26
        Me.LBL_NC_DOB.Text = "Date of Birth :"
        '
        'TB_NC_Province
        '
        Me.TB_NC_Province.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NC_Province.ForeColor = System.Drawing.Color.Black
        Me.TB_NC_Province.Location = New System.Drawing.Point(137, 380)
        Me.TB_NC_Province.Name = "TB_NC_Province"
        Me.TB_NC_Province.Size = New System.Drawing.Size(200, 22)
        Me.TB_NC_Province.TabIndex = 34
        '
        'TB_NC_city
        '
        Me.TB_NC_city.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NC_city.ForeColor = System.Drawing.Color.Black
        Me.TB_NC_city.Location = New System.Drawing.Point(137, 338)
        Me.TB_NC_city.Name = "TB_NC_city"
        Me.TB_NC_city.Size = New System.Drawing.Size(200, 22)
        Me.TB_NC_city.TabIndex = 33
        '
        'TB_NC_Address
        '
        Me.TB_NC_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NC_Address.ForeColor = System.Drawing.Color.Black
        Me.TB_NC_Address.Location = New System.Drawing.Point(137, 297)
        Me.TB_NC_Address.Name = "TB_NC_Address"
        Me.TB_NC_Address.Size = New System.Drawing.Size(200, 22)
        Me.TB_NC_Address.TabIndex = 32
        '
        'LBL_NC_PostalCode
        '
        Me.LBL_NC_PostalCode.AutoSize = True
        Me.LBL_NC_PostalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NC_PostalCode.ForeColor = System.Drawing.Color.White
        Me.LBL_NC_PostalCode.Location = New System.Drawing.Point(47, 425)
        Me.LBL_NC_PostalCode.Name = "LBL_NC_PostalCode"
        Me.LBL_NC_PostalCode.Size = New System.Drawing.Size(88, 16)
        Me.LBL_NC_PostalCode.TabIndex = 31
        Me.LBL_NC_PostalCode.Text = "Postal Code :"
        '
        'LBL_NC_Province
        '
        Me.LBL_NC_Province.AutoSize = True
        Me.LBL_NC_Province.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NC_Province.ForeColor = System.Drawing.Color.White
        Me.LBL_NC_Province.Location = New System.Drawing.Point(47, 383)
        Me.LBL_NC_Province.Name = "LBL_NC_Province"
        Me.LBL_NC_Province.Size = New System.Drawing.Size(67, 16)
        Me.LBL_NC_Province.TabIndex = 30
        Me.LBL_NC_Province.Text = "Province :"
        '
        'LBL_NC_city
        '
        Me.LBL_NC_city.AutoSize = True
        Me.LBL_NC_city.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NC_city.ForeColor = System.Drawing.Color.White
        Me.LBL_NC_city.Location = New System.Drawing.Point(47, 341)
        Me.LBL_NC_city.Name = "LBL_NC_city"
        Me.LBL_NC_city.Size = New System.Drawing.Size(36, 16)
        Me.LBL_NC_city.TabIndex = 29
        Me.LBL_NC_city.Text = "City :"
        '
        'LBL_NC_Address
        '
        Me.LBL_NC_Address.AutoSize = True
        Me.LBL_NC_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NC_Address.ForeColor = System.Drawing.Color.White
        Me.LBL_NC_Address.Location = New System.Drawing.Point(47, 300)
        Me.LBL_NC_Address.Name = "LBL_NC_Address"
        Me.LBL_NC_Address.Size = New System.Drawing.Size(65, 16)
        Me.LBL_NC_Address.TabIndex = 28
        Me.LBL_NC_Address.Text = "Address :"
        '
        'BTN_NC_cancle
        '
        Me.BTN_NC_cancle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_NC_cancle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NC_cancle.Location = New System.Drawing.Point(77, 478)
        Me.BTN_NC_cancle.Name = "BTN_NC_cancle"
        Me.BTN_NC_cancle.Size = New System.Drawing.Size(92, 32)
        Me.BTN_NC_cancle.TabIndex = 39
        Me.BTN_NC_cancle.Text = "Cancel"
        Me.BTN_NC_cancle.UseVisualStyleBackColor = False
        '
        'BTN_NC_save
        '
        Me.BTN_NC_save.BackColor = System.Drawing.Color.Yellow
        Me.BTN_NC_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NC_save.Location = New System.Drawing.Point(205, 478)
        Me.BTN_NC_save.Name = "BTN_NC_save"
        Me.BTN_NC_save.Size = New System.Drawing.Size(92, 32)
        Me.BTN_NC_save.TabIndex = 38
        Me.BTN_NC_save.Text = "Save"
        Me.BTN_NC_save.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LBL_NewClient)
        Me.Panel1.Location = New System.Drawing.Point(-3, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(379, 67)
        Me.Panel1.TabIndex = 40
        '
        'TB_NC_PostalCode
        '
        Me.TB_NC_PostalCode.Location = New System.Drawing.Point(137, 424)
        Me.TB_NC_PostalCode.Mask = "?0? 0?0"
        Me.TB_NC_PostalCode.Name = "TB_NC_PostalCode"
        Me.TB_NC_PostalCode.Size = New System.Drawing.Size(200, 20)
        Me.TB_NC_PostalCode.TabIndex = 41
        '
        'TB_NC_telephone
        '
        Me.TB_NC_telephone.Location = New System.Drawing.Point(137, 211)
        Me.TB_NC_telephone.Mask = "999-999-9999"
        Me.TB_NC_telephone.Name = "TB_NC_telephone"
        Me.TB_NC_telephone.Size = New System.Drawing.Size(200, 20)
        Me.TB_NC_telephone.TabIndex = 42
        '
        'CreateNewClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(374, 528)
        Me.Controls.Add(Me.TB_NC_telephone)
        Me.Controls.Add(Me.TB_NC_PostalCode)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_NC_cancle)
        Me.Controls.Add(Me.BTN_NC_save)
        Me.Controls.Add(Me.TB_NC_Province)
        Me.Controls.Add(Me.TB_NC_city)
        Me.Controls.Add(Me.TB_NC_Address)
        Me.Controls.Add(Me.LBL_NC_PostalCode)
        Me.Controls.Add(Me.LBL_NC_Province)
        Me.Controls.Add(Me.LBL_NC_city)
        Me.Controls.Add(Me.LBL_NC_Address)
        Me.Controls.Add(Me.DTP_NC_DOB)
        Me.Controls.Add(Me.LBL_NC_DOB)
        Me.Controls.Add(Me.TB_NC_Email)
        Me.Controls.Add(Me.LBL_NC_Email)
        Me.Controls.Add(Me.LBL_NC_Telephone)
        Me.Controls.Add(Me.TB_NC_LastName)
        Me.Controls.Add(Me.TB_NC_FirstName)
        Me.Controls.Add(Me.LBL_NC_LastName)
        Me.Controls.Add(Me.LBL_NC_FirstName)
        Me.Name = "CreateNewClient"
        Me.Text = "CreateNewClient"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_NewClient As Label
    Friend WithEvents TB_NC_LastName As TextBox
    Friend WithEvents TB_NC_FirstName As TextBox
    Friend WithEvents LBL_NC_LastName As Label
    Friend WithEvents LBL_NC_FirstName As Label
    Friend WithEvents LBL_NC_Telephone As Label
    Friend WithEvents LBL_NC_Email As Label
    Friend WithEvents TB_NC_Email As TextBox
    Friend WithEvents DTP_NC_DOB As DateTimePicker
    Friend WithEvents LBL_NC_DOB As Label
    Friend WithEvents TB_NC_Province As TextBox
    Friend WithEvents TB_NC_city As TextBox
    Friend WithEvents TB_NC_Address As TextBox
    Friend WithEvents LBL_NC_PostalCode As Label
    Friend WithEvents LBL_NC_Province As Label
    Friend WithEvents LBL_NC_city As Label
    Friend WithEvents LBL_NC_Address As Label
    Friend WithEvents BTN_NC_cancle As Button
    Friend WithEvents BTN_NC_save As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TB_NC_PostalCode As MaskedTextBox
    Friend WithEvents TB_NC_telephone As MaskedTextBox
End Class
