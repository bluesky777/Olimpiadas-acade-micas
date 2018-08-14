<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResultados))
        Me.lbReferencia = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridExamen = New System.Windows.Forms.DataGridView()
        Me.btReporte = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cbCategorias = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cbEntidad = New System.Windows.Forms.ComboBox()
        Me.rbCategoria = New System.Windows.Forms.RadioButton()
        Me.rbAmbos = New System.Windows.Forms.RadioButton()
        Me.rbColegio = New System.Windows.Forms.RadioButton()
        Me.lbCateg = New System.Windows.Forms.Label()
        Me.lbColeg = New System.Windows.Forms.Label()
        Me.DateInicio = New System.Windows.Forms.DateTimePicker()
        Me.DateFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btBuscar = New System.Windows.Forms.Button()
        CType(Me.DataGridExamen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbReferencia
        '
        Me.lbReferencia.AutoSize = True
        Me.lbReferencia.BackColor = System.Drawing.Color.Transparent
        Me.lbReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbReferencia.Location = New System.Drawing.Point(245, 9)
        Me.lbReferencia.Name = "lbReferencia"
        Me.lbReferencia.Size = New System.Drawing.Size(512, 20)
        Me.lbReferencia.TabIndex = 0
        Me.lbReferencia.Text = "Aquí pueden verse los examenes realizados hasta el momento."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 523)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Atrás"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridExamen
        '
        Me.DataGridExamen.AllowUserToAddRows = False
        Me.DataGridExamen.AllowUserToDeleteRows = False
        Me.DataGridExamen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridExamen.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridExamen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DataGridExamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridExamen.Location = New System.Drawing.Point(12, 126)
        Me.DataGridExamen.Name = "DataGridExamen"
        Me.DataGridExamen.ReadOnly = True
        Me.DataGridExamen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridExamen.Size = New System.Drawing.Size(1032, 386)
        Me.DataGridExamen.TabIndex = 3
        '
        'btReporte
        '
        Me.btReporte.Location = New System.Drawing.Point(844, 518)
        Me.btReporte.Name = "btReporte"
        Me.btReporte.Size = New System.Drawing.Size(97, 47)
        Me.btReporte.TabIndex = 4
        Me.btReporte.Text = "Generar reporte"
        Me.btReporte.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Olimpiadas_académicas.My.Resources.Resources.LogoAOL
        Me.PictureBox2.Location = New System.Drawing.Point(-22, -6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(203, 86)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(716, 518)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 47)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Borrar examen seleccionado"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cbCategorias
        '
        Me.cbCategorias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCategorias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategorias.FormattingEnabled = True
        Me.cbCategorias.Location = New System.Drawing.Point(157, 83)
        Me.cbCategorias.Name = "cbCategorias"
        Me.cbCategorias.Size = New System.Drawing.Size(200, 28)
        Me.cbCategorias.TabIndex = 42
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(947, 518)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 47)
        Me.Button3.TabIndex = 44
        Me.Button3.Text = "Ver detalles"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cbEntidad
        '
        Me.cbEntidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEntidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEntidad.FormattingEnabled = True
        Me.cbEntidad.Location = New System.Drawing.Point(363, 83)
        Me.cbEntidad.Name = "cbEntidad"
        Me.cbEntidad.Size = New System.Drawing.Size(193, 28)
        Me.cbEntidad.TabIndex = 45
        '
        'rbCategoria
        '
        Me.rbCategoria.AutoSize = True
        Me.rbCategoria.BackColor = System.Drawing.Color.Transparent
        Me.rbCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCategoria.Location = New System.Drawing.Point(20, 19)
        Me.rbCategoria.Name = "rbCategoria"
        Me.rbCategoria.Size = New System.Drawing.Size(96, 21)
        Me.rbCategoria.TabIndex = 46
        Me.rbCategoria.TabStop = True
        Me.rbCategoria.Text = "Categoría"
        Me.rbCategoria.UseVisualStyleBackColor = False
        '
        'rbAmbos
        '
        Me.rbAmbos.AutoSize = True
        Me.rbAmbos.BackColor = System.Drawing.Color.Transparent
        Me.rbAmbos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAmbos.Location = New System.Drawing.Point(20, 65)
        Me.rbAmbos.Name = "rbAmbos"
        Me.rbAmbos.Size = New System.Drawing.Size(74, 21)
        Me.rbAmbos.TabIndex = 47
        Me.rbAmbos.TabStop = True
        Me.rbAmbos.Text = "Ambos"
        Me.rbAmbos.UseVisualStyleBackColor = False
        '
        'rbColegio
        '
        Me.rbColegio.AutoSize = True
        Me.rbColegio.BackColor = System.Drawing.Color.Transparent
        Me.rbColegio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbColegio.Location = New System.Drawing.Point(20, 42)
        Me.rbColegio.Name = "rbColegio"
        Me.rbColegio.Size = New System.Drawing.Size(81, 21)
        Me.rbColegio.TabIndex = 48
        Me.rbColegio.TabStop = True
        Me.rbColegio.Text = "Entidad"
        Me.rbColegio.UseVisualStyleBackColor = False
        '
        'lbCateg
        '
        Me.lbCateg.AutoSize = True
        Me.lbCateg.BackColor = System.Drawing.Color.Transparent
        Me.lbCateg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCateg.Location = New System.Drawing.Point(154, 63)
        Me.lbCateg.Name = "lbCateg"
        Me.lbCateg.Size = New System.Drawing.Size(78, 17)
        Me.lbCateg.TabIndex = 49
        Me.lbCateg.Text = "Categoría"
        '
        'lbColeg
        '
        Me.lbColeg.AutoSize = True
        Me.lbColeg.BackColor = System.Drawing.Color.Transparent
        Me.lbColeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbColeg.Location = New System.Drawing.Point(360, 63)
        Me.lbColeg.Name = "lbColeg"
        Me.lbColeg.Size = New System.Drawing.Size(63, 17)
        Me.lbColeg.TabIndex = 50
        Me.lbColeg.Text = "Entidad"
        '
        'DateInicio
        '
        Me.DateInicio.Location = New System.Drawing.Point(625, 68)
        Me.DateInicio.Name = "DateInicio"
        Me.DateInicio.Size = New System.Drawing.Size(132, 20)
        Me.DateInicio.TabIndex = 51
        Me.DateInicio.Value = New Date(2011, 9, 1, 1, 0, 0, 0)
        '
        'DateFinal
        '
        Me.DateFinal.Location = New System.Drawing.Point(625, 94)
        Me.DateFinal.Name = "DateFinal"
        Me.DateFinal.Size = New System.Drawing.Size(132, 20)
        Me.DateFinal.TabIndex = 52
        Me.DateFinal.Value = New Date(2011, 10, 5, 11, 55, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(573, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(573, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Hasta:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.rbColegio)
        Me.GroupBox1.Controls.Add(Me.rbAmbos)
        Me.GroupBox1.Controls.Add(Me.rbCategoria)
        Me.GroupBox1.Location = New System.Drawing.Point(907, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 95)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por:"
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(773, 75)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(71, 35)
        Me.btBuscar.TabIndex = 56
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'frmResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Olimpiadas_académicas.My.Resources.Resources.FondoDos
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1056, 577)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateFinal)
        Me.Controls.Add(Me.DateInicio)
        Me.Controls.Add(Me.lbColeg)
        Me.Controls.Add(Me.lbCateg)
        Me.Controls.Add(Me.cbEntidad)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cbCategorias)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btReporte)
        Me.Controls.Add(Me.DataGridExamen)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbReferencia)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmResultados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resultados"
        CType(Me.DataGridExamen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbReferencia As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridExamen As System.Windows.Forms.DataGridView
    Friend WithEvents btReporte As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cbCategorias As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cbEntidad As System.Windows.Forms.ComboBox
    Friend WithEvents rbCategoria As System.Windows.Forms.RadioButton
    Friend WithEvents rbAmbos As System.Windows.Forms.RadioButton
    Friend WithEvents rbColegio As System.Windows.Forms.RadioButton
    Friend WithEvents lbCateg As System.Windows.Forms.Label
    Friend WithEvents lbColeg As System.Windows.Forms.Label
    Friend WithEvents DateInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btBuscar As System.Windows.Forms.Button
End Class
