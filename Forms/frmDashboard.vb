Public Class frmDashboard
    Private ReadOnly currentUser As UserSession

    Public Sub New(user As UserSession)

        InitializeComponent()

        currentUser = user

    End Sub
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Display logged-in user's information at the top
        lblWelcome.Text = "Welcome, " & currentUser.FullName
        lblRole.Text = "Role: " & currentUser.Role

        ' Display information in the bottom StatusStrip
        lblUserStatus.Text = "Logged in as: " & currentUser.FullName
        lblRoleStatus.Text = "Role: " & currentUser.Role
        lblDateStatus.Text = "Date: " & DateTime.Now.ToString("dd/MM/yyyy")

        ' Display buttons according to user role
        If currentUser.Role = "Parent" Then

            btnChildren.Visible = True
            btnSchedules.Visible = True
            btnKidHolders.Visible = True
            btnAssignments.Visible = True
            btnMySchedule.Visible = False

        ElseIf currentUser.Role = "KidHolder" Then

            btnChildren.Visible = False
            btnSchedules.Visible = False
            btnKidHolders.Visible = False
            btnAssignments.Visible = False
            btnMySchedule.Visible = True

        End If

    End Sub

    Private Sub btnKidHolders_Click(sender As Object, e As EventArgs) Handles btnKidHolders.Click
        Using holderForm As New frmManageKidHolders(currentUser)

            holderForm.ShowDialog()

        End Using
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show(
       "Are you sure you want to log out?",
       "Confirm Logout",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   )

        If result = DialogResult.Yes Then

            'Find the existing login form
            Dim loginForm As frmLogin =
                TryCast(Application.OpenForms("frmLogin"), frmLogin)

            If loginForm IsNot Nothing Then

                'Clear the password
                loginForm.txtPassword.Clear()

                'Display the login form again
                loginForm.Show()
                loginForm.Activate()

            End If

            'Close the dashboard
            Me.Close()

        End If
    End Sub
End Class