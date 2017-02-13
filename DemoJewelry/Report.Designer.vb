<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSearchID = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 71)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1297, 562)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(191, 23)
        Me.txtCustomerID.MaxLength = 10
        Me.txtCustomerID.Multiline = True
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(176, 33)
        Me.txtCustomerID.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label11.Location = New System.Drawing.Point(29, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 37)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "รหัสสินค้า"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearchID
        '
        Me.btnSearchID.BackColor = System.Drawing.Color.Silver
        Me.btnSearchID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchID.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.btnSearchID.Image = Global.DemoJewelry.My.Resources.Resources.ic_search_black_24dp_1x
        Me.btnSearchID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchID.Location = New System.Drawing.Point(392, 13)
        Me.btnSearchID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSearchID.Name = "btnSearchID"
        Me.btnSearchID.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnSearchID.Size = New System.Drawing.Size(179, 43)
        Me.btnSearchID.TabIndex = 22
        Me.btnSearchID.Text = "Search"
        Me.btnSearchID.UseVisualStyleBackColor = False
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 645)
        Me.Controls.Add(Me.btnSearchID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Report"
        Me.Text = "Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnSearchID As System.Windows.Forms.Button
End Class
