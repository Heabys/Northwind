Public Class frmPrincipal
    Private Sub RegistrarShipperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarShipperToolStripMenuItem.Click
        Dim form As frmRegistrarShipper
        form = New frmRegistrarShipper
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub RegistrarCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarCategoriaToolStripMenuItem.Click
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