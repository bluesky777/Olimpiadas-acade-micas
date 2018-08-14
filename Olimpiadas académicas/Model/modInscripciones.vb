Public Class modInscripciones
    Inherits ModBase


#Region "Contructores"

    Sub New(Codigo As Integer)
        MyBase.New(Codigo)
        Me.Id = Codigo
    End Sub

    Sub New()
        MyBase.New()
    End Sub
#End Region

    Public Overrides Sub Starting()
        Me.TableName = "Inscripciones"
        Me.Prefix = "Ins"

        Me.addForeign("InsUsuario", "Usuarios", "UsuId")
        Me.addForeign("InsCategoria", "Categorias", "CatId")
        Me.addForeign("InsEntidad", "Entidades", "EntId")
    End Sub


End Class
