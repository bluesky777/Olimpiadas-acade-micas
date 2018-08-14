Public Class modExamen
    Inherits ModBase

    ' Campos extras que son muy comunes cuando se pide un examen
    Public pregContestadas As Integer
    Public pregTotales As Integer
    Public respCorrectas As Integer
    Public respIncorrectas As Integer
    Public tiempoTotal As String
    Public totalScore As Integer = 0


    Dim dtDetalles As New DataTable


    ' Guardo las referencia a los controles donde mostraré los valores del examen
    Dim ctIdExam As Control
    Dim ctPregContestadas As Control
    Dim ctPregTotales As Control
    Dim ctRespCorrectas As Control
    Dim ctRespIncorrectas As Control
    Dim ctTiempoTotal As Control
    Dim ctTotalScore As Control

#Region "Contructores"

    Sub New(Codigo As Integer)
        MyBase.New(Codigo)
        Me.Id = Codigo
        'Me.CalcularExamen()
    End Sub

    Sub New()
        MyBase.New()
    End Sub

    Public Overrides Sub Starting()

        Me.TableName = "Examenes"
        Me.Prefix = "Exa"

        Me.addForeign("ExaInscripcion", "Inscripciones", "InsId")
        Me.addForeign("ExaTipoExamen", "TipoExamen", "TeId")
    End Sub

