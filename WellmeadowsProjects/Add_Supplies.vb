Public Class Add_Supplies
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If Not String.IsNullOrEmpty(sup_name.Text) Then
            sup_name.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(sup_tel.Text) Then
            sup_tel.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(sup_fax.Text) Then
            sup_fax.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(sup_address.Text) Then
            sup_address.Text = String.Empty
        End If
    End Sub
End Class