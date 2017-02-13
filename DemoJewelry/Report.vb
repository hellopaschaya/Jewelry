Imports CrystalDecisions.CrystalReports.Engine
Public Class Report

    Private _spAll As String
   

    Sub New(all As String)
        ' TODO: Complete member initialization 
        InitializeComponent()
        _spAll = all
    End Sub

 

   

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        txtCustomerID.Focus()
        If _spAll = "2" Then
            Label11.Visible = False
            txtCustomerID.Visible = False
            btnSearchID.Visible = False
            CrystalReportViewer1.Dock = DockStyle.Fill
            Dim rpt As New ReportDocument()

            Dim directory As String = My.Application.Info.DirectoryPath

            'rpt.Load(directory & "\myCrystalReport1.rpt")

            rpt.Load("E:\DemoJewelry\DemoJewelry\CRAll.rpt")



            Me.CrystalReportViewer1.ReportSource = rpt

            Me.CrystalReportViewer1.Refresh()

        End If
    End Sub

    Private Sub btnSearchID_Click(sender As Object, e As EventArgs) Handles btnSearchID.Click

        Dim rpt As New ReportDocument()

        Dim directory As String = My.Application.Info.DirectoryPath

        'rpt.Load(directory & "\myCrystalReport1.rpt")

        rpt.Load("E:\DemoJewelry\DemoJewelry\CrystalReport1.rpt")
        rpt.SetParameterValue("p_id", Me.txtCustomerID.Text)


        Me.CrystalReportViewer1.ReportSource = rpt

        Me.CrystalReportViewer1.Refresh()
    End Sub

    Private Sub txtCustomerID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustomerID.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            btnSearchID_Click(Me, EventArgs.Empty)
        End If
    End Sub
End Class