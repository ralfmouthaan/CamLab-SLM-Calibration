' Ralf Mouthaan
' University of Cambridge
' March 2020

Option Explicit On
Option Strict On

Module modMeasurementSetup

    Public MeasurementSetup As clsMeasurementSetup

End Module

Public Class clsMeasurementSetup

    Public Camera As clsCamera
    Public SLM As clsSLM
    Public Holo As New clsGratingHologram
    Public ReadOnly HoloWidth As Integer = 2000

    Public Sub New()

        ' Set up SLM
        SLM = New clsSLM
        SLM.intScreenNo = 1

        'Set up Camera
        Camera = New clsBlackflyCam
        Camera.Load("D:\RPM Data Files\Output Camera Pol 1.txt")

        'Set up hologram
        Holo = New clsGratingHologram With {
            .RawWidth = HoloWidth,
            .LineWidth = 50,
            .HighValue = 0,
            .LowValue = Math.PI,
            .bolVisible = True,
            .bolCircularAperture = False
        }
        Holo.LoadZernikes("D:\RPM Data Files\Tx1 Zernikes.txt")
        Holo.dblTiltx = 0
        Holo.dblTilty = 0
        Holo.dblFocus = 0
        SLM.lstHolograms.Add(Holo)

    End Sub
    Public Sub Startup()
        Camera.Startup()
        SLM.StartUp()
    End Sub
    Public Sub Shutdown()
        Camera.Shutdown()
        SLM.ShutDown()
    End Sub

End Class