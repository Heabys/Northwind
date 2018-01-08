Imports pyLogicaNegocio
Imports Microsoft.Reporting.WinForms

Public Class frmReportarVentas
    Private Sub frmReportarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rv_reporte.RefreshReport()
    End Sub

    Private Sub cb_Generar_Click(sender As Object, e As EventArgs) Handles cb_Generar.Click
        Dim x As nVentas
        x = New nVentas
        Me.rv_reporte.LocalReport.DataSources.Item(0).Value = x.Elabororar_ReporteVentas()
        Me.rv_reporte.SetDisplayMode(DisplayMode.PrintLayout)
        Me.rv_reporte.ZoomMode = ZoomMode.Percent
        Me.rv_reporte.ZoomPercent = 100
        Me.rv_reporte.RefreshReport()
        x = Nothing
    End Sub
End Class