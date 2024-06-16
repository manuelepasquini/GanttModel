Public Class GanttDiagram
    Property Data As Date
    Property GanttIntervalCount As Integer = 7

    Private ColumnsColor As New List(Of Integer)

    Public Sub New()

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        AddHandler Me.GanttHeadersTablePanel.CellPaint, AddressOf GanttHeadersTablePanel_CellPaint
        AddHandler Me.GoNext.Click, AddressOf PictureBox2_Click
        AddHandler Me.GoBack.Click, AddressOf PictureBox1_Click
        AddHandler Me.Resize, AddressOf GanttDiagram_Resize

        Data = Now.Date
        PerformGantt()
    End Sub

    Private Sub PerformGantt()
        Dim tasks As New List(Of TaskGantt) From {
            New TaskGantt() With {
                .Name = "Task 1",
                .DateStartPlanned = New Date(2024, 6, 15),
                .DateEndPlanned = New Date(2024, 6, 23, 0, 0, 0),
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
                .Name = "Task 9",
                .DateStartPlanned = New Date(2024, 6, 16),
                .DateEndPlanned = New Date(2024, 6, 16, 18, 0, 0),
                .Color = Color.Red
            },
            New TaskGantt() With {
                .Name = "task 10",
                .DateStartPlanned = New Date(2024, 6, 16, 12, 0, 0),
                .DateEndPlanned = New Date(2024, 6, 17)
            },
            New TaskGantt() With {
                .Name = "Task 11",
                .DateStartPlanned = New Date(2024, 6, 17),
                .DateEndPlanned = New Date(2024, 6, 18)
            },
            New TaskGantt() With {
                .Name = "task 12",
                .DateStartPlanned = New Date(2024, 6, 11),
                .DateEndPlanned = New Date(2024, 6, 14),
                .Color = Color.CadetBlue
            },
            New TaskGantt() With {
                .Name = "Task 13",
                .DateStartPlanned = New Date(2024, 6, 11),
                .DateEndPlanned = New Date(2024, 6, 14)
            },
            New TaskGantt() With {
                .Name = "task 14",
                .DateStartPlanned = New Date(2024, 6, 13),
                .DateEndPlanned = New Date(2024, 6, 19)
            },
            New TaskGantt() With {
                .Name = "Task 15",
                .DateStartPlanned = New Date(2024, 6, 11),
                .DateEndPlanned = New Date(2024, 6, 16)
            },
            New TaskGantt() With {
                .Name = "task 16",
                .DateStartPlanned = New Date(2024, 6, 11),
                .DateEndPlanned = New Date(2024, 6, 14)
            }
        }

        SetGanttHeadersGraphics(Data)
        SetGanttTasksGraphic(tasks)
    End Sub

    Private Sub SetGanttHeadersGraphics(ByVal startDate As Date)
        Dim pGanttHeadersTable As TableLayoutPanel = GanttHeadersTablePanel
        Dim locationHeaderInterval As New Point(0, 0)
        ColumnsColor.Clear()

        'Setting date
        Data = startDate
        'DateCurrent = Data

        pGanttHeadersTable.Controls.Clear()
        pGanttHeadersTable.ColumnStyles.Clear()

        pGanttHeadersTable.ColumnCount = GanttIntervalCount + 1
        pGanttHeadersTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30))
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

        Data = startDate
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
                .Dock = DockStyle.Left,
                .Text = task.Name,
                .ForeColor = Color.SlateGray,
                .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                .TextAlign = ContentAlignment.MiddleLeft
            }

            'Dim taskInfo As Panel = GetTaskInfoPanel(task, 50)

            Dim taskProgress As New TaskProgress(task, Data, DateAdd(DateInterval.Day, GanttIntervalCount, Data)) With {
                    .Dock = DockStyle.Fill
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

    'Private Sub GanttDiagram_Load(sender As Object, e As EventArgs)
    '    Data = Now.Date
    '    PerformGantt()
    'End Sub

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

    Private Function GetTaskInfoPanel(task As TaskGantt, width As Integer) As Panel
        Dim infoPanel As New Panel

        'Dichiarazione eelementi da mettere all'interno del panel
        Dim taskName As New Label() With {
            .Dock = DockStyle.Left,
            .Text = task.Name,
            .ForeColor = Color.SlateGray,
            .Font = New Font("Segoe UI", 12, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleLeft,
            .Size = New Size(width * 5, 10)
        }

        Dim btnInfo As New Button() With {
            .Dock = DockStyle.Left
        }

        infoPanel.Controls.Add(btnInfo)
        infoPanel.Controls.Add(taskName)


        Return infoPanel
    End Function
End Class
