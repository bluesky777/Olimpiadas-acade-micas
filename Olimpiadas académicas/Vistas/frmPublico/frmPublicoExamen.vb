Imports System.Data
Imports System.Text
Imports System.Data.SqlClient

Public Class frmPublicoExamen

    Dim dtPreg As New DataTable
    Dim CantidadPreg As Integer

    Dim miBinding As New BindingSource

    Private Sub frmPublicoExamen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 800
        Me.Height = 600

        conn.TraerTabla(dtPreg, "Select P.PregId, P.PregPregunta, P.PregRespCorrecta, P.PregResp2, P.PregResp3, P.PregResp4, c.PrCaOrden " _
                                         & "from tbPreguntas P INNER JOIN tbCatPreg c ON c.PrCaPregunta=P.PregId " _
                                         & "where c.PrCaCategoria=" & frmManagerChat.cbCategoria.SelectedValue & " and c.PrCaParaExamen=1")

        Me.CantidadPreg = dtPreg.Rows.Count
        miBinding.DataSource = dtPreg

        lbTiempo.Text = 0


        Me.lbCantPreg.Text = dtPreg.Rows.Count
        Me.miBinding.DataSource = dtPreg


        lbPregunta.DataBindings.Add("Text", miBinding, "PregPregunta")
        LbCorrecta.DataBindings.Add("Text", miBinding, "PregRespCorrecta")
        LbResp2.DataBindings.Add("Text", miBinding, "PregResp2")
        LbResp3.DataBindings.Add("Text", miBinding, "PregResp3")
        LbResp4.DataBindings.Add("Text", miBinding, "PregResp4")
        lbOrdenResp.DataBindings.Add("Text", miBinding, "PrCaOrden")
        lbPregId.DataBindings.Add("Text", miBinding, "PregId")

        Try
            frmManagerChat.lbOrdenResp.DataBindings.Clear()
            frmManagerChat.lbOrdenResp.DataBindings.Add("Text", Me.miBinding, "SelOrden")
        Catch ex As Exception

        End Try

        lbNumPreg.Text = frmManagerChat.NumericActual.Value
        lbCategoría.Text = frmManagerChat.cbCategoria.Text

        If frmManagerChat.NumericActual.Value < miBinding.Count Then
            Me.miBinding.Position = frmManagerChat.NumericActual.Value - 1
        Else
            frmManagerChat.NumericActual.Value = miBinding.Count
        End If



        ArreglarLabel()
        PosicionesRespuestas()

        Timer1.Enabled = True
    End Sub


    Private Sub ArreglarLabel()
        ArreglarRespuesta(LbResp2)
        ArreglarRespuesta(LbResp3)
        ArreglarRespuesta(LbResp4)
        ArreglarRespuesta(LbCorrecta)

        With lbPregunta
            Select Case Len(.Text)
                Case Is < 60
                    .Font = New Font("Calibri", 20)
                Case Is < 200
                    .Font = New Font("Calibri", 17)
                Case Is < 300
                    .Font = New Font("Calibri", 15)
                Case Is < 400
                    .Font = New Font("Calibri", 14)
                Case Is < 500
                    .Font = New Font("Calibri", 13)
                Case Is < 600
                    .Font = New Font("Calibri", 12)
                Case Is < 750
                    .Font = New Font("Calibri", 11)
                Case Is < 900
                    .Font = New Font("Calibri", 10)
                Case Is < 1101
                    .Font = New Font("Calibri", 9)
            End Select
            .MaximumSize = New Size(PanelPreg.Width, 0)
        End With

        CentrarObjeto(lbPregunta, PanelPreg)
        CentrarObjeto(LbResp2, PanelResp2)
        CentrarObjeto(LbResp3, PanelResp3)
        CentrarObjeto(LbResp4, PanelResp4)
        CentrarObjeto(LbCorrecta, PanelRespCorr)

    End Sub


    Private Sub ArreglarRespuesta(ByVal lbControl As Label)
        With lbControl
            .MaximumSize = New Size(250, 0)
            Select Case Len(lbControl.Text)
                Case Is < 30
                    .Font = New Font("Calibri", 18)
                Case Is < 50
                    .Font = New Font("Calibri", 16)
                Case Is < 75
                    .Font = New Font("Calibri", 15)
                Case Is < 100
                    .Font = New Font("Calibri", 13)
                Case Is < 130
                    .Font = New Font("Calibri", 11)
                Case Is < 175
                    .Font = New Font("Calibri", 10)
                Case Is < 251
                    .Font = New Font("Calibri", 9)
            End Select
        End With

    End Sub

    Private Sub CentrarObjeto(ByVal controlC As Control, ByVal PanelC As Control)
        With controlC
            .Top = ((PanelC.Height - .Height) / 2)
            .Left = ((PanelC.Width - .Width) / 2)
        End With
    End Sub


    Private Sub PosicionesRespuestas()
        Select Case frmManagerChat.lbOrdenResp.Text
            Case 1
                PanelRespCorr.Top = 385
                PanelRespCorr.Left = 105

                PanelResp2.Top = 385
                PanelResp2.Left = 555

                PanelResp3.Top = 495
                PanelResp3.Left = 105

                PanelResp4.Top = 495
                PanelResp4.Left = 555
            Case 2
                PanelResp4.Top = 385
                PanelResp4.Left = 105

                PanelRespCorr.Top = 385
                PanelRespCorr.Left = 555

                PanelResp2.Top = 495
                PanelResp2.Left = 105

                PanelResp3.Top = 495
                PanelResp3.Left = 555
            Case 3
                PanelResp3.Top = 385
                PanelResp3.Left = 105

                PanelResp4.Top = 385
                PanelResp4.Left = 555

                PanelRespCorr.Top = 495
                PanelRespCorr.Left = 105

                PanelResp2.Top = 495
                PanelResp2.Left = 555
            Case 4
                PanelResp2.Top = 385
                PanelResp2.Left = 105

                PanelResp3.Top = 385
                PanelResp3.Left = 555

                PanelResp4.Top = 495
                PanelResp4.Left = 105

                PanelRespCorr.Top = 495
                PanelRespCorr.Left = 555
        End Select


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbTiempo.Text += 1
    End Sub
End Class