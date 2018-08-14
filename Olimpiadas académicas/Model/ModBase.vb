Public MustInherit Class ModBase

    ' Aquí guardo las claves foraneas de este modelo
    Dim ForeignKeys As New ArrayList


#Region "PROPIEDADES DEL MODELO"


    Private _id As Integer
    Private _tableName As String
    Private _prefix As String
    Private _prefixTable As String
    Private _dt As DataTable
    Private _row As DataRow


    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property TableName() As String
        Get
            Return _tableName
        End Get
        Set(ByVal value As String)
            _tableName = Me.PrefixTable & value
        End Set
    End Property

    Public Property Prefix() As String
        Get
            Return _prefix
        End Get
        Set(ByVal value As String)
            _prefix = value
        End Set
    End Property

    Public Property PrefixTable() As String
        Get
            Return _prefixTable
        End Get
        Set(ByVal value As String)
            _prefixTable = value
        End Set
    End Property

    Public Property dt() As DataTable
        Get
            ' Me aseguro que la primera vez que lo llame ya esté instanciada la tabla.
            If _dt Is Nothing Then
                _dt = New DataTable
            End If

            Return _dt
        End Get
        Set(ByVal value As DataTable)
            _dt = value
        End Set
    End Property

    Public Property Row() As DataRow
        Get
            Return _row
        End Get
        Set(ByVal value As DataRow)
            _row = value
        End Set
    End Property

#End Region


#Region "Constructores"

    Sub New(Codigo As Integer)
        Me.PrefixTable = "tb"
        ' El id se tiene que asignar después de que el objeto ya halla especificado la tabla y el prefijo
        Me.Starting()
        Me.Id = Codigo
    End Sub

    Sub New()
        Me.PrefixTable = "tb"
        Me.Starting()
        ' Se pasan los datos después
    End Sub


    MustOverride Sub Starting()


#End Region

#Region "FUNCIONES CRUD"


    '******************************************************************************************
    ' Traer un solo registro de la tabla basado en la primaryKey (Id)
    '******************************************************************************************
    Public Function findRaw(id As Integer) As DataRow

        ' La condición da algo como: "UsuId = 7"
        Dim condicion As String = Me.Prefix & "Id = " & id

        ' Solo me interesa una fila
        Try
            Me.Row = conn.fillTable(Me.TableName, condicion).Rows(0)
        Catch ex As Exception

        End Try

        Return Me.Row
    End Function


    Public Function find(id As Integer) As DataRow

        Return Me.Row
    End Function



    '******************************************************************************************
    ' Traer un solo campo de la tabla basado en la primaryKey (Id)
    '******************************************************************************************
    Public Function getCampoRaw(id As Integer, field As String)
        Dim ValorDelCampo As String
        Try
            ValorDelCampo = Me.findRaw(id).Item(field)
        Catch ex As Exception

        End Try

        Return ValorDelCampo
    End Function

    '******************************************************************************************
    ' Traer un solo campo de la tabla basado en la primaryKey (Id)
    '******************************************************************************************
    Public Function getTableRaw(Optional condicion As String = "") As DataTable

        Me.dt.Clear()

        ' Si tiene condición...
        If condicion <> "" Then
            ' Creamos una tabla que cumpla la condición
            Me.dt = conn.fillTable(Me.TableName, condicion)
        Else
            ' Sino la creamos sin condición.
            Me.dt = conn.fillTable(Me.TableName)

        End If

        Return Me.dt
    End Function
    '******************************************************************************************
    ' Eliminar un registro
    '******************************************************************************************
    Public Function Delete(Codigo As Integer) As Boolean

        Dim Consulta As String = "DELETE FROM " & Me.TableName & " where " & Me.Prefix & "Id = " & Codigo & ";"
        Return conn.EjecutarConsulta(Consulta)

    End Function

    Public Function Delete(Condicion As String) As Boolean

        Dim Consulta As String = "DELETE FROM " & Me.TableName & " where " & Condicion & ";"
        Return conn.EjecutarConsulta(Consulta)

    End Function


    Public Sub mapCombo(ByRef AcomboBox As ComboBox, DisplayMember As String, Optional ValueMember As String = "", Optional selects As String = "*", Optional condicion As String = "")
        If ValueMember = "" Then
            ValueMember = Me.Prefix & "Id"
        End If

        With AcomboBox
            .DataSource = Me.getTable(selects, condicion)
            .DisplayMember = DisplayMember
            .ValueMember = ValueMember
        End With

    End Sub


    Sub mapList(ByRef AlistBox As ListBox, DisplayMember As String, Optional ValueMember As String = "", Optional selects As String = "*", Optional condicion As String = "")
        If ValueMember = "" Then
            ValueMember = Me.Prefix & "Id"
        End If

        With AlistBox
            .DataSource = Me.getTable(selects, condicion)
            .DisplayMember = DisplayMember
            .ValueMember = ValueMember
        End With
    End Sub

#End Region


