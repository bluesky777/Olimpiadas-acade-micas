Imports System.Net.Sockets
Imports System.Net
Imports System.Text

Public Class clsDatosDeUnCliente : Implements IEquatable(Of clsDatosDeUnCliente), IDisposable

    'Public Shared ipToFind As String = "" ' Creo que no será necesario

    Public idExamen As Integer = 0
    Public Socket As Socket
    Public Nombre As String
    Public Entidad As String
    Public AliasEntidad As String
    Public idCategoria As Integer = 0
    Public Categoria As String
    Public AliasCategoria As String
    Public cantPregsExam As Integer
    Public TiempoExam As Integer = 0
    Public IPString As String
    Public NombreEquipo As String
    Public MensajesInteractuados As New ArrayList
    Public PregCorrectas As Integer = 0
    Public PregIncorrectas As Integer = 0
    Public ColorActual As Color

    'Dim byteData(2048) As Byte
    Public sb As New StringBuilder()

    'Para mantener el seguimiento de si se ha desechado el objeto:
    Protected disposed As Boolean = False


    Dim NombreWav As String


#Region "EVENTOS"
    Public Event Conected(ByRef sender As clsDatosDeUnCliente)
    Public Event EmpiezaElExamen(ByRef sender As clsDatosDeUnCliente)
    Public Event CategoriaCambiada(ByRef sender As clsDatosDeUnCliente)
    Public Event PreguntaContestadaCorrectamente(ByRef sender As clsDatosDeUnCliente)
    Public Event PreguntaContestadaIncorrectamente(ByRef sender As clsDatosDeUnCliente)
    Public Event EmpiezaSiguientePreg(ByRef sender As clsDatosDeUnCliente)
    Public Event NuevoMensaje(ByRef sender As clsDatosDeUnCliente, msg As String)
    Public Event DatosEnviados(bytesSent As Integer)
    Public Event ComandoVacio(ByRef sender As clsDatosDeUnCliente)
    Public Event Desconectado(ByRef sender As clsDatosDeUnCliente)
    Public Event FallaAlRecibirDatos(msg As String, statusLabel As String)
    Public Event MostrarPuntaje(mostrar As Boolean)
#End Region


    Sub New(ByRef TheSocket As Socket)
        Me.Socket = TheSocket

        ActivarEscuchador()

    End Sub

