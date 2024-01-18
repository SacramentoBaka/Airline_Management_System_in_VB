Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        Timer1.Start()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        Label4.Text = ProgressBar1.Value & " %"

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()

        End If

        If ProgressBar1.Value = 20 Then
            Label1.Text = "Loading..."
        End If

        If ProgressBar1.Value = 35 Then
            Label1.Text = "Preparing Database..."
        End If

        If ProgressBar1.Value = 50 Then
            Label1.Text = "Halfway there please wait..."
        End If

        If ProgressBar1.Value = 75 Then
            Label1.Text = "Almost there..."
        End If

        If ProgressBar1.Value = 85 Then
            Label1.Text = "Launching Database..."
        End If

        If ProgressBar1.Value = 100 Then
            Label1.Text = "Done..."
            Me.Hide()
            Dim log = New Login
            log.Show()

        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
