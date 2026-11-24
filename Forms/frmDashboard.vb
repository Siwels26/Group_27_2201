Public Class frmDashboard
    Private ReadOnly currentUser As UserSession

    Public Sub New(user As UserSession)

        InitializeComponent()

        currentUser = user

    End Sub
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display logged-in user's information
        lblWelcome.Text = "Welcome, " & currentUser.FullName
        lblRole.Text = "Role: " & currentUser.Role

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
End Class