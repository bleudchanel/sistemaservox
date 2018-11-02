Imports SistemaServox2015BUS
Imports pryUtil.clsUtil
Imports System.Net

Public Class frmMantenimientoProducto


    Public bolEsBusqueda As New Boolean
    Public bolEsModificar As New Boolean
    Public bolEsBusquedaTextual As New Boolean
    Private bolPivot As New Boolean
    Private bolPivotCoste As New Boolean

    Private Sub frmMantenimientoProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ContenidoEnLoad()
    End Sub

    Sub ContenidoEnLoad()
        LlenaListaProductos(If(chkEstado.Checked = True, -1, enmEstado.Activo))
        Me.tbcProducto.TabPages.Remove(tbpListar)
        Me.tbcProducto.TabPages.Remove(tbpNuevo)
        Me.tbcProducto.TabPages.Remove(tbpDatosExtra)
        Me.tbcProducto.TabPages.Insert(0, tbpListar)
        '' fncSetDataTableInDGV(dtCliente, Me.dgvCliente)
        Dim UnidadMedida As New clsUnidadMedidaBUS
        SetComboBox(cmbUnidadMedida, UnidadMedida.fncListarUnidadMedidaBUS(enmEstado.Activo), "Abreviacion", "IdMedida")
        lblIGVActual.Text = (My.Settings.IGV * 100) & "%"
        Me.ActiveControl = Me.txtBusqueda
        Me.chkMostrarControlesAvanzados.Checked = My.Settings.MostrarControlesAvanzados

        Me.btnNuevo.Visible = Me.chkMostrarControlesAvanzados.Checked
        Me.btnDesactivar.Visible = Me.chkMostrarControlesAvanzados.Checked
        Me.btnEliminar.Visible = Me.chkMostrarControlesAvanzados.Checked

    End Sub

    Sub LlenaListaProductos(ByVal intEstado As Integer, Optional ByVal strDescripcion As String = "", Optional ByVal strCodigo As String = "")
        dgvProducto.Rows.Clear()
        Dim Producto As New clsProductoBUS
        Dim dtProducto = Producto.fncListarProductoPorCamposBUS("", "", intEstado, , strDescripcion)
        ''  Dim dtProductoDescripcion = Producto.fncListarProductoPorCamposBUS("", strDescripcion, intEstado, )
        If fncValidaDataTable(dtProducto) Then ''Or fncValidaDataTable(dtProductoDescripcion) Then
            '' Dim dtBase As DataTable = If(fncValidaDataTable(dtProductoCodigo) = True, dtProductoCodigo, dtProductoDescripcion)
            For Each row In dtProducto.Rows
                dgvProducto.Rows.Add()
                With Me.dgvProducto.Rows(dgvProducto.Rows.Count - 1)
                    .Cells("IdProducto").Value = ObtenerValorCelda(row, "IdProducto")
                    .Cells("NombreProducto").Value = ObtenerValorCelda(row, "PROnombre")
                    .Cells("DescripcionProducto").Value = ObtenerValorCelda(row, "PROdescripcion").ToString.ToUpper
                    .Cells("UnidadMedida").Value = ObtenerValorCelda(row, "Medida")
                    .Cells("StockMinimo").Value = fncForzarInteger(ObtenerValorCelda(row, "PROstockmin"))
                    .Cells("DocumentoProveedor").Value = ObtenerValorCelda(row, "TipoDocumentoIdentidad") & " : " & ObtenerValorCelda(row, "DocumentoIdentidad")
                    .Cells("DescripcionProveedor").Value = ObtenerValorCelda(row, "ProveedorPrincipal")
                    Dim strCodigoMonedaCompra As String = ObtenerValorCelda(row, "CodigoMonedaCompra")
                    .Cells("CosteSinIGV").Value = If(strCodigoMonedaCompra = "02", "$", "S/.") & FormatearNumero(ObtenerValorCelda(row, "CosteSinIGV"), 4)
                    .Cells("IGVCoste").Value = If(strCodigoMonedaCompra = "02", "$", "S/.") & Format(ObtenerValorCelda(row, "IGVCoste") * 100, "0.00")
                    .Cells("CosteConIGV").Value = If(strCodigoMonedaCompra = "02", "$", "S/.") & FormatearNumero(ObtenerValorCelda(row, "CosteConIGV"), 4)
                    Dim strCodigoMonedaVenta As String = ObtenerValorCelda(row, "CodigoMonedaVenta")
                    .Cells("PrecioNetoSinIGV").Value = If(strCodigoMonedaVenta = "02", "$", "S/.") & FormatearNumero(ObtenerValorCelda(row, "PrecioSinIGV"), 2)
                    .Cells("IGVActual").Value = If(strCodigoMonedaVenta = "02", "$", "S/.") & Format(CDec(My.Settings.IGV), "0.00")
                    .Cells("PrecioConIGV").Value = If(strCodigoMonedaVenta = "02", "$", "S/.") & FormatearNumero(ObtenerValorCelda(row, "PrecioNetoConIGV"), 2) ''Format(fncRound2(ObtenerValorCelda(row, "PrecioSinIGV") * My.Settings.IGV) + ObtenerValorCelda(row, "PrecioSinIGV"), "0.00")

                    .Cells("Estado").Value = If(ObtenerValorCelda(row, "Estado") = enmEstado.Activo, My.Resources.accept, My.Resources.cancel)
                    .Cells("StockActual").Value = fncForzarDecimal(FormatearNumero(ObtenerValorCelda(row, "StockActual"), 1))
                    .Cells("EstadoBase").Value = ObtenerValorCelda(row, "Estado")
                End With
            Next
        End If
    End Sub


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged

        LlenaListaProductos(If(chkEstado.Checked = True, -1, enmEstado.Activo), Me.txtBusqueda.Text, Me.txtBusqueda.Text)

        ''  BuscarEnDataGrid(dgvProducto, txtBusqueda.Text, {"NombreProducto", "DescripcionProducto"}, "NombreProducto")
    End Sub

    Private Sub dgvProducto_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProducto.CellDoubleClick

        '' Modificar()
        'If bolEsBusqueda = True Then

        '    Me.btnSeleccionar.PerformClick()
        'Else
        '    Me.btnModificar.PerformClick()

        'End If
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.bolEsModificar = False

        Me.tbcProducto.TabPages.Remove(tbpListar)
        Me.tbcProducto.TabPages.Remove(tbpNuevo)
        Me.tbcProducto.TabPages.Insert(0, tbpNuevo)
        Controles_En_Nuevo()
        Me.ActiveControl = Me.txtCodigoProducto
    End Sub