#End Region



    Public Sub DatagridByEvCatEntidad(ByRef gridExamenes As DataGridView, Optional idCat As Integer = 0, Optional idEnt As Integer = 0, _
                                      Optional SoloFinalistas As Boolean = False)

        Dim dtExamenes As DataTable
        Dim dtNewExamenes As New DataTable

        dtExamenes = Me.GetByEvCatEntidad(idCat, idEnt)
        dtExamenes.Columns.Add("Duración")

        dtNewExamenes.Columns.Add("No")
        For Each columna As DataColumn In dtExamenes.Columns
            dtNewExamenes.Columns.Add(columna.ColumnName)
        Next

        Dim catTempRecorrer As String = ""
        Dim Cont As Integer = 0
        Dim FilasTitulo As New ArrayList

        For Each row As DataRow In dtExamenes.Rows

            Cont += 1

            If row.Item("Categoría") <> catTempRecorrer Then

                If catTempRecorrer <> "" Then
                    'Añadimos dos columnas de espacio
                    dtNewExamenes.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "", "")
                    dtNewExamenes.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "", "")
                End If

                catTempRecorrer = row.Item("Categoría")
                Cont = 1

                'Añadimos una columna título de categoría con un True que estará oculto para el recorrido que hará la exportación en excel
                dtNewExamenes.Rows.Add("", "", "True", row.Item("Categoría"), "", "", "", "", "", "", "", "", "", "")
                FilasTitulo.Add(dtNewExamenes.Rows.Count - 1)
            End If


            ' Arreglamos la duración
            Dim tiempoFormated As String = FormatTimeToDisplay(row.Item("Tiempo"))
            Dim puntajeString As String = row.Item("Puntaje").ToString

            Dim posicion As Integer = puntajeString.IndexOf(",")
            Dim puntaje As Integer = 0

            If posicion <> -1 Then
                puntaje = puntajeString.Substring(0, posicion)
            End If


            If Cont < 2 And SoloFinalistas = True Then
                dtNewExamenes.Rows.Add(Cont, row.Item("Id"), row.Item("UsuId"), row.Item("Usuario"), row.Item("Entidad"), row.Item("InsId"), _
                                                   row.Item("Alias categoría"), row.Item("Categoría"), row.Item("Preguntas"), row.Item("Correctas"), _
                                                   row.Item("Incorrectas"), "", puntaje & "%", tiempoFormated)
            ElseIf SoloFinalistas = False Then
                dtNewExamenes.Rows.Add(Cont, row.Item("Id"), row.Item("UsuId"), row.Item("Usuario"), row.Item("Entidad"), row.Item("InsId"), _
                                                  row.Item("Alias categoría"), row.Item("Categoría"), row.Item("Preguntas"), row.Item("Correctas"), _
                                                  row.Item("Incorrectas"), "", puntaje & "%", tiempoFormated)

            End If


        Next


        gridExamenes.DataSource = dtNewExamenes

        Me.FixGridExamenes(gridExamenes, FilasTitulo)

    End Sub

    Public Function GetByEvCatEntidad(Optional idCat As Integer = 0, Optional idEnt As Integer = 0, _
                                      Optional SoloFinalistas As Boolean = False, Optional Examenes As String = "") As DataTable


        Dim condicionCategoria As String = ""
        If idCat <> 0 Then
            condicionCategoria = " AND CatId = " & idCat
        End If


        Dim condicionEntidad As String = ""
        If idEnt <> 0 Then
            condicionEntidad = " AND EntId = " & idEnt
        End If


        Dim ForaneasDeseadas As ModBase() = {New modInscripciones}
        'ForaneasDeseadas.Add("ExaInscripcion")

        Dim colDeseadas As String
        colDeseadas = "ExaId as Id, UsuId, UsuNombre as Usuario, EntNombreCorto as Entidad, InsId, CatNombreCorto as 'Alias categoría', " _
            & "CatNombre as Categoría, ExaCantPreg as Preguntas, Puntos as 'Correctas', (ExaCantPreg - Puntos) as 'Incorrectas', " _
            & "Tiempo, ((Puntos * 100) / ExaCantPreg) as Puntaje  "

        Dim fromAgregado(2) As String
        fromAgregado(0) = " (select d.DetExamen, SUM(  case DetContestada	when 'RespCorrec' then 1 end) as Puntos, SUM(DetTiempo) as Tiempo from tbDetalleExamen d group by d.DetExamen ) p"
        fromAgregado(1) = " p.DetExamen = ExaId "

        Dim Query As String
        Query = Me.createQuery(colDeseadas, " CatEvento=" & m_Eventos.Id & " AND ExaTipoExamen=" & m_Eventos.Row.Item("EvTipoExamen") _
                               & condicionCategoria & condicionEntidad & Examenes _
                               & " ORDER BY CatNombreCorto ASC, Puntaje DESC, Tiempo ASC, CatNombre, EntNombre", ForaneasDeseadas, fromAgregado)

        Dim dtExamenes As DataTable = conn.TraerTabla(Query)

        Return dtExamenes
    End Function



    Public Sub DatagridByEvento(ByRef gridExamenes As DataGridView, Optional SoloFinalistas As Boolean = False)

        Dim dtExamenes As DataTable
        Dim dtNewExamenes As New DataTable

        dtExamenes = Me.GetByEvento()
        dtExamenes.Columns.Add("Duración")

        dtNewExamenes.Columns.Add("No")
        For Each columna As DataColumn In dtExamenes.Columns
            dtNewExamenes.Columns.Add(columna.ColumnName)
        Next

        Dim catTempRecorrer As String = ""
        Dim Cont As Integer = 0
        Dim FilasTitulo As New ArrayList

        For Each row As DataRow In dtExamenes.Rows

            Cont += 1

            If row.Item("Categoría") <> catTempRecorrer Then

                If catTempRecorrer <> "" Then
                    'Añadimos dos columnas de espacio
                    dtNewExamenes.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "", "")
                    dtNewExamenes.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "", "")
                End If

                catTempRecorrer = row.Item("Categoría")
                Cont = 1

                'Añadimos una columna título de categoría con un True que estará oculto para el recorrido que hará la exportación en excel
                dtNewExamenes.Rows.Add("", "", "True", row.Item("Categoría"), "", "", "", "", "", "", "", "", "", "")
                FilasTitulo.Add(dtNewExamenes.Rows.Count - 1)
            End If


            ' Arreglamos la duración
            Dim tiempoFormated As String = FormatTimeToDisplay(row.Item("Tiempo"))
            Dim puntajeString As String = row.Item("Puntaje").ToString

            Dim posicion As Integer = puntajeString.IndexOf(",")
            Dim puntaje As Integer = 0

            If posicion <> -1 Then
                puntaje = puntajeString.Substring(0, posicion)
            End If


            If Cont < 2 And SoloFinalistas = True Then
                dtNewExamenes.Rows.Add(Cont, row.Item("Id"), row.Item("UsuId"), row.Item("Usuario"), row.Item("Entidad"), row.Item("InsId"), _
                                                   row.Item("Alias categoría"), row.Item("Categoría"), row.Item("Preguntas"), row.Item("Correctas"), _
                                                   row.Item("Incorrectas"), "", puntaje & "%", tiempoFormated)
            ElseIf SoloFinalistas = False Then
                dtNewExamenes.Rows.Add(Cont, row.Item("Id"), row.Item("UsuId"), row.Item("Usuario"), row.Item("Entidad"), row.Item("InsId"), _
                                                   row.Item("Alias categoría"), row.Item("Categoría"), row.Item("Preguntas"), row.Item("Correctas"), _
                                                   row.Item("Incorrectas"), "", puntaje & "%", tiempoFormated)
            End If


        Next


        gridExamenes.DataSource = dtNewExamenes
        Me.FixGridExamenes(gridExamenes, FilasTitulo)

    End Sub

    Private Function GetByEvento() As DataTable

        Dim ForaneasDeseadas As ModBase() = {New modInscripciones}
        'ForaneasDeseadas.Add("ExaInscripcion")

        Dim colDeseadas As String
        colDeseadas = "ExaId as Id, UsuId, UsuNombre as Usuario, EntNombreCorto as Entidad, InsId, CatNombreCorto as 'Alias categoría', " _
            & "CatNombre as Categoría, ExaCantPreg as Preguntas, Puntos as 'Correctas', (ExaCantPreg - Puntos) as 'Incorrectas', " _
            & "Tiempo, ((Puntos * 100) / ExaCantPreg) as Puntaje  "

        Dim fromAgregado(2) As String
        fromAgregado(0) = " (select d.DetExamen, SUM(case DetContestada	when 'RespCorrec' then 1 end) as Puntos, SUM(DetTiempo) as Tiempo from tbDetalleExamen d group by d.DetExamen ) p"
        fromAgregado(1) = " p.DetExamen = ExaId "

        Dim Query As String
        Query = Me.createQuery(colDeseadas, "CatEvento=" & m_Eventos.Id & " AND ExaTipoExamen=" & m_Eventos.Row.Item("EvTipoExamen") _
                               & " ORDER BY CatNombreCorto ASC, Puntaje DESC, Tiempo ASC", ForaneasDeseadas, fromAgregado)

        Dim dtExamenes As DataTable = conn.TraerTabla(Query)

        Return dtExamenes
    End Function



    Private Sub FixGridExamenes(ByRef gridExamenes As DataGridView, filasTitulo As ArrayList)

        With gridExamenes

            .Font = New Font("Arial", 10)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .EditMode = DataGridViewEditMode.EditProgrammatically
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            .Columns("InsId").HeaderText = "Id inscrip"

            .Columns("No").FillWeight = 40
            .Columns.Item("Usuario").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader

            .Columns("Id").Visible = False
            .Columns("InsId").Visible = False
            .Columns("UsuId").Visible = False
            .Columns("Categoría").Visible = False
            .Columns("Tiempo").Visible = False

        End With


        For Each FilaTit As Integer In FilasTitulo
            gridExamenes.Rows(FilaTit).Cells(3).Style.BackColor = Color.Gray
            gridExamenes.Rows(FilaTit).DefaultCellStyle.ForeColor = Color.White
            gridExamenes.Rows(FilaTit).Cells(3).Style.Font = New Font("Calibri", 13, FontStyle.Bold)

        Next
    End Sub




    Private Sub FormatAllTimeStringToSeg()

        Dim dtDetalles As New DataTable

        conn.TraerTabla(dtDetalles, "Select DetId, D.DetTiempo from tbDetalleExamen D")

        Dim segundos As Integer = 0, SegMinutos As Integer = 0, SegTotal As Integer = 0

        For Each Drow As DataRow In dtDetalles.Rows
            Dim tiempoResp As String = Drow.Item("DetTiempo").ToString

            Dim y As Integer = 0

            For Each Letra As Object In tiempoResp
                y += 1
                If Letra = ":" Then
                    Exit For
                End If
            Next

            segundos = Int(tiempoResp.Substring(y))
            SegMinutos = Int(tiempoResp.Substring(0, y - 1)) * 60
            SegTotal = segundos + SegMinutos

            conn.EjecutarConsulta("UPDATE tbDetalleExamen set DetTiempo =" & SegTotal & " where DetId = " & Drow.Item("DetId").ToString)
        Next
    End Sub



