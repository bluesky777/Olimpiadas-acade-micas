Public Class modTipoExamen
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
        Me.TableName = "TipoExamen"
        Me.Prefix = "Te"
    End Sub
End Class
