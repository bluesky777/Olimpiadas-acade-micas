Imports System.Data
Imports System.Text
Imports System.Data.SqlClient

Imports System.Net


Public Class frmAdministrador


    Dim salir As Boolean = False
    Dim Iniciado As Boolean = False

    Private Sub frmAdministrador_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If salir = False Then
            Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

            If opc = Windows.Forms.DialogResult.Yes Then
                m_UsuarioAuth.CerrarSesion()
            Else
                e.Cancel = True
            End If

        End If

    End Sub

  


    Private Sub frmAdministrador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Llamo el inicializador de las tablas
        If m_UsuarioAuth Is Nothing Then
            InicializarVariables()
            m_UsuarioAuth.Auth("admin", "purito", 2) 'Logueo de prueba como participante
        End If

        Me.Width = 900
        Me.Height = 700

        ListUsuarios.SelectionMode = SelectionMode.MultiExtended

        'LlenarPreguntas()


        ActualizarConectados()

        LlenarMenuPrincipal()

        DatosEvento()


        'Exit Sub

        'MisTools()

        Iniciado = True

    End Sub




    Private Sub LlenarPreguntas()
        Dim dtPreg As New DataTable 'Falta ordenar las preguntas

        If Iniciado = True Then
            Try
                conn.TraerTabla(dtPreg, "Select PregId as Código, PregPregunta as Pregunta from tbPreguntas INNER JOIN tbCatPreg ON PregId=PrCaPregunta where PrCaCategoria=" & cbCategoria.SelectedValue.ToString)
                GridPreguntas.DataSource = dtPreg

                GridPreguntas.Columns.Item("Código").Width = 30
                GridPreguntas.Columns.Item("Pregunta").Width = 500
                GridPreguntas.Font = New Font("Arial", 7)
                GridPreguntas.RowHeadersVisible = False
            Catch ex As Exception

            End Try

        End If



    End Sub

    Private Sub ActualizarConectados()

        Dim mEquipos As New modEquipos
        mEquipos.mapList(ListUsuarios, "Equipo", "EquiId", "EquiId, (EquiIP + ' - ' + UsuNombre + ' - ' + EquiNombre) as Equipo")

    End Sub


    Private Sub LlenarMenuPrincipal()

        Dim dtEventos As New DataTable

        conn.TraerTabla(dtEventos, "SELECT * FROM tbEventos")

        For i As Integer = 0 To dtEventos.Rows.Count - 1

            If dtEventos.Rows(i).Item("EvActual") = "Actual" Then

                UsuariosToolStripMenuItem.DropDownItems.Add(dtEventos.Rows(i).Item("EvNombre"), Nothing, New EventHandler(AddressOf Click_SubMenuEvento))
                'UsuariosToolStripMenuItem.DropDownItems.Add(dtEventos.Rows(i).Item("EvNombre") & " - Evento actual", Nothing, New EventHandler(AddressOf Click_SubMenuEvento))

                lbCodEvent.Text = dtEventos.Rows(i).Item("EvId")

            Else
                UsuariosToolStripMenuItem.DropDownItems.Add(dtEventos.Rows(i).Item("EvNombre"), Nothing, New EventHandler(AddressOf Click_SubMenuEvento))
            End If

            UsuariosToolStripMenuItem.DropDownItems.Item(i).ToolTipText = dtEventos.Rows(i).Item("EvDescrip")
            UsuariosToolStripMenuItem.DropDownItems.Item(i).Image = My.Resources.LogoAOL
            UsuariosToolStripMenuItem.DropDownItems.Item(i).AutoToolTip = True

        Next

    End Sub



    Private Sub Click_SubMenuEvento(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim item As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)

        MsgBox("Toma " & item.Text & "  -  " & sender.ToString)
    End Sub




    Private Sub ReiniciarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReiniciarSesiónToolStripMenuItem.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        salir = True
        Me.Close()
    End Sub

    Private Sub DatosEvento()

        
        '***********************************************
        'Organizamos los controles
        '************************************************

        lbTituloEvento.Text = m_Eventos.Row.Item("EvNombre")
        lbTituloEvento.Top = MenuPrincipal.Height + ToolStripAdmin.Height + 5
        lbTituloEvento.Left = Me.Width / 2 - lbTituloEvento.Width / 2
        lbTituloEvento.MaximumSize = New System.Drawing.Size(820, 30)

        txtEvento.Text = m_Eventos.Row.Item("EvNombre")
        txtEvento.Visible = False


        ' Movemos el logo a la izquierda del título de evento
        PctLogoEvento.Top = MenuPrincipal.Height + ToolStripAdmin.Height + 3
        PctLogoEvento.Width = 60
        PctLogoEvento.Height = 50
        PctLogoEvento.Left = lbTituloEvento.Left - PctLogoEvento.Width - 5


        ' Descripción como subtítulo del formulario
        lbDescripEven.Text = m_Eventos.Row.Item("EvDescrip")
        lbDescripEven.Top = lbTituloEvento.Top + lbTituloEvento.Height
        lbDescripEven.Left = Me.Width / 2 - lbDescripEven.Width / 2
        lbDescripEven.MaximumSize = New System.Drawing.Size(700, 50)

        txtDescripcion.Text = m_Eventos.Row.Item("EvDescrip")
        txtDescripcion.Visible = False


        lbEvActivo.Text = m_Eventos.Row.Item("EvActivo")

        ' Establezco si el tiempo de los examenes en eliminatoria será establecido por la categoría o por la configuración del evento
        CkTiempoTodos.Checked = m_Eventos.Row.Item("EvParaTodos")


        ' Fechas del evento
        lbFechIni.Text = m_Eventos.Row.Item("EvFechaInicio")
        lbFechIni.Left = 100
        lbFechIni.Top = 88
        DateFechaInicio.Value = m_Eventos.Row.Item("EvFechaInicio")
        DateFechaInicio.Left = 200
        DateFechaInicio.Top = 88
        DateFechaInicio.Visible = False


        lbFechFin.Text = m_Eventos.Row.Item("EvFechaFin")
        lbFechFin.Left = 100
        lbFechFin.Top = 115
        DateFechaFin.Value = m_Eventos.Row.Item("EvFechaFin")
        DateFechaFin.Left = 200
        DateFechaFin.Top = 115
        DateFechaFin.Visible = False



        nuTiempoPreg.Value = m_Eventos.Row.Item("EvSegundosPregMax")
        nuTiempoExa.Value = m_Eventos.Row.Item("EvMinutosTotalMax")


        If m_Eventos.Row.Item("EvPermisoEmpezar") = 0 Then
            lbPermisoEmpezar.Text = "No"
        Else
            lbPermisoEmpezar.Text = "Si"
        End If



        If (m_Eventos.Row.Item("EvActual") = "Actual") Then
            lbEvActual.Text = "EVENTO ACTUAL"
        Else
            lbEvActual.Text = "No Actual"
            lbEvActual.ForeColor = Color.Red
        End If





        '************************************************
        'Llenamos los paneles
        '************************************************

        'Llenamos los combos
        m_Categorias.mapCombo(cbCategoria, "CatNombre", "CatId", , "CatEvento=" & m_Eventos.Id)
        m_TipoExamen.mapCombo(cbTipoExamen, "TeTipo", "TeId")
        cbTipoExamen.SelectedValue = m_Eventos.Row.Item("EvTipoExamen")

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmUsuario.Show()

    End Sub

    Private Sub btDelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDelAll.Click

        If (MsgBox("Si elimina los registros de los equipos conectados, tendrá que pedirle a todos los usuarios que reinicien sesion.", vbYesNoCancel, "¿Está seguro?") = vbYes) Then
            m_UsuarioAuth.Equipo.Delete("EquiId != " & m_UsuarioAuth.Equipo.Id)
            ActualizarConectados()
        End If

    End Sub

    Private Sub ExportarPreguntasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarPreguntasToolStripMenuItem.Click
        frmExportarPreguntas.Show()
    End Sub

    Private Sub ImportarPreguntasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarPreguntasToolStripMenuItem.Click
        frmImportarPregs.Show()
    End Sub

    Private Sub btRevisarExamenes_Click(sender As Object, e As EventArgs)
        frmResult2.Show()
    End Sub

    Private Sub btIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmManagerChat.Show()
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs)
        frmPreguntas.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ActualizarConectados()
    End Sub

 
    Private Sub btDelSeleccionados_Click(sender As Object, e As EventArgs) Handles btDelSeleccionados.Click
        For Each itemselec As DataRowView In ListUsuarios.SelectedItems
            m_UsuarioAuth.Equipo.Delete("EquiId = " & itemselec.Item(0))
            ActualizarConectados()
        Next
    End Sub

    Private Sub cbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoria.SelectedIndexChanged
        
        LlenarPreguntas()

    End Sub

    Private Sub btGuardarConf_Click_1(sender As Object, e As EventArgs) Handles btGuardar.Click
        Dim actual As String
        If lbEvActual.Text = "EVENTO ACTUAL" Then
            actual = "Actual"
        Else
            actual = "No Actual"
        End If

        Dim Permiso As Integer
        If lbEvActual.Text = "Si" Then
            Permiso = 1
        Else
            Permiso = 0
        End If

        Dim consulta As String = "UPDATE tbEventos SET EvNombre='" & lbTituloEvento.Text & "', EvFechaInicio='" & lbFechIni.Text & "', EvFechaFin='" _
                              & lbFechFin.Text & "', EvDescrip='" & lbDescripEven.Text & "', EvActivo='" & lbEvActivo.Text & "', EvActual='" & actual _
                              & "', EvParaTodos='" & CkTiempoTodos.Checked & "', EvPermisoEmpezar='" & Permiso _
                              & "', EvTipoExamen='" & cbTipoExamen.SelectedValue & "', EvMinutosTotalMax='" & nuTiempoExa.Value _
                              & "', EvSegundosPregMax='" & nuTiempoPreg.Value & "', EvLogo='' where EvId = " & m_Eventos.Id


        If conn.EjecutarConsulta(consulta) = True Then
            MsgBox("Datos guardados con éxito.", MsgBoxStyle.Information, "IGAD")
            m_Eventos.getActual()
        End If

        DatosEvento()
        ComprobarValoresDefault()
    End Sub

    Private Sub lbFechIni_Click(sender As Object, e As EventArgs) Handles lbFechIni.Click
        With DateFechaInicio
            .Text = DateFechaInicio.Text
            .Visible = True
            .Left = 100
            .Top = 88
            .Focus()
        End With

    End Sub

    Private Sub lbFechFin_Click(sender As Object, e As EventArgs) Handles lbFechFin.Click
        With DateFechaFin
            .Text = DateFechaFin.Text
            .Visible = True
            .Left = 100
            .Top = 115
            .Focus()
            ComprobarValoresDefault()
        End With

    End Sub

    Private Sub DateFechaInicio_KeyDown(sender As Object, e As KeyEventArgs) Handles DateFechaInicio.KeyDown
        With DateFechaInicio
            If e.KeyCode = Keys.Enter Then
                lbFechIni.Text = .Value.ToString("dd/MM/yyyy")
                .Left = 200
                .Top = 88
                .Visible = False
            ElseIf e.KeyCode = Keys.Escape Then
                .Value = lbFechIni.Text
                .Left = 200
                .Top = 88
                .Visible = False
            End If
            ComprobarValoresDefault()
        End With
    End Sub


    Private Sub DateFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles DateFechaInicio.ValueChanged

    End Sub

    Private Sub DateFechaFin_KeyDown(sender As Object, e As KeyEventArgs) Handles DateFechaFin.KeyDown
        With DateFechaFin
            If e.KeyCode = Keys.Enter Then
                lbFechFin.Text = .Value.ToString("dd/MM/yyyy")
                .Left = 200
                .Top = 115
                .Visible = False
            ElseIf e.KeyCode = Keys.Escape Then
                .Value = lbFechFin.Text
                .Left = 200
                .Top = 115
                .Visible = False
            End If
            ComprobarValoresDefault()
        End With
    End Sub

    Private Sub DateFechaFin_ValueChanged(sender As Object, e As EventArgs) Handles DateFechaFin.ValueChanged

    End Sub

    Private Sub ToolStripBtPregutas_Click(sender As Object, e As EventArgs) Handles ToolStripBtPreguntas.Click
        frmPreguntas.Show()

    End Sub

    Private Sub BtSeleccionPreg_Click(sender As Object, e As EventArgs) Handles BtSeleccionPreg.Click
        frmSeleccionPreguntas.Show()
    End Sub

    Private Sub ToolStripBtResultados_Click(sender As Object, e As EventArgs) Handles ToolStripBtResultados.Click
        frmExamenes.Show()
    End Sub

    Private Sub ToolStripBtIniciarPruebas_Click(sender As Object, e As EventArgs) Handles ToolStripBtIniciarPruebas.Click
        'frmManagerChat.Show()
        frmAdminEvento.Show()
        Me.Hide()
    End Sub

    Private Sub ResultadosConFechasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResultadosConFechasToolStripMenuItem.Click
        frmResult2.Show()
    End Sub

    Private Sub ResultadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResultadosToolStripMenuItem.Click
        frmExamenes.Show()
    End Sub

    Private Sub lbTituloEvento_Click(sender As Object, e As EventArgs) Handles lbTituloEvento.Click
        With txtEvento
            .Text = lbTituloEvento.Text
            .Top = lbTituloEvento.Top
            .Left = lbTituloEvento.Left
            .Visible = True
            .Focus()
            ComprobarValoresDefault()
        End With


    End Sub

    Private Sub txtEvento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEvento.KeyDown
        With txtEvento
            If e.KeyCode = Keys.Enter Then
                .Visible = False
                lbTituloEvento.Text = .Text
            ElseIf e.KeyCode = Keys.Escape Then
                .Visible = False
                .Text = lbTituloEvento.Text
            End If
            ComprobarValoresDefault()
        End With
    End Sub


    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        With txtDescripcion
            If e.KeyCode = Keys.Enter Then
                .Visible = False
                lbDescripEven.Text = .Text
            ElseIf e.KeyCode = Keys.Escape Then
                .Visible = False
                .Text = lbDescripEven.Text
            End If
            ComprobarValoresDefault()
        End With
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub lbDescripEven_Click(sender As Object, e As EventArgs) Handles lbDescripEven.Click
        With txtDescripcion
            .Text = lbDescripEven.Text
            .Top = lbDescripEven.Top
            .Left = lbDescripEven.Left
            .Visible = True
            .Focus()
            ComprobarValoresDefault()
        End With
    End Sub

    Private Sub btRestablecer_Click(sender As Object, e As EventArgs) Handles btRestablecer.Click
        DatosEvento()
    End Sub

    Private Sub ToolStripBtUsuarios_Click(sender As Object, e As EventArgs) Handles ToolStripBtUsuarios.Click
        frmUsuario.Show()
    End Sub

    Private Sub lbEvActivo_Click(sender As Object, e As EventArgs) Handles lbEvActivo.Click
        If lbEvActivo.Text = True Then
            lbEvActivo.Text = False
        Else
            lbEvActivo.Text = True
        End If
        ComprobarValoresDefault()
    End Sub

    Private Sub ComprobarValoresDefault()
        If lbTituloEvento.Text = m_Eventos.Row.Item("EvNombre") And _
            lbDescripEven.Text = m_Eventos.Row.Item("EvDescrip") And _
            lbEvActivo.Text = m_Eventos.Row.Item("EvActivo") And _
            lbFechIni.Text = m_Eventos.Row.Item("EvFechaInicio") And _
            lbFechFin.Text = m_Eventos.Row.Item("EvFechaFin") And _
            nuTiempoExa.Value = m_Eventos.Row.Item("EvMinutosTotalMax") And _
            nuTiempoPreg.Value = m_Eventos.Row.Item("EvSegundosPregMax") And _
            CkTiempoTodos.Checked = m_Eventos.Row.Item("EvParaTodos") And _
            cbTipoExamen.SelectedValue = m_Eventos.Row.Item("EvTipoExamen") And _
            (lbPermisoEmpezar.Text = "Si" And m_Eventos.Row.Item("EvPermisoEmpezar") = 1 Or
             lbPermisoEmpezar.Text = "No" And m_Eventos.Row.Item("EvPermisoEmpezar") = 0) And _
            ((m_Eventos.Row.Item("EvActual") = "Actual" And lbEvActual.Text = "EVENTO ACTUAL") Or _
            (m_Eventos.Row.Item("EvActual") = "No Actual" And lbEvActual.Text = "No actual")) Then

            btGuardar.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)

        Else

            btGuardar.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
        End If



    End Sub


    Private Sub lbPermisoEmpezar_Click(sender As Object, e As EventArgs) Handles lbPermisoEmpezar.Click
        If lbPermisoEmpezar.Text = "Si" Then
            lbPermisoEmpezar.Text = "No"
        Else
            lbPermisoEmpezar.Text = "Si"
        End If
        ComprobarValoresDefault()
    End Sub

    Private Sub lbEvActual_Click(sender As Object, e As EventArgs) Handles lbEvActual.Click
        If lbEvActual.Text = "EVENTO ACTUAL" Then
            lbEvActual.Text = "No Actual"
        Else
            lbEvActual.Text = "EVENTO ACTUAL"
        End If
        ComprobarValoresDefault()
    End Sub

    Private Sub cbTipoExamen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoExamen.SelectedIndexChanged
        Try
            ComprobarValoresDefault()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub nuTiempoExa_ValueChanged(sender As Object, e As EventArgs) Handles nuTiempoExa.ValueChanged
        Try
            ComprobarValoresDefault()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub nuTiempoPreg_ValueChanged(sender As Object, e As EventArgs) Handles nuTiempoPreg.ValueChanged
        Try
            ComprobarValoresDefault()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CkTiempoTodos_CheckedChanged(sender As Object, e As EventArgs) Handles CkTiempoTodos.CheckedChanged
        Try
            ComprobarValoresDefault()
        Catch ex As Exception

        End Try

    End Sub
End Class