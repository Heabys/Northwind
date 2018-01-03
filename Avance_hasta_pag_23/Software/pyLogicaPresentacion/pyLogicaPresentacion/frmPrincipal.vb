﻿Public Class frmPrincipal
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        Dim form As frmRegistrarShipper

        form = New frmRegistrarShipper
        form.MdiParent = Me
        form.Show()

    End Sub

    Private Sub RegistrarCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarCategoriaToolStripMenuItem.Click
        Dim form As frmRegistrarShipper
        form = New frmRegistrarShipper
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RegistrarShipperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarShipperToolStripMenuItem.Click
        Dim form As frmRegistrarCategory
        form = New frmRegistrarCategory
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub RegistrarProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarProveedorToolStripMenuItem.Click
        Dim form As frmRegistrarSupplier
        form = New frmRegistrarSupplier
        form.MdiParent = Me
        form.Show()
    End Sub
End Class