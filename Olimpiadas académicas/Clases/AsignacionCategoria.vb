Public Class AsignacionCategoria
    Inherits Panel

    Property PrCaId As Integer
    Property PrCaPregunta As Integer
    Property PrCaCategoria As Integer
    Property PrCaOrden As String
    Property CatNombre As String
    Property CatEvento As Integer


    Private conexi As Conexion_SqlServer

    Sub New(ByVal DatosAsignacion As DataRow, ByVal conex As Conexion_SqlServer)

        Me.conexi = conex

        Me.PrCaId = DatosAsignacion("PrCaId")
        Me.PrCaPregunta = DatosAsignacion("PrCaPregunta")
        Me.PrCaCategoria = DatosAsignacion("PrCaCategoria")
        'Me.PrCaOrden = DatosAsignacion("PrCaOrden")
        Me.CatNombre = DatosAsignacion("CatNombre")
        Me.CatEvento = DatosAsignacion("CatEvento")


        Me.Width = 200
        Me.Height = 60
        Me.Left = 20
        Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle

        Dim lbCategoria As New Label
        lbCategoria.Text = Me.CatNombre
        lbCategoria.Font = New Font("Times New Roman", 14)
        'lbCategoria.Left = 10
        lbCategoria.Width = 200
        Me.Controls.Add(lbCategoria)

        Dim CatEvento As New Label
        CatEvento.Text = Me.CatEvento
        CatEvento.Left = 10
        CatEvento.Top = lbCategoria.Top + lbCategoria.Height
        Me.Controls.Add(CatEvento)



        Dim btEliminar As New Button
        btEliminar.Text = "Eliminar"
        btEliminar.Top = lbCategoria.Top + lbCategoria.Height
        btEliminar.Left = 110
        Me.Controls.Add(btEliminar)

        AddHandler btEliminar.Click, AddressOf btEliminar_Click



    End Sub

    Private Sub btEliminar_Click(ByVal sender As Object, ByVal e As EventArgs)

        If (MsgBox("¿Seguro que desea quitar la categoria " & Me.CatNombre, vbYesNoCancel, "Desinscribir") = MsgBoxResult.Yes) Then
            If Me.conexi.EjecutarConsulta("delete from tbCatPreg where PrCaId=" & Me.PrCaId) = True Then
                frmPreguntas.MostrarAsignaciones()
                MsgBox("Inscripción eliminada.", MsgBoxStyle.Information, "Eliminada")
            End If
        End If

    End Sub

End Class
