﻿Partial Class WellmeadowsDataSet
    Partial Public Class PW_PrescriptsDataTable
        Private Sub PW_PrescriptsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.mmIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class Staff_QualificatesDataTable
        Private Sub Staff_QualificatesDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.qualIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class StaffsDataTable
        Private Sub StaffsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.telColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class Med_MedicinesTableAdapter
    End Class
End Class
