Imports System.IO
Imports System.Net
Imports System.Net.Sockets


Public Class TCPController

    Public client As TcpClient
    Public clientData As StreamWriter

    Public Sub New(Host As String, Port As Integer)

        'The Client configuration.
        client = New TcpClient(Host, Port)
        clientData = New StreamWriter(client.GetStream)

    End Sub

    Public Sub send(Data As String)

        clientData.Write(Data & vbCrLf)
        clientData.Flush()

    End Sub

End Class
