Imports Forza_Horizon_3_Steam_Edition.SteamOverlay
Imports System.Media.SoundPlayer
Imports System.Media

Public Class AudioController

    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVallpstReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallBack As Integer) As Integer

    Private oName As String = Nothing

    Public Property Name As String
        Set(value As String)
            oName = value
        End Set
        Get
            Return oName
        End Get
    End Property


    Public Sub Play(ByVal id As Integer, ByVal repeat As Boolean, Optional vol As Integer = 1000)
        If repeat = True Then
            mciSendString("Open " & GetFile(id) & " alias " & oName, CStr(0), 0, 0)
            mciSendString("play " & oName & " repeat", CStr(0), 0, 0)
        Else
            mciSendString("Open " & GetFile(id) & " alias " & oName, CStr(0), 0, 0)
            mciSendString("play " & oName & " repeat", CStr(0), 0, 0)
        End If
        mciSendString("setaudio " & oName & " volume to ", CStr(0), 0, 0)
    End Sub


    Private Function GetFile(ByVal id As Integer) As String
        Dim path As String = ""

        Select Case id
            Case 0
                path = My.Resources.AMB_EC_Steam1.ToString

            Case 1
                path = My.Resources.AMB_EC_Steam2.ToString

            Case 2
                path = My.Resources.AMB_EC_Steam3.ToString

            Case 3
                path = My.Resources.AMB_EC_Steam4.ToString

            Case 4
                path = My.Resources.AMB_EC_Steam5.ToString

            Case 5
                path = My.Resources.AMB_EC_Steam6.ToString

            Case 6
                path = My.Resources.AMB_EC_Steam7.ToString

            Case 7
                path = My.Resources.AMB_EC_Voices1.ToString

            Case 8
                path = My.Resources.AMB_EC_Voices2.ToString

            Case 9
                path = My.Resources.AMB_EC_Voices3.ToString

            Case 10
                path = My.Resources.AMB_EC_Voices4.ToString

            Case 11
                path = My.Resources.AMB_EC_Voices5.ToString

            Case 12
                path = My.Resources.AMB_EC_Voices6.ToString

            Case 13
                path = My.Resources.AMB_EC_Voices7.ToString

            Case 14
                path = My.Resources.AMB_EC_Voices8.ToString

            Case 15
                path = My.Resources.AMB_EC_Voices9.ToString

            Case 16
                path = My.Resources.AMB_EC_Voices10.ToString

            Case 17
                path = My.Resources.AMB_EC_Voices11.ToString

            Case 18
                path = My.Resources.AMB_EC_Voices12.ToString

            Case 19
                path = My.Resources.AMB_EC_Voices13.ToString

            Case 20
                path = My.Resources.comm_static_1.ToString

            Case 21
                path = My.Resources.comm_static_2.ToString

            Case 22
                path = My.Resources.comm_static_3.ToString

            Case 23
                path = My.Resources.comm_static_4.ToString

            Case 24
                path = My.Resources.comm_voice_1.ToString

            Case 25
                path = My.Resources.comm_voice_2.ToString

            Case 26
                path = My.Resources.comm_voice_3.ToString

            Case 27
                path = My.Resources.comm_voice_4.ToString

            Case 28
                path = My.Resources.comm_voice_5.ToString

            Case 29
                path = My.Resources.comm_voice_6.ToString

            Case 30
                path = My.Resources.comm_voice_7.ToString

            Case 31
                path = My.Resources.comm_voice_8.ToString

            Case 32
                path = My.Resources.comm_voice_9.ToString

                ' Case 33
                '     path = My.Resources.
                '
                ' Case 34
                '     path = My.Resources.
                '
                ' Case 35
                '     path = My.Resources.
                '
                ' Case 36
                '     path = My.Resources.
                '
                ' Case 37
                '     path = My.Resources.
                '
                ' Case 38
                '     path = My.Resources.
                '
                ' Case 39
                '     path = My.Resources.         


        End Select

        path = Chr(34) & path & Chr(34)
        Return path


    End Function



    Public Shared Sub StartAmbient()

        ' mainAmbientPlayer.Stream = My.Resources.AMB_05_ENGINEROOM_LR
        ' mainAmbientPlayer.Load()
        ' mainAmbientPlayer.PlayLooping()

        '    Dim file = My.Resources.AMB_EC_Steam1

        '    Dim audioFile As Audio = New Audio(file)
        '   audioFile.Play()

    End Sub


    Public Shared Sub RndSteamSounds(index As Integer)

        '
        '     Dim fileName
        '
        '     fileName = My.Resources.AMB_05_ENGINEROOM_LR
        '     mciSendString("open " & fileName & " type mpegvideo alias FirstSound", String.Empty, 0, 0)
        '     mciSendString("play FirstSound", String.Empty, 0, 0)
        '
        '
        '     fileName = My.Resources.AMB_EC_Steam1
        '     mciSendString("open " & fileName & " type mpegvideo alias SecondSound", String.Empty, 0, 0)
        '     mciSendString("play SecondSound", String.Empty, 0, 0)
        '
        '
        '
        '
        '
        '     Select Case index
        '         Case 0
        '             Dim audioFile As Audio = New Audio(My.Resources.AMB_05_ENGINEROOM_LR)
        '             audioFile.Play()
        '         Case 1
        '
        '         Case 2
        '             rndSteamPlayer.Stream = My.Resources.AMB_EC_Steam3
        '             rndSteamPlayer.Load()
        '             rndSteamPlayer.Play()
        '         Case 3
        '             rndSteamPlayer.Stream = My.Resources.AMB_EC_Steam4
        '             rndSteamPlayer.Load()
        '             rndSteamPlayer.Play()
        '         Case 4
        '             rndSteamPlayer.Stream = My.Resources.AMB_EC_Steam5
        '             rndSteamPlayer.Load()
        '             rndSteamPlayer.Play()
        '         Case 5
        '             rndSteamPlayer.Stream = My.Resources.AMB_EC_Steam6
        '             rndSteamPlayer.Load()
        '             rndSteamPlayer.Play()
        '         Case 6
        '             rndSteamPlayer.Stream = My.Resources.AMB_EC_Steam7
        '             rndSteamPlayer.Load()
        '             rndSteamPlayer.Play()
        '         Case 7
        '             rndSteamPlayer.Stream = My.Resources.AMB_EC_Steam1
        '             rndSteamPlayer.Load()
        '             rndSteamPlayer.Play()
        '     End Select
    End Sub




End Class
