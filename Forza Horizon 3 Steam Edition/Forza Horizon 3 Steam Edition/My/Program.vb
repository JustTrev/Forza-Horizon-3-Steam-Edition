Imports System.Globalization
Imports System.IO
Imports System.Security.Principal
Imports System.Threading
Imports System.Net
Imports System.Environment
Imports System.ComponentModel
Imports Forza_Horizon_3_Steam_Edition.vAccountInfo

Namespace My
    Public Class Program
        Public Shared ReadOnly Args As String() = Environment.GetCommandLineArgs()
        Public Shared ReadOnly StartPath As String = CurDir() ' Current path of 
        'Public Shared ReadOnly Client As MyWebClient = New MyWebClient() With {.Timeout = 10000, .Proxy = Nothing}
        'Public Shared ReadOnly ItemPatchClient As MyWebClient = New MyWebClient() With {.Timeout = 10000, .Proxy = Nothing}
        ' Public Shared ReadOnly Client2 As MyWebClient = New MyWebClient() With {.Timeout = 10000, .Proxy = Nothing}

        ' Public Shared WithEvents BackgroudWorker_CheckForUpdates As BackgroundWorker
        ' Public Shared MainForm As frmMETMain
        Public Shared HostsFilePath As String
        Public Shared Nodiag As Boolean = False
        Public Shared IsMainFormTopMost As Boolean = False

        Public Shared mBackColorR ' = "64"
        Public Shared mBackColorG ' = "64"
        Public Shared mBackColorB ' = "64"

        Public Shared versionFilePath As String

        Public Shared Sub Main()
            ' On Error GoTo ErrHandeler
            Try

                '  If File.Exists(CurDir() & "\MetroFramework.Design.dll") = False Or File.Exists(CurDir() & "\MetroFramework.dll") = False Or File.Exists(CurDir() & "\MetroFramework.Fonts.dll") = False Then
                '      '  ApplicationUpdater.ShowDialog()
                '      Exit Sub
                '  End If



                'Put some objects in memory.
                ' MyGCCollectClass.MakeSomeGarbage()
                'Console.WriteLine("Memory used before collection:       {0:N0}",
                '               GC.GetTotalMemory(False))

                'Collect all generations of memory.
                ' GC.Collect()
                ' ' Console.WriteLine("Memory used after full collection:   {0:N0}",
                ' GC.GetTotalMemory(True))

                Dim userpath As String = CurDir()
                ' Dim filePath As String

                'Dim LatestAppVersion As String = "\\dublnt01\ITPUBLIC\CommandCenter\TSC\package\version.txt" 'Checks downloads to the latest version of the launcher

                '   If Directory.Exists("\\dublnt01\ITPUBLIC\CommandCenter\TSC\") = True Then
                '       'accessDenied = True
                '       filePath = "\\dublnt01\ITPUBLIC\CommandCenter\TSC\"
                '       versionFilePath = "\\dublnt01\ITPUBLIC\CommandCenter\TSC\package\version.txt"
                '   Else
                '       MessageBox.Show("Please make sure you have access to the local share drive location in order to use this application.", "Could not locate drive location.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '       filePath = Nothing
                '       versionFilePath = Nothing
                '
                '   End If
                ' Try         

                '  Dim LatestAppVersion As New StreamReader(versionFilePath) 'Checks downloads to the latest version of the launcher


                Helper.Log("Build number: " & Application.Info.Version.Major & "." & Application.Info.Version.Minor & "." & Application.Info.Version.Build & "." & Application.Info.Version.Revision)
                Helper.Log("Checking if PEANUT is running.")


                Helper.Log("Program started! - Logging enabled!")
                ' Helper.Log("Attempting to auto-load TSC directory from settings")
                '
                ' Helper.Log("Loaded TSC directory from settings")

                Helper.Log("Checking for updates.")




                '---------------------------------------------------------------  START Update Engine  ----------------------------------------------------------------------
                '  Dim web As New WebClient
                '
                '  Dim curVersion As String '= Application.Info.Version.ToString
                '  ' MsgBox(curVersion) 'Debug
                '  curVersion = Application.Info.Version.ToString & Environment.NewLine
                '
                '  Dim fileReader As System.IO.StreamReader
                '  fileReader = My.Computer.FileSystem.OpenTextFileReader(filePath & "feed\changelog.txt")
                '  Dim stringReader As String
                '  stringReader = fileReader.ReadToEnd()
                '
                '  ' MessageBox.Show("DEBUG: " & vbCrLf & "Current Version: " & curVersion & vbCrLf & "Latest Version: " & LatestAppVersion.ReadToEnd.ToString & vbCrLf & StringReader, "Tactical Support Center.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '
                '  Dim onlineVer As String = LatestAppVersion.ReadToEnd.ToString


                ' If onlineVer <> curVersion Then
                '     Helper.Log("Version mismatch found. Gathering latest files.")
                '     ' MessageBox.Show("DEBUG: " & vbCrLf & "Current Version: " & curVersion & vbCrLf & "Latest Version: " & LatestAppVersion.ReadToEnd.ToString & vbCrLf & stringReader, "Tactical Support Center.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '     'Show message of the latest update.
                '     MessageBox.Show("A new version of Tactical Support Center is available." & vbCrLf & vbCrLf & "Current Version: " & curVersion & vbCrLf & "Latest Version: " & onlineVer & vbCrLf & stringReader, "Tactical Support Center.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '     Helper.WriteDebugInfo("A newer version of Tactical Support Center is available for download.")
                '     ' ApplicationUpdater.ShowDialog()
                ' Else
                '     Helper.WriteDebugInfo("Latest version installed.  " & vbCrLf & "Current Version: " & curVersion & vbCrLf & "Latest Version: " & onlineVer)
                ' End If

                '-------------------------------------------------------------------- END Update Engine -----------------------------------------------------------------------
                Helper.Log("Attempting to auto-load PBJ directory from settings")
                'Try
                If String.IsNullOrEmpty(RegKey.GetValue(Of String)(RegKey.Firsttimerun)) Then RegKey.SetValue(Of String)(RegKey.Firsttimerun, "0")
                ' If String.IsNullOrEmpty(RegKey.GetValue(Of String)(RegKey.apperance)) Then RegKey.SetValue(Of String)(RegKey.apperance, "0")
                ' If String.IsNullOrEmpty(RegKey.GetValue(Of String)(RegKey.ThemStyle)) Then RegKey.SetValue(Of String)(RegKey.ThemStyle, "0")
                ' If String.IsNullOrEmpty(RegKey.GetValue(Of String)(RegKey.Theme)) Then RegKey.SetValue(Of String)(RegKey.Theme, "Default")
                ' If String.IsNullOrEmpty(RegKey.GetValue(Of String)(RegKey.MainPage)) Then RegKey.SetValue(Of String)(RegKey.MainPage, "HTML") 'Depreciated
                ' If String.IsNullOrEmpty(RegKey.GetValue(Of String)(RegKey.AutoStart)) Then RegKey.SetValue(Of String)(RegKey.AutoStart, "True")
                ' If String.IsNullOrEmpty(RegKey.GetValue(Of String)(RegKey.messages)) Then RegKey.SetValue(Of String)(RegKey.messages, "False")
                ' If String.IsNullOrEmpty(RegKey.GetValue(Of String)(RegKey.noticeDate)) Then RegKey.SetValue(Of String)(RegKey.noticeDate, "")
                ' If String.IsNullOrEmpty(RegKey.GetValue(Of String)(RegKey.noticeInformation)) Then RegKey.SetValue(Of String)(RegKey.noticeInformation, "\\dublnt01\ITPUBLIC\CommandCenter\TSC\environment\tcp\service\notices\")
                ' If String.IsNullOrEmpty(RegKey.GetValue(Of String)(RegKey.CustomWallpaper)) Then RegKey.SetValue(Of String)(RegKey.CustomWallpaper, "")
                If String.IsNullOrEmpty(RegKey.GetValue(Of String)(RegKey.VersionNumber)) Then RegKey.SetValue(Of String)(RegKey.VersionNumber, Environment.Version.ToString)
                '  If String.IsNullOrEmpty(RegKey.GetValue(Of String)(RegKey.BackgroundStyle)) Then RegKey.SetValue(Of String)(RegKey.BackgroundStyle, "3")
                ' If String.IsNullOrEmpty(RegKey.GetValue(Of String)(RegKey.DiagInfo)) Then RegKey.SetValue(Of String)(RegKey.DiagInfo, "True")
                If String.IsNullOrEmpty(RegKey.GetValue(Of String)(RegKey.startupPage)) Then RegKey.SetValue(Of String)(RegKey.startupPage, "0")

                If String.IsNullOrEmpty(RegKey.GetValue(Of String)(RegKey.Server)) Then RegKey.SetValue(Of String)(RegKey.Server, "live.peanuts.com")


                '\\Load defaults of the main bg color.
                If (RegKey.GetValue(Of Integer)(RegKey.mBackColorR) = 0) Then
                    RegKey.SetValue(Of Integer)(RegKey.mBackColorR, 64)
                Else

                End If
                If (RegKey.GetValue(Of Integer)(RegKey.mBackColorG)).Equals(0) Then
                    RegKey.SetValue(Of Integer)(RegKey.mBackColorG, 64)
                Else
                End If
                If (RegKey.GetValue(Of Integer)(RegKey.mBackColorB)).Equals(0) Then
                    RegKey.SetValue(Of Integer)(RegKey.mBackColorB, 64)
                Else

                End If

                '\\Load defaults of the textfield bg color.
                If (RegKey.GetValue(Of Integer)(RegKey.tBackColorR)).Equals(0) Then
                    RegKey.SetValue(Of Integer)(RegKey.tBackColorR, 64)
                Else
                End If
                If (RegKey.GetValue(Of Integer)(RegKey.tBackColorG)).Equals(0) Then
                    RegKey.SetValue(Of Integer)(RegKey.tBackColorG, 64)
                Else
                End If
                If (RegKey.GetValue(Of Integer)(RegKey.tBackColorB)).Equals(0) Then
                    RegKey.SetValue(Of Integer)(RegKey.tBackColorB, 64)
                Else
                End If

                '\\Load defaults of the textfield fr color.
                If (RegKey.GetValue(Of Integer)(RegKey.tForeColorR)).Equals(0) Then
                    RegKey.SetValue(Of Integer)(RegKey.tForeColorR, 242)
                Else
                End If
                If (RegKey.GetValue(Of Integer)(RegKey.tForeColorG)).Equals(0) Then
                    RegKey.SetValue(Of Integer)(RegKey.tForeColorG, 242)
                Else
                End If
                If (RegKey.GetValue(Of Integer)(RegKey.tForeColorB)).Equals(0) Then
                    RegKey.SetValue(Of Integer)(RegKey.tForeColorB, 238)
                Else
                End If

                '\\Load defaults of the labels\links fr color.
                If (RegKey.GetValue(Of Integer)(RegKey.lnkForeColorR)).Equals(0) Then
                    RegKey.SetValue(Of Integer)(RegKey.tForeColorR, 242)
                Else
                End If
                If (RegKey.GetValue(Of Integer)(RegKey.lnkForeColorG)).Equals(0) Then
                    RegKey.SetValue(Of Integer)(RegKey.tForeColorG, 242)
                Else
                End If
                If (RegKey.GetValue(Of Integer)(RegKey.lnkForeColorB)).Equals(0) Then
                    RegKey.SetValue(Of Integer)(RegKey.tForeColorB, 238)
                Else
                End If

                '\\Load defaults of the links\Visit fr color.
                If (RegKey.GetValue(Of Integer)(RegKey.lnkLinkColorR)).Equals(0) Then
                    RegKey.SetValue(Of Integer)(RegKey.tForeColorR, 242)
                Else
                End If
                If (RegKey.GetValue(Of Integer)(RegKey.lnkLinkColorG)).Equals(0) Then
                    RegKey.SetValue(Of Integer)(RegKey.tForeColorG, 242)
                Else
                End If
                If (RegKey.GetValue(Of Integer)(RegKey.lnkLinkColorB)).Equals(0) Then
                    RegKey.SetValue(Of Integer)(RegKey.tForeColorB, 238)
                Else
                End If




                If String.IsNullOrEmpty(RegKey.GetValue(Of String)(RegKey.ProfileName)) Then
                    RegKey.SetValue(Of String)(RegKey.Firsttimerun, "0")
                Else
                    NickFreFix = RegKey.GetValue(Of String)(RegKey.ProfileName)
                End If



                '   Dim fileModifiedDate As String = IO.File.GetLastWriteTime((RegKey.GetValue(Of String)(RegKey.noticeInformation) & "1128823216.DAT"))
                '   Dim regNoticeDate As String = RegKey.GetValue(Of String)(RegKey.noticeDate)
                '   'Load any of our unread notices.
                '   If fileModifiedDate = regNoticeDate Then
                '       frmMETMain.gNotice.BackColor = Color.Transparent
                '   Else 'False
                '       frmMETMain.gNotice.BackColor = Color.Orange
                '   End If


                If File.Exists(StartPath & "\logfile.txt") AndAlso Helper.GetFileSize(StartPath & "\logfile.txt") > 30720 Then
                    File.WriteAllText(StartPath & "\logfile.txt", "")
                End If
                Application.DoEvents()

                Helper.Log("Loaded settings from registry.")
            Catch ex As Exception
                Helper.Log(ex.Message.ToString & " Stack Trace: " & ex.StackTrace)
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' Call emailDataAnalysis(ex.Message, ex.StackTrace) 'Use this to auto send error reports when the error occours.

            End Try


            ' If whatever.length <= 20 Then
            '
            ' End If

        End Sub



    End Class
End Namespace
