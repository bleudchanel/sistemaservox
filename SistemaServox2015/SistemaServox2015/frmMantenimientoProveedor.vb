Imports SistemaServox2015BUS
Imports pryUtil.clsUtil
Imports System.Net

Public Class frmMantenimientoProveedor

    Public bolEnviar As New Boolean
    Public bolEsModificar As Boolean = True

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmMantenimientoProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ContenidoEnLoad()
    End Sub

    Sub ContenidoEnLoad()

        Me.cmbTipo.Items.Add("General")
        Me.cmbTipo.Items.Add("Transporte")
        Me.cmbTipo.SelectedIndex = 0
        ProcComboBoxAAnio(cmbAnio)
        ProcComboBoxAMes(cmbMes)
        LlenaListaProveedores(If(chkEstado.Checked = True, -1, enmEstado.Activo))
        Me.tbcProveedor.TabPages.Remove(tbpListar)
        Me.tbcProveedor.TabPages.Remove(tbpNuevo)
        Me.tbcProveedor.TabPages.Remove(tbpHistorial)
        Me.tbcProveedor.TabPages.Insert(0, tbpListar)

        ''ProcComboBoxEstado(cmbEstado)
        Dim TipoDocumentoIdentidad As New clsTipoDocumentoIdentidadBUS
        SetComboBox(cmbTipoDocumento, TipoDocumentoIdentidad.fncListarDocumentoIdentidadCamposBUS(enmEstado.Activo), "Descripcion", "IdTipoDocumentoIdentidad")

        '' fncSetDataTableInDGV(dtCliente, Me.dgvCliente)
        Me.ActiveControl = Me.txtBusqueda
    End Sub

    Dim intIdProveedorGlobal As Integer
    Sub LLenarDatosProveedor(ByVal intIdProveedor As Integer)
        intIdProveedorGlobal = intIdProveedor
        Dim Proveedor As New clsProveedorBUS
        Dim dtProveedor As DataTable = Proveedor.fncListarProveedoresPorCamposBUS(, intIdProveedor, enmEstado.Activo, )
        If fncValidaDataTable(dtProveedor) Then
            Me.txtIdProveedor.Text = ObtenerValorCelda(dtProveedor.Rows(0), "IdProveedor")
            Me.txtNombreProveedor.Text = ObtenerValorCelda(dtProveedor.Rows(0), "PRVnombre").ToString.ToUpper
            Me.txtNroDocumento.Text = ObtenerValorCelda(dtProveedor.Rows(0), "DocumentoIdentidad")
            Me.txtDireccion.Text = ObtenerValorCelda(dtProveedor.Rows(0), "PRVdireccion")
            Me.txtTelfFijo.Text = ObtenerValorCelda(dtProveedor.Rows(0), "PRVtelefonofijo")
            Me.txtTelfMovil.Text = ObtenerValorCelda(dtProveedor.Rows(0), "PRVtelefonomovil")
            Me.txtEmail.Text = ObtenerValorCelda(dtProveedor.Rows(0), "PRVemail")
            Me.txtObservacion.Text = ObtenerValorCelda(dtProveedor.Rows(0), "PRVobservacion")
            Me.cmbTipo.SelectedIndex = ObtenerValorCelda(dtProveedor.Rows(0), "TipoIndex")
        End If
    End Sub

    Sub LlenaListaProveedores(ByVal intEstado As Integer, Optional ByVal strProveedor As String = "")
        dgvProveedor.Rows.Clear()
        Dim Proveedor As New clsProveedorBUS
        Dim dtProveedor = Proveedor.fncListarProveedoresPorCamposBUS(, , intEstado, strProveedor)
        If fncValidaDataTable(dtProveedor) Then

            For Each row In dtProveedor.Rows
                dgvProveedor.Rows.Add()
                With Me.dgvProveedor.Rows(dgvProveedor.Rows.Count - 1)
                    .Cells("Tipo").Value = ObtenerValorCelda(row, "Abrev")
                    .Cells("DocumentoIdentidad").Value = ObtenerValorCelda(row, "DocumentoIdentidad")
                    .Cells("Nombre").Value = ObtenerValorCelda(row, "PRVnombre").ToString.ToUpper
                    .Cells("Direccion").Value = ObtenerValorCelda(row, "PRVdireccion")
                    .Cells("telefonofijo").Value = ObtenerValorCelda(row, "PRVtelefonofijo")
                    .Cells("telefonomovil").Value = ObtenerValorCelda(row, "PRVtelefonomovil")
                    .Cells("email").Value = ObtenerValorCelda(row, "PRVemail")
                    .Cells("fecharegistro").Value = ObtenerValorCelda(row, "FechaRegistro")
                    .Cells("observacion").Value = ObtenerValorCelda(row, "PRVobservacion")
                    .Cells("IdProveedor").Value = ObtenerValorCelda(row, "IdProveedor")
                    .Cells("Estado").Value = If(ObtenerValorCelda(row, "Estado") = enmEstado.Activo, My.Resources.accept, My.Resources.cancel)
                End With
            Next
        End If
    End Sub


    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
        BuscarEnDataGrid(dgvProveedor, txtBusqueda.Text, {"DocumentoIdentidad", "Nombre"}, "DocumentoIdentidad")
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        If Me.dgvProveedor.Rows.Count > 0 And dgvProveedor.CurrentRow IsNot Nothing Then
            If bolEnviar Then
                Me.DialogResult = Windows.Forms.DialogResult.OK

                '   MsgBox(dgvResultado.Rows.Count)

            End If
        End If
    End Sub

    Private Sub btnHistorialProveedor_Click(sender As System.Object, e As System.EventArgs) Handles btnHistorialProveedor.Click
        Dim frmReporte As New frmRepositorioReporte
        Dim Proveedor As New clsProveedorBUS
        'Dim Producto As New clsProductoBUS
        'Dim strTitulo As String = Me.dgvPlanillasPeriodo.CurrentRow.Cells("lstIdPlanilla").Value & " : " & Me.dgvPlanillasPeriodo.CurrentRow.Cells("lstDescripcionPlanilla").Value
        frmReporte.ConstruirReporteHistorialProveedor(Proveedor.fncHistorialDeCompras(-1), "")
        frmReporte.Show()
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Me.bolEsModificar = False

        Me.tbcProveedor.TabPages.Remove(tbpListar)
        Me.tbcProveedor.TabPages.Remove(tbpNuevo)
        Me.tbcProveedor.TabPages.Remove(tbpHistorial)
        Me.tbcProveedor.TabPages.Insert(0, tbpNuevo)
        Controles_En_Nuevo()
        Me.ActiveControl = Me.txtNombreProveedor
    End Sub

    Sub Controles_En_Nuevo()
        Me.txtIdProveedor.Text = ""
        Me.txtNombreProveedor.Text = ""
        Me.txtNroDocumento.Text = ""
        Me.txtDireccion.Text = ""
        Me.txtTelfFijo.Text = ""
        Me.txtTelfMovil.Text = ""
        Me.txtEmail.Text = ""
        Me.txtObservacion.Text = ""
    End Sub

    Private Sub dgvProveedor_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedor.CellDoubleClick
        If bolEsModificar = False Then
            Me.btnSeleccionar.PerformClick()
        Else
            Me.btnModificar.PerformClick()
        End If
    End Sub



    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        bolEsModificar = True
        If Me.dgvProveedor.CurrentRow IsNot Nothing Then
            Me.dgvHistorialVentas.Rows.Clear()
            Dim intIdProveedor As Integer = Me.dgvProveedor.CurrentRow.Cells("IdProveedor").Value
            Me.tbcProveedor.TabPages.Remove(tbpListar)
            Me.tbcProveedor.TabPages.Remove(tbpNuevo)
            Me.tbcProveedor.TabPages.Remove(tbpHistorial)
            Me.tbcProveedor.TabPages.Insert(0, tbpNuevo)
            Me.tbcProveedor.TabPages.Insert(1, tbpHistorial)
            LLenarDatosProveedor(intIdProveedor)
        End If
    End Sub

    Private Sub txtBusqueda_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            LlenaListaProveedores(enmEstado.Activo, Me.txtBusqueda.Text)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        ContenidoEnLoad()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If bolEsModificar Then
            Dim Proveedor As New clsProveedorBUS

            If Proveedor.fncValidaDocumento(Me.cmbTipoDocumento.SelectedValue, Me.txtNroDocumento.Text, Me.txtIdProveedor.Text) = True Then
                Notificar("Este número de " & Me.cmbTipoDocumento.Text & " ya está en uso.", "ERROR")
                Exit Sub
            End If

            Dim dtProveedor As DataTable = Proveedor.fncConsultarBUS(Me.txtIdProveedor.Text)
            If fncValidaDataTable(dtProveedor) Then
                With Proveedor
                    .fncSetearBUS(dtProveedor.Rows(0))
                    .PRVnombre = Me.txtNombreProveedor.Text
                    .IdTipoDocumentoIdentidad = Me.cmbTipoDocumento.SelectedValue
                    .DocumentoIdentidad = Me.txtNroDocumento.Text
                    .PRVdireccion = Me.txtDireccion.Text
                    .PRVtelefonofijo = Me.txtTelfFijo.Text
                    .PRVtelefonomovil = Me.txtTelfMovil.Text
                    .PRVobservacion = Me.txtObservacion.Text
                    .PRVemail = Me.txtEmail.Text
                    .FechaModifica = FechaHoraServidor()
                    .UsuarioModifica = My.Settings.Usuario
                    .Tipo = Me.cmbTipo.Text
                    If .fncModificarBUS() > 0 Then
                        Notificar("Modificado con éxito")
                        btnCancelar.PerformClick()
                    End If

                End With
            End If
        Else

            Dim ValidaProveedor As New clsProveedorBUS
            If ValidaProveedor.fncValidaDocumento(Me.cmbTipoDocumento.SelectedValue, Me.txtNroDocumento.Text) = True Then
                Notificar("Este número de " & Me.cmbTipoDocumento.Text & " ya está en uso.", "ERROR")
                Exit Sub
            End If

            Dim Proveedor As New clsProveedorBUS(Me.txtNroDocumento.Text _
                                                 , Me.txtNombreProveedor.Text _
                                                 , Me.txtDireccion.Text _
                                                 , Me.txtTelfFijo.Text _
                                                 , Me.txtTelfMovil.Text _
                                                 , Me.txtEmail.Text _
                                                 , FechaHoraServidor _
                                                 , Me.txtObservacion.Text _
                                                 , 0 _
                                                 , enmEstado.Activo _
                                                 , FechaHoraServidor _
                                                 , My.Settings.Usuario _
                                                 , Me.cmbTipoDocumento.SelectedValue _
                                                 , Me.txtNroDocumento.Text _
                                                 , Me.cmbTipo.Text)
            If Proveedor.fncRegistrarBUS() > 0 Then
                Notificar("Registrado con éxito")
                btnCancelar.PerformClick()
            End If

        End If
    End Sub

    Dim dtResultadoBase As New DataTable
    Private Sub btnGenerarHistorial_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerarHistorialMA.Click
        Me.dgvHistorialVentas.Rows.Clear()
        Dim Proveedor As New clsProveedorBUS
        dtResultadoBase = Proveedor.fncReporteHistorialProveedorBUS(intIdProveedorGlobal, If(chkSoloAnio.Checked = True, -1, Me.cmbMes.SelectedValue), Me.cmbAnio.SelectedValue)
        If fncValidaDataTable(dtResultadoBase) Then
            fncSetDataTableInDGV(dtResultadoBase, dgvHistorialVentas)
        End If
    End Sub

    Private Sub btnExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExcel.Click
        If fncValidaDataTable(dtResultadoBase) Then
            FncDataTable2Excel(dtResultadoBase, "Historial")
        End If
    End Sub

    Private Sub btnVerOperacion_Click(sender As System.Object, e As System.EventArgs) Handles btnVerOperacion.Click
        If Me.dgvHistorialVentas.Rows.Count > 0 AndAlso Me.dgvHistorialVentas.CurrentRow IsNot Nothing Then
            Dim strOperacion As String = Me.dgvHistorialVentas.CurrentRow.Cells("TipoOperacion").Value
            Dim intIdOperacion As Integer = fncForzarInteger(Me.dgvHistorialVentas.CurrentRow.Cells("IdCompra").Value)

             Select strOperacion
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
            End Select

        End If

       
    End Sub

    Private Sub dtpVentasDesde_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpVentasDesde.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.dtpVentasHasta
        End If
    End Sub

    Private Sub btnGenerarDosFechas_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerarDosFechas.Click
        Me.dgvHistorialVentas.Rows.Clear()
        Dim Proveedor As New clsProveedorBUS
        dtResultadoBase = Proveedor.fncReporteHistorialProveedorDosFechasBUS(intIdProveedorGlobal, dtpVentasDesde.Value, dtpVentasHasta.Value)
        If fncValidaDataTable(dtResultadoBase) Then
            fncSetDataTableInDGV(dtResultadoBase, dgvHistorialVentas)
        End If
    End Sub
End Class