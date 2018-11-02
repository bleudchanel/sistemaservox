Imports SistemaServox2015BUS
Imports pryUtil.clsUtil
Imports System.Net
Imports System.Media


Public Class frmMantenimientoTransporte


    Private intIdTransporte As New Integer
    Private intIdProveedor As New Integer
    Private decIGVCompra As New Decimal
    Private bolEsCompraNueva As New Boolean
    Private bolPivot As Boolean = True
    Private bolTextChange As Boolean = True
    Private bolBuscaAutomaticaProveedor As Boolean = True
    Private strRUCPROVEEDORBusquedaActual As String

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmMantenimientoCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        Me.txtProveedorNombre.Text = String.Empty
        bolBuscaAutomaticaProveedor = False
        Me.txtProveedorRUC.Text = String.Empty
        bolBuscaAutomaticaProveedor = True
        Me.txtDescripcion.Text = String.Empty

        Me.dtpFechaCompra.Value = If(My.Settings.UltimaFechaCompra.Year <= 2000, FechaHoraServidor.Date, My.Settings.UltimaFechaCompra)
        Me.txtIGV.Text = FormatearNumero(decIGVCompra, 2)
        Me.bolBuscaAutomaticaProveedor = True
        Me.txtMontoTransporte.Text = "0.00"

    End Sub

    Sub Controles_En_Load()

        Me.intIdTransporte = New Integer

        Me.intIdProveedor = New Integer
        Me.bolEsCompraNueva = True
        Me.strRUCPROVEEDORBusquedaActual = String.Empty
        Dim Periodo As New clsPeriodo
        SetComboBox(cmbAnioPeriodo, Periodo.fncListaPeriodoPorOperacionBUS(1), "Anio", "Anio")
        ''  ProcComboBoxAAnio(cmbAnioPeriodo)

        Dim TipoComprobante As New clsTipoComprobanteBUS
        SetComboBox(cmbTipoComprobante, TipoComprobante.fncTipoComprobanteBUS(enmEstado.Activo), "Abreviacion", "IdTipoComprobante")

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

        Me.grpNavegar.Enabled = True

        Me.chkActivarBloqueado.Checked = False
        Me.chkActivarBloqueado.Enabled = False


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

    End Sub

    Sub Controles_En_Producto()

        Me.tbcCompras.Enabled = False

    End Sub

    Sub Controles_En_NuevoProducto()
        bolTextChange = False
        bolTextChange = True
    End Sub

    Sub Controles_En_NuevoProductoRegistrar()
        bolTextChange = False
        bolTextChange = True
    End Sub

    Sub Controles_En_ProductoSeleccionado()

    End Sub

    Sub Controles_En_CancelarProducto()
        Me.tbcCompras.Enabled = True
    End Sub

    Sub Controles_En_NuevaOperacion()

        Me.bolEsCompraNueva = True
        Me.intIdTransporte = New Integer

        Me.intIdProveedor = New Integer

        Me.grpNavegar.Enabled = False
        '' Me.cmbTipoComprobante.Enabled = True
        Me.txtSerie.Enabled = True
        Me.txtNumero.Enabled = True
        Me.btnBuscarFactura.Enabled = False
        Me.btnBuscarProveedor.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.dtpFechaCompra.Enabled = True
        Me.txtIGV.Enabled = True
        Me.txtMontoTransporte.Enabled = True
        Me.chkActivarBloqueado.Enabled = False

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

        'Me.intIdProveedor = New Integer

        Me.grpNavegar.Enabled = False
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

        Me.btnNuevo.Enabled = False
        Me.btnModificar.Enabled = False
        Me.btnAnular.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True



    End Sub
