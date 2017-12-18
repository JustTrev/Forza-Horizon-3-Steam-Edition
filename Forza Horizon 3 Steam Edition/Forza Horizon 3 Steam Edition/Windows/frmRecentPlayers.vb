Imports Forza_Horizon_3_Steam_Edition.vbRegisterUsers
Imports Forza_Horizon_3_Steam_Edition.frmCommunityHub
Imports Forza_Horizon_3_Steam_Edition.vAccountInfo

Public Class frmRecentPlayers


    Private Sub frmRecentPlayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.Location = My.Settings.frmFriendsListLocation

        'Call the server to know who is online.
        Call whoIsOnline()

        lblUserName.Text = RegKey.GetValue(Of String)(RegKey.ProfileName)
        lblStatus.Text = "on Dashboard." 'Get data of status on activity to other players.

    End Sub
    '//Server Account Decryption
    Function HexToString(ByVal hex As String) As String
        Dim text As New System.Text.StringBuilder(hex.Length \ 2)
        For i As Integer = 0 To hex.Length - 2 Step 2
            text.Append(Chr(Convert.ToByte(hex.Substring(i, 2), 16)))
        Next
        Return text.ToString
    End Function
    'Call the server to know online users.
    Public Sub whoIsOnline()
        ' frmCommunityHub.command("AUTH436c69656e74526571AUTH") '43 6c 69 65 6e 74 52 65 71  ClientReq
        Try
            'For Each item As String In usersList
            ' lstRecentPlayers.Items(usersList)
            ' lstRecentPlayers.Items.Add(usersList.Items(0).Clone())
            ' lstRecentPlayers.Items = usersList.Items(0).Clone()
            Dim fuck As String
            ' lsbFriends.Items.Add("No Friends.")
            ' usersList.Items.CopyTo(lstRecentPlayers.Items(), usersList.Items.Count)



            If System.IO.File.Exists(CurDir() & "\userdata\friendslist.txt") = False Then
                Dim emptyFriends = New TreeNode("No Friends.")
                emptyFriends.Nodes.Add("Search for friends, up top.")

                Dim recentPlayers = New TreeNode("No Recent Players")

                tvPlayerHistory.Nodes.Add(recentPlayers)
                tvFriendsList.Nodes.Add(emptyFriends)
            Else

                '  tvPlayerHistory.Nodes.Add(recentPlayers)
                '  tvFriendsList.Nodes.Add(emptyFriends)
            End If

            If usersList.Items.Count = Nothing Then
                'lstRecentPlayers.Items.Add("No online users.")

            Else
                For Each item As String In usersList.Items
                    fuck = HexToString(item)
                    '       If fuck = NickFreFix Then
                    '          lstRecentPlayers.Items.Add(fuck & "   (YOU)")
                    '     Else
                    '         lstRecentPlayers.Items.Add(fuck)
                    '    End If
                Next
            End If
            ' lstRecentPlayers.Items.(usersList.Items().Count)

            'lstRecentPlayers.Items.Add(usersList.Items(0).Clone())
            'Add the items to the ListView.
            ' ListView1.Items.AddRange(New ListViewItem() {item1, item2, item3})
            '  lstRecentPlayers.Items.AddRange(New ListViewItem() {usersList.Items.Cast(Of ListViewItem)})
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace)
        End Try

    End Sub


    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    'Declare the variables
    Dim dragD As Boolean
    Dim mousexD As Integer
    Dim mouseyD As Integer

    Private Sub pHeadForm_MouseDown(sender As Object, e As MouseEventArgs) Handles pHeadForm.MouseDown
        Me.TopMost = True
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

    Private Sub frmRecentPlayers_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.TopMost = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        My.Settings.frmFriendsListLocation = Me.Location
        'My.Settings.frmAccLocationY = Me.Location.Y
        My.Settings.Save()
        Close()
    End Sub

    Dim i = 0
    Private Sub trefresh_Tick(sender As Object, e As EventArgs)
        If i = 10 Then
            i = 0
            Call whoIsOnline()
        End If
        i += 1
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class