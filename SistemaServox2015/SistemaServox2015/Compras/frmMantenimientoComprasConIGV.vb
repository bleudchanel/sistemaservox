Imports SistemaServox2015BUS
Imports pryUtil.clsUtil
Imports System.Net
Imports System.Media
Imports System.Threading
Imports System.Globalization


Public Class frmMantenimientoComprasConIGV


    Private intIdCompra As New Integer
    Private intIdDetalleCompra As New Integer
    Private intIdProveedor As New Integer
    Private intIdProducto As New Integer
    Private decIGVCompra As New Decimal
    Private bolEsDetalleModifica As New Boolean
    Private bolEsCompraNueva As New Boolean
    Private bolPivot As Boolean = True
    Private bolTextChange As Boolean = True
    Private bolBuscaAutomaticaProveedor As Boolean = True
    Private strRUCPROVEEDORBusquedaActual As String

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmMantenimientoCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Thread.CurrentThread.CurrentCulture = New CultureInfo("es-PE")
        decIGVCompra = My.Settings.IGV
        Controles_En_Load()
    End Sub

#Region "Controles"

    Sub ValoresPorDefecto()
        If My.Settings.UltimoTipoUsadoCompra <> 0 Then
            Me.cmbTipoComprobante.SelectedValue = My.Settings.UltimoTipoUsadoCompra
        End If

        Me.txtSerie.Text = If(My.Settings.UltimoSerieCompraFactura.Trim.Length = 0, "000", My.Settings.UltimoSerieCompraFactura)
        Me.txtNumero.Text = "00000000"
        Me.txtBusquedaDetalle.Text = String.Empty
        Me.dgvDetalleCompra.Rows.Clear()
        Me.dgvProducto.Rows.Clear()
        Me.txtProveedorNombre.Text = String.Empty
        bolBuscaAutomaticaProveedor = False
        Me.txtProveedorRUC.Text = String.Empty
        bolBuscaAutomaticaProveedor = True
        Me.txtDescripcion.Text = String.Empty
        Me.txtObservacion.Text = String.Empty
        Me.txtSubTotal.Text = "0.00"
        Me.txtTotalIGV.Text = "0.00"
        Me.txtTotal.Text = "0.00"
        Me.dtpFechaCompra.Value = If(My.Settings.UltimaFechaCompra.Year <= 2000, FechaHoraServidor.Date, My.Settings.UltimaFechaCompra)
        Me.txtIGV.Text = FormatearNumero(decIGVCompra, 2)
        Me.bolBuscaAutomaticaProveedor = True
        Me.chkActualizaPrecioCompra.Checked = My.Settings.ActualizaPrecioCompra
        Me.rbDolares.Select()
    End Sub

    Sub Controles_En_Load()

        Me.intIdCompra = New Integer
        Me.intIdDetalleCompra = New Integer
        Me.intIdProducto = New Integer
        Me.intIdProveedor = New Integer
        Me.bolEsCompraNueva = True
        Me.strRUCPROVEEDORBusquedaActual = String.Empty
        Dim Periodo As New clsPeriodo
        SetComboBox(cmbAnioPeriodo, Periodo.fncListaPeriodoPorOperacionBUS(1), "Anio", "Anio")
        ''  ProcComboBoxAAnio(cmbAnioPeriodo)

        Dim TipoComprobante As New clsTipoComprobanteBUS
        SetComboBox(cmbTipoComprobante, TipoComprobante.fncTipoComprobanteBUS(enmEstado.Activo), "Abreviacion", "IdTipoComprobante")

        Dim UnidadMedida As New clsUnidadMedidaBUS
        SetComboBox(cmbUnidadMedida, UnidadMedida.fncListarUnidadMedidaBUS(enmEstado.Activo), "Abreviacion", "IdMedida")

        ''   Me.txtIGV.Text = FormatearNumero(decIGVCompra, 2)

        Me.cmbTipoComprobante.Enabled = False
        Me.txtSerie.Enabled = False
        Me.txtNumero.Enabled = False
        Me.btnBuscarFactura.Enabled = True
        Me.btnBuscarProveedor.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.dtpFechaCompra.Enabled = False
        Me.txtIGV.Enabled = False
        Me.txtProveedorRUC.Enabled = False
        Me.btnAgregarDetalle.Enabled = False
        Me.btnModificarDetalle.Enabled = False
        Me.btnQuitarDetalle.Enabled = False
        Me.btnCodigosProducto.Enabled = False
        Me.txtObservacion.Enabled = False
        Me.grpNavegar.Enabled = True
        Me.grpTransporte.Enabled = False
        Me.chkActivarBloqueado.Checked = False
        Me.chkActivarBloqueado.Enabled = False

        Me.grpMoneda.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.btnNuevo.Enabled = True
        Me.btnAnular.Enabled = True
        Me.btnModificar.Enabled = True
        ''Me.txtSerie.Text = My.Settings.UltimoSerieCompra
        Me.lblCodigoProveedor.Text = Me.intIdProveedor
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
        Me.chkActualizaPrecioCompra.Checked = My.Settings.ActualizaPrecioCompra
    End Sub

    Sub Controles_En_Producto()
        Me.txtCodigoProducto.Enabled = True
        Me.txtDescripcionProducto.Enabled = True
        Me.dgvProducto.Enabled = True
        Me.btnConfirmarProducto.Enabled = True
        Me.tbcCompras.Enabled = False
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
        Me.lblMedida.ForeColor = Color.Black
        bolTextChange = True
        Me.chkActualizaPrecioCompra.Checked = My.Settings.ActualizaPrecioCompra
    End Sub

    Sub Controles_En_NuevoProductoRegistrar()
        bolTextChange = False
        Me.cmbUnidadMedida.Enabled = True
        Me.nudCantidad.Enabled = True
        Me.btnConfirmarProducto.Enabled = True

        Me.txtCodigoProducto.Enabled = True
        Me.txtCosto.Text = "0.00"
        Me.txtIGVCosto.Text = "0.00"
        Me.txtCostoConIGV.Text = "0.00"
        Me.txtDescripcionProducto.Enabled = True
        Me.txtCosto.Enabled = True
        Me.txtIGVCosto.Enabled = True
        Me.txtCostoConIGV.Enabled = True
        Me.lblMedida.ForeColor = Color.Red
        bolTextChange = True
    End Sub

    Sub Controles_En_ProductoSeleccionado()
        Me.cmbUnidadMedida.Enabled = False
        Me.nudCantidad.Enabled = True
        Me.btnConfirmarProducto.Enabled = True
    End Sub

    Sub Controles_En_CancelarProducto()
        Me.tbcCompras.Enabled = True
        Me.pnlControlProducto.Visible = False
        Me.dgvProducto.Rows.Clear()
        My.Settings.ActualizaPrecioCompra = Me.chkActualizaPrecioCompra.Checked
    End Sub

    Sub Controles_En_NuevaOperacion()

        Me.bolEsCompraNueva = True
        Me.intIdCompra = New Integer
        Me.intIdDetalleCompra = New Integer
        Me.intIdProducto = New Integer
        Me.intIdProveedor = New Integer

        Me.grpNavegar.Enabled = False
        Me.grpTransporte.Enabled = True
        '' Me.cmbTipoComprobante.Enabled = True
        Me.txtSerie.Enabled = True
        Me.txtNumero.Enabled = True
        Me.btnBuscarFactura.Enabled = False
        Me.btnBuscarProveedor.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.dtpFechaCompra.Enabled = True
        Me.txtIGV.Enabled = True
        Me.chkActivarBloqueado.Enabled = False

        Me.btnAgregarDetalle.Enabled = True
        Me.btnModificarDetalle.Enabled = True
        Me.btnQuitarDetalle.Enabled = True
        Me.btnCodigosProducto.Enabled = True
        Me.txtObservacion.Enabled = True
        Me.grpMoneda.Enabled = True

        Me.btnNuevo.Enabled = False
        Me.btnModificar.Enabled = False
        Me.btnAnular.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True

        Me.txtProveedorRUC.Enabled = True

        ValoresPorDefecto()
        Me.ActiveControl = Me.txtSerie

    End Sub

    Sub Controles_En_ModificarOperacion()

        Me.bolEsCompraNueva = False
        'Me.intIdCompra = New Integer
        Me.intIdDetalleCompra = New Integer
        Me.intIdProducto = New Integer
        'Me.intIdProveedor = New Integer

        Me.grpNavegar.Enabled = False
        Me.grpTransporte.Enabled = True
        '' Me.cmbTipoComprobante.Enabled = True
        Me.txtSerie.Enabled = True
        Me.txtNumero.Enabled = True
        Me.btnBuscarFactura.Enabled = False

        Me.btnBuscarProveedor.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.dtpFechaCompra.Enabled = False
        Me.txtIGV.Enabled = False
        Me.txtProveedorRUC.Enabled = False
        Me.chkActivarBloqueado.Enabled = True

        Me.btnAgregarDetalle.Enabled = True
        Me.btnModificarDetalle.Enabled = True
        Me.btnQuitarDetalle.Enabled = True
        Me.btnCodigosProducto.Enabled = True
        Me.txtObservacion.Enabled = True
        Me.grpMoneda.Enabled = True

        Me.btnNuevo.Enabled = False
        Me.btnModificar.Enabled = False
        Me.btnAnular.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True



    End Sub
