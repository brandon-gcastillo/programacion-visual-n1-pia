Public Class FormUsuario
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If txtUsuario.Text = "Equipo1" AndAlso txtContraseña.Text = "1234" Then
            MsgBox("Inicio de sesión correcto.")

            Dim frmMenu As New M_principal()
            frmMenu.Show()
            Me.Hide()

        Else
            MsgBox("Nombre de usuario o contraseña incorrectos.")
        End If
    End Sub
End Class
