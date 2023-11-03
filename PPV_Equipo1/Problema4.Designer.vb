<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Problema4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.Boton1 = New System.Windows.Forms.Button()
        Me.Boton2 = New System.Windows.Forms.Button()
        Me.Boton3 = New System.Windows.Forms.Button()
        Me.LabelAdivinanza = New System.Windows.Forms.Label()
        Me.LabelInstruccionNumero = New System.Windows.Forms.Label()
        Me.LabelPalabraEnmascarada = New System.Windows.Forms.Label()
        Me.TextBoxRespuesta = New System.Windows.Forms.TextBox()
        Me.TextBoxNumero = New System.Windows.Forms.TextBox()
        Me.TextBoxPalabra = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BotonMostrarRespuesta = New System.Windows.Forms.Button()
        Me.LabelNumeroAleatorio = New System.Windows.Forms.Label()
        Me.LabelResultadoNumero = New System.Windows.Forms.Label()
        Me.BotonComprobarNumero = New System.Windows.Forms.Button()
        Me.BotonReiniciarNumero = New System.Windows.Forms.Button()
        Me.BotonComprobarPalabra = New System.Windows.Forms.Button()
        Me.BotonVolverInicio = New System.Windows.Forms.Button()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Location = New System.Drawing.Point(116, 21)
        Me.LabelTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(169, 13)
        Me.LabelTitulo.TabIndex = 0
        Me.LabelTitulo.Text = "MAQUINA DE JUEGOS AL AZAR"
        '
        'Boton1
        '
        Me.Boton1.Location = New System.Drawing.Point(28, 73)
        Me.Boton1.Margin = New System.Windows.Forms.Padding(2)
        Me.Boton1.Name = "Boton1"
        Me.Boton1.Size = New System.Drawing.Size(70, 31)
        Me.Boton1.TabIndex = 1
        Me.Boton1.Text = "Juego 1"
        Me.Boton1.UseVisualStyleBackColor = True
        '
        'Boton2
        '
        Me.Boton2.Location = New System.Drawing.Point(156, 73)
        Me.Boton2.Margin = New System.Windows.Forms.Padding(2)
        Me.Boton2.Name = "Boton2"
        Me.Boton2.Size = New System.Drawing.Size(70, 31)
        Me.Boton2.TabIndex = 2
        Me.Boton2.Text = "Juego 2"
        Me.Boton2.UseVisualStyleBackColor = True
        '
        'Boton3
        '
        Me.Boton3.Location = New System.Drawing.Point(291, 73)
        Me.Boton3.Margin = New System.Windows.Forms.Padding(2)
        Me.Boton3.Name = "Boton3"
        Me.Boton3.Size = New System.Drawing.Size(70, 31)
        Me.Boton3.TabIndex = 3
        Me.Boton3.Text = "Juego 3"
        Me.Boton3.UseVisualStyleBackColor = True
        '
        'LabelAdivinanza
        '
        Me.LabelAdivinanza.AutoSize = True
        Me.LabelAdivinanza.Location = New System.Drawing.Point(28, 106)
        Me.LabelAdivinanza.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAdivinanza.Name = "LabelAdivinanza"
        Me.LabelAdivinanza.Size = New System.Drawing.Size(64, 13)
        Me.LabelAdivinanza.TabIndex = 4
        Me.LabelAdivinanza.Text = "Adivinanzas"
        '
        'LabelInstruccionNumero
        '
        Me.LabelInstruccionNumero.AutoSize = True
        Me.LabelInstruccionNumero.Location = New System.Drawing.Point(156, 106)
        Me.LabelInstruccionNumero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelInstruccionNumero.Name = "LabelInstruccionNumero"
        Me.LabelInstruccionNumero.Size = New System.Drawing.Size(122, 13)
        Me.LabelInstruccionNumero.TabIndex = 5
        Me.LabelInstruccionNumero.Text = "lige un numero del 1 al 5"
        '
        'LabelPalabraEnmascarada
        '
        Me.LabelPalabraEnmascarada.AutoSize = True
        Me.LabelPalabraEnmascarada.Location = New System.Drawing.Point(291, 106)
        Me.LabelPalabraEnmascarada.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPalabraEnmascarada.Name = "LabelPalabraEnmascarada"
        Me.LabelPalabraEnmascarada.Size = New System.Drawing.Size(91, 13)
        Me.LabelPalabraEnmascarada.TabIndex = 6
        Me.LabelPalabraEnmascarada.Text = "Adivina la palabra"
        '
        'TextBoxRespuesta
        '
        Me.TextBoxRespuesta.Location = New System.Drawing.Point(28, 135)
        Me.TextBoxRespuesta.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxRespuesta.Name = "TextBoxRespuesta"
        Me.TextBoxRespuesta.Size = New System.Drawing.Size(95, 20)
        Me.TextBoxRespuesta.TabIndex = 7
        '
        'TextBoxNumero
        '
        Me.TextBoxNumero.Location = New System.Drawing.Point(156, 135)
        Me.TextBoxNumero.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNumero.Name = "TextBoxNumero"
        Me.TextBoxNumero.Size = New System.Drawing.Size(95, 20)
        Me.TextBoxNumero.TabIndex = 8
        '
        'TextBoxPalabra
        '
        Me.TextBoxPalabra.Location = New System.Drawing.Point(291, 135)
        Me.TextBoxPalabra.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxPalabra.Name = "TextBoxPalabra"
        Me.TextBoxPalabra.Size = New System.Drawing.Size(95, 20)
        Me.TextBoxPalabra.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 170)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 25)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Reiniciar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BotonMostrarRespuesta
        '
        Me.BotonMostrarRespuesta.Location = New System.Drawing.Point(24, 199)
        Me.BotonMostrarRespuesta.Margin = New System.Windows.Forms.Padding(2)
        Me.BotonMostrarRespuesta.Name = "BotonMostrarRespuesta"
        Me.BotonMostrarRespuesta.Size = New System.Drawing.Size(116, 28)
        Me.BotonMostrarRespuesta.TabIndex = 11
        Me.BotonMostrarRespuesta.Text = "Mostrar Respuesta"
        Me.BotonMostrarRespuesta.UseVisualStyleBackColor = True
        '
        'LabelNumeroAleatorio
        '
        Me.LabelNumeroAleatorio.AutoSize = True
        Me.LabelNumeroAleatorio.Location = New System.Drawing.Point(156, 172)
        Me.LabelNumeroAleatorio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNumeroAleatorio.Name = "LabelNumeroAleatorio"
        Me.LabelNumeroAleatorio.Size = New System.Drawing.Size(88, 13)
        Me.LabelNumeroAleatorio.TabIndex = 12
        Me.LabelNumeroAleatorio.Text = "Numero Aleatorio"
        '
        'LabelResultadoNumero
        '
        Me.LabelResultadoNumero.AutoSize = True
        Me.LabelResultadoNumero.Location = New System.Drawing.Point(156, 199)
        Me.LabelResultadoNumero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelResultadoNumero.Name = "LabelResultadoNumero"
        Me.LabelResultadoNumero.Size = New System.Drawing.Size(102, 13)
        Me.LabelResultadoNumero.TabIndex = 13
        Me.LabelResultadoNumero.Text = "Numero Del Usuario"
        '
        'BotonComprobarNumero
        '
        Me.BotonComprobarNumero.Location = New System.Drawing.Point(156, 221)
        Me.BotonComprobarNumero.Margin = New System.Windows.Forms.Padding(2)
        Me.BotonComprobarNumero.Name = "BotonComprobarNumero"
        Me.BotonComprobarNumero.Size = New System.Drawing.Size(70, 25)
        Me.BotonComprobarNumero.TabIndex = 14
        Me.BotonComprobarNumero.Text = "Comprobar"
        Me.BotonComprobarNumero.UseVisualStyleBackColor = True
        '
        'BotonReiniciarNumero
        '
        Me.BotonReiniciarNumero.Location = New System.Drawing.Point(156, 250)
        Me.BotonReiniciarNumero.Margin = New System.Windows.Forms.Padding(2)
        Me.BotonReiniciarNumero.Name = "BotonReiniciarNumero"
        Me.BotonReiniciarNumero.Size = New System.Drawing.Size(70, 23)
        Me.BotonReiniciarNumero.TabIndex = 15
        Me.BotonReiniciarNumero.Text = "Reiniciar"
        Me.BotonReiniciarNumero.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BotonReiniciarNumero.UseVisualStyleBackColor = True
        '
        'BotonComprobarPalabra
        '
        Me.BotonComprobarPalabra.Location = New System.Drawing.Point(291, 170)
        Me.BotonComprobarPalabra.Margin = New System.Windows.Forms.Padding(2)
        Me.BotonComprobarPalabra.Name = "BotonComprobarPalabra"
        Me.BotonComprobarPalabra.Size = New System.Drawing.Size(70, 22)
        Me.BotonComprobarPalabra.TabIndex = 16
        Me.BotonComprobarPalabra.Text = "Ver Palabra"
        Me.BotonComprobarPalabra.UseVisualStyleBackColor = True
        '
        'BotonVolverInicio
        '
        Me.BotonVolverInicio.Location = New System.Drawing.Point(291, 196)
        Me.BotonVolverInicio.Margin = New System.Windows.Forms.Padding(2)
        Me.BotonVolverInicio.Name = "BotonVolverInicio"
        Me.BotonVolverInicio.Size = New System.Drawing.Size(70, 31)
        Me.BotonVolverInicio.TabIndex = 17
        Me.BotonVolverInicio.Text = "Reiniciar"
        Me.BotonVolverInicio.UseVisualStyleBackColor = True
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(13, 319)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(110, 31)
        Me.btnGoBack.TabIndex = 18
        Me.btnGoBack.Text = "Regresar"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'Problema4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(434, 362)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.BotonVolverInicio)
        Me.Controls.Add(Me.BotonComprobarPalabra)
        Me.Controls.Add(Me.BotonReiniciarNumero)
        Me.Controls.Add(Me.BotonComprobarNumero)
        Me.Controls.Add(Me.LabelResultadoNumero)
        Me.Controls.Add(Me.LabelNumeroAleatorio)
        Me.Controls.Add(Me.BotonMostrarRespuesta)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxPalabra)
        Me.Controls.Add(Me.TextBoxNumero)
        Me.Controls.Add(Me.TextBoxRespuesta)
        Me.Controls.Add(Me.LabelPalabraEnmascarada)
        Me.Controls.Add(Me.LabelInstruccionNumero)
        Me.Controls.Add(Me.LabelAdivinanza)
        Me.Controls.Add(Me.Boton3)
        Me.Controls.Add(Me.Boton2)
        Me.Controls.Add(Me.Boton1)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Problema4"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitulo As Label
    Friend WithEvents Boton1 As Button
    Friend WithEvents Boton2 As Button
    Friend WithEvents Boton3 As Button
    Friend WithEvents LabelAdivinanza As Label
    Friend WithEvents LabelInstruccionNumero As Label
    Friend WithEvents LabelPalabraEnmascarada As Label
    Friend WithEvents TextBoxRespuesta As TextBox
    Friend WithEvents TextBoxNumero As TextBox
    Friend WithEvents TextBoxPalabra As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BotonMostrarRespuesta As Button
    Friend WithEvents LabelNumeroAleatorio As Label
    Friend WithEvents LabelResultadoNumero As Label
    Friend WithEvents BotonComprobarNumero As Button
    Friend WithEvents BotonReiniciarNumero As Button
    Friend WithEvents BotonComprobarPalabra As Button
    Friend WithEvents BotonVolverInicio As Button
    Friend WithEvents btnGoBack As Button
End Class
