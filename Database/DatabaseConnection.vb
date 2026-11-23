Imports MySqlConnector

Public Class DatabaseConnection

    Private Shared ReadOnly ConnStr As String =
        "Server=localhost;Port=3306;Database=KidsScheduleDB;Uid=root;Pwd=" &
        Environment.GetEnvironmentVariable("KIDS_DB_PASSWORD") & ";"

    Public Shared Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnStr)
    End Function

End Class