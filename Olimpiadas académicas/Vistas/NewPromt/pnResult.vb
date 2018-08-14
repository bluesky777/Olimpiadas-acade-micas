Public Class pnResult
    Inherits Panel


    Dim Fuerza As Double
    Dim Velocidad As Double
    Dim timerAnim As Timer
    Public Examenes As New ArrayList({1322, 1232, 3234})
    Public dtExamenes As DataTable

    ' Para buscar todos lo que concuerden
    Dim idCatTemp As Integer


    Public Sub New(ByRef frmParent As Form, ByRef DatosClientes As List(Of clsDatosDeUnCliente))

        Me.Top = frmParent.Top + 50
        'Me.Width = frmParent.Width - 40
        Me.Height = frmParent.Height - Me.Top - 25
        'Me.AutoScroll = True

        'Obtengo todas las categorías a mostrar en la pantalla
        Dim idCats As New ArrayList
        For Each cliente As clsDatosDeUnCliente In DatosClientes
            If Not idCats.Contains(cliente.idCategoria) Then
                idCats.Add(cliente.idCategoria)
            End If
        Next

        ' Obtengo los participantes por categorías
        For Each i As Integer In idCats
            Dim participantesMostrar = New pnParticipantsCat(Me)
            idCatTemp = i
            participantesMostrar.Participantes = DatosClientes.FindAll(AddressOf FindByIdCategoria)
            participantesMostrar.CrearPanelesParticiantes()
            participantesMostrar.MostrarParticipantes()
        Next

        Dim anchura As Integer = 0
        For Each pnPartCat As Control In Me.Controls
            anchura += pnPartCat.Width
        Next

        If anchura < frmParent.Width Then
            Me.Width = frmParent.Width
        Else
            Me.Width = anchura
        End If


    End Sub


    Private Function FindByIdCategoria(DatosCliente As clsDatosDeUnCliente) As Boolean
        If DatosCliente.idCategoria = idCatTemp Then
            Return True
        Else
            Return False
        End If
    End Function

   


    Private Sub CalcularExamenes(Optional examenes As ArrayList = Nothing)

        If Not examenes Is Nothing Then
            Me.Examenes = examenes
        End If

        Dim condicionalIds As String = " AND ("

        For item As Integer = 0 To Me.Examenes.Count - 1
            condicionalIds += "ExaId=" & Me.Examenes(item)
            If Not (item + 1) = Me.Examenes.Count Then
                condicionalIds += " OR "
            End If
        Next

        condicionalIds += ")"

        Dim mExams As New modExamen
        Me.dtExamenes = mExams.GetByEvCatEntidad(, , False, condicionalIds)

        Dim dtExamsTemp As New DataTable
        Dim CatTemp As String = ""
        For Each row As DataRow In Me.dtExamenes.Rows

            If CatTemp = "" Then CatTemp = row.Item("Categoría")

            If CatTemp <> row.Item("Categoría") Then

                'Creo el panel para mostrar los participantes de la categoría recorrida
                Dim participantesMostrar As New pnParticipantsCat(Me)

                'participantesMostrar.LlenarParticipantes(15)
                'participantesMostrar.MostrarParticipantes(Me)

                CatTemp = row.Item("Categoría")

            End If

            dtExamsTemp.Rows.Add(row)

        Next



    End Sub


End Class
