Public Class GanttDiagram
    Property Data As Date
    Property DateCurrent As Date
    Property GanttIntervalCount As Integer = 7

    Private ColumnsColor As New List(Of Integer)

    Private Sub PerformGantt()
        Dim tasks As New List(Of TaskGantt) From {
        New TaskGantt() With {
            .Name = "Task 1",
            .DateStartPlanned = New Date(2024, 6, 16),
            .DateEndPlanned = New Date(2024, 6, 16, 18, 0, 0),
            .Color = Color.Red
        },
        New TaskGantt() With {
            .Name = "task 2",
            .DateStartPlanned = New Date(2024, 6, 16, 12, 0, 0),
            .DateEndPlanned = New Date(2024, 6, 17)
        },
        New TaskGantt() With {
            .Name = "Task 3",
            .DateStartPlanned = New Date(2024, 6, 17),
            .DateEndPlanned = New Date(2024, 6, 18)
        },
        New TaskGantt() With {
            .Name = "task 4",
            .DateStartPlanned = New Date(2024, 6, 11),
            .DateEndPlanned = New Date(2024, 6, 14),
            .Color = Color.CadetBlue
        },
        New TaskGantt() With {
            .Name = "Task 5",
            .DateStartPlanned = New Date(2024, 6, 11),
            .DateEndPlanned = New Date(2024, 6, 14)
        },
        New TaskGantt() With {
            .Name = "task 6",
            .DateStartPlanned = New Date(2024, 6, 13),
            .DateEndPlanned = New Date(2024, 6, 19)
        },
        New TaskGantt() With {
            .Name = "Task 7",
            .DateStartPlanned = New Date(2024, 6, 11),
            .DateEndPlanned = New Date(2024, 6, 16)
        },
        New TaskGantt() With {
            .Name = "task 8",
            .DateStartPlanned = New Date(2024, 6, 11),
            .DateEndPlanned = New Date(2024, 6, 14)
        },
                        New TaskGantt() With {
            .Name = "Task 1",
            .DateStartPlanned = New Date(2024, 6, 16),
            .DateEndPlanned = New Date(2024, 6, 16, 18, 0, 0),
            .Color = Color.Red
        },
        New TaskGantt() With {
            .Name = "task 2",
            .DateStartPlanned = New Date(2024, 6, 16, 12, 0, 0),
            .DateEndPlanned = New Date(2024, 6, 17)
        },
        New TaskGantt() With {
            .Name = "Task 3",
            .DateStartPlanned = New Date(2024, 6, 17),
            .DateEndPlanned = New Date(2024, 6, 18)
        },
        New TaskGantt() With {
            .Name = "task 4",
            .DateStartPlanned = New Date(2024, 6, 11),
            .DateEndPlanned = New Date(2024, 6, 14),
            .Color = Color.CadetBlue
        },
        New TaskGantt() With {
            .Name = "Task 5",
            .DateStartPlanned = New Date(2024, 6, 11),
            .DateEndPlanned = New Date(2024, 6, 14)
        },
        New TaskGantt() With {
            .Name = "task 6",
            .DateStartPlanned = New Date(2024, 6, 13),
            .DateEndPlanned = New Date(2024, 6, 19)
        },
        New TaskGantt() With {
            .Name = "Task 7",
            .DateStartPlanned = New Date(2024, 6, 11),
            .DateEndPlanned = New Date(2024, 6, 16)
        },
        New TaskGantt() With {
            .Name = "task 8",
            .DateStartPlanned = New Date(2024, 6, 11),
            .DateEndPlanned = New Date(2024, 6, 14)
        }
}

        SetGanttHeadersGraphics(Data)
        SetGanttTasksGraphic(tasks)
    End Sub

    Private Sub SetGanttHeadersGraphics(startDate As Date)
        Dim pGanttHeadersTable As TableLayoutPanel = GanttHeadersTablePanel
        Dim locationHeaderInterval As New Point(0, 0)
        ColumnsColor.Clear()

        'Setting date
        Data = startDate
        DateCurrent = startDate

        pGanttHeadersTable.Controls.Clear()
        pGanttHeadersTable.ColumnStyles.Clear()

        'pGanttHeadersTable.ColumnStyles.Clear()
        pGanttHeadersTable.ColumnCount = GanttIntervalCount + 1
        pGanttHeadersTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30))
        'pGanttHeadersTable.ColumnStyles(0) = New ColumnStyle(SizeType.Percent, 30)
        pGanttHeadersTable.RowCount = 1

        pGanttHeadersTable.Controls.Add(New Label() With {
            .Dock = DockStyle.Fill,
            .Text = "Tasks list",
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 12, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleCenter
        }, 0, 0)

        For i = 1 To GanttIntervalCount
            pGanttHeadersTable.ColumnStyles.Add(New ColumnStyle() With {
                .SizeType = SizeType.Percent,
                .Width = 100 / GanttIntervalCount
            })

            If Data.DayOfWeek = DayOfWeek.Saturday OrElse Data.DayOfWeek = DayOfWeek.Sunday Then
                ColumnsColor.Add(i)
                pGanttHeadersTable.Controls.Add(New IntervalHeader(Data.DayOfWeek.ToString.Substring(0, 3), Data.Day.ToString) With {
                    .Dock = DockStyle.Fill,
                    .BackColor = Color.Gray
                }, i, 0)
            Else
                pGanttHeadersTable.Controls.Add(New IntervalHeader(Data.DayOfWeek.ToString.Substring(0, 3), Data.Day.ToString) With {
                    .Dock = DockStyle.Fill,
                    .BackColor = Color.SteelBlue
                }, i, 0)
            End If

            Data = DateAdd(DateInterval.Day, 1, Data)           'Increment Date
        Next
        Data = DateCurrent
    End Sub

    Private Sub SetGanttTasksGraphic(tasks As List(Of TaskGantt))
        Dim ganttBody As TableLayoutPanel = GanttBodyTablePanel
        Dim i As Integer = 0

        ganttBody.RowStyles.Clear()
        ganttBody.Controls.Clear()
        ganttBody.RowCount = 0

        For Each task As TaskGantt In tasks
            ganttBody.RowStyles.Add(New RowStyle() With {
                .SizeType = SizeType.Absolute,
                .Height = 25
            })

            Dim lblTask As New Label() With {
                .Dock = DockStyle.Fill,
                .Text = task.Name,
                .ForeColor = Color.SlateGray,
                .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                .TextAlign = ContentAlignment.MiddleCenter
            }

            Dim taskProgress As New TaskProgress(task, DateCurrent, DateAdd(DateInterval.Day, GanttIntervalCount, DateCurrent)) With {
                    .Dock = DockStyle.Fill,
                    .Margin = New Padding(0, 0, 0, 0),
                    .Padding = New Padding(0, 0, 0, 0)
                }


            ganttBody.Controls.Add(lblTask, 0, i)
            ganttBody.Controls.Add(taskProgress, 1, i)
            taskProgress.DrawProgress()

            i += 1
        Next

        'Add a virutal last line to disabling resize of last row
        ganttBody.RowStyles.Add(New RowStyle() With {
            .SizeType = SizeType.Absolute,
            .Height = 20
        })
        ganttBody.Controls.Add(New Label(), 0, i)

    End Sub

    Private Sub GanttDiagram_Load(sender As Object, e As EventArgs)
        Data = Now.Date
        PerformGantt()
    End Sub

    Private Sub GanttDiagram_Resize(sender As Object, e As EventArgs)
        For Each control In GanttBodyTablePanel.Controls
            If TypeOf control Is TaskProgress Then
                CType(control, TaskProgress).DrawProgress()
            End If
        Next
    End Sub

    'Backgound grigio nei dabati e domeniche più altri colori per giorni
    Private Sub GanttHeadersTablePanel_CellPaint(sender As Object, e As TableLayoutCellPaintEventArgs)
        Me.SuspendLayout()

        If ColumnsColor.Contains(e.Column) Then
            e.Graphics.FillRectangle(Brushes.Gray, e.CellBounds)
        Else
            e.Graphics.FillRectangle(Brushes.SteelBlue, e.CellBounds)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        SetGanttHeadersGraphics(DateAdd(DateInterval.Day, -1, Data))
        For Each control In GanttBodyTablePanel.Controls
            If TypeOf control Is TaskProgress Then
                CType(control, TaskProgress).MoveProgression(1)
            End If
        Next
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        SetGanttHeadersGraphics(DateAdd(DateInterval.Day, 1, Data))
        For Each control In GanttBodyTablePanel.Controls
            If TypeOf control Is TaskProgress Then
                CType(control, TaskProgress).MoveProgression(2)
            End If
        Next
    End Sub
End Class
