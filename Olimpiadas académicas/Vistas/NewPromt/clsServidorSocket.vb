Imports System.Net
Imports System.Net.Sockets
Imports System.Threading.ManualResetEvent
Imports System.Text

Public Class clsServidorSocket



    Dim dat As clsDatosDeUnCliente
    Public DatosClientes As New List(Of clsDatosDeUnCliente)
    Dim Server As Socket
    Public formParent As Form

    Dim lingerOption As New LingerOption(True, 3)



#Region "EVENTOS"
    Public Event NuevaConexion(ByRef DatosClienteNuevo As clsDatosDeUnCliente)
    Public Event DatosRecibidos(ByRef sender As clsDatosDeUnCliente, msg As String)
    Public Event CategoriaCambiada(ByRef sender As clsDatosDeUnCliente)
    Public Event ConexionTerminada(ByVal IDTerminal As Net.IPEndPoint)
    Public Event allDone()
#End Region


    Public Sub New(ByRef formularioPadre As Form)
        Me.formParent = formularioPadre
    End Sub



#Region "INICIO DE CONEXIONES"

    Public Sub StartListen()

        Server = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Me.Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger, lingerOption)

        Dim TheIpEndPoint As New IPEndPoint(IPAddress.Any, VariablesGlobales.Puerto)

        Server.Bind(TheIpEndPoint)

        Server.Listen(50)

        Server.BeginAccept(New System.AsyncCallback(AddressOf IntentoEntrante), Nothing)

    End Sub

    Private Sub IntentoEntrante(ByVal ar As IAsyncResult)
        Dim aClientSocket As Socket
        Try
            aClientSocket = Server.EndAccept(ar)
        Catch ex As Exception

            If ex.Message = "Referencia a objeto no establecida como instancia de un objeto." Then
                Return
            End If
            
            Return

        End Try


        aClientSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger, lingerOption)


        ' Construimos el cliente nuevo y añadimos los Handlers
        Dim aDatosCliente As New clsDatosDeUnCliente(aClientSocket)
        aDatosCliente.IPString = CType(aDatosCliente.Socket.RemoteEndPoint, IPEndPoint).Address.ToString

        AddHandler aDatosCliente.Conected, AddressOf ClienteConectado
        AddHandler aDatosCliente.EmpiezaElExamen, AddressOf ClienteStartedTest
        AddHandler aDatosCliente.EmpiezaSiguientePreg, AddressOf EmpiezaSiguientePreg
        AddHandler aDatosCliente.PreguntaContestadaIncorrectamente, AddressOf ClienteContestaIncorrectamente
        AddHandler aDatosCliente.PreguntaContestadaCorrectamente, AddressOf ClienteContestaCorrectamente
        AddHandler aDatosCliente.CategoriaCambiada, AddressOf ClienteCambiaCategoria
        AddHandler aDatosCliente.NuevoMensaje, AddressOf ClienteNuevoMensaje
        AddHandler aDatosCliente.Desconectado, AddressOf ClienteDesconectado


        ' Inicio otro hilo para que siga escuchando a otro cliente que se quiera conectar.
        Server.BeginAccept(New System.AsyncCallback(AddressOf IntentoEntrante), Nothing)

        ProcesarNuevaConexion(aDatosCliente)

        RaiseEvent NuevaConexion(aDatosCliente)

    End Sub


    '' No sirve!
    Public Sub cerrarServidor()
        Me.Server.Close()
        For Each Conectados As clsDatosDeUnCliente In DatosClientes
            Conectados.Socket.Disconnect(True)
            Conectados = Nothing
        Next

        DatosClientes = Nothing

    End Sub


    Delegate Sub _ProcesarNuevaConexion(ByRef datosClienteConectado As clsDatosDeUnCliente)
    Public Sub ProcesarNuevaConexion(ByRef datosClienteConectado As clsDatosDeUnCliente)
        If Me.formParent.InvokeRequired Then
            Me.formParent.Invoke(New _ProcesarNuevaConexion(AddressOf ProcesarNuevaConexion), datosClienteConectado)
            Exit Sub
        End If

        Dim itemDeLista As New ListViewItem(datosClienteConectado.IPString)

        itemDeLista.Tag = datosClienteConectado
        DatosClientes.Add(datosClienteConectado)

    End Sub

    Delegate Sub _ClienteConectado(ByRef sender As clsDatosDeUnCliente)
    Private Sub ClienteConectado(ByRef sender As clsDatosDeUnCliente)
        If Me.formParent.InvokeRequired Then
            Me.formParent.Invoke(New _ClienteConectado(AddressOf ClienteConectado), sender)
            Exit Sub
        End If

        'For listVItem As Integer = 0 To Me.ListViewClientes.Items.Count - 1
        '    If Me.ListViewClientes.Items(listVItem).Tag.Equals(sender) Then
        '        Me.ListViewClientes.Items(listVItem).Tag = sender
        '        Me.ListViewClientes.Items(listVItem).Text = sender.Nombre & " - " & sender.AliasEntidad
        '        Me.ListViewClientes.Items(listVItem).BackColor = COLOR_CONECTED
        '    End If
        'Next

    End Sub


#End Region


#Region "ENVIAR MENSAJES"

    Public Sub StartTestToAll()

        ' A veces se intenta enviar datos a un socket perdido, eso modifica la lista pues elimina al socket, por lo tanto da error el ForEach
        ' Asi que intentamos volver a recorrer los actuales
        Dim Intentos As Integer = 30

