<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColores
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
        Me.BtnRojo = New System.Windows.Forms.Button()
        Me.BtnVerde = New System.Windows.Forms.Button()
        Me.BtnNegro = New System.Windows.Forms.Button()
        Me.BtnAzul = New System.Windows.Forms.Button()
        Me.BtnAmarillo = New System.Windows.Forms.Button()
        Me.txtColores = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnRojo
        '
        Me.BtnRojo.Location = New System.Drawing.Point(131, 53)
        Me.BtnRojo.Name = "BtnRojo"
        Me.BtnRojo.Size = New System.Drawing.Size(75, 23)
        Me.BtnRojo.TabIndex = 0
        Me.BtnRojo.Text = "Rojo"
        Me.BtnRojo.UseVisualStyleBackColor = True
        '
        'BtnVerde
        '
        Me.BtnVerde.Location = New System.Drawing.Point(131, 105)
        Me.BtnVerde.Name = "BtnVerde"
        Me.BtnVerde.Size = New System.Drawing.Size(75, 23)
        Me.BtnVerde.TabIndex = 1
        Me.BtnVerde.Text = "Verde"
        Me.BtnVerde.UseVisualStyleBackColor = True
        '
        'BtnNegro
        '
        Me.BtnNegro.Location = New System.Drawing.Point(131, 156)
        Me.BtnNegro.Name = "BtnNegro"
        Me.BtnNegro.Size = New System.Drawing.Size(75, 23)
        Me.BtnNegro.TabIndex = 2
        Me.BtnNegro.Text = "Negro"
        Me.BtnNegro.UseVisualStyleBackColor = True
        '
        'BtnAzul
        '
        Me.BtnAzul.Location = New System.Drawing.Point(131, 205)
        Me.BtnAzul.Name = "BtnAzul"
        Me.BtnAzul.Size = New System.Drawing.Size(75, 23)
        Me.BtnAzul.TabIndex = 3
        Me.BtnAzul.Text = "Azul"
        Me.BtnAzul.UseVisualStyleBackColor = True
        '
        'BtnAmarillo
        '
        Me.BtnAmarillo.Location = New System.Drawing.Point(131, 256)
        Me.BtnAmarillo.Name = "BtnAmarillo"
        Me.BtnAmarillo.Size = New System.Drawing.Size(75, 23)
        Me.BtnAmarillo.TabIndex = 4
        Me.BtnAmarillo.Text = "Amarillo"
        Me.BtnAmarillo.UseVisualStyleBackColor = True
        '
        'txtColores
        '
        Me.txtColores.Location = New System.Drawing.Point(305, 39)
        Me.txtColores.Multiline = True
        Me.txtColores.Name = "txtColores"
        Me.txtColores.Size = New System.Drawing.Size(367, 255)
        Me.txtColores.TabIndex = 6
        '
        'FrmColores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(800, 364)
        Me.Controls.Add(Me.txtColores)
        Me.Controls.Add(Me.BtnAmarillo)
        Me.Controls.Add(Me.BtnAzul)
        Me.Controls.Add(Me.BtnNegro)
        Me.Controls.Add(Me.BtnVerde)
        Me.Controls.Add(Me.BtnRojo)
        Me.Name = "FrmColores"
        Me.Text = "Colores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRojo As Button
    Friend WithEvents BtnVerde As Button
    Friend WithEvents BtnNegro As Button
    Friend WithEvents BtnAzul As Button
    Friend WithEvents BtnAmarillo As Button
    Friend WithEvents txtColores As TextBox
End Class
