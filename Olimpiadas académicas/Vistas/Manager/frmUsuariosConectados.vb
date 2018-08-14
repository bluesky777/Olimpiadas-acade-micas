Public Class frmUsuariosConectados

    Public MisUsuarios As New Listado_Usuarios_Conectados

    Private Sub frmUsuariosConectados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim opc As DialogResult = MsgBox("¿Está seguro que desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = Windows.Forms.DialogResult.Yes Then
            conn.EjecutarConsulta("delete from tbEquipos where EquiLogin='" & Yo.Login & "' and  EquiNombre='" & Yo.EquipoNombre & "'")
            End
        Else
            e.Cancel = True
        End If
    End Sub


    Private Sub frmUsuariosConectados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Me.Height = My.Computer.Screen.WorkingArea.Height
        Me.Width = 400

        Me.PanelPrincipal.Height = Me.Height - PanelPrincipal.Top - 10

        Me.MisUsuarios.Width = Me.PanelPrincipal.Width - 2
        Me.MisUsuarios.Height = Me.PanelPrincipal.Height - 2
        Me.PanelPrincipal.Controls.Add(Me.MisUsuarios)

    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.MisUsuarios.QuitarRespuestas()
    End Sub



    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

    End Sub
End Class