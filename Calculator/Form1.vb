Public Class Form1
    Private Sub Equals_Click(sender As Object, e As EventArgs) Handles Equals.Click
        Display.Text = "HELLO WORLD!"
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Display.Text = ""
    End Sub

    Private Sub Number_Click(sender As Object, e As EventArgs) _
Handles B0.Click, B1.Click, B2.Click, B3.Click, B4.Click, B5.Click,
        B6.Click, B7.Click, B8.Click, B9.Click, Point.Click, Plus.Click,
        Minus.Click, Multiply.Click, Divide.Click


        Dim btn As Button = CType(sender, Button)

        If Display.Text = "0" Then
            Display.Text = btn.Text
        Else
            Display.Text &= btn.Text
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Del_Click(sender As Object, e As EventArgs) Handles Del.Click

    End Sub
End Class
