Public Class FormResultados
    Dim drawOptions As Integer = 0
    Dim coordenadasDibujo(,) As Double, coordenadasNodos(,) As Double
    Dim pen1 As Pen = New Pen(Color.Black, 2)

    Sub DrawImage(ByVal coordinates(,) As Double, coorNodos(,) As Double)

        drawOptions = 1
        coordenadasDibujo = coordinates
        coordenadasNodos = coorNodos
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
                Dim chosenFont As Font = New Font("Comic Sans MS", 10)
                Dim chosenBrush As SolidBrush = New SolidBrush(Color.Black)
                'Dibujo de Elementos
                For i = 1 To coordenadasDibujo.GetLength(0) - 1

                    e.Graphics.DrawLine(pen1, CSng(coordenadasDibujo(i, 1)), CSng(coordenadasDibujo(i, 2)), CSng(coordenadasDibujo(i, 3)), CSng(coordenadasDibujo(i, 4)))
                Next
                'Enumerar Nodos
                For i = 1 To coordenadasNodos.GetLength(0) - 1
                    e.Graphics.DrawString(Str(i), chosenFont, chosenBrush, CSng(coordenadasNodos(i, 1) - 20), CSng(coordenadasNodos(i, 2) + 20))
                    Console.WriteLine("Nodo " + Str(i))
                    For j = 3 To 4
                        Console.WriteLine(Str(coordenadasNodos(i, j)))
                    Next
                Next
                'Dibujo de apoyos
                For i = 1 To coordenadasNodos.GetLength(0) - 1
                    'Condicion de 2 restricciones en nodo
                    If coordenadasNodos(i, 3) = 1 And coordenadasNodos(i, 4) = 1 Then
                        Dim puntoA As New Point(coordenadasNodos(i, 1), coordenadasNodos(i, 2))
                        Dim puntoB As New Point(coordenadasNodos(i, 1) - 10, coordenadasNodos(i, 2) + 10)
                        Dim puntoC As New Point(coordenadasNodos(i, 1) + 10, coordenadasNodos(i, 2) + 10)
                        Dim puntosTriangulo As Point() = {puntoA, puntoB, puntoC}

                        e.Graphics.DrawPolygon(pen1, puntosTriangulo)

                    End If

                    If coordenadasNodos(i, 3) = 1 And coordenadasNodos(i, 4) = 0 Then
                            'Dibujar apoyo solamente en x
                            Dim miRectangulo As New Rectangle
                            miRectangulo.X = coordenadasNodos(i, 1) - 5
                            miRectangulo.Y = coordenadasNodos(i, 2)
                            miRectangulo.Width = 10
                            miRectangulo.Height = 10
                            e.Graphics.DrawEllipse(pen1, miRectangulo)

                        End If

                    If coordenadasNodos(i, 3) = 0 And coordenadasNodos(i, 4) = 1 Then
                        'Dibujar solamente apoyo en Y
                        Dim miRectangulo As New Rectangle
                        miRectangulo.X = coordenadasNodos(i, 1)
                        miRectangulo.Y = coordenadasNodos(i, 2) + 5
                        miRectangulo.Width = 10
                        miRectangulo.Height = 10
                        e.Graphics.DrawEllipse(pen1, miRectangulo)
                    End If



                Next
                'e.Graphics.DrawLine(pen1, 10, 10, 100, 10)
                'drawOptions = 0
        End Select
        'picBoxDiagram.Invalidate()



    End Sub
End Class