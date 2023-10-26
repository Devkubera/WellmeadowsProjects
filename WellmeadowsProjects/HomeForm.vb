Imports System.Globalization
Imports System.Reflection.Emit

Public Class HomeForm

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentTime As DateTime = DateTime.Now
        Dim cultureInfo As CultureInfo = New CultureInfo("th-TH")
        Dim dayOfWeek As String = currentTime.ToString("dddd", cultureInfo)
        Dim timeOfDay As String = GetTimeOfDay(currentTime.Hour)
        Dim greeting As String = $"สวัสดีวัน{dayOfWeek}{timeOfDay}"
        day_label.Text = greeting
        Console.WriteLine($"hour is {currentTime.Hour}")
        Timer1.Start()
    End Sub

    Private Function GetTimeOfDay(hour As Integer) As String
        If hour < 12 And hour > 6 Then
            Return "ตอนเช้า !"
        ElseIf hour > 12 And hour < 17 Then
            Return "ตอนบ่าย !"
        ElseIf hour > 17 And hour < 20 Then
            Return "ตอนเย็น !"
        ElseIf hour > 20 Or hour < 5 Then
            Return "ตอนดึก !"
        Else
            Return "ตอนเช้าตรู่ !"
        End If
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim times = DateTime.Now.ToString("HH:mm:ss")
        timeLabel.Text = day_label.Text & Environment.NewLine & "ขณะนี้เวลา " & times & " นาฬิกา"
    End Sub
End Class
