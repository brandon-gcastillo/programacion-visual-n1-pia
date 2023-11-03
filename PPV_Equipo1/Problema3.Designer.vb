<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Problema3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelPrecioProducto1 = New System.Windows.Forms.Label()
        Me.textBoxProducto1 = New System.Windows.Forms.TextBox()
        Me.labelPrecioProducto2 = New System.Windows.Forms.Label()
        Me.textBoxProducto2 = New System.Windows.Forms.TextBox()
        Me.labelPrecioProducto3 = New System.Windows.Forms.Label()
        Me.textBoxProducto3 = New System.Windows.Forms.TextBox()
        Me.btnCalcMedia = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.labelResult = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.labelPrecioProducto1)
        Me.FlowLayoutPanel1.Controls.Add(Me.textBoxProducto1)
        Me.FlowLayoutPanel1.Controls.Add(Me.labelPrecioProducto2)
        Me.FlowLayoutPanel1.Controls.Add(Me.textBoxProducto2)
        Me.FlowLayoutPanel1.Controls.Add(Me.labelPrecioProducto3)
        Me.FlowLayoutPanel1.Controls.Add(Me.textBoxProducto3)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCalcMedia)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGoBack)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(13, 13)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(12)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(775, 425)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Problema 3: Precio medio de un producto"
        '
        'labelPrecioProducto1
        '
        Me.labelPrecioProducto1.AutoSize = True
        Me.labelPrecioProducto1.Location = New System.Drawing.Point(15, 49)
        Me.labelPrecioProducto1.Margin = New System.Windows.Forms.Padding(3, 12, 3, 0)
        Me.labelPrecioProducto1.Name = "labelPrecioProducto1"
        Me.labelPrecioProducto1.Size = New System.Drawing.Size(537, 19)
        Me.labelPrecioProducto1.TabIndex = 1
        Me.labelPrecioProducto1.Text = "Introduzca el precio del producto en el establecimiento número 1, en euros:"
        '
        'textBoxProducto1
        '
        Me.textBoxProducto1.Location = New System.Drawing.Point(15, 71)
        Me.textBoxProducto1.Name = "textBoxProducto1"
        Me.textBoxProducto1.Size = New System.Drawing.Size(166, 27)
        Me.textBoxProducto1.TabIndex = 2
        '
        'labelPrecioProducto2
        '
        Me.labelPrecioProducto2.AutoSize = True
        Me.labelPrecioProducto2.Location = New System.Drawing.Point(15, 113)
        Me.labelPrecioProducto2.Margin = New System.Windows.Forms.Padding(3, 12, 3, 0)
        Me.labelPrecioProducto2.Name = "labelPrecioProducto2"
        Me.labelPrecioProducto2.Size = New System.Drawing.Size(537, 19)
        Me.labelPrecioProducto2.TabIndex = 3
        Me.labelPrecioProducto2.Text = "Introduzca el precio del producto en el establecimiento número 2, en euros:"
        '
        'textBoxProducto2
        '
        Me.textBoxProducto2.Location = New System.Drawing.Point(15, 135)
        Me.textBoxProducto2.Name = "textBoxProducto2"
        Me.textBoxProducto2.Size = New System.Drawing.Size(166, 27)
        Me.textBoxProducto2.TabIndex = 4
        '
        'labelPrecioProducto3
        '
        Me.labelPrecioProducto3.AutoSize = True
        Me.labelPrecioProducto3.Location = New System.Drawing.Point(15, 177)
        Me.labelPrecioProducto3.Margin = New System.Windows.Forms.Padding(3, 12, 3, 0)
        Me.labelPrecioProducto3.Name = "labelPrecioProducto3"
        Me.labelPrecioProducto3.Size = New System.Drawing.Size(537, 19)
        Me.labelPrecioProducto3.TabIndex = 5
        Me.labelPrecioProducto3.Text = "Introduzca el precio del producto en el establecimiento número 3, en euros:"
        '
        'textBoxProducto3
        '
        Me.textBoxProducto3.Location = New System.Drawing.Point(15, 199)
        Me.textBoxProducto3.Name = "textBoxProducto3"
        Me.textBoxProducto3.Size = New System.Drawing.Size(166, 27)
        Me.textBoxProducto3.TabIndex = 6
        '
        'btnCalcMedia
        '
        Me.btnCalcMedia.Location = New System.Drawing.Point(15, 245)
        Me.btnCalcMedia.Margin = New System.Windows.Forms.Padding(3, 16, 3, 3)
        Me.btnCalcMedia.Name = "btnCalcMedia"
        Me.btnCalcMedia.Size = New System.Drawing.Size(166, 35)
        Me.btnCalcMedia.TabIndex = 7
        Me.btnCalcMedia.Text = "Calcular"
        Me.btnCalcMedia.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.labelResult)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 286)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 119)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultado:"
        '
        'labelResult
        '
        Me.labelResult.AutoSize = True
        Me.labelResult.Location = New System.Drawing.Point(7, 27)
        Me.labelResult.Name = "labelResult"
        Me.labelResult.Size = New System.Drawing.Size(0, 19)
        Me.labelResult.TabIndex = 0
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(558, 15)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(125, 43)
        Me.btnGoBack.TabIndex = 9
        Me.btnGoBack.Text = "Regresar"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'Problema3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "Problema3"
        Me.Text = "Problema 3"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents labelPrecioProducto1 As Label
    Friend WithEvents textBoxProducto1 As TextBox
    Friend WithEvents labelPrecioProducto2 As Label
    Friend WithEvents textBoxProducto2 As TextBox
    Friend WithEvents labelPrecioProducto3 As Label
    Friend WithEvents textBoxProducto3 As TextBox
    Friend WithEvents btnCalcMedia As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents labelResult As Label
    Friend WithEvents btnGoBack As Button
End Class
