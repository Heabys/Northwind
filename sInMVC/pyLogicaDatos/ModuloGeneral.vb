Module ModuloGeneral
    Public Function CadenaConexionDB() As String
        Dim rtn As String

        rtn = "Data Source=(local); initial Catalog=Northwind; User ID=sa; Password=$sql2014"
        Return rtn
    End Function
End Module
