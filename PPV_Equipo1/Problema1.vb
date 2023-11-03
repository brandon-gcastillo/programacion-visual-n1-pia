Public Class Problema1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t1, t2, c1, c2, n As Integer
        t1 = 32
        t2 = 11
        c1 = 40
        c2 = 65

        n = (t1 * c1) + (t2) * (c2)
        MsgBox(n)



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Hide()
        M_principal.Show()
    End Sub
End Class
