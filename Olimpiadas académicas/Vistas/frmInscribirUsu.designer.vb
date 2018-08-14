<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInscribirUsu
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
        Me.btInscribir = New System.Windows.Forms.Button()
        Me.cbCategorias = New System.Windows.Forms.ComboBox()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumOportunidades = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbEntidades = New System.Windows.Forms.ComboBox()
        CType(Me.NumOportunidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btInscribir
        '
        Me.btInscribir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInscribir.Location = New System.Drawing.Point(175, 160)
        Me.btInscribir.Name = "btInscribir"
        Me.btInscribir.Size = New System.Drawing.Size(126, 33)
        Me.btInscribir.TabIndex = 0
        Me.btInscribir.Text = "Inscribir"
        Me.btInscribir.UseVisualStyleBackColor = True
        '
        'cbCategorias
        '
        Me.cbCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategorias.FormattingEnabled = True
        Me.cbCategorias.Location = New System.Drawing.Point(161, 37)
        Me.cbCategorias.Name = "cbCategorias"
        Me.cbCategorias.Size = New System.Drawing.Size(125, 24)
        Me.cbCategorias.TabIndex = 1
        '
        'btCancelar
        '
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.Location = New System.Drawing.Point(43, 160)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(126, 33)
        Me.btCancelar.TabIndex = 2
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Categoría"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Oportunidades"
        '
        'NumOportunidades
        '
        Me.NumOportunidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumOportunidades.Location = New System.Drawing.Point(171, 114)
        Me.NumOportunidades.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumOportunidades.Name = "NumOportunidades"
        Me.NumOportunidades.Size = New System.Drawing.Size(49, 22)
        Me.NumOportunidades.TabIndex = 5
        Me.NumOportunidades.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Entidades"
        '
        'cbEntidades
        '
        Me.cbEntidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEntidades.FormattingEnabled = True
        Me.cbEntidades.Location = New System.Drawing.Point(161, 74)
        Me.cbEntidades.Name = "cbEntidades"
        Me.cbEntidades.Size = New System.Drawing.Size(125, 24)
        Me.cbEntidades.TabIndex = 7
        '
        'frmInscribirUsu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 205)
        Me.Controls.Add(Me.cbEntidades)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumOportunidades)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.cbCategorias)
        Me.Controls.Add(Me.btInscribir)
        Me.Name = "frmInscribirUsu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inscribir usuario a categoria"
        CType(Me.NumOportunidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btInscribir As System.Windows.Forms.Button
    Friend WithEvents cbCategorias As System.Windows.Forms.ComboBox
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumOportunidades As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbEntidades As System.Windows.Forms.ComboBox
End Class
