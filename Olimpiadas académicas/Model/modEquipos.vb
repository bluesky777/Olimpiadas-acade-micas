Imports System.Net.NetworkInformation

Public Class modEquipos
    Inherits ModBase


#Region "Contructores"

    Sub New(Codigo As Integer)
        MyBase.New(Codigo)
        Me.Id = Codigo
    End Sub

    Sub New()
        MyBase.New()
        ' Se pasan los datos después
    End Sub
#End Region

    Public Overrides Sub Starting()
        Me.TableName = "Equipos"
        Me.Prefix = "Equi"

        Me.addForeign("EquiRoll", "TipoUsuario", "TuId")
        Me.addForeign("EquiLogin", "Usuarios", "UsuLogin")
    End Sub

    Public Sub insert(usuario As modUsuarios, roll As String, actual As Boolean)
        conn.Desconectar()
        Dim consulta As String

        'Conseguir la tercera direccion IP de mi equipo
        'For Each adapter As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces()
        '    Dim properties As IPInterfaceProperties = adapter.GetIPProperties()
        '    MsgBox(adapter.Description & " - " & properties.DnsSuffix)
        'Next


        Dim Misip As Net.IPAddress() = Net.Dns.GetHostAddresses(Net.Dns.GetHostName())
        Dim MiIP As String = ""

        For Each ip As Net.IPAddress In Misip

            If ip.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then
                'MsgBox(ip.ToString)
                MiIP = ip.ToString
            End If
        Next


        'Try
        '    MiIP = Misip(2).ToString
        'Catch ex As Exception
        '    Try
        '        MiIP = Misip(1).ToString
        '    Catch exe As Exception
        '        MsgBox(ex.Message)
        '    End Try

        'End Try

        Dim Equipo = My.Computer.Name.ToString

        consulta = "INSERT INTO tbEquipos(EquiNombre, EquiIP, EquiLogin, EquiRoll) " _
            & "VALUES('" & Equipo & "', '" & MiIP & "', '" & usuario.Row.Item("UsuLogin") & "', " _
            & "'" & roll & "')"

        Dim lastId As Integer = conn.EjecutarConsulta(consulta, True)

        ' Asignamos el código asignado al equipo para que se llenen 
        ' automáticamente los datos de ese registro en este modelo
        If actual = True Then
            Me.Id = lastId
            Me.findRaw(Me.Id)
        End If


    End Sub


    Public Sub setServer()

        If Not Me.Row Is Nothing Then

            conn.Conectar()
            Dim consulta As String
            consulta = "UPDATE tbEquipos SET EquiConection = 'Servidor' WHERE EquiId=" & Me.Id
            Dim cmd As New Data.SqlClient.SqlCommand(consulta, conn.Conex)

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message & " - " & consulta)
            End Try



        End If

    End Sub


End Class
