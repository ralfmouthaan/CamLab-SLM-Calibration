' Ralf Mouthaan
' University of Cambridge
' December 2021
'
' Main from for grating-based SLM Calibration

Option Explicit On
Option Strict On

Public Class frmMain
    Private Sub cmdRefreshSLM_Click(sender As Object, e As EventArgs) Handles cmdRefreshSLM.Click

        MeasurementSetup.SLM.StartUp()
        MeasurementSetup.Holo.LowValue = 0
        MeasurementSetup.Holo.HighValue = Math.PI
        MeasurementSetup.Holo.LineWidth = CInt(nudLineWidth.Value)
        MeasurementSetup.SLM.Refresh()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MeasurementSetup = New clsMeasurementSetup
    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click

        Dim NoMeasurements As Integer = 50
        Dim NoRepeats As Integer = 1

        'Start up
        cmdStart.Enabled = False
        MeasurementSetup.Startup()
        For Each f In IO.Directory.GetFiles("Grating Cal Data")
            If f.EndsWith(".m") = False Then
                IO.File.Delete(f)
            End If
        Next

        'Run measurement
        MeasurementSetup.Holo.LowValue = 0
        For j = 1 To NoRepeats
            For i = 0 To NoMeasurements

                cmdStart.Text = Math.Round(i / NoMeasurements * 100, 2).ToString + "% Completed"
                cmdStart.Refresh()
                MeasurementSetup.Holo.HighValue = 2 * Math.PI / NoMeasurements * i
                MeasurementSetup.SLM.Refresh()
                MeasurementSetup.Camera.SaveImage("Grating Cal Data/Grating Cal - " +
                    MeasurementSetup.Holo.HighValue.ToString("F2") + " rad - #" + j.ToString + ".png")

            Next
        Next

        'Shut down
        cmdStart.Enabled = True
        cmdStart.Text = "Start Cal"
        MeasurementSetup.Shutdown()


    End Sub
End Class
