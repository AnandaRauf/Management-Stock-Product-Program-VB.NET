Imports System
Imports System.Security.Cryptography
Imports System.Text
s
Public Class MD5Hash

    Module1 MD5Hash
    'Untuk Login
    Public Function getMD5Hash(ByVal strToHash As String) As String
            Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider()
            Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
            bytesToHash = md5Obj.ComputeHash(bytesToHash)
            Dim strResult As String = ""
            Dim b As Byte
            For Each b In bytesToHash
                strResult += b.ToString("x2")
            Next
            Return strResult
        End Function
    End Module
End Class

