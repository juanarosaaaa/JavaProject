Public Class LoginForm
    Private Sub lblSignUp_Click(sender As Object, e As EventArgs) Handles lblSignUp.Click
        pnlRegister.Visible = True

    End Sub

    Private Sub btnBackToSignIn_Click(sender As Object, e As EventArgs) Handles btnBackToSignIn.Click
        pnlRegister.Visible = False
    End Sub

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Dim menu = New Menu
        menu.Show()

    End Sub
End Class