Imports Microsoft.VisualBasic
Imports pyLogicaEntidad
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Public Class dEmployee
    Public Function Elaborar_ReporteEmpleados() As List(Of eRep_ReporteEmpleados)
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim rtn As List(Of eRep_ReporteEmpleados)
        Dim Reg As SqlDataReader
        Dim x As eRep_ReporteEmpleados

        CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()
        CMD = New SqlCommand
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.CommandText = "Employees_ReporteEmpleados"
        Reg = CMD.ExecuteReader(CommandBehavior.CloseConnection)
        rtn = New List(Of eRep_ReporteEmpleados)
        While (Reg.Read())
            x = New eRep_ReporteEmpleados()
            x.EmployeeID = Reg.GetInt32(0)
            x.Nombres = Reg.GetString(1)
            x.Title = Reg.GetString(2)
            x.Antiguedad = Reg.GetInt32(3)
            x.Addreess = Reg.GetString(4)
            rtn.Add(x)
        End While
        Reg.Close()
        CN.Dispose()
        CMD.Dispose()
        Return (rtn)
    End Function
End Class
