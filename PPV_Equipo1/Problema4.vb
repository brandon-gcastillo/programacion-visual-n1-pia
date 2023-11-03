Public Class Problema4
    Dim adivinanzas As String() = {
        "Oro no es, plata no es, abre la ventana y verás lo que es",
        "Agua pasa por mi casa, cate de mi corazón...",
        "¿Qué es verde y huele a pintura?"
    }

    Dim respuestas As String() = {
        "Platano",
        "Aguacate",
        "Pintura verde"
    }

    Dim palabrasEnmascaradas As String() = {
    "f_o_n_o",
    "_ng_s",
    "_r_do"
    }

    Dim respuestasPalabras As String() = {
        "fondo",
        "inges",
        "crudo"
    }

    Dim juegoPalabrasActivo As Boolean = False
    Dim juegoAdivinanzasActivo As Boolean = False
    Dim juegoNumeroActivo As Boolean = False
    Dim numeroAleatorio As Integer
    Dim victoria As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ocultar los controles de juego al cargar la aplicación
        OcultarControlesDeJuego()
    End Sub

    Private Sub OcultarControlesDeJuego()
        ' Ocultar los controles relacionados con el juego de adivinanza
        LabelAdivinanza.Visible = False
        TextBoxRespuesta.Visible = False
        Button1.Visible = False
        BotonMostrarRespuesta.Visible = False

        ' Ocultar los controles relacionados con el juego de número
        LabelInstruccionNumero.Visible = False
        TextBoxNumero.Visible = False
        BotonComprobarNumero.Visible = False
        LabelNumeroAleatorio.Visible = False
        LabelResultadoNumero.Visible = False

        ' Ocultar los controles relacionados con el juego de palabras
        LabelPalabraEnmascarada.Visible = False
        TextBoxPalabra.Visible = False
        BotonComprobarPalabra.Visible = False
        BotonVolverInicio.Visible = False



    End Sub


    Private Sub Boton1_Click(sender As Object, e As EventArgs) Handles Boton1.Click
        ' Verificar si el juego de adivinanzas está activo
        If Not juegoAdivinanzasActivo Then
            ' Ocultar los controles del menú principal
            LabelTitulo.Visible = False
            Boton1.Visible = False
            Boton2.Visible = False
            Boton3.Visible = False

            ' Mostrar los controles relacionados con el juego de adivinanzas
            LabelAdivinanza.Visible = True
            TextBoxRespuesta.Visible = True
            Button1.Visible = True
            BotonMostrarRespuesta.Visible = True

            ' Elegir y mostrar una adivinanza aleatoria de la lista
            Dim rand As New Random()
            Dim indiceAdivinanza As Integer = rand.Next(adivinanzas.Length)
            LabelAdivinanza.Text = adivinanzas(indiceAdivinanza)

            ' Establecer el juego de adivinanzas como activo
            juegoAdivinanzasActivo = True
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Ocultar los controles relacionados con el juego de adivinanzas
        LabelAdivinanza.Visible = False
        TextBoxRespuesta.Visible = False
        Button1.Visible = False
        BotonMostrarRespuesta.Visible = False

        ' Mostrar los controles del menú principal
        LabelTitulo.Visible = True
        Boton1.Visible = True
        Boton2.Visible = True
        Boton3.Visible = True

        ' Limpiar la caja de texto de respuesta
        TextBoxRespuesta.Text = ""

        ' Restablecer el texto de la etiqueta de la adivinanza
        LabelAdivinanza.Text = ""

        ' Establecer el juego de adivinanzas como inactivo
        juegoAdivinanzasActivo = False
    End Sub
    Private Sub BotonMostrarRespuesta_Click(sender As Object, e As EventArgs) Handles BotonMostrarRespuesta.Click
        ' Obtener la respuesta correcta correspondiente a la adivinanza mostrada
        Dim respuesta As String = respuestas(Array.IndexOf(adivinanzas, LabelAdivinanza.Text))

        ' Mostrar la respuesta en una etiqueta o en una ventana de mensaje
        MessageBox.Show("La respuesta correcta es: " & respuesta, "Respuesta Correcta")
    End Sub

    Private Sub Boton2_Click(sender As Object, e As EventArgs) Handles Boton2.Click
        If Not juegoNumeroActivo Then
            ' Ocultar los controles del menú principal
            LabelTitulo.Visible = False
            Boton1.Visible = False
            Boton2.Visible = False
            Boton3.Visible = False

            ' Mostrar los controles relacionados con el juego de número
            LabelInstruccionNumero.Visible = True
            TextBoxNumero.Visible = True
            BotonComprobarNumero.Visible = True
            LabelNumeroAleatorio.Visible = True
            LabelResultadoNumero.Visible = True

            'Generar numero aleatorio del 1 al 5 
            Dim rand As New Random()
            numeroAleatorio = rand.Next(1, 6)
            LabelNumeroAleatorio.Text = "Numero aleatorio: " & numeroAleatorio
            juegoNumeroActivo = True

        End If
    End Sub
    Private Sub BotonComprobarNumero_Click(sender As Object, e As EventArgs) Handles BotonComprobarNumero.Click
        If juegoNumeroActivo Then
            ' Obtener el número ingresado por el usuario
            Dim numeroIngresado As Integer
            If Integer.TryParse(TextBoxNumero.Text, numeroIngresado) Then
                ' Comparar el número ingresado con el número aleatorio
                If numeroIngresado = numeroAleatorio Then
                    LabelResultadoNumero.Text = "¡Victoria!"
                    victoria = True
                Else
                    LabelResultadoNumero.Text = "¡Derrota!"
                    victoria = False
                End If
            End If
        End If
    End Sub

    Private Sub BotonReiniciarNumero_Click(sender As Object, e As EventArgs) Handles BotonReiniciarNumero.Click
        ' Ocultar los controles relacionados con el juego de número
        LabelInstruccionNumero.Visible = False
        TextBoxNumero.Visible = False
        BotonComprobarNumero.Visible = False
        LabelNumeroAleatorio.Visible = False
        LabelResultadoNumero.Visible = False

        ' Mostrar los controles del menú principal
        LabelTitulo.Visible = True
        Boton1.Visible = True
        Boton2.Visible = True
        Boton3.Visible = True

        ' Limpiar la caja de texto de número
        TextBoxNumero.Text = ""

        ' Restablecer el estado del juego de número
        juegoNumeroActivo = False
        LabelResultadoNumero.Text = ""
    End Sub

    Private Sub Boton3_Click(sender As Object, e As EventArgs) Handles Boton3.Click
        If Not juegoAdivinanzasActivo And Not juegoNumeroActivo And Not juegoPalabrasActivo Then
            ' Ocultar los controles del menú principal
            LabelTitulo.Visible = False
            Boton1.Visible = False
            Boton2.Visible = False
            Boton3.Visible = False

            ' Mostrar los controles relacionados con el juego de palabras
            LabelPalabraEnmascarada.Visible = True
            TextBoxPalabra.Visible = True
            BotonComprobarPalabra.Visible = True
            BotonVolverInicio.Visible = True

            ' Elegir y mostrar una palabra enmascarada aleatoria de la lista
            Dim rand As New Random()
            Dim indicePalabra As Integer = rand.Next(palabrasEnmascaradas.Length)
            LabelPalabraEnmascarada.Text = palabrasEnmascaradas(indicePalabra)

            ' Establecer el juego de palabras como activo
            juegoPalabrasActivo = True
        End If
    End Sub

    Private Sub BotonComprobarPalabra_Click(sender As Object, e As EventArgs) Handles BotonComprobarPalabra.Click
        If juegoPalabrasActivo Then
            ' Obtener la respuesta ingresada por el usuario
            Dim respuestaIngresada As String = TextBoxPalabra.Text
            Dim indicePalabra As Integer = Array.IndexOf(palabrasEnmascaradas, LabelPalabraEnmascarada.Text)

            If indicePalabra >= 0 AndAlso indicePalabra < respuestasPalabras.Length Then
                ' Obtener la respuesta correcta correspondiente a la palabra enmascarada mostrada
                Dim respuestaCorrecta As String = respuestasPalabras(indicePalabra)

                ' Comparar la respuesta ingresada con la respuesta correcta
                If respuestaIngresada.ToLower() = respuestaCorrecta Then
                    ' Mostrar "correcto" si la respuesta es correcta
                    MessageBox.Show("¡Correcto!", "Respuesta Correcta")
                Else
                    ' Mostrar "incorrecto" si la respuesta es incorrecta
                    MessageBox.Show("¡Incorrecto!", "Respuesta Incorrecta")
                End If
            End If
        End If
    End Sub

    Private Sub BotonVolverInicio_Click(sender As Object, e As EventArgs) Handles BotonVolverInicio.Click
        ' Ocultar los controles relacionados con el juego de palabras
        LabelPalabraEnmascarada.Visible = False
        TextBoxPalabra.Visible = False
        BotonComprobarPalabra.Visible = False
        BotonVolverInicio.Visible = False

        ' Mostrar los controles del menú principal
        LabelTitulo.Visible = True
        Boton1.Visible = True
        Boton2.Visible = True
        Boton3.Visible = True

        ' Limpiar la caja de texto de la palabra
        TextBoxPalabra.Text = ""

        ' Restablecer el texto de la etiqueta de la palabra enmascarada
        LabelPalabraEnmascarada.Text = ""

        ' Establecer el juego de palabras como inactivo
        juegoPalabrasActivo = False
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Hide()
        M_principal.Show()
    End Sub
End Class