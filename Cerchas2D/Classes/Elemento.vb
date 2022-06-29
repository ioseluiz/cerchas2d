Public Class Elemento
    Public id As Integer, Ni As Nodo, Nj As Nodo, ar As Double, modE As Double, gammaT As Double, deltaTemp As Double, deltaFab As Double
    Dim longitud As Double, coseno As Double, seno As Double
    Public KL(4, 4) As Double, T(4, 4) As Double, TT(4, 4) As Double, KG(4, 4) As Double, q0() As Double, errorFabGlobal(4) As Double, qT() As Double, cambioTempGlobal(4) As Double


    Public Sub New(ByVal elem_id As Integer, ByVal nodoInicial As Nodo, ByVal nodoFinal As Nodo, area As Double, moduElast As Double, gamma As Double, tempDelta As Double, fabDelta As Double)

        'Constructor
        id = elem_id
        Ni = nodoInicial
        Nj = nodoFinal
        ar = area
        modE = moduElast
        gammaT = gamma
        deltaTemp = tempDelta
        deltaFab = fabDelta
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

        ConstruirVectorErrorFabLocal()
        errorFabGlobal = MultMatVec(TT, q0)
        ConstruirVectorEfectosTemp()

        cambioTempGlobal = MultMatVec(TT, qT)
        Console.WriteLine("elemento no. " + Str(id))

        Console.WriteLine("Vector Efectos de Temperatura coordenadas globales")
        For i = 1 To 4
            Console.WriteLine(Str(cambioTempGlobal(i)))
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



    Public Sub ConstruirVectorEfectosTemp()
        ReDim qT(4)
        qT(1) = gammaT * deltaTemp * ar * modE
        qT(2) = 0
        qT(3) = -gammaT * deltaTemp * ar * modE
        qT(4) = 0
    End Sub

    Public Sub ConstruirVectorErrorFabLocal()
        ReDim q0(4)
        q0(1) = modE * ar * deltaFab / longitud
        q0(2) = 0
        q0(3) = -modE * ar * deltaFab / longitud
        q0(4) = 0


    End Sub


    Public Function MultMatVec(ByVal M1(,) As Double, ByVal V1() As Double) As Double()
        Dim Resultado(M1.GetLength(0) - 1) As Double
        Dim suma As Double
        For i = 1 To M1.GetLength(0) - 1
            suma = 0
            For j = 1 To V1.GetLength(0) - 1
                suma += M1(i, j) * V1(j)
            Next
            Resultado(i) = suma
        Next
        Return Resultado
    End Function



End Class
