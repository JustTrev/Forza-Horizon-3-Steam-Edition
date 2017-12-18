Option Explicit On

Imports System.Threading
Imports System.Diagnostics
Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Environment
Imports Forza_Horizon_3_Steam_Edition.vAccountInfo
Imports Forza_Horizon_3_Steam_Edition.AudioController
Public Class SteamOverlay


    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Keys) As Integer

    Public Shared gameEXE As String = "forza_x64_release_final" ' Forza Horizon 3

    Dim startCount As Integer = 0
    Dim oOpen As Boolean = False


    Private Sub SteamOverlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load





        ShowInTaskbar = False




        Call StartAmbient()

        Try
            If RegKey.GetValue(Of String)(RegKey.Firsttimerun) = "0" Then
                '// Open the Community Hub on launch. .. This will automatically connect to the server.
                Dim AC As New frmAccountSettings()
                AC.TopLevel = False
                AC.StartPosition = FormStartPosition.CenterScreen
                Me.pMainPanel.Controls.Add(AC)
                AC.Show()
                RegKey.SetValue(Of String)(RegKey.Firsttimerun, "1")
            End If

            'start our ticks
            shiftTabListener.Start()
            gameRunningTimer.Start()

            '// Open the Community Hub on launch. .. This will automatically connect to the server.
            Dim CHUB As New frmCommunityHub()
            CHUB.TopLevel = False
            CHUB.StartPosition = FormStartPosition.CenterScreen
            Me.pMainPanel.Controls.Add(CHUB)
            CHUB.Show()


        Catch ex As Exception
            Helper.Log(ex.StackTrace)

            NotifyIcon1.Visible = True
            'NotifyIcon1.Icon = My.Resources
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Error
            NotifyIcon1.BalloonTipTitle = "Forza Horizon 3 Steam Launcher"
            NotifyIcon1.BalloonTipText = ex.Message
            NotifyIcon1.ShowBalloonTip(6000)
            Label1.Text = ex.Message
            'Me.Hide()
            ShowInTaskbar = False
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Timer1.Stop()
            Close()
        End Try
    End Sub

    Dim t As Integer = 0
    Dim number As Integer

    Dim intSound As Integer = 0
    Dim snd As New AudioController

    Private Sub clock_Tick(sender As Object, e As EventArgs) Handles clock.Tick
        GameTitle.Text = "Forza Horizon 3"
        DateStamp.Text = DateTime.Now.ToString

        '//Update random audio events.

        intSound += 1
        If t = 5 Then
            t = 0

            Randomize()
            ' The program will generate a number from 0 to 50
            number = Int(Rnd() * 33) + 1

            With snd
                .Name = "AudioController" & intSound
                .Play(number, False)






            End With
            '  Call RndSteamSounds(number)

        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkReturn.LinkClicked
        '  WindowState = FormWindowState.Minimized
        oOpen = False
        Visible = False


    End Sub

    Private Sub shiftTabListener_Tick(sender As Object, e As EventArgs) Handles shiftTabListener.Tick
        If GetAsyncKeyState(Keys.LShiftKey) And GetAsyncKeyState(Keys.Tab) Then
            shiftTabListener.Stop()

            If oOpen = True Then
                Visible = False
            Else
                Visible = True
                TopMost = True
            End If
        Else
            'Do nothing.
        End If
    End Sub

    Public Sub sendNoticeAll(user As String, message As String)

        If Me.Visible = False Then
            NotifyIcon1.Visible = True
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.None
            NotifyIcon1.BalloonTipTitle = user
            NotifyIcon1.BalloonTipText = message
            NotifyIcon1.ShowBalloonTip(7500)
        End If

    End Sub


    Private Sub SteamOverlay_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        'oOpen = True

        If Me.Visible = True Then
            oOpen = True

            Me.Activate()

            ShowInTaskbar = True
            TopMost = True

            If BackgroundWorker2.IsBusy = False Then
                BackgroundWorker2.RunWorkerAsync()
            End If

        Else
            oOpen = False
            NotifyIcon1.Visible = True
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.None
            NotifyIcon1.BalloonTipTitle = "Now Playing"
            NotifyIcon1.BalloonTipText = "Forza Horizon 3."
            NotifyIcon1.ShowBalloonTip(5000)
            ' ShowInTaskbar = False

            If BackgroundWorker2.IsBusy = False Then
                BackgroundWorker2.RunWorkerAsync()
            End If
            ' Process.Start("shell:AppsFolder\Microsoft.OpusPG_8wekyb3d8bbwe!OpusReleaseFinal")  '// Forza Horizon 3 launch.
        End If

    End Sub


    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Thread.Sleep(800)
    End Sub

    Private Sub BackgroundWorker2_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged

    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        shiftTabListener.Start()
    End Sub



    '//Game check.
    Private Sub gameRunningTimer_Tick(sender As Object, e As EventArgs) Handles gameRunningTimer.Tick
        ' Dim p() As Process
        ' p = Process.GetProcessesByName(gameEXE)
        ' If p.Count > 0 Then
        '     ' Process is running
        ' Else
        '     ShowInTaskbar = False
        '     Close()
        ' End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs)
        Dim ans

        ans = MessageBox.Show("Are you sure you wish to close " & GameTitle.Text & "?" & vbNewLine & "Any unsaved progress will be lost.", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If ans = vbYes Then
            Close()
        Else

        End If

    End Sub


    Private Sub SteamOverlay_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim p() As Process
        p = Process.GetProcessesByName(gameEXE)
        If p.Count > 0 Then
            ' Process is running
            Process.GetProcessesByName(gameEXE)(0).Kill()
        Else
            ShowInTaskbar = False
            Close()
        End If
    End Sub




    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Thread.Sleep(1000)
        Visible = False

    End Sub

    Private Sub frmTestWindow_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles frmCommunityHub.LinkClicked
        'Dim f As frmTestWindow

        '//Make CHUB visible.
        'frmCommunityHub.Show()

        ' '// Open the Community Hub on launch. .. This will automatically connect to the server.
        '  Dim CHUB As frmCommunityHub()
        '  CHUB.TopLevel = False
        '  CHUB.StartPosition = FormStartPosition.CenterScreen
        '  Me.pMainPanel.Controls.Add(CHUB)
        '  CHUB.Show()


        '   pMainPanel.Controls.Add(frmCommunityHub)
        '   frmCommunityHub.Show()
        '   'Dim child As New Test()
        '
        '
        'child.TopLevel = False
        'Me.pMainPanel.Controls.Add(child)
        'child.Show()

    End Sub


    Private Sub btnQuit_Click_1(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dispose()
    End Sub

    Private Sub lnkAccountDetails_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAccountDetails.LinkClicked
        '// Open the frmAccountSettings...
        Dim ADetails As New frmAccountSettings()
        ADetails.TopLevel = False
        Me.pMainPanel.Controls.Add(ADetails)
        ADetails.Show()
    End Sub

    Private Sub BackgroundWorker_LoadChat_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_LoadChat.DoWork

    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Friends As New frmRecentPlayers()
        Friends.TopLevel = False
        Me.pMainPanel.Controls.Add(Friends)
        Friends.Show()
    End Sub
End Class