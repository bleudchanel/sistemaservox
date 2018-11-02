Imports SistemaServox2015BUS
Imports pryUtil.clsUtil
Imports System.Net

Public Class frmMantenimientoOtrosGastos



    Dim bolEsDetalleModifica As Boolean = False
    Dim bolActivaBusquedaKey As Boolean = True
    Dim OtroGastoId As New Integer
    Dim dtBusquedaActual As New DataTable
    Private Sub frmMantenimientoOtrosGastos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ProcComboBoxAAnio(cmbAnio)
        ProcComboBoxAMes(cmbMes)

        Me.ActiveControl = Me.cmbAnio
    End Sub


#Region "Controles"
    Sub Controles_En_Nuevo()
        Me.txtCodigoProducto.Enabled = True
        Me.txtCodigoProducto.Text = ""
        Me.grpDetalleCompra.Enabled = False
        Me.grpCabecera.Enabled = False
        OtroGastoId = 0
    End Sub

    Sub Controles_En_Modificar()

        Me.grpDetalleCompra.Enabled = False
        Me.grpCabecera.Enabled = False
    End Sub

    Sub Controles_En_CancelarProducto()
        bolActivaBusquedaKey = False
        Me.pnlControlProducto.Visible = False
        Me.txtCodigoProducto.Text = String.Empty
        Me.txtMonto.Text = "0.00"
        Me.dgvConcepto.Rows.Clear()
        Me.ActiveControl = Me.btnAgregarDetalle
        bolActivaBusquedaKey = True
        Me.grpDetalleCompra.Enabled = True
        Me.grpCabecera.Enabled = True
    End Sub

