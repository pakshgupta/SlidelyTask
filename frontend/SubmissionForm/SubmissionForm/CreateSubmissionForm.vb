Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Collections.Specialized

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Private Sub btnStartPause_Click(sender As Object, e As EventArgs) Handles btnStartPause.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            btnStartPause.Text = "Start"
        Else
            stopwatch.Start()
            btnStartPause.Text = "Pause"
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim github As String = txtGithub.Text
        Dim timeElapsed As String = stopwatch.Elapsed.ToString()

        Await SubmitDataAsync(name, email, phone, github, timeElapsed)
        MessageBox.Show("Submission Successful!")
    End Sub

    Private Async Function SubmitDataAsync(name As String, email As String, phone As String, github As String, timeElapsed As String) As Task
        Using client As New HttpClient()
            Dim values = New NameValueCollection From {
                {"name", name},
                {"email", email},
                {"phone", phone},
                {"github_link", github},
                {"stopwatch_time", timeElapsed}
            }
            Dim content = New FormUrlEncodedContent(values.Cast(Of DictionaryEntry).ToDictionary(Function(de) de.Key.ToString(), Function(de) de.Value.ToString()))
            Await client.PostAsync("http://localhost:3000/api/v1/submit", content)
        End Using
    End Function

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.S) Then
            btnSubmit.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
