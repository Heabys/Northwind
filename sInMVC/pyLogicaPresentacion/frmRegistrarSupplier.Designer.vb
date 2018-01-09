<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarSupplier
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
        Me.txt_SupplierID = New System.Windows.Forms.TextBox()
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_CompanyName = New System.Windows.Forms.TextBox()
        Me.txt_ContactName = New System.Windows.Forms.TextBox()
        Me.txt_ContactTitle = New System.Windows.Forms.TextBox()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.txt_City = New System.Windows.Forms.TextBox()
        Me.txt_Region = New System.Windows.Forms.TextBox()
        Me.txt_PostalCode = New System.Windows.Forms.TextBox()
        Me.txt_Country = New System.Windows.Forms.TextBox()
        Me.txt_Phone = New System.Windows.Forms.TextBox()
        Me.txt_Fax = New System.Windows.Forms.TextBox()
        Me.txt_HomePage = New System.Windows.Forms.TextBox()
        Me.cb_Nuevo = New System.Windows.Forms.Button()
        Me.cb_Guardar = New System.Windows.Forms.Button()
        Me.cb_Buscar = New System.Windows.Forms.Button()
        Me.cb_Eliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_SupplierID
        '
        Me.txt_SupplierID.Location = New System.Drawing.Point(157, 19)
        Me.txt_SupplierID.Name = "txt_SupplierID"
        Me.txt_SupplierID.Size = New System.Drawing.Size(154, 20)
        Me.txt_SupplierID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Proveedor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre de la Compañia:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre del Contacto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Titulo de Contacto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Direccion:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(108, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Ciudad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(107, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Region:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(78, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Codigo Postal:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(121, 235)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Pais:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(99, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Telefono:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(124, 287)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Fax:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(82, 313)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Pagina WEB:"
        '
        'txt_CompanyName
        '
        Me.txt_CompanyName.Location = New System.Drawing.Point(157, 47)
        Me.txt_CompanyName.Name = "txt_CompanyName"
        Me.txt_CompanyName.Size = New System.Drawing.Size(306, 20)
        Me.txt_CompanyName.TabIndex = 13
        '
        'txt_ContactName
        '
        Me.txt_ContactName.Location = New System.Drawing.Point(157, 73)
        Me.txt_ContactName.Name = "txt_ContactName"
        Me.txt_ContactName.Size = New System.Drawing.Size(240, 20)
        Me.txt_ContactName.TabIndex = 14
        '
        'txt_ContactTitle
        '
        Me.txt_ContactTitle.Location = New System.Drawing.Point(157, 107)
        Me.txt_ContactTitle.Name = "txt_ContactTitle"
        Me.txt_ContactTitle.Size = New System.Drawing.Size(363, 20)
        Me.txt_ContactTitle.TabIndex = 15
        '
        'txt_Address
        '
        Me.txt_Address.Location = New System.Drawing.Point(157, 134)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(416, 20)
        Me.txt_Address.TabIndex = 16
        '
        'txt_City
        '
        Me.txt_City.Location = New System.Drawing.Point(157, 161)
        Me.txt_City.Name = "txt_City"
        Me.txt_City.Size = New System.Drawing.Size(154, 20)
        Me.txt_City.TabIndex = 17
        '
        'txt_Region
        '
        Me.txt_Region.Location = New System.Drawing.Point(157, 186)
        Me.txt_Region.Name = "txt_Region"
        Me.txt_Region.Size = New System.Drawing.Size(154, 20)
        Me.txt_Region.TabIndex = 18
        '
        'txt_PostalCode
        '
        Me.txt_PostalCode.Location = New System.Drawing.Point(157, 209)
        Me.txt_PostalCode.Name = "txt_PostalCode"
        Me.txt_PostalCode.Size = New System.Drawing.Size(59, 20)
        Me.txt_PostalCode.TabIndex = 19
        '
        'txt_Country
        '
        Me.txt_Country.Location = New System.Drawing.Point(157, 232)
        Me.txt_Country.Name = "txt_Country"
        Me.txt_Country.Size = New System.Drawing.Size(219, 20)
        Me.txt_Country.TabIndex = 20
        '
        'txt_Phone
        '
        Me.txt_Phone.Location = New System.Drawing.Point(157, 258)
        Me.txt_Phone.Name = "txt_Phone"
        Me.txt_Phone.Size = New System.Drawing.Size(154, 20)
        Me.txt_Phone.TabIndex = 21
        '
        'txt_Fax
        '
        Me.txt_Fax.Location = New System.Drawing.Point(157, 284)
        Me.txt_Fax.Name = "txt_Fax"
        Me.txt_Fax.Size = New System.Drawing.Size(154, 20)
        Me.txt_Fax.TabIndex = 22
        '
        'txt_HomePage
        '
        Me.txt_HomePage.Location = New System.Drawing.Point(157, 310)
        Me.txt_HomePage.Name = "txt_HomePage"
        Me.txt_HomePage.Size = New System.Drawing.Size(416, 20)
        Me.txt_HomePage.TabIndex = 23
        '
        'cb_Nuevo
        '
        Me.cb_Nuevo.Location = New System.Drawing.Point(157, 350)
        Me.cb_Nuevo.Name = "cb_Nuevo"
        Me.cb_Nuevo.Size = New System.Drawing.Size(99, 23)
        Me.cb_Nuevo.TabIndex = 24
        Me.cb_Nuevo.Text = "Nuevo"
        Me.cb_Nuevo.UseVisualStyleBackColor = True
        '
        'cb_Guardar
        '
        Me.cb_Guardar.Location = New System.Drawing.Point(260, 350)
        Me.cb_Guardar.Name = "cb_Guardar"
        Me.cb_Guardar.Size = New System.Drawing.Size(89, 23)
        Me.cb_Guardar.TabIndex = 25
        Me.cb_Guardar.Text = "Guardar"
        Me.cb_Guardar.UseVisualStyleBackColor = True
        '
        'cb_Buscar
        '
        Me.cb_Buscar.Location = New System.Drawing.Point(355, 350)
        Me.cb_Buscar.Name = "cb_Buscar"
        Me.cb_Buscar.Size = New System.Drawing.Size(90, 23)
        Me.cb_Buscar.TabIndex = 26
        Me.cb_Buscar.Text = "Buscar"
        Me.cb_Buscar.UseVisualStyleBackColor = True
        '
        'cb_Eliminar
        '
        Me.cb_Eliminar.Location = New System.Drawing.Point(451, 350)
        Me.cb_Eliminar.Name = "cb_Eliminar"
        Me.cb_Eliminar.Size = New System.Drawing.Size(89, 23)
        Me.cb_Eliminar.TabIndex = 27
        Me.cb_Eliminar.Text = "Eliminar"
        Me.cb_Eliminar.UseVisualStyleBackColor = True
        '
        'frmRegistrarSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 385)
        Me.Controls.Add(Me.cb_Eliminar)
        Me.Controls.Add(Me.cb_Buscar)
        Me.Controls.Add(Me.cb_Guardar)
        Me.Controls.Add(Me.cb_Nuevo)
        Me.Controls.Add(Me.txt_HomePage)
        Me.Controls.Add(Me.txt_Fax)
        Me.Controls.Add(Me.txt_Phone)
        Me.Controls.Add(Me.txt_Country)
        Me.Controls.Add(Me.txt_PostalCode)
        Me.Controls.Add(Me.txt_Region)
        Me.Controls.Add(Me.txt_City)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.txt_ContactTitle)
        Me.Controls.Add(Me.txt_ContactName)
        Me.Controls.Add(Me.txt_CompanyName)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
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
        Me.Controls.Add(Me.txt_SupplierID)
        Me.Name = "frmRegistrarSupplier"
        Me.Text = "Registrar Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_SupplierID As TextBox
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
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_CompanyName As TextBox
    Friend WithEvents txt_ContactName As TextBox
    Friend WithEvents txt_ContactTitle As TextBox
    Friend WithEvents txt_Address As TextBox
    Friend WithEvents txt_City As TextBox
    Friend WithEvents txt_Region As TextBox
    Friend WithEvents txt_PostalCode As TextBox
    Friend WithEvents txt_Country As TextBox
    Friend WithEvents txt_Phone As TextBox
    Friend WithEvents txt_Fax As TextBox
    Friend WithEvents txt_HomePage As TextBox
    Friend WithEvents cb_Nuevo As Button
    Friend WithEvents cb_Guardar As Button
    Friend WithEvents cb_Buscar As Button
    Friend WithEvents cb_Eliminar As Button
End Class
