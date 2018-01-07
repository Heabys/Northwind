<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarShipper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrarShipper))
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_Nuevo = New System.Windows.Forms.Button()
        Me.cb_Buscar = New System.Windows.Forms.Button()
        Me.cb_Guardar = New System.Windows.Forms.Button()
        Me.cb_Eliminar = New System.Windows.Forms.Button()
        Me.txt_ShipperID = New System.Windows.Forms.TextBox()
        Me.txt_CompanyName = New System.Windows.Forms.TextBox()
        Me.txt_Phone = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Shipper ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Company Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone"
        '
        'cb_Nuevo
        '
        Me.cb_Nuevo.Location = New System.Drawing.Point(67, 194)
        Me.cb_Nuevo.Name = "cb_Nuevo"
        Me.cb_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cb_Nuevo.TabIndex = 3
        Me.cb_Nuevo.Text = "Nuevo"
        Me.cb_Nuevo.UseVisualStyleBackColor = True
        '
        'cb_Buscar
        '
        Me.cb_Buscar.Location = New System.Drawing.Point(186, 194)
        Me.cb_Buscar.Name = "cb_Buscar"
        Me.cb_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.cb_Buscar.TabIndex = 4
        Me.cb_Buscar.Text = "Buscar"
        Me.cb_Buscar.UseVisualStyleBackColor = True
        '
        'cb_Guardar
        '
        Me.cb_Guardar.Location = New System.Drawing.Point(311, 194)
        Me.cb_Guardar.Name = "cb_Guardar"
        Me.cb_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.cb_Guardar.TabIndex = 5
        Me.cb_Guardar.Text = "Guardar"
        Me.cb_Guardar.UseVisualStyleBackColor = True
        '
        'cb_Eliminar
        '
        Me.cb_Eliminar.Location = New System.Drawing.Point(435, 194)
        Me.cb_Eliminar.Name = "cb_Eliminar"
        Me.cb_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.cb_Eliminar.TabIndex = 6
        Me.cb_Eliminar.Text = "Eliminar"
        Me.cb_Eliminar.UseVisualStyleBackColor = True
        '
        'txt_ShipperID
        '
        Me.txt_ShipperID.Enabled = False
        Me.txt_ShipperID.Location = New System.Drawing.Point(162, 26)
        Me.txt_ShipperID.Name = "txt_ShipperID"
        Me.txt_ShipperID.Size = New System.Drawing.Size(100, 20)
        Me.txt_ShipperID.TabIndex = 7
        '
        'txt_CompanyName
        '
        Me.txt_CompanyName.Location = New System.Drawing.Point(162, 75)
        Me.txt_CompanyName.Name = "txt_CompanyName"
        Me.txt_CompanyName.Size = New System.Drawing.Size(348, 20)
        Me.txt_CompanyName.TabIndex = 8
        '
        'txt_Phone
        '
        Me.txt_Phone.Location = New System.Drawing.Point(162, 130)
        Me.txt_Phone.Name = "txt_Phone"
        Me.txt_Phone.Size = New System.Drawing.Size(100, 20)
        Me.txt_Phone.TabIndex = 9
        '
        'frmRegistrarShipper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 251)
        Me.Controls.Add(Me.txt_Phone)
        Me.Controls.Add(Me.txt_CompanyName)
        Me.Controls.Add(Me.txt_ShipperID)
        Me.Controls.Add(Me.cb_Eliminar)
        Me.Controls.Add(Me.cb_Guardar)
        Me.Controls.Add(Me.cb_Buscar)
        Me.Controls.Add(Me.cb_Nuevo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRegistrarShipper"
        Me.Text = "Registrar Shipper"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_Nuevo As Button
    Friend WithEvents cb_Buscar As Button
    Friend WithEvents cb_Guardar As Button
    Friend WithEvents cb_Eliminar As Button
    Friend WithEvents txt_ShipperID As TextBox
    Friend WithEvents txt_CompanyName As TextBox
    Friend WithEvents txt_Phone As TextBox
End Class
