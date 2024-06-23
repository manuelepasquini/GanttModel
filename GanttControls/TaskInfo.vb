Public Class TaskInfo
    Public Property Task As TaskGantt

    Public Sub New(task As TaskGantt)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        Me.Task = task
        Me.TaskName.Text = task.Name
        Me.dsPlan.Text = "Inizio: " + task.DateStartPlanned.ToShortDateString + " " + task.DateStartPlanned.ToShortTimeString
        Me.dePlan.Text = "Fine: " + task.DateEndPlanned.ToShortDateString + " " + task.DateEndPlanned.ToShortTimeString

        AddHandler PictureBox1.Click, AddressOf OpenMore
    End Sub

    Private Sub OpenMore()
        'MsgBox("Open task's detail")
        Dim form As New Container() With {
            .Text = "Dettaglio form",
            .Dock = DockStyle.Fill
        }
        Dim info As New TaskData(Me.Task) With {
            .Size = New Size(form.Width, form.Height)
        }
        form.Controls.Add(info)

        form.ShowDialog()
    End Sub
End Class
