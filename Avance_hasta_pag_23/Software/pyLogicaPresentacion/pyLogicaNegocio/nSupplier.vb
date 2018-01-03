Imports System
Imports pyLogicaDatos
Imports pyLogicaEntidad
Public Class nSupplier
    Public Sub Guardar(ByRef x As eSupplier)
        Dim d As dSupplier
        d = New dSupplierQ

        If x.SupplierlD <= 0 Then
            d.Insertar(x)
        Else
            d.Actualizar(x)
        End If
        d = Nothing
    End Sub

    Public Sub Eliminar(ByRef x As eSupplier)
        Dim d As dSupplier
        d = New dSupplie()
        If x.SupplierID > 0 Then
            d.Eliminar(x)
        End If
        d = Nothing
    End Sub

    Public Function Listar() As List(Of eSupplier)
        Dim d As dSupplier
        Dim rtn As List(Of eSupplier)
        d = New dSupplier()
        rtn = d.Listar()
        d = Nothing
        Return rtn
    End Function

    Public Sub Buscar(ByRef x As eSupplier)
        Dim d As dSupplier
        d = New dSupplier()
        d.Buscar(x)
        d = Nothing
    End Sub
End Class
