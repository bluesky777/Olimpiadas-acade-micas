Public Class frmPromt

    Dim WithEvents timerAnim As Timer

    Private Property Velocidad As Double
    Private Property Fuerza As Double

    Dim MyActualPanel As Panel
    Dim MyNewPanel As Panel
    Dim YPanel As Integer

    Public PanelResultados As pnResult
    Public PanelPregunta As pnPregunta


    Private Sub frmPromt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Arreglamos la apariencia del formulario
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.BackColor = Color.Black
        Me.AutoScroll = True


        'Establecemos valores a las variables para el efecto rebote
        Fuerza = -1.7
        Velocidad = 0
        YPanel = 50

        ' Creamos el timer de las para las animaciones de los paneles a mostrar y quitar
        timerAnim = New Timer
        timerAnim.Interval = 10

        ' Y Lo enlazamos con el método
        AddHandler timerAnim.Tick, AddressOf timerAnim_Tick


    End Sub


    Public Sub MostrarResultados(ByRef DatosClientes As List(Of clsDatosDeUnCliente))

        lbTitulo.Text = "Participantes."

        PanelResultados = New pnResult(Me, DatosClientes)
        Me.Controls.Add(PanelResultados)
        PanelResultados.BringToFront()
    End Sub


    Public Sub MostrarPregunta(idCat As Integer, numPreg As Integer, Categoria As String)

        'Me.limpiarPromt()

        lbTitulo.Text = "Pregunta " & numPreg & " de " & Categoria

        PanelPregunta = New pnPregunta(Me)
        PanelPregunta.getPregunta(idCat, numPreg)
        Me.Controls.Add(PanelPregunta)
        Me.PanelPregunta.BringToFront()

    End Sub

    Public Sub MostrarImagen(Optional dirImagen As String = "")
        lbTitulo.Text = "IGAD"
        Me.BackgroundImage = Image.FromFile(dirImagen)
    End Sub


    Public Sub AnimatiorEntrada(panelEntrante As Panel)
        MyNewPanel = panelEntrante
        MyNewPanel.Left = Me.Width + 20
        'MyNewPanel.Width = Me.Width - 40
        Me.Controls.Add(MyNewPanel)

        timerAnim.Enabled = True
        timerAnim.Start()
    End Sub

    Private Sub timerAnim_Tick(sender As Object, e As EventArgs)
        If MyNewPanel.Left < -40 Then
            'Esta linea se ejecuta cuando llega al límite
            MyNewPanel.Left = -40
            Velocidad = Velocidad * -0.2
        End If

        ' Aumentamos la velocidad
        Velocidad = Velocidad + Fuerza

        ' Movemos los paneles
        MyNewPanel.Left = MyNewPanel.Left + Velocidad
        If Not MyActualPanel Is Nothing Then
            MyActualPanel.Left = MyActualPanel.Left + Velocidad
        End If

        If Velocidad < 1 And Velocidad > -1 Then
            timerAnim.Stop()
            MyActualPanel.Dispose()
            MyActualPanel = MyNewPanel
            MyNewPanel.Dispose()
        End If




    End Sub

    Private Sub ParticipanteContestaCorrectamente(ByRef sender As clsDatosDeUnCliente)
        Try
            Me.BuscarPnParticipante(sender).GanarRespuesta()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ParticipanteContestaIncorrectamente(ByRef sender As clsDatosDeUnCliente)
        Try
            Me.BuscarPnParticipante(sender).PerderRespuesta()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function BuscarPnParticipante(ByRef sender As clsDatosDeUnCliente) As pnParticipante
        Dim NombreOld As String = sender.idExamen & sender.Nombre
        Dim NombreNuevo As String = NombreOld.Replace(" ", Nothing)
        Dim misControles() As Control = PanelResultados.Controls.Find(NombreNuevo, True)

        For Each micontrol As Control In misControles
            Dim miParticipant As pnParticipante = CType(micontrol, pnParticipante)
            Return miParticipant
        Next
        Return Nothing
    End Function

    Public Sub limpiarPromt()
        lbTitulo.Text = "IGAD"
        For Each micontrol As Control In Me.Controls
            If TypeOf micontrol Is pnResult Or TypeOf micontrol Is pnPregunta Then
                Me.Controls.Remove(micontrol)
            End If
        Next
    End Sub



End Class