#Region "RECIBIENDO DATOS"


    Private Sub ActivarEscuchador()

        ' Borramos los datos de respuesta anterior
        VariablesGlobales.response = ""

        ' Activamos el escuchador
        Try
            ' Create the state object.
            Dim state As New StateObject()
            state.workSocket = Me.Socket

            ' Begin receiving the data from the remote device.
            Me.Socket.BeginReceive(state.buffer, 0, state.BufferSize, 0, AddressOf OnRecieve, state)
        Catch e As Exception
            RaiseEvent FallaAlRecibirDatos("No se pudo activar el escuchador.", "Falla al intentar escuchar.")
        End Try

    End Sub

    Private Sub OnRecieve(ar As IAsyncResult)

        Try

            Dim state As StateObject = CType(ar.AsyncState, StateObject)
            Dim client As Socket = state.workSocket

            ' Read data from the remote device.
            Dim bytesRead As Integer = client.EndReceive(ar)

            If bytesRead > 0 Then
                ' There might be more data, so store the data received so far.
                state.sb.Append(Encoding.UTF8.GetString(state.buffer, 0, bytesRead))

                If state.sb.ToString.Contains("\0") Then

                    Dim textoMsg As String = state.sb.ToString

                    textoMsg = textoMsg.Substring(0, textoMsg.LastIndexOf("\0"))
                    DescifrarMsg(textoMsg)
                    Return
                End If
                '  Get the rest of the data.
                client.BeginReceive(state.buffer, 0, state.buffer.Length, 0, AddressOf OnRecieve, state)
            Else
                ' All the data has arrived; put it in response.
                If state.sb.Length > 1 Then
                    VariablesGlobales.response = state.sb.ToString()
                End If
                ' Signal that all bytes have been received.
                DescifrarMsg(VariablesGlobales.response)
            End If

        Catch ex As Exception
            RaiseEvent FallaAlRecibirDatos(ex.Message, "Error recibiendo datos de " & Me.Nombre)
            'If ex.ErrorCode = 10054 Or ex.ErrorCode = 10057 Then
            '    RaiseEvent Desconectado(Me)
            'Else
            '    RaiseEvent FallaAlRecibirDatos(ex.ErrorCode & " - " & ex.Message, "Error recibiendo datos de " & Me.Nombre)
            'End If
        End Try

    End Sub



    Public Sub DescifrarMsg(msg As String)

        ' Verifico si el mensaje entrante tiene la palabra clave, si la tiene, es un comando.
        If msg.StartsWith(VariablesGlobales.MyKeyWord) Then
            ' Averiguo entonces que comando es.
            DescifrarComando(msg.Substring(VariablesGlobales.MyKeyWord.Length))
        Else

            ' Si no es un comando, es un mensaje. Guardo el mensaje
            SyncLock Me
                MensajesInteractuados.Add(Me.Nombre & ": " & msg & vbCrLf)
            End SyncLock

            ' Desencadeno el evento que indica que ha llegado un mensaje.
            RaiseEvent NuevoMensaje(Me, msg)
        End If

        ActivarEscuchador()

    End Sub

    Private Sub DescifrarComando(Comando As String)

        Dim Arguments As String() = Comando.Split(New Char() {VariablesGlobales.Delimitador}, StringSplitOptions.RemoveEmptyEntries)

        Select Case Arguments(0)
            Case ""
                RaiseEvent ComandoVacio(Me)

            Case "GOOD_ANSWER"
                SyncLock Me
                    Me.PregCorrectas += 1
                    Me.TiempoExam += Arguments(1)
                    Me.ColorActual = COLOR_GOOD_ANSWER
                End SyncLock

                ReproducirSonido("Correcta")
                RaiseEvent PreguntaContestadaCorrectamente(Me)

            Case "BAD_ANSWER"
                SyncLock Me
                    Me.PregIncorrectas += 1
                    Me.TiempoExam += Arguments(1)
                    Me.ColorActual = COLOR_BAD_ANSWER
                End SyncLock

                ReproducirSonido("Error")
                RaiseEvent PreguntaContestadaIncorrectamente(Me)

            Case "CONECTED"
                SyncLock Me
                    Me.Nombre = Arguments(1)
                    Me.Entidad = Arguments(2)
                    Me.AliasEntidad = Arguments(3)
                    Me.NombreEquipo = Arguments(4)
                    Me.ColorActual = COLOR_IN_TEST
                End SyncLock

                RaiseEvent Conected(Me)

            Case "TEST_STARTED"
                SyncLock Me
                    Me.idExamen = Arguments(1)
                    Me.idCategoria = Arguments(2)
                    Me.Categoria = Arguments(3)
                    Me.cantPregsExam = Arguments(4)

                    Me.PregIncorrectas = 0
                    Me.PregCorrectas = 0
                    Me.TiempoExam = 0
                    Me.ColorActual = COLOR_IN_TEST
                End SyncLock

                RaiseEvent EmpiezaElExamen(Me)

            Case "CATEG_CHANGED"
                SyncLock Me
                    Me.idCategoria = Arguments(1)
                    Me.Categoria = Arguments(2)
                End SyncLock

                RaiseEvent CategoriaCambiada(Me)

                ' Próximos comandos a crear:
                'Case "NEXT_QUESTION"
                'Case "NEXT_SHOW_QUESTION"
                'Case "SHOW_RESULTS"
                'Case "SHOW_IMAGE"

        End Select

    End Sub

#End Region


