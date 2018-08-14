<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtPassw = New System.Windows.Forms.TextBox()
        Me.GridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btNuevo = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbEntidad = New System.Windows.Forms.ComboBox()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.txtFoto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbRutaImagen = New System.Windows.Forms.Label()
        Me.cbBuscar = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LbId = New System.Windows.Forms.Label()
        Me.lbRegistros = New System.Windows.Forms.Label()
        Me.btResultados = New System.Windows.Forms.Button()
        Me.btInscribir = New System.Windows.Forms.Button()
        Me.btAtras = New System.Windows.Forms.Button()
        Me.lbTipo = New System.Windows.Forms.Label()
        Me.lbEntidad = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbActivo = New System.Windows.Forms.ComboBox()
        Me.lbActivo = New System.Windows.Forms.Label()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(339, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Login"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(301, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contraseña"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(78, 130)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(213, 23)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Text = " "
        '
        'txtLogin
        '
        Me.txtLogin.Enabled = False
        Me.txtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.Location = New System.Drawing.Point(400, 127)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(112, 23)
        Me.txtLogin.TabIndex = 2
        '
        'txtPassw
        '
        Me.txtPassw.Enabled = False
        Me.txtPassw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassw.Location = New System.Drawing.Point(400, 157)
        Me.txtPassw.Name = "txtPassw"
        Me.txtPassw.Size = New System.Drawing.Size(89, 23)
        Me.txtPassw.TabIndex = 3
        '
        'GridView1
        '
        Me.GridView1.AllowUserToAddRows = False
        Me.GridView1.AllowUserToDeleteRows = False
        Me.GridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView1.Location = New System.Drawing.Point(18, 335)
        Me.GridView1.MultiSelect = False
        Me.GridView1.Name = "GridView1"
        Me.GridView1.ReadOnly = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.GridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.GridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView1.Size = New System.Drawing.Size(690, 225)
        Me.GridView1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tipo"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(400, 183)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(60, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Ocultar"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'cbTipo
        '
        Me.cbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTipo.Enabled = False
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(78, 163)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(129, 24)
        Me.cbTipo.TabIndex = 4
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(78, 9)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(61, 23)
        Me.btEliminar.TabIndex = 8
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btNuevo
        '
        Me.btNuevo.Location = New System.Drawing.Point(145, 9)
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(61, 23)
        Me.btNuevo.TabIndex = 9
        Me.btNuevo.Text = "Nuevo"
        Me.btNuevo.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.Enabled = False
        Me.btGuardar.Location = New System.Drawing.Point(212, 9)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(61, 23)
        Me.btGuardar.TabIndex = 10
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'btEditar
        '
        Me.btEditar.Location = New System.Drawing.Point(11, 9)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(61, 23)
        Me.btEditar.TabIndex = 7
        Me.btEditar.Text = "Editar"
        Me.btEditar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Entidad"
        '
        'cbEntidad
        '
        Me.cbEntidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEntidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEntidad.Enabled = False
        Me.cbEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEntidad.FormattingEnabled = True
        Me.cbEntidad.Items.AddRange(New Object() {"Participante", "Administrador"})
        Me.cbEntidad.Location = New System.Drawing.Point(78, 197)
        Me.cbEntidad.Name = "cbEntidad"
        Me.cbEntidad.Size = New System.Drawing.Size(129, 24)
        Me.cbEntidad.TabIndex = 5
        '
        'pbFoto
        '
        Me.pbFoto.Enabled = False
        Me.pbFoto.Location = New System.Drawing.Point(548, 105)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(160, 164)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFoto.TabIndex = 30
        Me.pbFoto.TabStop = False
        '
        'txtFoto
        '
        Me.txtFoto.Enabled = False
        Me.txtFoto.Location = New System.Drawing.Point(548, 81)
        Me.txtFoto.Name = "txtFoto"
        Me.txtFoto.Size = New System.Drawing.Size(160, 20)
        Me.txtFoto.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(545, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Foto"
        '
        'lbRutaImagen
        '
        Me.lbRutaImagen.AutoSize = True
        Me.lbRutaImagen.Location = New System.Drawing.Point(632, 65)
        Me.lbRutaImagen.Name = "lbRutaImagen"
        Me.lbRutaImagen.Size = New System.Drawing.Size(0, 13)
        Me.lbRutaImagen.TabIndex = 35
        Me.lbRutaImagen.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbBuscar
        '
        Me.cbBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuscar.FormattingEnabled = True
        Me.cbBuscar.Location = New System.Drawing.Point(78, 38)
        Me.cbBuscar.Name = "cbBuscar"
        Me.cbBuscar.Size = New System.Drawing.Size(434, 32)
        Me.cbBuscar.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Buscar:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(2, 2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 26)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Usuarios"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btEditar)
        Me.Panel1.Controls.Add(Me.btGuardar)
        Me.Panel1.Controls.Add(Me.btNuevo)
        Me.Panel1.Controls.Add(Me.btEliminar)
        Me.Panel1.Location = New System.Drawing.Point(141, 267)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(279, 39)
        Me.Panel1.TabIndex = 42
        '
        'LbId
        '
        Me.LbId.AutoSize = True
        Me.LbId.BackColor = System.Drawing.Color.Transparent
        Me.LbId.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbId.Location = New System.Drawing.Point(73, 101)
        Me.LbId.Name = "LbId"
        Me.LbId.Size = New System.Drawing.Size(48, 26)
        Me.LbId.TabIndex = 43
        Me.LbId.Text = "001"
        '
        'lbRegistros
        '
        Me.lbRegistros.AutoSize = True
        Me.lbRegistros.BackColor = System.Drawing.Color.Transparent
        Me.lbRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRegistros.Location = New System.Drawing.Point(25, 312)
        Me.lbRegistros.Name = "lbRegistros"
        Me.lbRegistros.Size = New System.Drawing.Size(26, 17)
        Me.lbRegistros.TabIndex = 47
        Me.lbRegistros.Text = "21"
        '
        'btResultados
        '
        Me.btResultados.Location = New System.Drawing.Point(956, 569)
        Me.btResultados.Name = "btResultados"
        Me.btResultados.Size = New System.Drawing.Size(90, 29)
        Me.btResultados.TabIndex = 12
        Me.btResultados.Text = "Ver resultados"
        Me.btResultados.UseVisualStyleBackColor = True
        '
        'btInscribir
        '
        Me.btInscribir.Location = New System.Drawing.Point(830, 18)
        Me.btInscribir.Name = "btInscribir"
        Me.btInscribir.Size = New System.Drawing.Size(137, 38)
        Me.btInscribir.TabIndex = 11
        Me.btInscribir.Text = "Inscribir"
        Me.btInscribir.UseVisualStyleBackColor = True
        '
        'btAtras
        '
        Me.btAtras.Location = New System.Drawing.Point(18, 569)
        Me.btAtras.Name = "btAtras"
        Me.btAtras.Size = New System.Drawing.Size(90, 29)
        Me.btAtras.TabIndex = 52
        Me.btAtras.Text = "Atras"
        Me.btAtras.UseVisualStyleBackColor = True
        '
        'lbTipo
        '
        Me.lbTipo.AutoSize = True
        Me.lbTipo.BackColor = System.Drawing.Color.Transparent
        Me.lbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipo.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lbTipo.Location = New System.Drawing.Point(213, 163)
        Me.lbTipo.Name = "lbTipo"
        Me.lbTipo.Size = New System.Drawing.Size(16, 17)
        Me.lbTipo.TabIndex = 53
        Me.lbTipo.Text = "0"
        '
        'lbEntidad
        '
        Me.lbEntidad.AutoSize = True
        Me.lbEntidad.BackColor = System.Drawing.Color.Transparent
        Me.lbEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEntidad.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lbEntidad.Location = New System.Drawing.Point(213, 200)
        Me.lbEntidad.Name = "lbEntidad"
        Me.lbEntidad.Size = New System.Drawing.Size(16, 17)
        Me.lbEntidad.TabIndex = 54
        Me.lbEntidad.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Activo"
        '
        'cbActivo
        '
        Me.cbActivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbActivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbActivo.Enabled = False
        Me.cbActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbActivo.FormattingEnabled = True
        Me.cbActivo.Items.AddRange(New Object() {"Verdadero", "Falso"})
        Me.cbActivo.Location = New System.Drawing.Point(78, 227)
        Me.cbActivo.Name = "cbActivo"
        Me.cbActivo.Size = New System.Drawing.Size(129, 24)
        Me.cbActivo.TabIndex = 6
        '
        'lbActivo
        '
        Me.lbActivo.AutoSize = True
        Me.lbActivo.BackColor = System.Drawing.Color.Transparent
        Me.lbActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbActivo.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lbActivo.Location = New System.Drawing.Point(213, 234)
        Me.lbActivo.Name = "lbActivo"
        Me.lbActivo.Size = New System.Drawing.Size(46, 17)
        Me.lbActivo.TabIndex = 57
        Me.lbActivo.Text = "Activo"
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1058, 610)
        Me.Controls.Add(Me.lbActivo)
        Me.Controls.Add(Me.cbActivo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbEntidad)
        Me.Controls.Add(Me.lbTipo)
        Me.Controls.Add(Me.btAtras)
        Me.Controls.Add(Me.btInscribir)
        Me.Controls.Add(Me.btResultados)
        Me.Controls.Add(Me.lbRegistros)
        Me.Controls.Add(Me.LbId)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbBuscar)
        Me.Controls.Add(Me.lbRutaImagen)
        Me.Controls.Add(Me.txtFoto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.pbFoto)
        Me.Controls.Add(Me.cbEntidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GridView1)
        Me.Controls.Add(Me.txtPassw)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtPassw As System.Windows.Forms.TextBox
    Friend WithEvents GridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox

    Friend WithEvents btEliminar As System.Windows.Forms.Button
    Friend WithEvents btNuevo As System.Windows.Forms.Button
    Friend WithEvents btGuardar As System.Windows.Forms.Button
    Friend WithEvents btEditar As System.Windows.Forms.Button

    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbEntidad As System.Windows.Forms.ComboBox
    Friend WithEvents pbFoto As System.Windows.Forms.PictureBox
    Friend WithEvents txtFoto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbRutaImagen As System.Windows.Forms.Label
    Friend WithEvents cbBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LbId As System.Windows.Forms.Label
    Friend WithEvents lbRegistros As System.Windows.Forms.Label
    Friend WithEvents btResultados As System.Windows.Forms.Button
    Friend WithEvents btInscribir As System.Windows.Forms.Button
    Friend WithEvents btAtras As System.Windows.Forms.Button
    Friend WithEvents lbTipo As System.Windows.Forms.Label
    Friend WithEvents lbEntidad As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbActivo As System.Windows.Forms.ComboBox
    Friend WithEvents lbActivo As System.Windows.Forms.Label
End Class
