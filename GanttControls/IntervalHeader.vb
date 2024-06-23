Public Class IntervalHeader
    Public Data As Date
    Public Sub New(header As String, body As String)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        Me.head.Text = header
        Me.body.Text = body
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
End Class
