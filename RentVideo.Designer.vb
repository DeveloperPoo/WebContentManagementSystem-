<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentVideo
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
        Me.RV_B_Cancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RV_B_Rent = New System.Windows.Forms.Button()
        Me.RV_TB_VideoResume = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RV_B_VideoSearch = New System.Windows.Forms.Button()
        Me.RV_TB_VideoDirector = New System.Windows.Forms.TextBox()
        Me.RV_TB_VideoLang = New System.Windows.Forms.TextBox()
        Me.RV_TB_VideoTitle = New System.Windows.Forms.TextBox()
        Me.RV_TB_VideoId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RV_LB = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RV_B_ClientSearch = New System.Windows.Forms.Button()
        Me.RV_TB_Clientphone = New System.Windows.Forms.TextBox()
        Me.RV_TB_ClientAddress = New System.Windows.Forms.TextBox()
        Me.RV_TB_ClientName = New System.Windows.Forms.TextBox()
        Me.RV_TB_ClientNum = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RV_B_Cancel
        '
        Me.RV_B_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RV_B_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RV_B_Cancel.Location = New System.Drawing.Point(543, 485)
        Me.RV_B_Cancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RV_B_Cancel.Name = "RV_B_Cancel"
        Me.RV_B_Cancel.Size = New System.Drawing.Size(123, 39)
        Me.RV_B_Cancel.TabIndex = 16
        Me.RV_B_Cancel.Text = "Cancel"
        Me.RV_B_Cancel.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(24, 39)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(237, 175)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RV_B_Rent
        '
        Me.RV_B_Rent.BackColor = System.Drawing.Color.Yellow
        Me.RV_B_Rent.Enabled = False
        Me.RV_B_Rent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RV_B_Rent.Location = New System.Drawing.Point(704, 485)
        Me.RV_B_Rent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RV_B_Rent.Name = "RV_B_Rent"
        Me.RV_B_Rent.Size = New System.Drawing.Size(123, 39)
        Me.RV_B_Rent.TabIndex = 15
        Me.RV_B_Rent.Text = "Rent"
        Me.RV_B_Rent.UseVisualStyleBackColor = False
        '
        'RV_TB_VideoResume
        '
        Me.RV_TB_VideoResume.ForeColor = System.Drawing.Color.Black
        Me.RV_TB_VideoResume.Location = New System.Drawing.Point(161, 249)
        Me.RV_TB_VideoResume.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RV_TB_VideoResume.Name = "RV_TB_VideoResume"
        Me.RV_TB_VideoResume.Size = New System.Drawing.Size(279, 26)
        Me.RV_TB_VideoResume.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RV_TB_VideoResume)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.RV_B_VideoSearch)
        Me.GroupBox2.Controls.Add(Me.RV_TB_VideoDirector)
        Me.GroupBox2.Controls.Add(Me.RV_TB_VideoLang)
        Me.GroupBox2.Controls.Add(Me.RV_TB_VideoTitle)
        Me.GroupBox2.Controls.Add(Me.RV_TB_VideoId)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(552, 114)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(793, 325)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Video's Information"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(477, 39)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(287, 242)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Video Poster"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 252)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Resume :"
        '
        'RV_B_VideoSearch
        '
        Me.RV_B_VideoSearch.ForeColor = System.Drawing.Color.Black
        Me.RV_B_VideoSearch.Location = New System.Drawing.Point(360, 50)
        Me.RV_B_VideoSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RV_B_VideoSearch.Name = "RV_B_VideoSearch"
        Me.RV_B_VideoSearch.Size = New System.Drawing.Size(81, 28)
        Me.RV_B_VideoSearch.TabIndex = 8
        Me.RV_B_VideoSearch.Text = "Search"
        Me.RV_B_VideoSearch.UseVisualStyleBackColor = True
        '
        'RV_TB_VideoDirector
        '
        Me.RV_TB_VideoDirector.ForeColor = System.Drawing.Color.Black
        Me.RV_TB_VideoDirector.Location = New System.Drawing.Point(161, 199)
        Me.RV_TB_VideoDirector.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RV_TB_VideoDirector.Name = "RV_TB_VideoDirector"
        Me.RV_TB_VideoDirector.Size = New System.Drawing.Size(279, 26)
        Me.RV_TB_VideoDirector.TabIndex = 7
        '
        'RV_TB_VideoLang
        '
        Me.RV_TB_VideoLang.ForeColor = System.Drawing.Color.Black
        Me.RV_TB_VideoLang.Location = New System.Drawing.Point(161, 149)
        Me.RV_TB_VideoLang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RV_TB_VideoLang.Name = "RV_TB_VideoLang"
        Me.RV_TB_VideoLang.Size = New System.Drawing.Size(279, 26)
        Me.RV_TB_VideoLang.TabIndex = 6
        '
        'RV_TB_VideoTitle
        '
        Me.RV_TB_VideoTitle.ForeColor = System.Drawing.Color.Black
        Me.RV_TB_VideoTitle.Location = New System.Drawing.Point(161, 100)
        Me.RV_TB_VideoTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RV_TB_VideoTitle.Name = "RV_TB_VideoTitle"
        Me.RV_TB_VideoTitle.Size = New System.Drawing.Size(279, 26)
        Me.RV_TB_VideoTitle.TabIndex = 5
        '
        'RV_TB_VideoId
        '
        Me.RV_TB_VideoId.ForeColor = System.Drawing.Color.Black
        Me.RV_TB_VideoId.Location = New System.Drawing.Point(161, 50)
        Me.RV_TB_VideoId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RV_TB_VideoId.Name = "RV_TB_VideoId"
        Me.RV_TB_VideoId.Size = New System.Drawing.Size(189, 26)
        Me.RV_TB_VideoId.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 199)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Director :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 149)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Language :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 103)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Title :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 50)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Video ID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 176)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client Number :"
        '
        'RV_LB
        '
        Me.RV_LB.AutoSize = True
        Me.RV_LB.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RV_LB.ForeColor = System.Drawing.Color.Yellow
        Me.RV_LB.Location = New System.Drawing.Point(573, 21)
        Me.RV_LB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RV_LB.Name = "RV_LB"
        Me.RV_LB.Size = New System.Drawing.Size(196, 39)
        Me.RV_LB.TabIndex = 12
        Me.RV_LB.Text = "Rent Video"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 229)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telephone :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RV_B_ClientSearch)
        Me.GroupBox1.Controls.Add(Me.RV_TB_Clientphone)
        Me.GroupBox1.Controls.Add(Me.RV_TB_ClientAddress)
        Me.GroupBox1.Controls.Add(Me.RV_TB_ClientName)
        Me.GroupBox1.Controls.Add(Me.RV_TB_ClientNum)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(37, 114)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(491, 325)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client's Information"
        '
        'RV_B_ClientSearch
        '
        Me.RV_B_ClientSearch.ForeColor = System.Drawing.Color.Black
        Me.RV_B_ClientSearch.Location = New System.Drawing.Point(369, 73)
        Me.RV_B_ClientSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RV_B_ClientSearch.Name = "RV_B_ClientSearch"
        Me.RV_B_ClientSearch.Size = New System.Drawing.Size(81, 28)
        Me.RV_B_ClientSearch.TabIndex = 8
        Me.RV_B_ClientSearch.Text = "Search"
        Me.RV_B_ClientSearch.UseVisualStyleBackColor = True
        '
        'RV_TB_Clientphone
        '
        Me.RV_TB_Clientphone.ForeColor = System.Drawing.Color.Black
        Me.RV_TB_Clientphone.Location = New System.Drawing.Point(169, 229)
        Me.RV_TB_Clientphone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RV_TB_Clientphone.Name = "RV_TB_Clientphone"
        Me.RV_TB_Clientphone.Size = New System.Drawing.Size(279, 26)
        Me.RV_TB_Clientphone.TabIndex = 7
        '
        'RV_TB_ClientAddress
        '
        Me.RV_TB_ClientAddress.ForeColor = System.Drawing.Color.Black
        Me.RV_TB_ClientAddress.Location = New System.Drawing.Point(169, 176)
        Me.RV_TB_ClientAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RV_TB_ClientAddress.Name = "RV_TB_ClientAddress"
        Me.RV_TB_ClientAddress.Size = New System.Drawing.Size(279, 26)
        Me.RV_TB_ClientAddress.TabIndex = 6
        '
        'RV_TB_ClientName
        '
        Me.RV_TB_ClientName.ForeColor = System.Drawing.Color.Black
        Me.RV_TB_ClientName.Location = New System.Drawing.Point(169, 122)
        Me.RV_TB_ClientName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RV_TB_ClientName.Name = "RV_TB_ClientName"
        Me.RV_TB_ClientName.Size = New System.Drawing.Size(279, 26)
        Me.RV_TB_ClientName.TabIndex = 5
        '
        'RV_TB_ClientNum
        '
        Me.RV_TB_ClientNum.ForeColor = System.Drawing.Color.Black
        Me.RV_TB_ClientNum.Location = New System.Drawing.Point(169, 73)
        Me.RV_TB_ClientNum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RV_TB_ClientNum.Name = "RV_TB_ClientNum"
        Me.RV_TB_ClientNum.Size = New System.Drawing.Size(189, 26)
        Me.RV_TB_ClientNum.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.RV_LB)
        Me.Panel1.Location = New System.Drawing.Point(-5, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1396, 82)
        Me.Panel1.TabIndex = 17
        '
        'RentVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1387, 554)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RV_B_Cancel)
        Me.Controls.Add(Me.RV_B_Rent)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "RentVideo"
        Me.Text = "RentVideo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RV_B_Cancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RV_B_Rent As Button
    Friend WithEvents RV_TB_VideoResume As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RV_B_VideoSearch As Button
    Friend WithEvents RV_TB_VideoDirector As TextBox
    Friend WithEvents RV_TB_VideoLang As TextBox
    Friend WithEvents RV_TB_VideoTitle As TextBox
    Friend WithEvents RV_TB_VideoId As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RV_LB As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RV_B_ClientSearch As Button
    Friend WithEvents RV_TB_Clientphone As TextBox
    Friend WithEvents RV_TB_ClientAddress As TextBox
    Friend WithEvents RV_TB_ClientName As TextBox
    Friend WithEvents RV_TB_ClientNum As TextBox
    Friend WithEvents Panel1 As Panel
End Class
