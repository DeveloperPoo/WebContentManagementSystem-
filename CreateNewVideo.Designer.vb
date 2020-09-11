<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewVideo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TB_NV_Year = New System.Windows.Forms.MaskedTextBox()
        Me.TB_NV_ImgUrl = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_NV_Resume = New System.Windows.Forms.TextBox()
        Me.TB_NV_Director = New System.Windows.Forms.TextBox()
        Me.TB_NV_Actor = New System.Windows.Forms.TextBox()
        Me.TB_NV_Genre = New System.Windows.Forms.TextBox()
        Me.TB_NV_Length = New System.Windows.Forms.TextBox()
        Me.TB_NV_Language = New System.Windows.Forms.TextBox()
        Me.TB_NV_Country = New System.Windows.Forms.TextBox()
        Me.TB_NV_Title = New System.Windows.Forms.TextBox()
        Me.LBL_NV_Resume = New System.Windows.Forms.Label()
        Me.LBL_NV_Director = New System.Windows.Forms.Label()
        Me.LBL_NV_Actor = New System.Windows.Forms.Label()
        Me.LBL_NV_Genre = New System.Windows.Forms.Label()
        Me.LBL_NV_Length = New System.Windows.Forms.Label()
        Me.LBL_NV_Language = New System.Windows.Forms.Label()
        Me.LBL_NV_Country = New System.Windows.Forms.Label()
        Me.LBL_NV_Year = New System.Windows.Forms.Label()
        Me.LBL_NV_Title = New System.Windows.Forms.Label()
        Me.LBL_NewVideo = New System.Windows.Forms.Label()
        Me.BTN_NV_Cancel = New System.Windows.Forms.Button()
        Me.BTN_NV_Save = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PB_NV_Picture = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PB_NV_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TB_NV_Year)
        Me.GroupBox1.Controls.Add(Me.TB_NV_ImgUrl)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TB_NV_Resume)
        Me.GroupBox1.Controls.Add(Me.TB_NV_Director)
        Me.GroupBox1.Controls.Add(Me.TB_NV_Actor)
        Me.GroupBox1.Controls.Add(Me.TB_NV_Genre)
        Me.GroupBox1.Controls.Add(Me.TB_NV_Length)
        Me.GroupBox1.Controls.Add(Me.TB_NV_Language)
        Me.GroupBox1.Controls.Add(Me.TB_NV_Country)
        Me.GroupBox1.Controls.Add(Me.TB_NV_Title)
        Me.GroupBox1.Controls.Add(Me.LBL_NV_Resume)
        Me.GroupBox1.Controls.Add(Me.LBL_NV_Director)
        Me.GroupBox1.Controls.Add(Me.LBL_NV_Actor)
        Me.GroupBox1.Controls.Add(Me.LBL_NV_Genre)
        Me.GroupBox1.Controls.Add(Me.LBL_NV_Length)
        Me.GroupBox1.Controls.Add(Me.LBL_NV_Language)
        Me.GroupBox1.Controls.Add(Me.LBL_NV_Country)
        Me.GroupBox1.Controls.Add(Me.LBL_NV_Year)
        Me.GroupBox1.Controls.Add(Me.LBL_NV_Title)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(289, 105)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(453, 565)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Video Information"
        '
        'TB_NV_Year
        '
        Me.TB_NV_Year.Location = New System.Drawing.Point(139, 132)
        Me.TB_NV_Year.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_NV_Year.Mask = "0000"
        Me.TB_NV_Year.Name = "TB_NV_Year"
        Me.TB_NV_Year.Size = New System.Drawing.Size(293, 26)
        Me.TB_NV_Year.TabIndex = 23
        '
        'TB_NV_ImgUrl
        '
        Me.TB_NV_ImgUrl.ForeColor = System.Drawing.Color.Black
        Me.TB_NV_ImgUrl.Location = New System.Drawing.Point(139, 84)
        Me.TB_NV_ImgUrl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_NV_ImgUrl.Name = "TB_NV_ImgUrl"
        Me.TB_NV_ImgUrl.Size = New System.Drawing.Size(293, 26)
        Me.TB_NV_ImgUrl.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Image URL :"
        '
        'TB_NV_Resume
        '
        Me.TB_NV_Resume.ForeColor = System.Drawing.Color.Black
        Me.TB_NV_Resume.Location = New System.Drawing.Point(139, 454)
        Me.TB_NV_Resume.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_NV_Resume.Multiline = True
        Me.TB_NV_Resume.Name = "TB_NV_Resume"
        Me.TB_NV_Resume.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TB_NV_Resume.Size = New System.Drawing.Size(293, 94)
        Me.TB_NV_Resume.TabIndex = 19
        '
        'TB_NV_Director
        '
        Me.TB_NV_Director.ForeColor = System.Drawing.Color.Black
        Me.TB_NV_Director.Location = New System.Drawing.Point(139, 411)
        Me.TB_NV_Director.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_NV_Director.Name = "TB_NV_Director"
        Me.TB_NV_Director.Size = New System.Drawing.Size(293, 26)
        Me.TB_NV_Director.TabIndex = 16
        '
        'TB_NV_Actor
        '
        Me.TB_NV_Actor.ForeColor = System.Drawing.Color.Black
        Me.TB_NV_Actor.Location = New System.Drawing.Point(139, 366)
        Me.TB_NV_Actor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_NV_Actor.Name = "TB_NV_Actor"
        Me.TB_NV_Actor.Size = New System.Drawing.Size(293, 26)
        Me.TB_NV_Actor.TabIndex = 15
        '
        'TB_NV_Genre
        '
        Me.TB_NV_Genre.ForeColor = System.Drawing.Color.Black
        Me.TB_NV_Genre.Location = New System.Drawing.Point(139, 320)
        Me.TB_NV_Genre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_NV_Genre.Name = "TB_NV_Genre"
        Me.TB_NV_Genre.Size = New System.Drawing.Size(293, 26)
        Me.TB_NV_Genre.TabIndex = 14
        '
        'TB_NV_Length
        '
        Me.TB_NV_Length.ForeColor = System.Drawing.Color.Black
        Me.TB_NV_Length.Location = New System.Drawing.Point(139, 274)
        Me.TB_NV_Length.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_NV_Length.Name = "TB_NV_Length"
        Me.TB_NV_Length.Size = New System.Drawing.Size(293, 26)
        Me.TB_NV_Length.TabIndex = 13
        '
        'TB_NV_Language
        '
        Me.TB_NV_Language.ForeColor = System.Drawing.Color.Black
        Me.TB_NV_Language.Location = New System.Drawing.Point(139, 226)
        Me.TB_NV_Language.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_NV_Language.Name = "TB_NV_Language"
        Me.TB_NV_Language.Size = New System.Drawing.Size(293, 26)
        Me.TB_NV_Language.TabIndex = 12
        '
        'TB_NV_Country
        '
        Me.TB_NV_Country.ForeColor = System.Drawing.Color.Black
        Me.TB_NV_Country.Location = New System.Drawing.Point(139, 180)
        Me.TB_NV_Country.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_NV_Country.Name = "TB_NV_Country"
        Me.TB_NV_Country.Size = New System.Drawing.Size(293, 26)
        Me.TB_NV_Country.TabIndex = 11
        '
        'TB_NV_Title
        '
        Me.TB_NV_Title.ForeColor = System.Drawing.Color.Black
        Me.TB_NV_Title.Location = New System.Drawing.Point(139, 37)
        Me.TB_NV_Title.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_NV_Title.Name = "TB_NV_Title"
        Me.TB_NV_Title.Size = New System.Drawing.Size(293, 26)
        Me.TB_NV_Title.TabIndex = 10
        '
        'LBL_NV_Resume
        '
        Me.LBL_NV_Resume.AutoSize = True
        Me.LBL_NV_Resume.Location = New System.Drawing.Point(29, 454)
        Me.LBL_NV_Resume.Name = "LBL_NV_Resume"
        Me.LBL_NV_Resume.Size = New System.Drawing.Size(81, 20)
        Me.LBL_NV_Resume.TabIndex = 8
        Me.LBL_NV_Resume.Text = "Resume :"
        '
        'LBL_NV_Director
        '
        Me.LBL_NV_Director.AutoSize = True
        Me.LBL_NV_Director.Location = New System.Drawing.Point(29, 414)
        Me.LBL_NV_Director.Name = "LBL_NV_Director"
        Me.LBL_NV_Director.Size = New System.Drawing.Size(80, 20)
        Me.LBL_NV_Director.TabIndex = 7
        Me.LBL_NV_Director.Text = "Director :"
        '
        'LBL_NV_Actor
        '
        Me.LBL_NV_Actor.AutoSize = True
        Me.LBL_NV_Actor.Location = New System.Drawing.Point(29, 368)
        Me.LBL_NV_Actor.Name = "LBL_NV_Actor"
        Me.LBL_NV_Actor.Size = New System.Drawing.Size(59, 20)
        Me.LBL_NV_Actor.TabIndex = 6
        Me.LBL_NV_Actor.Text = "Actor :"
        '
        'LBL_NV_Genre
        '
        Me.LBL_NV_Genre.AutoSize = True
        Me.LBL_NV_Genre.Location = New System.Drawing.Point(29, 324)
        Me.LBL_NV_Genre.Name = "LBL_NV_Genre"
        Me.LBL_NV_Genre.Size = New System.Drawing.Size(65, 20)
        Me.LBL_NV_Genre.TabIndex = 5
        Me.LBL_NV_Genre.Text = "Genre :"
        '
        'LBL_NV_Length
        '
        Me.LBL_NV_Length.AutoSize = True
        Me.LBL_NV_Length.Location = New System.Drawing.Point(29, 277)
        Me.LBL_NV_Length.Name = "LBL_NV_Length"
        Me.LBL_NV_Length.Size = New System.Drawing.Size(70, 20)
        Me.LBL_NV_Length.TabIndex = 4
        Me.LBL_NV_Length.Text = "Length :"
        '
        'LBL_NV_Language
        '
        Me.LBL_NV_Language.AutoSize = True
        Me.LBL_NV_Language.Location = New System.Drawing.Point(29, 229)
        Me.LBL_NV_Language.Name = "LBL_NV_Language"
        Me.LBL_NV_Language.Size = New System.Drawing.Size(92, 20)
        Me.LBL_NV_Language.TabIndex = 3
        Me.LBL_NV_Language.Text = "Language :"
        '
        'LBL_NV_Country
        '
        Me.LBL_NV_Country.AutoSize = True
        Me.LBL_NV_Country.Location = New System.Drawing.Point(29, 183)
        Me.LBL_NV_Country.Name = "LBL_NV_Country"
        Me.LBL_NV_Country.Size = New System.Drawing.Size(77, 20)
        Me.LBL_NV_Country.TabIndex = 2
        Me.LBL_NV_Country.Text = "Country :"
        '
        'LBL_NV_Year
        '
        Me.LBL_NV_Year.AutoSize = True
        Me.LBL_NV_Year.Location = New System.Drawing.Point(29, 135)
        Me.LBL_NV_Year.Name = "LBL_NV_Year"
        Me.LBL_NV_Year.Size = New System.Drawing.Size(53, 20)
        Me.LBL_NV_Year.TabIndex = 1
        Me.LBL_NV_Year.Text = "Year :"
        '
        'LBL_NV_Title
        '
        Me.LBL_NV_Title.AutoSize = True
        Me.LBL_NV_Title.Location = New System.Drawing.Point(29, 39)
        Me.LBL_NV_Title.Name = "LBL_NV_Title"
        Me.LBL_NV_Title.Size = New System.Drawing.Size(51, 20)
        Me.LBL_NV_Title.TabIndex = 0
        Me.LBL_NV_Title.Text = "Title :"
        '
        'LBL_NewVideo
        '
        Me.LBL_NewVideo.AutoSize = True
        Me.LBL_NewVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NewVideo.ForeColor = System.Drawing.Color.Yellow
        Me.LBL_NewVideo.Location = New System.Drawing.Point(264, 22)
        Me.LBL_NewVideo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_NewVideo.Name = "LBL_NewVideo"
        Me.LBL_NewVideo.Size = New System.Drawing.Size(192, 39)
        Me.LBL_NewVideo.TabIndex = 3
        Me.LBL_NewVideo.Text = "New Video"
        '
        'BTN_NV_Cancel
        '
        Me.BTN_NV_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_NV_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NV_Cancel.Location = New System.Drawing.Point(220, 697)
        Me.BTN_NV_Cancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_NV_Cancel.Name = "BTN_NV_Cancel"
        Me.BTN_NV_Cancel.Size = New System.Drawing.Size(123, 39)
        Me.BTN_NV_Cancel.TabIndex = 12
        Me.BTN_NV_Cancel.Text = "Cancel"
        Me.BTN_NV_Cancel.UseVisualStyleBackColor = False
        '
        'BTN_NV_Save
        '
        Me.BTN_NV_Save.BackColor = System.Drawing.Color.Yellow
        Me.BTN_NV_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NV_Save.Location = New System.Drawing.Point(391, 697)
        Me.BTN_NV_Save.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_NV_Save.Name = "BTN_NV_Save"
        Me.BTN_NV_Save.Size = New System.Drawing.Size(123, 39)
        Me.BTN_NV_Save.TabIndex = 11
        Me.BTN_NV_Save.Text = "Save"
        Me.BTN_NV_Save.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.PB_NV_Picture)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(27, 105)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(232, 202)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Video Poster"
        '
        'PB_NV_Picture
        '
        Me.PB_NV_Picture.Location = New System.Drawing.Point(8, 23)
        Me.PB_NV_Picture.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PB_NV_Picture.Name = "PB_NV_Picture"
        Me.PB_NV_Picture.Size = New System.Drawing.Size(216, 160)
        Me.PB_NV_Picture.TabIndex = 14
        Me.PB_NV_Picture.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LBL_NewVideo)
        Me.Panel1.Location = New System.Drawing.Point(-3, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(788, 82)
        Me.Panel1.TabIndex = 14
        '
        'CreateNewVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(784, 763)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BTN_NV_Cancel)
        Me.Controls.Add(Me.BTN_NV_Save)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "CreateNewVideo"
        Me.Text = "CreateNewVideo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PB_NV_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LBL_NewVideo As Label
    Friend WithEvents BTN_NV_Cancel As Button
    Friend WithEvents BTN_NV_Save As Button
    Friend WithEvents LBL_NV_Director As Label
    Friend WithEvents LBL_NV_Actor As Label
    Friend WithEvents LBL_NV_Genre As Label
    Friend WithEvents LBL_NV_Length As Label
    Friend WithEvents LBL_NV_Language As Label
    Friend WithEvents LBL_NV_Country As Label
    Friend WithEvents LBL_NV_Year As Label
    Friend WithEvents LBL_NV_Title As Label
    Friend WithEvents LBL_NV_Resume As Label
    Friend WithEvents TB_NV_Director As TextBox
    Friend WithEvents TB_NV_Actor As TextBox
    Friend WithEvents TB_NV_Genre As TextBox
    Friend WithEvents TB_NV_Length As TextBox
    Friend WithEvents TB_NV_Language As TextBox
    Friend WithEvents TB_NV_Country As TextBox
    Friend WithEvents TB_NV_Title As TextBox
    Friend WithEvents TB_NV_Resume As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PB_NV_Picture As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TB_NV_ImgUrl As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_NV_Year As MaskedTextBox
End Class
