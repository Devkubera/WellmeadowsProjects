Public Class Add_PatientVisit
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If Not String.IsNullOrEmpty(visit_date.Text) Then
            visit_date.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(visit_doc_Id.Text) Then
            visit_doc_Id.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(visit_p_Id.Text) Then
            visit_p_Id.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(visit_w_Id.Text) Then
            visit_w_Id.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(visit_type.Text) Then
            visit_type.Text = String.Empty
        End If
    End Sub
End Class