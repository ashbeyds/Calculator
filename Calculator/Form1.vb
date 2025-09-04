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
                    Display.Text = (firstNum - secondNum).ToString()
                Case "x"
                    Display.Text = (firstNum * secondNum).ToString()
                Case "/"
                    If secondNum <> 0 Then
                        Display.Text = (firstNum / secondNum).ToString()
                    Else
                        Display.Text = "Error"
                    End If
            End Select
        End If
        currentNumber = ""
        isOperatorPressed = False
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Display.Text = ""
        firstNum = 0
        currentNumber = ""
        isOperatorPressed = False
    End Sub

    Private Sub Number_Click(sender As Object, e As EventArgs) _
Handles B0.Click, B1.Click, B2.Click, B3.Click, B4.Click, B5.Click,
        B6.Click, B7.Click, B8.Click, B9.Click, Point.Click, Plus.Click,
        Minus.Click, Multiply.Click, Divide.Click

        ' limit input to 14 number
        If Display.Text.Length >= 14 AndAlso Not isOperatorPressed Then
            MessageBox.Show("Maximum input length reached (Up to 14 number only).", "Input Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim btn As Button = CType(sender, Button)
        Dim operators As String() = {"+", "-", "x", "/"}

        If operators.Contains(btn.Text) Then
            ' bawal same operator i input
            If String.IsNullOrEmpty(Display.Text) OrElse isOperatorPressed Then
                Return
            End If
            If Double.TryParse(Display.Text, firstNum) Then
                currentNumber = btn.Text
                isOperatorPressed = True
            End If
        ElseIf btn.Text = "." Then
            ' one deci onli
            If isOperatorPressed OrElse String.IsNullOrEmpty(Display.Text) Then
                Display.Text = "0."
                isOperatorPressed = False
            ElseIf Not Display.Text.Contains(".") Then
                Display.Text &= "."
            End If
        Else
            ' bawal zero una (except 0.1 and so on)
            If Display.Text = "0" AndAlso btn.Text <> "." Then
                Display.Text = btn.Text
            ElseIf isOperatorPressed Then
                Display.Text = btn.Text
                isOperatorPressed = False
            Else
                Display.Text &= btn.Text
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Display.KeyPress, AddressOf Display_KeyPress
    End Sub

    Private Sub Del_Click(sender As Object, e As EventArgs) Handles Del.Click
        If Display.Text.Length > 0 Then
            Display.Text = Display.Text.Substring(0, Display.Text.Length - 1)
        End If
        If Display.Text = "" Then
            isOperatorPressed = False
            currentNumber = ""
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Display_Click(sender As Object, e As EventArgs) Handles Display.Click
        Display.Focus()
    End Sub

    Private Sub Display_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Display.KeyPress
        Dim allowedChars As String = "0123456789.+-x/"
        e.Handled = True

        If allowedChars.Contains(e.KeyChar) Then
            Dim btn As New Button()
            btn.Text = e.KeyChar
            Number_Click(btn, EventArgs.Empty)
        ElseIf e.KeyChar = ChrW(Keys.Back) Then
            Del_Click(Nothing, EventArgs.Empty)
        ElseIf e.KeyChar = ChrW(Keys.Enter) Then
            Equals_Click(Nothing, EventArgs.Empty)
        End If
    End Sub
End Class
