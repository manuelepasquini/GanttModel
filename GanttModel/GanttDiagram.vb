Public Class GanttDiagram
    Property Data As Date

    Private Sub SetGanttHeadersGraphics()
        Dim pTaskHeaders As Panel = TaskHeadersPanel
        Dim pGanttHeadersTable As TableLayoutPanel = GanttHeadersTablePanel

        Dim GanttIntervalCount As Integer = 7

        Dim locationHeaderInterval As New Point(0, 0)
        Data = Now.Date

        pGanttHeadersTable.ColumnStyles.Clear()
        pGanttHeadersTable.ColumnCount = GanttIntervalCount
        pGanttHeadersTable.RowCount = 1

        For i = 1 To GanttIntervalCount
            pGanttHeadersTable.ColumnStyles.Add(New ColumnStyle() With {
                .SizeType = SizeType.Percent,
                .Width = 100 / GanttIntervalCount
            })

            pGanttHeadersTable.Controls.Add(New IntervalHeader(Data.DayOfWeek.ToString.Substring(0, 3), Data.Day.ToString) With {
                .Dock = DockStyle.Fill
            }, i - 1, 0)

            Data = DateAdd(DateInterval.Day, 1, Data)           'Increment Date
        Next
    End Sub

    Private Sub GanttDiagram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetGanttHeadersGraphics()
    End Sub

End Class
