Public Class TaskControl
    Private _task As TaskGantt
    Public Property Task() As TaskGantt
        Get
            Return _task
        End Get
        Set(ByVal value As TaskGantt)
            _task = value
        End Set
    End Property

    Private startPosition As Integer
    Private endPosition As Integer
    Private TempoVisualizzato As Integer

    Public Sub New(task As TaskGantt, DataInizioVisualizzazione As Date, DataFineVisualizzazione As Date)
        InitializeComponent()

        Me.Task = task

        TempoVisualizzato = DateDiff(DateInterval.Second, DataInizioVisualizzazione, DataFineVisualizzazione)
        startPosition = GetDateSecond(task.DateStartPlanned) - GetDateSecond(DataInizioVisualizzazione)
        endPosition = GetDateSecond(task.DateEndPlanned) - GetDateSecond(DataInizioVisualizzazione)
        Draw()
    End Sub

    Public Sub Draw()
        Dim VisualStep As Double = Me.Width / TempoVisualizzato
        Me.Controls.Clear()

        Dim bar As New PictureBox() With {
            .Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Top,
            .BackColor = Task.Color,
            .Height = Me.Height - 6,
            .Location = New Point(VisualStep * startPosition, 3),
            .Size = New Size(VisualStep * (endPosition - startPosition), Me.Height - 6)
        }

        Me.Controls.Add(bar)
    End Sub

    Public Sub MoveBar(action As Integer, Optional intervalType As DateInterval = DateInterval.Day)
        Dim k As Integer
        If intervalType = DateInterval.Day Then k = 86400
        If action = 1 Then
            startPosition += k
            endPosition += k
        Else
            startPosition -= k
            endPosition -= k
        End If
        Draw()
    End Sub
End Class
