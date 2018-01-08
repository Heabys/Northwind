Imports System
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports pyLogicaEntidad

Public Class dShipper
    Public Sub Insertar(ByRef x As eShipper)
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim oParameter As SqlParameter

        CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()
        CMD = New SqlCommand
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.CommandText = "Shippers_Insertar"

        oParameter = CMD.Parameters.Add("@xShipperID", SqlDbType.Int)
        oParameter.Direction = ParameterDirection.Output

        oParameter = CMD.Parameters.Add("@xCompanyName", SqlDbType.NVarChar, 40)
        oParameter.Value = x.CompanyName

        oParameter = CMD.Parameters.Add("@xPhone", SqlDbType.NVarChar, 24)
        oParameter.Value = x.Phone

        CMD.ExecuteNonQuery()
        x.ShipperID = CMD.Parameters(0).Value
        CN.Close()
        CN.Dispose()
        CMD.Dispose()
    End Sub

    Public Sub Actualizar(ByRef x As eShipper)
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim oParameter As SqlParameter

        CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()
        CMD = New SqlCommand
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.CommandText = "Shippers_Actualizar"

        oParameter = CMD.Parameters.Add("@xShipperID", SqlDbType.Int)
        oParameter.Value = x.ShipperID

        oParameter = CMD.Parameters.Add("@xCompanyName", SqlDbType.NVarChar, 40)
        oParameter.Value = x.CompanyName

        oParameter = CMD.Parameters.Add("@xPhone", SqlDbType.NVarChar, 24)
        oParameter.Value = x.Phone

        CMD.ExecuteNonQuery()

        CN.Close()
        CN.Dispose()
        CMD.Dispose()
    End Sub

    Public Sub Eliminar(ByRef x As eShipper)
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim oParameter As SqlParameter

        CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()
        CMD = New SqlCommand
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.CommandText = "Shippers_Eliminar"

        oParameter = CMD.Parameters.Add("@xShipperID", SqlDbType.Int)
        oParameter.Value = x.ShipperID

        CMD.ExecuteNonQuery()
        CN.Close()
        CN.Dispose()
        CMD.Dispose()
        CMD = Nothing
        CN = Nothing
    End Sub
End Class
