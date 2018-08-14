Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text

Public Class clsClienteSocket


    Dim clientSocket As Socket
    Public ipAddress As IPAddress
    Public sb As New StringBuilder()

    Dim autoEvent As New AutoResetEvent(False)
    Dim timerConectando As System.Threading.Timer
    Dim timerVerificarConexion As System.Threading.Timer
    Dim MensajesInteractuados As New ArrayList


    ' ManualResetEvent instances signal completion.
    Private Shared connectDone As New ManualResetEvent(False)
    Private Shared sendDone As New ManualResetEvent(False)
    Private Shared receiveDone As New ManualResetEvent(False)

    Public idCategTemp As Integer
    Public CategoriaTemp As String


#Region "EVENTOS"
    Public Event ConectadoAlServidor()
    Public Event FallaDeConexion(Mensage As String, statusLabel As String)
    Public Event FallaAlRecibirDatos(Mensage As String, statusLabel As String)
    Public Event FallaAlEnviarDatos(Mensage As String, statusLabel As String)
    Public Event MensajeRecibido(Mensage As String, statusLabel As String)
    Public Event ComandoVacio(Mensage As String, statusLabel As String)
    Public Event IniciarExamen()
    Public Event SiguientePregunta()
    Public Event IrAPregunta(num As Integer)
    Public Event ObligarCierreDeExamen()
    Public Event ObligarCierreDelPrograma()
    Public Event allDone()
    Public Event CambiaSegundosMax(segundos As Integer)
#End Region


    Public Sub Conectar()

        clientSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        
        Dim ipEndPoint As IPEndPoint = New IPEndPoint(Me.ipAddress, VariablesGlobales.Puerto)
        clientSocket.BeginConnect(ipEndPoint, New AsyncCallback(AddressOf OnConnect), clientSocket)

        ' Wait for connect.
        connectDone.WaitOne()

        EnviarDatosPersonales()

        ' Wait for send datas.
        sendDone.WaitOne()

        ActivarEscuchador()
        'receiveDone.WaitOne()

        'DescifrarMsg(VariablesGlobales.response)

    End Sub


#Region "INTENTOS DE CONEXIÓN"

    Private Sub OnConnect(ByVal ar As IAsyncResult)

        Dim s As Socket = CType(ar.AsyncState, Socket)
        Try
            s.EndConnect(ar)
        Catch ex As Exception
            RaiseEvent FallaDeConexion("No se pudo conectar con el servidor.", "Intento de conexión fallido.")
            's.Close()
            CrearTimerConectar()
            Exit Sub
        End Try

        connectDone.Set()

    End Sub

    Private Sub EnviarDatosPersonales()

        Dim mEntidad As New modEntidades
        mEntidad.findRaw(m_UsuarioAuth.Row.Item("UsuEntidad"))

        Dim Mensaje As String
        Mensaje = VariablesGlobales.MyKeyWord & "CONECTED" & VariablesGlobales.Delimitador & m_UsuarioAuth.Row.Item("UsuNombre") _
                            & VariablesGlobales.Delimitador & mEntidad.Row.Item("EntNombre") _
                            & VariablesGlobales.Delimitador & mEntidad.Row.Item("EntNombreCorto") _
                            & VariablesGlobales.Delimitador & m_UsuarioAuth.Equipo.Row.Item("EquiNombre") & "\0"

        ' Enviamos los datos personales al servidor
        Dim sendBytes As Byte() = UTF8Encoding.UTF8.GetBytes(Mensaje & VariablesGlobales.Delimitador)


        Try
            Me.clientSocket.BeginSend(sendBytes, 0, sendBytes.Length, SocketFlags.None, AddressOf DatosConectadoEnviado, Me.clientSocket)
        Catch ex As SocketException
            If ex.ErrorCode = 10057 Or ex.ErrorCode = 10054 Then
                RaiseEvent FallaDeConexion("El Servidor rompió la conexión actual.", "Servidor desconectado")
            Else
                RaiseEvent FallaAlRecibirDatos("Error al escuchar al servidor, lo sentimos.", "Error escuchando socket.")
            End If
        End Try

        sendDone.Set()

    End Sub


    Private Sub DatosConectadoEnviado(ByVal ar As IAsyncResult)

        Try
            ' Retrieve the socket from the state object.
            Dim client As Socket = CType(ar.AsyncState, Socket)

            ' Complete sending the data to the remote device.
            'Dim bytesSent As Integer = client.EndSend(ar)
            Me.CambiarCategoria(idCategTemp, CategoriaTemp)
            RaiseEvent ConectadoAlServidor()

        Catch ex As Exception
            RaiseEvent FallaDeConexion("No se pudo enviar los datos personales al servidor.", "Falla al enviar datos personales.")
        End Try

        CrearTimerVerificadorDeConexion()
    End Sub

