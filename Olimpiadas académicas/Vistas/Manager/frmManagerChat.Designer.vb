<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManagerChat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManagerChat))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.btEnviar = New System.Windows.Forms.Button()
        Me.txtConversa = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btSiguiente = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pbPrevio = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btActivarPublico = New System.Windows.Forms.Button()
        Me.btCerrarUsuarios = New System.Windows.Forms.Button()
        Me.btAtras = New System.Windows.Forms.Button()
        Me.btCerrarPublico = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.btParticipantes = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbCantPreg = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NumericActual = New System.Windows.Forms.NumericUpDown()
        Me.chkActual = New System.Windows.Forms.CheckBox()
        Me.lkbSelecCats = New System.Windows.Forms.LinkLabel()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ltCategAMostrar = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbOrdenResp = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        CType(Me.pbPrevio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericActual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.txtMensaje)
        Me.GroupBox5.Controls.Add(Me.btEnviar)
        Me.GroupBox5.Controls.Add(Me.txtConversa)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(337, 265)
        Me.GroupBox5.TabIndex = 36
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Mensajería instantanea."
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(19, 214)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensaje.Size = New System.Drawing.Size(207, 38)
        Me.txtMensaje.TabIndex = 0
        '
        'btEnviar
        '
        Me.btEnviar.Location = New System.Drawing.Point(232, 214)
        Me.btEnviar.Name = "btEnviar"
        Me.btEnviar.Size = New System.Drawing.Size(91, 28)
        Me.btEnviar.TabIndex = 1
        Me.btEnviar.Text = "Enviar"
        Me.btEnviar.UseVisualStyleBackColor = True
        '
        'txtConversa
        '
        Me.txtConversa.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtConversa.Location = New System.Drawing.Point(19, 20)
        Me.txtConversa.Multiline = True
        Me.txtConversa.Name = "txtConversa"
        Me.txtConversa.ReadOnly = True
        Me.txtConversa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConversa.Size = New System.Drawing.Size(304, 188)
        Me.txtConversa.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(205, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 56)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Comenzar examen"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btSiguiente
        '
        Me.btSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSiguiente.Location = New System.Drawing.Point(30, 184)
        Me.btSiguiente.Name = "btSiguiente"
        Me.btSiguiente.Size = New System.Drawing.Size(93, 61)
        Me.btSiguiente.TabIndex = 39
        Me.btSiguiente.Text = "Siguiente pregunta"
        Me.btSiguiente.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(179, 437)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 45)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Mostrar pregunta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'pbPrevio
        '
        Me.pbPrevio.Image = Global.Olimpiadas_académicas.My.Resources.Resources.FondoDos
        Me.pbPrevio.Location = New System.Drawing.Point(190, 12)
        Me.pbPrevio.Name = "pbPrevio"
        Me.pbPrevio.Size = New System.Drawing.Size(149, 121)
        Me.pbPrevio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPrevio.TabIndex = 42
        Me.pbPrevio.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 15)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "De clic sobre la imagen para cambiarla."
        '
        'btActivarPublico
        '
        Me.btActivarPublico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btActivarPublico.Location = New System.Drawing.Point(24, 47)
        Me.btActivarPublico.Name = "btActivarPublico"
        Me.btActivarPublico.Size = New System.Drawing.Size(115, 29)
        Me.btActivarPublico.TabIndex = 44
        Me.btActivarPublico.Text = "Mostrar imágen"
        Me.btActivarPublico.UseVisualStyleBackColor = True
        '
        'btCerrarUsuarios
        '
        Me.btCerrarUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCerrarUsuarios.ForeColor = System.Drawing.Color.Maroon
        Me.btCerrarUsuarios.Location = New System.Drawing.Point(257, 184)
        Me.btCerrarUsuarios.Name = "btCerrarUsuarios"
        Me.btCerrarUsuarios.Size = New System.Drawing.Size(112, 61)
        Me.btCerrarUsuarios.TabIndex = 46
        Me.btCerrarUsuarios.Text = "Forzar cierre de usuarios"
        Me.btCerrarUsuarios.UseVisualStyleBackColor = True
        '
        'btAtras
        '
        Me.btAtras.Location = New System.Drawing.Point(18, 12)
        Me.btAtras.Name = "btAtras"
        Me.btAtras.Size = New System.Drawing.Size(104, 38)
        Me.btAtras.TabIndex = 47
        Me.btAtras.Text = "Atrás"
        Me.btAtras.UseVisualStyleBackColor = True
        '
        'btCerrarPublico
        '
        Me.btCerrarPublico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCerrarPublico.Location = New System.Drawing.Point(24, 82)
        Me.btCerrarPublico.Name = "btCerrarPublico"
        Me.btCerrarPublico.Size = New System.Drawing.Size(115, 29)
        Me.btCerrarPublico.TabIndex = 49
        Me.btCerrarPublico.Text = "Cerrar ventanas"
        Me.btCerrarPublico.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.btParticipantes)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbCantPreg)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.btSiguiente)
        Me.GroupBox1.Controls.Add(Me.btCerrarPublico)
        Me.GroupBox1.Controls.Add(Me.btActivarPublico)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NumericActual)
        Me.GroupBox1.Controls.Add(Me.chkActual)
        Me.GroupBox1.Controls.Add(Me.btCerrarUsuarios)
        Me.GroupBox1.Controls.Add(Me.pbPrevio)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(368, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 500)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formulario público."
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(27, 118)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(115, 15)
        Me.LinkLabel2.TabIndex = 64
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Mostrar conectados"
        '
        'btParticipantes
        '
        Me.btParticipantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btParticipantes.Location = New System.Drawing.Point(129, 184)
        Me.btParticipantes.Name = "btParticipantes"
        Me.btParticipantes.Size = New System.Drawing.Size(99, 61)
        Me.btParticipantes.TabIndex = 63
        Me.btParticipantes.Text = "Mostrar participantes"
        Me.btParticipantes.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 445)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 17)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "de"
        '
        'lbCantPreg
        '
        Me.lbCantPreg.AutoSize = True
        Me.lbCantPreg.BackColor = System.Drawing.Color.Transparent
        Me.lbCantPreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCantPreg.Location = New System.Drawing.Point(150, 444)
        Me.lbCantPreg.Name = "lbCantPreg"
        Me.lbCantPreg.Size = New System.Drawing.Size(16, 17)
        Me.lbCantPreg.TabIndex = 61
        Me.lbCantPreg.Text = "0"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(281, 437)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 45)
        Me.Button4.TabIndex = 58
        Me.Button4.Text = "Cerrar preguntas"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'NumericActual
        '
        Me.NumericActual.Enabled = False
        Me.NumericActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericActual.Location = New System.Drawing.Point(72, 442)
        Me.NumericActual.Name = "NumericActual"
        Me.NumericActual.Size = New System.Drawing.Size(40, 23)
        Me.NumericActual.TabIndex = 54
        '
        'chkActual
        '
        Me.chkActual.AutoSize = True
        Me.chkActual.BackColor = System.Drawing.Color.Transparent
        Me.chkActual.Checked = True
        Me.chkActual.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActual.Location = New System.Drawing.Point(18, 417)
        Me.chkActual.Name = "chkActual"
        Me.chkActual.Size = New System.Drawing.Size(205, 19)
        Me.chkActual.TabIndex = 55
        Me.chkActual.Text = "Modificar la pregunta del público"
        Me.chkActual.UseVisualStyleBackColor = False
        '
        'lkbSelecCats
        '
        Me.lkbSelecCats.AutoSize = True
        Me.lkbSelecCats.Location = New System.Drawing.Point(192, 52)
        Me.lkbSelecCats.Name = "lkbSelecCats"
        Me.lkbSelecCats.Size = New System.Drawing.Size(72, 15)
        Me.lkbSelecCats.TabIndex = 2
        Me.lkbSelecCats.TabStop = True
        Me.lkbSelecCats.Text = "Seleccionar"
        '
        'cbCategoria
        '
        Me.cbCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(36, 49)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(150, 23)
        Me.cbCategoria.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Categoría"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LinkLabel1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.ltCategAMostrar)
        Me.GroupBox3.Controls.Add(Me.lkbSelecCats)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cbCategoria)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 334)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(337, 234)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Categorias a mostrar"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(192, 99)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(73, 15)
        Me.LinkLabel1.TabIndex = 60
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Quitar todas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 15)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Seleccionadas"
        '
        'ltCategAMostrar
        '
        Me.ltCategAMostrar.FormattingEnabled = True
        Me.ltCategAMostrar.ItemHeight = 15
        Me.ltCategAMostrar.Location = New System.Drawing.Point(36, 99)
        Me.ltCategAMostrar.Name = "ltCategAMostrar"
        Me.ltCategAMostrar.Size = New System.Drawing.Size(150, 79)
        Me.ltCategAMostrar.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(79, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 15)
        Me.Label2.TabIndex = 44
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lbOrdenResp)
        Me.GroupBox2.Location = New System.Drawing.Point(649, 527)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(74, 54)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Respuesta"
        '
        'lbOrdenResp
        '
        Me.lbOrdenResp.AutoSize = True
        Me.lbOrdenResp.Location = New System.Drawing.Point(9, 28)
        Me.lbOrdenResp.Name = "lbOrdenResp"
        Me.lbOrdenResp.Size = New System.Drawing.Size(90, 13)
        Me.lbOrdenResp.TabIndex = 41
        Me.lbOrdenResp.Text = "Orden Respuesta"
        '
        'frmManagerChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Olimpiadas_académicas.My.Resources.Resources.FondoDos
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(798, 610)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btAtras)
        Me.Controls.Add(Me.GroupBox5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmManagerChat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dirigidor de examen."
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.pbPrevio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericActual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents btEnviar As System.Windows.Forms.Button
    Friend WithEvents txtConversa As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btSiguiente As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents pbPrevio As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btActivarPublico As System.Windows.Forms.Button
    Friend WithEvents btCerrarUsuarios As System.Windows.Forms.Button
    Friend WithEvents btAtras As System.Windows.Forms.Button
    Friend WithEvents btCerrarPublico As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericActual As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkActual As System.Windows.Forms.CheckBox
    Friend WithEvents cbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbCantPreg As System.Windows.Forms.Label
    Friend WithEvents btParticipantes As System.Windows.Forms.Button

    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbOrdenResp As System.Windows.Forms.Label
    Friend WithEvents lkbSelecCats As System.Windows.Forms.LinkLabel
    Friend WithEvents ltCategAMostrar As System.Windows.Forms.ListBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
End Class
