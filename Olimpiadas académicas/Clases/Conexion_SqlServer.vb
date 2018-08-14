Imports System.Data
Imports System.Data.SqlClient
Imports System.IO




Public Class Conexion_SqlServer


    Property MyServer As String
    Property NombreDB As String
    Property Usuario_Id As String
    Property Usuario_Pass As String

    'Es un valor temporal ya que cuando sea instanciada esta clase, la cadena de conexión cambiará de inmediato
    Property StringConex As String = "Data Source=JOSECIN-PC/;Initial Catalog=Olimpiadas; user id=princesito; " & _
        "password=superjoseth; MultipleActiveResultSets=True"
    Property Conex As SqlConnection

    Property dt As DataTable
    Property Consulta As String

    Public prefixTables As String = "tb"


    Sub New(ByVal Servidor_SqlServer As String, ByVal Nombre_BaseDatos As String, ByVal Usuario_Login As String, ByVal Usuario_Password As String)


        If File.Exists("Servidor.txt") Then

            Dim lector As New StreamReader("Servidor.txt")
            Dim sLine As String = lector.ReadLine()
            lector.Close()
            frmLogin.txtServidor.Text = sLine
            Me.MyServer = sLine
        Else
            Me.MyServer = Servidor_SqlServer
            File.Create("Servidor.txt")
            MsgBox("Defina el servidor")
        End If

        Me.NombreDB = Nombre_BaseDatos
        Me.Usuario_Id = Usuario_Login
        Me.Usuario_Pass = Usuario_Password

        Me.StringConex = "Data Source=" & Me.MyServer & ";Initial Catalog=" & Me.NombreDB & "; user id=" & Me.Usuario_Id & "; password=" & Me.Usuario_Pass & _
            "; MultipleActiveResultSets=True"
        Me.Conex = New SqlConnection(Me.StringConex)

    End Sub

    Public Sub ActualizarCadena()

        If File.Exists("Servidor.txt") Then

            Dim lector As New StreamReader("Servidor.txt")
            Dim sLine As String = lector.ReadLine()
            lector.Close()
            frmLogin.txtServidor.Text = sLine
            Me.MyServer = sLine
            Me.StringConex = "Data Source=" & Me.MyServer & ";Initial Catalog=" & Me.NombreDB & "; user id=" & Me.Usuario_Id & "; password=" & Me.Usuario_Pass
            Me.Conex = New SqlConnection(Me.StringConex)
        Else
            File.Create("Servidor.txt")
            MsgBox("No hay servidor definido")
        End If
    End Sub


    Public Function Conectar() As Boolean

        If Me.Conex.State <> ConnectionState.Open Then
            Try

                Me.Conex.Open()
                Return True

            Catch ex As SqlClient.SqlException

                Select Case ex.Number
                    Case -1 Or 87
                        MsgBox("Servidor no encontrado, defina el servidor en donde" & vbCrLf & " se encuentra la base de datos.")
                    Case 53
                        MsgBox("No hay servidor o acceso a la base de datos.")
                    Case 4060
                        MsgBox("Base de datos no encontrada.")
                    Case Else
                        MsgBox("-Número de error: " & ex.Number & vbCrLf & vbCrLf & ex.Message)
                End Select

                Return False

            End Try
        Else
            Return True
        End If

    End Function


    Public Sub Desconectar()

        If Me.Conex.State <> ConnectionState.Closed Then
            Try
                Me.Conex.Close()
            Catch ex As Exception

            End Try
        End If

    End Sub


    Public Sub TraerTabla(ByRef DataTable_A_Llenar As DataTable, ByVal Consulta As String)
        Me.Conectar()
        Dim Adapt As New SqlDataAdapter(Consulta, Me.Conex)

        Try
            Adapt.Fill(DataTable_A_Llenar)
        Catch ex As Exception
            MsgBox("No se pudieron traer los datos." & ex.Message & vbCrLf & Consulta)
        End Try

    End Sub

    Public Function TraerTabla(ByVal Consulta As String) As DataTable
        Me.Conectar()
        Dim tmpTable As New DataTable
        Dim Adapt As New SqlDataAdapter(Consulta, Me.Conex)

        Try
            Adapt.Fill(tmpTable)
        Catch ex As Exception
            MsgBox("No se pudieron traer los datos." & ex.Message & vbCrLf & Consulta)
        End Try

        Return tmpTable
    End Function


    Public Function fillTable(ByVal tabla As String, Optional ByVal condicional As String = ";") As DataTable
        Me.Conectar()

        Dim tmpQuery As String = "SELECT * FROM " & tabla
        If condicional <> ";" Then
            tmpQuery += " where " & condicional & ";"
        End If

        Dim tmpTable As New DataTable
        Dim Adapt As New SqlDataAdapter(tmpQuery, Me.Conex)

        Try
            Adapt.Fill(tmpTable)
        Catch ex As Exception
            MsgBox("No se pudo traer los datos. " & ex.Message & vbCrLf & tmpQuery)
        End Try

        Return tmpTable

    End Function



    Public Function EjecutarConsulta(ByVal Consulta_A_Ejecutar As String, Optional retrieveId As Boolean = False)

        Me.Consulta = Consulta_A_Ejecutar

        Me.Conectar()


        Dim cmdTb As New SqlCommand(Me.Consulta, Me.Conex)

        Try
            cmdTb.ExecuteNonQuery()

            ' Si se requiere el último id Autonúmerico generado por SQL Server...
            If retrieveId = True Then
                Return lastId()
            End If

        Catch ex As SqlException
            MsgBox("Problema con la consulta: " & vbCrLf & ex.ErrorCode & ": " & ex.Message)
            Return False
        End Try

        Return True

    End Function

    Public Function lastId() As String
        ' Lo buscamos y lo retornarmos
        Dim dtTemp As DataTable = Me.TraerTabla("SELECT SCOPE_IDENTITY();")
        Dim last As Integer

        If dtTemp.Rows.Count = 1 Then
            last = dtTemp.Rows(0).Item(0)
        End If

        Return last
    End Function

    Public Function Dato_String(ByVal SelectCampo As String, ByVal tabla As String, ByVal CondicionCampo As String, ByVal valorCampo As String)
        Dim dato As String = ""

        Dim dtDato As New DataTable
        Dim dAdapt As New SqlDataAdapter("select " & SelectCampo & " from " & tabla & " where " & CondicionCampo & "='" & valorCampo & "'", Me.Conex)

        Try
            Me.Conectar()
            dAdapt.Fill(dtDato)
            dato = dtDato.Rows(0).Item(SelectCampo).ToString
        Catch ex As Exception
            MsgBox("No se encontró el dato. " & ex.Message)
            Return -1  ' Debo borrar esto y arreglar los errores que eso produzca
        End Try

        Return dato
    End Function




End Class
