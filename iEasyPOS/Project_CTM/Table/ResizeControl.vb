Public Class ResizeControl
    Private WithEvents mControl As Control
    Private AlowHS As Boolean = False
    Private AlowVS As Boolean = False
    Private AlowVHS As Boolean = False
    Private MXtmp As Integer = 0
    Private MYtmp As Integer = 0
    Private GMXtmp As Integer = 0
    Private GMYtmp As Integer = 0
    Dim Offset As Integer = 10

    Public Sub New(ByVal Control As Control)
        mControl = Control
    End Sub

    Private Sub mControl_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mControl.MouseMove
        If e.Button = MouseButtons.None Then
            If e.Y > sender.Height - Offset And e.Y < sender.Height And
            e.X > sender.Width - Offset And e.X < sender.Width Then

                sender.Cursor = Cursors.SizeNWSE
                AlowHS = False
                AlowVS = False
                AlowVHS = True





            ElseIf e.Y > sender.Height - Offset And e.Y < sender.Height And
            e.X < sender.Width - 20 Then

                sender.Cursor = Cursors.SizeNS
                AlowVS = True
                AlowHS = False
                AlowVHS = False
            ElseIf e.X > sender.Width - Offset And e.X < sender.Width And
            e.Y < sender.Height - 20 Then
                sender.Cursor = Cursors.SizeWE
                AlowHS = True
                AlowVS = False
                AlowVHS = False

            Else


                If sender.Cursor <> Cursors.Hand Then
                    sender.Cursor = Cursors.Hand
                End If
                AlowHS = False
                AlowVS = False
                AlowVHS = False

            End If



        End If

        If e.Button = MouseButtons.Left Then

            If Cursor.Position.X < FloorPlan.Floor.Left + FloorPlan.Floor.Width And Cursor.Position.Y < FloorPlan.Floor.Top + FloorPlan.Floor.Height Then

                If AlowHS = True Then
                    If sender.Width > 20 Then
                        sender.Width = sender.Width - (MXtmp - e.X)
                    Else
                        sender.Width += 1
                    End If
                ElseIf AlowVS = True Then

                    If sender.Height > 20 Then
                        sender.Height = sender.Height - (MYtmp - e.Y)
                    Else
                        sender.Height += 1
                    End If

                ElseIf AlowVHS = True Then

                    If sender.Height > 20 And sender.Width > 20 Then
                        sender.Width = sender.Width - (MXtmp - e.X)
                        sender.Height = sender.Height - (MYtmp - e.Y)

                    Else
                        sender.Height += 1
                        sender.Width += 1
                    End If

                Else

                    If sender.Top > 0 And sender.Top < FloorPlan.Floor.Height - 30 Then

                        sender.Top = sender.Top - (GMYtmp - Cursor.Position.Y)

                    Else

                        If sender.Top <= 0 Then
                            sender.Top += 10
                        Else
                            sender.Top -= 10
                        End If


                    End If

                    If sender.Left > 0 And sender.Left < FloorPlan.Floor.Width - 30 Then
                        sender.Left = sender.Left - (GMXtmp - Cursor.Position.X)
                    Else

                        If sender.Left <= 0 Then
                            sender.Left += 10
                        Else
                            sender.Left -= 10
                        End If

                    End If

                End If

            End If

        End If

        MXtmp = e.X
        MYtmp = e.Y
        GMXtmp = Cursor.Position.X
        GMYtmp = Cursor.Position.Y

    End Sub
End Class
