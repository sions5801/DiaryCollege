Public Class Form1
    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub LblClose_Click(sender As Object, e As EventArgs) Handles LblClose.Click
        Me.Close()
    End Sub
End Class
