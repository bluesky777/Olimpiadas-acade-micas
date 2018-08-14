Public Class frmInscribirUsu

    Property idCate As Integer
    Property idEnti As Integer
    Property Oportu As Integer
    Property Editando As Boolean = False
    Property idInsc As Integer


    Private Sub btCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub

    Private Sub btInscribir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btInscribir.Click
        If Editando = False Then



            If (conn.EjecutarConsulta("insert into tbInscripciones(InsUsuario, InsCategoria, InsFecha,InsOportunidades, InsEntidad, InsActivo) " _
                                         & " values(" & frmUsuario.LbId.Text & ", " & cbCategorias.SelectedValue & ", GETDATE(), " & NumOportunidades.Value & ", '" & cbEntidades.SelectedValue & "', 1);")) = True Then
                'MsgBox("Inscrito a " & cbCategorias.Text)

                Me.Close()
            End If

        Else

            If (conn.EjecutarConsulta("update tbInscripciones set InsUsuario=" & frmUsuario.LbId.Text & ", InsCategoria=" & cbCategorias.SelectedValue & ", " _
                                      & " InsOportunidades=" & NumOportunidades.Value & ", InsEntidad='" & cbEntidades.SelectedValue & "', " _
                                      & " InsActivo=1 where InsId=" & Me.idInsc)) = True Then
                'MsgBox("Inscrito a " & cbCategorias.Text)
                Me.Close()
            End If


        End If

        frmUsuario.MostrarInscripciones()

    End Sub

    Private Sub frmInscribirUsu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim dtCateg As New DataTable

        conn.TraerTabla(dtCateg, "Select CatId, CatNombre from tbCategorias where CatEvento=" & Yo.EvId)
        cbCategorias.DataSource = dtCateg
        cbCategorias.DisplayMember = "CatNombre"
        cbCategorias.ValueMember = "CatId"


        Dim dtEnti As New DataTable

        conn.TraerTabla(dtEnti, "Select EntId, EntNombre from tbEntidades")

        cbEntidades.DataSource = dtEnti
        cbEntidades.DisplayMember = "EntNombre"
        cbEntidades.ValueMember = "EntId"

        cbEntidades.SelectedValue = frmUsuario.cbEntidad.SelectedValue


        If Editando = True Then
            cbCategorias.SelectedValue = Me.idCate
            cbEntidades.SelectedValue = Me.idEnti
            NumOportunidades.Value = Me.Oportu
        End If

    End Sub
End Class