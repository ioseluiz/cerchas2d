Public Class FormResultados
    Dim drawOptions As Integer = 0
    Dim coordenadasDibujo(,) As Double
    Dim pen1 As Pen = New Pen(Color.Black, 2)

    Sub DrawImage(ByVal coordinates(,) As Double)

        drawOptions = 1
        coordenadasDibujo = coordinates
        picBoxDiagram.Invalidate()
        'MsgBox(Str(drawOptions))





    End Sub
    Private Sub FormResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub picBoxDiagram_Paint(sender As Object, e As PaintEventArgs) Handles picBoxDiagram.Paint
        Console.WriteLine(Str(drawOptions))
        'MsgBox(Str(drawOptions))
        'Dim surface As Graphics = picBoxDiagram.CreateGraphics()
        Select Case drawOptions
            Case 1
                For i = 1 To coordenadasDibujo.GetLength(0) - 1
                    e.Graphics.DrawLine(pen1, CSng(coordenadasDibujo(i, 1)), CSng(coordenadasDibujo(i, 2)), CSng(coordenadasDibujo(i, 3)), CSng(coordenadasDibujo(i, 4)))
                Next
                'e.Graphics.DrawLine(pen1, 10, 10, 100, 10)
                'drawOptions = 0
        End Select
        'picBoxDiagram.Invalidate()



    End Sub
End Class