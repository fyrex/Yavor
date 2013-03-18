Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For i = 1 To 20 Step 2
            Label1.Text = Label1.Text & " " & i
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For i = 1 To 30 Step 1
            Label1.Text = "I will be a good student" & " " & Label1.Text
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sum As Integer
        Dim a, b As Integer
        a = TextBox1.Text
        b = TextBox2.Text

        For i = a To b Step 1
            If i Mod 3 = 0 Or i Mod 7 = 0 Then
                Label1.Text = Label1.Text & " " & i
            End If

        Next
    End Sub
End Class
