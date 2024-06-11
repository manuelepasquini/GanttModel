<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskProgress
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
        ProgressTabelLayout = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProgressTabelLayout
        ' 
        ProgressTabelLayout.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ProgressTabelLayout.AutoScroll = True
        ProgressTabelLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        ProgressTabelLayout.ColumnCount = 1
        ProgressTabelLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        ProgressTabelLayout.Location = New Point(3, 25)
        ProgressTabelLayout.Name = "ProgressTabelLayout"
        ProgressTabelLayout.RowCount = 1
        ProgressTabelLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        ProgressTabelLayout.Size = New Size(310, 1)
        ProgressTabelLayout.TabIndex = 0
        ProgressTabelLayout.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ActiveCaption
        PictureBox1.Location = New Point(3, 5)
        PictureBox1.Margin = New Padding(0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(26, 17)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' TaskProgress
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(PictureBox1)
        Controls.Add(ProgressTabelLayout)
        Name = "TaskProgress"
        Size = New Size(316, 29)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ProgressTabelLayout As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
End Class
