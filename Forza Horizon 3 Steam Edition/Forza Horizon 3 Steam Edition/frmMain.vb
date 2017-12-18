Imports System.Runtime.InteropServices
Imports System.Threading

Public Class frmMain




    Private Declare Function ShowWindow Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal nCmdShow As SHOW_WINDOW) As Boolean

    <Flags()>
    Private Enum SHOW_WINDOW As Integer
        SW_HIDE = 0
        SW_SHOWNORMAL = 1
        SW_NORMAL = 1
        SW_SHOWMINIMIZED = 2
        SW_SHOWMAXIMIZED = 3
        SW_MAXIMIZE = 3
        SW_SHOWNOACTIVATE = 4
        SW_SHOW = 5
        SW_MINIMIZE = 6
        SW_SHOWMINNOACTIVE = 7
        SW_SHOWNA = 8
        SW_RESTORE = 9
        SW_SHOWDEFAULT = 10
        SW_FORCEMINIMIZE = 11
        SW_MAX = 11
    End Enum

    Private Sub MaximizeGame()
        For Each p As Process In Process.GetProcessesByName("forza_x64_release_final")
            ShowWindow(p.MainWindowHandle, SHOW_WINDOW.SW_RESTORE)
        Next p
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            'MsgBox("explorer.exe ""shell:AppsFolder\Microsoft.OpusPG_8wekyb3d8bbwe!OpusReleaseFinal""")
            'Process.Start("cmd.exe /c " + "explorer.exe", "shell:AppsFolder\Microsoft.OpusPG_8wekyb3d8bbwe!OpusReleaseFinal")
            'Shell("cmd.exe /c " + "explorer.exe " + """shell:AppsFolder\Microsoft.OpusPG_8wekyb3d8bbwe!OpusReleaseFinal""")
            'Shell("shell:AppsFolder\Microsoft.OpusPG_8wekyb3d8bbwe!OpusReleaseFinal")


            'start the game on launch..
            Process.Start("shell:AppsFolder\Microsoft.OpusPG_8wekyb3d8bbwe!OpusReleaseFinal")  ' Forza Horizon 3
            ' Process.Start("shell:AppsFolder\Microsoft.ApolloBaseGame_1.107.5368.2_x64__8wekyb3d8bbwe")  ' Forza 7


            'Simulate shift and tab press event to open the Overlay form..
            'SteamOverlay.Show()
            Thread.Sleep(10000)
            Timer1.Start()

            WindowState = FormWindowState.Minimized

        Catch ex As Exception
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

    Dim startCount As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Dim p() As Process
        ' p = Process.GetProcessesByName(gameEXE)
        ' If p.Count > 0 Then
        '     ' Process is running
        ' Else
        '     ShowInTaskbar = False
        '     Close()
        ' End If

        '  p = Process.GetProcessesByName("forzamotorsport7")
        '  If p.Count > 0 Then
        '      ' Process is running
        '      'Do nothing This means that we know that the process is running. We close this after the process has ended.
        '      ' MsgBox("Forza is running.")
        '  Else        '
        '      ShowInTaskbar = False
        '      Close()
        '  End If
        '  GC.Collect()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        If Me.WindowState = FormWindowState.Minimized Then

            NotifyIcon1.Visible = True
            'NotifyIcon1.Icon = My.Resources
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.None
            NotifyIcon1.BalloonTipTitle = "Now Playing"
            NotifyIcon1.BalloonTipText = "Forza Horizon 3."
            NotifyIcon1.ShowBalloonTip(9000)
            'Me.Hide()
            ShowInTaskbar = False

        End If
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        'Me.Show()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Process is not running
        'MsgBox("Forza is NOT running.")
        NotifyIcon1.Visible = True
        'NotifyIcon1.Icon = My.Resources
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.None
        NotifyIcon1.BalloonTipTitle = "Closing"
        NotifyIcon1.BalloonTipText = "Forza Horizon 3."
        NotifyIcon1.ShowBalloonTip(4000)
        'Me.Hide()
        Thread.Sleep(3000)
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        '  Try
        '      Dim p() As Process
        '
        '      '   p = Process.GetProcessesByName(gameEXE)
        '      If p.Count > 0 Then
        '          'Process is running
        '          'Do nothing This means that we know that the process is running. We close this after the process has ended.
        '          Label1.Text = "Closing Forza Horizon 3..."
        '          btnQuit.Enabled = False
        '          '      Process.GetProcessesByName(gameEXE)(0).Kill()
        '          Close()
        '      Else
        '          'Process is not running
        '          Close()
        '      End If
        '
        '  Catch ex As Exception
        '      Label1.Text = ex.Message
        '      btnQuit.Enabled = False
        '      Close()
        '  End Try

    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.Click
        'Me.Show()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        '   If GetAsyncKeyState(Keys.LShiftKey) And GetAsyncKeyState(Keys.Tab) Then
        If Overlay.IsBusy = True Then
                'Do nothing
            Else
                'Overlay.RunWorkerAsync()
                Timer2.Stop()
                Thread.Sleep(500)
                SteamOverlay.Show()
            End If
        '    End If
    End Sub

    Private Sub Overlay_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Overlay.DoWork
        Timer2.Stop()
        SteamOverlay.Show()
    End Sub

    Private Sub Overlay_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Overlay.RunWorkerCompleted

    End Sub



    ' We need to identify when to open the steam overlay feature using a different form that must be transparent..
    ' this will allow us to checkout our friends list, etc..



End Class
