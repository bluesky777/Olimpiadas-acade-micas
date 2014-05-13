
Public Class frmResult2

    Dim CriteriosBusqueda As String = ""
    Dim ConsultaBuscar As String
    Dim miToolTip As New ToolTip
    Dim dtDetalles As New DataTable
    Dim Iniciado As Boolean = False
    Dim SoloEntidad As Boolean = False


    Private Sub frmResult2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '****************************************************
        ''******        PRIMER TAB      *********************
        '****************************************************
        LlenarEventos()

        llenarEntidades()

        txtFechaIni.Format = DateTimePickerFormat.Custom
        txtFechaIni.CustomFormat = "dddd dd MMM hh:mm"
        txtFechaIni.Text = DateAdd(DateInterval.Day, -1, Date.Now)

        txtFechaFin.Format = DateTimePickerFormat.Custom
        txtFechaFin.CustomFormat = "dddd dd MMM hh:mm"
        txtFechaFin.Text = Date.Now

        Me.miToolTip.IsBalloon = True


        '****************************************************
        ''******        PRIMER TAB      *********************
        '****************************************************
        PanelResultados.Visible = False
        DataDetalles.DataSource = dtDetalles


        Dim dtUsuarios As New DataTable

        conn.TraerTabla(dtUsuarios, "select U.UsuNombre, U.UsuId from tbUsuarios U")

        With cbUsuario
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .DisplayMember = "UsuNombre"
            .ValueMember = "UsuId"
            .DataSource = dtUsuarios
            .Text = ""
        End With

        lbTextoDetExa.Text = "Aquí puede ver en detalle los resultados de cada participante. Debe ser cuidadoso " _
            & vbCrLf & "de no permitir que alguien vea las preguntas y respuestas aquí expuestas."


        m_Examenes.MapControles(lbTotalPreg, lbContestadas, lbRespCorrectas, lbRespInorrectas, lbTiempo, lbPuntaje)

        Iniciado = True


    End Sub

    Private Sub LlenarEventos()
        Dim dtEventos As New DataTable

        conn.TraerTabla(dtEventos, "select EvId, (EvActual + '- ' + EvNombre ) as Evento, EvActual from tbEventos")

        cbEvento.DataSource = dtEventos
        cbEvento.DisplayMember = "Evento"
        cbEvento.ValueMember = "EvId"

        Dim EvAc() As DataRow = dtEventos.Select("EvActual='Actual'")

        cbEvento.SelectedValue = EvAc(0)("EvId").ToString


    End Sub


    Private Sub cbEvento_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbEvento.SelectedValueChanged

        LlenarCategoriasGeneral()

    End Sub

    Private Sub LlenarCategoriasGeneral()
        Dim dtCat As New DataTable
        Try
            conn.TraerTabla(dtCat, "select CatId, CatNombre from tbCategorias where CatEvento=" & cbEvento.SelectedValue)
            cbCategoria.DataSource = dtCat
            cbCategoria.DisplayMember = "CatNombre"
            cbCategoria.ValueMember = "CatId"
        Catch ex As Exception

        End Try



    End Sub



    Private Sub llenarEntidades()
        Dim dtEnti As New DataTable

        conn.TraerTabla(dtEnti, "select EntId, EntNombre from tbEntidades")
        cbEntidades.DataSource = dtEnti
        cbEntidades.DisplayMember = "EntNombre"
        cbEntidades.ValueMember = "EntId"

    End Sub

    Private Sub btBuscarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscarDatos.Click

        CriteriosBusqueda = ""

        'Verificamos los criterios de busqueda
        If CkEntidad.Checked = True Then
            SoloEntidad = True
            CriteriosBusqueda = " and en.EntId=" & cbEntidades.SelectedValue
        End If

        If CkCategoria.Checked = True Then
            SoloEntidad = False
            CriteriosBusqueda += " and c.CatId=" & cbCategoria.SelectedValue
        End If


        If CkFecha.Checked = True Then
            SoloEntidad = False
            CriteriosBusqueda += "  and ex.ExaFecha >='" & txtFechaIni.Value & "' and ex.ExaFecha <= '" & txtFechaFin.Value & "'"
        End If




        '************************************************************************
        ''******        CAMBIE EL TIPO DE EXAMEN!!!      ************************
        '************************************************************************
        ConsultaBuscar = "select ExaId, u.UsuId, UsuNombre, EntNombreCorto, InsId, CatNombreCorto, CatNombre, ExaCantPreg " _
                        & "from tbEventos ev, tbCategorias c, tbInscripciones i, tbExamenes ex, tbEntidades en, " _
                        & "tbUsuarios u " _
                        & "where ev.EvId=c.CatEvento and c.CatId=i.InsCategoria and i.InsId=ex.ExaInscripcion and ExaTipoExamen= 1 " _
                        & "and u.UsuId=i.InsUsuario " _
                        & "and en.EntId=i.InsEntidad " & CriteriosBusqueda



        ' Si solo seleccionó la busqueda por Entidad, organizamos los resultados por categoría
        If SoloEntidad = True Then
            ConsultaBuscar += " order by CatNombreCorto"
        End If



        Dim dtExam As New DataTable
        conn.TraerTabla(dtExam, ConsultaBuscar)

        With dtExam
            .Columns.Add("Tiempo")
            .Columns.Add("Correctas")
            .Columns.Add("Incorrectas")
            .Columns.Add("Total")
            .Columns.Add("Puntaje")
        End With

        For Each fila As DataRow In dtExam.Rows
            m_Examenes.Id = fila.Item("ExaId").ToString

            fila.Item("Tiempo") = m_Examenes.tiempoTotal
            fila.Item("Correctas") = m_Examenes.respCorrectas
            fila.Item("Incorrectas") = m_Examenes.respIncorrectas
            fila.Item("Total") = m_Examenes.pregTotales
            fila.Item("Puntaje") = m_Examenes.totalScore & "%"

        Next


        'For Each drow As DataRow In dtExam.Rows
        '    dtExam.Select("Entidad", "Asc")
        'Next



        'If dtExam.Rows.Count = 0 Then
        '    lbReferencia.Text = "No se han realizado exámenes."
        '    Exit Sub
        'End If

        Dim dtExamenMod As New DataTable

        With dtExamenMod
            .Columns.Add("No")
            .Columns.Add("ID")
            .Columns.Add("Usu")
            .Columns.Add("Nombre")
            .Columns.Add("Entidad")
            .Columns.Add("IdIns") 'Esta como index 6
            .Columns.Add("Categoría")
            .Columns.Add("Tiempo")
            .Columns.Add("Correctas")
            .Columns.Add("Incorrectas")
            .Columns.Add("Total")
            .Columns.Add("PUNTAJE") ', Type.GetType("System.Double")

        End With

        DataExamenes.DataSource = dtExamenMod

        With DataExamenes
            .Font = New Drawing.Font("Arial", 10)
            .Columns.Item("No").FillWeight = 20
            .Columns.Item("ID").FillWeight = 1
            .Columns.Item("Usu").FillWeight = 1

            .Columns.Item("Nombre").FillWeight = 170
            .Columns.Item("Nombre").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("Nombre").HeaderCell.Style.Font = New Font("Arial", 11, FontStyle.Bold)
            .Columns.Item("Nombre").DefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Italic)

            .Columns.Item("Entidad").FillWeight = 50
            .Columns.Item("idIns").FillWeight = 1
            .Columns.Item("Categoría").FillWeight = 50

            .Columns.Item("Tiempo").FillWeight = 60
            .Columns.Item("Tiempo").HeaderCell.Style.Font = New Font("Arial", 9)


            .Columns.Item("Correctas").FillWeight = 50
            .Columns.Item("Correctas").HeaderCell.Style.Font = New Font("Arial", 9)

            .Columns.Item("Incorrectas").FillWeight = 50
            .Columns.Item("Incorrectas").HeaderCell.Style.Font = New Font("Arial", 9)

            .Columns.Item("Total").FillWeight = 50

            .Columns.Item("PUNTAJE").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("PUNTAJE").HeaderCell.Style.Font = New Font("Arial", 11, FontStyle.Bold)
            .Columns.Item("PUNTAJE").DefaultCellStyle.Font = New Font("Arial", 11, FontStyle.Bold)
        End With


        Dim catTempRecorrer As String = ""
        Dim Cont As Integer = 0
        Dim FilasTitulo As New ArrayList

        For Each DRow As DataRow In dtExam.Rows
            Cont += 1

            'Si se está consultado solo por Entidad....
            If SoloEntidad = True Then

                ' Si pasamos  a los examenes de la otra categoría, entonces hacemos espacios y...
                If catTempRecorrer <> DRow.Item("CatNombreCorto") Then

                    catTempRecorrer = DRow.Item("catNombreCorto")
                    Cont = 1

                    'Añadimos dos columnas de espacio
                    dtExamenMod.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "")
                    dtExamenMod.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "")
                    'Añadimos una columna título de categoría con un True que estará oculto para el recorrido que hará la exportación en excel
                    dtExamenMod.Rows.Add("", "True", "", DRow.Item("CatNombre"), "", "", "", "", "", "", "", "")
                    FilasTitulo.Add(dtExamenMod.Rows.Count - 1)
                End If


            End If

            Try
                m_Examenes.Id = DRow.Item("ExaId").ToString
                m_Examenes.CalcularExamen()

                dtExamenMod.Rows.Add(Cont, DRow.Item("ExaId").ToString, DRow.Item("UsuId").ToString, DRow.Item("UsuNombre").ToString, _
                                     DRow.Item("EntNombreCorto").ToString, DRow.Item("InsId").ToString, DRow.Item("CatNombreCorto").ToString, _
                                     m_Examenes.tiempoTotal, m_Examenes.respCorrectas, m_Examenes.respIncorrectas, _
                                     m_Examenes.pregTotales, m_Examenes.totalScore & "%")

            Catch ex As Exception
                MsgBox("Error de consulta resultados: " & ex.Message)
            End Try
        Next

        For i As Integer = 0 To DataExamenes.Columns.Count - 1
            DataExamenes.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next


        For Each FilaTit As Integer In FilasTitulo
            DataExamenes.Rows(FilaTit).Cells(3).Style.BackColor = Color.Gray
            DataExamenes.Rows(FilaTit).DefaultCellStyle.ForeColor = Color.White
            DataExamenes.Rows(FilaTit).Cells(3).Style.Font = New Font("Calibri", 13, FontStyle.Bold)

        Next


        If CkEntidad.Checked = True Then
            desactivarSort(DataExamenes)
        Else
            ActivarSort(DataExamenes)
        End If


    End Sub

    Private Sub CkEntidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkEntidad.CheckedChanged
        If CkEntidad.Checked = True Then
            cbEntidades.Enabled = True
        Else
            cbEntidades.Enabled = False
        End If
    End Sub

    Private Sub CkCategoria_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkCategoria.CheckedChanged
        If CkCategoria.Checked = True Then
            cbCategoria.Enabled = True
        Else
            cbCategoria.Enabled = False
        End If
    End Sub

    Private Sub CkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkFecha.CheckedChanged
        If CkFecha.Checked = True Then
            GroupFechas.Enabled = True
        Else
            GroupFechas.Enabled = False
        End If
    End Sub


    Private Sub txtFechaIni_TypeValidationCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.TypeValidationEventArgs)
        If (Not e.IsValidInput) Then
            Me.miToolTip.ToolTipTitle = "Fecha invalida"
            Me.miToolTip.Show("La fecha debe tener el formato especificado mm/dd/yyyy hh:mm.", Me.txtFechaIni, 0, -70, 5000)
        Else

            ''Para validar que no sea mayor que hoy
            'Dim UserDate As DateTime = CDate(e.ReturnValue)
            'If (UserDate > DateTime.Now) Then
            '    Me.miToolTip.ToolTipTitle = "Fecha invalida"
            '    Me.miToolTip.Show("La fecha debe ser menor de hoy.", Me.txtFechaIni, 0, -70, 5000)
            '    e.Cancel = True
            'End If
        End If
    End Sub

    Private Sub txtFechaFin_TypeValidationCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.TypeValidationEventArgs)
        If (Not e.IsValidInput) Then
            Me.miToolTip.ToolTipTitle = "Fecha invalida"
            Me.miToolTip.Show("La fecha debe tener el formato especificado mm/dd/yyyy hh:mm.", Me.txtFechaFin, 0, -70, 5000)
        End If
    End Sub


    Private Sub btVerDetExa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVerDetExa.Click
        TabControl1.SelectedIndex = 1
    End Sub


    Private Sub DataExamenes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataExamenes.CellDoubleClick


        ' Si el usuario dió doble click sobre un lugar invalido del Datagrid salimos de la rutina
        If e.RowIndex = -1 Then
            Exit Sub
        End If


        If DataExamenes.Rows(e.RowIndex).Cells("IdIns").Value = "" Then
            Exit Sub
        End If

        If e.RowIndex = -1 Then
            Exit Sub
        End If

        cbUsuario.SelectedValue = DataExamenes.Rows(e.RowIndex).Cells("Usu").Value
        LtCategoria.SelectedValue = DataExamenes.Rows(e.RowIndex).Cells("IdIns").Value
        LtExamenes.SelectedValue = DataExamenes.Rows(e.RowIndex).Cells("ID").Value

        TabControl1.SelectedIndex = 1
    End Sub


    Private Sub cbUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbUsuario.SelectedIndexChanged

        LlenarCategoriasUsuario()

    End Sub


    Private Sub LlenarCategoriasUsuario()
        If Iniciado = False Then
            Exit Sub
        End If
        'NoBuscar = False
        PanelResultados.Visible = False

        Try
            dtDetalles.Clear()
        Catch ex As Exception

        End Try

        Dim dtCategorias As New DataTable

        conn.TraerTabla(dtCategorias, "select InsId, CatNombre from tbInscripciones, tbCategorias U " _
                        & " where InsCategoria=CatId and InsUsuario=" & cbUsuario.SelectedValue)

        With LtCategoria
            .DisplayMember = "CatNombre"
            .ValueMember = "InsId"
            .DataSource = dtCategorias
        End With



    End Sub

    Private Sub LlenarListaExamenes()

        Dim dtExamenes As New DataTable

        conn.TraerTabla(dtExamenes, "select E.ExaId, STR(Num) + '.  ' + CONVERT(VARCHAR(24), E.ExaFecha, 100)  as Examen " _
                & " FROM tbExamenes E, (select ExaId, ROW_NUMBER() OVER(order by ExaId) as Num " _
                    & " from tbExamenes where ExaInscripcion='" & LtCategoria.SelectedValue & "') as n  " _
                & " where n.ExaId=E.ExaId")


        With LtExamenes
            .DisplayMember = "Examen"
            .ValueMember = "ExaId"
            .DataSource = dtExamenes
        End With



    End Sub

    Private Sub LtCategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LtCategoria.SelectedIndexChanged
        LlenarListaExamenes()
    End Sub


    Private Sub LtExamenes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LtExamenes.SelectedIndexChanged
        ActualizarDataUsu()
    End Sub

    Private Sub ActualizarDataUsu()

        Try
            dtDetalles.Clear()
        Catch ex As Exception

        End Try

        conn.TraerTabla(dtDetalles, "SELECT num as 'No', t4.PregPregunta as Pregunta, t4.PregRespCorrecta as Correcta, " _
        & "Case t3.DetContestada " _
        & "when 'RespCorrec' then 'CORRECTA' " _
        & "else  t3.DetContestada " _
        & "end as 'Opcion Contestada', " _
        & "Case t3.DetContestada " _
        & "when 'RespCorrec' then t4.PregRespCorrecta " _
        & "when 'Resp2' then t4.PregResp2 " _
        & "when 'Resp3' then t4.PregResp3 " _
        & "when 'Resp4' then t4.PregResp4 " _
        & "end AS 'Respuesta Contestada', t3.DetTiempo as Tiempo " _
        & "FROM (select DetExamen, DetPregunta, ROW_NUMBER() OVER(order by DetId) as num from tbDetalleExamen " _
            & "where DetExamen='" & LtExamenes.SelectedValue & "') AS Orden, " _
        & "tbUsuarios t0 " _
        & "JOIN tbInscripciones t1 ON t0.UsuId=t1.InsUsuario " _
        & "JOIN tbExamenes t2 ON t2.ExaInscripcion=t1.InsId " _
        & "JOIN tbDetalleExamen t3 ON t3.DetExamen  = t2.ExaId " _
        & "JOIN tbPreguntas t4 ON t4.PregId  = t3.DetPregunta " _
        & "where t3.DetExamen = '" & LtExamenes.SelectedValue & "' " _
        & " and Orden.DetExamen=t3.DetExamen  and Orden.DetPregunta=t4.PregId ;")


        With DataDetalles
            .Columns.Item("No").FillWeight = 30
            .Columns.Item("Pregunta").FillWeight = 150
            .Columns.Item("Correcta").FillWeight = 30
            .Columns.Item("Opcion Contestada").FillWeight = 80
            .Columns.Item("Opcion Contestada").HeaderCell.Style.Font = New Font("Arial", 10)
            .Columns.Item("Opcion Contestada").DefaultCellStyle.Font = New Font("Arial", 10)
            .Columns.Item("Opcion Contestada").DefaultCellStyle.BackColor = Color.AliceBlue

            .Columns.Item("Respuesta Contestada").FillWeight = 70

            .Columns.Item("Tiempo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("Tiempo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns.Item("Respuesta Contestada").HeaderCell.Style.Font = New Font("Arial", 10)
            .Columns.Item("Respuesta Contestada").DefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Strikeout)
            .Columns.Item("Respuesta Contestada").DefaultCellStyle.ForeColor = Color.Gray

            .Columns.Item("Correcta").HeaderCell.Style.Font = New Font("Arial", 10)
            .Columns.Item("Correcta").DefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Strikeout)
            .Columns.Item("Correcta").DefaultCellStyle.ForeColor = Color.Gray

        End With


        m_Examenes.Id = LtExamenes.SelectedValue
        m_Examenes.CalcularExamen()
        m_Examenes.FillMappedControls()

        PanelResultados.Visible = True

    End Sub




    Private Sub btReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReporte.Click

        Dim exporta As New classExportarExcel

        exporta.GridAExcel(DataExamenes)


    End Sub

    Private Sub btEliminarExa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEliminarExa.Click

        If DataExamenes.SelectedRows.Count > 1 Then
            If (MsgBox("¿Seguro que desea eliminar las " & DataExamenes.SelectedRows.Count & " filas seleccionadas?", vbYesNo, "Confirmar")) <> vbYes Then
                Exit Sub
            End If

        ElseIf DataExamenes.SelectedRows.Count = 1 Then
            If (MsgBox("¿Seguro que desea eliminar el examen de " & DataExamenes.Rows(DataExamenes.CurrentRow.Index).Cells("Nombre").Value & "?", vbYesNo, "Confirmar")) <> vbYes Then
                Exit Sub
            End If
        Else
            MsgBox("Debe seleccionar al menos un examen para eliminar.")
            Exit Sub
        End If



        For Each row As DataGridViewRow In DataExamenes.SelectedRows

            Dim Codigo As Integer

            Codigo = row.Cells("Id").Value

            conn.EjecutarConsulta("delete from tbDetalleExamen where DetExamen=" & Codigo)
            conn.EjecutarConsulta("delete from tbExamenes where ExaId=" & Codigo)

            DataExamenes.Rows.Remove(row)

        Next


        MsgBox("Eliminación exitosa.")

    End Sub

    Private Sub desactivarSort(ByRef dataGridView As DataGridView)
        'Desactivamos el ordenamiento del DataGrid
        For Each colum As DataGridViewColumn In dataGridView.Columns
            colum.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Private Sub ActivarSort(ByRef dataGridView As DataGridView)
        'Activamos el ordenamiento Automático
        For Each colum As DataGridViewColumn In dataGridView.Columns
            colum.SortMode = DataGridViewColumnSortMode.Automatic
        Next
    End Sub

End Class