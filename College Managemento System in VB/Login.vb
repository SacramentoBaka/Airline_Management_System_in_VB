Public Class Login
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles LoginEmail.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles LoginPassword.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles LoginRegister.Click
        Dim sign_in = New SignUp
        sign_in.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If LoginEmail.Text = "" Or LoginPassword.Text = " " Then
            MsgBox("Please enter email and password")
        End If
        If LoginEmail.Text = "Admin" And LoginPassword.Text = "admin" Then
            Dim Obj = New Home
            Obj.Show()
            Me.Hide()

        Else
            MsgBox("You have entered wrong credentials")
            LoginEmail.Text = ""
            LoginPassword.Text = ""

        End If

        LoginEmail.Text = ""
        LoginPassword.Text = ""

    End Sub
End Class