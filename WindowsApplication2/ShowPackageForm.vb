Imports System.Data.OleDb
Public Class ShowPackageForm

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles DAYS.Click

    End Sub

    Private Sub ShowPackageForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim range As String = Trim(range1.Text)
        Dim city As String = Trim(city1.Text)
        Dim Days As String = Trim(Days1.Text)
        Dim adapt As OleDbDataAdapter
        Dim dt As DataTable

        range = range1.Text().ToString()
        city = city1.Text().ToString()
        Days = Days1.Text().ToString()

        Try
            adapt = New OleDbDataAdapter("select city from packages ", con)
            dt = New DataTable
            adapt.Fill(dt)
            'range1.DataSource = dt

            city1.DataSource = dt
            city1.DisplayMember = "city"
            ' Days1.DataSource = dt

            
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub city1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles city1.SelectedIndexChanged

    End Sub
End Class