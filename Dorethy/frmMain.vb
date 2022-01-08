Imports PCSC
Imports PCSC.Iso7816
Imports PCSC.Monitoring
Imports System.Threading


<DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
Public Class FrmMain
    Private Shared ReadOnly _contextFactory As IContextFactory = ContextFactory.Instance
    Private _hContext As ISCardContext
    Dim readerName As String
    Dim readingMode As String
    Dim VoTis As String
    Dim isstart As Boolean = False

    Function LoadReaderList()
        Dim readerList As String()
        Try
            cbxReaderList.DataSource = Nothing

            _hContext = _contextFactory.Establish(SCardScope.System)
            readerList = _hContext.GetReaders()
            _hContext.Release()

            If readerList.Length > 0 Then
                cbxReaderList.DataSource = readerList
            Else
                MessageBox.Show("No card reader detected!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Return True
        Catch ex As Exceptions.PCSCException
            MessageBox.Show("Error: getReaderList() : " & ex.Message & " (" & ex.SCardError.ToString() & ")")
            Return False
        End Try

    End Function

    Dim monitor

    Private Sub StartMonitor()
        Dim monitorFactory As MonitorFactory = MonitorFactory.Instance
        monitor = monitorFactory.Create(SCardScope.System)
        AttachToAllEvents(monitor)
        monitor.Start(cbxReaderList.Text)

        readerName = cbxReaderList.Text
        readingMode = txtReadingMode.Text

    End Sub

    Private Sub AttachToAllEvents(monitor As ISCardMonitor)
        AddHandler monitor.CardInserted, AddressOf CardInit
    End Sub

    Sub CardInit(eventName As SCardMonitor, unknown As CardStatusEventArgs)
        If readingMode = 1 OrElse readingMode = 2 Then
            SendUID4Byte()
        ElseIf readingMode = 3 OrElse readingMode = 4 Then
            SendUID7Byte()
        End If
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReaderList()

    End Sub

    Private Sub BtnRefreshReader_Click(sender As Object, e As EventArgs) Handles btnRefreshReader.Click
        LoadReaderList()
    End Sub

    Private Sub BtnStartMonitor_Click(sender As Object, e As EventArgs) Handles btnStartMonitor.Click

        If txtReadingMode.Text <> 1 AndAlso txtReadingMode.Text <> 2 AndAlso txtReadingMode.Text <> 3 AndAlso txtReadingMode.Text <> 4 Then
            MessageBox.Show("Error: Reading mode not macth the preset.")
        Else
            If isstart = True Then
                monitor.Cancel()
            End If
            StartMonitor()
            isstart = True
            TxtInputspace.Text = ""
            TxtInputspace.Focus()
        End If

    End Sub

    Private Sub BtnStopMonitor_Click(sender As Object, e As EventArgs) Handles btnStopMonitor.Click
        If isstart = True Then
            monitor.Cancel()
            DRT_Login.GetFromRFID = TxtInputspace.Text
            DRT_Login.ReturnCodeRFID = "ok"
        ElseIf TxtInputspace.Text <> "" Then
            DRT_Login.GetFromRFID = TxtInputspace.Text
            DRT_Login.ReturnCodeRFID = "ok"
        End If
        TxtInputspace.Text = ""
        If DRT_Login.GetFromRFID = "" Then
            DRT_Login.ReturnCodeRFID = "canceled"
        End If

        If DRT_Login.ReturnTo = "1" Then
            DRT_Login.ActiveForm.Activate()
            DRT_Login.Show()
        End If
        If DRT_Login.ReturnTo = "2" Then
            AddNewUser.ActiveForm.Activate()
            AddNewUser.Show()
        End If
        If DRT_Login.ReturnTo = "3" Then
            Customer.ActiveForm.Activate()
            Customer.Show()
        End If
        Me.Close()

    End Sub

    Function SendUID4Byte()
        Try
            Using context = _contextFactory.Establish(SCardScope.System)
                Using rfidReader = context.ConnectReader(readerName, SCardShareMode.Shared, SCardProtocol.Any)
                    Using rfidReader.Transaction(SCardReaderDisposition.Leave)

                        Dim apdu As Byte() = {&HFF, &HCA, &H0, &H0, &H4}
                        Dim sendPci = SCardPCI.GetPci(rfidReader.Protocol)
                        Dim receivePci = New SCardPCI()

                        Dim receiveBuffer = New Byte(255) {}
                        Dim command = apdu.ToArray()
                        Dim bytesReceived = rfidReader.Transmit(sendPci, command, command.Length, receivePci, receiveBuffer, receiveBuffer.Length)
                        Dim responseApdu = New ResponseApdu(receiveBuffer, bytesReceived, IsoCase.Case2Short, rfidReader.Protocol)

                        If readingMode = 1 Then
                            Dim uid As String = BitConverter.ToString(responseApdu.GetData())
                            uid = uid.Replace("-", "")

                            SendKeys.SendWait(uid + "{ENTER}")
                        ElseIf readingMode = 2 Then
                            Dim uid As Byte() = New Byte(3) {}
                            Dim revuid As Byte() = New Byte(3) {}
                            Array.Copy(responseApdu.GetData(), uid, 4)
                            Array.Copy(uid, revuid, 4)
                            Array.Reverse(revuid, 0, 4)

                            Dim uid2 As String = BitConverter.ToString(revuid)
                            uid2 = uid2.Replace("-", "")

                            SendKeys.SendWait(uid2 + "{ENTER}")
                        End If
                    End Using
                End Using
            End Using
        Catch
            'Error Handling should be developed
        End Try

        Return True
    End Function

    Function SendUID7Byte()
        Try
            Using context = _contextFactory.Establish(SCardScope.System)
                Using rfidReader = context.ConnectReader(readerName, SCardShareMode.Shared, SCardProtocol.Any)
                    Using rfidReader.Transaction(SCardReaderDisposition.Leave)

                        Dim apdu As Byte() = {&HFF, &HCA, &H0, &H0, &H7}
                        Dim sendPci = SCardPCI.GetPci(rfidReader.Protocol)
                        Dim receivePci = New SCardPCI()

                        Dim receiveBuffer = New Byte(255) {}
                        Dim command = apdu.ToArray()
                        Dim bytesReceived = rfidReader.Transmit(sendPci, command, command.Length, receivePci, receiveBuffer, receiveBuffer.Length)
                        Dim responseApdu = New ResponseApdu(receiveBuffer, bytesReceived, IsoCase.Case2Short, rfidReader.Protocol)

                        If readingMode = 3 Then
                            Dim uid As String = BitConverter.ToString(responseApdu.GetData())
                            uid = uid.Replace("-", "")

                            SendKeys.SendWait(uid + "{ENTER}")
                        ElseIf readingMode = 4 Then
                            Dim uid As Byte() = New Byte(6) {}
                            Dim revuid As Byte() = New Byte(6) {}
                            Array.Copy(responseApdu.GetData(), uid, 7)
                            Array.Copy(uid, revuid, 7)
                            Array.Reverse(revuid, 0, 7)

                            Dim uid2 As String = BitConverter.ToString(revuid)
                            uid2 = uid2.Replace("-", "")

                            SendKeys.SendWait(uid2 + "{ENTER}")
                        End If
                    End Using
                End Using
            End Using
        Catch
            'Error Handling should be developed
        End Try

        Return True
    End Function

    Private Function GetDebuggerDisplay() As String
        Return ToString()
    End Function


End Class