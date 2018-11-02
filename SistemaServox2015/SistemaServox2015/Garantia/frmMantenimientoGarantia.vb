Imports SistemaServox2015BUS
Imports pryUtil.clsUtil
Imports System.Net

Public Class frmMantenimientoGarantia



    Private intIdGarantia As New Integer
    Private intIdDetalleGarantia As New Integer
    Private intIdProveedor As New Integer
    Private intIdProducto As New Integer
    Private intCantidadProducto As New Integer
    Private decIGVVenta As New Decimal
    Private bolEsDetalleModifica As New Boolean
    Private bolEsVentaNueva As New Boolean
    Private bolPivot As Boolean = True
    Private bolTextChange As Boolean = True
    Private bolEsBusquedaAutomaticaCliente As Boolean = False
    Private strCodigoClienteBusquedaActual As String = String.Empty
    Public bolEsFactura As New Boolean

#Region "Controles"

    Sub ValoresPorDefecto()
        Dim Garantia As New clsGarantiaBUS
        If bolEsFactura = True Then
            Me.txtSerie.Text = If(My.Settings.UltimaSerieGarantia.Trim.Length = 0, "G001", My.Settings.UltimaSerieGarantia)
            Me.txtNumero.Text = Garantia.fncRetornaNumeroSiguientePorComprobanteYSerie(enmTipoComprobante.Factura, If(Me.txtSerie.Text.Length = 0, "G001", Me.txtSerie.Text))
        Else
            Me.txtSerie.Text = If(My.Settings.UltimaSerieGarantia.Trim.Length = 0, "G001", My.Settings.UltimaSerieGarantia)
            Me.txtNumero.Text = Garantia.fncRetornaNumeroSiguientePorComprobanteYSerie(enmTipoComprobante.Boleta, If(Me.txtSerie.Text.Length = 0, "G001", Me.txtSerie.Text))
        End If


        Me.dgvDetalleGarantia.Rows.Clear()
        Me.dgvProducto.Rows.Clear()
        Me.txtProveedorNombre.Text = String.Empty
        Me.txtProveedorRUC.Text = String.Empty
        Me.txtDescripcion.Text = String.Empty
        Me.txtObservacion.Text = String.Empty
        Me.txtSubTotal.Text = "0.00"
        Me.txtTotalIGV.Text = "0.00"
        Me.txtTotal.Text = "0.00"
        Me.rbPendiente.Checked = True

        If bolEsFactura = True Then
            Me.dtpFechaVenta.Value = If(My.Settings.UltimaFechaProforma.Year <= 2000, FechaHoraServidor.Date, My.Settings.UltimaFechaProforma)
        Else
            Me.dtpFechaVenta.Value = If(My.Settings.UltimaFechaProforma.Year <= 2000, FechaHoraServidor.Date, My.Settings.UltimaFechaProforma)
        End If
        ''Me.dtpFechaVenta.Value = FechaHoraServidor.Date
        Me.txtIGV.Text = FormatearNumero(fncRound2(My.Settings.IGV), 2)
        bolEsBusquedaAutomaticaCliente = True

        chkActualizarPrecioVenta.Checked = My.Settings.ActualizarPrecioVenta

    End Sub

    Sub Controles_En_Load()

        Me.intIdGarantia = New Integer
        Me.intIdDetalleGarantia = New Integer
        Me.intIdProducto = New Integer
        Me.intCantidadProducto = New Integer
        Me.intIdProveedor = New Integer
        Me.bolEsVentaNueva = True

        Dim Periodo As New clsPeriodo
        SetComboBox(cmbAnioPeriodo, Periodo.fncListaPeriodoPorOperacionBUS(2), "Anio", "Anio")

        Dim TipoComprobante As New clsTipoComprobanteBUS
        SetComboBox(cmbTipoComprobante, TipoComprobante.fncTipoComprobanteBUS(enmEstado.Activo), "Abreviacion", "IdTipoComprobante")



        Dim UnidadMedida As New clsUnidadMedidaBUS
        SetComboBox(cmbUnidadMedida, UnidadMedida.fncListarUnidadMedidaBUS(enmEstado.Activo), "Abreviacion", "IdMedida")

        Me.txtIGV.Text = FormatearNumero(decIGVVenta, 2)

        Me.cmbTipoComprobante.Enabled = False
        Me.txtSerie.Enabled = False
        Me.txtNumero.Enabled = False
        Me.btnBuscarFactura.Enabled = True
        Me.btnBuscarProveedor.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.dtpFechaVenta.Enabled = False
        Me.txtIGV.Enabled = False
        Me.txtProveedorRUC.Enabled = False
        Me.grpEstadoProceso.Enabled = False

        Me.btnAgregarDetalle.Enabled = False
        Me.btnModificarDetalle.Enabled = False
        Me.btnQuitarDetalle.Enabled = False
        Me.txtObservacion.Enabled = False
        Me.btnCodigosProducto.Enabled = False
        Me.grpNavegar.Enabled = True

        Me.btnCancelar.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.btnNuevo.Enabled = True
        Me.btnAnular.Enabled = True
        Me.btnModificar.Enabled = True
        ''Me.txtSerie.Text = My.Settings.UltimoSerieCompra
        Me.lblCodigoCliente.Text = Me.intIdProveedor
        Me.cmbTipoComprobante.SelectedValue = If(bolEsFactura = True, enmTipoComprobante.Factura, enmTipoComprobante.Boleta)
        ValoresPorDefecto()

        Me.ActiveControl = Me.btnNuevo

    End Sub

    Sub Controles_En_ModificarProducto()
        Me.pnlControlProducto.Visible = True
        Me.pnlControlProducto.Location = New Point(Me.grpCabecera.Location.X + Me.grpCabecera.Width / 20, Me.grpCabecera.Location.Y + 100)
        Me.txtCodigoProducto.Enabled = False
        Me.txtDescripcionProducto.Enabled = False
        Me.cmbUnidadMedida.Enabled = False
        Me.btnConfirmarProducto.Enabled = True
        Me.nudCantidad.Enabled = True
        Me.chkActualizarPrecioVenta.Checked = My.Settings.ActualizarPrecioVenta
    End Sub

    Sub Controles_En_Producto()

        Me.tbcVentas.Enabled = False
        Me.cmbUnidadMedida.Enabled = False
        Me.nudCantidad.Enabled = False
        Me.btnConfirmarProducto.Enabled = False
    End Sub

    Sub Controles_En_NuevoProducto()
        bolTextChange = False
        Me.cmbUnidadMedida.Enabled = True
        Me.nudCantidad.Enabled = True
        Me.btnConfirmarProducto.Enabled = True
        Me.txtCodigoProducto.Enabled = True
        Me.txtCodigoProducto.Text = ""
        Me.txtDescripcionProducto.Text = ""
        Me.txtCosto.Text = "0.00"
        Me.txtIGVCosto.Text = "0.00"
        Me.txtCostoConIGV.Text = "0.00"
        Me.txtDescripcionProducto.Enabled = True
        Me.txtCosto.Enabled = True
        Me.txtIGVCosto.Enabled = True
        Me.txtCostoConIGV.Enabled = True
        bolTextChange = True
        chkActualizarPrecioVenta.Checked = My.Settings.ActualizarPrecioVenta
    End Sub

    Sub Controles_En_ProductoSeleccionado()
        Me.cmbUnidadMedida.Enabled = False
        Me.nudCantidad.Enabled = True
        Me.btnConfirmarProducto.Enabled = True
    End Sub

    Sub Controles_En_CancelarProducto()
        Me.tbcVentas.Enabled = True
        Me.pnlControlProducto.Visible = False
        Me.dgvProducto.Rows.Clear()

    End Sub

    Sub Controles_En_NuevaOperacion()

        Me.bolEsVentaNueva = True
        Me.intIdGarantia = New Integer
        Me.intIdDetalleGarantia = New Integer
        Me.intIdProducto = New Integer
        Me.intCantidadProducto = New Integer
        Me.intIdProveedor = New Integer

        Me.grpNavegar.Enabled = False
        ''Me.cmbTipoComprobante.Enabled = True
        Me.txtSerie.Enabled = True
        Me.txtNumero.Enabled = True
        Me.btnBuscarFactura.Enabled = False
        Me.btnBuscarProveedor.Enabled = True
        Me.txtProveedorRUC.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.dtpFechaVenta.Enabled = True
        Me.txtIGV.Enabled = True
        Me.grpEstadoProceso.Enabled = True

        Me.btnAgregarDetalle.Enabled = True
        Me.btnModificarDetalle.Enabled = True
        Me.btnQuitarDetalle.Enabled = True
        Me.txtObservacion.Enabled = True
        Me.btnCodigosProducto.Enabled = True

        Me.btnNuevo.Enabled = False
        Me.btnModificar.Enabled = False
        Me.btnAnular.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True

        ValoresPorDefecto()


    End Sub

    Sub Controles_En_ModificarOperacion()

        Me.bolEsVentaNueva = False
        'Me.intIdProforma = New Integer
        Me.intIdDetalleGarantia = New Integer
        Me.intIdProducto = New Integer
        Me.intCantidadProducto = New Integer
        'Me.intIdCliente = New Integer

        Me.grpNavegar.Enabled = False
        ''   Me.cmbTipoComprobante.Enabled = True
        Me.txtSerie.Enabled = True
        Me.txtNumero.Enabled = True
        Me.btnBuscarFactura.Enabled = False
        Me.btnBuscarProveedor.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.dtpFechaVenta.Enabled = True
        Me.txtIGV.Enabled = True
        Me.grpEstadoProceso.Enabled = True

        Me.btnAgregarDetalle.Enabled = True
        Me.btnModificarDetalle.Enabled = True
        Me.btnQuitarDetalle.Enabled = True
        Me.txtObservacion.Enabled = True
        Me.btnCodigosProducto.Enabled = True

        Me.btnNuevo.Enabled = False
        Me.btnModificar.Enabled = False
        Me.btnAnular.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True

    End Sub
