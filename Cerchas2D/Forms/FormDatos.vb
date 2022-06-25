Public Class FormDatos
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles nudNodos.ValueChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormNodos.dgvJoints.RowCount = nudNodos.Value
        For i = 1 To nudNodos.Value
            FormNodos.dgvJoints.Rows(i - 1).Cells(0).Value = i
        Next

        FormElementos.dgvElementos.RowCount = nudElementos.Value
        For i = 1 To nudElementos.Value
            FormElementos.dgvElementos.Rows(i - 1).Cells(0).Value = i
        Next

        FormFuerzas.dgvCargas.RowCount = nudNodos.Value
        For i = 1 To nudNodos.Value
            FormFuerzas.dgvCargas.Rows(i - 1).Cells(0).Value = i
        Next






    End Sub
End Class