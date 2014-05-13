Public Class modCategoria
    Inherits ModBase


#Region "Contructores"

    Sub New(Codigo As Integer)
        MyBase.New(Codigo)
    End Sub


    Sub New()
        MyBase.New()
        ' Se pasan los datos después
    End Sub
#End Region

    Public Overrides Sub Starting()
        Me.TableName = "Categorias"
        Me.Prefix = "Cat"
    End Sub


End Class
