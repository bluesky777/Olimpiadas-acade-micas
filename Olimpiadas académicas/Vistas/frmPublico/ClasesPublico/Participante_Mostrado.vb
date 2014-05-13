Public Class Participante_Mostrado
    Inherits Panel



    Public UsuId As Integer
    Property UsuNombre As String
    Property UsuLogin As String

    Property EntNombreCorto As String
    Property IdCatActual As Integer
    'Public UsuFoto As image
    Property Respondio As String = "No"
    Property Respuesta As String = "Sin"


    Dim lbNombreUsu As New Label
    Dim lbEntidad As New Label


    Sub New(idUsu As Integer, Usuario_Nombre As String, EntidadNombreCorto As String)
        Me.Name = idUsu
        Me.UsuId = idUsu
        Me.UsuNombre = Usuario_Nombre
        Me.EntNombreCorto = EntidadNombreCorto
        Controles()
    End Sub


    Private Sub Controles()
        With lbNombreUsu
            .Top = 5
            .Left = 5
            .AutoSize = True
            .BackColor = Color.Transparent
            .Font = New Font("Calibri", 22, FontStyle.Bold)
            .ForeColor = Color.White
            .Text = Me.UsuNombre
        End With
        Me.Controls.Add(lbNombreUsu)

        With lbEntidad
            .Top = lbNombreUsu.Top + lbNombreUsu.Height
            .Left = lbNombreUsu.Left + 10
            .BackColor = Color.Transparent
            .AutoSize = True
            .Font = New Font("Calibri", 18, FontStyle.Regular)
            .ForeColor = Color.White
            .Text = Me.EntNombreCorto
        End With
        Me.Controls.Add(lbEntidad)

    End Sub

    Public Sub Cambiar_Estado(Respuesta_Dada As String)
        Me.Respondio = "Si"
        Me.Respuesta = Respuesta_Dada
        If Respuesta_Dada = "Correcto" Then
            Me.BackColor = Color.Yellow
            Me.lbNombreUsu.ForeColor = Color.Black
            Me.lbEntidad.ForeColor = Color.Black
        Else
            Me.BackColor = Color.Red
        End If
    End Sub



End Class
