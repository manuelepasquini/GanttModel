Public Class Main
    Public Sub New()

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        gantt.Tasks = New List(Of TaskGantt) From {
            New TaskGantt() With {.Name = "Task 1", .DateStartPlanned = New Date(2024, 6, 25, 12, 0, 0), .DateEndPlanned = New Date(2024, 6, 26, 0, 0, 0), .Color = Color.Green},
            New TaskGantt() With {.Name = "Task 2", .DateStartPlanned = New Date(2024, 6, 24), .DateEndPlanned = New Date(2024, 6, 30, 3, 0, 0), .Color = Color.Orange},
            New TaskGantt() With {.Name = "Task 2", .DateStartPlanned = New Date(2024, 6, 24), .DateEndPlanned = New Date(2024, 6, 26, 6, 0, 0), .Color = Color.Orange}
        }
        gantt.Data = Now.Date
        gantt.IntervalCount = 7
        gantt.DrawHeader()
        gantt.SetBodyData()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        gantt.Tasks.Add(New TaskGantt() With {
            .Name = "Task aggiunta",
            .DateStartPlanned = New Date(2024, 7, 1),
            .DateEndPlanned = New Date(2024, 7, 2)
        })
        gantt.IntervalCount = 14
        gantt.DrawHeader()
        gantt.SetBodyData()
    End Sub
End Class