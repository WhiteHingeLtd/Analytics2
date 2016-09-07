Public Class totalNumberGatherer
    Public pickSH As Double = 0
    Public pickSQ As Double = 0
    Public pickBH As Double = 0
    Public pickBQ As Double = 0
    Public pickMH As Double = 0
    Public pickMQ As Double = 0
    Public packSH As Double = 0
    Public packSQ As Double = 0
    Public packBH As Double = 0
    Public packBQ As Double = 0
    Public packMH As Double = 0
    Public packMQ As Double = 0
    Public prepackH As Double = 0
    Public prepackQ As Double = 0

    Public TotalPickingH
    Public TotalPackingH
    Public TotalPickingQ
    Public TotalPackingQ

    Public TotalH
    Public TotalQ

    Public Sub New(piSH As Double, piSQ As Double, piBH As Double, piBQ As Double, piMH As Double, piMQ As Double, paSH As Double, paSQ As Double, paBH As Double, paBQ As Double, paMH As Double, paMQ As Double, ppH As Double, ppQ As Double)
        pickSH = piSH
        pickSQ = piSQ
        pickBH = piBH
        pickBQ = piBQ
        pickMH = piMH
        pickMQ = piMQ
        packSH = paSH
        packSQ = paSQ
        packBH = paBH
        packBQ = paBQ
        packMH = paMH
        packMQ = paMQ
        prepackH = ppH
        prepackQ = ppQ

        TotalPickingH = piSH + piBH + piMH
        TotalPackingH = paSH + paBH + paMH
        TotalPickingQ = piSQ + piBQ + piMQ
        TotalPackingQ = paSQ + paBQ + paMQ

        TotalH = piSH + piBH + piMH + paSH + paBH + paMH + ppH
        TotalQ = piSQ + piBQ + piMQ + paSQ + paBQ + paMQ + ppQ
    End Sub

End Class
