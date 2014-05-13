<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreguntas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreguntas))
        Me.cbCategorias = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPregunta = New System.Windows.Forms.TextBox()
        Me.txtRespCor = New System.Windows.Forms.TextBox()
        Me.txtResp3 = New System.Windows.Forms.TextBox()
        Me.txtResp2 = New System.Windows.Forms.TextBox()
        Me.txtResp4 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btNuevo = New System.Windows.Forms.Button()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()

        Me.lbLenPreg = New System.Windows.Forms.Label()
        Me.lbLenCorr = New System.Windows.Forms.Label()
        Me.lbLen2 = New System.Windows.Forms.Label()
        Me.lbLen3 = New System.Windows.Forms.Label()
        Me.LbLen4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbBuscar = New System.Windows.Forms.ComboBox()
        Me.lbId = New System.Windows.Forms.Label()
        Me.lbRegistros = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCateg2 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbCategorias
        '
        Me.cbCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategorias.FormattingEnabled = True
        Me.cbCategorias.Location = New System.Drawing.Point(15, 69)
        Me.cbCategorias.Name = "cbCategorias"
        Me.cbCategorias.Size = New System.Drawing.Size(169, 28)
        Me.cbCategorias.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Seleccione categoría:"
        '
        'txtPregunta
        '
        Me.txtPregunta.Enabled = False
        Me.txtPregunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPregunta.Location = New System.Drawing.Point(15, 103)
        Me.txtPregunta.Multiline = True
        Me.txtPregunta.Name = "txtPregunta"
        Me.txtPregunta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPregunta.Size = New System.Drawing.Size(816, 91)
        Me.txtPregunta.TabIndex = 2
        Me.txtPregunta.Text = "Pregunta"
        Me.txtPregunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRespCor
        '
        Me.txtRespCor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRespCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRespCor.Enabled = False
        Me.txtRespCor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespCor.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtRespCor.Location = New System.Drawing.Point(15, 213)
        Me.txtRespCor.Multiline = True
        Me.txtRespCor.Name = "txtRespCor"
        Me.txtRespCor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRespCor.Size = New System.Drawing.Size(423, 48)
        Me.txtRespCor.TabIndex = 4
        '
        'txtResp3
        '
        Me.txtResp3.BackColor = System.Drawing.Color.LightCyan
        Me.txtResp3.Enabled = False
        Me.txtResp3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResp3.Location = New System.Drawing.Point(15, 290)
        Me.txtResp3.Multiline = True
        Me.txtResp3.Name = "txtResp3"
        Me.txtResp3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResp3.Size = New System.Drawing.Size(423, 42)
        Me.txtResp3.TabIndex = 6
        '
        'txtResp2
        '
        Me.txtResp2.BackColor = System.Drawing.Color.LightCyan
        Me.txtResp2.Enabled = False
        Me.txtResp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResp2.Location = New System.Drawing.Point(473, 213)
        Me.txtResp2.Multiline = True
        Me.txtResp2.Name = "txtResp2"
        Me.txtResp2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResp2.Size = New System.Drawing.Size(420, 48)
        Me.txtResp2.TabIndex = 5
        '
        'txtResp4
        '
        Me.txtResp4.BackColor = System.Drawing.Color.LightCyan
        Me.txtResp4.Enabled = False
        Me.txtResp4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResp4.Location = New System.Drawing.Point(473, 290)
        Me.txtResp4.Multiline = True
        Me.txtResp4.Name = "txtResp4"
        Me.txtResp4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResp4.Size = New System.Drawing.Size(420, 42)
        Me.txtResp4.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 398)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(876, 262)
        Me.DataGridView1.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btNuevo)
        Me.Panel2.Controls.Add(Me.btEditar)
        Me.Panel2.Controls.Add(Me.btGuardar)
        Me.Panel2.Controls.Add(Me.btEliminar)
        Me.Panel2.Location = New System.Drawing.Point(16, 338)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(327, 41)
        Me.Panel2.TabIndex = 20
        '
        'btNuevo
        '
        Me.btNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNuevo.Location = New System.Drawing.Point(246, 5)
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(66, 29)
        Me.btNuevo.TabIndex = 11
        Me.btNuevo.Text = "Nuevo"
        Me.btNuevo.UseVisualStyleBackColor = True
        '
        'btEditar
        '
        Me.btEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEditar.Location = New System.Drawing.Point(170, 5)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(70, 29)
        Me.btEditar.TabIndex = 10
        Me.btEditar.Text = "Editar"
        Me.btEditar.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.Enabled = False
        Me.btGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGuardar.Location = New System.Drawing.Point(91, 5)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(73, 29)
        Me.btGuardar.TabIndex = 9
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEliminar.Location = New System.Drawing.Point(16, 5)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(69, 29)
        Me.btEliminar.TabIndex = 8
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Respuesta correta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(470, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Respuesta 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(12, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Respuesta 3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(470, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Respuesta 4"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(837, 177)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Activa"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(190, 73)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(53, 20)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Todas"
        '
        'Flash1
        '
        'lbLenPreg
        '
        Me.lbLenPreg.AutoSize = True
        Me.lbLenPreg.BackColor = System.Drawing.Color.Transparent
        Me.lbLenPreg.Location = New System.Drawing.Point(837, 110)
        Me.lbLenPreg.Name = "lbLenPreg"
        Me.lbLenPreg.Size = New System.Drawing.Size(39, 13)
        Me.lbLenPreg.TabIndex = 29
        Me.lbLenPreg.Text = "Label9"
        '
        'lbLenCorr
        '
        Me.lbLenCorr.AutoSize = True
        Me.lbLenCorr.BackColor = System.Drawing.Color.Transparent
        Me.lbLenCorr.Location = New System.Drawing.Point(399, 197)
        Me.lbLenCorr.Name = "lbLenCorr"
        Me.lbLenCorr.Size = New System.Drawing.Size(39, 13)
        Me.lbLenCorr.TabIndex = 30
        Me.lbLenCorr.Text = "Label9"
        '
        'lbLen2
        '
        Me.lbLen2.AutoSize = True
        Me.lbLen2.BackColor = System.Drawing.Color.Transparent
        Me.lbLen2.Location = New System.Drawing.Point(854, 197)
        Me.lbLen2.Name = "lbLen2"
        Me.lbLen2.Size = New System.Drawing.Size(39, 13)
        Me.lbLen2.TabIndex = 31
        Me.lbLen2.Text = "Label9"
        '
        'lbLen3
        '
        Me.lbLen3.AutoSize = True
        Me.lbLen3.BackColor = System.Drawing.Color.Transparent
        Me.lbLen3.Location = New System.Drawing.Point(399, 274)
        Me.lbLen3.Name = "lbLen3"
        Me.lbLen3.Size = New System.Drawing.Size(39, 13)
        Me.lbLen3.TabIndex = 32
        Me.lbLen3.Text = "Label9"
        '
        'LbLen4
        '
        Me.LbLen4.AutoSize = True
        Me.LbLen4.BackColor = System.Drawing.Color.Transparent
        Me.LbLen4.Location = New System.Drawing.Point(854, 274)
        Me.LbLen4.Name = "LbLen4"
        Me.LbLen4.Size = New System.Drawing.Size(39, 13)
        Me.LbLen4.TabIndex = 33
        Me.LbLen4.Text = "Label9"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(741, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Código"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 33)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Atrás"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(241, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Buscar"
        '
        'cbBuscar
        '
        Me.cbBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuscar.FormattingEnabled = True
        Me.cbBuscar.Location = New System.Drawing.Point(312, 32)
        Me.cbBuscar.Name = "cbBuscar"
        Me.cbBuscar.Size = New System.Drawing.Size(369, 33)
        Me.cbBuscar.TabIndex = 40
        '
        'lbId
        '
        Me.lbId.AutoSize = True
        Me.lbId.BackColor = System.Drawing.Color.Blue
        Me.lbId.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbId.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbId.Location = New System.Drawing.Point(812, 62)
        Me.lbId.Name = "lbId"
        Me.lbId.Size = New System.Drawing.Size(72, 37)
        Me.lbId.TabIndex = 43
        Me.lbId.Text = "001"
        '
        'lbRegistros
        '
        Me.lbRegistros.AutoSize = True
        Me.lbRegistros.BackColor = System.Drawing.Color.Transparent
        Me.lbRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRegistros.Location = New System.Drawing.Point(381, 353)
        Me.lbRegistros.Name = "lbRegistros"
        Me.lbRegistros.Size = New System.Drawing.Size(29, 20)
        Me.lbRegistros.TabIndex = 46
        Me.lbRegistros.Text = "21"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(70, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 27)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Asignar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbCateg2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(912, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 126)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asignar categoria a pregunta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(24, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Seleccione categoría:"
        '
        'cbCateg2
        '
        Me.cbCateg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCateg2.FormattingEnabled = True
        Me.cbCateg2.Location = New System.Drawing.Point(27, 42)
        Me.cbCateg2.Name = "cbCateg2"
        Me.cbCateg2.Size = New System.Drawing.Size(144, 23)
        Me.cbCateg2.TabIndex = 49
        '
        'frmPreguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.Olimpiadas_académicas.My.Resources.Resources.FondoTres
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1134, 672)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbRegistros)
        Me.Controls.Add(Me.lbId)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbBuscar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LbLen4)
        Me.Controls.Add(Me.lbLen3)
        Me.Controls.Add(Me.lbLen2)
        Me.Controls.Add(Me.lbLenCorr)
        Me.Controls.Add(Me.lbLenPreg)

        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtResp4)
        Me.Controls.Add(Me.txtResp2)
        Me.Controls.Add(Me.txtResp3)
        Me.Controls.Add(Me.txtRespCor)
        Me.Controls.Add(Me.txtPregunta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbCategorias)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPreguntas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preguntas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)

        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbCategorias As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPregunta As System.Windows.Forms.TextBox
    Friend WithEvents txtRespCor As System.Windows.Forms.TextBox
    Friend WithEvents txtResp3 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp2 As System.Windows.Forms.TextBox
    Friend WithEvents txtResp4 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btNuevo As System.Windows.Forms.Button
    Friend WithEvents btEditar As System.Windows.Forms.Button
    Friend WithEvents btGuardar As System.Windows.Forms.Button
    Friend WithEvents btEliminar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

    Friend WithEvents lbLenPreg As System.Windows.Forms.Label
    Friend WithEvents lbLenCorr As System.Windows.Forms.Label
    Friend WithEvents lbLen2 As System.Windows.Forms.Label
    Friend WithEvents lbLen3 As System.Windows.Forms.Label
    Friend WithEvents LbLen4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents lbId As System.Windows.Forms.Label
    Friend WithEvents lbRegistros As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbCateg2 As System.Windows.Forms.ComboBox
End Class
