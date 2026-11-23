Imports MySqlConnector
Public Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Using conn As MySqlConnection = DatabaseConnection.GetConnection()

                conn.Open()

                MessageBox.Show("Database connected successfully!")

            End Using

        Catch ex As Exception

            MessageBox.Show("Database connection failed: " & ex.Message)

        End Try

    End Sub

End Class
