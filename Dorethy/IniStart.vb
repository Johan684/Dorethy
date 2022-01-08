Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Interaction
Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports Npgsql

Public Class IniStart
    ReadOnly path As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

    Public Shared Property DBstr As String
    Public Shared Property AUpw As String
    Public Shared Property SAsl As String


    Private Sub IniStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EnterLocation()

    End Sub

    Private Sub EnterLocation()

        My.Computer.FileSystem.CreateDirectory(path & "\Dor")
            My.Computer.FileSystem.CreateDirectory(path & "\Dor\salesslips")
            BtnWRT.Visible = False


    End Sub

    Private Sub BtnCHK_Click(sender As Object, e As EventArgs) Handles BtnCHK.Click
        GLDBstr.Text = "Host=" & IPHN.Text & ";Username=" & IPUN.Text & ";Password=" & Chr(34) & IPPW.Text & Chr(34) & ";Database=" & IPDB.Text
        BtnWRT.Visible = True
    End Sub

    Private Sub BtnWRT_Click(sender As Object, e As EventArgs) Handles BtnWRT.Click
        Dim file As System.IO.StreamWriter
        Try
            DBstr = GLDBstr.Text
            AUpw = IPPWAU.Text
            SAsl = path & "\Dor\salesslips"
            file = My.Computer.FileSystem.OpenTextFileWriter(path & "\Dor\dps.ini", True)
            file.WriteLine(DBstr)
            file.WriteLine(AUpw)
            file.WriteLine(SAsl)
            file.Close()
            MsgBox("Dorethy will be closed. Restart for loading your settings!")
            End
        Catch ex As Exception
            MsgBox("Failed to write ini file.")
        End Try
    End Sub

End Class