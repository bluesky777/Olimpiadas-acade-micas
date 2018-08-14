Imports System.Data
Imports System.Data.SqlClient

Public Class frmPreguntas

    Dim dtPregu As New DataTable
    Dim Categoria As String
    Dim ActivaPreg As String
    Private mibinding As New BindingSource
    Public buscar As String = "No"
    Dim iniciado As Boolean = False

    Private Sub frmPreguntas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (MsgBox("¿Desea salir de la aplicación?", vbYesNo, "Seguridad") = vbYes) Then
            conn.EjecutarConsulta("delete from tbEquipos where EquiLogin='" & Login & "'")
            End
        Else
            e.Cancel = True
        End If

    End Sub


    Private Sub frmPreguntas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.Conectar()

        'Estoy en el evento 2013, pero estoy usando el código 2, esto solo si entro directamente al formulario frmUsuario
        If Yo.EvId = 0 Then
            Yo.EvId = 1
        End If

        cbCategorias.SelectAll()

        mibinding = New BindingSource

        AddHandler mibinding.PositionChanged, AddressOf CambiaPosicion

        Dim dtCats As New DataTable

        conn.TraerTabla(dtCats, "SELECT CatId as Cod, CatNombre as Nombre FROM tbCategorias")

        cbCategorias.DisplayMember = "Nombre"
        cbCategorias.ValueMember = "Cod"
        cbCategorias.DataSource = dtCats


        Dim dtCats2 As New DataTable

        conn.TraerTabla(dtCats2, "select CatId as Cod, CatNombre as Nombre FROM tbCategorias where CatEvento=" & Yo.EvId)

        cbCateg2.DisplayMember = "Nombre"
        cbCateg2.ValueMember = "Cod"
        cbCateg2.DataSource = dtCats2

        DataGridView1.DataSource = mibinding


        'Llenamos el combobox para el autocomplete

        conn.TraerTabla(dtPregu, "select P.PregId as Código, " _
            & " P.PregPregunta as Pregunta from tbPreguntas P, tbCatPreg where PrCaCategoria=" & cbCategorias.SelectedValue)


        cbBuscar.Text = ""

        Actualizar()

        For i As Integer = 0 To dtPregu.Rows.Count - 1
            cbBuscar.Items.Add(dtPregu.Rows(i).Item("Pregunta"))
        Next

        ActualizarPalabras()

        iniciado = True
    End Sub

    Private Sub cbCategorias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCategorias.SelectedIndexChanged
        If iniciado = True Then
            If btNuevo.Text = "Cancelar" Or btEditar.Text = "Cancelar" Then
                MsgBox("Debes terminar la edición.")
                Exit Sub
            End If
            buscar = "No"
            Actualizar()

        End If

    End Sub

    Public Sub Actualizar()

        Dim consulta As String = ""

        Select Case buscar
            Case "Si"
                consulta = "select P.PregId as Código," _
                        & " P.PregPregunta as Pregunta, P.PregRespCorrecta as 'Respuesta Correcta'," _
                        & " P.PregResp2 as 'Respuesta 2', P.PregResp3 as 'Respuesta 3'," _
                        & " P.PregResp4 as 'Respuesta 4', P.PregActiva as 'Activa' " _
                        & " from tbPreguntas P " _
                        & " where (P.PregId LIKE '%" & cbBuscar.Text & "%' or P.PregPregunta LIKE '%" & cbBuscar.Text & "%' or P.PregRespCorrecta LIKE '%" & cbBuscar.Text & "%' or P.PregResp2 LIKE '%" & cbBuscar.Text & "%' or P.PregResp3 LIKE '%" & cbBuscar.Text & "%' or P.PregResp4 LIKE '%" & cbBuscar.Text & "%')"
            Case "No"
                consulta = "select P.PregId as Código, " _
                        & " P.PregPregunta as Pregunta, P.PregRespCorrecta as 'Respuesta Correcta'," _
                        & " P.PregResp2 as 'Respuesta 2', P.PregResp3 as 'Respuesta 3'," _
                        & " P.PregResp4 as 'Respuesta 4', P.PregActiva as 'Activa' " _
                        & " from tbPreguntas P " _
                        & " where (P.PregId LIKE '%" & cbBuscar.Text & "%' or P.PregPregunta LIKE '%" & cbBuscar.Text & "%' or P.PregRespCorrecta LIKE '%" & cbBuscar.Text & "%' or P.PregResp2 LIKE '%" & cbBuscar.Text & "%' or P.PregResp3 LIKE '%" & cbBuscar.Text & "%' or P.PregResp4 LIKE '%" & cbBuscar.Text & "%')"

            Case "Una"
                consulta = "select P.PregId as Código, " _
                        & " P.PregPregunta as Pregunta, P.PregRespCorrecta as 'Respuesta Correcta'," _
                        & " P.PregResp2 as 'Respuesta 2', P.PregResp3 as 'Respuesta 3'," _
                        & " P.PregResp4 as 'Respuesta 4', P.PregActiva as 'Activa' " _
                        & " from tbPreguntas P  " _
                        & " where P.PregId=" & PreguntaABuscar
        End Select


        dtPregu.Clear()
        conn.TraerTabla(dtPregu, consulta)


        If buscar = "Una" Then
            cbCategorias.SelectedValue = dtPregu
        End If

        mibinding.DataSource = dtPregu
        Try
            DataGridView1.DataSource = mibinding
        Catch ex As Exception
            'No pasa nada
        End Try


        'No sé porque no funcionan estas modificaciones a las columnas
        DataGridView1.Columns.Item("Pregunta").FillWeight = 50

        Try
            lbId.DataBindings.Add("text", mibinding, "Código")
            txtPregunta.DataBindings.Add("text", mibinding, "Pregunta")
            txtRespCor.DataBindings.Add("text", mibinding, "Respuesta Correcta")
            txtResp2.DataBindings.Add("text", mibinding, "Respuesta 2")
            txtResp3.DataBindings.Add("text", mibinding, "Respuesta 3")
            txtResp4.DataBindings.Add("text", mibinding, "Respuesta 4")
            CheckBox1.DataBindings.Add("Checked", mibinding, "Activa")
        Catch ex As Exception
            'MsgBox(ex.Message)
            'No pasa nada
        End Try

        Try
            lbRegistros.Text = "Registro " & DataGridView1.CurrentCell.RowIndex + 1 & " de " & DataGridView1.Rows.Count
        Catch ex As Exception

        End Try



    End Sub


    Private Sub ActualizarTodas()
        Dim consulta As String
        consulta = "select P.PregId as Código, " _
                        & " P.PregPregunta as Pregunta, P.PregRespCorrecta as 'Respuesta Correcta'," _
                        & " P.PregResp2 as 'Respuesta 2', P.PregResp3 as 'Respuesta 3'," _
                        & " P.PregResp4 as 'Respuesta 4', P.PregActiva as 'Activa' " _
                        & " from tbPreguntas P "

        iniciado = False

        dtPregu.Clear()
        conn.TraerTabla(dtPregu, consulta)

        mibinding.DataSource = dtPregu

        iniciado = True
    End Sub

    Private Sub btNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNuevo.Click
        If btNuevo.Text = "Nuevo" Then
            mibinding.AddNew()
            ActualizarTodas()
            btNuevo.Text = "Cancelar"
            btEditar.Text = "Editar"
            btEditar.Enabled = False
            btGuardar.Enabled = True
            btEliminar.Enabled = False
            Activar(True)
            txtPregunta.Text = ""
            txtPregunta.Focus()
            txtRespCor.Text = ""
            txtResp2.Text = ""
            txtResp3.Text = ""
            txtResp4.Text = ""
            DataGridView1.Enabled = False
        Else
            mibinding.CancelEdit()
            btNuevo.Text = "Nuevo"
            btGuardar.Enabled = False
            btEliminar.Enabled = True
            btEditar.Enabled = True
            Activar(False)
            DataGridView1.Enabled = True
        End If



    End Sub

    Private Sub btGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGuardar.Click

        If btNuevo.Text = "Cancelar" Then
            conn.EjecutarConsulta("insert into tbPreguntas(PregPregunta, PregRespCorrecta, PregResp2, PregResp3, PregResp4, PregActiva)" _
                               & " values('" & txtPregunta.Text & "','" & txtRespCor.Text & "','" & txtResp2.Text & "','" _
                               & txtResp3.Text & "','" & txtResp4.Text & "', '" & CheckBox1.Checked & "')")

        Else
            conn.EjecutarConsulta("update tbPreguntas set PregPregunta='" & txtPregunta.Text & "', PregRespCorrecta='" & txtRespCor.Text & "',PregResp2='" & txtResp2.Text & "', PregResp3='" & txtResp3.Text & "', PregResp4='" & txtResp4.Text & "', PregActiva='" & CheckBox1.Checked & "' from tbPreguntas where PregId='" & lbId.Text & "'")
        End If

        btEliminar.Enabled = True

        btNuevo.Text = "Nuevo"
        btEditar.Text = "Editar"

        Dim posi As Integer
        posi = mibinding.Position

        Actualizar()

        mibinding.Position = posi

        Activar(False)
        DataGridView1.Enabled = True
    End Sub

    Private Sub btEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        If MsgBox("¿Seguro de eliminar esta pregunta?", vbYesNo, "Eliminar - Olimpiadas") = vbYes Then
            conn.EjecutarConsulta("delete from tbPreguntas where PregId = " & lbId.Text)

            Dim posi As Integer
            posi = mibinding.Position
            Actualizar()
            mibinding.Position = posi

        Else

        End If

        'DataGridView1.Refresh()
    End Sub

    Private Sub btEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditar.Click
        If btEditar.Text = "Editar" Then
            btEditar.Text = "Cancelar"
            btGuardar.Enabled = True
            btEliminar.Enabled = False
            Activar(True)
        Else
            btEditar.Text = "Editar"
            btGuardar.Enabled = False
            btEliminar.Enabled = True
            Activar(False)
        End If
    End Sub

    Private Sub Activar(ByVal sw As Boolean)

        txtPregunta.Enabled = sw
        txtRespCor.Enabled = sw
        txtResp2.Enabled = sw
        txtResp3.Enabled = sw
        txtResp4.Enabled = sw
        'chActivo.checked=sw

        If sw = False Then
            btEditar.Enabled = True
            btNuevo.Enabled = True
            btEliminar.Enabled = True
            btGuardar.Enabled = False

        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ActualizarTodas()
    End Sub



    Private Sub Flash1_FSCommand()
        Select Case ""
            Case "Ultimo"
                mibinding.MoveLast()
            Case "Anterior"
                If mibinding.Position = 0 Then
                    mibinding.MoveLast()
                Else
                    mibinding.MovePrevious()
                End If

            Case "Primero"
                mibinding.MoveFirst()
            Case "Siguiente"
                If mibinding.Position = mibinding.Count - 1 Then
                    mibinding.MoveFirst()
                Else
                    mibinding.MoveNext()
                End If
        End Select

        'If Button5.Text = "Cancelar" Then
        '    Button5.Text = "Nuevo"
        '    mibinding.CancelEdit()
        '    Bloquear()
        '    Button6.Enabled = True
        '    Button4.Enabled = False
        '    Button2.Enabled = True
        '    txtId.Focus()
        '    GridView1.Enabled = True
        '    ActualizarUsuarios()
        'End If
        'If Button6.Text = "Cancelar" Then
        '    Bloquear()
        '    Button6.Text = "Editar"
        '    Button4.Enabled = False
        '    Button2.Enabled = True
        '    GridView1.Enabled = True
        'End If

    End Sub

    Private Sub ActualizarPalabras() Handles txtPregunta.TextChanged, txtRespCor.TextChanged, txtResp2.TextChanged, txtResp3.TextChanged, txtResp4.TextChanged
        Try
            lbLenPreg.Text = 500 - Len(txtPregunta.Text) & "/" & 500
            lbLenCorr.Text = 250 - Len(txtRespCor.Text) & "/" & 250
            lbLen2.Text = 250 - Len(txtResp2.Text) & "/" & 250
            lbLen3.Text = 250 - Len(txtResp3.Text) & "/" & 250
            LbLen4.Text = 250 - Len(txtResp4.Text) & "/" & 250
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmAdministrador.Show()
        Me.Hide()
    End Sub

    Private Sub cbBuscar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBuscar.TextChanged
        If iniciado = True Then
            If btNuevo.Text = "Cancelar" Or btEditar.Text = "Cancelar" Then
                MsgBox("Debes terminar la edición.")
                Exit Sub
            End If

            buscar = "Si"
            Actualizar()

        End If

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Try
            lbRegistros.Text = "Registro " & DataGridView1.CurrentCell.RowIndex + 1 & " de " & DataGridView1.Rows.Count
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CambiaPosicion(sender As Object, e As EventArgs)

        If mibinding.Position <> -1 Then
            MostrarAsignaciones()
        End If

    End Sub


    Public Sub MostrarAsignaciones()

        For Each Contro As Control In Me.Controls
            If TypeOf (Contro) Is Categorias_Asignadas Then
                Contro.Dispose()
            End If
        Next


        If lbId.Text <> "" Then
            Dim LasAsign As New Categorias_Asignadas(lbId.Text, conn)
            Me.Controls.Add(LasAsign)

        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (conn.EjecutarConsulta("insert into tbCatPreg(PrCaPregunta, PrCaCategoria) " _
                      & " values(" & lbId.Text & ", " & cbCateg2.SelectedValue & ");")) = True Then
            MostrarAsignaciones()
            MsgBox("Asignada a " & cbCateg2.Text)

        End If
    End Sub
End Class