#Region "ENVIO DE DATOS"


    Public Sub StartTest()
        Me.EnviarXComando("START_TEST")
    End Sub

    Public Sub CerrarPrograma()
        Me.EnviarXComando("CLOSE_SYSTEM")
    End Sub

    Public Sub CerrarTest()
        Me.EnviarXComando("CLOSE_TEST")
    End Sub

    Public Sub NextQuestion()
        Me.EnviarXComando("NEXT_QUESTION")
        Me.ColorActual = COLOR_IN_TEST
        RaiseEvent EmpiezaSiguientePreg(Me)
    End Sub

    Public Sub GotoQuestion(Preg As Integer)
        Me.EnviarXComando("GOTO_QUESTION" & VariablesGlobales.Delimitador & Preg)
    End Sub

    Public Sub ChangeTiempoMax(Segundos As Integer)
        Me.EnviarXComando("CHANGE_TIME" & VariablesGlobales.Delimitador & Segundos)
    End Sub

    Public Sub EnviarXComando(Comando As String)
        ' Decodificamos el mensaje
        Dim sendBytes As Byte() = UTF8Encoding.UTF8.GetBytes(VariablesGlobales.MyKeyWord & Comando & VariablesGlobales.Delimitador & "\0")
        Try
            Me.Socket.BeginSend(sendBytes, 0, sendBytes.Length, SocketFlags.None, New AsyncCallback(AddressOf onDatosSent), Me.Socket)
        Catch ex As Exception
            RaiseEvent Desconectado(Me)
            Me.Dispose()
        End Try

    End Sub


    Public Sub EnviarDatos(msg As String)

        ' Decodificamos el mensaje
        Dim sendBytes As Byte() = UTF8Encoding.UTF8.GetBytes(msg & "\0")

        Try
            Me.Socket.BeginSend(sendBytes, 0, sendBytes.Length, SocketFlags.None, AddressOf onDatosSent, Me.Socket)
        Catch ex As SocketException
            If ex.ErrorCode = 10054 Or ex.ErrorCode = 10057 Then
                RaiseEvent Desconectado(Me)
                Me.Dispose()
            Else
                RaiseEvent FallaAlRecibirDatos("Falla al recibir datos de " & Me.Nombre, "Cliente desconectado.")
            End If
            Return
        End Try

        SyncLock Me
            MensajesInteractuados.Add(m_UsuarioAuth.Row.Item("UsuLogin") & ": " & msg & vbCrLf)
        End SyncLock
    End Sub

    Private Sub onDatosSent(ByVal ar As IAsyncResult)
        Try
            Dim client As Socket = ar.AsyncState
            Dim bytesSent As Integer = client.EndSend(ar)
            RaiseEvent DatosEnviados(bytesSent)
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

#End Region


    Public Sub MostrarPuntajes(mostrar As Boolean)
        RaiseEvent MostrarPuntaje(mostrar)
    End Sub


    Public Overloads Function Equals(other As clsDatosDeUnCliente) As Boolean Implements IEquatable(Of clsDatosDeUnCliente).Equals

        If other Is Nothing Then Return False

        Dim ipOther As String = CType(other.Socket.RemoteEndPoint, IPEndPoint).Address.ToString

        ' Si los Sockets viene de la misma ip, se cumple Equals
        If ipOther = Me.IPString Then
            Return True
        Else
            Return False
        End If

    End Function


    'Para eliminar el objeto
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposed Then
            If disposing Then
                ' Insert code to free managed resources.
            End If
            ' Insert code to free unmanaged resources.

        End If
        Me.disposed = True
    End Sub
    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
    Protected Overrides Sub Finalize()
        Dispose(False)
        MyBase.Finalize()
    End Sub


    Public Sub ReproducirSonido(NombreSonido As String)
        Dim thrSound As New Threading.Thread(AddressOf StartThreadReproducirSonido)
        Me.NombreWav = NombreSonido
        thrSound.Start()
    End Sub
    Public Sub StartThreadReproducirSonido(NombreSonido As String)
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\sounds\" & NombreWav & ".wav", AudioPlayMode.Background)
    End Sub

End Class
