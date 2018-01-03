Public Class frmPrincipal
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        Dim form As frmRegistrarShipper

        form = New frmRegistrarShipper
        form.MdiParent = Me
        form.Show()

    End Sub
End Class