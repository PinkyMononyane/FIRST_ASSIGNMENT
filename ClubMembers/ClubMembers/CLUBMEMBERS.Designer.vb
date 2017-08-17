<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CLUBMEMBERS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CLUBMEMBERS))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Female = New System.Windows.Forms.RadioButton()
        Me.Male = New System.Windows.Forms.RadioButton()
        Me.MDob = New System.Windows.Forms.DateTimePicker()
        Me.Mage = New System.Windows.Forms.TextBox()
        Me.MLname = New System.Windows.Forms.TextBox()
        Me.MName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Id_Number = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RDATE = New System.Windows.Forms.Label()
        Me.UPDATE = New System.Windows.Forms.Button()
        Me.DELETE_RECORD = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(946, 68)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.DELETE_RECORD)
        Me.GroupBox1.Controls.Add(Me.UPDATE)
        Me.GroupBox1.Controls.Add(Me.RDATE)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.MId)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Female)
        Me.GroupBox1.Controls.Add(Me.Male)
        Me.GroupBox1.Controls.Add(Me.MDob)
        Me.GroupBox1.Controls.Add(Me.Mage)
        Me.GroupBox1.Controls.Add(Me.MLname)
        Me.GroupBox1.Controls.Add(Me.MName)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 554)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MEMBERS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "ID NUMBER"
        '
        'MId
        '
        Me.MId.Location = New System.Drawing.Point(186, 176)
        Me.MId.Name = "MId"
        Me.MId.Size = New System.Drawing.Size(286, 20)
        Me.MId.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "AGE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "DATE OF BIRTH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "LAST NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "NAME"
        '
        'Female
        '
        Me.Female.AutoSize = True
        Me.Female.Location = New System.Drawing.Point(272, 416)
        Me.Female.Name = "Female"
        Me.Female.Size = New System.Drawing.Size(67, 17)
        Me.Female.TabIndex = 19
        Me.Female.TabStop = True
        Me.Female.Text = "FEMALE"
        Me.Female.UseVisualStyleBackColor = True
        '
        'Male
        '
        Me.Male.AutoSize = True
        Me.Male.Location = New System.Drawing.Point(186, 416)
        Me.Male.Name = "Male"
        Me.Male.Size = New System.Drawing.Size(54, 17)
        Me.Male.TabIndex = 18
        Me.Male.TabStop = True
        Me.Male.Text = "MALE"
        Me.Male.UseVisualStyleBackColor = True
        '
        'MDob
        '
        Me.MDob.Location = New System.Drawing.Point(186, 306)
        Me.MDob.Name = "MDob"
        Me.MDob.Size = New System.Drawing.Size(140, 20)
        Me.MDob.TabIndex = 14
        '
        'Mage
        '
        Me.Mage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Mage.Location = New System.Drawing.Point(186, 369)
        Me.Mage.Name = "Mage"
        Me.Mage.ReadOnly = True
        Me.Mage.Size = New System.Drawing.Size(67, 20)
        Me.Mage.TabIndex = 17
        '
        'MLname
        '
        Me.MLname.Location = New System.Drawing.Point(186, 263)
        Me.MLname.Name = "MLname"
        Me.MLname.Size = New System.Drawing.Size(286, 20)
        Me.MLname.TabIndex = 16
        '
        'MName
        '
        Me.MName.Location = New System.Drawing.Point(186, 219)
        Me.MName.Name = "MName"
        Me.MName.Size = New System.Drawing.Size(286, 20)
        Me.MName.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Search)
        Me.GroupBox2.Controls.Add(Me.Id_Number)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 90)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MEMBER ID NUMBER "
        '
        'Id_Number
        '
        Me.Id_Number.Location = New System.Drawing.Point(6, 40)
        Me.Id_Number.Name = "Id_Number"
        Me.Id_Number.Size = New System.Drawing.Size(261, 20)
        Me.Id_Number.TabIndex = 0
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(298, 9)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(176, 75)
        Me.Search.TabIndex = 1
        Me.Search.Text = "SEARCH"
        Me.Search.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 459)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "REGISTRATION DATE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 420)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "GENDER"
        '
        'RDATE
        '
        Me.RDATE.AutoSize = True
        Me.RDATE.Location = New System.Drawing.Point(183, 459)
        Me.RDATE.Name = "RDATE"
        Me.RDATE.Size = New System.Drawing.Size(10, 13)
        Me.RDATE.TabIndex = 28
        Me.RDATE.Text = "."
        '
        'UPDATE
        '
        Me.UPDATE.Location = New System.Drawing.Point(6, 525)
        Me.UPDATE.Name = "UPDATE"
        Me.UPDATE.Size = New System.Drawing.Size(75, 23)
        Me.UPDATE.TabIndex = 29
        Me.UPDATE.Text = "UPDATE USER"
        Me.UPDATE.UseVisualStyleBackColor = True
        '
        'DELETE_RECORD
        '
        Me.DELETE_RECORD.Location = New System.Drawing.Point(118, 525)
        Me.DELETE_RECORD.Name = "DELETE_RECORD"
        Me.DELETE_RECORD.Size = New System.Drawing.Size(75, 23)
        Me.DELETE_RECORD.TabIndex = 30
        Me.DELETE_RECORD.Text = "DELETE USER"
        Me.DELETE_RECORD.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(225, 525)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "CLEAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(946, 68)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.toolStripSeparator, Me.SaveToolStripMenuItem, Me.toolStripSeparator1, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 64)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.NewToolStripMenuItem.Text = "ADD NEW MEMBER "
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(178, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.SaveToolStripMenuItem.Text = "&UPDATE"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(178, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'CLUBMEMBERS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 640)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CLUBMEMBERS"
        Me.Text = "CLUBMEMBERS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Female As RadioButton
    Friend WithEvents Male As RadioButton
    Friend WithEvents MDob As DateTimePicker
    Friend WithEvents Mage As TextBox
    Friend WithEvents MLname As TextBox
    Friend WithEvents MName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Search As Button
    Friend WithEvents Id_Number As TextBox
    Friend WithEvents RDATE As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents DELETE_RECORD As Button
    Friend WithEvents UPDATE As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
