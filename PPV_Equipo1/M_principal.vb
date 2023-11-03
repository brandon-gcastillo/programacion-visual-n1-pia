Public Class M_principal
    Private Sub btnProblema3_Click(sender As Object, e As EventArgs) Handles btnProblema3.Click
        Problema3.Show()
        Me.Hide()
    End Sub

    Private Sub btnProblema1_Click(sender As Object, e As EventArgs) Handles btnProblema1.Click
        Me.Hide()
        Problema1.Show()
    End Sub

    Private Sub btnProblema2_Click(sender As Object, e As EventArgs) Handles btnProblema2.Click
        Me.Hide()
        Problema2.Show()
    End Sub

    Private Sub btnProblema4_Click(sender As Object, e As EventArgs) Handles btnProblema4.Click
        Me.Hide()
        Problema4.Show()
    End Sub

    Private Sub btnProblema5_Click(sender As Object, e As EventArgs) Handles btnProblema5.Click
        Me.Hide()
        Problema5.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        FormUsuario.Show()
    End Sub
End Class