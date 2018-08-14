Public Class frmAdminEvento

    Public WithEvents AdminClientes As clsServidorSocket


    Dim NombreWav As String

    Dim salir As Boolean = False


#Region "CERRAR Y SONIDO"


    Private Sub frmAdminEvento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If salir = False Then
            Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

            If opc = Windows.Forms.DialogResult.Yes Then
                m_UsuarioAuth.CerrarSesion()
                End
            Else
                e.Cancel = True
            End If
        Else
            'm_UsuarioAuth.CerrarSesion()
        End If
    End Sub


    Public Sub ReproducirSonido(NombreSonido As String)
        Me.NombreWav = NombreSonido
        Try
            Dim thrSound As New Threading.Thread(AddressOf StartThreadReproducirSonido)
            thrSound.Start()
        Catch ex As Exception

        End Try

    End Sub
    Public Sub StartThreadReproducirSonido(NombreSonido As String)
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\sounds\" & NombreWav & ".wav", AudioPlayMode.Background)
    End Sub

#End Region



    Private Sub frmAdminEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llamo el inicializador de las tablas
        If m_UsuarioAuth Is Nothing Then
            InicializarVariables()
            m_UsuarioAuth.Auth("admin", "purito", 2) 'Logueo de prueba como participante
        End If


        m_UsuarioAuth.Equipo.setServer()

        Me.PanelLive.ContextMenuStrip = ContextMenuLive

        ' Agregamos el List al formulario
        Me.GroupClientes.Controls.Add(listViewClientes)
        Dim ancho As Integer = 430
        Me.listViewClientes.ContextMenuStrip = Me.ContextMenuItemView

        ' Inicializo el aministrador de clientes (el servidor)
        AdminClientes = New clsServidorSocket(Me)
        AdminClientes.StartListen()

        ToolStripStatusLabel1.Text = "Servidor iniciado."

        'Descomentar esto !!!
        Me.ReproducirSonido("Sirviendo")

        Me.ckSoloLlenarCatsAct.Checked = True

    End Sub



    Private Sub DatosRecibidos_Event(ByRef sender As clsDatosDeUnCliente, msg As String) Handles AdminClientes.DatosRecibidos
        DelegadoDatosRecibidos(sender, msg)
    End Sub


    Delegate Sub _DelegadoDatosRecibidos(ByRef sender As clsDatosDeUnCliente, msg As String)
    Private Sub DelegadoDatosRecibidos(ByRef sender As clsDatosDeUnCliente, msg As String)
        If InvokeRequired Then
            Me.Invoke(New _DelegadoDatosRecibidos(AddressOf DelegadoDatosRecibidos), sender, msg)
            Exit Sub
        End If

        txtMensajes.Text = sender.Nombre & ":" & msg & vbCrLf & txtMensajes.Text
        ToolStripStatusLabel1.Text = "Mensaje nuevo."
        Me.ReproducirSonido("Pin")
    End Sub



    Private Sub CambiaCategoria_Event(ByRef sender As clsDatosDeUnCliente) Handles AdminClientes.CategoriaCambiada
        DelegadoCategoriaCambiada(sender)
    End Sub

    Delegate Sub _DelegadoCategoriaCambiada(ByRef sender As clsDatosDeUnCliente)
    Private Sub DelegadoCategoriaCambiada(ByRef sender As clsDatosDeUnCliente)
        If InvokeRequired Then
            Me.Invoke(New _DelegadoCategoriaCambiada(AddressOf DelegadoCategoriaCambiada), sender)
            Exit Sub
        End If

        actualizarListCategoria()
        txtMensajes.Text = " - " & sender.Nombre & " cambió a " & sender.Categoria & "." & vbCrLf & txtMensajes.Text


    End Sub




    Private Sub timerStatusStrip_Tick(sender As Object, e As EventArgs) Handles timerStatusStrip.Tick
        ToolStripStatusLabel1.Text = Now.ToLongTimeString
    End Sub

    Private Sub txtMsgToSend_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMsgToSend.KeyDown
        If e.KeyCode = Keys.Enter Then

            ' Primero verifico si ha copiado algo
            If txtMsgToSend.Text = "" Then
                Exit Sub
            End If

            ' Veamos si el mensaje es para todos o solo para los items seleccionados
            If CkParaTodos.Checked = True Then
                If AdminClientes.EnviarMensajeToAll(txtMsgToSend.Text) = False Then
                    ToolStripStatusLabel1.Text = "Error al enviar el mensaje."
                    Return
                End If
            Else

                ' Recorremos los items seleccionados y les enviamos el mensaje
                For Each listVItem As clsItemView In listViewClientes.SelectedItems
                    listVItem.cliente.EnviarDatos(txtMsgToSend.Text)
                Next

            End If

            txtMensajes.Text = "Yo: " & txtMsgToSend.Text & vbCrLf & txtMensajes.Text
            txtMsgToSend.Text = ""
        End If
    End Sub


    Public Sub actualizarListCategoria()

        Dim ArrCategorias As New ArrayList
        Dim cantPregMaximas As Integer = 0

        For Each clientes As clsDatosDeUnCliente In AdminClientes.DatosClientes

            If Not ArrCategorias.Contains(clientes.idCategoria) Then
                ArrCategorias.Add("CatId=" & clientes.idCategoria)
            End If

            If cantPregMaximas < clientes.cantPregsExam Then
                cantPregMaximas = clientes.cantPregsExam
            End If

        Next

        Dim condicionCat As String

        If ArrCategorias.Count > 1 Then
            condicionCat = String.Join(" OR ", ArrCategorias.ToArray)
            condicionCat += " AND CatEvento=" & m_Eventos.Id
        ElseIf ArrCategorias.Count = 1 Then
            condicionCat = ArrCategorias(0)
            condicionCat += " AND CatEvento=" & m_Eventos.Id
        Else
            condicionCat = "CatEvento=" & 0
        End If

        'nuPregunta.Maximum = cantPregMaximas

        Dim CategoriasActuales As New modCategoria
        'CategoriasActuales.getTableRaw(condicionCat)

        CategoriasActuales.mapList(ListCategorias, "CatNombre", "CatId", , condicionCat)

    End Sub

    Public Sub actualizarListCategoriaAll()

        nuPregunta.Maximum = 50

        Dim condicionCat As String = " CatEvento=" & m_Eventos.Id
        Dim CategoriasActuales As New modCategoria

        CategoriasActuales.mapList(ListCategorias, "CatNombre", "CatId", , condicionCat)

    End Sub



    Private Sub MostrarMensajesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarMensajesToolStripMenuItem.Click

        txtMensajes.Text = ""

        For Each listVItem As clsItemView In listViewClientes.SelectedItems
            For Each item As String In listVItem.cliente.MensajesInteractuados
                txtMensajes.Text += item
            Next
        Next

    End Sub

    Private Sub EmpezarExamenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpezarExamenToolStripMenuItem.Click

        For Each listVItem As clsItemView In listViewClientes.SelectedItems
            listVItem.cliente.StartTest()
        Next

    End Sub

    Private Sub txtMensajes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMensajes.KeyPress
        e.Handled = True
        txtMsgToSend.Focus()
    End Sub


    Private Sub CerrarElSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarElSistemaToolStripMenuItem.Click
        For Each listVItem As clsItemView In listViewClientes.SelectedItems
            listVItem.cliente.CerrarPrograma()
        Next
        ReproducirSonido("bye")
    End Sub

    Private Sub CerrarExamenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarExamenToolStripMenuItem.Click
        For Each listVItem As clsItemView In listViewClientes.SelectedItems
            listVItem.cliente.CerrarTest()
        Next
    End Sub

    Private Sub DesconectarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesconectarToolStripMenuItem.Click
        For Each listVItem As clsItemView In listViewClientes.SelectedItems
            listVItem.Remove()
            AdminClientes.DatosClientes.Remove(listVItem.cliente)
            'listVItem.cliente.Socket.Shutdown(Net.Sockets.SocketShutdown.Both)
            'listVItem.cliente.Socket.BeginDisconnect(True, )
            'clienteActual.Socket.Close()
        Next
    End Sub

    Private Sub SiguientePreguntaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiguientePreguntaToolStripMenuItem.Click
        For Each listVItem As clsItemView In listViewClientes.SelectedItems
            listVItem.cliente.NextQuestion()
        Next
    End Sub

    Private Sub IrALaPreguntaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IrALaPreguntaToolStripMenuItem.Click

        Dim Mensaje As String = "¿A qué pregunta desea enviar a los clientes?"
        Dim NumPreg As String = InputBox(Mensaje, "Escriba un número.", 10)

        If String.IsNullOrEmpty(NumPreg) Then
            MessageBox.Show("Se cancelo la operación")
            Return
        End If

        For Each listVItem As clsItemView In listViewClientes.SelectedItems
            listVItem.cliente.GotoQuestion(NumPreg)
        Next

    End Sub

    Private Sub txtMsgToSend_TextChanged(sender As Object, e As EventArgs) Handles txtMsgToSend.TextChanged

    End Sub

    Private Sub MostrarDatosClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarDatosClientesToolStripMenuItem.Click
        frmAdminClientes.Show()
    End Sub

    Private Sub onClickCerrraSistemaContext()
        Throw New NotImplementedException
    End Sub


    Private Sub AtrásToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtrásToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MostrarEventoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarEventoToolStripMenuItem.Click
        frmAdministrador.Show()
    End Sub






