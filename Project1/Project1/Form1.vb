Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim username As String
        Dim pass As String
        username = TextBox1.Text
        pass = TextBox2.Text
        If username = "fyrex" And pass = "1234" Then
            Label1.Text = "Welcome"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For i = 1 To 100 Step 1
            Label1.Text = Label1.Text & " " & i
        Next
    End Sub
End Class
