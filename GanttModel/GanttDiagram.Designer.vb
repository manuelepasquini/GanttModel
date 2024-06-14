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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(GanttDiagram))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        GanttHeadersTablePanel = New TableLayoutPanel()
        ToolStrip1 = New ToolStrip()
        ToolStripButton1 = New ToolStripButton()
        GanttBodyTablePanel = New TableLayoutPanel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources.next__1_
        PictureBox1.Location = New Point(219, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(49, 48)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = My.Resources.Resources._next
        PictureBox2.Location = New Point(274, 25)
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
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton1})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(508, 25)
        ToolStrip1.TabIndex = 6
        ToolStrip1.Text = "ToolStrip1"' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(23, 22)
        ToolStripButton1.Text = "ToolStripButton1"' 
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
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "GanttDiagram"
        Size = New Size(508, 310)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