#Region "SEGUNDA PANTALLA"


    Private Sub ArreglarPantalla(Optional formulario As Form = Nothing)
        Dim Pantallas() As Screen = Screen.AllScreens

        If formulario Is Nothing Then
            formulario = frmPromt
        End If

        ' Si existen dos pantallas, arreglo el formulario a mostrar en la segunda pantalla.
        If Pantallas.Length = 2 Then
            formulario.StartPosition = FormStartPosition.Manual
            formulario.Location = Pantallas(1).Bounds.Location
        Else
            formulario.StartPosition = FormStartPosition.CenterScreen
        End If

        formulario.Show()
        Me.Activate()
    End Sub



    Private Sub btMostrarParticipantes_Click(sender As Object, e As EventArgs) Handles btMostrarParticipantes.Click

        SHOW_Participantes()

    End Sub



    Private Sub CerrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem1.Click
        frmPromt.Close()
        frmPromt.Show()
        ArreglarPantalla(Me)
        frmPromt.limpiarPromt()
        setPnLiveBlank()
        Me.Activate()
    End Sub

    Private Sub MostrarBlankToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarBlankToolStripMenuItem.Click
        frmPromt.Close()
        frmPromt.Show()
        ArreglarPantalla(Me)
        frmPromt.limpiarPromt()
        setPnLiveBlank()
        Me.Activate()
    End Sub



    Private Sub setPnLiveParticipantes()
        Me.lbActionLive.Text = "Participantes"
        Me.lbCategoriaLive.Text = Me.ListCategorias.Text
        Me.lbPreguntaLive.Text = Me.nuPregunta.Value


        PanelLive.BackColor = _COLOR_PARTCIPANTES
        PanelLive.ForeColor = _COLOR_FONT
        For Each Control As Control In PanelLive.Controls
            Control.ForeColor = _COLOR_FONT
        Next

        Me.centrarControlsPanelLive()
    End Sub

    Private Sub setPnLivePreguntas(numPreg As Integer)
        lbActionLive.Text = "Pregunta Live"
        lbCategoriaLive.Text = ListCategorias.Text
        lbPreguntaLive.Text = numPreg

        PanelLive.BackColor = _COLOR_PREGUNTA
        For Each Control As Control In PanelLive.Controls
            Control.ForeColor = _COLOR_FONT
        Next
        Me.centrarControlsPanelLive()
    End Sub


    Private Sub setPnLiveBlank()
        lbActionLive.Text = "En Blank"
        lbCategoriaLive.Text = ""
        lbPreguntaLive.Text = ""

        PanelLive.BackColor = _COLOR_PARTCIPANTES
        PanelLive.ForeColor = _COLOR_FONT
        For Each Control As Control In PanelLive.Controls
            Control.ForeColor = _COLOR_FONT
        Next
        Me.centrarControlsPanelLive()
    End Sub


    Private Sub centrarControlsPanelLive()
        For Each Control As Control In PanelLive.Controls
            Control.Left = (PanelLive.Width / 2) - (Control.Width / 2)
        Next
    End Sub

