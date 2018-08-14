

Public Class Categoria_A_Importar

    Inherits Panel

    Dim checkCat As New CheckBox
    'Private listadoPregs As CheckedListBox
    Private listadoPregs As ListBox

    Sub New(ByVal Codigo_Categoria As Integer, ByVal Conexion_Actual As ConexionLite)



        listadoPregs = New ListBox
        Dim dtPregs As New DataTable

        listadoPregs.SelectionMode = SelectionMode.MultiExtended

        AddHandler (checkCat.CheckedChanged), AddressOf CheckedClic


        Conexion_Actual.TraerTabla(dtPregs, "select * from tbPreguntas, tbCategorias where CatId=PregCategoria and CatId=" & Codigo_Categoria)

        Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        Me.Height = 150
        Me.Width = frmImportarPregs.PanelAImportar.Width - 10
        Me.Top = 5
        Me.Left = 5
        'Me.AutoScroll = True


        checkCat.Text = "Seleccionar todas de " & dtPregs.Rows(0).Item("CatNombre")
        checkCat.Top = 3
        checkCat.Width = frmImportarPregs.PanelAImportar.Width - 20
        checkCat.Left = 10
        ListadoPregs.Top = checkCat.Height + 5
        ListadoPregs.Width = frmImportarPregs.PanelAImportar.Width - 20
        ListadoPregs.Height = Me.Height - checkCat.Height - 10
        ListadoPregs.Left = 10


        'For Each domanda As DataRow In dtPregs.Rows
        '    listadoPregs.Items.Add(domanda.Item("PregPregunta"))
        'Next

        listadoPregs.DataSource = dtPregs
        listadoPregs.DisplayMember = "PregPregunta"
        listadoPregs.ValueMember = "Codigo"

        Me.Controls.Add(checkCat)
        Me.Controls.Add(listadoPregs)


    End Sub

    Private Sub CheckedClic()
        If checkCat.CheckState = CheckState.Checked Then
            For i As Integer = 0 To listadoPregs.Items.Count - 1
                'listadoPregs.SetItemChecked(i, True)
                listadoPregs.SetSelected(i, True)
            Next
        Else
            For i As Integer = 0 To listadoPregs.Items.Count - 1
                listadoPregs.SetSelected(i, False)
            Next
        End If


    End Sub

End Class




'Public Class Controllare
'    Inherits CheckBox

'    Protected Overrides Sub OnCheckedChanged(e As EventArgs)
'        MyBase.OnCheckedChanged(e)
'        If Me.CheckState = Windows.Forms.CheckState.Checked Then
'            For Each voce As CheckBox In listadoPregs.CheckedItems
'                voce.CheckState = Windows.Forms.CheckState.Checked
'            Next
'        Else
'            For Each voce As CheckBox In listadoPregs.CheckedItems
'                voce.CheckState = Windows.Forms.CheckState.Unchecked
'            Next
'        End If
'    End Sub
'End Class

