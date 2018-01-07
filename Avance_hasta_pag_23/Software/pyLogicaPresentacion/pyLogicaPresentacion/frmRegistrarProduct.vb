Imports ClassLibrary1
Imports pyLogicaNegocio
Public Class frmRegistrarProduct
    Private Sub CargarCategorias()
        Dim n As nCategory
        n = New nCategory()
        cbo_CategoryID.DataSource = n.Listar()
        cbo_CategoryID.DisplayMember = "CategoryName"
        cbo_CategoryID.ValueMember = "CategoryID"
    End Sub

    Private Sub CargarProveedores()
        Dim n As nSupplier
        n = New nSupplier()
        cbo_SupplierID.DataSource = n.Listar()
        cbo_SupplierID.DisplayMember = "SupplierName"
        cbo_SupplierID.ValueMember = "SupplierID”
    End Sub
    Private Sub cb_Nuevo_Click(sender As Object, e As EventArgs) Handles cb_Nuevo.Click
        Me.txt_ProductID.Clear()
        Me.txt_ProductName.Clear()
        Me.cbo_SupplierID.SelectedIndex = -1
        Me.cbo_CategoryID.SelectedIndex = -1
        Me.txt_QuantityxUnit.Clear()
        Me.txt_UnitPrice.Clear()
        Me.txt_UnitsInStock.Clear()
        Me.txt_UnitsOnOrder.Clear()
        Me.txt_ReorderLevel.Clear()
        Me.check_Discontinued.Checked = False
    End Sub

    Private Sub cb_Guardar_Click(sender As Object, e As EventArgs) Handles cb_Guardar.Click
        Dim n As nProduct
        Dim x As eProduct
        Try
            n = New nProduct()
            x = New eProduct()
            x.ProductName = txt_ProductName.Text
            x.SupplierID = cbo_SupplierID.SelectedValue
            x.CategoryID = cbo_CategoryID.SelectedValue
            x.QuantityPerUnit = txt_QuantityxUnit.Text
            x.UnitPrice = CDbl(txt_UnitPrice.Text)
            x.UnitsInStock = CInt(txt_UnitsInStock.Text)
            x.UnitsOnOrder = txt_UnitsOnOrder.Text
            x.ReorderLevel = check_Discontinued.Checked
            If txt_ProductID.Text <> "" Then
                x.ProductID = CInt(txt_ProductID.Text)
            Else
                x.ProductID = -1
            End If
            n.Guardar(x)
            MsgBox("Se guardo correctamente", MsgBoxStyle.Information, Me.Text)
            txt_ProductID.Text = x.ProductID.ToString()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, Me.Text)
        Finally
            n = Nothing
            x = Nothing
        End Try
    End Sub

    Private Sub cb_Buscar_Click(sender As Object, e As EventArgs) Handles cb_Buscar.Click
        Dim n As nProduct
        Dim x As eProduct
        Try
            If txt_ProductName.Text <> "" Then
                n = New nProduct
                x = New eProduct
                x.ProductName = txt_ProductName.Text.Trim()
                n.Buscar(x)
                If x.SupplierID >= 1 Then
                    MsgBox("Categoria encontrada", MsgBoxStyle.Information, Me.Text)
                    txt_ProductName.Text = x.ProductName.ToString()
                    cbo_SupplierID.SelectedValue = x.SupplierID
                    cbo_CategoryID.SelectedValue = x.CategoryID
                    txt_QuantityxUnit.Text = x.QuantityPerUnit
                    txt_UnitPrice.Text = x.UnitPrice
                    txt_UnitsInStock.Text = x.UnitsInStock
                    txt_UnitsOnOrder.Text = x.UnitsOnOrder
                    txt_ReorderLevel.Text = x.ReorderLevel
                    check_Discontinued.Checked = x.Discontinued
                Else
                    MsgBox("Producto no encontrado!", MsgBoxStyle.Information, Me.Text)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, Me.Text)
        Finally
            n = Nothing
            x = Nothing
        End Try
    End Sub

    Private Sub cb_Eliminar_Click(sender As Object, e As EventArgs) Handles cb_Eliminar.Click
        Dim n As nProduct
        Dim x As eProduct
        Try
            If txt_ProductID.Text <> "" Then
                n = New nProduct
                x = New eProduct
                x.CategoryID = CInt(txt_ProductID.Text)
                n.Eliminar(x)
            End If
            MsgBox("Se elimino correctamente", MsgBoxStyle.Information, Me.Text)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, Me.Text)
        Finally
            n = Nothing
            x = Nothing
        End Try
    End Sub

    Private Sub frmRegistrarProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarCategorias()
        Me.CargarProveedores()
    End Sub
End Class