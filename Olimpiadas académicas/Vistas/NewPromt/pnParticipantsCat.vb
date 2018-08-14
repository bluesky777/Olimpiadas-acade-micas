Public Class pnParticipantsCat
    Inherits Panel

    Public Participantes As New List(Of clsDatosDeUnCliente)
    Public panelesParticipantes As New List(Of pnParticipante)
    Dim distanciaVPart As Integer = 72
    Public idCategoria As Integer
    Public lbTituloCategoria As New Label
    Dim pnResultados As pnResult
    Dim AlturaPadreResult As Integer
    Dim xspace As Integer = 10
    Dim yspace As Integer = 10
    Public AnchoElemento As Integer = 210
    Public AlturaElemento As Integer = 70
    Dim alturaTitulo As Integer = 40

    Dim espacioYreal As Integer

    Dim numCols As Integer
    Dim numRows As Integer


    Sub New(ByRef pnResultados As pnResult)
        Me.pnResultados = pnResultados
        Me.AlturaPadreResult = pnResultados.Height
        Me.espacioYreal = Me.AlturaPadreResult - Me.alturaTitulo

        Me.Height = pnResultados.Height - 20
        'Me.AutoScroll = True
    End Sub

    Public Sub MostrarParticipantes()
        Me.OrdenarPorExamenes()
        Me.CalcularFilasColumnas()

        Me.Width = (Me.numCols * Me.AnchoElemento) '+ (Me.numRows * Me.xspace)

        Dim Indice As Integer = 0

        For y As Integer = 0 To Me.numCols

            For x As Integer = 0 To Me.numRows

                If Indice < Me.panelesParticipantes.Count Then
                    Me.panelesParticipantes(Indice).Left = (xspace + Me.AnchoElemento) * (y)
                    Me.panelesParticipantes(Indice).Top = ((yspace + Me.AlturaElemento) * (x)) + Me.alturaTitulo

                    Me.Controls.Add(Me.panelesParticipantes(Indice))

                    Indice += 1
                End If
            Next

        Next


        'Averiguaré en donde pondré el siguiente panel. Para ello, averiguaré cuantos pnParticipantes hay
        Dim AnchoPaneles As Integer = 10 ' Inicia en diez para que el primero no golpee el borde del form
        For Each pnPart As pnParticipantsCat In Me.pnResultados.Controls
            AnchoPaneles += pnPart.Width + 10
        Next

        ' La posición será lo que miden todos los pnResultado mas una distancia entre sí
        Me.Left = AnchoPaneles

        Me.pnResultados.Controls.Add(Me)



        Dim m_categ As New modCategoria
        Dim categ As String = m_categ.getCampoRaw(Participantes(0).idCategoria, "CatNombre")

        lbTituloCategoria.AutoSize = True
        Me.lbTituloCategoria.Text = categ
        lbTituloCategoria.Font = New Font("Arial", 20, FontStyle.Bold)
        'lbTituloCategoria.Height = 35
        lbTituloCategoria.ForeColor = Color.White
        lbTituloCategoria.Top = 0
        lbTituloCategoria.Left = 2
        'MsgBox("width/2: " & (Me.Width / 2) & " - lbTituloCategoria.Width/2: " & lbTituloCategoria.Width / 2 & "  -  lbTituloCategoria.Left: " & lbTituloCategoria.Left)
        Me.Controls.Add(lbTituloCategoria)


    End Sub

    Private Sub CalcularFilasColumnas()
        Dim ElementosCount As Integer = Me.panelesParticipantes.Count
        Dim Altura As Integer = Me.AlturaPadreResult

        Dim yNeeded As Integer

        yNeeded = (Me.AlturaElemento * ElementosCount) + (Me.yspace * ElementosCount)

        Me.numCols = Math.Ceiling(yNeeded / Me.espacioYreal)

        Me.numRows = Math.Floor(Me.espacioYreal / (xspace + Me.AlturaElemento))

    End Sub



    Sub OrdenarPorExamenes()
        Me.Participantes.Sort(AddressOf Me.CompareExamenes)
    End Sub

    Private Function CompareExamenes(ByVal Datos1 As clsDatosDeUnCliente, ByVal Datos2 As clsDatosDeUnCliente) As Integer
        If Datos1.PregCorrectas = Datos2.PregCorrectas Then

            If Datos1.TiempoExam = Datos2.TiempoExam Then
                If Datos1.Nombre = Nothing Then
                    Return 1
                ElseIf Datos2.Nombre = Nothing Then
                    Return 0
                End If
                Return Datos1.Nombre.CompareTo(Datos2.Nombre)
            Else
                Return Datos1.TiempoExam.CompareTo(Datos2.TiempoExam)
            End If

        Else
            Return Datos1.PregCorrectas.CompareTo(Datos2.PregCorrectas)
        End If

    End Function

    Sub CrearPanelesParticiantes()
        Try
            Me.lbTituloCategoria.Text = Participantes(0).Categoria
        Catch ex As Exception

        End Try


        ' Quito los paneles agregados
        Me.panelesParticipantes.Clear()

        For Each Parti As clsDatosDeUnCliente In Me.Participantes

            ' Creo el panel de un particpante, le doy posición y lo agrego al panel de la categoría (me)
            Dim pnDatosParticipante As New pnParticipante(Parti, Me)
            Me.panelesParticipantes.Add(pnDatosParticipante)
        Next

    End Sub