#Region "FUNCIONES PARA LAS CLAVES FORANEAS DE NUESTRO MODELO"

    Public Sub addForeign(foreignField As String, TablaName As String, ForeignKey As String)
        Dim claveForanea As New strucForeign(foreignField, TablaName, ForeignKey, Me)
        ForeignKeys.Add(claveForanea)
    End Sub

    'Public Function getForeignValue(KeyField As String, DesiredField As String) As String

    '    ' Traigo la relación correspondiente a KeyField, quien es una clave foranea
    '    Dim claveForanea As strucForeign = Me.getForeignField(KeyField)

    '    ' Luego solo traemos el item que corresponda con el DiseredFiel (Campo deseado)
    '    Dim valor As String = claveForanea.valorPromt(DesiredField)

    '    Return valor
    'End Function

    Public Function getStrucForeignByForeignField(ForeignField As String) As strucForeign

        'Busco una de las relaciones que tiene este modelo, la que corresponda con el campo indicado en KeyField
        Dim claveForanea As New strucForeign

        For Each foreign As strucForeign In ForeignKeys
            If foreign.ForeignField = ForeignField Then
                claveForanea = foreign
                Exit For
            End If
        Next

        Return claveForanea
    End Function


    Public Function getTable(Optional SelectFields As String = "*", Optional condicionFiltro As String = "", Optional ForeignTables As ModBase() = Nothing) As DataTable
        Dim Query As String

        Query = createQuery(SelectFields, condicionFiltro, ForeignTables)

        Me.dt = conn.TraerTabla(Query)

        Return Me.dt
    End Function


    Public Function createQuery(Optional SelectFields As String = "*", Optional condicionFiltro As String = "", Optional ForeignTables As ModBase() = Nothing, Optional fromAgregado As String() = Nothing) As String
        Dim Query As String
        Dim tablesQuery As New ArrayList
        Dim tablesQueryStr As String = ""
        Dim condQuery As String = ""


        tablesQuery.Add(Me.TableName)

        getTablesNamesAndConds(tablesQuery, condQuery)


        ' Si se pasó un StrongForeign
        If Not ForeignTables Is Nothing Then
            ' Agregamos AND a la operación para continuar con los condicionales
            condQuery += " AND "

            For Each ForeignTable As ModBase In ForeignTables
                ' Añadimos las tablas foraneas de ese modelo y sus respectivas condiciones
                getTablesNamesAndConds(tablesQuery, condQuery, ForeignTable)
            Next

        End If


        If Not fromAgregado Is Nothing Then tablesQuery.Add(fromAgregado(0))


        For i As Integer = 0 To tablesQuery.Count - 1
            tablesQueryStr += tablesQuery(i)
            If i = (tablesQuery.Count - 1) Then
                tablesQueryStr += " "
            Else
                tablesQueryStr += ", "
            End If

        Next

        Query = "SELECT " & SelectFields & " FROM " & tablesQueryStr

        If Me.ForeignKeys.Count > 0 Then Query += " WHERE " & condQuery

        If Not fromAgregado Is Nothing Then
            If Me.ForeignKeys.Count > 0 Then
                Query += " AND " & fromAgregado(1)
            Else
                Query += " WHERE " & fromAgregado(1)
            End If

        End If


        ' Si se pasó condición, la agregamos
        If condicionFiltro <> "" And condQuery <> "" Then
            Query += " AND " & condicionFiltro
        ElseIf condicionFiltro <> "" Then
            Query += " WHERE " & condicionFiltro
        End If

        Return Query
    End Function

    Private Sub getTablesNamesAndConds(ByRef tablesQuery As ArrayList, ByRef condQuery As String, Optional Modelo As ModBase = Nothing)

        If Modelo Is Nothing Then Modelo = Me

        For key As Integer = 0 To Modelo.ForeignKeys.Count - 1
            Dim strucForeignTemp As strucForeign = Modelo.ForeignKeys.Item(key)
            Dim nombreTabla As String = Me.PrefixTable & strucForeignTemp.Table

            If tablesQuery.Contains(nombreTabla) = False Then
                tablesQuery.Add(nombreTabla)
            End If

            condQuery += Modelo.ForeignKeys.Item(key).KeyField & " = " & Modelo.ForeignKeys.Item(key).ForeignField

            If key < Modelo.ForeignKeys.Count - 1 Then
                condQuery += " AND "
            End If

        Next

    End Sub
    Private Sub getTablesNamesAndConds(ByRef condQuery As String, Optional Modelo As ModBase = Nothing)

        If Modelo Is Nothing Then Modelo = Me

        For key As Integer = 0 To Modelo.ForeignKeys.Count - 1

            condQuery += Modelo.ForeignKeys.Item(key).KeyField & " = " & Modelo.ForeignKeys.Item(key).ForeignField

            If key < Modelo.ForeignKeys.Count - 1 Then
                condQuery += " AND "
            End If

        Next

    End Sub

#End Region



End Class
