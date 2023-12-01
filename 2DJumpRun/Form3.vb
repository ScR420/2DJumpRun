﻿Public Class Level3

    Dim xPosition As Integer = 49
    Dim yPosition As Integer = 332
    Dim figGeschw As Integer = 8
    Dim jumping As Boolean = False
    Dim jumpDirection As Integer = 0

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.A
                xPosition -= figGeschw
                jumpDirection = -1
                UpdatePosition()
            Case Keys.D
                xPosition += figGeschw
                jumpDirection = 1
                UpdatePosition()
            Case Keys.Space
                If Not jumping Then
                    jumping = True
                    Jump()
                End If
        End Select

        If PboxMain.Bounds.IntersectsWith(PboxBlock1.Bounds) OrElse PboxMain.Bounds.IntersectsWith(PboxBlock2.Bounds) OrElse PboxMain.Bounds.IntersectsWith(PboxBlock3.Bounds) Then
            xPosition = 49
            yPosition = 332
            UpdatePosition()
        End If
        If PboxMain.Bounds.IntersectsWith(pboxTeleport1.Bounds) Then
            xPosition = 680
            yPosition = 115
            UpdatePosition()
        End If
    End Sub

    Private Sub UpdatePosition()
        If xPosition < 0 Then
            xPosition = 0
        End If

        If xPosition > Me.Width - PboxMain.Width Then
            xPosition = Me.Width - PboxMain.Width
        End If


        PboxMain.Location = New Point(xPosition, yPosition)
        Me.Refresh()
        '
        finish()
    End Sub

    ' Sprungfunktion
    Private Sub Jump()
        Dim jumpHeight As Integer = 70
        Dim jumpStep As Integer = 3

        For i As Integer = 1 To jumpHeight / jumpStep
            yPosition -= jumpStep
            UpdatePosition()
            Threading.Thread.Sleep(10)
        Next

        For i As Integer = 1 To jumpHeight / jumpStep
            If jumpDirection = -1 Then
                xPosition -= 4
            ElseIf jumpDirection = 1 Then
                xPosition += 4
            End If

            yPosition += jumpStep
            UpdatePosition()
            Threading.Thread.Sleep(10)
        Next


        jumping = False
        jumpDirection = 0
    End Sub

    Private Sub finish()
        If PboxMain.Bounds.IntersectsWith(PboxFinish.Bounds) Then
            Me.Close()
            gewonnenForm.Show()
        End If
    End Sub

    Private Sub fail()
        If PboxMain.Bounds.IntersectsWith(PboxBlock1.Bounds) Then
            MessageBox.Show("Du hast es leider nicht geschaft.")
        End If

        xPosition = 49
        yPosition = 332
        UpdatePosition()
    End Sub


End Class