#Region "Controles Form"
    Sub Controles_En_Nuevo()
        Me.txtIdProducto.Text = ""
        Me.txtCodigoProducto.Text = ""
        Me.txtDescripcionProducto.Text = ""
        Me.txtIdProveedor.Text = ""
        Me.txtRucProveedor.Text = ""
        Me.txtDescripcionProveedor.Text = ""
        Me.dgvHistorial.Rows.Clear()
        Me.txtPrecioVenta.Text = 0.0
        Me.txtPrecioCosteConIGV.Text = 0.0
    End Sub


    Sub Llenar_Listar_ProveedoresSecundarios(ByVal intIdProducto As Integer)
        Me.dgvProveedores.Rows.Clear()
        Dim dtProviders As New DataTable
        Dim ProveedoresSecundario As New clsProveedorSecundarioBUS

        dtProviders = ProveedoresSecundario.fncListarProveedoresSecundariosBUS(intIdProducto)
        If fncValidaDataTable(dtProviders) Then
            fncSetDataTableInDGV(dtProviders, dgvProveedores)
        End If
    End Sub

    Dim dtProductoHistorial As DataTable
    Sub Llenar_Datos_Producto(ByVal intIdProducto As Integer)
        Me.dgvHistorial.Rows.Clear()
        dtProductoHistorial = New DataTable
        Dim Producto As New clsProductoBUS

        Dim dtProducto As DataTable = Producto.fncListarProductoPorCamposBUS(, , 1, intIdProducto)
        If fncValidaDataTable(dtProducto) Then
            Me.txtIdProducto.Text = ObtenerValorCelda(dtProducto.Rows(0), "IdProducto")
            Me.txtCodigoProducto.Text = ObtenerValorCelda(dtProducto.Rows(0), "PROnombre")
            Me.txtDescripcionProducto.Text = ObtenerValorCelda(dtProducto.Rows(0), "PROdescripcion")
            Me.cmbUnidadMedida.SelectedValue = ObtenerValorCelda(dtProducto.Rows(0), "IdMedida")
            Me.nudStockMinimo.Value = ObtenerValorCelda(dtProducto.Rows(0), "PROstockmin")
            Me.txtIdProveedor.Text = ObtenerValorCelda(dtProducto.Rows(0), "IdProveedor")
            Me.txtRucProveedor.Text = ObtenerValorCelda(dtProducto.Rows(0), "DocumentoIdentidad")
            Me.txtDescripcionProveedor.Text = ObtenerValorCelda(dtProducto.Rows(0), "ProveedorPrincipal")
            ''Me.txtPrecioCosteSinIGV.Text = FormatearNumero((ObtenerValorCelda(dtProducto.Rows(0), "CosteSinIGV")), 6)
            bolPivotCoste = False
            Me.txtPrecioCosteConIGV.Text = FormatearNumero((ObtenerValorCelda(dtProducto.Rows(0), "CosteConIGV")), 8)
            Me.txtIdEmpleado.Text = ObtenerValorCelda(dtProducto.Rows(0), "IdEmpleadoComision")
            Me.txtNombreEmpleado.Text = ObtenerValorCelda(dtProducto.Rows(0), "Empleado")
            Me.txtMontoComision.Text = ObtenerValorCelda(dtProducto.Rows(0), "MontoComision")
            ''Me.txtPrecioVenta.Text = fncRound2(ObtenerValorCelda(dtProducto.Rows(0), "PrecioSinIGV"))
            bolPivot = False
            Me.txtPrecioVentaConIGV.Text = FormatearNumero(ObtenerValorCelda(dtProducto.Rows(0), "PrecioNetoConIGV"), 2)
            Me.lblUltimaModificacion.Text = "Modificado: " & ObtenerValorCelda(dtProducto.Rows(0), "FechaModifica")

            Dim strCodigoMonedaCompra As String = ObtenerValorCelda(dtProducto.Rows(0), "CodigoMonedaCompra")
            If strCodigoMonedaCompra.Equals("01") Then
                rbSolesCompra.Checked = True
            ElseIf strCodigoMonedaCompra.Equals("02") Then
                rbDolaresCompra.Checked = True
            End If

            Dim strCodigoMonedaVenta As String = ObtenerValorCelda(dtProducto.Rows(0), "CodigoMonedaVenta")
            If strCodigoMonedaVenta.Equals("01") Then
                rbSolesVenta.Checked = True
            ElseIf strCodigoMonedaVenta.Equals("02") Then
                rbDolaresVenta.Checked = True
            End If

        End If


        dtProductoHistorial = Producto.fncConstruyeResumenPorProducto(intIdProducto)
        If fncValidaDataTable(dtProductoHistorial) Then
            fncSetDataTableInDGV(dtProductoHistorial, dgvHistorial)

            'For Each row In dtProductoHistorial.Rows
            '    Me.dgvHistorial.Rows.Add()
            '    With Me.dgvHistorial.Rows(Me.dgvHistorial.Rows.Count - 1)
            '        .Cells("").Value = ObtenerValorCelda(row, "")
            '        .Cells("").Value = ObtenerValorCelda(row, "")
            '        .Cells("").Value = ObtenerValorCelda(row, "")
            '        .Cells("").Value = ObtenerValorCelda(row, "")
            '        .Cells("").Value = ObtenerValorCelda(row, "")
            '    End With
            'Next
        Else
            Me.dgvHistorial.Rows.Clear()
        End If

    End Sub
