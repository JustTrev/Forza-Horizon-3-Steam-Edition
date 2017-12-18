Option Explicit On

Imports System.Threading
Imports System.Diagnostics
Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Environment
Imports Forza_Horizon_3_Steam_Edition.vAccountInfo
Imports Forza_Horizon_3_Steam_Edition.SteamOverlay
Imports Forza_Horizon_3_Steam_Edition.vbRegisterUsers
Imports Forza_Horizon_3_Steam_Edition.ColorPallet


Public Class frmCommunityHub

    Public Shared inputChat  '//This is value last message recieved.
    Public Shared outputChat '//This is value last message sent.




    Private Sub frmCommunityHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim bColorR = RegKey.GetValue(Of Integer)(RegKey.mBackColorR)
        Dim bColorG = RegKey.GetValue(Of Integer)(RegKey.mBackColorG)
        Dim bColorB = RegKey.GetValue(Of Integer)(RegKey.mBackColorB)

        Dim tBColorR = RegKey.GetValue(Of Integer)(RegKey.tBackColorR)
        Dim tBColorG = RegKey.GetValue(Of Integer)(RegKey.tBackColorG)
        Dim tBColorB = RegKey.GetValue(Of Integer)(RegKey.tBackColorB)

        Dim tFColorR = RegKey.GetValue(Of Integer)(RegKey.tForeColorR)
        Dim tFColorG = RegKey.GetValue(Of Integer)(RegKey.tForeColorG)
        Dim tFColorB = RegKey.GetValue(Of Integer)(RegKey.tForeColorB)


        Call backgroundColor(bColorR, bColorG, bColorB)
        Call fTextColor(tFColorR, tFColorG, tFColorB)
        'Call backgroundColor(bColorR, bColorG, bColorB)

        Call Connect()

        TextField.Focus()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        '  Call CloseTCPConnection()
        'Close()
        ' Hide()

        Me.WindowState = FormWindowState.Minimized

        'Me.Visible = False
    End Sub

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    'Declare the variables
    Dim dragD As Boolean
    Dim mousexD As Integer
    Dim mouseyD As Integer

    Private Sub pHeadForm_MouseDown(sender As Object, e As MouseEventArgs) Handles pHeadForm.MouseDown
        dragD = True 'Sets the variable drag to true.
        mousexD = Cursor.Position.X - Me.Left 'Sets variable mousex
        mouseyD = Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub pHeadForm_MouseMove(sender As Object, e As MouseEventArgs) Handles pHeadForm.MouseMove
        If dragD Then
            Me.Top = Cursor.Position.Y - mouseyD
            Me.Left = Cursor.Position.X - mousexD
        End If
    End Sub

    Private Sub pHeadForm_MouseUp(sender As Object, e As MouseEventArgs) Handles pHeadForm.MouseUp
        dragD = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    '//Server Account Decryption
    Function HexToString(ByVal hex As String) As String
        Dim text As New System.Text.StringBuilder(hex.Length \ 2)
        For i As Integer = 0 To hex.Length - 2 Step 2
            text.Append(Chr(Convert.ToByte(hex.Substring(i, 2), 16)))
        Next
        Return text.ToString
    End Function


    '=====================================================================
    ' Chat Communications start here..
    ' We need to create a server to connect too and talk to users locally.
    '=====================================================================
    Dim client As TcpClient
    Dim sWriter As StreamWriter

    Delegate Sub _xUpdate(ByVal str As String)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        'Send public message
        'outputChat = TextField.Text & " 9!!!!!1"

        If TextField.Text = Nothing Then
        Else
            Call serverWhatDoIDO(NickFreFix & ": " & TextField.Text, " 9!!!!!1")
            ' Chat.AppendText(TextField.Text & vbNewLine)
            ' send(NickFreFix & ": " & TextField.Text)
            lastSentMSG = TextField.Text
            TextField.Clear()

        End If

    End Sub
    Dim lastSentMSG As String = ""

    Private Sub TextField_KeyDown(sender As Object, e As KeyEventArgs) Handles TextField.KeyDown
        If e.KeyCode = Keys.Enter Then

            '  outputChat = TextField.Text & " 9!!!!!1"

            If TextField.Text = Nothing Then
            Else
                Call serverWhatDoIDO(NickFreFix & ": " & TextField.Text, " 9!!!!!1")
                ' Chat.AppendText(TextField.Text & vbNewLine)
                ' send(NickFreFix & ": " & TextField.Text)
                lastSentMSG = TextField.Text
                TextField.Clear()

            End If
        End If
        If e.KeyCode = Keys.Up Then
            TextField.Text = lastSentMSG
        End If
    End Sub

    Dim grabUsrMsg

    '/// WRITE OUR CONTROL GATE \\\

    Public Sub readChat(ByVal s As String)

        '//Capture any parameters before retrieving information to the main chat window. 

        '//1 series numbers are Data feeds.
        If s.Contains(" 1!!!!0") Then
            '// Remove from online session players list. "History".
            ' Dim phrase As String = s
            ' phrase = Replace(s, " 1!!!!5", "")
            ' usersList.Remove(phrase)
        End If
        If s.Contains(" 1!!!!5") Then
            '//Add to recent players history, and session list.
            ' Dim phrase As String = s
            ' phrase = Replace(s, " 1!!!!5", "")
            ' usersList.Add(phrase)
        End If

        '//4 Series numbers are social events data.  Track users, record user history, display activity, show status, etc..
        If s.Contains(" 4!!!!0") Then
            '//Add to recent players history, and session list.
            Dim phrase As String = s
            phrase = Replace(s, " 4!!!!0", "")

            usersList.Items.Add(phrase)

            'usersList.Items.Add(phrase)
            ' usersList.Columns.Add(phrase)
            ' frmRecentPlayers.lstRecentPlayers.Items.Add()
            'usersList.

        End If







        '//9 series numbers are Chat commands.
        If s.Contains(" 9!!!!!1") Then
            Dim phrase As String = s
            phrase = Replace(s, " 9!!!!!1", "")
            Chat.AppendText(vbNewLine & phrase)

            If phrase.Contains("@all ") Then
                Dim phraseS As String = s
                Dim userID = phraseS.Substring(0, phrase.IndexOf(":")).Trim()

                '// Send notice if CN is minimized.
                If phraseS.Contains(userID.ToString) = True Then
                    Dim f = phraseS.Replace(userID.ToString & ": ", "")  '// This will remove the recieved username to just capture the msg.  
                    SteamOverlay.sendNoticeAll(userID, f)
                    My.Computer.Audio.Play(My.Resources.Global_Keyboard_Stroke_2, AudioPlayMode.WaitToComplete)

                    Dim lengthofGarbage As Integer = lastLine.Length

                    Dim startText As Integer = 0
                    Dim endText As Integer

                    endText = Chat.Text.LastIndexOf(lastLine)

                    'Chat.SelectAll()
                    Chat.SelectionBackColor = Color.FromArgb(64, 64, 64)
                    Chat.SelectionColor = Color.Goldenrod
                    While startText < endText

                        Chat.Find("@everyone", startText, Chat.TextLength, RichTextBoxFinds.MatchCase)

                        Chat.SelectionBackColor = Color.FromArgb(43, 43, 43)
                        Chat.SelectionColor = Color.FromArgb(180, 43, 55)  'Highlighhted Font when used in this case.

                        startText = Chat.Text.IndexOf("@everyone", startText) + 1

                        '//  Tool eclips of the heart

                    End While
                End If
            End If

        End If



    End Sub

    Public Sub serverWhatDoIDO(ByVal s As String, code As String)
        '//Capture any parameters before sending information to the main chat window.

        send(s & code) '//Pass data through this tunnel.

    End Sub

    Sub xUpdate(ByVal str As String) '// Class that retrives updates from the server.

        If InvokeRequired Then
            Try
                Invoke(New _xUpdate(AddressOf xUpdate), str)
            Catch ex As Exception
                'It is possible for it to error on form close while signed in.  
                'Though when closing the window you are already disconnected from the session.
            End Try
        Else
            Try
                '//Send all data information to the read sub class.
                inputChat = str
                Call readChat(inputChat)
            Catch ex As Exception
                'It is possible for it to error on form close while signed in.  
                'Though when closing the window you are already disconnected from the session.
            End Try
        End If

    End Sub

    ' Dim signout As Boolean = False

    Sub read(ByVal ar As IAsyncResult)
        On Error GoTo ErrorHandler

        'Try
        xUpdate(New StreamReader(client.GetStream).ReadLine)
        client.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf read, Nothing)

        ' Catch ex As Exception
        Exit Sub
