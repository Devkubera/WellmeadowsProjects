Public Class Add_Medicine
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If Not String.IsNullOrEmpty(m_Id.Text) Then
            m_Id.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_name.Text) Then
            m_name.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_desc.Text) Then
            m_desc.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_method.Text) Then
            m_method.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_scale.Text) Then
            m_scale.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_stock.Text) Then
            m_stock.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_unit.Text) Then
            m_unit.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_dosage.Text) Then
            m_dosage.Text = String.Empty
        End If
    End Sub
End Class