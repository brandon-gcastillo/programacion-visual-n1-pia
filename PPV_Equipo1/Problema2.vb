Public Class Problema2
    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        ' Declarar variables
        Dim D As Double
        Dim H As Double
        Dim R As Double
        Dim V As Double

        ' Obtener el diámetro y la altura desde los cuadros de texto
        If Double.TryParse(TextBoxDiametro.Text, D) AndAlso Double.TryParse(TextBoxAltura.Text, H) Then
            ' Calcular el radio
            R = D / 2
            ' Calcular el volumen
            V = Math.PI * (R ^ 2) * H
            ' Mostrar el resultado
            LabelResultado.Text = "El volumen del cilindro es de " & V.ToString("N2") & " metros cúbicos."
        Else
            ' Manejar entrada inválida
            MessageBox.Show("Por favor, introduzca valores válidos para el diámetro y la altura.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Hide()
        M_principal.Show()
    End Sub
End Class

