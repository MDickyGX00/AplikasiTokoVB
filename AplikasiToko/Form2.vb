﻿Public Class Form2
    Sub childForm(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False

        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        childForm(red)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        childForm(yellow)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        childForm(green)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class