<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColegios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmColegios))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btNuevo = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.GridView1 = New System.Windows.Forms.DataGridView()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtEscudo = New System.Windows.Forms.TextBox()
        Me.txtRector = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btBuscarImg = New System.Windows.Forms.Button()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(70, 59)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(32, 20)
        Me.txtId.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(70, 85)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 0
        '
        'btEditar
        '
        Me.btEditar.Location = New System.Drawing.Point(102, 223)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(61, 23)
        Me.btEditar.TabIndex = 5
        Me.btEditar.Text = "Editar"
        Me.btEditar.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(303, 223)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(61, 23)
        Me.btGuardar.TabIndex = 8
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'btNuevo
        '
        Me.btNuevo.Location = New System.Drawing.Point(236, 223)
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(61, 23)
        Me.btNuevo.TabIndex = 7
        Me.btNuevo.Text = "Nuevo"
        Me.btNuevo.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(169, 223)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(61, 23)
        Me.btEliminar.TabIndex = 6
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'GridView1
        '
        Me.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView1.Location = New System.Drawing.Point(12, 282)
        Me.GridView1.Name = "GridView1"
        Me.GridView1.Size = New System.Drawing.Size(491, 139)
        Me.GridView1.TabIndex = 31
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(70, 117)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 2
        '
        'txtCiudad
        '
        Me.txtCiudad.Enabled = False
        Me.txtCiudad.Location = New System.Drawing.Point(235, 85)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(61, 20)
        Me.txtCiudad.TabIndex = 1
        '
        'txtEscudo
        '
        Me.txtEscudo.Enabled = False
        Me.txtEscudo.Location = New System.Drawing.Point(385, 99)
        Me.txtEscudo.Name = "txtEscudo"
        Me.txtEscudo.Size = New System.Drawing.Size(166, 20)
        Me.txtEscudo.TabIndex = 35
        '
        'txtRector
        '
        Me.txtRector.Enabled = False
        Me.txtRector.Location = New System.Drawing.Point(235, 113)
        Me.txtRector.Name = "txtRector"
        Me.txtRector.Size = New System.Drawing.Size(100, 20)
        Me.txtRector.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(484, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Logo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Cod"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(189, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Ciudad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Teléfono"
        '
        'btBuscarImg
        '
        Me.btBuscarImg.Enabled = False
        Me.btBuscarImg.Location = New System.Drawing.Point(521, 70)
        Me.btBuscarImg.Name = "btBuscarImg"
        Me.btBuscarImg.Size = New System.Drawing.Size(30, 23)
        Me.btBuscarImg.TabIndex = 4
        Me.btBuscarImg.Text = "..."
        Me.btBuscarImg.UseVisualStyleBackColor = True
        '
        'pbLogo
        '
        Me.pbLogo.Location = New System.Drawing.Point(385, 125)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(166, 151)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 42
        Me.pbLogo.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(192, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Rector"
        '
        'frmColegios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(563, 468)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.btBuscarImg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEscudo)
        Me.Controls.Add(Me.txtRector)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.GridView1)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.btNuevo)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmColegios"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colegios"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btEditar As System.Windows.Forms.Button
    Friend WithEvents btGuardar As System.Windows.Forms.Button
    Friend WithEvents btNuevo As System.Windows.Forms.Button
    Friend WithEvents btEliminar As System.Windows.Forms.Button
    Friend WithEvents GridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents txtEscudo As System.Windows.Forms.TextBox
    Friend WithEvents txtRector As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btBuscarImg As System.Windows.Forms.Button
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
