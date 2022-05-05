Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel2.Width += 8

        If Panel2.Width >= 1169 Then

            LoginForm.Show()
            Me.Close()

        End If
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
