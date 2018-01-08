Imports pyLogicaEntidad
Imports pyLogicaDatos
Public Class nProduct
    Public Sub Guardar(ByRef x As eProduct)
        Dim d As dProduct
        d = New dProduct()
        If x.ProductID <= 0 Then
            d.Insertar(x)
        Else
            d.Actualizar(x)
        End If
        d = Nothing
    End Sub


    Public Sub Eliminar(ByRef x As eProduct)
        Dim d As dProduct
        d = New dProduct()
        If x.ProductID > 0 Then
            d.Eliminar(x)
        End If
        d = Nothing
    End Sub

    Public Function Listar() As List(Of eProduct)
        Dim d As dProduct
        Dim rtn As List(Of eProduct)
        d = New dProduct()
        rtn = d.Listar()
        d = Nothing
        Return rtn
    End Function

    Public Sub Buscar(ByRef x As eProduct)
        Dim d As dProduct
        d = New dProduct()
        d.Buscar(x)
        d = Nothing
    End Sub
End Class
