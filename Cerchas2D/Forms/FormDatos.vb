Public Class FormDatos
    Dim i As Integer
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles nudNodos.ValueChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormNodos.dgvJoints.RowCount = nudNodos.Value
        'Encabezados de acuerdo a sistema de unidades seleccionado
        If Principal.optEs.Checked Then
            FormNodos.dgvJoints.Columns(1).HeaderText = "X (ft)"
            FormNodos.dgvJoints.Columns(2).HeaderText = "Y (ft)"
            FormNodos.dgvJoints.Columns(5).HeaderText = "Δx (in)"
            FormNodos.dgvJoints.Columns(6).HeaderText = "Δy (in)"
        End If
        If Principal.optSI.Checked Then
            FormNodos.dgvJoints.Columns(1).HeaderText = "X (m)"
            FormNodos.dgvJoints.Columns(2).HeaderText = "Y (m)"
            FormNodos.dgvJoints.Columns(5).HeaderText = "Δx (mm)"
            FormNodos.dgvJoints.Columns(6).HeaderText = "Δy (mm)"
        End If
        For i = 1 To nudNodos.Value
            FormNodos.dgvJoints.Rows(i - 1).Cells(0).Value = i
        Next

        FormElementos.dgvElementos.RowCount = nudElementos.Value
        For i = 1 To nudElementos.Value
            FormElementos.dgvElementos.Rows(i - 1).Cells(0).Value = i
        Next
        'Encabezados de acuerdo a sistema de unidades seleccionado
        If Principal.optEs.Checked Then
            FormElementos.dgvElementos.Columns(3).HeaderText = "E (ksi)"
            FormElementos.dgvElementos.Columns(4).HeaderText = "A (in2)"
            FormElementos.dgvElementos.Columns(6).HeaderText = "Error Fab (in)"



        End If
        If Principal.optSI.Checked Then
            FormElementos.dgvElementos.Columns(3).HeaderText = "E (GPa)"
            FormElementos.dgvElementos.Columns(4).HeaderText = "A (m2)"
            FormElementos.dgvElementos.Columns(6).HeaderText = "Error Fab (mm)"

        End If

        FormFuerzas.dgvCargas.RowCount = nudNodos.Value
        'Encabezados de la Tabla de Fuerzas
        If Principal.optEs.Checked Then
            FormFuerzas.dgvCargas.Columns(1).HeaderText = "Px (kips)"
            FormFuerzas.dgvCargas.Columns(2).HeaderText = "Py (kips)"

        End If
        If Principal.optSI.Checked Then
            FormFuerzas.dgvCargas.Columns(1).HeaderText = "Px (KN)"
            FormFuerzas.dgvCargas.Columns(2).HeaderText = "Py (KN)"

        End If
        For i = 1 To nudNodos.Value
            FormFuerzas.dgvCargas.Rows(i - 1).Cells(0).Value = i
        Next

        'Formulario de Matrices
        FormMatrices.dgvMatrizK.ColumnCount = 2 * Int(nudNodos.Value)
        FormMatrices.dgvMatrizK.RowCount = 2 * Int(nudNodos.Value)
        FormMatrices.dgvF.RowCount = 2 * Int(nudNodos.Value)
        FormMatrices.dgvF.ColumnCount = 1
        FormMatrices.dgvP.RowCount = 2 * Int(nudNodos.Value)
        FormMatrices.dgvP.ColumnCount = 1
        FormMatrices.dgvD.RowCount = 2 * Int(nudNodos.Value)
        FormMatrices.dgvD.ColumnCount = 1
        FormMatrices.dgvSP.RowCount = 2 * Int(nudNodos.Value)
        FormMatrices.dgvSP.ColumnCount = 1


        Button1.Enabled = False
        Button1.BackColor = Color.FromArgb(83, 77, 86)



    End Sub
End Class