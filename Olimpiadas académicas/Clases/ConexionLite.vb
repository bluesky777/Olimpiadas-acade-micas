Imports System
Imports System.IO

Public Class ConexionLite

    Property CadenaConex As String
    Property ConL As SQLiteConnection
    Property dt As DataTable
    Property NombreDB As String = "-1"
    Property RutaNombreDB As String
    Property Contraseña_Conex As String
    Property Encriptada As Boolean = True
    Property Consulta As String


    Public Function CrearDB(Optional ByVal Nombre_BD As String = "-1", Optional ByVal Contraseña_Conexion As String = "-1", Optional ByVal Dialogo_Guardar As Boolean = False) As Boolean

        If Dialogo_Guardar = True Then

            Dim RutaGuar As New FolderBrowserDialog

            If RutaGuar.ShowDialog = Windows.Forms.DialogResult.OK Then

                If Nombre_BD <> "-1" Then
                    Me.NombreDB = Nombre_BD
                    RutaNombreDB = Path.Combine(RutaGuar.SelectedPath, Me.NombreDB)
                ElseIf NombreDB <> "-1" Then
                    RutaNombreDB = Path.Combine(RutaGuar.SelectedPath, NombreDB)
                Else
                    MsgBox("No ha especificado el nombre de la base de datos.", MsgBoxStyle.Critical, "Error")
                    Return False
                End If

                If File.Exists(RutaNombreDB) Then
                    If (MsgBox("La base de datos ya existe ¿desea reemplazarla?", vbYesNoCancel) = MsgBoxResult.Yes) Then
                        Try
                            File.Delete(RutaNombreDB)
                        Catch ex As Exception
                            MsgBox("No se pudo borrar el archivo anterior.", vbCritical, "Error")
                            Return False
                        End Try

                    Else
                        Return False
                    End If

                End If

            Else
                Return False

            End If

        Else
            Return False
        End If


        Me.CadenaConex = "Data Source=" & RutaNombreDB & ";Version=3"

        Try
            Me.ConL = New SQLiteConnection(CadenaConex)
        Catch ex As Exception
            MsgBox("No se pudo crear la variable de conexión.")
        End Try


        Try
            Me.ConL.Open()
        Catch ex As Exception
            MsgBox("No se pudo crear la base de datos '" & RutaNombreDB & "'." & vbCrLf & ex.Message)
        End Try

        If Contraseña_Conexion <> "-1" Then
            Me.Encriptada = True
            Me.ConL.ChangePassword(Contraseña_Conexion)
        Else
            Me.Encriptada = False
        End If

        Try
            Me.ConL.Close()
        Catch ex As Exception

        End Try

        Return True

    End Function


    Public Function Conectar(Optional ByVal Ruta_Nombre_Base_De_Datos As String = "-1", Optional ByVal Contraseña_BaseDatos As String = "-1") As Boolean


        If Ruta_Nombre_Base_De_Datos <> "-1" Then 'Si se especifica la ruta, entonces verificamos si espcifica también la contraseña

            If File.Exists(Ruta_Nombre_Base_De_Datos) = False Then
                MsgBox("La se encontró base de datos en la ruta especificada.", vbCritical, "Error al conectar")
                Return False
            End If

            If Contraseña_BaseDatos <> "-1" Then

                Me.RutaNombreDB = Ruta_Nombre_Base_De_Datos
                Me.Contraseña_Conex = Contraseña_BaseDatos
                Me.Encriptada = True

            Else

                Me.RutaNombreDB = Ruta_Nombre_Base_De_Datos
                Me.Encriptada = False

            End If

        Else

            If Contraseña_BaseDatos <> "-1" Then

                Me.Encriptada = True
                Me.Contraseña_Conex = Contraseña_BaseDatos

            Else

                Me.Encriptada = False

            End If

        End If


        If Me.Encriptada = True Then
            Me.CadenaConex = "Data Source=" & Me.RutaNombreDB & ";Version=3;password=" & Me.Contraseña_Conex
        Else
            Me.CadenaConex = "Data Source=" & Me.RutaNombreDB & ";Version=3"
        End If

        Try
            Me.ConL.Close()
        Catch ex As Exception

        End Try



        Me.ConL = New SQLiteConnection(Me.CadenaConex)

        Try
            Me.ConL.Open()
            Return True
        Catch ex As Exception
            MsgBox("No se pudo abrir la base de datos '" & RutaNombreDB & "'." & vbCrLf & ex.Message)
            Return False
        End Try


    End Function


    Public Function EjecutarConsulta(ByVal Consulta_A_Ejecutar As String) As Boolean

        Me.Consulta = Consulta_A_Ejecutar

        If Me.ConL.State <> ConnectionState.Open Then
            MsgBox("Lo sentimos, antes de ejecutar una consulta debe estar abierta la conexión.")
            Return False
        End If

        Dim cmdTb As New SQLiteCommand(Me.Consulta, Me.ConL)

        Try
            cmdTb.ExecuteNonQuery()
        Catch ex As SQLiteException
            MsgBox("Problema con la consulta: " & vbCrLf & ex.ErrorCode & ": " & ex.Message)
            Return False
        End Try

        Return True

    End Function

    Public Function TraerTabla(ByRef Tabla_A_Llenar As DataTable, ByVal StrSelect As String) As Boolean

        Dim daLite As New SQLiteDataAdapter(StrSelect, Me.ConL)

        Try
            daLite.Fill(Tabla_A_Llenar)
            Return True
        Catch ex As Exception
            MsgBox("No se pudo llenar la tabla." & vbCrLf & ex.Message)
            Return False
        End Try


    End Function


    Public Sub Desconectar()
        Try
            Me.ConL.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class
