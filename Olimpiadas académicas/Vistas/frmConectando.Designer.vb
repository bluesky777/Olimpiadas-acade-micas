<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConectando
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConectando))
        Me.btReiciarSesion = New System.Windows.Forms.Button()
        Me.lbBienvenido = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbTipoExamen = New System.Windows.Forms.Label()
        Me.lbtituloCatIns = New System.Windows.Forms.Label()
        Me.lbTemporal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbTotalPreg = New System.Windows.Forms.Label()
        Me.lbRespCorrectas = New System.Windows.Forms.Label()
        Me.lbRespInorrectas = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbPuntaje = New System.Windows.Forms.Label()
        Me.lbTiempo = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtConversa = New System.Windows.Forms.TextBox()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.btEnviar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbContestadas = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lkbElimTest = New System.Windows.Forms.LinkLabel()
        Me.LtExamenes = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btResultados = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbOportunidades = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbCatIns = New System.Windows.Forms.Label()
        Me.btIniciar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LtCategEmp = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.timerStatusStrip = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btReiciarSesion
        '
        Me.btReiciarSesion.Location = New System.Drawing.Point(28, 447)
        Me.btReiciarSesion.Name = "btReiciarSesion"
        Me.btReiciarSesion.Size = New System.Drawing.Size(89, 39)
        Me.btReiciarSesion.TabIndex = 4
        Me.btReiciarSesion.Text = "Reiniciar sesión"
        Me.btReiciarSesion.UseVisualStyleBackColor = True
        '
        'lbBienvenido
        '
        Me.lbBienvenido.AutoSize = True
        Me.lbBienvenido.BackColor = System.Drawing.Color.Transparent
        Me.lbBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBienvenido.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbBienvenido.Location = New System.Drawing.Point(8, 9)
        Me.lbBienvenido.Name = "lbBienvenido"
        Me.lbBienvenido.Size = New System.Drawing.Size(115, 24)
        Me.lbBienvenido.TabIndex = 10
        Me.lbBienvenido.Text = "Bienvenido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(56, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tipo de examen: "
        '
        'lbTipoExamen
        '
        Me.lbTipoExamen.AutoSize = True
        Me.lbTipoExamen.BackColor = System.Drawing.Color.Transparent
        Me.lbTipoExamen.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipoExamen.Location = New System.Drawing.Point(162, 43)
        Me.lbTipoExamen.Name = "lbTipoExamen"
        Me.lbTipoExamen.Size = New System.Drawing.Size(142, 18)
        Me.lbTipoExamen.TabIndex = 10
        Me.lbTipoExamen.Text = "Básico - Experto"
        '
        'lbtituloCatIns
        '
        Me.lbtituloCatIns.AutoSize = True
        Me.lbtituloCatIns.BackColor = System.Drawing.Color.Transparent
        Me.lbtituloCatIns.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtituloCatIns.Location = New System.Drawing.Point(48, 64)
        Me.lbtituloCatIns.Name = "lbtituloCatIns"
        Me.lbtituloCatIns.Size = New System.Drawing.Size(274, 17)
        Me.lbtituloCatIns.TabIndex = 17
        Me.lbtituloCatIns.Text = "Selecciona el examen que deseas realizar"
        '
        'lbTemporal
        '
        Me.lbTemporal.AutoSize = True
        Me.lbTemporal.Enabled = False
        Me.lbTemporal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTemporal.Location = New System.Drawing.Point(280, 196)
        Me.lbTemporal.Name = "lbTemporal"
        Me.lbTemporal.Size = New System.Drawing.Size(30, 13)
        Me.lbTemporal.TabIndex = 15
        Me.lbTemporal.Text = "valor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Espere a que el Manager inicie el Test"
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
        'lbRespCorrectas
        '
        Me.lbRespCorrectas.AutoSize = True
        Me.lbRespCorrectas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRespCorrectas.ForeColor = System.Drawing.Color.Blue
        Me.lbRespCorrectas.Location = New System.Drawing.Point(223, 91)
        Me.lbRespCorrectas.Name = "lbRespCorrectas"
        Me.lbRespCorrectas.Size = New System.Drawing.Size(21, 24)
        Me.lbRespCorrectas.TabIndex = 17
        Me.lbRespCorrectas.Text = "0"
        '
        'lbRespInorrectas
        '
        Me.lbRespInorrectas.AutoSize = True
        Me.lbRespInorrectas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRespInorrectas.ForeColor = System.Drawing.Color.Red
        Me.lbRespInorrectas.Location = New System.Drawing.Point(223, 126)
        Me.lbRespInorrectas.Name = "lbRespInorrectas"
        Me.lbRespInorrectas.Size = New System.Drawing.Size(21, 24)
        Me.lbRespInorrectas.TabIndex = 18
        Me.lbRespInorrectas.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(68, 359)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 25)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Puntaje:"
        '
        'lbPuntaje
        '
        Me.lbPuntaje.AutoSize = True
        Me.lbPuntaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPuntaje.Location = New System.Drawing.Point(172, 352)
        Me.lbPuntaje.Name = "lbPuntaje"
        Me.lbPuntaje.Size = New System.Drawing.Size(97, 36)
        Me.lbPuntaje.TabIndex = 20
        Me.lbPuntaje.Text = "100%"
        '
        'lbTiempo
        '
        Me.lbTiempo.AutoSize = True
        Me.lbTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTiempo.Location = New System.Drawing.Point(223, 162)
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
        'txtConversa
        '
        Me.txtConversa.Location = New System.Drawing.Point(24, 19)
        Me.txtConversa.Multiline = True
        Me.txtConversa.Name = "txtConversa"
        Me.txtConversa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConversa.Size = New System.Drawing.Size(257, 86)
        Me.txtConversa.TabIndex = 23
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(23, 125)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(190, 20)
        Me.txtMensaje.TabIndex = 0
        '
        'btEnviar
        '
        Me.btEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEnviar.Location = New System.Drawing.Point(220, 115)
        Me.btEnviar.Name = "btEnviar"
        Me.btEnviar.Size = New System.Drawing.Size(55, 38)
        Me.btEnviar.TabIndex = 1
        Me.btEnviar.Text = "Enviar"
        Me.btEnviar.UseVisualStyleBackColor = True
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
        Me.Panel1.Location = New System.Drawing.Point(25, 126)
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(370, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(343, 409)
        Me.Panel2.TabIndex = 28
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lkbElimTest)
        Me.Panel3.Controls.Add(Me.LtExamenes)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.lbPuntaje)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(330, 394)
        Me.Panel3.TabIndex = 28
        '
        'lkbElimTest
        '
        Me.lkbElimTest.AutoSize = True
        Me.lkbElimTest.Location = New System.Drawing.Point(118, 67)
        Me.lkbElimTest.Name = "lkbElimTest"
        Me.lkbElimTest.Size = New System.Drawing.Size(63, 13)
        Me.lkbElimTest.TabIndex = 42
        Me.lkbElimTest.TabStop = True
        Me.lkbElimTest.Text = "Eliminar test"
        '
        'LtExamenes
        '
        Me.LtExamenes.FormattingEnabled = True
        Me.LtExamenes.Location = New System.Drawing.Point(187, 38)
        Me.LtExamenes.Name = "LtExamenes"
        Me.LtExamenes.Size = New System.Drawing.Size(123, 82)
        Me.LtExamenes.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Exámenes realizados"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(43, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(227, 29)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Puntaje exámenes"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btEnviar)
        Me.GroupBox3.Controls.Add(Me.txtMensaje)
        Me.GroupBox3.Controls.Add(Me.txtConversa)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 282)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(294, 159)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chat (Solo si el manager está conectado)"
        '
        'btResultados
        '
        Me.btResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btResultados.Location = New System.Drawing.Point(248, 447)
        Me.btResultados.Name = "btResultados"
        Me.btResultados.Size = New System.Drawing.Size(74, 39)
        Me.btResultados.TabIndex = 2
        Me.btResultados.Text = "Actualizar"
        Me.btResultados.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Olimpiadas_académicas.My.Resources.Resources.LogoAOL
        Me.PictureBox1.Location = New System.Drawing.Point(608, 419)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'lbOportunidades
        '
        Me.lbOportunidades.AutoSize = True
        Me.lbOportunidades.BackColor = System.Drawing.Color.Transparent
        Me.lbOportunidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOportunidades.Location = New System.Drawing.Point(136, 161)
        Me.lbOportunidades.Name = "lbOportunidades"
        Me.lbOportunidades.Size = New System.Drawing.Size(16, 17)
        Me.lbOportunidades.TabIndex = 36
        Me.lbOportunidades.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(56, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Oportunidades:"
        '
        'lbCatIns
        '
        Me.lbCatIns.AutoSize = True
        Me.lbCatIns.BackColor = System.Drawing.Color.Transparent
        Me.lbCatIns.Location = New System.Drawing.Point(283, 165)
        Me.lbCatIns.Name = "lbCatIns"
        Me.lbCatIns.Size = New System.Drawing.Size(13, 13)
        Me.lbCatIns.TabIndex = 38
        Me.lbCatIns.Text = "0"
        '
        'btIniciar
        '
        Me.btIniciar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btIniciar.Location = New System.Drawing.Point(106, 220)
        Me.btIniciar.Name = "btIniciar"
        Me.btIniciar.Size = New System.Drawing.Size(136, 56)
        Me.btIniciar.TabIndex = 39
        Me.btIniciar.Text = "Iniciar"
        Me.btIniciar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(52, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(283, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "______________________________________________"
        '
        'LtCategEmp
        '
        Me.LtCategEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LtCategEmp.FormattingEnabled = True
        Me.LtCategEmp.ItemHeight = 16
        Me.LtCategEmp.Location = New System.Drawing.Point(106, 84)
        Me.LtCategEmp.Name = "LtCategEmp"
        Me.LtCategEmp.Size = New System.Drawing.Size(149, 68)
        Me.LtCategEmp.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(201, 165)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Cod Inscripción:"
        '
        'timerStatusStrip
        '
        Me.timerStatusStrip.Enabled = True
        Me.timerStatusStrip.Interval = 10000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 494)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(734, 22)
        Me.StatusStrip1.TabIndex = 42
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(49, 17)
        Me.ToolStripStatusLabel1.Text = "Iniciado"
        '
        'frmConectando
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Olimpiadas_académicas.My.Resources.Resources.FondoDos
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 516)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LtCategEmp)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btIniciar)
        Me.Controls.Add(Me.lbCatIns)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbOportunidades)
        Me.Controls.Add(Me.lbtituloCatIns)
        Me.Controls.Add(Me.lbTemporal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbTipoExamen)
        Me.Controls.Add(Me.btResultados)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbBienvenido)
        Me.Controls.Add(Me.btReiciarSesion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConectando"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio del examen - Bienvenido"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btReiciarSesion As System.Windows.Forms.Button
    Friend WithEvents lbBienvenido As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbTipoExamen As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbTotalPreg As System.Windows.Forms.Label
    Friend WithEvents lbRespCorrectas As System.Windows.Forms.Label
    Friend WithEvents lbRespInorrectas As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbPuntaje As System.Windows.Forms.Label
    Friend WithEvents lbTiempo As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtConversa As System.Windows.Forms.TextBox
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents btEnviar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btResultados As System.Windows.Forms.Button
    Friend WithEvents lbTemporal As System.Windows.Forms.Label
    Friend WithEvents lbContestadas As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbtituloCatIns As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbOportunidades As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbCatIns As System.Windows.Forms.Label
    Friend WithEvents btIniciar As System.Windows.Forms.Button
    Friend WithEvents LtExamenes As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LtCategEmp As System.Windows.Forms.ListBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lkbElimTest As System.Windows.Forms.LinkLabel
    Friend WithEvents timerStatusStrip As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
