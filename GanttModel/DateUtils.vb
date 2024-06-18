Module DateUtils
    'Riferimento con una data fissa per avere un confronto eed avere i secondi trascorsi
    Private UnixEpoch As New DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)

    ''' <summary>
    ''' Function returns the quantity of seconds elapsed between UnixEpoch and Data input
    ''' </summary>
    ''' <param name="Data">Data which has to be convertend in seconds</param>
    ''' <returns>Amount of seconds elapsed between UnixEpoch (01/01/1970) and Date</returns>
    Public Function GetDateSecond(Data As DateTime) As Double
        Return DateDiff(DateInterval.Second, UnixEpoch, Data)
    End Function
End Module
