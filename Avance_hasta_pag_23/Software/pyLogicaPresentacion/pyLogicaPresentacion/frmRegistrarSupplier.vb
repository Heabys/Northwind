Imports ClassLibrary1
Imports pyLogicaNegocio
Public Class frmRegistrarSupplier
    Private Sub cb_Nuevo_Click(sender As Object, e As EventArgs) Handles cb_Nuevo.Click
        txt_SupplierID.Clear()
        txt_CompanyName.Clear()
        txt_ContactName.Clear()
        txt_ContactTitle.Clear()
        txt_Address.Clear()
        txt_City.Clear()
        txt_Region.Clear()
        txt_PostalCode.Clear()
        txt_Country.Clear()
        txt_Phone.Clear()
        txt_Fax.Clear()
        txt_HomePage.Clear()
    End Sub

    Private Sub cb_Guardar_Click(sender As Object, e As EventArgs) Handles cb_Guardar.Click
        Dim n As nSupplier
        Dim x As eSupplier
        Try
            n = New nSupplier()
            x = New eSupplier()
            x.CompanyName = txt_CompanyName.Text
            x.ContactName = txt_ContactName.Text
            x.ContactTitle = txt_ContactTitle.Text
            x.Address = txt_Address.Text
            x.City = txt_City.Text
            x.Region = txt_Region.Text
            x.PostalCode = txt_PostalCode.Text
            x.Country = txt_Country.Text
            x.Phone = txt_Phone.Text
            x.Fax = txt_Fax.Text
            x.HomePage = txt_HomePage.Text
            If txt_SupplierID.Text <> "" Then
                x.SupplierID = CInt(txt_SupplierID.Text)
            Else
                x.SupplierID = -1
            End If
            n.Guardar(x)
            MsgBox("Se guardo correctamente", MsgBoxStyle.Information, Me.Text)
            txt_SupplierID.Text = x.SupplierID.ToString()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, Me.Text)
        Finally
            n = Nothing
            x = Nothing
        End Try
    End Sub

    Private Sub cb_Buscar_Click(sender As Object, e As EventArgs) Handles cb_Buscar.Click
        Dim n As nSupplier
        Dim x As eSupplier
        Try
            If txt_CompanyName.Text <> "" Then
                n = New nSupplier
                x = New eSupplier
                x.CompanyName = txt_CompanyName.Text.Trim()
                n.Buscar(x)
                If x.SupplierID >= 1 Then
                    MsgBox("Categoria encontrada", MsgBoxStyle.Information, Me.Text)
                    txt_CompanyName.Text = x.CompanyName.ToString()
                    txt_ContactName.Text = x.ContactName
                    txt_ContactTitle.Text = x.ContactTitle
                    txt_Address.Text = x.Address
                    txt_City.Text = x.City
                    txt_Region.Text = x.Region
                    txt_PostalCode.Text = x.PostalCode
                    txt_Country.Text = x.Country
                    txt_Phone.Text = x.Phone
                    txt_Fax.Text = x.Fax
                    txt_HomePage.Text = x.HomePage
                Else
                    MsgBox("Proveedor no encontrado!", MsgBoxStyle.Information, Me.Text)
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
        Dim n As nSupplier
        Dim x As eSupplier
        Try
            If txt_SupplierID.Text <> "" Then
                n = New nSupplier
                x = New eSupplier
                x.SupplierID = CInt(txt_SupplierID.Text)
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
    Private Sub frmRegistrarSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class