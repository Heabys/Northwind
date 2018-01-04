<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarProduct
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
        Me.txt_ProductID = New System.Windows.Forms.TextBox()
        Me.txt_ProductName = New System.Windows.Forms.TextBox()
        Me.cbo_SupplierID = New System.Windows.Forms.ComboBox()
        Me.cbo_ProductID = New System.Windows.Forms.ComboBox()
        Me.txt_QuantityxUnit = New System.Windows.Forms.TextBox()
        Me.txt_UnitPrice = New System.Windows.Forms.TextBox()
        Me.txt_UnitsInStock = New System.Windows.Forms.TextBox()
        Me.txt_UnitsOnOrder = New System.Windows.Forms.TextBox()
        Me.txt_ReorderLevel = New System.Windows.Forms.TextBox()
        Me.check_Discontinued = New System.Windows.Forms.CheckBox()
        Me.cb_Nuevo = New System.Windows.Forms.Button()
        Me.cb_Guardar = New System.Windows.Forms.Button()
        Me.cb_Buscar = New System.Windows.Forms.Button()
        Me.cb_Eliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_ProductID
        '
        Me.txt_ProductID.Location = New System.Drawing.Point(130, 43)
        Me.txt_ProductID.Name = "txt_ProductID"
        Me.txt_ProductID.Size = New System.Drawing.Size(100, 20)
        Me.txt_ProductID.TabIndex = 0
        '
        'txt_ProductName
        '
        Me.txt_ProductName.Location = New System.Drawing.Point(130, 69)
        Me.txt_ProductName.Name = "txt_ProductName"
        Me.txt_ProductName.Size = New System.Drawing.Size(233, 20)
        Me.txt_ProductName.TabIndex = 1
        '
        'cbo_SupplierID
        '
        Me.cbo_SupplierID.FormattingEnabled = True
        Me.cbo_SupplierID.Location = New System.Drawing.Point(130, 95)
        Me.cbo_SupplierID.Name = "cbo_SupplierID"
        Me.cbo_SupplierID.Size = New System.Drawing.Size(193, 21)
        Me.cbo_SupplierID.TabIndex = 2
        '
        'cbo_ProductID
        '
        Me.cbo_ProductID.FormattingEnabled = True
        Me.cbo_ProductID.Location = New System.Drawing.Point(130, 123)
        Me.cbo_ProductID.Name = "cbo_ProductID"
        Me.cbo_ProductID.Size = New System.Drawing.Size(144, 21)
        Me.cbo_ProductID.TabIndex = 3
        '
        'txt_QuantityxUnit
        '
        Me.txt_QuantityxUnit.Location = New System.Drawing.Point(130, 151)
        Me.txt_QuantityxUnit.Name = "txt_QuantityxUnit"
        Me.txt_QuantityxUnit.Size = New System.Drawing.Size(131, 20)
        Me.txt_QuantityxUnit.TabIndex = 4
        '
        'txt_UnitPrice
        '
        Me.txt_UnitPrice.Location = New System.Drawing.Point(130, 178)
        Me.txt_UnitPrice.Name = "txt_UnitPrice"
        Me.txt_UnitPrice.Size = New System.Drawing.Size(131, 20)
        Me.txt_UnitPrice.TabIndex = 5
        '
        'txt_UnitsInStock
        '
        Me.txt_UnitsInStock.Location = New System.Drawing.Point(130, 205)
        Me.txt_UnitsInStock.Name = "txt_UnitsInStock"
        Me.txt_UnitsInStock.Size = New System.Drawing.Size(100, 20)
        Me.txt_UnitsInStock.TabIndex = 6
        '
        'txt_UnitsOnOrder
        '
        Me.txt_UnitsOnOrder.Location = New System.Drawing.Point(130, 232)
        Me.txt_UnitsOnOrder.Name = "txt_UnitsOnOrder"
        Me.txt_UnitsOnOrder.Size = New System.Drawing.Size(100, 20)
        Me.txt_UnitsOnOrder.TabIndex = 7
        '
        'txt_ReorderLevel
        '
        Me.txt_ReorderLevel.Location = New System.Drawing.Point(130, 259)
        Me.txt_ReorderLevel.Name = "txt_ReorderLevel"
        Me.txt_ReorderLevel.Size = New System.Drawing.Size(100, 20)
        Me.txt_ReorderLevel.TabIndex = 8
        '
        'check_Discontinued
        '
        Me.check_Discontinued.AutoSize = True
        Me.check_Discontinued.Location = New System.Drawing.Point(131, 293)
        Me.check_Discontinued.Name = "check_Discontinued"
        Me.check_Discontinued.Size = New System.Drawing.Size(15, 14)
        Me.check_Discontinued.TabIndex = 9
        Me.check_Discontinued.UseVisualStyleBackColor = True
        '
        'cb_Nuevo
        '
        Me.cb_Nuevo.Location = New System.Drawing.Point(56, 331)
        Me.cb_Nuevo.Name = "cb_Nuevo"
        Me.cb_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cb_Nuevo.TabIndex = 10
        Me.cb_Nuevo.Text = "Nuevo"
        Me.cb_Nuevo.UseVisualStyleBackColor = True
        '
        'cb_Guardar
        '
        Me.cb_Guardar.Location = New System.Drawing.Point(155, 331)
        Me.cb_Guardar.Name = "cb_Guardar"
        Me.cb_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.cb_Guardar.TabIndex = 11
        Me.cb_Guardar.Text = "Guardar"
        Me.cb_Guardar.UseVisualStyleBackColor = True
        '
        'cb_Buscar
        '
        Me.cb_Buscar.Location = New System.Drawing.Point(248, 331)
        Me.cb_Buscar.Name = "cb_Buscar"
        Me.cb_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.cb_Buscar.TabIndex = 12
        Me.cb_Buscar.Text = "Buscar"
        Me.cb_Buscar.UseVisualStyleBackColor = True
        '
        'cb_Eliminar
        '
        Me.cb_Eliminar.Location = New System.Drawing.Point(343, 331)
        Me.cb_Eliminar.Name = "cb_Eliminar"
        Me.cb_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.cb_Eliminar.TabIndex = 13
        Me.cb_Eliminar.Text = "Eliminar"
        Me.cb_Eliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ID Producto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Product Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Supplier:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Categoria:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Quantity x Unit:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = " Unit Price:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Units in Stock:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Units On Order:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(53, 259)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Reorder Level:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(53, 294)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Discontinued:"
        '
        'frmRegistrarProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 510)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_Eliminar)
        Me.Controls.Add(Me.cb_Buscar)
        Me.Controls.Add(Me.cb_Guardar)
        Me.Controls.Add(Me.cb_Nuevo)
        Me.Controls.Add(Me.check_Discontinued)
        Me.Controls.Add(Me.txt_ReorderLevel)
        Me.Controls.Add(Me.txt_UnitsOnOrder)
        Me.Controls.Add(Me.txt_UnitsInStock)
        Me.Controls.Add(Me.txt_UnitPrice)
        Me.Controls.Add(Me.txt_QuantityxUnit)
        Me.Controls.Add(Me.cbo_ProductID)
        Me.Controls.Add(Me.cbo_SupplierID)
        Me.Controls.Add(Me.txt_ProductName)
        Me.Controls.Add(Me.txt_ProductID)
        Me.Name = "frmRegistrarProduct"
        Me.Text = "frmRegistrarProduct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_ProductID As TextBox
    Friend WithEvents txt_ProductName As TextBox
    Friend WithEvents cbo_SupplierID As ComboBox
    Friend WithEvents cbo_ProductID As ComboBox
    Friend WithEvents txt_QuantityxUnit As TextBox
    Friend WithEvents txt_UnitPrice As TextBox
    Friend WithEvents txt_UnitsInStock As TextBox
    Friend WithEvents txt_UnitsOnOrder As TextBox
    Friend WithEvents txt_ReorderLevel As TextBox
    Friend WithEvents check_Discontinued As CheckBox
    Friend WithEvents cb_Nuevo As Button
    Friend WithEvents cb_Guardar As Button
    Friend WithEvents cb_Buscar As Button
    Friend WithEvents cb_Eliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
