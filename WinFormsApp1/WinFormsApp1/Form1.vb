Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        If username = "HOFOR" AndAlso password = "admin" Then
            MessageBox.Show("Login godkendt.")
            Form2.Show() ' Vis Form2
            Me.Hide() ' Skjul Form1
        Else
            MessageBox.Show("Login fejlet. Prøv igen.")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


