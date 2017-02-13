<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUser
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpBrith = New System.Windows.Forms.DateTimePicker()
        Me.tbFLName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbGenid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbPassCF = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbShowID = New System.Windows.Forms.TextBox()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStrip1.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAddData, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1248, 69)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbAddData
        '
        Me.tsbAddData.AutoSize = False
        Me.tsbAddData.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tsbAddData.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.tsbAddData.Image = Global.DemoJewelry.My.Resources.Resources.ic_home_black_24dp_1x
        Me.tsbAddData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddData.Name = "tsbAddData"
        Me.tsbAddData.Size = New System.Drawing.Size(95, 50)
        Me.tsbAddData.Text = "HOME"
        Me.tsbAddData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 69)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.dtpBrith)
        Me.GroupBox1.Controls.Add(Me.tbFLName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbGenid)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbType)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbPassCF)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbPass)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbShowID)
        Me.GroupBox1.Controls.Add(Me.btCancel)
        Me.GroupBox1.Controls.Add(Me.btSubmit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(270, 173)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(847, 544)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Register Form"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(609, 173)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 27)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "(ใช้ในการ Login)"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpBrith
        '
        Me.dtpBrith.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpBrith.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.dtpBrith.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBrith.Location = New System.Drawing.Point(275, 330)
        Me.dtpBrith.Name = "dtpBrith"
        Me.dtpBrith.Size = New System.Drawing.Size(189, 40)
        Me.dtpBrith.TabIndex = 21
        '
        'tbFLName
        '
        Me.tbFLName.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFLName.Location = New System.Drawing.Point(275, 100)
        Me.tbFLName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbFLName.MaxLength = 30
        Me.tbFLName.Name = "tbFLName"
        Me.tbFLName.Size = New System.Drawing.Size(326, 41)
        Me.tbFLName.TabIndex = 19
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
        Me.Label8.Text = "Fname -Lname"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbGenid
        '
        Me.tbGenid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbGenid.Enabled = False
        Me.tbGenid.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGenid.Location = New System.Drawing.Point(276, 39)
        Me.tbGenid.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbGenid.MaxLength = 5
        Me.tbGenid.Name = "tbGenid"
        Me.tbGenid.Size = New System.Drawing.Size(326, 41)
        Me.tbGenid.TabIndex = 19
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
        Me.Label7.Text = "Generated ID"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbType
        '
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Bold)
        Me.cbType.FormattingEnabled = True
        Me.cbType.Location = New System.Drawing.Point(275, 389)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(189, 41)
        Me.cbType.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label6.Location = New System.Drawing.Point(37, 393)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(231, 37)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Gender"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.Label5.Location = New System.Drawing.Point(31, 336)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(237, 34)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Brith Day"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbPassCF
        '
        Me.tbPassCF.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassCF.Location = New System.Drawing.Point(276, 273)
        Me.tbPassCF.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbPassCF.MaxLength = 30
        Me.tbPassCF.Name = "tbPassCF"
        Me.tbPassCF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassCF.Size = New System.Drawing.Size(326, 41)
        Me.tbPassCF.TabIndex = 13
        Me.tbPassCF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.Label4.Location = New System.Drawing.Point(31, 280)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 34)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Confirm PassWord"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbPass
        '
        Me.tbPass.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPass.Location = New System.Drawing.Point(276, 217)
        Me.tbPass.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbPass.MaxLength = 30
        Me.tbPass.Name = "tbPass"
        Me.tbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPass.Size = New System.Drawing.Size(326, 41)
        Me.tbPass.TabIndex = 11
        Me.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.Label3.Location = New System.Drawing.Point(31, 224)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 34)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "PassWord"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbShowID
        '
        Me.tbShowID.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbShowID.Location = New System.Drawing.Point(276, 159)
        Me.tbShowID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbShowID.MaxLength = 30
        Me.tbShowID.Name = "tbShowID"
        Me.tbShowID.Size = New System.Drawing.Size(326, 41)
        Me.tbShowID.TabIndex = 1
        Me.tbShowID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btCancel
        '
        Me.btCancel.BackColor = System.Drawing.Color.Gainsboro
        Me.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancel.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.btCancel.Image = Global.DemoJewelry.My.Resources.Resources.ic_clear_black_24dp_1x
        Me.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCancel.Location = New System.Drawing.Point(455, 453)
        Me.btCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btCancel.Size = New System.Drawing.Size(147, 41)
        Me.btCancel.TabIndex = 10
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
        Me.btSubmit.Location = New System.Drawing.Point(275, 453)
        Me.btSubmit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btSubmit.Name = "btSubmit"
        Me.btSubmit.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btSubmit.Size = New System.Drawing.Size(147, 41)
        Me.btSubmit.TabIndex = 10
        Me.btSubmit.Text = "Submit"
        Me.btSubmit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(31, 166)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "UserID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Image = Global.DemoJewelry.My.Resources.Resources.user1
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(0, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1248, 76)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Register"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ManageUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 772)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManageUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ManageUser"
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbShowID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbPassCF As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbPass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents btSubmit As System.Windows.Forms.Button
    Friend WithEvents tbGenid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpBrith As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbFLName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
