
Imports System.Data
Imports System.Text
Imports System.Data.SqlClient

Imports System.Net
Imports System.Threading

Public Class frmConectando

    Public WithEvents Cliente As New clsClienteSocket
    Dim salir As Boolean = False
    Dim dtConfig As New DataTable
    Dim EquiServidor As modEquipos
    Dim modEquipoManager As New modEquipos
    Public IamInTest As Boolean = False


#Region "ORGANIZANDO LOS DATOS DE INICIO"


    Private Sub btReiciarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReiciarSesion.Click
        If m_Eventos.Row.Item("EvTipoExamen") = 2 Then
            End
        End If

        salir = True
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub frmConectando_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ActualizarPuntajesDisplay()
    End Sub

    Private Sub frmConectando_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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


    Private Sub frmConectando_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Para permitir que los hilos usen los controles visuales, los cuales se encuentran en el subhilo principal
        CheckForIllegalCrossThreadCalls = False

        If m_UsuarioAuth Is Nothing Then
            InicializarVariables()
            m_UsuarioAuth.Auth("pru", "pru", 4) 'Logueo de prueba como participante
        End If

        EquiServidor = New modEquipos

        DatosConfig()
        VerificarDatos()

        Me.Width = 750
        Me.Height = 585

        CrearTimerConectar()
    End Sub


    Function DatosConfig()

        Me.Text = "Inicio del examen."

        lbBienvenido.Text = "Bienvenido " & m_UsuarioAuth.Row.Item("UsuNombre")

        Me.Text = "Evento: " & m_Eventos.Row.Item("EvNombre")
        lbTipoExamen.Text = m_TipoExamen.Row.Item("TeTipo")
        'lbTipoExamen

        modEquipoManager.getTable(, "EquiConection='Servidor'")

        If modEquipoManager.dt.Rows.Count > 0 Then
            modEquipoManager.Row = modEquipoManager.dt.Rows(0)
            Return True
        Else
            Return False
        End If
    End Function


    Public Sub VerificarDatos()

        Select Case m_Eventos.Row.Item("EvTipoExamen")
            Case 1
                Label2.Text = "Ya puede iniciar sus examenenes"
            Case 2
                Label2.Text = "Espere que el Manager inicie el Test"
        End Select



        Dim dtInscrip As New DataTable

        conn.TraerTabla(dtInscrip, "select * from tbInscripciones, tbCategorias where InsUsuario=" & m_UsuarioAuth.Id & " and InsActivo=1 " _
                        & " and CatId=InsCategoria and CatEvento=" & m_Eventos.Id)

        lbOportunidades.DataBindings.Clear()
        lbCatIns.DataBindings.Clear()

        lbOportunidades.DataBindings.Add("Text", dtInscrip, "InsOportunidades")
        lbCatIns.DataBindings.Add("Text", dtInscrip, "InsCategoria")


        If dtInscrip.Rows.Count > 0 Then

            LtCategEmp.DataSource = dtInscrip
            LtCategEmp.DisplayMember = "CatNombre"
            LtCategEmp.ValueMember = "InsId"

            Dim dtExa As New DataTable

            For Each Ins In dtInscrip.Rows

                Dim idT As Integer = Ins("InsId")

                conn.TraerTabla(dtExa, "Select e.ExaId, e.ExaFecha, (CAST(i.InsId AS varchar(50)) +' - ' + c.CatNombre) as Examen, i.InsOportunidades " _
                                & " from tbExamenes e, tbInscripciones i, tbCategorias c " _
                                & " where e.ExaInscripcion=i.InsId and i.InsCategoria=c.CatId and " _
                                & " i.InsId=" & idT)

            Next

            If dtExa.Rows.Count > 0 Then

                LtExamenes.DataSource = dtExa
                LtExamenes.DisplayMember = "Examen"
                LtExamenes.ValueMember = "ExaId"

                LtExamenes.SelectedIndex = 0

            Else
                'LtExamenes.Items.Add("No ha realizado ningún examen")
                'LtExamenes.SelectedIndex = 0
            End If

        Else

            lbtituloCatIns.Text = "No está inscrito a ninguna categoría"
            LtCategEmp.Visible = False

        End If

    End Sub


#End Region



    Private Sub Conectar()

        EquiServidor.getTableRaw("EquiConection='Servidor'")

        If EquiServidor.dt.Rows.Count > 0 Then
            EquiServidor.Row = EquiServidor.dt.Rows(0)
        End If
        
    End Sub






