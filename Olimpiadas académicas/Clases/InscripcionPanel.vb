Public Class InscripcionPanel
    Inherits Panel

    Property idIns As Integer
    Property InsUsuario As Integer
    Property InsCategoria As Integer
    Property CatNombre As String
    Property InsFecha As Date
    Property InsOportunidades As Integer
    Property InsEntidad As Integer
    Property EntNombreCorto As String
    Property InsActivo As Integer

    Private conexi As Conexion_SqlServer

    Sub New(ByVal DatosIncripcion As DataRow, ByVal conex As Conexion_SqlServer)

        Me.conexi = conex

        Me.idIns = DatosIncripcion("InsId")
        Me.InsUsuario = DatosIncripcion("InsUsuario")
        Me.InsCategoria = DatosIncripcion("InsCategoria")
        Me.CatNombre = DatosIncripcion("CatNombre")
        Me.InsFecha = DatosIncripcion("InsFecha")
        Me.InsOportunidades = DatosIncripcion("InsOportunidades")
        Me.InsEntidad = DatosIncripcion("InsEntidad")
        Me.EntNombreCorto = DatosIncripcion("EntNombreCorto")
        Me.InsActivo = DatosIncripcion("InsActivo")

        Me.AutoScroll = True
        Me.Width = 250
        Me.Left = 20
        Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle

        Dim lbCategoria As New Label
        lbCategoria.Text = Me.CatNombre
        lbCategoria.Font = New Font("Times New Roman", 14)
        'lbCategoria.Left = 10
        lbCategoria.Width = 230
        Me.Controls.Add(lbCategoria)

        Dim lbInsFecha As New Label
        With lbInsFecha
            .Text = Me.InsFecha
            .Left = 10
            .Top = lbCategoria.Top + lbCategoria.Height
        End With

        Me.Controls.Add(lbInsFecha)


        Dim lbInsOportunidades As New Label
        lbInsOportunidades.Text = "Oport: " & Me.InsOportunidades
        lbInsOportunidades.Width = 50
        lbInsOportunidades.Top = lbInsFecha.Top + lbInsFecha.Height
        Me.Controls.Add(lbInsOportunidades)

        Dim lbEntNombreCorto As New Label
        With lbEntNombreCorto
            .Text = Me.EntNombreCorto
            .Top = lbInsOportunidades.Top
            .Left = lbInsOportunidades.Left + lbInsOportunidades.Width + 5
            .AutoSize = True
        End With

        Me.Controls.Add(lbEntNombreCorto)


        Dim lbInsActivo As New Label
        With lbInsActivo
            If Me.InsActivo = 1 Then
                lbInsActivo.Text = "Activo"
            Else
                lbInsActivo.Text = "Inactivo"
            End If
            .AutoSize = True
            .Height = 150
            .Top = lbEntNombreCorto.Top + lbEntNombreCorto.Height
        End With

        Me.Controls.Add(lbInsActivo)



        Dim btEliminar As New Button
        btEliminar.Text = "Eliminar"
        btEliminar.Top = lbCategoria.Top + lbCategoria.Height
        btEliminar.Left = 150
        Me.Controls.Add(btEliminar)

        AddHandler btEliminar.Click, AddressOf btEliminar_Click


        Dim btEditar As New Button
        With btEditar
            .Text = "Editar"
            .Top = btEliminar.Top + btEliminar.Height
            .Left = 150

        End With
        Me.Controls.Add(btEditar)

        AddHandler btEditar.Click, AddressOf btEditar_Click



    End Sub

    Private Sub btEliminar_Click(ByVal sender As Object, ByVal e As EventArgs)

        If (MsgBox("¿Seguro que desea quitar la inscripción a " & Me.CatNombre, vbYesNoCancel, "Desinscribir") = MsgBoxResult.Yes) Then
            If Me.conexi.EjecutarConsulta("delete from tbInscripciones where InsId=" & Me.idIns) = True Then
                MsgBox("Inscripción eliminada.", MsgBoxStyle.Information, "Eliminada")
            End If
        End If

    End Sub

    Private Sub btEditar_Click(ByVal sender As Object, ByVal e As EventArgs)
        With frmInscribirUsu
            .Oportu = Me.InsOportunidades
            .idEnti = Me.InsEntidad
            .idCate = Me.InsCategoria
            .Editando = True
            .idInsc = Me.idIns

            .Text = "Editar inscripción"
            .btInscribir.Text = "Guardar"

            .ShowDialog()
        End With

    End Sub

End Class
