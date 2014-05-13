Public Class frmPublicoImagen

    Private Sub frmPublicoImagen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 600
        Me.Width = 800

        Me.BackColor = Color.Blue
        Me.BackgroundImage = frmManagerChat.pbPrevio.Image
        Me.BackgroundImageLayout = ImageLayout.Zoom
    End Sub
End Class