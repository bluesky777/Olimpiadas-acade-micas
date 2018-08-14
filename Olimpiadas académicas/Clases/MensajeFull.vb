Public Class MensajeFull

    Inherits Form

    Dim frmPreg As New Form
    Dim frmPadre As Form
    Property resp As Integer = 0

    Dim btNo As New Button
    Dim btSi As New Button

    Sub New(Titulo As String, Pregunta As String, _frmPadre As Form)
        Me.Height = My.Computer.Screen.Bounds.Height
        Me.Width = My.Computer.Screen.Bounds.Width
        Me.Top = 0
        Me.Left = 0
        Me.Opacity = 0.4
        Me.BackColor = Color.Black
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        frmPadre = _frmPadre

        AddHandler Me.GotFocus, AddressOf frmPreg_GotFocus

        With frmPreg
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .BackColor = Color.Black
            .Opacity = 0.9
            .Width = My.Computer.Screen.Bounds.Width
            .Height = 240
            .StartPosition = FormStartPosition.CenterScreen

            AddHandler .FormClosed, AddressOf frmPreg_Cerrado

        End With


        Dim mipanel As New Panel

        frmPreg.Controls.Add(mipanel)
        With mipanel
            .AutoSize = True
            .BackColor = Color.Black
            .Width = 600
            .Height = 180
            .Top = (frmPreg.Height - mipanel.Height) / 2
            .Left = frmPreg.Width / 2 - mipanel.Width / 2

        End With


        Dim lbTitu As New Label
        With lbTitu
            .AutoSize = True
            .Text = Titulo
            .Top = 20
            .Left = 10
            .Width = 400
            .Height = 40
            .Font = New Font("Calibri", 20)
            .ForeColor = Color.White

            mipanel.Controls.Add(lbTitu)
        End With

        Dim lbPreg As New Label
        With lbPreg
            .AutoSize = True
            .Text = Pregunta
            .Top = lbTitu.Top + lbTitu.Height + 10
            .Left = 20
            .Width = 400
            .Font = New Font("Calibri", 12)
            .ForeColor = Color.White

            mipanel.Controls.Add(lbPreg)
        End With


        With btSi
            .Text = "Si"
            .Top = lbPreg.Top + lbPreg.Height + 20
            .Left = 120
            .Font = New Font("Calibri", 12)
            .ForeColor = Color.White
            .Height = 35
            .Width = 90
            .Cursor = Cursors.Hand

            AddHandler .Click, AddressOf Click_Si
        End With
        mipanel.Controls.Add(btSi)



        With btNo
            .Text = "No"
            .Top = btSi.Top
            .Left = btSi.Left + btSi.Width + 20
            .Font = New Font("Calibri", 12)
            .ForeColor = Color.White
            .Height = 35
            .Width = 90
            .Cursor = Cursors.Hand


            AddHandler .Click, AddressOf Click_No
        End With
        mipanel.Controls.Add(btNo)


    End Sub



    Public Sub Mostrar()
        Me.Show()
        Me.frmPreg.Show()
    End Sub

    Private Sub Click_No(sender As Object, e As EventArgs)
        resp = 0
        frmPreg.Close()
        frmPadre.Show()
    End Sub

    Private Sub Click_Si(sender As Object, e As EventArgs)
        resp = 1
        frmPreg.Close()
        frmPadre.Show()
    End Sub

    Private Sub frmPreg_Cerrado(sender As Object, e As FormClosedEventArgs)
        Me.Close()
        frmPadre.Show()
    End Sub

    Private Sub frmPreg_GotFocus(sender As Object, e As EventArgs)

        frmPreg.Show()
        frmPreg.Focus()

    End Sub





End Class
