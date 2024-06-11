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

    Public Sub New(task As TaskGantt, StartInterval As Date, EndInterval As Date, color As Color)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        Me.Task = task

        PerformGraphic(StartInterval, EndInterval)
    End Sub

    Private Sub PerformGraphic(StartInterval As Date, EndInterval As Date)
        Dim progressLayout As TableLayoutPanel = ProgressTabelLayout

        Dim i As Integer
        Dim CountDayInterval As Integer = DateDiff(DateInterval.Day, StartInterval, EndInterval)
        'Dim CountHourInterval As Integer = CountDayInterval * 24
        CountHourInterval = CountDayInterval * 24

        Dim CountSecondStartInterval As Double = GetDateSecond(StartInterval)
        Dim CountSecondEndInterval As Double = GetDateSecond(EndInterval)

        Dim CountSecondStartPlanned As Double = GetDateSecond(Task.DateStartPlanned)
        Dim CountSecondendPlanned As Double = GetDateSecond(Task.DateEndPlanned)

        progressLayout.ColumnStyles.Clear()
        'progressLayout.ColumnCount = CountHourInterval

        For i = 0 To CountHourInterval
            'Calcolo cella per inizio colorazione
            If (CountSecondStartInterval + (3600 * i)) >= CountSecondStartPlanned AndAlso CellColorStartindex = -1 Then
                CellColorStartindex = i
            End If

            'Calcolo cella per fine colorazione
            If (CountSecondStartInterval + (3600 * i)) >= CountSecondendPlanned AndAlso CellColorEndtindex = -1 Then
                CellColorEndtindex = i
                'Exit For
            End If

        Next

        'MsgBox("Inizio:" + Str(CellColorStartindex) + vbCrLf + "Fine:" + Str(CellColorEndtindex))
    End Sub

    Public Sub DrawProgress()
        Dim widthIncrement As Double = Me.Width / CountHourInterval
        Me.PictureBox1.BackColor = Task.Color
        Me.PictureBox1.Location = New Point(widthIncrement * (CellColorStartindex), 3)
        Me.PictureBox1.Size = New Size(widthIncrement * (CellColorEndtindex - CellColorStartindex), 15)
    End Sub
End Class