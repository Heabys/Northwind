Imports Microsoft.VisualBasic
Imports ClassLibrary1
Imports pyLogicaDatos
Public Class nEmployee
    Public Function Elaborar_ReporteEmpleados() As List(Of eRep_ReporteEmpleados)
        Dim d As dEmployee
        Dim rtn As List(Of eRep_ReporteEmpleados)
        d = New dEmployee()
        rtn = d.Elaborar_ReporteEmpleados()
        d = Nothing
        Return rtn
    End Function
End Class