#End Region

    Sub LlenarDatosPorCompra(ByVal intIdCompra As Integer)
        bolBuscaAutomaticaProveedor = False
        Dim Compra As New clsCompraBUS
        '' Dim DetalleCompra As New clsDetalleCompraBUS
        Dim dtBase As DataTable() = Compra.fncComprasPorIdentificador(intIdCompra)
        If fncValidaDataTable(dtBase(0)) Then
            Me.dgvDetalleCompra.Rows.Clear()
            Me.cmbAnioPeriodo.SelectedValue = CDate(ObtenerValorCelda(dtBase(0).Rows(0), "FechaCompra")).Year
            Me.intIdCompra = ObtenerValorCelda(dtBase(0).Rows(0), "IdCompra")
            Me.txtSerie.Text = ObtenerValorCelda(dtBase(0).Rows(0), "Serie")
            Me.txtNumero.Text = ObtenerValorCelda(dtBase(0).Rows(0), "Numero")
            Me.txtDescripcion.Text = ObtenerValorCelda(dtBase(0).Rows(0), "Descripcion")
            Me.cmbTipoComprobante.SelectedValue = ObtenerValorCelda(dtBase(0).Rows(0), "IdTipoComprobante")
            Me.intIdProveedor = ObtenerValorCelda(dtBase(0).Rows(0), "IdProveedor")
            Me.lblCodigoProveedor.Text = Me.intIdProveedor
            Me.txtProveedorRUC.Text = ObtenerValorCelda(dtBase(0).Rows(0), "DocumentoIdentidad") ''ObtenerValorCelda(dtBase(0).Rows(0), "TipoDocumento") & " : " & ObtenerValorCelda(dtBase(0).Rows(0), "DocumentoIdentidad")
            Me.txtProveedorNombre.Text = ObtenerValorCelda(dtBase(0).Rows(0), "PRVnombre")
            Me.decIGVCompra = ObtenerValorCelda(dtBase(0).Rows(0), "IGV")
            Me.txtIGV.Text = FormatearNumero(decIGVCompra, 2)
            'Moneda
            Dim strCodigMoneda As String = ObtenerValorCelda(dtBase(0).Rows(0), "CodigoMoneda")
            If strCodigMoneda.Equals("01") Then
                rbSoles.Checked = True
            ElseIf strCodigMoneda.Equals("02") Then
                rbDolares.Checked = True
            End If
            Me.txtObservacion.Text = ObtenerValorCelda(dtBase(0).Rows(0), "Observacion")
            Me.dtpFechaCompra.Value = CDate(ObtenerValorCelda(dtBase(0).Rows(0), "FechaCompra")).ToString("dd/MM/yyyy")
            ''  If fncValidaDataTable(dtBase(1)) Then
            LlenarDetalleCompra(dtBase(1))
            LlenarTransporte(dtBase(2))
            ''End If
        End If
        bolBuscaAutomaticaProveedor = True
    End Sub

    Sub LlenarDatosPorOrdenCompra(ByVal intIdCompraActual As Integer, ByVal intOrden As Integer, ByVal intAnioPeriodo As Integer)
        bolBuscaAutomaticaProveedor = False
        Dim Compra As New clsCompraBUS
        '' Dim DetalleCompra As New clsDetalleCompraBUS
        Dim dtBase As DataTable() = Compra.fncComprasPorOrden(enmTipoInterno.CompraConIGV, intAnioPeriodo, , "1", intOrden, intIdCompraActual)
        If fncValidaDataTable(dtBase(0)) Then

            Me.intIdCompra = ObtenerValorCelda(dtBase(0).Rows(0), "IdCompra")
            Me.txtSerie.Text = ObtenerValorCelda(dtBase(0).Rows(0), "Serie")
            Me.txtNumero.Text = ObtenerValorCelda(dtBase(0).Rows(0), "Numero")
            Me.txtDescripcion.Text = ObtenerValorCelda(dtBase(0).Rows(0), "Descripcion")
            Me.cmbTipoComprobante.SelectedValue = ObtenerValorCelda(dtBase(0).Rows(0), "IdTipoComprobante")
            Me.intIdProveedor = ObtenerValorCelda(dtBase(0).Rows(0), "IdProveedor")
            Me.lblCodigoProveedor.Text = Me.intIdProveedor
            Me.txtProveedorRUC.Text = ObtenerValorCelda(dtBase(0).Rows(0), "DocumentoIdentidad") ''ObtenerValorCelda(dtBase(0).Rows(0), "TipoDocumento") & " : " & ObtenerValorCelda(dtBase(0).Rows(0), "DocumentoIdentidad")
            Me.txtProveedorNombre.Text = ObtenerValorCelda(dtBase(0).Rows(0), "PRVnombre")
            Me.decIGVCompra = ObtenerValorCelda(dtBase(0).Rows(0), "IGV")
            Me.txtIGV.Text = FormatearNumero(decIGVCompra, 2)

            Dim strCodigoMoneda As String = ObtenerValorCelda(dtBase(0).Rows(0), "CodigoMoneda")
            If strCodigoMoneda.Equals("01") Then
                rbSoles.Checked = True
            ElseIf strCodigoMoneda.Equals("02") Then
                rbDolares.Checked = True
            End If

            Me.txtObservacion.Text = ObtenerValorCelda(dtBase(0).Rows(0), "Observacion")
            Me.dtpFechaCompra.Value = CDate(ObtenerValorCelda(dtBase(0).Rows(0), "FechaCompra")).ToString("dd/MM/yyyy")
            ''  If fncValidaDataTable(dtBase(1)) Then
            LlenarDetalleCompra(dtBase(1))
            LlenarTransporte(dtBase(2))
            ''End If
        End If
        bolBuscaAutomaticaProveedor = True
    End Sub

    Sub LlenarDetalleCompra(ByVal dtDetalle As DataTable)

        Me.dgvDetalleCompra.Rows.Clear()
        If fncValidaDataTable(dtDetalle) Then
            For Each row In dtDetalle.Rows
                Me.dgvDetalleCompra.Rows.Add()
                With dgvDetalleCompra.Rows(dgvDetalleCompra.Rows.Count - 1)
                    .Cells("IdDetalleCompra").Value = ObtenerValorCelda(row, "IdDetalleCompra")
                    .Cells("IdProducto").Value = ObtenerValorCelda(row, "IdProducto")
                    .Cells("CodigoProducto").Value = ObtenerValorCelda(row, "PROnombre")
                    .Cells("DescripcionProducto").Value = ObtenerValorCelda(row, "PROdescripcion")
                    .Cells("IdUnidadMedida").Value = ObtenerValorCelda(row, "IdMedida")
                    .Cells("UnidadMedida").Value = ObtenerValorCelda(row, "UnidadMedida")
                    .Cells("Cantidad").Value = FormatearNumero(ObtenerValorCelda(row, "Cantidad"), 1)
                    .Cells("CostoUnidadSinIGV").Value = FormatearNumero(ObtenerValorCelda(row, "CostoUnidadSinIGV"), 4)
                    .Cells("CostoUnidadIGV").Value = FormatearNumero(ObtenerValorCelda(row, "UnidadIGV"), 4)
                    .Cells("CostoUnidadConIGV").Value = FormatearNumero(ObtenerValorCelda(row, "CostoUnidadConIGV"), 4)
                    .Cells("CostoTotalSinIGV").Value = FormatearNumero(ObtenerValorCelda(row, "CostoTotalSinIGV"), 2)

                    .Cells("CostoTotalIGV").Value = FormatearNumero(ObtenerValorCelda(row, "CostoIGV"), 2)

                    .Cells("CostoTotalConIGV").Value = FormatearNumero(ObtenerValorCelda(row, "CostoTotalConIGV"), 2)
                    .Cells("Estado").Value = ObtenerValorCelda(row, "Estado")
                End With
            Next


            'Me.txtSubTotal.Text = Formatear(decSubTotal, 2)
            'Me.txtTotalIGV.Text = Formatear(decTotalIGV, 2)
            'Me.txtTotal.Text = Formatear(decTotalFinal, 2)
        End If
        LlenarTotalesOperacion()

        Me.dgvDetalleCompra.ClearSelection()
        Me.dgvDetalleCompra.Refresh()
    End Sub


    Sub LlenarTransporte(ByVal dtTransporte As DataTable)
        If fncValidaDataTable(dtTransporte) Then
            Me.txtTransporteNombre.Text = ObtenerValorCelda(dtTransporte.Rows(0), "PRVnombre")
            Me.txtTransporteRUC.Text = ObtenerValorCelda(dtTransporte.Rows(0), "DocumentoIdentidad")
            Me.txtSerieTransporte.Text = ObtenerValorCelda(dtTransporte.Rows(0), "Serie")
            Me.txtNumeroTransporte.Text = ObtenerValorCelda(dtTransporte.Rows(0), "Numero")
            Me.txtIdTransporte.Text = ObtenerValorCelda(dtTransporte.Rows(0), "IdTransporte")
            Me.txtMontoTransporte.Text = ObtenerValorCelda(dtTransporte.Rows(0), "MontoTransporte")
            Me.txtObservacionTransporte.Text = ObtenerValorCelda(dtTransporte.Rows(0), "Descripcion")
        Else
            ResetControlesTransporte()
        End If
    End Sub

    Sub ResetControlesTransporte()
        Me.txtTransporteNombre.Text = String.Empty
        Me.txtTransporteRUC.Text = String.Empty
        Me.txtSerieTransporte.Text = "000"
        Me.txtNumeroTransporte.Text = "00000000"
        Me.txtIdTransporte.Text = String.Empty
        Me.txtMontoTransporte.Text = "0.00"
        Me.txtObservacionTransporte.Text = String.Empty
    End Sub

    Sub LlenarTotalesOperacion()
        Dim decSubTotal As New Decimal
        Dim decTotalIGV As New Decimal
        Dim decTotalFinal As New Decimal

        If dgvDetalleCompra.Rows.Count > 0 Then
            For i As Integer = 0 To dgvDetalleCompra.Rows.Count - 1
                If dgvDetalleCompra.Rows(i).Visible = True Then
                    decSubTotal += fncForzarDecimal(dgvDetalleCompra.Rows(i).Cells("CostoTotalSinIGV").Value)
                    decTotalIGV += fncForzarDecimal(dgvDetalleCompra.Rows(i).Cells("CostoTotalIGV").Value)
                    decTotalFinal += fncForzarDecimal(dgvDetalleCompra.Rows(i).Cells("CostoTotalConIGV").Value)
                End If
            Next

        End If

        Me.txtSubTotal.Text = FormatearNumero(decSubTotal, 2)
        Me.txtTotalIGV.Text = FormatearNumero(decTotalIGV, 2)
        Me.txtTotal.Text = FormatearNumero(decTotalFinal, 2)

    End Sub

    Private Sub txtProveedorRUC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProveedorRUC.TextChanged
        If bolBuscaAutomaticaProveedor = True Then
            Dim Compra As New clsCompraBUS
            Dim dtCompra As DataTable = Compra.fncBuscarTop1ProveedorBUS(Me.txtProveedorRUC.Text, "General")
            If fncValidaDataTable(dtCompra) Then
                bolBuscaAutomaticaProveedor = False
                ''Me.txtProveedorRUC.Text = ObtenerValorCelda(dtCompra.Rows(0), "DocumentoIdentidad")
                Me.strRUCPROVEEDORBusquedaActual = ObtenerValorCelda(dtCompra.Rows(0), "DocumentoIdentidad")
                Me.txtProveedorNombre.Text = ObtenerValorCelda(dtCompra.Rows(0), "PRVnombre")
                Me.intIdProveedor = ObtenerValorCelda(dtCompra.Rows(0), "IdProveedor")
                Me.lblCodigoProveedor.Text = Me.intIdProveedor
                bolBuscaAutomaticaProveedor = True
            Else

                Me.strRUCPROVEEDORBusquedaActual = String.Empty
                Me.txtProveedorNombre.Text = String.Empty
                Me.intIdProveedor = New Integer
                Me.lblCodigoProveedor.Text = "0"

            End If
        End If
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        LlenarDatosPorOrdenCompra(intIdCompra, enmOrden.Primero, cmbAnioPeriodo.SelectedValue)
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        LlenarDatosPorOrdenCompra(intIdCompra, enmOrden.Atras, cmbAnioPeriodo.SelectedValue)
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        LlenarDatosPorOrdenCompra(intIdCompra, enmOrden.Siguiente, cmbAnioPeriodo.SelectedValue)
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        LlenarDatosPorOrdenCompra(intIdCompra, enmOrden.Ultimo, cmbAnioPeriodo.SelectedValue)
    End Sub


    Private Sub btnAgregarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDetalle.Click
        If Me.intIdProveedor > 0 Then
            Me.pnlControlProducto.Visible = True
            Me.pnlControlProducto.Location = New Point(Me.grpCabecera.Location.X + Me.grpCabecera.Width / 20, Me.grpCabecera.Location.Y + Me.grpCabecera.Location.Y / 2)
            decIGVCompra = (fncForzarDecimal(Me.txtIGV.Text))
            Me.lblProductoIGV.Text = "IGV " & FormatearNumero(decIGVCompra, 2)
            bolEsDetalleModifica = False
            Controles_En_NuevoProducto()
            ErrorCompras.SetError(Me.txtProveedorRUC, Nothing)
            Me.ActiveControl = txtCodigoProducto
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
            ''ErrorCompras.SetError(Me.txtProveedorRUC, "Debe Seleccionar un Proveedor")
        End If

    End Sub

    Private Sub btnCancelarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarProducto.Click
        Controles_En_CancelarProducto()
        bolPivot = True
        Me.ActiveControl = Me.btnAgregarDetalle
    End Sub


    'Private Sub txtCosto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalSinIGV.TextChanged
    '    'If bolPivot = True Then
    '    '    ''Dim decCosto As Decimal = fncForzarDecimal(Me.txtCosto.Text)
    '    '    Dim decCosto As Decimal = fncForzarDecimal(Me.txtTotalSinIGV.Text)
    '    '    Dim decIGVCalculo As Decimal = fncRound2(decCosto * (decIGVCompra))
    '    '    Dim decCostoConIGV As Decimal = decCosto + decIGVCalculo
    '    '    Dim decCantidad As Decimal = fncForzarDecimal(nudCantidad.Text)


    '    '    Dim decCostoUnidad As Decimal = fncRound2(If(decCantidad > 0, decCosto / decCantidad, 0))
    '    '    Dim decIGVUnidad As Decimal = fncRound2(If(decCantidad > 0, decIGVCalculo / decCantidad, 0))
    '    '    Dim decCostoUnidadConIGV As Decimal = fncRound2(If(decCantidad > 0, decCostoConIGV / decCantidad, 0))

    '    '    Me.txtIGVTotal.Text = FormatearNumero(decIGVCalculo, 2)
    '    '    Me.txtTotalConIGV.Text = FormatearNumero(decCostoConIGV, 2)

    '    '    Me.txtCosto.Text = FormatearNumero(decCostoUnidad, 2)
    '    '    Me.txtIGVCosto.Text = FormatearNumero(decIGVUnidad, 2)
    '    '    Me.txtCostoConIGV.Text = FormatearNumero(decCostoUnidadConIGV, 2)

    '    '    'Me.txtIGVCosto.Text = FormatearNumero(decIGVCalculo, 2)
    '    '    ' ''Dim decCostoConIGV As Decimal = fncForzarDecimal(Me.txtCosto.Text) + decIGVCalculo
    '    '    'Me.txtCostoConIGV.Text = FormatearNumero(decCostoConIGV, 2)
    '    '    'Me.txtTotalSinIGV.Text = FormatearNumero(fncRound2(fncForzarDecimal(Me.txtCosto.Text) * nudCantidad.Value), 2)
    '    '    'Me.txtIGVTotal.Text = FormatearNumero(fncRound2(decIGVCalculo * nudCantidad.Value), 2)
    '    '    'Me.txtTotalConIGV.Text = FormatearNumero(fncRound2(decCostoConIGV * nudCantidad.Value), 2)
    '    End If
    'End Sub

    'Private Sub txtCostoConIGV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalConIGV.TextChanged
    '    If bolPivot = False Then

    '        Dim decCostoConIGV As Decimal = fncForzarDecimal(Me.txtTotalConIGV.Text)
    '        Dim decCosto As Decimal = fncRound2(decCostoConIGV / (1 + (decIGVCompra)))
    '        ''  Dim decCostoSinIGV As Decimal = decCostoConIGV - decCosto

    '        Dim decIGVCalculo As Decimal = fncRound2(decCostoConIGV - decCosto)

    '        Dim decCantidad As Decimal = fncForzarDecimal(nudCantidad.Text)

    '        Dim decCostoUnidad As Decimal = fncRound2(If(decCantidad > 0, decCosto / decCantidad, 0))
    '        Dim decIGVUnidad As Decimal = fncRound2(If(decCantidad > 0, decIGVCalculo / decCantidad, 0))
    '        Dim decCostoUnidadConIGV As Decimal = fncRound2(If(decCantidad > 0, decCostoConIGV / decCantidad, 0))

    '        Me.txtIGVTotal.Text = FormatearNumero(decIGVCalculo, 2)
    '        Me.txtTotalSinIGV.Text = FormatearNumero(decCosto, 2)

    '        Me.txtCosto.Text = FormatearNumero(decCostoUnidad, 2)
    '        Me.txtIGVCosto.Text = FormatearNumero(decIGVUnidad, 2)
    '        Me.txtCostoConIGV.Text = FormatearNumero(decCostoUnidadConIGV, 2)

    '        'Dim decCostoConIGV As Decimal = fncForzarDecimal(Me.txtCostoConIGV.Text)
    '        'Dim decCostoSinIGV As Decimal = fncRound2(decCostoConIGV / (1 + (decIGVCompra / 100)))
    '        'Dim decIGVCalculo As Decimal = decCostoConIGV - decCostoSinIGV
    '        'Dim decTotal As Decimal = fncRound2(decCostoConIGV * nudCantidad.Value)

    '        'Me.txtIGVCosto.Text = FormatearNumero(decIGVCalculo, 2)
    '        'Me.txtCosto.Text = FormatearNumero(decCostoSinIGV, 2)

    '        'Me.txtTotalSinIGV.Text = FormatearNumero(fncRound2(decCostoSinIGV * nudCantidad.Value), 2)
    '        'Me.txtIGVTotal.Text = FormatearNumero(fncRound2(decIGVCalculo * nudCantidad.Value), 2)
    '        'Me.txtTotalConIGV.Text = FormatearNumero(decTotal, 2)
    '    End If
    'End Sub

    Private Sub nudCantidad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudCantidad.TextChanged
        If fncForzarDecimal(nudCantidad.Text) = 0 Then
            Exit Sub
        End If

        ''  bolPivot = False
        '' Dim decCostoSinIGV As Decimal = fncForzarDecimal(Me.txtCosto.Text)

        '' Me.txtCostoConIGV.Text = FormatearNumero(, 4)
        Dim decTotalConIGV As Decimal = fncRound2(fncForzarDecimal(nudCantidad.Text) * fncForzarDecimal(Me.txtCostoConIGV.Text))

        Me.txtTotalConIGV.Text = FormatearNumero(decTotalConIGV, 2)
        Dim decTotalSinIGV As Decimal = fncRound2(decTotalConIGV / (1 + decIGVCompra))
        Me.txtTotalSinIGV.Text = FormatearNumero(decTotalSinIGV, 2)
        Me.txtIGVTotal.Text = FormatearNumero(fncRound2(decTotalConIGV - decTotalSinIGV), 2)

    End Sub

    'Private Sub txtCosto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalSinIGV.Enter
    '    bolPivot = True
    'End Sub

    'Private Sub txtCostoConIGV_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalConIGV.Enter
    '    bolPivot = False
    'End Sub

    Private Sub txtCodigoProductoEspecifico_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoProducto.KeyDown
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.Down Then
            bolTextChange = False
            Me.txtCodigoProducto.Text = String.Empty
            Me.ActiveControl = Me.txtDescripcionProducto
            Me.txtDescripcionProducto.Select(0, txtDescripcionProducto.Text.Length)
            bolTextChange = True
        End If
    End Sub

    Private Sub txtDescripcionProductoEspecifico_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcionProducto.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Then
            bolTextChange = False
            Me.txtDescripcionProducto.Text = String.Empty
            Me.ActiveControl = Me.txtCodigoProducto
            Me.txtCodigoProducto.Select(0, txtCodigoProducto.Text.Length)
            bolTextChange = True
        End If
    End Sub

    Private Sub txtCodigoProducto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoProducto.KeyDown, txtDescripcionProducto.KeyDown, dgvProducto.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    'BuscarProductoBase(txtCodigoProducto.Text, txtDescripcionProducto.Text)

        'Else
        If e.KeyCode = Keys.Enter Then
            If Me.dgvProducto.Rows.Count > 0 AndAlso Me.dgvProducto.CurrentRow IsNot Nothing Then
                SeleccionaProducto()

            Else
                If txtCodigoProducto.Text.Trim.Length > 0 And txtDescripcionProducto.Text.Trim.Length = 0 Then
                    intIdProducto = 0
                    Me.lblTituloPanel.Text = "Nuevo Producto"
                    Me.ActiveControl = Me.txtDescripcionProducto
                Else
                    If Me.txtCodigoProducto.Text.Trim.Length > 0 And Me.txtDescripcionProducto.Text.Trim.Length > 0 Then
                        intIdProducto = 0
                        Me.lblTituloPanel.Text = "Nuevo Producto"
                        Controles_En_NuevoProductoRegistrar()
                        Me.ActiveControl = Me.cmbUnidadMedida
                    Else
                        intIdProducto = 0
                        Notificar("Debe Seleccionar un producto o ingresar un Código de Producto y una Descripción para proceder a ingresar un nuevo Producto.")
                        Exit Sub
                    End If
                End If

                '    intIdProducto = 0
                '    Me.lblTituloPanel.Text = "Nuevo Producto"
                '    Controles_En_NuevoProducto()
                'Else

                '' End If
            End If
        ElseIf e.KeyCode = Keys.F1 Then
            If Me.txtCodigoProducto.Text.Trim.Length > 0 And Me.txtDescripcionProducto.Text.Trim.Length > 0 Then
                intIdProducto = 0
                Me.lblTituloPanel.Text = "Nuevo Producto"
                Controles_En_NuevoProductoRegistrar()
                Me.ActiveControl = Me.cmbUnidadMedida
            Else
                intIdProducto = 0
                Notificar("Debe Seleccionar un producto o ingresar un Código de Producto y una Descripción para proceder a ingresar un nuevo Producto.")
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            bolTextChange = False
            Me.txtCodigoProducto.Text = String.Empty
            Me.txtDescripcionProducto.Text = String.Empty
            Me.intIdProducto = New Integer
            bolTextChange = True
        ElseIf e.KeyCode = Keys.Escape Then
            Me.btnCancelarProducto.PerformClick()
            Me.ActiveControl = Me.btnAgregarDetalle
        End If
    End Sub

    Sub BuscarProductoBase(Optional ByVal strCodigo As String = "", Optional ByVal strDescripcion As String = "", Optional ByVal strBusqueda As String = "")
        Me.intIdProducto = 0
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
                    .Cells("subCodigoMonedaCompra").Value = ObtenerValorCelda(row, "CodigoMonedaCompra")
                End With
            Next
        End If
    End Sub

    'Private Sub txtDescripcionProducto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcionProducto.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        BuscarProductoBase(String.Empty, txtDescripcionProducto.Text)
    '    Elseif e.KeyCode = Keys.Right
    '        If Me.dgvProducto.Rows.Count > 0 AndAlso Me.dgvProducto.CurrentRow IsNot Nothing Then

    '        Else
    '            If Me.txtDescripcionProducto.Text.Trim.Length > 0 And Me.txtCodigoProducto.Text.Trim.Length > 0 Then
    '                Me.lblTituloPanel.Text = "Nuevo Producto"
    '                Controles_En_NuevoProducto()
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub btnConfirmarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmarProducto.Click
        Dim decSubTotal As New Decimal
        Dim decTotalIGV As New Decimal
        Dim decTotalFinal As New Decimal

        '' VALIDA DETALLE
        If bolEsDetalleModifica = False Then
            Dim bolEncontroCoincidencia As New Boolean
            If intIdProducto <> 0 Then
                For i As Integer = 0 To dgvDetalleCompra.Rows.Count - 1
                    If dgvDetalleCompra.Rows(i).Visible = True AndAlso intIdProducto = dgvDetalleCompra.Rows(i).Cells("IdProducto").Value Then
                        bolEncontroCoincidencia = True
                    End If
                Next
            End If

            If bolEncontroCoincidencia = True Then
                Notificar("No puede registrar este producto dos veces en el mismo comprobante, pruebe modificando el registro existente.")
                Exit Sub
            End If

        End If


        If bolEsDetalleModifica = True Then

        Else
            If intIdProducto = 0 Then
                Dim ProductoBase As New clsProductoBUS
                If ProductoBase.fncValidaCodigoExistente(Me.txtCodigoProducto.Text) = True Then
                    Notificar("El código para este nuevo producto ya está en uso. Debe usar otro código.")
                    Exit Sub
                End If

                Dim Producto As New clsProductoBUS(Me.txtCodigoProducto.Text _
                                                   , Me.cmbUnidadMedida.Text _
                                                   , Me.txtDescripcionProducto.Text _
                                                   , 1 _
                                                   , 1 _
                                                   , FormatearNumero(fncForzarDecimal(Me.txtCostoConIGV.Text), 2) _
                                                   , 0 _
                                                   , Me.dtpFechaCompra.Value _
                                                   , Me.cmbUnidadMedida.SelectedValue _
                                                   , Me.intIdProveedor _
                                                   , FormatearNumero(fncForzarDecimal(Me.txtCosto.Text), 6) _
                                                   , fncForzarDecimal(Me.txtIGV.Text) * 100 _
                                                   , FormatearNumero(fncForzarDecimal(Me.txtCostoConIGV.Text), 6) _
                                                   , FormatearNumero(fncForzarDecimal(Me.txtCostoConIGV.Text), 6) _
                                                   , My.Settings.Usuario _
                                                   , fncForzarDecimal(Me.txtIGV.Text) * 100 _
                                                   , FormatearNumero(fncForzarDecimal(Me.txtCostoConIGV.Text), 6) _
                                                   , 0 _
                                                   , 0 _
                                                   , If(rbDolares.Checked = True, "02", "01") _
                                                   , "01")
                If Producto.PROnombre.Length > 0 Then
                    If Producto.fncRegistrarBUS() > 0 Then
                        SystemSounds.Beep.Play()
                        Notificar("Se ha registrado un nuevo producto en la base de datos.")
                        intIdProducto = Producto.IdProducto
                    End If
                Else
                    Notificar("Si está registrando un nuevo producto debe especificar un Código y una Descripción.")
                    Exit Sub
                End If
            Else
                Dim Producto As New clsProductoBUS
                Dim dtPrecio As DataTable = Producto.fncObtenerPrecioCostoActualProducto(intIdProducto, False)
                If fncValidaDataTable(dtPrecio) Then
                    Dim decPrecio As Decimal = ObtenerValorCelda(dtPrecio.Rows(0), "Precio")
                    Dim strCodigoMoneda As String = ObtenerValorCelda(dtPrecio.Rows(0), "CodigoMonedaCompra")
                    Dim strCodigoMonedaActual As String = If(rbDolares.Checked = True, "02", "01")

                    If decPrecio <> fncForzarDecimal(Me.txtCostoConIGV.Text) Or strCodigoMoneda <> strCodigoMonedaActual Then
                        Dim strMensajeAlerta As String = "Existen diferencias entre los datos ingresados y los datos existentes: " & vbCrLf
                        strMensajeAlerta &= If(decPrecio <> fncForzarDecimal(Me.txtCostoConIGV.Text), "El precio actual: " & decPrecio & ", es diferente al precio ingresado: " & fncForzarDecimal(Me.txtCostoConIGV.Text), "") & vbCrLf
                        strMensajeAlerta &= If(strCodigoMoneda <> strCodigoMonedaActual, "La moneda actual: " & If(strCodigoMoneda = "02", "Dólares", "Soles") & ", es diferente a la moneda registrada: " & If(strCodigoMonedaActual = "02", "Dólares", "Soles"), "") & vbCrLf
                        strMensajeAlerta &= "¿Desea actualizar el producto?"
                        If MsgBox(strMensajeAlerta, MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                            Dim dtProducto As DataTable = Producto.fncConsultarBUS(intIdProducto)
                            If fncValidaDataTable(dtProducto) Then
                                Producto.fncSetearBUS(dtProducto.Rows(0))
                                Producto.FechaModifica = FechaHoraServidor()
                                Producto.UsuarioModifica = My.Settings.Usuario
                                Producto.PrecioCoste = fncForzarDecimal(Me.txtCosto.Text)
                                Producto.PrecioCosteConIGV = fncForzarDecimal(Me.txtCostoConIGV.Text)
                                Producto.CodigoMonedaCompra = strCodigoMonedaActual
                                ''Producto.PrecioNetoConIGV = fncRound2(fncForzarDecimal(Me.txtCostoConIGV.Text))
                                Producto.fncModificarBUS()
                            End If
                        End If
                    End If

                End If
                
                'If chkActualizaPrecioCompra.Checked = True Then
                '    Dim Producto As New clsProductoBUS
                '    Dim dtProducto As DataTable = Producto.fncConsultarBUS(intIdProducto)
                '    If fncValidaDataTable(dtProducto) Then
                '        Producto.fncSetearBUS(dtProducto.Rows(0))
                '        Producto.FechaModifica = FechaHoraServidor()
                '        Producto.UsuarioModifica = My.Settings.Usuario
                '        Producto.PrecioCoste = fncForzarDecimal(Me.txtCosto.Text)
                '        Producto.PrecioCosteConIGV = fncForzarDecimal(Me.txtCostoConIGV.Text)
                '        ''Producto.PrecioNetoConIGV = fncRound2(fncForzarDecimal(Me.txtCostoConIGV.Text))
                '        Producto.fncModificarBUS()
                '    End If
                'End If

            End If
        End If



        If bolEsDetalleModifica = False Then
            Me.dgvDetalleCompra.Rows.Add()
            With dgvDetalleCompra.Rows(dgvDetalleCompra.Rows.Count - 1)
                .Cells("IdDetalleCompra").Value = If(bolEsDetalleModifica = True, intIdDetalleCompra, 0)
                .Cells("IdProducto").Value = intIdProducto
                .Cells("CodigoProducto").Value = Me.txtCodigoProducto.Text
                .Cells("DescripcionProducto").Value = Me.txtDescripcionProducto.Text
                .Cells("IdUnidadMedida").Value = cmbUnidadMedida.SelectedValue
                .Cells("UnidadMedida").Value = cmbUnidadMedida.Text
                .Cells("Cantidad").Value = FormatearNumero(fncForzarDecimal(Me.nudCantidad.Text), 1)
                .Cells("CostoUnidadSinIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtCosto.Text), 6)
                .Cells("CostoUnidadIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtIGVCosto.Text), 6)
                .Cells("CostoUnidadConIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtCostoConIGV.Text), 6)
                .Cells("CostoTotalSinIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtTotalSinIGV.Text), 2)
                '' decSubTotal += ObtenerValorCelda(row, "CostoTotalSinIGV")
                .Cells("CostoTotalIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtIGVTotal.Text), 2)
                ''  decTotalIGV += ObtenerValorCelda(row, "CostoTotalConIGV") - ObtenerValorCelda(row, "CostoTotalSinIGV")
                .Cells("CostoTotalConIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtTotalConIGV.Text), 2)
                .Cells("Estado").Value = enmEstado.Activo
                '' decTotalFinal += ObtenerValorCelda(row, "CostoTotalConIGV")
            End With
        Else
            If Me.dgvDetalleCompra.CurrentRow IsNot Nothing AndAlso Me.dgvDetalleCompra.Rows.Count > 0 Then
                With Me.dgvDetalleCompra.CurrentRow
                    .Cells("Cantidad").Value = FormatearNumero(fncForzarDecimal(Me.nudCantidad.Text), 1)
                    .Cells("CostoUnidadSinIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtCosto.Text), 6)
                    .Cells("CostoUnidadIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtIGVCosto.Text), 6)
                    .Cells("CostoUnidadConIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtCostoConIGV.Text), 6)
                    .Cells("CostoTotalSinIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtTotalSinIGV.Text), 2)
                    '' decSubTotal += ObtenerValorCelda(row, "CostoTotalSinIGV")
                    .Cells("CostoTotalIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtIGVTotal.Text), 2)
                    ''  decTotalIGV += ObtenerValorCelda(row, "CostoTotalConIGV") - ObtenerValorCelda(row, "CostoTotalSinIGV")
                    .Cells("CostoTotalConIGV").Value = FormatearNumero(fncForzarDecimal(Me.txtTotalConIGV.Text), 2)
                    .Cells("Estado").Value = enmEstado.Activo
                End With
            End If
        End If


        ''   btnCancelarProducto.PerformClick()
        LlenarTotalesOperacion()
        Me.dgvDetalleCompra.ClearSelection()
        Me.dgvDetalleCompra.Refresh()

        If bolEsDetalleModifica = True Then
            btnCancelarProducto.PerformClick()
            Me.ActiveControl = Me.btnAgregarDetalle
        Else
            bolTextChange = False
            Me.txtCodigoProducto.Text = ""
            Me.txtDescripcionProducto.Text = ""
            Me.ActiveControl = Me.txtCodigoProducto
            bolTextChange = True
        End If

        Me.lblMedida.ForeColor = Color.Black
        My.Settings.ActualizaPrecioCompra = Me.chkActualizaPrecioCompra.Checked

    End Sub



    Private Sub dgvProducto_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProducto.CellDoubleClick
        If Me.dgvProducto.Rows.Count > 0 AndAlso Me.dgvProducto.CurrentRow IsNot Nothing Then
            SeleccionaProducto()
        End If
    End Sub

    Private Sub dgvDetalleCompra_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvDetalleCompra.CellFormatting
        Try
            With Me.dgvDetalleCompra
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

    Private Sub btnQuitarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarDetalle.Click
        If Me.dgvDetalleCompra.CurrentRow IsNot Nothing Then
            Dim intIndex = Me.dgvDetalleCompra.CurrentRow.Index
            Me.dgvDetalleCompra.CurrentRow.Cells("Estado").Value = enmEstado.Inactivo
            Me.dgvDetalleCompra.CurrentRow.Visible = False

            FilaInvisibleIndex(dgvDetalleCompra, intIndex)
        End If
        Me.dgvDetalleCompra.Refresh()
        Me.dgvDetalleCompra.ClearSelection()
        LlenarTotalesOperacion()
    End Sub



    Private Sub btnModificarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarDetalle.Click
        Controles_En_ModificarProducto()
        If Me.dgvDetalleCompra.CurrentRow IsNot Nothing Then
            bolEsDetalleModifica = True
            With Me.dgvDetalleCompra.CurrentRow
                bolTextChange = False
                Me.nudCantidad.Text = .Cells("Cantidad").Value
                Me.intIdProducto = .Cells("IdProducto").Value
                Me.txtCodigoProducto.Text = .Cells("CodigoProducto").Value
                Me.txtDescripcionProducto.Text = .Cells("DescripcionProducto").Value
                Me.cmbUnidadMedida.SelectedValue = .Cells("IdUnidadMedida").Value
                Me.txtCosto.Text = fncForzarDecimal(.Cells("CostoUnidadSinIGV").Value)
                Me.txtIGVCosto.Text = fncForzarDecimal(.Cells("CostoUnidadIGV").Value)
                Me.txtCostoConIGV.Text = fncForzarDecimal(.Cells("CostoUnidadConIGV").Value)
                bolPivot = False
                Me.txtCostoConIGV.Text = FormatearNumero(fncForzarDecimal(.Cells("CostoUnidadConIGV").Value), 4)
                Me.txtTotalSinIGV.Text = fncForzarDecimal(.Cells("CostoTotalSinIGV").Value)
                Me.txtIGVTotal.Text = fncForzarDecimal(.Cells("CostoTotalIGV").Value)
                bolPivot = True
                Me.txtTotalConIGV.Text = fncForzarDecimal(.Cells("CostoTotalConIGV").Value)
                Me.intIdDetalleCompra = .Cells("IdDetalleCompra").Value
                Me.ActiveControl = Me.nudCantidad
                Me.nudCantidad.Select(0, Me.nudCantidad.Text.Length)
                bolTextChange = True
            End With


        Else
            Notificar("Debe seleccionar un item del detalle.")
        End If

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
        ErrorCompras.Clear()
        Controles_En_Load()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If intIdCompra > 0 Then
            Controles_En_ModificarOperacion()
            Me.ActiveControl = Me.txtProveedorRUC
            Me.txtProveedorRUC.Select(0, txtProveedorRUC.Text.Length)
        Else
            Notificar("Debe seleccionar una operación a Modificar.")
        End If
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        If fncDetalleVisible(dgvDetalleCompra) > 0 Then
            Notificar("No puede eliminar este comprobante sin antes eliminar todo el detalle.")
            Exit Sub
        End If

        If MsgBox("¿Está seguro de que desea anular este comprobante?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            If intIdCompra > 0 Then
                Dim Compra As New clsCompraBUS
                Dim DetalleCompra As New clsDetalleCompraBUS
                Dim dtCompra As DataTable = Compra.fncConsultarBUS(Me.intIdCompra)
                If fncValidaDataTable(dtCompra) Then
                    Compra.fncSetearBUS(dtCompra.Rows(0))
                    With Compra
                        .Estado = enmEstado.Inactivo
                        .FechaModifica = FechaHoraServidor()
                        .UsuarioModifica = My.Settings.Usuario
                        If .fncModificarBUS() > 0 Then

                            Dim dtDetalleCompra As DataTable = DetalleCompra.fncListarDetallePorCompraBUS(Me.intIdCompra)

                            For Each row In dtDetalleCompra.Rows
                                Dim intIdDetalleCompra As Integer = ObtenerValorCelda(row, "IdDetalleCompra")
                                Dim dtDetalle = DetalleCompra.fncConsultarBUS(intIdDetalleCompra)
                                If fncValidaDataTable(dtDetalle) Then
                                    DetalleCompra.fncSetearBUS(dtDetalle.Rows(0))
                                    DetalleCompra.Estado = enmEstado.Inactivo
                                    DetalleCompra.FechaModifica = FechaHoraServidor()
                                    DetalleCompra.fncModificarBUS()

                                End If
                            Next

                            Notificar("Comprobante Anulado")
                            Dim intIdCompraProvisional As Integer = intIdCompra
                            Controles_En_Load()
                            LlenarDatosPorCompra(intIdCompraProvisional)
                        End If
                    End With
                End If
            Else
                Notificar("Debe seleccionar una operación a Anular.")
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If bolEsCompraNueva = True Then


            If Me.txtSerie.Text.Length <= 0 Or Me.txtNumero.Text.Length <= 0 Or fncForzarDecimal(Me.txtNumero.Text.Length) <= 0 Then
                ErrorCompras.SetError(Me.txtNumero, "Especifique un número de comprobante válido")
                Exit Sub
            ElseIf Me.intIdProveedor = 0 Then
                ErrorCompras.SetError(Me.txtProveedorRUC, "Debe especificar un Proveedor.")
                Exit Sub
            Else
                ErrorCompras.SetError(Me.txtNumero, Nothing)
            End If

            Dim CompraValida As New clsCompraBUS
            Dim dtCompraValida As DataTable = CompraValida.fncValidaNumeroCompraBUS(Me.txtSerie.Text, Me.txtNumero.Text, Me.intIdProveedor, Me.cmbTipoComprobante.SelectedValue)
            If fncValidaDataTable(dtCompraValida) Then
                ErrorCompras.SetError(Me.txtNumero, "Este número de comprobante ya se ha registrado")
                Exit Sub
            End If

            Dim Compra As New clsCompraBUS(0, Me.txtSerie.Text, Me.txtNumero.Text _
                                           , Me.txtDescripcion.Text _
                                           , Me.txtObservacion.Text _
                                           , Me.intIdProveedor _
                                           , Me.dtpFechaCompra.Value _
                                           , Me.dtpFechaCompra.Value _
                                           , enmModalidadPago.Contado _
                                           , cmbTipoComprobante.SelectedValue _
                                           , 1 _
                                           , fncForzarDecimal(Me.txtIGV.Text) _
                                           , enmTipoInterno.CompraConIGV _
                                           , If(rbDolares.Checked = True, "02", "01"))
            If Compra.fncRegistrarBUS() > 0 Then
                intIdCompra = Compra.IdCompra
                '' Registra Transporte
                'Dim intIdProveedorTransporte As Integer = Integer.Parse(fncForzarDecimal(Me.txtIdTransporte.Text))
                'If intIdProveedorTransporte > 0 Then
                '    Dim Transporte As New clsRegularCostBUS(0 _
                '                                            , intIdCompra _
                '                                            , Me.txtSerieTransporte.Text _
                '                                            , Me.txtNumeroTransporte.Text _
                '                                            , enmRegularConcept.Transporte _
                '                                            , intIdProveedorTransporte _
                '                                            , fncForzarDecimal(Me.txtMontoTransporte.Text) _
                '                                            , dtpFechaCompra.Value _
                '                                            , Me.txtObservacionTransporte.Text)
                '    If Transporte.fncRegistrarBUS > 0 Then
                '        ' Mensaje
                '    End If
                'End If

                ' Registra Detalle
                If intIdCompra > 0 Then
                    For i = 0 To dgvDetalleCompra.Rows.Count - 1
                        If dgvDetalleCompra.Rows(i).Visible = True Then
                            Dim Detalle As New clsDetalleCompraBUS(0, intIdCompra, dgvDetalleCompra.Rows(i).Cells("IdProducto").Value _
                                                                   , dgvDetalleCompra.Rows(i).Cells("Cantidad").Value _
                                                                   , dgvDetalleCompra.Rows(i).Cells("CostoUnidadSinIGV").Value _
                                                                   , dgvDetalleCompra.Rows(i).Cells("CostoUnidadIGV").Value _
                                                                   , dgvDetalleCompra.Rows(i).Cells("CostoUnidadConIGV").Value _
                                                                   , dgvDetalleCompra.Rows(i).Cells("CostoTotalSinIGV").Value _
                                                                   , dgvDetalleCompra.Rows(i).Cells("CostoTotalIGV").Value _
                                                                   , dgvDetalleCompra.Rows(i).Cells("CostoTotalConIGV").Value _
                                                                   , FechaHoraServidor _
                                                                   , 1 _
                                                                   , dgvDetalleCompra.Rows(i).Cells("CodigoProducto").Value _
                                                                   , dgvDetalleCompra.Rows(i).Cells("DescripcionProducto").Value _
                                                                   , dgvDetalleCompra.Rows(i).Cells("IdUnidadMedida").Value)
                            If Detalle.fncRegistrarBUS > 0 Then
                                My.Settings.UltimoSerieCompraFactura = Me.txtSerie.Text
                            Else

                                Notificar("Error en Registro de Detalle de Compra", "Error")
                            End If
                        End If
                    Next
                    My.Settings.UltimoTipoUsadoCompra = Me.cmbTipoComprobante.SelectedValue
                    My.Settings.UltimoSerieCompraFactura = Me.txtSerie.Text
                    My.Settings.UltimaFechaCompra = Me.dtpFechaCompra.Value
                    Notificar("Registrado con éxito.")
                    Dim intIdCompraProvisional As Integer = Me.intIdCompra
                    My.Settings.IGV = decIGVCompra
                    Controles_En_Load()
                    LlenarDatosPorCompra(intIdCompraProvisional)

                Else
                    Notificar("Error en Registro de Compra", "ERROR")
                End If
            Else
                Notificar("Error en Registro de Compra", "ERROR")
            End If

        Else
            If intIdCompra > 0 And intIdProveedor > 0 Then
                Dim Compra As New clsCompraBUS

                Dim dtCompraValida As DataTable = Compra.fncValidaCompraExistenteBUS(Me.intIdCompra, Me.cmbTipoComprobante.SelectedValue, Me.txtSerie.Text, Me.txtNumero.Text, Me.intIdProveedor)
                If fncValidaDataTable(dtCompraValida) Then
                    ErrorCompras.SetError(txtNumero, "No puede usar esta combinación de Tipo de Comprobante, Serie, Numero y Proveedor; porque ya se encuentra en uso.")
                    Exit Sub
                Else
                    ErrorCompras.SetError(txtNumero, Nothing)
                End If

                Dim dtCompra As DataTable = Compra.fncConsultarBUS(Me.intIdCompra)
                If fncValidaDataTable(dtCompra) Then
                    Compra.fncSetearBUS(dtCompra.Rows(0))
                    With Compra
                        .Serie = txtSerie.Text
                        .Numero = txtNumero.Text
                        .IdTipoComprobante = Me.cmbTipoComprobante.SelectedValue
                        .FechaCompra = Me.dtpFechaCompra.Value
                        .IdProveedor = intIdProveedor
                        .IGV = fncForzarDecimal(Me.txtIGV.Text)
                        .FechaModifica = FechaHoraServidor()
                        .UsuarioModifica = My.Settings.Usuario
                        .Descripcion = Me.txtDescripcion.Text
                        .Observacion = Me.txtObservacion.Text
                        .CodigoMoneda = If(rbDolares.Checked = True, "02", "01")
                    End With



                    '' Transporte
                    'Dim Transporte As New clsRegularCostBUS
                    'Dim intIdProveedorTransporte As Integer = Integer.Parse(fncForzarDecimal(Me.txtIdTransporte.Text))
                    'If intIdProveedorTransporte > 0 Then
                    '    Dim dtTransporte As DataTable = Transporte.fncRegularCostPorIdCompraBUS(Me.intIdCompra)
                    '    ' Existe Transporte
                    '    If fncValidaDataTable(dtTransporte) Then
                    '        Dim intIdRegularCost As Integer = ObtenerValorCelda(dtTransporte.Rows(0), "IdRegularCost")
                    '        Dim dtRegistroTransporte As DataTable = Transporte.fncConsultarBUS(intIdRegularCost)
                    '        If fncValidaDataTable(dtRegistroTransporte) Then
                    '            Transporte.fncSetearBUS(dtRegistroTransporte.Rows(0))
                    '            Transporte.CostDate = Me.dtpFechaCompra.Value
                    '            Transporte.Amount = fncForzarDecimal(Me.txtMontoTransporte.Text)
                    '            Transporte.IdProveedor = intIdProveedorTransporte
                    '            Transporte.CostDescription = Me.txtObservacionTransporte.Text
                    '            If Transporte.fncModificarBUS > 0 Then
                    '            Else
                    '                Notificar("Error al modificar transporte.", "SERVOX")
                    '            End If
                    '        End If
                    '    Else
                    '        Dim NuevoTransporte As New clsRegularCostBUS(0 _
                    '                                       , intIdCompra _
                    '                                       , Me.txtSerieTransporte.Text _
                    '                                       , Me.txtNumeroTransporte.Text _
                    '                                       , enmRegularConcept.Transporte _
                    '                                       , intIdProveedorTransporte _
                    '                                       , fncForzarDecimal(Me.txtMontoTransporte.Text) _
                    '                                       , dtpFechaCompra.Value _
                    '                                       , Me.txtObservacionTransporte.Text)
                    '        If NuevoTransporte.fncRegistrarBUS > 0 Then
                    '            ' Mensaje
                    '        Else
                    '            Notificar("Error al registrar nuevo transporte.", "SERVOX")
                    '        End If
                    '    End If
                    'Else
                    '    Dim dtTransporte As DataTable = Transporte.fncRegularCostPorIdCompraBUS(Me.intIdCompra)
                    '    ' Existe Transporte
                    '    If fncValidaDataTable(dtTransporte) Then
                    '        Dim intIdRegularCost As Integer = ObtenerValorCelda(dtTransporte.Rows(0), "IdRegularCost")
                    '        Dim dtRegistroTransporte As DataTable = Transporte.fncConsultarBUS(intIdRegularCost)
                    '        If fncValidaDataTable(dtRegistroTransporte) Then
                    '            Transporte.fncSetearBUS(dtRegistroTransporte.Rows(0))
                    '            Transporte.CostStatus = enmEstado.Inactivo
                    '            If Transporte.fncModificarBUS > 0 Then

                    '            Else
                    '                Notificar("Error al modificar transporte.", "SERVOX")
                    '            End If
                    '        End If
                    '    End If
                    'End If

                    ' Detalle
                    If Compra.fncModificarBUS() > 0 Then
                        For i = 0 To dgvDetalleCompra.Rows.Count - 1
                            If dgvDetalleCompra.Rows(i).Visible = True Then
                                Dim intIdDetalleCompra As Integer = dgvDetalleCompra.Rows(i).Cells("IdDetalleCompra").Value
                                If intIdDetalleCompra > 0 Then
                                    '' Modificar
                                    Dim Detalle As New clsDetalleCompraBUS()
                                    Dim dtDetalle As DataTable = Detalle.fncConsultarBUS(intIdDetalleCompra)

                                    If fncValidaDataTable(dtDetalle) Then
                                        Detalle.fncSetearBUS(dtDetalle.Rows(0))
                                        With Detalle
                                            .PROnombre = dgvDetalleCompra.Rows(i).Cells("CodigoProducto").Value
                                            .PROdescripcion = dgvDetalleCompra.Rows(i).Cells("DescripcionProducto").Value
                                            .Cantidad = dgvDetalleCompra.Rows(i).Cells("Cantidad").Value
                                            .UsuarioModifica = My.Settings.Usuario
                                            .CostoUnidadSinIGV = fncForzarDecimal(dgvDetalleCompra.Rows(i).Cells("CostoUnidadSinIGV").Value)
                                            .UnidadIGV = fncForzarDecimal(dgvDetalleCompra.Rows(i).Cells("CostoUnidadIGV").Value)
                                            .CostoUnidadConIGV = fncForzarDecimal(dgvDetalleCompra.Rows(i).Cells("CostoUnidadConIGV").Value)

                                            .CostoTotalSinIGV = fncForzarDecimal(dgvDetalleCompra.Rows(i).Cells("CostoTotalSinIGV").Value)
                                            .CostoIGV = fncForzarDecimal(dgvDetalleCompra.Rows(i).Cells("CostoTotalIGV").Value)
                                            .CostoTotalConIGV = fncForzarDecimal(dgvDetalleCompra.Rows(i).Cells("CostoTotalConIGV").Value)
                                            .FechaModifica = FechaHoraServidor()
                                            .fncModificarBUS()
                                        End With
                                    End If
                                Else
                                    '' Registrar
                                    Dim Detalle As New clsDetalleCompraBUS(intIdDetalleCompra, intIdCompra, dgvDetalleCompra.Rows(i).Cells("IdProducto").Value _
                                                              , dgvDetalleCompra.Rows(i).Cells("Cantidad").Value _
                                                              , dgvDetalleCompra.Rows(i).Cells("CostoUnidadSinIGV").Value _
                                                              , dgvDetalleCompra.Rows(i).Cells("CostoUnidadIGV").Value _
                                                              , dgvDetalleCompra.Rows(i).Cells("CostoUnidadConIGV").Value _
                                                              , dgvDetalleCompra.Rows(i).Cells("CostoTotalSinIGV").Value _
                                                              , dgvDetalleCompra.Rows(i).Cells("CostoTotalIGV").Value _
                                                              , dgvDetalleCompra.Rows(i).Cells("CostoTotalConIGV").Value _
                                                              , FechaHoraServidor _
                                                              , 1 _
                                                              , dgvDetalleCompra.Rows(i).Cells("CodigoProducto").Value _
                                                              , dgvDetalleCompra.Rows(i).Cells("DescripcionProducto").Value _
                                                              , dgvDetalleCompra.Rows(i).Cells("IdUnidadMedida").Value)
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
                                Dim intIdDetalleCompra As Integer = dgvDetalleCompra.Rows(i).Cells("IdDetalleCompra").Value
                                If intIdDetalleCompra > 0 Then
                                    '' Eliminar (estado 0)
                                    Dim Detalle As New clsDetalleCompraBUS()
                                    Dim dtDetalle As DataTable = Detalle.fncConsultarBUS(intIdDetalleCompra)

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
                        Dim intIdCompraProvisional As Integer = Me.intIdCompra
                        Controles_En_Load()
                        LlenarDatosPorCompra(intIdCompraProvisional)

                    Else
                        Notificar("Error al modificar compra", "ERROR")
                    End If
                Else
                    Notificar("Esta compra no existe", "Error")
                End If
            Else
                Notificar("Debe seleccionar una compra a modificar y esta debe tener un Proveedor", "ERROR")
            End If



        End If
    End Sub

    Private Sub btnBuscarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarProveedor.Click
        Dim ObjFrmHijo As New frmMantenimientoProveedor
        'ObjFrmHijo.pFormularioPadrePTA = Me.Name
        'ObjFrmHijo.bolEsBusqueda = True
        'ObjFrmHijo.Owner = Me
        'ObjFrmHijo.ShowDialog()
        ObjFrmHijo.bolEnviar = True
        ObjFrmHijo.bolEsModificar = False
        If ObjFrmHijo.ShowDialog = Windows.Forms.DialogResult.OK Then


            With ObjFrmHijo.dgvProveedor.CurrentRow
                bolBuscaAutomaticaProveedor = False
                Me.intIdProveedor = .Cells("IdProveedor").Value
                Me.txtProveedorRUC.Text = .Cells("DocumentoIdentidad").Value '' .Cells("Tipo").Value & " : " & .Cells("DocumentoIdentidad").Value
                Me.txtProveedorNombre.Text = .Cells("Nombre").Value
                bolBuscaAutomaticaProveedor = True
                ''SeteaNodo(.Cells("IdPtaDependencia").Value)
            End With

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

            Me.intIdProducto = .Cells("subIdProducto").Value
            Me.nudCantidad.Text = 0 '' If(.Cells("subStockActual").Value >= 0, .Cells("subStockActual").Value, 0)
            Me.txtCodigoProducto.Text = .Cells("subCodigoProducto").Value
            Me.txtDescripcionProducto.Text = .Cells("subDescripcionProducto").Value
            Me.cmbUnidadMedida.SelectedValue = .Cells("subIdMedida").Value
            Me.lblTituloPanel.Text = .Cells("subCodigoProducto").Value
            Dim strCodigoMonedaCompra As String = .Cells("subCodigoMonedaCompra").Value
            Me.lblMoneda.Text = If(strCodigoMonedaCompra = "02", "Dólares", "Soles")

            bolPivot = False
            Me.txtCostoConIGV.Text = fncForzarDecimal(.Cells("subCosteConIGV").Value)
            '' Me.txtTotalSinIGV.Text = FormatearNumero(fncForzarDecimal(.Cells("subCosteSinIGV").Value) * .Cells("subStockActual").Value, 2)
        End With

        Controles_En_ProductoSeleccionado()
        bolTextChange = True
        Me.ActiveControl = Me.nudCantidad
        Me.nudCantidad.Select(0, Me.nudCantidad.Text.Length)
    End Sub

    Private Sub btnBuscarFactura_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarFactura.Click
        Dim ObjFrmHijo As New frmBuscadorOperacion
        'ObjFrmHijo.pFormularioPadrePTA = Me.Name
        'ObjFrmHijo.bolEsBusqueda = True
        'ObjFrmHijo.Owner = Me
        'ObjFrmHijo.ShowDialog()
        ObjFrmHijo.bolEnviar = True
        ObjFrmHijo.bolEsVenta = False
        ObjFrmHijo.ActiveControl = ObjFrmHijo.txtNumero
        ObjFrmHijo.intIdIdentificador = enmTipoInterno.CompraConIGV  'Compra con IGV
        ObjFrmHijo.intIdTipoInterno = enmTipoInterno.CompraConIGV
        If ObjFrmHijo.ShowDialog = Windows.Forms.DialogResult.OK Then

            Controles_En_Load()
            LlenarDatosPorCompra(fncForzarDecimal(ObjFrmHijo.txtIdOperacion.Text))

            'With ObjFrmHijo.dgvProveedor.CurrentRow

            '    Me.intIdProveedor = .Cells("IdProveedor").Value
            '    Me.txtProveedorRUC.Text = .Cells("Tipo").Value & " : " & .Cells("DocumentoIdentidad").Value
            '    Me.txtProveedorNombre.Text = .Cells("Nombre").Value
            '    ''SeteaNodo(.Cells("IdPtaDependencia").Value)
            'End With

        End If
    End Sub

    Private Sub txtCodigoProducto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodigoProducto.TextChanged
        If bolTextChange = True Then
            BuscarProductoBase(strCodigo:=Me.txtCodigoProducto.Text)
        End If

    End Sub

    Private Sub txtDescripcionProducto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDescripcionProducto.TextChanged
        If bolTextChange = True Then
            BuscarProductoBase(strDescripcion:=txtDescripcionProducto.Text)
        End If

    End Sub

    Private Sub txtProveedorRUC_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtProveedorRUC.KeyDown
        If e.KeyCode = Keys.Enter Then
            If bolBuscaAutomaticaProveedor = True Then
                If intIdProveedor <> 0 Then

                    bolBuscaAutomaticaProveedor = False
                    Me.txtProveedorRUC.Text = Me.strRUCPROVEEDORBusquedaActual
                    bolBuscaAutomaticaProveedor = True

                    If Me.intIdCompra = 0 Then ' Nueva compra
                        Dim CompraValida As New clsCompraBUS
                        Dim dtCompraValida As DataTable = CompraValida.fncValidaNumeroCompraBUS(Me.txtSerie.Text, Me.txtNumero.Text, Me.intIdProveedor, Me.cmbTipoComprobante.SelectedValue)
                        If fncValidaDataTable(dtCompraValida) Then
                            Notificar("Esta combinación de comprobante y proveedor ya se ha registrado. El sistema no le dejará guardar.")
                            Exit Sub
                        End If
                    End If
                    

                    Me.ActiveControl = Me.dtpFechaCompra

                    ''Me.ActiveControl = Me.btnAgregarDetalle
                    ''Me.btnAgregarDetalle.PerformClick()
                Else

                    Me.ActiveControl = Me.txtProveedorNombre
                    Me.txtProveedorNombre.Select(0, Me.txtProveedorNombre.Text.Length)

                End If

            End If
        End If

    End Sub

    'Private Sub txtTotalSinIGV_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtTotalSinIGV.KeyDown
    '    If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
    '        Me.ActiveControl = Me.txtTotalConIGV
    '        Me.txtTotalConIGV.Select(0, txtTotalConIGV.Text.Length)
    '    ElseIf e.KeyCode = Keys.Escape Then
    '        Me.btnCancelarProducto.PerformClick()
    '    ElseIf e.KeyCode = Keys.Up Then
    '        Me.ActiveControl = Me.nudCantidad
    '        nudCantidad.Select(0, nudCantidad.Text.Length)
    '        'ElseIf e.KeyCode = Keys.Left Then
    '        '    If Me.txtDescripcionProducto.Enabled = True Then
    '        '        Me.ActiveControl = Me.txtDescripcionProducto
    '        '        txtDescripcionProducto.Select(0, txtDescripcionProducto.Text.Length)
    '        '    End If
    '    End If
    ''   End Sub

    Private Sub dgvDetalleCompra_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleCompra.CellDoubleClick
        If Me.btnModificarDetalle.Enabled Then
            Me.btnModificarDetalle.PerformClick()
        End If
    End Sub

    Private Sub nudCantidad_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles nudCantidad.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            Me.ActiveControl = Me.txtCostoConIGV
            Me.txtCostoConIGV.Select(0, txtCostoConIGV.Text.Length)
        ElseIf e.KeyCode = Keys.Up Then
            If Me.txtDescripcionProducto.Enabled = True Then
                Me.ActiveControl = Me.txtDescripcionProducto
                Me.txtDescripcionProducto.Select(0, txtDescripcionProducto.Text.Length)
            End If
            'ElseIf e.KeyCode = Keys.Right Then
            '    Me.ActiveControl = Me.txtTotalConIGV
            '    Me.txtTotalConIGV.Select(0, txtTotalConIGV.Text.Length)
        End If
    End Sub

    'Private Sub txtTotalConIGV_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtTotalConIGV.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        Me.btnConfirmarProducto.PerformClick()
    '    ElseIf e.KeyCode = Keys.Escape Then
    '        Me.btnCancelarProducto.PerformClick()
    '        'ElseIf e.KeyCode = Keys.Up Then
    '        '    Me.ActiveControl = nudCantidad
    '        '    nudCantidad.Select(0, nudCantidad.Text.Length)
    '    ElseIf e.KeyCode = Keys.Up Then
    '        Me.ActiveControl = txtTotalSinIGV
    '        txtTotalSinIGV.Select(0, txtTotalSinIGV.Text.Length)
    '    End If
    'End Sub

    Private Sub txtSerie_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSerie.KeyDown
        If e.KeyCode = Keys.Enter Then


            If bolEsCompraNueva = True Then
                Me.txtNumero.Text = String.Empty
            End If


            If txtSerie.Text.Trim.Length < 3 Then
                txtSerie.Text = CerosIzquierda(txtSerie.Text, 3)
            End If


            Me.ActiveControl = Me.txtNumero
            Me.txtNumero.Select(0, Me.txtNumero.Text.Length)
        End If
    End Sub

    Private Sub txtNumero_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNumero.KeyDown
        If e.KeyCode = Keys.Enter Then

            

            If txtNumero.Text.Trim.Length < 8 Then
                txtNumero.Text = CerosIzquierda(txtNumero.Text, 8)
            End If

            Me.ActiveControl = Me.txtProveedorRUC
            Me.txtProveedorRUC.Select(0, txtProveedorRUC.Text.Length)
        End If
    End Sub

    Private Sub dgvDetalleCompra_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvDetalleCompra.KeyDown
        'If Me.dgvDetalleCompra.Rows.Count > 0 AndAlso Me.dgvDetalleCompra.CurrentRow IsNot Nothing Then
        '    Me.btnQuitarDetalle.PerformClick()
        'End If
        If e.KeyCode = Keys.Add Then
            Me.btnAgregarDetalle.PerformClick()
        ElseIf e.KeyCode = Keys.Subtract Or e.KeyCode = Keys.Delete Then
            Me.btnQuitarDetalle.PerformClick()
        End If
    End Sub

    Private Sub btnAgregarDetalle_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles btnQuitarDetalle.KeyDown, btnModificarDetalle.KeyDown, btnAgregarDetalle.KeyDown
        If e.KeyCode = Keys.Down Then
            If btnGuardar.Enabled = True Then
                Me.ActiveControl = Me.btnGuardar
            Else
                Me.ActiveControl = Me.btnCancelar
            End If
        End If
    End Sub

    Private Sub cmbUnidadMedida_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbUnidadMedida.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Right Then
            Me.ActiveControl = Me.nudCantidad
            Me.nudCantidad.Select(0, Me.nudCantidad.Text.Length)
        End If
    End Sub

    Private Sub txtProveedorNombre_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtProveedorNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.dtpFechaCompra
        End If
    End Sub

    Private Sub dtpFechaCompra_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpFechaCompra.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.btnAgregarDetalle
            Me.btnAgregarDetalle.PerformClick()
        End If
    End Sub

    Private Sub txtCosto_Enter_1(sender As System.Object, e As System.EventArgs) Handles txtCosto.Enter
        bolPivot = True
    End Sub

    Private Sub txtCostoConIGV_Enter_1(sender As System.Object, e As System.EventArgs) Handles txtCostoConIGV.Enter
        bolPivot = False
    End Sub

    Private Sub txtCosto_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtCosto.TextChanged
        If bolPivot = True Then
            Dim decCostoUnitarioSinIGV As Decimal = fncRound4(fncForzarDecimal(Me.txtCosto.Text))
            Dim decCostoUnitarioConIGV As Decimal = fncRound4(decCostoUnitarioSinIGV * (1 + decIGVCompra))
            Dim decCostoUnitarioIGV As Decimal = fncRound4(decCostoUnitarioConIGV - decCostoUnitarioSinIGV)


            Dim decCostoTotalSinIGV As Decimal = fncRound2(decCostoUnitarioSinIGV * fncForzarDecimal(nudCantidad.Text))
            Dim decCostoTotalConIGV As Decimal = fncRound2(decCostoTotalSinIGV * (1 + decIGVCompra))
            Dim decCostoTotalIGV As Decimal = fncRound2(decCostoTotalConIGV - decCostoTotalSinIGV)

            Me.txtIGVCosto.Text = FormatearNumero(decCostoUnitarioIGV, 4)
            Me.txtCostoConIGV.Text = FormatearNumero(decCostoUnitarioConIGV, 4)

            Me.txtTotalSinIGV.Text = FormatearNumero(decCostoTotalSinIGV, 2)
            Me.txtIGVTotal.Text = FormatearNumero(decCostoTotalIGV, 2)
            Me.txtTotalConIGV.Text = FormatearNumero(decCostoTotalConIGV, 2)

        End If
    End Sub

    Private Sub txtCostoConIGV_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtCostoConIGV.TextChanged
        If bolPivot = False Then


            'Dim decTotalConIGV As Decimal = fncRound2(fncForzarDecimal(nudCantidad.Text) * fncForzarDecimal(Me.txtCostoConIGV.Text))

            'Me.txtTotalConIGV.Text = FormatearNumero(decTotalConIGV, 2)
            'Dim decTotalSinIGV As Decimal = fncRound2(decTotalConIGV / (1 + decIGVCompra))
            'Me.txtTotalSinIGV.Text = FormatearNumero(decTotalSinIGV, 2)
            'Me.txtIGVTotal.Text = FormatearNumero(fncRound2(decTotalConIGV - decTotalSinIGV), 2)

            Dim decCostoUnitarioConIGV As Decimal = fncForzarDecimal(Me.txtCostoConIGV.Text)
            Dim decCostoUnitarioSinIGV As Decimal = decCostoUnitarioConIGV / (1 + decIGVCompra)
            Dim decCostoUnitarioIGV As Decimal = decCostoUnitarioConIGV - decCostoUnitarioSinIGV

            Dim decCostoTotalConIGV As Decimal = fncRound2(decCostoUnitarioConIGV * fncForzarDecimal(nudCantidad.Text))
            Dim decCostoTotalSinIGV As Decimal = fncRound2(decCostoTotalConIGV / (1 + decIGVCompra))
            Dim decCostoTotalIGV As Decimal = fncRound2(decCostoTotalConIGV - decCostoTotalSinIGV)

            Me.txtIGVCosto.Text = FormatearNumero(decCostoUnitarioIGV, 4)
            Me.txtCosto.Text = FormatearNumero(decCostoUnitarioSinIGV, 4)

            Me.txtTotalSinIGV.Text = FormatearNumero(decCostoTotalSinIGV, 2)
            Me.txtIGVTotal.Text = FormatearNumero(decCostoTotalIGV, 2)
            Me.txtTotalConIGV.Text = FormatearNumero(decCostoTotalConIGV, 2)

        End If
    End Sub

    Private Sub txtCosto_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCosto.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            Me.ActiveControl = Me.txtCostoConIGV
            Me.txtCostoConIGV.Select(0, txtCostoConIGV.Text.Length)
        ElseIf e.KeyCode = Keys.Escape Then
            Me.btnCancelarProducto.PerformClick()
        ElseIf e.KeyCode = Keys.Up Then
            Me.ActiveControl = Me.nudCantidad
            nudCantidad.Select(0, nudCantidad.Text.Length)
            'ElseIf e.KeyCode = Keys.Left Then
            '    If Me.txtDescripcionProducto.Enabled = True Then
            '        Me.ActiveControl = Me.txtDescripcionProducto
            '        txtDescripcionProducto.Select(0, txtDescripcionProducto.Text.Length)
            '    End If
        End If
    End Sub

    Private Sub txtCostoConIGV_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCostoConIGV.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnConfirmarProducto.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.btnCancelarProducto.PerformClick()
            'ElseIf e.KeyCode = Keys.Up Then
            '    Me.ActiveControl = nudCantidad
            '    nudCantidad.Select(0, nudCantidad.Text.Length)
        ElseIf e.KeyCode = Keys.Up Then
            Me.ActiveControl = nudCantidad
            nudCantidad.Select(0, nudCantidad.Text.Length)
        ElseIf e.KeyCode = Keys.Down Then
            Me.ActiveControl = txtTotalConIGV
            txtTotalConIGV.Select(0, txtTotalConIGV.Text.Length)
        End If
    End Sub

    Private Sub txtBusquedaDetalle_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBusquedaDetalle.TextChanged
        BuscarEnDataGrid(dgvDetalleCompra, txtBusquedaDetalle.Text, {"CodigoProducto", "DescripcionProducto"}, "CodigoProducto")
    End Sub

    Private Sub btnCodigosProducto_Click(sender As System.Object, e As System.EventArgs) Handles btnCodigosProducto.Click
        If Me.intIdCompra <= 0 Then
            Notificar("Debe guardar el comprobante antes de ingresar series.")
        End If

        If Me.dgvDetalleCompra.Rows.Count > 0 AndAlso Me.dgvDetalleCompra.CurrentRow IsNot Nothing Then
            Dim ObjFrmHijo As New frmMantenimientoCodigosUnidad
            Dim dtProducto As New DataTable
            dtProducto.Columns.Add("IdDetalle", GetType(Integer))
            dtProducto.Columns.Add("Producto", GetType(String))
            dtProducto.Columns.Add("Cantidad", GetType(Decimal))
            For i = 0 To dgvDetalleCompra.Rows.Count - 1
                dtProducto.Rows.Add(Me.dgvDetalleCompra.Rows(i).Cells("IdDetalleCompra").Value, Me.dgvDetalleCompra.Rows(i).Cells("CodigoProducto").Value, (Me.dgvDetalleCompra.Rows(i).Cells("Cantidad").Value))
            Next

            ''  Dim intIdDetalleCompra As Integer = Me.dgvDetalleCompra.CurrentRow.Cells("IdDetalleCompra").Value
            'ObjFrmHijo.pFormularioPadrePTA = Me.Name
            'ObjFrmHijo.bolEsBusqueda = True
            'ObjFrmHijo.Owner = Me
            'ObjFrmHijo.ShowDialog()
            ObjFrmHijo.dtProducto = dtProducto
            ObjFrmHijo.ConstruyeProductos(dtProducto)
            ObjFrmHijo.intCantidadUnidad = Me.dgvDetalleCompra.CurrentRow.Cells("Cantidad").Value
            ObjFrmHijo.txtComprobante.Text = txtSerie.Text & "-" & txtNumero.Text
            ObjFrmHijo.intIdCompra = Me.intIdCompra  ' intIdDetalleCompra
            ObjFrmHijo.bolEsCodigosCompra = True
            ObjFrmHijo.ListarCodigosBase()
            ObjFrmHijo.ActiveControl = ObjFrmHijo.btnNuevo
            If ObjFrmHijo.ShowDialog = Windows.Forms.DialogResult.OK Then

            End If
        End If
    End Sub

    Private Sub btnLimpiarTransporte_Click(sender As System.Object, e As System.EventArgs)
        ResetControlesTransporte()
    End Sub

    Private Sub btnBuscarProveedorTransporte_Click(sender As System.Object, e As System.EventArgs)
        Dim ObjFrmHijo As New frmMantenimientoProveedor
        'ObjFrmHijo.pFormularioPadrePTA = Me.Name
        'ObjFrmHijo.bolEsBusqueda = True
        'ObjFrmHijo.Owner = Me
        'ObjFrmHijo.ShowDialog()
        ObjFrmHijo.bolEnviar = True
        ObjFrmHijo.bolEsModificar = False
        If ObjFrmHijo.ShowDialog = Windows.Forms.DialogResult.OK Then


            With ObjFrmHijo.dgvProveedor.CurrentRow
                ''  bolBuscaAutomaticaProveedor = False
                Me.txtIdTransporte.Text = .Cells("IdProveedor").Value
                Me.txtTransporteRUC.Text = .Cells("DocumentoIdentidad").Value '' .Cells("Tipo").Value & " : " & .Cells("DocumentoIdentidad").Value
                Me.txtTransporteNombre.Text = .Cells("Nombre").Value
                ''   bolBuscaAutomaticaProveedor = True
                ''SeteaNodo(.Cells("IdPtaDependencia").Value)
            End With

        End If
    End Sub




    'Private Sub txtNumero_Enter(sender As System.Object, e As System.EventArgs) Handles txtNumero.Enter
    '    Me.BeginInvoke(DirectCast(Sub() txtNumero.SelectAll(), MethodInvoker))
    'End Sub

    Private Sub cmbUnidadMedida_Enter(sender As System.Object, e As System.EventArgs) Handles cmbUnidadMedida.Enter
        Me.cmbUnidadMedida.BackColor = Color.Aquamarine
    End Sub

    Private Sub chkActivarBloqueado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkActivarBloqueado.CheckedChanged

        Me.txtDescripcion.Enabled = chkActivarBloqueado.Checked
        Me.dtpFechaCompra.Enabled = chkActivarBloqueado.Checked
        Me.txtIGV.Enabled = chkActivarBloqueado.Checked
        Me.txtProveedorRUC.Enabled = chkActivarBloqueado.Checked
        Me.txtProveedorNombre.Enabled = chkActivarBloqueado.Checked

    End Sub

    Private Sub btnBuscarProveedorTransporte_Click_1(sender As System.Object, e As System.EventArgs) Handles btnBuscarProveedorTransporte.Click
        If Me.intIdCompra = 0 Then
            Notificar("Debe guardar el comprobante antes de asignarle un transporte")
            Exit Sub
        End If

        Dim ObjFrmHijo As New frmBuscadorOperacion
        'ObjFrmHijo.pFormularioPadrePTA = Me.Name
        'ObjFrmHijo.bolEsBusqueda = True
        'ObjFrmHijo.Owner = Me
        'ObjFrmHijo.ShowDialog()
        ObjFrmHijo.bolEnviar = True
        ObjFrmHijo.bolEsVenta = False
        ObjFrmHijo.ActiveControl = ObjFrmHijo.txtNumero
        ObjFrmHijo.intIdIdentificador = enmTipoInterno.Transporte   'Compra con IGV
        ObjFrmHijo.intIdTipoInterno = enmTipoInterno.Transporte
        If ObjFrmHijo.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim Transporte As New clsTransporteBUS
            Dim intIdTransporte As Integer = ObjFrmHijo.txtIdOperacion.Text

            Dim dtTransporte() As DataTable = Transporte.fncTransportePorIdentificador(intIdTransporte)

            If fncValidaDataTable(dtTransporte(0)) Then
                Me.txtSerieTransporte.Text = ObtenerValorCelda(dtTransporte(0).Rows(0), "Serie")
                Me.txtNumeroTransporte.Text = ObtenerValorCelda(dtTransporte(0).Rows(0), "Numero")
                Me.txtTransporteRUC.Text = ObtenerValorCelda(dtTransporte(0).Rows(0), "DocumentoIdentidad")
                Me.txtTransporteNombre.Text = ObtenerValorCelda(dtTransporte(0).Rows(0), "PRVnombre")
                Me.txtObservacionTransporte.Text = ObtenerValorCelda(dtTransporte(0).Rows(0), "Descripcion")
                Me.txtIdTransporte.Text = ObtenerValorCelda(dtTransporte(0).Rows(0), "IdTransporte")
                Me.txtMontoTransporte.Text = ObtenerValorCelda(dtTransporte(0).Rows(0), "MontoTransporte")
                Me.txtObservacion.Text = Me.txtObservacion.Text & " | Transporte: " & ObtenerValorCelda(dtTransporte(0).Rows(0), "Serie") & "-" & _
                    ObtenerValorCelda(dtTransporte(0).Rows(0), "Numero")
            End If

            If Me.intIdCompra > 0 Then
                Dim Compra As New clsCompraBUS
                Dim dtCompra As DataTable = Compra.fncConsultarBUS(intIdCompra)
                If fncValidaDataTable(dtCompra) Then
                    With Compra
                        .fncSetearBUS(dtCompra.Rows(0))
                        .IdTransporte = Me.txtIdTransporte.Text
                        .FechaModifica = FechaHoraServidor()
                        .Observacion = Me.txtObservacion.Text
                        .UsuarioModifica = My.Settings.Usuario
                        If .fncModificarBUS() > 0 Then
                            Notificar("Transporte actualizado")
                        End If
                    End With
                End If


            Else
                Notificar("Debe registrar primero esta comprar antes de asignar un transporte.")
            End If

            'LlenarDatosPorCompra(fncForzarDecimal(ObjFrmHijo.txtIdOperacion.Text))

            'With ObjFrmHijo.dgvProveedor.CurrentRow

            '    Me.intIdProveedor = .Cells("IdProveedor").Value
            '    Me.txtProveedorRUC.Text = .Cells("Tipo").Value & " : " & .Cells("DocumentoIdentidad").Value
            '    Me.txtProveedorNombre.Text = .Cells("Nombre").Value
            '    ''SeteaNodo(.Cells("IdPtaDependencia").Value)
            'End With

        End If
    End Sub

    Private Sub btnQuitarTransporte_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarTransporte.Click
        Dim Compra As New clsCompraBUS
        If intIdCompra > 0 Then

            ' Actualiza transporte observacion
            Dim strObservacion As String = txtObservacion.Text
            Dim intCharEspecial As Integer = strObservacion.IndexOf("|")
            strObservacion = strObservacion.Substring(0, intCharEspecial - 1)
            Me.txtObservacion.Text = strObservacion


            Dim dtCompra As DataTable = Compra.fncConsultarBUS(intIdCompra)

            If fncValidaDataTable(dtCompra) Then
                With Compra
                    .fncSetearBUS(dtCompra.Rows(0))
                    .FechaModifica = FechaHoraServidor()
                    .IdTransporte = DBNull.Value
                    .Observacion = strObservacion
                    If .fncModificarBUS() > 0 Then
                        Notificar("Transporte quitado de comprobante")
                    End If
                End With
            End If
        Else
            Notificar("No puede quitar el transporte de un comprobante no registrado. Se borrarán los datos de todas maneras.")
        End If


        ResetControlesTransporte()
    End Sub

    'Private Sub txtNumero_Enter(sender As System.Object, e As System.EventArgs) Handles txtNumero.Enter
    '    Dim strText As String = txtNumero.Text
    '    Dim intLastPositionChar As New Integer
    '    If strText.Length > 0 Then
    '        For i As Integer = 0 To strText.Length - 1
    '            If strText.Chars(i) = "0" Then
    '                intLastPositionChar = i
    '            End If
    '        Next
    '    End If

    '    txtNumero.Select(intLastPositionChar, 0)
    'End Sub
    'Const KEY_BACK = &H8
    'Private Sub txtNumero_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
    '    If e.KeyChar <> KEY_BACK Then
    '        Text1.SelLength = 1
    '    End If
    'End Sub

    Private Sub txtNumero_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        txtNumero.SelectionLength = 1
    End Sub

    Private Sub txtNumero_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumero.TextChanged
        txtNumero.SelectionLength = 1
    End Sub

    Private Sub txtTotalConIGV_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTotalConIGV.TextChanged
      If bolPivot = True
            Dim decPrecioUnidad As Decimal = fncRound2(fncForzarDecimal(Me.txtTotalConIGV.Text) / If(fncForzarDecimal(nudCantidad.Text) > 0, fncForzarDecimal(nudCantidad.Text), 1))
            Me.txtCostoConIGV.Text = FormatearNumero(decPrecioUnidad, 2)

            Dim decCostoUnitarioSinIGV As Decimal = fncRound4((decPrecioUnidad / (1 + decIGVCompra)))
            Dim decCostoUnitarioConIGV As Decimal = fncRound4(decPrecioUnidad)
            Dim decCostoUnitarioIGV As Decimal = fncRound4(decCostoUnitarioConIGV - decCostoUnitarioSinIGV)


            Dim decCostoTotalSinIGV As Decimal = fncRound2(decCostoUnitarioSinIGV * fncForzarDecimal(nudCantidad.Text))
            Dim decCostoTotalConIGV As Decimal = fncForzarDecimal(Me.txtTotalConIGV.Text)
            Dim decCostoTotalIGV As Decimal = fncRound2(decCostoTotalConIGV - decCostoTotalSinIGV)

            Me.txtIGVCosto.Text = FormatearNumero(decCostoUnitarioIGV, 4)
            ''  Me.txtCostoConIGV.Text = FormatearNumero(decCostoUnitarioConIGV, 4)

            Me.txtTotalSinIGV.Text = FormatearNumero(decCostoTotalSinIGV, 2)
            Me.txtIGVTotal.Text = FormatearNumero(decCostoTotalIGV, 2)
            ''  Me.txtTotalConIGV.Text = FormatearNumero(decCostoTotalConIGV, 2)



        End If
    End Sub

    Private Sub txtTotalConIGV_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtTotalConIGV.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConfirmarProducto.PerformClick()
        ElseIf e.KeyCode = Keys.Up Then
            Me.ActiveControl = Me.txtCostoConIGV
            txtCostoConIGV.Select(0, txtCostoConIGV.Text.Length)
        End If
    End Sub

    Private Sub txtCostoConIGV_FontChanged(sender As System.Object, e As System.EventArgs) Handles txtCostoConIGV.FontChanged

    End Sub

    Private Sub txtTotalConIGV_Enter(sender As System.Object, e As System.EventArgs) Handles txtTotalConIGV.Enter
        bolPivot = True
    End Sub

    Private Sub grpCabecera_Enter(sender As System.Object, e As System.EventArgs) Handles grpCabecera.Enter

    End Sub
End Class