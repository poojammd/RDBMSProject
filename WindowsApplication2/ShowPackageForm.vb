Public Class ShowPackageForm

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles DAYS.Click

    End Sub

    Private Sub ShowPackageForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim range As String = Trim(range1.Text)
        Dim city As String = Trim(city1.Text)
        Dim Days As String = Trim(Days1.Text)

        range = range1.Text().ToString()
        city = city1.Text().ToString()
        Days = Days1.Text().ToString()
    End Sub
End Class