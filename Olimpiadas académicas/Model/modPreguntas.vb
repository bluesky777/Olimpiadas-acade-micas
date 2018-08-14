Public Class modPreguntas
    Inherits ModBase


#Region "Contructores"

    Sub New(Codigo As Integer)
        MyBase.New(Codigo)
    End Sub


    Sub New()
        MyBase.New()
        ' Se pasan los datos después
    End Sub
#End Region

    Public Overrides Sub Starting()
        Me.TableName = "Preguntas"
        Me.Prefix = "Preg"


    End Sub



    Public Shared Function MostrarPregunta(idCat As Integer, numPreg As Integer, ByRef lbTitulo As Label, ByRef lbRes1 As Label, ByRef lbRes2 As Label, ByRef lbRes3 As Label, ByRef lbRes4 As Label, Optional MostrarCorrecta As Boolean = False) As Integer

        If idCat = 0 Then
            lbTitulo.Text = "No has seleccionado ningúna categoría."
            lbRes1.Text = ""
            lbRes2.Text = ""
            lbRes3.Text = ""
            lbRes4.Text = ""
            Return 0
        ElseIf numPreg = 0 Then
            lbTitulo.Text = "No has seleccionado el número de pregunta."
            lbRes2.Text = ""
            lbRes3.Text = ""
            lbRes4.Text = ""
            Return 0
        End If

        Dim arrMod As ModBase() = {New modPreguntas}

        Dim m_CatPreg As New modCatPreg
        m_CatPreg.getTable(, "PrCaCategoria=" & idCat & "  AND PrCaParaExamen=1")


        If m_CatPreg.dt.Rows.Count = 0 Then
            lbTitulo.Text = "La categoría seleccionada no tiene preguntas asignadas al examen."
            lbRes1.Text = ""
            lbRes2.Text = ""
            lbRes3.Text = ""
            lbRes4.Text = ""
            Return 0
        ElseIf m_CatPreg.dt.Rows.Count < (numPreg + 1) Then
            lbRes1.Text = ""
            lbRes2.Text = ""
            lbRes3.Text = ""
            lbRes4.Text = ""
            Return 0
        End If


        m_CatPreg.Row = m_CatPreg.dt.Rows(numPreg - 1)

        lbTitulo.Text = m_CatPreg.Row.Item("PregPregunta")
        Dim orden As Integer = m_CatPreg.Row.Item("PrCaOrden")

        Select Case orden
            Case 1
                If MostrarCorrecta = True Then
                    lbRes1.Text = ".:: " & m_CatPreg.Row.Item("PregRespCorrecta") & " ::."
                Else
                    lbRes1.Text = m_CatPreg.Row.Item("PregRespCorrecta")
                End If

                lbRes2.Text = m_CatPreg.Row.Item("PregResp2")
                lbRes3.Text = m_CatPreg.Row.Item("PregResp3")
                lbRes4.Text = m_CatPreg.Row.Item("PregResp4")

            Case 2
                If MostrarCorrecta = True Then
                    lbRes2.Text = ".:: " & m_CatPreg.Row.Item("PregRespCorrecta") & " ::."
                Else
                    lbRes2.Text = m_CatPreg.Row.Item("PregRespCorrecta")
                End If

                lbRes1.Text = m_CatPreg.Row.Item("PregResp4")
                lbRes3.Text = m_CatPreg.Row.Item("PregResp2")
                lbRes4.Text = m_CatPreg.Row.Item("PregResp3")

            Case 3
                If MostrarCorrecta = True Then
                    lbRes3.Text = ".:: " & m_CatPreg.Row.Item("PregRespCorrecta") & " ::."
                Else
                    lbRes3.Text = m_CatPreg.Row.Item("PregRespCorrecta")
                End If

                lbRes1.Text = m_CatPreg.Row.Item("PregResp3")
                lbRes2.Text = m_CatPreg.Row.Item("PregResp4")
                lbRes4.Text = m_CatPreg.Row.Item("PregResp2")

            Case 4
                If MostrarCorrecta = True Then
                    lbRes4.Text = ".:: " & m_CatPreg.Row.Item("PregRespCorrecta") & " ::."
                Else
                    lbRes4.Text = m_CatPreg.Row.Item("PregRespCorrecta")
                End If

                lbRes1.Text = m_CatPreg.Row.Item("PregResp2")
                lbRes2.Text = m_CatPreg.Row.Item("PregResp3")
                lbRes3.Text = m_CatPreg.Row.Item("PregResp4")

        End Select

        Return orden

    End Function

End Class
