<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndexPage
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbAddData = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbUser = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmEditPerson = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmRegister = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbFLName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbGenid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbShowName = New System.Windows.Forms.Label()
        Me.btLogout = New System.Windows.Forms.Button()
        Me.lbid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStrip1.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAddData, Me.ToolStripSeparator1, Me.tsbUser, Me.ToolStripSeparator2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1364, 69)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbAddData
        '
        Me.tsbAddData.AutoSize = False
        Me.tsbAddData.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tsbAddData.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.tsbAddData.Image = Global.DemoJewelry.My.Resources.Resources.ic_add_black_24dp_1x
        Me.tsbAddData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddData.Name = "tsbAddData"
        Me.tsbAddData.Size = New System.Drawing.Size(95, 50)
        Me.tsbAddData.Text = "AddProduct"
        Me.tsbAddData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbAddData.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 69)
        '
        'tsbUser
        '
        Me.tsbUser.AutoSize = False
        Me.tsbUser.BackColor = System.Drawing.Color.Aqua
        Me.tsbUser.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmEditPerson, Me.tsmRegister, Me.ChangPasswordToolStripMenuItem})
        Me.tsbUser.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.tsbUser.Image = Global.DemoJewelry.My.Resources.Resources.ic_account_circle_black_24dp_1x
        Me.tsbUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbUser.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.tsbUser.Name = "tsbUser"
        Me.tsbUser.Size = New System.Drawing.Size(140, 50)
        Me.tsbUser.Text = "Manage Account"
        Me.tsbUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsmEditPerson
        '
        Me.tsmEditPerson.Name = "tsmEditPerson"
        Me.tsmEditPerson.Size = New System.Drawing.Size(193, 28)
        Me.tsmEditPerson.Text = "แก้ไขข้อมูลส่วนตัว"
        Me.tsmEditPerson.Visible = False
        '
        'tsmRegister
        '
        Me.tsmRegister.Name = "tsmRegister"
        Me.tsmRegister.Size = New System.Drawing.Size(193, 28)
        Me.tsmRegister.Text = "Register"
        '
        'ChangPasswordToolStripMenuItem
        '
        Me.ChangPasswordToolStripMenuItem.Name = "ChangPasswordToolStripMenuItem"
        Me.ChangPasswordToolStripMenuItem.Size = New System.Drawing.Size(193, 28)
        Me.ChangPasswordToolStripMenuItem.Text = "Chang Password"
        Me.ChangPasswordToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 69)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ToolStripButton1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.ToolStripButton1.Image = Global.DemoJewelry.My.Resources.Resources.ic_power_settings_new_black_24dp_1x
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(60, 50)
        Me.ToolStripButton1.Text = "Exit"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.tbFLName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbGenid)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btCancel)
        Me.GroupBox1.Controls.Add(Me.btSubmit)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(257, 181)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(847, 300)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login Form"
        '
        'Label13
        '
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline)
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(272, 237)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(150, 27)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Register"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbFLName
        '
        Me.tbFLName.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFLName.Location = New System.Drawing.Point(275, 100)
        Me.tbFLName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbFLName.MaxLength = 30
        Me.tbFLName.Name = "tbFLName"
        Me.tbFLName.Size = New System.Drawing.Size(326, 41)
        Me.tbFLName.TabIndex = 2
        Me.tbFLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.Label8.Location = New System.Drawing.Point(30, 107)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(237, 34)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Password"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbGenid
        '
        Me.tbGenid.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGenid.Location = New System.Drawing.Point(276, 39)
        Me.tbGenid.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbGenid.MaxLength = 30
        Me.tbGenid.Name = "tbGenid"
        Me.tbGenid.Size = New System.Drawing.Size(326, 41)
        Me.tbGenid.TabIndex = 1
        Me.tbGenid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.Label7.Location = New System.Drawing.Point(31, 46)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(237, 34)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "UserName"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btCancel
        '
        Me.btCancel.BackColor = System.Drawing.Color.Gainsboro
        Me.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancel.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.btCancel.Image = Global.DemoJewelry.My.Resources.Resources.ic_clear_black_24dp_1x
        Me.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCancel.Location = New System.Drawing.Point(455, 170)
        Me.btCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btCancel.Size = New System.Drawing.Size(147, 51)
        Me.btCancel.TabIndex = 4
        Me.btCancel.Text = "Cancel"
        Me.btCancel.UseVisualStyleBackColor = False
        '
        'btSubmit
        '
        Me.btSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSubmit.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.btSubmit.Image = Global.DemoJewelry.My.Resources.Resources.ic_done_black_24dp_1x
        Me.btSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSubmit.Location = New System.Drawing.Point(275, 170)
        Me.btSubmit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btSubmit.Name = "btSubmit"
        Me.btSubmit.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btSubmit.Size = New System.Drawing.Size(147, 51)
        Me.btSubmit.TabIndex = 3
        Me.btSubmit.Text = "Login"
        Me.btSubmit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(11, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 34)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "ชื่อพนักงาน"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'lbShowName
        '
        Me.lbShowName.BackColor = System.Drawing.SystemColors.Control
        Me.lbShowName.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.lbShowName.Location = New System.Drawing.Point(149, 144)
        Me.lbShowName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbShowName.Name = "lbShowName"
        Me.lbShowName.Size = New System.Drawing.Size(348, 34)
        Me.lbShowName.TabIndex = 21
        Me.lbShowName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbShowName.Visible = False
        '
        'btLogout
        '
        Me.btLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLogout.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.btLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btLogout.Location = New System.Drawing.Point(505, 137)
        Me.btLogout.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btLogout.Name = "btLogout"
        Me.btLogout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btLogout.Size = New System.Drawing.Size(147, 49)
        Me.btLogout.TabIndex = 21
        Me.btLogout.Text = "Log Out"
        Me.btLogout.UseVisualStyleBackColor = False
        Me.btLogout.Visible = False
        '
        'lbid
        '
        Me.lbid.BackColor = System.Drawing.SystemColors.Control
        Me.lbid.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.lbid.Location = New System.Drawing.Point(149, 95)
        Me.lbid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbid.Name = "lbid"
        Me.lbid.Size = New System.Drawing.Size(348, 34)
        Me.lbid.TabIndex = 23
        Me.lbid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbid.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.Label3.Location = New System.Drawing.Point(11, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 34)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "รหัสพนักงาน"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'IndexPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 727)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btLogout)
        Me.Controls.Add(Me.lbShowName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IndexPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "IndexPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAddData As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbUser As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsmRegister As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbFLName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbGenid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents btSubmit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbShowName As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btLogout As System.Windows.Forms.Button
    Friend WithEvents lbid As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tsmEditPerson As System.Windows.Forms.ToolStripMenuItem
End Class
