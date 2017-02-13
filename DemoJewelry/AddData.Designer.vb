<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddData
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
        Me.tbShowID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddID = New System.Windows.Forms.Button()
        Me.dgvShowItem = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnSearchID = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.rtbDetail = New System.Windows.Forms.RichTextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpPro = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbNamePro = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbPerson = New System.Windows.Forms.ComboBox()
        Me.lbShowName = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbPrintOne = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbPrintAll = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvShowItem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(1342, 69)
        Me.ToolStrip1.TabIndex = 0
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
        'tbShowID
        '
        Me.tbShowID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbShowID.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbShowID.Location = New System.Drawing.Point(177, 42)
        Me.tbShowID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbShowID.MaxLength = 5
        Me.tbShowID.Name = "tbShowID"
        Me.tbShowID.Size = New System.Drawing.Size(141, 41)
        Me.tbShowID.TabIndex = 1
        Me.tbShowID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ProductID :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddID
        '
        Me.btnAddID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddID.Location = New System.Drawing.Point(731, 165)
        Me.btnAddID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAddID.Name = "btnAddID"
        Me.btnAddID.Size = New System.Drawing.Size(111, 41)
        Me.btnAddID.TabIndex = 10
        Me.btnAddID.Text = "เพิ่ม"
        Me.btnAddID.UseVisualStyleBackColor = False
        '
        'dgvShowItem
        '
        Me.dgvShowItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowItem.Location = New System.Drawing.Point(731, 212)
        Me.dgvShowItem.Name = "dgvShowItem"
        Me.dgvShowItem.Size = New System.Drawing.Size(598, 291)
        Me.dgvShowItem.TabIndex = 10
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(850, 165)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(176, 41)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(1218, 165)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 41)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(1176, 509)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(153, 41)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "ClearData"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.tbShowID)
        Me.GroupBox1.Controls.Add(Me.btnSearchID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(98, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 106)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Product"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(336, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(179, 26)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "(Press Enter For Search)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearchID
        '
        Me.btnSearchID.BackColor = System.Drawing.Color.Silver
        Me.btnSearchID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchID.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.btnSearchID.Image = Global.DemoJewelry.My.Resources.Resources.ic_search_black_24dp_1x
        Me.btnSearchID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchID.Location = New System.Drawing.Point(336, 42)
        Me.btnSearchID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSearchID.Name = "btnSearchID"
        Me.btnSearchID.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnSearchID.Size = New System.Drawing.Size(179, 41)
        Me.btnSearchID.TabIndex = 10
        Me.btnSearchID.Text = "Search"
        Me.btnSearchID.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label3.Location = New System.Drawing.Point(138, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 37)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "รหัสสินค้า :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbID
        '
        Me.tbID.Enabled = False
        Me.tbID.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbID.Location = New System.Drawing.Point(314, 279)
        Me.tbID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbID.MaxLength = 5
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(221, 41)
        Me.tbID.TabIndex = 1
        Me.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label4.Location = New System.Drawing.Point(138, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 37)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ชื่อสินค้า :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label5.Location = New System.Drawing.Point(138, 413)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 37)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "ราคา :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label6.Location = New System.Drawing.Point(138, 474)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 37)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "ประเภทสินค้า :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label7.Location = New System.Drawing.Point(139, 538)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 37)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "รายละเอียด :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbPrice
        '
        Me.tbPrice.Enabled = False
        Me.tbPrice.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPrice.Location = New System.Drawing.Point(314, 409)
        Me.tbPrice.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbPrice.MaxLength = 20
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(221, 41)
        Me.tbPrice.TabIndex = 2
        Me.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rtbDetail
        '
        Me.rtbDetail.Enabled = False
        Me.rtbDetail.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Bold)
        Me.rtbDetail.Location = New System.Drawing.Point(314, 538)
        Me.rtbDetail.Name = "rtbDetail"
        Me.rtbDetail.Size = New System.Drawing.Size(221, 102)
        Me.rtbDetail.TabIndex = 4
        Me.rtbDetail.Text = ""
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(1034, 165)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(176, 41)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "อัพเดทข้อมูล"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'cbType
        '
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.Enabled = False
        Me.cbType.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Bold)
        Me.cbType.FormattingEnabled = True
        Me.cbType.Location = New System.Drawing.Point(314, 474)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(221, 41)
        Me.cbType.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 25.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(842, 578)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(418, 45)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Application By Paschaya"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 25.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(875, 623)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(440, 54)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Visual Studio 2013"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpPro
        '
        Me.dtpPro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpPro.Enabled = False
        Me.dtpPro.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.dtpPro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPro.Location = New System.Drawing.Point(697, 603)
        Me.dtpPro.Name = "dtpPro"
        Me.dtpPro.Size = New System.Drawing.Size(189, 40)
        Me.dtpPro.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label10.Location = New System.Drawing.Point(560, 603)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 37)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "วันที่"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label11.Location = New System.Drawing.Point(555, 538)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 37)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "พนักงาน"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbNamePro
        '
        Me.tbNamePro.Enabled = False
        Me.tbNamePro.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNamePro.Location = New System.Drawing.Point(314, 345)
        Me.tbNamePro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbNamePro.MaxLength = 30
        Me.tbNamePro.Name = "tbNamePro"
        Me.tbNamePro.Size = New System.Drawing.Size(221, 41)
        Me.tbNamePro.TabIndex = 1
        Me.tbNamePro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label12.Location = New System.Drawing.Point(542, 413)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(169, 37)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "บาท"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(1176, 553)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(153, 27)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "(press F5 to refresh)"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbPerson
        '
        Me.cmbPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPerson.Enabled = False
        Me.cmbPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.cmbPerson.FormattingEnabled = True
        Me.cmbPerson.Location = New System.Drawing.Point(697, 540)
        Me.cmbPerson.Name = "cmbPerson"
        Me.cmbPerson.Size = New System.Drawing.Size(261, 37)
        Me.cmbPerson.TabIndex = 5
        '
        'lbShowName
        '
        Me.lbShowName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbShowName.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.lbShowName.Location = New System.Drawing.Point(981, 18)
        Me.lbShowName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbShowName.Name = "lbShowName"
        Me.lbShowName.Size = New System.Drawing.Size(348, 34)
        Me.lbShowName.TabIndex = 23
        Me.lbShowName.Text = "UserName"
        Me.lbShowName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.Label14.Location = New System.Drawing.Point(843, 18)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(130, 34)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "ชื่อผู้ใช้งาน"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbPrintOne
        '
        Me.lbPrintOne.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbPrintOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lbPrintOne.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbPrintOne.Image = Global.DemoJewelry.My.Resources.Resources.ic_print_black_24dp_2x
        Me.lbPrintOne.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbPrintOne.Location = New System.Drawing.Point(839, 690)
        Me.lbPrintOne.Name = "lbPrintOne"
        Me.lbPrintOne.Size = New System.Drawing.Size(218, 73)
        Me.lbPrintOne.TabIndex = 15
        Me.lbPrintOne.Text = "พิมพ์ด้วยรหัสสินค้า"
        Me.lbPrintOne.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Image = Global.DemoJewelry.My.Resources.Resources.diamond__1_
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(0, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1342, 76)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Jewelry"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lbPrintAll
        '
        Me.lbPrintAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbPrintAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lbPrintAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbPrintAll.Image = Global.DemoJewelry.My.Resources.Resources.ic_print_black_24dp_2x
        Me.lbPrintAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbPrintAll.Location = New System.Drawing.Point(1111, 690)
        Me.lbPrintAll.Name = "lbPrintAll"
        Me.lbPrintAll.Size = New System.Drawing.Size(218, 73)
        Me.lbPrintAll.TabIndex = 15
        Me.lbPrintAll.Text = "พิมพ์ทั้งหมดในตาราง"
        Me.lbPrintAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'AddData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 756)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbShowName)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbPerson)
        Me.Controls.Add(Me.dtpPro)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.rtbDetail)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbNamePro)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.lbPrintAll)
        Me.Controls.Add(Me.lbPrintOne)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvShowItem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAddID)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Program Jewelry"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvShowItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAddData As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbShowID As System.Windows.Forms.TextBox
    Friend WithEvents btnAddID As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSearchID As System.Windows.Forms.Button
    Friend WithEvents dgvShowItem As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbPrice As System.Windows.Forms.TextBox
    Friend WithEvents rtbDetail As System.Windows.Forms.RichTextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpPro As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbNamePro As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbPerson As System.Windows.Forms.ComboBox
    Friend WithEvents lbShowName As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbPrintOne As System.Windows.Forms.Label
    Friend WithEvents lbPrintAll As System.Windows.Forms.Label

End Class
