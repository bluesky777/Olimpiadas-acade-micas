Public Class modEntidades
    Inherits ModBase

#Region "Contructores"

    Sub New(Codigo As Integer)
        MyBase.New(Codigo)
        Me.Id = Codigo
    End Sub

    Sub New()
        MyBase.New()
        ' Si no quiere especificar el Id tendrá que hacerlo luego manualmente
    End Sub

#End Region

    Public Overrides Sub Starting()
        Me.TableName = "Entidades"
        Me.Prefix = "Ent"
    End Sub

End Class