#End Region

    Private Sub cmbAnio_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbAnio.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.cmbMes
        End If
    End Sub

    Private Sub cmbMes_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbMes.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.btnBuscarGastos
        End If
    End Sub

    Private Sub btnBuscarGastos_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarGastos.Click
        MostrarDatos(Me.cmbMes.SelectedValue, Me.cmbAnio.SelectedValue)
    End Sub

    Sub MostrarDatos(ByVal intMes As Integer, ByVal intAnio As Integer)
        dtBusquedaActual.Rows.Clear()
        Me.dgvOtro.Rows.Clear()
        Me.txtTotal.Text = "0.00"
        Dim decSumatoria As New Decimal
        Dim Otro As New clsOtrosGastosBUS
        dtBusquedaActual = Otro.fncListarOtrosGastosPorPeriodoBUS(intMes, intAnio)

        If fncValidaDataTable(dtBusquedaActual) Then
            For Each row In dtBusquedaActual.Rows
                Me.dgvOtro.Rows.Add()
                With Me.dgvOtro.Rows(Me.dgvOtro.Rows.Count - 1)
                    .Cells("IdOtroGasto").Value = ObtenerValorCelda(row, "IdOtroGasto")
                    .Cells("Descripcion").Value = ObtenerValorCelda(row, "Descripcion")
                    decSumatoria += FormatearNumero(fncForzarDecimal(ObtenerValorCelda(row, "Monto")), 2)
                    .Cells("Monto").Value = FormatearNumero(fncForzarDecimal(ObtenerValorCelda(row, "Monto")), 2)
                End With
            Next
            ''fncSetDataTableInDGV(dtOtro, dgvOtro)
            Me.txtTotal.Text = FormatearNumero(decSumatoria, 2)
        End If

    End Sub

    Private Sub btnAgregarDetalle_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarDetalle.Click
        Me.pnlControlProducto.Visible = True
        Me.pnlControlProducto.Location = New Point(Me.grpCabecera.Location.X + Me.grpCabecera.Width / 20, Me.grpCabecera.Location.Y + Me.grpCabecera.Location.Y / 2)
        bolEsDetalleModifica = False
        Controles_En_Nuevo()
        Me.ActiveControl = txtCodigoProducto
    End Sub

    Private Sub btnModificarDetalle_Click(sender As System.Object, e As System.EventArgs) Handles btnModificarDetalle.Click
        If Me.dgvOtro.Rows.Count > 0 AndAlso Me.dgvOtro.CurrentRow IsNot Nothing Then
            OtroGastoId = Me.dgvOtro.CurrentRow.Cells("IdOtroGasto").Value
            Me.pnlControlProducto.Visible = True
            Me.pnlControlProducto.Location = New Point(Me.grpCabecera.Location.X + Me.grpCabecera.Width / 20, Me.grpCabecera.Location.Y + Me.grpCabecera.Location.Y / 2)
            bolEsDetalleModifica = False
            Controles_En_Modificar()
            Me.txtCodigoProducto.Text = Me.dgvOtro.CurrentRow.Cells("Descripcion").Value
            Me.txtMonto.Text = Me.dgvOtro.CurrentRow.Cells("Monto").Value
            Me.ActiveControl = txtCodigoProducto
        Else
            Notificar("Debe seleccionar un gasto a modificar.")
        End If
    End Sub


    Private Sub btnQuitarDetalle_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarDetalle.Click
        If Me.dgvOtro.Rows.Count > 0 AndAlso Me.dgvOtro.CurrentRow IsNot Nothing Then
            OtroGastoId = Me.dgvOtro.CurrentRow.Cells("IdOtroGasto").Value
            Dim Otro As New clsOtrosGastosBUS
            Dim dtOtro As DataTable = Otro.fncConsultarBUS(OtroGastoId)
            If fncValidaDataTable(dtOtro) Then
                Otro.fncSetearBUS(dtOtro.Rows(0))
                Otro.Estado = enmEstado.Inactivo
                Otro.fncModificarBUS()
                MostrarDatos(Me.cmbMes.SelectedValue, Me.cmbAnio.SelectedValue)
            End If
        Else
            Notificar("Debe seleccionar un gasto a modificar.")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Controles_En_CancelarProducto()
        MostrarDatos(Me.cmbMes.SelectedValue, Me.cmbAnio.SelectedValue)
        Me.ActiveControl = Me.btnAgregarDetalle
    End Sub

    Private Sub btnConfirmarGasto_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmarGasto.Click
        If OtroGastoId = 0 Then
            Dim Otro As New clsOtrosGastosBUS(Me.txtCodigoProducto.Text, Me.cmbMes.SelectedValue, Me.cmbAnio.SelectedValue, fncForzarDecimal(Me.txtMonto.Text))
            If Otro.fncRegistrarBUS() > 0 Then
                Notificar("Registrado.")
                MostrarDatos(Me.cmbMes.SelectedValue, Me.cmbAnio.SelectedValue)
                Me.btnCancelar.PerformClick()
            Else
                Notificar("No se pudo registrar este concepto.")
            End If
        Else
            Dim Otro As New clsOtrosGastosBUS
            Dim dtOtro As DataTable = Otro.fncConsultarBUS(OtroGastoId)
            If fncValidaDataTable(dtOtro) Then
                Otro.fncSetearBUS(dtOtro.Rows(0))
                Otro.Descripcion = Me.txtCodigoProducto.Text
                Otro.Monto = fncForzarDecimal(Me.txtMonto.Text)
                If Otro.fncModificarBUS() > 0 Then
                    Notificar("Modificado.")
                    MostrarDatos(Me.cmbMes.SelectedValue, Me.cmbAnio.SelectedValue)
                    Me.btnCancelar.PerformClick()
                End If

            End If
        End If

    End Sub

    Private Sub txtCodigoProducto_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.dgvConcepto.Rows.Count > 0 And Me.dgvConcepto.CurrentRow IsNot Nothing Then
                Me.txtCodigoProducto.Text = Me.dgvConcepto.CurrentRow.Cells("subConcepto").Value
                Me.ActiveControl = Me.txtMonto
            Else
                Me.ActiveControl = Me.txtMonto
            End If
        End If
    End Sub

    Private Sub txtMonto_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtMonto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnConfirmarGasto.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.btnCancelar.PerformClick()
        End If
    End Sub

    Private Sub txtCodigoProducto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodigoProducto.TextChanged
        If bolActivaBusquedaKey = True Then
            Dim Otro As New clsOtrosGastosBUS
            Dim dtConceptos As DataTable = Otro.fncConceptosBusquedaListaBUS(Me.txtCodigoProducto.Text)
            If fncValidaDataTable(dtConceptos) Then
                fncSetDataTableInDGV(dtConceptos, dgvConcepto)
            End If
        End If

    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExcel.Click
        FncDataTable2Excel(dtBusquedaActual, "Otros Gastos")
    End Sub



    Private Sub cmbMes_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmbMes.SelectionChangeCommitted, cmbAnio.SelectionChangeCommitted
        MostrarDatos(Me.cmbMes.SelectedValue, Me.cmbAnio.SelectedValue)
    End Sub
End Class