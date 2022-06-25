Public Class Cercha
    Public cantElementos As Integer, arrayElementos() As Elemento, cantNodos As Integer, arrayNodos() As Nodo, arrayCargas() As Carga, arrayRestricciones() As Restriccion
    Public K(,) As Double, P() As Double, D() As Object, F() As Object

    Public Sub New(vectorNodos() As Nodo, vectorElementos() As Elemento, vectorCargas() As Carga, vectorRestricciones() As Restriccion)
        'Constructor de la clase
        cantNodos = vectorNodos.Length - 1
        cantElementos = vectorElementos.Length - 1
        ReDim arrayElementos(cantElementos), arrayNodos(cantNodos), arrayCargas(cantNodos), arrayRestricciones(2 * cantNodos)
        arrayElementos = vectorElementos
        arrayNodos = vectorNodos
        arrayCargas = vectorCargas
        arrayRestricciones = vectorRestricciones
        ReDim K(2 * cantNodos, 2 * cantNodos), P(2 * cantNodos), D(2 * cantNodos), F(2 * cantNodos)
        ConstruirMatrizRigidezGlobal() '{K}
        ConstruirVectorCargas() '{P}
        ConstruirVectorDesplazamientos() '{D} y {F}



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

    Public Sub ConstruirVectorCargas()
        Dim idJoint As Integer
        Dim Px As Double, Py As Double
        For i = 1 To cantNodos
            idJoint = arrayCargas(i).id_nodo
            Px = arrayCargas(i).Px
            Py = arrayCargas(i).Py
            P(2 * idJoint - 1) = Px
            P(2 * idJoint) = Py
        Next

    End Sub

    Public Sub ConstruirVectorDesplazamientos()
        For i = 1 To 2 * cantNodos
            If arrayRestricciones(i).tipoRestriccion = True Then
                D(i) = 0
                If (-1) ^ i < 0 Then
                    F(i) = "Rx" + Str(arrayRestricciones(i).idNodo)
                Else
                    F(i) = "Ry" + Str(arrayRestricciones(i).idNodo)
                End If
            Else
                'No hay Restriccion en el grado de libertad
                F(i) = 0
                If (-1) ^ i < 0 Then
                    'Grado de Libertad en X
                    D(i) = "U" + Str(arrayRestricciones(i).idNodo)
                Else
                    'Grado de Libertad en Y
                    D(i) = "V" + Str(arrayRestricciones(i).idNodo)
                End If

            End If
        Next
    End Sub




End Class
