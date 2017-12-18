Public Class frmPrivateMessage
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

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
End Class