Public Class Nodo
    Public id_nodo As Integer, x As Double, y As Double, deltax As Double, deltay As Double
    'Constructor
    Public Sub New(ByVal joint As Integer, ByVal coor_x As Double, ByVal coor_y As Double, despx As Double, despy As Double)
        id_nodo = joint
        x = coor_x
        y = coor_y
        deltax = despx
        deltay = despy

    End Sub



End Class
