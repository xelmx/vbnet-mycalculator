Public Class frmMyCalCu

    'Dim firstNumber, secondNumber As Double
    Dim secondNumber As Double
    Dim currentInput As Double = 0

    Dim opt As String
    Dim optSelect As Boolean = False


    Private Sub operator_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnSubtract.Click, btnMultiply.Click, btnModulus.Click, btnDivide.Click
        Dim btn As Button = sender


        If currentInput <> "0" Then
            btnEquals.PerformClick()
            optSelect = True
            opt = btn.Text
            lblDisplay2.Text = currentInput & " " & opt

        Else
            opt = btn.Text
            currentInput = CDbl(lblDisplay.Text)
            optSelect = True
            lblDisplay2.Text = currentInput & " " & opt
        End If
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click

        secondNumber = CDbl(lblDisplay.Text)
        lblDisplay2.Text = ""
        Try
            Select Case opt
                Case "+"
                    lblDisplay.Text = currentInput + CDbl(lblDisplay.Text)
                Case "-"
                    lblDisplay.Text = currentInput - CDbl(lblDisplay.Text)
                Case "x"
                    lblDisplay.Text = currentInput * CDbl(lblDisplay.Text)
                Case "÷"

                    If secondNumber <> "0" Then
                        lblDisplay.Text = currentInput / CDbl(lblDisplay.Text)
                    Else
                        lblDisplay.Text = "Can't divide by zero"
                    End If

                Case "%"
                    lblDisplay.Text = currentInput Mod CDbl(lblDisplay.Text)

            End Select


            currentInput = CDbl(lblDisplay.Text)
            opt = ""
        Catch
            lblDisplay.Text = "Can't divide by zero"

        End Try
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click


        If lblDisplay.Text = "0" Or optSelect Then
            lblDisplay.Text = ""
            lblDisplay.Text = "1"
            optSelect = False

        Else
            lblDisplay.Text += "1"
        End If


    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If lblDisplay.Text = "0" Or optSelect Then
            lblDisplay.Text = ""
            lblDisplay.Text = "2"
            optSelect = False
        Else
            lblDisplay.Text += "2"
        End If

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If lblDisplay.Text = "0" Or optSelect Then
            lblDisplay.Text = ""
            lblDisplay.Text = "3"
            optSelect = False
        Else
            lblDisplay.Text += "3"
        End If

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If lblDisplay.Text = "0" Or optSelect Then
            lblDisplay.Text = ""
            lblDisplay.Text = "4"
            optSelect = False
        Else
            lblDisplay.Text += "4"
        End If

    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If lblDisplay.Text = "0" Or optSelect Then
            lblDisplay.Text = ""
            lblDisplay.Text = "5"
            optSelect = False
        Else
            lblDisplay.Text += "5"
        End If

    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If lblDisplay.Text = "0" Or optSelect Then
            lblDisplay.Text = ""
            lblDisplay.Text = "6"
            optSelect = False
        Else
            lblDisplay.Text += "6"
        End If

    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If lblDisplay.Text = "0" Or optSelect Then
            lblDisplay.Text = ""
            lblDisplay.Text = "7"
            optSelect = False
        Else
            lblDisplay.Text += "7"
        End If

    End Sub


    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If lblDisplay.Text = "0" Or optSelect Then
            lblDisplay.Text = ""
            lblDisplay.Text = "8"
            optSelect = False
        Else
            lblDisplay.Text += "8"
        End If

    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If lblDisplay.Text = "0" Or optSelect Then
            lblDisplay.Text = ""
            lblDisplay.Text = "9"
            optSelect = False

        Else
            lblDisplay.Text += "9"
        End If

    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If lblDisplay.Text = "0" Or optSelect Then
            lblDisplay.Text = ""
            lblDisplay.Text = "0"
            optSelect = False
        Else
            lblDisplay.Text += "0"
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lblDisplay.Text.Length > 0 Then
            lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1, 1)
        End If

        If lblDisplay.Text = "" Then
            lblDisplay.Text = "0"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblDisplay.Text = "0"
        lblDisplay2.Text = Nothing
    End Sub

    Private Sub btnPeriod_Click(sender As Object, e As EventArgs) Handles btnPeriod.Click
        If Not lblDisplay.Text.Contains(".") Then
            lblDisplay.Text = lblDisplay.Text + "."
        End If
    End Sub

    Private Sub btnNegate_Click(sender As Object, e As EventArgs) Handles btnNegate.Click

        currentInput = CDbl(lblDisplay.Text)

        currentInput = currentInput * -1
        lblDisplay.Text = currentInput
    End Sub
End Class

