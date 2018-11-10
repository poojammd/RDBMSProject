Imports System.Data.OleDb

Public Class BookPackage


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim startDate As String
        startDate = DateTimePicker1.Text
        Dim name, age, origincity, mob As String
        name = Trim(Ename.Text)
        age = Trim(Eage.Text)
        origincity = Trim(Ecity.Text)
        mob = Trim(Emob.Text)
        Dim com As OleDbCommand
        Try
            com = New OleDbCommand()
            com.Connection = con
            com.CommandText = "insert into bookings values('" & LoggedUser & "','" & sPid & "','" & name & "','" & age & "','" & origincity & "','" & mob & "','" & sCity & "','" & startDate & "')"
            com.ExecuteNonQuery()
            MsgBox("Booking Completed Succesfully")
            Me.Close()
            WelcomePage.Show()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub BookPackage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Lname.Text = sPname
        Lid.Text = sPid
        Lprice.Text = sPrice
        Ldays.Text = sDays
        Lcity.Text = sCity

        Dim adapt As OleDbDataAdapter
        Dim dt As DataTable
        Try
            adapt = New OleDbDataAdapter("select * from users where usern = '" & LoggedUser & "'", con)
            dt = New DataTable
            adapt.Fill(dt)
            Ename.Text = dt.Rows(0).Item(2)
            Eage.Text = dt.Rows(0).Item(3)
            Ecity.Text = dt.Rows(0).Item(4)
            Emob.Text = dt.Rows(0).Item(5)
           
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs) Handles Label10.Click

    End Sub
End Class