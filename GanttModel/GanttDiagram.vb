Public Class GanttDiagram
    Property Data As Date

    Private Sub SetGanttHeadersGraphics()
        Dim pTaskHeaders As Panel = TaskHeadersPanel
        Dim pGanttHeaders As Panel = GanttHeadersPanel

        Dim GanttIntervalCount As Integer = 7
        Dim pGanttHeadersWidth As Double = pGanttHeaders.Width
        Dim GanttIntervalWidth As Double = pGanttHeadersWidth \ GanttIntervalCount

        Dim locationHeaderInterval As New Point(0, 0)
        Data = Now.Date

        For i = 1 To GanttIntervalCount
            pGanttHeaders.Controls.Add(New IntervalHeader(Data.DayOfWeek.ToString.Substring(0, 3), Data.Day.ToString) With {
                .Size = New Size(GanttIntervalWidth, pGanttHeaders.Height),
                .Location = locationHeaderInterval
            })

            Data = DateAdd(DateInterval.Day, 1, Data)           'Increment Date
            locationHeaderInterval.X += GanttIntervalWidth      'Increment location
        Next

    End Sub

    Private Sub GanttDiagram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetGanttHeadersGraphics()
    End Sub
End Class
