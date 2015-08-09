Imports System.Text
Imports System.Security.Cryptography
Public Class MD5Class

    Private Shared ReadOnly _md5 As MD5 = MD5.Create()

    Public Function GetMd5Hash(source As String) As String

        Dim data = _md5.ComputeHash(Encoding.UTF8.GetBytes(source))
        Dim sb As New StringBuilder()
        Array.ForEach(data, Function(x) sb.Append(x.ToString("X2")))
        Return sb.ToString()

    End Function

    Public Function VerifyMd5Hash(source As String, hash As String) As Boolean

        Dim sourceHash = GetMd5Hash(source)
        Dim comparer As StringComparer = StringComparer.OrdinalIgnoreCase
        Return If(comparer.Compare(sourceHash, hash) = 0, True, False)

    End Function

    Public Function GetMd5HashBase64(source As String) As String

        Dim data = _md5.ComputeHash(Encoding.UTF8.GetBytes(source))
        Return Convert.ToBase64String(data)

    End Function

    Public Function VerifyMd5HashBase64(source As String, hash As String) As Boolean

        Dim sourceHash = GetMd5HashBase64(source)
        Dim comparer As StringComparer = StringComparer.OrdinalIgnoreCase
        Return If(comparer.Compare(sourceHash, hash) = 0, True, False)

    End Function

End Class
