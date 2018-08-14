Imports System.Data
Imports System.Text
Imports System.Data.SqlClient

Imports System.Net
Imports System.Net.Sockets
Imports System.Threading 'Hilo que se activa para recibir mensajes

Public Class frmExamen

    Dim dtPreg As New DataTable
    Dim cmdExa As SqlCommand
    Public TiempoMax As Integer
    Dim SegMax As Double
    Dim Regresivo As Boolean = True
    Dim Elegida As String
    Dim ExamenId As Integer
    Dim ExamenActual As modExamen
    Public WithEvents mibinding As New BindingSource
    Dim dtConf As New DataTable
    Public salir As Boolean = False
    Dim CantidadPreg As Integer

    Dim ultimaPreg As Boolean = False


    Private Sub frmExamen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If salir = False Then
            Dim opc As DialogResult = MsgBox("¿Desea terminar el examen?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

            If opc = Windows.Forms.DialogResult.Yes Then
                Me.VolverAConectando()
            Else
                e.Cancel = True
            End If
        End If

    End Sub


    Private Sub frmExamen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Width = 930
        Me.Height = 635

        txtConversa.Text = "IG: Comienza el test! - Pregunta 1"
        FechaHora = Now

        Dim consultaPreguntas As String = "Select P.PregId, P.PregPregunta, P.PregRespCorrecta, P.PregResp2, P.PregResp3, P.PregResp4, c.PrCaOrden " _
                                & "from tbPreguntas P INNER JOIN tbCatPreg c ON c.PrCaPregunta=P.PregId " _
                                & "where c.PrCaCategoria=" & m_UsuarioAuth.IdCatInsActual & " and c.PrCaParaExamen=1"

        'MsgBox(consultaPreguntas)

        conn.TraerTabla(dtPreg, consultaPreguntas)
        Me.CantidadPreg = dtPreg.Rows.Count
        mibinding.DataSource = dtPreg

        conn.Conectar()

        Dim consultaInsertExa As String
        consultaInsertExa = "INSERT INTO tbExamenes(ExaInscripcion, ExaFecha, ExaEquipo, ExaCantPreg, ExaTipoExamen) " _
            & "VALUES(" & m_UsuarioAuth.IdInsActual & ", '" & FechaHora & "', '" & m_UsuarioAuth.Equipo.Row.Item("EquiNombre") & "', " _
            & Me.CantidadPreg & ", " & m_Eventos.Row.Item("EvTipoExamen") & ") ; "

        ExamenId = conn.EjecutarConsulta(consultaInsertExa, True)
        ExamenActual = New modExamen(ExamenId)
        ExamenActual.findRaw(ExamenActual.Id)

        m_Entidades.Id = m_UsuarioAuth.Row.Item("UsuEntidad")
        m_Entidades.findRaw(m_Entidades.Id)

        m_TipoExamen.findRaw(ExamenActual.Row.Item("ExaTipoExamen"))

        lbNombre.Text = m_UsuarioAuth.Row.Item("UsuNombre")
        lbInformacion.Text = m_Entidades.Row.Item("EntNombre") & vbCrLf & "Examen: " & m_TipoExamen.Row.Item("TeTipo")

        Dim idCat As Integer = m_Inscripciones.getCampoRaw(ExamenActual.Row.Item("ExaInscripcion"), "InsCategoria")
        lbCategoria.Text = m_Categorias.getCampoRaw(idCat, "CatNombre")

        'Dim AliasCat As String = m_Categorias.getCampoRaw(idCat, "CatNombreCorto")

       

        If ExamenActual.Row.Item("ExaTipoExamen") = 1 Then

            If m_Eventos.Row.Item("EvParaTodos") = False Then
                TiempoMax = m_Eventos.SegTimeExam
            Else

                Dim dtCat As New DataTable
                conn.TraerTabla(dtCat, "Select CatDuracion, CatNombre from tbCategorias where CatId=" & m_UsuarioAuth.IdCatInsActual)

                lbCategoria.Text = dtCat.Rows(0).Item("CatNombre")


                TiempoMax = modEventos.MinutesToSeg(dtCat.Rows(0).Item("CatDuracion"))

            End If

            SegMax = 0

        ElseIf ExamenActual.Row.Item("ExaTipoExamen") = 2 Then

            ' Envio el comando con los datos del examen al servidor.
            frmConectando.Cliente.EnviarTestIniciado(ExamenId, idCat, lbCategoria.Text, ExamenActual.Row.Item("ExaCantPreg"))

            TiempoMax = m_Eventos.Row.Item("EvSegundosPregMax")
        End If


        lbPregunta.DataBindings.Add("Text", mibinding, "PregPregunta")
        LbCorrecta.DataBindings.Add("Text", mibinding, "PregRespCorrecta")
        LbResp2.DataBindings.Add("Text", mibinding, "PregResp2")
        LbResp3.DataBindings.Add("Text", mibinding, "PregResp3")
        LbResp4.DataBindings.Add("Text", mibinding, "PregResp4")
        lbOrdenResp.DataBindings.Add("Text", mibinding, "PrCaOrden")
        lbPregId.DataBindings.Add("Text", mibinding, "PregId")


        ArreglarLabel()
        PosicionesRespuestas()
        TimerCompleto.Enabled = True
    End Sub


    Private Sub ArreglarLabel()
        ArreglarRespuesta(LbResp2)
        ArreglarRespuesta(LbResp3)
        ArreglarRespuesta(LbResp4)
        ArreglarRespuesta(LbCorrecta)

        With lbPregunta
            Select Case Len(.Text)
                Case Is < 60
                    .MaximumSize = New Size(580, 0)
                    .Font = New Font("Calibri", 17)
                Case Is < 100
                    .MaximumSize = New Size(580, 0)
                    .Font = New Font("Calibri", 16)
                Case Is < 200
                    .MaximumSize = New Size(600, 0)
                    .Font = New Font("Calibri", 16)
                Case Is < 300
                    .MaximumSize = New Size(620, 0)
                    .Font = New Font("Calibri", 15)
                Case Is < 400
                    .MaximumSize = New Size(620, 0)
                    .Font = New Font("Calibri", 14)
                Case Is < 500
                    .MaximumSize = New Size(620, 0)
                    .Font = New Font("Calibri", 13)
                Case Is < 600
                    .MaximumSize = New Size(620, 0)
                    .Font = New Font("Calibri", 12)
                Case Is < 750
                    .MaximumSize = New Size(620, 0)
                    .Font = New Font("Calibri", 11)
                Case Is < 900
                    .MaximumSize = New Size(620, 0)
                    .Font = New Font("Calibri", 10)
                Case Is < 1101
                    .MaximumSize = New Size(620, 0)
                    .Font = New Font("Calibri", 9)
            End Select
        End With


        CentrarObjeto(lbPregunta, PanelPreg)
        CentrarObjeto(LbResp2, PanelResp2)
        CentrarObjeto(LbResp3, PanelResp3)
        CentrarObjeto(LbResp4, PanelResp4)
        CentrarObjeto(LbCorrecta, PanelRespCorr)

    End Sub

    Private Sub ArreglarRespuesta(ByVal lbControl As Label)
        With lbControl
            .MaximumSize = New Size(270, 0)
            Select Case Len(lbControl.Text)
                Case Is < 30
                    .Font = New Font("Calibri", 16)
                Case Is < 50
                    .Font = New Font("Calibri", 15)
                Case Is < 75
                    .Font = New Font("Calibri", 14)
                Case Is < 100
                    .Font = New Font("Calibri", 12)
                Case Is < 130
                    .Font = New Font("Calibri", 11)
                Case Is < 175
                    .Font = New Font("Calibri", 10)
                Case Is < 251
                    .Font = New Font("Calibri", 9)
            End Select
        End With


    End Sub

    Public Sub CentrarObjeto(ByVal controlC As Control, ByVal PanelC As Control)
        With controlC
            .Top = ((PanelC.Height - .Height) / 2)
            .Left = ((PanelC.Width - .Width) / 2)
        End With
    End Sub


    Private Sub TimerCompleto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCompleto.Tick

        lbSegPreg.Text += 1
        lbSegTotal.Text += 1

        Reloj()

        If ExamenActual.Row.Item("ExaTipoExamen") = 1 Then

            If lbSegTotal.Text = TiempoMax Then
                TimerCompleto.Enabled = False
                MsgBox("Se acabó el tiempo.", vbInformation)

IntentoGuardarBlanco:

                If (conn.EjecutarConsulta("INSERT INTO tbDetalleExamen(DetExamen, DetPregunta, DetContestada, DetTiempo) " _
                                          & " VALUES(" & ExamenActual.Id & "," & lbPregId.Text & ",'TimeOver','" & lbSegPreg.Text & "')")) = False Then
                    If (MsgBox("Error de red guardando la respuesta en blanco. ¿Desea volver a intentar?") = vbYes) Then
                        GoTo IntentoGuardarBlanco
                    End If

                End If

                lbMensaje.Visible = True

                salir = True
                Me.VolverAConectando()
                Me.Close()
            End If
        ElseIf ExamenActual.Row.Item("ExaTipoExamen") = 2 Then
            If lbSegPreg.Text = TiempoMax Then

                frmConectando.Cliente.EnviarRespuesta(False, lbSegPreg.Text)

                TimerCompleto.Enabled = False

                Me.lbMensaje.Text = "Se acabó el tiempo. Espera la siguiente."
                lbMensaje.Visible = True

IntentoGuardarNormal:

                If (conn.EjecutarConsulta("INSERT INTO tbDetalleExamen(DetExamen,DetPregunta,DetContestada,DetTiempo) " _
                                          & " VALUES(" & ExamenActual.Id & "," & lbPregId.Text & ",'TimeOver','" & lbSegPreg.Text & "')")) = False Then
                    If (MsgBox("Error guardando la respuesta en blanco. ¿Desea volver a intentar?") = vbYes) Then
                        GoTo IntentoGuardarNormal
                    End If
                End If

                PanelPreg.Visible = False
                PanelRespCorr.Visible = False
                PanelResp2.Visible = False
                PanelResp3.Visible = False
                PanelResp4.Visible = False
            End If
        End If


    End Sub

    Private Sub Reloj()
        If Regresivo = False Then
            lbTiempo.Text = modExamen.FormatTimeToDisplay(lbSegTotal.Text)
        Else
            Dim tiempoRestante As Integer
            If m_Eventos.Row.Item("EvTipoExamen") = 1 Then
                tiempoRestante = TiempoMax - lbSegTotal.Text
            ElseIf m_Eventos.Row.Item("EvTipoExamen") = 2 Then
                tiempoRestante = TiempoMax - lbSegPreg.Text
            End If

            lbTiempo.Text = modExamen.FormatTimeToDisplay(tiempoRestante)
        End If
    End Sub

    Private Sub lbTiempo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbTiempo.Click
        If Regresivo = True Then
            Regresivo = False
            Reloj()
        Else
            Regresivo = True
            Reloj()
        End If

    End Sub


    Private Sub PosicionesRespuestas()
        Select Case lbOrdenResp.Text
            Case 1
                PanelRespCorr.Top = 385
                PanelRespCorr.Left = 105

                PanelResp2.Top = 385
                PanelResp2.Left = 555

                PanelResp3.Top = 495
                PanelResp3.Left = 105

                PanelResp4.Top = 495
                PanelResp4.Left = 555
            Case 2
                PanelResp4.Top = 385
                PanelResp4.Left = 105

                PanelRespCorr.Top = 385
                PanelRespCorr.Left = 555

                PanelResp2.Top = 495
                PanelResp2.Left = 105

                PanelResp3.Top = 495
                PanelResp3.Left = 555
            Case 3
                PanelResp3.Top = 385
                PanelResp3.Left = 105

                PanelResp4.Top = 385
                PanelResp4.Left = 555

                PanelRespCorr.Top = 495
                PanelRespCorr.Left = 105

                PanelResp2.Top = 495
                PanelResp2.Left = 555
            Case 4
                PanelResp2.Top = 385
                PanelResp2.Left = 105

                PanelResp3.Top = 385
                PanelResp3.Left = 555

                PanelResp4.Top = 495
                PanelResp4.Left = 105

                PanelRespCorr.Top = 495
                PanelRespCorr.Left = 555
        End Select


    End Sub


    Private Sub PanelRespCorr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanelRespCorr.Click, LbCorrecta.Click
        PanelResp2.BorderStyle = BorderStyle.None
        PanelResp3.BorderStyle = BorderStyle.None
        PanelResp4.BorderStyle = BorderStyle.None
        PanelRespCorr.BorderStyle = BorderStyle.None

        PanelRespCorr.BorderStyle = BorderStyle.Fixed3D


        Dim msg As New MensajeFull("¿Está seguro?", "Continuar a la siguiente pregunta", Me)

        msg.ShowDialog()

        If msg.resp = 1 Then

            Elegida = "RespCorrec"
            Aceptando()

        End If



        Exit Sub


    End Sub

    Private Sub PanelRespCorr_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanelRespCorr.MouseLeave, LbCorrecta.MouseLeave
        'PanelRespCorr.BorderStyle = BorderStyle.None
        Cursor = Cursors.Default
    End Sub

    Private Sub PanelRespCorr_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelRespCorr.MouseMove, LbCorrecta.MouseMove
        'PanelRespCorr.BorderStyle = BorderStyle.FixedSingle
        Cursor = Cursors.Hand
    End Sub

    Private Sub PanelResp2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanelResp2.Click, LbResp2.Click
        PanelResp2.BorderStyle = BorderStyle.None
        PanelResp3.BorderStyle = BorderStyle.None
        PanelResp4.BorderStyle = BorderStyle.None
        PanelRespCorr.BorderStyle = BorderStyle.None

        PanelResp2.BorderStyle = BorderStyle.Fixed3D



        Dim msg As New MensajeFull("¿Está seguro?", "Continuar a la siguiente pregunta", Me)

        msg.ShowDialog()

        If msg.resp = 1 Then

            Elegida = "Resp2"
            Aceptando()

        End If

    End Sub

    Private Sub PanelResp2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanelResp2.MouseLeave, LbResp2.MouseLeave
        'PanelResp2.BorderStyle = BorderStyle.None
        Cursor = Cursors.Default
    End Sub

    Private Sub PanelResp2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelResp2.MouseMove, LbResp2.MouseMove
        'PanelResp2.BorderStyle = BorderStyle.FixedSingle
        Cursor = Cursors.Hand
    End Sub

    Private Sub PanelResp3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanelResp3.Click, LbResp3.Click
        PanelResp2.BorderStyle = BorderStyle.None
        PanelResp3.BorderStyle = BorderStyle.None
        PanelResp4.BorderStyle = BorderStyle.None
        PanelRespCorr.BorderStyle = BorderStyle.None

        PanelResp3.BorderStyle = BorderStyle.Fixed3D


        Dim msg As New MensajeFull("¿Está seguro?", "Continuar a la siguiente pregunta", Me)

        msg.ShowDialog()

        If msg.resp = 1 Then

            Elegida = "Resp3"
            Aceptando()

        End If

    End Sub

    Private Sub PanelResp3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanelResp3.MouseLeave, LbResp3.MouseLeave
        'PanelResp3.BorderStyle = BorderStyle.None
        Cursor = Cursors.Default
    End Sub

    Private Sub PanelResp3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelResp3.MouseMove, LbResp3.MouseMove
        'PanelResp3.BorderStyle = BorderStyle.FixedSingle
        Cursor = Cursors.Hand
    End Sub

    Private Sub PanelResp4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanelResp4.Click, LbResp4.Click
        PanelResp2.BorderStyle = BorderStyle.None
        PanelResp3.BorderStyle = BorderStyle.None
        PanelResp4.BorderStyle = BorderStyle.None
        PanelRespCorr.BorderStyle = BorderStyle.None

        PanelResp4.BorderStyle = BorderStyle.Fixed3D



        Dim msg As New MensajeFull("¿Está seguro?", "Continuar a la siguiente pregunta", Me)

        msg.ShowDialog()

        If msg.resp = 1 Then

            Elegida = "Resp4"
            Aceptando()

        End If

    End Sub

    Private Sub PanelResp4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanelResp4.MouseLeave, LbResp4.MouseLeave
        'PanelResp4.BorderStyle = BorderStyle.None
        Cursor = Cursors.Default
    End Sub

    Private Sub PanelResp4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelResp4.MouseMove, LbResp4.MouseMove
        'PanelResp4.BorderStyle = BorderStyle.FixedSingle
        Cursor = Cursors.Hand
    End Sub


    Private Sub Aceptando()

        If Elegida = "RespCorrec" Then
            lbCorrectas.Text += 1
        Else
            LbIncorrectas.Text += 1
        End If

GuardandoRespuesta:
        If (conn.EjecutarConsulta("INSERT INTO tbDetalleExamen(DetExamen,DetPregunta,DetContestada,DetTiempo) " _
                    & " VALUES(" & ExamenActual.Id & "," & lbPregId.Text & ",'" & Elegida & "','" & lbSegPreg.Text & "')")) = False Then
            If (MsgBox("Error de red guardando la respuesta. ¿Intente de nuevo?", vbYes, "Intentar")) = MsgBoxResult.Yes Then
                GoTo GuardandoRespuesta
            End If

        End If



        If (mibinding.Position + 1) = mibinding.Count Then
            ExamenTerminado = True
            frmConectando.txtConversa.Text = "Examen terminado." & vbCrLf & frmConectando.txtConversa.Text

            Dim msg As New MensajeFull("Examen terminado", "Ha finalizado la prueba.", Me)

            msg.ShowDialog()

            salir = True
            Me.VolverAConectando()
            Me.Close()
            Exit Sub
        Else
            If ExamenActual.Row.Item("ExaTipoExamen") = 2 Then
                txtConversa.Text = "IG: Espera a la siguiente pregunta" & vbCrLf & vbCrLf & txtConversa.Text
                If Elegida = "RespCorrec" Then
                    frmConectando.Cliente.EnviarRespuesta(True, lbSegPreg.Text)
                    Me.lbMensaje.Text = "Respuesta correcta. Espera la siguiente."
                Else
                    frmConectando.Cliente.EnviarRespuesta(False, lbSegPreg.Text)
                    Me.lbMensaje.Text = "Respuesta Incorrecta. Espera la siguiente."
                End If


                lbMensaje.Visible = True
                TimerCompleto.Enabled = False
                PanelPreg.Visible = False
                PanelRespCorr.Visible = False
                PanelResp2.Visible = False
                PanelResp3.Visible = False
                PanelResp4.Visible = False
            Else
                siguiente_pregunta_basico()

            End If

        End If


        PanelResp2.BorderStyle = BorderStyle.None
        PanelResp3.BorderStyle = BorderStyle.None
        PanelResp4.BorderStyle = BorderStyle.None
        PanelRespCorr.BorderStyle = BorderStyle.None

        ArreglarLabel()
        PosicionesRespuestas()

    End Sub



    Public Function Ir_A_pregunta(Num As Integer) As Boolean

        ResetLabelsPregunta()
        Elegida = "TimeOver"

        Num -= 1

        If Num < mibinding.Count And Num > -1 Then

            mibinding.Position = Num

            If mibinding.Position = (mibinding.Count - 1) Then
                If ultimaPreg = True Then
                    Return False
                Else
                    ultimaPreg = True
                End If
            End If
        End If

        txtConversa.Text = "IG: Trasladado a la pregunta " & mibinding.Position + 1 & " de " & mibinding.Count & vbCrLf & txtConversa.Text

        ArreglarLabel()
        PosicionesRespuestas()

        lbSegTotal.Text = 0
        lbSegPreg.Text = 0
        TimerCompleto.Enabled = True

        Return True

    End Function

    Private Sub ResetLabelsPregunta()

        PanelRespCorr.BorderStyle = BorderStyle.None
        PanelResp2.BorderStyle = BorderStyle.None
        PanelResp3.BorderStyle = BorderStyle.None
        PanelResp4.BorderStyle = BorderStyle.None

        PanelPreg.Visible = True
        PanelRespCorr.Visible = True
        PanelResp2.Visible = True
        PanelResp3.Visible = True
        PanelResp4.Visible = True
        lbMensaje.Visible = False
    End Sub

    Public Sub siguiente_pregunta()

        ResetLabelsPregunta()
        Elegida = "TimeOver"

        mibinding.Position += 1
        If mibinding.Position + 1 = mibinding.Count Then
            If ultimaPreg = True Then
                ExamenTerminado = True
                frmConectando.txtConversa.Text = "Examen terminado." & vbCrLf & frmConectando.txtConversa.Text
                MsgBox("¡Examen completado!", vbInformation, "Listo - IGAD")
                salir = True

                Me.VolverAConectando()
                Me.Close()
                Exit Sub
            Else
                ultimaPreg = True
            End If
        End If
        txtConversa.Text = "IG: Pregunta " & mibinding.Position + 1 & " de " & mibinding.Count & vbCrLf & txtConversa.Text

        ArreglarLabel()
        PosicionesRespuestas()

        lbSegTotal.Text = 0
        lbSegPreg.Text = 0
        TimerCompleto.Enabled = True
    End Sub

    Public Sub siguiente_pregunta_basico()

        lbSegPreg.Text = 0

        PanelRespCorr.BorderStyle = BorderStyle.None
        PanelResp2.BorderStyle = BorderStyle.None
        PanelResp3.BorderStyle = BorderStyle.None
        PanelResp4.BorderStyle = BorderStyle.None

        mibinding.Position += 1
        If mibinding.Position + 1 = mibinding.Count Then
            If ultimaPreg = True Then

                frmConectando.txtConversa.Text = "Examen terminado." & vbCrLf & frmConectando.txtConversa.Text
                MsgBox("¡Examen completado!", vbInformation, "Listo - IGAD")
                salir = True

                Me.VolverAConectando()
                Me.Close()
                Exit Sub
            Else
                ultimaPreg = True
            End If
        End If
        txtConversa.Text = "IG: Pregunta " & mibinding.Position + 1 & " de " & mibinding.Count & vbCrLf & txtConversa.Text

        ArreglarLabel()
        PosicionesRespuestas()


        lbSegPreg.Text = 0

    End Sub



    Private Sub txtConversa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtConversa.KeyDown
        e.Handled = True
    End Sub

    Private Sub PanelRespCorr_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelRespCorr.Paint

    End Sub

    Private Sub PanelResp2_Paint(sender As Object, e As PaintEventArgs) Handles PanelResp2.Paint

    End Sub

    Private Sub VolverAConectando()
        frmConectando.IamInTest = False
        ExamenTerminado = True
        frmConectando.VerificarDatos()
        frmConectando.LtExamenes.SelectedItem = frmConectando.LtExamenes.Items.Count - 1
        frmConectando.Show()
    End Sub

End Class