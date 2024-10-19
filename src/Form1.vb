Imports System.IO
Imports System.Net

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim webView2Path As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WebView2Loader.dll")
        If ScaricaFile("https://sacred-tribute.com/community/Shaddar-Nur/WebView2Loader.dll", webView2Path) Then
            MainForm.Refresh()
            MainForm.Show()
            Me.Close()
        Else
            MessageBox.Show("Errore nel download del file.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ScaricaFile(url As String, destPath As String) As Boolean
        Try
            Using client As New WebClient()
                client.DownloadFile(url, destPath)
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Si è verificato un errore durante il download: " & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class

