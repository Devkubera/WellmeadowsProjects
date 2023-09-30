Public Class Add_Patient
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If Not String.IsNullOrEmpty(pt_firstName.Text) Then
            pt_firstName.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(pt_lastName.Text) Then
            pt_lastName.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(pt_birthday.Text) Then
            pt_birthday.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(pt_gender.Text) Then
            pt_gender.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(pt_tel.Text) Then
            pt_tel.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(pt_date.Text) Then
            pt_date.Text = String.Empty
        End If
    End Sub
End Class