Public Class GanttDiagram
    Property Data As Date                           'Main Date used by gantt diagram. Starting date of gantt headers                        
    Property GanttIntervalCount As Integer = 30      'Day viewed in gantt diagram

    Dim tasks As New List(Of TaskGantt) From {
            New TaskGantt() With {
                .Name = "Task 1",
                .DateStartPlanned = New Date(2024, 6, 18, 6, 0, 0),
                .DateEndPlanned = New Date(2024, 6, 20, 12, 0, 0),
                .Color = Color.Green
            }
        }          'List of task managed by Gantt diagram
    Private ColumnsColor As New List(Of Integer)    'rapresent the holiday date, color gantt headers

    Public Sub New()
        InitializeComponent()

        'Adding handler
        AddHandler Me.GanttHeadersTablePanel.CellPaint, AddressOf GanttHeadersTablePanel_CellPaint
        AddHandler Me.GoNext.Click, AddressOf PictureBox2_Click
        AddHandler Me.GoBack.Click, AddressOf PictureBox1_Click
        AddHandler Me.Resize, AddressOf GanttDiagram_Resize

        'Set starting date and perform gantt
        Data = Now.Date
        PerformGantt()
    End Sub

    ''' <summary>
    ''' Call function to show tasks in gantt diagram 
    ''' </summary>
    Private Sub PerformGantt()
        SetGanttHeadersGraphics(Data)
        SetGanttTasksGraphic(tasks)
    End Sub

    ''' <summary>
    ''' Configure table layout header with days
    ''' </summary>
    ''' <param name="startDate"></param>
    Private Sub SetGanttHeadersGraphics(ByVal startDate As Date)
        Dim pGanttHeadersTable As TableLayoutPanel = GanttHeadersTablePanel
        Dim locationHeaderInterval As New Point(0, 0)
        ColumnsColor.Clear()

        'Setting date
        Data = startDate

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

    Private Sub SetGanttHeaders(ByVal startDate As Date)
        Dim i As Integer = 1
        ColumnsColor.Clear()
        Data = startDate
        For Each control In GanttHeadersTablePanel.Controls
            If TypeOf control Is IntervalHeader Then
                CType(control, IntervalHeader).head.Text = Data.DayOfWeek.ToString.Substring(0, 3)
                CType(control, IntervalHeader).body.Text = Data.Day.ToString
                If Data.DayOfWeek = DayOfWeek.Saturday OrElse Data.DayOfWeek = DayOfWeek.Sunday Then
                    ColumnsColor.Add(i)
                    CType(control, IntervalHeader).BackColor = Color.Gray
                Else
                    CType(control, IntervalHeader).BackColor = Color.SteelBlue
                End If
                i += 1
                Data = DateAdd(DateInterval.Day, 1, Data)           'Increment Date
            End If
        Next
        GanttHeadersTablePanel.Invalidate()
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
                .Height = 40
            })

            'Det delle informazioni della task
            Dim taskInfo As New TaskInfo(task)

            'Impostazione della barra di avanzamento del task 
            Dim taskProgress As New TaskProgress(task, Data, DateAdd(DateInterval.Day, GanttIntervalCount, Data)) With {
                    .Dock = DockStyle.Fill
             }


            ganttBody.Controls.Add(taskInfo, 0, i)
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

    Private Sub GanttDiagram_Resize(sender As Object, e As EventArgs)
        For Each control In GanttBodyTablePanel.Controls
            If TypeOf control Is TaskProgress Then
                CType(control, TaskProgress).DrawProgress()
            End If
        Next
    End Sub

    'Backgound grigio nei dabati e domeniche più altri colori per giorni
    Private Sub GanttHeadersTablePanel_CellPaint(sender As Object, e As TableLayoutCellPaintEventArgs) Handles GanttHeadersTablePanel.CellPaint
        Me.SuspendLayout()
        If ColumnsColor.Contains(e.Column) Then
            e.Graphics.FillRectangle(Brushes.Gray, e.CellBounds)
        Else
            e.Graphics.FillRectangle(Brushes.SteelBlue, e.CellBounds)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        'SetGanttHeadersGraphics(DateAdd(DateInterval.Day, -1, Data))
        SetGanttHeaders(DateAdd(DateInterval.Day, -1, Data))
        For Each control In GanttBodyTablePanel.Controls
            If TypeOf control Is TaskProgress Then
                CType(control, TaskProgress).MoveProgression(1)
            End If
        Next
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        'SetGanttHeadersGraphics(DateAdd(DateInterval.Day, 1, Data))
        SetGanttHeaders(DateAdd(DateInterval.Day, 1, Data))
        For Each control In GanttBodyTablePanel.Controls
            If TypeOf control Is TaskProgress Then
                CType(control, TaskProgress).MoveProgression(2)
            End If
        Next
    End Sub

    Private Sub GanttReload_Click(sender As Object, e As EventArgs) Handles GanttReload.Click
        PerformGantt()
    End Sub

    Private Sub TaskAdd_Click(sender As Object, e As EventArgs) Handles TaskAdd.Click
        tasks.Add(New TaskGantt() With {
            .Name = "task",
            .DateStartPlanned = New Date(1900, 1, 1),
            .DateEndPlanned = New Date(1900, 1, 1)
        })
    End Sub

End Class
