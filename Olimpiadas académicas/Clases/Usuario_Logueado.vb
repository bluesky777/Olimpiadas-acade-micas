Imports System
Imports System.Data

Public Class Usuario_Logueado

    Property Codigo As Integer
    Property Nombre As String
    Property Login As String
    Property Password As String
    Property TipoId As Integer
    Property TipoStr As String
    Property EntidadId As Integer
    Property EntidadStr As String
    Property IdInsActual As Integer
    Property IdCatInsActual As Integer
    Property idExaActual As Integer

    Property EquipoNombre As String

    'Datos del evento actual
    Property EvId As Integer
    Property EvNombre As String
    Property EvNombreCorto As String
    Property EvFechaInicio As Date
    Property EvFechaFin As Date
    Property EvDescrip As String
    Property EvActivo As String
    Property EvActual As String
    Property EvParaTodos As String
    Property EvPermisoEmpezar As Integer
    Property EvTipoExamenId As Integer
    Property EvTipoExamenStr As String
    Property EvMinutosTotalMax As Integer
    Property EvSegundosPregMax As Integer
    Property EvLogo As Image


    Public Function Validar_Login(ByVal Nombre_Usuario As String, ByVal Contrasena_Usuario As String, Roll As String, ByVal Conexion_Actual As Conexion_SqlServer) As String

        If Conexion_Actual.Conectar() = False Then
            Return "No conecta"
        End If

        Dim dtUsu As New DataTable
        Dim strConsulta As String

        strConsulta = "SELECT u.UsuId, u.UsuNombre, u.UsuLogin, u.UsuTipo, t.TuTipoUsuario, u.UsuFoto, u.UsuActivo " _
            & "from tbUsuarios u, tbTipoUsuario t " _
            & "where UsuLogin='" & Nombre_Usuario & "' and UsuPassw='" & Contrasena_Usuario & "' " _
            & "and t.TuId=u.UsuTipo"

        'MsgBox(strConsulta)

        Conexion_Actual.TraerTabla(dtUsu, strConsulta)

        If dtUsu.Rows.Count = 0 Then
            Return "Datos incorrectos"
        End If


        If dtUsu.Rows(0).Item("UsuActivo") = "False" Then
            Return "Desactivado"
        End If

        Me.Codigo = dtUsu.Rows(0).Item("UsuId")
        Me.Nombre = dtUsu.Rows(0).Item("UsuNombre")
        Me.Login = dtUsu.Rows(0).Item("UsuLogin")
        Me.Password = Contrasena_Usuario
        Me.TipoId = dtUsu.Rows(0).Item("UsuTipo")
        Me.TipoStr = dtUsu.Rows(0).Item("TuTipoUsuario")


        'Conseguir la tercera direccion IP de mi equipo
        Dim Misip As Net.IPAddress() = Net.Dns.GetHostAddresses(Net.Dns.GetHostName())
        Dim MiIP As String
        Try
            MiIP = Misip(2).ToString
        Catch ex As Exception
            Try
                MiIP = Misip(1).ToString
            Catch exe As Exception
                MsgBox(ex.Message)
                Return "No IP"
            End Try
        Finally
            Me.EquipoNombre = My.Computer.Name.ToString
        End Try

        'Dim consultaEqui As String = "INSERT INTO tbEquipos(EquiNombre, EquiIP, EquiLogin, EquiRoll, EquiTipo) VALUES('" & Me.EquipoNombre & "', '" & MiIP & "', '" & Me.Login & "',  '" & Roll & "', '" & Me.TipoStr & "')"

        'If conn.EjecutarConsulta(consultaEqui) = False Then
        '    Return "No Consulta Equipo"
        'End If



        Return "Exitoso"

    End Function


    Public Sub Evento_Actual(ByVal Conexion_Actual As Conexion_SqlServer, Optional ByVal Cod_Evento As Integer = -1)

        Dim dtEventos As New DataTable

        If Cod_Evento = -1 Then
            Conexion_Actual.TraerTabla(dtEventos, "SELECT * FROM tbEventos WHERE EvActual='Actual'")
        Else
            Conexion_Actual.TraerTabla(dtEventos, "SELECT * FROM tbEventos WHERE EvId='" & Cod_Evento & "'")
        End If

        If dtEventos.Rows.Count > 0 Then
            Me.EvId = dtEventos.Rows(0).Item("EvId")
            Me.EvNombre = dtEventos.Rows(0).Item("EvNombre")
            Me.EvNombreCorto = dtEventos.Rows(0).Item("EvNombreCorto")
            Me.EvFechaInicio = dtEventos.Rows(0).Item("EvFechaInicio")
            Me.EvFechaFin = dtEventos.Rows(0).Item("EvFechaFin")
            Me.EvDescrip = dtEventos.Rows(0).Item("EvDescrip")
            Me.EvActivo = dtEventos.Rows(0).Item("EvActivo")
            Me.EvActual = dtEventos.Rows(0).Item("EvActual")
            Me.EvParaTodos = dtEventos.Rows(0).Item("EvParaTodos")
            Me.EvPermisoEmpezar = dtEventos.Rows(0).Item("EvPermisoEmpezar")
            Me.EvTipoExamenId = dtEventos.Rows(0).Item("EvTipoExamen")

            Dim dtT As New DataTable
            conn.TraerTabla(dtT, "select TeTipo from tbTipoExamen where TeId=" & Me.EvTipoExamenId)

            Me.EvTipoExamenStr = dtT.Rows(0).Item("TeTipo")

            Me.EvMinutosTotalMax = dtEventos.Rows(0).Item("EvMinutosTotalMax")
            Me.EvSegundosPregMax = dtEventos.Rows(0).Item("EvSegundosPregMax")

        End If


    End Sub


End Class
