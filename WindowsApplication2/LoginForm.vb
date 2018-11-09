Imports System.Data.OleDb
Public Class LoginForm

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        
        Dim user As String = Trim(TextBox1.Text)
        Dim pass As String = Trim(TextBox2.Text)
        Dim pass1 As String
        user = TextBox1.Text().ToString()
        pass = TextBox2.Text().ToString()
        Dim adapt As OleDbDataAdapter
        Dim dt As DataTable
        Dim dt2 As DataTable
        dt2 = New DataTable
        ComboBox1.DataSource = dt2

        If user = "" Then
            MsgBox("Please Enter Username")
            TextBox1.Focus()
            Exit Sub
        End If

        If pass = "" Then
            MsgBox("Please Enter Password")
            TextBox2.Focus()
            Exit Sub
        End If

        Try
            adapt = New OleDbDataAdapter("select pass from users where usern = '" & user & "'", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "pass"
            pass1 = ComboBox1.Text
            If (pass = pass1) Then
                MsgBox("Login Successful")
                LoggedUser = user
                ShowPackageForm.Show()

            Else
                MsgBox("Invalid Credentials")
                LoggedUser = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        RegisterForm.Show()
    End Sub

    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        connect()
        AcceptButton = Button1
        TextBox1.Focus()
    End Sub
End Class
