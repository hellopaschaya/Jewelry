Imports System.Data.SqlClient

Public Class ManageUser
    Private Sub ClearData()
        tbFLName.Text = ""
        tbShowID.Text = ""
        tbPass.Text = ""
        tbPassCF.Text = ""
        dtpBrith.Value = Date.Now
        cbType.SelectedIndex = 0
    End Sub
    Private Sub tsbAddData_Click(sender As Object, e As EventArgs) Handles tsbAddData.Click
        Me.Hide()
        IndexPage.Show()
    End Sub
    Private Sub setYear()
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture
    End Sub
    Public Sub LoadDDGender()
        Dim cn As New SqlConnection(Connection.Con)
        With cn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = Connection.Con
            .Open()
        End With
        Dim strSql As String

        strSql = "select * from tb_gendertype"

        Dim da As New SqlDataAdapter(strSql, cn)
        Dim ds As New DataSet
        da.Fill(ds, "data")



        cbType.DataSource = ds.Tables("data")
        cbType.DisplayMember = "p_gendername"
        cbType.ValueMember = "p_genderid"
    End Sub
    Public Sub GenId()
        Dim cn As New SqlConnection(Connection.Con)
        With cn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = Connection.Con
            .Open()
        End With
        Dim strSql As String
        strSql = "select TOP 1 p_personid from tb_person ORDER BY p_personid desc"

        Dim da As New SqlDataAdapter(strSql, cn)
        Dim ds As New DataSet

        da.Fill(ds, "data")
        If ds.Tables("data").Rows.Count = 0 Then
            'กรณีที่ยังไม่มีหนังสือเลยใน tbbook
            tbGenid.Text = "S001"
        Else
            'กรณีที่มีหนังสืออยู่แล้ว เราต้องเอารหัสล่าสุดมารันนิ่งนัมเบอร์ต่อจากของเดิม
            'สร้างตัวแปรเก็บรหัวล่าสุด
            Dim oldId As String = ds.Tables("data").Rows(0).Item("p_personid").ToString
            Dim rNumber As Integer = CInt(oldId.Substring(1, 3)) + 1
            Dim newId As String = "S" & rNumber.ToString("000")
            tbGenid.Text = newId
        End If

        cn.Close()
    End Sub



    Private Sub ManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbFLName.Focus()
        setYear()
        GenId()
        LoadDDGender()
    End Sub

   
    Private Sub tbFLName_Leave(sender As Object, e As EventArgs) Handles tbFLName.Leave
        Dim cn As New SqlConnection(Connection.Con)
        With cn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = Connection.Con
            .Open()
        End With
        Dim strSql As String
        strSql = "select p_nameperson from tb_person where p_nameperson = '" & tbFLName.Text & "' "

        Dim da As New SqlDataAdapter(strSql, cn)
        Dim ds As New DataSet

        da.Fill(ds, "data")
        If ds.Tables("data").Rows.Count > 0 Then
            MsgBox("มีคนใช้ชื่อนี้แล้ว")


            tbFLName.Focus()
            Return
        End If

        cn.Close()
    End Sub

    Private Sub tbShowID_Leave(sender As Object, e As EventArgs) Handles tbShowID.Leave
        Dim cn As New SqlConnection(Connection.Con)
        With cn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = Connection.Con
            .Open()
        End With
        Dim strSql As String
        strSql = "select p_userid from tb_person where p_userid = '" & tbShowID.Text.Trim & "' "

        Dim da As New SqlDataAdapter(strSql, cn)
        Dim ds As New DataSet

        da.Fill(ds, "data")
        If ds.Tables("data").Rows.Count > 0 Then
            MsgBox("มีคนใช้ User นี้แล้ว")
            tbShowID.Focus()
            Return
        End If

        cn.Close()
    End Sub

  
    Private Sub tbPassCF_Leave(sender As Object, e As EventArgs) Handles tbPassCF.Leave
        If tbPassCF.Text.Trim <> tbPass.Text.Trim Then
            MsgBox("คุณใส่รหัสผ่านไม่ตรงกัน")
            tbPassCF.Focus()
            Return
        End If
    End Sub


    Private Sub btSubmit_Click(sender As Object, e As EventArgs) Handles btSubmit.Click
        If tbFLName.Text = "" Or tbShowID.Text = "" Then
            MsgBox("ต้องกรอกข้อมูลให้ครบทุกช่อง")
            tbFLName.Focus()
        Else
            Select Case MsgBox("ยืนยันการสมัครสมาชิก", MsgBoxStyle.YesNo, "บันทึกข้อมูล")
                Case MsgBoxResult.Yes
                    Dim cn As New SqlConnection(Connection.Con)
                    With cn
                        If .State = ConnectionState.Open Then Close()
                        .ConnectionString = Connection.Con
                        .Open()
                    End With

                    Dim strSql As String



                    dtpBrith.Format = DateTimePickerFormat.Custom
                    dtpBrith.CustomFormat = "yyyy MMM dd"
                    strSql = "INSERT INTO tb_person (p_personid, p_nameperson, p_userid, p_password, p_brith, p_genderid)"
                    strSql = strSql & " VALUES ('" & tbGenid.Text & "','" & tbFLName.Text & "','" & tbShowID.Text.Trim & "', '" & tbPass.Text.Trim & "', '" & dtpBrith.Value.Date & "', '" & cbType.SelectedValue & "');"

                    Dim cm As New SqlCommand
                    With cm
                        'copy แปะได้เลยไม่ต้องแก้
                        .CommandType = CommandType.Text
                        .CommandText = strSql
                        .Connection = cn            'cn = connecttion ใน step ที่ 1
                        .Parameters.Clear()
                        .ExecuteNonQuery()
                        MessageBox.Show("บันทึกเรียบร้อยแล้ว")
                        GenId()
                        ClearData()
                        cn.Close()
                    End With

                Case MsgBoxResult.No


            End Select
        End If
        
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        ClearData()
    End Sub

    Private Sub tbShowID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbShowID.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If


        End If
    End Sub

    Private Sub tbPass_Leave(sender As Object, e As EventArgs) Handles tbPass.Leave
        If tbPass.Text.Length < 5 Then
            MessageBox.Show("password ต้องไม่น้อยกว่า 4 ตัว")
            tbPass.Focus()

        End If
    End Sub
End Class