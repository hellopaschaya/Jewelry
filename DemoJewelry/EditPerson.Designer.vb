<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPerson
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbFLName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbGenid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNewName = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStrip1.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAddData})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1045, 69)
        Me.ToolStrip1.TabIndex = 3
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbNewName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbFLName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbGenid)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btCancel)
        Me.GroupBox1.Controls.Add(Me.btSubmit)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(99, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(847, 333)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Name"
        '
        'tbFLName
        '
        Me.tbFLName.Enabled = False
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
        Me.Label8.Text = "ชื่อพนักงาน(เดิม)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbGenid
        '
        Me.tbGenid.Enabled = False
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
        Me.Label7.Text = "ID ในระบบ"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btCancel
        '
        Me.btCancel.BackColor = System.Drawing.Color.Gainsboro
        Me.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancel.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.btCancel.Image = Global.DemoJewelry.My.Resources.Resources.ic_clear_black_24dp_1x
        Me.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCancel.Location = New System.Drawing.Point(455, 230)
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
        Me.btSubmit.Location = New System.Drawing.Point(275, 230)
        Me.btSubmit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btSubmit.Name = "btSubmit"
        Me.btSubmit.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btSubmit.Size = New System.Drawing.Size(147, 51)
        Me.btSubmit.TabIndex = 3
        Me.btSubmit.Text = "Edit"
        Me.btSubmit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(31, 166)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 34)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ใส่ชื่อใหม่"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbNewName
        '
        Me.tbNewName.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNewName.Location = New System.Drawing.Point(276, 159)
        Me.tbNewName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbNewName.MaxLength = 30
        Me.tbNewName.Name = "tbNewName"
        Me.tbNewName.Size = New System.Drawing.Size(326, 41)
        Me.tbNewName.TabIndex = 2
        Me.tbNewName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EditPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 541)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditPerson"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EditPerson"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAddData As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbFLName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbGenid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents btSubmit As System.Windows.Forms.Button
    Friend WithEvents tbNewName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
