Imports MySql.Data.MySqlClient

Public Module Db

    Public ConnectionString As String =
        "Server=localhost;Port=3306;Database=registrar_db;Uid=root;Pwd=;" &
        "SslMode=Disabled;AllowPublicKeyRetrieval=True;Convert Zero Datetime=True;"

    Public Const ErrDuplicateKey As Integer = 1062
    Public Const ErrRowReferenced As Integer = 1451

    Public Function OpenConnection() As MySqlConnection
        Dim cn As New MySqlConnection(ConnectionString)
        cn.Open()
        Return cn
    End Function

    Public Function P(name As String, value As Object) As MySqlParameter
        Return New MySqlParameter(name, If(value, DBNull.Value))
    End Function

    Public Function GetTable(sql As String, ParamArray parameters As MySqlParameter()) As DataTable
        Using cn = OpenConnection()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddRange(parameters)
                Dim dt As New DataTable()
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
                Return dt
            End Using
        End Using
    End Function

    Public Function Execute(sql As String, ParamArray parameters As MySqlParameter()) As Integer
        Using cn = OpenConnection()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddRange(parameters)
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function Scalar(sql As String, ParamArray parameters As MySqlParameter()) As Object
        Using cn = OpenConnection()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddRange(parameters)
                Dim result = cmd.ExecuteScalar()
                Return If(result Is DBNull.Value, Nothing, result)
            End Using
        End Using
    End Function

    Public Function Exists(sql As String, ParamArray parameters As MySqlParameter()) As Boolean
        Return ToInt(Scalar(sql, parameters)) > 0
    End Function

    Public Function ToInt(value As Object) As Integer
        If value Is Nothing OrElse value Is DBNull.Value Then Return 0
        Return Convert.ToInt32(value)
    End Function

    Public Function ToDec(value As Object) As Decimal
        If value Is Nothing OrElse value Is DBNull.Value Then Return 0D
        Return Convert.ToDecimal(value)
    End Function

    Public Function ToStr(value As Object) As String
        If value Is Nothing OrElse value Is DBNull.Value Then Return ""
        Return Convert.ToString(value)
    End Function

    Public Function ToDate(value As Object) As Date?
        If value Is Nothing OrElse value Is DBNull.Value Then Return Nothing
        Return Convert.ToDateTime(value)
    End Function

End Module
