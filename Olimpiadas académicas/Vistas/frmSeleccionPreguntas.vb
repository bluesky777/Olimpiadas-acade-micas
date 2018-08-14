Imports System.Data
Imports System.Data.SqlClient

Public Class frmSeleccionPreguntas

    Dim salir As Boolean = False
    Dim Iniciado As Boolean = False

    Private Sub frmSeleccionPreguntas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frmSeleccionPreguntas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        conn.Conectar()

        LlenarCategorias()

        cbCategoria.Text = "Seleccione..."

        Iniciado = True
    End Sub

    Dim dtPreguntas As New DataTable
    Dim dtSeleccion As New DataTable

    Private Sub ActualizarListas()

        dtPreguntas.Rows.Clear()
        dtSeleccion.Rows.Clear()
        
        conn.TraerTabla(dtPreguntas, "select PregId, PregPregunta from tbPreguntas, tbCatPreg " _
                                & " where (PrCaCategoria=" & cbCategoria.SelectedValue & " and PrCaPregunta=PregId ) " _
                                & " AND (PregActiva='True') AND PregId NOT IN (select PregId from tbPreguntas, tbCatPreg where PrCaPregunta=PregId and PrCaParaExamen=1 and PrCaCategoria=" & cbCategoria.SelectedValue & ")")

        conn.TraerTabla(dtSeleccion, "Select p.PregId as Codigo, p.PregPregunta as Pregunta from tbPreguntas p, tbCatPreg c " _
                                & " where p.PregId=c.PrCaPregunta and PrCaParaExamen=1 and PrCaParaExamen=1 AND  c.PrCaCategoria=" & cbCategoria.SelectedValue)




        ListBox1.DisplayMember = "PregPregunta"
        ListBox1.ValueMember = "PregId"
        ListBox1.DataSource = dtPreguntas

        ListBox2.DisplayMember = "Pregunta"
        ListBox2.ValueMember = "Codigo"
        ListBox2.DataSource = dtSeleccion

        lbTotal1.Text = "Total: " & ListBox1.Items.Count
        lbTotal2.Text = "Total: " & ListBox2.Items.Count

        If ListBox1.Items.Count = 0 Then
            ListBox1.DataSource = Nothing
            ListBox1.Items.Add("---No hay preguntas agregadas---")
        End If
        If ListBox2.Items.Count = 0 Then
            ListBox2.DataSource = Nothing
            ListBox2.Items.Add("---No hay preguntas agregadas---")
        End If

    End Sub


    Private Sub cbCategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCategoria.SelectedValueChanged
        If Iniciado = True Then

            ActualizarListas()

        End If

    End Sub

    Private Sub LlenarCategorias()
        Dim dtCategorias As New DataTable

        'ERRROOOORRRRRRRRRRR  POR EL EVENTO QUE ES ESTATICO
        conn.TraerTabla(dtCategorias, "Select CatId, CatNombre from tbCategorias where CatEvento=2")

        'Lleno el combobox con las categorias
        cbCategoria.DisplayMember = "CatNombre"
        cbCategoria.ValueMember = "CatId"
        cbCategoria.DataSource = dtCategorias
        'cbCategoria.SelectedIndex = 0
    End Sub


    Private Sub btAgregarSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAgregarSel.Click
        AgregarSeleccionados()
    End Sub

    Private Sub btQuitarSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuitarSel.Click
        QuitarSeleccionados()
    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        AgregarSeleccionados()
    End Sub

    Private Sub ListBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.DoubleClick
        QuitarSeleccionados()
    End Sub


    Private Sub AgregarSeleccionados()
        If ListBox1.Items(0).ToString = "---No hay preguntas agregadas---" Then
            Exit Sub
        End If

        For Each Objeto As DataRowView In ListBox1.SelectedItems

            'cmdSeleccion = New SqlCommand("insert into tbSeleccion values(" & cbCategoria.SelectedValue & "," & Objeto.Row(0).ToString & ", ABS (CAST(CAST(NEWID() as binary(2)) AS INT)% 4 + 1))", cnn)

            If (conn.EjecutarConsulta("update tbCatPreg set PrCaParaExamen=1, PrCaOrden=ABS (CAST(CAST(NEWID() as binary(2)) AS INT)% 4 + 1) where PrCaCategoria=" & cbCategoria.SelectedValue & " and PrCaPregunta=" & Objeto.Row(0).ToString)) = False Then

            End If

        Next

        ActualizarListas()
    End Sub

    Private Sub QuitarSeleccionados()
        If ListBox2.Items(0).ToString = "---No hay preguntas agregadas---" Then
            Exit Sub
        End If

        For Each Objeto As DataRowView In ListBox2.SelectedItems
            'Dim Fila As DataRow = Objeto.Row '***Esto podía servir

            conn.EjecutarConsulta("update tbCatPreg set PrCaParaExamen=0 where PrCaCategoria=" & cbCategoria.SelectedValue & " AND PrCaPregunta=" & Objeto.Row(0).ToString)

        Next

        ActualizarListas()
    End Sub


    Private Sub btQuitarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuitarTodo.Click
        QuitarTodo()
    End Sub

    Private Sub QuitarTodo()
        If ListBox2.Items(0).ToString = "---No hay preguntas agregadas---" Then
            Exit Sub
        End If

        conn.EjecutarConsulta("update tbCatPreg set PrCaParaExamen=0 where PrCaCategoria=" & cbCategoria.SelectedValue)

        ActualizarListas()
    End Sub

    Private Sub btAgregarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAgregarTodo.Click
        If ListBox1.Items(0).ToString = "---No hay preguntas agregadas---" Then
            Exit Sub
        End If

        For Each Objeto As DataRowView In ListBox1.Items

            conn.EjecutarConsulta("update tbCatPreg set PrCaParaExamen=1, PrCaOrden=ABS (CAST(CAST(NEWID() as binary(2)) AS INT)% 4 + 1) " _
                                  & " where PrCaCategoria=" & cbCategoria.SelectedValue & " and PrCaPregunta" & Objeto.Row(0).ToString)
        Next

        ActualizarListas()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        salir = True
        frmAdministrador.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        QuitarTodo()
        If ListBox1.Items(0).ToString = "---No hay preguntas agregadas---" Then
            Exit Sub
        End If

        Dim dtAlea As New DataTable

        conn.TraerTabla(dtAlea, "Select top(" & NumCant.Value & ") PregId, PrCaCategoria from tbPreguntas, tbCatPreg " _
                        & " where PregActiva='True' AND PrCaPregunta=PregId and  PrCaCategoria=" & cbCategoria.SelectedValue & " order by NEWID()")


        For Each Fila As DataRow In dtAlea.Rows
            conn.EjecutarConsulta("update tbCatPreg set PrCaParaExamen=1, PrCaOrden=ABS (CAST(CAST(NEWID() as binary(2)) AS INT)% 4 + 1)" _
                                  & " where PrCaCategoria=" & cbCategoria.SelectedValue & " and PrCaPregunta=" & Fila(0))
        Next

        ActualizarListas()
    End Sub

    Private Sub RepuestasAleatorias()
        conn.EjecutarConsulta("UPDATE tbSeleccion SET SelOrden =  ABS (CAST(CAST(NEWID() as binary(2)) AS INT)% 4) + 1 where SelCategoria = " & cbCategoria.SelectedValue)
    End Sub


End Class