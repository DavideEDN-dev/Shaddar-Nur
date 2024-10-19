Imports System.Diagnostics
Imports System.Text.RegularExpressions

Public Class Form3
    Private substitutions As New Dictionary(Of String, String) From {
        {"NETWORK_CDKEY", "NETWORK_CDKEY : AMVW2Y3MF2OTBTSS9TLC"},
        {"NETWORK_CDKEY2", "NETWORK_CDKEY2 : 3L4FLSIRGBQS8BTCMGE9"},
        {"NETWORK_LOBBY", "NETWORK_LOBBY : 94.16.105.70"},
        {"NETWORK_LOBBYPORT", "NETWORK_LOBBYPORT : 7066"},
        {"NETWORK_PORT_LISTEN", "NETWORK_PORT_LISTEN : 2005"}
    }

    Private resolutionX As Integer = 1920
    Private resolutionY As Integer = 1080

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Risoluzione HD 720p: 1280x720")
        ComboBox1.Items.Add("Risoluzione HD Ready: 1366x768")
        ComboBox1.Items.Add("Risoluzione Full HD 1080p: 1920x1080")
        ComboBox1.Items.Add("Risoluzione Ultra HD 4K: 3840x2160")

        ComboBox1.SelectedItem = "Risoluzione Full HD 1080p: 1920x1080"
    End Sub

    Private Sub ButtonApply_Click(sender As Object, e As EventArgs) Handles ButtonApply.Click
        Dim filePath As String = "Settings.cfg"
        Dim executablePath As String = "pureHD.exe"

        If Not System.IO.File.Exists(filePath) Then
            CreateDefaultSettings(filePath)
            WriteSubstitutions(filePath)
        Else
            UpdateSettings(filePath)
        End If

        If Not System.IO.File.Exists(executablePath) Then
            MessageBox.Show("Il file pureHD.exe non è presente nella cartella di installazione!", "| Shaddar-Nur | Attenzione ! |")
            Return
        End If

        If System.IO.File.Exists(filePath) Then
            Try
                ModifyFileContent(filePath, GetSubstitutions())
                ShowWelcomeMessage()
            Catch ex As Exception
                MessageBox.Show("Errore nella creazione del file: " & ex.Message, "| Shaddar-Nur | Attenzione ! |")
            End Try
        Else
            MessageBox.Show("Il Launcher non si trova nella cartella di installazione di Sacred !", "| Shaddar-Nur | Attenzione ! |")
            Return
        End If

        Try
            Process.Start(executablePath)
        Catch ex As Exception
            MessageBox.Show("Errore durante l'avvio del Gioco !" & vbCrLf & " " & vbCrLf &
                            "Impossibile rilevare l'eseguibile pureHD.exe !", "| Shaddar-Nur | Attenzione ! |")
        End Try

        Me.Close()
    End Sub

    Private Sub CreateDefaultSettings(filePath As String)
        Using writer As New System.IO.StreamWriter(filePath)
            writer.WriteLine($"PHD_RES_SCX : {resolutionX}")
            writer.WriteLine($"PHD_RES_SCY : {resolutionY}")
            WriteFontSettings(writer)
        End Using
        MessageBox.Show("File Settings.cfg creato con risoluzioni e impostazioni del font predefinite.")
    End Sub

    Private Sub WriteSubstitutions(filePath As String)
        Using writer As New System.IO.StreamWriter(filePath, True)
            For Each kvp In substitutions
                writer.WriteLine(kvp.Value)
            Next
        End Using
    End Sub

    Private Sub UpdateSettings(filePath As String)
        Dim lines As List(Of String) = System.IO.File.ReadAllLines(filePath).ToList()

        Dim foundX As Boolean = False
        Dim foundY As Boolean = False

        For i As Integer = 0 To lines.Count - 1
            If lines(i).StartsWith("PHD_RES_SCX") Then
                lines(i) = $"PHD_RES_SCX : {resolutionX}"
                foundX = True
            ElseIf lines(i).StartsWith("PHD_RES_SCY") Then
                lines(i) = $"PHD_RES_SCY : {resolutionY}"
                foundY = True
            End If
        Next

        If Not foundX Then lines.Add($"PHD_RES_SCX : {resolutionX}")
        If Not foundY Then lines.Add($"PHD_RES_SCY : {resolutionY}")

        For Each kvp In substitutions
            Dim keyExists As Boolean = False

            For i As Integer = 0 To lines.Count - 1
                If lines(i).StartsWith(kvp.Key) Then
                    lines(i) = kvp.Value
                    keyExists = True
                    Exit For
                End If
            Next

            If Not keyExists Then
                lines.Add(kvp.Value)
            End If
        Next

        WriteFontSettings(lines)

        System.IO.File.WriteAllLines(filePath, lines)
    End Sub

    Private Function GetSubstitutions() As Dictionary(Of String, String)
        Return substitutions
    End Function

    Private Sub ModifyFileContent(filePath As String, substitutions As Dictionary(Of String, String))
        Dim fileContent As String = System.IO.File.ReadAllText(filePath)

        For Each kvp As KeyValuePair(Of String, String) In substitutions
            If Not Regex.IsMatch(fileContent, "\b" & Regex.Escape(kvp.Key) & "\b") Then
                fileContent &= vbCrLf & kvp.Value
            Else
                fileContent = Regex.Replace(fileContent, "\b" & Regex.Escape(kvp.Key) & "\b.*", kvp.Value)
            End If
        Next

        System.IO.File.WriteAllText(filePath, fileContent)
    End Sub

    Private Sub ShowWelcomeMessage()
        MessageBox.Show("Benvenuto in Shaddar-Nur !" & vbCrLf & " " & vbCrLf &
                        "Segui il percorso:" & vbCrLf & " " & vbCrLf &
                        "Sacred On-Line>Partite Libere" & vbCrLf & " " & vbCrLf &
                        "Inserisci una Username e un Password a scelta, premi Log on.",
                        "| Shaddar-Nur | Connessione al Server |")
    End Sub

    Private Sub WriteFontSettings(writer As System.IO.StreamWriter)
        writer.WriteLine("FONT : 1, ""CyrillicChancellor"", 13")
        writer.WriteLine("FONT : 2, ""AntiquaSSK"", 12")
        writer.WriteLine("FONT : 3, ""CyrillicChancellor"", 16")
        writer.WriteLine("FONT : 4, ""AntiquaSSK"", 25")
        writer.WriteLine("FONT : 5, ""AntiquaSSK"", 16")
        writer.WriteLine("FONT : 6, ""AntiquaSSK"", 18")
        writer.WriteLine("FONT : 7, ""CyrillicChancellor"", 8")
    End Sub

    Private Sub WriteFontSettings(lines As List(Of String))
        Dim fontSettings As String() = {
            "FONT : 1, ""CyrillicChancellor"", 13",
            "FONT : 2, ""AntiquaSSK"", 12",
            "FONT : 3, ""CyrillicChancellor"", 16",
            "FONT : 4, ""AntiquaSSK"", 25",
            "FONT : 5, ""AntiquaSSK"", 16",
            "FONT : 6, ""AntiquaSSK"", 18",
            "FONT : 7, ""CyrillicChancellor"", 8"
        }

        For Each setting In fontSettings
            If Not lines.Contains(setting) Then
                lines.Add(setting)
            End If
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedResolution As String = ComboBox1.SelectedItem.ToString()
        Dim dimensions() As String = selectedResolution.Split(":"c)(1).Trim().Split("x"c)

        If dimensions.Length = 2 Then
            Integer.TryParse(dimensions(0), resolutionX)
            Integer.TryParse(dimensions(1), resolutionY)
        End If
    End Sub

End Class