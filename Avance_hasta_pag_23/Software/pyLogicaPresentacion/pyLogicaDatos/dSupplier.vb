Imports System
Imports System.Data.SqlClient
Imports pyLogicaEntidad
Public Class dSupplier
    Public Sub Insertar(ByRef x As eSupplier)
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()
        CMD = New SqlCommand
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.CommandText = "Suppliers_Insertar"
        CMD.Parameters.Add("@xSupplierlD", SqlDbType.Int).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xCompanyName", SqlDbType.NVarChar, 40).Value = x.CompanyName
        CMD.Parameters.Add("@xContactName", SqlDbType.NVarChar, 30).Value = x.ContactName
        CMD.Parameters.Add("@xContactTitle", SqlDbType.NVarChar, 30).Value = x.ContactTitle
        CMD.Parameters.Add("@xAddress", SqlDbType.NVarChar, 60).Value = x.Address
        CMD.Parameters.Add("@xCity", SqlDbType.NVarChar, 15).Value = x.City
        CMD.Parameters.Add("@xRegion", SqlDbType.NVarChar, 15).Value = x.Region
        CMD.Parameters.Add("@xPostalCode", SqlDbType.NVarChar, 10).Value = x.PostalCode
        CMD.Parameters.Add("@xCountry", SqlDbType.NVarChar, 15).Value = x.Country
        CMD.Parameters.Add("@xPhone", SqlDbType.NVarChar, 24).Value = x.Phone
        CMD.Parameters.Add("@xFax", SqlDbType.NVarChar, 24).Value = x.Fax
        CMD.Parameters.Add("@xHomePage", SqlDbType.NText).Value = x.HomePage
        CMD.ExecuteNonQuery()
        x.SupplierlD = CMD.Parameters(0).Value
        CN.Close()
        CN.Dispose()
        CMD.Dispose()
    End Sub

    Public Sub Eliminar(ByRef x As eSupplier)
        Dim CN As SqlConnection Dim CMD As SqlCommand
		CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()
        CMD = New SqlCommand
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.CommandText = "Suppliers_Eliminar"
        CMD.Parameters.Add("@xSupplierID", SqlDbType.Int).Value = x.SupplierlD
        CMD.ExecuteNonQuery()
        CN.Close()
        CN.Dispose()
        CMD.Dispose()
    End Sub

    Public Sub Actualizar(ByRef x As eSupplier)
        Dim CN As SqlConnection
        Dim CMD As SqlCommand

        CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()

        CMD = New SqlCommand

        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN

        CMD.CommandText = "Suppliers_Actualizar”
        CMD.Parameters.Add("@xSupplierlD", SqlDbType.Int).Value = x.SupplierlD
        CMD.Parameters.Add("@xCompanyName", SqlDbType.NVarChar, 40).Value = x.CompanyName
        CMD.Parameters.Add("@xContactName", SqlDbType.NVarChar, 30).Value = x.ContactName
        CMD.Parameters.Add("@xContactTitle", SqlDbType.NVarChar, 30).Value = x.ContactTitle
        CMD.Parameters.Add("@xAddress", SqlDbType.NVarChar, 60).Value = x.Address
        CMD.Parameters.Add("@xCity", SqlDbType.NVarChar, 15).Value = x.City
        CMD.Parameters.Add("@xRegion", SqlDbType.NVarChar, 15).Value = x.Region
        CMD.Parameters.Add("@xPostalCode", SqlDbType.NVarChar, 10).Value = x.PostalCode
        CMD.Parameters.Add("@xCountry", SqlDbType.NVarChar, 15).Value = x.Country
        CMD.Parameters.Add("@xPhone", SqlDbType.NVarChar, 24).Value = x.Phone
        CMD.Parameters.Add("@xFax", SqlDbType.NVarChar, 24).Value = x.Fax
        CMD.Parameters.Add("@xHomePage", SqlDbType.NText).Value = x.HomePage
        CMD.ExecuteNonQuery()
        CN.Close()
        CN.DisposeQ
        CMD.Dispose()

    End Sub

    Public Function Listar() As List(Of eSupplier)
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim rtn As List(Of eSupplier)
        Dim Reg As SqlDataReader
        Dim x As eSupplier
        CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.OpenQ
        CMD = New SqlCommand
        CMD.CommandType = CommandType.Text
        CMD.CommandText = "Select CategoryID, CategoryName from Categories Order By 2"
        Reg = CMD.ExecuteReader(CommandBehavior.CloseConnection)
        rtn = New List(Of eSupplier)
        While (Reg.Read())
            x = New eSupplier()
            x.SupplierlD = Reg.GetInt32(0)
            x.CompanyName = Reg.GetString(1)
            x.ContactName = Reg.GetString(2)
            x.ContactTitle = Reg.GetString(3)
            x.Address = Reg.GetString(4)
            x.City = Reg.GetString(5)
            x.Region = Reg.GetString(6)
            x.PostalCode = Reg.GetString(7)
            x.Country = Reg.GetString(8)
            x.Phone = Reg.GetString(9)
            x.Fax = Reg.GetString(10)
            x.HomePage = Reg.GetString(11)
            rtn.Add(x)
        End While
        Reg.Close()
        CN.Dispose()
        CMD.Dispose()
        Return (rtn)
    End Function

    Public Sub Buscar(ByRef x As eSupplier)
        Dim CN As SqlConnection Dim CMD As SqlCommand
		CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()
        CMD = New SqlCommand
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.CommandText = "Suppliers_Buscar"
        CMD.Parameters.Add("@xSupplierID", SqlDbType.Int).Value = x.CompanyName
        CMD.Parameters.Add("@xCompanyName", SqlDbType.NVarChar, 40).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xContactName", SqlDbType.NVarChar, 30).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xContactTitle", SqlDbType.NVarChar, 30).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xAddress", SqlDbType.NVarChar, 60).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xCity", SqlDbType.NVarChar, 15).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xRegion", SqlDbType.NVarChar, 15).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xPostalCode", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xCountry", SqlDbType.NVarChar, 15).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xPhone", SqlDbType.NVarChar, 24).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xFax", SqlDbType.NVarChar, 24).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@xHomePage", SqlDbType.NText).Direction = ParameterDirection.Output
        CMD.ExecuteNonQuery()
        x.CompanyName = IIf(IsDBNull(CMD.Parameter s ("(SlxCompanyName ").Value),	CMD.Parameters("@xCompanyName").Value
		x.ContactName = IIf(IsDBNull(CMD.ParametersC'^xContactName").Value),	CMD.Parameters("@xContactName").Value)
        x.ContactTitle = IIf(IsDBNull(CMD.Parameters("@xContactTitle").Value), CMD.Parameters("@xContactTitle").Value)
        x.Address = IIf(IsDBNull(CMD.Parameters("@xAddress").Value), CMD.Parameters("@xAddress").Value)
        x.City = Ilf(IsDBNull(CMD.Parameters("@xCity").Value), CMD.Parameters("@xCity").Value)
        x.Region = IIf(IsDBNull(CMD.Parameters("@xRegion").Value), CMD.Parameters("@xRegion").Value)
        x.PostalCode = IIf(IsDBNull(CMD.Parameters("@xPostalCode").Value), CMD.Parameters("@xPostalCode").Value)
        x.Country = IIf(IsDBNull(CMD.Parameters("@xCountry").Value), CMD.Parameters("@xCountry").Value)
        x.Fax = IIf(IsDBNull(CMD.Parameters("@xFax").Value), CMD.Parameters("@xFax").Value)
        x.HomePage = IIf(IsDBNull(CMD.Parameters("@xHomePage").Value), CMD.Parameters("@xHomePage").Value)
        CN.Close()
        CN.Dispose()
        CMD.Dispose()
    End Sub
End Class
