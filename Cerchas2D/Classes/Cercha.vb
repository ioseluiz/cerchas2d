Public Class Cercha
    Public cantElementos As Integer, arrayElementos() As Elemento, cantNodos As Integer, arrayNodos() As Nodo
    Public K(,) As Double

    Public Sub New(vectorNodos() As Nodo, vectorElementos() As Elemento)
        'Constructor de la clase
        cantNodos = vectorNodos.Length - 1
        cantElementos = vectorElementos.Length - 1
        ReDim arrayElementos(cantElementos), arrayNodos(cantNodos)
        arrayElementos = vectorElementos
        arrayNodos = vectorNodos
        ReDim K(2 * cantNodos, 2 * cantNodos)
        ConstruirMatrizRigidezGlobal()


    End Sub

    'Metodos de la Clase
    Private Sub ConstruirMatrizRigidezGlobal()
        Dim nodoInicial As Integer, nodoFinal As Integer
        Dim kg(4, 4) As Double
        For i = 1 To cantElementos
            nodoInicial = arrayElementos(i).Ni.id_nodo
            nodoFinal = arrayElementos(i).Nj.id_nodo
            kg = arrayElementos(i).KG
            'Primera Fila
            K(2 * nodoInicial - 1, 2 * nodoInicial - 1) += kg(1, 1)
            K(2 * nodoInicial - 1, 2 * nodoInicial) += kg(1, 2)
            K(2 * nodoInicial - 1, 2 * nodoFinal - 1) += kg(1, 3)
            K(2 * nodoInicial - 1, 2 * nodoFinal) += kg(1, 4)
            'Fila 2
            K(2 * nodoInicial, 2 * nodoInicial - 1) += kg(2, 1)
            K(2 * nodoInicial, 2 * nodoInicial) += kg(2, 2)
            K(2 * nodoInicial, 2 * nodoFinal - 1) += kg(2, 3)
            K(2 * nodoInicial, 2 * nodoFinal) += kg(2, 4)
            'Fila 3
            K(2 * nodoFinal - 1, 2 * nodoInicial - 1) += kg(3, 1)
            K(2 * nodoFinal - 1, 2 * nodoInicial) += kg(3, 2)
            K(2 * nodoFinal - 1, 2 * nodoFinal - 1) += kg(3, 3)
            K(2 * nodoFinal - 1, 2 * nodoFinal) += kg(3, 4)
            'Fila 4
            K(2 * nodoFinal, 2 * nodoInicial - 1) += kg(4, 1)
            K(2 * nodoFinal, 2 * nodoInicial) += kg(4, 2)
            K(2 * nodoFinal, 2 * nodoFinal - 1) += kg(4, 3)
            K(2 * nodoFinal, 2 * nodoFinal) += kg(4, 4)
        Next
    End Sub


End Class
