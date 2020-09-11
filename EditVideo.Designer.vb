<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditVideo
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
        Me.BTN_EV_search = New System.Windows.Forms.Button()
        Me.TB_EV_ChooseVideo = New System.Windows.Forms.TextBox()
        Me.LBL_EV_ChooseVideo = New System.Windows.Forms.Label()
        Me.LBL_EditVideo = New System.Windows.Forms.Label()
        Me.TB_EV_Director = New System.Windows.Forms.TextBox()
        Me.TB_EV_Actor = New System.Windows.Forms.TextBox()
        Me.TB_EV_Genre = New System.Windows.Forms.TextBox()
        Me.TB_EV_Length = New System.Windows.Forms.TextBox()
        Me.TB_EV_Language = New System.Windows.Forms.TextBox()
        Me.TB_EV_Country = New System.Windows.Forms.TextBox()
        Me.TB_EV_Title = New System.Windows.Forms.TextBox()
        Me.LBL_EV_Resume = New System.Windows.Forms.Label()
        Me.LBL_EV_Director = New System.Windows.Forms.Label()
        Me.LBL_EV_Genre = New System.Windows.Forms.Label()
        Me.LBL_EV_Length = New System.Windows.Forms.Label()
        Me.LBL_EV_Language = New System.Windows.Forms.Label()
        Me.LBL_EV_Country = New System.Windows.Forms.Label()
        Me.LBL_EV_Year = New System.Windows.Forms.Label()
        Me.LBL_EV_Title = New System.Windows.Forms.Label()
        Me.BTN_EV_Edit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TB_EV_Year = New System.Windows.Forms.MaskedTextBox()
        Me.TB_NV_ImgUrl = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_EV_Resume = New System.Windows.Forms.TextBox()
        Me.LBL_EV_Actor = New System.Windows.Forms.Label()
        Me.BTN_EV_Cancel = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PB_EV_Picture = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PB_EV_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BTN_EV_search)
        Me.GroupBox1.Controls.Add(Me.TB_EV_ChooseVideo)
        Me.GroupBox1.Controls.Add(Me.LBL_EV_ChooseVideo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(29, 94)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(723, 70)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose a video"
        '
        'BTN_EV_search
        '
        Me.BTN_EV_search.ForeColor = System.Drawing.Color.Black
        Me.BTN_EV_search.Location = New System.Drawing.Point(584, 28)
        Me.BTN_EV_search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_EV_search.Name = "BTN_EV_search"
        Me.BTN_EV_search.Size = New System.Drawing.Size(100, 28)
        Me.BTN_EV_search.TabIndex = 2
        Me.BTN_EV_search.Text = "Search"
        Me.BTN_EV_search.UseVisualStyleBackColor = True
        '
        'TB_EV_ChooseVideo
        '
        Me.TB_EV_ChooseVideo.ForeColor = System.Drawing.Color.Black
        Me.TB_EV_ChooseVideo.Location = New System.Drawing.Point(108, 30)
        Me.TB_EV_ChooseVideo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_EV_ChooseVideo.Name = "TB_EV_ChooseVideo"
        Me.TB_EV_ChooseVideo.Size = New System.Drawing.Size(453, 26)
        Me.TB_EV_ChooseVideo.TabIndex = 1
        '
        'LBL_EV_ChooseVideo
        '
        Me.LBL_EV_ChooseVideo.AutoSize = True
        Me.LBL_EV_ChooseVideo.Location = New System.Drawing.Point(35, 33)
        Me.LBL_EV_ChooseVideo.Name = "LBL_EV_ChooseVideo"
        Me.LBL_EV_ChooseVideo.Size = New System.Drawing.Size(61, 20)
        Me.LBL_EV_ChooseVideo.TabIndex = 0
        Me.LBL_EV_ChooseVideo.Text = "Video :"
        '
        'LBL_EditVideo
        '
        Me.LBL_EditVideo.AutoSize = True
        Me.LBL_EditVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EditVideo.ForeColor = System.Drawing.Color.Yellow
        Me.LBL_EditVideo.Location = New System.Drawing.Point(268, 22)
        Me.LBL_EditVideo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_EditVideo.Name = "LBL_EditVideo"
        Me.LBL_EditVideo.Size = New System.Drawing.Size(183, 39)
        Me.LBL_EditVideo.TabIndex = 4
        Me.LBL_EditVideo.Text = "Edit Video"
        '
        'TB_EV_Director
        '
        Me.TB_EV_Director.ForeColor = System.Drawing.Color.Black
        Me.TB_EV_Director.Location = New System.Drawing.Point(141, 390)
        Me.TB_EV_Director.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_EV_Director.Name = "TB_EV_Director"
        Me.TB_EV_Director.Size = New System.Drawing.Size(293, 26)
        Me.TB_EV_Director.TabIndex = 16
        '
        'TB_EV_Actor
        '
        Me.TB_EV_Actor.ForeColor = System.Drawing.Color.Black
        Me.TB_EV_Actor.Location = New System.Drawing.Point(141, 348)
        Me.TB_EV_Actor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_EV_Actor.Name = "TB_EV_Actor"
        Me.TB_EV_Actor.Size = New System.Drawing.Size(293, 26)
        Me.TB_EV_Actor.TabIndex = 15
        '
        'TB_EV_Genre
        '
        Me.TB_EV_Genre.ForeColor = System.Drawing.Color.Black
        Me.TB_EV_Genre.Location = New System.Drawing.Point(141, 299)
        Me.TB_EV_Genre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_EV_Genre.Name = "TB_EV_Genre"
        Me.TB_EV_Genre.Size = New System.Drawing.Size(293, 26)
        Me.TB_EV_Genre.TabIndex = 14
        '
        'TB_EV_Length
        '
        Me.TB_EV_Length.ForeColor = System.Drawing.Color.Black
        Me.TB_EV_Length.Location = New System.Drawing.Point(141, 256)
        Me.TB_EV_Length.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_EV_Length.Name = "TB_EV_Length"
        Me.TB_EV_Length.Size = New System.Drawing.Size(293, 26)
        Me.TB_EV_Length.TabIndex = 13
        '
        'TB_EV_Language
        '
        Me.TB_EV_Language.ForeColor = System.Drawing.Color.Black
        Me.TB_EV_Language.Location = New System.Drawing.Point(141, 206)
        Me.TB_EV_Language.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_EV_Language.Name = "TB_EV_Language"
        Me.TB_EV_Language.Size = New System.Drawing.Size(293, 26)
        Me.TB_EV_Language.TabIndex = 12
        '
        'TB_EV_Country
        '
        Me.TB_EV_Country.ForeColor = System.Drawing.Color.Black
        Me.TB_EV_Country.Location = New System.Drawing.Point(141, 159)
        Me.TB_EV_Country.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_EV_Country.Name = "TB_EV_Country"
        Me.TB_EV_Country.Size = New System.Drawing.Size(293, 26)
        Me.TB_EV_Country.TabIndex = 11
        '
        'TB_EV_Title
        '
        Me.TB_EV_Title.ForeColor = System.Drawing.Color.Black
        Me.TB_EV_Title.Location = New System.Drawing.Point(141, 23)
        Me.TB_EV_Title.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_EV_Title.Name = "TB_EV_Title"
        Me.TB_EV_Title.Size = New System.Drawing.Size(293, 26)
        Me.TB_EV_Title.TabIndex = 10
        '
        'LBL_EV_Resume
        '
        Me.LBL_EV_Resume.AutoSize = True
        Me.LBL_EV_Resume.Location = New System.Drawing.Point(37, 439)
        Me.LBL_EV_Resume.Name = "LBL_EV_Resume"
        Me.LBL_EV_Resume.Size = New System.Drawing.Size(81, 20)
        Me.LBL_EV_Resume.TabIndex = 8
        Me.LBL_EV_Resume.Text = "Resume :"
        '
        'LBL_EV_Director
        '
        Me.LBL_EV_Director.AutoSize = True
        Me.LBL_EV_Director.Location = New System.Drawing.Point(37, 393)
        Me.LBL_EV_Director.Name = "LBL_EV_Director"
        Me.LBL_EV_Director.Size = New System.Drawing.Size(80, 20)
        Me.LBL_EV_Director.TabIndex = 7
        Me.LBL_EV_Director.Text = "Director :"
        '
        'LBL_EV_Genre
        '
        Me.LBL_EV_Genre.AutoSize = True
        Me.LBL_EV_Genre.Location = New System.Drawing.Point(37, 303)
        Me.LBL_EV_Genre.Name = "LBL_EV_Genre"
        Me.LBL_EV_Genre.Size = New System.Drawing.Size(65, 20)
        Me.LBL_EV_Genre.TabIndex = 5
        Me.LBL_EV_Genre.Text = "Genre :"
        '
        'LBL_EV_Length
        '
        Me.LBL_EV_Length.AutoSize = True
        Me.LBL_EV_Length.Location = New System.Drawing.Point(37, 256)
        Me.LBL_EV_Length.Name = "LBL_EV_Length"
        Me.LBL_EV_Length.Size = New System.Drawing.Size(70, 20)
        Me.LBL_EV_Length.TabIndex = 4
        Me.LBL_EV_Length.Text = "Length :"
        '
        'LBL_EV_Language
        '
        Me.LBL_EV_Language.AutoSize = True
        Me.LBL_EV_Language.Location = New System.Drawing.Point(37, 208)
        Me.LBL_EV_Language.Name = "LBL_EV_Language"
        Me.LBL_EV_Language.Size = New System.Drawing.Size(92, 20)
        Me.LBL_EV_Language.TabIndex = 3
        Me.LBL_EV_Language.Text = "Language :"
        '
        'LBL_EV_Country
        '
        Me.LBL_EV_Country.AutoSize = True
        Me.LBL_EV_Country.Location = New System.Drawing.Point(37, 162)
        Me.LBL_EV_Country.Name = "LBL_EV_Country"
        Me.LBL_EV_Country.Size = New System.Drawing.Size(77, 20)
        Me.LBL_EV_Country.TabIndex = 2
        Me.LBL_EV_Country.Text = "Country :"
        '
        'LBL_EV_Year
        '
        Me.LBL_EV_Year.AutoSize = True
        Me.LBL_EV_Year.Location = New System.Drawing.Point(37, 114)
        Me.LBL_EV_Year.Name = "LBL_EV_Year"
        Me.LBL_EV_Year.Size = New System.Drawing.Size(53, 20)
        Me.LBL_EV_Year.TabIndex = 1
        Me.LBL_EV_Year.Text = "Year :"
        '
        'LBL_EV_Title
        '
        Me.LBL_EV_Title.AutoSize = True
        Me.LBL_EV_Title.Location = New System.Drawing.Point(37, 26)
        Me.LBL_EV_Title.Name = "LBL_EV_Title"
        Me.LBL_EV_Title.Size = New System.Drawing.Size(51, 20)
        Me.LBL_EV_Title.TabIndex = 0
        Me.LBL_EV_Title.Text = "Title :"
        '
        'BTN_EV_Edit
        '
        Me.BTN_EV_Edit.BackColor = System.Drawing.Color.Yellow
        Me.BTN_EV_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EV_Edit.Location = New System.Drawing.Point(373, 766)
        Me.BTN_EV_Edit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_EV_Edit.Name = "BTN_EV_Edit"
        Me.BTN_EV_Edit.Size = New System.Drawing.Size(123, 39)
        Me.BTN_EV_Edit.TabIndex = 14
        Me.BTN_EV_Edit.Text = "Edit"
        Me.BTN_EV_Edit.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TB_EV_Year)
        Me.GroupBox2.Controls.Add(Me.TB_NV_ImgUrl)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TB_EV_Resume)
        Me.GroupBox2.Controls.Add(Me.TB_EV_Director)
        Me.GroupBox2.Controls.Add(Me.TB_EV_Actor)
        Me.GroupBox2.Controls.Add(Me.TB_EV_Genre)
        Me.GroupBox2.Controls.Add(Me.TB_EV_Length)
        Me.GroupBox2.Controls.Add(Me.TB_EV_Language)
        Me.GroupBox2.Controls.Add(Me.TB_EV_Country)
        Me.GroupBox2.Controls.Add(Me.TB_EV_Title)
        Me.GroupBox2.Controls.Add(Me.LBL_EV_Resume)
        Me.GroupBox2.Controls.Add(Me.LBL_EV_Director)
        Me.GroupBox2.Controls.Add(Me.LBL_EV_Actor)
        Me.GroupBox2.Controls.Add(Me.LBL_EV_Genre)
        Me.GroupBox2.Controls.Add(Me.LBL_EV_Length)
        Me.GroupBox2.Controls.Add(Me.LBL_EV_Language)
        Me.GroupBox2.Controls.Add(Me.LBL_EV_Country)
        Me.GroupBox2.Controls.Add(Me.LBL_EV_Year)
        Me.GroupBox2.Controls.Add(Me.LBL_EV_Title)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(284, 178)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(468, 571)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Video Information"
        '
        'TB_EV_Year
        '
        Me.TB_EV_Year.Location = New System.Drawing.Point(141, 111)
        Me.TB_EV_Year.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_EV_Year.Mask = "0000"
        Me.TB_EV_Year.Name = "TB_EV_Year"
        Me.TB_EV_Year.Size = New System.Drawing.Size(293, 26)
        Me.TB_EV_Year.TabIndex = 25
        '
        'TB_NV_ImgUrl
        '
        Me.TB_NV_ImgUrl.ForeColor = System.Drawing.Color.Black
        Me.TB_NV_ImgUrl.Location = New System.Drawing.Point(141, 66)
        Me.TB_NV_ImgUrl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_NV_ImgUrl.Name = "TB_NV_ImgUrl"
        Me.TB_NV_ImgUrl.Size = New System.Drawing.Size(293, 26)
        Me.TB_NV_ImgUrl.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Image URL :"
        '
        'TB_EV_Resume
        '
        Me.TB_EV_Resume.ForeColor = System.Drawing.Color.Black
        Me.TB_EV_Resume.Location = New System.Drawing.Point(141, 436)
        Me.TB_EV_Resume.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_EV_Resume.Multiline = True
        Me.TB_EV_Resume.Name = "TB_EV_Resume"
        Me.TB_EV_Resume.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TB_EV_Resume.Size = New System.Drawing.Size(293, 94)
        Me.TB_EV_Resume.TabIndex = 20
        '
        'LBL_EV_Actor
        '
        Me.LBL_EV_Actor.AutoSize = True
        Me.LBL_EV_Actor.Location = New System.Drawing.Point(37, 351)
        Me.LBL_EV_Actor.Name = "LBL_EV_Actor"
        Me.LBL_EV_Actor.Size = New System.Drawing.Size(59, 20)
        Me.LBL_EV_Actor.TabIndex = 6
        Me.LBL_EV_Actor.Text = "Actor :"
        '
        'BTN_EV_Cancel
        '
        Me.BTN_EV_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_EV_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EV_Cancel.Location = New System.Drawing.Point(204, 766)
        Me.BTN_EV_Cancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_EV_Cancel.Name = "BTN_EV_Cancel"
        Me.BTN_EV_Cancel.Size = New System.Drawing.Size(123, 39)
        Me.BTN_EV_Cancel.TabIndex = 15
        Me.BTN_EV_Cancel.Text = "Cancel"
        Me.BTN_EV_Cancel.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.PB_EV_Picture)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(29, 178)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(232, 202)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Video Poster"
        '
        'PB_EV_Picture
        '
        Me.PB_EV_Picture.Location = New System.Drawing.Point(8, 23)
        Me.PB_EV_Picture.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PB_EV_Picture.Name = "PB_EV_Picture"
        Me.PB_EV_Picture.Size = New System.Drawing.Size(216, 160)
        Me.PB_EV_Picture.TabIndex = 14
        Me.PB_EV_Picture.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LBL_EditVideo)
        Me.Panel1.Location = New System.Drawing.Point(-4, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 82)
        Me.Panel1.TabIndex = 17
        '
        'EditVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(791, 820)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BTN_EV_Edit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BTN_EV_Cancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "EditVideo"
        Me.Text = "EditVideo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PB_EV_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LBL_EditVideo As Label
    Friend WithEvents LBL_EV_ChooseVideo As Label
    Friend WithEvents TB_EV_ChooseVideo As TextBox
    Friend WithEvents TB_EV_Director As TextBox
    Friend WithEvents TB_EV_Actor As TextBox
    Friend WithEvents TB_EV_Genre As TextBox
    Friend WithEvents TB_EV_Length As TextBox
    Friend WithEvents TB_EV_Language As TextBox
    Friend WithEvents TB_EV_Country As TextBox
    Friend WithEvents TB_EV_Title As TextBox
    Friend WithEvents LBL_EV_Resume As Label
    Friend WithEvents LBL_EV_Director As Label
    Friend WithEvents LBL_EV_Genre As Label
    Friend WithEvents LBL_EV_Length As Label
    Friend WithEvents LBL_EV_Language As Label
    Friend WithEvents LBL_EV_Country As Label
    Friend WithEvents LBL_EV_Year As Label
    Friend WithEvents LBL_EV_Title As Label
    Friend WithEvents BTN_EV_Edit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LBL_EV_Actor As Label
    Friend WithEvents BTN_EV_Cancel As Button
    Friend WithEvents BTN_EV_search As Button
    Friend WithEvents TB_EV_Resume As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PB_EV_Picture As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TB_NV_ImgUrl As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_EV_Year As MaskedTextBox
End Class
