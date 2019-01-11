Public Class Form1
    Dim slowbox1 As Boolean
    Dim fastbox2 As Boolean
    Dim bitslowbox3 As Boolean
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Up Then
            lblSquare.Top = lblSquare.Top - 5
        End If

        If e.KeyCode = Keys.Right Then
            lblSquare.Left = lblSquare.Left + 5
        End If

        If e.KeyCode = Keys.Left Then
            lblSquare.Left = lblSquare.Left - 5
        End If

        If e.KeyCode = Keys.Down Then
            lblSquare.Top = lblSquare.Top + 5
        End If

        If lblSquare.Bounds.IntersectsWith(GroupBox1.Bounds) Then
            MsgBox("You win!")
            reset()
            Exit Sub
        End If
    End Sub
    Private Sub reset()
        lblSquare.Location = New Point(280, 409)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmr1.Tick
        Dim moveright As Boolean

        If moveright = True Then
            lbl1.Left = lbl1.Left + 10
            lbl2.Left = lbl2.Left + 10
            lbl3.Left = lbl3.Left + 10
        Else
            lbl1.Left = lbl1.Left - 10
            lbl2.Left = lbl2.Left - 10
            lbl3.Left = lbl3.Left - 10
        End If



        If lbl1.Bounds.IntersectsWith(lblRightBump.Bounds) Then
            lbl1.Top = lbl1.Top + 10
        End If

    End Sub

    Private Sub tmr2_Tick(sender As Object, e As EventArgs) Handles tmr2.Tick
        If lbl2.Bounds Then
    End Sub

    Private Sub tmr3_Tick(sender As Object, e As EventArgs) Handles tmr3.Tick

    End Sub
End Class
