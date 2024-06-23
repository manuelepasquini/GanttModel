Imports System.Runtime.Intrinsics.X86

Public Class GanttControl
    'Visual style
    Dim HeaderFont As Font = New Font("Segoe UI", 14, FontStyle.Bold)
    Dim HeaderBackcolor As Color = Color.SteelBlue
    Dim HeaderForeColor As Color = Color.White
    Dim HeaderItemBackColor As Color = Color.FromArgb(100, 150, 200)
    Dim HeaderItemForeColor As Color = Color.White
    Dim HeaderItemHeadFont As Font = New Font("Segoe UI", 10, FontStyle.Bold)
    Dim HeaderItemBodyFont As Font = New Font("Segoe UI", 9)
    Dim HeaderHolidayBackColor As Color = Color.Gray
    Dim HeaderHolidayForeColor As Color = Color.White

    'public Proprety
    Public Property Data As Date
    Public Property IntervalType As DateInterval = DateInterval.Day
    Public Property IntervalCount As Integer = 21

    'Lista di dati mostrati
    Private _tasks As List(Of TaskGantt)
    Public Property Tasks() As List(Of TaskGantt)
        Get
            Return _tasks
        End Get
        Set(ByVal value As List(Of TaskGantt))
            _tasks = value
        End Set
    End Property

    'UserControl create in line
    Private HeaderTimeInterval As TableLayoutPanel
    Private HeaderTimeIntervalItems As TableLayoutPanel

    Public Sub New()
        InitializeComponent()

        Data = Now.Date
        DrawHeader()
        SetHeaderData()
        DrawBody()
    End Sub
    Public Sub New(tasks As List(Of TaskGantt))
        InitializeComponent()

        Data = Now.Date
        Me.Tasks = tasks
        DrawHeader()
        SetHeaderData()
        DrawBody()
        SetBodyData()
    End Sub


    Public Sub DrawHeader()
        'Set visual style
        Header.BackColor = HeaderBackcolor

        'Set columns settings
        Header.Controls.Clear()
        Header.ColumnStyles.Clear()
        Header.ColumnCount = 2
        Header.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        Header.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 75.0F))

        'Second Column
        HeaderTimeInterval = New TableLayoutPanel() With {
            .Dock = DockStyle.Fill,
            .ColumnCount = 1,
            .RowCount = 2,
            .CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
            .Padding = New Padding(0, 0, 0, 0),
            .Margin = New Padding(0, 0, 0, 0)
        }   'Dichiarazione di tlp intervalli di tempo

        HeaderTimeInterval.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        HeaderTimeInterval.RowStyles.Add(New RowStyle(SizeType.Percent, 80.0F))

        HeaderTimeIntervalItems = New TableLayoutPanel() With {
            .Dock = DockStyle.Fill,
            .ColumnCount = IntervalCount,
            .CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
            .RowCount = 1,
            .Margin = New Padding(0, 0, 0, 0),
            .Padding = New Padding(0, 0, 0, 0)
        }
        For i = 0 To IntervalCount - 1
            HeaderTimeIntervalItems.ColumnStyles.Add(New ColumnStyle() With {.SizeType = SizeType.Percent, .Width = 100.0F / IntervalCount})

            Dim interval As New IntervalHeader() With {
                .Dock = DockStyle.Fill,
                .Padding = New Padding(0, 0, 0, 0),
                .Margin = New Padding(0, 0, 0, 0)
            }
            interval.body.Font = HeaderItemBodyFont
            interval.head.Font = HeaderItemHeadFont

            HeaderTimeIntervalItems.Controls.Add(interval, i, 0)
        Next

        'Set controls
        Header.Controls.Add(New Label() With {
            .Dock = DockStyle.Fill,
            .Text = "Lista attività",
            .TextAlign = ContentAlignment.MiddleLeft,
            .Font = HeaderFont,
            .ForeColor = HeaderForeColor
        }, 0, 0)      'Lista attività
        HeaderTimeInterval.Controls.Add(HeaderTimeIntervalItems, 0, 1)
        Header.Controls.Add(HeaderTimeInterval, 1, 0)
        SetHeaderData()
    End Sub

    Private Sub SetHeaderData()
        Dim tmpData As Date = Data
        For Each control As Control In HeaderTimeIntervalItems.Controls
            If TypeOf control Is IntervalHeader Then
                CType(control, IntervalHeader).Data = tmpData
                CType(control, IntervalHeader).head.Text = tmpData.ToString("ddd") '+ vbCrLf + tmpData.Day.ToString
                CType(control, IntervalHeader).body.Text = tmpData.ToString("dd") + " " + tmpData.ToString("MMM")

                If tmpData.DayOfWeek = DayOfWeek.Saturday OrElse tmpData.DayOfWeek = DayOfWeek.Sunday Then
                    CType(control, IntervalHeader).BackColor = HeaderHolidayBackColor
                    CType(control, IntervalHeader).ForeColor = HeaderHolidayForeColor
                Else
                    CType(control, IntervalHeader).BackColor = HeaderItemBackColor
                    CType(control, IntervalHeader).ForeColor = HeaderItemForeColor
                End If

                tmpData = DateAdd(IntervalType, 1, tmpData)
            End If
        Next
    End Sub

    Public Sub DrawBody()
        Body.ColumnStyles.Clear()
        Body.ColumnCount = 2
        Body.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        Body.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 75.0F))
    End Sub

    Public Sub SetBodyData()
        Dim i As Integer = 0
        Body.RowCount = 0
        Body.RowStyles.Clear()
        Body.Controls.Clear()

        For Each task As TaskGantt In Tasks
            Body.RowStyles.Add(New RowStyle(SizeType.Absolute, 50))

            'Set delle informazioni della task
            Dim taskInfo As New TaskInfo(task)

            'Impostazione della barra di avanzamento del task 
            Dim taskControl As New TaskControl(task, Data, DateAdd(DateInterval.Day, IntervalCount, Data)) With {.Dock = DockStyle.Fill}

            Body.Controls.Add(taskInfo, 0, i)
            Body.Controls.Add(taskControl, 1, i)
            taskControl.Draw()

            i += 1
        Next

        Body.RowStyles.Add(New RowStyle() With {
            .SizeType = SizeType.Absolute,
            .Height = 10
        })
        Body.Controls.Add(New Label(), 0, i)
    End Sub

    Private Sub GoBackInterval() Handles GoBack.Click
        Data = DateAdd(IntervalType, -1, Data)
        SetHeaderData()
        For Each control As Control In Body.Controls
            If TypeOf control Is TaskControl Then
                CType(control, TaskControl).MoveBar(1)
            End If
        Next
    End Sub

    Private Sub GoNextInterval() Handles GoNext.Click
        Data = DateAdd(IntervalType, 1, Data)
        SetHeaderData()
        For Each control As Control In Body.Controls
            If TypeOf control Is TaskControl Then
                CType(control, TaskControl).MoveBar(2)
            End If
        Next
    End Sub

    Private Sub ReDraw() Handles Me.Resize
        For Each control As Control In Body.Controls
            If TypeOf control Is TaskControl Then
                CType(control, TaskControl).Draw()
            End If
        Next
    End Sub
End Class
