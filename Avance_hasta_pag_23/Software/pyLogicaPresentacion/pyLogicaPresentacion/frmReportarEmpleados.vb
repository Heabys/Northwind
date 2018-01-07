Imports Microsoft.VisualBasic
Imports pyLogicaNegocio
Imports Microsoft.Reporting.WinForms

Public Class frmReportarEmpleados
    Private Sub cb_Generar_Click(sender As Object, e As EventArgs) Handles cb_Generar.Click
        Dim x As nEmployee
        x = New nEmployee()
        Me.rv_Reporte.LocalReport.DataSources.Item(0).Value = x.Elaborar_ReporteEmpleados()
        Me.rv_Reporte.SetDisplayMode(DisplayMode.PrintLayout)
        Me.rv_Reporte.ZoomMode = ZoomMode.Percent
        Me.rv_Reporte.ZoomPercent = 100 Me.rv_Reporte.RefreshReport()
		x = Nothing
    End Sub
End Class
