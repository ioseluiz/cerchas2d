Public Class Cercha
    Public cantElementos As Integer, arrayElementos() As Elemento, cantNodos As Integer, arrayNodos() As Nodo, arrayCargas() As Carga, arrayRestricciones() As Restriccion
    Public K(,) As Double, P() As Double, D() As Object, F() As Object, SP() As Double, DespApoyos() As Double
    Public KFF(,) As Double, PF() As Double, KFS(,) As Double, KSF(,) As Double, KSS(,) As Double, PS() As Double, DS() As Double, SPF() As Double, SPS() As Double
    Public FC() As Double, MatA(,) As Double, HF() As Double, FD() As Double, FE() As Double, FS() As Double
    Public incognitasDesp As Integer, incognitasFuerza As Integer
    Public Q() As Double, Solucion As String, DesplazamientosCalculados() As String, ReaccionesCalculadas() As String, FuerzasInternas(,) As String
    Public Pos() As Integer, Posf() As Integer, DG() As Double, DL() As Double, FG() As Double, FL() As Double

    Public Sub New(vectorNodos() As Nodo, vectorElementos() As Elemento, vectorCargas() As Carga, vectorRestricciones() As Restriccion)
        'Constructor de la clase
        cantNodos = vectorNodos.Length - 1
        cantElementos = vectorElementos.Length - 1
        ReDim arrayElementos(cantElementos), arrayNodos(cantNodos), arrayCargas(cantNodos), arrayRestricciones(2 * cantNodos)
        arrayElementos = vectorElementos
        arrayNodos = vectorNodos
        arrayCargas = vectorCargas
        arrayRestricciones = vectorRestricciones
        ReDim K(2 * cantNodos, 2 * cantNodos), P(2 * cantNodos), D(2 * cantNodos), F(2 * cantNodos), SP(2 * cantNodos)
        ConstruirMatrizRigidezGlobal() '{K}
        Console.WriteLine("Matriz de Rigidez [K]")
        For i = 1 To 2 * cantNodos
            Console.WriteLine("FILA " + Str(i))
            For j = 1 To 2 * cantNodos
                Console.WriteLine(Str(K(i, j)))
            Next
        Next
        ConstruirVectorCargas() '{P}

        ConstruirSolucionParticular() '{SP}
        Console.WriteLine("Vector solucion particular {SP}")
        For i = 1 To 2 * cantNodos
            Console.WriteLine(CType(SP(i), String))
        Next

        ConstruirVectorDesplazamientos() '{D} y {F}
        Console.WriteLine("Vector Desplazamientos")
        For i = 1 To 2 * cantNodos
            Console.WriteLine(CType(D(i), String))
        Next

        incognitasDesp = determinarIncognitasDesp(D)
        incognitasFuerza = determinarIncognitasFuerza(D)
        ReDim Pos(incognitasDesp), Posf(incognitasFuerza)
        Pos = obtenerPosicionesIncognitasDesp(D, incognitasDesp)
        Console.WriteLine("Posiciones con incognitas en D")
        For i = 1 To incognitasDesp
            Console.WriteLine(Pos(i))
        Next
        Posf = obtenerPosicionesIncognitasFuerza(D, incognitasFuerza)
        'Subdividir la matriz de Rigidez
        ConstruirSubMatrizKFF()
        Console.WriteLine("Matriz de Rigidez [KFF]")
        For i = 1 To incognitasDesp
            Console.WriteLine("FILA " + Str(i))
            For j = 1 To incognitasDesp
                Console.WriteLine(Str(K(i, j)))
            Next
        Next
        ConstruirSubMatrizKFS()
        ConstruirSubMatrizKSF()
        ConstruirSubMatrizKSS()
        'Subdividir vector P
        ConstruirSubVectorPF()
        ConstruirSubVectorPS()
        'Subdividir vector {SP}
        ConstruirSubVectorSPF()
        ConstruirSubVectorSPS()
        'Subdividir Vector D
        ConstruirSubVectorDS()
        ReDim HF(incognitasDesp)
        HF = MultMatVec(KFS, DS)
        Console.WriteLine("HF")
        For i = 1 To incognitasDesp
            Console.WriteLine(Str(HF(i)))
        Next
        'Solucion de la ecuacion para {DF} la ecuacion: {FF} + {PF} - {SPF} = [KFF]{DF} + [KFS]{DS}
        ConstruirVectorFC()
        ReDim MatA(incognitasDesp, incognitasDesp + 1)
        MatA = ObtenerMatrizAumentada(KFF, FC, incognitasDesp)
        Console.WriteLine("Matriz Aumentada")
        For i = 1 To incognitasDesp
            Console.WriteLine("Fila " + Str(i))
            For j = 1 To incognitasDesp
                Console.WriteLine(Str(MatA(i, j)))
            Next
        Next
        ReDim Q(incognitasDesp)
        GAUSS(incognitasDesp, MatA, Q, Solucion)

        For i = 1 To incognitasDesp
            Console.WriteLine("SOLUCION = " + Solucion)
            Console.WriteLine(Q(i))
        Next

        ReDim DesplazamientosCalculados(incognitasDesp)
        DesplazamientosCalculados = ConstruccionDesplazamientosCalculados(D, Q, incognitasDesp)

        'Calcular las Reacciones, resolviendo para {FS} la ecuacion: {FS} = [KSF]{DF} + [KSS]{DS} + {SPS} - {PS}
        '{FD} = [KSF]{DF}
        '{FE} = [KSS]{DS}
        ReDim FD(incognitasFuerza), FE(incognitasFuerza)
        FD = MultMatVec(KSF, Q)
        FE = MultMatVec(KSS, DS)
        ReDim FS(incognitasFuerza)
        FS = CalcularReacciones(FD, FE, PS, SPS)

        'Imprimir las reacciones calculadas
        Console.WriteLine("Reacciones")
        For i = 1 To incognitasFuerza
            Console.WriteLine(FS(i))

        Next
        ReDim ReaccionesCalculadas(incognitasFuerza)
        ReaccionesCalculadas = ConstruccionReaccionesCalculadas(F, FS, incognitasFuerza)

        'Calcular las Fuerzas Internas de los Elementos
        CalcularFuerzasInternas()




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

    Public Sub ConstruirSolucionParticular()
        Dim idElemento As Integer, startJoint As Integer, endJoint As Integer
        For i = 1 To cantElementos
            idElemento = arrayElementos(i).id
            startJoint = arrayElementos(i).Ni.id_nodo
            endJoint = arrayElementos(i).Nj.id_nodo
            'Errores de Fabricacion
            'Nodo inicial
            'Carga de Error de Fabricacion en X
            SP(2 * startJoint - 1) += arrayElementos(i).errorFabGlobal(1)
            'Carga de Error de Fabricacion en Y
            SP(2 * startJoint) += arrayElementos(i).errorFabGlobal(2)
            'Nodo Final
            SP(2 * endJoint - 1) += arrayElementos(i).errorFabGlobal(3)
            'Carga de Error de Fabricacion en Y
            SP(2 * endJoint) += arrayElementos(i).errorFabGlobal(4)

            'Cambio de Temperatura
            'Nodo Inicial
            SP(2 * startJoint - 1) += arrayElementos(i).cambioTempGlobal(1)
            SP(2 * startJoint) += arrayElementos(i).cambioTempGlobal(2)
            'Nodo Final
            SP(2 * endJoint - 1) += arrayElementos(i).cambioTempGlobal(3)
            SP(2 * endJoint) += arrayElementos(i).cambioTempGlobal(4)


        Next
    End Sub

    Public Sub ConstruirVectorDesplazamientos()

        'Desplazamientos inducidos en apoyos
        ReDim DespApoyos(2 * cantNodos)
        Console.WriteLine("Vector desplazamientos inducidos en los apoyos")
        For i = 1 To cantNodos
            Console.WriteLine("Nudo " + CType(i, String))
            'Desplazamiento en x
            DespApoyos(2 * i - 1) = arrayNodos(i).deltax
            Console.WriteLine("X " + Str(DespApoyos(2 * i - 1)))
            'Desplazamiento en y
            DespApoyos(2 * i) = arrayNodos(i).deltay
            Console.WriteLine("Y " + Str(DespApoyos(2 * i)))
        Next


        For i = 1 To 2 * cantNodos
            If arrayRestricciones(i).tipoRestriccion = True Then
                D(i) = 0 + DespApoyos(i)
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

    Private Function determinarIncognitasDesp(ByVal VectorD() As Object) As Integer
        Dim incognitas As Integer = 0
        For i = 1 To VectorD.Length - 1
            If IsNumeric(VectorD(i)) = False Then
                incognitas += 1
            End If
        Next

        Return incognitas

    End Function

    Private Function determinarIncognitasFuerza(ByVal VectorD() As Object) As Integer
        Dim incognitas As Integer = 0
        For i = 1 To VectorD.Length - 1
            If IsNumeric(VectorD(i)) Then
                incognitas += 1
            End If
        Next

        Return incognitas
    End Function

    Private Function obtenerPosicionesIncognitasDesp(ByVal VectorD() As Object, cantIncognitas As Integer) As Integer()
        Dim IncognitasPos(cantIncognitas) As Integer
        Dim x0 As Integer = 0
        For i = 1 To VectorD.Length - 1
            If IsNumeric(VectorD(i)) = False Then
                x0 += 1
                IncognitasPos(x0) = i
            End If

        Next

        Return IncognitasPos
    End Function
    Private Function obtenerPosicionesIncognitasFuerza(ByVal VectorD() As Object, cantIncognitas As Integer) As Integer()
        Dim IncognitasPosf(cantIncognitas) As Integer
        Dim x0 As Integer = 0
        For i = 1 To VectorD.Length - 1
            If IsNumeric(VectorD(i)) Then
                x0 += 1
                IncognitasPosf(x0) = i
            End If

        Next

        Return IncognitasPosf
    End Function


    Public Sub ConstruirSubMatrizKFF()
        ReDim KFF(incognitasDesp, incognitasDesp)
        For i = 1 To incognitasDesp
            For j = 1 To incognitasDesp
                KFF(i, j) = K(Pos(i), Pos(j))
            Next
        Next

    End Sub

    Public Sub ConstruirSubMatrizKFS()
        ReDim KFS(incognitasDesp, incognitasFuerza)
        For i = 1 To incognitasDesp
            For j = 1 To incognitasFuerza
                KFS(i, j) = K(Pos(i), Posf(j))
            Next
        Next
    End Sub

    Public Sub ConstruirSubMatrizKSF()
        ReDim KSF(incognitasFuerza, incognitasDesp)
        For i = 1 To incognitasFuerza
            For j = 1 To incognitasDesp
                KSF(i, j) = K(Posf(i), Pos(j))
            Next
        Next
    End Sub

    Public Sub ConstruirSubMatrizKSS()
        ReDim KSS(incognitasFuerza, incognitasFuerza)
        For i = 1 To incognitasFuerza
            For j = 1 To incognitasFuerza
                KSS(i, j) = K(Posf(i), Posf(j))
            Next
        Next
    End Sub

    Public Sub ConstruirSubVectorPF()
        ReDim PF(incognitasDesp)
        For i = 1 To incognitasDesp
            PF(i) = P(Pos(i))
        Next

    End Sub

    Public Sub ConstruirSubVectorPS()
        ReDim PS(incognitasFuerza)
        For i = 1 To incognitasFuerza
            PS(i) = P(Posf(i))
        Next
    End Sub

    Public Sub ConstruirSubVectorSPF()
        ReDim SPF(incognitasDesp)
        For i = 1 To incognitasDesp
            SPF(i) = SP(Pos(i))
        Next
    End Sub

    Public Sub ConstruirSubVectorSPS()
        ReDim SPS(incognitasFuerza)
        For i = 1 To incognitasFuerza
            SPS(i) = SP(Posf(i))
        Next
    End Sub

    Public Sub ConstruirSubVectorDS()
        ReDim DS(incognitasFuerza)
        For i = 1 To incognitasFuerza
            DS(i) = D(Posf(i))
        Next
    End Sub

    Public Sub ConstruirVectorFC()
        ReDim FC(incognitasDesp)
        For i = 1 To incognitasDesp
            FC(i) = PF(i) - HF(i) - SPF(i)
        Next
    End Sub

    Public Function CalcularReacciones(VectorFD() As Double, VectorFE() As Double, VectorPS() As Double, VectorSPS() As Double) As Double()
        Dim Resultado(VectorFD.GetLength(0) - 1) As Double
        For i = 1 To VectorFD.GetLength(0) - 1
            Resultado(i) = VectorFD(i) + VectorFE(i) - VectorPS(i) + VectorSPS(i)
        Next
        Return Resultado

    End Function



    Public Function ObtenerMatrizAumentada(ByVal M1(,) As Double, V1() As Double, incognitas As Integer) As Double(,)
        Dim AA(incognitas, incognitas + 1) As Double
        Console.WriteLine("METODO OBTENER MATRIZ AUMENTADA")
        For i = 1 To incognitas
            Console.WriteLine("fila " + Str(i))
            For j = 1 To incognitas
                Console.WriteLine(Str(M1(i, j)))
                AA(i, j) = M1(i, j)
            Next
            AA(i, incognitas + 1) = V1(i)
        Next
        Return AA
    End Function


    Sub GAUSS(n As Integer, ByVal a(,) As Double, ByVal xxx() As Double, solucion As String)
        Dim K As Integer, j As Integer, i As Integer, M As Integer, L As Integer
        Dim JK As Integer, DIV As Double, MAX As Double, TEMP As Double
        Dim S As Double
        Console.WriteLine("GAUSS")
        Console.WriteLine("Matriz Aumentada")
        For i = 1 To n
            For j = 1 To n + 1
                Console.WriteLine(Str(a(i, j)))
            Next
        Next

        '********CICLO DE ELIMINACION********************************************
        For K = 1 To n - 1
            JK = 0
            MAX = Math.Abs(a(K, K))
            'Ciclo para buscar el mayor elemento por debajo del elemento pivote
            For M = K + 1 To n
                If Math.Abs(a(M, K)) > MAX Then
                    MAX = Math.Abs(a(M, K))
                    JK = 1
                    L = M
                End If
            Next
            'Si hay un mayor elemento por debajo del pivote se realiza un intercambio de filas
            If JK = 1 Then
                For M = K To n + 1
                    TEMP = a(K, M)
                    a(K, M) = a(L, M)
                    a(L, M) = TEMP
                Next
            End If
            'Verificar si el sistema tiene solucion
            If a(K, K) = 0 Then
                MsgBox("EL SISTEMA TIENE INFINITAS SOLUCIONES")
                solucion = "NO"
                Exit Sub
            End If
            For i = K + 1 To n
                DIV = a(i, K) / a(K, K)
                a(i, K) = 0
                For j = K + 1 To n + 1
                    a(i, j) = a(i, j) - DIV * a(K, j)
                Next
            Next
        Next
        'Verificar si el sistema tiene solucion
        If (a(n, n) = 0) And (a(n, n + 1) <> 0) Then
            MsgBox("EL SISTEMA NO TIENE SOLUCION")
            solucion = "NO"
            Exit Sub
        End If
        'Verificar si el sistema tiene solucion
        If (a(n, n) = 0) And (a(n, n + 1) <> 0) Then
            MsgBox("EL SISTEMA TIENE INFINTAS SOLUCIONES")
            solucion = "NO"
            Exit Sub
        End If
        'ReDim xxx(n)
        solucion = "SI"
        Console.WriteLine(solucion)
        'Sustitucion hacia atras
        xxx(n) = a(n, n + 1) / a(n, n)
        For i = n - 1 To 1 Step -1
            S = 0
            For j = i + 1 To n
                S += a(i, j) * xxx(j)
            Next
            xxx(i) = (a(i, n + 1) - S) / a(i, i)
            Console.WriteLine("xxx(" + Str(i) + ")= " + Str(xxx(i)))
        Next



    End Sub

    Public Function ConstruccionDesplazamientosCalculados(ByVal VectorD() As Object, ByVal VectorQ() As Double, ByVal cantidad As Integer) As String()
        Dim VectorResultados(cantidad) As String
        For i = 1 To cantidad
            VectorResultados(i) = CType(VectorD(Pos(i)), String) + " = " + CType(Math.Round(VectorQ(i), 5), String)
        Next
        Return VectorResultados
    End Function

    Public Function ConstruccionReaccionesCalculadas(ByVal VectorF() As Object, ByVal VectorFS() As Double, ByVal cantidad As Integer) As String()
        Dim VectorResultados(cantidad) As String
        For i = 1 To cantidad
            VectorResultados(i) = CType(VectorF(Posf(i)), String) + " = " + CType(Math.Round(VectorFS(i), 2), String)
        Next
        Return VectorResultados
    End Function

    Public Function GetDesplazamientosCalculados() As String()
        Return DesplazamientosCalculados
    End Function

    Public Function GetReaccionesCalculadas() As String()
        Return ReaccionesCalculadas
    End Function

    Public Function GetCantIncognitasDesp() As Integer
        Return incognitasDesp
    End Function

    Public Function GetCantIncognitasFuerza() As Integer
        Return incognitasFuerza
    End Function

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

    Public Sub CalcularFuerzasInternas()
        ReDim FuerzasInternas(cantElementos, 4)

        'Reemplazar DF en {D}
        For i = 1 To incognitasDesp
            D(Pos(i)) = Q(i)
        Next

        'Desplazamientos de nodos en coordenadas globales
        For i = 1 To cantElementos
            ReDim DG(4), FG(4)
            DG(1) = D(2 * arrayElementos(i).Ni.id_nodo - 1)
            DG(2) = D(2 * arrayElementos(i).Ni.id_nodo)
            DG(3) = D(2 * arrayElementos(i).Nj.id_nodo - 1)
            DG(4) = D(2 * arrayElementos(i).Nj.id_nodo)

            FG = MultMatVec(arrayElementos(i).KG, DG)

            FL = MultMatVec(arrayElementos(i).T, FG)

            For j = 1 To 4
                FuerzasInternas(i, j) = CType(Math.Round(FL(j), 2), String)
            Next

        Next


    End Sub

    Public Function GetFuerzasInternas() As String(,)
        Return FuerzasInternas
    End Function




End Class


