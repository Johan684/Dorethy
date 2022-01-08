Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Interaction
Imports System.Data.SqlClient
Imports Npgsql


Public Class Products

    Private Const V11 As String = "Select * from products, cmb"
    'Private Const V As String = ""
    Dim V12 As String

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
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

            Dim sql As String = "Select * from products where products.ean = '" & EAN2DB.Text & "'"

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
                MsgBox("EAN is already stored in the database, select your option below",, "Dorethy message")
                DRT_Login.ReturnCodeRFID = "exist"
                V12 = "EDT"
                BtnEdit.Visible = True
            End If

        End If

    End Sub
    Private Sub AddNU2DB()
        If EAN2DB.Text <> "" And Name2DB.Text <> "" And NETPR2DB.Text <> "" And SALESPR2DB.Text <> "" Then
            Dim Conn As NpgsqlConnection
            Dim Adpt As NpgsqlDataAdapter
            Dim cmd As NpgsqlCommand

            Conn = New NpgsqlConnection With {
                .ConnectionString = IniStart.DBstr
            }
            Conn.Open()

            Dim sql As String = V11

            Adpt = New NpgsqlDataAdapter(sql, Conn)

            If V12 <> "EDT" Then
                sql = ("insert into public.products (ean, name, netprice, salesprice) values (" & Chr(39) & EAN2DB.Text & Chr(39) & ", " & Chr(39) & Name2DB.Text & Chr(39) & "," & Chr(39) & NETPR2DB.Text & Chr(39) & ", " & Chr(39) & SALESPR2DB.Text & Chr(39) & ")")
            ElseIf V12 = "EDT" Then
                sql = "update public.products set name = " & Chr(39) & DataGridView1.CurrentRow.Cells(2).Value & Chr(39) & ", netprice = " & Chr(39) & DataGridView1.CurrentRow.Cells(3).Value & Chr(39) & ", salesprice = " & Chr(39) & DataGridView1.CurrentRow.Cells(4).Value & Chr(39) & " where id=" & Chr(39) & DataGridView1.CurrentRow.Cells(0).Value & Chr(39) & " "

            End If


            cmd = New NpgsqlCommand(sql, Conn)
            cmd.ExecuteNonQuery()

            Conn.Close()
            If ID_FS.Visible = False Then ID_FS.Visible = True
            ID_FS.ForeColor.R.ToString()
            ID_FS.Text = "Key successfuly saved"
            V12 = ""
            Application.DoEvents()
            System.Threading.Thread.Sleep(500)
            Application.DoEvents()
            ID_FS.Visible = False
            ClearFields()
            GoTo SKIPPED
        End If
        If V12 <> "EDT" And EAN2DB.Text = "" And Name2DB.Text = "" And NETPR2DB.Text = "" And SALESPR2DB.Text = "" Then
            MsgBox("All fields are mandatory!",, "Dorethy error message")
        End If
SKIPPED:
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        IF_SWN.Visible = True
        Dim Conn As NpgsqlConnection
        Dim Adpt As NpgsqlDataAdapter

        'Dim cmd As NpgsqlCommand

        Dim npgsqlConnection As New NpgsqlConnection
        Conn = npgsqlConnection
        Conn.ConnectionString = IniStart.DBstr
        Conn.Open()

        Dim sql As String = "Select * from products"

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
        BtnAdd.Text = "Save changes"

        V12 = "EDT"
        MsgBox("Edit your data in the datagrid and save your changed by clicking the Add new product button. Remember! You have to save settings per line!",, "Dorethy message")
    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        DataGridView1.Columns.Clear()
        IF_SWN.Visible = False
        Dim oForm As Menu
        oForm = New Menu()
        oForm.Show()

        Hide()
    End Sub
    Private Sub ClearFields()
        EAN2DB.Text = ""
        Name2DB.Text = ""
        NETPR2DB.Text = ""
        SALESPR2DB.Text = ""
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        EAN2DB.Text = DataGridView1.CurrentRow.Cells(1).Value
        Name2DB.Text = DataGridView1.CurrentRow.Cells(2).Value
        NETPR2DB.Text = DataGridView1.CurrentRow.Cells(3).Value
        SALESPR2DB.Text = DataGridView1.CurrentRow.Cells(4).Value
        V12 = "EDT"

    End Sub

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        IF_SWN.Visible = False
    End Sub

    Private Sub NETPR2DB_Keypress(sender As Object, e As KeyPressEventArgs) Handles NETPR2DB.KeyPress

        If (e.KeyChar = ".") Then
            e.KeyChar = ","
        End If
        If (e.KeyChar = Chr(13)) Then
            DataGridView1.CurrentRow.Cells(3).Value = NETPR2DB.Text
        End If
    End Sub

    Private Sub EAN2DB_Keypress(sender As Object, e As KeyPressEventArgs) Handles EAN2DB.KeyPress
        If (e.KeyChar = Chr(13)) Then
            DataGridView1.CurrentRow.Cells(1).Value = EAN2DB.Text
        End If
    End Sub

    Private Sub Name2DB_Keypress(sender As Object, e As KeyPressEventArgs) Handles Name2DB.KeyPress
        If (e.KeyChar = Chr(13)) Then
            DataGridView1.CurrentRow.Cells(2).Value = Name2DB.Text
        End If
    End Sub

    Private Sub SALESPR2DB_Keypress(sender As Object, e As KeyPressEventArgs) Handles SALESPR2DB.KeyPress

        If (e.KeyChar = ".") Then
            e.KeyChar = ","
        End If
        If (e.KeyChar = Chr(13)) Then
            DataGridView1.CurrentRow.Cells(4).Value = SALESPR2DB.Text
        End If
    End Sub
End Class