Imports System
Imports pyLogicaDatos
Imports pyLogicaEntidad

Public Class nCategory
    Public Sub Guardar(ByRef x As eCategory)
        Dim d As dCategory

        d = New dCategory
        If x.CategoryID <= 0 Then
            d.Insertar(x)
        Else
            d.Actualizar(x)
        End If
        d = Nothing
    End Sub

    Public Sub Eliminar(ByRef x As eCategory)
        Dim d As dCategory
        d = New dCategory
        If x.CategoryID > 0 Then
            d.Eliminar(x)
        End If
        d = Nothing
    End Sub

    Public Function Listar() As List(Of eCategory)
        Dim d As dCategory
        Dim rtn As List(Of eCategory)

        d = New dCategory()
        rtn = d.Listar()
        d = Nothing
        Return rtn
    End Function

    Public Sub Buscar(ByRef x As eCategory)
        Dim d As dCategory

        d = New dCategory
        d.Buscar(x)
        d = Nothing
    End Sub
End Class
