Imports MySqlConnector
Imports DotNetEnv

Public Class DatabaseConnection

    Private Shared ReadOnly ConnStr As String = BuildConnectionString()

    Private Shared Function BuildConnectionString() As String

        'Load settings from the .env file
        Env.Load()

        Dim server As String = Environment.GetEnvironmentVariable("DB_SERVER")
        Dim port As String = Environment.GetEnvironmentVariable("DB_PORT")
        Dim database As String = Environment.GetEnvironmentVariable("DB_NAME")
        Dim username As String = Environment.GetEnvironmentVariable("DB_USER")
        Dim password As String = Environment.GetEnvironmentVariable("DB_PASSWORD")

        'Build the connection string
        Return "Server=" & server &
               ";Port=" & port &
               ";Database=" & database &
               ";Uid=" & username &
               ";Pwd=" & password & ";"

    End Function

    Public Shared Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnStr)
    End Function

End Class