#Region "INTERFACE PARA CONTROLES SIMPLES"


    Private Sub btIniciar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btIniciar.Click

        If m_Eventos.Row.Item("EvTipoExamen") = 2 Then
            MsgBox("El manager iniciará el exámen automáticamente.", vbInformation, "Espera por favor.")
            Exit Sub
        End If

        Dim dtHechos As New DataTable

        conn.TraerTabla(dtHechos, "select count(ExaId) as Cont from tbExamenes where ExaInscripcion=" & LtCategEmp.SelectedValue)

        If dtHechos.Rows(0).Item("Cont") >= lbOportunidades.Text Then
            MsgBox("Usted no puede hacer mas exámenes de esta categoría.", vbInformation, "Comuníquese con el manager.")
        Else

            Dim msg As New MensajeFull("Empezar examen", "Va a realizar una prueba de " & LtCategEmp.Text & ". ¿Desea continuar?", Me)

            msg.ShowDialog()

            If msg.resp = 1 Then

                m_UsuarioAuth.IdInsActual = LtCategEmp.SelectedValue
                m_UsuarioAuth.IdCatInsActual = lbCatIns.Text

                frmExamen.Show()
                Me.Hide()
            End If


        End If

    End Sub


    Private Sub cbCategEmp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            m_UsuarioAuth.IdInsActual = LtCategEmp.SelectedValue
            m_UsuarioAuth.IdCatInsActual = lbCatIns.Text
        Catch ex As Exception

        End Try

    End Sub

    Private Sub lbOportunidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbOportunidades.Click
        frmValidando.Operacion = "Oportunidades"
        frmValidando.ShowDialog()
    End Sub

    Private Sub lbOportunidades_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbOportunidades.MouseLeave
        lbOportunidades.BackColor = Color.Transparent
    End Sub

    Private Sub lbOportunidades_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbOportunidades.MouseMove
        lbOportunidades.BackColor = Color.Coral
    End Sub

    Private Sub LtCategEmp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LtCategEmp.SelectedIndexChanged
        Try
            Dim idCat As Integer = m_Inscripciones.getCampoRaw(LtCategEmp.SelectedValue, "InsCategoria")
            Cliente.CambiarCategoria(idCat, LtCategEmp.Text)

            m_UsuarioAuth.IdInsActual = LtCategEmp.SelectedValue
            m_UsuarioAuth.IdCatInsActual = lbCatIns.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lkbElimTest_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkbElimTest.LinkClicked
        frmValidando.Operacion = "EliminarExamen"
        frmValidando.ShowDialog()
    End Sub


    '**********************************************************************
    '************** FUNCIONAMIENTO PARA MOSTRAR LOS RESULTADOS ************
    '**********************************************************************
    Private Sub lbTipoExamen_MouseLeave(sender As Object, e As EventArgs) Handles lbTipoExamen.MouseLeave
        Me.Text = "Inicio del examen."
    End Sub

    Private Sub lbTipoExamen_MouseMove(sender As Object, e As MouseEventArgs) Handles lbTipoExamen.MouseMove
        Me.Text = m_TipoExamen.Row.Item("TeDescrip")
    End Sub

    Private Sub LtExamenes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LtExamenes.SelectedIndexChanged
        ActualizarPuntajesDisplay()
    End Sub

    Private Sub ActualizarPuntajesDisplay()
        Try
            If Not IsNothing(LtExamenes.SelectedValue) Then
                Dim examenTemp As New modExamen(LtExamenes.SelectedValue)
                examenTemp.CalcularExamen()
                examenTemp.MapControles(lbTotalPreg, lbContestadas, lbRespCorrectas, lbRespInorrectas, lbTiempo, lbPuntaje)
                examenTemp.FillMappedControls()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btResultados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResultados.Click
        VerificarDatos()

        m_Examenes.Id = LtExamenes.SelectedValue
        m_Examenes.CalcularExamen()

    End Sub



    '**********************************************************************
    '**************** BOTONES DE MENSAJERÍA *******************************
    '**********************************************************************
    Private Sub txtMensaje_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMensaje.KeyDown
        If e.KeyCode = Keys.Enter Then
            btEnviar.PerformClick()

        End If
    End Sub

    Private Sub txtConversa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConversa.KeyPress
        e.Handled = True
        txtMensaje.Focus()
    End Sub

    Private Sub btEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnviar.Click

        Cliente.EnviarDatos(txtMensaje.Text)

        If txtMensaje.Text <> "" Then
            txtConversa.Text = "Yo: " & txtMensaje.Text & vbCrLf & txtConversa.Text
            txtMensaje.Text = ""
            txtMensaje.Focus()
        Else
            MsgBox("Debe escribir algo.")
        End If
    End Sub



#End Region


