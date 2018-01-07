<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarShipperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip2.TabIndex = 3
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarShipperToolStripMenuItem, Me.RegistrarCategoriaToolStripMenuItem, Me.RegistrarProveedorToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'RegistrarShipperToolStripMenuItem
        '
        Me.RegistrarShipperToolStripMenuItem.Name = "RegistrarShipperToolStripMenuItem"
        Me.RegistrarShipperToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RegistrarShipperToolStripMenuItem.Text = "Registrar Shipper "
        '
        'RegistrarCategoriaToolStripMenuItem
        '
        Me.RegistrarCategoriaToolStripMenuItem.Name = "RegistrarCategoriaToolStripMenuItem"
        Me.RegistrarCategoriaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RegistrarCategoriaToolStripMenuItem.Text = "Registrar Categoria"
        '
        'RegistrarProveedorToolStripMenuItem
        '
        Me.RegistrarProveedorToolStripMenuItem.Name = "RegistrarProveedorToolStripMenuItem"
        Me.RegistrarProveedorToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RegistrarProveedorToolStripMenuItem.Text = "Registrar Proveedor"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MenuStrip2)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.Text = "Sistema Northwind"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarShipperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarCategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarProveedorToolStripMenuItem As ToolStripMenuItem
End Class
