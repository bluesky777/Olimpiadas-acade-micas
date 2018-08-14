Imports System.Data
Imports System.Data.SqlClient

Public Class frmDetalleResultado

    Dim dtDetalles As New DataTable
    Dim Iniciado As Boolean = False
    Dim NoBuscar As Boolean = False
    Public ExaUsuABuscar() As Integer, BuscarUno As Boolean = False, BuscarSoloUno As Boolean = False


    Private Sub frmDetalleResultado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        PanelResultados.Visible = False

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

        DataDetalles.DataSource = dtDetalles

        Iniciado = True
        If BuscarUno = True Then
            cbUsuario.SelectedValue = ExaUsuABuscar(0)
        End If
        If BuscarSoloUno = True Then
            cbUsuario.SelectedValue = ExaUsuABuscar(0)
        End If
    End Sub

    Private Sub Actualizar()
        If Iniciado = True Then
            NoBuscar = False
            PanelResultados.Visible = False

            Try
                dtDetalles.Clear()
            Catch ex As Exception

            End Try


            Dim dtExaCodigos As New DataTable
            Dim resul As String
            resul = conn.Dato_String("UsuLogin", "tbUsuarios", "UsuNombre", cbUsuario.Text)

            conn.TraerTabla(dtExaCodigos, "select E.ExaId, STR(E.ExaId) + ' - ' + C.CatNombre as Categoria from tbExamenes E, tbCategorias C  where E.ExaLogin='" & resul & "' AND C.CatId =(SELECT C.CatId  FROM tbCategorias C where C.CatId =E.ExaCategoria)")


            cbExamen.DisplayMember = "Categoria"
            cbExamen.ValueMember = "ExaId"
            cbExamen.DataSource = dtExaCodigos

            If BuscarUno = True Then
                cbExamen.SelectedValue = ExaUsuABuscar(1)
                BuscarUno = False
            End If
            If BuscarSoloUno = True Then
                cbExamen.SelectedIndex = 0
                BuscarUno = False
            End If

        End If

    End Sub

    Private Sub cbUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbUsuario.SelectedIndexChanged
        Actualizar()
    End Sub

    Private Sub cbExamen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbExamen.SelectedIndexChanged
        Actualizar2()
    End Sub

    Private Sub Actualizar2()

        If cbExamen.Text <> "" Then

            Try
                dtDetalles.Clear()
            Catch ex As Exception
                'No pasa nada
            End Try

            conn.TraerTabla(dtDetalles, "SELECT t3.PregPregunta,t3.PregRespCorrecta,t2.DetContestada, " _
            & "Case t2.DetContestada " _
            & "when 'RespCorrec' then t3.PregRespCorrecta " _
            & "when 'Resp2' then t3.PregResp2 " _
            & "when 'Resp3' then t3.PregResp3 " _
            & "when 'Resp4' then t3.PregResp4 " _
            & "end AS 'Respuesta Contestada', t2.DetTiempo " _
            & "FROM tbUsuarios t0 " _
            & "JOIN tbExamenes t1 ON t1.ExaLogin = t0.UsuLogin " _
            & "JOIN tbDetalleExamen t2 ON t2.DetExamen  = t1.ExaId " _
            & "JOIN tbPreguntas t3 ON t3.PregId  = t2.DetPregunta " _
            & "where t2.DetExamen = '" & cbExamen.SelectedValue & "'")


        End If

        Resultados_Examen(cbExamen.SelectedValue)
        lbTotalPreg.Text = PreguntasTotales
        lbContestadas.Text = PreguntasContestadas
        lbRespCorrectas.Text = RespuestasCorrectas
        lbRespInorrectas.Text = RespuestasIncorrectas
        lbTiempo.Text = TiempoTotalExamen
        lbPuntaje.Text = Puntaje & "%"

        PanelResultados.Visible = True


    End Sub
End Class