Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDate.Text = DateTime.Now.ToLongDateString
        Timer1.Start()

        cbC1.Checked = False
        cbC2.Checked = False
        cbC3.Checked = False
        cbC4.Checked = False
        cbC5.Checked = False
        cbC6.Checked = False
        cbC7.Checked = False

        cbNC1.Checked = False
        cbNC2.Checked = False
        cbNC3.Checked = False
        cbNC4.Checked = False
        cbNC5.Checked = False
        cbNC6.Checked = False
        cbNC7.Checked = False

        cbS1.Checked = False
        cbS2.Checked = False
        cbS3.Checked = False
        cbS4.Checked = False

        cbF1.Checked = False
        cbF2.Checked = False
        cbF3.Checked = False
        cbF4.Checked = False
        cbF5.Checked = False
        cbF6.Checked = False
        cbF7.Checked = False

        cbCK1.Checked = False
        cbCK2.Checked = False
        cbCK3.Checked = False
        cbCK4.Checked = False
        cbCK5.Checked = False
        cbCK6.Checked = False
        cbCK7.Checked = False
        cbCK8.Checked = False

        numC1.Enabled = False
        numC2.Enabled = False
        numC3.Enabled = False
        numC4.Enabled = False
        numC5.Enabled = False
        numC6.Enabled = False
        numC7.Enabled = False

        numNC1.Enabled = False
        numNC2.Enabled = False
        numNC3.Enabled = False
        numNC4.Enabled = False
        numNC5.Enabled = False
        numNC6.Enabled = False
        numNC7.Enabled = False

        numS1.Enabled = False
        numS2.Enabled = False
        numS3.Enabled = False
        numS4.Enabled = False

        numF1.Enabled = False
        numF2.Enabled = False
        numF3.Enabled = False
        numF4.Enabled = False
        numF5.Enabled = False
        numF6.Enabled = False
        numF7.Enabled = False

        numCK1.Enabled = False
        numCK2.Enabled = False
        numCK3.Enabled = False
        numCK4.Enabled = False
        numCK5.Enabled = False
        numCK6.Enabled = False
        numCK7.Enabled = False
        numCK8.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub cbC1_CheckedChanged(sender As Object, e As EventArgs) Handles cbC1.CheckedChanged
        If (cbC1.Checked = True) Then
            numC1.Enabled = True
            numC1.Value = 1
        ElseIf (cbC1.Checked = False) Then
            numC1.Enabled = False
            numC1.Value = 0
        End If
    End Sub

    Private Sub cbC2_CheckedChanged(sender As Object, e As EventArgs) Handles cbC2.CheckedChanged
        If (cbC2.Checked = True) Then
            numC2.Enabled = True
            numC2.Value = 1
        ElseIf (cbC2.Checked = False) Then
            numC2.Enabled = False
            numC2.Value = 0
        End If
    End Sub

    Private Sub cbC3_CheckedChanged(sender As Object, e As EventArgs) Handles cbC3.CheckedChanged
        If (cbC3.Checked = True) Then
            numC3.Enabled = True
            numC3.Value = 1
        ElseIf (cbC3.Checked = False) Then
            numC3.Enabled = False
            numC3.Value = 0
        End If
    End Sub

    Private Sub cbC4_CheckedChanged(sender As Object, e As EventArgs) Handles cbC4.CheckedChanged
        If (cbC4.Checked = True) Then
            numC4.Enabled = True
            numC4.Value = 1
        ElseIf (cbC4.Checked = False) Then
            numC4.Enabled = False
            numC4.Value = 0
        End If
    End Sub

    Private Sub cbC5_CheckedChanged(sender As Object, e As EventArgs) Handles cbC5.CheckedChanged
        If (cbC5.Checked = True) Then
            numC5.Enabled = True
            numC5.Value = 1
        ElseIf (cbC5.Checked = False) Then
            numC5.Enabled = False
            numC5.Value = 0
        End If
    End Sub

    Private Sub cbC6_CheckedChanged(sender As Object, e As EventArgs) Handles cbC6.CheckedChanged
        If (cbC6.Checked = True) Then
            numC6.Enabled = True
            numC6.Value = 1
        ElseIf (cbC6.Checked = False) Then
            numC6.Enabled = False
            numC6.Value = 0
        End If
    End Sub

    Private Sub cbC7_CheckedChanged(sender As Object, e As EventArgs) Handles cbC7.CheckedChanged
        If (cbC7.Checked = True) Then
            numC7.Enabled = True
            numC7.Value = 1
        ElseIf (cbC7.Checked = False) Then
            numC7.Enabled = False
            numC7.Value = 0
        End If
    End Sub

    Private Sub cbNC1_CheckedChanged(sender As Object, e As EventArgs) Handles cbNC1.CheckedChanged
        If (cbNC1.Checked = True) Then
            numNC1.Enabled = True
            numNC1.Value = 1
        ElseIf (cbNC1.Checked = False) Then
            numNC1.Enabled = False
            numNC1.Value = 0
        End If
    End Sub

    Private Sub cbNC2_CheckedChanged(sender As Object, e As EventArgs) Handles cbNC2.CheckedChanged
        If (cbNC2.Checked = True) Then
            numNC2.Enabled = True
            numNC2.Value = 1
        ElseIf (cbNC2.Checked = False) Then
            numNC2.Enabled = False
            numNC2.Value = 0
        End If
    End Sub

    Private Sub cbNC3_CheckedChanged(sender As Object, e As EventArgs) Handles cbNC3.CheckedChanged
        If (cbNC3.Checked = True) Then
            numNC3.Enabled = True
            numNC3.Value = 1
        ElseIf (cbNC3.Checked = False) Then
            numNC3.Enabled = False
            numNC3.Value = 0
        End If
    End Sub

    Private Sub cbNC4_CheckedChanged(sender As Object, e As EventArgs) Handles cbNC4.CheckedChanged
        If (cbNC4.Checked = True) Then
            numNC4.Enabled = True
            numNC4.Value = 1
        ElseIf (cbNC4.Checked = False) Then
            numNC4.Enabled = False
            numNC4.Value = 0
        End If
    End Sub

    Private Sub cbNC5_CheckedChanged(sender As Object, e As EventArgs) Handles cbNC5.CheckedChanged
        If (cbNC5.Checked = True) Then
            numNC5.Enabled = True
            numNC5.Value = 1
        ElseIf (cbNC5.Checked = False) Then
            numNC5.Enabled = False
            numNC5.Value = 0
        End If
    End Sub

    Private Sub cbNC6_CheckedChanged(sender As Object, e As EventArgs) Handles cbNC6.CheckedChanged
        If (cbNC6.Checked = True) Then
            numNC6.Enabled = True
            numNC6.Value = 1
        ElseIf (cbNC6.Checked = False) Then
            numNC6.Enabled = False
            numNC6.Value = 0
        End If
    End Sub

    Private Sub cbNC7_CheckedChanged(sender As Object, e As EventArgs) Handles cbNC7.CheckedChanged
        If (cbNC7.Checked = True) Then
            numNC7.Enabled = True
            numNC7.Value = 1
        ElseIf (cbNC7.Checked = False) Then
            numNC7.Enabled = False
            numNC7.Value = 0
        End If
    End Sub

    Private Sub cbS1_CheckedChanged(sender As Object, e As EventArgs) Handles cbS1.CheckedChanged
        If (cbS1.Checked = True) Then
            numS1.Enabled = True
            numS1.Value = 1
        ElseIf (cbS1.Checked = False) Then
            numS1.Enabled = False
            numS1.Value = 0
        End If
    End Sub

    Private Sub cbS2_CheckedChanged(sender As Object, e As EventArgs) Handles cbS2.CheckedChanged
        If (cbS2.Checked = True) Then
            numS2.Enabled = True
            numS2.Value = 1
        ElseIf (cbS2.Checked = False) Then
            numS2.Enabled = False
            numS2.Value = 0
        End If
    End Sub

    Private Sub cbS3_CheckedChanged(sender As Object, e As EventArgs) Handles cbS3.CheckedChanged
        If (cbS3.Checked = True) Then
            numS3.Enabled = True
            numS3.Value = 1
        ElseIf (cbS3.Checked = False) Then
            numS3.Enabled = False
            numS3.Value = 0
        End If
    End Sub

    Private Sub cbS4_CheckedChanged(sender As Object, e As EventArgs) Handles cbS4.CheckedChanged
        If (cbS4.Checked = True) Then
            numS4.Enabled = True
            numS4.Value = 1
        ElseIf (cbS4.Checked = False) Then
            numS4.Enabled = False
            numS4.Value = 0
        End If
    End Sub

    Private Sub cbF1_CheckedChanged(sender As Object, e As EventArgs) Handles cbF1.CheckedChanged
        If (cbF1.Checked = True) Then
            numF1.Enabled = True
            numF1.Value = 1
        ElseIf (cbF1.Checked = False) Then
            numF1.Enabled = False
            numF1.Value = 0
        End If
    End Sub

    Private Sub cbF2_CheckedChanged(sender As Object, e As EventArgs) Handles cbF2.CheckedChanged
        If (cbF2.Checked = True) Then
            numF2.Enabled = True
            numF2.Value = 1
        ElseIf (cbF2.Checked = False) Then
            numF2.Enabled = False
            numF2.Value = 0
        End If
    End Sub

    Private Sub cbF3_CheckedChanged(sender As Object, e As EventArgs) Handles cbF3.CheckedChanged
        If (cbF3.Checked = True) Then
            numF3.Enabled = True
            numF3.Value = 1
        ElseIf (cbF3.Checked = False) Then
            numF3.Enabled = False
            numF3.Value = 0
        End If
    End Sub

    Private Sub cbF4_CheckedChanged(sender As Object, e As EventArgs) Handles cbF4.CheckedChanged
        If (cbF4.Checked = True) Then
            numF4.Enabled = True
            numF4.Value = 1
        ElseIf (cbF4.Checked = False) Then
            numF4.Enabled = False
            numF4.Value = 0
        End If
    End Sub

    Private Sub cbF5_CheckedChanged(sender As Object, e As EventArgs) Handles cbF5.CheckedChanged
        If (cbF5.Checked = True) Then
            numF5.Enabled = True
            numF5.Value = 1
        ElseIf (cbF5.Checked = False) Then
            numF5.Enabled = False
            numF5.Value = 0
        End If
    End Sub

    Private Sub cbF6_CheckedChanged(sender As Object, e As EventArgs) Handles cbF6.CheckedChanged
        If (cbF6.Checked = True) Then
            numF6.Enabled = True
            numF6.Value = 1
        ElseIf (cbF6.Checked = False) Then
            numF6.Enabled = False
            numF6.Value = 0
        End If
    End Sub

    Private Sub cbF7_CheckedChanged(sender As Object, e As EventArgs) Handles cbF7.CheckedChanged
        If (cbF7.Checked = True) Then
            numF7.Enabled = True
            numF7.Value = 1
        ElseIf (cbF7.Checked = False) Then
            numF7.Enabled = False
            numF7.Value = 0
        End If
    End Sub

    Private Sub cbCK1_CheckedChanged(sender As Object, e As EventArgs) Handles cbCK1.CheckedChanged
        If (cbCK1.Checked = True) Then
            numCK1.Enabled = True
            numCK1.Value = 1
        ElseIf (cbCK1.Checked = False) Then
            numCK1.Enabled = False
            numCK1.Value = 0
        End If
    End Sub

    Private Sub cbCK2_CheckedChanged(sender As Object, e As EventArgs) Handles cbCK2.CheckedChanged
        If (cbCK2.Checked = True) Then
            numCK2.Enabled = True
            numCK2.Value = 1
        ElseIf (cbCK2.Checked = False) Then
            numCK2.Enabled = False
            numCK2.Value = 0
        End If
    End Sub

    Private Sub cbCK3_CheckedChanged(sender As Object, e As EventArgs) Handles cbCK3.CheckedChanged
        If (cbCK3.Checked = True) Then
            numCK3.Enabled = True
            numCK3.Value = 1
        ElseIf (cbCK3.Checked = False) Then
            numCK3.Enabled = False
            numCK3.Value = 0
        End If
    End Sub

    Private Sub cbCK4_CheckedChanged(sender As Object, e As EventArgs) Handles cbCK4.CheckedChanged
        If (cbCK4.Checked = True) Then
            numCK4.Enabled = True
            numCK4.Value = 1
        ElseIf (cbCK4.Checked = False) Then
            numCK4.Enabled = False
            numCK4.Value = 0
        End If
    End Sub

    Private Sub cbCK5_CheckedChanged(sender As Object, e As EventArgs) Handles cbCK5.CheckedChanged
        If (cbCK5.Checked = True) Then
            numCK5.Enabled = True
            numCK5.Value = 1
        ElseIf (cbCK5.Checked = False) Then
            numCK5.Enabled = False
            numCK5.Value = 0
        End If
    End Sub

    Private Sub cbCK6_CheckedChanged(sender As Object, e As EventArgs) Handles cbCK6.CheckedChanged
        If (cbCK6.Checked = True) Then
            numCK6.Enabled = True
            numCK6.Value = 1
        ElseIf (cbCK6.Checked = False) Then
            numCK6.Enabled = False
            numCK6.Value = 0
        End If
    End Sub

    Private Sub cbCK7_CheckedChanged(sender As Object, e As EventArgs) Handles cbCK7.CheckedChanged
        If (cbCK7.Checked = True) Then
            numCK7.Enabled = True
            numCK7.Value = 1
        ElseIf (cbCK7.Checked = False) Then
            numCK7.Enabled = False
            numCK7.Value = 0
        End If
    End Sub

    Private Sub cbCK8_CheckedChanged(sender As Object, e As EventArgs) Handles cbCK8.CheckedChanged
        If (cbCK8.Checked = True) Then
            numCK8.Enabled = True
            numCK8.Value = 1
        ElseIf (cbCK8.Checked = False) Then
            numCK8.Enabled = False
            numCK8.Value = 0
        End If
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click

        cbC1.Checked = False
        cbC2.Checked = False
        cbC3.Checked = False
        cbC4.Checked = False
        cbC5.Checked = False
        cbC6.Checked = False
        cbC7.Checked = False

        cbNC1.Checked = False
        cbNC2.Checked = False
        cbNC3.Checked = False
        cbNC4.Checked = False
        cbNC5.Checked = False
        cbNC6.Checked = False
        cbNC7.Checked = False

        cbS1.Checked = False
        cbS2.Checked = False
        cbS3.Checked = False
        cbS4.Checked = False

        cbF1.Checked = False
        cbF2.Checked = False
        cbF3.Checked = False
        cbF4.Checked = False
        cbF5.Checked = False
        cbF6.Checked = False
        cbF7.Checked = False

        cbCK1.Checked = False
        cbCK2.Checked = False
        cbCK3.Checked = False
        cbCK4.Checked = False
        cbCK5.Checked = False
        cbCK6.Checked = False
        cbCK7.Checked = False
        cbCK8.Checked = False

        numC1.Enabled = False
        numC2.Enabled = False
        numC3.Enabled = False
        numC4.Enabled = False
        numC5.Enabled = False
        numC6.Enabled = False
        numC7.Enabled = False

        numNC1.Enabled = False
        numNC2.Enabled = False
        numNC3.Enabled = False
        numNC4.Enabled = False
        numNC5.Enabled = False
        numNC6.Enabled = False
        numNC7.Enabled = False

        numS1.Enabled = False
        numS2.Enabled = False
        numS3.Enabled = False
        numS4.Enabled = False

        numF1.Enabled = False
        numF2.Enabled = False
        numF3.Enabled = False
        numF4.Enabled = False
        numF5.Enabled = False
        numF6.Enabled = False
        numF7.Enabled = False

        numCK1.Enabled = False
        numCK2.Enabled = False
        numCK3.Enabled = False
        numCK4.Enabled = False
        numCK5.Enabled = False
        numCK6.Enabled = False
        numCK7.Enabled = False
        numCK8.Enabled = False
    End Sub
End Class