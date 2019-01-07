Public Class Form1
    Private Sub reset()

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Up Then
            lblSquare.Location = New Point(lblSquare.Location.Y + 1)
        End If

        If e.KeyCode = Keys.Right Then
            lblSquare.Left = lblSquare.Left + 5
        End If

        If e.KeyCode = Keys.Left Then

        End If

        If lblSquare.Bounds.IntersectsWith(GroupBox1.Bounds) Then
            MsgBox("You win!")
        End If
    End Sub
End Class
