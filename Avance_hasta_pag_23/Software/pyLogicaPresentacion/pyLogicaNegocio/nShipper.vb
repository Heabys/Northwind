Imports ClassLibrary1
Imports pyLogicaDatos

Public Class nShipper
    Public Sub Guardar(ByRef x As eShipper)
        Dim d As dShipper

        d = New dShipper
        If x.ShipperID <= 0 Then
            ' Es transportista nuevo
            d.Insertar(x)
        Else
            ' El transportista ya existe
            d.Actualizar(x)
        End If

        d = Nothing
    End Sub

    Public Sub Eliminar(ByRef x As eShipper)
        Dim d As dShipper

        d = New dShipper
        If x.ShipperID > 0 Then
            ' el transportista existe
            d.Eliminar(x)
        End If

        d = Nothing
    End Sub
End Class
