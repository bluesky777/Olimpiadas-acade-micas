Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Collections
Imports System.Threading

Public Class frmLogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmConectando.Show()
        Me.Hide()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        InicializarVariables()

        If (conn.Conectar() = False) Then
            lbConectando.Text = "No hay conexión."
            Exit Sub
        Else
            lbConectando.Text = "Conectado"
            lbConectando.Visible = False
        End If

        Me.Height = 220

        LlenarCbTipo()

        'CheckForIllegalCrossThreadCalls = False
        'Dim thr As New Thread(AddressOf Hilo)
        'thr.Start()
        
    End Sub

    'Private Sub Hilo()
    '    lbConectando.Text = "Conectando..."
    '    If AbrirConn() = False Then
    '        lbConectando.Text = "Conexión fallida."
    '        Exit Sub
    '    Else
    '        lbConectando.Text = "Conectado"
    '        lbConectando.Visible = False
    '    End If
    'End Sub

    
    Private Sub validar_usuario()

        Dim validar As ArrayList = m_UsuarioAuth.Auth(txtUsuario.Text, txtPassword.Text, cbTipoUsu.SelectedValue)

        If validar(0) = True Then

            Me.Hide()
            txtPassword.Text = ""
            txtUsuario.Text = ""
            txtUsuario.Focus()

            Select Case validar(1)
                Case 2 ' Administrador
                    frmAdministrador.Show()

                Case 3 'Asesor
                    frmAdministrador.Show()

                Case 4 'Participante
                    frmConectando.Show()

            End Select

        Else
            MsgBox(validar(1), MsgBoxStyle.Information, "Intente de nuevo.")
            txtUsuario.Focus()
        End If

    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Len(txtServidor.Text) <> 0 Then

            Me.Height = 220
            Dim escritor As New StreamWriter("Servidor.txt")
            escritor.WriteLine(txtServidor.Text)
            escritor.Close()
            conn.MyServer = txtServidor.Text
            conn.ActualizarCadena()
            If conn.Conectar() = True Then
                LlenarCbTipo()
                lbConectando.Text = "Conectado"
                lbConectando.Visible = False
            End If
        Else
            MsgBox("Debes escribir el servidor.")
        End If
    End Sub


    Private Sub txtServidor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServidor.TextChanged
        If Len(txtServidor.Text) <> 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtUsuario.Text = "" Then
            txtUsuario.Focus()
        Else
            txtPassword.Focus()
        End If
        Me.Height = 220
    End Sub

    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
        txtPassword.SelectAll()
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then

            If lbConectando.Text = "Conectando..." Then
                MsgBox("Espere a que conecte a la base de datos.")
            ElseIf lbConectando.Text = "Conexión fallida." Then
                MsgBox("Conexión fallida.")
            Else
                validar_usuario()
            End If

        End If
    End Sub

    Private Sub txtUsuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.GotFocus
        txtUsuario.SelectAll()
    End Sub

    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then

            If lbConectando.Text = "Conectando..." Then
                MsgBox("Espere a que conecte a la base de datos.")
            ElseIf lbConectando.Text = "Conexión fallida." Then
                MsgBox("Conexión fallida.")
            Else
                validar_usuario()
            End If

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Me.Height < 270 Then
            Me.Height = 270
        Else
            Me.Height = 220
            txtServidor.Focus()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmCreditos.Show()
    End Sub

    Private Sub btIngresar_Click(sender As Object, e As EventArgs) Handles btIngresar.Click
        If lbConectando.Text = "Conectando..." Then
            MsgBox("Espere a que conecte a la base de datos.")
        ElseIf lbConectando.Text = "Conexión fallida." Then
            MsgBox("Conexión fallida.")
        Else
            validar_usuario()
        End If

    End Sub

    Private Sub cbTipoUsu_KeyDown(sender As Object, e As KeyEventArgs) Handles cbTipoUsu.KeyDown
        If e.KeyCode = Keys.Enter Then

            If lbConectando.Text = "Conectando..." Then
                MsgBox("Espere a que conecte a la base de datos.")
            ElseIf lbConectando.Text = "Conexión fallida." Then
                MsgBox("Conexión fallida.")
            Else
                validar_usuario()
            End If

        End If
    End Sub

    Private Sub LlenarCbTipo()

        m_TipoUsuarios.mapCombo(cbTipoUsu, "TuTipoUsuario")
        cbTipoUsu.SelectedValue = "4"

    End Sub


    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class
