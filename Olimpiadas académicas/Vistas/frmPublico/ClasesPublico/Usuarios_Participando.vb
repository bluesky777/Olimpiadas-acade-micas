Public Class Usuarios_Participando
    Inherits Panel


    Property IdCat As Integer
    Property Categoria As String

    Property Listado_Mostrado As New List(Of Usuario_Conectado)

    Dim lbTituloCat As New Label


    Sub New(Codigo_Categoria As Integer, List_Usuario_Conectados As Listado_Usuarios_Conectados)

        Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        Me.BackColor = Color.Transparent
        Me.Width = 290
        Me.AutoScroll = True

        Dim dtCategoria As New DataTable

        conn.TraerTabla(dtCategoria, "select CatId, CatNombre from tbCategorias where CatId=" & Codigo_Categoria)

        Me.IdCat = Codigo_Categoria
        Me.Categoria = dtCategoria.Rows(0).Item("CatNombre")

        With lbTituloCat
            .Top = 5
            .AutoSize = True
            .Text = Me.Categoria
            .BackColor = Color.Transparent
            .Font = New Font("Calibri", 18, FontStyle.Bold)
            .ForeColor = Color.AliceBlue
            .Left = Me.Width / 2 - .Width / 2 - 10
        End With
        Me.Controls.Add(lbTituloCat)

        List_Usuario_Conectados.strBuscar = Codigo_Categoria
        Dim Listado_Mostrado = List_Usuario_Conectados.UsuariosConects.FindAll(AddressOf List_Usuario_Conectados.FiltrarUsu)

        Dim Posy As Integer = lbTituloCat.Top + lbTituloCat.Height

        For Each usu As Usuario_Conectado In Listado_Mostrado

            'Creo cada participante mostrado
            Dim Participante As New Participante_Mostrado(usu.UsuId, usu.UsuNombre, usu.EntNombreCorto)

            If usu.Respondio = "Si" Then
                Participante.Cambiar_Estado(usu.Respuesta)
            End If

            Participante.Width = Me.Width - 2
            Participante.Height = 70
            Participante.Top = Posy

            Me.Controls.Add(Participante)

            Posy = Posy + Participante.Height + 1
        Next

    End Sub




End Class
