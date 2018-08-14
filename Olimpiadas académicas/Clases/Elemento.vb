Public Class Elemento
    Inherits Panel
    Property SelectedPregElem As Integer

    Sub New(ByVal drPreg As DataRow)
        Dim labelCod As New LabelPreg(drPreg)
        Dim labelPreg As New LabelPreg(drPreg)
        Me.SelectedPregElem = drPreg.Item("PregId")
        Me.BorderStyle = Windows.Forms.BorderStyle.None
        labelCod.Text = drPreg.Item("PregId")
        LabelPreg.Text = drPreg.Item("PregPregunta")
        LabelPreg.Left = 3
        'LabelPreg.Width = frmInicio.Width - 20
        labelCod.ForeColor = Color.DeepPink
        LabelPreg.ForeColor = Color.White
        labelCod.Left = LabelPreg.Width + 20
        LabelPreg.Top = 8
        labelCod.BackColor = Color.Transparent
        LabelPreg.BackColor = Color.Transparent

        Me.Height = LabelPreg.Height + 5
        'Me.Width = frmInicio.Width - 20
        Me.Location = New Point(3, 0)
        Me.Controls.Add(labelCod)
        Me.Controls.Add(labelPreg)

        AddHandler labelCod.MouseMove, AddressOf Colorear
        AddHandler labelPreg.MouseMove, AddressOf Colorear
        AddHandler Me.MouseMove, AddressOf Colorear

        AddHandler labelCod.MouseLeave, AddressOf Descolorear
        AddHandler labelPreg.MouseLeave, AddressOf Descolorear
        AddHandler Me.MouseLeave, AddressOf Descolorear
    End Sub

    Private Sub Colorear()
        Me.BackColor = Color.BlueViolet
    End Sub

    Private Sub Descolorear()
        Me.BackColor = Color.DeepPink
    End Sub

End Class

Public Class LabelPreg
    Inherits Label
    Property SelectedPregLabel As Integer

    Sub New(ByVal drPreg2 As DataRow)
        Me.SelectedPregLabel = drPreg2.Item("PregId")
    End Sub

    Protected Overrides Sub OnMouseClick(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseClick(e)
    End Sub

End Class
