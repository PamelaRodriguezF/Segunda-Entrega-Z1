Imports MySql.Data.MySqlClient

Public NotInheritable Class DAOUtilidades

    Public Shared Function listarConParametros(query As String, parametros As String(,))
        Try

            Dim cmd As New MySqlCommand(query, DataBaseManager.Conexion)

            For i As Integer = 0 To parametros.GetLength(0) - 1
                cmd.Parameters.AddWithValue(parametros(i, 0), parametros(i, 1))
            Next

            Dim reader = cmd.ExecuteReader()

            Return reader
        Catch ex As Exception

            Return Nothing
        End Try
    End Function

    Public Shared Function insertarConParametros(query As String, parametros As String(,))
        Try

            Dim cmd As New MySqlCommand(query, DataBaseManager.Conexion)

            For i As Integer = 0 To parametros.GetLength(0) - 1
                cmd.Parameters.AddWithValue(parametros(i, 0), parametros(i, 1))
            Next

            Return (cmd.ExecuteNonQuery() > 0)
        Catch ex As Exception

            Return False
        End Try
    End Function
End Class
