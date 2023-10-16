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

        Timer1.Start()
    End Sub

    Private Function GetTimeOfDay(hour As Integer) As String
        If hour < 12 Then
            Return "ตอนเช้า"
        ElseIf hour < 17 Then
            Return "ตอนบ่าย"
        ElseIf hour < 20 Then
            Return "ตอนเย็น"
        Else
            Return "ตอนดึก"
        End If
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim times = DateTime.Now.ToString("HH:mm:ss")
        timeLabel.Text = day_label.Text & " " & times & " นาฬิกา"
    End Sub

    Private Sub day_label_Click(sender As Object, e As EventArgs)

    End Sub
End Class
