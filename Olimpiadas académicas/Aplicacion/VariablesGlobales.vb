Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Module VariablesGlobales


#Region "MODELOS"

    Public m_UsuarioAuth As modUsuarios

    Public m_Categorias As modCategoria
    Public m_Entidades As modEntidades
    Public m_Equipo As modEquipos
    Public m_Eventos As modEventos
    Public m_Examenes As modExamen
    Public m_Inscripciones As modInscripciones
    Public m_Preguntas As modPreguntas
    Public m_TipoUsuarios As modTipoUsuario
    Public m_TipoExamen As modTipoExamen
    Public m_Usuarios As modUsuarios

#End Region



#Region "CONEXIÓN"
    Public Yo As New Usuario_Logueado
    Public conn As Conexion_SqlServer

    'Public cnn As New SqlConnection

    Dim cmdTemp As SqlCommand
    Public dtable As New DataTable
    Private NombreDBLite As String = "Administrator.sqlite"
    Private PassDbLite As String = "greatking"

#End Region



    ' Variables conexión
    Public Puerto As Integer = 8522
    Public MyKeyWord As String = "IGAD_XCOMMAND->"
    Public Delimitador As String = "::"
    Public response As String = ""


    ' Colores clientes
    Public COLOR_IN_IP As Color = Color.WhiteSmoke
    Public COLOR_CONECTED As Color = Color.White
    Public COLOR_IN_TEST As Color = Color.AliceBlue
    Public COLOR_GOOD_ANSWER As Color = Color.Yellow
    Public COLOR_BAD_ANSWER As Color = Color.Red

    ' Colores Live
    Public _COLOR_FONT As Color = Color.White
    Public _COLOR_PREGUNTA As Color = Color.DodgerBlue
    Public _COLOR_PARTCIPANTES As Color = Color.DodgerBlue
    Public _COLOR_BLANK As Color = Color.DimGray
    Public _COLOR_CLOSE As Color = Color.WhiteSmoke
    Public _COLOR_FONT_CLOSE As Color = Color.Black




    Public Sub InicializarVariables()


        conn = New Conexion_SqlServer("BLUESKY-PC", "Olimpiadas", "princesito", "superjoseth")


        m_UsuarioAuth = New modUsuarios

        m_Categorias = New modCategoria
        m_Entidades = New modEntidades
        m_Equipo = New modEquipos
        m_Eventos = New modEventos
        m_Examenes = New modExamen
        m_Inscripciones = New modInscripciones
        m_Preguntas = New modPreguntas
        m_TipoUsuarios = New modTipoUsuario
        m_TipoExamen = New modTipoExamen
        m_Usuarios = New modUsuarios


        m_Eventos.getActual()
        m_TipoExamen.findRaw(m_Eventos.Row.Item("EvTipoExamen"))

        
    End Sub

End Module
