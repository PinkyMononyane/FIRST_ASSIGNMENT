<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SIGNUP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SIGNUP))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CLEAR = New System.Windows.Forms.Button()
        Me.PREVIEW = New System.Windows.Forms.Button()
        Me.SAVE = New System.Windows.Forms.Button()
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Pbox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(994, 638)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Pbox)
        Me.GroupBox2.Location = New System.Drawing.Point(536, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(453, 426)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MEMBER INFO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 426)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MEMBERS REGISTRATION FORM"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.MId)
        Me.Panel3.Controls.Add(Me.CLEAR)
        Me.Panel3.Controls.Add(Me.PREVIEW)
        Me.Panel3.Controls.Add(Me.SAVE)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Female)
        Me.Panel3.Controls.Add(Me.Male)
        Me.Panel3.Controls.Add(Me.MDob)
        Me.Panel3.Controls.Add(Me.Mage)
        Me.Panel3.Controls.Add(Me.MLname)
        Me.Panel3.Controls.Add(Me.MName)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(521, 407)
        Me.Panel3.TabIndex = 0
        '
        'CLEAR
        '
        Me.CLEAR.Location = New System.Drawing.Point(444, 379)
        Me.CLEAR.Name = "CLEAR"
        Me.CLEAR.Size = New System.Drawing.Size(72, 23)
        Me.CLEAR.TabIndex = 10
        Me.CLEAR.Text = "CLEAR"
        Me.CLEAR.UseVisualStyleBackColor = True
        '
        'PREVIEW
        '
        Me.PREVIEW.Location = New System.Drawing.Point(325, 379)
        Me.PREVIEW.Name = "PREVIEW"
        Me.PREVIEW.Size = New System.Drawing.Size(70, 23)
        Me.PREVIEW.TabIndex = 9
        Me.PREVIEW.Text = "PREVIEW"
        Me.PREVIEW.UseVisualStyleBackColor = True
        '
        'SAVE
        '
        Me.SAVE.Location = New System.Drawing.Point(197, 379)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(75, 23)
        Me.SAVE.TabIndex = 8
        Me.SAVE.Text = "SAVE"
        Me.SAVE.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "AGE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "DATE OF BIRTH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "LAST NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAME"
        '
        'Female
        '
        Me.Female.AutoSize = True
        Me.Female.Location = New System.Drawing.Point(304, 245)
        Me.Female.Name = "Female"
        Me.Female.Size = New System.Drawing.Size(67, 17)
        Me.Female.TabIndex = 4
        Me.Female.TabStop = True
        Me.Female.Text = "FEMALE"
        Me.Female.UseVisualStyleBackColor = True
        '
        'Male
        '
        Me.Male.AutoSize = True
        Me.Male.Location = New System.Drawing.Point(218, 245)
        Me.Male.Name = "Male"
        Me.Male.Size = New System.Drawing.Size(54, 17)
        Me.Male.TabIndex = 3
        Me.Male.TabStop = True
        Me.Male.Text = "MALE"
        Me.Male.UseVisualStyleBackColor = True
        '
        'MDob
        '
        Me.MDob.Location = New System.Drawing.Point(218, 135)
        Me.MDob.Name = "MDob"
        Me.MDob.Size = New System.Drawing.Size(140, 20)
        Me.MDob.TabIndex = 0
        '
        'Mage
        '
        Me.Mage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Mage.Location = New System.Drawing.Point(218, 198)
        Me.Mage.Name = "Mage"
        Me.Mage.ReadOnly = True
        Me.Mage.Size = New System.Drawing.Size(39, 20)
        Me.Mage.TabIndex = 2
        '
        'MLname
        '
        Me.MLname.Location = New System.Drawing.Point(218, 92)
        Me.MLname.Name = "MLname"
        Me.MLname.Size = New System.Drawing.Size(286, 20)
        Me.MLname.TabIndex = 1
        '
        'MName
        '
        Me.MName.Location = New System.Drawing.Point(218, 48)
        Me.MName.Name = "MName"
        Me.MName.Size = New System.Drawing.Size(286, 20)
        Me.MName.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(986, 143)
        Me.Panel2.TabIndex = 0
        '
        'MId
        '
        Me.MId.Location = New System.Drawing.Point(218, 5)
        Me.MId.Name = "MId"
        Me.MId.Size = New System.Drawing.Size(286, 20)
        Me.MId.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ID NUMBER"
        '
        'Pbox
        '
        Me.Pbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pbox.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pbox.Location = New System.Drawing.Point(3, 16)
        Me.Pbox.Multiline = True
        Me.Pbox.Name = "Pbox"
        Me.Pbox.Size = New System.Drawing.Size(447, 407)
        Me.Pbox.TabIndex = 0
        Me.Pbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(982, 139)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.SaveToolStripMenuItem, Me.toolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 135)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.OpenToolStripMenuItem.Text = "&VIEW MEMBERS"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(155, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(155, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'SIGNUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 638)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SIGNUP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIGNUP"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Female As RadioButton
    Friend WithEvents Male As RadioButton
    Friend WithEvents MDob As DateTimePicker
    Friend WithEvents Mage As TextBox
    Friend WithEvents MLname As TextBox
    Friend WithEvents SAVE As Button
    Friend WithEvents CLEAR As Button
    Friend WithEvents PREVIEW As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents MId As TextBox
    Friend WithEvents Pbox As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
