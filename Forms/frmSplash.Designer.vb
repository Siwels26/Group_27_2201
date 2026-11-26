<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSplash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblTitle = New Label()
        lblSubtitle = New Label()
        picLogo = New PictureBox()
        progressLoading = New ProgressBar()
        lblStatus = New Label()
        tmrSplash = New Timer(components)
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Kristen ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(114, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(409, 36)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Kids Weekly Schedule Planner"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Location = New Point(152, 154)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(230, 15)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = vbTab & "Managing your children's weekly activities"
        ' 
        ' picLogo
        ' 
        picLogo.Location = New Point(214, 67)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(100, 50)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 2
        picLogo.TabStop = False
        ' 
        ' progressLoading
        ' 
        progressLoading.Location = New Point(214, 224)
        progressLoading.MarqueeAnimationSpeed = 30
        progressLoading.Name = "progressLoading"
        progressLoading.Size = New Size(100, 23)
        progressLoading.Style = ProgressBarStyle.Marquee
        progressLoading.TabIndex = 3
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(183, 294)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(179, 15)
        lblStatus.TabIndex = 4
        lblStatus.Text = "Checking database connection..."
        ' 
        ' tmrSplash
        ' 
        tmrSplash.Interval = 1000
        ' 
        ' frmSplash
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(634, 361)
        ControlBox = False
        Controls.Add(lblStatus)
        Controls.Add(progressLoading)
        Controls.Add(picLogo)
        Controls.Add(lblSubtitle)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmSplash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kids Weekly Schedule Planner"
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents progressLoading As ProgressBar
    Friend WithEvents lblStatus As Label
    Friend WithEvents tmrSplash As Timer

End Class
