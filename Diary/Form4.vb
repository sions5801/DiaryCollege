Public Class Form4
    Public title As String
    Public day As String
    Public month As String
    Public year As String
    Public entry As String
    Public mood As String
    Public target As String

    Private Sub LblClose_Click(sender As Object, e As EventArgs) Handles LblClose.Click
        Me.Close()
        Form1.Close()
        Form2.Close()
        Form3.Close()
    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        title = TxtTitle.Text()
        day = TxtDay.Text()
        month = TxtMonth.Text()
        year = TxtYear.Text()
        entry = TxtEntry.Text()
        mood = TxtMood.Text()
        target = TxtTargets.Text()
    End Sub
End Class