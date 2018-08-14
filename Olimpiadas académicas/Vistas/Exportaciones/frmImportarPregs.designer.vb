<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarPregs
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
        Me.lsbImportadas = New System.Windows.Forms.ListBox()
        Me.btExplorar = New System.Windows.Forms.Button()
        Me.btImportar = New System.Windows.Forms.Button()
        Me.PanelAImportar = New System.Windows.Forms.Panel()
        Me.CheckEncriptar = New System.Windows.Forms.CheckBox()
        Me.btImportarNuev = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lsbImportadas
        '
        Me.lsbImportadas.FormattingEnabled = True
        Me.lsbImportadas.Location = New System.Drawing.Point(426, 46)
        Me.lsbImportadas.Name = "lsbImportadas"
        Me.lsbImportadas.Size = New System.Drawing.Size(254, 472)
        Me.lsbImportadas.TabIndex = 4
        '
        'btExplorar
        '
        Me.btExplorar.Location = New System.Drawing.Point(106, 27)
        Me.btExplorar.Name = "btExplorar"
        Me.btExplorar.Size = New System.Drawing.Size(63, 26)
        Me.btExplorar.TabIndex = 9
        Me.btExplorar.Text = "Explorar"
        Me.btExplorar.UseVisualStyleBackColor = True
        '
        'btImportar
        '
        Me.btImportar.Location = New System.Drawing.Point(23, 60)
        Me.btImportar.Name = "btImportar"
        Me.btImportar.Size = New System.Drawing.Size(186, 26)
        Me.btImportar.TabIndex = 0
        Me.btImportar.Text = "Importar preguntas seleccionadas"
        Me.btImportar.UseVisualStyleBackColor = True
        '
        'PanelAImportar
        '
        Me.PanelAImportar.Location = New System.Drawing.Point(23, 92)
        Me.PanelAImportar.Name = "PanelAImportar"
        Me.PanelAImportar.Size = New System.Drawing.Size(334, 460)
        Me.PanelAImportar.TabIndex = 11
        '
        'CheckEncriptar
        '
        Me.CheckEncriptar.AutoSize = True
        Me.CheckEncriptar.Location = New System.Drawing.Point(23, 33)
        Me.CheckEncriptar.Name = "CheckEncriptar"
        Me.CheckEncriptar.Size = New System.Drawing.Size(77, 17)
        Me.CheckEncriptar.TabIndex = 12
        Me.CheckEncriptar.Text = "Encriptada"
        Me.CheckEncriptar.UseVisualStyleBackColor = True
        '
        'btImportarNuev
        '
        Me.btImportarNuev.Location = New System.Drawing.Point(215, 60)
        Me.btImportarNuev.Name = "btImportarNuev"
        Me.btImportarNuev.Size = New System.Drawing.Size(142, 26)
        Me.btImportarNuev.TabIndex = 13
        Me.btImportarNuev.Text = "Importar preguntas nuevas"
        Me.btImportarNuev.UseVisualStyleBackColor = True
        '
        'frmImportarPregs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 597)
        Me.Controls.Add(Me.btImportarNuev)
        Me.Controls.Add(Me.CheckEncriptar)
        Me.Controls.Add(Me.PanelAImportar)
        Me.Controls.Add(Me.btImportar)
        Me.Controls.Add(Me.btExplorar)
        Me.Controls.Add(Me.lsbImportadas)
        Me.Name = "frmImportarPregs"
        Me.Text = "frmImportarPregs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsbImportadas As System.Windows.Forms.ListBox
    Friend WithEvents btExplorar As System.Windows.Forms.Button
    Friend WithEvents btImportar As System.Windows.Forms.Button
    Friend WithEvents PanelAImportar As System.Windows.Forms.Panel
    Friend WithEvents CheckEncriptar As System.Windows.Forms.CheckBox
    Friend WithEvents btImportarNuev As System.Windows.Forms.Button
End Class
