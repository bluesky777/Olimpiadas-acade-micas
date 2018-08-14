Public Class frmPublicoResultados

    Dim Altura As Integer = 20, pos As Integer = 10

    Private Sub frmPublicoResultados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = 600
        Me.Width = 800


        '**********************************************************************************
        'Primero arreglo el formulario de participantes
        '**********************************************************************************

        pos = 10
        Altura = 20


        'Calculamos el puntaje de cada participante y los guardamos en un nuevo dataTable temporal
        Dim rows() As DataRow
        rows = frmManagerChat.dtUsuariosConectados.Select("Nombre <>'' AND Categoría='" & frmManagerChat.cbCategoria.Text & "'", "Puntaje ASC") 'Seleccionamos todo ordenado por puntaje

 
        'Ahora mostramos al público los participantes ordenados por mejor puntaje hasta el momento
        For i As Integer = 0 To rows.Length - 1
            CrearLabel(rows(i).Item("Login").ToString, rows(i).Item("Nombre").ToString)
        Next

    End Sub

    Private Sub CrearLabel(ByVal nombre As String, ByVal texto As String)
        Dim MiPanel As New Panel

        MiPanel.Top = Altura
        Altura += 70

        With MiPanel
            .Width = 300
            .Left = (Me.Width / 2) - (MiPanel.Width / 2)
            .Height = 60
            .BackColor = Color.AliceBlue
        End With


        Dim MiLabel As New Label
        With MiLabel
            .Font = New Font("Arial", 22, FontStyle.Bold)
            '.ForeColor = Color.White
            .Width = MiPanel.Width
            .Height = MiPanel.Height
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = texto
        End With
        MiPanel.Controls.Add(MiLabel)

        Me.Controls.Add(MiPanel)

        MiPanel.Name = nombre
    End Sub

End Class