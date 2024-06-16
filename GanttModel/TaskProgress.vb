Public Class TaskProgress
    Private _task As TaskGantt
    Public Property Task() As TaskGantt
        Get
            Return _task
        End Get
        Set(ByVal value As TaskGantt)
            _task = value
        End Set
    End Property

    'Variabili per colorazione delle celle del tablelayoutpanel
    Private CellColorStartindex As Integer = -1
    Private CellColorEndtindex As Integer = -1
    Dim CountHourInterval As Integer

    Public Sub New(task As TaskGantt, StartInterval As Date, EndInterval As Date)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        Me.Task = task
        PerformGraphic(StartInterval, EndInterval)
    End Sub

    Public Sub PerformGraphic(StartInterval As Date, EndInterval As Date)
        Dim progressLayout As TableLayoutPanel = ProgressTabelLayout
        Dim CountDayInterval As Integer = DateDiff(DateInterval.Day, StartInterval, EndInterval)

        CountHourInterval = CountDayInterval * 24

        Dim CountSecondStartInterval As Double = GetDateSecond(StartInterval)
        Dim CountSecondEndInterval As Double = GetDateSecond(EndInterval)

        Dim CountSecondStartPlanned As Double = GetDateSecond(Task.DateStartPlanned)
        Dim CountSecondendPlanned As Double = GetDateSecond(Task.DateEndPlanned)

        progressLayout.ColumnStyles.Clear()

        CellColorStartindex = (CountSecondStartPlanned - CountSecondStartInterval) \ 3600
        CellColorEndtindex = (CountSecondendPlanned - CountSecondStartInterval) \ 3600
    End Sub

    Public Sub DrawProgress()
        Dim widthIncrement As Double = Me.Width / CountHourInterval
        Me.PictureBox1.BackColor = Task.Color
        Me.PictureBox1.Location = New Point(widthIncrement * (CellColorStartindex), 3)
        Me.PictureBox1.Size = New Size(widthIncrement * (CellColorEndtindex - CellColorStartindex), 15)
    End Sub

    Public Sub MoveProgression(action As Integer)
        If action = 1 Then
            CellColorStartindex += 24
            CellColorEndtindex += 24
        ElseIf action = 2 Then
            CellColorStartindex -= 24
            CellColorEndtindex -= 24
        End If
        DrawProgress()
    End Sub

    Public Sub PrintInfo()
        MsgBox(Task.Name + " | Inizio ora: " + CellColorStartindex.ToString + vbCrLf + " | Fine ora: " + CellColorEndtindex.ToString)
    End Sub
End Class