Public Class clsItemView
    Inherits ListViewItem

    Public WithEvents cliente As clsDatosDeUnCliente


    Public Sub PreguntaContestadaCorrectamente(ByRef sender As clsDatosDeUnCliente) Handles cliente.PreguntaContestadaCorrectamente
        Me.BackColor = COLOR_GOOD_ANSWER
    End Sub

    Public Sub PreguntaContestadaIncorrectamente(ByRef sender As clsDatosDeUnCliente) Handles cliente.PreguntaContestadaIncorrectamente
        Me.BackColor = COLOR_BAD_ANSWER
    End Sub

    Private Sub EmpiezaSiguientePreg(ByRef sender As clsDatosDeUnCliente) Handles cliente.EmpiezaSiguientePreg
        Me.BackColor = COLOR_IN_TEST
    End Sub

    Private Sub EmpiezaElExamen(ByRef sender As clsDatosDeUnCliente) Handles cliente.EmpiezaElExamen
        Me.BackColor = COLOR_IN_TEST
    End Sub

    Private Sub Desconectado(ByRef sender As clsDatosDeUnCliente) Handles cliente.Desconectado
        Me.Remove()
    End Sub

End Class
