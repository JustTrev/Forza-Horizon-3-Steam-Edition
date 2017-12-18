Imports System.Net.Sockets
Imports System.Text

Public Class vbRCON
    ' This is the connection to reach the server for admin.

    'Public Shared msg As String
    Public Shared clientSocket As New System.Net.Sockets.TcpClient()
    Public Shared serverStream As NetworkStream

    Public Shared Sub OpenConnection()

        msg("Client Started")
        clientSocket.Connect("47.196.219.55", 9000) ' Server connection address used to establish chat.
        '      frmMETMain.txtOutPut.Text = "Client Socket Program - Server Connected ..."
    End Sub


    Public Shared Sub ProcessCommand()

        Dim serverStream As NetworkStream = clientSocket.GetStream()
        Dim outStream As Byte() =
        System.Text.Encoding.ASCII.GetBytes("Message from Client$")
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()

        Dim inStream(10024) As Byte
        serverStream.Read(inStream, 0, CInt(clientSocket.ReceiveBufferSize))
        Dim returndata As String =
        System.Text.Encoding.ASCII.GetString(inStream)
        msg("Data from Server : " + returndata)
    End Sub

    Public Shared Sub msg(ByVal mesg As String)
        '     frmMETMain.txtOutPut.Text = frmMETMain.txtTextMessage.Text + Environment.NewLine + " >> " + mesg
    End Sub
End Class
