<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SchermataPrincipale
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SchermataPrincipale))
        WebBrowser2 = New WebBrowser()
        WebBrowser3 = New WebBrowser()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        GroupBox2 = New GroupBox()
        WebView22 = New Microsoft.Web.WebView2.WinForms.WebView2()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        GroupBox5 = New GroupBox()
        BtnModifica = New Button()
        Button5 = New Button()
        Timer1 = New Timer(components)
        Button6 = New Button()
        GroupBox6 = New GroupBox()
        GroupBox7 = New GroupBox()
        Button9 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        GroupBox8 = New GroupBox()
        Button13 = New Button()
        Button10 = New Button()
        Button12 = New Button()
        Button11 = New Button()
        GroupBox2.SuspendLayout()
        CType(WebView22, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox6.SuspendLayout()
        GroupBox7.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox8.SuspendLayout()
        SuspendLayout()
        ' 
        ' WebBrowser2
        ' 
        WebBrowser2.AllowNavigation = False
        WebBrowser2.IsWebBrowserContextMenuEnabled = False
        WebBrowser2.Location = New Point(7, 42)
        WebBrowser2.Margin = New Padding(4, 3, 4, 3)
        WebBrowser2.MinimumSize = New Size(23, 23)
        WebBrowser2.Name = "WebBrowser2"
        WebBrowser2.ScriptErrorsSuppressed = True
        WebBrowser2.ScrollBarsEnabled = False
        WebBrowser2.Size = New Size(410, 99)
        WebBrowser2.TabIndex = 4
        WebBrowser2.Url = New Uri("http://185.229.237.120/connessioni.php", UriKind.Absolute)
        ' 
        ' WebBrowser3
        ' 
        WebBrowser3.AllowNavigation = False
        WebBrowser3.IsWebBrowserContextMenuEnabled = False
        WebBrowser3.Location = New Point(7, 22)
        WebBrowser3.Margin = New Padding(4, 3, 4, 3)
        WebBrowser3.MinimumSize = New Size(23, 23)
        WebBrowser3.Name = "WebBrowser3"
        WebBrowser3.ScriptErrorsSuppressed = True
        WebBrowser3.ScrollBarsEnabled = False
        WebBrowser3.Size = New Size(410, 114)
        WebBrowser3.TabIndex = 5
        WebBrowser3.Url = New Uri("http://185.229.237.120/checkserver2.php", UriKind.Absolute)
        WebBrowser3.WebBrowserShortcutsEnabled = False
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(8, 54)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(273, 27)
        Button1.TabIndex = 7
        Button1.TabStop = False
        Button1.Text = "Sacred-Tribute"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(6, 21)
        Button2.Name = "Button2"
        Button2.Size = New Size(351, 23)
        Button2.TabIndex = 8
        Button2.Text = "Download Patch Italiana"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(6, 50)
        Button3.Name = "Button3"
        Button3.Size = New Size(352, 23)
        Button3.TabIndex = 9
        Button3.Text = "Download pureHD 1.40"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.Black
        Button4.Location = New Point(8, 21)
        Button4.Margin = New Padding(4, 3, 4, 3)
        Button4.Name = "Button4"
        Button4.Size = New Size(273, 27)
        Button4.TabIndex = 8
        Button4.TabStop = False
        Button4.Text = "Discord"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(WebView22)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.FromArgb(CByte(225), CByte(198), CByte(168))
        GroupBox2.Location = New Point(13, 112)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.Size = New Size(892, 517)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        ' 
        ' WebView22
        ' 
        WebView22.AllowExternalDrop = True
        WebView22.CreationProperties = Nothing
        WebView22.DefaultBackgroundColor = Color.White
        WebView22.Location = New Point(7, 14)
        WebView22.Name = "WebView22"
        WebView22.Size = New Size(878, 497)
        WebView22.Source = New Uri("https://shaddarnur.altervista.org/pages/news2.html", UriKind.Absolute)
        WebView22.TabIndex = 0
        WebView22.ZoomFactor = 1R
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(GroupBox4)
        GroupBox3.Controls.Add(WebBrowser2)
        GroupBox3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.ForeColor = Color.FromArgb(CByte(225), CByte(198), CByte(168))
        GroupBox3.Location = New Point(1424, 179)
        GroupBox3.Margin = New Padding(4, 3, 4, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4, 3, 4, 3)
        GroupBox3.Size = New Size(346, 153)
        GroupBox3.TabIndex = 11
        GroupBox3.TabStop = False
        GroupBox3.Text = "Status Giocatori"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Location = New Point(0, 160)
        GroupBox4.Margin = New Padding(4, 3, 4, 3)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(4, 3, 4, 3)
        GroupBox4.Size = New Size(425, 237)
        GroupBox4.TabIndex = 14
        GroupBox4.TabStop = False
        GroupBox4.Text = "GroupBox4"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(BtnModifica)
        GroupBox5.Controls.Add(Button5)
        GroupBox5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox5.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        GroupBox5.Location = New Point(913, 533)
        GroupBox5.Margin = New Padding(4, 3, 4, 3)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Padding = New Padding(4, 3, 4, 3)
        GroupBox5.Size = New Size(288, 96)
        GroupBox5.TabIndex = 12
        GroupBox5.TabStop = False
        GroupBox5.Text = "Gioca a Sacred"
        ' 
        ' BtnModifica
        ' 
        BtnModifica.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnModifica.ForeColor = Color.Black
        BtnModifica.Location = New Point(8, 57)
        BtnModifica.Margin = New Padding(4, 3, 4, 3)
        BtnModifica.Name = "BtnModifica"
        BtnModifica.Size = New Size(273, 27)
        BtnModifica.TabIndex = 6
        BtnModifica.TabStop = False
        BtnModifica.Text = "Avvia il Gioco (Sacred.exe)"
        BtnModifica.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.Black
        Button5.Location = New Point(8, 24)
        Button5.Margin = New Padding(4, 3, 4, 3)
        Button5.Name = "Button5"
        Button5.Size = New Size(273, 27)
        Button5.TabIndex = 7
        Button5.TabStop = False
        Button5.Text = "Avvia il Gioco (pureHD.exe)"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 6000
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(1601, 62)
        Button6.Margin = New Padding(4, 3, 4, 3)
        Button6.Name = "Button6"
        Button6.Size = New Size(230, 27)
        Button6.TabIndex = 13
        Button6.Text = "Button6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(WebBrowser3)
        GroupBox6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox6.ForeColor = Color.FromArgb(CByte(225), CByte(198), CByte(168))
        GroupBox6.Location = New Point(1443, 295)
        GroupBox6.Margin = New Padding(4, 3, 4, 3)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Padding = New Padding(4, 3, 4, 3)
        GroupBox6.Size = New Size(326, 167)
        GroupBox6.TabIndex = 6
        GroupBox6.TabStop = False
        GroupBox6.Text = "Status GameServers"
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Controls.Add(Button9)
        GroupBox7.Controls.Add(Button7)
        GroupBox7.Controls.Add(Button8)
        GroupBox7.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox7.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        GroupBox7.Location = New Point(913, 397)
        GroupBox7.Margin = New Padding(4, 3, 4, 3)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Padding = New Padding(4, 3, 4, 3)
        GroupBox7.Size = New Size(288, 130)
        GroupBox7.TabIndex = 11
        GroupBox7.TabStop = False
        GroupBox7.Text = "AddOn"
        ' 
        ' Button9
        ' 
        Button9.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button9.ForeColor = Color.Black
        Button9.Location = New Point(8, 87)
        Button9.Margin = New Padding(4, 3, 4, 3)
        Button9.Name = "Button9"
        Button9.Size = New Size(273, 27)
        Button9.TabIndex = 9
        Button9.TabStop = False
        Button9.Text = "Avvia Keyboard Remapper"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = Color.Black
        Button7.Location = New Point(8, 21)
        Button7.Margin = New Padding(4, 3, 4, 3)
        Button7.Name = "Button7"
        Button7.Size = New Size(273, 27)
        Button7.TabIndex = 8
        Button7.TabStop = False
        Button7.Text = "Installa PureHD 1.40"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = Color.Black
        Button8.Location = New Point(8, 54)
        Button8.Margin = New Padding(4, 3, 4, 3)
        Button8.Name = "Button8"
        Button8.Size = New Size(273, 27)
        Button8.TabIndex = 7
        Button8.TabStop = False
        Button8.Text = "Download Patch Italiana"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(1105, 12)
        PictureBox3.Margin = New Padding(4, 3, 4, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(96, 96)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(127, 35)
        PictureBox2.Margin = New Padding(4, 3, 4, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(970, 71)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 12)
        PictureBox1.Margin = New Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(96, 96)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' GroupBox8
        ' 
        GroupBox8.Controls.Add(Button13)
        GroupBox8.Controls.Add(Button10)
        GroupBox8.Controls.Add(Button1)
        GroupBox8.Controls.Add(Button4)
        GroupBox8.Controls.Add(Button12)
        GroupBox8.Controls.Add(Button11)
        GroupBox8.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox8.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        GroupBox8.Location = New Point(913, 112)
        GroupBox8.Margin = New Padding(4, 3, 4, 3)
        GroupBox8.Name = "GroupBox8"
        GroupBox8.Padding = New Padding(4, 3, 4, 3)
        GroupBox8.Size = New Size(288, 226)
        GroupBox8.TabIndex = 11
        GroupBox8.TabStop = False
        GroupBox8.Text = "Community"
        ' 
        ' Button13
        ' 
        Button13.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button13.ForeColor = Color.Black
        Button13.Location = New Point(8, 153)
        Button13.Margin = New Padding(4, 3, 4, 3)
        Button13.Name = "Button13"
        Button13.Size = New Size(273, 27)
        Button13.TabIndex = 11
        Button13.TabStop = False
        Button13.Text = "News | Changelog | Annunci"
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button10.ForeColor = Color.Black
        Button10.Location = New Point(7, 186)
        Button10.Margin = New Padding(4, 3, 4, 3)
        Button10.Name = "Button10"
        Button10.Size = New Size(273, 27)
        Button10.TabIndex = 10
        Button10.TabStop = False
        Button10.Text = "Ringraziamenti Speciali | Special Thanks"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button12
        ' 
        Button12.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button12.ForeColor = Color.Black
        Button12.Location = New Point(8, 120)
        Button12.Margin = New Padding(4, 3, 4, 3)
        Button12.Name = "Button12"
        Button12.Size = New Size(273, 27)
        Button12.TabIndex = 9
        Button12.TabStop = False
        Button12.Text = "Screenshots dal Server"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button11.ForeColor = Color.Black
        Button11.Location = New Point(8, 87)
        Button11.Margin = New Padding(4, 3, 4, 3)
        Button11.Name = "Button11"
        Button11.Size = New Size(272, 27)
        Button11.TabIndex = 7
        Button11.TabStop = False
        Button11.Text = "Mappa Interattiva"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' SchermataPrincipale
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1214, 641)
        Controls.Add(GroupBox8)
        Controls.Add(GroupBox7)
        Controls.Add(GroupBox6)
        Controls.Add(Button6)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "SchermataPrincipale"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Shaddar-Nur | Sacred Online Community ITA | 1.2.1"
        GroupBox2.ResumeLayout(False)
        CType(WebView22, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        GroupBox6.ResumeLayout(False)
        GroupBox7.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox8.ResumeLayout(False)
        ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents WebBrowser2 As WebBrowser
    Friend WithEvents WebBrowser3 As WebBrowser
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BtnModifica As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents WebView22 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Button10 As Button
    Friend WithEvents Button13 As Button
End Class
