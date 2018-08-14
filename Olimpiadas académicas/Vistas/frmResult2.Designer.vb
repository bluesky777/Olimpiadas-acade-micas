<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResult2
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbEvento = New System.Windows.Forms.ComboBox()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.cbEntidades = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Categoria = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btBuscarDatos = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupFechas = New System.Windows.Forms.GroupBox()
        Me.txtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.txtFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupChecks = New System.Windows.Forms.GroupBox()
        Me.CkFecha = New System.Windows.Forms.CheckBox()
        Me.CkCategoria = New System.Windows.Forms.CheckBox()
        Me.CkEntidad = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btVerDetExa = New System.Windows.Forms.Button()
        Me.btEliminarExa = New System.Windows.Forms.Button()
        Me.btReporte = New System.Windows.Forms.Button()
        Me.DataExamenes = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lbTextoDetExa = New System.Windows.Forms.Label()
        Me.GroupCriteriosUsu = New System.Windows.Forms.GroupBox()
        Me.LtExamenes = New System.Windows.Forms.ListBox()
        Me.LtCategoria = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbUsuario = New System.Windows.Forms.ComboBox()
        Me.PanelResultados = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbContestadas = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.DataDetalles = New System.Windows.Forms.DataGridView()
        Me.GroupFechas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupChecks.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataExamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupCriteriosUsu.SuspendLayout()
        Me.PanelResultados.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbEvento
        '
        Me.cbEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEvento.FormattingEnabled = True
        Me.cbEvento.Location = New System.Drawing.Point(59, 27)
        Me.cbEvento.Name = "cbEvento"
        Me.cbEvento.Size = New System.Drawing.Size(293, 24)
        Me.cbEvento.TabIndex = 0
        '
        'cbCategoria
        '
        Me.cbCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(628, 27)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(121, 24)
        Me.cbCategoria.TabIndex = 1
        '
        'cbEntidades
        '
        Me.cbEntidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEntidades.FormattingEnabled = True
        Me.cbEntidades.Location = New System.Drawing.Point(418, 27)
        Me.cbEntidades.Name = "cbEntidades"
        Me.cbEntidades.Size = New System.Drawing.Size(131, 24)
        Me.cbEntidades.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Evento"
        '
        'Categoria
        '
        Me.Categoria.AutoSize = True
        Me.Categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Categoria.Location = New System.Drawing.Point(555, 30)
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Size = New System.Drawing.Size(67, 16)
        Me.Categoria.TabIndex = 4
        Me.Categoria.Text = "Categoria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(358, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Entidad"
        '
        'btBuscarDatos
        '
        Me.btBuscarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscarDatos.Location = New System.Drawing.Point(570, 85)
        Me.btBuscarDatos.Name = "btBuscarDatos"
        Me.btBuscarDatos.Size = New System.Drawing.Size(129, 46)
        Me.btBuscarDatos.TabIndex = 6
        Me.btBuscarDatos.Text = "Buscar"
        Me.btBuscarDatos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Inicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(248, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Fin"
        '
        'GroupFechas
        '
        Me.GroupFechas.Controls.Add(Me.txtFechaFin)
        Me.GroupFechas.Controls.Add(Me.txtFechaIni)
        Me.GroupFechas.Controls.Add(Me.Label4)
        Me.GroupFechas.Controls.Add(Me.Label3)
        Me.GroupFechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupFechas.Location = New System.Drawing.Point(81, 58)
        Me.GroupFechas.Name = "GroupFechas"
        Me.GroupFechas.Size = New System.Drawing.Size(483, 73)
        Me.GroupFechas.TabIndex = 12
        Me.GroupFechas.TabStop = False
        Me.GroupFechas.Text = "Fecha de examen"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Location = New System.Drawing.Point(277, 37)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(191, 23)
        Me.txtFechaFin.TabIndex = 15
        '
        'txtFechaIni
        '
        Me.txtFechaIni.Location = New System.Drawing.Point(46, 37)
        Me.txtFechaIni.MaxDate = New Date(2040, 12, 31, 0, 0, 0, 0)
        Me.txtFechaIni.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.txtFechaIni.Name = "txtFechaIni"
        Me.txtFechaIni.Size = New System.Drawing.Size(196, 23)
        Me.txtFechaIni.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupChecks)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btBuscarDatos)
        Me.GroupBox1.Controls.Add(Me.GroupFechas)
        Me.GroupBox1.Controls.Add(Me.Categoria)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbEntidades)
        Me.GroupBox1.Controls.Add(Me.cbCategoria)
        Me.GroupBox1.Controls.Add(Me.cbEvento)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(900, 143)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos a buscar"
        '
        'GroupChecks
        '
        Me.GroupChecks.Controls.Add(Me.CkFecha)
        Me.GroupChecks.Controls.Add(Me.CkCategoria)
        Me.GroupChecks.Controls.Add(Me.CkEntidad)
        Me.GroupChecks.Location = New System.Drawing.Point(753, 15)
        Me.GroupChecks.Name = "GroupChecks"
        Me.GroupChecks.Size = New System.Drawing.Size(135, 121)
        Me.GroupChecks.TabIndex = 13
        Me.GroupChecks.TabStop = False
        Me.GroupChecks.Text = "Busqueda por"
        '
        'CkFecha
        '
        Me.CkFecha.AutoSize = True
        Me.CkFecha.Checked = True
        Me.CkFecha.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CkFecha.Location = New System.Drawing.Point(17, 89)
        Me.CkFecha.Name = "CkFecha"
        Me.CkFecha.Size = New System.Drawing.Size(66, 21)
        Me.CkFecha.TabIndex = 2
        Me.CkFecha.Text = "Fecha"
        Me.CkFecha.UseVisualStyleBackColor = True
        '
        'CkCategoria
        '
        Me.CkCategoria.AutoSize = True
        Me.CkCategoria.Checked = True
        Me.CkCategoria.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CkCategoria.Location = New System.Drawing.Point(17, 62)
        Me.CkCategoria.Name = "CkCategoria"
        Me.CkCategoria.Size = New System.Drawing.Size(88, 21)
        Me.CkCategoria.TabIndex = 1
        Me.CkCategoria.Text = "Categoría"
        Me.CkCategoria.UseVisualStyleBackColor = True
        '
        'CkEntidad
        '
        Me.CkEntidad.AutoSize = True
        Me.CkEntidad.Checked = True
        Me.CkEntidad.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CkEntidad.Location = New System.Drawing.Point(17, 35)
        Me.CkEntidad.Name = "CkEntidad"
        Me.CkEntidad.Size = New System.Drawing.Size(75, 21)
        Me.CkEntidad.TabIndex = 0
        Me.CkEntidad.Text = "Entidad"
        Me.CkEntidad.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(19, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(935, 590)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btVerDetExa)
        Me.TabPage1.Controls.Add(Me.btEliminarExa)
        Me.TabPage1.Controls.Add(Me.btReporte)
        Me.TabPage1.Controls.Add(Me.DataExamenes)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(927, 561)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Busqueda general"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btVerDetExa
        '
        Me.btVerDetExa.Location = New System.Drawing.Point(805, 511)
        Me.btVerDetExa.Name = "btVerDetExa"
        Me.btVerDetExa.Size = New System.Drawing.Size(97, 47)
        Me.btVerDetExa.TabIndex = 47
        Me.btVerDetExa.Text = "Ver detalles"
        Me.btVerDetExa.UseVisualStyleBackColor = True
        '
        'btEliminarExa
        '
        Me.btEliminarExa.Location = New System.Drawing.Point(574, 511)
        Me.btEliminarExa.Name = "btEliminarExa"
        Me.btEliminarExa.Size = New System.Drawing.Size(122, 47)
        Me.btEliminarExa.TabIndex = 46
        Me.btEliminarExa.Text = "Borrar examen seleccionado"
        Me.btEliminarExa.UseVisualStyleBackColor = True
        '
        'btReporte
        '
        Me.btReporte.Location = New System.Drawing.Point(702, 511)
        Me.btReporte.Name = "btReporte"
        Me.btReporte.Size = New System.Drawing.Size(97, 47)
        Me.btReporte.TabIndex = 45
        Me.btReporte.Text = "Generar reporte"
        Me.btReporte.UseVisualStyleBackColor = True
        '
        'DataExamenes
        '
        Me.DataExamenes.AllowUserToAddRows = False
        Me.DataExamenes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataExamenes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataExamenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataExamenes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataExamenes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DataExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataExamenes.Location = New System.Drawing.Point(14, 165)
        Me.DataExamenes.Name = "DataExamenes"
        Me.DataExamenes.ReadOnly = True
        Me.DataExamenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataExamenes.Size = New System.Drawing.Size(888, 337)
        Me.DataExamenes.TabIndex = 14
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lbTextoDetExa)
        Me.TabPage2.Controls.Add(Me.GroupCriteriosUsu)
        Me.TabPage2.Controls.Add(Me.PanelResultados)
        Me.TabPage2.Controls.Add(Me.DataDetalles)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(927, 561)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalle por usuario"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lbTextoDetExa
        '
        Me.lbTextoDetExa.AutoSize = True
        Me.lbTextoDetExa.Location = New System.Drawing.Point(22, 17)
        Me.lbTextoDetExa.Name = "lbTextoDetExa"
        Me.lbTextoDetExa.Size = New System.Drawing.Size(172, 17)
        Me.lbTextoDetExa.TabIndex = 43
        Me.lbTextoDetExa.Text = "Puedes ver los resultados"
        '
        'GroupCriteriosUsu
        '
        Me.GroupCriteriosUsu.Controls.Add(Me.LtExamenes)
        Me.GroupCriteriosUsu.Controls.Add(Me.LtCategoria)
        Me.GroupCriteriosUsu.Controls.Add(Me.Label13)
        Me.GroupCriteriosUsu.Controls.Add(Me.Label5)
        Me.GroupCriteriosUsu.Controls.Add(Me.Label7)
        Me.GroupCriteriosUsu.Controls.Add(Me.cbUsuario)
        Me.GroupCriteriosUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupCriteriosUsu.Location = New System.Drawing.Point(6, 94)
        Me.GroupCriteriosUsu.Name = "GroupCriteriosUsu"
        Me.GroupCriteriosUsu.Size = New System.Drawing.Size(568, 153)
        Me.GroupCriteriosUsu.TabIndex = 42
        Me.GroupCriteriosUsu.TabStop = False
        Me.GroupCriteriosUsu.Text = "Criterios de busqueda"
        '
        'LtExamenes
        '
        Me.LtExamenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LtExamenes.FormattingEnabled = True
        Me.LtExamenes.ItemHeight = 15
        Me.LtExamenes.Location = New System.Drawing.Point(365, 59)
        Me.LtExamenes.Name = "LtExamenes"
        Me.LtExamenes.Size = New System.Drawing.Size(197, 79)
        Me.LtExamenes.TabIndex = 41
        '
        'LtCategoria
        '
        Me.LtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LtCategoria.FormattingEnabled = True
        Me.LtCategoria.ItemHeight = 15
        Me.LtCategoria.Location = New System.Drawing.Point(92, 59)
        Me.LtCategoria.Name = "LtCategoria"
        Me.LtCategoria.Size = New System.Drawing.Size(184, 79)
        Me.LtCategoria.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 17)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Categorias"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 17)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Seleccione un usuario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(286, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Examenes"
        '
        'cbUsuario
        '
        Me.cbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUsuario.FormattingEnabled = True
        Me.cbUsuario.Location = New System.Drawing.Point(170, 22)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Size = New System.Drawing.Size(291, 24)
        Me.cbUsuario.TabIndex = 32
        '
        'PanelResultados
        '
        Me.PanelResultados.AutoScroll = True
        Me.PanelResultados.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelResultados.Controls.Add(Me.Label8)
        Me.PanelResultados.Controls.Add(Me.Panel1)
        Me.PanelResultados.Controls.Add(Me.lbPuntaje)
        Me.PanelResultados.Controls.Add(Me.Label16)
        Me.PanelResultados.Location = New System.Drawing.Point(592, 103)
        Me.PanelResultados.Name = "PanelResultados"
        Me.PanelResultados.Size = New System.Drawing.Size(315, 373)
        Me.PanelResultados.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(288, 29)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Resultados del Examen"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbContestadas)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lbTiempo)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.lbRespInorrectas)
        Me.Panel1.Controls.Add(Me.lbRespCorrectas)
        Me.Panel1.Controls.Add(Me.lbTotalPreg)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(19, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 240)
        Me.Panel1.TabIndex = 27
        '
        'lbContestadas
        '
        Me.lbContestadas.AutoSize = True
        Me.lbContestadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbContestadas.Location = New System.Drawing.Point(207, 64)
        Me.lbContestadas.Name = "lbContestadas"
        Me.lbContestadas.Size = New System.Drawing.Size(21, 24)
        Me.lbContestadas.TabIndex = 24
        Me.lbContestadas.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Respuestas contestadas"
        '
        'lbTiempo
        '
        Me.lbTiempo.AutoSize = True
        Me.lbTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTiempo.Location = New System.Drawing.Point(202, 186)
        Me.lbTiempo.Name = "lbTiempo"
        Me.lbTiempo.Size = New System.Drawing.Size(21, 24)
        Me.lbTiempo.TabIndex = 22
        Me.lbTiempo.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(9, 189)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 20)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Tiempo"
        '
        'lbRespInorrectas
        '
        Me.lbRespInorrectas.AutoSize = True
        Me.lbRespInorrectas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRespInorrectas.ForeColor = System.Drawing.Color.Red
        Me.lbRespInorrectas.Location = New System.Drawing.Point(207, 137)
        Me.lbRespInorrectas.Name = "lbRespInorrectas"
        Me.lbRespInorrectas.Size = New System.Drawing.Size(21, 24)
        Me.lbRespInorrectas.TabIndex = 18
        Me.lbRespInorrectas.Text = "0"
        '
        'lbRespCorrectas
        '
        Me.lbRespCorrectas.AutoSize = True
        Me.lbRespCorrectas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRespCorrectas.ForeColor = System.Drawing.Color.Blue
        Me.lbRespCorrectas.Location = New System.Drawing.Point(207, 98)
        Me.lbRespCorrectas.Name = "lbRespCorrectas"
        Me.lbRespCorrectas.Size = New System.Drawing.Size(21, 24)
        Me.lbRespCorrectas.TabIndex = 17
        Me.lbRespCorrectas.Text = "0"
        '
        'lbTotalPreg
        '
        Me.lbTotalPreg.AutoSize = True
        Me.lbTotalPreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalPreg.Location = New System.Drawing.Point(207, 16)
        Me.lbTotalPreg.Name = "lbTotalPreg"
        Me.lbTotalPreg.Size = New System.Drawing.Size(21, 24)
        Me.lbTotalPreg.TabIndex = 16
        Me.lbTotalPreg.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 139)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(181, 20)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Respuestas incorrectas:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(169, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Respuestas correctas:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Total preguntas:"
        '
        'lbPuntaje
        '
        Me.lbPuntaje.AutoSize = True
        Me.lbPuntaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPuntaje.ForeColor = System.Drawing.Color.Blue
        Me.lbPuntaje.Location = New System.Drawing.Point(152, 316)
        Me.lbPuntaje.Name = "lbPuntaje"
        Me.lbPuntaje.Size = New System.Drawing.Size(97, 36)
        Me.lbPuntaje.TabIndex = 20
        Me.lbPuntaje.Text = "100%"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(41, 323)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 25)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Puntaje:"
        '
        'DataDetalles
        '
        Me.DataDetalles.AllowUserToAddRows = False
        Me.DataDetalles.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.DataDetalles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataDetalles.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataDetalles.Location = New System.Drawing.Point(2, 253)
        Me.DataDetalles.Name = "DataDetalles"
        Me.DataDetalles.ReadOnly = True
        Me.DataDetalles.Size = New System.Drawing.Size(572, 283)
        Me.DataDetalles.TabIndex = 31
        '
        'frmResult2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 605)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmResult2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resultados"
        Me.GroupFechas.ResumeLayout(False)
        Me.GroupFechas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupChecks.ResumeLayout(False)
        Me.GroupChecks.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataExamenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupCriteriosUsu.ResumeLayout(False)
        Me.GroupCriteriosUsu.PerformLayout()
        Me.PanelResultados.ResumeLayout(False)
        Me.PanelResultados.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbEvento As System.Windows.Forms.ComboBox
    Friend WithEvents cbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents cbEntidades As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Categoria As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btBuscarDatos As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupFechas As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupChecks As System.Windows.Forms.GroupBox
    Friend WithEvents CkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents CkCategoria As System.Windows.Forms.CheckBox
    Friend WithEvents CkEntidad As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataExamenes As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents btVerDetExa As System.Windows.Forms.Button
    Friend WithEvents btEliminarExa As System.Windows.Forms.Button
    Friend WithEvents btReporte As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PanelResultados As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbContestadas As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents DataDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents LtExamenes As System.Windows.Forms.ListBox
    Friend WithEvents LtCategoria As System.Windows.Forms.ListBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupCriteriosUsu As System.Windows.Forms.GroupBox
    Friend WithEvents lbTextoDetExa As System.Windows.Forms.Label
End Class
