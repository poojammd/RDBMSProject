Imports System.Data.OleDb
Module Module1
    Public con As OleDbConnection
    Public Function connect()
        Try
            con = New OleDbConnection("Provider=SQLOLEDB;server=localhost;database=travel;Integrated Security=SSPI")
            con.Open()
            MsgBox("Connected to Database")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
End Module