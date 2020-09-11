<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateNewClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateNewVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvanceSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tab_topEntity = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbl_lastUpdated = New System.Windows.Forms.Label()
        Me.lbl_topClients = New System.Windows.Forms.Label()
        Me.lbl_topClientHead = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lbl_lastUpdatedVideo = New System.Windows.Forms.Label()
        Me.lbl_topVideos = New System.Windows.Forms.Label()
        Me.lbl_topVideoHead = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.tab_topEntity.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Yellow
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.ClientToolStripMenuItem, Me.VideoToolStripMenuItem, Me.SerchToolStripMenuItem, Me.RentToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(597, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.Yellow
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(43, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListToolStripMenuItem, Me.CreateNewToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeletToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(86, 22)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ListToolStripMenuItem.Text = "List "
        '
        'CreateNewToolStripMenuItem
        '
        Me.CreateNewToolStripMenuItem.Name = "CreateNewToolStripMenuItem"
        Me.CreateNewToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.CreateNewToolStripMenuItem.Text = "Create New Employee"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeletToolStripMenuItem
        '
        Me.DeletToolStripMenuItem.Name = "DeletToolStripMenuItem"
        Me.DeletToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.DeletToolStripMenuItem.Text = "Delete"
        '
        'ClientToolStripMenuItem
        '
        Me.ClientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListToolStripMenuItem1, Me.CreateNewClientToolStripMenuItem, Me.EditToolStripMenuItem1, Me.DeleteToolStripMenuItem})
        Me.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem"
        Me.ClientToolStripMenuItem.Size = New System.Drawing.Size(57, 22)
        Me.ClientToolStripMenuItem.Text = "Client"
        '
        'ListToolStripMenuItem1
        '
        Me.ListToolStripMenuItem1.Name = "ListToolStripMenuItem1"
        Me.ListToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.ListToolStripMenuItem1.Text = "List"
        '
        'CreateNewClientToolStripMenuItem
        '
        Me.CreateNewClientToolStripMenuItem.Name = "CreateNewClientToolStripMenuItem"
        Me.CreateNewClientToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CreateNewClientToolStripMenuItem.Text = "Create New Client"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.EditToolStripMenuItem1.Text = "Edit"
        Me.EditToolStripMenuItem1.Visible = False
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        Me.DeleteToolStripMenuItem.Visible = False
        '
        'VideoToolStripMenuItem
        '
        Me.VideoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListToolStripMenuItem2, Me.CreateNewVideoToolStripMenuItem, Me.EditToolStripMenuItem2, Me.DeleteToolStripMenuItem1})
        Me.VideoToolStripMenuItem.Name = "VideoToolStripMenuItem"
        Me.VideoToolStripMenuItem.Size = New System.Drawing.Size(57, 22)
        Me.VideoToolStripMenuItem.Text = "Video"
        '
        'ListToolStripMenuItem2
        '
        Me.ListToolStripMenuItem2.Name = "ListToolStripMenuItem2"
        Me.ListToolStripMenuItem2.Size = New System.Drawing.Size(195, 22)
        Me.ListToolStripMenuItem2.Text = "List"
        '
        'CreateNewVideoToolStripMenuItem
        '
        Me.CreateNewVideoToolStripMenuItem.Name = "CreateNewVideoToolStripMenuItem"
        Me.CreateNewVideoToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CreateNewVideoToolStripMenuItem.Text = "Create New Video"
        '
        'EditToolStripMenuItem2
        '
        Me.EditToolStripMenuItem2.Name = "EditToolStripMenuItem2"
        Me.EditToolStripMenuItem2.Size = New System.Drawing.Size(195, 22)
        Me.EditToolStripMenuItem2.Text = "Edit"
        Me.EditToolStripMenuItem2.Visible = False
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        Me.DeleteToolStripMenuItem1.Visible = False
        '
        'SerchToolStripMenuItem
        '
        Me.SerchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuickSearchToolStripMenuItem, Me.AdvanceSearchToolStripMenuItem})
        Me.SerchToolStripMenuItem.Name = "SerchToolStripMenuItem"
        Me.SerchToolStripMenuItem.Size = New System.Drawing.Size(67, 22)
        Me.SerchToolStripMenuItem.Text = "Search"
        '
        'QuickSearchToolStripMenuItem
        '
        Me.QuickSearchToolStripMenuItem.Name = "QuickSearchToolStripMenuItem"
        Me.QuickSearchToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.QuickSearchToolStripMenuItem.Text = "Quick Search"
        '
        'AdvanceSearchToolStripMenuItem
        '
        Me.AdvanceSearchToolStripMenuItem.Name = "AdvanceSearchToolStripMenuItem"
        Me.AdvanceSearchToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AdvanceSearchToolStripMenuItem.Text = "Advance Search"
        '
        'RentToolStripMenuItem
        '
        Me.RentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RentVideoToolStripMenuItem, Me.ReturnVideoToolStripMenuItem})
        Me.RentToolStripMenuItem.Name = "RentToolStripMenuItem"
        Me.RentToolStripMenuItem.Size = New System.Drawing.Size(51, 22)
        Me.RentToolStripMenuItem.Text = "Rent"
        '
        'RentVideoToolStripMenuItem
        '
        Me.RentVideoToolStripMenuItem.Name = "RentVideoToolStripMenuItem"
        Me.RentVideoToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.RentVideoToolStripMenuItem.Text = "Rent Video"
        '
        'ReturnVideoToolStripMenuItem
        '
        Me.ReturnVideoToolStripMenuItem.Name = "ReturnVideoToolStripMenuItem"
        Me.ReturnVideoToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ReturnVideoToolStripMenuItem.Text = "Return Video"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(50, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'tab_topEntity
        '
        Me.tab_topEntity.Controls.Add(Me.TabPage1)
        Me.tab_topEntity.Controls.Add(Me.TabPage2)
        Me.tab_topEntity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_topEntity.Location = New System.Drawing.Point(12, 39)
        Me.tab_topEntity.Multiline = True
        Me.tab_topEntity.Name = "tab_topEntity"
        Me.tab_topEntity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tab_topEntity.SelectedIndex = 0
        Me.tab_topEntity.Size = New System.Drawing.Size(573, 440)
        Me.tab_topEntity.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.lbl_lastUpdated)
        Me.TabPage1.Controls.Add(Me.lbl_topClients)
        Me.TabPage1.Controls.Add(Me.lbl_topClientHead)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(565, 409)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Top Clients"
        '
        'lbl_lastUpdated
        '
        Me.lbl_lastUpdated.AutoSize = True
        Me.lbl_lastUpdated.Location = New System.Drawing.Point(30, 385)
        Me.lbl_lastUpdated.Name = "lbl_lastUpdated"
        Me.lbl_lastUpdated.Size = New System.Drawing.Size(51, 18)
        Me.lbl_lastUpdated.TabIndex = 2
        Me.lbl_lastUpdated.Text = "Label1"
        '
        'lbl_topClients
        '
        Me.lbl_topClients.AutoSize = True
        Me.lbl_topClients.Location = New System.Drawing.Point(50, 69)
        Me.lbl_topClients.Name = "lbl_topClients"
        Me.lbl_topClients.Size = New System.Drawing.Size(51, 18)
        Me.lbl_topClients.TabIndex = 1
        Me.lbl_topClients.Text = "Label1"
        '
        'lbl_topClientHead
        '
        Me.lbl_topClientHead.AutoSize = True
        Me.lbl_topClientHead.Location = New System.Drawing.Point(30, 20)
        Me.lbl_topClientHead.Name = "lbl_topClientHead"
        Me.lbl_topClientHead.Size = New System.Drawing.Size(51, 18)
        Me.lbl_topClientHead.TabIndex = 0
        Me.lbl_topClientHead.Text = "Label1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lbl_lastUpdatedVideo)
        Me.TabPage2.Controls.Add(Me.lbl_topVideos)
        Me.TabPage2.Controls.Add(Me.lbl_topVideoHead)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(565, 409)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Top Videos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lbl_lastUpdatedVideo
        '
        Me.lbl_lastUpdatedVideo.AutoSize = True
        Me.lbl_lastUpdatedVideo.Location = New System.Drawing.Point(41, 385)
        Me.lbl_lastUpdatedVideo.Name = "lbl_lastUpdatedVideo"
        Me.lbl_lastUpdatedVideo.Size = New System.Drawing.Size(51, 18)
        Me.lbl_lastUpdatedVideo.TabIndex = 5
        Me.lbl_lastUpdatedVideo.Text = "Label1"
        '
        'lbl_topVideos
        '
        Me.lbl_topVideos.AutoSize = True
        Me.lbl_topVideos.Location = New System.Drawing.Point(61, 69)
        Me.lbl_topVideos.Name = "lbl_topVideos"
        Me.lbl_topVideos.Size = New System.Drawing.Size(51, 18)
        Me.lbl_topVideos.TabIndex = 4
        Me.lbl_topVideos.Text = "Label1"
        '
        'lbl_topVideoHead
        '
        Me.lbl_topVideoHead.AutoSize = True
        Me.lbl_topVideoHead.Location = New System.Drawing.Point(41, 20)
        Me.lbl_topVideoHead.Name = "lbl_topVideoHead"
        Me.lbl_topVideoHead.Size = New System.Drawing.Size(51, 18)
        Me.lbl_topVideoHead.TabIndex = 3
        Me.lbl_topVideoHead.Text = "Label1"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(597, 491)
        Me.Controls.Add(Me.tab_topEntity)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tab_topEntity.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SerchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateNewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeletToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CreateNewClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CreateNewVideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents QuickSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdvanceSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RentVideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnVideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tab_topEntity As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lbl_lastUpdated As Label
    Friend WithEvents lbl_topClients As Label
    Friend WithEvents lbl_topClientHead As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lbl_lastUpdatedVideo As Label
    Friend WithEvents lbl_topVideos As Label
    Friend WithEvents lbl_topVideoHead As Label
End Class
