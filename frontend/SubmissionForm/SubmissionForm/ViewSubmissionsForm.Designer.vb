<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        btnPrevious = New Button()
        lblSubmissionData = New Label()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(47, 136)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(183, 74)
        btnPrevious.TabIndex = 0
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' lblSubmissionData
        ' 
        lblSubmissionData.AutoSize = True
        lblSubmissionData.Location = New Point(187, 45)
        lblSubmissionData.Name = "lblSubmissionData"
        lblSubmissionData.Size = New Size(188, 25)
        lblSubmissionData.TabIndex = 1
        lblSubmissionData.Text = "Submission Data Here"
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(295, 142)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(199, 62)
        btnNext.TabIndex = 2
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnNext)
        Controls.Add(lblSubmissionData)
        Controls.Add(btnPrevious)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblSubmissionData As Label
    Friend WithEvents btnNext As Button
End Class
