Imports System.Data.OleDb

Public Class SelectPackageByDays
    Dim adapt, adapt1 As OleDbDataAdapter
    Dim dt, dt1 As DataTable
    Private Sub SelectPackageByDays_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'MsgBox("Form Load : " + SelectDays)
        DaysSelectCombo.Text = SelectDays
        ' MsgBox("Opening Days Package")
        adapt = New OleDbDataAdapter("select distinct noofdays as days from packages order by days", con)
        dt = New DataTable
        adapt.Fill(dt)
        DaysSelectCombo.DataSource = dt
        DaysSelectCombo.DisplayMember = "days"
        DaysSelectCombo.Text = SelectDays

        Try
            adapt1 = New OleDbDataAdapter("select * from packages where noofdays = '" & SelectDays & "' ", con)
            dt1 = New DataTable
            adapt1.Fill(dt1)
            DataGridView1.DataSource = dt1
        Catch ex As Exception
            MsgBox("Load Date Error : " + ex.Message)
        End Try
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.ReadOnly = True

    End Sub

    Private Sub DaysSelectCombo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles DaysSelectCombo.SelectedIndexChanged
        ' MsgBox("Index Changed : " + DaysSelectCombo.Text)
        Try
            adapt1 = New OleDbDataAdapter("select * from packages where noofdays = '" & DaysSelectCombo.Text & "'", con)
            dt1 = New DataTable
            adapt1.Fill(dt1)
            DataGridView1.DataSource = dt1
        Catch ex As Exception
            ' MsgBox("DaysComboChange Error : " + ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count = 1 Then
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.SelectedRows(0)
            SelectPackage = selectedRow.Cells(0).Value.ToString
            sPid = selectedRow.Cells(0).Value.ToString
            sPname = selectedRow.Cells(1).Value.ToString
            sPrice = selectedRow.Cells(2).Value.ToString
            sCity = selectedRow.Cells(3).Value.ToString
            sDays = selectedRow.Cells(4).Value.ToString
            MsgBox("Selected Package ID is " + SelectPackage)
            Me.Close()
            BookPackage.Show()
        Else
            MsgBox("Please Select A Package")
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
        ShowPackageForm.Show()
    End Sub
End Class