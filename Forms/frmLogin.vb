Imports MySqlConnector
Public Class frmLogin
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Using registerForm As New frmRegisterParent()
            registerForm.ShowDialog()
        End Using
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim loggedInUser As UserSession = Nothing
        If txtUsername.Text.Trim() = "" OrElse txtPassword.Text = "" Then
            MessageBox.Show("Please enter your username and password.")
            Return
        End If

        Try

            Using conn As MySqlConnection = DatabaseConnection.GetConnection()

                conn.Open()

                Dim query As String =
                "SELECT UserID, FullName, Username, PasswordHash, Role, ParentID " &
                "FROM Users WHERE Username = @Username"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())

                    Using reader = cmd.ExecuteReader()

                        If reader.Read() Then

                            Dim storedHash As String =
                            reader("PasswordHash").ToString()

                            If BCrypt.Net.BCrypt.Verify(txtPassword.Text, storedHash) Then

                                Dim userID As Integer =
                                Convert.ToInt32(reader("UserID"))

                                Dim fullName As String =
                                reader("FullName").ToString()

                                Dim role As String =
                                reader("Role").ToString()

                                Dim parentID As Integer? = Nothing

                                If Not IsDBNull(reader("ParentID")) Then
                                    parentID = Convert.ToInt32(reader("ParentID"))
                                End If

                                loggedInUser = New UserSession With {
                                    .UserID = userID,
                                    .FullName = fullName,
                                    .Role = role,
                                    .ParentID = parentID
                                    }

                            Else

                                MessageBox.Show("Incorrect username or password.")

                            End If

                        Else

                            MessageBox.Show("Incorrect username or password.")

                        End If

                    End Using

                End Using

            End Using

            If loggedInUser IsNot Nothing Then

                Dim dashboard As New frmDashboard(loggedInUser)

                dashboard.Show()
                Me.Hide()

            End If

        Catch ex As Exception

            MessageBox.Show("Login error: " & ex.Message)

        End Try

    End Sub
End Class