Imports SistemaServox2015BUS
Imports pryUtil.clsUtil
Imports System.Net
Imports System.IO

Public Class frmReporteProductoAvanzado

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Dim bolEsReporteAnual As New Boolean
    Private Sub frmReporteProductoAvanzado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Periodo As New clsPeriodo
        SetComboBox(cmbAnio, Periodo.fncListaPeriodoPorOperacionBUS(2), "Anio", "Anio")
        ProcComboBoxAMes(cmbMes)

    End Sub

    Private Sub btnGenerarData_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerarData.Click
        bolEsReporteAnual = False
        Dim Producto As New clsProductoBUS

        Dim dtProducto As DataTable = Producto.fncReporteVentasPorPeriodoProductoBUS(Me.cmbMes.SelectedValue, Me.cmbAnio.SelectedValue) ' Reemplazar
        If fncValidaDataTable(dtProducto) Then
            LlenarGrid(dtProducto)
        End If
        lblAviso.Text = "REPORTE MENSUAL " & Me.cmbMes.Text & " - " & Me.cmbAnio.Text
    End Sub

    Private Sub btnGenerarReporteIndividual_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerarReporteIndividual.Click
        If Me.dgvCliente.CurrentRow IsNot Nothing AndAlso Me.dgvCliente.Rows.Count > 0 Then
            Dim intIdProducto As Integer = Me.dgvCliente.CurrentRow.Cells("IdProducto").Value
            Dim Producto As New clsProductoBUS
            Dim dtProducto As DataTable = Producto.fncReporteVentasProductoPorPeriodoBUS(If(bolEsReporteAnual = True, -1, Me.cmbMes.SelectedValue), Me.cmbAnio.SelectedValue, intIdProducto)
            If fncValidaDataTable(dtProducto) Then
                FncDataTable2Excel(dtProducto, "Registro")
            End If
        End If
    End Sub

    Sub LlenarGrid(ByVal dtBase As DataTable)
        Me.dgvCliente.Rows.Clear()
        If fncValidaDataTable(dtBase) Then
            For Each row In dtBase.Rows
                Me.dgvCliente.Rows.Add()
                With Me.dgvCliente.Rows(Me.dgvCliente.Rows.Count - 1)
                    .Cells("IdProducto").Value = ObtenerValorCelda(row, "IdProducto")
                    .Cells("Producto").Value = ObtenerValorCelda(row, "Producto")
                    .Cells("Descripcion").Value = ObtenerValorCelda(row, "Descripcion")
                    .Cells("Cantidad").Value = FormatearNumero(ObtenerValorCelda(row, "Cantidad"), 0)
                    .Cells("PrecioVenta").Value = FormatearNumero(ObtenerValorCelda(row, "PrecioVenta"), 2)
                    .Cells("Total").Value = FormatearNumero(ObtenerValorCelda(row, "Total"), 2)
                End With
            Next
        End If
    End Sub

    Private Sub btnReporteGrafico_Click(sender As System.Object, e As System.EventArgs) Handles btnReporteGrafico.Click
        If Me.dgvCliente.CurrentRow IsNot Nothing AndAlso Me.dgvCliente.Rows.Count > 0 Then
            If bolEsReporteAnual = False Then
                Dim frmReporte As New frmRepositorioReporte
                Dim Producto As New clsProductoBUS
                'Dim strTitulo As String = Me.dgvPlanillasPeriodo.CurrentRow.Cells("lstIdPlanilla").Value & " : " & Me.dgvPlanillasPeriodo.CurrentRow.Cells("lstDescripcionPlanilla").Value
                Dim intIdProducto As Integer = Me.dgvCliente.CurrentRow.Cells("IdProducto").Value

                frmReporte.ConstruirReporteProveedorAvanzado(Producto.fncReporteVentasProductoAgrupadoBUS(Me.cmbMes.SelectedValue, Me.cmbAnio.SelectedValue, intIdProducto), "")

                frmReporte.Show()
            Else
                Dim frmReporte As New frmRepositorioReporte
                Dim Producto As New clsProductoBUS
                'Dim strTitulo As String = Me.dgvPlanillasPeriodo.CurrentRow.Cells("lstIdPlanilla").Value & " : " & Me.dgvPlanillasPeriodo.CurrentRow.Cells("lstDescripcionPlanilla").Value
                Dim intIdProducto As Integer = Me.dgvCliente.CurrentRow.Cells("IdProducto").Value

                frmReporte.ConstruirReporteProveedorAvanzadoAnual(Producto.fncReporteVentasProductoAgrupadoAnualBUS(Me.cmbAnio.SelectedValue, intIdProducto), "")

                frmReporte.Show()
            End If
          
        Else
            Notificar("Seleccione Producto")
        End If
    End Sub



    Private Sub btnGenerarDataAnual_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerarDataAnual.Click
        bolEsReporteAnual = True
        Dim Producto As New clsProductoBUS

        Dim dtProducto As DataTable = Producto.fncReporteVentasPorPeriodoProductoBUS(, Me.cmbAnio.SelectedValue) ' Reemplazar
        If fncValidaDataTable(dtProducto) Then
            LlenarGrid(dtProducto)
        End If
        lblAviso.Text = "REPORTE ANUAL " & Me.cmbAnio.Text
    End Sub
End Class