ErrorHandler:
        xUpdate("Connection lost.")
        Helper.Log("Connection lost.. Unable to reach the server.")
        ' Dim ans As DialogResult
        ' ans = MessageBox.Show("Connection to the datacenter could not be established." & vbNewLine & "Would you like to try again?" & vbNewLine & "ERROR : " & Err.Number, "Unable to contact server.", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        ' If ans = DialogResult.No Then
        '     Application.Exit()
        ' End If
        Resume Next
    End Sub

    Public Sub send(ByVal str As String)
        On Error GoTo ErrorHandler

        sWriter = New StreamWriter(client.GetStream)
        sWriter.WriteLine(str)
        sWriter.Flush()
        'Catch ex As Exception
        ' Call timerstart()
        Exit Sub
ErrorHandler:
        xUpdate("Retrying connection...")
        Call Connect()

        Resume Next

    End Sub


    Sub Connect()
        'StartConnection: 'This begins the connection.
        Try

            client = New TcpClient("47.196.219.55", CInt(63500))
            '127.0.0.1 Is the local host. 64090 is the default port. Machine Name will also work over the local area network. 
            'Replace IP with Private IP address on the network. Open port through the firewall And place the public IP of the server to allow internet connectivity.
            client.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf read), Nothing)


            'Extra Flare
            ' If backupServer = False Then
            '     lblServerStatus.Text = "Online"
            ' Else
            '     lblServerStatus.Text = "Online"
            ' End If
            ' lblServerStatus.ForeColor = Color.White
            ' lblServerStatus.BackColor = Color.Green
            ' 'Server Status
            ' ServerAvailable = True
            ' Visible = False
            ' If NickFreFix.Length <= 20 Then
            '     Dim aL As Integer = 20 - NickFreFix.Length
            ' Debug.WriteLine(StringToHex("sim0n"))
            'MsgBox()

            send(StringToHex(NickFreFix) & " 4!!!!0") '//Send server notice to authenticate.
            ' End If

            Helper.Log("Connected.")

        Catch ex As Exception
            ' lblServerStatus.Text = "Unreachable"
            ' lblServerStatus.ForeColor = Color.Gold
            ' lblServerStatus.BackColor = Color.Red
            '
            ' ServerAvailable = False
            ' 'CloseTCPConnection()
            ' btnSignin.Text = "Sign In"
            ' xUpdate("Failed to connect to server. Please check your connection.")
            Helper.Log("Failed to connect to server. Please check your connection and try again.")  '//  Thit ith a commenth.........


        End Try

    End Sub

    Function StringToHex(ByVal text As String) As String
        Dim hexa As String
        For i As Integer = 0 To text.Length - 1
            hexa &= Asc(text.Substring(i, 1)).ToString("x").ToUpper
        Next
        Return hexa
    End Function

    Sub CloseTCPConnection()
        Try
            Thread.Sleep(100)
            ' If NickFreFix.Length <= 20 Then
            '     Dim aL As Integer = 20 - NickFreFix.Length
            '     send("DISC" & NickFreFix) '//User Identification.
            ' End If
            send(StringToHex(NickFreFix) & " 4!!!!1") '//User Identification.

            Thread.Sleep(300)
            client.Client.Close()
            client = Nothing
            Close()
        Catch ex As Exception
            'We don't want to show any possible errors when we disconnect without even connecting to the chat server.
        End Try

    End Sub

    Dim lastLine As String

    Private Sub Chat_TextChanged(sender As Object, e As EventArgs) Handles Chat.TextChanged
        lastLine = Chat.Lines(Chat.Lines.Length - 1)

        If (lastLine = String.Empty) Then
            lastLine = Chat.Lines(Chat.Lines.Length - 2)
        End If

        Chat.SelectionStart = Chat.Text.Length
        ' scroll it automatically
        Chat.ScrollToCaret()
    End Sub
    Dim delayCount = 0
    Private grabeUsrID As String

    Private Sub sendDelay_Tick(sender As Object, e As EventArgs) Handles sendDelay.Tick
        ' delayCount += 1
        '
        ' If delayCount = 1 Then
        '     sendDelay.Stop()
        '     TextField.ReadOnly = False
        '     TextField.Focus()
        '     delayCount = 0
        ' End If
    End Sub

    Private Sub frmCommunityHub_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub


    '//Call to users using @ThierNickName




End Class