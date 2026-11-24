<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblWelcome = New Label()
        lblRole = New Label()
        btnChildren = New Button()
        btnSchedules = New Button()
        btnKidHolders = New Button()
        btnAssignments = New Button()
        btnMySchedule = New Button()
        btnLogout = New Button()
        SuspendLayout()
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Microsoft Sans Serif", 16F)
        lblWelcome.Location = New Point(72, 21)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(110, 26)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome!"
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Segoe UI", 10F)
        lblRole.Location = New Point(72, 63)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(38, 19)
        lblRole.TabIndex = 1
        lblRole.Text = "Role:"
        ' 
        ' btnChildren
        ' 
        btnChildren.Location = New Point(72, 106)
        btnChildren.Name = "btnChildren"
        btnChildren.Size = New Size(127, 23)
        btnChildren.TabIndex = 2
        btnChildren.Text = "Manage Children"
        btnChildren.UseVisualStyleBackColor = True
        ' 
        ' btnSchedules
        ' 
        btnSchedules.Location = New Point(72, 149)
        btnSchedules.Name = "btnSchedules"
        btnSchedules.Size = New Size(127, 23)
        btnSchedules.TabIndex = 3
        btnSchedules.Text = "Manage Schedules"
        btnSchedules.UseVisualStyleBackColor = True
        ' 
        ' btnKidHolders
        ' 
        btnKidHolders.Location = New Point(72, 248)
        btnKidHolders.Name = "btnKidHolders"
        btnKidHolders.Size = New Size(144, 23)
        btnKidHolders.TabIndex = 4
        btnKidHolders.Text = "Manage Kid Holders"
        btnKidHolders.UseVisualStyleBackColor = True
        ' 
        ' btnAssignments
        ' 
        btnAssignments.Location = New Point(72, 300)
        btnAssignments.Name = "btnAssignments"
        btnAssignments.Size = New Size(118, 23)
        btnAssignments.TabIndex = 5
        btnAssignments.Text = "Assign Children"
        btnAssignments.UseVisualStyleBackColor = True
        ' 
        ' btnMySchedule
        ' 
        btnMySchedule.Location = New Point(72, 197)
        btnMySchedule.Name = "btnMySchedule"
        btnMySchedule.Size = New Size(188, 23)
        btnMySchedule.TabIndex = 6
        btnMySchedule.Text = "View My Assigned Children"
        btnMySchedule.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(174, 400)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(75, 23)
        btnLogout.TabIndex = 7
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 611)
        Controls.Add(btnLogout)
        Controls.Add(btnMySchedule)
        Controls.Add(btnAssignments)
        Controls.Add(btnKidHolders)
        Controls.Add(btnSchedules)
        Controls.Add(btnChildren)
        Controls.Add(lblRole)
        Controls.Add(lblWelcome)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kids Planner - Dashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents btnChildren As Button
    Friend WithEvents btnSchedules As Button
    Friend WithEvents btnKidHolders As Button
    Friend WithEvents btnAssignments As Button
    Friend WithEvents btnMySchedule As Button
    Friend WithEvents btnLogout As Button
End Class
