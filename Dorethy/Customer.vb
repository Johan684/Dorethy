Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Interaction
Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports Npgsql


Public Class Customer

    Private Const V11 As String = "Select * from customer, cmb"
    'Private Const V As String = ""
    Dim V12 As String

    Private Sub BtnScanCrd_Click(sender As Object, e As EventArgs) Handles BtnScanCrd.Click

        BtnScanCrd.Visible = False
        BtnGetCardData.Visible = True
        DRT_Login.ReturnTo = "3"
        DRT_Login.GetFromRFID = ""
        NFC2DB.Text = ""
        Dim oForm As FrmMain
        oForm = New FrmMain()
        oForm.Show()

        Hide()
    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LockFields()
        DataGridView1.Enabled = False
        If DRT_Login.ReturnTo = "3" Then
            BtnGetCardData.Visible = True
        End If
    End Sub

    Private Sub BtnGetCardData_Click(sender As Object, e As EventArgs) Handles BtnGetCardData.Click
        NFC2DB.Text = DRT_Login.GetFromRFID
        BtnGetCardData.Visible = False
        BtnScanCrd.Visible = False
        OpenFields()
        DispBAnfc()
    End Sub

    Private Sub DispBAnfc()
        Dim Conn As NpgsqlConnection
        Dim Adpt As NpgsqlDataAdapter

        'Dim cmd As NpgsqlCommand

        Dim npgsqlConnection As New NpgsqlConnection
        Conn = npgsqlConnection
        Conn.ConnectionString = IniStart.DBstr
        Conn.Open()

        Dim sql As String = "Select * from customer where customer.nfc = '" & NFC2DB.Text & "'"

        Adpt = New NpgsqlDataAdapter(sql, Conn)
        Dim RS As New DataTable
        Try
            Adpt.Fill(RS)
            Dim ds As New DataSet("DataSetOne")
            ds.Tables.Add(RS)
            DataGridView1.DataSource = RS
            Conn.Close()
        Catch ex As Exception
            MsgBox("Some database error ocurred!",, "Dorethy message")
        End Try

        Conn.Close()

    End Sub
    Private Sub BtnAdd_Click() Handles BtnAdd.Click
        If V12 = "EDT" Then
            AddNU2DB()
        ElseIf V12 <> "EDT" Then
            Dim Conn As NpgsqlConnection
            Dim Adpt As NpgsqlDataAdapter

            'Dim cmd As NpgsqlCommand

            Dim npgsqlConnection As New NpgsqlConnection
            Conn = npgsqlConnection
            Conn.ConnectionString = IniStart.DBstr
            Conn.Open()

            Dim sql As String = "Select * from customer where customer.nfc = '" & NFC2DB.Text & "'"

            Adpt = New NpgsqlDataAdapter(sql, Conn)
            Dim RS As New DataTable
            Try
                Adpt.Fill(RS)
                Dim ds As New DataSet("DataSetOne")
                ds.Tables.Add(RS)
                DataGridView1.DataSource = RS
                Conn.Close()
            Catch ex As Exception
                MsgBox("Some database error ocurred!",, "Dorethy message")
            End Try

            Conn.Close()

            If DataGridView1.Rows(0).Cells(1).Value = "" Then
                AddNU2DB()
            ElseIf DataGridView1.Rows(0).Cells(1).Value <> "" Then
                MsgBox("Campinglocation is in use, correct the error",, "Dorethy message")
                DRT_Login.ReturnCodeRFID = "exist"
                V12 = "EDT"
                BtnEdit.Visible = True
            End If

        End If
    End Sub

    Private Sub AddNU2DB()
        If Name2DB.Text <> "" And Address2DB.Text <> "" And PostalC2DB.Text <> "" And City2DB.Text <> "" And PHONE2DB.Text <> "" And NFC2DB.Text <> "" And CLOC2DB.Text <> "" Then
            Dim Conn As NpgsqlConnection
            Dim Adpt As NpgsqlDataAdapter
            Dim cmd As NpgsqlCommand

            Conn = New NpgsqlConnection With {
                .ConnectionString = IniStart.DBstr
            }
            Conn.Open()

            Dim sql As String = V11
            Dim Cloc As Integer = Convert.ToInt32(CLOC2DB.Text)
            Dim LBL As Integer
            If LBleft.Text = "Has left" Then LBL = 0
            If LBleft.Text = "Has arrived" Then LBL = 1
            Adpt = New NpgsqlDataAdapter(sql, Conn)

            If V12 <> "EDT" Then
                sql = ("insert into public.customer (name, address, postalcode, city, phone, nfc, clocation, active) values (" & Chr(39) & Name2DB.Text & Chr(39) & ", " & Chr(39) & Address2DB.Text & Chr(39) & "," & Chr(39) &
                   PostalC2DB.Text & Chr(39) & ", " & Chr(39) & City2DB.Text & Chr(39) & "," & Chr(39) &
                   PHONE2DB.Text & Chr(39) & ", " & Chr(39) & NFC2DB.Text & Chr(39) & "," & Chr(39) & Cloc & Chr(39) & "," & Chr(39) & LBL & Chr(39) & ")")
            ElseIf V12 = "EDT" Then
                sql = "update public.customer set name = " & Chr(39) & DataGridView1.Rows(0).Cells(1).Value & Chr(39) & ", address = " & Chr(39) & DataGridView1.Rows(0).Cells(2).Value & Chr(39) & ", postalcode = " & Chr(39) & DataGridView1.Rows(0).Cells(3).Value & Chr(39) &
                   ", city = " & Chr(39) & DataGridView1.Rows(0).Cells(4).Value & Chr(39) & ", phone = " & Chr(39) & DataGridView1.Rows(0).Cells(5).Value & Chr(39) & ", nfc = " & Chr(39) & DataGridView1.Rows(0).Cells(6).Value & Chr(39) & ", clocation = " & Chr(39) & DataGridView1.Rows(0).Cells(7).Value & Chr(39) &
                   ", active = " & Chr(39) & DataGridView1.Rows(0).Cells(8).Value & Chr(39) & " where id=" & Chr(39) & DataGridView1.Rows(0).Cells(0).Value & Chr(39) & " "

            End If


            cmd = New NpgsqlCommand(sql, Conn)
            cmd.ExecuteNonQuery()

            Conn.Close()
            ID_FS.Visible = True
            ID_FS.ForeColor.R.ToString()
            ID_FS.Text = "Key successfuly saved"

        End If
        If V12 = "EDT" Then
            V12 = ""
        ElseIf Name2DB.Text = "" Or Address2DB.Text = "" Or PostalC2DB.Text = "" Or City2DB.Text = "" Or PHONE2DB.Text = "" Or CLOC2DB.Text = "" Or LBleft.Text = "" Then
            MsgBox("All fields are mandatory!",, "Dorethy error message")
        End If
        ClearFields()
    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        DataGridView1.Columns.Clear()
        ClearFields()
        BtnGetCardData.Visible = True
        BtnScanCrd.Visible = True
        InfoHTC.Visible = False
        DataGridView1.Enabled = False
        Dim oForm As Menu
        oForm = New Menu()
        oForm.Show()

        Hide()
    End Sub
    Private Sub ClearFields()
        Name2DB.Text = ""
        Address2DB.Text = ""
        PostalC2DB.Text = ""
        City2DB.Text = ""
        PHONE2DB.Text = ""
        NFC2DB.Text = ""
    End Sub
    Private Sub LockFields()
        Name2DB.Enabled = False
        Address2DB.Enabled = False
        PostalC2DB.Enabled = False
        City2DB.Enabled = False
        PHONE2DB.Enabled = False
        InfoHTC.Visible = False
        ID_FS.Visible = False
    End Sub
    Private Sub OpenFields()
        Name2DB.Enabled = True
        Address2DB.Enabled = True
        PostalC2DB.Enabled = True
        City2DB.Enabled = True
        PHONE2DB.Enabled = True
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim LBL As Integer
        V12 = "EDT"
        Name2DB.Text = DataGridView1.Rows(0).Cells(1).Value
        Address2DB.Text = DataGridView1.Rows(0).Cells(2).Value
        PostalC2DB.Text = DataGridView1.Rows(0).Cells(3).Value
        City2DB.Text = DataGridView1.Rows(0).Cells(4).Value
        PHONE2DB.Text = DataGridView1.Rows(0).Cells(5).Value
        NFC2DB.Text = DataGridView1.Rows(0).Cells(6).Value
        CLOC2DB.Text = DataGridView1.Rows(0).Cells(7).Value
        LBL = DataGridView1.Rows(0).Cells(8).Value
        If LBL = 0 Then LBleft.Text = "Has left"
        If LBL = 1 Then LBleft.Text = "Has arrived"
        InfoHTC.Visible = True
        DataGridView1.Enabled = True
    End Sub
End Class