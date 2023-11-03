<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Problema2
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
        Me.LabelAltura = New System.Windows.Forms.Label()
        Me.LabelDiametro = New System.Windows.Forms.Label()
        Me.LabelResultado = New System.Windows.Forms.Label()
        Me.TextBoxAltura = New System.Windows.Forms.TextBox()
        Me.TextBoxDiametro = New System.Windows.Forms.TextBox()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelAltura
        '
        Me.LabelAltura.AutoSize = True
        Me.LabelAltura.Location = New System.Drawing.Point(186, 48)
        Me.LabelAltura.Name = "LabelAltura"
        Me.LabelAltura.Size = New System.Drawing.Size(34, 13)
        Me.LabelAltura.TabIndex = 0
        Me.LabelAltura.Text = "Altura"
        '
        'LabelDiametro
        '
        Me.LabelDiametro.AutoSize = True
        Me.LabelDiametro.Location = New System.Drawing.Point(186, 114)
        Me.LabelDiametro.Name = "LabelDiametro"
        Me.LabelDiametro.Size = New System.Drawing.Size(49, 13)
        Me.LabelDiametro.TabIndex = 1
        Me.LabelDiametro.Text = "Diametro"
        '
        'LabelResultado
        '
        Me.LabelResultado.AutoSize = True
        Me.LabelResultado.Location = New System.Drawing.Point(80, 163)
        Me.LabelResultado.Name = "LabelResultado"
        Me.LabelResultado.Size = New System.Drawing.Size(55, 13)
        Me.LabelResultado.TabIndex = 2
        Me.LabelResultado.Text = "Resultado"
        '
        'TextBoxAltura
        '
        Me.TextBoxAltura.Location = New System.Drawing.Point(67, 45)
        Me.TextBoxAltura.Name = "TextBoxAltura"
        Me.TextBoxAltura.Size = New System.Drawing.Size(86, 20)
        Me.TextBoxAltura.TabIndex = 3
        '
        'TextBoxDiametro
        '
        Me.TextBoxDiametro.Location = New System.Drawing.Point(67, 107)
        Me.TextBoxDiametro.Name = "TextBoxDiametro"
        Me.TextBoxDiametro.Size = New System.Drawing.Size(86, 20)
        Me.TextBoxDiametro.TabIndex = 4
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.Location = New System.Drawing.Point(260, 72)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(64, 20)
        Me.ButtonCalcular.TabIndex = 5
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(309, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ejercicio 2"
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(12, 343)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(107, 35)
        Me.btnGoBack.TabIndex = 7
        Me.btnGoBack.Text = "Regresar"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'Problema2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(686, 390)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.TextBoxDiametro)
        Me.Controls.Add(Me.TextBoxAltura)
        Me.Controls.Add(Me.LabelResultado)
        Me.Controls.Add(Me.LabelDiametro)
        Me.Controls.Add(Me.LabelAltura)
        Me.Name = "Problema2"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelAltura As Label
    Friend WithEvents LabelDiametro As Label
    Friend WithEvents LabelResultado As Label
    Friend WithEvents TextBoxAltura As TextBox
    Friend WithEvents TextBoxDiametro As TextBox
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGoBack As Button
End Class
