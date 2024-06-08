<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IntervalHeader
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
        head = New Label()
        body = New Label()
        SuspendLayout()
        ' 
        ' head
        ' 
        head.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        head.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        head.ForeColor = Color.SteelBlue
        head.Location = New Point(0, 0)
        head.Name = "head"
        head.Size = New Size(61, 26)
        head.TabIndex = 0
        head.Text = "Head"
        head.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' body
        ' 
        body.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        body.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        body.ForeColor = Color.SteelBlue
        body.Location = New Point(0, 26)
        body.Name = "body"
        body.Size = New Size(61, 21)
        body.TabIndex = 1
        body.Text = "Body"
        body.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' IntervalHeader
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(body)
        Controls.Add(head)
        Name = "IntervalHeader"
        Size = New Size(64, 51)
        ResumeLayout(False)
    End Sub

    Friend WithEvents head As Label
    Friend WithEvents body As Label
End Class