#End Region

#Region "RECIBIENDO DATOS"

    Private Sub ActivarEscuchador()

        ' Borramos los datos de respuesta anterior
        VariablesGlobales.response = ""

        ' Activamos el escuchador
        Try
            ' Create the state object.
            Dim state As New StateObject()
            state.workSocket = Me.clientSocket

            ' Begin receiving the data from the remote device.
            Me.clientSocket.BeginReceive(state.buffer, 0, state.BufferSize, 0, AddressOf OnRecieve, state)
        Catch e As Exception
            RaiseEvent FallaAlRecibirDatos("No se pudo activar el escuchador.", "Falla al intentar escuchar.")
        End Try

    End Sub

    Private Sub OnRecieve(ByVal ar As IAsyncResult)
        Try
            Dim state As StateObject = CType(ar.AsyncState, StateObject)
            Dim client As Socket = state.workSocket

            ' Read data from the remote device.
            Dim bytesRead As Integer = client.EndReceive(ar)

            If bytesRead > 0 Then
                ' There might be more data, so store the data received so far.
                state.sb.Append(Encoding.UTF8.GetString(state.buffer, 0, bytesRead))

                'receiveDone.Set()

                If state.sb.ToString.Contains("\0") Then

                    Dim textoMsg As String = state.sb.ToString

                    textoMsg = textoMsg.Substring(0, textoMsg.LastIndexOf("\0"))
                    DescifrarMsg(textoMsg)
                    Return
                End If

                '  Se supone que vuelve por los datos que faltan, pero no lo haré
                client.BeginReceive(state.buffer, 0, state.BufferSize, 0, AddressOf OnRecieve, state)



            Else
                ' All the data has arrived; put it in response.
                If state.sb.Length > 1 Then
                    VariablesGlobales.response = state.sb.ToString()
                End If
                ' Signal that all bytes have been received.
                receiveDone.Set()
            End If


        Catch ex As SocketException
            If ex.ErrorCode = 10054 Or ex.ErrorCode = 10057 Then
                RaiseEvent FallaDeConexion("Servidor desconectado, intentaremos reconectar.", "Servidor no conectado")
            Else
                RaiseEvent FallaAlRecibirDatos(ex.ErrorCode & " - " & ex.Message, "Falla en endReceive.")
            End If

        End Try

    End Sub


    Public Sub DescifrarMsg(msg As String)

        ' Verifico si el mensaje entrante tiene la palabra clave, si la tiene, es un comando.
        If msg.StartsWith(VariablesGlobales.MyKeyWord) Then
            ' Averiguo entonces que comando es.
            DescifrarComando(msg.Substring(VariablesGlobales.MyKeyWord.Length))
        Else

            ' Si no es un comando, es un mensaje. Guardo el mensaje
            ' Desencadeno el evento que indica que ha llegado un mensaje.
            If Not msg = "" Then
                RaiseEvent MensajeRecibido(msg, "Mensaje recibido.")
            End If

        End If

        ActivarEscuchador()

    End Sub



    Private Sub DescifrarComando(Comando As String)

        Dim Arguments As String() = Comando.Split(New Char() {VariablesGlobales.Delimitador}, StringSplitOptions.RemoveEmptyEntries)

        Select Case Arguments(0)
            Case ""
                RaiseEvent ComandoVacio("Se recibió un Comando Vacio.", "Comando vacío recibido.")

            Case "START_TEST"
                RaiseEvent IniciarExamen()

            Case "NEXT_QUESTION"
                RaiseEvent SiguientePregunta()

            Case "GOTO_QUESTION"
                RaiseEvent IrAPregunta(Arguments(1))

            Case "CLOSE_TEST"
                RaiseEvent ObligarCierreDeExamen()
                
            Case "CLOSE_SYSTEM"
                RaiseEvent ObligarCierreDelPrograma()

            Case "CHANGE_TIME"
                RaiseEvent CambiaSegundosMax(Arguments(1))

            Case Else
                RaiseEvent ComandoVacio(Comando, "Comando vacio")

        End Select
    End Sub



#End Region