#End Region



    Private Sub CerrarTodasLasVentanasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTodasLasVentanasToolStripMenuItem.Click
        frmPromt.Close()
        frmResult2.Close()
        frmExamenes.Close()
        frmUsuario.Close()
        frmAdministrador.Hide()
    End Sub

    Private Sub CuantosHayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuantosHayToolStripMenuItem.Click
        MsgBox(frmPromt.Controls.Count)
    End Sub

    Private Sub BackcolorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackcolorsToolStripMenuItem.Click
        For Each desaparecido As Control In frmPromt.Controls
            desaparecido.BackColor = Color.Gray
            MsgBox(desaparecido.Top & " - Left:" & desaparecido.Left & " - nombre: " & desaparecido.Name & vbCrLf & "text: " & desaparecido.Text & " - " & desaparecido.Width)

            If TypeOf desaparecido Is pnResult Then
                For Each internos As Control In desaparecido.Controls
                    MsgBox("INTERNO: top: " & internos.Top & " - Left: " & internos.Left & " - nombre: " & internos.Name & vbCrLf & "text: " & internos.Text & " - width: " & internos.Width)
                    internos.BackColor = Color.DimGray
                Next
            End If
        Next
    End Sub


    Private Sub SHOW_Participantes()
        'AdminClientes.OrdenarPorExamenes()
        ArreglarPantalla()

        frmPromt.MostrarResultados(AdminClientes.DatosClientes)

        Me.setPnLiveParticipantes()
    End Sub

    Private Sub LinkPregToLive_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkPregToLive.LinkClicked
        SHOW_Preguntas(nuPregunta.Value)
    End Sub

    Private Sub SHOW_Preguntas(Optional numPreg As Integer = 0)
        If numPreg = 0 Then
            numPreg = lbPregActual.Text
        End If

        ArreglarPantalla()

        frmPromt.MostrarPregunta(ListCategorias.SelectedValue, numPreg, ListCategorias.Text)

        Me.setPnLivePreguntas(numPreg)
        Me.centrarControlsPanelLive()
    End Sub

    Private Sub btLiveImagen_Click(sender As Object, e As EventArgs) Handles btLiveImagen.Click

    End Sub


    Private Sub SHOW_Imagen()

        ArreglarPantalla()

        frmPromt.MostrarImagen()

        'Me.setPnLivePreguntas()
        Me.centrarControlsPanelLive()
    End Sub

    ' Solo categorias actuales o todas las categorías del evento
    Private Sub ckSoloLlenarCatsAct_CheckedChanged(sender As Object, e As EventArgs) Handles ckSoloLlenarCatsAct.CheckedChanged
        If ckSoloLlenarCatsAct.Checked = True Then
            actualizarListCategoria()
        Else
            actualizarListCategoriaAll()
        End If
    End Sub

    Private Sub PicturePregunta_MouseEnter(sender As Object, e As EventArgs) Handles PicturePregunta.MouseEnter
        frmMensajeSuperior.Close()
        frmMensajeSuperior.Show()
        frmMensajeSuperior.MostrarPregunta(ListCategorias.SelectedValue, nuPregunta.Value)
        Me.Activate()
    End Sub

    Private Sub PicturePregunta_MouseLeave(sender As Object, e As EventArgs) Handles PicturePregunta.MouseLeave
        frmMensajeSuperior.CerraAnimacion()
        Me.Activate()
    End Sub

    Private Sub btSiguientePreg_Click(sender As Object, e As EventArgs) Handles btSiguientePreg.Click
        Me.lbPregActual.Text += 1
        SHOW_Preguntas()
        ReproducirSonido("Siguiente")
        AdminClientes.SiguientePregToAll()
    End Sub

    Private Sub btSiguientePreg_MouseEnter(sender As Object, e As EventArgs) Handles btSiguientePreg.MouseEnter, btIniciarTest.MouseEnter
        frmMensajeSuperior.Close()
        frmMensajeSuperior.Show()
        frmMensajeSuperior.MostrarPregunta(ListCategorias.SelectedValue, lbPregActual.Text + 1)
        Me.Activate()
    End Sub

    Private Sub btSiguientePreg_MouseLeave(sender As Object, e As EventArgs) Handles btSiguientePreg.MouseLeave, btIniciarTest.MouseLeave
        frmMensajeSuperior.CerraAnimacion()
        Me.Activate()
    End Sub

    Private Sub ControlesEnLaPreguntaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlesEnLaPreguntaToolStripMenuItem.Click
        For Each contr As Control In frmPromt.Controls
            MsgBox(contr.Left & " - " & contr.Top)
            contr.BackColor = Color.Blue
        Next
    End Sub


    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.CERRAR_Promt()

    End Sub

    Private Sub CERRAR_Promt()
        frmPromt.Close()
        lbActionLive.Text = "Cerrado"
        lbCategoriaLive.Text = ""
        lbPreguntaLive.Text = ""

        PanelLive.BackColor = _COLOR_PREGUNTA
        lbActionLive.ForeColor = _COLOR_FONT
    End Sub

    Private Sub CerraPromtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerraPromtToolStripMenuItem.Click
        Me.CERRAR_Promt()
    End Sub

    Private Sub ParticipanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParticipanteToolStripMenuItem.Click
        SHOW_Participantes()
    End Sub

    Private Sub btIniciarTest_Click(sender As Object, e As EventArgs) Handles btIniciarTest.Click
        AdminClientes.StartTestToAll()
        Me.lbPregActual.Text = 1
        SHOW_Preguntas()
    End Sub

    Private Sub BorrarMensajesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarMensajesToolStripMenuItem.Click

    End Sub


    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        ActualizarListViewClientes()
    End Sub

    Private Sub NuevaConexion(ByRef sender As clsDatosDeUnCliente) Handles AdminClientes.NuevaConexion
        DelegadoNuevaConexion(sender)
    End Sub

    Delegate Sub _DelegadoNuevaConexion(ByRef sender As clsDatosDeUnCliente)
    Private Sub DelegadoNuevaConexion(ByRef sender As clsDatosDeUnCliente)
        If InvokeRequired Then
            Me.Invoke(New _DelegadoNuevaConexion(AddressOf DelegadoNuevaConexion), sender)
            Exit Sub
        End If

        ActualizarListViewClientes()

    End Sub

    Private Sub ActualizarListViewClientes()

        listViewClientes.Items.Clear()
        For Each cliente As clsDatosDeUnCliente In Me.AdminClientes.DatosClientes

            Dim itemDeLista As New clsItemView
            itemDeLista.Text = cliente.Nombre & " - " & cliente.AliasEntidad
            itemDeLista.cliente = cliente
            itemDeLista.BackColor = cliente.ColorActual

            Me.listViewClientes.Items.Add(itemDeLista)
        Next
    End Sub



    Private Sub CambiarTiempoMaximoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarTiempoMaximoToolStripMenuItem.Click
        Dim segAnt As Integer = m_Eventos.Row.Item("EvSegundosPregMax")

        Dim valor As String = InputBox("Segundos máximos para cada pregunta: ", "Cambiar tiempo máximo", segAnt)
        Dim segundos As Integer
        If valor <> "" And IsNumeric(valor) Then
            segundos = valor
        Else
            Exit Sub
        End If

        If (segundos > 5) And (segAnt <> segundos) Then
            For Each cliente As clsDatosDeUnCliente In Me.AdminClientes.DatosClientes
                cliente.ChangeTiempoMax(segundos)
            Next

            Dim consulta As String = "UPDATE tbEventos SET EvSegundosPregMax='" & segundos & "' where EvId = " & m_Eventos.Id
            If conn.EjecutarConsulta(consulta) = True Then
                MsgBox("Segundos máximos modificados.", MsgBoxStyle.Information, "IGAD")
                m_Eventos.getActual()
            End If
        Else
            MsgBox("Valor incorrecto. Debe ser un número mayor de 5 y diferente al ya establecido.", MsgBoxStyle.Information, "IGAD")
        End If


    End Sub

    Private Sub btCerrarLive_Click(sender As Object, e As EventArgs) Handles btCerrarLive.Click
        Me.CERRAR_Promt()
    End Sub

    Private Sub btMostrarPuntajes_Click(sender As Object, e As EventArgs) Handles btMostrarPuntajes.Click
        MostrarPuntajes(True)
    End Sub

    Private Sub btOcultarPuntajes_Click(sender As Object, e As EventArgs) Handles btOcultarPuntajes.Click
        MostrarPuntajes(False)
    End Sub

    Private Sub MostrarPuntajes(mostrar As Boolean)
        For Each cliente As clsDatosDeUnCliente In AdminClientes.DatosClientes
            Try
                cliente.MostrarPuntajes(mostrar)
            Catch ex As Exception

            End Try
        Next
    End Sub
End Class