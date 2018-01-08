<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarCategory
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
        Me.txt_CategoryID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_CategoryName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pb_Imagen = New System.Windows.Forms.PictureBox()
        Me.cb_CambiarImagen = New System.Windows.Forms.Button()
        Me.cb_Nuevo = New System.Windows.Forms.Button()
        Me.cb_Buscar = New System.Windows.Forms.Button()
        Me.cb_Guardar = New System.Windows.Forms.Button()
        Me.cb_Eliminar = New System.Windows.Forms.Button()
        Me.txt_Descripcion = New System.Windows.Forms.RichTextBox()
        CType(Me.pb_Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_CategoryID
        '
        Me.txt_CategoryID.Enabled = False
        Me.txt_CategoryID.Location = New System.Drawing.Point(148, 12)
        Me.txt_CategoryID.Name = "txt_CategoryID"
        Me.txt_CategoryID.Size = New System.Drawing.Size(100, 20)
        Me.txt_CategoryID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo de Categoria:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre de Categoria:"
        '
        'txt_CategoryName
        '
        Me.txt_CategoryName.Location = New System.Drawing.Point(148, 43)
        Me.txt_CategoryName.Name = "txt_CategoryName"
        Me.txt_CategoryName.Size = New System.Drawing.Size(326, 20)
        Me.txt_CategoryName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripcion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Imagen:"
        '
        'pb_Imagen
        '
        Me.pb_Imagen.Location = New System.Drawing.Point(148, 231)
        Me.pb_Imagen.Name = "pb_Imagen"
        Me.pb_Imagen.Size = New System.Drawing.Size(187, 178)
        Me.pb_Imagen.TabIndex = 7
        Me.pb_Imagen.TabStop = False
        '
        'cb_CambiarImagen
        '
        Me.cb_CambiarImagen.Location = New System.Drawing.Point(341, 231)
        Me.cb_CambiarImagen.Name = "cb_CambiarImagen"
        Me.cb_CambiarImagen.Size = New System.Drawing.Size(107, 27)
        Me.cb_CambiarImagen.TabIndex = 8
        Me.cb_CambiarImagen.Text = "Cambiar Imagen"
        Me.cb_CambiarImagen.UseVisualStyleBackColor = True
        '
        'cb_Nuevo
        '
        Me.cb_Nuevo.Location = New System.Drawing.Point(35, 432)
        Me.cb_Nuevo.Name = "cb_Nuevo"
        Me.cb_Nuevo.Size = New System.Drawing.Size(107, 27)
        Me.cb_Nuevo.TabIndex = 9
        Me.cb_Nuevo.Text = "Nuevo"
        Me.cb_Nuevo.UseVisualStyleBackColor = True
        '
        'cb_Buscar
        '
        Me.cb_Buscar.Location = New System.Drawing.Point(261, 432)
        Me.cb_Buscar.Name = "cb_Buscar"
        Me.cb_Buscar.Size = New System.Drawing.Size(107, 27)
        Me.cb_Buscar.TabIndex = 10
        Me.cb_Buscar.Text = "Buscar"
        Me.cb_Buscar.UseVisualStyleBackColor = True
        '
        'cb_Guardar
        '
        Me.cb_Guardar.Location = New System.Drawing.Point(148, 432)
        Me.cb_Guardar.Name = "cb_Guardar"
        Me.cb_Guardar.Size = New System.Drawing.Size(107, 27)
        Me.cb_Guardar.TabIndex = 11
        Me.cb_Guardar.Text = "Guardar"
        Me.cb_Guardar.UseVisualStyleBackColor = True
        '
        'cb_Eliminar
        '
        Me.cb_Eliminar.Location = New System.Drawing.Point(374, 432)
        Me.cb_Eliminar.Name = "cb_Eliminar"
        Me.cb_Eliminar.Size = New System.Drawing.Size(107, 27)
        Me.cb_Eliminar.TabIndex = 12
        Me.cb_Eliminar.Text = "Eliminar"
        Me.cb_Eliminar.UseVisualStyleBackColor = True
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.Location = New System.Drawing.Point(148, 69)
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txt_Descripcion.Size = New System.Drawing.Size(326, 136)
        Me.txt_Descripcion.TabIndex = 5
        Me.txt_Descripcion.Text = ""
        '
        'frmRegistrarCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 472)
        Me.Controls.Add(Me.cb_Eliminar)
        Me.Controls.Add(Me.cb_Guardar)
        Me.Controls.Add(Me.cb_Buscar)
        Me.Controls.Add(Me.cb_Nuevo)
        Me.Controls.Add(Me.cb_CambiarImagen)
        Me.Controls.Add(Me.pb_Imagen)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Descripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_CategoryName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_CategoryID)
        Me.Name = "frmRegistrarCategory"
        Me.Text = "Registrar Categoria"
        CType(Me.pb_Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_CategoryID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_CategoryName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pb_Imagen As PictureBox
    Friend WithEvents cb_CambiarImagen As Button
    Friend WithEvents cb_Nuevo As Button
    Friend WithEvents cb_Buscar As Button
    Friend WithEvents cb_Guardar As Button
    Friend WithEvents cb_Eliminar As Button
    Friend WithEvents txt_Descripcion As RichTextBox
End Class
