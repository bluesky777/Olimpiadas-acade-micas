<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExamenes))
        Me.gridExamenes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CkSoloFinalistas = New System.Windows.Forms.CheckBox()
        Me.BtExportar = New System.Windows.Forms.Button()
        Me.LtCategoria = New System.Windows.Forms.ListBox()
        Me.LtEntidad = New System.Windows.Forms.ListBox()
        Me.CkCategoria = New System.Windows.Forms.CheckBox()
        Me.CkEntidad = New System.Windows.Forms.CheckBox()
        Me.btBuscarDatos = New System.Windows.Forms.Button()
        Me.ContextMenuGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuItemEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemVerDetalles = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.gridExamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuGrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridExamenes
        '
        Me.gridExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridExamenes.Location = New System.Drawing.Point(12, 165)
        Me.gridExamenes.Name = "gridExamenes"
        Me.gridExamenes.Size = New System.Drawing.Size(904, 399)
        Me.gridExamenes.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CkSoloFinalistas)
        Me.GroupBox1.Controls.Add(Me.BtExportar)
        Me.GroupBox1.Controls.Add(Me.LtCategoria)
        Me.GroupBox1.Controls.Add(Me.LtEntidad)
        Me.GroupBox1.Controls.Add(Me.CkCategoria)
        Me.GroupBox1.Controls.Add(Me.CkEntidad)
        Me.GroupBox1.Controls.Add(Me.btBuscarDatos)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(900, 147)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos a buscar"
        '
        'CkSoloFinalistas
        '
        Me.CkSoloFinalistas.AutoSize = True
        Me.CkSoloFinalistas.Location = New System.Drawing.Point(411, 14)
        Me.CkSoloFinalistas.Name = "CkSoloFinalistas"
        Me.CkSoloFinalistas.Size = New System.Drawing.Size(118, 21)
        Me.CkSoloFinalistas.TabIndex = 10
        Me.CkSoloFinalistas.Text = "Solo Finalistas"
        Me.CkSoloFinalistas.UseVisualStyleBackColor = True
        '
        'BtExportar
        '
        Me.BtExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtExportar.Location = New System.Drawing.Point(765, 95)
        Me.BtExportar.Name = "BtExportar"
        Me.BtExportar.Size = New System.Drawing.Size(129, 46)
        Me.BtExportar.TabIndex = 9
        Me.BtExportar.Text = "Exportar"
        Me.BtExportar.UseVisualStyleBackColor = True
        '
        'LtCategoria
        '
        Me.LtCategoria.FormattingEnabled = True
        Me.LtCategoria.ItemHeight = 16
        Me.LtCategoria.Location = New System.Drawing.Point(222, 41)
        Me.LtCategoria.Name = "LtCategoria"
        Me.LtCategoria.Size = New System.Drawing.Size(157, 100)
        Me.LtCategoria.TabIndex = 8
        '
        'LtEntidad
        '
        Me.LtEntidad.FormattingEnabled = True
        Me.LtEntidad.ItemHeight = 16
        Me.LtEntidad.Location = New System.Drawing.Point(6, 41)
        Me.LtEntidad.Name = "LtEntidad"
        Me.LtEntidad.Size = New System.Drawing.Size(193, 100)
        Me.LtEntidad.TabIndex = 7
        '
        'CkCategoria
        '
        Me.CkCategoria.AutoSize = True
        Me.CkCategoria.Checked = True
        Me.CkCategoria.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CkCategoria.Location = New System.Drawing.Point(224, 16)
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
        Me.CkEntidad.Location = New System.Drawing.Point(6, 20)
        Me.CkEntidad.Name = "CkEntidad"
        Me.CkEntidad.Size = New System.Drawing.Size(75, 21)
        Me.CkEntidad.TabIndex = 0
        Me.CkEntidad.Text = "Entidad"
        Me.CkEntidad.UseVisualStyleBackColor = True
        '
        'btBuscarDatos
        '
        Me.btBuscarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscarDatos.Location = New System.Drawing.Point(411, 41)
        Me.btBuscarDatos.Name = "btBuscarDatos"
        Me.btBuscarDatos.Size = New System.Drawing.Size(129, 46)
        Me.btBuscarDatos.TabIndex = 6
        Me.btBuscarDatos.Text = "Buscar"
        Me.btBuscarDatos.UseVisualStyleBackColor = True
        '
        'ContextMenuGrid
        '
        Me.ContextMenuGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemEliminar, Me.MenuItemVerDetalles})
        Me.ContextMenuGrid.Name = "ContextMenuGrid"
        Me.ContextMenuGrid.Size = New System.Drawing.Size(162, 48)
        '
        'MenuItemEliminar
        '
        Me.MenuItemEliminar.Name = "MenuItemEliminar"
        Me.MenuItemEliminar.Size = New System.Drawing.Size(161, 22)
        Me.MenuItemEliminar.Text = "Eliminar examen"
        '
        'MenuItemVerDetalles
        '
        Me.MenuItemVerDetalles.Name = "MenuItemVerDetalles"
        Me.MenuItemVerDetalles.Size = New System.Drawing.Size(161, 22)
        Me.MenuItemVerDetalles.Text = "Ver detalles"
        '
        'frmExamenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 576)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gridExamenes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmExamenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Puntajes exámenes"
        CType(Me.gridExamenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuGrid.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridExamenes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LtEntidad As System.Windows.Forms.ListBox
    Friend WithEvents CkCategoria As System.Windows.Forms.CheckBox
    Friend WithEvents CkEntidad As System.Windows.Forms.CheckBox
    Friend WithEvents btBuscarDatos As System.Windows.Forms.Button
    Friend WithEvents ContextMenuGrid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuItemEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemVerDetalles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LtCategoria As System.Windows.Forms.ListBox
    Friend WithEvents BtExportar As System.Windows.Forms.Button
    Friend WithEvents CkSoloFinalistas As System.Windows.Forms.CheckBox
End Class
