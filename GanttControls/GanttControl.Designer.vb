<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GanttControl
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
        Header = New TableLayoutPanel()
        Body = New TableLayoutPanel()
        GoNext = New PictureBox()
        GoBack = New PictureBox()
        CType(GoNext, ComponentModel.ISupportInitialize).BeginInit()
        CType(GoBack, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Header
        ' 
        Header.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Header.ColumnCount = 1
        Header.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        Header.Location = New Point(3, 50)
        Header.Name = "Header"
        Header.RowCount = 1
        Header.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        Header.Size = New Size(663, 75)
        Header.TabIndex = 0
        ' 
        ' Body
        ' 
        Body.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Body.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        Body.ColumnCount = 1
        Body.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        Body.Location = New Point(3, 131)
        Body.Name = "Body"
        Body.RowCount = 1
        Body.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        Body.Size = New Size(663, 232)
        Body.TabIndex = 1
        ' 
        ' GoNext
        ' 
        GoNext.Anchor = AnchorStyles.Top
        GoNext.Cursor = Cursors.Hand
        GoNext.Image = My.Resources.Resources._next
        GoNext.Location = New Point(346, 7)
        GoNext.Name = "GoNext"
        GoNext.Size = New Size(41, 37)
        GoNext.SizeMode = PictureBoxSizeMode.CenterImage
        GoNext.TabIndex = 5
        GoNext.TabStop = False
        ' 
        ' GoBack
        ' 
        GoBack.Anchor = AnchorStyles.Top
        GoBack.Cursor = Cursors.Hand
        GoBack.Image = My.Resources.Resources.next__1_
        GoBack.Location = New Point(289, 7)
        GoBack.Name = "GoBack"
        GoBack.Size = New Size(39, 37)
        GoBack.SizeMode = PictureBoxSizeMode.CenterImage
        GoBack.TabIndex = 4
        GoBack.TabStop = False
        ' 
        ' GanttControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(GoBack)
        Controls.Add(GoNext)
        Controls.Add(Body)
        Controls.Add(Header)
        Name = "GanttControl"
        Size = New Size(669, 366)
        CType(GoNext, ComponentModel.ISupportInitialize).EndInit()
        CType(GoBack, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Header As TableLayoutPanel
    Friend WithEvents Body As TableLayoutPanel
    Friend WithEvents GoNext As PictureBox
    Friend WithEvents GoBack As PictureBox
End Class