#Region "CALCULAR EXAMEN CON CADA UNO DE SUS CAMPOS"


    Public Sub CalcularExamen()

        Me.pregContestadas = Me.HallarPreguntasContestadas(Me.Id)

        Me.pregTotales = Me.HallarTotalPreguntas(Me.Id)

        Me.respCorrectas = Me.HallarRespuestasCorrectas(Me.Id)

        Me.tiempoTotal = Me.TiempoDelTest(Me.Id)

        Me.respIncorrectas = Me.pregContestadas - Me.respCorrectas

        Me.totalScore = Me.CalcularTotalScore()

    End Sub


    Public Shared Function formatTime(minutos As Integer, segundos As Integer) As String

        Dim TiempoFormateado As String


        If segundos < 10 Then
            If minutos < 10 Then
                TiempoFormateado = "0" & minutos & ":0" & segundos
            Else
                TiempoFormateado = minutos & ":0" & segundos
            End If
        Else
            If minutos < 10 Then
                TiempoFormateado = "0" & minutos & ":" & segundos
            Else
                TiempoFormateado = minutos & ":" & segundos
            End If
        End If

        Return TiempoFormateado
    End Function

    Public Function TiempoDelTest(ByVal id_Examen As Integer)

        '************************************ Hallamos el tiempo qué duró el test ***************************

        dtDetalles.Clear()
        conn.TraerTabla(dtDetalles, "Select D.DetTiempo from tbDetalleExamen D where D.DetExamen=" & id_Examen)

        Dim segundos As Integer = 0


        'Recorremos los tiempos de cada pregunta y los sumamos

        For Each Drow As DataRow In dtDetalles.Rows
            Dim tiempoResp As Integer = Drow.Item("DetTiempo")
            segundos += tiempoResp
        Next

        Dim tiempo_exam As String = FormatTimeToDisplay(segundos)

        dtDetalles.Clear()

        Return tiempo_exam
    End Function


    Public Shared Function FormatTimeToDisplay(Segundos As Integer) As String
        Dim formatedTime As String
        Dim minutos As Integer
        Dim segundosExtras As Integer

        minutos = Math.Floor(Segundos / 60)
        segundosExtras = Segundos - (minutos * 60)

        formatedTime = formatTime(minutos, segundosExtras)

        Return formatedTime
    End Function


    Public Function HallarPreguntasContestadas(ByVal id_Examen) As String

        '***************************************************  Preguntas  Contestadas ***************************
        dtDetalles.Clear()
        conn.TraerTabla(dtDetalles, "Select count(D.DetPregunta) as CantContestadas, count(D.DetContestada) as CantCorrec from tbDetalleExamen D where D.DetExamen=" & id_Examen)

        Dim preguntas_contestadas As String = dtDetalles.Rows(0).Item("CantContestadas").ToString
        dtDetalles.Clear()

        Return preguntas_contestadas
    End Function

    Public Function HallarTotalPreguntas(ByVal id_Examen) As String

        '***************************************************  Total Preguntas  ************************************
        dtDetalles.Clear()
        conn.TraerTabla(dtDetalles, "Select E.ExaCantPreg  from tbExamenes E where E.ExaId=" & id_Examen)
        Try
            Dim preguntas As String = dtDetalles.Rows(0).Item("ExaCantPreg").ToString
            dtDetalles.Clear()

            Return preguntas
        Catch ex As Exception

        End Try

    End Function

    Public Function HallarRespuestasCorrectas(ByVal id_Examen) As String

        '***************************************************  Respuestas Correctas  ***************************
        dtDetalles.Clear()
        conn.TraerTabla(dtDetalles, "Select count(DetContestada) as CantPreg, count(DetContestada) as CantCorrec from tbDetalleExamen where DetExamen=" & id_Examen & " AND DetContestada='RespCorrec';")

        Dim respuestas_correctas As String = dtDetalles.Rows(0).Item("CantPreg").ToString
        dtDetalles.Clear()

        Return respuestas_correctas
    End Function

    Public Function CalcularTotalScore() As Integer

        '***************************************************  Respuestas Correctas  ***************************
        Dim puntaje_total As Integer = 0
        If Me.pregTotales <> 0 Then
            puntaje_total = Math.Round(((Me.respCorrectas * 100) / Me.pregTotales), 1)
        End If

        Return puntaje_total
    End Function

