Public Class frmRepositorioReporte

    Private Sub frmRepositorioReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ConstruirReporteKardex(ByVal dtResultado As DataTable, ByVal strTitulo As String)
        Dim repBase As New crpKardexValorado
        repBase.SetDataSource(dtResultado)
        ''repBase.SetParameterValue("Periodicidad", strTitulo)
        Me.crpViewer.ReportSource = repBase
        Me.crpViewer.Refresh()
    End Sub

    Public Sub ConstruirReporteHistorialProveedor(ByVal dtResultado As DataTable, ByVal strTitulo As String)
        Dim repBase As New crpHistorialProveedor
        repBase.SetDataSource(dtResultado)
        ''repBase.SetParameterValue("Periodicidad", strTitulo)
        Me.crpViewer.ReportSource = repBase
        Me.crpViewer.Refresh()
    End Sub

    Public Sub ConstruirReporteProveedorAvanzado(ByVal dtResultado As DataTable, ByVal strTitulo As String)
        Dim repBase As New crpProductoAvanzadoMensual
        repBase.SetDataSource(dtResultado)
        ''repBase.SetParameterValue("Periodicidad", strTitulo)
        Me.crpViewer.ReportSource = repBase
        Me.crpViewer.Refresh()
    End Sub

    Public Sub ConstruirReporteProveedorAvanzadoAnual(ByVal dtResultado As DataTable, ByVal strTitulo As String)
        Dim repBase As New crpProductoAvanzadoAnual
        repBase.SetDataSource(dtResultado)
        ''repBase.SetParameterValue("Periodicidad", strTitulo)
        Me.crpViewer.ReportSource = repBase
        Me.crpViewer.Refresh()
    End Sub

End Class