#End Region

    Sub LlenarDatosPorVenta(ByVal intIdGarantia As Integer)
        bolEsBusquedaAutomaticaCliente = False
        Dim Garantia As New clsGarantiaBUS
        '' Dim DetalleCompra As New clsDetalleCompraBUS
        Dim dtBase As DataTable() = Garantia.fncGarantiasPorIdentificador(intIdGarantia)
        If fncValidaDataTable(dtBase(0)) Then

            Me.dgvDetalleGarantia.Rows.Clear()
            Me.cmbAnioPeriodo.SelectedValue = CDate(ObtenerValorCelda(dtBase(0).Rows(0), "FechaGarantia")).Year
            Me.intIdGarantia = ObtenerValorCelda(dtBase(0).Rows(0), "IdGarantia")
            Me.txtSerie.Text = ObtenerValorCelda(dtBase(0).Rows(0), "Serie")
            Me.txtNumero.Text = ObtenerValorCelda(dtBase(0).Rows(0), "Numero")
            Me.txtDescripcion.Text = ObtenerValorCelda(dtBase(0).Rows(0), "Descripcion")
            Me.cmbTipoComprobante.SelectedValue = ObtenerValorCelda(dtBase(0).Rows(0), "IdTipoComprobante")
            Me.intIdProveedor = ObtenerValorCelda(dtBase(0).Rows(0), "IdProveedor")
            Me.txtProveedorRUC.Text = Me.intIdProveedor
            Me.txtProveedorRUC.Text = ObtenerValorCelda(dtBase(0).Rows(0), "DocumentoIdentidad") '' ObtenerValorCelda(dtBase(0).Rows(0), "TipoDocumento") & " : " & ObtenerValorCelda(dtBase(0).Rows(0), "DocumentoIdentidad")
            Me.txtProveedorNombre.Text = ObtenerValorCelda(dtBase(0).Rows(0), "PRVnombre")
            Me.decIGVVenta = ObtenerValorCelda(dtBase(0).Rows(0), "IGV")
            Me.txtIGV.Text = FormatearNumero(decIGVVenta, 2)
            Dim intIdEstadoProceso As Integer = ObtenerValorCelda(dtBase(0).Rows(0), "EstadoProceso")
            Select Case intIdEstadoProceso
                Case enmEstadoGarantia.Pendiente
                    Me.rbPendiente.Checked = True
                Case enmEstadoGarantia.PasoGarantia
                    Me.rbAceptada.Checked = True
                Case enmEstadoGarantia.NoPasoGarantia
                    Me.rbNoAceptada.Checked = True
            End Select
            Me.txtObservacion.Text = ObtenerValorCelda(dtBase(0).Rows(0), "Observacion")
            Me.dtpFechaVenta.Value = CDate(ObtenerValorCelda(dtBase(0).Rows(0), "FechaGarantia")).ToString("dd/MM/yyyy")
            ''   If fncValidaDataTable(dtBase(1)) Then
            LlenarDetalleVenta(dtBase(1))
        End If
        bolEsBusquedaAutomaticaCliente = True
    End Sub

    Sub LlenarDatosPorOrdenCompra(ByVal intIdCompraActual As Integer, ByVal intOrden As Integer, ByVal intAnioPeriodo As Integer)
        bolEsBusquedaAutomaticaCliente = False
        Dim Garantia As New clsGarantiaBUS
        '' Dim DetalleCompra As New clsDetalleCompraBUS
        Dim dtBase As DataTable() = Garantia.fncGarantiasPorOrden(intAnioPeriodo, , "1", intOrden, intIdCompraActual, )
        If fncValidaDataTable(dtBase(0)) Then
            Me.dgvDetalleGarantia.Rows.Clear()
            Me.intIdGarantia = ObtenerValorCelda(dtBase(0).Rows(0), "IdGarantia")
            Me.txtSerie.Text = ObtenerValorCelda(dtBase(0).Rows(0), "Serie")
            Me.txtNumero.Text = ObtenerValorCelda(dtBase(0).Rows(0), "Numero")
            Me.txtDescripcion.Text = ObtenerValorCelda(dtBase(0).Rows(0), "Descripcion")
            Me.cmbTipoComprobante.SelectedValue = ObtenerValorCelda(dtBase(0).Rows(0), "IdTipoComprobante")
            Me.intIdProveedor = ObtenerValorCelda(dtBase(0).Rows(0), "IdProveedor")
            Me.txtProveedorRUC.Text = Me.intIdProveedor
            Me.txtProveedorRUC.Text = ObtenerValorCelda(dtBase(0).Rows(0), "DocumentoIdentidad") '' ObtenerValorCelda(dtBase(0).Rows(0), "TipoDocumento") & " : " & ObtenerValorCelda(dtBase(0).Rows(0), "DocumentoIdentidad")
            Me.txtProveedorNombre.Text = ObtenerValorCelda(dtBase(0).Rows(0), "PRVnombre")
            Me.decIGVVenta = ObtenerValorCelda(dtBase(0).Rows(0), "IGV")
            Me.txtIGV.Text = FormatearNumero(decIGVVenta, 2)
            Dim intIdEstadoProceso As Integer = ObtenerValorCelda(dtBase(0).Rows(0), "EstadoProceso")
            Select Case intIdEstadoProceso
                Case enmEstadoGarantia.Pendiente
                    Me.rbPendiente.Checked = True
                Case enmEstadoGarantia.PasoGarantia
                    Me.rbAceptada.Checked = True
                Case enmEstadoGarantia.NoPasoGarantia
                    Me.rbNoAceptada.Checked = True
            End Select
            Me.txtObservacion.Text = ObtenerValorCelda(dtBase(0).Rows(0), "Observacion")
            Me.dtpFechaVenta.Value = CDate(ObtenerValorCelda(dtBase(0).Rows(0), "FechaGarantia")).ToString("dd/MM/yyyy")
            ''   If fncValidaDataTable(dtBase(1)) Then
            LlenarDetalleVenta(dtBase(1))
            ''End If
        End If
        bolEsBusquedaAutomaticaCliente = True
    End Sub

    Sub LlenarDetalleVenta(ByVal dtDetalle As DataTable)




        Me.dgvDetalleGarantia.Rows.Clear()
        If fncValidaDataTable(dtDetalle) Then
            For Each row In dtDetalle.Rows
                Me.dgvDetalleGarantia.Rows.Add()
                With dgvDetalleGarantia.Rows(dgvDetalleGarantia.Rows.Count - 1)
                    .Cells("IdDetalleVenta").Value = ObtenerValorCelda(row, "IdDetalleGarantia")
                    .Cells("IdProducto").Value = ObtenerValorCelda(row, "IdProducto")
                    .Cells("CodigoProducto").Value = ObtenerValorCelda(row, "PROnombre")
                    .Cells("DescripcionProducto").Value = ObtenerValorCelda(row, "PROdescripcion")
                    .Cells("IdUnidadMedida").Value = ObtenerValorCelda(row, "IdMedida")
                    .Cells("UnidadMedida").Value = ObtenerValorCelda(row, "UnidadMedida")
                    .Cells("Cantidad").Value = FormatearNumero(ObtenerValorCelda(row, "Cantidad"), 1)
                    .Cells("PrecioUnidadSinIGV").Value = FormatearNumero(ObtenerValorCelda(row, "PrecioUnidadSinIGV"), 2)
                    .Cells("PrecioUnidadIGV").Value = FormatearNumero(ObtenerValorCelda(row, "UnidadIGV"), 2)
                    .Cells("PrecioUnidadConIGV").Value = FormatearNumero(ObtenerValorCelda(row, "PrecioUnidadConIGV"), 2)
                    .Cells("PrecioTotalSinIGV").Value = FormatearNumero(ObtenerValorCelda(row, "PrecioTotalSinIGV"), 2)

                    .Cells("PrecioTotalIGV").Value = FormatearNumero(ObtenerValorCelda(row, "TotalIGV"), 2)

                    .Cells("PrecioTotalConIGV").Value = FormatearNumero(ObtenerValorCelda(row, "PrecioTotalConIGV"), 2)
                    .Cells("Estado").Value = ObtenerValorCelda(row, "Estado")
                    .Cells("ObservacionDetalle").Value = ObtenerValorCelda(row, "ObservacionDetalle")
                End With
            Next


            'Me.txtSubTotal.Text = Formatear(decSubTotal, 2)
            'Me.txtTotalIGV.Text = Formatear(decTotalIGV, 2)
            'Me.txtTotal.Text = Formatear(decTotalFinal, 2)
        End If

        LlenarTotalesOperacion()

        Me.dgvDetalleGarantia.ClearSelection()
        Me.dgvDetalleGarantia.Refresh()
    End Sub

    Sub LlenarTotalesOperacion()
        Dim decSubTotal As New Decimal
        Dim decTotalIGV As New Decimal
        Dim decTotalFinal As New Decimal

        If dgvDetalleGarantia.Rows.Count > 0 Then
            For i As Integer = 0 To dgvDetalleGarantia.Rows.Count - 1
                If dgvDetalleGarantia.Rows(i).Visible = True Then
                    decSubTotal += fncForzarDecimal(dgvDetalleGarantia.Rows(i).Cells("PrecioTotalSinIGV").Value)
                    decTotalIGV += fncForzarDecimal(dgvDetalleGarantia.Rows(i).Cells("PrecioTotalIGV").Value)
                    decTotalFinal += fncForzarDecimal(dgvDetalleGarantia.Rows(i).Cells("PrecioTotalConIGV").Value)
                End If
            Next

        End If

        Me.txtSubTotal.Text = FormatearNumero(decSubTotal, 2)
        Me.txtTotalIGV.Text = FormatearNumero(decTotalIGV, 2)
        Me.txtTotal.Text = FormatearNumero(decTotalFinal, 2)

    End Sub


    Private Sub frmMantenimientoVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.decIGVVenta = My.Settings.IGV
        Controles_En_Load()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarProveedor.Click
        Dim ObjFrmHijo As New frmMantenimientoProveedor
        'ObjFrmHijo.pFormularioPadrePTA = Me.Name
        'ObjFrmHijo.bolEsBusqueda = True
        'ObjFrmHijo.Owner = Me
        'ObjFrmHijo.ShowDialog()
        ObjFrmHijo.bolEnviar = True
        ObjFrmHijo.bolEsModificar = False
        If ObjFrmHijo.ShowDialog = Windows.Forms.DialogResult.OK Then


            With ObjFrmHijo.dgvProveedor.CurrentRow
                bolEsBusquedaAutomaticaCliente = False
                Me.intIdProveedor = .Cells("IdProveedor").Value
                Me.txtProveedorRUC.Text = .Cells("DocumentoIdentidad").Value '' .Cells("Tipo").Value & " : " & .Cells("DocumentoIdentidad").Value
                Me.txtProveedorNombre.Text = .Cells("Nombre").Value
                bolEsBusquedaAutomaticaCliente = True
                ''SeteaNodo(.Cells("IdPtaDependencia").Value)
            End With

        End If
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        LlenarDatosPorOrdenCompra(intIdGarantia, enmOrden.Primero, cmbAnioPeriodo.SelectedValue)
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        LlenarDatosPorOrdenCompra(intIdGarantia, enmOrden.Atras, cmbAnioPeriodo.SelectedValue)
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        LlenarDatosPorOrdenCompra(intIdGarantia, enmOrden.Siguiente, cmbAnioPeriodo.SelectedValue)
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        LlenarDatosPorOrdenCompra(intIdGarantia, enmOrden.Ultimo, cmbAnioPeriodo.SelectedValue)
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Controles_En_NuevaOperacion()
        Me.ActiveControl = Me.txtSerie
        Me.txtSerie.Select(0, Me.txtSerie.Text.Length)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If pnlControlProducto.Visible = True Then
            Notificar("Termine la operación.")
            Exit Sub

        End If
        ErrorVentas.Clear()
        Controles_En_Load()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If intIdGarantia > 0 Then
            Controles_En_ModificarOperacion()
            Me.ActiveControl = Me.txtProveedorRUC
            Me.txtProveedorRUC.Select(0, Me.txtProveedorRUC.Text.Length)
        Else
            Notificar("Debe seleccionar una operación a Modificar.")
        End If
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        If fncDetalleVisible(dgvDetalleGarantia) > 0 Then
            Notificar("No puede eliminar este comprobante sin antes eliminar todo el detalle.")
            Exit Sub
        End If

        If MsgBox("¿Está seguro de que desea anular este comprobante?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            If intIdGarantia > 0 Then
                Dim Garantia As New clsGarantiaBUS
                Dim DetalleGarantia As New clsDetalleGarantiaBUS

                Dim dtProforma As DataTable = Garantia.fncConsultarBUS(Me.intIdGarantia)
                If fncValidaDataTable(dtProforma) Then
                    Garantia.fncSetearBUS(dtProforma.Rows(0))
                    With Garantia
                        .Estado = enmEstado.Inactivo
                        .FechaModifica = FechaHoraServidor()
                        .UsuarioModifica = My.Settings.Usuario
                        If .fncModificarBUS() > 0 Then

                            Dim dtDetalleProforma As DataTable = DetalleGarantia.fncListarDetallePorGarantiaBUS(Me.intIdGarantia)

                            For Each row In dtDetalleProforma.Rows
                                Dim intIdDetalleProforma As Integer = ObtenerValorCelda(row, "IdDetalleVenta")
                                Dim dtDetalle = DetalleGarantia.fncConsultarBUS(intIdDetalleProforma)
                                If fncValidaDataTable(dtDetalle) Then
                                    DetalleGarantia.fncSetearBUS(dtDetalle.Rows(0))
                                    DetalleGarantia.Estado = enmEstado.Inactivo
                                    DetalleGarantia.FechaModifica = FechaHoraServidor()
                                    DetalleGarantia.fncModificarBUS()

                                End If
                            Next

                            Notificar("Comprobante Anulado")
                            Dim intIdGarantiaProvisional As Integer = intIdGarantia
                            Controles_En_Load()
                            LlenarDatosPorVenta(intIdGarantiaProvisional)
                        End If
                    End With
                End If
            Else
                Notificar("Debe seleccionar una operación a Anular.")
            End If
        End If

    End Sub

    Private Sub btnAgregarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDetalle.Click
        If Me.intIdProveedor > 0 Then
            Me.pnlControlProducto.Visible = True
            Me.pnlControlProducto.Location = New Point(Me.grpCabecera.Location.X + Me.grpCabecera.Width / 20, Me.grpCabecera.Location.Y + Me.grpCabecera.Location.Y / 2)
            decIGVVenta = fncForzarDecimal(Me.txtIGV.Text) '' / 100
            Me.lblProductoIGV.Text = "IGV " & FormatearNumero(decIGVVenta, 2)

            bolEsDetalleModifica = False
            Controles_En_NuevoProducto()
            Me.ActiveControl = txtCodigoProducto
            ErrorVentas.SetError(Me.txtProveedorRUC, Nothing)
        Else
            If IsNumeric(Me.txtProveedorRUC.Text) = True And Me.txtProveedorRUC.Text.Trim.Length = 11 And Me.txtProveedorNombre.Text.Trim.Length > 0 Then
                Dim Proveedor As New clsProveedorBUS
                If Proveedor.fncValidaDocumento(enmTipoDocumento.RUC, Me.txtProveedorRUC.Text) = False Then
                    If MsgBox("Se registrará un nuevo Proveedor con RUC: " & Me.txtProveedorRUC.Text & vbCrLf & "Descripción: " & Me.txtProveedorNombre.Text & vbCrLf & "¿Desea continuar?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                        Dim NuevoProveedor As New clsProveedorBUS(Me.txtProveedorRUC.Text _
                                                              , Me.txtProveedorNombre.Text _
                                                              , String.Empty _
                                                              , String.Empty _
                                                              , String.Empty _
                                                              , String.Empty _
                                                              , FechaHoraServidor _
                                                              , "Registro Automático" _
                                                              , 0 _
                                                              , enmEstado.Activo _
                                                              , FechaHoraServidor _
                                                              , My.Settings.Usuario _
                                                              , enmTipoDocumento.RUC _
                                                              , Me.txtProveedorRUC.Text _
                                                              , "General")
                        If NuevoProveedor.fncRegistrarBUS > 0 Then
                            intIdProveedor = NuevoProveedor.IdProveedor
                            Notificar("Se ha registrado un nuevo proveedor.", "ATENCIÓN")
                            Me.ActiveControl = Me.btnAgregarDetalle
                            btnAgregarDetalle.PerformClick()

                        End If
                    End If

                Else
                    Notificar("Este número de RUC ya está en uso.", "ERROR")
                End If
            Else
                Notificar("Ingrese un número de RUC válido, así como una descripción de Proveedor válida.", "ERROR")
            End If

            '' Notificar("Debe Seleccionar un Proveedor")
            ''ErrorVentas.SetError(Me.txtCodigoCliente, "Debe Seleccionar un Proveedor")
        End If
    End Sub

    Private Sub btnModificarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarDetalle.Click
        Controles_En_ModificarProducto()
        If Me.dgvDetalleGarantia.CurrentRow IsNot Nothing Then
            bolEsDetalleModifica = True
            With Me.dgvDetalleGarantia.CurrentRow
                bolTextChange = False
                Me.intIdProducto = .Cells("IdProducto").Value
                Me.txtCodigoProducto.Text = .Cells("CodigoProducto").Value
                Me.txtDescripcionProducto.Text = .Cells("DescripcionProducto").Value
                Me.cmbUnidadMedida.SelectedValue = .Cells("IdUnidadMedida").Value
                Me.nudCantidad.Text = .Cells("Cantidad").Value
                bolPivot = False
                'Me.txtCosto.Text = fncForzarDecimal(.Cells("PrecioUnidadSinIGV").Value)
                'Me.txtIGVCosto.Text = fncForzarDecimal(.Cells("PrecioUnidadSinIGV").Value)
                Me.txtCostoConIGV.Text = FormatearNumero(fncForzarDecimal(.Cells("PrecioUnidadConIGV").Value), 2)

                'Me.txtTotalSinIGV.Text = FormatearNumero(fncForzarDecimal(.Cells("PrecioTotalSinIGV").Value), 2)
                'Me.txtTotalIGV.Text = FormatearNumero(fncForzarDecimal(.Cells("PrecioTotalIGV").Value), 2)
                'Me.txtTotalConIGV.Text = FormatearNumero(fncForzarDecimal(.Cells("PrecioTotalConIGV").Value), 2)

                Me.intIdDetalleGarantia = .Cells("IdDetalleVenta").Value
                Me.rtbObservacionDetalle.Text = .Cells("ObservacionDetalle").Value
                Me.ActiveControl = Me.nudCantidad
                Me.nudCantidad.Select(0, nudCantidad.Text.Length)
                bolTextChange = True
            End With


        Else
            Notificar("Debe seleccionar un item del detalle.")
        End If
    End Sub

    Private Sub btnQuitarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarDetalle.Click
        If Me.dgvDetalleGarantia.CurrentRow IsNot Nothing Then
            Dim intIndex = Me.dgvDetalleGarantia.CurrentRow.Index
            Me.dgvDetalleGarantia.CurrentRow.Cells("Estado").Value = enmEstado.Inactivo
            Me.dgvDetalleGarantia.CurrentRow.Visible = False

            FilaInvisibleIndex(dgvDetalleGarantia, intIndex)
        End If
        Me.dgvDetalleGarantia.Refresh()
        Me.dgvDetalleGarantia.ClearSelection()
        LlenarTotalesOperacion()
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
            Me.btnCancelarProducto.PerformClick()
            Me.ActiveControl = Me.btnAgregarDetalle
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

    Private Sub btnConfirmarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmarProducto.Click
        Dim decSubTotal As New Decimal
        Dim decTotalIGV As New Decimal
        Dim decTotalFinal As New Decimal

        If bolEsDetalleModifica = False Then
            Dim bolEncontroCoincidencia As New Boolean
            If intIdProducto <> 0 Then
                For i As Integer = 0 To dgvDetalleGarantia.Rows.Count - 1
                    If dgvDetalleGarantia.Rows(i).Visible = True AndAlso intIdProducto = dgvDetalleGarantia.Rows(i).Cells("IdProducto").Value Then
                        bolEncontroCoincidencia = True
                    End If
                Next
            End If

            If bolEncontroCoincidencia = True Then
                Notificar("No puede registrar este producto dos veces en el mismo documento, pruebe modificando el registro existente.")
                Exit Sub
            End If

        End If


        If intIdProducto = 0 Then
            Notificar("Debe seleccionar un producto.")
            Exit Sub
        Else
            'If chkActualizarPrecioVenta.Checked = True Then
            '    Dim Producto As New clsProductoBUS
            '    Dim dtProducto As DataTable = Producto.fncConsultarBUS(intIdProducto)
            '    If fncValidaDataTable(dtProducto) Then
            '        Producto.fncSetearBUS(dtProducto.Rows(0))
            '        Producto.FechaModifica = FechaHoraServidor()
            '        Producto.UsuarioModifica = My.Settings.Usuario
            '        Producto.PrecioNetoConIGV = fncRound2(fncForzarDecimal(Me.txtCostoConIGV.Text))
            '        Producto.fncModificarBUS()
            '    End If
            'End If

            If bolEsDetalleModifica = True Then
                'Dim Producto As New clsProductoBUS
                'Dim intStockActual As List(Of Integer) = Producto.fncObtenerStockActualPorProducto(intIdProducto, Me.intIdDetalleGarantia)
                'If intStockActual(0) - fncForzarDecimal(Me.nudCantidad.Text) < 0 Then
                '    If MsgBox("Esta modificación de registro venderá más stock del disponible." & vbCrLf & "¿Desea continuar?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                '        Exit Sub
                '    End If
                'ElseIf intStockActual(0) - fncForzarDecimal(Me.nudCantidad.Text) <= intStockActual(1) Then
                '    If MsgBox("Esta modificación de registro venderá más stock del establecido como stock mínimo: " & intStockActual(1) & vbCrLf & "¿Desea continuar?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                '        Exit Sub
                '    End If
                'End If
            Else
                'Dim Producto As New clsProductoBUS
                'Dim intStockActual As List(Of Integer) = Producto.fncObtenerStockActualPorProducto(intIdProducto)
                'If intStockActual(0) - fncForzarDecimal(Me.nudCantidad.Text) < 0 Then
                '    If MsgBox("Esta operación venderá más stock del disponible." & vbCrLf & "¿Desea continuar?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                '        Exit Sub
                '    End If
                'ElseIf intStockActual(0) - fncForzarDecimal(Me.nudCantidad.Text) <= intStockActual(1) Then
                '    If MsgBox("Esta operación venderá más stock del establecido como stock mínimo: " & intStockActual(1) & vbCrLf & "¿Desea continuar?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                '        Exit Sub
                '    End If
                'End If
            End If
        End If


        If bolEsDetalleModifica = False Then
            Me.dgvDetalleGarantia.Rows.Add()
            With dgvDetalleGarantia.Rows(dgvDetalleGarantia.Rows.Count - 1)
                .Cells("IdDetalleVenta").Value = If(bolEsDetalleModifica = True, intIdDetalleGarantia, 0)
                .Cells("IdProducto").Value = intIdProducto
                .Cells("CodigoProducto").Value = Me.txtCodigoProducto.Text
                .Cells("DescripcionProducto").Value = Me.txtDescripcionProducto.Text
                .Cells("IdUnidadMedida").Value = cmbUnidadMedida.SelectedValue
                .Cells("UnidadMedida").Value = cmbUnidadMedida.Text
                .Cells("Cantidad").Value = FormatearNumero(fncForzarDecimal(Me.nudCantidad.Text), 1)
                .Cells("PrecioUnidadSinIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtCosto.Text), 2)
                .Cells("PrecioUnidadIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtIGVCosto.Text), 2)
                .Cells("PrecioUnidadConIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtCostoConIGV.Text), 2)
                .Cells("PrecioTotalSinIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtTotalSinIGV.Text), 2)
                '' decSubTotal += ObtenerValorCelda(row, "CostoTotalSinIGV")
                .Cells("PrecioTotalIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtIGVTotal.Text), 2)
                ''  decTotalIGV += ObtenerValorCelda(row, "CostoTotalConIGV") - ObtenerValorCelda(row, "CostoTotalSinIGV")
                .Cells("PrecioTotalConIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtTotalConIGV.Text), 2)
                .Cells("Estado").Value = enmEstado.Activo
                .Cells("ObservacionDetalle").Value = Me.rtbObservacionDetalle.Text
                '' decTotalFinal += ObtenerValorCelda(row, "CostoTotalConIGV")
            End With
        Else
            If Me.dgvDetalleGarantia.CurrentRow IsNot Nothing AndAlso Me.dgvDetalleGarantia.Rows.Count > 0 Then
                With Me.dgvDetalleGarantia.CurrentRow
                    .Cells("Cantidad").Value = FormatearNumero(fncForzarDecimal(Me.nudCantidad.Text), 1)
                    .Cells("PrecioUnidadSinIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtCosto.Text), 2)
                    .Cells("PrecioUnidadIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtIGVCosto.Text), 2)
                    .Cells("PrecioUnidadConIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtCostoConIGV.Text), 2)
                    .Cells("PrecioTotalSinIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtTotalSinIGV.Text), 2)
                    '' decSubTotal += ObtenerValorCelda(row, "CostoTotalSinIGV")
                    .Cells("PrecioTotalIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtIGVTotal.Text), 2)
                    ''  decTotalIGV += ObtenerValorCelda(row, "CostoTotalConIGV") - ObtenerValorCelda(row, "CostoTotalSinIGV")
                    .Cells("PrecioTotalConIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtTotalConIGV.Text), 2)
                    .Cells("Estado").Value = enmEstado.Activo
                    .Cells("ObservacionDetalle").Value = Me.rtbObservacionDetalle.Text
                End With
            End If
        End If

        ''   btnCancelarProducto.PerformClick()
        LlenarTotalesOperacion()
        Me.dgvDetalleGarantia.ClearSelection()
        Me.dgvDetalleGarantia.Refresh()

        If bolEsDetalleModifica = True Then
            btnCancelarProducto.PerformClick()
            Me.ActiveControl = Me.btnAgregarDetalle
        Else
            Me.txtCodigoProducto.Text = ""
            Me.txtDescripcionProducto.Text = ""
            Me.ActiveControl = Me.txtCodigoProducto
        End If

        ''   My.Settings.ActualizarPrecioVenta = chkActualizarPrecioVenta.Checked


    End Sub

    Private Sub btnCancelarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarProducto.Click
        Controles_En_CancelarProducto()
        bolPivot = True
        Me.ActiveControl = Me.btnAgregarDetalle
    End Sub

    Private Sub txtCosto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCosto.Enter
        bolPivot = True
    End Sub

    Private Sub txtCostoConIGV_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCostoConIGV.Enter
        bolPivot = False
    End Sub

    Private Sub txtCosto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCosto.TextChanged
        If bolPivot = True Then
            ''Dim decCosto As Decimal = fncForzarDecimal(Me.txtCosto.Text)
            Dim decIGVCalculo As Decimal = fncRound2(fncForzarDecimal(Me.txtCosto.Text) * (decIGVVenta))
            Me.txtIGVCosto.Text = FormatearNumero(decIGVCalculo, 2)
            Dim decCostoConIGV As Decimal = fncRound2(fncForzarDecimal(Me.txtCosto.Text) + decIGVCalculo)
            Me.txtCostoConIGV.Text = FormatearNumero(decCostoConIGV, 2)

            Dim decTotalSinIGV As Decimal = fncRound2(fncForzarDecimal(Me.txtCosto.Text) * fncForzarDecimal(nudCantidad.Text))
            Me.txtTotalSinIGV.Text = FormatearNumero(decTotalSinIGV, 2)
            Dim decTotalIGVCalculo As Decimal = fncRound2(decTotalSinIGV * (decIGVVenta))
            Me.txtIGVTotal.Text = FormatearNumero(decTotalIGVCalculo, 2)
            Me.txtTotalConIGV.Text = FormatearNumero(fncRound2(decTotalSinIGV + decTotalIGVCalculo), 2)
        End If
    End Sub

    Private Sub txtCostoConIGV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCostoConIGV.TextChanged
        If bolPivot = False Then
            Dim decCostoConIGV As Decimal = fncRound2(fncForzarDecimal(Me.txtCostoConIGV.Text))
            Dim decCostoSinIGV As Decimal = fncRound2(decCostoConIGV / (1 + (decIGVVenta)))
            Dim decIGVCalculo As Decimal = fncRound2(decCostoConIGV - decCostoSinIGV)

            Dim decCostoTotalConIGV As Decimal = fncRound2(decCostoConIGV * fncForzarDecimal(nudCantidad.Text))
            Dim decCostoTotalSinIGV As Decimal = fncRound2(decCostoTotalConIGV / (1 + (decIGVVenta)))
            Dim decCostoTotalIGV As Decimal = fncRound2(decCostoTotalConIGV - decCostoTotalSinIGV)

            ''Dim decTotal As Decimal = fncRound2(decCostoConIGV * nudCantidad.Value)
            Me.txtIGVCosto.Text = FormatearNumero(decIGVCalculo, 2)
            Me.txtCosto.Text = FormatearNumero(decCostoSinIGV, 2)

            Me.txtTotalSinIGV.Text = FormatearNumero(decCostoTotalSinIGV, 2)
            Me.txtIGVTotal.Text = FormatearNumero(decCostoTotalIGV, 2)
            Me.txtTotalConIGV.Text = FormatearNumero(decCostoTotalConIGV, 2)
        End If
    End Sub

    Private Sub nudCantidad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudCantidad.TextChanged

        Dim decTotalConIGV As Decimal = fncRound2(fncForzarDecimal(Me.txtCostoConIGV.Text) * fncForzarDecimal(nudCantidad.Text))

        Dim decTotalSinIGV As Decimal = fncRound2(decTotalConIGV / (1 + decIGVVenta))

        Dim decTotalIGV As Decimal = fncRound2(decTotalConIGV - decTotalSinIGV)

        Me.txtTotalSinIGV.Text = FormatearNumero(decTotalSinIGV, 2)
        Me.txtIGVTotal.Text = FormatearNumero(decTotalIGV, 2)
        Me.txtTotalConIGV.Text = FormatearNumero(decTotalConIGV, 2)
    End Sub

    Private Sub dgvProducto_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProducto.CellDoubleClick
        If Me.dgvProducto.Rows.Count > 0 AndAlso Me.dgvProducto.CurrentRow IsNot Nothing Then
            SeleccionaProducto()
        End If
    End Sub



    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click




        If bolEsVentaNueva = True Then

            If Me.txtSerie.Text.Length <= 0 Or Me.txtNumero.Text.Length <= 0 Or fncForzarDecimal(Me.txtNumero.Text.Length) <= 0 Then
                ErrorVentas.SetError(Me.txtNumero, "Especifique un número de comprobante válido")
                Exit Sub
            ElseIf intIdProveedor = 0 Then
                ErrorVentas.SetError(Me.txtProveedorRUC, "Debe especificar un Cliente.")
                Exit Sub
            Else
                ErrorVentas.SetError(Me.txtNumero, Nothing)
            End If

            Dim GarantiaValida As New clsGarantiaBUS
            Dim dtVentaValida As DataTable = GarantiaValida.fncValidaNumeroGarantiaBUS(Me.txtSerie.Text, Me.txtNumero.Text, Me.cmbTipoComprobante.SelectedValue)
            If fncValidaDataTable(dtVentaValida) Then
                ErrorVentas.SetError(Me.txtNumero, "Este número de comprobante ya se ha registrado")
                Exit Sub
            Else
                ErrorVentas.SetError(Me.txtNumero, Nothing)
            End If

            Dim Garantia As New clsGarantiaBUS(0, enmModalidadPago.Contado _
                                           , cmbTipoComprobante.SelectedValue _
                                           , Me.txtSerie.Text _
                                           , Me.txtNumero.Text _
                                           , Me.txtDescripcion.Text _
                                           , Me.txtObservacion.Text _
                                           , Me.intIdProveedor _
                                           , Me.dtpFechaVenta.Value _
                                           , Me.dtpFechaVenta.Value _
                                           , fncForzarDecimal(Me.txtIGV.Text) _
                                           , "1" _
                                           , FechaHoraServidor _
                                           , My.Settings.Usuario _
                                           , If(rbPendiente.Checked = True, enmEstadoGarantia.Pendiente, If(rbNoAceptada.Checked = True, enmEstadoGarantia.NoPasoGarantia, enmEstadoGarantia.PasoGarantia)))

            If Garantia.fncRegistrarBUS() > 0 Then
                intIdGarantia = Garantia.IdGarantia
                If intIdGarantia > 0 Then
                    For i = 0 To dgvDetalleGarantia.Rows.Count - 1
                        If dgvDetalleGarantia.Rows(i).Visible = True Then

                            Dim Detalle As New clsDetalleGarantiaBUS(0, intIdGarantia, dgvDetalleGarantia.Rows(i).Cells("IdProducto").Value _
                                                                   , dgvDetalleGarantia.Rows(i).Cells("Cantidad").Value _
                                                                   , dgvDetalleGarantia.Rows(i).Cells("PrecioUnidadSinIGV").Value _
                                                                   , dgvDetalleGarantia.Rows(i).Cells("PrecioUnidadIGV").Value _
                                                                   , dgvDetalleGarantia.Rows(i).Cells("PrecioUnidadConIGV").Value _
                                                                   , dgvDetalleGarantia.Rows(i).Cells("PrecioTotalSinIGV").Value _
                                                                   , dgvDetalleGarantia.Rows(i).Cells("PrecioTotalIGV").Value _
                                                                   , dgvDetalleGarantia.Rows(i).Cells("PrecioTotalConIGV").Value _
                                                                   , FechaHoraServidor _
                                                                   , 1 _
                                                                   , dgvDetalleGarantia.Rows(i).Cells("CodigoProducto").Value _
                                                                   , dgvDetalleGarantia.Rows(i).Cells("DescripcionProducto").Value _
                                                                   , dgvDetalleGarantia.Rows(i).Cells("IdUnidadMedida").Value _
                                                                   , dgvDetalleGarantia.Rows(i).Cells("ObservacionDetalle").Value)
                            If Detalle.fncRegistrarBUS > 0 Then



                            Else

                                Notificar("Error en Registro de Detalle de Compra", "Error")
                            End If
                        End If
                    Next
                    '' If bolEsFactura = True Then
                    My.Settings.UltimaSerieGarantia = Me.txtSerie.Text
                    My.Settings.UltimaFechaGarantia = Me.dtpFechaVenta.Value
                    '    My.Settings.UltimaFechaVentaFactura = Me.dtpFechaVenta.Value
                    'Else
                    '    My.Settings.UltimoSerieVentaBoleta = Me.txtSerie.Text
                    ''     '    My.Settings.UltimaFechaVentaBoleta = Me.dtpFechaVenta.Value
                    ''  End If

                    Notificar("Registrado con éxito.")
                    My.Settings.IGV = Me.decIGVVenta
                    Dim intIdProformaProvisional As Integer = Me.intIdGarantia
                    Controles_En_Load()
                    LlenarDatosPorVenta(intIdProformaProvisional)
                Else
                    Notificar("Error en Registro de Garantía", "ERROR")
                End If
            Else
                Notificar("Error en Registro de Garantía", "ERROR")
            End If

            Else


                If intIdGarantia > 0 And intIdProveedor > 0 Then
                    Dim Garantia As New clsGarantiaBUS

                    Dim dtValida As DataTable = Garantia.fncValidaGarantiaExistenteBUS(Me.intIdGarantia, Me.cmbTipoComprobante.SelectedValue, Me.txtSerie.Text, Me.txtNumero.Text)
                    If fncValidaDataTable(dtValida) Then
                        ErrorVentas.SetError(Me.txtNumero, "No puede usar esta combinación de Tipo de Comprobante, Serie y Número, pues ya se encuentra en uso.")
                        Exit Sub
                    Else
                        ErrorVentas.SetError(Me.txtNumero, Nothing)
                    End If

                    Dim dtProforma As DataTable = Garantia.fncConsultarBUS(Me.intIdGarantia)
                    If fncValidaDataTable(dtProforma) Then
                        Garantia.fncSetearBUS(dtProforma.Rows(0))
                        With Garantia
                            .Serie = txtSerie.Text
                            .Numero = txtNumero.Text
                            .IdTipoComprobante = Me.cmbTipoComprobante.SelectedValue
                            .IdProveedor = intIdProveedor
                            .IGV = fncForzarDecimal(Me.txtIGV.Text)
                            .FechaModifica = FechaHoraServidor()
                            .UsuarioModifica = My.Settings.Usuario
                        .Descripcion = Me.txtDescripcion.Text
                        .FechaGarantia = Me.dtpFechaVenta.Value
                        .Observacion = Me.txtObservacion.Text
                        .EstadoProceso = If(rbPendiente.Checked = True, enmEstadoGarantia.Pendiente, If(rbNoAceptada.Checked = True, enmEstadoGarantia.NoPasoGarantia, enmEstadoGarantia.PasoGarantia))
                        End With

                        If Garantia.fncModificarBUS() > 0 Then
                            For i = 0 To dgvDetalleGarantia.Rows.Count - 1
                                If dgvDetalleGarantia.Rows(i).Visible = True Then
                                    Dim intIdDetalleProforma As Integer = dgvDetalleGarantia.Rows(i).Cells("IdDetalleVenta").Value
                                    If intIdDetalleProforma > 0 Then
                                        '' Modificar
                                        Dim Detalle As New clsDetalleGarantiaBUS()
                                        Dim dtDetalle As DataTable = Detalle.fncConsultarBUS(intIdDetalleProforma)

                                        If fncValidaDataTable(dtDetalle) Then
                                            Detalle.fncSetearBUS(dtDetalle.Rows(0))
                                            With Detalle
                                                .PROnombre = dgvDetalleGarantia.Rows(i).Cells("CodigoProducto").Value
                                                .PROdescripcion = dgvDetalleGarantia.Rows(i).Cells("DescripcionProducto").Value
                                                .ObservacionDetalle = dgvDetalleGarantia.Rows(i).Cells("ObservacionDetalle").Value
                                                .Cantidad = dgvDetalleGarantia.Rows(i).Cells("Cantidad").Value
                                                .UsuarioModifica = My.Settings.Usuario
                                                .PrecioUnidadSinIGV = fncForzarDecimal(dgvDetalleGarantia.Rows(i).Cells("PrecioUnidadSinIGV").Value)
                                                .PrecioTotalSinIGV = fncForzarDecimal(dgvDetalleGarantia.Rows(i).Cells("PrecioTotalSinIGV").Value)
                                                .TotalIGV = fncForzarDecimal(dgvDetalleGarantia.Rows(i).Cells("PrecioTotalIGV").Value)
                                                .PrecioTotalConIGV = fncForzarDecimal(dgvDetalleGarantia.Rows(i).Cells("PrecioTotalConIGV").Value)
                                                .FechaModifica = FechaHoraServidor()
                                                .fncModificarBUS()
                                            End With
                                        End If
                                    Else
                                        '' Registrar
                                        Dim Detalle As New clsDetalleGarantiaBUS(intIdDetalleProforma, intIdGarantia, dgvDetalleGarantia.Rows(i).Cells("IdProducto").Value _
                                                                  , dgvDetalleGarantia.Rows(i).Cells("Cantidad").Value _
                                                                  , dgvDetalleGarantia.Rows(i).Cells("PrecioUnidadSinIGV").Value _
                                                                  , dgvDetalleGarantia.Rows(i).Cells("PrecioUnidadIGV").Value _
                                                                  , dgvDetalleGarantia.Rows(i).Cells("PrecioUnidadConIGV").Value _
                                                                  , dgvDetalleGarantia.Rows(i).Cells("PrecioTotalSinIGV").Value _
                                                                  , dgvDetalleGarantia.Rows(i).Cells("PrecioTotalIGV").Value _
                                                                  , dgvDetalleGarantia.Rows(i).Cells("PrecioTotalConIGV").Value _
                                                                  , FechaHoraServidor _
                                                                  , 1 _
                                                                  , dgvDetalleGarantia.Rows(i).Cells("CodigoProducto").Value _
                                                                  , dgvDetalleGarantia.Rows(i).Cells("DescripcionProducto").Value _
                                                                  , dgvDetalleGarantia.Rows(i).Cells("IdUnidadMedida").Value _
                                                                  , dgvDetalleGarantia.Rows(i).Cells("ObservacionDetalle").Value)

                                        If Detalle.fncRegistrarBUS < 0 Then
                                            Notificar("Error en Registro de Detalle de Compra", "Error")
                                            Exit Sub
                                        End If

                                    End If




                                    'Dim Detalle As New clsDetalleCompraBUS(0, intIdCompra, dgvDetalleCompra.Rows(i).Cells("IdProducto").Value _
                                    '                                       , dgvDetalleCompra.Rows(i).Cells("Cantidad").Value _
                                    '                                       , dgvDetalleCompra.Rows(i).Cells("CostoUnidadSinIGV").Value _
                                    '                                       , dgvDetalleCompra.Rows(i).Cells("CostoTotalSinIGV").Value _
                                    '                                       , dgvDetalleCompra.Rows(i).Cells("CostoTotalIGV").Value _
                                    '                                       , dgvDetalleCompra.Rows(i).Cells("CostoTotalConIGV").Value _
                                    '                                       , FechaHoraServidor _
                                    '                                       , 1)
                                    'If Detalle.fncRegistrarBUS < 0 Then
                                    '    Notificar("Error en Registro de Detalle de Compra", "Error")
                                    'End If
                                Else
                                    Dim intIdDetalleGarantía As Integer = dgvDetalleGarantia.Rows(i).Cells("IdDetalleVenta").Value
                                    If intIdDetalleGarantía > 0 Then
                                        '' Eliminar (estado 0)
                                        Dim Detalle As New clsDetalleGarantiaBUS()
                                        Dim dtDetalle As DataTable = Detalle.fncConsultarBUS(intIdDetalleGarantía)

                                        If fncValidaDataTable(dtDetalle) Then
                                            Detalle.fncSetearBUS(dtDetalle.Rows(0))
                                            With Detalle
                                                .UsuarioModifica = My.Settings.Usuario
                                                .Estado = enmEstado.Inactivo
                                                .FechaModifica = FechaHoraServidor()
                                                If .fncModificarBUS() <= 0 Then
                                                    Notificar("Error al quitar detalle")
                                                    Exit Sub
                                                End If
                                            End With
                                        End If
                                    Else
                                        '' No hacer nada
                                    End If
                                End If
                            Next

                            '' Exito

                            Notificar("Modificado con éxito")
                            Dim intIdProformaProvisional As Integer = Me.intIdGarantia
                            Controles_En_Load()
                            LlenarDatosPorVenta(intIdProformaProvisional)
                        Else
                            Notificar("Error al modificar Proforma.", "ERROR")
                        End If
                    Else
                        Notificar("Esta venta no existe.", "Error")
                    End If
                Else
                    Notificar("Debe seleccionar una garantía a modificar y esta debe tener un cliente", "ERROR")
                End If



            End If
    End Sub

    Private Sub dgvProducto_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProducto.CellClick
        If Me.dgvProducto.Rows.Count > 0 AndAlso Me.dgvProducto.CurrentRow IsNot Nothing Then
            SeleccionaProducto()
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
            Me.txtCostoConIGV.Text = FormatearNumero(fncForzarDecimal(.Cells("subPrecioConIGV").Value), 2)
        End With

        Controles_En_ProductoSeleccionado()
        bolTextChange = True
        Me.ActiveControl = Me.nudCantidad
        Me.nudCantidad.Select(0, Me.nudCantidad.Text.Length)
    End Sub

    Private Sub dgvDetalleVenta_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleGarantia.CellDoubleClick, dgvDetalleGarantia.CellDoubleClick
        If btnModificarDetalle.Enabled Then
            btnModificarDetalle.PerformClick()
        End If

    End Sub

    Private Sub btnBuscarFactura_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarFactura.Click
        Dim ObjFrmHijo As New frmBuscadorOperacion
        'ObjFrmHijo.pFormularioPadrePTA = Me.Name
        'ObjFrmHijo.bolEsBusqueda = True
        'ObjFrmHijo.Owner = Me
        'ObjFrmHijo.ShowDialog()
        ObjFrmHijo.bolEnviar = True
        ObjFrmHijo.bolEsVenta = False
        ObjFrmHijo.bolEsSoloFactura = bolEsFactura
        ObjFrmHijo.intIdIdentificador = enmTipoInterno.Garantía  'Garantía
        ObjFrmHijo.ActiveControl = ObjFrmHijo.txtNumero

        If ObjFrmHijo.ShowDialog = Windows.Forms.DialogResult.OK Then

            Controles_En_Load()
            LlenarDatosPorVenta(ObjFrmHijo.txtIdOperacion.Text)

            'With ObjFrmHijo.dgvProveedor.CurrentRow

            '    Me.intIdProveedor = .Cells("IdProveedor").Value
            '    Me.txtProveedorRUC.Text = .Cells("Tipo").Value & " : " & .Cells("DocumentoIdentidad").Value
            '    Me.txtProveedorNombre.Text = .Cells("Nombre").Value
            '    ''SeteaNodo(.Cells("IdPtaDependencia").Value)
            'End With

        End If
    End Sub

    Private Sub dgvDetalleVenta_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvDetalleGarantia.CellFormatting, dgvDetalleGarantia.CellFormatting
        Try
            With Me.dgvDetalleGarantia
                Select Case .Rows(e.RowIndex).Cells("Estado").Value
                    Case enmEstado.Inactivo
                        e.CellStyle.BackColor = Color.LightSalmon
                        e.CellStyle.SelectionBackColor = Color.LightSalmon

                    Case enmEstado.Activo
                        '' Select Case .Rows(e.RowIndex).Cells("pMigrado").Value
                        ''Case 1
                        e.CellStyle.BackColor = Color.LightGreen
                        e.CellStyle.SelectionBackColor = Color.LightGreen
                        ''   Case 0
                        ''  End Select
                        'Select Case .Rows(e.RowIndex).Cells("cEsIncremento").Value
                        '    Case 1
                        '        Select Case .Rows(e.RowIndex).Cells("cEsRegistroManual").Value
                        '            Case 1
                        '                e.CellStyle.BackColor = Color.LimeGreen
                        '                e.CellStyle.SelectionBackColor = Color.LimeGreen
                        '            Case 0
                        '                e.CellStyle.BackColor = Color.LightGreen
                        '                e.CellStyle.SelectionBackColor = Color.LightGreen
                        '        End Select
                        '    Case 0
                        '        Select Case .Rows(e.RowIndex).Cells("cEsRegistroManual").Value
                        '            Case 1
                        '                e.CellStyle.BackColor = Color.AntiqueWhite
                        '                e.CellStyle.SelectionBackColor = Color.AntiqueWhite
                        '            Case 0
                        '                e.CellStyle.BackColor = Color.LightYellow
                        '                e.CellStyle.SelectionBackColor = Color.LightYellow
                        '        End Select
                        'End Select
                        'e.CellStyle.BackColor = Color.LightYellow
                End Select

                e.CellStyle.SelectionForeColor = Color.Black

                'End If
            End With


        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub

    Private Sub dgvProducto_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvProducto.CellFormatting
        Try
            With Me.dgvProducto
                Select Case .Rows(e.RowIndex).Cells("subStockActual").Value
                    Case Is <= .Rows(e.RowIndex).Cells("subStockMinimo").Value
                        e.CellStyle.BackColor = Color.LightSalmon
                        ''  e.CellStyle.SelectionBackColor = Color.LightSalmon
                        e.CellStyle.SelectionForeColor = Color.White
                        e.CellStyle.SelectionBackColor = Color.DarkRed
                    Case Else
                        '' Select Case .Rows(e.RowIndex).Cells("pMigrado").Value
                        ''Case 1
                        e.CellStyle.BackColor = Color.LightGreen
                        e.CellStyle.SelectionForeColor = Color.White
                        e.CellStyle.SelectionBackColor = Color.DarkGreen
                        ''  e.CellStyle.SelectionBackColor = Color.LightGreen
                        ''   Case 0
                        ''  End Select
                        'Select Case .Rows(e.RowIndex).Cells("cEsIncremento").Value
                        '    Case 1
                        '        Select Case .Rows(e.RowIndex).Cells("cEsRegistroManual").Value
                        '            Case 1
                        '                e.CellStyle.BackColor = Color.LimeGreen
                        '                e.CellStyle.SelectionBackColor = Color.LimeGreen
                        '            Case 0
                        '                e.CellStyle.BackColor = Color.LightGreen
                        '                e.CellStyle.SelectionBackColor = Color.LightGreen
                        '        End Select
                        '    Case 0
                        '        Select Case .Rows(e.RowIndex).Cells("cEsRegistroManual").Value
                        '            Case 1
                        '                e.CellStyle.BackColor = Color.AntiqueWhite
                        '                e.CellStyle.SelectionBackColor = Color.AntiqueWhite
                        '            Case 0
                        '                e.CellStyle.BackColor = Color.LightYellow
                        '                e.CellStyle.SelectionBackColor = Color.LightYellow
                        '        End Select
                        'End Select
                        'e.CellStyle.BackColor = Color.LightYellow
                End Select

                ''    e.CellStyle.SelectionForeColor = Color.Black

                'End If
            End With


        Catch ex As Exception
            NotificarError(ex)
        End Try
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


    Private Sub txtCantidad_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles nudCantidad.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            Me.ActiveControl = Me.rtbObservacionDetalle
            Me.rtbObservacionDetalle.Select(0, Me.rtbObservacionDetalle.Text.Length)
            ''            Me.btnConfirmarProducto.PerformClick()
            'ElseIf e.KeyCode = Keys.Delete Then
            '    Me.btnCancelarProducto.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.btnCancelarProducto.PerformClick()
        ElseIf e.KeyCode = Keys.Up Then
            Me.ActiveControl = Me.txtDescripcionProducto
            Me.txtDescripcionProducto.Select(0, Me.txtDescripcionProducto.Text.Length)
        End If
    End Sub

    Private Sub txtCodigoCliente_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtProveedorRUC.TextChanged
        If bolEsBusquedaAutomaticaCliente = True Then
            Dim Compra As New clsCompraBUS
            Dim dtCompra As DataTable = Compra.fncBuscarTop1ProveedorBUS(Me.txtProveedorRUC.Text, "General")
            If fncValidaDataTable(dtCompra) Then
                bolEsBusquedaAutomaticaCliente = False
                ''Me.txtProveedorRUC.Text = ObtenerValorCelda(dtCompra.Rows(0), "DocumentoIdentidad")
                Me.strCodigoClienteBusquedaActual = ObtenerValorCelda(dtCompra.Rows(0), "DocumentoIdentidad")
                Me.txtProveedorNombre.Text = ObtenerValorCelda(dtCompra.Rows(0), "PRVnombre")
                Me.intIdProveedor = ObtenerValorCelda(dtCompra.Rows(0), "IdProveedor")
                Me.lblCodigoCliente.Text = Me.intIdProveedor
                bolEsBusquedaAutomaticaCliente = True
            Else

                Me.strCodigoClienteBusquedaActual = String.Empty
                Me.txtProveedorNombre.Text = String.Empty
                Me.intIdProveedor = New Integer
                Me.lblCodigoCliente.Text = "0"

            End If
        End If
    End Sub

    Private Sub txtCodigoCliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtProveedorRUC.KeyDown
        If e.KeyCode = Keys.Enter Then
            If bolEsBusquedaAutomaticaCliente = True Then
                If intIdProveedor <> 0 Then
                    bolEsBusquedaAutomaticaCliente = False
                    Me.txtProveedorRUC.Text = Me.strCodigoClienteBusquedaActual
                    bolEsBusquedaAutomaticaCliente = True
                    Me.ActiveControl = Me.dtpFechaVenta
                Else
                    Me.ActiveControl = Me.txtProveedorNombre
                    Me.txtProveedorNombre.Select(0, Me.txtProveedorNombre.Text.Length)
                    ''Me.ActiveControl = Me.btnAgregarDetalle
                    ''Me.btnAgregarDetalle.PerformClick()
                End If
            End If
        End If
    End Sub


    Private Sub txtCosto_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCostoConIGV.KeyDown, txtCosto.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            Me.btnConfirmarProducto.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.btnCancelarProducto.PerformClick()
        ElseIf e.KeyCode = Keys.Up Then
            Me.ActiveControl = Me.nudCantidad
            Me.nudCantidad.Select(0, nudCantidad.Text.Length)
        End If
    End Sub

    Private Sub txtSerie_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSerie.KeyDown
        If e.KeyCode = Keys.Enter Then

            'If bolEsVentaNueva = True Then
            '    Me.txtNumero.Text = String.Empty
            'End If

            Me.ActiveControl = Me.txtNumero
            Me.txtNumero.Select(0, txtNumero.Text.Length)
            'Private Sub txtNumero_Enter(sender As System.Object, e As System.EventArgs) Handles txtNumero.Enter

            'End Sub
        End If
    End Sub

    Private Sub txtNumero_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNumero.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtNumero.Text.Trim.Length < 8 Then
                txtNumero.Text = CerosIzquierda(txtNumero.Text, 8)
            End If

            Me.ActiveControl = Me.txtProveedorRUC
            Me.txtProveedorRUC.Select(0, Me.txtProveedorRUC.Text.Length)
        End If
    End Sub

    Private Sub dgvDetalleVenta_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvDetalleGarantia.KeyDown, dgvDetalleGarantia.KeyDown
        'If Me.dgvDetalleVenta.Rows.Count > 0 AndAlso Me.dgvDetalleVenta.CurrentRow IsNot Nothing Then
        '    Me.btnQuitarDetalle.PerformClick()
        'End If
        If e.KeyCode = Keys.Add Then
            Me.btnAgregarDetalle.PerformClick()
        ElseIf e.KeyCode = Keys.Subtract Or e.KeyCode = Keys.Delete Then
            Me.btnQuitarDetalle.PerformClick()
        End If
    End Sub


    Private Sub frmMantenimientoVentas_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If bolEsFactura = True Then
            modInventario.bolVentasFacturaAbierto = False
        Else
            modInventario.bolVentasBoletaAbierto = False
        End If
    End Sub

    Private Sub btnAgregarDetalle_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles btnQuitarDetalle.KeyDown, btnModificarDetalle.KeyDown, btnAgregarDetalle.KeyDown
        If Me.btnGuardar.Enabled = True Then
            Me.ActiveControl = Me.btnGuardar
        Else
            Me.ActiveControl = Me.btnCancelar
        End If
    End Sub

    Private Sub chkActualizarPrecioVenta_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkActualizarPrecioVenta.CheckedChanged, chkActualizarPrecioVenta.CheckedChanged
        My.Settings.ActualizarPrecioVenta = chkActualizarPrecioVenta.Checked
    End Sub


    Private Sub txtNombreCliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtProveedorNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.dtpFechaVenta
        End If
    End Sub

    Private Sub dtpFechaVenta_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpFechaVenta.KeyDown, dtpFechaVenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.btnAgregarDetalle
            Me.btnAgregarDetalle.PerformClick()
        End If
    End Sub

    'Private Sub btnCodigosProducto_Click(sender As System.Object, e As System.EventArgs) Handles btnCodigosProducto.Click
    '    If Me.dgvDetalleVenta.CurrentRow IsNot Nothing Then
    '        Dim ObjFrmHijo As New frmMantenimientoCodigosUnidad

    '        Dim intIdDetalleProforma As Integer = Me.dgvDetalleVenta.CurrentRow.Cells("IdDetalleVenta").Value
    '        'ObjFrmHijo.pFormularioPadrePTA = Me.Name
    '        'ObjFrmHijo.bolEsBusqueda = True
    '        'ObjFrmHijo.Owner = Me
    '        'ObjFrmHijo.ShowDialog()
    '        ObjFrmHijo.txtComprobante.Text = txtSerie.Text & "-" & txtNumero.Text
    '        ObjFrmHijo.intIdDetalleProforma = intIdDetalleProforma
    '        ObjFrmHijo.bolEsCodigosCompra = False
    '        ObjFrmHijo.ListarCodigosBase()
    '        ObjFrmHijo.ActiveControl = ObjFrmHijo.btnNuevo
    '        If ObjFrmHijo.ShowDialog = Windows.Forms.DialogResult.OK Then

    '        End If
    '    End If


    'End Sub

    Private Sub rtbObservacionDetalle_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles rtbObservacionDetalle.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnConfirmarProducto.PerformClick()
        End If
    End Sub

    'Private Sub txtNumero_Enter(sender As System.Object, e As System.EventArgs) Handles txtNumero.Enter
    '    Me.BeginInvoke(DirectCast(Sub() txtNumero.SelectAll(), MethodInvoker))
    'End Sub

    Private Sub txtNumero_Enter(sender As System.Object, e As System.EventArgs) Handles txtNumero.Enter
        'PosicionUltimo(txtNumero, "0")
    End Sub
End Class