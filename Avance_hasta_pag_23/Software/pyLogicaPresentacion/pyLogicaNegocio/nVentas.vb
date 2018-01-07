Imports pyLogicaDatos
Imports ClassLibrary1
Public Class nVentas
    Public Function Elabororar_ReporteVentas() As List(Of eRep_ReporteVentas)
        Dim d As dVentas
        Dim rtn As List(Of eRep_ReporteVentas)

        d = New dVentas()
        rtn = d.Elaborar_ReporteVentas()
        d = Nothing
        Return rtn
    End Function
End Class
