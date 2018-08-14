Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections


Public Class frmPublicoParticipantes

    Dim Altura As Integer = 20, posx As Integer = 10


    Private Sub frmPublico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Height = 600
        Me.Width = 800
        Me.AutoScroll = True

        posx = 10
        Altura = 20

    End Sub


    Public Sub MostrarUsus(Usus As Listado_Usuarios_Conectados)

        Dim i As Integer
        Dim ultimox As Integer = 5

        For i = 0 To frmManagerChat.ltCategAMostrar.Items.Count - 1

            Dim PanelParticipantes As New Usuarios_Participando(frmManagerChat.idsCat(i), Usus)
            PanelParticipantes.Top = 10
            PanelParticipantes.Left = ultimox
            PanelParticipantes.Height = 570
            ultimox += PanelParticipantes.Width + 5

            Me.Controls.Add(PanelParticipantes)

        Next


    End Sub


End Class