#Region "TRABAJO DE HILOS CON TIMERS"


    Dim autoEvent As New AutoResetEvent(False)
    Dim timerConectando As System.Threading.Timer
    Public Sub CrearTimerConectar()
        'MsgBox("ACTIVADO EL TIMER")

        timerConectando = New System.Threading.Timer(AddressOf TimerConectar_Tick, autoEvent, 1000, 1000)

    End Sub


    Private Sub TimerConectar_Tick(ByVal state As System.Object) 'Handles TimerConectar.Tick

        Dim autoEvent As AutoResetEvent = DirectCast(state, AutoResetEvent)
        autoEvent.Set()

        modEquipoManager.getTable(, "EquiConection='Servidor'")

        If modEquipoManager.dt.Rows.Count > 0 Then
            modEquipoManager.Row = modEquipoManager.getTable(, "EquiConection='Servidor'").Rows(0)
            timerConectando.Change(Timeout.Infinite, Timeout.Infinite)
            Cliente.ipAddress = IPAddress.Parse(modEquipoManager.Row.Item("EquiIP"))
            Dim idCat As Integer = m_Inscripciones.getCampoRaw(LtCategEmp.SelectedValue, "InsCategoria")
            Cliente.idCategTemp = idCat
            Cliente.CategoriaTemp = LtCategEmp.Text

            Cliente.Conectar()
            
        End If


    End Sub

    Private Sub timerStatusStrip_Tick(sender As Object, e As EventArgs) Handles timerStatusStrip.Tick
        ToolStripStatusLabel1.Text = Now.ToLongTimeString
    End Sub

    Private Sub IntentoDeConexionFallida_Event(mensaje As String, statusLabel As String) Handles Cliente.FallaDeConexion
        DelegadoStatusMessage(mensaje, statusLabel)
    End Sub


    Private Sub ConetadoAlServidor_Event() Handles Cliente.ConectadoAlServidor
        DelegadoConetadoAlServidor("Servidor respondió correctamente.", "Conexión exitosa.")
    End Sub


    Delegate Sub _DelegadoConetadoAlServidor(msg As String, statusLabel As String)
    Private Sub DelegadoConetadoAlServidor(msg As String, statusLabel As String)
        If InvokeRequired Then
            Me.Invoke(New _DelegadoConetadoAlServidor(AddressOf DelegadoConetadoAlServidor), msg, statusLabel)
            Exit Sub
        End If

        If IamInTest = True Then
            frmExamen.txtConversa.Text = "IG: " & msg & vbCrLf & vbCrLf & frmExamen.txtConversa.Text
        End If

        DelegadoStatusMessage(msg, statusLabel)
    End Sub


