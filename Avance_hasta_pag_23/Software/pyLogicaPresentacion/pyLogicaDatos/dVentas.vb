Imports ClassLibrary1
Imports System.Data.SqlClient
Imports System.Data.SqlDbType

Public Class dVentas

    Public Function Elaborar_ReporteVentas() As List(Of eRep_ReporteVentas)
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim rtn As List(Of eRep_ReporteVentas)
        Dim Reg As SqlDataReader
        Dim x As eRep_ReporteVentas

        CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()
        CMD = New SqlCommand
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.CommandText = "Categories_ReporteVentas"
        Reg = CMD.ExecuteReader(CommandBehavior.CloseConnection)
        rtn = New List(Of eRep_ReporteVentas)
        While (Reg.Read())
            x = New eRep_ReporteVentas()
            x.CategoryID = Reg.GetInt32(0)
            x.CategoryName = Reg.GetString(1)
            x.Cantidad = Reg.GetInt32(2)
            x.Venta = Reg.GetDouble(3)
        End While
        Reg.Close()
        CN.Dispose()
        CMD.Dispose()
        Return (rtn)
    End Function
End Class
