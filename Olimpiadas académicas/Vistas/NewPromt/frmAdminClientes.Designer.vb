<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminClientes
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
        Me.ContextMenuTree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CerrarExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiguientePreguntaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpezarExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.btExpand = New System.Windows.Forms.Button()
        Me.btContraer = New System.Windows.Forms.Button()
        Me.btCerrarSistemas = New System.Windows.Forms.Button()
        Me.ContextMenuTree.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuTree
        '
        Me.ContextMenuTree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarExamenToolStripMenuItem, Me.CerrarSistemaToolStripMenuItem, Me.SiguientePreguntaToolStripMenuItem, Me.EmpezarExamenToolStripMenuItem})
        Me.ContextMenuTree.Name = "ContextMenuTree"
        Me.ContextMenuTree.Size = New System.Drawing.Size(178, 114)
        '
        'CerrarExamenToolStripMenuItem
        '
        Me.CerrarExamenToolStripMenuItem.Name = "CerrarExamenToolStripMenuItem"
        Me.CerrarExamenToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CerrarExamenToolStripMenuItem.Text = "Cerrar examen."
        '
        'CerrarSistemaToolStripMenuItem
        '
        Me.CerrarSistemaToolStripMenuItem.Name = "CerrarSistemaToolStripMenuItem"
        Me.CerrarSistemaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CerrarSistemaToolStripMenuItem.Text = "Cerrar sistema."
        '
        'SiguientePreguntaToolStripMenuItem
        '
        Me.SiguientePreguntaToolStripMenuItem.Name = "SiguientePreguntaToolStripMenuItem"
        Me.SiguientePreguntaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.SiguientePreguntaToolStripMenuItem.Text = "Siguiente pregunta."
        '
        'EmpezarExamenToolStripMenuItem
        '
        Me.EmpezarExamenToolStripMenuItem.Name = "EmpezarExamenToolStripMenuItem"
        Me.EmpezarExamenToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.EmpezarExamenToolStripMenuItem.Text = "Empezar examen."
        '
        'TreeView1
        '
        Me.TreeView1.ContextMenuStrip = Me.ContextMenuTree
        Me.TreeView1.Location = New System.Drawing.Point(12, 31)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(331, 361)
        Me.TreeView1.TabIndex = 1
        '
        'btExpand
        '
        Me.btExpand.Location = New System.Drawing.Point(12, 3)
        Me.btExpand.Name = "btExpand"
        Me.btExpand.Size = New System.Drawing.Size(33, 23)
        Me.btExpand.TabIndex = 2
        Me.btExpand.Text = "+"
        Me.btExpand.UseVisualStyleBackColor = True
        '
        'btContraer
        '
        Me.btContraer.Location = New System.Drawing.Point(51, 3)
        Me.btContraer.Name = "btContraer"
        Me.btContraer.Size = New System.Drawing.Size(33, 23)
        Me.btContraer.TabIndex = 3
        Me.btContraer.Text = "-"
        Me.btContraer.UseVisualStyleBackColor = True
        '
        'btCerrarSistemas
        '
        Me.btCerrarSistemas.Location = New System.Drawing.Point(12, 398)
        Me.btCerrarSistemas.Name = "btCerrarSistemas"
        Me.btCerrarSistemas.Size = New System.Drawing.Size(120, 28)
        Me.btCerrarSistemas.TabIndex = 4
        Me.btCerrarSistemas.Text = "Cerrar sistemas"
        Me.btCerrarSistemas.UseVisualStyleBackColor = True
        '
        'frmAdminClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 439)
        Me.Controls.Add(Me.btCerrarSistemas)
        Me.Controls.Add(Me.btContraer)
        Me.Controls.Add(Me.btExpand)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "frmAdminClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Administrar clientes."
        Me.ContextMenuTree.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuTree As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents btExpand As System.Windows.Forms.Button
    Friend WithEvents btContraer As System.Windows.Forms.Button
    Friend WithEvents btCerrarSistemas As System.Windows.Forms.Button
    Friend WithEvents CerrarExamenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SiguientePreguntaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpezarExamenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
