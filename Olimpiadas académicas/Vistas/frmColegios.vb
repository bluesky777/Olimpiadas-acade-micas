Imports System.Data.SqlClient

Public Class frmColegios
    Dim daColegio As SqlDataAdapter
    Dim dtdataset As New DataTable
    Dim dtColegios As New DataTable
    Private mibinding As New BindingSource

    Private Sub frmColegios_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        conn.EjecutarConsulta("delete from tbEquipos where EquiLogin='" & Login & "'")
        End
    End Sub
    'Dim rutaimg As String = ""

    Private Sub frmColegios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

        ActualizarColegios()

        txtId.DataBindings.Add("text", mibinding, "Código")
        txtNombre.DataBindings.Add("text", mibinding, "Nombre")
        txtCiudad.DataBindings.Add("text", mibinding, "Ciudad")
        txtTelefono.DataBindings.Add("text", mibinding, "Teléfono")
        txtRector.DataBindings.Add("text", mibinding, "Rector")
        txtEscudo.DataBindings.Add("text", mibinding, "Logo")

    End Sub



    Private Sub ActualizarColegios()
        Try
            dtColegios.Clear()
        Catch ex As Exception
            'Si hay error porque aun no existía la tabla, No pasa nada
        End Try
        conn.TraerTabla(dtColegios, "select C.ColId as Código,C.ColNombre as Nombre,C.ColCiudad as Ciudad, C.ColTelefono as Teléfono, C.ColRector as Rector, C.ColLogo as Logo from tbEntidades C")
        
        Try
            mibinding.DataSource = dtColegios
        Catch ex As Exception
            MsgBox("No se pudo asignar el BindingSource")
        End Try

        GridView1.DataSource = mibinding
        If txtEscudo.Text = "" Then
            pbLogo.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Imágenes\Colegios\sin logo.gif")
            txtEscudo.Text = My.Application.Info.DirectoryPath & "\Imágenes\Colegios\sin logo.gif"
        Else
            pbLogo.Image = Image.FromFile(txtEscudo.Text)
        End If

    End Sub

    Private Sub btGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGuardar.Click
        If btNuevo.Text = "Cancelar" Then
            conn.EjecutarConsulta("Insert into tbEntidades(ColNombre, ColCiudad, ColTelefono, ColRector, ColLogo) Values('" & txtNombre.Text & "','" & txtCiudad.Text & "','" & txtTelefono.Text & "', '" & txtRector.Text & "', '" & txtEscudo.Text & "')")
            btNuevo.Text = "Nuevo"
            Desbloquear(False)
        Else
            conn.EjecutarConsulta("Update tbEntidades set ColNombre='" & txtNombre.Text & "', ColCiudad='" & txtCiudad.Text & "', ColTelefono='" & txtTelefono.Text & "', ColRector='" & txtRector.Text & "', ColLogo='" & txtEscudo.Text & "' where ColId=" & txtId.Text)
            btEditar.Text = "Editar"
            Desbloquear(False)
        End If
        btGuardar.Enabled = False
        ActualizarColegios()
    End Sub

    Private Sub btNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNuevo.Click
        If btNuevo.Text = "Nuevo" Then
            btNuevo.Text = "Cancelar"
            mibinding.AddNew()
            txtEscudo.Text = My.Application.Info.DirectoryPath & "\Imágenes\Colegios\sin logo.gif"
            btGuardar.Enabled = True
            txtNombre.Focus()
            Desbloquear(True)
        Else
            mibinding.CancelEdit()
            btGuardar.Enabled = False
            btNuevo.Text = "Nuevo"
            Desbloquear(False)
        End If

    End Sub

    Private Sub Desbloquear(ByVal Valor As Boolean)
        txtCiudad.Enabled = Valor
        txtNombre.Enabled = Valor
        txtRector.Enabled = Valor
        txtTelefono.Enabled = Valor
        btBuscarImg.Enabled = Valor

        If Valor = True Then
            btEliminar.Enabled = False
        Else
            btEliminar.Enabled = True
        End If

    End Sub

    Private Sub btBuscarImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscarImg.Click
        With OpenFileDialog1

            .FileName = Nothing
            .Filter = "Imagen (*.jpg; *.gif; *.png) | *.jpg;*.gif;*.png"
            .ShowDialog()

            If .FileName <> "" Then
                pbLogo.Image = Image.FromFile(.FileName)
                'Dim fs As System.IO.FileStream = CType(.OpenFile(), System.IO.FileStream)
                'pbLogo.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg)
                txtEscudo.Text = .FileName
            End If
        End With

    End Sub


    Private Sub Flash1_FSCommand()
        Select Case ""
            Case "Ultimo"
                mibinding.MoveLast()
            Case "Anterior"
                If mibinding.Position = 0 Then
                    mibinding.MoveLast()
                Else
                    mibinding.MovePrevious()
                End If

            Case "Primero"
                mibinding.MoveFirst()
            Case "Siguiente"
                If mibinding.Position = mibinding.Count - 1 Then
                    mibinding.MoveFirst()
                Else
                    mibinding.MoveNext()
                End If
        End Select

        If btNuevo.Text = "Cancelar" Then
            btNuevo.Text = "Nuevo"
            mibinding.CancelEdit()
            Desbloquear(False)
            txtNombre.Focus()
            GridView1.Enabled = True
            ActualizarColegios()
        End If
        If btEditar.Text = "Cancelar" Then
            Desbloquear(False)
            btEditar.Text = "Editar"
            GridView1.Enabled = True
        End If

    End Sub

    Private Sub btEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditar.Click
        If btEditar.Text = "Editar" Then
            btEditar.Text = "Cancelar"
            txtEscudo.Text = My.Application.Info.DirectoryPath & "\Imágenes\Colegios\sin logo.gif"
            btGuardar.Enabled = True
            txtNombre.Focus()
            Desbloquear(True)
        Else
            mibinding.CancelEdit()
            btGuardar.Enabled = False
            btEditar.Text = "Editar"
            Desbloquear(False)
        End If
    End Sub


    Private Sub Flash2_FSCommand()
        frmAdministrador.Show()
        Me.Hide()
    End Sub
End Class