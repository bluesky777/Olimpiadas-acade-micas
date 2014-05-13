Public Class modEventos
    Inherits ModBase

    Public SegTimeExam As Integer

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
        Me.TableName = "Eventos"
        Me.Prefix = "Ev"
    End Sub

    Public Sub getActual()
        Try

            Me.Row = Me.getTableRaw("EvActual='Actual'").Rows(0)
            Me.Id = Me.Row("EvId")

            Me.SegTimeExam = MinutesToSeg(Me.Row.Item("EvMinutosTotalMax"))

        Catch ex As Exception
            Me.Id = 0
        End Try
    End Sub

    Public Shared Function MinutesToSeg(min As Integer) As Integer
        Dim seg As Integer
        seg = min * 60
        Return seg
    End Function

End Class
