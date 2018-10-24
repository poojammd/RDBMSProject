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
        Dim passRow As DataRow
        Try
            adapt = New OleDbDataAdapter("select passwd from users where username='" & user & "'", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "passwd"
            pass1 = ComboBox1.Text
            Label5.Text = pass1
            If (pass = pass1) Then
                ShowPackageForm.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        If ((user = "poo") And (pass = "poo")) Then
            ShowPackageForm.Show()
        Else
            MsgBox("Invalid User")
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        RegisterForm.Show()
    End Sub

    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        connect()
        AcceptButton = Button2
    End Sub
End Class
