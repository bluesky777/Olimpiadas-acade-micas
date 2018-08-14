<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPublicoExamen
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
        Me.lbCategoría = New System.Windows.Forms.Label()
        Me.lbTiempo = New System.Windows.Forms.Label()
        Me.PanelResp4 = New System.Windows.Forms.Panel()
        Me.LbResp4 = New System.Windows.Forms.Label()
        Me.PanelResp3 = New System.Windows.Forms.Panel()
        Me.LbResp3 = New System.Windows.Forms.Label()
        Me.PanelResp2 = New System.Windows.Forms.Panel()
        Me.LbResp2 = New System.Windows.Forms.Label()
        Me.PanelRespCorr = New System.Windows.Forms.Panel()
        Me.LbCorrecta = New System.Windows.Forms.Label()
        Me.PanelPreg = New System.Windows.Forms.Panel()
        Me.lbPregunta = New System.Windows.Forms.Label()
        Me.lbInformacion1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbNumPreg = New System.Windows.Forms.Label()
        Me.lbCantPreg = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbIncorrectas = New System.Windows.Forms.Label()
        Me.lbCorrectas = New System.Windows.Forms.Label()
        Me.lbPregId = New System.Windows.Forms.Label()
        Me.lbOrdenResp = New System.Windows.Forms.Label()
        Me.lbSegPreg = New System.Windows.Forms.Label()
        Me.lbMinPreg = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LbSeg2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbSeg = New System.Windows.Forms.Label()
        Me.LbMin2 = New System.Windows.Forms.Label()
        Me.lbMin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelResp4.SuspendLayout()
        Me.PanelResp3.SuspendLayout()
        Me.PanelResp2.SuspendLayout()
        Me.PanelRespCorr.SuspendLayout()
        Me.PanelPreg.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbCategoría
        '
        Me.lbCategoría.AutoSize = True
        Me.lbCategoría.BackColor = System.Drawing.Color.Transparent
        Me.lbCategoría.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCategoría.Location = New System.Drawing.Point(127, 21)
        Me.lbCategoría.Name = "lbCategoría"
        Me.lbCategoría.Size = New System.Drawing.Size(127, 29)
        Me.lbCategoría.TabIndex = 50
        Me.lbCategoría.Text = "Categoría"
        '
        'lbTiempo
        '
        Me.lbTiempo.AutoSize = True
        Me.lbTiempo.BackColor = System.Drawing.Color.Transparent
        Me.lbTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTiempo.Location = New System.Drawing.Point(717, 11)
        Me.lbTiempo.Name = "lbTiempo"
        Me.lbTiempo.Size = New System.Drawing.Size(30, 31)
        Me.lbTiempo.TabIndex = 47
        Me.lbTiempo.Text = "0"
        '
        'PanelResp4
        '
        Me.PanelResp4.BackColor = System.Drawing.Color.Transparent
        Me.PanelResp4.Controls.Add(Me.LbResp4)
        Me.PanelResp4.Location = New System.Drawing.Point(479, 488)
        Me.PanelResp4.Name = "PanelResp4"
        Me.PanelResp4.Size = New System.Drawing.Size(250, 90)
        Me.PanelResp4.TabIndex = 45
        '
        'LbResp4
        '
        Me.LbResp4.AutoSize = True
        Me.LbResp4.BackColor = System.Drawing.Color.Transparent
        Me.LbResp4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbResp4.Location = New System.Drawing.Point(40, 29)
        Me.LbResp4.Name = "LbResp4"
        Me.LbResp4.Size = New System.Drawing.Size(120, 17)
        Me.LbResp4.TabIndex = 5
        Me.LbResp4.Text = "Respuesta cuatro"
        Me.LbResp4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelResp3
        '
        Me.PanelResp3.BackColor = System.Drawing.Color.Transparent
        Me.PanelResp3.Controls.Add(Me.LbResp3)
        Me.PanelResp3.Location = New System.Drawing.Point(85, 488)
        Me.PanelResp3.Name = "PanelResp3"
        Me.PanelResp3.Size = New System.Drawing.Size(250, 90)
        Me.PanelResp3.TabIndex = 44
        '
        'LbResp3
        '
        Me.LbResp3.AutoSize = True
        Me.LbResp3.BackColor = System.Drawing.Color.Transparent
        Me.LbResp3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbResp3.Location = New System.Drawing.Point(78, 19)
        Me.LbResp3.Name = "LbResp3"
        Me.LbResp3.Size = New System.Drawing.Size(104, 17)
        Me.LbResp3.TabIndex = 4
        Me.LbResp3.Text = "Respuesta tres"
        Me.LbResp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelResp2
        '
        Me.PanelResp2.BackColor = System.Drawing.Color.Transparent
        Me.PanelResp2.Controls.Add(Me.LbResp2)
        Me.PanelResp2.Location = New System.Drawing.Point(479, 380)
        Me.PanelResp2.Name = "PanelResp2"
        Me.PanelResp2.Size = New System.Drawing.Size(250, 90)
        Me.PanelResp2.TabIndex = 43
        '
        'LbResp2
        '
        Me.LbResp2.AutoSize = True
        Me.LbResp2.BackColor = System.Drawing.Color.Transparent
        Me.LbResp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbResp2.Location = New System.Drawing.Point(100, 18)
        Me.LbResp2.Name = "LbResp2"
        Me.LbResp2.Size = New System.Drawing.Size(103, 17)
        Me.LbResp2.TabIndex = 3
        Me.LbResp2.Text = "Respuesta dos"
        Me.LbResp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelRespCorr
        '
        Me.PanelRespCorr.BackColor = System.Drawing.Color.Transparent
        Me.PanelRespCorr.Controls.Add(Me.LbCorrecta)
        Me.PanelRespCorr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelRespCorr.Location = New System.Drawing.Point(85, 380)
        Me.PanelRespCorr.Name = "PanelRespCorr"
        Me.PanelRespCorr.Size = New System.Drawing.Size(250, 90)
        Me.PanelRespCorr.TabIndex = 42
        '
        'LbCorrecta
        '
        Me.LbCorrecta.AutoSize = True
        Me.LbCorrecta.BackColor = System.Drawing.Color.Transparent
        Me.LbCorrecta.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCorrecta.Location = New System.Drawing.Point(17, 36)
        Me.LbCorrecta.Name = "LbCorrecta"
        Me.LbCorrecta.Size = New System.Drawing.Size(112, 17)
        Me.LbCorrecta.TabIndex = 2
        Me.LbCorrecta.Text = "Repuesta correcta"
        Me.LbCorrecta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelPreg
        '
        Me.PanelPreg.BackColor = System.Drawing.Color.Transparent
        Me.PanelPreg.Controls.Add(Me.lbPregunta)
        Me.PanelPreg.Location = New System.Drawing.Point(114, 197)
        Me.PanelPreg.Name = "PanelPreg"
        Me.PanelPreg.Size = New System.Drawing.Size(566, 159)
        Me.PanelPreg.TabIndex = 41
        '
        'lbPregunta
        '
        Me.lbPregunta.AutoSize = True
        Me.lbPregunta.BackColor = System.Drawing.Color.Transparent
        Me.lbPregunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPregunta.Location = New System.Drawing.Point(298, 71)
        Me.lbPregunta.Name = "lbPregunta"
        Me.lbPregunta.Size = New System.Drawing.Size(66, 17)
        Me.lbPregunta.TabIndex = 1
        Me.lbPregunta.Text = "Pregunta"
        Me.lbPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbInformacion1
        '
        Me.lbInformacion1.AutoSize = True
        Me.lbInformacion1.BackColor = System.Drawing.Color.Transparent
        Me.lbInformacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInformacion1.Location = New System.Drawing.Point(207, 96)
        Me.lbInformacion1.Name = "lbInformacion1"
        Me.lbInformacion1.Size = New System.Drawing.Size(289, 24)
        Me.lbInformacion1.TabIndex = 52
        Me.lbInformacion1.Text = "Pregunta Número               de"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lbNumPreg
        '
        Me.lbNumPreg.AutoSize = True
        Me.lbNumPreg.BackColor = System.Drawing.Color.Transparent
        Me.lbNumPreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumPreg.Location = New System.Drawing.Point(389, 78)
        Me.lbNumPreg.Name = "lbNumPreg"
        Me.lbNumPreg.Size = New System.Drawing.Size(43, 46)
        Me.lbNumPreg.TabIndex = 53
        Me.lbNumPreg.Text = "0"
        '
        'lbCantPreg
        '
        Me.lbCantPreg.AutoSize = True
        Me.lbCantPreg.BackColor = System.Drawing.Color.Transparent
        Me.lbCantPreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCantPreg.Location = New System.Drawing.Point(502, 78)
        Me.lbCantPreg.Name = "lbCantPreg"
        Me.lbCantPreg.Size = New System.Drawing.Size(43, 46)
        Me.lbCantPreg.TabIndex = 54
        Me.lbCantPreg.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LbIncorrectas)
        Me.GroupBox1.Controls.Add(Me.lbCorrectas)
        Me.GroupBox1.Controls.Add(Me.lbPregId)
        Me.GroupBox1.Controls.Add(Me.lbOrdenResp)
        Me.GroupBox1.Controls.Add(Me.lbSegPreg)
        Me.GroupBox1.Controls.Add(Me.lbMinPreg)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LbSeg2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbSeg)
        Me.GroupBox1.Controls.Add(Me.LbMin2)
        Me.GroupBox1.Controls.Add(Me.lbMin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(796, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 171)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        '
        'LbIncorrectas
        '
        Me.LbIncorrectas.AutoSize = True
        Me.LbIncorrectas.Location = New System.Drawing.Point(25, 152)
        Me.LbIncorrectas.Name = "LbIncorrectas"
        Me.LbIncorrectas.Size = New System.Drawing.Size(13, 13)
        Me.LbIncorrectas.TabIndex = 44
        Me.LbIncorrectas.Text = "0"
        '
        'lbCorrectas
        '
        Me.lbCorrectas.AutoSize = True
        Me.lbCorrectas.Location = New System.Drawing.Point(25, 131)
        Me.lbCorrectas.Name = "lbCorrectas"
        Me.lbCorrectas.Size = New System.Drawing.Size(13, 13)
        Me.lbCorrectas.TabIndex = 43
        Me.lbCorrectas.Text = "0"
        '
        'lbPregId
        '
        Me.lbPregId.AutoSize = True
        Me.lbPregId.Location = New System.Drawing.Point(25, 111)
        Me.lbPregId.Name = "lbPregId"
        Me.lbPregId.Size = New System.Drawing.Size(13, 13)
        Me.lbPregId.TabIndex = 42
        Me.lbPregId.Text = "1"
        '
        'lbOrdenResp
        '
        Me.lbOrdenResp.AutoSize = True
        Me.lbOrdenResp.Location = New System.Drawing.Point(25, 88)
        Me.lbOrdenResp.Name = "lbOrdenResp"
        Me.lbOrdenResp.Size = New System.Drawing.Size(90, 13)
        Me.lbOrdenResp.TabIndex = 41
        Me.lbOrdenResp.Text = "Orden Respuesta"
        '
        'lbSegPreg
        '
        Me.lbSegPreg.AutoSize = True
        Me.lbSegPreg.BackColor = System.Drawing.Color.Transparent
        Me.lbSegPreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSegPreg.Location = New System.Drawing.Point(78, 43)
        Me.lbSegPreg.Name = "lbSegPreg"
        Me.lbSegPreg.Size = New System.Drawing.Size(18, 20)
        Me.lbSegPreg.TabIndex = 33
        Me.lbSegPreg.Text = "0"
        '
        'lbMinPreg
        '
        Me.lbMinPreg.AutoSize = True
        Me.lbMinPreg.BackColor = System.Drawing.Color.Transparent
        Me.lbMinPreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMinPreg.Location = New System.Drawing.Point(49, 43)
        Me.lbMinPreg.Name = "lbMinPreg"
        Me.lbMinPreg.Size = New System.Drawing.Size(18, 20)
        Me.lbMinPreg.TabIndex = 34
        Me.lbMinPreg.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(70, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 20)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(70, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 20)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "/"
        '
        'LbSeg2
        '
        Me.LbSeg2.AutoSize = True
        Me.LbSeg2.BackColor = System.Drawing.Color.Transparent
        Me.LbSeg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSeg2.Location = New System.Drawing.Point(111, 16)
        Me.LbSeg2.Name = "LbSeg2"
        Me.LbSeg2.Size = New System.Drawing.Size(18, 20)
        Me.LbSeg2.TabIndex = 29
        Me.LbSeg2.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = ":"
        '
        'lbSeg
        '
        Me.lbSeg.AutoSize = True
        Me.lbSeg.BackColor = System.Drawing.Color.Transparent
        Me.lbSeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSeg.Location = New System.Drawing.Point(49, 16)
        Me.lbSeg.Name = "lbSeg"
        Me.lbSeg.Size = New System.Drawing.Size(18, 20)
        Me.lbSeg.TabIndex = 26
        Me.lbSeg.Text = "0"
        '
        'LbMin2
        '
        Me.LbMin2.AutoSize = True
        Me.LbMin2.BackColor = System.Drawing.Color.Transparent
        Me.LbMin2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMin2.Location = New System.Drawing.Point(80, 16)
        Me.LbMin2.Name = "LbMin2"
        Me.LbMin2.Size = New System.Drawing.Size(18, 20)
        Me.LbMin2.TabIndex = 30
        Me.LbMin2.Text = "0"
        '
        'lbMin
        '
        Me.lbMin.AutoSize = True
        Me.lbMin.BackColor = System.Drawing.Color.Transparent
        Me.lbMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMin.Location = New System.Drawing.Point(20, 16)
        Me.lbMin.Name = "lbMin"
        Me.lbMin.Size = New System.Drawing.Size(18, 20)
        Me.lbMin.TabIndex = 27
        Me.lbMin.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = ":"
        '
        'frmPublicoExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Olimpiadas_académicas.My.Resources.Resources.FondoExamen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbCantPreg)
        Me.Controls.Add(Me.lbNumPreg)
        Me.Controls.Add(Me.lbInformacion1)
        Me.Controls.Add(Me.lbCategoría)
        Me.Controls.Add(Me.lbTiempo)
        Me.Controls.Add(Me.PanelResp4)
        Me.Controls.Add(Me.PanelResp3)
        Me.Controls.Add(Me.PanelResp2)
        Me.Controls.Add(Me.PanelRespCorr)
        Me.Controls.Add(Me.PanelPreg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPublicoExamen"
        Me.Text = "frmPublicoExamen"
        Me.PanelResp4.ResumeLayout(False)
        Me.PanelResp4.PerformLayout()
        Me.PanelResp3.ResumeLayout(False)
        Me.PanelResp3.PerformLayout()
        Me.PanelResp2.ResumeLayout(False)
        Me.PanelResp2.PerformLayout()
        Me.PanelRespCorr.ResumeLayout(False)
        Me.PanelRespCorr.PerformLayout()
        Me.PanelPreg.ResumeLayout(False)
        Me.PanelPreg.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbCategoría As System.Windows.Forms.Label
    Friend WithEvents lbTiempo As System.Windows.Forms.Label
    Friend WithEvents PanelResp4 As System.Windows.Forms.Panel
    Friend WithEvents LbResp4 As System.Windows.Forms.Label
    Friend WithEvents PanelResp3 As System.Windows.Forms.Panel
    Friend WithEvents LbResp3 As System.Windows.Forms.Label
    Friend WithEvents PanelResp2 As System.Windows.Forms.Panel
    Friend WithEvents LbResp2 As System.Windows.Forms.Label
    Friend WithEvents PanelRespCorr As System.Windows.Forms.Panel
    Friend WithEvents LbCorrecta As System.Windows.Forms.Label
    Friend WithEvents PanelPreg As System.Windows.Forms.Panel
    Friend WithEvents lbPregunta As System.Windows.Forms.Label
    Friend WithEvents lbInformacion1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbNumPreg As System.Windows.Forms.Label
    Friend WithEvents lbCantPreg As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbIncorrectas As System.Windows.Forms.Label
    Friend WithEvents lbCorrectas As System.Windows.Forms.Label
    Friend WithEvents lbPregId As System.Windows.Forms.Label
    Friend WithEvents lbOrdenResp As System.Windows.Forms.Label
    Friend WithEvents lbSegPreg As System.Windows.Forms.Label
    Friend WithEvents lbMinPreg As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LbSeg2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbSeg As System.Windows.Forms.Label
    Friend WithEvents LbMin2 As System.Windows.Forms.Label
    Friend WithEvents lbMin As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
