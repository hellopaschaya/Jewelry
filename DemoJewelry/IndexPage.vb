Imports System.Data.SqlClient
Imports System.Globalization

Public Class IndexPage
    Dim idStaff As New ChangePass()
    Dim localDate = dateTime.Now
    Dim rNumber As Integer
    Private Sub SelectIDPWForCheck()
        Dim cn As New SqlConnection(Connection.Con)
        With cn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = Connection.Con
            .Open()
        End With
        Dim strSql As String

        strSql = "select p_personid, p_nameperson, p_userid, p_password from tb_person where p_userid = '" & tbGenid.Text & "' AND p_password = '" & tbFLName.Text & "' "

        Dim da As New SqlDataAdapter(strSql, cn)
        Dim ds As New DataSet
        da.Fill(ds, "data")

        Dim name As String
        Dim id As String



        If ds.Tables("data").Rows.Count = 0 Then
            MessageBox.Show("ไม่มี User นี้ในระบบ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbGenid.Focus()
            Return
        ElseIf ds.Tables("data").Rows.Count > 0 Then
            name = ds.Tables("data").Rows(0).Item("p_nameperson")
            id = ds.Tables("data").Rows(0).Item("p_personid")

            MessageBox.Show("ยินดีต้อนรับคุณ :" & name, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbFLName.Text = Convert.ToString(ds.Tables("data").Rows(0).Item("p_password"))
            tbGenid.Text = ""

            GroupBox1.Visible = False
            lbid.Text = id
            lbShowName.Text = name
            Label1.Visible = True
            btLogout.Visible = True
            Label3.Visible = True
            lbid.Visible = True
            tsbAddData.Visible = True
            ChangPasswordToolStripMenuItem.Visible = True
            lbShowName.Visible = True
            tsmRegister.Visible = False
            tsmEditPerson.Visible = True

            cn.Close()
        End If

    End Sub
    Private Sub DeleteLog()
        Dim cn As New SqlConnection(Connection.Con)
        With cn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = Connection.Con
            .Open()
        End With
        Dim strSql As String
        strSql = "DELETE FROM tb_log WHERE log_id in (SELECT TOP 1 log_id FROM tb_log)"
        Dim da As New SqlDataAdapter(strSql, cn)
        Dim ds As New DataSet
        da.Fill(ds, "data")
    End Sub
    Private Sub SelectLog()
        Dim cn As New SqlConnection(Connection.Con)
        With cn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = Connection.Con
            .Open()
        End With
        Dim strSql As String

        strSql = "select * from tb_log"

        Dim da As New SqlDataAdapter(strSql, cn)
        Dim ds As New DataSet
        da.Fill(ds, "data")
        If ds.Tables("data").Rows.Count > 10 Then
            DeleteLog()
        End If
    End Sub
    Private Sub InsertLogin()
        Dim cn As New SqlConnection(Connection.Con)
        With cn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = Connection.Con
            .Open()
        End With
        Dim strSql As String

        strSql = "INSERT INTO tb_log (log_id, p_personid, log_timein) VALUES ('" & rNumber & "', '" & lbid.Text & "', '" & localDate & "')"

        Dim da As New SqlDataAdapter(strSql, cn)
        Dim ds As New DataSet
        da.Fill(ds, "data")

        cn.Close()
    End Sub
    Private Sub InsertLogout()
        Dim cn As New SqlConnection(Connection.Con)
        With cn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = Connection.Con
            .Open()
        End With
        Dim strSql As String

        strSql = "UPDATE tb_log SET log_timeout =  '" & localDate & "' where log_id = '" & rNumber & "' "

        Dim da As New SqlDataAdapter(strSql, cn)
        Dim ds As New DataSet
        da.Fill(ds, "data")

        cn.Close()
    End Sub
    Private Sub setYear()
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture
    End Sub
    Private Sub tsbAddData_Click(sender As Object, e As EventArgs) Handles tsbAddData.Click

        Dim sname As New AddData

        sname.StringPass = lbShowName.Text

        sname.Show()
        Me.Hide()

    End Sub
    Private Sub GenIdLog()
        Dim cn As New SqlConnection(Connection.Con)
        With cn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = Connection.Con
            .Open()
        End With
        Dim strSql As String
        strSql = "select TOP 1 log_id from tb_log ORDER BY log_id desc"

        Dim da As New SqlDataAdapter(strSql, cn)
        Dim ds As New DataSet

        da.Fill(ds, "data")
        If ds.Tables("data").Rows.Count = 0 Then
            'กรณีที่ยังไม่มีหนังสือเลยใน tbbook
            Dim idlog As Integer
            idlog = 1
        Else
            'กรณีที่มีหนังสืออยู่แล้ว เราต้องเอารหัสล่าสุดมารันนิ่งนัมเบอร์ต่อจากของเดิม
            'สร้างตัวแปรเก็บรหัวล่าสุด
            Dim oldId As Integer = ds.Tables("data").Rows(0).Item("log_id")
            rNumber = oldId + 1
            cn.Close()
        End If
    End Sub

    Private Sub tsbExit_Click(sender As Object, e As EventArgs)
        Select Case MsgBox("Do You Want Exit Program ?", MsgBoxStyle.YesNo, "Exit Program")
            Case MsgBoxResult.Yes
                Application.Exit()
            Case MsgBoxResult.No
                ' MessageBox.Show(Connection.Con)
        End Select
    End Sub


    Private Sub tsmRegister_Click(sender As Object, e As EventArgs) Handles tsmRegister.Click
        ManageUser.Show()
        Me.Hide()
    End Sub

    Private Sub btSubmit_Click(sender As Object, e As EventArgs) Handles btSubmit.Click
        SelectLog()
        SelectIDPWForCheck()
        GenIdLog()
        InsertLogin()

       




       
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        tbGenid.Text = ""
        tbFLName.Text = ""
    End Sub



    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Select Case MsgBox("ต้องการออกจากโปรแกรมหรือไม่ ?", MsgBoxStyle.YesNo, "ออกจากโปรแกรม")
            Case MsgBoxResult.Yes
                If lbid.Text <> "" Or lbShowName.Text <> "" Then
                    MsgBox("กรุณา Logout ก่อนออกจากโปรแกรม", MsgBoxStyle.YesNo, "คำเตือน")
                Else
                    End
                End If


            Case MsgBoxResult.No

        End Select
    End Sub



    Private Sub btLogout_Click(sender As Object, e As EventArgs) Handles btLogout.Click
        Select Case MsgBox("ต้องการ Log Out หรือไม่ ?", MsgBoxStyle.YesNo, "ออกจากระบบ")
            Case MsgBoxResult.Yes
                Label1.Visible = False
                btLogout.Visible = False
                Label3.Visible = False
                lbid.Visible = False
                lbShowName.Visible = False
                tsbAddData.Visible = False
                lbid.Text = ""
                lbShowName.Text = ""
                GroupBox1.Visible = True
                tsmRegister.Visible = True
                tbFLName.Text = ""
                tsmEditPerson.Visible = False
                ChangPasswordToolStripMenuItem.Visible = False
                InsertLogout()


            Case MsgBoxResult.No

        End Select

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        ManageUser.Show()
        Me.Hide()
    End Sub

    Private Sub tbFLName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbFLName.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            btSubmit_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub ChangPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangPasswordToolStripMenuItem.Click
        If idStaff Is Nothing Then
            'control that form is not opened yet if open close before
            idStaff = New ChangePass()
        Else
            idStaff.Close()
            idStaff = New ChangePass()
        End If

        idStaff.sidStaff = lbid.Text

        idStaff.Show()
        Me.Hide()
    End Sub

    Private Sub tsmEditPerson_Click(sender As Object, e As EventArgs) Handles tsmEditPerson.Click
        Dim ChangeJobInfo As New EditPerson(lbid.Text, lbShowName.Text)
        ChangeJobInfo.Show()
        Me.Hide()
    End Sub

    Private Sub IndexPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        setYear()

    End Sub

    Private Sub IndexPage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        InsertLogout()
    End Sub
End Class