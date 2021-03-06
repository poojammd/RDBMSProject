﻿Imports System.Data.OleDb

Public Class SelectPackageByRange
    Dim adapt, adapt1 As OleDbDataAdapter
    Dim dt, dt1 As DataTable
    Private Sub SelectPackageByRange_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'MsgBox("Form Load : " + SelectRange)
        RangeSelectCombo.Text = SelectRange
        ' MsgBox("Opening Range Package")
        adapt = New OleDbDataAdapter("select distinct price from packages order by price", con)
        dt = New DataTable
        adapt.Fill(dt)
        RangeSelectCombo.DataSource = dt
        RangeSelectCombo.DisplayMember = "price"
        RangeSelectCombo.Text = SelectRange

        Try
            adapt1 = New OleDbDataAdapter("select * from packages where price = '" & SelectRange & "' ", con)
            dt1 = New DataTable
            adapt1.Fill(dt1)
            DataGridView1.DataSource = dt1
        Catch ex As Exception
            MsgBox("Load Range Error : " + ex.Message)
        End Try
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.ReadOnly = True

    End Sub

    Private Sub RangeSelectCombo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles RangeSelectCombo.SelectedIndexChanged
        ' MsgBox("Index Changed : " + RangeSelectCombo.Text)
        Try
            adapt1 = New OleDbDataAdapter("select * from packages where price = '" & RangeSelectCombo.Text & "'", con)
            dt1 = New DataTable
            adapt1.Fill(dt1)
            DataGridView1.DataSource = dt1
        Catch ex As Exception
            ' MsgBox("RangeComboChange Error : " + ex.Message)
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