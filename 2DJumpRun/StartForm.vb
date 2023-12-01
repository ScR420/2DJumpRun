
Public Class StartForm
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim gameForm As New Level1()

        gameForm.Show()
        Me.Hide()
    End Sub

    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleStartButton(btnStart)
    End Sub

    Private Sub StyleStartButton(button As Button)

        button.BackColor = Color.FromArgb(0, 128, 0)


        button.ForeColor = Color.White


        button.Font = New Font(button.Font.FontFamily, 14, FontStyle.Bold)


        button.Text = "Start ►"


        button.TextAlign = ContentAlignment.MiddleCenter
    End Sub
End Class