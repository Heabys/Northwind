Imports ClassLibrary1
Imports pyLogicaNegocio
Imports System.IO
Public Class frmRegistrarCategory
    Private Sub cb_Nuevo_Click(sender As Object, e As EventArgs) Handles cb_Nuevo.Click
        txt_CategoryID.Clear()
        txt_CategoryName.Clear()
        txt_Descripcion.Clear()
        pb_Imagen.ResetText()
    End Sub

    Private Sub cb_CambiarImagen_Click(sender As Object, e As EventArgs) Handles cb_CambiarImagen.Click
        Dim file As OpenFileDialog = New OpenFileDialog()
        file.Filter = "Archivo IPG|*.jpg"
        If (file.ShowDialog() = DialogResult.OK) Then
            pb_Imagen.Image = Image.FromFile(file.FileName)
        End If
    End Sub

    Private Sub cb_Guardar_Click(sender As Object, e As EventArgs) Handles cb_Guardar.Click
        Dim n As nCategory
        Dim x As eCategory
        Try
            n = New nCategory()
            x = New eCategory()
            x.CategoryName = txt_CategoryName.Text
            x.Description = txt_Descripcion.Text
            x.PictureJPG = pb_Imagen.Image
            If txt_CategoryID.Text <> "" Then
                x.CategoryID = CInt(txt_CategoryID.Text)
            Else
                x.CategoryID = -1
            End If
            n.Guardar(x)
            MsgBox("Se guardo correctamente", MsgBoxStyle.Information, Me.Text)
            txt_CategoryID.Text = x.CategoryID.ToString()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, Me.Text)
        Finally
            n = Nothing
            x = Nothing
        End Try
    End Sub

    Private Sub cb_Eliminar_Click(sender As Object, e As EventArgs) Handles cb_Eliminar.Click
        Dim n As nCategory
        Dim x As eCategory
        Try

            If txt_CategoryID.Text <> "" Then
                n = New nCategory
                x = New eCategory
                x.CategoryID = CInt(txt_CategoryID.Text)
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

    Sub cb_Buscar_Click(sender As Object, e As EventArgs) Handles cb_Buscar.Click
        Dim n As nCategory
        Dim x As eCategory
        Try
            If txt_CategoryName.Text <> "" Then
                n = New nCategory
                x = New eCategory
                x.CategoryName = txt_CategoryName.Text.Trim()
                n.Buscar(x)
                If x.CategoryID >= 1 Then
                    MsgBox("Categoria encontrada", MsgBoxStyle.Information, Me.Text)
                    txt_CategoryID.Text = x.CategoryID.ToString()
                    txt_Descripcion.Text = x.Description
                    pb_Imagen.Image = x.PictureJPG
                Else
                    MsgBox("Categoria no encontrada", MsgBoxStyle.Information, Me.Text)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, Me.Text)
        Finally
            n = Nothing
            x = Nothing
        End Try
    End Sub

    Private Sub frmRegistrarCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class