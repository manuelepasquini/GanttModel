<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GanttDiagram
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
        GanttHeadersPanel = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        ComboBox1 = New ComboBox()
        TaskHeadersPanel = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GanttHeadersPanel
        ' 
        GanttHeadersPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GanttHeadersPanel.BackColor = SystemColors.ActiveCaption
        GanttHeadersPanel.Location = New Point(309, 32)
        GanttHeadersPanel.Name = "GanttHeadersPanel"
        GanttHeadersPanel.Size = New Size(196, 57)
        GanttHeadersPanel.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(73), CByte(103), CByte(190))
        Label1.Location = New Point(261, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 23)
        Label1.TabIndex = 1
        Label1.Text = "Giugno 2024"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox1.Image = My.Resources.Resources.next__1_
        PictureBox1.Location = New Point(443, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(28, 28)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox2.Image = My.Resources.Resources._next
        PictureBox2.Location = New Point(477, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(28, 28)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Giorno", "Settimana", "Mese"})
        ComboBox1.Location = New Point(3, 3)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 4
        ' 
        ' TaskHeadersPanel
        ' 
        TaskHeadersPanel.BackColor = Color.SteelBlue
        TaskHeadersPanel.Location = New Point(3, 32)
        TaskHeadersPanel.Name = "TaskHeadersPanel"
        TaskHeadersPanel.Size = New Size(300, 57)
        TaskHeadersPanel.TabIndex = 1
        ' 
        ' GanttDiagram
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TaskHeadersPanel)
        Controls.Add(ComboBox1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(GanttHeadersPanel)
        Name = "GanttDiagram"
        Size = New Size(508, 310)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GanttHeadersPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TaskHeadersPanel As Panel
End Class
