Imports System.Data.OleDb

Public Class ModifyBooking
    Dim count As String
    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Welcome.Text = "Welcome " + LoggedName
        Dim adapt As OleDbDataAdapter
        Dim dt As DataTable
        Dim count As String
        Try
            adapt = New OleDbDataAdapter("select u.name as Name,p.pid as PackageID,p.pname as PassengerName, p.page as Age, p.porigin as OriginCity, p.pmob as Mobile, p.city as City,p.startdate as StartDate from users u,bookings p where u.usern = p.usern and u.usern = '" & LoggedUser & "'", con)
            dt = New DataTable
            adapt.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.ReadOnly = True

            Try
                count = DataGridView1.Rows().Count()
                count = Integer.Parse(count)
                If count = 1 Then
                    MsgBox("No Booking Exists")
                    Me.Close()
                    WelcomePage.Show()
                End If
            Catch ex As Exception
                MsgBox("No Booking Exists" + ex.Message)

            End Try
           
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
        WelcomePage.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count = 1 Then
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.SelectedRows(0)
            Try
                SelectPackage = selectedRow.Cells(1).Value.ToString
                MsgBox("Selected Package ID is " + SelectPackage)
                Dim com As OleDbCommand
                com = New OleDbCommand

                Try
                    com.Connection = con
                    com.CommandText = "DELETE FROM bookings where usern ='" & LoggedUser & "' and pid = '" & SelectPackage & "'"
                    com.ExecuteNonQuery()
                    MsgBox("Booking Deleted Successfully")

                    Dim adapt As OleDbDataAdapter
                    Dim dt As DataTable
                    Try
                        adapt = New OleDbDataAdapter("select u.name as Name,p.pid as PackageID,p.pname as PassengerName, p.page as Age, p.porigin as OriginCity, p.pmob as Mobile, p.city as City,p.startdate as StartDate from users u,bookings p where u.usern = p.usern and u.usern = '" & LoggedUser & "'", con)
                        dt = New DataTable
                        adapt.Fill(dt)
                        DataGridView1.DataSource = dt
                        count = DataGridView1.Rows().Count()
                        count = Integer.Parse(count)
                        If count = 1 Then
                            MsgBox("No Booking Exists")
                            Me.Close()
                            WelcomePage.Show()
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
            Catch
                MsgBox("No Booking Selected")

            End Try
            
        Else
            MsgBox("Please Select A Booking")
        End If
    End Sub

End Class