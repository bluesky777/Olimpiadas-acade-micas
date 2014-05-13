Public Class frmAdminClientes


    Private Sub btExpand_Click(sender As Object, e As EventArgs) Handles btExpand.Click
        TreeView1.ExpandAll()
    End Sub

    Private Sub btContraer_Click(sender As Object, e As EventArgs) Handles btContraer.Click
        TreeView1.CollapseAll()
    End Sub



    Private Sub btCerrarSistemas_Click(sender As Object, e As EventArgs) Handles btCerrarSistemas.Click
        frmAdminEvento.AdminClientes.CerrarProgramaToAll()
    End Sub

    Private Sub frmAdminClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each cliente As clsDatosDeUnCliente In frmAdminEvento.AdminClientes.DatosClientes

            Dim parentNode As New TreeNode(cliente.Nombre & " -> " & cliente.Entidad)
            TreeView1.Nodes.Add(parentNode)

            Dim childnode As New TreeNode
            childnode = parentNode.Nodes.Add(cliente.IPString & " - '" & cliente.NombreEquipo & "' - Conectado: " & cliente.Socket.Connected)

            Dim childnode2 As New TreeNode
            childnode2 = parentNode.Nodes.Add("Correctas: " & cliente.PregCorrectas & " vs " & cliente.PregIncorrectas & " - Categoría: " & cliente.idCategoria & "-" & cliente.Categoria)

        Next
        TreeView1.ExpandAll()

    End Sub

    Private Sub CerrarExamenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarExamenToolStripMenuItem.Click
        frmAdminEvento.AdminClientes.CerrarExamenToAll()
    End Sub

    Private Sub CerrarSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSistemaToolStripMenuItem.Click

    End Sub
End Class