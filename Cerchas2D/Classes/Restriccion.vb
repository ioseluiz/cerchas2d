Public Class Restriccion
    Public idGDL As Integer, tipoRestriccion As Boolean, idNodo
    Public Sub New(ByVal idGradoLibertad As Integer, ByVal nodoId As Integer, ByVal tipo As Boolean)
        'Constructor
        idGDL = idGradoLibertad
        tipoRestriccion = tipo
        idNodo = nodoId

    End Sub

End Class
