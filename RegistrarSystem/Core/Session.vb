Imports System.Security.Cryptography
Imports System.Text

Public Module Session

    Public Const RoleAdmin As String = "Administrator"
    Public Const RoleStaff As String = "Registrar Staff"

    Public Property UserID As Integer
    Public Property Username As String = ""
    Public Property FullName As String = ""
    Public Property Role As String = ""

    Public ReadOnly Property IsAdmin As Boolean
        Get
            Return Role = RoleAdmin
        End Get
    End Property

    Public Sub Clear()
        UserID = 0
        Username = ""
        FullName = ""
        Role = ""
    End Sub

    Public Function HashPassword(plain As String) As String
        Dim bytes = SHA256.HashData(Encoding.UTF8.GetBytes(plain))
        Return Convert.ToHexString(bytes).ToLowerInvariant()
    End Function

End Module
