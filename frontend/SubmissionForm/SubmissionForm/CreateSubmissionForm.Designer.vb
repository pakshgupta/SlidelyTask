<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtGithub = New TextBox()
        txtPhone = New TextBox()
        btnStartPause = New Button()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(97, 31)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Enter Name"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(354, 31)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Enter Email"
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 2
        ' 
        ' txtGithub
        ' 
        txtGithub.Location = New Point(354, 144)
        txtGithub.Name = "txtGithub"
        txtGithub.PlaceholderText = "Enter GitHub Repo Link"
        txtGithub.Size = New Size(150, 31)
        txtGithub.TabIndex = 3
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(88, 144)
        txtPhone.Name = "txtPhone"
        txtPhone.PlaceholderText = "Enter Phone"
        txtPhone.Size = New Size(150, 31)
        txtPhone.TabIndex = 4
        ' 
        ' btnStartPause
        ' 
        btnStartPause.Location = New Point(126, 254)
        btnStartPause.Name = "btnStartPause"
        btnStartPause.Size = New Size(112, 34)
        btnStartPause.TabIndex = 5
        btnStartPause.Text = "Start"
        btnStartPause.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(319, 254)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(112, 34)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSubmit)
        Controls.Add(btnStartPause)
        Controls.Add(txtPhone)
        Controls.Add(txtGithub)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnStartPause As Button
    Friend WithEvents btnSubmit As Button
End Class
