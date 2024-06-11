Module DateUtils
    Private UnixEpoch As New DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)

    Public Function GetDateSecond(Data As DateTime) As Double
        Return DateDiff(DateInterval.Second, UnixEpoch, Data)
    End Function
End Module