#End Region


    Private Sub ObligarCierreDeExamen_Event() Handles Cliente.ObligarCierreDeExamen
        DelegadoObligarCierreDeExamen()
    End Sub

    Delegate Sub _DelegadoObligarCierreDeExamen()
    Private Sub DelegadoObligarCierreDeExamen()
        If InvokeRequired Then
            Me.Invoke(New _DelegadoObligarCierreDeExamen(AddressOf DelegadoObligarCierreDeExamen))
            Exit Sub
        End If

        If IamInTest = False Then
            Exit Sub
        End If

        frmExamen.salir = True
        frmExamen.Close()
        Me.Show()
        IamInTest = False

    End Sub


    Private Sub IrAPregunta_Event(num As Integer) Handles Cliente.IrAPregunta
        DelegadoIrAPreguntan(num)
    End Sub

    Delegate Sub _DelegadoIrAPreguntan(num As Integer)
    Private Sub DelegadoIrAPreguntan(num As Integer)
        If InvokeRequired Then
            Me.Invoke(New _DelegadoIrAPreguntan(AddressOf DelegadoIrAPreguntan), num)
            Exit Sub
        End If

        If IamInTest = True Then
            frmExamen.Ir_A_pregunta(num)
        End If

    End Sub


    Private Sub SiguientePregunta_Event() Handles Cliente.SiguientePregunta
        DelegadoSiguienteAPreguntan()
    End Sub

    Delegate Sub _DelegadoSiguienteAPreguntan()
    Private Sub DelegadoSiguienteAPreguntan()
        If InvokeRequired Then
            Me.Invoke(New _DelegadoSiguienteAPreguntan(AddressOf DelegadoSiguienteAPreguntan))
            Exit Sub
        End If

        If IamInTest = True Then
            frmExamen.siguiente_pregunta()
        End If

    End Sub


    Private Sub ObligarCierreDelPrograma_Event() Handles Cliente.ObligarCierreDelPrograma
        DelegadoObligarCierreDelPrograma()
    End Sub

    Delegate Sub _DelegadoObligarCierreDelPrograma()
    Private Sub DelegadoObligarCierreDelPrograma()
        If InvokeRequired Then
            Me.Invoke(New _DelegadoObligarCierreDelPrograma(AddressOf DelegadoObligarCierreDelPrograma))
            Exit Sub
        End If

        If IamInTest = True Then
            ' Por ahora voy a cerrar el programa sin importar que esté en examen.
            'Exit Sub
        End If

        m_UsuarioAuth.CerrarSesion()
        MsgBox("El manager ha cerrado el programa.")
        End

    End Sub

    Private Sub IniciarExamen_Event() Handles Cliente.IniciarExamen
        DelegadoInicarTest()
    End Sub


    Delegate Sub _DelegadoInicarTest()
    Private Sub DelegadoInicarTest()
        If InvokeRequired Then
            Me.Invoke(New _DelegadoInicarTest(AddressOf DelegadoInicarTest))
            Exit Sub
        End If

        If IamInTest = True Then
            Exit Sub
        End If

        txtConversa.Text = Now.ToShortTimeString & " IGAD: " & "Examen iniciado." & vbCrLf & vbCrLf & txtConversa.Text
        ToolStripStatusLabel1.Text = "Iniciar examen!"

        m_UsuarioAuth.IdInsActual = LtCategEmp.SelectedValue
        m_UsuarioAuth.IdCatInsActual = lbCatIns.Text

        frmExamen.Show()
        Me.Hide()
        IamInTest = True

    End Sub



    Private Sub CambiaSegundosMax_Event(segundos As Integer) Handles Cliente.CambiaSegundosMax
        DelegadoCambiaSegundosMax(segundos)
    End Sub


    Delegate Sub _DelegadoCambiaSegundosMax(msg As Integer)
    Private Sub DelegadoCambiaSegundosMax(segundos As Integer)
        If InvokeRequired Then
            Me.Invoke(New _DelegadoCambiaSegundosMax(AddressOf DelegadoCambiaSegundosMax), segundos)
            Exit Sub
        End If

        If IamInTest = True Then
            frmExamen.txtConversa.Text = "IG: Tiempo máximo cambiado a " & segundos & "seg" & vbCrLf & vbCrLf & frmExamen.txtConversa.Text
            frmExamen.TiempoMax = segundos
        End If

        DelegadoStatusMessage(segundos, "Tiempo máximo cambiado a " & segundos & "seg")
    End Sub




    Private Sub MensajeRecibido_Event(Mensage As String, statusLabel As String) Handles Cliente.MensajeRecibido
        DelegadoMensajeRecibido(Mensage, statusLabel)
    End Sub


    Delegate Sub _DelegadoMensajeRecibido(Mensage As String, statusLabel As String)
    Private Sub DelegadoMensajeRecibido(Mensage As String, statusLabel As String)
        If InvokeRequired Then
            Me.Invoke(New _DelegadoMensajeRecibido(AddressOf DelegadoMensajeRecibido), Mensage, statusLabel)
            Exit Sub
        End If

        If IamInTest = True Then
            frmExamen.txtConversa.Text = "IGAD: " & Mensage & vbCrLf & vbCrLf & txtConversa.Text
        End If

        txtConversa.Text = "IGAD: " & Mensage & vbCrLf & vbCrLf & txtConversa.Text
        ToolStripStatusLabel1.Text = statusLabel

    End Sub

    Private Sub FallaDeConexion_Event(Mensage As String, statusLabel As String) Handles Cliente.FallaDeConexion
        DelegadoFallaDeConexion(Mensage, statusLabel)
    End Sub


    Delegate Sub _DelegadoFallaDeConexion(Mensage As String, statusLabel As String)
    Private Sub DelegadoFallaDeConexion(Mensage As String, statusLabel As String)
        If InvokeRequired Then
            Me.Invoke(New _DelegadoFallaDeConexion(AddressOf DelegadoFallaDeConexion), Mensage, statusLabel)
            Exit Sub
        End If

        If IamInTest = True Then
            frmExamen.txtConversa.Text = "IGAD: " & Mensage & " . Espere instrucciones." & vbCrLf & vbCrLf & txtConversa.Text
        End If

        txtConversa.Text = "IGAD: " & Mensage & " . Espere instrucciones." & vbCrLf & vbCrLf & txtConversa.Text
        ToolStripStatusLabel1.Text = statusLabel

        timerConectando.Dispose()

    End Sub



    Delegate Sub _DelegadoStatusMessage(ByVal Mensaje As String, statusLabel As String)
    Private Sub DelegadoStatusMessage(ByVal Mensaje As String, statusLabel As String) 'Handles Cliente.DatosRecibidos
        If InvokeRequired Then
            Me.Invoke(New _DelegadoStatusMessage(AddressOf DelegadoStatusMessage), Mensaje, statusLabel)
            Exit Sub
        End If
        txtConversa.Text = Now.ToLongTimeString & ": " & Mensaje & vbCrLf & vbCrLf & txtConversa.Text
        ToolStripStatusLabel1.Text = statusLabel
    End Sub


    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub txtMensaje_TextChanged(sender As Object, e As EventArgs) Handles txtMensaje.TextChanged

    End Sub
End Class