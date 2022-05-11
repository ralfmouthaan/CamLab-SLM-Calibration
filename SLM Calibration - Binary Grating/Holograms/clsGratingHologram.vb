' Ralf Mouthaan
' University of Cambridge
' December 2021
'
' Class for binary grating holograms

Option Explicit On
Option Strict On

Public Class clsGratingHologram
    Inherits clsHologram

    Public LineWidth As Integer
    Public LowValue As Double
    Public HighValue As Double

    Public Overrides Property arrRawHologram(i As Integer, j As Integer) As Double
        Get
            If Math.Round(i / LineWidth) Mod 2 = 0 Then
                Return LowValue
            Else
                Return HighValue
            End If
        End Get
        Set(value As Double)
            Throw New NotImplementedException()
        End Set
    End Property

End Class
