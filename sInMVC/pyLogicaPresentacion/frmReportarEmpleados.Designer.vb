<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportarEmpleados
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.eRep_ReporteEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cb_generar = New System.Windows.Forms.Button()
        Me.rv_Reporte = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.eRep_ReporteEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'eRep_ReporteEmpleadosBindingSource
        '
        Me.eRep_ReporteEmpleadosBindingSource.DataSource = GetType(pyLogicaEntidad.eRep_ReporteEmpleados)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cb_generar)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.rv_Reporte)
        Me.SplitContainer1.Size = New System.Drawing.Size(681, 347)
        Me.SplitContainer1.SplitterDistance = 59
        Me.SplitContainer1.TabIndex = 0
        '
        'cb_generar
        '
        Me.cb_generar.Location = New System.Drawing.Point(12, 10)
        Me.cb_generar.Name = "cb_generar"
        Me.cb_generar.Size = New System.Drawing.Size(145, 29)
        Me.cb_generar.TabIndex = 0
        Me.cb_generar.Text = "Generar"
        Me.cb_generar.UseVisualStyleBackColor = True
        '
        'rv_Reporte
        '
        Me.rv_Reporte.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_ReporteEmpleados"
        ReportDataSource1.Value = Me.eRep_ReporteEmpleadosBindingSource
        Me.rv_Reporte.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_Reporte.LocalReport.ReportEmbeddedResource = "pyLogicaPresentacion.Rep_ReporteEmpleados.rdlc"
        Me.rv_Reporte.Location = New System.Drawing.Point(0, 0)
        Me.rv_Reporte.Name = "rv_Reporte"
        Me.rv_Reporte.ServerReport.BearerToken = Nothing
        Me.rv_Reporte.Size = New System.Drawing.Size(681, 284)
        Me.rv_Reporte.TabIndex = 0
        '
        'frmReportarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 347)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmReportarEmpleados"
        Me.Text = "Reportar Empleados"
        CType(Me.eRep_ReporteEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents rv_Reporte As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents eRep_ReporteEmpleadosBindingSource As BindingSource
    Friend WithEvents cb_generar As Button
End Class
