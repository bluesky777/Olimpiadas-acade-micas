Imports System.IO
Imports System.Data.SqlClient
Imports System.Threading

Public Class frmExportarPreguntas

    Dim cnLite As New ConexionLite
    Dim UsuExport As String
    Dim LUsu As String
    Dim LPass As String


    Private Sub frmExportarPreguntas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbMensajeDB.Text = "Aqui puede crear una base de datos para un usuario, " & vbCrLf & "luego importarla con los cambios que este halla realizado."
        lbMensajeEx.Text = "Tal vez desee crear un archivo de excel con todas las preguntas " & vbCrLf & "y respuestas, pero debe ser cuidadoso, ya que cualquier persona" & vbCrLf & "podría acceder este. Use esta opción con mucha responsabilidad."

        Cargar()
    End Sub

    Dim dtCategorias As New DataTable

    Private Sub Cargar()

        conn.TraerTabla(dtCategorias, "Select CatId, CatNombre from tbCategorias")

        lsbCategorias.DataSource = dtCategorias
        lsbCategorias.DisplayMember = "CatNombre"
        lsbCategorias.ValueMember = "CatId"

        lsbCategorias2.DataSource = dtCategorias
        lsbCategorias2.DisplayMember = "CatNombre"
        lsbCategorias2.ValueMember = "CatId"


    End Sub


    Dim LCatCont As Integer = 0

    Private Sub btExportDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExportDB.Click

        UsuExport = txtUsuario.Text

        LUsu = Me.txtUsuario.Text
        LPass = Me.txtPass.Text

        If LUsu = "" Then
            MsgBox("Debe ingresar el usuario que manipulará las preguntas exportadas.", MsgBoxStyle.Information, "Incompleto")
            txtUsuario.Focus()
            Exit Sub
        End If
        If LPass = "" Then
            MsgBox("Debe ingresar una contraseña.", MsgBoxStyle.Information, "Incompleto")
            txtPass.Focus()
            Exit Sub
        End If


        If CheckEncript.Checked = True Then
            If cnLite.CrearDB(UsuExport & ".sqlite", "olimpic", True) = False Then
                Exit Sub
            End If
            cnLite.Conectar(, "olimpic")
        Else
            If cnLite.CrearDB(UsuExport & ".sqlite", , True) = False Then
                Exit Sub
            End If
            cnLite.Conectar()
        End If




        '*****************************************************************
        'CREAMOS LA TABLA DEL USUARIO QUE MANIPULARÁ ESTA BASE DE DATOS
        '*****************************************************************
        Dim Continuador As Boolean = True

        cnLite.EjecutarConsulta("CREATE TABLE 'tbUsuario' ('UsuId' INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL , 'UsuNombre' VARCHAR(50) , 'UsuPass' VARCHAR(25))")
        Continuador = cnLite.EjecutarConsulta("Insert into 'tbUsuario' ('UsuNombre','UsuPass') VALUES ('" & LUsu & "', '" & LPass & "')")

        If Continuador = False Then
            MsgBox("No se pudo crear la tabla usuario.", MsgBoxStyle.Critical, "Exportación incorrecta")
            cnLite.Desconectar()
            Exit Sub
        End If



        '*****************************************************************
        'CREAMOS LA TABLA DE CATEGORIAS
        '*****************************************************************
        cnLite.EjecutarConsulta("CREATE TABLE 'tbCategorias' ('Codigo' INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL , 'CatId' INTEGER, 'CatNombre' VARCHAR(100) , 'CatMateria' VARCHAR(100))")

        Dim dtCate As New DataTable

        For Each Seleccionado As DataRowView In lsbCategorias.SelectedItems

            conn.TraerTabla(dtCate, "Select * from tbCategorias where CatId='" & Seleccionado(0) & "'")

        Next

        For Each item As DataRow In dtCate.Rows

            Dim LIdCat As String = item("CatId")
            Dim LCatN As String = item("CatNombre")
            Dim LCatM As String = item("CatTema")

            Dim Comprobar As String = cnLite.EjecutarConsulta("Insert into 'tbCategorias' ('CatId','CatNombre', 'CatMateria') VALUES ('" & LIdCat & "', '" & LCatN & "', '" & LCatM & "')")

            If Comprobar = True Then
                LCatCont += 1
            Else
                MsgBox("No se agregó las categorías, proceso cancelado. ")
            End If


        Next


        InsercionPreguntas()


    End Sub


    Private Sub InsercionPreguntas()


        '*****************************************************************
        'CREAMOS LA TABLA DE PREGUNTAS Y LA LLENAMOS
        '*****************************************************************
        Dim Continuador As Boolean = cnLite.EjecutarConsulta("CREATE  TABLE 'tbPreguntas' ('Codigo' INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL , 'PregId' INTEGER, 'PregCategoria' INTEGER, 'PregPregunta' VARCHAR(1000), 'PregRespCorrect' VARCHAR(250), 'PregResp2' VARCHAR(250), 'PregResp3' VARCHAR(250), 'PregResp4' VARCHAR(250), 'PregCreador' VARCHAR(50), 'PregFechaCreacion' DATETIME, 'PregImportada' INTEGER(1), 'PregFechaEditada' DATETIME NULL )")

        If Continuador = False Then
            cnLite.Desconectar()
            Exit Sub
        End If

        Dim dtPreg As New DataTable

        For Each Seleccionado As DataRowView In lsbCategorias.SelectedItems

            conn.TraerTabla(dtPreg, "select * from tbPreguntas, tbCatPreg, tbCategorias  where CatId=PrCaCategoria and PrCaPregunta=PregId and CatId='" & Seleccionado(0) & "'")

        Next


        frmExportEstado.Height = 100
        frmExportEstado.Show()

        frmExportEstado.ProgressPregExport.Minimum = 0
        frmExportEstado.ProgressPregExport.Maximum = dtPreg.Rows.Count
        frmExportEstado.ProgressPregExport.Value = 0


        Dim ContExi As Integer = 0, ContMal As Integer = 0

        Dim contItem As Integer = 0

        For Each item As DataRow In dtPreg.Rows


            Dim LCat As String = item("CatId")
            Dim LCod As String = item("PregId")
            Dim LPreg As String = item("PregPregunta")
            Dim LCorr As String = item("PregRespCorrecta")
            Dim Lr1 As String = item("PregResp2")
            Dim Lr2 As String = item("PregResp3")
            Dim Lr3 As String = item("PregResp4")
            Dim LFechCr As Date, LFeCrParam As SQLiteParameter
            Dim LFechEd As Date, LFeEdParam As SQLiteParameter

            Try
                LFechCr = item("PregFechaCreacion")
            Catch ex As Exception
                LFechCr = "" 'El valor de la base de datos puede ser null
            End Try


            Try
                LFechEd = item("PregFechaEditada")
            Catch ex As Exception
                LFechEd = "" 'El valor de la base de datos puede ser null
            End Try

            LFeCrParam = New SQLiteParameter("@fechaCr", LFechCr)
            LFeEdParam = New SQLiteParameter("@fechaEd", LFechEd)


            Dim cmdInsert As New SQLiteCommand("Insert into 'tbPreguntas' ('PregCategoria', 'PregId','PregPregunta', 'PregRespCorrect', 'PregResp2', 'PregResp3', 'PregResp4', 'PregFechaCreacion', 'PregImportada', 'PregFechaEditada') " _
                                   & " VALUES ('" & LCat & "', '" & LCod & "', '" & LPreg & "', '" & LCorr & "', '" & Lr1 & "', '" & Lr2 & "', '" & Lr3 & "', @fechaCr, '1', @fechaEd)", cnLite.ConL)

            cmdInsert.Parameters.Add(LFeCrParam)
            cmdInsert.Parameters.Add(LFeEdParam)

            Try

                cmdInsert.ExecuteNonQuery()
                ContExi += 1
            Catch ex As Exception
                ContMal += 1
                MsgBox(ex.Message)
            End Try


            contItem += 1
            frmExportEstado.ProgressPregExport.Value = contItem

        Next

        cnLite.Desconectar()

        frmExportEstado.lbEstadoFinal.Text = "Total categorías=" & LCatCont & " - Preguntas exportadas: " & ContExi & " - Preguntas errores: " & ContMal
        frmExportEstado.Text = "Proceso terminado"

        frmExportEstado.lstExportados.DataSource = dtPreg
        frmExportEstado.lstExportados.DisplayMember = "PregPregunta"


        frmExportEstado.Height = 327
    End Sub



    Private Sub CheckVer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckVer.CheckedChanged


        With CheckVer
            If .Checked = True Then
                txtPass.PasswordChar = ""
                txtPass.Font = New Font("Microsoft Sans Serif", 10)
            Else
                txtPass.PasswordChar = "*"
                txtPass.Font = New Font("Microsoft Sans Serif", 12)
            End If
        End With

    End Sub

End Class