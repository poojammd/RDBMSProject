Imports System.Data.OleDb
Public Class ShowPackageForm
    Public city As String
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim Days As String = Trim(DaysCombo.Text)
        SelectCity = Trim(CityCombo.Text)
        SelectRange = Trim(RangeCombo.Text)
        SelectDays = Trim(DaysCombo.Text)
        'MsgBox(SelectCity)
        If RadioButton1.Checked Then
            SelectPackageByRange.Show()
        ElseIf RadioButton2.Checked Then
            SelectPackageByCity.Show()
        ElseIf RadioButton3.Checked Then
            SelectPackageByDays.Show()
        End If

        Me.Hide()



    End Sub

    Private Sub city1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ShowPackageForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CityCombo.Enabled = False
        DaysCombo.Enabled = False
        RadioButton1.Checked = True
        Dim adapt1, adapt2, adapt3 As OleDbDataAdapter
        Dim dt1, dt2, dt3 As DataTable
        Try
            adapt1 = New OleDbDataAdapter("select distinct price from packages order by price", con)
            dt1 = New DataTable
            adapt1.Fill(dt1)
            RangeCombo.DataSource = dt1
            RangeCombo.DisplayMember = "price"
            adapt2 = New OleDbDataAdapter("select distinct city from packages order by city", con)
            dt2 = New DataTable
            adapt2.Fill(dt2)
            CityCombo.DataSource = dt2
            CityCombo.DisplayMember = "city"
            adapt3 = New OleDbDataAdapter("select distinct noofdays from packages order by noofdays", con)
            dt3 = New DataTable
            adapt3.Fill(dt3)
            DaysCombo.DataSource = dt3
            DaysCombo.DisplayMember = "noofdays"
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            RangeCombo.Enabled = True
        Else
            RangeCombo.Enabled = False
        End If
       
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            CityCombo.Enabled = True
        Else
            CityCombo.Enabled = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged

        If RadioButton3.Checked Then
            DaysCombo.Enabled = True
        Else
            DaysCombo.Enabled = False
        End If
    End Sub
End Class