#Region "ENVIANDO DATOS"


    Public Sub EnviarTestIniciado(idExamen As Integer, idCategoria As Integer, Categoria As String, CantPreg As Integer)

        Dim comando As String = "TEST_STARTED"

        comando += VariablesGlobales.Delimitador & idExamen & VariablesGlobales.Delimitador & idCategoria _
                    & VariablesGlobales.Delimitador & Categoria & VariablesGlobales.Delimitador & CantPreg

        Me.EnviarXComando(comando)

    End Sub

    Public Sub EnviarRespuesta(Resp As Boolean, tiempoEnResponder As Integer)
        If Resp = True Then
            Me.EnviarXComando("GOOD_ANSWER" & VariablesGlobales.Delimitador & tiempoEnResponder)
        Else
            Me.EnviarXComando("BAD_ANSWER" & VariablesGlobales.Delimitador & tiempoEnResponder)
        End If

    End Sub

    Public Sub EnviarXComando(Comando As String)
        ' Decodificamos el mensaje
        Dim byteData As Byte() = UTF8Encoding.UTF8.GetBytes(VariablesGlobales.MyKeyWord & Comando & VariablesGlobales.Delimitador & "\0")

        Me.clientSocket.BeginSend(byteData, 0, byteData.Length, SocketFlags.None, New AsyncCallback(AddressOf onDatosSent), Me.clientSocket)
    End Sub

    Public Sub EnviarDatos(msg As String)
        ' Decodificamos el mensaje
        Dim byteData As Byte() = UTF8Encoding.UTF8.GetBytes(msg & "\0")

        Me.clientSocket.BeginSend(byteData, 0, byteData.Length, SocketFlags.None, AddressOf onDatosSent, Me.clientSocket)
        SyncLock Me
            MensajesInteractuados.Add("Yo: " & msg & vbCrLf & vbCrLf)
        End SyncLock
    End Sub


    Public Sub CambiarCategoria(idCat As Integer, Categoria As String)
        ' Enviamos el código de la categoría en que participará
        Me.EnviarXComando("CATEG_CHANGED" & VariablesGlobales.Delimitador & idCat & VariablesGlobales.Delimitador & Categoria)
        SyncLock Me
            MensajesInteractuados.Add(" - Categoría cambiada." & vbCrLf & vbCrLf)
        End SyncLock
    End Sub

    Private Sub onDatosSent(ByVal ar As IAsyncResult)
        Try
            Dim client As Socket = ar.AsyncState
            client.EndSend(ar)
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

#End Region



#Region "VERIFICAR SI SIGUE CONECTADO AL SERVIDOR"

    Public Sub CrearTimerConectar()
        timerConectando = New System.Threading.Timer(AddressOf TimerConectar_Tick, autoEvent, 1000, 1000)
    End Sub


    Private Sub TimerConectar_Tick(ByVal state As System.Object) 'Handles TimerConectar.Tick
        'MsgBox("Tick :)")

        Dim autoEvent As AutoResetEvent = DirectCast(state, AutoResetEvent)
        autoEvent.Set()

        Dim modEquipoManager As New modEquipos
        modEquipoManager.getTable(, "EquiConection='Servidor'")

        If modEquipoManager.dt.Rows.Count > 0 Then
            modEquipoManager.Row = modEquipoManager.getTable(, "EquiConection='Servidor'").Rows(0)
            timerConectando.Change(Timeout.Infinite, Timeout.Infinite)
            Me.ipAddress = ipAddress.Parse(modEquipoManager.Row.Item("EquiIP"))
            Me.Conectar()
        End If
    End Sub


    Public Sub CrearTimerVerificadorDeConexion()
        'MsgBox("ACTIVADO EL TIMER")

        timerVerificarConexion = New System.Threading.Timer(AddressOf timerVerificarConexion_Tick, autoEvent, 1000, 1000)

    End Sub


    Private Sub timerVerificarConexion_Tick(ByVal state As System.Object)
        'MsgBox("Tick :)")

        Dim autoEvent As AutoResetEvent = DirectCast(state, AutoResetEvent)
        autoEvent.Set()

        If Connected() = False Then
            Try
                Me.clientSocket.Close()
            Catch ex As Exception

            End Try

            CrearTimerConectar()

            timerVerificarConexion.Change(Timeout.Infinite, Timeout.Infinite)

        End If


    End Sub

    Function Connected() As Boolean

        Dim blockingState As Boolean = clientSocket.Blocking
        Connected = False
        Try
            Dim tmp(0) As Byte
            clientSocket.Blocking = False
            clientSocket.Send(tmp, 0, 0)
            Return True
        Catch e As SocketException
            If e.NativeErrorCode.Equals(10035) Then
                Return True
            Else : Return False
            End If
        Finally
            clientSocket.Blocking = blockingState
        End Try

        ' Using Poll
        'Connected = False
        'If (clientSocket.Connected) Then
        '    If ((clientSocket.Poll(0, SelectMode.SelectWrite)) AndAlso (Not clientSocket.Poll(0, SelectMode.SelectError))) Then
        '        Dim b As Byte() = New Byte(1) {}
        '        If clientSocket.Receive(b, SocketFlags.Peek) = 0 Then
        '            Return False
        '        Else : Return True
        '        End If
        '    Else
        '        Return False
        '    End If
        'Else
        '    Return False

        'End If
    End Function

#End Region



End Class
