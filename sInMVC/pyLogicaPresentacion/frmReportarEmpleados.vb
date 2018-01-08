Imports pyLogicaNegocio
Imports Microsoft.Reporting.WinForms

Public Class frmReportarEmpleados
    Private Sub frmReportarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.rv_Reporte.RefreshReport()
    End Sub

    Private Sub cb_generar_Click(sender As Object, e As EventArgs) Handles cb_generar.Click
        Dim x As nEmployee
        x = New nEmployee()
        Me.rv_Reporte.LocalReport.DataSources.Item(0).Value = x.Elaborar_ReporteEmpleados()
        Me.rv_Reporte.SetDisplayMode(DisplayMode.PrintLayout)
        Me.rv_Reporte.ZoomMode = ZoomMode.Percent
        Me.rv_Reporte.ZoomPercent = 100
        Me.rv_Reporte.RefreshReport()
        x = Nothing
    End Sub
End Class