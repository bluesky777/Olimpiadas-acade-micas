Public Class frmValidando

    Public Operacion As String

    Private Sub frmValidando_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, Button2.KeyDown, txtUsuario.KeyDown, txtPass.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then

            validar_usuario()

        End If
    End Sub

    Private Sub frmValidando_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        validar_usuario()
    End Sub



    Private Sub validar_usuario()

        Dim Validador As New Usuario_Logueado

        Dim Resp_Validar As String

        Resp_Validar = Validador.Validar_Login(txtUsuario.Text, txtPass.Text, "Asesor", conn)

        conn.EjecutarConsulta("delete from tbEquipos where EquiLogin='" & Validador.Login & "'")

        txtPass.Text = ""

        Select Case Resp_Validar
            Case "No conecta"
                MsgBox("No se conecta a la base de datos.")
                Exit Sub

            Case "Datos incorrectos"
                MsgBox("Datos incorrectos.", vbExclamation, "IGAD")
                txtUsuario.Focus()
                Exit Sub

            Case "Desactivado"
                MsgBox("El usuario está bloqueado, comuníquese con el manager.", vbExclamation, "IGAD")
                Exit Sub

            Case "No IP"
                MsgBox("Lo sentimos, hubo un problema con la Ip de este equipo, comuníquese co el manager.", vbExclamation, "IGAD")
                Exit Sub

            Case "No Consulta Equipo"
                MsgBox("Lo sentimos, hubo problemas guardando los datos de este equipo, comuniquese con el manager.", vbExclamation, "IGAD")
                Exit Sub

            Case "Exitoso"

                If Validador.TipoId = 2 Or Validador.TipoId = 3 Then


                    Select Case Operacion
                        Case "Oportunidades"

                            frmOportunidadesUsu.ShowDialog()

                        Case "EliminarExamen"

                            If frmConectando.LtExamenes.SelectedItems.Count > 0 Then

                                conn.EjecutarConsulta("delete from tbDetalleExamen where DetExamen=" & frmConectando.LtExamenes.SelectedValue)
                                conn.EjecutarConsulta("delete from tbExamenes where ExaId=" & frmConectando.LtExamenes.SelectedValue)

                                frmConectando.VerificarDatos()


                            End If


                        Case Else
                            MsgBox("Operación no registrada")
                    End Select

                    Me.Close()

                Else
                    MsgBox("Lo sentimos, usted no tiene permisos de edición.")
                End If


        End Select


    End Sub

    Private Sub txtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass.TextChanged

    End Sub
End Class