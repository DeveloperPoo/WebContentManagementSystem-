<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteVideo
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
        Me.BTN_DV_Delete = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TB_NV_ImgUrl = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_DV_Year = New System.Windows.Forms.TextBox()
        Me.TB_DV_Resume = New System.Windows.Forms.TextBox()
        Me.TB_DV_Director = New System.Windows.Forms.TextBox()
        Me.TB_DV_Actor = New System.Windows.Forms.TextBox()
        Me.TB_DV_Genre = New System.Windows.Forms.TextBox()
        Me.TB_DV_Length = New System.Windows.Forms.TextBox()
        Me.TB_DV_Language = New System.Windows.Forms.TextBox()
        Me.TB_DV_Country = New System.Windows.Forms.TextBox()
        Me.TB_DV_Title = New System.Windows.Forms.TextBox()
        Me.LBL_DV_Resume = New System.Windows.Forms.Label()
        Me.LBL_DV_Director = New System.Windows.Forms.Label()
        Me.LBL_DV_Actor = New System.Windows.Forms.Label()
        Me.LBL_DV_Genre = New System.Windows.Forms.Label()
        Me.LBL_DV_Length = New System.Windows.Forms.Label()
        Me.LBL_DV_Language = New System.Windows.Forms.Label()
        Me.LBL_DV_Country = New System.Windows.Forms.Label()
        Me.LBL_DV_Year = New System.Windows.Forms.Label()
        Me.LBL_DV_Title = New System.Windows.Forms.Label()
        Me.BTN_DV_Cancel = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PB_EV_Picture = New System.Windows.Forms.PictureBox()
        Me.TB_DV_ChooseVideo = New System.Windows.Forms.TextBox()
        Me.BTN_DV_Search = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBL_EditVideo = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PB_EV_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_DV_Delete
        '
        Me.BTN_DV_Delete.BackColor = System.Drawing.Color.Yellow
        Me.BTN_DV_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DV_Delete.Location = New System.Drawing.Point(376, 791)
        Me.BTN_DV_Delete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_DV_Delete.Name = "BTN_DV_Delete"
        Me.BTN_DV_Delete.Size = New System.Drawing.Size(123, 39)
        Me.BTN_DV_Delete.TabIndex = 19
        Me.BTN_DV_Delete.Text = "Delete"
        Me.BTN_DV_Delete.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TB_NV_ImgUrl)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TB_DV_Year)
        Me.GroupBox2.Controls.Add(Me.TB_DV_Resume)
        Me.GroupBox2.Controls.Add(Me.TB_DV_Director)
        Me.GroupBox2.Controls.Add(Me.TB_DV_Actor)
        Me.GroupBox2.Controls.Add(Me.TB_DV_Genre)
        Me.GroupBox2.Controls.Add(Me.TB_DV_Length)
        Me.GroupBox2.Controls.Add(Me.TB_DV_Language)
        Me.GroupBox2.Controls.Add(Me.TB_DV_Country)
        Me.GroupBox2.Controls.Add(Me.TB_DV_Title)
        Me.GroupBox2.Controls.Add(Me.LBL_DV_Resume)
        Me.GroupBox2.Controls.Add(Me.LBL_DV_Director)
        Me.GroupBox2.Controls.Add(Me.LBL_DV_Actor)
        Me.GroupBox2.Controls.Add(Me.LBL_DV_Genre)
        Me.GroupBox2.Controls.Add(Me.LBL_DV_Length)
        Me.GroupBox2.Controls.Add(Me.LBL_DV_Language)
        Me.GroupBox2.Controls.Add(Me.LBL_DV_Country)
        Me.GroupBox2.Controls.Add(Me.LBL_DV_Year)
        Me.GroupBox2.Controls.Add(Me.LBL_DV_Title)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(283, 198)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(476, 571)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Video Information"
        '
        'TB_NV_ImgUrl
        '
        Me.TB_NV_ImgUrl.ForeColor = System.Drawing.Color.Black
        Me.TB_NV_ImgUrl.Location = New System.Drawing.Point(140, 78)
        Me.TB_NV_ImgUrl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_NV_ImgUrl.Name = "TB_NV_ImgUrl"
        Me.TB_NV_ImgUrl.Size = New System.Drawing.Size(293, 26)
        Me.TB_NV_ImgUrl.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Image URL :"
        '
        'TB_DV_Year
        '
        Me.TB_DV_Year.ForeColor = System.Drawing.Color.Black
        Me.TB_DV_Year.Location = New System.Drawing.Point(140, 124)
        Me.TB_DV_Year.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_DV_Year.Name = "TB_DV_Year"
        Me.TB_DV_Year.Size = New System.Drawing.Size(293, 26)
        Me.TB_DV_Year.TabIndex = 21
        '
        'TB_DV_Resume
        '
        Me.TB_DV_Resume.ForeColor = System.Drawing.Color.Black
        Me.TB_DV_Resume.Location = New System.Drawing.Point(140, 449)
        Me.TB_DV_Resume.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_DV_Resume.Multiline = True
        Me.TB_DV_Resume.Name = "TB_DV_Resume"
        Me.TB_DV_Resume.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TB_DV_Resume.Size = New System.Drawing.Size(293, 94)
        Me.TB_DV_Resume.TabIndex = 20
        '
        'TB_DV_Director
        '
        Me.TB_DV_Director.ForeColor = System.Drawing.Color.Black
        Me.TB_DV_Director.Location = New System.Drawing.Point(140, 404)
        Me.TB_DV_Director.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_DV_Director.Name = "TB_DV_Director"
        Me.TB_DV_Director.Size = New System.Drawing.Size(293, 26)
        Me.TB_DV_Director.TabIndex = 16
        '
        'TB_DV_Actor
        '
        Me.TB_DV_Actor.ForeColor = System.Drawing.Color.Black
        Me.TB_DV_Actor.Location = New System.Drawing.Point(140, 362)
        Me.TB_DV_Actor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_DV_Actor.Name = "TB_DV_Actor"
        Me.TB_DV_Actor.Size = New System.Drawing.Size(293, 26)
        Me.TB_DV_Actor.TabIndex = 15
        '
        'TB_DV_Genre
        '
        Me.TB_DV_Genre.ForeColor = System.Drawing.Color.Black
        Me.TB_DV_Genre.Location = New System.Drawing.Point(140, 313)
        Me.TB_DV_Genre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_DV_Genre.Name = "TB_DV_Genre"
        Me.TB_DV_Genre.Size = New System.Drawing.Size(293, 26)
        Me.TB_DV_Genre.TabIndex = 14
        '
        'TB_DV_Length
        '
        Me.TB_DV_Length.ForeColor = System.Drawing.Color.Black
        Me.TB_DV_Length.Location = New System.Drawing.Point(140, 270)
        Me.TB_DV_Length.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_DV_Length.Name = "TB_DV_Length"
        Me.TB_DV_Length.Size = New System.Drawing.Size(293, 26)
        Me.TB_DV_Length.TabIndex = 13
        '
        'TB_DV_Language
        '
        Me.TB_DV_Language.ForeColor = System.Drawing.Color.Black
        Me.TB_DV_Language.Location = New System.Drawing.Point(140, 219)
        Me.TB_DV_Language.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_DV_Language.Name = "TB_DV_Language"
        Me.TB_DV_Language.Size = New System.Drawing.Size(293, 26)
        Me.TB_DV_Language.TabIndex = 12
        '
        'TB_DV_Country
        '
        Me.TB_DV_Country.ForeColor = System.Drawing.Color.Black
        Me.TB_DV_Country.Location = New System.Drawing.Point(140, 172)
        Me.TB_DV_Country.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_DV_Country.Name = "TB_DV_Country"
        Me.TB_DV_Country.Size = New System.Drawing.Size(293, 26)
        Me.TB_DV_Country.TabIndex = 11
        '
        'TB_DV_Title
        '
        Me.TB_DV_Title.ForeColor = System.Drawing.Color.Black
        Me.TB_DV_Title.Location = New System.Drawing.Point(140, 34)
        Me.TB_DV_Title.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_DV_Title.Name = "TB_DV_Title"
        Me.TB_DV_Title.Size = New System.Drawing.Size(293, 26)
        Me.TB_DV_Title.TabIndex = 10
        '
        'LBL_DV_Resume
        '
        Me.LBL_DV_Resume.AutoSize = True
        Me.LBL_DV_Resume.Location = New System.Drawing.Point(37, 453)
        Me.LBL_DV_Resume.Name = "LBL_DV_Resume"
        Me.LBL_DV_Resume.Size = New System.Drawing.Size(81, 20)
        Me.LBL_DV_Resume.TabIndex = 8
        Me.LBL_DV_Resume.Text = "Resume :"
        '
        'LBL_DV_Director
        '
        Me.LBL_DV_Director.AutoSize = True
        Me.LBL_DV_Director.Location = New System.Drawing.Point(37, 406)
        Me.LBL_DV_Director.Name = "LBL_DV_Director"
        Me.LBL_DV_Director.Size = New System.Drawing.Size(80, 20)
        Me.LBL_DV_Director.TabIndex = 7
        Me.LBL_DV_Director.Text = "Director :"
        '
        'LBL_DV_Actor
        '
        Me.LBL_DV_Actor.AutoSize = True
        Me.LBL_DV_Actor.Location = New System.Drawing.Point(37, 364)
        Me.LBL_DV_Actor.Name = "LBL_DV_Actor"
        Me.LBL_DV_Actor.Size = New System.Drawing.Size(59, 20)
        Me.LBL_DV_Actor.TabIndex = 6
        Me.LBL_DV_Actor.Text = "Actor :"
        '
        'LBL_DV_Genre
        '
        Me.LBL_DV_Genre.AutoSize = True
        Me.LBL_DV_Genre.Location = New System.Drawing.Point(37, 316)
        Me.LBL_DV_Genre.Name = "LBL_DV_Genre"
        Me.LBL_DV_Genre.Size = New System.Drawing.Size(65, 20)
        Me.LBL_DV_Genre.TabIndex = 5
        Me.LBL_DV_Genre.Text = "Genre :"
        '
        'LBL_DV_Length
        '
        Me.LBL_DV_Length.AutoSize = True
        Me.LBL_DV_Length.Location = New System.Drawing.Point(37, 270)
        Me.LBL_DV_Length.Name = "LBL_DV_Length"
        Me.LBL_DV_Length.Size = New System.Drawing.Size(70, 20)
        Me.LBL_DV_Length.TabIndex = 4
        Me.LBL_DV_Length.Text = "Length :"
        '
        'LBL_DV_Language
        '
        Me.LBL_DV_Language.AutoSize = True
        Me.LBL_DV_Language.Location = New System.Drawing.Point(37, 222)
        Me.LBL_DV_Language.Name = "LBL_DV_Language"
        Me.LBL_DV_Language.Size = New System.Drawing.Size(92, 20)
        Me.LBL_DV_Language.TabIndex = 3
        Me.LBL_DV_Language.Text = "Language :"
        '
        'LBL_DV_Country
        '
        Me.LBL_DV_Country.AutoSize = True
        Me.LBL_DV_Country.Location = New System.Drawing.Point(37, 176)
        Me.LBL_DV_Country.Name = "LBL_DV_Country"
        Me.LBL_DV_Country.Size = New System.Drawing.Size(77, 20)
        Me.LBL_DV_Country.TabIndex = 2
        Me.LBL_DV_Country.Text = "Country :"
        '
        'LBL_DV_Year
        '
        Me.LBL_DV_Year.AutoSize = True
        Me.LBL_DV_Year.Location = New System.Drawing.Point(37, 128)
        Me.LBL_DV_Year.Name = "LBL_DV_Year"
        Me.LBL_DV_Year.Size = New System.Drawing.Size(53, 20)
        Me.LBL_DV_Year.TabIndex = 1
        Me.LBL_DV_Year.Text = "Year :"
        '
        'LBL_DV_Title
        '
        Me.LBL_DV_Title.AutoSize = True
        Me.LBL_DV_Title.Location = New System.Drawing.Point(37, 37)
        Me.LBL_DV_Title.Name = "LBL_DV_Title"
        Me.LBL_DV_Title.Size = New System.Drawing.Size(51, 20)
        Me.LBL_DV_Title.TabIndex = 0
        Me.LBL_DV_Title.Text = "Title :"
        '
        'BTN_DV_Cancel
        '
        Me.BTN_DV_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_DV_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DV_Cancel.Location = New System.Drawing.Point(205, 791)
        Me.BTN_DV_Cancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_DV_Cancel.Name = "BTN_DV_Cancel"
        Me.BTN_DV_Cancel.Size = New System.Drawing.Size(123, 39)
        Me.BTN_DV_Cancel.TabIndex = 20
        Me.BTN_DV_Cancel.Text = "Cancel"
        Me.BTN_DV_Cancel.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.PB_EV_Picture)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(25, 199)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(232, 202)
        Me.GroupBox3.TabIndex = 21
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
        'TB_DV_ChooseVideo
        '
        Me.TB_DV_ChooseVideo.ForeColor = System.Drawing.Color.Black
        Me.TB_DV_ChooseVideo.Location = New System.Drawing.Point(114, 29)
        Me.TB_DV_ChooseVideo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_DV_ChooseVideo.Name = "TB_DV_ChooseVideo"
        Me.TB_DV_ChooseVideo.Size = New System.Drawing.Size(473, 22)
        Me.TB_DV_ChooseVideo.TabIndex = 1
        '
        'BTN_DV_Search
        '
        Me.BTN_DV_Search.ForeColor = System.Drawing.Color.Black
        Me.BTN_DV_Search.Location = New System.Drawing.Point(613, 26)
        Me.BTN_DV_Search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_DV_Search.Name = "BTN_DV_Search"
        Me.BTN_DV_Search.Size = New System.Drawing.Size(93, 28)
        Me.BTN_DV_Search.TabIndex = 2
        Me.BTN_DV_Search.Text = "Search"
        Me.BTN_DV_Search.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TB_DV_ChooseVideo)
        Me.GroupBox1.Controls.Add(Me.BTN_DV_Search)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(33, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(726, 69)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose a Video"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Video :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LBL_EditVideo)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 82)
        Me.Panel1.TabIndex = 23
        '
        'LBL_EditVideo
        '
        Me.LBL_EditVideo.AutoSize = True
        Me.LBL_EditVideo.BackColor = System.Drawing.Color.Transparent
        Me.LBL_EditVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EditVideo.ForeColor = System.Drawing.Color.Yellow
        Me.LBL_EditVideo.Location = New System.Drawing.Point(268, 22)
        Me.LBL_EditVideo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_EditVideo.Name = "LBL_EditVideo"
        Me.LBL_EditVideo.Size = New System.Drawing.Size(225, 39)
        Me.LBL_EditVideo.TabIndex = 4
        Me.LBL_EditVideo.Text = "Delete Video"
        '
        'DeleteVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(796, 854)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BTN_DV_Delete)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BTN_DV_Cancel)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "DeleteVideo"
        Me.Text = "DeleteVideo"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PB_EV_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_DV_Delete As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TB_DV_Director As TextBox
    Friend WithEvents TB_DV_Actor As TextBox
    Friend WithEvents TB_DV_Genre As TextBox
    Friend WithEvents TB_DV_Length As TextBox
    Friend WithEvents TB_DV_Language As TextBox
    Friend WithEvents TB_DV_Country As TextBox
    Friend WithEvents TB_DV_Title As TextBox
    Friend WithEvents LBL_DV_Resume As Label
    Friend WithEvents LBL_DV_Director As Label
    Friend WithEvents LBL_DV_Actor As Label
    Friend WithEvents LBL_DV_Genre As Label
    Friend WithEvents LBL_DV_Length As Label
    Friend WithEvents LBL_DV_Language As Label
    Friend WithEvents LBL_DV_Country As Label
    Friend WithEvents LBL_DV_Year As Label
    Friend WithEvents LBL_DV_Title As Label
    Friend WithEvents BTN_DV_Cancel As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PB_EV_Picture As PictureBox
    Friend WithEvents TB_DV_Resume As TextBox
    Friend WithEvents TB_DV_Year As TextBox
    Friend WithEvents TB_NV_ImgUrl As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_DV_ChooseVideo As TextBox
    Friend WithEvents BTN_DV_Search As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBL_EditVideo As Label
End Class