End Class










Public Class pnParticipante
    Inherits Panel


    Dim lbNombre As New Label
    Dim lbEntidad As New Label
    Dim lbPuntaje As New Label


    Sub New(ByRef datosParticipante As clsDatosDeUnCliente, ByRef pnParent As pnParticipantsCat)

        Me.Width = pnParent.AnchoElemento
        Me.Height = pnParent.AlturaElemento

        AddHandler datosParticipante.PreguntaContestadaCorrectamente, AddressOf GanarRespuesta
        AddHandler datosParticipante.PreguntaContestadaIncorrectamente, AddressOf PerderRespuesta
        AddHandler datosParticipante.EmpiezaSiguientePreg, AddressOf EmpiezaSiguientePreg
        AddHandler datosParticipante.MostrarPuntaje, AddressOf MostrarPuntajeEvent

        If pnParent.HorizontalScroll.Visible = True Then
            pnParent.Width = Me.Width + 20
        Else
            'pnParent.Width = Me.Width + 5
        End If



        Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle

        With Me.lbPuntaje
            .Width = 60
            .Text = datosParticipante.PregCorrectas
            .Top = 2
            .Left = Me.Width - Me.Width - 1
            .Font = New Font("Arial", 20, FontStyle.Bold)
            .Height = 50
            .TextAlign = ContentAlignment.MiddleCenter
            .BackColor = Color.Blue
            .ForeColor = Color.White
            .Visible = False
        End With


        With Me.lbNombre
            .Text = datosParticipante.Nombre
            .Top = 2
            .Left = 2
            .Font = New Font("Arial", 22)
            '.Width = Me.Width - 4

            .AutoSize = True
            '.Height = 40
            .TextAlign = ContentAlignment.MiddleCenter
            .ForeColor = Color.White
        End With

        With Me.lbEntidad
            .Text = datosParticipante.Entidad
            .Top = Me.lbNombre.Height + Me.lbNombre.Top + 10
            .Left = Me.lbNombre.Left
            .Font = New Font("Arial", 15, FontStyle.Italic)
            '.Width = Me.lbNombre.Width
            '.Height = Me.Height / 2 - 20
            .AutoSize = True
            .TextAlign = ContentAlignment.MiddleCenter
            .ForeColor = Color.White
        End With

        Dim NombreOld As String = datosParticipante.idExamen & datosParticipante.Nombre
        Dim NombreNuevo As String = NombreOld.Replace(" ", Nothing)
        Me.Name = NombreNuevo

        'MsgBox("nombreBox: " & Me.Name & " - top: " & Me.Top & " - left: " & Me.Left)

        Me.Controls.Add(lbPuntaje)
        Me.Controls.Add(lbNombre)
        Me.Controls.Add(lbEntidad)

        AddHandler Me.MouseMove, AddressOf MostrarPuntaje
        AddHandler Me.lbNombre.MouseMove, AddressOf MostrarPuntaje
        AddHandler Me.lbEntidad.MouseMove, AddressOf MostrarPuntaje


        AddHandler Me.MouseLeave, AddressOf OcultarPuntaje
        AddHandler Me.lbNombre.MouseLeave, AddressOf OcultarPuntaje
        AddHandler Me.lbEntidad.MouseLeave, AddressOf OcultarPuntaje



        If datosParticipante.ColorActual = COLOR_GOOD_ANSWER Then
            Me.BackColor = COLOR_GOOD_ANSWER
            lbNombre.ForeColor = Color.Black
            lbEntidad.ForeColor = Color.Black
        ElseIf datosParticipante.ColorActual = COLOR_BAD_ANSWER Then
            Me.BackColor = COLOR_BAD_ANSWER
            lbNombre.ForeColor = Color.White
            lbEntidad.ForeColor = Color.White
        ElseIf datosParticipante.ColorActual = COLOR_IN_TEST Then
            Me.BackColor = Color.Black
            lbNombre.ForeColor = Color.White
            lbEntidad.ForeColor = Color.White
        End If

    End Sub


    Public Sub MostrarPuntaje(sender As Object, e As MouseEventArgs)
        Me.lbPuntaje.Visible = True
    End Sub


    Public Sub OcultarPuntaje(sender As Object, e As EventArgs)
        Me.lbPuntaje.Visible = False
    End Sub

    Public Sub GanarRespuesta()
        Me.BackColor = COLOR_GOOD_ANSWER
        Me.lbNombre.ForeColor = Color.Black
        Me.lbEntidad.ForeColor = Color.Black
    End Sub


    Public Sub PerderRespuesta()
        Me.BackColor = COLOR_BAD_ANSWER
        lbNombre.ForeColor = Color.White
        lbEntidad.ForeColor = Color.White
    End Sub

    Private Sub EmpiezaSiguientePreg(ByRef sender As clsDatosDeUnCliente)
        Me.BackColor = Color.Black
        lbNombre.ForeColor = Color.White
        lbEntidad.ForeColor = Color.White
    End Sub

    Private Sub MostrarPuntajeEvent(mostrar As Boolean)
        Me.lbPuntaje.Visible = mostrar
    End Sub


End Class
