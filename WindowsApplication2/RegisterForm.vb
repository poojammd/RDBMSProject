Public Class RegisterForm

    Private Sub RegisterForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
        LoginForm.Show()
        Dim name As String = Trim(TextBox1.Text)

        Dim age As String = Trim(TextBox2.Text)
        Dim city As String = Trim(TextBox3.Text)
        Dim mob As String = Trim(TextBox4.Text)
        Dim user As String = Trim(TextBox5.Text)
        Dim pass As String = Trim(TextBox6.Text)
        Dim cpass As String = Trim(TextBox7.Text)

        name = TextBox1.Text().ToString()
        age = TextBox2.Text().ToString()
        city = TextBox3.Text().ToString()
        mob = TextBox4.Text().ToString()
        user = TextBox5.Text().ToString()
        pass = TextBox6.Text().ToString()
        cpass = TextBox7.Text().ToString()



    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class