Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Interaction
Imports System.Drawing.Printing
Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports System.Runtime.InteropServices
Imports Npgsql


Public Class CheckOut
    Private Const V11 As String = "Select * from customer, cmb"
    Dim TSTR, W2P As Single
    Dim CID, CLOC, CACT, PAY, PREVA As String

    Private Sub CPO_Click(sender As Object, e As EventArgs) Handles CPO.Click
        Dim Conn As NpgsqlConnection
        Dim Adpt As NpgsqlDataAdapter
        Dim cmd As NpgsqlCommand
        Dim LA, TTLBill As Single

        Conn = New NpgsqlConnection With {
                .ConnectionString = IniStart.DBstr
            }

        If PAY = "other" Then
            W2P = 1
        End If
        If PAY = "Dorethy Card" Then
            SalesSlip.Text = SalesSlip.Text & Chr(13) & "Your Dorethy card has a value of:  " & TTLsls.Text
            LA = TSTR + CURRA
            SalesSlip.Text = SalesSlip.Text & Chr(13) & Chr(13) & "If your card has a negative value, you'll be payed by us. Every positive value is a debt to us: " & LA.ToString("€ #,###.00")
            If LA <= 0 Then
                SalesSlip.Text = SalesSlip.Text & Chr(13) & Chr(13) & "We refund you: " & LA.ToString("€ #,###.00")
            Else SalesSlip.Text = SalesSlip.Text & Chr(13) & Chr(13) & "You pay us: " & LA.ToString("€ #,###.00")
                LA -= LA
            End If
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

        CNFC = ""
        CACT = 0
        CLOC = 0

        sql = "update public.customer set nfc = " & Chr(39) & CNFC & Chr(39) & ", active = " & Chr(39) & CACT & Chr(39) & ", clocation = " & Chr(39) & CLOC & Chr(39) & " where id=" & Chr(39) & CID & Chr(39) & " "

        cmd = New NpgsqlCommand(sql, Conn)
        cmd.ExecuteNonQuery()

        Conn.Close()
        BtnReturn.PerformClick()
    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        DataGridView1.Columns.Clear()
        Dim oForm As Menu
        oForm = New Menu()
        oForm.Show()

        Hide()
    End Sub

    Dim CNAM, CADD, CPOSTAL, CCIT, CNFC, DAT2Day, BNR, CURRA As String
    Private Sub CheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Enabled = False
    End Sub

    ReadOnly time As DateTime = DateTime.Now
    ReadOnly format As String = "M/d/yy HH:mm"
    ReadOnly format2 As String = "yMdHHmm"

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
            DAT2Day = time.ToString(Format)
            BNR = time.ToString(format2)
            SalesSlip.Text = "Dorethy camping" & Chr(13) & "Mountain View 7001" & Chr(13) & "123456 RelayCity" & Chr(13) & Chr(13) & "Date: " & DAT2Day & Chr(13) & Chr(13) &
                "Salesnr: " & BNR & Chr(13) & Chr(13) & CNAM & Chr(13) & CADD & Chr(13) & CPOSTAL & "  " & CCIT & Chr(13) & Chr(13)
            SalesSlip.Text = SalesSlip.Text & "CHECKOUT" & Chr(13)
            If Len(CNFC) < 3 Then
                SalesSlip.Text = SalesSlip.Text & "No Dorethy card used" & Chr(13) & Chr(13) & "On behalf of the Dorethy team, THANK YOU for visiting us!" & Chr(13) & Chr(13) & "Have a save trip home!"
                'Hier nog toevoegen Bewaren afschrift, opslaan en de juiste waarden op 0 zetten.
                PAY = "other"
                GoTo EndCheckout
            End If

            S4LOC.Enabled = False
            S4CL.Enabled = False
            CAMPLOC.Enabled = False
            GetValueCard()
EndCheckout:
        End If
    End Sub

    Private Sub GetValueCard()
        Dim Conn As NpgsqlConnection
        Dim Adpt As NpgsqlDataAdapter
        Dim SaldoP As Single
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
        PREVA = DataGridView1.Rows(0).Cells(2).Value
        CURRA = DataGridView1.Rows(0).Cells(6).Value
        CA.Text = CURRA
        PAY = "Dorethy Card"
        SaldoP = (Val(CURRA) - Val(CURRA)) - Val(CURRA)
        'Saldo = (CA.Text - CA.Text) + CA.Text
        If SaldoP > 0 Then IN_pay.Text = "You owe the customer: " & SaldoP.ToString("€ #,###.00")
        If SaldoP <= 0 Then IN_pay.Text = "The customer has to pay: " & SaldoP.ToString("€ #,###.00")
    End Sub
End Class