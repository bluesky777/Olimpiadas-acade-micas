Public Class frmOportunidadesUsu

    Private Sub frmOportunidadesUsu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbTitulo.Text = "Oportunidades para " & Yo.Login & vbCrLf & " en la categoría " & frmConectando.LtCategEmp.Text
        NumOportunidades.Value = frmConectando.lbOportunidades.Text
    End Sub



    Private Sub btGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGuardar.Click
        If NumOportunidades.Value = frmConectando.lbOportunidades.Text Then
            MsgBox("No realizó cambios")
            Exit Sub
        End If

        If conn.EjecutarConsulta("update tbInscripciones set InsOportunidades=" & NumOportunidades.Value & " where InsId=" & frmConectando.LtCategEmp.SelectedValue) = True Then
            frmConectando.lbOportunidades.Text = NumOportunidades.Value
            Me.Close()
        End If

    End Sub

    Private Sub NumOportunidades_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NumOportunidades.KeyDown
        If e.KeyCode = Keys.Enter Then
            btGuardar.PerformClick()
        End If
    End Sub

    Private Sub NumOportunidades_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumOportunidades.ValueChanged

    End Sub
End Class