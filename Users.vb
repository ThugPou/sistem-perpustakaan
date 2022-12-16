Imports System.Security.Cryptography

Public Class Users

    Private username As String
    Private password As String
    Private datauser As New ArrayList()
    Private Tripledes As New TripleDESCryptoServiceProvider

    Public Property GSUsername() As String
        Get
            Return username
        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property

    Public Property GSPassword() As String
        Get
            Return password
        End Get
        Set(ByVal value As String)
            password = value
        End Set
    End Property

    Public Function EncryptData(plaintext As String) As String
        'Convert the plaintext string to a byte array.
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)
        'Create the stream.
        Dim ms As New System.IO.MemoryStream
        'Create the encoder to write to the stream.
        Dim encStream As New CryptoStream(ms,
                                          Tripledes.CreateEncryptor(),
                                          System.Security.Cryptography.CryptoStreamMode.Write)
        'Use the crypto stream To write the Byte array To the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()
        'Convert the encrypted stream to a printable string.
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function CheckAuth(username As String, ByVal plainPassword As String) As String
        'Static Password
        Dim flag As Boolean = False
        Dim realPassword As String = EncryptData(plainPassword)

        For Each userdata In getdatauser
            If String.Compare(username, userdata(0)) = 0 And String.Compare(EncryptData(plainPassword), userdata(1)) = 0 And Not flag Then
                flag = True
            End If
        Next
        Return flag

    End Function

    Public Function Adddatauser(username As String,
                                password As String
                               )
        datauser.Add({username,
                      EncryptData(password)})
    End Function

    Public ReadOnly Property getdatauser() As ArrayList
        Get
            Return datauser
        End Get
    End Property
End Class
