Imports System.Data.OleDb

Public Class WelcomePage

    Private Sub WelcomePage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Welcome.Text = "Welcome " + LoggedName
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
        LoginForm.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
        ShowPackageForm.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
        ModifyBooking.Show()
    End Sub
End Class