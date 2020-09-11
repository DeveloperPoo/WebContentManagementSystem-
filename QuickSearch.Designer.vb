<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuickSearch
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
        Me.LBL_QS_VideoID = New System.Windows.Forms.Label()
        Me.LBL_QS_Title = New System.Windows.Forms.Label()
        Me.LBL_QickSearch = New System.Windows.Forms.Label()
        Me.TB_QS_VideoID = New System.Windows.Forms.TextBox()
        Me.TB_QS_Title = New System.Windows.Forms.TextBox()
        Me.BTN_QS_Cancel = New System.Windows.Forms.Button()
        Me.BTN_QS_Search = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_QS_VideoID
        '
        Me.LBL_QS_VideoID.AutoSize = True
        Me.LBL_QS_VideoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_QS_VideoID.ForeColor = System.Drawing.Color.White
        Me.LBL_QS_VideoID.Location = New System.Drawing.Point(31, 123)
        Me.LBL_QS_VideoID.Name = "LBL_QS_VideoID"
        Me.LBL_QS_VideoID.Size = New System.Drawing.Size(83, 20)
        Me.LBL_QS_VideoID.TabIndex = 0
        Me.LBL_QS_VideoID.Text = "Video ID :"
        '
        'LBL_QS_Title
        '
        Me.LBL_QS_Title.AutoSize = True
        Me.LBL_QS_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_QS_Title.ForeColor = System.Drawing.Color.White
        Me.LBL_QS_Title.Location = New System.Drawing.Point(31, 177)
        Me.LBL_QS_Title.Name = "LBL_QS_Title"
        Me.LBL_QS_Title.Size = New System.Drawing.Size(51, 20)
        Me.LBL_QS_Title.TabIndex = 1
        Me.LBL_QS_Title.Text = "Title :"
        '
        'LBL_QickSearch
        '
        Me.LBL_QickSearch.AutoSize = True
        Me.LBL_QickSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_QickSearch.ForeColor = System.Drawing.Color.Yellow
        Me.LBL_QickSearch.Location = New System.Drawing.Point(108, 22)
        Me.LBL_QickSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_QickSearch.Name = "LBL_QickSearch"
        Me.LBL_QickSearch.Size = New System.Drawing.Size(233, 39)
        Me.LBL_QickSearch.TabIndex = 18
        Me.LBL_QickSearch.Text = "Quick Search"
        '
        'TB_QS_VideoID
        '
        Me.TB_QS_VideoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QS_VideoID.ForeColor = System.Drawing.Color.Black
        Me.TB_QS_VideoID.Location = New System.Drawing.Point(123, 121)
        Me.TB_QS_VideoID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_QS_VideoID.Name = "TB_QS_VideoID"
        Me.TB_QS_VideoID.Size = New System.Drawing.Size(307, 26)
        Me.TB_QS_VideoID.TabIndex = 19
        '
        'TB_QS_Title
        '
        Me.TB_QS_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QS_Title.ForeColor = System.Drawing.Color.Black
        Me.TB_QS_Title.Location = New System.Drawing.Point(123, 175)
        Me.TB_QS_Title.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_QS_Title.Name = "TB_QS_Title"
        Me.TB_QS_Title.Size = New System.Drawing.Size(307, 26)
        Me.TB_QS_Title.TabIndex = 20
        '
        'BTN_QS_Cancel
        '
        Me.BTN_QS_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_QS_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_QS_Cancel.Location = New System.Drawing.Point(84, 240)
        Me.BTN_QS_Cancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_QS_Cancel.Name = "BTN_QS_Cancel"
        Me.BTN_QS_Cancel.Size = New System.Drawing.Size(123, 39)
        Me.BTN_QS_Cancel.TabIndex = 22
        Me.BTN_QS_Cancel.Text = "Cancel"
        Me.BTN_QS_Cancel.UseVisualStyleBackColor = False
        '
        'BTN_QS_Search
        '
        Me.BTN_QS_Search.BackColor = System.Drawing.Color.Yellow
        Me.BTN_QS_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_QS_Search.Location = New System.Drawing.Point(255, 240)
        Me.BTN_QS_Search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_QS_Search.Name = "BTN_QS_Search"
        Me.BTN_QS_Search.Size = New System.Drawing.Size(123, 39)
        Me.BTN_QS_Search.TabIndex = 21
        Me.BTN_QS_Search.Text = "Search"
        Me.BTN_QS_Search.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LBL_QickSearch)
        Me.Panel1.Location = New System.Drawing.Point(-3, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 82)
        Me.Panel1.TabIndex = 23
        '
        'QuickSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(475, 311)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_QS_Cancel)
        Me.Controls.Add(Me.BTN_QS_Search)
        Me.Controls.Add(Me.TB_QS_Title)
        Me.Controls.Add(Me.TB_QS_VideoID)
        Me.Controls.Add(Me.LBL_QS_Title)
        Me.Controls.Add(Me.LBL_QS_VideoID)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "QuickSearch"
        Me.Text = "QuickSearch"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_QS_VideoID As Label
    Friend WithEvents LBL_QS_Title As Label
    Friend WithEvents LBL_QickSearch As Label
    Friend WithEvents TB_QS_VideoID As TextBox
    Friend WithEvents TB_QS_Title As TextBox
    Friend WithEvents BTN_QS_Cancel As Button
    Friend WithEvents BTN_QS_Search As Button
    Friend WithEvents Panel1 As Panel
End Class
