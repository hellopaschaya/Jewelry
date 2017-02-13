<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePass
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbConfirm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbFLName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbOldPass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btSubmit = New System.Windows.Forms.Button()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(1058, 69)
        Me.ToolStrip1.TabIndex = 2
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
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(0, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1058, 76)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Change Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbConfirm)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbFLName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbOldPass)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btCancel)
        Me.GroupBox1.Controls.Add(Me.btSubmit)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(317, 220)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(847, 372)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Change Password Form"
        '
        'tbConfirm
        '
        Me.tbConfirm.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConfirm.Location = New System.Drawing.Point(276, 161)
        Me.tbConfirm.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbConfirm.MaxLength = 30
        Me.tbConfirm.Name = "tbConfirm"
        Me.tbConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbConfirm.Size = New System.Drawing.Size(326, 41)
        Me.tbConfirm.TabIndex = 2
        Me.tbConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(31, 168)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 34)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Confirm Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbFLName
        '
        Me.tbFLName.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFLName.Location = New System.Drawing.Point(275, 100)
        Me.tbFLName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbFLName.MaxLength = 30
        Me.tbFLName.Name = "tbFLName"
        Me.tbFLName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
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
        Me.Label8.Text = "New Password"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbOldPass
        '
        Me.tbOldPass.Font = New System.Drawing.Font("AngsanaUPC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOldPass.Location = New System.Drawing.Point(276, 39)
        Me.tbOldPass.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbOldPass.MaxLength = 30
        Me.tbOldPass.Name = "tbOldPass"
        Me.tbOldPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbOldPass.Size = New System.Drawing.Size(326, 41)
        Me.tbOldPass.TabIndex = 1
        Me.tbOldPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.Label7.Location = New System.Drawing.Point(31, 46)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(237, 34)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Old Password"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btCancel
        '
        Me.btCancel.BackColor = System.Drawing.Color.Gainsboro
        Me.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancel.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.btCancel.Image = Global.DemoJewelry.My.Resources.Resources.ic_clear_black_24dp_1x
        Me.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCancel.Location = New System.Drawing.Point(455, 251)
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
        Me.btSubmit.Location = New System.Drawing.Point(275, 251)
        Me.btSubmit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btSubmit.Name = "btSubmit"
        Me.btSubmit.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btSubmit.Size = New System.Drawing.Size(147, 51)
        Me.btSubmit.TabIndex = 3
        Me.btSubmit.Text = "Ok"
        Me.btSubmit.UseVisualStyleBackColor = False
        '
        'ChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 733)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ChangePass"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAddData As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbConfirm As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbFLName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbOldPass As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents btSubmit As System.Windows.Forms.Button
End Class
