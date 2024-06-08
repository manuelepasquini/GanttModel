Public Class IntervalHeader
    Public Sub New(header As String, body As String)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        Me.head.Text = header
        Me.body.Text = body
    End Sub
End Class