#End Region

    Public Sub MapControles(ByRef Total_Preg As Control, ByRef Contestadas As Control, ByRef resp_correctas As Control, ByRef resp_incorrectas As Control, ByRef tiempo As Control, ByRef puntaje As Control)

        Me.ctPregTotales = Total_Preg
        Me.ctPregContestadas = Contestadas
        Me.ctRespCorrectas = resp_correctas
        Me.ctRespIncorrectas = resp_incorrectas
        Me.ctTiempoTotal = tiempo
        Me.ctTotalScore = puntaje

    End Sub



    Public Sub FillMappedControls()
        Me.ctPregTotales.Text = Me.pregTotales
        Me.ctPregContestadas.Text = Me.pregContestadas
        Me.ctRespCorrectas.Text = Me.respCorrectas
        Me.ctRespIncorrectas.Text = Me.respIncorrectas
        Me.ctTiempoTotal.Text = Me.tiempoTotal
        Me.ctTotalScore.Text = Me.totalScore
    End Sub

    Public Function fixTable(ByRef dTableToFix) As DataTable

        With dTableToFix
            
            ' Columnas extras que no están en la tabla tbExamenes de la BD
            .Columns.Add("Tiempo")
            .Columns.Add("Correctas")
            .Columns.Add("Incorrectas")
            .Columns.Add("Total")
            .Columns.Add("Puntaje")
        End With


        For Each fila As DataRow In dTableToFix.Rows

            ' Objeto examen que calcula puntaje y más
            Dim id_Exa As Integer = fila.Item("ExaId").ToString
            m_Examenes.Id = id_Exa
            m_Examenes.CalcularExamen()

            'fila.Item("Id usu") = m_Inscripciones 

            ' Añadimos los calculos a la tabla examenes
            fila.Item("Tiempo") = m_Examenes.tiempoTotal
            fila.Item("Correctas") = m_Examenes.respCorrectas
            fila.Item("Incorrectas") = m_Examenes.respIncorrectas
            fila.Item("Total") = m_Examenes.pregTotales
            fila.Item("Puntaje") = m_Examenes.totalScore & "%"

        Next

        Return dTableToFix
    End Function


End Class
