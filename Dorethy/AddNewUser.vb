Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Interaction
Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports Npgsql

Public Class AddNewUser

    Private Const V11 As String = "Select * from users, cmb"
    Private Const V As String = ""
    Dim V12 As String
    Private Sub ScanNewRFID_Click(sender As Object, e As EventArgs) Handles ScanNewRFID.Click
        DRT_Login.ReturnTo = "2"
        DRT_Login.GetFromRFID = ""
        GetscannedRFID.Visible = True
        ScanNewRFID.Visible = False
        Refresh()
        Dim oForm As FrmMain
        oForm = New FrmMain()
        oForm.Show()

        Hide()
    End Sub

    Private Sub GetscannedRFID_Click(sender As Object, e As EventArgs) Handles GetscannedRFID.Click
        If DRT_Login.ReturnCodeRFID = "ok" And DRT_Login.ReturnTo = "2" Then
            ID_FS.Text = DRT_Login.GetFromRFID
        End If
        ScanNewRFID.Visible = False
        Save2DB.Visible = True
        GetscannedRFID.Visible = False
        Save2DB.PerformClick()

    End Sub

    Private Sub Save2DB_Click() Handles Save2DB.Click

        If V12 <> "EDT" Then
            Dim Conn As NpgsqlConnection
            Dim Adpt As NpgsqlDataAdapter

            'Dim cmd As NpgsqlCommand

            Dim npgsqlConnection As New NpgsqlConnection
            Conn = npgsqlConnection
            Conn.ConnectionString = IniStart.DBstr
            Conn.Open()

            Dim sql As String = "Select * from users where users.nfc = '" & ID_FS.Text & "'"

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

            If DataGridView1.Rows(0).Cells(1).Value = "" And Name2DB.Text <> "" Then
                AddNU2DB()
            ElseIf DataGridView1.Rows(0).Cells(1).Value <> "" Then
                Name2DB.Text = DataGridView1.Rows(0).Cells(1).Value
                ID_FS.Text = DataGridView1.Rows(0).Cells(2).Value
                Auth2DB.Text = DataGridView1.Rows(0).Cells(3).Value
                MsgBox("RFID is already stored in the database, select your option below",, "Dorethy message")
                DRT_Login.ReturnCodeRFID = "exist"
                ViewEKS()
            End If

        End If
        If V12 = "EDT" Then
            AddNU2DB()
        End If
    End Sub
    Private Sub AddNU2DB()
        
        If Name2DB.Text <> "" And Auth2DB.Text <> "" Then
            Dim Conn As NpgsqlConnection
            Dim Adpt As NpgsqlDataAdapter
            Dim cmd As NpgsqlCommand

            Conn = New NpgsqlConnection With {
                .ConnectionString = IniStart.DBstr
            }
            Conn.Open()

            Dim sql As String = V11

            Adpt = New NpgsqlDataAdapter(sql, Conn)

            If DRT_Login.ReturnCodeRFID = "ok" And V12 <> "EDT" Then
                sql = ("insert into public.users (" & Chr(34) & "user" & Chr(34) & ", nfc, auth) values (" & Chr(39) & Name2DB.Text & Chr(39) & ", " & Chr(39) & ID_FS.Text & Chr(39) & "," & Chr(39) & Auth2DB.Text & Chr(39) & ")")
            End If

            If V12 = "EDT" Then
                sql = "update public.users set ""user"" =" & Chr(39) & DataGridView1.Rows(0).Cells(1).Value & Chr(39) & ", auth = " & Chr(39) & DataGridView1.Rows(0).Cells(3).Value & Chr(39) & " where id=" & Chr(39) & DataGridView1.Rows(0).Cells(0).Value & Chr(39) & " "
            End If

            cmd = New NpgsqlCommand(sql, Conn)
            cmd.ExecuteNonQuery()

            Conn.Close()
            ID_FS.ForeColor.R.ToString()
            ID_FS.Text = "Key successfuly saved"
        End If
        If Name2DB.Text = "" And Auth2DB.Text = "" Then
            MsgBox("Name and authorisation need to be filled in!",, "Dorethy error message")
        End If
        ScanNewRFID.Visible = True
        Save2DB.Visible = False
        V12 = ""
    End Sub
    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        Name2DB.Text = ""
        Auth2DB.Text = ""
        HideEKS()
        ScanNewRFID.Visible = True
        GetscannedRFID.Visible = True
        DataGridView1.Columns.Clear()
        Dim oForm As DRT_Login
        oForm = New DRT_Login()
        oForm.Show()

        Hide()
    End Sub

    Private Sub AddNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Save2DB.Visible = False
        DataGridView1.Enabled = False
        HideEKS()
    End Sub
    Private Sub ViewEKS()
        SNI.Visible = True
        EDT.Visible = True
        SRM.Visible = True
    End Sub
    Private Sub HideEKS()
        SNI.Visible = False
        EDT.Visible = False
        SRM.Visible = False
    End Sub

    Private Sub SNI_Click(sender As Object, e As EventArgs) Handles SNI.Click
        HideEKS()
        ScanNewRFID.Visible = True
        Save2DB.Visible = False
        Name2DB.Text = ""
        Auth2DB.Text = ""
        ID_FS.Text = ""
    End Sub

    Private Sub EDT_Click(sender As Object, e As EventArgs) Handles EDT.Click
        V12 = "EDT"
        Name2DB.Text = DataGridView1.Rows(0).Cells(1).Value
        HideEKS()
        DataGridView1.Enabled = True
    End Sub


    Private Sub SRM_Click(sender As Object, e As EventArgs) Handles SRM.Click
        BtnReturn.PerformClick()

    End Sub
End Class