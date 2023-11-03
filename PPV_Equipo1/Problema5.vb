Public Class Problema5
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        If Not String.IsNullOrEmpty(txtCalificaciones.Text) Then

            Dim calificaciones As String() = txtCalificaciones.Text.Split(","c)
            Dim suma As Double = 0


            For Each calificacion As String In calificaciones

                suma += Convert.ToDouble(calificacion)
            Next

            Dim promedio As Double = suma / calificaciones.Length

            lblPromedio.Text = "Tu promedio es de: " & promedio.ToString("N2")
        Else

            lblPromedio.Text = "Asegurate de llenar la caja de texto con tus calificaciones"
        End If
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Hide()
        M_principal.Show()
    End Sub
End Class
