
Public Class Inscripciones_Usuario
    Inherits Panel
    Dim Connex As Conexion_SqlServer

    Sub New(ByVal CodigoUsuario As Integer, ByVal CodigoEvento As Integer, ByVal ConexionActual As Conexion_SqlServer, Optional ByVal Editable As Boolean = True)
        'Me.AutoScroll = True
        Me.Width = 300
        Me.Height = 400
        Me.Top = 80
        Me.Left = 750
        Me.AutoScroll = True

        Dim dtInscripciones As New DataTable

        Connex = ConexionActual

        Connex.TraerTabla(dtInscripciones, "select InsId, InsUsuario, InsCategoria, CatNombre, InsFecha, InsOportunidades, InsEntidad, EntNombreCorto, InsActivo " _
                          & " from tbInscripciones, tbCategorias, tbEntidades " _
                          & " where CatId=InsCategoria and InsEntidad=EntId and InsUsuario=" & CodigoUsuario & " and CatEvento=" & CodigoEvento)

        Dim posy As Integer = 25

        For Each Inscripcion As DataRow In dtInscripciones.Rows
            Dim PanelIns As New InscripcionPanel(Inscripcion, ConexionActual)
            PanelIns.Top = posy
            posy = PanelIns.Top + PanelIns.Height + 5
            Me.Controls.Add(PanelIns)
        Next

    End Sub

End Class
