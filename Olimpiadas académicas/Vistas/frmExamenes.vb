Public Class frmExamenes

    Dim SubEncabezado As String = ""

    Private Sub frmExamenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Llamo el inicializador de las tablas
        If m_UsuarioAuth Is Nothing Then
            InicializarVariables()
            m_UsuarioAuth.Auth("admin", "purito", 2) 'Logueo de prueba como participante
        End If

        Me.StartPosition = FormStartPosition.CenterScreen

        gridExamenes.ContextMenuStrip = ContextMenuGrid

        With LtEntidad
            .DataSource = m_Entidades.getTableRaw()
            .DisplayMember = "EntNombre"
            .ValueMember = "EntId"
        End With

        With LtCategoria
            .DataSource = m_Categorias.getTableRaw("CatEvento=" & m_Eventos.Id)
            .DisplayMember = "CatNombre"
            .ValueMember = "CatId"
        End With

        m_Examenes.DatagridByEvCatEntidad(gridExamenes, LtCategoria.SelectedValue, LtEntidad.SelectedValue)
    End Sub


    Private Sub CkCategoria_CheckedChanged(sender As Object, e As EventArgs) Handles CkCategoria.CheckedChanged
        If CkCategoria.Checked = True Then
            LtCategoria.Enabled = True
        Else
            LtCategoria.Enabled = False
        End If
    End Sub

    Private Sub CkEntidad_CheckedChanged(sender As Object, e As EventArgs) Handles CkEntidad.CheckedChanged
        If CkEntidad.Checked = True Then
            LtEntidad.Enabled = True
        Else
            LtEntidad.Enabled = False
        End If
    End Sub

    Private Sub LtEntidad_DoubleClick(sender As Object, e As EventArgs) Handles LtEntidad.DoubleClick, LtCategoria.DoubleClick
        BuscarExamenes()
    End Sub


    Private Sub BuscarExamenes()
        If CkCategoria.Checked = True And CkEntidad.Checked = True And CkSoloFinalistas.Checked = True Then

            m_Examenes.DatagridByEvCatEntidad(gridExamenes, LtCategoria.SelectedValue, LtEntidad.SelectedValue, True)
            SubEncabezado = "Finalistas " & LtEntidad.Text & " - " & LtCategoria.Text & "."

        ElseIf CkCategoria.Checked = True And CkEntidad.Checked = True And CkSoloFinalistas.Checked = False Then

            m_Examenes.DatagridByEvCatEntidad(gridExamenes, LtCategoria.SelectedValue, LtEntidad.SelectedValue, False)
            SubEncabezado = LtEntidad.Text & " - " & LtCategoria.Text & "."



        ElseIf CkCategoria.Checked = True And CkSoloFinalistas.Checked = True Then
            MsgBox("La consulta Todos los finalistas de todas las entidades en una categoría, No está listo aun.")
            'm_Examenes.DatagridByEvCatEntidad(gridExamenes, LtCategoria.SelectedValue, , True)
            'SubEncabezado = "Finalistas en todas las Entidades - " & LtCategoria.Text & "."

        ElseIf CkCategoria.Checked = True And CkSoloFinalistas.Checked = False Then

            m_Examenes.DatagridByEvCatEntidad(gridExamenes, LtCategoria.SelectedValue, , False)
            SubEncabezado = "Finalistas en todas las Entidades - " & LtCategoria.Text & "."


            
        ElseIf CkEntidad.Checked = True And CkSoloFinalistas.Checked = True Then

            m_Examenes.DatagridByEvCatEntidad(gridExamenes, , LtEntidad.SelectedValue, True)
            SubEncabezado = "Finalistas " & LtEntidad.Text & "."

        ElseIf CkEntidad.Checked = True And CkSoloFinalistas.Checked = False Then

            m_Examenes.DatagridByEvCatEntidad(gridExamenes, , LtEntidad.SelectedValue, False)
            SubEncabezado = LtEntidad.Text & "."

            

        ElseIf CkCategoria.Checked = False And CkEntidad.Checked = False And CkSoloFinalistas.Checked = True Then
            MsgBox("La consulta Todos los finalistas de todas las entidades, No está listo aun.")
            'm_Examenes.DatagridByEvento(gridExamenes, True)
            'SubEncabezado = "Finalistas en Todas las Entidades - Todas las categorías."

        ElseIf CkCategoria.Checked = False And CkEntidad.Checked = False And CkSoloFinalistas.Checked = False Then
            m_Examenes.DatagridByEvento(gridExamenes, False)
            SubEncabezado = "Todas las Entidades - Todas las categorías."

        End If

    End Sub

    Private Sub MenuItemEliminar_Click(sender As Object, e As EventArgs) Handles MenuItemEliminar.Click
        MsgBox("Aun se está desarrollando.")
    End Sub

    Private Sub btBuscarDatos_Click(sender As Object, e As EventArgs) Handles btBuscarDatos.Click
        BuscarExamenes()
    End Sub

    Private Sub BtExportar_Click(sender As Object, e As EventArgs) Handles BtExportar.Click
        'BuscarExamenes()
        Dim exporta As New classExportarExcel

        exporta.GridAExcel(gridExamenes, SubEncabezado)

    End Sub

    Private Sub MenuItemVerDetalles_Click(sender As Object, e As EventArgs) Handles MenuItemVerDetalles.Click
        MsgBox("Aun se está desarrollando.")
    End Sub
End Class