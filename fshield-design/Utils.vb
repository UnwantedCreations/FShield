Imports System.Security.Cryptography
Imports System.Text

Public Class Utils
    Public Shared Function CreateSalt() As String
        Dim size As Integer = 64
        Using rng As New RNGCryptoServiceProvider
            Dim data(If(size < 7, 7, size)) As Byte
            rng.GetBytes(data)
            Return Convert.ToBase64String(data)
        End Using
    End Function

    Public Shared Function GetSaltedHash(pw As String, salt As String) As String
        Dim tmp As String = pw & salt

        Using hash As HashAlgorithm = New SHA256Managed()
            Dim saltyPW = Encoding.UTF8.GetBytes(tmp)
            Dim hBytes = hash.ComputeHash(saltyPW)
            Return Convert.ToBase64String(hBytes)
        End Using

    End Function
End Class
