<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KeyboardRemapper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KeyboardRemapper))
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        txtkey6 = New TextBox()
        txtKey7 = New TextBox()
        txtKey8 = New TextBox()
        txtKey9 = New TextBox()
        txtKey0 = New TextBox()
        TextBox1 = New TextBox()
        btnAttiva = New Button()
        btnDisattiva = New Button()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(12, 12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(468, 70)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(12, 88)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(468, 81)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' txtkey6
        ' 
        txtkey6.BackColor = Color.Black
        txtkey6.BorderStyle = BorderStyle.None
        txtkey6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtkey6.ForeColor = Color.White
        txtkey6.Location = New Point(27, 99)
        txtkey6.MaxLength = 1
        txtkey6.Name = "txtkey6"
        txtkey6.Size = New Size(16, 15)
        txtkey6.TabIndex = 2
        txtkey6.TabStop = False
        txtkey6.Text = "6"
        ' 
        ' txtKey7
        ' 
        txtKey7.BackColor = Color.Black
        txtKey7.BorderStyle = BorderStyle.None
        txtKey7.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtKey7.ForeColor = Color.White
        txtKey7.Location = New Point(122, 99)
        txtKey7.MaxLength = 1
        txtKey7.Name = "txtKey7"
        txtKey7.Size = New Size(16, 15)
        txtKey7.TabIndex = 3
        txtKey7.TabStop = False
        txtKey7.Text = "7"
        ' 
        ' txtKey8
        ' 
        txtKey8.BackColor = Color.Black
        txtKey8.BorderStyle = BorderStyle.None
        txtKey8.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtKey8.ForeColor = Color.White
        txtKey8.Location = New Point(217, 99)
        txtKey8.MaxLength = 1
        txtKey8.Name = "txtKey8"
        txtKey8.Size = New Size(16, 15)
        txtKey8.TabIndex = 4
        txtKey8.TabStop = False
        txtKey8.Text = "8"
        ' 
        ' txtKey9
        ' 
        txtKey9.BackColor = Color.Black
        txtKey9.BorderStyle = BorderStyle.None
        txtKey9.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtKey9.ForeColor = Color.White
        txtKey9.Location = New Point(310, 99)
        txtKey9.MaxLength = 1
        txtKey9.Name = "txtKey9"
        txtKey9.Size = New Size(16, 15)
        txtKey9.TabIndex = 5
        txtKey9.TabStop = False
        txtKey9.Text = "9"
        ' 
        ' txtKey0
        ' 
        txtKey0.BackColor = Color.Black
        txtKey0.BorderStyle = BorderStyle.None
        txtKey0.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtKey0.ForeColor = Color.White
        txtKey0.Location = New Point(405, 99)
        txtKey0.MaxLength = 1
        txtKey0.Name = "txtKey0"
        txtKey0.Size = New Size(16, 15)
        txtKey0.TabIndex = 6
        txtKey0.TabStop = False
        txtKey0.Text = "0"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 230)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(468, 23)
        TextBox1.TabIndex = 7
        ' 
        ' btnAttiva
        ' 
        btnAttiva.Location = New Point(12, 172)
        btnAttiva.Name = "btnAttiva"
        btnAttiva.Size = New Size(75, 23)
        btnAttiva.TabIndex = 8
        btnAttiva.Text = "Button1"
        btnAttiva.UseVisualStyleBackColor = True
        ' 
        ' btnDisattiva
        ' 
        btnDisattiva.Location = New Point(12, 201)
        btnDisattiva.Name = "btnDisattiva"
        btnDisattiva.Size = New Size(75, 23)
        btnDisattiva.TabIndex = 9
        btnDisattiva.Text = "Button2"
        btnDisattiva.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        BackColor = Color.Black
        ClientSize = New Size(492, 336)
        Controls.Add(btnDisattiva)
        Controls.Add(btnAttiva)
        Controls.Add(TextBox1)
        Controls.Add(txtKey0)
        Controls.Add(txtKey9)
        Controls.Add(txtKey8)
        Controls.Add(txtKey7)
        Controls.Add(txtkey6)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "Form2"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Keyboard Remapper 1.1"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtKey1 As TextBox
    Friend WithEvents txtKey2 As TextBox
    Friend WithEvents txtKey3 As TextBox
    Friend WithEvents txtKey4 As TextBox
    Friend WithEvents txtKey5 As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtkey6 As TextBox
    Friend WithEvents txtKey7 As TextBox
    Friend WithEvents txtKey8 As TextBox
    Friend WithEvents txtKey9 As TextBox
    Friend WithEvents txtKey0 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnAttiva As Button
    Friend WithEvents btnDisattiva As Button
End Class
