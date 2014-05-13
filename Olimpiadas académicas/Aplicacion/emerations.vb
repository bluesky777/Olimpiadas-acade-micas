Imports System.Text
Imports System.Net.Sockets

Module emerations


    Public Enum SearchTestBy
        OnlyCategoria
        OnlyEntidad
        CategoriaEntidad
    End Enum



    Public Class StateObject
        ' Client socket.
        Public workSocket As Socket = Nothing
        ' Size of receive buffer.
        Public BufferSize As Integer = 256
        ' Receive buffer.
        Public buffer(256) As Byte
        ' Received data string.
        Public sb As New StringBuilder()
    End Class


End Module
