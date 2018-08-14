Public Class Usuario_Conectado
    Inherits Panel


    Public IP As String

    Public UsuId As Integer
    Property UsuNombre As String
    Property UsuLogin As String

    Property EntNombreCorto As String
    Public dtInscripciones As New DataTable
    Property IdCatActual As Integer
    'Public UsuFoto As image
    Property Respondio As String = "No"
    Property Respuesta As String = "Sin"

    Private ConnInterna As Conexion_SqlServer


    Dim lbNombreUsu As New Label
    Dim lbEntidad As New Label
    Dim lbRespuesta As New Label
    Dim cbCategorias As New ComboBox



    Sub New(Ip_Equipo As String, Conexion_Actual As Conexion_SqlServer)


        IP = Ip_Equipo

        ConnInterna = Conexion_Actual

        Dim dtUsuConected As New DataTable

        ConnInterna.TraerTabla(dtUsuConected, "Select U.UsuId, U.UsuNombre, U.UsuLogin, U.UsuFoto, Et.EntNombreCorto  " _
                          & "FROM tbEquipos E, tbUsuarios U, tbEntidades Et " _
                          & "WHERE E.EquiIp='" & IP & "' AND E.EquiLogin=U.UsuLogin AND U.UsuEntidad=Et.EntId " _
                          & "AND E.EquiRoll='Participante'")

        Try
            Me.UsuId = dtUsuConected.Rows(0).Item("UsuId").ToString()
            Me.UsuNombre = dtUsuConected.Rows(0).Item("UsuNombre").ToString()
            Me.UsuLogin = dtUsuConected.Rows(0).Item("UsuLogin").ToString()
            Me.EntNombreCorto = dtUsuConected.Rows(0).Item("EntNombreCorto").ToString()

        Catch ex As Exception
            Exit Sub
        End Try

        dtUsuConected.Dispose()

        Dim dtCatIns As New DataTable

        ConnInterna.TraerTabla(dtCatIns, "Select i.InsId, i.InsCategoria, c.CatNombre, c.CatNombreCorto " _
                          & "FROM tbInscripciones i, tbCategorias c " _
                          & "WHERE i.InsCategoria=c.CatId and i.InsUsuario=" & Me.UsuId & " and CatEvento=2")

        Llenar_Categorias(dtCatIns)


        With lbNombreUsu
            .Top = 3
            .Left = 3
            .AutoSize = True
            .BackColor = Color.Transparent
            .Font = New Font("Calibri", 12, FontStyle.Bold)
            .Text = Me.UsuNombre
        End With
        Me.Controls.Add(lbNombreUsu)


        With lbEntidad
            .Top = lbNombreUsu.Top + lbNombreUsu.Height + 10
            .Left = lbNombreUsu.Left + 10
            .BackColor = Color.Transparent
            .AutoSize = True
            .Font = New Font("Calibri", 9, FontStyle.Regular)
            .Text = Me.EntNombreCorto
        End With
        Me.Controls.Add(lbEntidad)

        With cbCategorias
            .Top = lbNombreUsu.Top + lbNombreUsu.Height + 5
            .Left = lbEntidad.Left + lbEntidad.Width + 10

            .DataSource = Me.dtInscripciones
            .DisplayMember = "NombreCat"
            .ValueMember = "IdCat"
            AddHandler .SelectedIndexChanged, AddressOf cbCategorias_SelectedIndexChanged
        End With
        Me.Controls.Add(cbCategorias)


        With lbRespuesta
            .Top = lbEntidad.Top - 10
            .Left = 270
            .BackColor = Color.Transparent
            .AutoSize = True
            .Font = New Font("Calibri", 11, FontStyle.Bold)
            .Text = Me.Respuesta
        End With
        Me.Controls.Add(lbRespuesta)

        Me.BorderStyle = BorderStyle.FixedSingle

        Me.Height = 70

    End Sub

    Private Sub Llenar_Categorias(dtCats As DataTable)

        With Me.dtInscripciones
            .Columns.Add("IdIns")
            .Columns.Add("idCat")
            .Columns.Add("NombreCat")
            .Columns.Add("NombreCortoCat")
            .Columns.Add("ActualCat")
            .PrimaryKey = New DataColumn() {.Columns("idCat")}
        End With


        For Each row As DataRow In dtCats.Rows

            Dim InsId As Integer = row("InsId").ToString
            Dim InsCategoria As Integer = row("InsCategoria").ToString
            Dim CatNombre As String = row("CatNombre").ToString
            Dim CatNombreCorto As String = row("CatNombreCorto").ToString

            Me.dtInscripciones.Rows.Add(InsId, InsCategoria, CatNombre, CatNombreCorto, "")

        Next

        ConnInterna.EjecutarConsulta("delete tbConfigFinal where FinIdUsuario=" & Me.UsuId & "; " _
                    & "INSERT INTO tbConfigFinal(FinIdUsuario, FinNombreUsuario) " _
                    & "values(" & Me.UsuId & ", '" & Me.UsuNombre & "')")

    End Sub


    Public Sub Respondiendo(Respuesta As String)
        Me.Respondio = "Si"
        Me.Respuesta = Respuesta
        Me.lbRespuesta.Text = Respuesta

        For Each Ctrs As Object In frmPublicoParticipantes.Controls
            If TypeOf Ctrs Is Usuarios_Participando Then
                For Each UsuMos As Object In Ctrs.Controls
                    If TypeOf UsuMos Is Participante_Mostrado Then
                        If UsuMos.UsuId = Me.UsuId Then
                            UsuMos.Cambiar_Estado(Respuesta)
                        End If
                    End If
                Next
            End If
        Next
    End Sub


    Dim CambioInterno As Boolean = False
    Dim IgnorarEvCambio As Boolean = False

    Private Sub cbCategorias_SelectedIndexChanged(sender As Object, e As EventArgs)
        If IgnorarEvCambio = True Then
            Exit Sub
        End If

        Try
            CambioInterno = True
            Cambiar_Categoria_Actual(cbCategorias.SelectedValue)
        Catch ex As Exception

        End Try


    End Sub


    Public Sub Cambiar_Categoria_Actual(idCat As Integer)

        If CambioInterno = False Then

            Dim dro As DataRow
            dro = dtInscripciones.Rows.Find(idCat)

            If Not dro Is Nothing Then
                cbCategorias.SelectedValue = idCat
                Exit Sub
            End If

        Else
            CambioInterno = False
        End If

        Dim dr As DataRow
        dr = dtInscripciones.Rows.Find(idCat)

        If dr Is Nothing Then
            'MsgBox("No se encuentra la categoría buscada como parte de este Usuario")
            Exit Sub
        Else

            Dim Buscar_Fila() As DataRow

            Buscar_Fila = dtInscripciones.Select("ActualCat LIKE 'Actual'")
            IgnorarEvCambio = True
            If Buscar_Fila.Length > 0 Then
                Buscar_Fila(0)("ActualCat") = ""
            Else
                ' MsgBox("Ninguna inscripción era actual")
            End If

            dr("ActualCat") = "Actual"
            Me.IdCatActual = idCat

            ConnInterna.EjecutarConsulta("update tbConfigFinal set FinIdCategoria='" & dr("idCat") & "',  FinIdInscripcion='" & dr("IdIns") & "'" _
                                        & "where FinIdUsuario=" & Me.UsuId)
            IgnorarEvCambio = False

        End If

    End Sub


    Public Sub LimpiarRespuesta()
        Me.Respondio = "No"
        Me.Respuesta = ""
        Me.lbRespuesta.Text = ""
    End Sub


End Class
