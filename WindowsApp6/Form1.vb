Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Diagnostics
Imports System.Windows.Forms

Public Class Form1
    ' Dizionario per le sostituzioni
    Private substitutions As New Dictionary(Of String, String) From {
        {"NETWORK_CDKEY", "NETWORK_CDKEY : AMVW2Y3MF2OTBTSS9TLC"},
        {"NETWORK_CDKEY2", "NETWORK_CDKEY2 : 3L4FLSIRGBQS8BTCMGE9"},
        {"NETWORK_LOBBY", "NETWORK_LOBBY : shaddarnur.vpsgh.it"},
        {"NETWORK_LOBBYPORT", "NETWORK_LOBBYPORT : 7066"},
        {"NETWORK_PORT_LISTEN", "NETWORK_PORT_LISTEN : 2005"}
    }

    Private updater As New Aggiornatore()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControllaPresenzaEseguibile()
        ' Controlla la presenza dei file DLL richiesti
        Dim dllPath1 As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "granny.dll")
        Dim dllPath2 As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tincat2.dll")

        If Not File.Exists(dllPath1) And Not File.Exists(dllPath2) Then
            MessageBox.Show("Il Launcher non si trova nel percorso di installazione di Sacred !",
                            "Shaddar-Nur | Attenzione !")
            Me.Close() ' Chiudi l'applicazione se i file richiesti non sono trovati
            Return
        End If

        ' Controlla aggiornamenti all'avvio
        updater.ControllaAggiornamenti()
    End Sub

    Private Sub ControllaPresenzaEseguibile()
        Dim percorsoEseguibile As String = "pureHD.exe" ' Percorso all'eseguibile

        ' Abilita o disabilita Button5 in base alla presenza di pureHD.exe
        Button5.Enabled = File.Exists(percorsoEseguibile)
    End Sub

    Private Sub btnModifica_Click(sender As Object, e As EventArgs) Handles btnModifica.Click
        Dim filePath As String = "Settings.cfg" ' Modifica con il percorso corretto

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
            Return ' Aggiungi un return per evitare di continuare l'esecuzione se il file non esiste.
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
        Dim url As String = "https://shaddarnur.altervista.org"
        Process.Start(url)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim discordLink As String = "https://discord.gg/CBCHKDFWut"
        Process.Start(discordLink)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.Show()
    End Sub

    Private Sub WebBrowser3_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser3.DocumentCompleted
        WebBrowser3.Document.Body.Style = "background-color: #4b3d2b; margin: 0; padding: 0;"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim url As String = "https://myfree.altervista.org/patch.rar"
        Process.Start(url)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim savePath As String = Application.StartupPath
        Dim fontDirectory As String = Path.Combine(savePath, "font")

        ' List of files to download
        Dim urls As New List(Of String) From {
            "http://myfree.altervista.org/pureHD/ChangeLog_eng.doc",
            "http://myfree.altervista.org/pureHD/pHD.dll",
            "http://myfree.altervista.org/pureHD/pureHD.exe",
            "http://myfree.altervista.org/pureHD/font/AntiquaSSK.TTF",
            "http://myfree.altervista.org/pureHD/font/CyrillicChancellor.TTF"
        }

        Try
            ' Create font directory if it doesn't exist
            If Not Directory.Exists(fontDirectory) Then
                Directory.CreateDirectory(fontDirectory)
            End If

            Using client As New WebClient()
                For Each fileUrl In urls
                    Dim fileName As String = Path.GetFileName(fileUrl)

                    ' Check if the file is a font file and set the appropriate path
                    If fileUrl.Contains("/font/") Then
                        Dim fullPath As String = Path.Combine(fontDirectory, fileName)
                        client.DownloadFile(fileUrl, fullPath)
                    Else
                        Dim fullPath As String = Path.Combine(savePath, fileName)
                        client.DownloadFile(fileUrl, fullPath)
                    End If
                Next
            End Using

            MessageBox.Show("pureHD installata con Successo !", "Shaddar-Nur | Attenzione !", MessageBoxButtons.OK)

            ' Ask user if they want to start the game with the mod pureHD
            Dim result As DialogResult = MessageBox.Show("Vuoi avviare ora il gioco con la Mod Grafica pureHD ?",
                                                          "Shaddar-Nur | Attenzione !",
                                                          MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                ' Open Form3 to start the game
                Dim form3 As New Form3()
                form3.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Download Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form2.Show()
    End Sub

    Private Sub WebBrowser2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted
        WebBrowser2.Document.Body.Style = "background-color: #4b3d2b; margin: 0; padding: 0;"
    End Sub

End Class

Public Class Aggiornatore

    Private Const UrlFileVersioneRemota As String = "https://myfree.altervista.org/update.txt"
    Private Const UrlFileRemoto As String = "https://myfree.altervista.org/Shaddar-Nur.exe"
    Private Const PercorsoFileLocale As String = "Shaddar-Nur.exe"

    ' Definisci la versione corrente dell'applicazione
    Private Const VersioneLocale As String = "1.1.0" ' Modifica questa stringa con la tua versione attuale

    Public Sub ControllaAggiornamenti()
        Dim versioneRemota As String = OttieniVersioneRemota()

        ' Confronta le versioni
        If New Version(versioneRemota) > New Version(VersioneLocale) Then
            Dim risultato As DialogResult = MessageBox.Show("È disponibile una nuova versione. Vuoi aggiornare?",
                                                             "Shaddar-Nur | Attenzione !",
                                                             MessageBoxButtons.YesNo)

            If risultato = DialogResult.Yes Then
                CreaFileBatchAggiornamento() ' Crea il file batch per gestire l'aggiornamento 
            Else
            End If
        End If
    End Sub

    Private Function OttieniVersioneRemota() As String
        Using client As New WebClient()
            Return client.DownloadString(UrlFileVersioneRemota).Trim()
        End Using
    End Function

    Private Sub CreaFileBatchAggiornamento()
        Dim batchFilePath As String = Path.Combine(Path.GetTempPath(), "aggiorna.bat")

        Using writer As New StreamWriter(batchFilePath)
            writer.WriteLine("@echo off")
            writer.WriteLine("echo Chiusura dell'applicazione...")
            writer.WriteLine("taskkill /F /IM """ & PercorsoFileLocale & """") ' Chiudi l'applicazione corrente

            writer.WriteLine("echo Eliminazione dell'eseguibile corrente...")
            writer.WriteLine("del """ & PercorsoFileLocale & """") ' Elimina l'eseguibile esistente

            writer.WriteLine("echo Download della nuova versione...")
            writer.WriteLine("curl -o """ & PercorsoFileLocale & """ """ & UrlFileRemoto & """") ' Scarica il nuovo eseguibile

            writer.WriteLine("echo Avvio della nuova applicazione...")
            writer.WriteLine("start """" """ & PercorsoFileLocale & """") ' Avvia la nuova applicazione

            writer.WriteLine("echo Pulizia...")
            writer.WriteLine("del """ & batchFilePath & """") ' Elimina il file batch dopo l'esecuzione

            writer.WriteLine("exit")
        End Using

        ' Crea un file VBS per eseguire il batch in modo invisibile.
        Dim vbsFilePath As String = Path.Combine(Path.GetTempPath(), "esegui_aggiornamento.vbs")

        Using vbsWriter As New StreamWriter(vbsFilePath)
            vbsWriter.WriteLine("Set WshShell = CreateObject(""WScript.Shell"")")
            vbsWriter.WriteLine("WshShell.Run """ & batchFilePath & """, 0") ' Esegui il batch in modo invisibile.
            vbsWriter.WriteLine("Set WshShell = Nothing")
        End Using

        Process.Start(vbsFilePath) ' Esegui il file VBS creato.
    End Sub

End Class