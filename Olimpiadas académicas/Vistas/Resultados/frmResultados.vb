Imports System
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class frmResultados

    Dim salir As Boolean = False
    Dim iniciado As Boolean = False
    Dim dtCategorias As New DataTable
    Dim dtColegios As New DataTable

    Private Sub frmResultados_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        frmDetalleResultado.Close()
    End Sub

    Private Sub frmResultados_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If salir = False Then
            Dim opc As DialogResult = MsgBox("¿Desea cerrar la aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir - IGAD")

            If opc = Windows.Forms.DialogResult.Yes Then
                conn.EjecutarConsulta("delete from tbEquipos where EquiLogin='" & Login & "'")
                End
            Else
                e.Cancel = True
            End If
        End If
    End Sub


    Private Sub frmResultados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        rbAmbos.Checked = True


        conn.TraerTabla(dtCategorias, "Select CatNombre, CatId from tbCategorias")

        With cbCategorias
            .DataSource = dtCategorias
            .DisplayMember = "CatNombre"
            .ValueMember = "CatId"
            .SelectedValue = 0
        End With

        conn.TraerTabla(dtColegios, "Select EntId, EntNombre from tbEntidades")
        With cbEntidad
            .DataSource = dtColegios
            .DisplayMember = "EntNombre"
            .ValueMember = "EntId"
            .SelectedValue = 0
        End With

        iniciado = True
        'actualizar()
    End Sub

    Private Sub actualizar()

        lbReferencia.Text = "Aquí pueden verse los examenes realizados hasta el momento."

        Dim dtExamen As New DataTable
        dtable.Dispose()

        Try
            DataGridExamen.DataSource = dtExamen
        Catch ex As Exception

        End Try

        Dim enti As String, cate As String
        If cbCategorias.Text <> "" Then
            cate = cbCategorias.SelectedValue
        Else
            cate = -1
        End If
        If cbEntidad.Text <> "" Then
            enti = cbEntidad.SelectedValue
        Else
            enti = -1
        End If



        If rbAmbos.Checked = True Then
            conn.TraerTabla(dtable, "select C.CatNombreCorto, E.ExaFecha, E.ExaId, E.ExaInscripcion, U.UsuNombre, Col.ColNombreCorto " _
                                         & "from tbCategorias C,tbExamenes E, tbUsuarios U, tbEntidades Ent where U.UsuLogin=E.ExaLogin " _
                                         & "and C.CatId=E.ExaCategoria and Col.ColId=U.UsuColegio " _
                                         & "and E.ExaCategoria=" & cate & " AND col.ColId=" & enti & " AND E.ExaFecha > '" & DateInicio.Value & "' AND E.ExaFecha < '" & DateFinal.Value & "'")
        ElseIf rbCategoria.Checked = True Then
            conn.TraerTabla(dtable, "select C.CatNombreCorto, E.ExaFecha, E.ExaId, E.ExaLogin, U.UsuNombre, Col.ColNombreCorto " _
                                             & "from tbCategorias C,tbExamenes E, tbUsuarios U, tbEntidades Col where U.UsuLogin=E.ExaLogin " _
                                             & "and C.CatId=E.ExaCategoria and Col.ColId=U.UsuColegio " _
                                             & "and E.ExaCategoria=" & cate & " AND E.ExaFecha > '" & DateInicio.Value & "' AND E.ExaFecha < '" & DateFinal.Value & "'")
        Else
            conn.TraerTabla(dtable, "select C.CatNombreCorto, E.ExaFecha, E.ExaId, E.ExaLogin, U.UsuNombre, Col.ColNombreCorto " _
                     & "from tbCategorias C,tbExamenes E, tbUsuarios U, tbEntidades Col where U.UsuLogin=E.ExaLogin " _
                     & "and C.CatId=E.ExaCategoria and Col.ColId=U.UsuColegio " _
                     & "and col.ColId=" & cate & " AND col.ColId=" & enti & " AND E.ExaFecha > '" & DateInicio.Value & "' AND E.ExaFecha < '" & DateFinal.Value & "'")

        End If



        If dtable.Rows.Count = 0 Then
            lbReferencia.Text = "No se han realizado exámenes."
            Exit Sub
        End If

        dtExamen.Columns.Add("No")
        dtExamen.Columns.Add("ID")
        dtExamen.Columns.Add("Colegio")
        dtExamen.Columns.Add("Fecha")
        dtExamen.Columns.Add("Nombre")
        dtExamen.Columns.Add("Tiempo")
        dtExamen.Columns.Add("Correctas")
        dtExamen.Columns.Add("Incorrectas")
        dtExamen.Columns.Add("Total")
        dtExamen.Columns.Add("PUNTAJE")

        DataGridExamen.Font = New Drawing.Font("Arial", 15)
        DataGridExamen.Columns.Item("No").FillWeight = 20
        DataGridExamen.Columns.Item("Colegio").FillWeight = 70
        DataGridExamen.Columns.Item("ID").FillWeight = 20
        DataGridExamen.Columns.Item("Nombre").FillWeight = 250
        DataGridExamen.Columns.Item("Nombre").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dim Cont As Integer = 0
        For Each DRow As DataRow In dtable.Rows
            Cont += 1

            Resultados_Examen(DRow.Item("ExaId").ToString)

            Try
                ', DRow.Item("CatNombreCorto").ToString         Agrego esta porción después de usuNombre si quiero que aparezca
                dtExamen.Rows.Add(Cont, DRow.Item("ExaId").ToString, DRow.Item("ColNombreCorto").ToString, DRow.Item("ExaFecha").ToString, DRow.Item("UsuNombre").ToString, TiempoTotalExamen, RespuestasCorrectas, RespuestasIncorrectas, PreguntasTotales, Puntaje & "%")

            Catch ex As Exception
                MsgBox("Error de consulta resultados: " & ex.Message)
            End Try
        Next

        For i As Integer = 0 To DataGridExamen.Columns.Count - 1
            DataGridExamen.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        salir = True
        frmAdministrador.Show()
        Me.Close()
    End Sub

    Private Sub btReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReporte.Click
        'MsgBox("No está disponible en esta versión.")
        GridAExcel(DataGridExamen)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (MsgBox("¿Seguro que desea eliminar el examen de " & DataGridExamen.Rows(DataGridExamen.CurrentRow.Index).Cells("Nombre").Value & "?", vbYesNo, "Confirmar")) = vbYes Then

            Dim Codigo As String

            For Each row As DataGridViewRow In DataGridExamen.Rows
                If row.Selected Then
                    Codigo = row.Cells("Id").Value

                    conn.EjecutarConsulta("delete from tbDetalleExamen where DetExamen=" & Codigo)
                    conn.EjecutarConsulta("delete from tbExamenes where ExaId=" & Codigo)

                End If
            Next
            MsgBox("Examenes eliminados.")
            actualizar()
        End If

    End Sub

    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables
        Dim exApp As New Excel.Application
        Dim exLibro As Excel.Workbook
        Dim exHoja As Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()


            'Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try

        Return True

    End Function



    Private Sub DataGridExamen_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridExamen.CellDoubleClick
        Try
            Dim LoginSelec As String = conn.Dato_String("ExaLogin", "tbExamenes", "ExaId", DataGridExamen.Rows(e.RowIndex).Cells("ID").Value)
            Dim CodUsuSelec As Integer = conn.Dato_String("UsuId", "tbUsuarios", "UsuLogin", LoginSelec)
            frmDetalleResultado.ExaUsuABuscar = New Integer() {CodUsuSelec, DataGridExamen.Rows(e.RowIndex).Cells("ID").Value}
            frmDetalleResultado.BuscarUno = True
            frmDetalleResultado.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmDetalleResultado.Show()
    End Sub

    Private Sub DataGridExamen_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridExamen.CellContentClick

    End Sub


    Private Sub rbCategoria_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCategoria.CheckedChanged
        If iniciado = True Then
            If rbCategoria.Checked = True Then
                cbEntidad.Visible = False
                lbColeg.Visible = False
            Else
                cbEntidad.Visible = True
                lbColeg.Visible = True
            End If
        End If

    End Sub

    Private Sub rbColegio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbColegio.CheckedChanged
        If iniciado = True Then
            If rbColegio.Checked = True Then
                cbCategorias.Visible = False
                lbCateg.Visible = False
            Else
                cbCategorias.Visible = True
                lbCateg.Visible = True
            End If
        End If

    End Sub

    Private Sub rbAmbos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAmbos.CheckedChanged
        If rbAmbos.Checked = True Then
            cbCategorias.Visible = True
            lbCateg.Visible = True

            cbEntidad.Visible = True
            lbColeg.Visible = True
            If cbCategorias.Text <> "" And cbEntidad.Text <> "" Then
                actualizar()
            End If
        End If
    End Sub

    Private Sub cbColegio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEntidad.SelectedIndexChanged
        If iniciado = True Then
            If rbColegio.Checked = True Or (cbCategorias.Text <> "") Then
                actualizar()
            End If
        End If
    End Sub


    Private Sub cbCategorias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCategorias.SelectedIndexChanged
        If iniciado = True Then
            If rbCategoria.Checked = True Or (cbEntidad.Text <> "") Then
                actualizar()
            End If
        End If
    End Sub

    Private Sub btBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscar.Click
       
        actualizar()

    End Sub
End Class