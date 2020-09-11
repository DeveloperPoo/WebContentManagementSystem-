<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientList
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientList))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.headLabel = New System.Windows.Forms.Label()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.searchField = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 174)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "bundle-icon-search-blue-search-button.jpg")
        '
        'headLabel
        '
        Me.headLabel.AutoEllipsis = True
        Me.headLabel.AutoSize = True
        Me.headLabel.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headLabel.ForeColor = System.Drawing.Color.Yellow
        Me.headLabel.Location = New System.Drawing.Point(382, 69)
        Me.headLabel.Name = "headLabel"
        Me.headLabel.Size = New System.Drawing.Size(162, 30)
        Me.headLabel.TabIndex = 7
        Me.headLabel.Text = "Client List"
        '
        'searchButton
        '
        Me.searchButton.BackgroundImage = CType(resources.GetObject("searchButton.BackgroundImage"), System.Drawing.Image)
        Me.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.searchButton.Location = New System.Drawing.Point(608, 118)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(48, 43)
        Me.searchButton.TabIndex = 6
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'searchField
        '
        Me.searchField.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchField.Location = New System.Drawing.Point(216, 124)
        Me.searchField.Name = "searchField"
        Me.searchField.Size = New System.Drawing.Size(374, 32)
        Me.searchField.TabIndex = 5
        '
        'ClientList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.headLabel)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.searchField)
        Me.Name = "ClientList"
        Me.Text = "ClientList"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents headLabel As Label
    Friend WithEvents searchButton As Button
    Friend WithEvents searchField As TextBox
End Class
