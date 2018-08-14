
Imports Microsoft.Office.Interop



Public Class classExportarExcel


    Public Function GridAExcel(ByVal ElGrid As DataGridView, Optional SubEncabezado As String = "") As Boolean

        'Creamos las variables
        Dim exApp As New Excel.Application
        Dim exLibro As Excel.Workbook
        Dim exHoja As Excel.Worksheet
        Try

            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try

        ' ¿Cuantas columnas y cuantas filas?
        Dim NCol As Integer = ElGrid.ColumnCount
        Dim NRow As Integer = ElGrid.RowCount



        'Colocamos el título del archivo
        exHoja.Range("A2:I2").MergeCells = True
        exHoja.Range("A2").Font.Bold = True
        exHoja.Range("A2").Font.Size = 16
        'exHoja.Range("A2").Font.FontStyle = New Font("Calibri", 16, FontStyle.Bold)
        exHoja.Cells.Item(2, 1).HorizontalAlignment = Excel.Constants.xlCenter
        exHoja.Cells.Item(2, 1) = m_Eventos.Row.Item("EvNombre") ' Olimpiadas Académicas Libertad 2013

        exHoja.Range("A3:I3").MergeCells = True
        exHoja.Range("A3").Font.Bold = True
        exHoja.Range("A3").Font.Size = 16
        'exHoja.Range("A3").Font.FontStyle = New Font("Calibri", 16, FontStyle.Bold)
        exHoja.Cells.Item(3, 1).HorizontalAlignment = Excel.Constants.xlCenter
        exHoja.Cells.Item(3, 1) = SubEncabezado



        ' Por cada fila extra que añada para los títulos de cada categoría, se suma una fila al total
        Dim contFilasExtras As Int16 = 5

        'Variable para moverme de columna en columna en una fila para agregar los datos
        Dim NumsColumna As New ArrayList
        With NumsColumna
            .Add(0)
            .Add(3)
            .Add(4)
            .Add(6)
            .Add(8)
            .Add(9)
            .Add(10)
            .Add(13)
            .Add(12)
        End With

        For Fila As Integer = 0 To NRow - 1


            'Si la segunda columna de esta fila dice True, es porque debo agregar una fila con títulos
            If ElGrid.Rows(Fila).Cells(2).Value = "True" Then

                'Para agregar la fila con sus títulos, debo recorrer las columnas del DataGrid
                For numColum As Integer = 0 To NumsColumna.Count - 1

                    'Colocamos el título de la Categoría
                    exHoja.Range("A" & (Fila + contFilasExtras) & ":I" & (Fila + contFilasExtras)).MergeCells = True
                    exHoja.Range("A" & (Fila + contFilasExtras)).Font.Bold = True
                    exHoja.Range("A" & (Fila + contFilasExtras)).HorizontalAlignment = Excel.Constants.xlCenter

                    exHoja.Cells.Item(Fila + contFilasExtras, 1) = ElGrid.Rows(Fila).Cells(NumsColumna(1)).Value


                    'Colocamos los subtítulos de los encabezados para los exámenes que se pondrán después
                    exHoja.Cells.Item(Fila + contFilasExtras + 1, numColum + 1) = ElGrid.Columns(NumsColumna(numColum)).Name.ToString
                    exHoja.Range("A" & (Fila + contFilasExtras + 1) & ":I" & (Fila + contFilasExtras + 1)).Font.Bold = True
                    exHoja.Range("A" & (Fila + contFilasExtras + 1) & ":I" & (Fila + contFilasExtras + 1)).Borders.LineStyle = 1

                Next

                contFilasExtras += 1

            Else
                ' Si es una fila normal, se añade normalmente
                For numColum As Integer = 0 To NumsColumna.Count - 1
                    exHoja.Cells.Item(Fila + contFilasExtras, numColum + 1) = ElGrid.Rows(Fila).Cells(NumsColumna(numColum)).Value

                    ' Hay filas en el DataGrid que están vacías, a esas no les quiero poner bordes
                    Try
                        If ElGrid.Rows(Fila).Cells(NumsColumna(numColum)).Value <> "" Then
                            exHoja.Range("A" & (Fila + contFilasExtras) & ":I" & (Fila + contFilasExtras)).Borders.LineStyle = 1
                        End If
                    Catch ex As Exception

                    End Try


                Next

            End If

        Next

        'Que el tamaño de la columna se ajuste al texto
        exHoja.Columns.AutoFit()

        'exHoja.Shapes.AddPicture(IO.Path.Combine(Application.StartupPath, "Images/Logo AOL.jpg"), Microsoft.Office.Core.MsoTriState.msoCTrue, Microsoft.Office.Core.MsoTriState.msoCTrue, 0, 0, 100, 70)


        Dim FilaFooter As Integer = NRow + contFilasExtras + 3
        exHoja.Range("A" & FilaFooter & ":I" & FilaFooter + 6).MergeCells = True
        exHoja.Range("A" & FilaFooter & ":I" & FilaFooter + 6).HorizontalAlignment = Excel.Constants.xlCenter
        exHoja.Range("A" & FilaFooter & ":I" & FilaFooter + 6).VerticalAlignment = Excel.Constants.xlTop
        exHoja.Range("A" & FilaFooter & ":I" & FilaFooter + 6).WrapText = True
        exHoja.Range("A" & FilaFooter & ":I" & FilaFooter).Value = m_Eventos.Row.Item("EvFooterReport")

        'Aplicación visible
        exApp.Application.Visible = True

        exHoja = Nothing
        exLibro = Nothing
        exApp = Nothing

        Return True

    End Function

End Class