IntentoDeInicio:
        Try
            For Each clienteConectado As clsDatosDeUnCliente In DatosClientes
                clienteConectado.StartTest()
            Next
        Catch ex As Exception
            GoTo IntentoDeInicio
        End Try


    End Sub


    Public Sub SiguientePregToAll()
        Dim Intentos As Integer = 30

IntentoDeInicio:
        Try
            For Each clienteConectado As clsDatosDeUnCliente In DatosClientes
                clienteConectado.NextQuestion()
            Next
        Catch ex As Exception
            GoTo IntentoDeInicio
        End Try

    End Sub

    Public Sub CerrarProgramaToAll()
        Dim Intentos As Integer = 30

IntentoDeInicio:
        Try
            For Each clienteConectado As clsDatosDeUnCliente In DatosClientes
                clienteConectado.CerrarPrograma()
            Next
        Catch ex As Exception
            GoTo IntentoDeInicio
        End Try

    End Sub

    Public Sub CerrarExamenToAll()
        Dim Intentos As Integer = 30

IntentoDeInicio:
        Try
            For Each clienteConectado As clsDatosDeUnCliente In DatosClientes
                clienteConectado.CerrarTest()
            Next
        Catch ex As Exception
            GoTo IntentoDeInicio
        End Try


    End Sub

    Public Function EnviarMensajeToAll(msg As String) As Boolean
        Dim Intentos As Integer = 30

IntentoDeInicio:
        Try
            For Each clienteConectado As clsDatosDeUnCliente In DatosClientes
                clienteConectado.EnviarDatos(msg)
            Next
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function


#End Region



    Private Sub ClienteStartedTest(ByRef sender As clsDatosDeUnCliente)
        DelegadoClienteStartedTest(sender)
    End Sub

    Delegate Sub _DelegadoClienteStartedTest(ByRef datosClienteConectado As clsDatosDeUnCliente)
    Public Sub DelegadoClienteStartedTest(ByRef datosClienteConectado As clsDatosDeUnCliente)
        If Me.formParent.InvokeRequired Then
            Me.formParent.Invoke(New _DelegadoClienteStartedTest(AddressOf DelegadoClienteStartedTest), datosClienteConectado)
            Exit Sub
        End If

    End Sub


    Private Sub EmpiezaSiguientePreg(ByRef sender As clsDatosDeUnCliente)
        DelegadoEmpiezaSiguientePreg(sender)
    End Sub

    Delegate Sub _DelegadoEmpiezaSiguientePreg(ByRef datosClienteConectado As clsDatosDeUnCliente)
    Public Sub DelegadoEmpiezaSiguientePreg(ByRef datosClienteConectado As clsDatosDeUnCliente)
        If Me.formParent.InvokeRequired Then
            Me.formParent.Invoke(New _DelegadoEmpiezaSiguientePreg(AddressOf DelegadoEmpiezaSiguientePreg), datosClienteConectado)
            Exit Sub
        End If

    End Sub


    Private Sub ClienteContestaIncorrectamente(ByRef sender As clsDatosDeUnCliente)
        DelegadoClienteContestaIncorrectamente(sender)
    End Sub

    Delegate Sub _DelegadoClienteContestaIncorrectamente(ByRef datosClienteConectado As clsDatosDeUnCliente)
    Public Sub DelegadoClienteContestaIncorrectamente(ByRef datosClienteConectado As clsDatosDeUnCliente)
        If Me.formParent.InvokeRequired Then
            Me.formParent.Invoke(New _DelegadoClienteContestaIncorrectamente(AddressOf DelegadoClienteContestaIncorrectamente), datosClienteConectado)
            Exit Sub
        End If

    End Sub


    Private Sub ClienteContestaCorrectamente(ByRef sender As clsDatosDeUnCliente)
        DelegadoClienteContestaCorrectamente(sender)
    End Sub

    Delegate Sub _DelegadoClienteContestaCorrectamente(ByRef datosClienteConectado As clsDatosDeUnCliente)
    Public Sub DelegadoClienteContestaCorrectamente(ByRef datosClienteConectado As clsDatosDeUnCliente)
        If Me.formParent.InvokeRequired Then
            Me.formParent.Invoke(New _DelegadoClienteContestaCorrectamente(AddressOf DelegadoClienteContestaCorrectamente), datosClienteConectado)
            Exit Sub
        End If

    End Sub


    Private Sub ClienteNuevoMensaje(ByRef sender As clsDatosDeUnCliente, msg As String)
        RaiseEvent DatosRecibidos(sender, msg)
    End Sub


    Private Sub ClienteCambiaCategoria(ByRef sender As clsDatosDeUnCliente)
        RaiseEvent CategoriaCambiada(sender)
    End Sub


    Private Sub ClienteDesconectado(ByRef sender As clsDatosDeUnCliente)
        SyncLock Me
            DatosClientes.Remove(sender)
        End SyncLock
    End Sub


    Sub OrdenarPorExamenes()
        Me.DatosClientes.Sort(AddressOf Me.CompareExamenes)
    End Sub

    Private Function CompareExamenes(ByVal Datos1 As clsDatosDeUnCliente, ByVal Datos2 As clsDatosDeUnCliente) As Integer
        If Datos1.PregCorrectas = Datos2.PregCorrectas Then

            If Datos1.TiempoExam = Datos2.TiempoExam Then
                If Datos1.Nombre = Nothing Then
                    Return 1
                ElseIf Datos2.Nombre = Nothing Then
                    Return 0
                End If
                Return Datos1.Nombre.CompareTo(Datos2.Nombre)
            Else
                Return Datos1.TiempoExam.CompareTo(Datos2.TiempoExam)
            End If

        Else

            Return Datos1.PregCorrectas.CompareTo(Datos2.PregCorrectas)

        End If

    End Function


End Class
