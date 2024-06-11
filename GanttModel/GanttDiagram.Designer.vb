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
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        GanttHeadersTablePanel = New TableLayoutPanel()
        ToolStrip1 = New ToolStrip()
        GanttBodyTablePanel = New TableLayoutPanel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(73), CByte(103), CByte(190))
        Label1.Location = New Point(220, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 48)
        Label1.TabIndex = 1
        Label1.Text = "Giugno 2024"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources.next__1_
        PictureBox1.Location = New Point(402, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(49, 48)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = My.Resources.Resources._next
        PictureBox2.Location = New Point(457, 28)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(49, 48)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' GanttHeadersTablePanel
        ' 
        GanttHeadersTablePanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GanttHeadersTablePanel.AutoScroll = True
        GanttHeadersTablePanel.BackColor = Color.AliceBlue
        GanttHeadersTablePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        GanttHeadersTablePanel.ColumnCount = 1
        GanttHeadersTablePanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        GanttHeadersTablePanel.Location = New Point(3, 79)
        GanttHeadersTablePanel.Name = "GanttHeadersTablePanel"
        GanttHeadersTablePanel.RowCount = 1
        GanttHeadersTablePanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        GanttHeadersTablePanel.Size = New Size(503, 43)
        GanttHeadersTablePanel.TabIndex = 5
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(508, 25)
        ToolStrip1.TabIndex = 6
        ToolStrip1.Text = "ToolStrip1"' 
        ' GanttBodyTablePanel
        ' 
        GanttBodyTablePanel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GanttBodyTablePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        GanttBodyTablePanel.ColumnCount = 2
        GanttBodyTablePanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 23.07692F))
        GanttBodyTablePanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 76.92308F))
        GanttBodyTablePanel.Location = New Point(3, 128)
        GanttBodyTablePanel.Name = "GanttBodyTablePanel"
        GanttBodyTablePanel.RowCount = 1
        GanttBodyTablePanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        GanttBodyTablePanel.Size = New Size(503, 179)
        GanttBodyTablePanel.TabIndex = 7
        ' 
        ' GanttDiagram
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(GanttBodyTablePanel)
        Controls.Add(ToolStrip1)
        Controls.Add(GanttHeadersTablePanel)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "GanttDiagram"
        Size = New Size(508, 310)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GanttHeadersTablePanel As TableLayoutPanel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents GanttBodyTablePanel As TableLayoutPanel
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
