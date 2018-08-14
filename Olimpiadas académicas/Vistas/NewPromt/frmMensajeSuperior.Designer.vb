<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMensajeSuperior
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
        Me.components = New System.ComponentModel.Container()
        Me.TimerAnimacion = New System.Windows.Forms.Timer(Me.components)
        Me.TimerAnimEntrada = New System.Windows.Forms.Timer(Me.components)
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.lbSubTitulo1 = New System.Windows.Forms.Label()
        Me.lbSubTitulo2 = New System.Windows.Forms.Label()
        Me.TimerAnimTitulo = New System.Windows.Forms.Timer(Me.components)
        Me.lbSubTitulo3 = New System.Windows.Forms.Label()
        Me.lbSubTitulo4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TimerAnimacion
        '
        Me.TimerAnimacion.Interval = 50
        '
        'TimerAnimEntrada
        '
        Me.TimerAnimEntrada.Interval = 40
        '
        'lbTitulo
        '
        Me.lbTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbTitulo.Location = New System.Drawing.Point(-1, 0)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(1046, 58)
        Me.lbTitulo.TabIndex = 0
        Me.lbTitulo.Text = "Este es el título de este mensaje personalizadoEste es el título de este mensaje " & _
    "personalizadoEste es el título de este mensaje personalizadoEste es el título de" & _
    " este mensaje personal  izado dfvsvsdf"
        Me.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSubTitulo1
        '
        Me.lbSubTitulo1.AutoSize = True
        Me.lbSubTitulo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSubTitulo1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbSubTitulo1.Location = New System.Drawing.Point(46, 61)
        Me.lbSubTitulo1.Name = "lbSubTitulo1"
        Me.lbSubTitulo1.Size = New System.Drawing.Size(384, 22)
        Me.lbSubTitulo1.TabIndex = 1
        Me.lbSubTitulo1.Text = "Este es el título de este mensaje personalizado"
        '
        'lbSubTitulo2
        '
        Me.lbSubTitulo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSubTitulo2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbSubTitulo2.Location = New System.Drawing.Point(610, 52)
        Me.lbSubTitulo2.Name = "lbSubTitulo2"
        Me.lbSubTitulo2.Size = New System.Drawing.Size(384, 31)
        Me.lbSubTitulo2.TabIndex = 2
        Me.lbSubTitulo2.Text = "Este es el título de este mensaje personalizado"
        '
        'TimerAnimTitulo
        '
        Me.TimerAnimTitulo.Interval = 20
        '
        'lbSubTitulo3
        '
        Me.lbSubTitulo3.AutoSize = True
        Me.lbSubTitulo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSubTitulo3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbSubTitulo3.Location = New System.Drawing.Point(46, 93)
        Me.lbSubTitulo3.Name = "lbSubTitulo3"
        Me.lbSubTitulo3.Size = New System.Drawing.Size(384, 22)
        Me.lbSubTitulo3.TabIndex = 3
        Me.lbSubTitulo3.Text = "Este es el título de este mensaje personalizado"
        '
        'lbSubTitulo4
        '
        Me.lbSubTitulo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSubTitulo4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbSubTitulo4.Location = New System.Drawing.Point(610, 74)
        Me.lbSubTitulo4.Name = "lbSubTitulo4"
        Me.lbSubTitulo4.Size = New System.Drawing.Size(384, 31)
        Me.lbSubTitulo4.TabIndex = 4
        Me.lbSubTitulo4.Text = "Este es el título de este mensaje personalizado"
        '
        'frmMensajeSuperior
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1045, 115)
        Me.Controls.Add(Me.lbSubTitulo4)
        Me.Controls.Add(Me.lbSubTitulo3)
        Me.Controls.Add(Me.lbSubTitulo2)
        Me.Controls.Add(Me.lbSubTitulo1)
        Me.Controls.Add(Me.lbTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMensajeSuperior"
        Me.Opacity = 0.8R
        Me.Text = "frmMensajeSuperior"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerAnimacion As System.Windows.Forms.Timer
    Friend WithEvents TimerAnimEntrada As System.Windows.Forms.Timer
    Friend WithEvents lbTitulo As System.Windows.Forms.Label
    Friend WithEvents lbSubTitulo1 As System.Windows.Forms.Label
    Friend WithEvents lbSubTitulo2 As System.Windows.Forms.Label
    Friend WithEvents TimerAnimTitulo As System.Windows.Forms.Timer
    Friend WithEvents lbSubTitulo3 As System.Windows.Forms.Label
    Friend WithEvents lbSubTitulo4 As System.Windows.Forms.Label
End Class
