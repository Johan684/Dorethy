Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Interaction
Imports System.Drawing.Printing
Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports System.Runtime.InteropServices
Imports System.Globalization
Imports Npgsql


Public Class Sales

    Private Const V11 As String = "Select * from customer, cmb"
    'Private Const V As String = ""
    Dim V12 As String
    Dim Pprice, Tprice, TSTR, FWS, W2P As Single
    Dim LOT As Integer
    Dim CID, CLOC, CACT, FChar, Adis, PAY, PREVA As String
    Dim CNAM, CADD, CPOSTAL, CCIT, CNFC, DAT2Day, BNR, CURRA As String


    Private Sub BtnReturn_Click() Handles BtnReturn.Click
        DataGridView1.Columns.Clear()
        Dim oForm As Menu
        oForm = New Menu()
        oForm.Show()

        Hide()
    End Sub

    ReadOnly time As DateTime = DateTime.Now
    ReadOnly format As String = "M/d/yy HH:mm"
    ReadOnly format2 As String = "yMdHHmm"


    Private Sub PayNow_Click(sender As Object, e As EventArgs) Handles PayNow.Click
        Dim Conn As NpgsqlConnection
        Dim Adpt As NpgsqlDataAdapter
        Dim cmd As NpgsqlCommand
        Dim LA, TTLBill As Single

        Conn = New NpgsqlConnection With {
                .ConnectionString = IniStart.DBstr
            }

        If PAY = "other" Then
            SalesSlip.Text = SalesSlip.Text & Chr(13) & "THE TOTAL AMOUNT OF THIS BILL IS:  " & TTLsls.Text
            SalesSlip.Text = SalesSlip.Text & Chr(13) & Chr(13) & "OTHER PAYMENT METHOD SELECTED"
            W2P = 1
        End If
        If PAY = "Dorethy Card" Then
            SalesSlip.Text = SalesSlip.Text & Chr(13) & "THE TOTAL AMOUNT OF THIS BILL IS:  " & TTLsls.Text
            LA = TSTR + CURRA
            SalesSlip.Text = SalesSlip.Text & Chr(13) & Chr(13) & "PAYED WITH DORETHY CARD. YOUR AVAILABLE SALDO IS: " & LA.ToString("€ #,###.00")
            W2P = 2
        End If
        SalesSlip.SaveFile(IniStart.SAsl & "\" & BNR & ".rtf")

        Conn.Open()

        Dim sql As String = V11
        Dim SID As String = BNR
        Dim Card As String = CNFC

        Adpt = New NpgsqlDataAdapter(sql, Conn)
        If W2P = 1 And TTLBill < 0 Then
            LA = TTLBill
            CURRA = TTLBill
        End If
        sql = ("INSERT INTO Public.payments (salesid, prevamount, waytopay, nfc, amounttopay, amount) VALUES (" & Chr(39) & SID & Chr(39) & "::integer, " & Chr(39) & CURRA & Chr(39) & "::money, " & Chr(39) & W2P & Chr(39) &
          "::integer, " & Chr(39) & Card & Chr(39) & "::text, " & Chr(39) & TTLBill & Chr(39) & "::money, " & Chr(39) & LA & Chr(39) & "::money)")

        cmd = New NpgsqlCommand(sql, Conn)
        cmd.ExecuteNonQuery()

        Conn.Close()
        BtnReturn.PerformClick()
    End Sub


    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SCNPR.Visible = False
        ISCBpr.Visible = False
        AMT.Visible = False
        IMOU.Visible = False
        BtnNext.Visible = False
        CAC.Visible = False
        CA.Visible = False
        SalesSlip.Text = ""
        DataGridView1.Enabled = False
    End Sub
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Dim Conn As NpgsqlConnection
        Dim Adpt As NpgsqlDataAdapter

        'Dim cmd As NpgsqlCommand

        Dim npgsqlConnection As New NpgsqlConnection
        Conn = npgsqlConnection
        Conn.ConnectionString = IniStart.DBstr
        Conn.Open()

        Dim sql As String = "Select * from products where products.ean = '" & ISCBpr.Text & "'"

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
            ResetInput()
        End Try

        Conn.Close()
        GaDoor()
        If DataGridView1.Rows(0).Cells(1).Value = "" Then
            MsgBox("Can't find EAN, please retry",, "Dorethy message")

        End If
    End Sub
    Private Sub GaDoor()
        If ISCBpr.Text <> "" And IMOU.Text <> "" Then
            Dim Conn As NpgsqlConnection
            Dim Adpt As NpgsqlDataAdapter
            Dim cmd As NpgsqlCommand

            Conn = New NpgsqlConnection With {
                .ConnectionString = IniStart.DBstr
            }
            Conn.Open()

            Dim sql As String = V11
            Dim Amt As Integer = Convert.ToInt32(IMOU.Text)
            Dim SID As Integer = Convert.ToInt32(BNR)
            Dim iCID As Integer = Convert.ToInt32(CID)


            Adpt = New NpgsqlDataAdapter(sql, Conn)
            Pprice = Val(DataGridView1.Rows(0).Cells(4).Value)
            If ISCBpr.Text = "D010" Then
                ' Dim Cpp As Integer = Convert.ToDouble(TTLsls.Text)
                Dim Cpp = TTLsls.Text
                Pprice = Cpp
            End If

            Adis = DataGridView1.Rows(0).Cells(2).Value
            Tprice = Amt * Pprice
            TSTR += Tprice
            TTLsls.Text = TSTR

            sql = ("INSERT INTO public.sales (ean, custid, amount, salesid) VALUES (" & Chr(39) & ISCBpr.Text & Chr(39) & "::text, " & Chr(39) & iCID & Chr(39) & "::integer, " & Chr(39) & Amt & Chr(39) & "::integer, " & Chr(39) & SID & Chr(39) & "::integer)")

            cmd = New NpgsqlCommand(Sql, Conn)
            cmd.ExecuteNonQuery()

            Conn.Close()
            V12 = ""

            SalesSlipAdd()
        End If
        ResetInput()

    End Sub

    Private Sub ResetInput()
        ISCBpr.Text = ""
        IMOU.Text = ""
        ISCBpr.Focus()
    End Sub



    Private Sub PWDCN_Click() Handles PWDCN.Click
        PWDCY.Visible = False
        CAC.Visible = False
        CA.Visible = False
        ScanFields()
        PAY = "other"
    End Sub

    Private Sub PWDCY_Click(sender As Object, e As EventArgs) Handles PWDCY.Click
        Dim Conn As NpgsqlConnection
        Dim Adpt As NpgsqlDataAdapter

        'Dim cmd As NpgsqlCommand

        Dim npgsqlConnection As New NpgsqlConnection
        Conn = npgsqlConnection
        Conn.ConnectionString = IniStart.DBstr
        Conn.Open()

        Dim sql As String = "Select * from payments where payments.nfc = '" & CNFC & "' order by id desc"

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
        CAC.Visible = True
        CA.Visible = True
        PWDCN.Visible = False
        ScanFields()
        PREVA = DataGridView1.Rows(0).Cells(2).Value
        CURRA = DataGridView1.Rows(0).Cells(6).Value
        CA.Text = CURRA
        PAY = "Dorethy Card"
    End Sub
    Private Sub ScanFields()
        SCNPR.Visible = True
        ISCBpr.Visible = True
        AMT.Visible = True
        IMOU.Visible = True
        BtnNext.Visible = True

    End Sub



    Private Sub SalesSlipAdd() Handles MyBase.Load
        LOT = Microsoft.VisualBasic.Len(IMOU.Text)
        FWS = 6 - LOT
        AW32()
        SalesSlip.Text = SalesSlip.Text & FChar & IMOU.Text & Chr(32)
        LOT = Microsoft.VisualBasic.Len(ISCBpr.Text)
        FWS = 14 - LOT
        AW32()
        SalesSlip.Text = SalesSlip.Text & ISCBpr.Text & FChar & Chr(32)
        LOT = Microsoft.VisualBasic.Len(Adis)
        FWS = 40 - LOT
        AW32()
        SalesSlip.Text = SalesSlip.Text & Adis & FChar
        LOT = Microsoft.VisualBasic.Len(Pprice)
        FWS = 8 - LOT
        AW32()
        SalesSlip.Text = SalesSlip.Text & FChar & Pprice.ToString("€ #,###.00")
        LOT = Microsoft.VisualBasic.Len(Tprice)
        FWS = 12 - LOT
        AW32()
        SalesSlip.Text = SalesSlip.Text & FChar & Tprice.ToString("€ #,###.00") & Chr(13)
    End Sub
    Private Sub AW32()
        FChar = ""
        For i = 1 To FWS
            FChar += Chr(32)
        Next
    End Sub
    Private Sub S4LOC_Click(sender As Object, e As EventArgs) Handles S4LOC.Click
        Dim Conn As NpgsqlConnection
        Dim Adpt As NpgsqlDataAdapter

        'Dim cmd As NpgsqlCommand

        Dim npgsqlConnection As New NpgsqlConnection
        Conn = npgsqlConnection
        Conn.ConnectionString = IniStart.DBstr
        Conn.Open()

        Dim sql As String = "Select * from customer where customer.clocation = '" & Val(S4CL.Text) & "'"

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
            MsgBox("this location is not registred",, "Dorethy message")
        ElseIf DataGridView1.Rows(0).Cells(1).Value <> "" Then
            CID = DataGridView1.Rows(0).Cells(0).Value
            CNAM = DataGridView1.Rows(0).Cells(1).Value
            CADD = DataGridView1.Rows(0).Cells(2).Value
            CPOSTAL = DataGridView1.Rows(0).Cells(3).Value
            CCIT = DataGridView1.Rows(0).Cells(4).Value
            CNFC = DataGridView1.Rows(0).Cells(6).Value
            CLOC = DataGridView1.Rows(0).Cells(7).Value
            CACT = DataGridView1.Rows(0).Cells(8).Value
            DAT2Day = time.ToString(format)
            BNR = time.ToString(format2)
            SalesSlip.Text = "Dorethy camping" & Chr(13) & "Mountain View 7001" & Chr(13) & "123456 RelayCity" & Chr(13) & Chr(13) & "Date: " & DAT2Day & Chr(13) & Chr(13) &
                "Salesnr: " & BNR & Chr(13) & Chr(13) & CNAM & Chr(13) & CADD & Chr(13) & CPOSTAL & "  " & CCIT & Chr(13) & Chr(13)
            SalesSlip.Text = SalesSlip.Text & "Amount EAN            Discription                                 Price             Total" & Chr(13)
            S4LOC.Enabled = False
            S4CL.Enabled = False
            CAMPLOC.Enabled = False
        End If

        If CACT <> 1 Then
            MsgBox("This location is not occupied. Sales is impossible!!",, "Dorethy WARNING!!")
            BtnReturn.PerformClick()
            GoTo EndCorrect
        End If

        If Len(CNFC) < 3 Then
            PWDCN.PerformClick()
        End If

EndCorrect:
    End Sub

End Class