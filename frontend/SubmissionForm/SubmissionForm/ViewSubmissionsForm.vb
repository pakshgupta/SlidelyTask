Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Text.Json

Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmissionsAsync()
        ShowSubmission(0)
    End Sub

    Private Async Function LoadSubmissionsAsync() As Task
        Using client As New HttpClient()
            Dim response = Await client.GetStringAsync("http://localhost:3000/api/v1/read?index=0")
            submissions = JsonSerializer.Deserialize(Of List(Of Submission))(response)
        End Using
    End Function

    Private Sub ShowSubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            Dim submission = submissions(index)
            lblSubmissionData.Text = $"Name: {submission.Name}" & vbCrLf &
                                     $"Email: {submission.Email}" & vbCrLf &
                                     $"Phone: {submission.Phone}" & vbCrLf &
                                     $"GitHub: {submission.GitHubLink}" & vbCrLf &
                                     $"Time: {submission.StopwatchTime}"
            currentIndex = index
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        ShowSubmission(Math.Max(0, currentIndex - 1))
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ShowSubmission(Math.Min(submissions.Count - 1, currentIndex + 1))
    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHubLink As String
    Public Property StopwatchTime As String
End Class
