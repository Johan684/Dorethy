Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Interaction
Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports Npgsql
Public Class Report
    Private Const V11 As String = "0000"
    Private Const V12 As String = "2359"
    'Dim V12 As String
    Dim A1, Dat2Day, RepSLSst, RepSLSsp As String
    ReadOnly time As DateTime = DateTime.Now

    ReadOnly format3 As String = "yMd"

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        Dim Conn As NpgsqlConnection
        Dim Adpt As NpgsqlDataAdapter

        'Dim cmd As NpgsqlCommand

        Dim npgsqlConnection As New NpgsqlConnection
        Conn = npgsqlConnection
        Conn.ConnectionString = IniStart.DBstr
        Conn.Open()
        Dim sql As String
        Dat2Day = time.ToString(format3)
        RepSLSst = Dat2Day & V11
        RepSLSsp = Dat2Day & V12
        If LBTable.Text = "Customer" Then
            A1 = "Select * from customer"
        End If
        If LBTable.Text = "Products" Then
            A1 = "Select * from products"
        End If
        If LBTable.Text = "Sales Today" Then
            A1 = "Select * from sales, payments, products where payments.salesid > '" & RepSLSst & "' and sales.salesid = payments.salesid and sales.ean=products.ean"
            'and payments.salesid <= '" & RepSLSsp & "'"
        End If

        sql = A1

        Adpt = New NpgsqlDataAdapter(sql, Conn)

        Dim RS As New DataTable

        Adpt.Fill(RS)
            Dim ds As New DataSet("DataSetOne")
            ds.Tables.Add(RS)
            DataGridView1.DataSource = RS
            Conn.Close()
    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        DataGridView1.Columns.Clear()
        Dim oForm As Menu
        oForm = New Menu()
        oForm.Show()

        Hide()
    End Sub
End Class