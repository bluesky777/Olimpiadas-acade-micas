Public Class modCatPreg
    Inherits ModBase


#Region "Contructores"

    Sub New(Codigo As Integer)
        MyBase.New(Codigo)
        Me.Id = Codigo
    End Sub

    Sub New()
        MyBase.New()
        ' Se pasan los datos después
    End Sub
#End Region

    Public Overrides Sub Starting()
        Me.TableName = "CatPreg"
        Me.Prefix = "PrCa"

        Me.addForeign("PrCaPregunta", "Preguntas", "PregId")
        Me.addForeign("PrCaCategoria", "Categorias", "CatId")
    End Sub

End Class
