<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageKidHolders
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
        btnAdd = New Button()
        btnUpdate = New Button()
        btnClear = New Button()
        dgvKidHolders = New DataGridView()
        btnDelete = New Button()
        btnClose = New Button()
        CType(dgvKidHolders, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(63, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(114, 15)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Manage Kid Holders"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Location = New Point(63, 56)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(64, 15)
        lblFullName.TabIndex = 1
        lblFullName.Text = "Full Name:"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(196, 48)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(100, 23)
        txtFullName.TabIndex = 2
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(63, 95)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(63, 15)
        lblUsername.TabIndex = 3
        lblUsername.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(196, 87)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(100, 23)
        txtUsername.TabIndex = 4
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(63, 141)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(57, 15)
        lblPassword.TabIndex = 5
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(196, 133)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(100, 23)
        txtPassword.TabIndex = 6
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.Location = New Point(63, 190)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(107, 15)
        lblConfirmPassword.TabIndex = 7
        lblConfirmPassword.Text = "Confirm Password:"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(196, 182)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(100, 23)
        txtConfirmPassword.TabIndex = 8
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(121, 224)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(120, 23)
        btnAdd.TabIndex = 9
        btnAdd.Text = "Create Account"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(63, 263)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(141, 301)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 11
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dgvKidHolders
        ' 
        dgvKidHolders.AllowUserToAddRows = False
        dgvKidHolders.AllowUserToDeleteRows = False
        dgvKidHolders.AllowUserToResizeRows = False
        dgvKidHolders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvKidHolders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKidHolders.Location = New Point(30, 350)
        dgvKidHolders.MultiSelect = False
        dgvKidHolders.Name = "dgvKidHolders"
        dgvKidHolders.ReadOnly = True
        dgvKidHolders.RowHeadersVisible = False
        dgvKidHolders.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKidHolders.Size = New Size(650, 250)
        dgvKidHolders.TabIndex = 12
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(221, 263)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 13
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(500, 263)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 14
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' frmManageKidHolders
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(734, 611)
        ControlBox = False
        Controls.Add(btnClose)
        Controls.Add(btnDelete)
        Controls.Add(dgvKidHolders)
        Controls.Add(btnClear)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(txtConfirmPassword)
        Controls.Add(lblConfirmPassword)
        Controls.Add(txtPassword)
        Controls.Add(lblPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblUsername)
        Controls.Add(txtFullName)
        Controls.Add(lblFullName)
        Controls.Add(lblTitle)
        Name = "frmManageKidHolders"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmManageKidHolders"
        CType(dgvKidHolders, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvKidHolders As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
End Class
