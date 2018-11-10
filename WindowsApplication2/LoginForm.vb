﻿Imports System.Data.OleDb
Public Class LoginForm

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        
        Dim user As String = Trim(TextBox1.Text)
        Dim pass As String = Trim(TextBox2.Text)
        Dim pass1, uname As String
        user = TextBox1.Text().ToString()
        pass = TextBox2.Text().ToString()
        Dim adapt As OleDbDataAdapter
        Dim dt As DataTable

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
            adapt = New OleDbDataAdapter("select pass,name from users where usern = '" & user & "'", con)
            dt = New DataTable
            adapt.Fill(dt)
            pass1 = dt.Rows(0).Item(0)
            uname = dt.Rows(0).Item(1)
            If (pass = pass1) Then
                MsgBox("Login Successful")
                LoggedUser = user
                LoggedName = uname
                WelcomePage.Show()
                Me.Hide()

            Else
                MsgBox("Invalid Credentials")
                LoggedUser = ""
                LoggedName = ""
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
