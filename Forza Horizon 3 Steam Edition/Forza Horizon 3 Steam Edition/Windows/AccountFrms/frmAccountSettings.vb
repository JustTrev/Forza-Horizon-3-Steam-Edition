Imports Forza_Horizon_3_Steam_Edition.vAccountInfo


Public Class frmAccountSettings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtPName.Text = Nothing Then
            lblNotices.Text = "Please enter nickname."
            lblNotices.Visible = True
        Else
            lblNotices.Visible = False
            RegKey.SetValue(Of String)(RegKey.ProfileName, txtPName.Text)
            NickFreFix = RegKey.GetValue(Of String)(RegKey.ProfileName)

            byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(NickFreFix)  '// This is now written in HEX for the server to decrypt.

            Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If txtPName.Text = Nothing Then
            lblNotices.Text = "Please enter nickname."
            lblNotices.Visible = True
        Else
            lblNotices.Visible = False
            RegKey.SetValue(Of String)(RegKey.ProfileName, txtPName.Text)
            NickFreFix = RegKey.GetValue(Of String)(RegKey.ProfileName)

            byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(NickFreFix) '// This is now written in HEX for the server to decrypt.

            Close()
        End If
    End Sub

    Private Sub txtPName_TextChanged(sender As Object, e As EventArgs) Handles txtPName.TextChanged
        lblNotices.Visible = False
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

    Private Sub frmAccountSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.Location = My.Settings.frmAccLocation
        ' Me.Location.Y = My.Settings.frmAccLocationY

        txtPName.Text = RegKey.GetValue(Of String)(RegKey.ProfileName)
    End Sub

    Private Sub frmAccountSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.frmAccLocation = Me.Location
        'My.Settings.frmAccLocationY = Me.Location.Y
        My.Settings.Save()

    End Sub

    Private Sub frmAccountSettings_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.TopMost = True
    End Sub
End Class