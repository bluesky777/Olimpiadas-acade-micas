<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionPreguntas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeleccionPreguntas))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.lbTotal2 = New System.Windows.Forms.Label()
        Me.lbTotal1 = New System.Windows.Forms.Label()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btQuitarTodo = New System.Windows.Forms.Button()
        Me.btAgregarTodo = New System.Windows.Forms.Button()
        Me.btQuitarSel = New System.Windows.Forms.Button()
        Me.btAgregarSel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NumCant = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lbA = New System.Windows.Forms.Label()
        Me.lbPregunta = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.NumCant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(14, 93)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(254, 251)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(355, 93)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox2.Size = New System.Drawing.Size(240, 251)
        Me.ListBox2.TabIndex = 1
        '
        'lbTotal2
        '
        Me.lbTotal2.AutoSize = True
        Me.lbTotal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal2.Location = New System.Drawing.Point(352, 347)
        Me.lbTotal2.Name = "lbTotal2"
        Me.lbTotal2.Size = New System.Drawing.Size(64, 17)
        Me.lbTotal2.TabIndex = 5
        Me.lbTotal2.Text = "Total: 0"
        '
        'lbTotal1
        '
        Me.lbTotal1.AutoSize = True
        Me.lbTotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal1.Location = New System.Drawing.Point(14, 347)
        Me.lbTotal1.Name = "lbTotal1"
        Me.lbTotal1.Size = New System.Drawing.Size(56, 17)
        Me.lbTotal1.TabIndex = 7
        Me.lbTotal1.Text = "Total: 0"
        '
        'cbCategoria
        '
        Me.cbCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(365, 39)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(159, 28)
        Me.cbCategoria.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Seleccione Categoría"
        '
        'btQuitarTodo
        '
        Me.btQuitarTodo.Location = New System.Drawing.Point(286, 292)
        Me.btQuitarTodo.Name = "btQuitarTodo"
        Me.btQuitarTodo.Size = New System.Drawing.Size(53, 23)
        Me.btQuitarTodo.TabIndex = 11
        Me.btQuitarTodo.Text = "<<"
        Me.btQuitarTodo.UseVisualStyleBackColor = True
        '
        'btAgregarTodo
        '
        Me.btAgregarTodo.Location = New System.Drawing.Point(286, 321)
        Me.btAgregarTodo.Name = "btAgregarTodo"
        Me.btAgregarTodo.Size = New System.Drawing.Size(53, 23)
        Me.btAgregarTodo.TabIndex = 10
        Me.btAgregarTodo.Text = ">>"
        Me.btAgregarTodo.UseVisualStyleBackColor = True
        '
        'btQuitarSel
        '
        Me.btQuitarSel.Location = New System.Drawing.Point(286, 93)
        Me.btQuitarSel.Name = "btQuitarSel"
        Me.btQuitarSel.Size = New System.Drawing.Size(53, 23)
        Me.btQuitarSel.TabIndex = 13
        Me.btQuitarSel.Text = "<"
        Me.btQuitarSel.UseVisualStyleBackColor = True
        '
        'btAgregarSel
        '
        Me.btAgregarSel.Location = New System.Drawing.Point(286, 122)
        Me.btAgregarSel.Name = "btAgregarSel"
        Me.btAgregarSel.Size = New System.Drawing.Size(53, 23)
        Me.btAgregarSel.TabIndex = 12
        Me.btAgregarSel.Text = ">"
        Me.btAgregarSel.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 488)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 38)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Atrás"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.NumCant)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(445, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 69)
        Me.Panel1.TabIndex = 15
        '
        'NumCant
        '
        Me.NumCant.Location = New System.Drawing.Point(31, 43)
        Me.NumCant.Name = "NumCant"
        Me.NumCant.Size = New System.Drawing.Size(46, 20)
        Me.NumCant.TabIndex = 23
        Me.NumCant.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(83, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Ejecutar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "preguntas aleatoriamente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Borrar y establecer"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 65)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(615, 412)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.ListBox2)
        Me.TabPage1.Controls.Add(Me.btQuitarSel)
        Me.TabPage1.Controls.Add(Me.lbTotal2)
        Me.TabPage1.Controls.Add(Me.btAgregarSel)
        Me.TabPage1.Controls.Add(Me.lbTotal1)
        Me.TabPage1.Controls.Add(Me.btQuitarTodo)
        Me.TabPage1.Controls.Add(Me.btAgregarTodo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(607, 386)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Preguntas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(319, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Pase las preguntas que desea para el examen de cada categoría."
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lbA)
        Me.TabPage2.Controls.Add(Me.lbPregunta)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(607, 386)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Respuestas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lbA
        '
        Me.lbA.AutoSize = True
        Me.lbA.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbA.Location = New System.Drawing.Point(177, 167)
        Me.lbA.Name = "lbA"
        Me.lbA.Size = New System.Drawing.Size(219, 26)
        Me.lbA.TabIndex = 1
        Me.lbA.Text = "Zona en construcción"
        '
        'lbPregunta
        '
        Me.lbPregunta.AutoSize = True
        Me.lbPregunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPregunta.Location = New System.Drawing.Point(83, 299)
        Me.lbPregunta.Name = "lbPregunta"
        Me.lbPregunta.Size = New System.Drawing.Size(438, 17)
        Me.lbPregunta.TabIndex = 0
        Me.lbPregunta.Text = "Aquí podrás elegir en donde quieres que vaya la respuesta correcta"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Olimpiadas_académicas.My.Resources.Resources.LogoAOL
        Me.PictureBox2.Location = New System.Drawing.Point(-6, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(138, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'frmSeleccionPreguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Olimpiadas_académicas.My.Resources.Resources.FondoUno
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(646, 529)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbCategoria)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSeleccionPreguntas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selección de preguntas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumCant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents lbTotal2 As System.Windows.Forms.Label
    Friend WithEvents lbTotal1 As System.Windows.Forms.Label
    Friend WithEvents cbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btQuitarTodo As System.Windows.Forms.Button
    Friend WithEvents btAgregarTodo As System.Windows.Forms.Button
    Friend WithEvents btQuitarSel As System.Windows.Forms.Button
    Friend WithEvents btAgregarSel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NumCant As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lbPregunta As System.Windows.Forms.Label
    Friend WithEvents lbA As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
