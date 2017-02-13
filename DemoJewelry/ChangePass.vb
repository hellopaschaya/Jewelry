Imports System.Data.SqlClient

Public Class ChangePass
    Public sidStaff As String
    Private Sub tsbAddData_Click(sender As Object, e As EventArgs) Handles tsbAddData.Click
        Me.Hide()
        IndexPage.Show()
    End Sub

    Private Sub tbGenid_Leave(sender As Object, e As EventArgs) Handles tbOldPass.Leave
        Dim cn As New SqlConnection(Connection.Con)
        With cn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = Connection.Con
            .Open()
        End With
        Dim strSql As String

        strSql = "select * from tb_person where p_password = '" & tbOldPass.Text & "' "

        Dim da As New SqlDataAdapter(strSql, cn)
        Dim ds As New DataSet
        da.Fill(ds, "data")

        If ds.Tables("data").Rows.Count = 0 Then
            MessageBox.Show("password เดิมผิดพลาด กรุณาลองใหม่", "Old Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbOldPass.Focus()
            Return
        End If
        
    End Sub

    Private Sub btSubmit_Click(sender As Object, e As EventArgs) Handles btSubmit.Click
        If tbOldPass.Text = "" Or tbFLName.Text = "" Or tbConfirm.Text = "" Then
            MsgBox("กรุณาใส่ข้อมูลให้ครบทุกช่อง")
            tbOldPass.Focus()
            Return
        Else
            Select Case MsgBox("ต้องการเปลี่ยน Password ใช่หรือไม่ ?", MsgBoxStyle.YesNo, "Chang Password")
                Case MsgBoxResult.Yes
                    Dim cn As New SqlConnection(Connection.Con)
                    With cn
                        If .State = ConnectionState.Open Then .Close()
                        .ConnectionString = Connection.Con
                        .Open()
                    End With
                    Dim strSql As String
                    strSql = "UPDATE tb_person SET p_password = '" & tbFLName.Text & "' where p_personid = '" & sidStaff & "'"
                    Dim da As New SqlDataAdapter(strSql, cn)
                    Dim ds As New DataSet
                    da.Fill(ds, "data")
                    cn.Close()
                    MsgBox("เปลี่ยน password สำเร็จ")

                    MsgBox("กรุณาล็อคอินใหม่")
                    End

                Case MsgBoxResult.No

            End Select
        End If
    End Sub

    Private Sub tbConfirm_Leave(sender As Object, e As EventArgs) Handles tbConfirm.Leave
        If tbConfirm.Text <> tbFLName.Text Then
            MessageBox.Show("password และ confirm password ต้องตรงกัน", "Confirm Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbConfirm.Focus()
            Return
        End If
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        tbOldPass.Text = ""
        tbFLName.Text = ""
        tbConfirm.Text = ""
        tbOldPass.Focus()


    End Sub
End Class