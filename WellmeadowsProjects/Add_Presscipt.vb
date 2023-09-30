Public Class Add_Presscipt
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If Not String.IsNullOrEmpty(pt_firstName.Text) Then
            pt_firstName.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(pt_lastName.Text) Then
            pt_lastName.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(pt_id.Text) Then
            pt_id.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_id.Text) Then
            m_id.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_name.Text) Then
            m_name.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_dosage.Text) Then
            m_dosage.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_method.Text) Then
            m_method.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_startDate.Text) Then
            m_startDate.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_endDate.Text) Then
            m_endDate.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_desc.Text) Then
            m_desc.Text = String.Empty
        End If

    End Sub
End Class