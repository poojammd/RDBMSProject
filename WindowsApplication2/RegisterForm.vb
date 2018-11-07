Imports System.Data.OleDb

Public Class RegisterForm

    Private Sub RegisterForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        
        Dim name As String = Trim(TextBox1.Text)

        Dim age As String = Trim(TextBox2.Text)
        Dim city As String = Trim(TextBox3.Text)
        Dim mob As String = Trim(TextBox4.Text)
        Dim usern As String = Trim(TextBox5.Text)
        Dim pass As String = Trim(TextBox6.Text)
        Dim cpass As String = Trim(TextBox7.Text)

        name = TextBox1.Text().ToString()
        age = TextBox2.Text().ToString()
        city = TextBox3.Text().ToString()
        mob = TextBox4.Text().ToString()
        usern = TextBox5.Text().ToString()
        pass = TextBox6.Text().ToString()
        cpass = TextBox7.Text().ToString()

        If Trim(TextBox1.Text) = "" Then
            MsgBox("Please Enter Your Name")
            TextBox1.Focus()
            Exit Sub
        End If

        If Trim(TextBox2.Text) = "" Then
            MsgBox("Please Enter Your Age")
            TextBox2.Focus()
            Exit Sub
        End If

        If Trim(TextBox3.Text) = "" Then
            MsgBox("Please Enter Your City Name")
            TextBox3.Focus()
            Exit Sub
        End If

        If Trim(TextBox4.Text) = "" Then
            MsgBox("Please Enter Your Mobile Number")
            TextBox4.Focus()
            Exit Sub
        End If

        If Trim(TextBox5.Text) = "" Then
            MsgBox("Please Enter Desired Username")
            TextBox5.Focus()
            Exit Sub
        End If

        If Trim(TextBox6.Text) = "" Then
            MsgBox("Please Enter Desired Password")
            TextBox6.Focus()
            Exit Sub
        End If

        If Trim(TextBox7.Text) = "" Then
            MsgBox("Please Confirm Desired Password")
            TextBox7.Focus()
            Exit Sub
        End If

       

        If Not Trim(TextBox7.Text) = Trim(TextBox6.Text) Then
            MsgBox("Passwords Dont Match")
            TextBox7.Focus()
            Exit Sub
        End If

        If Not IsNumeric(TextBox2.Text) Then
            MsgBox("Enter integer value for age ")
            TextBox2.Focus()
            TextBox2.SelectAll()
            Exit Sub
        End If

        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("Enter integer value for mobile number ")
            TextBox4.Focus()
            TextBox4.SelectAll()
            Exit Sub
        End If

        Dim com As OleDbCommand
        Try
            com = New OleDbCommand()
            com.Connection = con
            com.CommandText = "insert into users values('" & usern & "','" & pass & "'," & age & ",'" & city & "'," & mob & ")"
            com.ExecuteNonQuery()
            MsgBox("Registered Succesfully")
            Me.Close()
            LoginForm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

   
End Class