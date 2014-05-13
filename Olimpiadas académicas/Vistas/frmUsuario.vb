Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing


Public Class frmUsuario
    Dim daUsuario As SqlDataAdapter
    Dim dtUsuarios As New DataTable
    Private mibinding As New BindingSource
    Dim buscar As Boolean = False
    Dim Iniciado As Boolean = False
    Dim searching = False
    Dim LasInscrip As Inscripciones_Usuario




    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassw.PasswordChar = "*"
        Else
            txtPassw.PasswordChar = ""
        End If
    End Sub

    Dim salir As Boolean = False

    Private Sub frmUsuario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        frmDetalleResultado.Close()
    End Sub

    Private Sub frmUsuario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If salir = False Then
            Dim opc As DialogResult = MsgBox("¿Desea cerrar la aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir - IGAD")

            If opc = Windows.Forms.DialogResult.Yes Then
                conn.EjecutarConsulta("delete from tbEquipos where EquiLogin='" & Login & "'")
                End
            Else
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        ' Llamo el inicializador de las tablas
        If m_UsuarioAuth Is Nothing Then
            InicializarVariables()
            m_UsuarioAuth.Auth("admin", "purito", 2) 'Logueo de prueba como participante
        End If



        'Estoy en el evento 2013, pero estoy usando el código 2, esto solo si entro directamente al formulario frmUsuario
        If Yo.EvId = 0 Then
            Yo.EvId = 2
        End If


        frmDetalleResultado.Close()


        AddHandler mibinding.PositionChanged, AddressOf CambiaPosicion


        ActualizarUsuarios()

        lbTipo.DataBindings.Add("Text", mibinding, "Tipo")
        lbEntidad.DataBindings.Add("Text", mibinding, "Entidad")
        lbActivo.DataBindings.Add("Text", mibinding, "Activo")
        txtNombre.DataBindings.Add("Text", mibinding, "Nombre")
        txtLogin.DataBindings.Add("Text", mibinding, "Login")
        txtPassw.DataBindings.Add("Text", mibinding, "Contraseña")
        LbId.DataBindings.Add("Text", mibinding, "Código")
        pbFoto.DataBindings.Add("text", mibinding, "Foto")
        GridView1.Columns.Remove("Contraseña")


        'Llenamos el combobox para autocomplete de CATEGORÍAS
        Dim dtUsuario As New DataTable
        Dim daUsuario As New SqlDataAdapter("Select UsuId, UsuNombre from tbUsuarios", conn.Conex)
        daUsuario.Fill(dtUsuario)
        With cbBuscar
            .DisplayMember = "UsuNombre"
            .ValueMember = "UsuId"
            .DataSource = dtUsuario
        End With

        cbBuscar.Text = ""

        Dim dtEnti As New DataTable
        conn.TraerTabla(dtEnti, "Select EntId, EntNombre from tbEntidades")

        With cbEntidad
            .DataSource = dtEnti
            .DisplayMember = "EntNombre"
            .ValueMember = "EntId"

        End With


        Dim dtTipo As New DataTable
        conn.TraerTabla(dtTipo, "Select TuId, TuTipoUsuario from tbTipoUsuario")

        With cbTipo
            .DataSource = dtTipo
            .DisplayMember = "TuTipoUsuario"
            .ValueMember = "TuId"

        End With


        '------------------



        'PictureBox1.Image = ConvertirImagen(pbFoto.Image)
        MisTools()

        Iniciado = True
    End Sub

    Private Sub ActualizarUsuarios()

        Try
            dtUsuarios.Clear()
        Catch ex As Exception
            'Si hay error porque aun no existía la tabla, No pasa nada
        End Try

        If buscar = False Then
            conn.TraerTabla(dtUsuarios, "select U.UsuId as Código,U.UsuNombre as Nombre,U.UsuLogin as Login, " _
                                           & "U.UsuPassw as Contraseña, U.UsuEntidad as Entidad, " _
                                           & "U.UsuTipo  as Tipo, U.UsuFoto as Foto, U.UsuActivo as Activo from tbUsuarios U " _
                                           & "ORDER BY U.UsuId DESC")
        ElseIf cbBuscar.Text = "" Then
            conn.TraerTabla(dtUsuarios, "select U.UsuId as Código,U.UsuNombre as Nombre,U.UsuLogin as Login, " _
                                           & "U.UsuPassw as Contraseña, U.UsuEntidad as Entidad, " _
                                           & "U.UsuTipo  as Tipo, U.UsuFoto as Foto, U.UsuActivo as Activo from tbUsuarios U " _
                                           & "ORDER BY U.UsuId DESC")
        Else
            conn.TraerTabla(dtUsuarios, "select U.UsuId as Código,U.UsuNombre as Nombre,U.UsuLogin as Login, " _
                                           & " U.UsuPassw as Contraseña, U.UsuEntidad as Entidad, " _
                                           & "U.UsuTipo  as Tipo, U.UsuFoto as Foto, U.UsuActivo as Activo " _
                                           & "from tbUsuarios U " _
                                           & "where UsuNombre LIKE '%" & cbBuscar.Text & "%' or " _
                                           & "UsuLogin LIKE '%" & cbBuscar.Text & "%'" _
                                           & "ORDER BY U.UsuId DESC")
        End If


        Try
            mibinding.DataSource = dtUsuarios
        Catch ex As Exception
            MsgBox("No se pudo asignar el BindingSource")
        End Try

        GridView1.DataSource = mibinding


        If txtFoto.Text = "" Then
            pbFoto.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Imágenes\Personas\sin imágen.gif")
            txtFoto.Text = My.Application.Info.DirectoryPath & "\Imágenes\Personas\sin imágen.gif"
        Else
            pbFoto.Image = Image.FromFile(txtFoto.Text)
        End If

        Try
            lbRegistros.Text = "Registro " & GridView1.CurrentCell.RowIndex + 1 & " de " & GridView1.Rows.Count
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        If MsgBox("¿Está seguro de querer eliminar?", vbYesNo, "Eliminar permanentemente") = vbYes Then
            conn.EjecutarConsulta("delete from tbUsuarios where UsuId = " & LbId.Text)
            ActualizarUsuarios()
        End If
        MostrarInscripciones()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAdministrador.Show()
        Me.LbId.Hide()
    End Sub


    Private Sub btNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNuevo.Click
        If btNuevo.Text = "Cancelar" Then
            btNuevo.Text = "Nuevo"
            mibinding.CancelEdit()
            Bloquear()
            pbFoto.Enabled = False
            btEditar.Enabled = True
            btGuardar.Enabled = False
            btEliminar.Enabled = True
            txtNombre.Focus()
            GridView1.Enabled = True
        Else
            btGuardar.Enabled = True
            pbFoto.Enabled = True
            Desbloquear()
            btNuevo.Text = "Cancelar"
            mibinding.AddNew()
            txtNombre.Focus()
            btEditar.Text = "Editar"
            btEditar.Enabled = False
            btEliminar.Enabled = False
            GridView1.Enabled = False

        End If

        cbActivo.SelectedIndex = 0
        cbTipo.SelectedIndex = 2
        cbEntidad.SelectedIndex = 5

    End Sub

    Private Sub btGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGuardar.Click
        
        'Dim pic As New SqlParameter("@pic", SqlDbType.Image)
        'pic.Value = pbFoto.Image

        'Dim Drow As DataRow
        'Drow.SetAdded()
        'Drow("UsuFoto") = frmUsuario.Image2Bytes(pbFoto.Image)

        Dim acti As String

        If cbActivo.SelectedIndex = 0 Then
            acti = "True"
        Else
            acti = "False"
        End If

        If btNuevo.Text = "Cancelar" Then
            btNuevo.Text = "Nuevo"
            

            If txtFoto.Text = "" Then txtFoto.Text = My.Application.Info.DirectoryPath & "\Imágenes\Personas\sin imágen.gif"
            conn.EjecutarConsulta("insert into tbUsuarios(UsuNombre, UsuLogin, UsuPassw, UsuTipo, UsuEntidad, UsuActivo) " _
                                 & "values('" & txtNombre.Text & "','" & txtLogin.Text & "','" & txtPassw.Text & "','" & cbTipo.SelectedValue & "', " & cbEntidad.SelectedValue & ", '" & acti & "')")
            'cmd.Parameters.Add(pic)
            
            btEditar.Enabled = True
        ElseIf btEditar.Text = "Cancelar" Then
            btEditar.Text = "Editar"
            conn.EjecutarConsulta("update tbUsuarios set UsuNombre = '" & txtNombre.Text & "', UsuLogin = '" & txtLogin.Text & "', UsuPassw = '" & txtPassw.Text & "', UsuTipo = '" & cbTipo.SelectedValue & "', UsuEntidad=" & cbEntidad.SelectedValue & ", UsuActivo='" & acti & "' where UsuId= " & LbId.Text)
            'cmd.Parameters.Add(pic)
            
        End If

        btNuevo.Enabled = True
        btGuardar.Enabled = False
        btEliminar.Enabled = True
        btEditar.Enabled = True
        Bloquear()
        GridView1.Enabled = True

        ActualizarUsuarios()
        MostrarInscripciones()

    End Sub


    Private Sub btEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditar.Click
        If btEditar.Text = "Editar" Then
            Desbloquear()
            pbFoto.Enabled = True
            btEditar.Text = "Cancelar"
            btGuardar.Enabled = True
            btEliminar.Enabled = False
            btNuevo.Enabled = False
            GridView1.Enabled = False

        Else
            Bloquear()
            pbFoto.Enabled = False
            btEditar.Text = "Editar"
            btGuardar.Enabled = False
            btEliminar.Enabled = True
            btNuevo.Enabled = True
            GridView1.Enabled = True
        End If

    End Sub

    Private Sub Desbloquear()
        txtLogin.Enabled = True
        txtNombre.Enabled = True
        txtPassw.Enabled = True
        cbTipo.Enabled = True
        cbEntidad.Enabled = True
        cbActivo.Enabled = True
        btInscribir.Enabled = False
    End Sub

    Private Sub Bloquear()
        txtLogin.Enabled = False
        txtNombre.Enabled = False
        txtPassw.Enabled = False
        cbTipo.Enabled = False
        cbEntidad.Enabled = False
        cbActivo.Enabled = False
        btInscribir.Enabled = True
    End Sub


    '*****************************************************************
    '************Aqui transformamos la imagen*************************
    '*****************************************************************
    Public Shared Function Image2Bytes(ByVal img As Image) As Byte()
        Dim sTemp As String = Path.GetTempFileName()
        Dim fs As New FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite)
        img.Save(fs, System.Drawing.Imaging.ImageFormat.Png)
        fs.Position = 0
        '
        Dim imgLength As Integer = CInt(fs.Length)
        Dim bytes(0 To imgLength - 1) As Byte
        fs.Read(bytes, 0, imgLength)
        fs.Close()
        Return bytes
    End Function

    Public Shared Function Bytes2Image(ByVal bytes() As Byte) As Image
        If bytes Is Nothing Then Return Nothing
        '
        Dim ms As New MemoryStream(bytes)
        Dim bm As Bitmap = Nothing
        Try
            bm = New Bitmap(ms)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        Return bm
    End Function

    Private Sub cbBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles cbBuscar.KeyDown
        If e.KeyCode = Keys.Escape Then
            cbBuscar.Text = ""
        End If
    End Sub
    '*****************************************************************
    '*****************************************************************


    Private Sub cbBuscar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBuscar.TextChanged

        If btNuevo.Text = "Cancelar" Then
            If (MsgBox("¿Desea descartar la edición?", vbYesNo, "Precaución.") = vbYes) Then
                btNuevo.Text = "Nuevo"
                mibinding.CancelEdit()
                Bloquear()
                pbFoto.Enabled = False
                btEditar.Enabled = True
                btGuardar.Enabled = False
                btEliminar.Enabled = True
                txtNombre.Focus()
                GridView1.Enabled = True

                buscar = True
                ActualizarUsuarios()
            End If
        ElseIf btEditar.Text = "Cancelar" Then
            If (MsgBox("¿Desea descartar la edición?", vbYesNo, "Precaución.") = vbYes) Then
                Bloquear()
                pbFoto.Enabled = False
                btEditar.Text = "Editar"
                btGuardar.Enabled = False
                btEliminar.Enabled = True
                GridView1.Enabled = True
                buscar = True
                ActualizarUsuarios()
            End If
        Else
            buscar = True


            ' Esto no mapea los controles de arriba
            Dim dtableSearch As New DataView(dtUsuarios)
            dtableSearch.RowFilter = "Nombre LIKE '%" & cbBuscar.Text & "%' or " & "Login LIKE '%" & cbBuscar.Text & "%'"
            mibinding.DataSource = dtableSearch
            'GridView1.DataSource = dtableSearch

            ActualizarUsuarios()
        End If


    End Sub

    Private Sub MisTools()

        Dim MiTooltipData As New ToolTip
        With MiTooltipData
            .IsBalloon = True
            .ToolTipIcon = ToolTipIcon.Info
            .ToolTipTitle = "Buscar imágen."
            .SetToolTip(pbFoto, "Dé clic sobre la imágen para examinar")
        End With


        Dim MiToolGrupoPreguntas As New ToolTip
        With MiToolGrupoPreguntas
            .IsBalloon = True
            .InitialDelay = 0
            .ToolTipIcon = ToolTipIcon.Info
            .ToolTipTitle = "Cuadro de busqueda."
            .SetToolTip(cbBuscar, "A medida que copie o borre algún texto" & vbCrLf & "se irán actualizando los registros de acuerdo a la busqueda.")
        End With

    End Sub

    Private Sub pbFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbFoto.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        With OpenFileDialog1
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            .FileName = Nothing
            .Filter = "Imagen (*.jpg; *.gif; *.png) | *.jpg;*.gif;*.png"
            .ShowDialog()

            If .FileName <> "" Then

                'Dim fs As System.IO.FileStream = CType(.OpenFile(), System.IO.FileStream)
                'pbLogo.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg)
                lbRutaImagen.Text = .FileName

                pbFoto.Image = Image.FromFile(.FileName)

                Dim xt As Double = pbFoto.Image.Width
                Dim yt As Double = pbFoto.Image.Height
                Dim porcentaje As Double, NueX As Double, NueY As Double

                If xt < yt Then
                    NueY = 200
                    porcentaje = (NueY * 100) / yt
                    NueX = porcentaje * xt / 100
                Else
                    NueX = 200
                    porcentaje = (NueX * 100) / xt
                    NueY = porcentaje * yt / 100
                End If

                Dim NueSize As New Size(NueX, NueY)

                Dim ImagenRezize As Image

                ImagenRezize = New Bitmap(pbFoto.Image, NueSize)
                pbFoto.Image = ImagenRezize
            End If
        End With
    End Sub

    Private Sub pbFoto_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbFoto.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub pbFoto_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbFoto.MouseMove
        Cursor = Cursors.Hand
    End Sub

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        If mibinding.Position <> -1 Then
            MostrarInscripciones()
        End If
    End Sub



    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectionChanged
        Try
            lbRegistros.Text = "Registro " & GridView1.CurrentCell.RowIndex + 1 & " de " & GridView1.Rows.Count
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btResultados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResultados.Click
        'frmDetalleResultado.ExaUsuABuscar = New Integer() {LbId.Text}
        'frmDetalleResultado.BuscarSoloUno = True
        frmResult2.Show()
    End Sub


    Public Sub MostrarInscripciones()
        Try
            LasInscrip.Dispose()
        Catch ex As Exception

        End Try


        If LbId.Text <> "" Then
            LasInscrip = New Inscripciones_Usuario(LbId.Text, Yo.EvId, conn, True)
            Me.Controls.Add(LasInscrip)

        End If

    End Sub

    Private Sub btInscribir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btInscribir.Click
        frmInscribirUsu.ShowDialog()
    End Sub

    Private Sub CambiaPosicion(sender As Object, e As EventArgs)
        If mibinding.Position <> -1 Then
            MostrarInscripciones()
        End If

    End Sub

    Private Sub btAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtras.Click
        Me.Hide()
        frmAdministrador.Show()
    End Sub


    Private Sub lbTipo_Click(sender As Object, e As EventArgs) Handles lbTipo.Click

    End Sub

    Private Sub lbTipo_TextChanged(sender As Object, e As EventArgs) Handles lbTipo.TextChanged
        Try
            cbTipo.SelectedValue = lbTipo.Text
        Catch ex As Exception

        End Try

    End Sub



   

    Private Sub lbActivo_TextChanged(sender As Object, e As EventArgs) Handles lbActivo.TextChanged

        If lbActivo.Text = "True" Then
            cbActivo.SelectedIndex = 0
        Else
            cbActivo.SelectedIndex = 1
        End If

    End Sub

    Private Sub lbEntidad_Click(sender As Object, e As EventArgs) Handles lbEntidad.Click

    End Sub

    Private Sub lbEntidad_TextChanged(sender As Object, e As EventArgs) Handles lbEntidad.TextChanged
        Try
            cbEntidad.SelectedValue = lbEntidad.Text
        Catch ex As Exception
            'MsgBox("No se pudo actualizar la entidad ... " & ex.Message)
        End Try
    End Sub


    Private Sub cbBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBuscar.SelectedIndexChanged

    End Sub

    Private Sub GridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView1.CellContentClick

    End Sub
End Class