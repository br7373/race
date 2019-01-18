Public Class Form1
    Dim change1 As Boolean
    Dim change2 As Boolean
    Dim change3 As Boolean
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Up Then
            lblSquare.Top = lblSquare.Top - 10
        End If

        If e.KeyCode = Keys.Right Then
            lblSquare.Left = lblSquare.Left + 10
        End If

        If e.KeyCode = Keys.Left Then
            lblSquare.Left = lblSquare.Left - 10
        End If

        If e.KeyCode = Keys.Down Then
            lblSquare.Top = lblSquare.Top + 10
        End If

        If lblSquare.Bounds.IntersectsWith(GroupBox1.Bounds) Then
            MsgBox("You win!")
            reset()
            Exit Sub
        End If

        If lblSquare.Bounds.IntersectsWith(lblRight.Bounds) Then
            reset()
        End If

        If lblSquare.Bounds.IntersectsWith(lblLeft.Bounds) Then
            reset()
        End If

        If lblSquare.Bounds.IntersectsWith(lblBottom.Bounds) Then
            reset()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmr1.Tick
        intersection()

        If change1 = False Then
            lbl1.Left = lbl1.Left + 7.5
        End If

        If change1 = True Then
            lbl1.Left = lbl1.Left - 7.5
        End If

        If lbl1.Bounds.IntersectsWith(lblRight.Bounds) Then
            change1 = True
        End If

        If lbl1.Bounds.IntersectsWith(lblLeft.Bounds) Then
            change1 = False
        End If
    End Sub

    Private Sub tmr2_Tick(sender As Object, e As EventArgs) Handles tmr2.Tick
        intersection()

        If change2 = False Then
            lbl2.Left = lbl2.Left + 10
        End If

        If change2 = True Then
            lbl2.Left = lbl2.Left - 10
        End If

        If lbl2.Bounds.IntersectsWith(lblRight.Bounds) Then
            change2 = True
        End If

        If lbl2.Bounds.IntersectsWith(lblLeft.Bounds) Then
            change2 = False
        End If
    End Sub

    Private Sub tmr3_Tick(sender As Object, e As EventArgs) Handles tmr3.Tick
        intersection()

        If change3 = False Then
            lbl3.Left = lbl3.Left + 20
        End If

        If change3 = True Then
            lbl3.Left = lbl3.Left - 20
        End If

        If lbl3.Bounds.IntersectsWith(lblRight.Bounds) Then
            change3 = True
        End If

        If lbl3.Bounds.IntersectsWith(lblLeft.Bounds) Then
            change3 = False
        End If
    End Sub
    Private Sub intersection()
        If lblSquare.Bounds.IntersectsWith(lbl1.Bounds) Then
            reset()
        End If
        If lblSquare.Bounds.IntersectsWith(lbl2.Bounds) Then
            reset()
        End If
        If lblSquare.Bounds.IntersectsWith(lbl3.Bounds) Then
            reset()
        End If
    End Sub
    Private Sub reset()
        lblSquare.Location = New Point(280, 409)
    End Sub
End Class
