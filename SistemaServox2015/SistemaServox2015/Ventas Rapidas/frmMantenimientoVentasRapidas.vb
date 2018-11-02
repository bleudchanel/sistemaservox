Imports SistemaServox2015BUS
Imports pryUtil.clsUtil
Imports System.Net

Public Class frmMantenimientoVentasRapidas

    Private bolEsBusquedaAutomaticaCliente As Boolean = False
    Dim bolEsDetalleModifica As Boolean = False
    Dim bolActivaBusquedaKey As Boolean = True
    Dim VentaRapidaId As New Integer
    Dim intIdCliente As New Integer
    Dim intIdProducto As New Integer
    Dim intCantidadProducto As New Integer
    Private bolTextChange As Boolean = True
    Private bolPivot As Boolean = True
    Dim strCodigoClienteBusquedaActual As String = String.Empty
    Dim dtBusquedaActual As New DataTable

    Private Sub frmMantenimientoOtrosGastos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ProcComboBoxAAnio(cmbAnio)
        ProcComboBoxAMes(cmbMes)
        Dim UnidadMedida As New clsUnidadMedidaBUS
        SetComboBox(cmbUnidadMedida, UnidadMedida.fncListarUnidadMedidaBUS(enmEstado.Activo), "Abreviacion", "IdMedida")
        Me.ActiveControl = Me.cmbAnio
        Me.lblIGV.Text = "IGV " & (My.Settings.IGV * 100) & "%"

        dtBusquedaActual.Columns.Add("Fecha", GetType(String))
        dtBusquedaActual.Columns.Add("Código", GetType(String))
        dtBusquedaActual.Columns.Add("Producto", GetType(String))
        dtBusquedaActual.Columns.Add("DocCliente", GetType(String))
        dtBusquedaActual.Columns.Add("Cliente", GetType(String))
        dtBusquedaActual.Columns.Add("Unitario", GetType(Decimal))
        dtBusquedaActual.Columns.Add("Cantidad", GetType(Integer))
        dtBusquedaActual.Columns.Add("Total", GetType(Decimal))

    End Sub

    Public Sub EstructuraReporte(strFecha As String _
                                 , strCodigo As String _
                                 , strProducto As String _
                                 , strDocCliente As String _
                                 , strCliente As String _
                                 , decUnitario As Decimal _
                                 , intCantidad As Integer _
                                 , decTotal As Decimal)


        dtBusquedaActual.Rows.Add(strFecha, strCodigo, strProducto, strDocCliente, strCliente, decUnitario, intCantidad, decTotal)
    End Sub


