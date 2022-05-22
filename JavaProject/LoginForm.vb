Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class LoginForm

    Dim sqlConn As New MySqlConnection("datasource = localhost; port = 3306; username = root; password = root; database = javadatabase")
    Dim sqlCmd As New MySqlCommand
    Dim sqlQuery As String


    Private bitmap As Bitmap

    Private Sub reset()
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtFirstname.Text = ""
        txtSurname.Text = ""
        txtAge.Text = ""
        cmbSex.SelectedIndex = -1
        txtContactNo.Text = ""
        txtRegUsername.Text = ""
        txtRegPassword.Text = ""
        txtReenter.Text = ""
    End Sub

    Private Sub lblSignUp_Click(sender As Object, e As EventArgs) Handles lblSignUp.Click
        cbShowPassword.Visible = False
        pnlRegister.Visible = True
        txtFirstname.Select()

    End Sub

    Private Sub btnBackToSignIn_Click(sender As Object, e As EventArgs) Handles btnBackToSignIn.Click
        pnlRegister.Visible = False
        cbShowPassword.Visible = True
        reset()
    End Sub

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        sqlConn = New MySqlConnection
        sqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=javadatabase"

        sqlCmd = New MySqlCommand

        Try
            sqlConn.Open()
            sqlQuery = "SELECT * FROM javadatabase.tbl_user WHERE Username='" & txtUsername.Text & "' and password= '" & txtPassword.Text & "'"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)

            sqlCmd.Parameters.Add("Username", MySqlDbType.VarChar).Value = txtUsername.Text
            sqlCmd.Parameters.Add("Password", MySqlDbType.VarChar).Value = txtPassword.Text

            Dim sqlAdapter As New MySqlDataAdapter(sqlCmd)
            Dim sqltable As New DataTable()

            sqlAdapter.Fill(sqltable)

            If sqltable.Rows.Count = 0 Then
                MessageBox.Show("Invalid Username or Password")
                txtUsername.Text = ""
                txtPassword.Text = ""
                txtUsername.Select()
            Else
                Dim menu = New Menu
                menu.passValue = txtUsername.Text
                menu.Show()
                sqlConn.Close()
                Me.Hide()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        sqlConn = New MySqlConnection
        sqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=javadatabase"
        Dim sqlReader As MySqlDataReader

        Try
            sqlConn.Open()

            If txtfirstname.Text = String.Empty Or txtSurname.Text = String.Empty Or txtAge.Text = String.Empty Or cmbSex.Text = String.Empty Or txtContactNo.Text = String.Empty Or txtRegUsername.Text = String.Empty Or txtRegPassword.Text = String.Empty Or txtReenter.Text = String.Empty Then
                MessageBox.Show("Please enter chuchu....") 'prompt to complete the details

            ElseIf (txtRegPassword.Text <> txtReenter.Text) Then
                MessageBox.Show("Password doesn't match.") 'not match
                txtRegPassword.Text = ""
                txtReenter.Text = ""
                txtPassword.Select()
            Else
                sqlQuery = "INSERT into javadatabase.tbl_user(Firstname, Surname, Age, ContactNumber, Sex, Username, Password) 
            value('" & txtFirstname.Text & "','" & txtSurname.Text & "','" & txtAge.Text & "','" & txtContactNo.Text & "','" & cmbSex.Text & "','" & txtRegUsername.Text & "','" & txtRegPassword.Text & "')"
                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
                sqlReader = sqlCmd.ExecuteReader

                MessageBox.Show("Account Created Successfully.")
                pnlRegister.Visible = False
                cbShowPassword.Visible = True
                reset()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try
    End Sub

    Private Sub cbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPassword.CheckedChanged

        If cbShowPassword.CheckState = CheckState.Checked Then
            txtPassword.UseSystemPasswordChar = False   'if true, shows the text
        Else
            txtPassword.UseSystemPasswordChar = True    'if false, hides the text
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
        txtRegPassword.UseSystemPasswordChar = True
        txtReenter.UseSystemPasswordChar = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to exit?", "MySQL Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub cbRegShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbRegShowPass.CheckedChanged

        If cbRegShowPass.CheckState = CheckState.Checked Then
            txtRegPassword.UseSystemPasswordChar = False
            txtReenter.UseSystemPasswordChar = False
        Else
            txtRegPassword.UseSystemPasswordChar = True
            txtReenter.UseSystemPasswordChar = True
        End If
    End Sub

End Class
