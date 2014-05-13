Imports System.Data
Imports System.Data.SqlClient


Public Class frmCategorias
    Dim daUsuario As SqlDataAdapter
    Dim dtCategoria As New DataTable
    Private mibinding As New BindingSource

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmAdministrador.Show()
        Hide()
    End Sub

    Private Sub frmCategorias_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        conn.EjecutarConsulta("delete from tbEquipos where EquiLogin='" & Login & "'")
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Actalizar()

        GridView1.DataSource = mibinding
        txt1.DataBindings.Add("text", mibinding, "Código")
        txt2.DataBindings.Add("text", mibinding, "Nombre")
        txt3.DataBindings.Add("text", mibinding, "Materia")
        txt4.DataBindings.Add("text", mibinding, "Nombre Corto")
        txt5.DataBindings.Add("text", mibinding, "Grado")
        txt6.DataBindings.Add("text", mibinding, "Duración")
    End Sub

    Private Sub Actalizar()

        conn.TraerTabla(dtCategoria, "select C.catId as Código,C.catNombre as Nombre, C.catMateria as Materia, C.catNombreCorto as 'Nombre Corto', C.catGrado as Grado, C.CatDuracion as Duración from tbCategorias C")

        mibinding.DataSource = dtCategoria
    End Sub

    Private Sub btEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        If MsgBox("¿Está seguro?", vbYesNo, "Drooly - Confirmar ") = vbYes Then
            conn.EjecutarConsulta("delete from tbCategorias where catId =" & txt1.Text)
            Actalizar()

        End If
    End Sub

    Private Sub btNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNuevo.Click
        If btNuevo.Text = "Nuevo" Then
            btGuardar.Enabled = True
            btNuevo.Text = "Cancelar"
            btNuevo.Text = "Cancelar"
            btEditar.Text = "Editar"
            btEditar.Enabled = False
            btEliminar.Enabled = False
            txt1.Enabled = True
            txt2.Enabled = True
            txt3.Enabled = True
            txt4.Enabled = True
            txt5.Enabled = True
            txt6.Enabled = True
            mibinding.AddNew()
        Else
            btNuevo.Text = "Nuevo"
            btGuardar.Enabled = False
            btEditar.Enabled = True
            btEliminar.Enabled = True
            txt1.Enabled = False
            txt2.Enabled = False
            txt3.Enabled = False
            txt4.Enabled = False
            txt5.Enabled = False
            txt6.Enabled = False
            mibinding.CancelEdit()

        End If
    End Sub

    Private Sub btEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditar.Click
        If btEditar.Text = "Editar" Then
            btEditar.Text = "Cancelar"
            btGuardar.Enabled = True
            btEliminar.Enabled = False
            btEditar.Text = "Cancelar"
            btNuevo.Text = "Nuevo"
            txt2.Enabled = True
            txt3.Enabled = True
            txt4.Enabled = True
            txt5.Enabled = True
            txt6.Enabled = True
        Else
            txt2.Enabled = False
            txt3.Enabled = False
            txt4.Enabled = False
            txt5.Enabled = False
            txt6.Enabled = False
            btEditar.Text = "Editar"
            btGuardar.Enabled = False
            btEliminar.Enabled = True
        End If
    End Sub

    Private Sub btGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGuardar.Click
        If btEditar.Text = "Cancelar" Then
            conn.EjecutarConsulta("Update tbCategorias set CatNombre='" & txt2.Text & "', CatMateria='" & txt3.Text & "', CatNombreCorto='" & txt4.Text & "', CatGrado='" & txt5.Text & "', CatDuracion=" & txt6.Text & " where CatId='" & txt1.Text & "'")
            btEditar.Text = "Editar"
        Else
            conn.EjecutarConsulta("insert into tbCategorias(CatNombre, CatMateria, CatNombreCorto, CatGrado) values('" & txt2.Text & "','" & txt3.Text & "','" & txt4.Text & "','" & txt5.Text & "', CatDuracion=" & txt6.Text & ")")
            btNuevo.Text = "Nuevo"
        End If

        btGuardar.Enabled = False
        btEditar.Enabled = True
        btEliminar.Enabled = True

        txt2.Enabled = False
        txt3.Enabled = False
        txt4.Enabled = False
        txt5.Enabled = False
        txt6.Enabled = False
        Actalizar()

    End Sub
End Class