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
        GoBack = New PictureBox()
        GoNext = New PictureBox()
        GanttHeadersTablePanel = New TableLayoutPanel()
        ToolStrip1 = New ToolStrip()
        TaskAdd = New ToolStripButton()
        GanttReload = New ToolStripButton()
        GanttBodyTablePanel = New TableLayoutPanel()
        CType(GoBack, ComponentModel.ISupportInitialize).BeginInit()
        CType(GoNext, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GoBack
        ' 
        GoBack.Anchor = AnchorStyles.Top
        GoBack.Cursor = Cursors.Hand
        GoBack.Image = My.Resources.Resources.next__1_
        GoBack.Location = New Point(219, 25)
        GoBack.Name = "GoBack"
        GoBack.Size = New Size(49, 48)
        GoBack.SizeMode = PictureBoxSizeMode.CenterImage
        GoBack.TabIndex = 2
        GoBack.TabStop = False
        ' 
        ' GoNext
        ' 
        GoNext.Anchor = AnchorStyles.Top
        GoNext.Cursor = Cursors.Hand
        GoNext.Image = My.Resources.Resources._next
        GoNext.Location = New Point(274, 25)
        GoNext.Name = "GoNext"
        GoNext.Size = New Size(49, 48)
        GoNext.SizeMode = PictureBoxSizeMode.CenterImage
        GoNext.TabIndex = 3
        GoNext.TabStop = False
        ' 
        ' GanttHeadersTablePanel
        ' 
        GanttHeadersTablePanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GanttHeadersTablePanel.AutoScroll = True
        GanttHeadersTablePanel.BackColor = Color.SteelBlue
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
        ToolStrip1.Items.AddRange(New ToolStripItem() {TaskAdd, GanttReload})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(508, 25)
        ToolStrip1.TabIndex = 6
        ToolStrip1.Text = "ToolStrip1"' 
        ' TaskAdd
        ' 
        TaskAdd.DisplayStyle = ToolStripItemDisplayStyle.Image
        TaskAdd.Image = My.Resources.Resources.plus__1_
        TaskAdd.ImageTransparentColor = Color.Magenta
        TaskAdd.Name = "TaskAdd"
        TaskAdd.Size = New Size(23, 22)
        TaskAdd.Text = "Aggiungi Task"' 
        ' GanttReload
        ' 
        GanttReload.DisplayStyle = ToolStripItemDisplayStyle.Image
        GanttReload.Image = My.Resources.Resources.refresh
        GanttReload.ImageTransparentColor = Color.Magenta
        GanttReload.Name = "GanttReload"
        GanttReload.Size = New Size(23, 22)
        GanttReload.Text = "Ricarica Gantt"' 
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
        AutoScroll = True
        Controls.Add(GanttBodyTablePanel)
        Controls.Add(ToolStrip1)
        Controls.Add(GanttHeadersTablePanel)
        Controls.Add(GoNext)
        Controls.Add(GoBack)
        DoubleBuffered = True
        Name = "GanttDiagram"
        Size = New Size(508, 310)
        CType(GoBack, ComponentModel.ISupportInitialize).EndInit()
        CType(GoNext, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GanttHeadersTablePanel As TableLayoutPanel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents GanttBodyTablePanel As TableLayoutPanel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents GanttReload As ToolStripButton
    Friend WithEvents GoBack As PictureBox
    Friend WithEvents GoNext As PictureBox
    Friend WithEvents TaskAdd As ToolStripButton
End Class
