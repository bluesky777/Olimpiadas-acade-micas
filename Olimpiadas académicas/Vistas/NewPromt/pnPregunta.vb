Public Class pnPregunta
    Inherits Panel

    Public lbPregunta As Label
    Public lbResp1 As Label
    Public lbResp2 As Label
    Public lbResp3 As Label
    Public lbResp4 As Label

    Public formPromt As Form

    Sub New(ByRef formPromt As Form)

        Me.formPromt = formPromt
        Me.Width = Me.formPromt.Width
        Me.Height = Me.formPromt.Height - 30
        Me.Top = 30
        Me.Left = 0

        lbPregunta = New Label
        lbResp1 = New Label
        lbResp2 = New Label
        lbResp3 = New Label
        lbResp4 = New Label

        ArreglarLabels()
        ArreglarPictures()
    End Sub

    Public Sub getPregunta(idCat As Integer, numPreg As Integer, Optional mostrarCorrect As Boolean = False)

        modPreguntas.MostrarPregunta(idCat, numPreg, lbPregunta, lbResp1, lbResp2, lbResp3, lbResp4, mostrarCorrect)

        Me.Controls.Add(lbPregunta)
        Me.Controls.Add(lbResp1)
        Me.Controls.Add(lbResp2)
        Me.Controls.Add(lbResp3)
        Me.Controls.Add(lbResp4)

    End Sub


    Public Sub Llenar(preg As String, res1 As String, res2 As String, res3 As String, res4 As String)
        lbPregunta.Text = preg
        lbResp1.Text = res1
        lbResp2.Text = res2
        lbResp3.Text = res3
        lbResp4.Text = res4
    End Sub

    Private Sub ArreglarLabels()

        Dim _COLOR_LETRA As Color = Color.White

        With lbPregunta
            .AutoSize = False
            .Top = 0
            .Left = 0
            .BackColor = Color.Transparent
            .ForeColor = _COLOR_LETRA
            .Width = Me.Width
            .Height = Me.Height * 0.4
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = New Font("Arial", 22, FontStyle.Bold)
        End With

        With lbResp1
            .AutoSize = False
            .Top = lbPregunta.Top + lbPregunta.Height
            .Left = 0
            .BackColor = Color.Transparent
            .ForeColor = _COLOR_LETRA
            .Width = Me.formPromt.Width / 2
            .Height = Me.Height * 0.3
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = New Font("Arial", 22)
        End With

        With lbResp2
            .AutoSize = False
            .Top = lbPregunta.Top + lbPregunta.Height
            .Left = Me.Width / 2
            .BackColor = Color.Transparent
            .ForeColor = _COLOR_LETRA
            .Width = Me.formPromt.Width / 2
            .Height = Me.Height * 0.3
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = New Font("Arial", 22)
        End With

        With lbResp3
            .AutoSize = False
            .Top = lbResp1.Top + lbResp1.Height
            .Left = 0
            .BackColor = Color.Transparent
            .ForeColor = _COLOR_LETRA
            .Width = Me.formPromt.Width / 2
            .Height = Me.Height * 0.3
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = New Font("Arial", 22)
        End With

        With lbResp4
            .AutoSize = False
            .Top = lbResp1.Top + lbResp1.Height
            .Left = Me.Width / 2
            .BackColor = Color.Transparent
            .ForeColor = _COLOR_LETRA
            .Width = Me.formPromt.Width / 2
            .Height = Me.Height * 0.3
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = New Font("Arial", 22)
        End With

    
    End Sub

    Private Sub ArreglarPictures()


        Dim pictureDeg As New PictureBox
        pictureDeg.SizeMode = PictureBoxSizeMode.StretchImage
        pictureDeg.Image = CType(My.Resources.fondoStreak, Image)
        'pictureDeg.BringToFront()
        pictureDeg.Width = Me.Width
        pictureDeg.Height = 60
        pictureDeg.Top = Me.Height * 0.33

        Me.Controls.Add(pictureDeg)


        Dim pictureDeg1 As New PictureBox
        pictureDeg1.SizeMode = PictureBoxSizeMode.StretchImage
        pictureDeg1.Image = CType(My.Resources.planet, Image)
        'pictureDeg.BringToFront()
        pictureDeg1.Width = 150
        pictureDeg1.Height = 120
        pictureDeg1.Top = Me.Height * 0.6
        pictureDeg1.Left = Me.Width / 2 - 75

        Me.Controls.Add(pictureDeg1)


        'Dim myBrush As New System.Drawing.SolidBrush(System.Drawing.Color.Red)
        'Dim formGraphics As System.Drawing.Graphics
        'formGraphics = Me.CreateGraphics()
        'formGraphics.FillEllipse(myBrush, New Rectangle(0, 0, 200, 300))
        'myBrush.Dispose()
        'formGraphics.Dispose()


    End Sub

End Class

