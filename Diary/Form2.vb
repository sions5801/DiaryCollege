Imports System.Data.SqlClient

Public Class Form2
    Private Sub LblClose_Click(sender As Object, e As EventArgs) Handles LblClose.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim user As String = "coolguy84"
        Dim pass As String = "abc1234"
        If TxtUser.Text = user Then
            If TxtPassword.Text = pass Then
                Form3.Show()
                Me.Hide()
            End If
        Else
            LblError.Text = "Incorrect details."
        End If
    End Sub

    Private Sub LblTitle_Click(sender As Object, e As EventArgs) Handles LblTitle.Click

    End Sub

    Private Sub LblSubtitle_Click(sender As Object, e As EventArgs) Handles LblSubtitle.Click

    End Sub

    Private Sub TxtUser_TextChanged(sender As Object, e As EventArgs) Handles TxtUser.TextChanged

    End Sub
End Class