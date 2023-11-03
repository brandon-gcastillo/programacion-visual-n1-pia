<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Problema5
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCalificaciones = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblPromedio = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(25, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(826, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduce tus calificaciones para que conocer tu promedio, separa tus calificacio" &
    "nes con una Coma "","""
        '
        'txtCalificaciones
        '
        Me.txtCalificaciones.Location = New System.Drawing.Point(25, 166)
        Me.txtCalificaciones.Name = "txtCalificaciones"
        Me.txtCalificaciones.Size = New System.Drawing.Size(295, 20)
        Me.txtCalificaciones.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 2
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(337, 166)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(64, 20)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Promediar"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblPromedio
        '
        Me.lblPromedio.AutoSize = True
        Me.lblPromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblPromedio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPromedio.Location = New System.Drawing.Point(25, 210)
        Me.lblPromedio.Name = "lblPromedio"
        Me.lblPromedio.Size = New System.Drawing.Size(84, 20)
        Me.lblPromedio.TabIndex = 4
        Me.lblPromedio.Text = "Promedio"
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(29, 13)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(107, 30)
        Me.btnGoBack.TabIndex = 5
        Me.btnGoBack.Text = "Regresar"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'Problema5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(938, 390)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.lblPromedio)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCalificaciones)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Problema5"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCalificaciones As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblPromedio As Label
    Friend WithEvents btnGoBack As Button
End Class
