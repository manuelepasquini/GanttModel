<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskInfo
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
        TableLayoutPanel1 = New TableLayoutPanel()
        TaskName = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        dePlan = New Label()
        dsPlan = New Label()
        PictureBox1 = New PictureBox()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Controls.Add(TaskName, 0, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 1, 0)
        TableLayoutPanel1.Controls.Add(PictureBox1, 2, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(475, 79)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TaskName
        ' 
        TaskName.AutoSize = True
        TaskName.Dock = DockStyle.Fill
        TaskName.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        TaskName.ForeColor = SystemColors.ControlDarkDark
        TaskName.Location = New Point(3, 0)
        TaskName.Name = "TaskName"
        TaskName.Size = New Size(231, 79)
        TaskName.TabIndex = 0
        TaskName.Text = "Label1"
        TaskName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(dePlan, 0, 1)
        TableLayoutPanel2.Controls.Add(dsPlan, 0, 0)
        TableLayoutPanel2.Location = New Point(240, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(184, 73)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' dePlan
        ' 
        dePlan.AutoSize = True
        dePlan.Dock = DockStyle.Fill
        dePlan.Location = New Point(3, 36)
        dePlan.Name = "dePlan"
        dePlan.Size = New Size(178, 37)
        dePlan.TabIndex = 2
        dePlan.Text = "Label3"
        dePlan.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dsPlan
        ' 
        dsPlan.AutoSize = True
        dsPlan.Dock = DockStyle.Fill
        dsPlan.Location = New Point(3, 0)
        dsPlan.Name = "dsPlan"
        dsPlan.Size = New Size(178, 36)
        dsPlan.TabIndex = 1
        dsPlan.Text = "Label2"
        dsPlan.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.info
        PictureBox1.Location = New Point(430, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(42, 73)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' TaskInfo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "TaskInfo"
        Size = New Size(475, 79)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TaskName As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dePlan As Label
    Friend WithEvents dsPlan As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
