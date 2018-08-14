<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministrador
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministrador))
        Me.lbDescripEven = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GridPreguntas = New System.Windows.Forms.DataGridView()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtSeleccionPreg = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btDelSeleccionados = New System.Windows.Forms.Button()
        Me.btDelAll = New System.Windows.Forms.Button()
        Me.ListUsuarios = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbPermisoEmpezar = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btRestablecer = New System.Windows.Forms.Button()
        Me.DateFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.DateFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.lbCodEvent = New System.Windows.Forms.Label()
        Me.lbEvActual = New System.Windows.Forms.Label()
        Me.lbEvActivo = New System.Windows.Forms.Label()
        Me.Activo = New System.Windows.Forms.Label()
        Me.lbFechFin = New System.Windows.Forms.Label()
        Me.lbFechIni = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nuTiempoPreg = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTipoExamen = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CkTiempoTodos = New System.Windows.Forms.CheckBox()
        Me.nuTiempoExa = New System.Windows.Forms.NumericUpDown()
        Me.lbTiempoExa = New System.Windows.Forms.Label()
        Me.lbTituloEvento = New System.Windows.Forms.Label()
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReiniciarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdiciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InscripcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultadosConFechasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramaExternoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarPreguntasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarPreguntasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripAdmin = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBtUsuarios = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtCategoria = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtPreguntas = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtEntidades = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripBtResultados = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtIniciarPruebas = New System.Windows.Forms.ToolStripButton()
        Me.PctLogoEvento = New System.Windows.Forms.PictureBox()
        Me.txtEvento = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridPreguntas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.nuTiempoPreg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuTiempoExa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuPrincipal.SuspendLayout()
        Me.ToolStripAdmin.SuspendLayout()
        CType(Me.PctLogoEvento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbDescripEven
        '
        Me.lbDescripEven.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation
        Me.lbDescripEven.AutoSize = True
        Me.lbDescripEven.BackColor = System.Drawing.Color.Transparent
        Me.lbDescripEven.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbDescripEven.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescripEven.Location = New System.Drawing.Point(236, 114)
        Me.lbDescripEven.Name = "lbDescripEven"
        Me.lbDescripEven.Size = New System.Drawing.Size(86, 15)
        Me.lbDescripEven.TabIndex = 47
        Me.lbDescripEven.Text = "lbDescripEven"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridPreguntas)
        Me.GroupBox2.Controls.Add(Me.cbCategoria)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.BtSeleccionPreg)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(422, 369)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 239)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Preguntas seleccionadas"
        '
        'GridPreguntas
        '
        Me.GridPreguntas.AllowUserToAddRows = False
        Me.GridPreguntas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridPreguntas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridPreguntas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridPreguntas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.GridPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPreguntas.Location = New System.Drawing.Point(9, 56)
        Me.GridPreguntas.Name = "GridPreguntas"
        Me.GridPreguntas.ReadOnly = True
        Me.GridPreguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridPreguntas.Size = New System.Drawing.Size(422, 168)
        Me.GridPreguntas.TabIndex = 30
        '
        'cbCategoria
        '
        Me.cbCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(79, 27)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(220, 23)
        Me.cbCategoria.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Categoría"
        '
        'BtSeleccionPreg
        '
        Me.BtSeleccionPreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtSeleccionPreg.Location = New System.Drawing.Point(305, 22)
        Me.BtSeleccionPreg.Name = "BtSeleccionPreg"
        Me.BtSeleccionPreg.Size = New System.Drawing.Size(126, 28)
        Me.BtSeleccionPreg.TabIndex = 13
        Me.BtSeleccionPreg.Text = "Modificar selección"
        Me.BtSeleccionPreg.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btDelSeleccionados)
        Me.GroupBox3.Controls.Add(Me.btDelAll)
        Me.GroupBox3.Controls.Add(Me.ListUsuarios)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(422, 155)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(442, 187)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Equipos conectados"
        '
        'btDelSeleccionados
        '
        Me.btDelSeleccionados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDelSeleccionados.Location = New System.Drawing.Point(207, 157)
        Me.btDelSeleccionados.Name = "btDelSeleccionados"
        Me.btDelSeleccionados.Size = New System.Drawing.Size(131, 24)
        Me.btDelSeleccionados.TabIndex = 28
        Me.btDelSeleccionados.Text = "Borrar seleccionados"
        Me.btDelSeleccionados.UseVisualStyleBackColor = True
        '
        'btDelAll
        '
        Me.btDelAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDelAll.Location = New System.Drawing.Point(344, 157)
        Me.btDelAll.Name = "btDelAll"
        Me.btDelAll.Size = New System.Drawing.Size(92, 24)
        Me.btDelAll.TabIndex = 27
        Me.btDelAll.Text = "Borrar todos"
        Me.btDelAll.UseVisualStyleBackColor = True
        '
        'ListUsuarios
        '
        Me.ListUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListUsuarios.FormattingEnabled = True
        Me.ListUsuarios.ItemHeight = 15
        Me.ListUsuarios.Location = New System.Drawing.Point(11, 31)
        Me.ListUsuarios.Name = "ListUsuarios"
        Me.ListUsuarios.Size = New System.Drawing.Size(425, 109)
        Me.ListUsuarios.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(11, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 24)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.lbPermisoEmpezar)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.btRestablecer)
        Me.GroupBox4.Controls.Add(Me.DateFechaFin)
        Me.GroupBox4.Controls.Add(Me.DateFechaInicio)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.btGuardar)
        Me.GroupBox4.Controls.Add(Me.lbCodEvent)
        Me.GroupBox4.Controls.Add(Me.lbEvActual)
        Me.GroupBox4.Controls.Add(Me.lbEvActivo)
        Me.GroupBox4.Controls.Add(Me.Activo)
        Me.GroupBox4.Controls.Add(Me.lbFechFin)
        Me.GroupBox4.Controls.Add(Me.lbFechIni)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.nuTiempoPreg)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.cbTipoExamen)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.CkTiempoTodos)
        Me.GroupBox4.Controls.Add(Me.nuTiempoExa)
        Me.GroupBox4.Controls.Add(Me.lbTiempoExa)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 155)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(373, 453)
        Me.GroupBox4.TabIndex = 50
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Configuración del evento"
        '
        'lbPermisoEmpezar
        '
        Me.lbPermisoEmpezar.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation
        Me.lbPermisoEmpezar.AutoSize = True
        Me.lbPermisoEmpezar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbPermisoEmpezar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPermisoEmpezar.Location = New System.Drawing.Point(168, 281)
        Me.lbPermisoEmpezar.Name = "lbPermisoEmpezar"
        Me.lbPermisoEmpezar.Size = New System.Drawing.Size(27, 15)
        Me.lbPermisoEmpezar.TabIndex = 41
        Me.lbPermisoEmpezar.Text = "-----"
        '
        'Label10
        '
        Me.Label10.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 281)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 15)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Permiso para empezar:"
        '
        'btRestablecer
        '
        Me.btRestablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRestablecer.Location = New System.Drawing.Point(157, 392)
        Me.btRestablecer.Name = "btRestablecer"
        Me.btRestablecer.Size = New System.Drawing.Size(104, 46)
        Me.btRestablecer.TabIndex = 39
        Me.btRestablecer.Text = "Restablecer"
        Me.btRestablecer.UseVisualStyleBackColor = True
        '
        'DateFechaFin
        '
        Me.DateFechaFin.Location = New System.Drawing.Point(186, 115)
        Me.DateFechaFin.Name = "DateFechaFin"
        Me.DateFechaFin.Size = New System.Drawing.Size(225, 21)
        Me.DateFechaFin.TabIndex = 38
        '
        'DateFechaInicio
        '
        Me.DateFechaInicio.Location = New System.Drawing.Point(186, 88)
        Me.DateFechaInicio.Name = "DateFechaInicio"
        Me.DateFechaInicio.Size = New System.Drawing.Size(225, 21)
        Me.DateFechaInicio.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 15)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Código:"
        '
        'btGuardar
        '
        Me.btGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGuardar.Location = New System.Drawing.Point(263, 392)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(104, 46)
        Me.btGuardar.TabIndex = 35
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'lbCodEvent
        '
        Me.lbCodEvent.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation
        Me.lbCodEvent.AutoSize = True
        Me.lbCodEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodEvent.Location = New System.Drawing.Point(73, 64)
        Me.lbCodEvent.Name = "lbCodEvent"
        Me.lbCodEvent.Size = New System.Drawing.Size(15, 15)
        Me.lbCodEvent.TabIndex = 34
        Me.lbCodEvent.Text = "0"
        '
        'lbEvActual
        '
        Me.lbEvActual.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation
        Me.lbEvActual.AutoSize = True
        Me.lbEvActual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbEvActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEvActual.Location = New System.Drawing.Point(96, 24)
        Me.lbEvActual.Name = "lbEvActual"
        Me.lbEvActual.Size = New System.Drawing.Size(66, 15)
        Me.lbEvActual.TabIndex = 33
        Me.lbEvActual.Text = "ACTUAL?"
        '
        'lbEvActivo
        '
        Me.lbEvActivo.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation
        Me.lbEvActivo.AutoSize = True
        Me.lbEvActivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbEvActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEvActivo.Location = New System.Drawing.Point(215, 64)
        Me.lbEvActivo.Name = "lbEvActivo"
        Me.lbEvActivo.Size = New System.Drawing.Size(27, 15)
        Me.lbEvActivo.TabIndex = 32
        Me.lbEvActivo.Text = "-----"
        '
        'Activo
        '
        Me.Activo.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation
        Me.Activo.AutoSize = True
        Me.Activo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Activo.Location = New System.Drawing.Point(168, 64)
        Me.Activo.Name = "Activo"
        Me.Activo.Size = New System.Drawing.Size(41, 15)
        Me.Activo.TabIndex = 31
        Me.Activo.Text = "Activo:"
        '
        'lbFechFin
        '
        Me.lbFechFin.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation
        Me.lbFechFin.AutoSize = True
        Me.lbFechFin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbFechFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechFin.Location = New System.Drawing.Point(134, 115)
        Me.lbFechFin.Name = "lbFechFin"
        Me.lbFechFin.Size = New System.Drawing.Size(27, 15)
        Me.lbFechFin.TabIndex = 30
        Me.lbFechFin.Text = "-----"
        '
        'lbFechIni
        '
        Me.lbFechIni.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation
        Me.lbFechIni.AutoSize = True
        Me.lbFechIni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbFechIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechIni.Location = New System.Drawing.Point(134, 88)
        Me.lbFechIni.Name = "lbFechIni"
        Me.lbFechIni.Size = New System.Drawing.Size(27, 15)
        Me.lbFechIni.TabIndex = 29
        Me.lbFechIni.Text = "-----"
        '
        'Label7
        '
        Me.Label7.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Fecha fin:"
        '
        'Label6
        '
        Me.Label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 15)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Fecha inicio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(247, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "seg"
        '
        'nuTiempoPreg
        '
        Me.nuTiempoPreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuTiempoPreg.Location = New System.Drawing.Point(196, 240)
        Me.nuTiempoPreg.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nuTiempoPreg.Name = "nuTiempoPreg"
        Me.nuTiempoPreg.Size = New System.Drawing.Size(46, 21)
        Me.nuTiempoPreg.TabIndex = 25
        Me.nuTiempoPreg.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 15)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Tiempo máximo por pregunta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tipo de test"
        '
        'cbTipoExamen
        '
        Me.cbTipoExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoExamen.FormattingEnabled = True
        Me.cbTipoExamen.Items.AddRange(New Object() {"Dirigido básico", "Dirigido experto"})
        Me.cbTipoExamen.Location = New System.Drawing.Point(103, 144)
        Me.cbTipoExamen.Name = "cbTipoExamen"
        Me.cbTipoExamen.Size = New System.Drawing.Size(143, 23)
        Me.cbTipoExamen.TabIndex = 13
        Me.cbTipoExamen.Text = "Dirigido básico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(248, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "min"
        '
        'CkTiempoTodos
        '
        Me.CkTiempoTodos.AutoSize = True
        Me.CkTiempoTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkTiempoTodos.Location = New System.Drawing.Point(21, 185)
        Me.CkTiempoTodos.Name = "CkTiempoTodos"
        Me.CkTiempoTodos.Size = New System.Drawing.Size(231, 17)
        Me.CkTiempoTodos.TabIndex = 17
        Me.CkTiempoTodos.Text = "Establecer tiempo para todas las categorias"
        Me.CkTiempoTodos.UseVisualStyleBackColor = True
        '
        'nuTiempoExa
        '
        Me.nuTiempoExa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuTiempoExa.Location = New System.Drawing.Point(196, 214)
        Me.nuTiempoExa.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nuTiempoExa.Name = "nuTiempoExa"
        Me.nuTiempoExa.Size = New System.Drawing.Size(46, 21)
        Me.nuTiempoExa.TabIndex = 19
        Me.nuTiempoExa.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'lbTiempoExa
        '
        Me.lbTiempoExa.AutoSize = True
        Me.lbTiempoExa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTiempoExa.Location = New System.Drawing.Point(18, 218)
        Me.lbTiempoExa.Name = "lbTiempoExa"
        Me.lbTiempoExa.Size = New System.Drawing.Size(165, 15)
        Me.lbTiempoExa.TabIndex = 18
        Me.lbTiempoExa.Text = "Tiempo máximo de examen:"
        '
        'lbTituloEvento
        '
        Me.lbTituloEvento.AutoSize = True
        Me.lbTituloEvento.BackColor = System.Drawing.Color.Transparent
        Me.lbTituloEvento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbTituloEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTituloEvento.Location = New System.Drawing.Point(229, 85)
        Me.lbTituloEvento.Name = "lbTituloEvento"
        Me.lbTituloEvento.Size = New System.Drawing.Size(93, 29)
        Me.lbTituloEvento.TabIndex = 43
        Me.lbTituloEvento.Text = "Evento"
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.BackColor = System.Drawing.SystemColors.HighlightText
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EdiciónToolStripMenuItem, Me.VerToolStripMenuItem, Me.ProgramaExternoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(964, 24)
        Me.MenuPrincipal.TabIndex = 55
        Me.MenuPrincipal.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReiniciarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'ReiniciarSesiónToolStripMenuItem
        '
        Me.ReiniciarSesiónToolStripMenuItem.Name = "ReiniciarSesiónToolStripMenuItem"
        Me.ReiniciarSesiónToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ReiniciarSesiónToolStripMenuItem.Text = "&Reiniciar sesión"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'EdiciónToolStripMenuItem
        '
        Me.EdiciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.CategoriasToolStripMenuItem, Me.EntidadesToolStripMenuItem, Me.TipoDeUsuariosToolStripMenuItem, Me.InscripcionesToolStripMenuItem})
        Me.EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        Me.EdiciónToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.EdiciónToolStripMenuItem.Text = "&Edición"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.UsuariosToolStripMenuItem.Text = "E&ventos"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CategoriasToolStripMenuItem.Text = "C&ategorias"
        '
        'EntidadesToolStripMenuItem
        '
        Me.EntidadesToolStripMenuItem.Name = "EntidadesToolStripMenuItem"
        Me.EntidadesToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.EntidadesToolStripMenuItem.Text = "E&ntidades"
        '
        'TipoDeUsuariosToolStripMenuItem
        '
        Me.TipoDeUsuariosToolStripMenuItem.Name = "TipoDeUsuariosToolStripMenuItem"
        Me.TipoDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.TipoDeUsuariosToolStripMenuItem.Text = "&Tipo de Usuarios"
        '
        'InscripcionesToolStripMenuItem
        '
        Me.InscripcionesToolStripMenuItem.Name = "InscripcionesToolStripMenuItem"
        Me.InscripcionesToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.InscripcionesToolStripMenuItem.Text = "&Inscripciones"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResultadosToolStripMenuItem, Me.ResultadosConFechasToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'ResultadosToolStripMenuItem
        '
        Me.ResultadosToolStripMenuItem.Name = "ResultadosToolStripMenuItem"
        Me.ResultadosToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ResultadosToolStripMenuItem.Text = "Resultados"
        '
        'ResultadosConFechasToolStripMenuItem
        '
        Me.ResultadosConFechasToolStripMenuItem.Name = "ResultadosConFechasToolStripMenuItem"
        Me.ResultadosConFechasToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ResultadosConFechasToolStripMenuItem.Text = "Resultados con fechas"
        '
        'ProgramaExternoToolStripMenuItem
        '
        Me.ProgramaExternoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarPreguntasToolStripMenuItem, Me.ImportarPreguntasToolStripMenuItem})
        Me.ProgramaExternoToolStripMenuItem.Name = "ProgramaExternoToolStripMenuItem"
        Me.ProgramaExternoToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.ProgramaExternoToolStripMenuItem.Text = "Programa externo"
        '
        'ExportarPreguntasToolStripMenuItem
        '
        Me.ExportarPreguntasToolStripMenuItem.Name = "ExportarPreguntasToolStripMenuItem"
        Me.ExportarPreguntasToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ExportarPreguntasToolStripMenuItem.Text = "Exportar preguntas"
        '
        'ImportarPreguntasToolStripMenuItem
        '
        Me.ImportarPreguntasToolStripMenuItem.Name = "ImportarPreguntasToolStripMenuItem"
        Me.ImportarPreguntasToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ImportarPreguntasToolStripMenuItem.Text = "Importar preguntas"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreditosToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'CreditosToolStripMenuItem
        '
        Me.CreditosToolStripMenuItem.Name = "CreditosToolStripMenuItem"
        Me.CreditosToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CreditosToolStripMenuItem.Text = "Créditos"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'ToolStripAdmin
        '
        Me.ToolStripAdmin.AutoSize = False
        Me.ToolStripAdmin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtUsuarios, Me.ToolStripBtCategoria, Me.ToolStripBtPreguntas, Me.ToolStripBtEntidades, Me.ToolStripSeparator1, Me.ToolStripBtResultados, Me.ToolStripBtIniciarPruebas})
        Me.ToolStripAdmin.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripAdmin.Name = "ToolStripAdmin"
        Me.ToolStripAdmin.Size = New System.Drawing.Size(964, 50)
        Me.ToolStripAdmin.TabIndex = 56
        Me.ToolStripAdmin.Text = "ToolStrip1"
        '
        'ToolStripBtUsuarios
        '
        Me.ToolStripBtUsuarios.AutoSize = False
        Me.ToolStripBtUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtUsuarios.Image = Global.Olimpiadas_académicas.My.Resources.Resources.Profile
        Me.ToolStripBtUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtUsuarios.Name = "ToolStripBtUsuarios"
        Me.ToolStripBtUsuarios.Size = New System.Drawing.Size(80, 48)
        Me.ToolStripBtUsuarios.Text = "Usuarios"
        Me.ToolStripBtUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripBtUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.ToolStripBtUsuarios.ToolTipText = "Usuarios"
        '
        'ToolStripBtCategoria
        '
        Me.ToolStripBtCategoria.AutoSize = False
        Me.ToolStripBtCategoria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtCategoria.Image = Global.Olimpiadas_académicas.My.Resources.Resources.Categorias
        Me.ToolStripBtCategoria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtCategoria.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtCategoria.Name = "ToolStripBtCategoria"
        Me.ToolStripBtCategoria.Size = New System.Drawing.Size(80, 47)
        Me.ToolStripBtCategoria.Text = "Categorias"
        Me.ToolStripBtCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripBtCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.ToolStripBtCategoria.ToolTipText = "Categorías"
        '
        'ToolStripBtPreguntas
        '
        Me.ToolStripBtPreguntas.AutoSize = False
        Me.ToolStripBtPreguntas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtPreguntas.Image = Global.Olimpiadas_académicas.My.Resources.Resources.Preguntas
        Me.ToolStripBtPreguntas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtPreguntas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtPreguntas.Name = "ToolStripBtPreguntas"
        Me.ToolStripBtPreguntas.Size = New System.Drawing.Size(80, 47)
        Me.ToolStripBtPreguntas.Text = "Preguntas"
        Me.ToolStripBtPreguntas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripBtPreguntas.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripBtEntidades
        '
        Me.ToolStripBtEntidades.AutoSize = False
        Me.ToolStripBtEntidades.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtEntidades.Image = Global.Olimpiadas_académicas.My.Resources.Resources.Entidades
        Me.ToolStripBtEntidades.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtEntidades.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtEntidades.Name = "ToolStripBtEntidades"
        Me.ToolStripBtEntidades.Size = New System.Drawing.Size(80, 47)
        Me.ToolStripBtEntidades.Text = "Entidades"
        Me.ToolStripBtEntidades.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripBtEntidades.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.ToolStripBtEntidades.ToolTipText = "Entidades"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 50)
        '
        'ToolStripBtResultados
        '
        Me.ToolStripBtResultados.AutoSize = False
        Me.ToolStripBtResultados.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtResultados.Image = Global.Olimpiadas_académicas.My.Resources.Resources.Resultados
        Me.ToolStripBtResultados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtResultados.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtResultados.Name = "ToolStripBtResultados"
        Me.ToolStripBtResultados.Size = New System.Drawing.Size(60, 47)
        Me.ToolStripBtResultados.Text = "Resultados"
        Me.ToolStripBtResultados.ToolTipText = "Resultados"
        '
        'ToolStripBtIniciarPruebas
        '
        Me.ToolStripBtIniciarPruebas.AutoSize = False
        Me.ToolStripBtIniciarPruebas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtIniciarPruebas.Image = Global.Olimpiadas_académicas.My.Resources.Resources.ManagerChat
        Me.ToolStripBtIniciarPruebas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtIniciarPruebas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtIniciarPruebas.Name = "ToolStripBtIniciarPruebas"
        Me.ToolStripBtIniciarPruebas.Size = New System.Drawing.Size(80, 47)
        Me.ToolStripBtIniciarPruebas.Text = "Iniciar pruebas"
        '
        'PctLogoEvento
        '
        Me.PctLogoEvento.BackColor = System.Drawing.Color.Transparent
        Me.PctLogoEvento.Image = Global.Olimpiadas_académicas.My.Resources.Resources.LogoAOL
        Me.PctLogoEvento.Location = New System.Drawing.Point(149, 77)
        Me.PctLogoEvento.Name = "PctLogoEvento"
        Me.PctLogoEvento.Size = New System.Drawing.Size(50, 43)
        Me.PctLogoEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PctLogoEvento.TabIndex = 52
        Me.PctLogoEvento.TabStop = False
        '
        'txtEvento
        '
        Me.txtEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvento.Location = New System.Drawing.Point(345, 77)
        Me.txtEvento.Name = "txtEvento"
        Me.txtEvento.Size = New System.Drawing.Size(607, 35)
        Me.txtEvento.TabIndex = 57
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(345, 114)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(607, 21)
        Me.txtDescripcion.TabIndex = 58
        '
        'frmAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(964, 649)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtEvento)
        Me.Controls.Add(Me.ToolStripAdmin)
        Me.Controls.Add(Me.lbDescripEven)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PctLogoEvento)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lbTituloEvento)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdministrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador de eventos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridPreguntas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.nuTiempoPreg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuTiempoExa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        Me.ToolStripAdmin.ResumeLayout(False)
        Me.ToolStripAdmin.PerformLayout()
        CType(Me.PctLogoEvento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbDescripEven As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPreguntas As System.Windows.Forms.DataGridView
    Friend WithEvents cbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtSeleccionPreg As System.Windows.Forms.Button
    Friend WithEvents PctLogoEvento As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btDelAll As System.Windows.Forms.Button
    Friend WithEvents ListUsuarios As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbCodEvent As System.Windows.Forms.Label
    Friend WithEvents lbEvActual As System.Windows.Forms.Label
    Friend WithEvents lbEvActivo As System.Windows.Forms.Label
    Friend WithEvents Activo As System.Windows.Forms.Label
    Friend WithEvents lbFechFin As System.Windows.Forms.Label
    Friend WithEvents lbFechIni As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nuTiempoPreg As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbTipoExamen As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CkTiempoTodos As System.Windows.Forms.CheckBox
    Friend WithEvents nuTiempoExa As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbTiempoExa As System.Windows.Forms.Label
    Friend WithEvents lbTituloEvento As System.Windows.Forms.Label
    Friend WithEvents MenuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReiniciarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntidadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoDeUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InscripcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramaExternoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportarPreguntasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarPreguntasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btDelSeleccionados As System.Windows.Forms.Button
    Friend WithEvents btGuardar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents btRestablecer As System.Windows.Forms.Button
    Friend WithEvents ToolStripAdmin As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripBtPreguntas As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripBtCategoria As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripBtUsuarios As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripBtEntidades As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripBtIniciarPruebas As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripBtResultados As System.Windows.Forms.ToolStripButton
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultadosConFechasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtEvento As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreditosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbPermisoEmpezar As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
