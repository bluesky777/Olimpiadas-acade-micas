Public Class Resultados
    Inherits Panel

    Dim posy = 3
    Dim tim As New Timer

    Sub New(ByVal dtResult As DataTable)

        'Me.Top = frmInicio.cbCategoria.Top + frmInicio.cbCategoria.Height + 20
        'Me.Height = frmInicio.btNuevaPreg.Top - Me.Top - 20
        'Me.Width = frmInicio.Width - 10
        'Me.BorderStyle = Windows.Forms.BorderStyle.None
        'Me.AutoScroll = True
        'Me.Left = frmInicio.Width - 180

        For i = 0 To dtResult.Rows.Count - 1

            Dim novaElem As New Elemento(dtResult.Rows(i))
            novaElem.Top = posy
            novaElem.Name = "Elem" & dtResult.Rows(i).Item("PregId")
            Me.Controls.Add(novaElem)
            posy += 30
        Next

        Encender()

        AddHandler tim.Tick, AddressOf posPan
    End Sub

    Private Sub posPan()
        If Me.Left > 5 Then
            Me.Left -= 15
        Else
            tim.Enabled = False
            Me.Left = 5
        End If
    End Sub

    Private Sub Encender()
        tim.Interval = 1
        tim.Enabled = True
    End Sub

End Class
