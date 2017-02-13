Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class AddData
    Public Property StringPass As String


    Private Function GetMyFormat(value As Int64) As String
        Select Case Math.Abs(value)
            Case Is < 1000000
                Return "0,.############'k'"
            Case Is < 1000000000
                Return "0,,.############'m'"
            Case Else
                Return "0,,,.############'b'"
        End Select
    End Function
    Private Sub setDgvShowS()
        Dim cn As New SqlConnection(Connection.Con)
        With cn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = Connection.Con
            .Open()
        End With
        Dim strSql As String
        strSql = "select a.p_id, a.p_name, a.p_price, b.p_typename, a.p_detail, c.p_nameperson, a.p_date from tb_addProduct as a INNER JOIN tb_productType as b ON a.p_typeid=b.p_typeid INNER JOIN tb_person as c ON a.p_personid=c.p_personid"
        Dim da As New SqlDataAdapter(strSql, cn)
        Dim ds As New DataSet
        da.Fill(ds, "data")
        dgvShowItem.DataSource = ds.Tables("data")
        cn.Close()
        With dgvShowItem
            .Columns(0).HeaderText = "รหัสสินค้า"
            .Columns(1).HeaderText = "ชื่อสินค้า"
            .Columns(2).HeaderText = "ราคา"
            .Columns(3).HeaderText = "ประเภทสินค้า"
            .Columns(4).HeaderText = "รายละเอียด"
            .Columns(5).HeaderText = "ชื่อผู้ลง"
            .Columns(6).HeaderText = "วันที่"

            .Columns(0).Width = 100
            .Columns(1).Width = 100
            .Columns(3).Width = 100
            .Columns(5).Width = 100
            .Columns(6).Width = 100

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            .ReadOnly = True
        End With
    End Sub
    Private Sub setYear()
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture
    End Sub
    Public Sub ClearData()

        tbShowID.Focus()
        cmbPerson.Enabled = False
        cmbPerson.SelectedIndex = 0
        tbShowID.Enabled = True
        tbShowID.Text = ""
        btnSearchID.Enabled = True
        tbID.Enabled = False
        tbID.Text = ""
        tbNamePro.Enabled = False
        tbNamePro.Text = ""
        tbPrice.Enabled = False
        tbPrice.Text = 0
        cbType.Enabled = False
        cbType.SelectedIndex = 0
        'cbType.SelectedItem = cbType.Items(0)
        rtbDetail.Enabled = False
        rtbDetail.Text = ""
        dtpPro.Enabled = False
        dtpPro.Value = Date.Now
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnSave.Enabled = False
        btnAddID.Enabled = True

    End Sub
    Public Sub LoadGV()
        Dim cn As New SqlConnection(Connection.Con)
        With cn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = Connection.Con
            .Open()
        End With
        Dim strSql As String

        strSql = "select a.p_id, a.p_name, a.p_price, b.p_typename, a.p_detail, c.p_nameperson, a.p_date from tb_addProduct as a INNER JOIN tb_productType as b ON a.p_typeid=b.p_typeid INNER JOIN tb_person as c ON a.p_personid=c.p_personid where p_id  ='" & tbShowID.Text & "' "

        Dim da As New SqlDataAdapter(strSql, cn)
        Dim ds As New DataSet
        da.Fill(ds, "data")
    End Sub
    Public Sub LoadDDType()
        Dim cn As New SqlConnection(Connection.Con)
        With cn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = Connection.Con
            .Open()
        End With
        Dim strSql As String

        strSql = "select * from tb_productType"

        Dim da As New SqlDataAdapter(strSql, cn)
        Dim ds As New DataSet
        da.Fill(ds, "data")



        cbType.DataSource = ds.Tables("data")
        cbType.DisplayMember = "p_typename"
        cbType.ValueMember = "p_typeid"
    End Sub
    Public Sub LoadDDPerson()
        Dim cn As New SqlConnection(Connection.Con)
        With cn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = Connection.Con
            .Open()
        End With
        Dim strSql As String

        strSql = "select * from tb_person"

        Dim da As New SqlDataAdapter(strSql, cn)
        Dim ds As New DataSet
        da.Fill(ds, "data")



        cmbPerson.DataSource = ds.Tables("data")
        cmbPerson.DisplayMember = "p_nameperson"
        cmbPerson.ValueMember = "p_personid"
    End Sub

    Private Sub AddData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True
        tbPrice.Text = 0
        setDgvShowS()
        setYear()
        LoadDDType()
        LoadDDPerson()
        tbShowID.Focus()
        lbShowName.Text = StringPass

    End Sub

    'select TOP 1 * from tb_addProduct as a
    'INNER JOIN tb_productType as b
    'ON a.p_typeid=b.p_typeid order by a.p_id DESC

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        setDgvShowS()
        ClearData()
    End Sub

    Private Sub btnAddID_Click_1(sender As Object, e As EventArgs) Handles btnAddID.Click
        tbNamePro.Focus()
        tbShowID.Text = ""
        cmbPerson.Enabled = True
        tbShowID.Enabled = False
        btnSearchID.Enabled = False
        tbNamePro.Enabled = True
        tbPrice.Enabled = True
        cbType.Enabled = True
        rtbDetail.Enabled = True
        dtpPro.Enabled = True
        btnSave.Enabled = True
        Dim cn As New SqlConnection(Connection.Con)
        With cn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = Connection.Con
            .Open()
        End With
        Dim strSql As String
        strSql = "select TOP 1 p_id from tb_addProduct ORDER BY p_id desc"

        Dim da As New SqlDataAdapter(strSql, cn)
        Dim ds As New DataSet

        da.Fill(ds, "data")
        If ds.Tables("data").Rows.Count = 0 Then
            'กรณีที่ยังไม่มีหนังสือเลยใน tbbook
            tbID.Text = "P001"
        Else
            'กรณีที่มีหนังสืออยู่แล้ว เราต้องเอารหัสล่าสุดมารันนิ่งนัมเบอร์ต่อจากของเดิม
            'สร้างตัวแปรเก็บรหัวล่าสุด
            Dim oldId As String = ds.Tables("data").Rows(0).Item("p_id").ToString
            Dim rNumber As Integer = CInt(oldId.Substring(1, 3)) + 1
            Dim newId As String = "P" & rNumber.ToString("000")
            tbID.Text = newId
        End If

        cn.Close()
    End Sub

    Private Sub btnSearchID_Click(sender As Object, e As EventArgs) Handles btnSearchID.Click

        If tbShowID.Text = "" Then
            MessageBox.Show("กรุณาใส่ข้อมูลการค้นหา", "ผลการค้นหา", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbShowID.Focus()
            Return

        Else

            tbNamePro.Enabled = True
            tbPrice.Enabled = True
            cbType.Enabled = True
            rtbDetail.Enabled = True
            cmbPerson.Enabled = True
            dtpPro.Enabled = True
            btnAddID.Enabled = False
            btnSave.Enabled = False
            btnDelete.Enabled = True
            btnUpdate.Enabled = True
            Dim cn As New SqlConnection(Connection.Con)
            With cn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = Connection.Con
                .Open()
            End With
            Dim strSql As String

            strSql = "select a.p_id, a.p_name, a.p_price, b.p_typename, a.p_detail, c.p_nameperson, a.p_date from tb_addProduct as a INNER JOIN tb_productType as b ON a.p_typeid=b.p_typeid INNER JOIN tb_person as c ON a.p_personid=c.p_personid where p_id  ='" & tbShowID.Text & "' "

            Dim da As New SqlDataAdapter(strSql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "data")


            If ds.Tables("data").Rows.Count = 0 Then
                MessageBox.Show("ไม่มีข้อมูลที่คุณค้นหา..", "ผลการค้นหา", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearData()


                Exit Sub
            End If

            tbID.Text = ds.Tables("data").Rows(0).Item("p_id")
            tbNamePro.Text = ds.Tables("data").Rows(0).Item("p_name").ToString.Trim
            Dim price As Double
            price = ds.Tables("data").Rows(0).Item("p_price").ToString.Trim
            tbPrice.Text = String.Format("{0:n}", price)
            cbType.Text = ds.Tables("data").Rows(0).Item("p_typename")


            rtbDetail.Text = ds.Tables("data").Rows(0).Item("p_detail")

            cmbPerson.Text = ds.Tables("data").Rows(0).Item("p_nameperson")

            dtpPro.Text = ds.Tables("data").Rows(0).Item("p_date")

            cn.Close()
        End If
    End Sub





    Private Sub tbShowID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbShowID.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            btnSearchID_Click(Me, EventArgs.Empty)
        End If

        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If


        End If


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Select Case MsgBox("คุณต้องการจะลบข้อมูลหรือไม่ " & vbCrLf & "Product ID : " & tbID.Text & "", MsgBoxStyle.YesNo, "บันทึกข้อมูล")
            Case MsgBoxResult.Yes
                Dim cn As New SqlConnection(Connection.Con)
                With cn
                    If .State = ConnectionState.Open Then Close()
                    .ConnectionString = Connection.Con
                    .Open()
                End With

                Dim strSql As String
                Dim amount As Integer
                amount = CType(tbPrice.Text, String)
                tbPrice.Text = amount.ToString("#,###.00")

                dtpPro.Format = DateTimePickerFormat.Custom
                dtpPro.CustomFormat = "yyyy MMM dd"
                strSql = "INSERT INTO tb_addProduct (p_id, p_name, p_price, p_typeid, p_detail, p_personid, p_date)"
                strSql = strSql & " VALUES ('" & tbID.Text & "','" & tbNamePro.Text & "','" & tbPrice.Text.Trim & "', '" & Integer.Parse(cbType.SelectedValue) & "', '" & rtbDetail.Text & "', '" & cmbPerson.SelectedValue & "', '" & dtpPro.Value.Date & "');"

                Dim cm As New SqlCommand
                With cm
                    'copy แปะได้เลยไม่ต้องแก้
                    .CommandType = CommandType.Text
                    .CommandText = strSql
                    .Connection = cn            'cn = connecttion ใน step ที่ 1
                    .Parameters.Clear()
                    .ExecuteNonQuery()
                    MessageBox.Show("บันทึกเรียบร้อยแล้ว")
                    ClearData()
                    setDgvShowS()
                    cn.Close()
                End With

            Case MsgBoxResult.No


        End Select
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Select Case MsgBox("คุณต้องการจะลบข้อมูลหรือไม่ " & vbCrLf & "Product ID : " & tbID.Text & "", MsgBoxStyle.YesNo, "ลบข้อมูล")
            Case MsgBoxResult.Yes

                Dim cn As New SqlConnection(Connection.Con)
                With cn
                    If .State = ConnectionState.Open Then
                        Close()
                        .ConnectionString = Connection.Con
                        .Open()
                    End If
                End With
                Dim strSql As String
                strSql = "DELETE FROM tb_addProduct WHERE p_id = '" & tbID.Text & "';"
                Dim da As New SqlDataAdapter(strSql, cn)
                Dim ds As New DataSet
                da.Fill(ds, "data")
                MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "ผลการลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearData()
                cn.Close()
                setDgvShowS()
            Case MsgBoxResult.No


        End Select
    End Sub



    Private Sub tbPrice_Leave(sender As Object, e As EventArgs) Handles tbPrice.Leave
        If tbPrice.Text = "" Then
            tbPrice.Text = ""
        Else
            Dim amount As Integer
            amount = CType(tbPrice.Text, Integer)
            tbPrice.Text = amount.ToString("#,##0.00")
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If tbNamePro.Text = "" Or tbPrice.Text = "" Then
            MessageBox.Show("ต้องกรอกชื่อสินค้าและราคา", "การกรอกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Select Case MsgBox("คุณต้องการจะแก้ไขข้อมูลหรือไม่ ", MsgBoxStyle.YesNo, "การแก้ไขข้อมูล")
                Case MsgBoxResult.Yes
                    Dim cn As New SqlConnection(Connection.Con)
                    With cn
                        If .State = ConnectionState.Open Then
                            .Close()
                            .ConnectionString = Connection.Con
                            .Open()
                        End If
                    End With
                    Dim amount As Integer
                    amount = CType(tbPrice.Text, String)
                    tbPrice.Text = amount.ToString("#,###.00")
                    Dim strSql As String
                    strSql = "UPDATE tb_addProduct SET " & _
            " p_id = '" & tbID.Text & "' " & _
            " ,p_name = '" & tbNamePro.Text & "' " & _
            " ,p_price = '" & Double.Parse(tbPrice.Text.Trim) & "' " & _
            " ,p_typeid = '" & Integer.Parse(cbType.SelectedValue) & "' " & _
             " ,p_detail = '" & rtbDetail.Text & "' " & _
             " ,p_personid = '" & cmbPerson.SelectedValue & "' " & _
             " ,p_date = '" & dtpPro.Value.Date & "' " & _
             " WHERE p_id = '" & tbID.Text & "' "
                    Dim da As New SqlDataAdapter(strSql, cn)
                    Dim ds As New DataSet
                    da.Fill(ds, "data")
                    MessageBox.Show("อัพเดทข้อมูลเรียบร้อยแล้ว", "ผลการแก้ไข", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearData()
                    setDgvShowS()
                    cn.Close()
                Case MsgBoxResult.No


            End Select
        End If




    End Sub

    Private Sub tsbAddData_Click(sender As Object, e As EventArgs) Handles tsbAddData.Click
        Me.Hide()
        IndexPage.Show()
    End Sub


    Private Sub AddData_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = 116 Then
            btnClear_Click(Me, EventArgs.Empty)
        End If
    End Sub



    Private Sub lbPrintOne_Click(sender As Object, e As EventArgs) Handles lbPrintOne.Click
        Dim pOne As New Report(1)
        pOne.Show()



    End Sub

    Private Sub lbPrintAll_Click(sender As Object, e As EventArgs) Handles lbPrintAll.Click
        Dim pAll As New Report("2")
        pAll.Show()
    End Sub
End Class
