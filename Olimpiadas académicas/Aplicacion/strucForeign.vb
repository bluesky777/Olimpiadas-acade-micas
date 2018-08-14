Public Structure strucForeign

    '*********************************************************************************************************************
    ' Una clave foranea es el campo foraneo, la tabla a la que pertenece esa clave, y la clave principal de esa tabla.
    '*********************************************************************************************************************
    Private _foreignField As String ' Nombre de la columna foranea
    Private _table As String
    Private _keyField As String ' Codigo que se encuentra como foraneo en una tabla y que también está como primario en _table
    Private _valor As String ' Valor temporal que se deseara obtener en vez de la clave foránea.
    Public Modelo As ModBase


    Public Property ForeignField() As String
        Get
            Return _foreignField
        End Get
        Set(ByVal value As String)
            _foreignField = value
        End Set
    End Property


    Public Property Table() As String
        Get
            Return _table
        End Get
        Set(ByVal value As String)
            _table = value
        End Set
    End Property


    Public Property KeyField() As String
        Get
            Return _keyField
        End Get
        Set(ByVal value As String)
            _keyField = value
        End Set
    End Property


    Public Sub New(ForeignField As String, ByRef table As String, ForeignKey As String, ByRef ModeloParent As ModBase)
        Me.ForeignField = ForeignField
        Me.Table = table
        Me.KeyField = ForeignKey
        Me.Modelo = ModeloParent
    End Sub



End Structure
