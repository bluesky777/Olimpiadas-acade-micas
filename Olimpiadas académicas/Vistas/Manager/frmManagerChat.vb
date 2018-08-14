Imports System.Data.SqlClient
Imports System.Net

Public Class frmManagerChat

    Public WithEvents Servidor As New SocketServidor
    Dim Comenzado As Boolean = False
    Dim ListadoRealizado() As String
    Public pos As Integer = 10 'Posicion inicial del Panel del primer participante
    Dim iniciado As Boolean = False
    Dim dtUsuConected As New DataTable
    Dim dtCatSel As New DataTable
    Public dtUsuariosConectados As New DataTable
    Public ParticipantesAbiertos As Boolean = False
    Public idsCat As New List(Of Integer)


    Private Sub frmManagerChat_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        frmUsuariosConectados.Show()
        Me.Focus()
    End Sub

    Private Sub frmManagerChat_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim opc As DialogResult = MsgBox("¿Está seguro que desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = Windows.Forms.DialogResult.Yes Then
            conn.EjecutarConsulta("delete from tbEquipos where EquiLogin='" & Yo.Login & "' and  EquiNombre='" & Yo.EquipoNombre & "'")
            End
        Else
            e.Cancel = True
        End If

    End Sub


    Dim dtCat As New DataTable

    Private Sub frmManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Llamo el inicializador de las tablas
        If m_UsuarioAuth Is Nothing Then
            InicializarVariables()
            m_UsuarioAuth.Auth("admin", "purito", 2) 'Logueo de prueba como participante
        End If


        CheckForIllegalCrossThreadCalls = False
        With Servidor
            .PuertoDeEscucha = 8050
            .Escuchar()
        End With

        Dim thrSon As New Threading.Thread(AddressOf ReproducirSonido)
        NombreWav = "Sirviendo"
        thrSon.Start()
       
        conn.TraerTabla(dtCat, "select CatId, CatNombre from tbCategorias where CatEvento=2")

        With cbCategoria
            .DataSource = dtCat
            .ValueMember = "CatId"
            .DisplayMember = "CatNombre"
        End With

        With dtCatSel
            .Columns.Add("idCat")
            .Columns.Add("CatNombre")
            .PrimaryKey = New DataColumn() {.Columns("idCat")}
        End With

        ltCategAMostrar.DataSource = dtCatSel
        ltCategAMostrar.ValueMember = "idCat"
        ltCategAMostrar.DisplayMember = "CatNombre"

        frmUsuariosConectados.Show()

        Me.Left = frmUsuariosConectados.Width + 30

        iniciado = True
    End Sub


    '************************************************
    '****************** MENSAJERÍA ******************
    '************************************************

    Delegate Sub DelegNuevaCon(ByVal idTerm As IPEndPoint)

    Private Sub SocketServer_NuevaConexion(ByVal IDTerminal As IPEndPoint) Handles Servidor.NuevaConexion
        Dim thr As New Threading.Thread(AddressOf ReproducirSonido)
        NombreWav = "Pin"
        thr.Start()

        Dim d As New DelegNuevaCon(AddressOf LocalizarNuevo)
        Me.Invoke(d, New Object() {IDTerminal})
    End Sub

    Private Sub LocalizarNuevo(ByVal IDTerminal As IPEndPoint)

        'Creo un usuario conectado según su ip
        Dim NewConect As New Usuario_Conectado(IDTerminal.Address.ToString, conn)
        frmUsuariosConectados.MisUsuarios.AddUsuario(NewConect)

        txtConversa.Text = "Se conectó " & NewConect.UsuNombre & " del " & NewConect.EntNombreCorto & "." & vbCrLf & txtConversa.Text

    End Sub



    Delegate Sub DelRecibirDatos(ByVal Mensaje As String, ByVal IP As IPAddress)

    Private Sub Server_RecibirDatos(ByVal IDTerminal As IPEndPoint) Handles Servidor.DatosRecibidos

        Dim MensajeRecibido As String
        MensajeRecibido = Servidor.ObtenerDatos(IDTerminal)

        Dim d As New DelRecibirDatos(AddressOf RecibirDatos)
        Me.Invoke(d, New Object() {MensajeRecibido, IDTerminal.Address})
    End Sub


    Dim LoginTemp As String

    Private Sub RecibirDatos(ByVal Datos As String, ByVal IP As IPAddress)
  

        Dim Usu As Usuario_Conectado = BuscarUsuarioCon(IP.ToString)

        Dim textboxTemp As New TextBox
        textboxTemp.Text = Datos
        textboxTemp.SelectionStart = 0
        textboxTemp.SelectionLength = 20

        Dim DatosResumido As String = textboxTemp.SelectedText
        textboxTemp.SelectionStart = 0
        textboxTemp.SelectionLength = 12
        Dim datosDoce As String = textboxTemp.SelectedText


        If datosDoce = "AnsweredGood" Then
            txtConversa.Text = "El participante " & Usu.UsuNombre & " ha respondido correctamente." & vbCrLf & txtConversa.Text
            Dim thr As New Threading.Thread(AddressOf ReproducirSonido)
            NombreWav = "Correcta"
            thr.Start()
            'My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\sounds\Correcta.wav", AudioPlayMode.Background)

            Usu.Respondiendo("Correcto")


        ElseIf datosDoce = "AnsweredEvil" Then
            txtConversa.Text = "El participante " & Usu.UsuNombre & " ha respondido incorrectamente." & vbCrLf & txtConversa.Text
            Dim thr As New Threading.Thread(AddressOf ReproducirSonido)
            NombreWav = "Error"
            thr.Start()

            Usu.Respondiendo("Incorrecto")


            'If ParticipantesAbiertos = True Then
            '    For Each MiControl As Control In frmPublicoParticipantes.Controls
            '        If TypeOf MiControl Is Panel Then
            '            If MiControl.Name = LoginTemp Then
            '                MiControl.BackColor = Color.Red
            '            End If
            '        End If
            '    Next
            'End If

        Else
            Dim thr As New Threading.Thread(AddressOf ReproducirSonido)
            NombreWav = "Pin"
            thr.Start()

            txtConversa.Text = Usu.UsuLogin & ": " & DatosResumido & vbCrLf & txtConversa.Text
        End If

    End Sub


    Delegate Sub DeleEliminarParticipante(ByVal IDTerminal As IPEndPoint)

    Private Sub SocketServer_ConexionTerminada(ByVal IDTerminal As IPEndPoint) Handles Servidor.ConexionTerminada

        Dim d As New DeleEliminarParticipante(AddressOf EliminarDesconectado)
        Me.Invoke(d, New Object() {IDTerminal})

    End Sub

    Private Sub EliminarDesconectado(ByVal IDTerm As IPEndPoint)
        
        Dim result As Usuario_Conectado = BuscarUsuarioCon(IDTerm.Address.ToString())

        frmUsuariosConectados.MisUsuarios.QuitarUsuario(result)

        txtConversa.Text = "Se desconectó " & result.UsuNombre & " del " & result.EntNombreCorto & "." & vbCrLf & txtConversa.Text

    End Sub


    '************************************************
    '************ TERMINA MENSAJERIA ****************
    '************************************************



    Function BuscarUsuarioCon(ByVal IP As String)

        frmUsuariosConectados.MisUsuarios.IpBuscada = IP
        Dim result As Usuario_Conectado = frmUsuariosConectados.MisUsuarios.UsuariosConects.Find(AddressOf frmUsuariosConectados.MisUsuarios.FindUsu)

        If result IsNot Nothing Then
            Return result
        Else
            'MsgBox("Not found: ")
        End If

        Return 0
    End Function

    Private Sub btEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnviar.Click

        Servidor.EnviarDatos(txtMensaje.Text)

        txtConversa.Text = "Yo:  " & txtMensaje.Text & vbCrLf & txtConversa.Text
        txtMensaje.Text = ""
        txtMensaje.Focus()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ltCategAMostrar.Items.Count = 0 Then
            MsgBox("No ha elegido las categorias para el examen")
            Exit Sub
        End If

        If NumericActual.Value = 0 Then
            NumericActual.Value += 1
        End If

        Servidor.EnviarDatos("IniciarTest")

        frmUsuariosConectados.MisUsuarios.QuitarRespuestas()
        btParticipantes.Enabled = True
        btSiguiente.Enabled = True

        frmPublicoParticipantes.Close()
        frmPublicoExamen.Show()

        txtConversa.Text = vbCrLf & "----------------TEST INICIADO----------------" & vbCrLf & vbCrLf & txtConversa.Text
        Comenzado = True
    End Sub



    Dim Altura As Integer = 20


    Private Sub btSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSiguiente.Click
        Dim thrSonFin As New Threading.Thread(AddressOf ReproducirSonido)
        NombreWav = "Siguiente"
        thrSonFin.Start()

        frmUsuariosConectados.MisUsuarios.QuitarRespuestas()
        SiguientePreg()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If NumericActual.Value = 0 Then
            NumericActual.Value += 1
        End If

        frmPublicoParticipantes.Close()
        frmPublicoExamen.Close()

        ArreglarPantalla(frmPublicoExamen)

    End Sub


    Private Sub btActivarPublico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btActivarPublico.Click
        frmPublicoParticipantes.Close()
        frmPublicoExamen.Close()

        ArreglarPantalla(frmPublicoImagen)

    End Sub



    Private Sub btCerrarUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCerrarUsuarios.Click
        If (MsgBox("Está seguro que desea cerrar el programa de los equipos conectados?", vbYesNoCancel, "Cuidado - IGAD") = MsgBoxResult.Yes) Then
            Try
                Dim thrSonFin As New Threading.Thread(AddressOf ReproducirSonido)
                NombreWav = "bye"
                thrSonFin.Start()

                Servidor.EnviarDatos("GameOver")
            Catch ex As Exception
                MsgBox("Mensaje enviado")
            End Try
        End If

    End Sub

    Private Sub btAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtras.Click
        frmAdministrador.Show()
        Me.Hide()
    End Sub

    Private Sub txtConversa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConversa.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtMensaje_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMensaje.KeyDown
        If e.KeyCode = Keys.Enter Then
            btEnviar.PerformClick()
        End If
    End Sub

    Private Sub pbPrevio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbPrevio.Click
        Dim Dialogo As New OpenFileDialog

        Dialogo.Filter = "Imágenes|*.jpg;*.png;*.gif"

        With Dialogo
            .ShowDialog()

            If .FileName <> "" Then
                pbPrevio.Image = Image.FromFile(.FileName)
            End If
        End With

    End Sub

    Private Sub pbPrevio_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbPrevio.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub pbPrevio_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbPrevio.MouseMove
        Cursor = Cursors.Hand
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCerrarPublico.Click
        frmPublicoParticipantes.Close()
        frmPublicoExamen.Close()
        frmPublicoResultados.Close()
        frmPublicoImagen.Close()
    End Sub


    Private Sub ArreglarPantalla(ByVal formulario As Form)
        Dim Pantallas() As Screen = Screen.AllScreens

        If Pantallas.Length = 2 Then
            formulario.StartPosition = FormStartPosition.Manual
            formulario.Location = Pantallas(1).Bounds.Location

        Else
            formulario.StartPosition = FormStartPosition.CenterScreen
        End If

        formulario.Show()
        Me.Activate()
    End Sub

    Private Sub btBorrarEquipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub chkActual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActual.CheckedChanged
        If chkActual.Checked = True Then
            NumericActual.Enabled = True
        Else
            NumericActual.Enabled = False

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmPublicoExamen.Close()
    End Sub



    Private Sub cbCategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCategoria.SelectedIndexChanged
        If iniciado = True Then
            Dim dtCant As New DataTable
            conn.TraerTabla(dtCant, "Select P.PregId, P.PregPregunta, P.PregRespCorrecta, P.PregResp2, P.PregResp3, P.PregResp4, c.PrCaOrden " _
                                & "from tbPreguntas P INNER JOIN tbCatPreg c ON c.PrCaPregunta=P.PregId " _
                                & "where c.PrCaCategoria=" & cbCategoria.SelectedValue & " and c.PrCaParaExamen=1")

            lbCantPreg.Text = dtCant.Rows(0).Item(0).ToString
        End If
    End Sub

    Private Sub btParticipantes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btParticipantes.Click
        MostrarParticipantes()
        frmPublicoParticipantes.MostrarUsus(frmUsuariosConectados.MisUsuarios)
    End Sub


    Private Sub SiguientePreg()

        'frmPublicoResultados.Close()
        frmPublicoParticipantes.Close()

        '**********************************************************************************
        'Ahora arreglamos y mostramos el formualario de pregunta
        '**********************************************************************************

        NumericActual.Value += 1
        ArreglarPantalla(frmPublicoExamen)
        Servidor.EnviarDatos("Siguiente")
        txtConversa.Text = vbCrLf & "---------Siguiente pregunta-----------" & vbCrLf & vbCrLf & txtConversa.Text

        '**********************************************************************************
        'Borramo las respuestas de la columna
        '**********************************************************************************
        For Each row As DataRow In dtUsuariosConectados.Rows
            row.Item("Respuesta") = ""
        Next

    End Sub

    Private Sub MostrarParticipantes()

        frmPublicoExamen.Close()
        frmPublicoResultados.Close()
        frmPublicoParticipantes.MostrarUsus(frmUsuariosConectados.MisUsuarios)
        ArreglarPantalla(frmPublicoParticipantes)

    End Sub



    Private Sub lkbSelecCats_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkbSelecCats.LinkClicked
        Try
            For Each Usu As Usuario_Conectado In frmUsuariosConectados.MisUsuarios.UsuariosConects
                Usu.Cambiar_Categoria_Actual(cbCategoria.SelectedValue)
            Next
            idsCat.Add(cbCategoria.SelectedValue)
            dtCatSel.Rows.Add(cbCategoria.SelectedValue, cbCategoria.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ltCategAMostrar_DoubleClick(sender As Object, e As EventArgs) Handles ltCategAMostrar.DoubleClick
        QuitarCats()
    End Sub

    Private Sub QuitarCats()
        'Dim res As DataRow = dtCatSel.Rows.Find(ltCategAMostrar.SelectedValue)
        'idsCat.RemoveAll(res("idCat"))
        'dtCatSel.Rows.Remove(res)

        dtCatSel.Rows.Clear()
        idsCat.Clear()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        QuitarCats()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        For Each Ct As Object In frmUsuariosConectados.MisUsuarios.Controls
            If TypeOf Ct Is Usuario_Conectado Then
                MsgBox(Ct.UsuNombre)
            End If

        Next
    End Sub

    Dim NombreWav As String
    Public Sub ReproducirSonido()
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\sounds\" & NombreWav & ".wav", AudioPlayMode.Background)
    End Sub

End Class