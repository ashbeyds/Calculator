Public Class Form1
    Private Sub Equals_Click(sender As Object, e As EventArgs) Handles Equals.Click
        Label1.Text = "HELLO WORLD!"
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Label1.Text = ""
    End Sub

    Private Sub Number_Click(sender As Object, e As EventArgs) _
Handles B0.Click, B1.Click, B2.Click, B3.Click, B4.Click, B5.Click,
        B6.Click, B7.Click, B8.Click, B9.Click, Point.Click, Plus.Click,
        Minus.Click, Multiply.Click, Divide.Click


        Dim btn As Button = CType(sender, Button)

        If Label1.Text = "0" Then
            Label1.Text = btn.Text
        Else
            Label1.Text &= btn.Text
        End If
    End Sub


End Class
