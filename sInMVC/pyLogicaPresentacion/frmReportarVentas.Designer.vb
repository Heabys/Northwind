<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportarVentas
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.eRep_ReporteVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cb_Generar = New System.Windows.Forms.Button()
        Me.rv_reporte = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.eRep_ReporteVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'eRep_ReporteVentasBindingSource
        '
        Me.eRep_ReporteVentasBindingSource.DataSource = GetType(pyLogicaEntidad.eRep_ReporteVentas)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.cb_Generar)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.rv_reporte)
        Me.SplitContainer1.Size = New System.Drawing.Size(692, 356)
        Me.SplitContainer1.SplitterDistance = 39
        Me.SplitContainer1.TabIndex = 0
        '
        'cb_Generar
        '
        Me.cb_Generar.Location = New System.Drawing.Point(12, 6)
        Me.cb_Generar.Name = "cb_Generar"
        Me.cb_Generar.Size = New System.Drawing.Size(137, 31)
        Me.cb_Generar.TabIndex = 0
        Me.cb_Generar.Text = "Generar"
        Me.cb_Generar.UseVisualStyleBackColor = True
        '
        'rv_reporte
        '
        Me.rv_reporte.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DS_ReporteVentas"
        ReportDataSource2.Value = Me.eRep_ReporteVentasBindingSource
        Me.rv_reporte.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rv_reporte.LocalReport.ReportEmbeddedResource = "pyLogicaPresentacion.Rep_ReporteVentas.rdlc"
        Me.rv_reporte.Location = New System.Drawing.Point(0, 0)
        Me.rv_reporte.Name = "rv_reporte"
        Me.rv_reporte.ServerReport.BearerToken = Nothing
        Me.rv_reporte.Size = New System.Drawing.Size(692, 313)
        Me.rv_reporte.TabIndex = 0
        '
        'frmReportarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 356)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmReportarVentas"
        Me.Text = "Reporte de Ventas"
        CType(Me.eRep_ReporteVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents cb_Generar As Button
    Friend WithEvents rv_reporte As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents eRep_ReporteVentasBindingSource As BindingSource
End Class
