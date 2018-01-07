Imports System
Imports pyLogicaNegocio
Imports ClassLibrary1
Public Class frmRegistrarShipper
    Private Sub cb_Nuevo_Click(sender As Object, e As EventArgs) Handles cb_Nuevo.Click
        txt_ShipperID.Clear()
        txt_CompanyName.Clear()
        txt_Phone.Clear()
    End Sub

    Private Sub cb_Guardar_Click(sender As Object, e As EventArgs) Handles cb_Guardar.Click
        Dim x As eShipper
        Dim d As nShipper
        Try
            x = New eShipper
            d = New nShipper
            x.CompanyName = txt_CompanyName.Text
            x.Phone = txt_Phone.Text

            If txt_ShipperID.Text <> "" Then
                x.ShipperID = CInt(txt_ShipperID.Text)
            Else
                x.ShipperID = -1
            End If
            d.Guardar(x)
            txt_ShipperID.Text = x.ShipperID
            x = Nothing
            d = Nothing
            MsgBox("Guardo correctamente", MsgBoxStyle.Information, Me.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub cb_Eliminar_Click(sender As Object, e As EventArgs)
        Dim x As eShipper
        Dim d As nShipper

        Try
            x = New eShipper
            d = New nShipper

            If txt_ShipperID.Text <> "" Then
                x.ShipperID = CInt(txt_ShipperID.Text)
                d.Eliminar(x)
                MsgBox("Eliminacion exitosa", MsgBoxStyle.Information, Me.Text)
            Else
                MsgBox("Transportista no registrado", MsgBoxStyle.Information, Me.Text)
            End If

            x = Nothing
            d = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
End Class