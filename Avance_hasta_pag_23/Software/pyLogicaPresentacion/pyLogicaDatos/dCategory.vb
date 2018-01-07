Imports System
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports ClassLibrary1.eCategory

Public Class dCategory
    Public Sub Eliminar(ByRef x As eCategory)
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim oParameter As SqlParameter

        CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()
        CMD = New SqlCommand
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.CommandText = "Categories_Eliminar"

        oParameter = CMD.Parameters.Add("(@xCategorylD", SqlDbType.Int)
        oParameter.Value = x.CategoryID
        CMD.ExecuteNonQuery()

        CN.Close()
        CN.Dispose()
        CMD.Dispose()
    End Sub

    Public Sub Insertar(ByRef x As eCategory)
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim oParameter As SqlParameter

        CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()
        CMD = New SqlCommand
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.CommandText = "Categories_Insertar"

        oParameter = CMD.Parameters.Add("@xCategorylD", SqlDbType.Int)
        oParameter.Direction = ParameterDirection.Output
        oParameter = CMD.Parameters.Add("@xCategoryName", SqlDbType.NVarChar, 15)
        oParameter.Value = x.CategoryName
        oParameter = CMD.Parameters.Add("@xDescription", SqlDbType.NText)
        oParameter.Value = x.Description
        oParameter = CMD.Parameters.Add("@xPicture", SqlDbType.Image)
        oParameter.Value = x.Picture
        CMD.ExecuteNonQuery()
        x.CategoryID = CMD.Parameters(0).Value
        CN.Close()
        CN.Dispose()
        CMD.Dispose()
    End Sub

    Public Sub Actualizar(ByRef x As eCategory)
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim oParameter As SqlParameter

        CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()
        CMD = New SqlCommand
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.CommandText = "Categories_Actualizar”

        oParameter = CMD.Parameters.Add("@xCategoryID", SqlDbType.Int)
        oParameter.Value = x.CategoryID

        oParameter = CMD.Parameters.Add("@xCategoryName", SqlDbType.NVarChar, 15)
        oParameter.Value = x.CategoryName

        oParameter = CMD.Parameters.Add("@xDescription", SqlDbType.NText)
        oParameter.Value = x.Description

        oParameter = CMD.Parameters.Add("@xPicture", SqlDbType.Image)
        oParameter.Value = x.Picture

        CMD.ExecuteNonQuery()
        CN.Close()
        CN.Dispose()
        CMD.Dispose()
    End Sub

    Public Function Listar() As List(Of eCategory)

        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim rtn As List(Of eCategory)
        Dim Reg As SqlDataReader
        Dim x As eCategory

        CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()
        CMD = New SqlCommand
        CMD.CommandType = CommandType.Text
        CMD.Connection = CN
        CMD.CommandText = "Select CategorylD, CategoryName from Categories Order By 2"
        Reg = CMD.ExecuteReader(CommandBehavior.CloseConnection)
        rtn = New List(Of eCategory)
        While (Reg.Read())
            x = New eCategory()
            x.CategoryID = Reg.GetInt32(0)
            x.CategoryName = Reg.GetString(1)
            rtn.Add(x)
        End While

        Reg.Close()
        CN.Dispose()
        CMD.Dispose()
        Return (rtn)
    End Function




    Public Sub Buscar(ByRef x As eCategory)
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim oParameter As SqlParameter

        CN = New SqlClient.SqlConnection(CadenaConexionDB())
        CN.Open()
        CMD = New SqlCommand
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.CommandText = "Categories_Buscar"

        oParameter = CMD.Parameters.Add("@xCategorylD", SqlDbType.Int)
        oParameter.Direction = ParameterDirection.Output

        oParameter = CMD.Parameters.Add("@xCategoryName", SqlDbType.NVarChar, 15)
        oParameter.Value = x.CategoryName

        oParameter = CMD.Parameters.Add("@xDescription", SqlDbType.NVarChar, 1000)
        oParameter.Direction = ParameterDirection.Output

        oParameter = CMD.Parameters.Add("@Picture", SqlDbType.VarBinary, 512002)
        'imagenes de hasta 500KB + 2 bytes de control internos 
        oParameter.Direction = ParameterDirection.Output

        CMD.ExecuteNonQuery()
        x.CategoryID = IIf(IsDBNull(CMD.Parameters("@xCategorylD").Value), -1, CMD.Parameters("@xCategoryID").Value)
        x.Description = IIf(IsDBNull(CMD.Parameters("@xDescription").Value), -1, CMD.Parameters("@xDescription").Value)
        If Not IsDBNull(CMD.Parameters("@xPicture").Value) Then
            x.Picture = CMD.Parameters("@xPicture").Value
        End If

        CN.Close()
        CN.Dispose()
        CMD.Dispose()
    End Sub
End Class
