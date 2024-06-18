<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskData
    Inherits System.Windows.Forms.UserControl

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
        Label1 = New Label()
        InizioPianificato = New DateTimePicker()
        FinePianificata = New DateTimePicker()
        Nome = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.SteelBlue
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(323, 45)
        Label1.TabIndex = 0
        Label1.Text = "informazioni Task"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' InizioPianificato
        ' 
        InizioPianificato.CustomFormat = "dd/MM/yyyy HH:mm"
        InizioPianificato.Format = DateTimePickerFormat.Custom
        InizioPianificato.Location = New Point(67, 96)
        InizioPianificato.Name = "InizioPianificato"
        InizioPianificato.Size = New Size(221, 23)
        InizioPianificato.TabIndex = 2
        ' 
        ' FinePianificata
        ' 
        FinePianificata.CustomFormat = "dd/MM/yyyy hh:mm"
        FinePianificata.Format = DateTimePickerFormat.Custom
        FinePianificata.Location = New Point(67, 125)
        FinePianificata.Name = "FinePianificata"
        FinePianificata.Size = New Size(221, 23)
        FinePianificata.TabIndex = 3
        ' 
        ' Nome
        ' 
        Nome.Location = New Point(67, 51)
        Nome.Multiline = True
        Nome.Name = "Nome"
        Nome.Size = New Size(221, 39)
        Nome.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 15)
        Label2.TabIndex = 5
        Label2.Text = "Nome"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 6
        Label3.Text = "Inizio"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(29, 15)
        Label4.TabIndex = 7
        Label4.Text = "Fine"' 
        ' Button1
        ' 
        Button1.Location = New Point(117, 182)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 8
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TaskData
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Nome)
        Controls.Add(FinePianificata)
        Controls.Add(InizioPianificato)
        Controls.Add(Label1)
        Name = "TaskData"
        Size = New Size(323, 265)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents InizioPianificato As DateTimePicker
    Friend WithEvents FinePianificata As DateTimePicker
    Friend WithEvents Nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
