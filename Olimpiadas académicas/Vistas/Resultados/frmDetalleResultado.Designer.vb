<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleResultado
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
        Me.DataDetalles = New System.Windows.Forms.DataGridView()
        Me.cbUsuario = New System.Windows.Forms.ComboBox()
        Me.cbExamen = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelResultados = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbContestadas = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbTiempo = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbRespInorrectas = New System.Windows.Forms.Label()
        Me.lbRespCorrectas = New System.Windows.Forms.Label()
        Me.lbTotalPreg = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbPuntaje = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelResultados.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataDetalles
        '
        Me.DataDetalles.AllowUserToAddRows = False
        Me.DataDetalles.AllowUserToDeleteRows = False
        Me.DataDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataDetalles.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataDetalles.Location = New System.Drawing.Point(12, 208)
        Me.DataDetalles.Name = "DataDetalles"
        Me.DataDetalles.Size = New System.Drawing.Size(645, 316)
        Me.DataDetalles.TabIndex = 0
        '
        'cbUsuario
        '
        Me.cbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUsuario.FormattingEnabled = True
        Me.cbUsuario.Location = New System.Drawing.Point(262, 78)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Size = New System.Drawing.Size(247, 32)
        Me.cbUsuario.TabIndex = 1
        '
        'cbExamen
        '
        Me.cbExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbExamen.FormattingEnabled = True
        Me.cbExamen.Location = New System.Drawing.Point(262, 125)
        Me.cbExamen.Name = "cbExamen"
        Me.cbExamen.Size = New System.Drawing.Size(247, 28)
        Me.cbExamen.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Participante"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Examen"
        '
        'PanelResultados
        '
        Me.PanelResultados.AutoScroll = True
        Me.PanelResultados.BackColor = System.Drawing.Color.Transparent
        Me.PanelResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelResultados.Controls.Add(Me.Label8)
        Me.PanelResultados.Controls.Add(Me.Panel1)
        Me.PanelResultados.Controls.Add(Me.lbPuntaje)
        Me.PanelResultados.Controls.Add(Me.Label16)
        Me.PanelResultados.Location = New System.Drawing.Point(686, 137)
        Me.PanelResultados.Name = "PanelResultados"
        Me.PanelResultados.Size = New System.Drawing.Size(330, 360)
        Me.PanelResultados.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(275, 29)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Resultado del Examen"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbContestadas)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lbTiempo)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.lbRespInorrectas)
        Me.Panel1.Controls.Add(Me.lbRespCorrectas)
        Me.Panel1.Controls.Add(Me.lbTotalPreg)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(22, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(289, 207)
        Me.Panel1.TabIndex = 27
        '
        'lbContestadas
        '
        Me.lbContestadas.AutoSize = True
        Me.lbContestadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbContestadas.Location = New System.Drawing.Point(223, 53)
        Me.lbContestadas.Name = "lbContestadas"
        Me.lbContestadas.Size = New System.Drawing.Size(21, 24)
        Me.lbContestadas.TabIndex = 24
        Me.lbContestadas.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Respuestas contestadas"
        '
        'lbTiempo
        '
        Me.lbTiempo.AutoSize = True
        Me.lbTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTiempo.Location = New System.Drawing.Point(224, 156)
        Me.lbTiempo.Name = "lbTiempo"
        Me.lbTiempo.Size = New System.Drawing.Size(21, 24)
        Me.lbTiempo.TabIndex = 22
        Me.lbTiempo.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(21, 162)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 20)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Tiempo"
        '
        'lbRespInorrectas
        '
        Me.lbRespInorrectas.AutoSize = True
        Me.lbRespInorrectas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRespInorrectas.Location = New System.Drawing.Point(223, 126)
        Me.lbRespInorrectas.Name = "lbRespInorrectas"
        Me.lbRespInorrectas.Size = New System.Drawing.Size(21, 24)
        Me.lbRespInorrectas.TabIndex = 18
        Me.lbRespInorrectas.Text = "0"
        '
        'lbRespCorrectas
        '
        Me.lbRespCorrectas.AutoSize = True
        Me.lbRespCorrectas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRespCorrectas.Location = New System.Drawing.Point(223, 87)
        Me.lbRespCorrectas.Name = "lbRespCorrectas"
        Me.lbRespCorrectas.Size = New System.Drawing.Size(21, 24)
        Me.lbRespCorrectas.TabIndex = 17
        Me.lbRespCorrectas.Text = "0"
        '
        'lbTotalPreg
        '
        Me.lbTotalPreg.AutoSize = True
        Me.lbTotalPreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalPreg.Location = New System.Drawing.Point(223, 11)
        Me.lbTotalPreg.Name = "lbTotalPreg"
        Me.lbTotalPreg.Size = New System.Drawing.Size(21, 24)
        Me.lbTotalPreg.TabIndex = 16
        Me.lbTotalPreg.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(181, 20)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Respuestas incorrectas:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(169, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Respuestas correctas:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Total preguntas:"
        '
        'lbPuntaje
        '
        Me.lbPuntaje.AutoSize = True
        Me.lbPuntaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPuntaje.Location = New System.Drawing.Point(179, 308)
        Me.lbPuntaje.Name = "lbPuntaje"
        Me.lbPuntaje.Size = New System.Drawing.Size(93, 36)
        Me.lbPuntaje.TabIndex = 20
        Me.lbPuntaje.Text = "100%"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(68, 315)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 25)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Puntaje:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(116, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(357, 24)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Seleccione el usuario que desea detallar."
        '
        'frmDetalleResultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Olimpiadas_académicas.My.Resources.Resources.FondoDos
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1028, 535)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PanelResultados)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbExamen)
        Me.Controls.Add(Me.cbUsuario)
        Me.Controls.Add(Me.DataDetalles)
        Me.Name = "frmDetalleResultado"
        Me.Text = "Ver exámenes de cada usuarios."
        CType(Me.DataDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelResultados.ResumeLayout(False)
        Me.PanelResultados.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents cbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents cbExamen As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PanelResultados As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbContestadas As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbTiempo As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lbRespInorrectas As System.Windows.Forms.Label
    Friend WithEvents lbRespCorrectas As System.Windows.Forms.Label
    Friend WithEvents lbTotalPreg As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbPuntaje As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
