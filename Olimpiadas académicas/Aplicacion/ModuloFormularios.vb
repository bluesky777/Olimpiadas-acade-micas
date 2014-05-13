Imports System.Data
Imports System.Data.SqlClient

Imports System.Net
Imports System.Text
Imports System.Net.Sockets
Imports System.IO

Imports System.Threading 'Hilo que se activa para recibir mensajes

Module ModuloFormularios
    Public Usuario As String = "Administrador"
    Public Equipo As String = "Matriculas" 'Estos valores son de prueba, pero cambian automáticamente al iniciar el programa
    Public Login As String = "Joseth"      'Estos valores son de prueba, pero cambian automáticamente al iniciar el programa
    Public UsuCategoria As Integer = 1      'Estos valores son de prueba, pero cambian automáticamente al iniciar el programa
    Public Colegio As String = "LAL"        'Estos valores son de prueba, pero cambian automáticamente al iniciar el programa
    Public ColgioCorto As String = "Liceo Adventista"

    'Variables de configuración por defecto
    Public TipoExamen As String = "Dirigido básico"  'Estos valores son de prueba, pero cambian automáticamente al iniciar el programa
    Public PermisoEmpezar As String = "Si"      'Estos valores son de prueba, pero cambian automáticamente al iniciar el programa
    Public TiempoMax As Integer = 2             'Estos valores son de prueba, pero cambian automáticamente al iniciar el programa
    Public Categoría As String = 1             'Estos valores son de prueba, pero cambian automáticamente al iniciar el programa
    Public FechaHora As String = ""

    Public PreguntaABuscar As Integer = 0

    Public ExamenTerminado As Boolean = False


    Function enviarMensaje(ByVal Mensaje As String, ByVal IPDestino As String)
        Dim IPServidor As IPAddress
        Dim PortServidor As Integer
        Dim udpCliente As New UdpClient
        Dim bytesEnviados As Integer
        Dim bytCommand As Byte() = New Byte() {}

        IPServidor = IPAddress.Parse(IPDestino) 'Parsea la direccion IP a la cual se va a enviar la data
        PortServidor = "1001" 'Establece el puerto
        udpCliente.Connect(IPServidor, PortServidor) 'Se conecta al socket

        bytCommand = Encoding.UTF8.GetBytes(Mensaje) 'convierte en bytes la informacion
        bytesEnviados = udpCliente.Send(bytCommand, bytCommand.Length) 'Envia la informacion

        Return bytesEnviados

    End Function



    Public PreguntasContestadas As Integer, RespuestasCorrectas As Integer, RespuestasIncorrectas As Integer, PreguntasTotales As Integer
    Public TiempoTotalExamen As String
    Public Puntaje As Double
    Public ExamenId As Integer

    Public Sub Resultados_Examen(ByVal Cod_Examen As Integer)

        Dim dtDetalles As New DataTable

        Try
            conn.TraerTabla(dtDetalles, "Select count(D.DetPregunta) as CantContestadas, count(D.DetContestada) as CantCorrec from tbDetalleExamen D where D.DetExamen=" & Cod_Examen)
            '***************************************************  Preguntas  Contestadas ***************************
            PreguntasContestadas = dtDetalles.Rows(0).Item("CantContestadas").ToString
            dtDetalles.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            conn.TraerTabla(dtDetalles, "Select E.ExaCantPreg  from tbExamenes E where E.ExaId=" & Cod_Examen)
            '***************************************************  Total Preguntas  ************************************
            PreguntasTotales = dtDetalles.Rows(0).Item("ExaCantPreg").ToString
            dtDetalles.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            conn.TraerTabla(dtDetalles, "Select count(DetContestada) as CantPreg, count(DetContestada) as CantCorrec from tbDetalleExamen where DetExamen=" & Cod_Examen & " AND DetContestada='RespCorrec'")
            '***************************************************  Respuestas Correctas  ***************************
            RespuestasCorrectas = dtDetalles.Rows(0).Item("CantPreg").ToString
            dtDetalles.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            conn.TraerTabla(dtDetalles, "Select D.DetTiempo from tbDetalleExamen D where D.DetExamen=" & Cod_Examen)
            
            Dim segundos As Integer = 0, minutos As Integer = 0

            For Each Drow As DataRow In dtDetalles.Rows
                Dim tiempoResp As String = Drow.Item("DetTiempo").ToString

                Dim y As Integer = 0

                For Each Letra As Object In tiempoResp
                    y += 1
                    If Letra = ":" Then
                        Exit For
                    End If
                Next

                segundos = segundos + Int(tiempoResp.Substring(y))
                minutos = minutos + Int(tiempoResp.Substring(0, y - 1))
            Next

            Dim MinFaltantes As Integer

            MinFaltantes = Int(segundos / 60)
            minutos = minutos + MinFaltantes
            segundos = (MinFaltantes * 60) - (segundos)
            segundos = segundos * (-1)
            '***************************************************  Tiempo total de examen ***************************

            If segundos < 10 Then
                If minutos < 10 Then
                    TiempoTotalExamen = "0" & minutos & ":0" & segundos
                Else
                    TiempoTotalExamen = minutos & ":0" & segundos
                End If
            Else
                If minutos < 10 Then
                    TiempoTotalExamen = "0" & minutos & ":" & segundos
                Else
                    TiempoTotalExamen = minutos & ":" & segundos
                End If
            End If

            dtDetalles.Clear()
        Catch ex As Exception
            MsgBox("Error calculando tiempo del examen número " & Cod_Examen & vbCrLf & vbCrLf & "Descripción: " & ex.Message)
        End Try

        '******************************************************  Respuestas Incorrectas ***************************
        RespuestasIncorrectas = PreguntasContestadas - RespuestasCorrectas

        '****************************************************** PUNTAJE ***************************
        Puntaje = Math.Round((RespuestasCorrectas * 100) / PreguntasTotales, 2)

    End Sub

    Dim btBoton As Button
    Public Sub Crear_Boton(ByVal Nombre As String, ByVal Alto As Integer, ByVal Ancho As Integer, ByVal Titulo As String, ByVal px As Integer, ByVal py As Integer)
        btBoton = New Button
        btBoton.Name = Nombre
        btBoton.Text = Titulo
        btBoton.Width = Ancho
        btBoton.Height = Alto
        btBoton.Top = py
        btBoton.Left = px
    End Sub


    Public Function ConvertirImagen(ByVal MiImagen As Image) As Byte()
        Dim Mistream As New MemoryStream()

        MiImagen.Save(Mistream, System.Drawing.Imaging.ImageFormat.Jpeg)

        Dim MiBytes(Mistream.Length - 1) As Byte
        Mistream.Position = 0

        Mistream.Read(MiBytes, 0, Mistream.Length)

        Return MiBytes

    End Function

End Module
