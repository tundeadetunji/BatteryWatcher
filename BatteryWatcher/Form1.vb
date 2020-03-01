Imports System.Runtime.InteropServices
Imports General_Module.FormatWindow
Imports NModule.NFunctions
Imports NetModule.NTimer
Public Class Form1
	Dim myManagedPower As New ManagedPower()
	Dim g As New General_Module.FormatWindow
	Dim n As New NetModule.NTimer

	''' <summary>
	''' Opens any application stored in Programs.txt in JSON
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		'open apps if not already open
		Dim v As String = ReadText(My.Application.Info.DirectoryPath & "\Programs.txt")
		If v.Length < 1 Then GoTo 3
		v = v.Replace("\", "\\")
		Dim s As New List(Of String)
		Try
			s.Clear()
		Catch ex As Exception
		End Try
		s = DatabaseToListJSON(v)
		For i As Integer = 0 To s.Count - 1
			StartFile(s(i), ProcessWindowStyle.Normal, False, True)
		Next
3:
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		If myManagedPower.ToString().ToLower = "ac" Then
			StopTimer(Timer2, Timer3)
		Else
			StartTimer("Please plug in your machine!", Timer2, Timer3, 3, 0.5, True, False, False, False, False, True)
		End If
	End Sub
End Class

Public Class ManagedPower
    ' GetSystemPowerStatus() is the only unmanaged API called.
    Declare Auto Function GetSystemPowerStatus Lib "kernel32.dll" _
	Alias "GetSystemPowerStatus" (ByRef sps As SystemPowerStatus) As Boolean

	Public Overrides Function ToString() As String
		Dim text As String = ""
		Dim sysPowerStatus As SystemPowerStatus
        ' Get the power status of the system
        If ManagedPower.GetSystemPowerStatus(sysPowerStatus) Then
            ' Current power source - AC/DC
            Dim currentPowerStatus = sysPowerStatus.ACLineStatus
			text += sysPowerStatus.ACLineStatus.ToString()
		End If
		Return text
	End Function

	<StructLayout(LayoutKind.Sequential)>
	Public Structure SystemPowerStatus
		Public ACLineStatus As _ACLineStatus
		Public BatteryFlag As _BatteryFlag
		Public BatteryLifePercent As Byte
		Public Reserved1 As Byte
		Public BatteryLifeTime As System.UInt32
		Public BatteryFullLifeTime As System.UInt32
	End Structure

	Public Enum _ACLineStatus As Byte
		Battery = 0
		AC = 1
		Unknown = 255
	End Enum

	<Flags()>
	Public Enum _BatteryFlag As Byte
		High = 1
		Low = 2
		Critical = 4
		Charging = 8
		NoSystemBattery = 128
		Unknown = 255
	End Enum
End Class
