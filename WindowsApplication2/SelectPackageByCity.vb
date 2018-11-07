Imports System.Data.OleDb

Public Class SelectPackageByCity
    Dim adapt, adapt1 As OleDbDataAdapter
    Dim dt, dt1 As DataTable
    Private Sub SelectPackageByCity_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
        adapt = New OleDbDataAdapter("select distinct city from packages order by city", con)
        dt = New DataTable
        adapt.Fill(dt)
        CitySelectCombo.DataSource = dt
        CitySelectCombo.DisplayMember = "city"
        CitySelectCombo.Text = SelectCity
        'MsgBox(SelectCity)
        Try
            adapt1 = New OleDbDataAdapter("select * from packages where city = " & SelectCity, con)
            dt1 = New DataTable
            adapt.Fill(dt1)
            DataGridView1.DataSource = dt1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CitySelectCombo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CitySelectCombo.SelectedIndexChanged
        Try
            adapt1 = New OleDbDataAdapter("select * from packages where city = " & CitySelectCombo.Text, con)
            dt1 = New DataTable
            adapt.Fill(dt1)
            DataGridView1.DataSource = dt1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class