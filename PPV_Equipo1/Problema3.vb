Public Class Problema3
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnCalcMedia_Click(sender As Object, e As EventArgs) Handles btnCalcMedia.Click
        Dim precio1 As Double = Convert.ToDouble(textBoxProducto1.Text.Trim())
        Dim precio2 As Double = Convert.ToDouble(textBoxProducto1.Text.Trim())
        Dim precio3 As Double = Convert.ToDouble(textBoxProducto1.Text.Trim())

        Dim media As Double = (precio1 + precio2 + precio3) / 3

        'Mostrar el precio medio del producto

        labelResult.Text = "El precio medio del producto es " & media & " Euros"

    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Hide()
        M_principal.Show()
    End Sub
End Class