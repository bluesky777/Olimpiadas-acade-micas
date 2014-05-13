Public Class frmMensajeSuperior

    Dim Delay As Integer = 20
    Dim DelayTitulo As Integer = 20

    Private Sub frmMensajeSuperior_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Me.Width = My.Computer.Screen.Bounds.Width
        Me.Height = 110

        Me.Opacity = 0
        TimerAnimEntrada.Enabled = True
    End Sub

    Public Sub MostrarPregunta(idCat As Integer, numPreg As Integer)
        Dim Orden As Integer

        Orden = modPreguntas.MostrarPregunta(idCat, numPreg, lbTitulo, lbSubTitulo1, lbSubTitulo2, lbSubTitulo3, lbSubTitulo4, True)

        Centrar5Labels()
    End Sub

    Public Sub CerraAnimacion()
        TimerAnimacion.Enabled = True
    End Sub

    Private Sub TimerAnimacion_Tick(sender As Object, e As EventArgs) Handles TimerAnimacion.Tick
        If Delay < 0 Then
            If Me.Opacity < 0.09 Then
                Me.Close()
            Else
                Me.Opacity -= 0.08
            End If
        Else
            Delay -= 1
        End If

    End Sub

    Private Sub frmMensajeSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Close()
    End Sub

    Private Sub TimerAnimEntrada_Tick(sender As Object, e As EventArgs) Handles TimerAnimEntrada.Tick
        If Me.Opacity > 0.7 Then
            TimerAnimEntrada.Enabled = False
        Else
            Me.Opacity += 0.08
        End If
    End Sub

    Private Sub Centrar5Labels()

        lbTitulo.AutoSize = False
        lbSubTitulo1.AutoSize = False
        lbSubTitulo2.AutoSize = False
        lbSubTitulo3.AutoSize = False
        lbSubTitulo4.AutoSize = False


        lbTitulo.Top = 0
        lbTitulo.Left = 0
        lbTitulo.Width = Me.Width
        lbTitulo.Height = 58
        lbTitulo.TextAlign = ContentAlignment.MiddleCenter

        lbSubTitulo1.Left = 3
        lbSubTitulo2.Left = Me.Width / 2 - 6
        lbSubTitulo3.Left = 3
        lbSubTitulo4.Left = Me.Width / 2 - 6

        lbSubTitulo1.Width = Me.Width / 2 - 3
        lbSubTitulo2.Width = Me.Width / 2 - 6
        lbSubTitulo3.Width = Me.Width / 2 - 3
        lbSubTitulo4.Width = Me.Width / 2 - 6

        lbSubTitulo1.TextAlign = ContentAlignment.MiddleCenter
        lbSubTitulo2.TextAlign = ContentAlignment.MiddleCenter
        lbSubTitulo3.TextAlign = ContentAlignment.MiddleCenter
        lbSubTitulo4.TextAlign = ContentAlignment.MiddleCenter

        lbSubTitulo1.Top = lbTitulo.Top + lbTitulo.Height
        lbSubTitulo2.Top = lbTitulo.Top + lbTitulo.Height

        lbSubTitulo3.Top = lbSubTitulo1.Top + lbSubTitulo1.Height
        lbSubTitulo4.Top = lbSubTitulo1.Top + lbSubTitulo1.Height



    End Sub


    Private Sub Centrar3Labels()
        lbTitulo.Top = 5
        lbTitulo.Left = Me.Width / 2 - lbTitulo.Width / 2
        lbSubTitulo1.Left = Me.Width / 2 - lbSubTitulo1.Width / 2
        lbSubTitulo2.Left = Me.Width / 2 - lbSubTitulo2.Width / 2
    End Sub


    Private Sub lbSubTitulo2_MouseEnter(sender As Object, e As EventArgs) Handles lbSubTitulo2.MouseEnter, lbSubTitulo1.MouseEnter, lbSubTitulo3.MouseEnter, lbSubTitulo4.MouseEnter, lbTitulo.MouseEnter
        Me.Close()
    End Sub
End Class