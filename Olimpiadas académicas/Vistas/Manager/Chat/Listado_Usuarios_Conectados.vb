Public Class Listado_Usuarios_Conectados
    Inherits Panel


    Public UsuariosConects As New List(Of Usuario_Conectado)
    Public IpBuscada As String
    Public strBuscar As String
    Private posY As Integer = 0

    Sub New()
        Me.AutoScroll = True
    End Sub


    Public Sub AddUsuario(Usu_Conect As Usuario_Conectado)
        Usu_Conect.Name = Usu_Conect.UsuLogin
        Me.UsuariosConects.Add(Usu_Conect)
        Usu_Conect.Width = 339
        Usu_Conect.Top = posY
        posY += Usu_Conect.Height
        Me.Controls.Add(Usu_Conect)
        'Actualizar_Usuarios_Mostrados()

    End Sub


    Public Sub QuitarUsuario(Usu_Conect As Usuario_Conectado)

        Me.UsuariosConects.Remove(Usu_Conect)
        Me.Controls.Remove(Usu_Conect)
        conn.EjecutarConsulta("delete tbConfigFinal where FinIdUsuario=" & Usu_Conect.UsuId & ";")
        'Actualizar_Usuarios_Mostrados()

    End Sub


    Public Function FindUsu(usu As Usuario_Conectado) As Boolean
        If usu.IP = IpBuscada Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function FiltrarUsu(usu As Usuario_Conectado) As Boolean
        Return usu.IdCatActual = strBuscar  'Se llama así: Dim newLista = MisUsuarios.FindAll(AddressOf FiltrarUsu)
    End Function


    Public Sub QuitarRespuestas()
        For Each usu As Usuario_Conectado In Me.UsuariosConects
            usu.LimpiarRespuesta()
        Next
    End Sub



End Class
