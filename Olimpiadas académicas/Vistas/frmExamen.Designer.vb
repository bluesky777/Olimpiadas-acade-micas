<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExamen))
        Me.TimerCompleto = New System.Windows.Forms.Timer(Me.components)
        Me.PanelPreg = New System.Windows.Forms.Panel()
        Me.lbPregunta = New System.Windows.Forms.Label()
        Me.PanelRespCorr = New System.Windows.Forms.Panel()
        Me.LbCorrecta = New System.Windows.Forms.Label()
        Me.PanelResp2 = New System.Windows.Forms.Panel()
        Me.LbResp2 = New System.Windows.Forms.Label()
        Me.PanelResp3 = New System.Windows.Forms.Panel()
        Me.LbResp3 = New System.Windows.Forms.Label()
        Me.PanelResp4 = New System.Windows.Forms.Panel()
        Me.LbResp4 = New System.Windows.Forms.Label()
        Me.lbTiempo = New System.Windows.Forms.Label()
        Me.lbSegTotal = New System.Windows.Forms.Label()
        Me.GroupOcultar = New System.Windows.Forms.GroupBox()
        Me.LbIncorrectas = New System.Windows.Forms.Label()
        Me.lbCorrectas = New System.Windows.Forms.Label()
        Me.lbPregId = New System.Windows.Forms.Label()
        Me.lbOrdenResp = New System.Windows.Forms.Label()
        Me.lbSegPreg = New System.Windows.Forms.Label()
        Me.txtConversa = New System.Windows.Forms.TextBox()
        Me.lbInformacion = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbMensaje = New System.Windows.Forms.Label()
        Me.lbCategoria = New System.Windows.Forms.Label()
        Me.PanelPreg.SuspendLayout()
        Me.PanelRespCorr.SuspendLayout()
        Me.PanelResp2.SuspendLayout()
        Me.PanelResp3.SuspendLayout()
        Me.PanelResp4.SuspendLayout()
        Me.GroupOcultar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerCompleto
        '
        Me.TimerCompleto.Interval = 1000
        '
        'PanelPreg
        '
        Me.PanelPreg.BackColor = System.Drawing.Color.Transparent
        Me.PanelPreg.Controls.Add(Me.lbPregunta)
        Me.PanelPreg.Location = New System.Drawing.Point(137, 204)
        Me.PanelPreg.Name = "PanelPreg"
        Me.PanelPreg.Size = New System.Drawing.Size(610, 152)
        Me.PanelPreg.TabIndex = 13
        '
        'lbPregunta
        '
        Me.lbPregunta.AutoSize = True
        Me.lbPregunta.BackColor = System.Drawing.Color.Transparent
        Me.lbPregunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPregunta.Location = New System.Drawing.Point(298, 71)
        Me.lbPregunta.Name = "lbPregunta"
        Me.lbPregunta.Size = New System.Drawing.Size(66, 17)
        Me.lbPregunta.TabIndex = 1
        Me.lbPregunta.Text = "Pregunta"
        Me.lbPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelRespCorr
        '
        Me.PanelRespCorr.BackColor = System.Drawing.Color.Transparent
        Me.PanelRespCorr.Controls.Add(Me.LbCorrecta)
        Me.PanelRespCorr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelRespCorr.Location = New System.Drawing.Point(95, 381)
        Me.PanelRespCorr.Name = "PanelRespCorr"
        Me.PanelRespCorr.Size = New System.Drawing.Size(275, 84)
        Me.PanelRespCorr.TabIndex = 14
        '
        'LbCorrecta
        '
        Me.LbCorrecta.AutoSize = True
        Me.LbCorrecta.BackColor = System.Drawing.Color.Transparent
        Me.LbCorrecta.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCorrecta.Location = New System.Drawing.Point(17, 36)
        Me.LbCorrecta.Name = "LbCorrecta"
        Me.LbCorrecta.Size = New System.Drawing.Size(112, 17)
        Me.LbCorrecta.TabIndex = 2
        Me.LbCorrecta.Text = "Repuesta correcta"
        Me.LbCorrecta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelResp2
        '
        Me.PanelResp2.BackColor = System.Drawing.Color.Transparent
        Me.PanelResp2.Controls.Add(Me.LbResp2)
        Me.PanelResp2.Location = New System.Drawing.Point(567, 381)
        Me.PanelResp2.Name = "PanelResp2"
        Me.PanelResp2.Size = New System.Drawing.Size(268, 84)
        Me.PanelResp2.TabIndex = 15
        '
        'LbResp2
        '
        Me.LbResp2.AutoSize = True
        Me.LbResp2.BackColor = System.Drawing.Color.Transparent
        Me.LbResp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbResp2.Location = New System.Drawing.Point(168, 18)
        Me.LbResp2.Name = "LbResp2"
        Me.LbResp2.Size = New System.Drawing.Size(103, 17)
        Me.LbResp2.TabIndex = 3
        Me.LbResp2.Text = "Respuesta dos"
        Me.LbResp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelResp3
        '
        Me.PanelResp3.BackColor = System.Drawing.Color.Transparent
        Me.PanelResp3.Controls.Add(Me.LbResp3)
        Me.PanelResp3.Location = New System.Drawing.Point(95, 490)
        Me.PanelResp3.Name = "PanelResp3"
        Me.PanelResp3.Size = New System.Drawing.Size(275, 84)
        Me.PanelResp3.TabIndex = 16
        '
        'LbResp3
        '
        Me.LbResp3.AutoSize = True
        Me.LbResp3.BackColor = System.Drawing.Color.Transparent
        Me.LbResp3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbResp3.Location = New System.Drawing.Point(84, 0)
        Me.LbResp3.Name = "LbResp3"
        Me.LbResp3.Size = New System.Drawing.Size(104, 17)
        Me.LbResp3.TabIndex = 4
        Me.LbResp3.Text = "Respuesta tres"
        Me.LbResp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelResp4
        '
        Me.PanelResp4.BackColor = System.Drawing.Color.Transparent
        Me.PanelResp4.Controls.Add(Me.LbResp4)
        Me.PanelResp4.Location = New System.Drawing.Point(567, 490)
        Me.PanelResp4.Name = "PanelResp4"
        Me.PanelResp4.Size = New System.Drawing.Size(268, 84)
        Me.PanelResp4.TabIndex = 17
        '
        'LbResp4
        '
        Me.LbResp4.AutoSize = True
        Me.LbResp4.BackColor = System.Drawing.Color.Transparent
        Me.LbResp4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbResp4.Location = New System.Drawing.Point(168, 59)
        Me.LbResp4.Name = "LbResp4"
        Me.LbResp4.Size = New System.Drawing.Size(120, 17)
        Me.LbResp4.TabIndex = 5
        Me.LbResp4.Text = "Respuesta cuatro"
        Me.LbResp4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbTiempo
        '
        Me.lbTiempo.AutoSize = True
        Me.lbTiempo.BackColor = System.Drawing.Color.Transparent
        Me.lbTiempo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTiempo.Location = New System.Drawing.Point(442, 4)
        Me.lbTiempo.Name = "lbTiempo"
        Me.lbTiempo.Size = New System.Drawing.Size(27, 29)
        Me.lbTiempo.TabIndex = 33
        Me.lbTiempo.Text = "0"
        '
        'lbSegTotal
        '
        Me.lbSegTotal.AutoSize = True
        Me.lbSegTotal.BackColor = System.Drawing.Color.Transparent
        Me.lbSegTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSegTotal.Location = New System.Drawing.Point(65, 16)
        Me.lbSegTotal.Name = "lbSegTotal"
        Me.lbSegTotal.Size = New System.Drawing.Size(18, 20)
        Me.lbSegTotal.TabIndex = 27
        Me.lbSegTotal.Text = "0"
        '
        'GroupOcultar
        '
        Me.GroupOcultar.BackColor = System.Drawing.Color.Transparent
        Me.GroupOcultar.Controls.Add(Me.LbIncorrectas)
        Me.GroupOcultar.Controls.Add(Me.lbCorrectas)
        Me.GroupOcultar.Controls.Add(Me.lbPregId)
        Me.GroupOcultar.Controls.Add(Me.lbOrdenResp)
        Me.GroupOcultar.Controls.Add(Me.lbSegPreg)
        Me.GroupOcultar.Controls.Add(Me.lbSegTotal)
        Me.GroupOcultar.Location = New System.Drawing.Point(1174, 96)
        Me.GroupOcultar.Name = "GroupOcultar"
        Me.GroupOcultar.Size = New System.Drawing.Size(146, 171)
        Me.GroupOcultar.TabIndex = 21
        Me.GroupOcultar.TabStop = False
        '
        'LbIncorrectas
        '
        Me.LbIncorrectas.AutoSize = True
        Me.LbIncorrectas.Location = New System.Drawing.Point(25, 152)
        Me.LbIncorrectas.Name = "LbIncorrectas"
        Me.LbIncorrectas.Size = New System.Drawing.Size(13, 13)
        Me.LbIncorrectas.TabIndex = 44
        Me.LbIncorrectas.Text = "0"
        '
        'lbCorrectas
        '
        Me.lbCorrectas.AutoSize = True
        Me.lbCorrectas.Location = New System.Drawing.Point(25, 131)
        Me.lbCorrectas.Name = "lbCorrectas"
        Me.lbCorrectas.Size = New System.Drawing.Size(13, 13)
        Me.lbCorrectas.TabIndex = 43
        Me.lbCorrectas.Text = "0"
        '
        'lbPregId
        '
        Me.lbPregId.AutoSize = True
        Me.lbPregId.Location = New System.Drawing.Point(25, 111)
        Me.lbPregId.Name = "lbPregId"
        Me.lbPregId.Size = New System.Drawing.Size(13, 13)
        Me.lbPregId.TabIndex = 42
        Me.lbPregId.Text = "1"
        '
        'lbOrdenResp
        '
        Me.lbOrdenResp.AutoSize = True
        Me.lbOrdenResp.Location = New System.Drawing.Point(25, 88)
        Me.lbOrdenResp.Name = "lbOrdenResp"
        Me.lbOrdenResp.Size = New System.Drawing.Size(90, 13)
        Me.lbOrdenResp.TabIndex = 41
        Me.lbOrdenResp.Text = "Orden Respuesta"
        '
        'lbSegPreg
        '
        Me.lbSegPreg.AutoSize = True
        Me.lbSegPreg.BackColor = System.Drawing.Color.Transparent
        Me.lbSegPreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSegPreg.Location = New System.Drawing.Point(65, 52)
        Me.lbSegPreg.Name = "lbSegPreg"
        Me.lbSegPreg.Size = New System.Drawing.Size(18, 20)
        Me.lbSegPreg.TabIndex = 33
        Me.lbSegPreg.Text = "0"
        '
        'txtConversa
        '
        Me.txtConversa.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtConversa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConversa.Location = New System.Drawing.Point(623, 0)
        Me.txtConversa.Multiline = True
        Me.txtConversa.Name = "txtConversa"
        Me.txtConversa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConversa.Size = New System.Drawing.Size(267, 88)
        Me.txtConversa.TabIndex = 37
        Me.txtConversa.Text = "Pregunta numero uno para ti"
        '
        'lbInformacion
        '
        Me.lbInformacion.AutoSize = True
        Me.lbInformacion.BackColor = System.Drawing.Color.Transparent
        Me.lbInformacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInformacion.Location = New System.Drawing.Point(144, 30)
        Me.lbInformacion.Name = "lbInformacion"
        Me.lbInformacion.Size = New System.Drawing.Size(81, 17)
        Me.lbInformacion.TabIndex = 38
        Me.lbInformacion.Text = "Información"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.BackColor = System.Drawing.Color.Transparent
        Me.lbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.Location = New System.Drawing.Point(133, 4)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(71, 20)
        Me.lbNombre.TabIndex = 39
        Me.lbNombre.Text = "Nombre"
        '
        'lbMensaje
        '
        Me.lbMensaje.AutoSize = True
        Me.lbMensaje.BackColor = System.Drawing.Color.Transparent
        Me.lbMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMensaje.Location = New System.Drawing.Point(156, 172)
        Me.lbMensaje.Name = "lbMensaje"
        Me.lbMensaje.Size = New System.Drawing.Size(614, 29)
        Me.lbMensaje.TabIndex = 40
        Me.lbMensaje.Text = "Espera que el manager envíe la siguiente pregunta."
        Me.lbMensaje.Visible = False
        '
        'lbCategoria
        '
        Me.lbCategoria.AutoSize = True
        Me.lbCategoria.BackColor = System.Drawing.Color.Transparent
        Me.lbCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCategoria.Location = New System.Drawing.Point(133, 78)
        Me.lbCategoria.Name = "lbCategoria"
        Me.lbCategoria.Size = New System.Drawing.Size(101, 20)
        Me.lbCategoria.TabIndex = 41
        Me.lbCategoria.Text = "lbCategoria"
        '
        'frmExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Olimpiadas_académicas.My.Resources.Resources.FondoExamen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1175, 597)
        Me.Controls.Add(Me.lbCategoria)
        Me.Controls.Add(Me.lbMensaje)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.lbInformacion)
        Me.Controls.Add(Me.txtConversa)
        Me.Controls.Add(Me.lbTiempo)
        Me.Controls.Add(Me.GroupOcultar)
        Me.Controls.Add(Me.PanelResp4)
        Me.Controls.Add(Me.PanelResp3)
        Me.Controls.Add(Me.PanelResp2)
        Me.Controls.Add(Me.PanelRespCorr)
        Me.Controls.Add(Me.PanelPreg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmExamen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Examen - IGAD"
        Me.PanelPreg.ResumeLayout(False)
        Me.PanelPreg.PerformLayout()
        Me.PanelRespCorr.ResumeLayout(False)
        Me.PanelRespCorr.PerformLayout()
        Me.PanelResp2.ResumeLayout(False)
        Me.PanelResp2.PerformLayout()
        Me.PanelResp3.ResumeLayout(False)
        Me.PanelResp3.PerformLayout()
        Me.PanelResp4.ResumeLayout(False)
        Me.PanelResp4.PerformLayout()
        Me.GroupOcultar.ResumeLayout(False)
        Me.GroupOcultar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerCompleto As System.Windows.Forms.Timer
    Friend WithEvents PanelPreg As System.Windows.Forms.Panel
    Friend WithEvents lbPregunta As System.Windows.Forms.Label
    Friend WithEvents PanelRespCorr As System.Windows.Forms.Panel
    Friend WithEvents LbCorrecta As System.Windows.Forms.Label
    Friend WithEvents PanelResp2 As System.Windows.Forms.Panel
    Friend WithEvents LbResp2 As System.Windows.Forms.Label
    Friend WithEvents PanelResp3 As System.Windows.Forms.Panel
    Friend WithEvents LbResp3 As System.Windows.Forms.Label
    Friend WithEvents PanelResp4 As System.Windows.Forms.Panel
    Friend WithEvents LbResp4 As System.Windows.Forms.Label
    Friend WithEvents lbTiempo As System.Windows.Forms.Label
    Friend WithEvents lbSegTotal As System.Windows.Forms.Label
    Friend WithEvents GroupOcultar As System.Windows.Forms.GroupBox

    Friend WithEvents lbSegPreg As System.Windows.Forms.Label
    Friend WithEvents LbIncorrectas As System.Windows.Forms.Label
    Friend WithEvents lbCorrectas As System.Windows.Forms.Label
    Friend WithEvents lbPregId As System.Windows.Forms.Label
    Friend WithEvents lbOrdenResp As System.Windows.Forms.Label
    Friend WithEvents txtConversa As System.Windows.Forms.TextBox
    Friend WithEvents lbInformacion As System.Windows.Forms.Label
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents lbMensaje As System.Windows.Forms.Label
    Friend WithEvents lbCategoria As System.Windows.Forms.Label
End Class
