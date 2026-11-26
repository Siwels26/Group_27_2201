Imports MySqlConnector
Public Class frmManageKidHolders
    Private currentUser As UserSession
    Private selectedUserID As Integer = 0

    Public Sub New(user As UserSession)

        InitializeComponent()

        currentUser = user

    End Sub

    Private Sub LoadKidHolders()

        Try

            Using conn As MySqlConnection = DatabaseConnection.GetConnection()

                conn.Open()

                Dim query As String =
                "SELECT UserID, FullName, Username " &
                "FROM Users " &
                "WHERE Role = 'KidHolder' AND ParentID = @ParentID"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@ParentID", currentUser.UserID)

                    Using adapter As New MySqlDataAdapter(cmd)

                        Dim table As New DataTable()

                        adapter.Fill(table)

                        dgvKidHolders.DataSource = table

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Unable to load Kid Holders: " & ex.Message)

        End Try

    End Sub
    Private Sub frmManageKidHolders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKidHolders()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
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

            Using conn As MySqlConnection = DatabaseConnection.GetConnection()

                conn.Open()

                Dim query As String =
                "INSERT INTO Users " &
                "(FullName, Username, PasswordHash, Role, ParentID) " &
                "VALUES (@FullName, @Username, @PasswordHash, 'KidHolder', @ParentID)"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash)
                    cmd.Parameters.AddWithValue("@ParentID", currentUser.UserID)

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show("Kid Holder account created successfully!")

            ' Clear the fields
            txtFullName.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
            txtConfirmPassword.Clear()

            ' Refresh the table
            LoadKidHolders()

        Catch ex As MySqlException

            If ex.Number = 1062 Then

                MessageBox.Show("That username is already taken.")

            Else

                MessageBox.Show("Database error: " & ex.Message)

            End If

        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message)

        End Try

    End Sub

    Private Sub dgvKidHolders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKidHolders.CellContentClick

    End Sub

    Private Sub dgvKidHolders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKidHolders.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim row As DataGridViewRow = dgvKidHolders.Rows(e.RowIndex)

        selectedUserID = Convert.ToInt32(row.Cells("UserID").Value)

        txtFullName.Text = row.Cells("FullName").Value.ToString()
        txtUsername.Text = row.Cells("Username").Value.ToString()

        ' Password fields remain empty for security
        txtPassword.Clear()
        txtConfirmPassword.Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedUserID = 0 Then
            MessageBox.Show("Please select a Kid Holder first.")
            Return
        End If

        If txtFullName.Text.Trim() = "" OrElse txtUsername.Text.Trim() = "" Then
            MessageBox.Show("Full Name and Username are required.")
            Return
        End If

        Try

            Using conn As MySqlConnection = DatabaseConnection.GetConnection()

                conn.Open()

                Dim query As String =
                "UPDATE Users SET FullName = @FullName, Username = @Username " &
                "WHERE UserID = @UserID AND ParentID = @ParentID AND Role = 'KidHolder'"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@UserID", selectedUserID)
                    cmd.Parameters.AddWithValue("@ParentID", currentUser.UserID)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Kid Holder updated successfully!")
                    Else
                        MessageBox.Show("No matching Kid Holder was found.")
                    End If

                End Using

            End Using

            LoadKidHolders()

        Catch ex As MySqlException

            If ex.Number = 1062 Then
                MessageBox.Show("That username is already taken.")
            Else
                MessageBox.Show("Database error: " & ex.Message)
            End If

        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message)

        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedUserID = 0 Then
            MessageBox.Show("Please select a Kid Holder first.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to delete this Kid Holder account?",
            "Confirm Deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If result <> DialogResult.Yes Then
            Return
        End If

        Try

            Using conn As MySqlConnection = DatabaseConnection.GetConnection()

                conn.Open()

                Dim query As String =
                    "DELETE FROM Users " &
                    "WHERE UserID = @UserID AND ParentID = @ParentID AND Role = 'KidHolder'"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@UserID", selectedUserID)
                    cmd.Parameters.AddWithValue("@ParentID", currentUser.UserID)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Kid Holder deleted successfully!")
                    Else
                        MessageBox.Show("No matching Kid Holder was found.")
                    End If

                End Using

            End Using

            selectedUserID = 0

            txtFullName.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
            txtConfirmPassword.Clear()

            LoadKidHolders()

        Catch ex As Exception

            MessageBox.Show("Unable to delete Kid Holder: " & ex.Message)

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFullName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()

        selectedUserID = 0

        dgvKidHolders.ClearSelection()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class