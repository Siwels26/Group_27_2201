Imports MySqlConnector
Public Class frmRegisterParent
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Validate required fields
        If txtFullName.Text.Trim() = "" OrElse
           txtUsername.Text.Trim() = "" OrElse
           txtPassword.Text = "" OrElse
           txtConfirmPassword.Text = "" Then

            MessageBox.Show("Please fill in all fields.")
            Return

        End If

        ' Check password length
        If txtPassword.Text.Length < 8 Then
            MessageBox.Show("Password must contain at least 8 characters.")
            Return
        End If

        ' Confirm passwords match
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.")
            Return
        End If

        Try

            ' Hash the password
            Dim passwordHash As String =
                BCrypt.Net.BCrypt.HashPassword(txtPassword.Text)

            Using conn = DatabaseConnection.GetConnection()

                conn.Open()

                Dim query As String =
                    "INSERT INTO Users " &
                    "(FullName, Username, PasswordHash, Role, ParentID) " &
                    "VALUES (@FullName, @Username, @PasswordHash, 'Parent', NULL)"

                Using cmd As New MySqlConnector.MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash)

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show("Parent account created successfully!")

            Me.Close()

        Catch ex As MySqlConnector.MySqlException

            If ex.Number = 1062 Then
                MessageBox.Show("That username is already taken.")
            Else
                MessageBox.Show("Database error: " & ex.Message)
            End If

        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message)

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class