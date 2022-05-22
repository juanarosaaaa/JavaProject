Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Public Class Menu
    Public Property passValue As String
    Private Sub reset()

        ' reset the checkboxes and numUpDown
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
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' hide the panel for sign up panel
        pnlReceipt.Visible = False

        ' display the date
        lblDate.Text = DateTime.Now.ToLongDateString
        Timer1.Start()
        reset()
        'pass the username from loginform
        lblUser.Text = passValue

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' display the time
        lblTime.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub cbC1_CheckedChanged(sender As Object, e As EventArgs) Handles cbC1.CheckedChanged
        ' enable and disable the numeric up and down tool

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

    Private Sub picReset_Click(sender As Object, e As EventArgs) Handles picReset.Click
        reset()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click


        tabMenu.Visible = False
        btnDone.Visible = False
        picReset.Visible = False
        lblMenu.Text = "Receipt"
        pnlReceipt.Visible = True
        rtbReceipt.Clear()

        ' mga nakalagay sa receipt
        rtbReceipt.AppendText(vbTab + vbTab + "     CASH RECEIPT" + Environment.NewLine)
        rtbReceipt.AppendText(vbTab + vbTab + "             JAVA" + Environment.NewLine)
        rtbReceipt.AppendText(vbTab + "         Address: Malvar, Batangas" + Environment.NewLine)
        rtbReceipt.AppendText(vbTab + "                 Tel #: 043-123-4567" + Environment.NewLine)
        rtbReceipt.AppendText("--------------------------------------------------------------------------" + Environment.NewLine)
        rtbReceipt.AppendText("Customer: " & lblUser.Text & Environment.NewLine)
        rtbReceipt.AppendText("Date: " & lblDate.Text & vbTab & lblTime.Text & Environment.NewLine)
        rtbReceipt.AppendText("==========================================" + Environment.NewLine)
        rtbReceipt.AppendText("Order Details: " + Environment.NewLine)
        rtbReceipt.AppendText(Environment.NewLine + "PRODUCTS" + vbTab + "PRICE" + vbTab + vbTab + "QTY" + vbTab + "AMOUNT" + Environment.NewLine)
        rtbReceipt.AppendText("--------------------------------------------------------------------------" + Environment.NewLine)

        'espresso
        If cbC1.Checked = True Then
            Dim qtyC1, orPriceC1, priceC1 As Integer
            qtyC1 = numC1.Value
            orPriceC1 = 75
            priceC1 = orPriceC1 * qtyC1
            Me.dgvOrder.Rows.Add(cbC1.Text, qtyC1, priceC1)
            rtbReceipt.AppendText(cbC1.Text & vbTab & orPriceC1 & vbTab & vbTab & qtyC1 & vbTab & priceC1 & Environment.NewLine)
        End If

        'americano
        If cbC2.Checked = True Then
            Dim qtyC2, orPriceC2, priceC2 As Integer
            qtyC2 = numC2.Value
            orPriceC2 = 85
            priceC2 = orPriceC2 * qtyC2
            Me.dgvOrder.Rows.Add(cbC2.Text, qtyC2, priceC2)
            rtbReceipt.AppendText(cbC2.Text & vbTab & orPriceC2 & vbTab & vbTab & qtyC2 & vbTab & priceC2 & Environment.NewLine)
        End If
        'latte
        If cbC3.Checked = True Then
            Dim qtyC3, orPriceC3, priceC3 As Integer
            qtyC3 = numC3.Value
            orPriceC3 = 95
            priceC3 = orPriceC3 * qtyC3
            Me.dgvOrder.Rows.Add(cbC3.Text, qtyC3, priceC3)
            rtbReceipt.AppendText(cbC3.Text & vbTab & vbTab & orPriceC3 & vbTab & vbTab & qtyC3 & vbTab & priceC3 & Environment.NewLine)
        End If
        'cappucino
        If cbC4.Checked = True Then
            Dim qtyC4, orPriceC4, priceC4 As Integer
            qtyC4 = numC4.Value
            orPriceC4 = 95
            priceC4 = orPriceC4 * qtyC4
            Me.dgvOrder.Rows.Add(cbC4.Text, qtyC4, priceC4)
            rtbReceipt.AppendText(cbC4.Text & vbTab & orPriceC4 & vbTab & vbTab & qtyC4 & vbTab & priceC4 & Environment.NewLine)
        End If
        'caramel machiato
        If cbC5.Checked = True Then
            Dim qtyC5, orPriceC5, priceC5 As Integer
            qtyC5 = numC5.Value
            orPriceC5 = 95
            priceC5 = orPriceC5 * qtyC5
            Me.dgvOrder.Rows.Add(cbC5.Text, qtyC5, priceC5)
            rtbReceipt.AppendText(cbC5.Text & vbTab & orPriceC5 & vbTab & vbTab & qtyC5 & vbTab & priceC5 & Environment.NewLine)
        End If
        'white mocha 
        If cbC6.Checked = True Then
            Dim qtyC6, orPriceC6, priceC6 As Integer
            qtyC6 = numC6.Value
            orPriceC6 = 95
            priceC6 = orPriceC6 * qtyC6
            Me.dgvOrder.Rows.Add(cbC6.Text, qtyC6, priceC6)
            rtbReceipt.AppendText(cbC6.Text & vbTab & vbTab & orPriceC6 & vbTab & vbTab & qtyC6 & vbTab & priceC6 & Environment.NewLine)
        End If
        'drip coffee
        If cbC7.Checked = True Then
            Dim qtyC7, orPriceC7, priceC7 As Integer
            qtyC7 = numC7.Value
            orPriceC7 = 180
            priceC7 = orPriceC7 * qtyC7
            Me.dgvOrder.Rows.Add(cbC7.Text, qtyC7, priceC7)
            rtbReceipt.AppendText(cbC7.Text & vbTab & orPriceC7 & vbTab & vbTab & qtyC7 & vbTab & priceC7 & Environment.NewLine)
        End If
        '--------------------------------------------------------------
        'chocolate
        If cbNC1.Checked = True Then
            Dim qtyNC1, orPriceNC1, priceNC1 As Integer
            qtyNC1 = numNC1.Value
            orPriceNC1 = 80
            priceNC1 = orPriceNC1 * qtyNC1
            Me.dgvOrder.Rows.Add(cbNC1.Text, qtyNC1, priceNC1)
            rtbReceipt.AppendText(cbNC1.Text & vbTab & orPriceNC1 & vbTab & vbTab & qtyNC1 & vbTab & priceNC1 & Environment.NewLine)
        End If
        'jasmin green tea
        If cbNC2.Checked = True Then
            Dim qtyNC2, orPriceNC2, priceNC2 As Integer
            qtyNC2 = numNC2.Value
            orPriceNC2 = 90
            priceNC2 = orPriceNC2 * qtyNC2
            Me.dgvOrder.Rows.Add(cbNC2.Text, qtyNC2, priceNC2)
            rtbReceipt.AppendText(cbNC2.Text & vbTab & orPriceNC2 & vbTab & vbTab & qtyNC2 & vbTab & priceNC2 & Environment.NewLine)
        End If
        'lemon ginger tea
        If cbNC3.Checked = True Then
            Dim qtyNC3, orPriceNC3, priceNC3 As Integer
            qtyNC3 = numNC3.Value
            orPriceNC3 = 120
            priceNC3 = orPriceNC3 * qtyNC3
            Me.dgvOrder.Rows.Add(cbNC3.Text, qtyNC3, priceNC3)
            rtbReceipt.AppendText(cbNC3.Text & vbTab & orPriceNC3 & vbTab & vbTab & qtyNC3 & vbTab & priceNC3 & Environment.NewLine)
        End If
        'earl gray tea
        If cbNC4.Checked = True Then
            Dim qtyNC4, orPriceNC4, priceNC4 As Integer
            qtyNC4 = numNC4.Value
            orPriceNC4 = 90
            priceNC4 = orPriceNC4 * qtyNC4
            Me.dgvOrder.Rows.Add(cbNC4.Text, qtyNC4, priceNC4)
            rtbReceipt.AppendText(cbNC4.Text & vbTab & orPriceNC4 & vbTab & vbTab & qtyNC4 & vbTab & priceNC4 & Environment.NewLine)
        End If
        'peppermint tea
        If cbNC5.Checked = True Then
            Dim qtyNC5, orPriceNC5, priceNC5 As Integer
            qtyNC5 = numNC5.Value
            orPriceNC5 = 90
            priceNC5 = orPriceNC5 * qtyNC5
            Me.dgvOrder.Rows.Add(cbNC5.Text, qtyNC5, priceNC5)
            rtbReceipt.AppendText(cbNC5.Text & vbTab & vbTab & orPriceNC5 & vbTab & vbTab & qtyNC5 & vbTab & priceNC5 & Environment.NewLine)
        End If
        'almond milk
        If cbNC6.Checked = True Then
            Dim qtyNC6, orPriceNC6, priceNC6 As Integer
            qtyNC6 = numNC6.Value
            orPriceNC6 = 60
            priceNC6 = orPriceNC6 * qtyNC6
            Me.dgvOrder.Rows.Add(cbNC6.Text, qtyNC6, priceNC6)
            rtbReceipt.AppendText(cbNC6.Text & vbTab & vbTab & orPriceNC6 & vbTab & vbTab & qtyNC6 & vbTab & priceNC6 & Environment.NewLine)
        End If
        'fresh milk
        If cbNC7.Checked = True Then
            Dim qtyNC7, orPriceNC7, priceNC7 As Integer
            qtyNC7 = numNC1.Value
            orPriceNC7 = 50
            priceNC7 = orPriceNC7 * qtyNC7
            Me.dgvOrder.Rows.Add(cbNC7.Text, qtyNC7, priceNC7)
            rtbReceipt.AppendText(cbNC7.Text & vbTab & orPriceNC7 & vbTab & vbTab & qtyNC7 & vbTab & priceNC7 & Environment.NewLine)
        End If

        '------------------------------------------------------------
        'strawberry
        If cbS1.Checked = True Then
            Dim qtyS1, orPriceS1, priceS1 As Integer
            qtyS1 = numS1.Value
            orPriceS1 = 130
            priceS1 = orPriceS1 * qtyS1
            Me.dgvOrder.Rows.Add(cbS1.Text, qtyS1, priceS1)
            rtbReceipt.AppendText(cbS1.Text & vbTab & orPriceS1 & vbTab & vbTab & qtyS1 & vbTab & priceS1 & Environment.NewLine)
        End If
        'lychee
        If cbS2.Checked = True Then
            Dim qtyS2, orPriceS2, priceS2 As Integer
            qtyS2 = numS2.Value
            orPriceS2 = 120
            priceS2 = orPriceS2 * qtyS2
            Me.dgvOrder.Rows.Add(cbS2.Text, qtyS2, priceS2)
            rtbReceipt.AppendText(cbS2.Text & vbTab & vbTab & orPriceS2 & vbTab & vbTab & qtyS2 & vbTab & priceS2 & Environment.NewLine)
        End If
        'lemon
        If cbS3.Checked = True Then
            Dim qtyS3, orPriceS3, priceS3 As Integer
            qtyS3 = numS3.Value
            orPriceS3 = 85
            priceS3 = orPriceS3 * qtyS3
            Me.dgvOrder.Rows.Add(cbS3.Text, qtyS3, priceS3)
            rtbReceipt.AppendText(cbS3.Text & vbTab & vbTab & orPriceS3 & vbTab & vbTab & qtyS3 & vbTab & priceS3 & Environment.NewLine)
        End If
        'mango
        If cbS4.Checked = True Then
            Dim qtyS4, orPriceS4, priceS4 As Integer
            qtyS4 = numS4.Value
            orPriceS4 = 130
            priceS4 = orPriceS4 * qtyS4
            Me.dgvOrder.Rows.Add(cbS4.Text, qtyS4, priceS4)
            rtbReceipt.AppendText(cbS4.Text & vbTab & vbTab & orPriceS4 & vbTab & vbTab & qtyS4 & vbTab & priceS4 & Environment.NewLine)
        End If

        '-------------------------------------
        'coffee jelly
        If cbF1.Checked = True Then
            Dim qtyF1, orPriceF1, priceF1 As Integer
            qtyF1 = numF1.Value
            orPriceF1 = 135
            priceF1 = orPriceF1 * qtyF1
            Me.dgvOrder.Rows.Add(cbF1.Text, qtyF1, priceF1)
            rtbReceipt.AppendText(cbF1.Text & vbTab & orPriceF1 & vbTab & vbTab & qtyF1 & vbTab & priceF1 & Environment.NewLine)
        End If
        'java chip
        If cbF2.Checked = True Then
            Dim qtyF2, orPriceF2, priceF2 As Integer
            qtyF2 = numF2.Value
            orPriceF2 = 140
            priceF2 = orPriceF2 * qtyF2
            Me.dgvOrder.Rows.Add(cbF2.Text, qtyF2, priceF2)
            rtbReceipt.AppendText(cbF2.Text & vbTab & orPriceF2 & vbTab & vbTab & qtyF2 & vbTab & priceF2 & Environment.NewLine)
        End If
        'cookies n cream
        If cbF3.Checked = True Then
            Dim qtyF3, orPriceF3, priceF3 As Integer
            qtyF3 = numF3.Value
            orPriceF3 = 145
            priceF3 = orPriceF3 * qtyF3
            Me.dgvOrder.Rows.Add(cbF3.Text, qtyF3, priceF3)
            rtbReceipt.AppendText(cbF3.Text & vbTab & vbTab & orPriceF3 & vbTab & vbTab & qtyF3 & vbTab & priceF3 & Environment.NewLine)
        End If
        'salted caramel
        If cbF4.Checked = True Then
            Dim qtyF4, orPriceF4, priceF4 As Integer
            qtyF4 = numF4.Value
            orPriceF4 = 145
            priceF4 = orPriceF4 * qtyF4
            Me.dgvOrder.Rows.Add(cbF4.Text, qtyF4, priceF4)
            rtbReceipt.AppendText(cbF4.Text & vbTab & vbTab & orPriceF4 & vbTab & vbTab & qtyF4 & vbTab & priceF4 & Environment.NewLine)
        End If
        'matcha
        If cbF5.Checked = True Then
            Dim qtyF5, orPriceF5, priceF5 As Integer
            qtyF5 = numF1.Value
            orPriceF5 = 150
            priceF5 = orPriceF5 * qtyF5
            Me.dgvOrder.Rows.Add(cbF5.Text, qtyF5, priceF5)
            rtbReceipt.AppendText(cbF5.Text & vbTab & vbTab & orPriceF5 & vbTab & vbTab & qtyF5 & vbTab & priceF5 & Environment.NewLine)
        End If
        'chocolate chip
        If cbF6.Checked = True Then
            Dim qtyF6, orPriceF6, priceF6 As Integer
            qtyF6 = numF6.Value
            orPriceF6 = 130
            priceF6 = orPriceF6 * qtyF6
            Me.dgvOrder.Rows.Add(cbF6.Text, qtyF6, priceF6)
            rtbReceipt.AppendText(cbF6.Text & vbTab & vbTab & orPriceF6 & vbTab & vbTab & qtyF6 & vbTab & priceF6 & Environment.NewLine)
        End If
        'dark chocolate
        If cbF7.Checked = True Then
            Dim qtyF7, orPriceF7, priceF7 As Integer
            qtyF7 = numF7.Value
            orPriceF7 = 130
            priceF7 = orPriceF7 * qtyF7
            Me.dgvOrder.Rows.Add(cbF7.Text, qtyF7, priceF7)
            rtbReceipt.AppendText(cbF7.Text & vbTab & orPriceF7 & vbTab & vbTab & qtyF7 & vbTab & priceF7 & Environment.NewLine)
        End If

        '---------------------------------------------------
        'chocolate cake
        If cbCK1.Checked = True Then
            Dim qtyCK1, orPriceCK1, priceCK1 As Integer
            qtyCK1 = numCK1.Value
            orPriceCK1 = 115
            priceCK1 = orPriceCK1 * qtyCK1
            Me.dgvOrder.Rows.Add(cbCK1.Text, qtyCK1, priceCK1)
            rtbReceipt.AppendText(cbCK1.Text & vbTab & vbTab & orPriceCK1 & vbTab & vbTab & qtyCK1 & vbTab & priceCK1 & Environment.NewLine)
        End If
        'blueberry cake
        If cbCK2.Checked = True Then
            Dim qtyCK2, orPriceCK2, priceCK2 As Integer
            qtyCK2 = numCK2.Value
            orPriceCK2 = 215
            priceCK2 = orPriceCK2 * qtyCK2
            Me.dgvOrder.Rows.Add(cbCK2.Text, qtyCK2, priceCK2)
            rtbReceipt.AppendText(cbCK2.Text & vbTab & vbTab & orPriceCK2 & vbTab & vbTab & qtyCK2 & vbTab & priceCK2 & Environment.NewLine)
        End If
        'strawberry cake
        If cbCK3.Checked = True Then
            Dim qtyCK3, orPriceCK3, priceCK3 As Integer
            qtyCK3 = numCK3.Value
            orPriceCK3 = 170
            priceCK3 = orPriceCK3 * qtyCK3
            Me.dgvOrder.Rows.Add(cbCK3.Text, qtyCK3, priceCK3)
            rtbReceipt.AppendText(cbCK3.Text & vbTab & vbTab & orPriceCK3 & vbTab & vbTab & qtyCK3 & vbTab & priceCK3 & Environment.NewLine)
        End If
        'red velvet cake
        If cbCK4.Checked = True Then
            Dim qtyCK4, orPriceCK4, priceCK4 As Integer
            qtyCK4 = numCK4.Value
            orPriceCK4 = 180
            priceCK4 = orPriceCK4 * qtyCK4
            Me.dgvOrder.Rows.Add(cbCK4.Text, qtyCK4, priceCK4)
            rtbReceipt.AppendText(cbCK4.Text & vbTab & vbTab & orPriceCK4 & vbTab & vbTab & qtyCK4 & vbTab & priceCK4 & Environment.NewLine)
        End If
        'carrot cake
        If cbCK5.Checked = True Then
            Dim qtyCK5, orPriceCK5, priceCK5 As Integer
            qtyCK5 = numCK5.Value
            orPriceCK5 = 115
            priceCK5 = orPriceCK5 * qtyCK5
            Me.dgvOrder.Rows.Add(cbCK5.Text, qtyCK5, priceCK5)
            rtbReceipt.AppendText(cbCK5.Text & vbTab & orPriceCK5 & vbTab & vbTab & qtyCK5 & vbTab & priceCK5 & Environment.NewLine)
        End If
        'sponge cake
        If cbCK6.Checked = True Then
            Dim qtyCK6, orPriceCK6, priceCK6 As Integer
            qtyCK6 = numCK6.Value
            orPriceCK6 = 115
            priceCK6 = orPriceCK6 * qtyCK6
            Me.dgvOrder.Rows.Add(cbCK6.Text, qtyCK6, priceCK6)
            rtbReceipt.AppendText(cbCK6.Text & vbTab & orPriceCK6 & vbTab & vbTab & qtyCK6 & vbTab & priceCK6 & Environment.NewLine)
        End If
        'cupcake
        If cbCK7.Checked = True Then
            Dim qtyCK7, orPriceCK7, priceCK7 As Integer
            qtyCK7 = numCK7.Value
            orPriceCK7 = 125
            priceCK7 = orPriceCK7 * qtyCK7
            Me.dgvOrder.Rows.Add(cbCK7.Text, qtyCK7, priceCK7)
            rtbReceipt.AppendText(cbCK7.Text & vbTab & orPriceCK7 & vbTab & vbTab & qtyCK7 & vbTab & priceCK7 & Environment.NewLine)
        End If
        'tiramisu
        If cbCK8.Checked = True Then
            Dim qtyCK8, orPriceCK8, priceCK8 As Integer
            qtyCK8 = numCK8.Value
            orPriceCK8 = 125
            priceCK8 = orPriceCK8 * qtyCK8
            Me.dgvOrder.Rows.Add(cbCK8.Text, qtyCK8, priceCK8)
            rtbReceipt.AppendText(cbCK8.Text & vbTab & orPriceCK8 & vbTab & vbTab & qtyCK8 & vbTab & priceCK8 & Environment.NewLine)
        End If

        'total the amounts
        Dim total As Decimal = 0
        For Each R As DataGridViewRow In dgvOrder.Rows
            total += R.Cells(2).Value
        Next
        lblTotal.Text = total

        rtbReceipt.AppendText("==========================================" + Environment.NewLine)
        rtbReceipt.AppendText(vbTab & vbTab & vbTab & "TOTAL:" & vbTab & vbTab & lblTotal.Text & Environment.NewLine)
        rtbReceipt.AppendText(Environment.NewLine & Environment.NewLine & Environment.NewLine)
        rtbReceipt.AppendText(vbTab & "     THANK YOU FOR PURCHASING!     " & Environment.NewLine)

    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        dgvOrder.Rows.Clear()
        tabMenu.Visible = True
        btnDone.Visible = True
        picReset.Visible = True
        lblMenu.Text = "Menu"
        pnlReceipt.Visible = False
        reset()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        dgvOrder.Rows.Clear()
        tabMenu.Visible = True
        btnDone.Visible = True
        picReset.Visible = True
        lblMenu.Text = "Menu"
        pnlReceipt.Visible = False
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(rtbReceipt.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 120, 120)
    End Sub

    Private Sub btnbSignOut_Click(sender As Object, e As EventArgs) Handles btnbSignOut.Click
        reset()
        Dim backLogin As New LoginForm
        backLogin.Show()
        Me.Hide()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveFileDialog1.Filter = "TXT Files (*.txt)|*.txt"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, rtbReceipt.Text, True)
        End If
    End Sub
End Class