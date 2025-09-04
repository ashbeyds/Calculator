Public Class Form1
    Private firstNum As Double = 0
    Private currentOperator As String = ""
    Private isOperatorPressed As Boolean = False
    Private wasEqualsPressed As Boolean = False

    Private Sub Equals_Click(sender As Object, e As EventArgs) Handles Equals.Click
        Dim secondNum As Double
        If Double.TryParse(TextBox1.Text, secondNum) Then
            Select Case currentOperator
                Case "+"
                    TextBox1.Text = (firstNum + secondNum).ToString()
                Case "-"
                    TextBox1.Text = (firstNum - secondNum).ToString()
                Case "*"
                    TextBox1.Text = (firstNum * secondNum).ToString()
                Case "/"
                    If secondNum <> 0 Then
                        TextBox1.Text = (firstNum / secondNum).ToString()
                    Else
                        TextBox1.Text = "Error"
                    End If
            End Select
        End If
        currentOperator = ""
        isOperatorPressed = False
        Display1.Text = ""
        wasEqualsPressed = True
        If Double.TryParse(TextBox1.Text, firstNum) Then
        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        TextBox1.Text = ""
        firstNum = 0
        currentOperator = ""
        isOperatorPressed = False
        wasEqualsPressed = False
        Display1.Text = ""
    End Sub

    Private Sub Number_Click(sender As Object, e As EventArgs) _
    Handles B0.Click, B1.Click, B2.Click, B3.Click, B4.Click, B5.Click,
        B6.Click, B7.Click, B8.Click, B9.Click, Point.Click, Plus.Click,
        Minus.Click, Multiply.Click, Divide.Click

        Dim btn As Button = CType(sender, Button)
        Dim operators As String() = {"+", "-", "*", "/"}

        If TextBox1.Text = "Error" Then
            TextBox1.Text = ""
            wasEqualsPressed = False
        End If

        If wasEqualsPressed Then
            If operators.Contains(btn.Text) Then
                wasEqualsPressed = False
                isOperatorPressed = False
            Else
                TextBox1.Text = ""
                wasEqualsPressed = False
            End If
        End If

        If operators.Contains(btn.Text) AndAlso String.IsNullOrEmpty(TextBox1.Text) Then
            If btn.Text = "-" Then
                TextBox1.Text = "-"
                isOperatorPressed = False
            End If
            Return
        End If

        Dim txt As String = TextBox1.Text
        If txt.Replace("-", "").Replace(".", "").Length >= 10 AndAlso Not isOperatorPressed Then
            If Not operators.Contains(btn.Text) Then
                Return
            End If
        End If

        If operators.Contains(btn.Text) Then

            If isOperatorPressed Then
                currentOperator = btn.Text
                Display1.Text = btn.Text
                Return
            End If

            If Double.TryParse(TextBox1.Text, firstNum) Then
                currentOperator = btn.Text
                isOperatorPressed = True
                Display1.Text = btn.Text
            End If

        ElseIf btn.Text = "." Then
            If isOperatorPressed OrElse String.IsNullOrEmpty(TextBox1.Text) Then
                TextBox1.Text = "0."
                isOperatorPressed = False
            ElseIf Not TextBox1.Text.Contains(".") Then
                TextBox1.Text &= "."
            End If

        Else

            If TextBox1.Text = "0" AndAlso btn.Text <> "." Then
                TextBox1.Text = btn.Text
            ElseIf isOperatorPressed Then
                TextBox1.Text = btn.Text
                isOperatorPressed = False
            Else
                TextBox1.Text &= btn.Text
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Equals_Click(Nothing, EventArgs.Empty)
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim allowedChars As String = "0123456789.+-*/"
        e.Handled = True


        If e.KeyChar = "-"c AndAlso String.IsNullOrEmpty(TextBox1.Text) Then
            TextBox1.Text = "-"
            e.Handled = True
            Return
        End If

        If (TextBox1.Text = "Error" OrElse wasEqualsPressed) AndAlso allowedChars.Contains(e.KeyChar) Then
            If allowedChars.Contains(e.KeyChar) AndAlso Not "+-*/".Contains(e.KeyChar) Then
                TextBox1.Text = ""
                wasEqualsPressed = False
            End If
        End If

        If allowedChars.Contains(e.KeyChar) Then
            Dim btn As New Button()
            btn.Text = e.KeyChar
            Number_Click(btn, EventArgs.Empty)
        ElseIf e.KeyChar = ChrW(Keys.Back) Then
            Del_Click(Nothing, EventArgs.Empty)
        End If
    End Sub

    Private Sub Del_Click(sender As Object, e As EventArgs) Handles Del.Click
        If wasEqualsPressed Then
            TextBox1.Text = ""
            wasEqualsPressed = False
            isOperatorPressed = False
            currentOperator = ""
            Return
        End If

        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        End If
        If TextBox1.Text = "" Then
            isOperatorPressed = False
            currentOperator = ""
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Focus()
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Dim allowedChars As String = "0123456789.+-*/"
        If allowedChars.Contains(e.KeyChar) Then
            If TextBox1.Text = "Error" OrElse wasEqualsPressed Then
                If allowedChars.Contains(e.KeyChar) AndAlso Not "+-*/".Contains(e.KeyChar) Then
                    TextBox1.Text = ""
                    wasEqualsPressed = False
                End If
            End If

            If e.KeyChar = "-"c AndAlso String.IsNullOrEmpty(TextBox1.Text) Then
                TextBox1.Text = "-"
                e.Handled = True
                Return
            End If
            Dim btn As New Button()
            btn.Text = e.KeyChar
            Number_Click(btn, EventArgs.Empty)
            e.Handled = True
        ElseIf e.KeyChar = ChrW(Keys.Back) Then
            Del_Click(Nothing, EventArgs.Empty)
            e.Handled = True
        ElseIf e.KeyChar = ChrW(Keys.Enter) Then
            Equals_Click(Nothing, EventArgs.Empty)
            e.Handled = True
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Display1.Click

    End Sub

    Private Sub Display_Click(sender As Object, e As EventArgs) Handles Display.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Focus()
        If TextBox1.Text = "Error" Then
            TextBox1.SelectionStart = 0
        End If
    End Sub
End Class