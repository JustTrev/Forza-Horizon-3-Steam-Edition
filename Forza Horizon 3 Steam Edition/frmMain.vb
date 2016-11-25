Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            'MsgBox("explorer.exe ""shell:AppsFolder\Microsoft.OpusPG_8wekyb3d8bbwe!OpusReleaseFinal""")
            'Process.Start("cmd.exe /c " + "explorer.exe", "shell:AppsFolder\Microsoft.OpusPG_8wekyb3d8bbwe!OpusReleaseFinal")
            'Shell("cmd.exe /c " + "explorer.exe " + """shell:AppsFolder\Microsoft.OpusPG_8wekyb3d8bbwe!OpusReleaseFinal""")
            'Shell("shell:AppsFolder\Microsoft.OpusPG_8wekyb3d8bbwe!OpusReleaseFinal")
            Process.Start("shell:AppsFolder\Microsoft.OpusPG_8wekyb3d8bbwe!OpusReleaseFinal")


            Timer1.Start()
            WindowState = FormWindowState.Minimized

        Catch ex As Exception
            NotifyIcon1.Visible = True
            'NotifyIcon1.Icon = My.Resources
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Error
            NotifyIcon1.BalloonTipTitle = "Forza Horizon 3 Steam Edition"
            NotifyIcon1.BalloonTipText = ex.Message
            NotifyIcon1.ShowBalloonTip(6000)
            'Me.Hide()
            ShowInTaskbar = False
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Timer1.Stop()
            Close()

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim p() As Process

        p = Process.GetProcessesByName("forza_x64_release_final")
        If p.Count > 0 Then
            ' Process is running
            'Do nothing This means that we know that the process is running. We close this after the process has ended.
            ' MsgBox("Forza is running.")


        Else

            ShowInTaskbar = False
            Close()
        End If

        GC.Collect()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            'NotifyIcon1.Icon = My.Resources
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.None
            NotifyIcon1.BalloonTipTitle = "Now Playing"
            NotifyIcon1.BalloonTipText = "Forza Horizon 3 Steam Edition."
            NotifyIcon1.ShowBalloonTip(10000)
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
        NotifyIcon1.BalloonTipTitle = "Forza Horizon 3 Steam Edition"
        NotifyIcon1.BalloonTipText = "Closing."
        NotifyIcon1.ShowBalloonTip(6000)
        'Me.Hide()
        System.Threading.Thread.Sleep(6000)
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Try
            Dim p() As Process

            p = Process.GetProcessesByName("forza_x64_release_final")
            If p.Count > 0 Then
                ' Process is running
                'Do nothing This means that we know that the process is running. We close this after the process has ended.
                ' MsgBox("Forza is running.")
                Process.GetProcessesByName("forza_x64_release_final")(0).Kill()
                Close()

            Else
                ' Process is not running
                'MsgBox("Forza is NOT running.")
                Close()

            End If
        Catch ex As Exception

        End Try

    End Sub
End Class