#Region "Controles"
    Sub Controles_En_Nuevo()
        Me.txtCodigoProducto.Enabled = True
        Me.txtCodigoProducto.Text = ""
        Me.txtDescripcionProducto.Text = ""
        Me.nudCantidad.Text = ""
        Me.txtPrecioUnitario.Text = "0.00"
        Me.txtPrecioTotal.Text = "0.00"
        Me.intIdProducto = 0
        Me.intIdCliente = 0
        Me.txtCodigoCliente.Text = ""
        Me.txtNombreCliente.Text = ""
        Me.grpDetalleCompra.Enabled = False
        Me.grpCabecera.Enabled = False
        VentaRapidaId = 0
        bolEsBusquedaAutomaticaCliente = True
    End Sub

    Sub Controles_En_Modificar()

        Me.grpDetalleCompra.Enabled = False
        Me.grpCabecera.Enabled = False
    End Sub

    Sub Controles_En_CancelarProducto()
        bolActivaBusquedaKey = False
        Me.pnlControlProducto.Visible = False
        Me.txtCodigoProducto.Text = String.Empty
        Me.txtPrecioUnitario.Text = "0.00"
        Me.dgvProducto.Rows.Clear()
        Me.ActiveControl = Me.btnAgregarDetalle
        bolActivaBusquedaKey = True
        Me.grpDetalleCompra.Enabled = True
        Me.grpCabecera.Enabled = True
    End Sub

    Sub Controles_En_ModificarProducto()
        Me.pnlControlProducto.Visible = True
        Me.pnlControlProducto.Location = New Point(Me.grpCabecera.Location.X + Me.grpCabecera.Width / 20, Me.grpCabecera.Location.Y + 100)
        Me.txtCodigoProducto.Enabled = False
        Me.txtDescripcionProducto.Enabled = False
        Me.cmbUnidadMedida.Enabled = False
        Me.btnConfirmarGasto.Enabled = True
        Me.nudCantidad.Enabled = True

    End Sub

    Sub Controles_En_Producto()

        Me.tbcVentas.Enabled = False
        Me.cmbUnidadMedida.Enabled = False
        Me.nudCantidad.Enabled = False
        Me.btnConfirmarGasto.Enabled = False
    End Sub

    Sub Controles_En_NuevoProducto()
        bolTextChange = False
        Me.cmbUnidadMedida.Enabled = True
        Me.nudCantidad.Enabled = True
        Me.btnConfirmarGasto.Enabled = True
        Me.txtCodigoProducto.Enabled = True
        Me.txtCodigoProducto.Text = ""
        Me.txtDescripcionProducto.Text = ""
        Me.txtPrecioUnitario.Text = "0.00"
        Me.txtDescripcionProducto.Enabled = True
        Me.txtPrecioUnitario.Enabled = True
        bolTextChange = True

    End Sub

    Sub Controles_En_ProductoSeleccionado()
        Me.cmbUnidadMedida.Enabled = False
        Me.nudCantidad.Enabled = True
        Me.btnConfirmarGasto.Enabled = True
    End Sub

    Sub Controles_En_CancelarGasto()
        Me.tbcVentas.Enabled = True
        Me.pnlControlProducto.Visible = False
        Me.dgvProducto.Rows.Clear()

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
        Dim Venta As New clsVentaRapidaBUS
        Dim dtVenta As DataTable = Venta.fncListarVentasRapidasPorPeriodoBUS(intMes, intAnio)

        If fncValidaDataTable(dtVenta) Then
            For Each row In dtVenta.Rows
                EstructuraReporte(ObtenerValorCelda(row, "FechaVenta") _
                                  , ObtenerValorCelda(row, "CodigoProducto") _
                                  , ObtenerValorCelda(row, "Producto") _
                                  , ObtenerValorCelda(row, "DocumentoIdentidad") _
                                  , ObtenerValorCelda(row, "Cliente") _
                                  , ObtenerValorCelda(row, "PrecioIndividual") _
                                  , ObtenerValorCelda(row, "Cantidad") _
                                  , ObtenerValorCelda(row, "PrecioTotal"))

                Me.dgvOtro.Rows.Add()
                With Me.dgvOtro.Rows(Me.dgvOtro.Rows.Count - 1)
                    .Cells("IdVentaRapida").Value = ObtenerValorCelda(row, "Id")
                    .Cells("Descripcion").Value = ObtenerValorCelda(row, "Descripcion")
                    .Cells("FechaVenta").Value = ObtenerValorCelda(row, "FechaVenta")
                    .Cells("Producto").Value = ObtenerValorCelda(row, "Producto")
                    .Cells("Cliente").Value = ObtenerValorCelda(row, "Cliente")
                    .Cells("Cantidad").Value = ObtenerValorCelda(row, "Cantidad")
                    decSumatoria += FormatearNumero(fncForzarDecimal(ObtenerValorCelda(row, "PrecioTotal")), 2)
                    .Cells("PrecioTotal").Value = FormatearNumero(fncForzarDecimal(ObtenerValorCelda(row, "PrecioTotal")), 2)
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
        Controles_En_NuevoProducto()
        EstablecerRangoDeFechas()
        Me.ActiveControl = txtCodigoProducto
    End Sub

    Sub EstablecerRangoDeFechas()
        Dim intMes As Integer = Me.cmbMes.SelectedValue
        Dim intAnio As Integer = Me.cmbAnio.SelectedValue
        Me.dtpFechaVenta.MinDate = New Date(1900, 1, 1)
        Me.dtpFechaVenta.MaxDate = New Date(2500, 1, 1)
        Me.dtpFechaVenta.MaxDate = (New Date(If(intMes = 12, intAnio + 1, intAnio), If(intMes = 12, 1, intMes + 1), 1)).AddDays(-1)
        Me.dtpFechaVenta.MinDate = New Date(intAnio, intMes, 1)
    End Sub

    Private Sub btnModificarDetalle_Click(sender As System.Object, e As System.EventArgs) Handles btnModificarDetalle.Click
        Controles_En_ModificarProducto()
        If Me.dgvOtro.Rows.Count > 0 AndAlso Me.dgvOtro.CurrentRow IsNot Nothing Then
            VentaRapidaId = Me.dgvOtro.CurrentRow.Cells("IdVentaRapida").Value
            
            Dim Venta As New clsVentaRapidaBUS
            Dim dtVenta As DataTable = Venta.fncListarVentasRapidasPorPeriodoBUS(, , VentaRapidaId)
            If fncValidaDataTable(dtVenta) Then
                Me.pnlControlProducto.Visible = True
                Me.pnlControlProducto.Location = New Point(Me.grpCabecera.Location.X + Me.grpCabecera.Width / 20, Me.grpCabecera.Location.Y + Me.grpCabecera.Location.Y / 2)
                bolEsDetalleModifica = False
                Controles_En_Modificar()

                bolTextChange = False
                Me.intIdProducto = ObtenerValorCelda(dtVenta.Rows(0), "IdProducto")
                Me.txtCodigoProducto.Text = ObtenerValorCelda(dtVenta.Rows(0), "CodigoProducto")
                Me.txtDescripcionProducto.Text = ObtenerValorCelda(dtVenta.Rows(0), "Producto")
                bolTextChange = True

                Me.txtPrecioUnitario.Text = ObtenerValorCelda(dtVenta.Rows(0), "PrecioIndividual")
                Me.nudCantidad.Text = ObtenerValorCelda(dtVenta.Rows(0), "Cantidad")
                Me.txtPrecioTotal.Text = ObtenerValorCelda(dtVenta.Rows(0), "PrecioTotal")
                bolEsBusquedaAutomaticaCliente = False
                Me.intIdCliente = ObtenerValorCelda(dtVenta.Rows(0), "IdCliente")
                Me.txtCodigoCliente.Text = ObtenerValorCelda(dtVenta.Rows(0), "DocumentoIdentidad")
                Me.txtNombreCliente.Text = ObtenerValorCelda(dtVenta.Rows(0), "Cliente")
                bolEsBusquedaAutomaticaCliente = True

                Me.dtpFechaVenta.Value = ObtenerValorCelda(dtVenta.Rows(0), "FechaVenta")
                EstablecerRangoDeFechas()
                Me.ActiveControl = txtCodigoProducto
            Else
                Notificar("Hubo un error al procesar su solicitud.")
            End If

            
        Else
            Notificar("Debe seleccionar un gasto a modificar.")
        End If
    End Sub


    Private Sub btnQuitarDetalle_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarDetalle.Click
        If Me.dgvOtro.Rows.Count > 0 AndAlso Me.dgvOtro.CurrentRow IsNot Nothing Then
            VentaRapidaId = Me.dgvOtro.CurrentRow.Cells("IdVentaRapida").Value
            Dim Venta As New clsVentaRapidaBUS
            Dim dtVenta As DataTable = Venta.fncConsultarBUS(VentaRapidaId)
            If fncValidaDataTable(dtVenta) Then
                Venta.fncSetearBUS(dtVenta.Rows(0))
                Venta.Estado = enmEstado.Inactivo
                Venta.fncModificarBUS()
                MostrarDatos(Me.cmbMes.SelectedValue, Me.cmbAnio.SelectedValue)
            End If
        Else
            Notificar("Debe seleccionar una venta a modificar.")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Controles_En_CancelarProducto()
        Controles_En_CancelarGasto()
        bolPivot = True
        MostrarDatos(Me.cmbMes.SelectedValue, Me.cmbAnio.SelectedValue)
        Me.ActiveControl = Me.btnAgregarDetalle
    End Sub

    Private Sub btnConfirmarGasto_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmarGasto.Click
        If intIdCliente = 0 Then
            Notificar("Debe ingresar un cliente")
            Exit Sub
        End If

        If VentaRapidaId = 0 Then
            Dim Venta As New clsVentaRapidaBUS("Default", intIdProducto, Me.dtpFechaVenta.Value, intIdCliente, fncForzarDecimal(Me.txtPrecioUnitario.Text), fncForzarInteger(Me.nudCantidad.Text), Me.txtPrecioTotal.Text, My.Settings.IdUltimoUsuario)
            If Venta.fncRegistrarBUS() > 0 Then
                Notificar("Registrado.")
                '' MostrarDatos(Me.cmbMes.SelectedValue, Me.cmbAnio.SelectedValue)
                Me.btnCancelar.PerformClick()
            Else
                Notificar("No se pudo registrar este concepto.")
            End If

            'Dim Otro As New clsOtrosGastosBUS(Me.txtCodigoProducto.Text, Me.cmbMes.SelectedValue, Me.cmbAnio.SelectedValue, fncForzarDecimal(Me.txtPrecioUnitario.Text))
            'If Otro.fncRegistrarBUS() > 0 Then
            '    Notificar("Registrado.")
            '    MostrarDatos(Me.cmbMes.SelectedValue, Me.cmbAnio.SelectedValue)
            '    Me.btnCancelar.PerformClick()
            'Else
            '    Notificar("No se pudo registrar este concepto.")
            'End If

        Else
            Dim Venta As New clsVentaRapidaBUS
            Dim dtVenta As DataTable = Venta.fncConsultarBUS(VentaRapidaId)

            If fncValidaDataTable(dtVenta) Then
                Venta.fncSetearBUS(dtVenta.Rows(0))
                Venta.IdProducto = intIdProducto
                Venta.IdCliente = intIdCliente
                Venta.PrecioIndividual = fncForzarDecimal(Me.txtPrecioUnitario.Text)
                Venta.PrecioTotal = fncForzarDecimal(Me.txtPrecioTotal.Text)
                Venta.Cantidad = fncForzarInteger(Me.nudCantidad.Text)
                Venta.FechaModifica = FechaHoraServidor()
                Venta.UsuarioModifica = My.Settings.IdUltimoUsuario
                If Venta.fncModificarBUS() > 0 Then
                    Notificar("Modificado.")
                    ''      MostrarDatos(Me.cmbMes.SelectedValue, Me.cmbAnio.SelectedValue)
                    Me.btnCancelar.PerformClick()
                End If
            End If


            'Dim Otro As New clsOtrosGastosBUS
            'Dim dtOtro As DataTable = Otro.fncConsultarBUS(VentaRapidaId)
            'If fncValidaDataTable(dtOtro) Then
            '    Otro.fncSetearBUS(dtOtro.Rows(0))
            '    Otro.Descripcion = Me.txtCodigoProducto.Text
            '    Otro.Monto = fncForzarDecimal(Me.txtPrecioUnitario.Text)
            '    If Otro.fncModificarBUS() > 0 Then
            '        Notificar("Modificado.")
            '        MostrarDatos(Me.cmbMes.SelectedValue, Me.cmbAnio.SelectedValue)
            '        Me.btnCancelar.PerformClick()
            '    End If

            'End If
        End If

    End Sub



    Private Sub txtMonto_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPrecioUnitario.KeyDown
     If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.txtCodigoCliente
            Me.txtCodigoCliente.Select(0, Me.txtCodigoCliente.Text.Length)
        End If
    End Sub

    'Private Sub txtCodigoProducto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodigoProducto.TextChanged
    '    If bolActivaBusquedaKey = True Then
    '        Dim Otro As New clsOtrosGastosBUS
    '        Dim dtConceptos As DataTable = Otro.fncConceptosBusquedaListaBUS(Me.txtCodigoProducto.Text)
    '        If fncValidaDataTable(dtConceptos) Then
    '            fncSetDataTableInDGV(dtConceptos, dgvConcepto)
    '        End If
    '    End If

    'End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub txtCodigoCliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            If bolEsBusquedaAutomaticaCliente = True Then
                If intIdCliente <> 0 Then
                    bolEsBusquedaAutomaticaCliente = False
                    Me.txtCodigoCliente.Text = Me.strCodigoClienteBusquedaActual
                    bolEsBusquedaAutomaticaCliente = True
                    Me.ActiveControl = Me.dtpFechaVenta
                Else
                    Me.ActiveControl = Me.txtNombreCliente
                    Me.txtNombreCliente.Select(0, Me.txtNombreCliente.Text.Length)
                    ''Me.ActiveControl = Me.btnAgregarDetalle
                    ''Me.btnAgregarDetalle.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub txtCodigoCliente_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodigoCliente.TextChanged
        If bolEsBusquedaAutomaticaCliente = True Then
            Dim Venta As New clsVentaBUS
            Dim dtVenta As DataTable = Venta.fncBuscarTop1ClienteBUS(Me.txtCodigoCliente.Text)
            If fncValidaDataTable(dtVenta) Then
                bolEsBusquedaAutomaticaCliente = False
                ''Me.txtProveedorRUC.Text = ObtenerValorCelda(dtCompra.Rows(0), "DocumentoIdentidad")
                Me.strCodigoClienteBusquedaActual = ObtenerValorCelda(dtVenta.Rows(0), "DocumentoIdentidad")
                Me.txtNombreCliente.Text = ObtenerValorCelda(dtVenta.Rows(0), "CLInombre")
                Me.intIdCliente = ObtenerValorCelda(dtVenta.Rows(0), "IdCliente")
                Me.lblCodigoCliente.Text = Me.intIdCliente
                bolEsBusquedaAutomaticaCliente = True
            Else

                Me.strCodigoClienteBusquedaActual = String.Empty
                Me.txtNombreCliente.Text = String.Empty
                Me.intIdCliente = New Integer
                Me.lblCodigoCliente.Text = "0"

            End If
        End If
    End Sub


    Sub BuscarProductoBase(Optional ByVal strCodigo As String = "", Optional ByVal strDescripcion As String = "", Optional ByVal strBusqueda As String = "")
        intIdProducto = 0
        intCantidadProducto = 0
        Me.dgvProducto.Rows.Clear()
        Dim Producto As New clsProductoBUS
        Dim dtProductoBase As DataTable = Producto.fncListarProductoPorCamposTop10BUS(strCodigo, strDescripcion, enmEstado.Activo, -1, strBusqueda)
        If fncValidaDataTable(dtProductoBase) Then
            For Each row In dtProductoBase.Rows
                Me.dgvProducto.Rows.Add()
                With Me.dgvProducto.Rows(Me.dgvProducto.Rows.Count - 1)
                    .Cells("subIdProducto").Value = ObtenerValorCelda(row, "IdProducto")
                    .Cells("subCodigoProducto").Value = ObtenerValorCelda(row, "PROnombre")
                    .Cells("subDescripcionProducto").Value = ObtenerValorCelda(row, "PROdescripcion")
                    .Cells("subStockActual").Value = CInt(ObtenerValorCelda(row, "StockActual"))
                    .Cells("subIdMedida").Value = ObtenerValorCelda(row, "IdMedida")
                    .Cells("subCosteSinIGV").Value = ObtenerValorCelda(row, "CosteSinIGV")
                    .Cells("subCosteConIGV").Value = ObtenerValorCelda(row, "CosteConIGV")
                    .Cells("subCosteIGV").Value = ObtenerValorCelda(row, "IGVCoste")
                    .Cells("subPrecioSinIGV").Value = ObtenerValorCelda(row, "PrecioSinIGV")
                    .Cells("subPrecioConIGV").Value = ObtenerValorCelda(row, "PrecioNetoConIGV")
                    .Cells("subStockMinimo").Value = ObtenerValorCelda(row, "PROstockmin")
                End With
            Next
        End If
    End Sub


    Private Sub txtCodigoProducto_KeyDownEspecifico(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoProducto.KeyDown
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.Down Then
            bolTextChange = False
            txtCodigoProducto.Text = String.Empty
            Me.ActiveControl = txtDescripcionProducto
            txtDescripcionProducto.Select(0, txtDescripcionProducto.Text.Length)
            bolTextChange = True
        End If
    End Sub

    Private Sub txtDescripcionProducto_KeyDownEspecifico(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcionProducto.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Then
            bolTextChange = False
            txtDescripcionProducto.Text = String.Empty
            Me.ActiveControl = txtCodigoProducto
            txtDescripcionProducto.Select(0, txtCodigoProducto.Text.Length)
            bolTextChange = True
        End If
    End Sub

    Private Sub txtCodigoProducto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoProducto.KeyDown, txtDescripcionProducto.KeyDown, dgvProducto.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    ''  BuscarProductoBase(txtCodigoProducto.Text, txtDescripcionProducto.Text)
        'Else
        If e.KeyCode = Keys.Enter Then
            If Me.dgvProducto.Rows.Count > 0 AndAlso Me.dgvProducto.CurrentRow IsNot Nothing Then
                SeleccionaProducto()
            Else
                'If Me.txtCodigoProducto.Text.Trim.Length > 0 And Me.txtDescripcionProducto.Text.Trim.Length > 0 Then
                '    intIdProducto = 0
                '    Me.lblTituloPanel.Text = "Nuevo Producto"
                '    Controles_En_NuevoProducto()
                'Else
                intIdProducto = 0
                intCantidadProducto = New Integer
                Notificar("Debe Seleccionar un Producto", "Advertencia")
                Exit Sub
                ''End If
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            bolTextChange = False
            Me.txtCodigoProducto.Text = String.Empty
            Me.txtDescripcionProducto.Text = String.Empty
            Me.intIdProducto = New Integer
            intCantidadProducto = New Integer
            bolTextChange = True
        ElseIf e.KeyCode = Keys.Escape Then
            Me.btnCancelar.PerformClick()
            Me.ActiveControl = Me.btnAgregarDetalle
        End If
    End Sub

    Sub SeleccionaProducto()
        With Me.dgvProducto.CurrentRow
            bolTextChange = False
            Me.nudCantidad.Text = If(.Cells("subStockActual").Value >= 0, .Cells("subStockActual").Value, 0)
            Me.intIdProducto = .Cells("subIdProducto").Value
            Me.intCantidadProducto = If(.Cells("subStockActual").Value >= 0, .Cells("subStockActual").Value, 0)
            Me.txtCodigoProducto.Text = .Cells("subCodigoProducto").Value
            Me.txtDescripcionProducto.Text = .Cells("subDescripcionProducto").Value
            Me.cmbUnidadMedida.SelectedValue = .Cells("subIdMedida").Value
            ''Me.txtCosto.Text = .Cells("subPrecioSinIGV").Value
            bolPivot = False
            Me.txtPrecioUnitario.Text = FormatearNumero(fncForzarDecimal(.Cells("subPrecioConIGV").Value), 2)
        End With

        Controles_En_ProductoSeleccionado()
        bolTextChange = True
        Me.ActiveControl = Me.nudCantidad
        Me.nudCantidad.Select(0, Me.nudCantidad.Text.Length)
    End Sub

    Private Sub dtpFechaVenta_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpFechaVenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnConfirmarGasto.PerformClick()
        End If
    End Sub

    Private Sub txtCodigoProducto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodigoProducto.TextChanged
        If bolTextChange = True Then
            BuscarProductoBase(strCodigo:=txtCodigoProducto.Text)
        End If
    End Sub

    Private Sub txtDescripcionProducto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDescripcionProducto.TextChanged
        If bolTextChange = True Then
            BuscarProductoBase(strDescripcion:=txtDescripcionProducto.Text)
        End If
    End Sub

    Private Sub dgvProducto_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProducto.CellDoubleClick
        If Me.dgvProducto.Rows.Count > 0 AndAlso Me.dgvProducto.CurrentRow IsNot Nothing Then
            SeleccionaProducto()
        End If
    End Sub

    Private Sub nudCantidad_TextChanged(sender As System.Object, e As System.EventArgs) Handles nudCantidad.TextChanged, txtPrecioUnitario.TextChanged
        txtPrecioTotal.Text = fncRound2(fncForzarDecimal(Me.nudCantidad.Text) * fncForzarDecimal(Me.txtPrecioUnitario.Text))
    End Sub

    Private Sub nudCantidad_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles nudCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.txtPrecioUnitario
            Me.txtCodigoCliente.Select(0, Me.txtCodigoCliente.Text.Length)
        End If
    End Sub

    Private Sub btnExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExcel.Click
        If fncValidaDataTable(dtBusquedaActual) Then
            FncDataTable2Excel(dtBusquedaActual, "Reporte")
        Else
            NotificarError(New Exception("No existe data"), "001", My.Settings.IdUltimoUsuario)
        End If
    End Sub

    Private Sub cmbAnio_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmbAnio.SelectionChangeCommitted, cmbMes.SelectionChangeCommitted
        MostrarDatos(Me.cmbMes.SelectedValue, Me.cmbAnio.SelectedValue)
    End Sub
End Class