Imports System.Threading.Tasks

Public Class frmSplash

    Private countdown As Integer = 2

    Private Async Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblStatus.Text = "Checking database connection..."
        progressLoading.Style = ProgressBarStyle.Marquee

        Dim connected As Boolean = Await Task.Run(Function()

                                                      Try
                                                          Using conn = DatabaseConnection.GetConnection()
                                                              conn.Open()
                                                              Return True
                                                          End Using

                                                      Catch ex As Exception
                                                          Return False

                                                      End Try

                                                  End Function)

        If connected Then
            lblStatus.Text = "✔ Connected"
        Else
            lblStatus.Text = "Experiencing problems connecting to the database"
        End If

        tmrSplash.Start()

    End Sub

    Private Sub tmrSplash_Tick(sender As Object, e As EventArgs) Handles tmrSplash.Tick

        countdown -= 1

        If countdown <= 0 Then

            tmrSplash.Stop()

            Dim login As New frmLogin()
            login.Show()

            Me.Hide()

        End If

    End Sub

End Class