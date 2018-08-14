Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class frmImportarPregs

    Dim cnLite As New ConexionLite

    Private Sub frmImportarPregs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.Conectar()
        PanelAImportar.AutoScroll = True
    End Sub

    Dim export As New OpenFileDialog
    Dim origen As String
    Dim noma As String

    Private Sub btExplorar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExplorar.Click
        export.Filter = "igx|*.igx;*.ig;*.igad;*.sqlite"
        If export.ShowDialog = Windows.Forms.DialogResult.OK Then

            noma = Path.GetFileNameWithoutExtension(export.FileName)

            Try
                origen = export.FileName
                File.Copy(origen, Path.Combine(Application.StartupPath, noma & ".sqlite"), True)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If CheckEncriptar.Checked = True Then
                If (cnLite.Conectar(noma & ".sqlite", "olimpic")) = False Then
                    Exit Sub
                End If
            Else
                If (cnLite.Conectar(noma & ".sqlite")) = False Then
                    Exit Sub
                End If
            End If

            Dim dtCat As New DataTable

            cnLite.TraerTabla(dtCat, "select * from tbCategorias")

            Dim posy = 10

            For Each row As DataRow In dtCat.Rows

                Dim PnCats As New Categoria_A_Importar(row.Item("CatId"), cnLite)
                PnCats.Top = posy
                PanelAImportar.Controls.Add(PnCats)
                posy = PnCats.Top + PnCats.Height
            Next

        End If

    End Sub

    'Private Sub btImportar_Click(sender As Object, e As EventArgs) Handles btImportar.Click

    '    Dim domande As Integer = 0

    '    For Each Elem As Object In PanelAImportar.Controls

    '        For Each CatList As Object In Elem.Controls

    '            If (TypeOf (CatList) Is CheckedListBox) Then

    '                For Each ItemList As Object In CatList.CheckedItems
    '                    lsbImportadas.Items.Add(ItemList.item)
    '                Next

    '            End If

    '        Next

    '    Next

    '    'MsgBox(domande)

    'End Sub

    Private Sub btImportar_Click(sender As Object, e As EventArgs) Handles btImportar.Click
        ImportarPreguntas(False)
    End Sub

    Private Sub btImportarNuev_Click(sender As Object, e As EventArgs) Handles btImportarNuev.Click

        ImportarPreguntas()
    End Sub

    Private Function ImportarPreguntas(Optional Nuevas As Boolean = True) As Integer

        Dim dtCods As New DataTable

        dtCods.Columns.Add("Codigo")
        dtCods.Columns.Add("PregId")
        dtCods.Columns.Add("PregCategoria")
        dtCods.Columns.Add("PregPregunta")
        dtCods.Columns.Add("PregRespCorrect")
        dtCods.Columns.Add("PregResp2")
        dtCods.Columns.Add("PregResp3")
        dtCods.Columns.Add("PregResp4")
        dtCods.Columns.Add("PregFechaCreacion")
        dtCods.Columns.Add("PregImportada")
        dtCods.Columns.Add("PregFechaEditada")

        For Each Elem As Object In PanelAImportar.Controls

            For Each CatList As Object In Elem.Controls
                If (TypeOf (CatList) Is ListBox) Then

                    If Nuevas = True Then

                        For Each itemPreg As DataRowView In CatList.items

                            dtCods.Rows.Add((itemPreg(0)), (itemPreg(1)), (itemPreg(2)), (itemPreg(3)), (itemPreg(4)), (itemPreg(5)), (itemPreg(6)), (itemPreg(7)), (itemPreg(8)), (itemPreg(9)), (itemPreg(10)))

                        Next

                    Else

                        For Each itemPreg As DataRowView In CatList.SelectedItems

                            dtCods.Rows.Add((itemPreg(0)), (itemPreg(1)), (itemPreg(2)), (itemPreg(3)), (itemPreg(4)), (itemPreg(5)), (itemPreg(6)), (itemPreg(7)), (itemPreg(8)), (itemPreg(9)), (itemPreg(10)))

                        Next

                    End If

                End If
            Next

        Next



        For Each pato As DataRow In dtCods.Rows
            lsbImportadas.Items.Add(pato.Item("PregPregunta"))
        Next


        For Each row As DataRow In dtCods.Rows


            If Nuevas = True Then

                If row.Item("PregImportada") = 0 Then

                    Dim categ As Integer = row("PregCategoria")

                    Dim FecCre As DateTime
                    Dim FecEd As DateTime

                    If row.Item("PregFechaCreacion") = "" Then
                        FecCre = Now.Date
                    Else
                        FecCre = row.Item("PregFechaCreacion")
                    End If

                    If row.Item("PregFechaEditada") = "" Then
                        FecEd = Now.Date
                    Else
                        FecEd = row.Item("PregFechaEditada")
                    End If


                    Dim InsertCommand As New SqlCommand("Insert into tbPreguntas (PregPregunta, PregRespCorrecta, PregResp2, PregResp3, PregResp4, PregCreador, PregFechaCreacion, PregFechaEditada) " _
                                           & "Values('" & row.Item("PregPregunta") & "', '" & row.Item("PregRespCorrect") & "', '" & row.Item("PregResp2") _
                                           & "', '" & row.Item("PregResp3") & "', '" & row.Item("PregResp4") & "', 'Yeison', @FecCr, " _
                                           & " @FecEd); " & " SELECT SCOPE_IDENTITY() as Id FROM tbPreguntas", conn.Conex)
                    InsertCommand.Parameters.AddWithValue("@FecEd", FecEd)
                    InsertCommand.Parameters.AddWithValue("@FecCr", FecCre)

                    MsgBox(InsertCommand.CommandText)

                    Dim MiId As Integer = CInt(InsertCommand.ExecuteScalar())

                    conn.EjecutarConsulta("Insert into TbCatPreg(PrCaPregunta, PrCaCategoria) Values('" & MiId & "', '" & categ & "')")

                    MsgBox("La pregunta " & MiId & " fue registrada en la categoría " & categ)

                Else
                    MsgBox("no nueva")
                End If

            Else

                ' MsgBox(row.Item("PregImportada"))

                'Return 2

                If row.Item("PregImportada") = 0 Then

                    Dim categ As Integer = row("PregCategoria")

                    Dim InsertCommand As New SqlCommand("Insert into tbPreguntas (PregPregunta, PregRespCorrect, PregResp2, PregResp3, PregResp4, PregFechaCreacion, PregImportada, PregFechaEditada) " _
                                           & "Values('" & row.Item("PregPregunta") & "', '" & row.Item("PregRespCorrect") & "', '" & row.Item("PregResp2") _
                                           & ", '" & row.Item("PregResp3") & "', '" & row.Item("PregResp4") & "', '" & row.Item("PregFechaCreacion") & "', '1' " _
                                           & ", '" & row.Item("PregFechaEditada") & "'; " & "SELECT SCOPE_IDENTITY() as Id FROM tbPreguntas", conn.Conex)

                    Dim MiId As Integer = CInt(InsertCommand.ExecuteScalar())

                    conn.EjecutarConsulta("Insert into TbCatPreg(PrCaPregunta, PrCaCategoria) Values('" & MiId & "', '" & categ & "')")

                Else

                    conn.EjecutarConsulta("UPDATE tbPreguntas SET PregPregunta='" & row.Item("PregPregunta") & "', PregRespCorrecta='" & row.Item("PregRespCorrect") & "', PregResp2='" & row.Item("PregResp2") _
                                          & "', PregResp3='" & row.Item("PregResp3") & "', PregResp4='" & row.Item("PregResp4") & "' WHERE PregId='" & row.Item("PregId") & "'")

                    conn.EjecutarConsulta("Insert into TbCatPreg(PrCaPregunta, PrCaCategoria) Values('" & row("PregId") & "', '" & row("PregCategoria") & "')")

                    '                    , PregFechaEditada='" & row.Item("PregFechaEditada") & "'

                    'conn.EjecutarConsulta()

                End If

            End If

            'MsgBox("La fila " & row("PregId") & " fue editada")

        Next

        Return 2

    End Function

End Class