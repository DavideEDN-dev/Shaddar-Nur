<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScegliRisoluzione
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ComboBox1 = New ComboBox()
        ButtonApply = New Button()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(15, 15)
        ComboBox1.Margin = New Padding(4, 3, 4, 3)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(284, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' ButtonApply
        ' 
        ButtonApply.Location = New Point(307, 15)
        ButtonApply.Margin = New Padding(4, 3, 4, 3)
        ButtonApply.Name = "ButtonApply"
        ButtonApply.Size = New Size(88, 24)
        ButtonApply.TabIndex = 1
        ButtonApply.Text = "Avvia Gioco"
        ButtonApply.UseVisualStyleBackColor = True
        ' 
        ' ScegliRisoluzione
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(408, 53)
        Controls.Add(ButtonApply)
        Controls.Add(ComboBox1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(4, 3, 4, 3)
        Name = "ScegliRisoluzione"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Shaddar Nur | Applica Risoluzione"
        ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ButtonApply As Button
End Class
