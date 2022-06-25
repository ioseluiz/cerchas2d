Public Class Elemento
    Public id As Integer, Ni As Nodo, Nj As Nodo, ar As Double, modE As Double
    Dim longitud As Double, coseno As Double, seno As Double
    Public KL(4, 4) As Double, T(4, 4) As Double, TT(4, 4) As Double, KG(4, 4) As Double


    Public Sub New(ByVal elem_id As Integer, ByVal nodoInicial As Nodo, ByVal nodoFinal As Nodo, area As Double, moduElast As Double)

        'Constructor
        id = elem_id
        Ni = nodoInicial
        Nj = nodoFinal
        ar = area
        modE = moduElast
        calcular_longitud()
        calcular_coseno()
        calcular_seno()
        ConstruirMatrizRigidezLocal()
        ConstruirMatrizTransformacion()
        ConstruirMatrizTransformacionTranspuesta()
        KG = MMultMatrices(MMultMatrices(TT, KL), T)
        'Imprimir KG
        Console.WriteLine("Elemento " + Str(id))
        For i = 1 To 4
            Console.WriteLine("FILA " + Str(i))
            For j = 1 To 4
                Console.WriteLine(Str(KG(i, j)))
            Next
        Next


    End Sub

    Public Sub calcular_longitud()
        longitud = ((Me.Nj.x - Me.Ni.x) ^ 2 + (Me.Nj.y - Me.Ni.y) ^ 2) ^ 0.5

    End Sub
    Public Sub calcular_coseno()
        coseno = (Me.Nj.x - Me.Ni.x) / longitud
    End Sub
    Public Sub calcular_seno()
        seno = (Me.Nj.y - Me.Ni.y) / longitud
    End Sub
    Public Sub ConstruirMatrizRigidezLocal()
        'Inicializar con ceros la matriz
        For i = 1 To 4
            For j = 1 To 4
                KL(i, j) = 0
            Next
        Next
        'Fila 1
        KL(1, 1) = modE * ar / longitud
        KL(1, 3) = -modE * ar / longitud
        'Fila 3
        KL(3, 1) = -modE * ar / longitud
        KL(3, 3) = modE * ar / longitud

    End Sub

    Public Sub ConstruirMatrizTransformacion()
        'Inicializar la Matriz con ceros
        For i = 1 To 4
            For j = 1 To 4
                T(i, j) = 0
            Next
        Next
        'Fila 1
        T(1, 1) = Me.coseno
        T(1, 2) = Me.seno
        'Fila 2
        T(2, 1) = -Me.seno
        T(2, 2) = Me.coseno
        'Fila 3
        T(3, 3) = Me.coseno
        T(3, 4) = Me.seno
        'Fila 4
        T(4, 3) = -Me.seno
        T(4, 4) = Me.coseno
    End Sub

    Public Sub ConstruirMatrizTransformacionTranspuesta()
        For i = 1 To 4
            For j = 1 To 4
                TT(i, j) = 0
            Next
        Next
        'Fila 1
        TT(1, 1) = Me.coseno
        TT(1, 2) = -Me.seno
        'Fila 2
        TT(2, 1) = Me.seno
        TT(2, 2) = Me.coseno
        'Fila 3
        TT(3, 3) = Me.coseno
        TT(3, 4) = -Me.seno
        'Fila 4
        TT(4, 3) = Me.seno
        TT(4, 4) = Me.coseno

    End Sub

    Public Sub ConstruirMatrizRigidezGlobal()

    End Sub

    Public Function MMultMatrices(M1(,) As Double, M2(,) As Double) As Double(,)
        Dim Resultado As Double(,)
        ReDim Resultado(M1.GetLength(0) - 1, M2.GetLength(1) - 1)
        For h = 1 To M1.GetLength(0) - 1
            For j = 1 To M2.GetLength(0) - 1
                For k = 1 To M2.GetLength(1) - 1
                    Resultado(h, j) += M1(h, k) * M2(k, j)
                Next

            Next
        Next

        Return Resultado

    End Function






End Class
