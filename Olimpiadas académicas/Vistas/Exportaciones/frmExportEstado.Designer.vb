<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportEstado
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
        Me.lstExportados = New System.Windows.Forms.ListBox()
        Me.lbEstadoFinal = New System.Windows.Forms.Label()
        Me.ProgressPregExport = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'lstExportados
        '
        Me.lstExportados.FormattingEnabled = True
        Me.lstExportados.Location = New System.Drawing.Point(11, 76)
        Me.lstExportados.Name = "lstExportados"
        Me.lstExportados.Size = New System.Drawing.Size(478, 173)
        Me.lstExportados.TabIndex = 0
        '
        'lbEstadoFinal
        '
        Me.lbEstadoFinal.AutoSize = True
        Me.lbEstadoFinal.Location = New System.Drawing.Point(9, 265)
        Me.lbEstadoFinal.Name = "lbEstadoFinal"
        Me.lbEstadoFinal.Size = New System.Drawing.Size(70, 13)
        Me.lbEstadoFinal.TabIndex = 1
        Me.lbEstadoFinal.Text = "lbEstadoFinal"
        '
        'ProgressPregExport
        '
        Me.ProgressPregExport.Location = New System.Drawing.Point(12, 24)
        Me.ProgressPregExport.Name = "ProgressPregExport"
        Me.ProgressPregExport.Size = New System.Drawing.Size(476, 23)
        Me.ProgressPregExport.TabIndex = 2
        '
        'frmExportEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 299)
        Me.Controls.Add(Me.ProgressPregExport)
        Me.Controls.Add(Me.lbEstadoFinal)
        Me.Controls.Add(Me.lstExportados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmExportEstado"
        Me.Text = "Exportando, por favor espere..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstExportados As System.Windows.Forms.ListBox
    Friend WithEvents lbEstadoFinal As System.Windows.Forms.Label
    Friend WithEvents ProgressPregExport As System.Windows.Forms.ProgressBar
End Class