#End Region

    Sub LlenarDatosPorCompra(ByVal intIdTransporte As Integer)
        bolBuscaAutomaticaProveedor = False
        Dim Transporte As New clsTransporteBUS

        '' Dim DetalleCompra As New clsDetalleCompraBUS
        Dim dtBase As DataTable() = Transporte.fncTransportePorIdentificador(intIdTransporte)
        If fncValidaDataTable(dtBase(0)) Then
            Me.cmbAnioPeriodo.SelectedValue = CDate(ObtenerValorCelda(dtBase(0).Rows(0), "FechaTransporte")).Year
            Me.intIdTransporte = ObtenerValorCelda(dtBase(0).Rows(0), "IdTransporte")
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
            Me.dtpFechaCompra.Value = CDate(ObtenerValorCelda(dtBase(0).Rows(0), "FechaTransporte")).ToString("dd/MM/yyyy")
            Me.txtMontoTransporte.Text = ObtenerValorCelda(dtBase(0).Rows(0), "MontoTransporte")

            ''  If fncValidaDataTable(dtBase(1)) Then
            LlenarComprobantesPorTransporte(intIdTransporte)
            ''End If
        End If
        bolBuscaAutomaticaProveedor = True
    End Sub

    Sub LlenarComprobantesPorTransporte(ByVal intIdTransporte As Integer)
        Me.dgvComprobantesTransporte.Rows.Clear()
        Dim Transporte As New clsTransporteBUS
        Dim dtTransporte As DataTable = Transporte.fncComprobantesPorTransporteBUS(intIdTransporte)
        If fncValidaDataTable(dtTransporte) Then
            For Each row In dtTransporte.Rows
                Me.dgvComprobantesTransporte.Rows.Add()
                With Me.dgvComprobantesTransporte.Rows(Me.dgvComprobantesTransporte.Rows.Count - 1)
                    .Cells("Serie").Value = ObtenerValorCelda(row, "Serie")
                    .Cells("Numero").Value = ObtenerValorCelda(row, "Numero")
                    .Cells("Fecha").Value = CDate(ObtenerValorCelda(row, "FechaCompra")).ToString("dd/MM/yyyy")
                    .Cells("Observacion").Value = ObtenerValorCelda(row, "Observacion")
                    .Cells("Tipo").Value = ObtenerValorCelda(row, "TipoInterno")
                End With
            Next
        End If
    End Sub

    Sub LlenarDatosPorOrdenCompra(ByVal intIdTransporteActual As Integer, ByVal intOrden As Integer, ByVal intAnioPeriodo As Integer)
        bolBuscaAutomaticaProveedor = False
        Dim Transporte As New clsTransporteBUS

        '' Dim DetalleCompra As New clsDetalleCompraBUS
        Dim dtBase As DataTable() = Transporte.fncTransportesPorOrden(intAnioPeriodo, , "1", intOrden, intIdTransporteActual)
        If fncValidaDataTable(dtBase(0)) Then

            Me.intIdTransporte = ObtenerValorCelda(dtBase(0).Rows(0), "IdTransporte")
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
            Me.txtMontoTransporte.Text = ObtenerValorCelda(dtBase(0).Rows(0), "MontoTransporte")

            Me.dtpFechaCompra.Value = CDate(ObtenerValorCelda(dtBase(0).Rows(0), "FechaTransporte")).ToString("dd/MM/yyyy")
            ''  If fncValidaDataTable(dtBase(1)) Then
            LlenarComprobantesPorTransporte(intIdTransporte)
            ''End If
        End If
        bolBuscaAutomaticaProveedor = True
    End Sub




    Private Sub txtProveedorRUC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProveedorRUC.TextChanged
        If bolBuscaAutomaticaProveedor = True Then
            Dim Compra As New clsCompraBUS
            Dim dtCompra As DataTable = Compra.fncBuscarTop1ProveedorBUS(Me.txtProveedorRUC.Text, "Transporte")
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
        LlenarDatosPorOrdenCompra(intIdTransporte, enmOrden.Primero, cmbAnioPeriodo.SelectedValue)
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        LlenarDatosPorOrdenCompra(intIdTransporte, enmOrden.Atras, cmbAnioPeriodo.SelectedValue)
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        LlenarDatosPorOrdenCompra(intIdTransporte, enmOrden.Siguiente, cmbAnioPeriodo.SelectedValue)
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        LlenarDatosPorOrdenCompra(intIdTransporte, enmOrden.Ultimo, cmbAnioPeriodo.SelectedValue)
    End Sub



    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Controles_En_NuevaOperacion()
        Me.ActiveControl = Me.txtSerie
        Me.txtSerie.Select(0, Me.txtSerie.Text.Length)
    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If intIdTransporte > 0 Then
            Controles_En_ModificarOperacion()
            Me.ActiveControl = Me.txtProveedorRUC
            Me.txtProveedorRUC.Select(0, txtProveedorRUC.Text.Length)
        Else
            Notificar("Debe seleccionar una operación a Modificar.")
        End If
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click


        If MsgBox("¿Está seguro de que desea anular este comprobante?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            If intIdTransporte > 0 Then
                Dim Transporte As New clsTransporteBUS

                Dim dtCompra As DataTable = Transporte.fncConsultarBUS(Me.intIdTransporte)
                If fncValidaDataTable(dtCompra) Then
                    Transporte.fncSetearBUS(dtCompra.Rows(0))
                    With Transporte
                        .Estado = enmEstado.Inactivo
                        .FechaModifica = FechaHoraServidor()
                        .UsuarioModifica = My.Settings.Usuario
                        If .fncModificarBUS() > 0 Then

                            Notificar("Comprobante Anulado")
                            Dim intIdCompraProvisional As Integer = intIdTransporte
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

            Dim TransporteValida As New clsTransporteBUS
            Dim dtCompraValida As DataTable = TransporteValida.fncValidaNumeroTransporteBUS(Me.txtSerie.Text, Me.txtNumero.Text, Me.intIdProveedor, Me.cmbTipoComprobante.SelectedValue)
            If fncValidaDataTable(dtCompraValida) Then
                ErrorCompras.SetError(Me.txtNumero, "Este número de comprobante ya se ha registrado")
                Exit Sub
            End If

            Dim Transporte As New clsTransporteBUS(0, cmbTipoComprobante.SelectedValue _
                                                   , Me.txtSerie.Text, Me.txtNumero.Text _
                                           , Me.txtDescripcion.Text _
                                           , String.Empty _
                                           , Me.intIdProveedor _
                                           , Me.dtpFechaCompra.Value _
                                           , Me.dtpFechaCompra.Value _
                                           , fncForzarDecimal(Me.txtIGV.Text) _
                                           , FechaHoraServidor.Date _
                                           , My.Settings.Usuario _
                                           , fncForzarDecimal(Me.txtMontoTransporte.Text))

            If Transporte.fncRegistrarBUS() > 0 Then
                intIdTransporte = Transporte.IdTransporte


                ' Registra Detalle
                If intIdTransporte > 0 Then

                    My.Settings.UltimoTipoUsadoCompra = Me.cmbTipoComprobante.SelectedValue
                    My.Settings.UltimoSerieCompraFactura = Me.txtSerie.Text
                    My.Settings.UltimaFechaCompra = Me.dtpFechaCompra.Value
                    Notificar("Registrado con éxito.")
                    Dim intIdCompraProvisional As Integer = Me.intIdTransporte
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
            If intIdTransporte > 0 And intIdProveedor > 0 Then
                Dim Transporte As New clsTransporteBUS

                Dim dtCompraValida As DataTable = Transporte.fncValidaTransporteExistenteBUS(Me.intIdTransporte, Me.cmbTipoComprobante.SelectedValue, Me.txtSerie.Text, Me.txtNumero.Text, Me.intIdProveedor)
                If fncValidaDataTable(dtCompraValida) Then
                    ErrorCompras.SetError(txtNumero, "No puede usar esta combinación de Tipo de Comprobante, Serie, Numero y Proveedor; porque ya se encuentra en uso.")
                    Exit Sub
                Else
                    ErrorCompras.SetError(txtNumero, Nothing)
                End If

                Dim dtTransporte As DataTable = Transporte.fncConsultarBUS(Me.intIdTransporte)
                If fncValidaDataTable(dtTransporte) Then
                    Transporte.fncSetearBUS(dtTransporte.Rows(0))
                    With Transporte
                        .Serie = txtSerie.Text
                        .Numero = txtNumero.Text
                        .IdTipoComprobante = Me.cmbTipoComprobante.SelectedValue
                        .IdProveedor = intIdProveedor
                        .IGV = fncForzarDecimal(Me.txtIGV.Text)
                        .FechaTransporte = Me.dtpFechaCompra.Value
                        .FechaModifica = FechaHoraServidor()
                        .UsuarioModifica = My.Settings.Usuario
                        .Descripcion = Me.txtDescripcion.Text
                        .Observacion = String.Empty
                        .MontoTransporte = fncForzarDecimal(Me.txtMontoTransporte.Text)
                    End With


                    ' Detalle
                    If Transporte.fncModificarBUS() > 0 Then


                        Notificar("Modificado con éxito")
                        Dim intIdCompraProvisional As Integer = Me.intIdTransporte
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



    Private Sub btnBuscarFactura_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarFactura.Click
        Dim ObjFrmHijo As New frmBuscadorOperacion
        'ObjFrmHijo.pFormularioPadrePTA = Me.Name
        'ObjFrmHijo.bolEsBusqueda = True
        'ObjFrmHijo.Owner = Me
        'ObjFrmHijo.ShowDialog()
        ObjFrmHijo.bolEnviar = True
        ObjFrmHijo.bolEsVenta = False
        ObjFrmHijo.ActiveControl = ObjFrmHijo.txtNumero
        ObjFrmHijo.intIdIdentificador = enmTipoInterno.Transporte  'Compra con IGV
        ObjFrmHijo.intIdTipoInterno = enmTipoInterno.Transporte
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


    Private Sub txtProveedorRUC_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtProveedorRUC.KeyDown
        If e.KeyCode = Keys.Enter Then
            If bolBuscaAutomaticaProveedor = True Then
                If intIdProveedor <> 0 Then

                    bolBuscaAutomaticaProveedor = False
                    Me.txtProveedorRUC.Text = Me.strRUCPROVEEDORBusquedaActual
                    bolBuscaAutomaticaProveedor = True
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



    Private Sub txtSerie_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSerie.KeyDown
        If e.KeyCode = Keys.Enter Then


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

    Private Sub dgvDetalleCompra_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        'If Me.dgvDetalleCompra.Rows.Count > 0 AndAlso Me.dgvDetalleCompra.CurrentRow IsNot Nothing Then
        '    Me.btnQuitarDetalle.PerformClick()
        'End If
    End Sub

    Private Sub btnAgregarDetalle_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Down Then
            If btnGuardar.Enabled = True Then
                Me.ActiveControl = Me.btnGuardar
            Else
                Me.ActiveControl = Me.btnCancelar
            End If
        End If
    End Sub


    Private Sub txtProveedorNombre_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtProveedorNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.dtpFechaCompra
        End If
    End Sub

    Private Sub dtpFechaCompra_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpFechaCompra.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.txtDescripcion

        End If
    End Sub

    Private Sub txtCosto_Enter_1(sender As System.Object, e As System.EventArgs)
        bolPivot = True
    End Sub

    Private Sub txtCostoConIGV_Enter_1(sender As System.Object, e As System.EventArgs)
        bolPivot = False
    End Sub





    'Private Sub txtNumero_Enter(sender As System.Object, e As System.EventArgs) Handles txtNumero.Enter
    '    Me.BeginInvoke(DirectCast(Sub() txtNumero.SelectAll(), MethodInvoker))
    'End Sub


    Private Sub chkActivarBloqueado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkActivarBloqueado.CheckedChanged

        Me.txtDescripcion.Enabled = chkActivarBloqueado.Checked
        Me.dtpFechaCompra.Enabled = chkActivarBloqueado.Checked
        Me.txtIGV.Enabled = chkActivarBloqueado.Checked
        Me.txtProveedorRUC.Enabled = chkActivarBloqueado.Checked
        Me.txtProveedorNombre.Enabled = chkActivarBloqueado.Checked

    End Sub

    Private Sub txtDescripcion_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.txtMontoTransporte
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        ErrorCompras.Clear()
        Controles_En_Load()
    End Sub

    Private Sub txtMontoTransporte_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtMontoTransporte.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.btnGuardar
        End If

    End Sub
End Class