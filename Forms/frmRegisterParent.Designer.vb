<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterParent
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
        lblTitle = New Label()
        lblFullName = New Label()
        txtFullName = New TextBox()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        lblConfirmPassword = New Label()
        txtConfirmPassword = New TextBox()
        btnRegister = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(44, 24)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(107, 15)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Parent Registration"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Location = New Point(44, 76)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(61, 15)
        lblFullName.TabIndex = 1
        lblFullName.Text = "Full Name"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(202, 68)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(100, 23)
        txtFullName.TabIndex = 2
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(44, 119)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(60, 15)
        lblUsername.TabIndex = 3
        lblUsername.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(202, 111)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(100, 23)
        txtUsername.TabIndex = 4
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(44, 165)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(57, 15)
        lblPassword.TabIndex = 5
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(202, 157)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(100, 23)
        txtPassword.TabIndex = 6
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.Location = New Point(44, 205)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(104, 15)
        lblConfirmPassword.TabIndex = 7
        lblConfirmPassword.Text = "Confirm Password"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(202, 197)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(100, 23)
        txtConfirmPassword.TabIndex = 8
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(116, 277)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(105, 23)
        btnRegister.TabIndex = 9
        btnRegister.Text = "Create Account"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(128, 352)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' frmRegisterParent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(600, 450)
        ControlBox = False
        Controls.Add(btnCancel)
        Controls.Add(btnRegister)
        Controls.Add(txtConfirmPassword)
        Controls.Add(lblConfirmPassword)
        Controls.Add(txtPassword)
        Controls.Add(lblPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblUsername)
        Controls.Add(txtFullName)
        Controls.Add(lblFullName)
        Controls.Add(lblTitle)
        Name = "frmRegisterParent"
        Text = "frmRegisterParent"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnCancel As Button
End Class
