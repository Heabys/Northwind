Imports pyLogicaEntidad
Imports System.Data.SqlClient
Public Class dProduct
    Public Sub Eliminar(ByRef x As eProduct)

        Dim CN As SqlConnection

        Dim CMD As SqlCommand

        Dim oParameter As SqlParameter

        CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()
        CMD = New SqlCommand
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.CommandText = "Products_Eliminar"
        oParameter = CMD.Parameters.Add("@xProductlD", SqlDbType.Int)
        oParameter.Value = x.ProductID
        CMD.ExecuteNonQuery()
        CN.Close()
        CN.Dispose()
        CMD.Dispose()
    End Sub

    Public Sub Insertar(ByRef x As eProduct)
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()
        CMD = New SqlCommand
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.CommandText = "Products_Insertar"
        CMD.Parameters.Add("@xProductID", SqlDbType.Int).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xProductName", SqlDbType.NVarChar, 40).Value = x.ProductName
        CMD.Parameters.Add("@xSupplierID", SqlDbType.Int).Value = x.SupplierID
        CMD.Parameters.Add("@xCategorylD", SqlDbType.Int).Value = x.CategoryID
        CMD.Parameters.Add("@xQuantityPerUnit", SqlDbType.NVarChar, 20).Value = x.QuantityPerUnit
        CMD.Parameters.Add("@xUnitPrice", SqlDbType.Money).Value = x.UnitPrice
        CMD.Parameters.Add("@xUnitsInStock", SqlDbType.SmallInt).Value = x.UnitsInStock
        CMD.Parameters.Add("@xUnitsOnOrder", SqlDbType.SmallInt).Value = x.UnitsOnOrder
        CMD.Parameters.Add("@xReorderLevel", SqlDbType.SmallInt).Value = x.UnitPrice
        CMD.Parameters.Add("@xDiscontinued", SqlDbType.Bit).Value = x.Discontinued
        CMD.ExecuteNonQuery()
        x.CategoryID = CMD.Parameters(0).Value
        CN.Close()
        CN.Dispose()
        CMD.Dispose()
    End Sub
    Public Sub Actualizar(ByRef x As eProduct)
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()
        CMD = New SqlCommand
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.CommandText = "Products_Actualizar”
        CMD.Parameters.Add("@xProductID", SqlDbType.Int).Value = x.ProductID
        CMD.Parameters.Add("@xProductName", SqlDbType.NVarChar, 40).Value = x.ProductName
        CMD.Parameters.Add("@xSupplierID", SqlDbType.Int).Value = x.SupplierID
        CMD.Parameters.Add("@xCategorylD", SqlDbType.Int).Value = x.CategoryID
        CMD.Parameters.Add("@xQuantityPerUnit", SqlDbType.NVarChar, 20).Value = x.QuantityPerUnit
        CMD.Parameters.Add("@xUnitPrice", SqlDbType.Money).Value = x.UnitPrice
        CMD.Parameters.Add("@xUnitsInStock", SqlDbType.SmallInt).Value = x.UnitsInStock
        CMD.Parameters.Add("@xUnitsOnOrder", SqlDbType.SmallInt).Value = x.UnitsOnOrder
        CMD.Parameters.Add("@xReorderLevel", SqlDbType.SmallInt).Value = x.UnitPrice
        CMD.Parameters.Add("@xDiscontinued", SqlDbType.Bit).Value = x.Discontinued
        CMD.ExecuteNonQuery()
        CN.Close()
        CN.Dispose()
        CMD.Dispose()
    End Sub
    Public Function Listar() As List(Of eProduct)
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim rtn As List(Of eProduct)
        Dim Reg As SqlDataReader
        Dim x As eProduct
        CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()
        CMD = New SqlCommand
        CMD.CommandType = CommandType.Text
        CMD.Connection = CN
        CMD.CommandText = "Select ProductID, ProductName from Products Order By ProductName"
        Reg = CMD.ExecuteReader(CommandBehavior.CloseConnection)
        rtn = New List(Of eProduct)
        While (Reg.Read())
            x = New eProduct()
            x.ProductID = Reg.GetInt32(0)
            x.ProductName = Reg.GetString(1)
            rtn.Add(x)
        End While
        Reg.Close()
        CN.Dispose()
        CMD.Dispose()
        Return (rtn)
    End Function
    Public Sub Buscar(ByRef x As eProduct)
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()
        CMD = New SqlCommand
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.CommandText = "Products_Buscar"
        CMD.Parameters.Add("@xProductID", SqlDbType.Int).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xProductName", SqlDbType.NVarChar, 40).Value = x.ProductName
        CMD.Parameters.Add("@xSupplierID", SqlDbType.Int).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xCategoryID", SqlDbType.Int).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xQuantityPerUnit", SqlDbType.NVarChar, 20).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xUnitPrice", SqlDbType.Money).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xUnitsInStock", SqlDbType.SmallInt).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xUnitsOnOrder", SqlDbType.SmallInt).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xReorderLever", SqlDbType.SmallInt).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xDiscontinued", SqlDbType.Bit).Direction = ParameterDirection.Output
        CMD.ExecuteNonQuery()
        x.ProductID = IIf(IsDBNull(CMD.Parameters("@xProductID").Value), -1, CMD.Parameters("(StxProductlD").Value)
        x.SupplierID = IIf(IsDBNull(CMD.Parameters("@xSupplierID").Value), -1, CMD.Parameters("@xSupplierID").Value)
        x.CategoryID = IIf(IsDBNull(CMD.Parameters("@xCategoryID").Value), -1, CMD.Parameters("@xCategoryID").Value)
        x.QuantityPerUnit = IIf(IsDBNull(CMD.Parameters("@xQuantityPerUnit").Value), -1, CMD.Parameters("@xQuantityPerUnit").Value)
        x.UnitPrice = IIf(IsDBNull(CMD.Parameters("@xUnitPrice").Value), -1, CMD.Parameters("@xUnitPrice").Value)
        x.UnitsInStock = IIf(IsDBNull(CMD.Parameters("@xUnitsInStock").Value), -1, CMD.Parameters("@xUnitsInStock").Value)
        x.UnitsOnOrder = IIf(IsDBNull(CMD.Parameters("@xUnitsOnOrder").Value), -1, CMD.Parameters("@xUnitsOnOrder").Value)
        x.ReorderLevel = IIf(IsDBNull(CMD.Parameters("@xReorderLevel").Value), -1, CMD.Parameters("@xReorderLevel").Value)
        x.Discontinued = IIf(IsDBNull(CMD.Parameters("@xDiscontinued").Value), -1, CMD.Parameters("@xDiscontinued").Value)
        CN.Close()
        CN.Dispose()
        CMD.Dispose()
    End Sub
End Class
