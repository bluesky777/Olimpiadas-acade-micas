Public Class Categorias_Asignadas

    Inherits Panel

    Dim Connex As Conexion_SqlServer

    Sub New(ByVal CodigoPregunta As Integer, ByVal ConexionActual As Conexion_SqlServer)
        'Me.AutoScroll = True
        Me.Width = 230
        Me.Height = 400
        Me.Top = 200
        Me.Left = 900
        Me.AutoScroll = True

        Dim dtAsignaciones As New DataTable

        Connex = ConexionActual

        Connex.TraerTabla(dtAsignaciones, "select PrCaId, PrCaPregunta, CatNombre, CatEvento, PrCaCategoria, PrCaOrden " _
                          & " from tbCatPreg, tbPreguntas, tbCategorias " _
                          & " where PrCaPregunta=PregId and PrCaCategoria=CatId and PregId=" & CodigoPregunta & " and PrCaPregunta=" & CodigoPregunta)

        Dim posy As Integer = 25

        For Each Asignacion As DataRow In dtAsignaciones.Rows
            Dim PanelIns As New AsignacionCategoria(Asignacion, ConexionActual)
            PanelIns.Top = posy
            posy = PanelIns.Top + PanelIns.Height + 5
            Me.Controls.Add(PanelIns)
        Next

    End Sub



End Class
