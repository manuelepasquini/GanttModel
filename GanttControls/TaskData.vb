Public Class TaskData
    Public Property task As TaskGantt
    Private bs As New BindingSource

    Public Sub New()
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
    End Sub

    Public Sub New(task As TaskGantt)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        Me.task = task
        Me.Nome.Text = task.Name
        Me.InizioPianificato.Value = task.DateStartPlanned
        Me.FinePianificata.Value = task.DateEndPlanned

        'Set the datasource
        bs.DataSource = task

        'Set the binding on control
        Nome.DataBindings.Add("Text", bs, "Name", False, DataSourceUpdateMode.OnPropertyChanged)
        InizioPianificato.DataBindings.Add("Value", bs, "DateStartPlanned", False, DataSourceUpdateMode.OnPropertyChanged)
        FinePianificata.DataBindings.Add("Value", bs, "DateEndPlanned", False, DataSourceUpdateMode.OnPropertyChanged)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(task.DateStartPlanned)
    End Sub
End Class
