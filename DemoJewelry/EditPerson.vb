Imports System.Data.SqlClient

Public Class EditPerson

    Private _p1 As String
    Private _p2 As String

    Sub New(p1 As String, p2 As String)
        ' TODO: Complete member initialization 
        InitializeComponent()
        _p1 = p1
        _p2 = p2
    End Sub

    Private Sub tsbAddData_Click(sender As Object, e As EventArgs) Handles tsbAddData.Click
        Me.Hide()
        IndexPage.Show()
    End Sub

    Private Sub EditPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbGenid.Text = _p1
        tbFLName.Text = _p2
    End Sub

    Private Sub btSubmit_Click(sender As Object, e As EventArgs) Handles btSubmit.Click
        If tbNewName.Text = "" Then
            MsgBox("กรุณาใส่ชื่อที่ต้องการเปลี่ยน")
        Else
            Select Case MsgBox("ต้องการเปลี่ยนชื่อใช่หรือไม่ ?", MsgBoxStyle.YesNo, "การแจ้งเตือน")
                Case MsgBoxResult.Yes
                    Dim cn As New SqlConnection(Connection.Con)
                    With cn
                        If .State = ConnectionState.Open Then .Close()
                        .ConnectionString = Connection.Con
                        .Open()
                    End With
                    Dim strSql As String

                    strSql = "UPDATE tb_person SET p_nameperson = '" & tbNewName.Text & "' WHERE p_personid = '" & tbGenid.Text & "' "
                    Dim da As New SqlDataAdapter(strSql, cn)
                    Dim ds As New DataSet
                    da.Fill(ds, "data")

                    MsgBox("เปลี่ยนชื่อสำเร็จ")

                    MsgBox("กรุณาล็อคอินใหม่")
                    cn.Close()
                    End
                Case MsgBoxResult.No

            End Select
        End If
    End Sub
End Class