#End Region

    'Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
    '    bolEsModificar = True
    '    If dgvProducto.CurrentRow IsNot Nothing Then
    '        Dim intIdProducto As Integer = Me.dgvProducto.CurrentRow.Cells("IdProducto").Value
    '        Me.tbcProducto.TabPages.Remove(tbpListar)
    '        Me.tbcProducto.TabPages.Remove(tbpNuevo)
    '        Me.tbcProducto.TabPages.Insert(0, tbpNuevo)
    '        Llenar_Datos_Producto(intIdProducto)
    '        Me.ActiveControl = Me.txtCodigoProducto
    '        Me.txtCodigoProducto.Select(0, Me.txtCodigoProducto.Text.Length)
    '    End If
    'End Sub

    Sub Modificar()
        bolEsModificar = True
        If dgvProducto.CurrentRow IsNot Nothing Then
            Dim intIdProducto As Integer = Me.dgvProducto.CurrentRow.Cells("IdProducto").Value
            Me.tbcProducto.TabPages.Remove(tbpListar)
            Me.tbcProducto.TabPages.Remove(tbpNuevo)
            Me.tbcProducto.TabPages.Remove(tbpDatosExtra)
            Me.tbcProducto.TabPages.Insert(0, tbpNuevo)
            Me.tbcProducto.TabPages.Insert(1, tbpDatosExtra)
            Me.chkUnlock.Checked = False
            txtPrecioCosteConIGV.Enabled = False
            txtPrecioCosteSinIGV.Enabled = False

            Llenar_Datos_Producto(intIdProducto)
            Llenar_Listar_ProveedoresSecundarios(intIdProducto)
            Me.ActiveControl = Me.txtCodigoProducto
            Me.txtCodigoProducto.Select(0, Me.txtCodigoProducto.Text.Length)
        End If
    End Sub

    Private Sub txtTitulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTitulo.TextChanged

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        ContenidoEnLoad()
    End Sub

    Private Sub btnKardex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKardex.Click
        If Me.dgvProducto.CurrentRow IsNot Nothing AndAlso Me.dgvProducto.Rows.Count > 0 Then
            Dim frmReporte As New frmRepositorioReporte
            Dim Producto As New clsProductoBUS
            'Dim strTitulo As String = Me.dgvPlanillasPeriodo.CurrentRow.Cells("lstIdPlanilla").Value & " : " & Me.dgvPlanillasPeriodo.CurrentRow.Cells("lstDescripcionPlanilla").Value
            frmReporte.ConstruirReporteKardex(Producto.fncConstruirKardexValorado(Me.dgvProducto.CurrentRow.Cells("NombreProducto").Value.ToString), "")

            frmReporte.Show()
        Else
            Notificar("Seleccione Producto")
        End If

    End Sub

    Private Sub btnDesactivar_Click(sender As System.Object, e As System.EventArgs) Handles btnDesactivar.Click
        If Me.dgvProducto.CurrentRow IsNot Nothing AndAlso Me.dgvProducto.Rows.Count > 0 Then
            If btnDesactivar.Text = "Descontinuar" Then
                If MsgBox("¿Realmente desea descontinuar este producto?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    Dim Producto As New clsProductoBUS
                    Dim dtProducto As DataTable = Producto.fncConsultarBUS(Me.dgvProducto.CurrentRow.Cells("IdProducto").Value)
                    If fncValidaDataTable(dtProducto) Then
                        Producto.fncSetearBUS(dtProducto.Rows(0))
                        Producto.Estado = enmEstado.Inactivo
                        Producto.FechaModifica = FechaHoraServidor()
                        Producto.UsuarioModifica = My.Settings.Usuario
                        If Producto.fncModificarBUS() > 0 Then
                            Notificar("Completado", "SERVOX")
                            ContenidoEnLoad()
                        End If
                    End If
                End If
            Else
                If MsgBox("¿Realmente desea reactivar este producto?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    Dim Producto As New clsProductoBUS
                    Dim dtProducto As DataTable = Producto.fncConsultarBUS(Me.dgvProducto.CurrentRow.Cells("IdProducto").Value)
                    If fncValidaDataTable(dtProducto) Then
                        Producto.fncSetearBUS(dtProducto.Rows(0))
                        Producto.Estado = enmEstado.Activo
                        Producto.FechaModifica = FechaHoraServidor()
                        Producto.UsuarioModifica = My.Settings.Usuario
                        If Producto.fncModificarBUS() > 0 Then
                            Notificar("Completado", "SERVOX")
                            ContenidoEnLoad()
                        End If
                    End If
                End If
            End If

        End If
    End Sub

    'Private Sub txtBusqueda_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBusqueda.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        LlenaListaProductos(enmEstado.Activo, Me.txtBusqueda.Text)
    '    End If
    'End Sub

    Private Sub txtPrecioVenta_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPrecioVenta.TextChanged
        If bolPivot = True Then
            Me.txtPrecioVentaConIGV.Text = fncRound2(fncForzarDecimal(Me.txtPrecioVenta.Text) * (1 + My.Settings.IGV))
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

        If bolEsModificar = True Then
            Dim Producto As New clsProductoBUS

            If Producto.fncValidaCodigoExistente(Me.txtCodigoProducto.Text, Me.txtIdProducto.Text) = True Then
                Notificar("Este código de producto ya está en uso. Ingrese uno distinto.")
                Exit Sub
            End If


            Dim dtProducto As DataTable = Producto.fncConsultarBUS(Me.txtIdProducto.Text)
            If fncValidaDataTable(dtProducto) Then
                Producto.fncSetearBUS(dtProducto.Rows(0))
                Producto.PROnombre = Me.txtCodigoProducto.Text
                Producto.PROdescripcion = Me.txtDescripcionProducto.Text
                Producto.IdMedida = Me.cmbUnidadMedida.SelectedValue
                Producto.PROstockmin = Me.nudStockMinimo.Value
                Producto.PrecioCosteConIGV = fncForzarDecimal(Me.txtPrecioCosteConIGV.Text)
                Producto.PrecioCoste = fncForzarDecimal(Me.txtPrecioCosteSinIGV.Text)
                Producto.PrecioNetoSinIGV = fncForzarDecimal(Me.txtPrecioVenta.Text)
                Producto.IdProveedor = If(fncForzarDecimal(Me.txtIdProveedor.Text) = 0, DBNull.Value, Me.txtIdProveedor.Text)
                Producto.PrecioNetoConIGV = fncForzarDecimal(Me.txtPrecioVentaConIGV.Text)
                Producto.UsuarioModifica = My.Settings.Usuario
                Producto.FechaModifica = FechaHoraServidor()
                Producto.CodigoMonedaCompra = If(rbDolaresCompra.Checked = True, "02", "01")
                Producto.CodigoMonedaVenta = If(rbDolaresVenta.Checked = True, "02", "01")
                If Producto.fncModificarBUS() > 0 Then
                    Notificar("Modificado!")
                End If
            Else
                Notificar("Imposible guardar cambios")
            End If
        Else
            Dim ProductoBase As New clsProductoBUS
            If ProductoBase.fncValidaCodigoExistente(Me.txtCodigoProducto.Text) = True Then
                Notificar("Este código de producto ya está en uso. Ingrese uno distinto.")
                Exit Sub
            End If


            Dim Producto As New clsProductoBUS(Me.txtCodigoProducto.Text _
                                               , Me.cmbUnidadMedida.Text _
                                               , Me.txtDescripcionProducto.Text _
                                               , 0 _
                                               , Me.nudStockMinimo.Value _
                                               , 0 _
                                               , 0 _
                                               , FechaHoraServidor _
                                               , Me.cmbUnidadMedida.SelectedValue _
                                               , Me.txtIdProveedor.Text _
                                               , fncForzarDecimal(Me.txtPrecioCosteSinIGV.Text) _
                                               , 0 _
                                               , fncForzarDecimal(Me.txtPrecioCosteConIGV.Text) _
                                               , fncForzarDecimal(Me.txtPrecioVenta.Text) _
                                               , My.Settings.Usuario _
                                               , My.Settings.IGV _
                                               , fncForzarDecimal(Me.txtPrecioVentaConIGV.Text) _
                                               , 0 _
                                               , 0 _
                                               , If(rbDolaresCompra.Checked = True, "02", "01") _
                                               , If(rbDolaresVenta.Checked = True, "02", "01"))
            If Producto.fncRegistrarBUS() > 0 Then
                Notificar("Registrado con éxito!")
            End If


        End If
        btnCancelar.PerformClick()
    End Sub

    Private Sub btnBuscarProveedor_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarProveedor.Click
        Dim ObjFrmHijo As New frmMantenimientoProveedor
        'ObjFrmHijo.pFormularioPadrePTA = Me.Name
        'ObjFrmHijo.bolEsBusqueda = True
        'ObjFrmHijo.Owner = Me
        'ObjFrmHijo.ShowDialog()
        ObjFrmHijo.bolEnviar = True
        ObjFrmHijo.bolEsModificar = False
        If ObjFrmHijo.ShowDialog = Windows.Forms.DialogResult.OK Then


            With ObjFrmHijo.dgvProveedor.CurrentRow

                Me.txtIdProveedor.Text = .Cells("IdProveedor").Value
                Me.txtRucProveedor.Text = .Cells("DocumentoIdentidad").Value
                Me.txtDescripcionProveedor.Text = .Cells("Nombre").Value
                ''SeteaNodo(.Cells("IdPtaDependencia").Value)
            End With

        End If
    End Sub

    'Private Sub txtBusquedaCodigo_TextChanged(sender As System.Object, e As System.EventArgs)
    '    LlenaListaProductos(enmEstado.Activo, strCodigo:=Me.txtBusquedaCodigo.Text)
    'End Sub

    Private Sub grpDatos_Enter(sender As System.Object, e As System.EventArgs) Handles grpDatos.Enter

    End Sub

    Private Sub txtPrecioVenta_Enter(sender As System.Object, e As System.EventArgs) Handles txtPrecioVenta.Enter
        bolPivot = True
    End Sub

    Private Sub txtPrecioVentaConIGV_Enter(sender As System.Object, e As System.EventArgs) Handles txtPrecioVentaConIGV.Enter
        bolPivot = False
    End Sub

    Private Sub txtPrecioVentaConIGV_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPrecioVentaConIGV.TextChanged
        If bolPivot = False Then
            Me.txtPrecioVenta.Text = fncRound2(fncForzarDecimal(Me.txtPrecioVentaConIGV.Text) / (1 + My.Settings.IGV))
        End If
    End Sub

    Private Sub txtBusqueda_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            Modificar()
        End If
    End Sub

    Dim bolControl As New Boolean
    Private Sub chkMostrarControlesAvanzados_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMostrarControlesAvanzados.CheckedChanged
        If bolControl = False Then
            If My.Settings.Usuario = 1 Then
                Me.btnNuevo.Visible = Me.chkMostrarControlesAvanzados.Checked
                Me.btnDesactivar.Visible = Me.chkMostrarControlesAvanzados.Checked
                Me.btnEliminar.Visible = Me.chkMostrarControlesAvanzados.Checked
                My.Settings.MostrarControlesAvanzados = Me.chkMostrarControlesAvanzados.Checked
            Else
                bolControl = True
                Me.chkMostrarControlesAvanzados.Checked = False
                Notificar("No tiene permisos para realizar esta acción.", "ERROR")
                bolControl = False
            End If
        End If


    End Sub

    Private Sub dgvProducto_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvProducto.CellFormatting
        Try
            With Me.dgvProducto
                Select Case .Rows(e.RowIndex).Cells("StockActual").Value
                    Case Is <= .Rows(e.RowIndex).Cells("StockMinimo").Value
                        e.CellStyle.BackColor = Color.LightSalmon
                        '' e.CellStyle.SelectionBackColor = Color.LightSalmon

                    Case Else
                        '' Select Case .Rows(e.RowIndex).Cells("pMigrado").Value
                        ''Case 1
                        e.CellStyle.BackColor = Color.LightGreen
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

                ''     e.CellStyle.SelectionForeColor = Color.Black

                'End If
            End With


        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub

    Private Sub dgvProducto_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvProducto.SelectionChanged
        With Me.dgvProducto.CurrentRow
            If .Cells("EstadoBase").Value = enmEstado.Activo Then
                Me.btnDesactivar.Text = "Descontinuar"
            Else
                Me.btnDesactivar.Text = "Reactivar"
            End If
        End With
    End Sub

    Private Sub chkEstado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkEstado.CheckedChanged
        ContenidoEnLoad()

    End Sub

    Private Sub btnExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExcel.Click


        FncDataTable2Excel(dtProductoHistorial, "Historial")

    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        Modificar()

    End Sub

    Private Sub btnNuevoPS_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoPS.Click
        Dim ObjFrmHijo As New frmMantenimientoProveedor
        'ObjFrmHijo.pFormularioPadrePTA = Me.Name
        'ObjFrmHijo.bolEsBusqueda = True
        'ObjFrmHijo.Owner = Me
        'ObjFrmHijo.ShowDialog()
        ObjFrmHijo.bolEnviar = True
        ObjFrmHijo.bolEsModificar = False
        If ObjFrmHijo.ShowDialog = Windows.Forms.DialogResult.OK Then

            If ObjFrmHijo.dgvProveedor.CurrentRow IsNot Nothing Then
                Dim ProveedorSecundario As New clsProveedorSecundarioBUS(0, ObjFrmHijo.dgvProveedor.CurrentRow.Cells("IdProveedor").Value, Me.txtIdProducto.Text)
                If ProveedorSecundario.fncRegistrarBUS() > 0 Then
                    Llenar_Listar_ProveedoresSecundarios(Me.txtIdProducto.Text)
                End If
            End If

            'With ObjFrmHijo.dgvProveedor.CurrentRow



            '    Me.txtIdProveedor.Text = .Cells("IdProveedor").Value
            '    Me.txtRucProveedor.Text = .Cells("DocumentoIdentidad").Value
            '    Me.txtDescripcionProveedor.Text = .Cells("Nombre").Value
            '    ''SeteaNodo(.Cells("IdPtaDependencia").Value)
            'End With

        End If
    End Sub

    Private Sub btnEliminarPS_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarPS.Click
        If Me.dgvProveedores.CurrentRow IsNot Nothing Then
            With Me.dgvProveedores.CurrentRow
                Dim intIdProveedoresSecundario As Integer = .Cells("IdProveedorSecundario").Value
                Dim Proveedor As New clsProveedorSecundarioBUS
                Dim dtProveedor As DataTable = Proveedor.fncConsultarBUS(intIdProveedoresSecundario)
                If fncValidaDataTable(dtProveedor) Then
                    Proveedor.fncSetearBUS(dtProveedor.Rows(0))
                    Proveedor.Estado = enmEstado.Inactivo
                    If Proveedor.fncModificarBUS() > 0 Then
                        Llenar_Listar_ProveedoresSecundarios(Me.txtIdProducto.Text)
                    End If
                End If

            End With
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarEmpleado.Click
        Dim ObjFrmHijo As New frmMantenimientoEmpleado
        'ObjFrmHijo.pFormularioPadrePTA = Me.Name
        'ObjFrmHijo.bolEsBusqueda = True
        'ObjFrmHijo.Owner = Me
        'ObjFrmHijo.ShowDialog()
        ObjFrmHijo.bolEnviar = True
        ObjFrmHijo.bolEsModificar = False
        If ObjFrmHijo.ShowDialog = Windows.Forms.DialogResult.OK Then


            With ObjFrmHijo.dgvEmpleado.CurrentRow
                ''    bolEsBusquedaAutomaticaCliente = False
                Me.txtIdEmpleado.Text = .Cells("IdEmpleado").Value
                Me.txtNombreEmpleado.Text = .Cells("Apellidos").Value + ", " + .Cells("Nombres").Value ' .Cells("Tipo").Value & " : " & .Cells("DocumentoIdentidad").Value

                ''   bolEsBusquedaAutomaticaCliente = True
                ''SeteaNodo(.Cells("IdPtaDependencia").Value)
            End With
            Me.txtMontoComision.Text = "0.00"
            Me.ActiveControl = Me.txtMontoComision
        End If
    End Sub


    Private Sub btnGuardarComision_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarComision.Click
        Dim intIdEmpleado As Integer = CInt(fncForzarDecimal(Me.txtIdEmpleado.Text))
        Dim intIdProducto As Integer = CInt(fncForzarDecimal(Me.txtIdProducto.Text))
        Dim decMontoComision As Decimal = fncForzarDecimal(Me.txtMontoComision.Text)

        If intIdProducto = 0 Then
            Notificar("Debe registrar el producto antes de asignar una comisión.")
        End If

        Dim Producto As New clsProductoBUS
        Dim dtProducto As DataTable = Producto.fncConsultarBUS(intIdProducto)
        If fncValidaDataTable(dtProducto) Then
            With Producto
                .fncSetearBUS(dtProducto.Rows(0))
                .IdEmpleadoComision = intIdEmpleado
                .MontoComision = decMontoComision
                .FechaModifica = FechaHoraServidor()
                If .fncModificarBUS() > 0 Then
                    Notificar("Comisión registrada.")
                    '' btnCancelar.PerformClick()
                End If
            End With
        End If

    End Sub

    Private Sub btnEliminarComision_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarComision.Click
        Dim intIdEmpleado As Integer = CInt(fncForzarDecimal(Me.txtIdEmpleado.Text))
        Dim intIdProducto As Integer = CInt(fncForzarDecimal(Me.txtIdProducto.Text))
        Dim decMontoComision As Decimal = fncForzarDecimal(Me.txtMontoComision.Text)

        If intIdProducto = 0 Then
            Notificar("Debe registrar el producto antes de asignar una comisión.")
        End If


        Dim Producto As New clsProductoBUS
        Dim dtProducto As DataTable = Producto.fncConsultarBUS(intIdProducto)
        If fncValidaDataTable(dtProducto) Then
            With Producto
                .fncSetearBUS(dtProducto.Rows(0))
                .IdEmpleadoComision = DBNull.Value
                .MontoComision = 0
                .FechaModifica = FechaHoraServidor()
                If .fncModificarBUS() > 0 Then
                    Notificar("Comisión eliminada.")
                    ''  btnCancelar.PerformClick()
                    Me.txtIdEmpleado.Text = String.Empty
                    Me.txtNombreEmpleado.Text = String.Empty
                    Me.txtMontoComision.Text = "0.00"
                End If
            End With
        End If
    End Sub

    Private Sub txtPrecioCosteSinIGV_Enter(sender As System.Object, e As System.EventArgs) Handles txtPrecioCosteSinIGV.Enter
        bolPivotCoste = True
    End Sub

    Private Sub txtPrecioCosteConIGV_Enter(sender As System.Object, e As System.EventArgs) Handles txtPrecioCosteConIGV.Enter
        bolPivotCoste = False
    End Sub

    Private Sub txtPrecioCosteSinIGV_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPrecioCosteSinIGV.TextChanged
        If bolPivotCoste = True Then
            Me.txtPrecioCosteConIGV.Text = FormatearNumero((fncForzarDecimal(Me.txtPrecioCosteSinIGV.Text) * (1 + My.Settings.IGV)), 8)
        End If
    End Sub

    Private Sub txtPrecioCosteConIGV_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPrecioCosteConIGV.TextChanged
        If bolPivotCoste = False Then
            Me.txtPrecioCosteSinIGV.Text = FormatearNumero(fncForzarDecimal(Me.txtPrecioCosteConIGV.Text) / (1 + My.Settings.IGV), 8)
        End If
    End Sub

    Private Sub btnVerOperacion_Click(sender As System.Object, e As System.EventArgs) Handles btnVerOperacion.Click
        If Me.dgvHistorial.Rows.Count > 0 AndAlso Me.dgvHistorial.CurrentRow IsNot Nothing Then

            Dim strOperacion As String = Me.dgvHistorial.CurrentRow.Cells("TipoOperacion").Value
            Dim intIdOperacion As Integer = fncForzarInteger(Me.dgvHistorial.CurrentRow.Cells("IdOperacion").Value)
            Dim intIdTipoComprobante As Integer = fncForzarInteger(Me.dgvHistorial.CurrentRow.Cells("IdTipoComprobante").Value)


            Select Case strOperacion
                Case "CompraIGV"

                    Dim ChildForm As New frmMantenimientoComprasConIGV

                    ChildForm.StartPosition = FormStartPosition.Manual
                    ChildForm.Left = 0
                    ChildForm.Top = 0
                    ChildForm.MdiParent = Me.ParentForm

                    ChildForm.Show()
                    ChildForm.Controles_En_Load()
                    ChildForm.LlenarDatosPorCompra(intIdOperacion)

                Case "Compra"

                    Dim ChildForm As New frmMantenimientoComprasSinIGV

                    ChildForm.StartPosition = FormStartPosition.Manual
                    ChildForm.Left = 0
                    ChildForm.Top = 0
                    ChildForm.MdiParent = Me.ParentForm

                    ChildForm.Show()
                    ChildForm.Controles_En_Load()
                    ChildForm.LlenarDatosPorCompra(intIdOperacion)

                Case Else
                    Select Case intIdTipoComprobante
                        Case enmTipoComprobante.Factura
                            'If SingletonForm(frmMantenimientoVentas) = True Then
                            Dim ChildForm As New frmMantenimientoVentas

                            ChildForm.StartPosition = FormStartPosition.Manual
                            ChildForm.Left = 0
                            ChildForm.Top = 0
                            ChildForm.MdiParent = Me.ParentForm
                            ChildForm.txtTitulo.Text = "MANTENIMIENTO DE FACTURA"
                            ChildForm.Text = "FACTURA"
                            ChildForm.bolEsFactura = True
                            modInventario.bolVentasFacturaAbierto = True
                            ChildForm.Show()
                            ChildForm.Controles_En_Load()
                            ChildForm.LlenarDatosPorVenta(intIdOperacion)

                            'Else
                            '    DevolverEnfoque(frmMantenimientoVentas)
                            'End If

                        Case enmTipoComprobante.Boleta

                            Dim ChildForm As New frmMantenimientoVentas

                            ChildForm.StartPosition = FormStartPosition.Manual
                            ChildForm.Left = 0
                            ChildForm.Top = 0
                            ChildForm.MdiParent = Me.ParentForm
                            ChildForm.txtTitulo.Text = "MANTENIMIENTO DE BOLETA"
                            ChildForm.Text = "BOLETA"
                            ChildForm.bolEsFactura = False
                            modInventario.bolVentasBoletaAbierto = True
                            ChildForm.Show()
                            ChildForm.Controles_En_Load()
                            ChildForm.LlenarDatosPorVenta(intIdOperacion)
                            ChildForm.txtTitulo.BackColor = Color.DarkCyan


                    End Select
            End Select

        End If
    End Sub


    Private Function SingletonForm(ByVal FormUnico As Form) As Boolean
        Dim Rpta As Boolean = True
        Dim ctl As Form
        For Each ctl In Me.ParentForm.MdiChildren
            If ctl.Name = FormUnico.Name Then
                Rpta = False
                Exit For
            Else
                Rpta = True
            End If
        Next
        Return Rpta
    End Function


    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If MsgBox("¿Está seguro de que desea eliminar este producto? Esta acción no es reversible.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If Me.dgvProducto.CurrentRow IsNot Nothing AndAlso Me.dgvProducto.Rows.Count > 0 Then
                Dim Producto As New clsProductoBUS
                Dim intIdProducto As Integer = Me.dgvProducto.CurrentRow.Cells("IdProducto").Value
                Dim dtValida As DataTable = Producto.fncValidarUsoDeProductoBUS(intIdProducto)
                If fncValidaDataTable(dtValida) Then
                    Notificar("No puede eliminar este producto porque ya ha sido usado.")
                Else
                    Producto.fncEliminaProductoDetallesBUS(intIdProducto)
                    Dim dtProducto As DataTable = Producto.fncConsultarBUS(intIdProducto)
                    If fncValidaDataTable(dtProducto) Then
                        Producto.fncSetearBUS(dtProducto.Rows(0))
                        If Producto.fncEliminarBUS() > 0 Then
                            Notificar("Producto eliminado!")
                            ContenidoEnLoad()
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub chkUnlock_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnlock.CheckedChanged
        Me.txtPrecioCosteSinIGV.Enabled = chkUnlock.CheckState
        Me.txtPrecioCosteConIGV.Enabled = chkUnlock.CheckState
    End Sub
End Class