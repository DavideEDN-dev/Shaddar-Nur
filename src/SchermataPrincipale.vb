Imports System.IO
Imports System.Net.Http
Imports System.Text.RegularExpressions
Imports System.Diagnostics
Imports System.Windows.Forms

Public Class SchermataPrincipale
    Private substitutions As New Dictionary(Of String, String) From {
        {"NETWORK_CDKEY", "NETWORK_CDKEY : AMVW2Y3MF2OTBTSS9TLC"},
        {"NETWORK_CDKEY2", "NETWORK_CDKEY2 : 3L4FLSIRGBQS8BTCMGE9"},
        {"NETWORK_LOBBY", "NETWORK_LOBBY : 94.16.105.70"},
        {"NETWORK_LOBBYPORT", "NETWORK_LOBBYPORT : 7066"},
        {"NETWORK_PORT_LISTEN", "NETWORK_PORT_LISTEN : 2005"}
    }

    Private Sub ControllaPresenzaEseguibile()
        Dim percorsoEseguibile As String = "pureHD.exe"
        Button5.Enabled = File.Exists(percorsoEseguibile)
    End Sub

    Private Sub BtnModifica_Click(sender As Object, e As EventArgs) Handles BtnModifica.Click
        Dim filePath As String = "Settings.cfg"
        If File.Exists(filePath) Then
            Try
                Dim fileContent As String = File.ReadAllText(filePath)
                For Each kvp As KeyValuePair(Of String, String) In substitutions
                    If Not Regex.IsMatch(fileContent, "\b" & Regex.Escape(kvp.Key) & "\b") Then
                        fileContent &= vbCrLf & kvp.Value
                    Else
                        fileContent = Regex.Replace(fileContent, "\b" & Regex.Escape(kvp.Key) & "\b.*", kvp.Value)
                    End If
                Next
                File.WriteAllText(filePath, fileContent)
                MessageBox.Show("Benvenuto in Shaddar-Nur !" & vbCrLf & " " & vbCrLf &
                                "Segui il percorso:" & vbCrLf & " " & vbCrLf &
                                "Sacred On-Line>Partite Libere" & vbCrLf & " " & vbCrLf &
                                "Inserisci una Username e un Password a scelta, premi Log on.",
                                "Shaddar-Nur | Connessione al Server")
            Catch ex As Exception
                MessageBox.Show("Errore nella creazione del file: " & ex.Message, "Shaddar-Nur | Attenzione !")
            End Try
        Else
            MessageBox.Show("Il Launcher non si trova nella cartella di installazione di Sacred !", "Shaddar-Nur | Attenzione !")
            Return
        End If

        Dim percorsoEseguibile As String = "sacred.exe"
        Try
            Process.Start(percorsoEseguibile)
        Catch ex As Exception
            MessageBox.Show("Errore durante l'avvio del Gioco !" & vbCrLf & " " & vbCrLf &
                            "Impossibile rilevare l'eseguibile Sacred.exe !", "Shaddar-Nur | Attenzione !")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim discordLink As String = "https://sacred-tribute.com"
            Process.Start(New ProcessStartInfo(discordLink) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("Si è verificato un errore: " & ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim discordLink As String = "https://discord.gg/fQtr7b8H7Q"
            Process.Start(New ProcessStartInfo(discordLink) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("Si è verificato un errore: " & ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ScegliRisoluzione.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Dim discordLink As String = "https://sacred-tribute.com/community/Shaddar-Nur/patch.rar"
            Process.Start(New ProcessStartInfo(discordLink) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("Si è verificato un errore: " & ex.Message)
        End Try
    End Sub

    Private Async Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim savePath As String = Application.StartupPath
        Dim fontDirectory As String = Path.Combine(savePath, "font")
        Dim urls As New List(Of String) From {
            "https://sacred-tribute.com/community/Shaddar-Nur/pureHD/pHD.dll",
            "https://sacred-tribute.com/community/Shaddar-Nur/pureHD/pureHD.exe",
            "https://sacred-tribute.com/community/Shaddar-Nur/pureHD/font/AntiquaSSK.TTF",
            "https://sacred-tribute.com/community/Shaddar-Nur/pureHD/font/CyrillicChancellor.TTF"
        }

        Try
            If Not Directory.Exists(fontDirectory) Then
                Directory.CreateDirectory(fontDirectory)
            End If

            Using client As New HttpClient()
                For Each fileUrl In urls
                    Dim fileName As String = Path.GetFileName(fileUrl)
                    Dim fullPath As String

                    If fileUrl.Contains("/font/") Then
                        fullPath = Path.Combine(fontDirectory, fileName)
                    Else
                        fullPath = Path.Combine(savePath, fileName)
                    End If

                    ' Download the file asynchronously and save it to the specified path.
                    Dim responseBytes As Byte() = Await client.GetByteArrayAsync(fileUrl)
                    File.WriteAllBytes(fullPath, responseBytes)
                Next
            End Using

            MessageBox.Show("pureHD installata con Successo !", "Shaddar-Nur | Attenzione !", MessageBoxButtons.OK)
            Dim result As DialogResult = MessageBox.Show("Vuoi avviare ora il gioco con la Mod Grafica pureHD ?",
                                                          "Shaddar-Nur | Attenzione !",
                                                          MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                Dim form3 As New ScegliRisoluzione()
                form3.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("Errore: " & ex.Message, "Download Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MessageBox.Show("Attualmente non disponibile", "Shaddar-Nur | Attenzione !")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        WebView22.CoreWebView2.Navigate("https://sacred-tribute.com/map/")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        WebView22.CoreWebView2.Navigate("https://shaddarnur.altervista.org/pages/media.php")
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControllaPresenzaEseguibile()
        Dim dllPath1 As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "granny.dll")
        Dim dllPath2 As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tincat2.dll")

        If Not File.Exists(dllPath1) And Not File.Exists(dllPath2) Then
            MessageBox.Show("Il Launcher non si trova nel percorso di installazione di Sacred !",
                              "Shaddar-Nur | Attenzione !")
            Me.Close()
            Return
        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MessageBox.Show("Sacred-Tribute - https://sacred-tribute.com" & vbCrLf & "" & vbCrLf &
                        "LobbyServer Hosting - DarkHack[DarkBloods.Admin]" & vbCrLf & "" & vbCrLf &
                        "LobbyServer Developer - Shaddar-Nur Launcher Revisor" & vbCrLf & "kryotek777" & vbCrLf & "" & vbCrLf &
                        "TUROKhc - Sacred Online Community ITA" & vbCrLf & "" & vbCrLf &
                        "pureHD 1.40 | Mappa Interattiva - WilliamTokarev" & vbCrLf & "" & vbCrLf &
                        "Un Ringraziamento speciale anche per tutti voi amici di" & vbCrLf &
                        "Sacred Online Community ITA !" & vbCrLf & "" & vbCrLf &
                        "DavideEDN", "Ringraziamenti Speciali | Special Thanks")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        WebView22.CoreWebView2.Navigate("https://shaddarnur.altervista.org/pages/news2.html")
    End Sub

End Class
