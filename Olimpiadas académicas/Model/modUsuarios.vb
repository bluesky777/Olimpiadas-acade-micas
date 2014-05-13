Public Class modUsuarios
    Inherits ModBase

    Public IdInsActual As Integer
    Public IdCatInsActual As Integer
    Public Equipo As modEquipos


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

        Me.TableName = "Usuarios"
        Me.Prefix = "Usu"

        Me.addForeign("ExaInscripcion", "tbInscripciones", "InsId")
    End Sub

    Public Function Auth(Nombre_Usuario As String, Contrasena_Usuario As String, Roll As Integer) As ArrayList

        Me.dt.Clear()

        Dim Logueado As New ArrayList

        Dim condicion As String

        condicion = "UsuLogin='" & Nombre_Usuario & "' and UsuPassw='" & Contrasena_Usuario & "' " _
            & "and UsuActivo='True'"

        Me.getTableRaw(condicion)

        ' Si se trajo un registro, está autorizado.
        If Me.dt.Rows.Count = 1 Then

            Me.Row = Me.dt.Rows(0)
            Me.Id = Me.Row.Item("UsuId")

            m_TipoUsuarios.findRaw(Me.Row.Item("UsuTipo"))


            Select Case Roll
                Case 2 ' Administrador
                    If Roll = m_TipoUsuarios.Row.Item("TuId") Then
                        Logueado.Add(True)
                        Logueado.Add(Roll)
                    Else
                        Logueado.Add(False)
                        Logueado.Add("No tiene suficientes privilegios.")
                    End If

                Case 3 'Asesor
                    If (Roll = m_TipoUsuarios.Row.Item("TuId")) Or (m_TipoUsuarios.Row.Item("TuTipoUsuario") = "Administrador") Then
                        Logueado.Add(True)
                        Logueado.Add(Roll)
                    Else
                        Logueado.Add(False)
                        Logueado.Add("No tiene suficientes privilegios.")
                    End If

                Case 4 'Participante
                    Logueado.Add(True)
                    Logueado.Add(Roll)

            End Select

            Me.Equipo = New modEquipos
            Me.Equipo.insert(Me, Roll, True)

        ElseIf Me.dt.Rows.Count > 1 Then
            Logueado.Add(False)
            Logueado.Add("'" & Me.dt.Rows(0).Item("UsuLogin").ToString.ToUpper & "' existe más de una vez en la base de datos, por favor comuníquese con el administrador del sistema.")

        ElseIf Me.dt.Rows.Count = 0 Then
            Logueado.Add(False)
            Logueado.Add("Datos incorrectos.")

        Else
            Logueado.Add(True)
            Logueado.Add("Error desconocido, por favor comuníquese con el administrador del sistema.")

        End If

        Return Logueado
    End Function

    Public Sub CerrarSesion()
        Me.Equipo.Delete(Equipo.Id)

    End Sub


End Class
