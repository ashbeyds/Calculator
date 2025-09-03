Public Class Form1
    Private firstNum As Double = 0
    Private currentNumber As String = ""
    Private isOperatorPressed As Boolean = False
    Private Sub Equals_Click(sender As Object, e As EventArgs) Handles Equals.Click
        Dim secondNum As Double
        If Double.TryParse(Display.Text, secondNum) Then
            Select Case currentNumber
                Case "+"
                    Display.Text = (firstNum + secondNum).ToString()
                Case "-"
                    Display.Text = (firstNum = secondNum).ToString()
                Case "x"
                    Display.Text = (firstNum * secondNum).ToString()
            End Select
        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Display.Text = ""
    End Sub

    Private Sub Number_Click(sender As Object, e As EventArgs) _
Handles B0.Click, B1.Click, B2.Click, B3.Click, B4.Click, B5.Click,
        B6.Click, B7.Click, B8.Click, B9.Click, Point.Click, Plus.Click,
        Minus.Click, Multiply.Click, Divide.Click

        Dim btn As Button = CType(sender, Button)

        If btn.Text = "+" OrElse btn.Text = "-" OrElse btn.Text = "x" OrElse btn.Text = "/" Then
            If Double.TryParse(Display.Text, firstNum) Then
                currentNumber = btn.Text
                isOperatorPressed = True
            End If
        Else
            If Display.Text = "0" OrElse isOperatorPressed Then
                Display.Text = btn.Text
                isOperatorPressed = False
            Else
                Display.Text &= btn.Text
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Del_Click(sender As Object, e As EventArgs) Handles Del.Click

    End Sub
End Class
