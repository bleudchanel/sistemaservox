Imports SistemaServox2015BUS
Imports pryUtil.clsUtil
Imports System.Net

Public Class frmMantenimientoCliente

    Public bolEsModificar As Boolean = True
    Public bolEnviar As New Boolean

    Private Sub frmMantenimientoCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ContenidoEnLoad()
    End Sub

    Sub ContenidoEnLoad()
        LlenaListaClientes(If(chkEstado.Checked = True, -1, enmEstado.Activo))

        Me.tbcCliente.TabPages.Remove(tbpListar)
        Me.tbcCliente.TabPages.Remove(tbpNuevo)
        Me.tbcCliente.TabPages.Remove(tbpDatosExtra)
        Me.tbcCliente.TabPages.Insert(0, tbpListar)

        ProcComboBoxEstado(cmbEstado)
        Dim TipoDocumentoIdentidad As New clsTipoDocumentoIdentidadBUS
        SetComboBox(cmbTipoDocumentoIdentidad, TipoDocumentoIdentidad.fncListarDocumentoIdentidadCamposBUS(enmEstado.Activo), "Descripcion", "IdTipoDocumentoIdentidad")
        Me.dgvHistorialCompras.Rows.Clear()
        Me.dgvHistorialCompras.Refresh()
        '' fncSetDataTableInDGV(dtCliente, Me.dgvCliente)
        Me.ActiveControl = Me.txtBusqueda

    End Sub

    Dim intIdClienteGlobal As Integer
    Sub LlenarDatosCliente(ByVal intIdCliente As Integer)
        intIdClienteGlobal = intIdCliente
        dtResultadoBase = New DataTable
        Dim Cliente As New clsClienteBUS
        Dim dtCliente = Cliente.fncListarClientesPorCamposBUS(, intIdCliente, , )
        If fncValidaDataTable(dtCliente) Then
            Me.txtIdEmpleado.Text = ObtenerValorCelda(dtCliente.Rows(0), "IdCliente")
            Me.txtNombreCompleto.Text = ObtenerValorCelda(dtCliente.Rows(0), "CLInombre").ToString.ToUpper
            Me.cmbTipoDocumentoIdentidad.SelectedValue = ObtenerValorCelda(dtCliente.Rows(0), "IdTipoDocumentoIdentidad")
            Me.txtNroDocumentoIdentidad.Text = ObtenerValorCelda(dtCliente.Rows(0), "DocumentoIdentidad")
            Me.txtDireccion.Text = ObtenerValorCelda(dtCliente.Rows(0), "CLIdireccion")
            Me.txtTelefonoFijo.Text = ObtenerValorCelda(dtCliente.Rows(0), "CLItelefonofijo")
            Me.txtTelefonoMovil.Text = ObtenerValorCelda(dtCliente.Rows(0), "CLItelefonomovil")
        End If
    End Sub

    Sub LlenaListaClientes(ByVal intEstado As Integer, Optional ByVal strNombre As String = "")
        dgvCliente.Rows.Clear()
        Dim Cliente As New clsClienteBUS
        Dim dtCliente = Cliente.fncListarClientesPorCamposBUS(, , intEstado, strNombre)
        If fncValidaDataTable(dtCliente) Then

            For Each row In dtCliente.Rows
                dgvCliente.Rows.Add()
                With Me.dgvCliente.Rows(dgvCliente.Rows.Count - 1)
                    .Cells("Tipo").Value = ObtenerValorCelda(row, "Abrev")
                    .Cells("DocumentoIdentidad").Value = ObtenerValorCelda(row, "DocumentoIdentidad")
                    .Cells("CLInombre").Value = ObtenerValorCelda(row, "CLInombre").ToString.ToUpper
                    .Cells("CLIdireccion").Value = ObtenerValorCelda(row, "CLIdireccion")
                    .Cells("CLItelefonofijo").Value = ObtenerValorCelda(row, "CLItelefonofijo")
                    .Cells("CLItelefonomovil").Value = ObtenerValorCelda(row, "CLItelefonomovil")
                    .Cells("CLIemail").Value = ObtenerValorCelda(row, "CLIemail")
                    .Cells("CLIfecharegistro").Value = ObtenerValorCelda(row, "FechaRegistro")
                    .Cells("CLIobservacion").Value = ObtenerValorCelda(row, "CLIobservacion")
                    .Cells("IdCliente").Value = ObtenerValorCelda(row, "IdCliente")
                    .Cells("IdTipoDocumentoIdentidad").Value = ObtenerValorCelda(row, "IdTipoDocumentoIdentidad")
                    .Cells("Estado").Value = If(ObtenerValorCelda(row, "Estado") = enmEstado.Activo, My.Resources.accept, My.Resources.cancel)
                End With
            Next
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
        BuscarEnDataGrid(dgvCliente, txtBusqueda.Text, {"DocumentoIdentidad", "CLInombre"}, "DocumentoIdentidad")
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        bolEsModificar = False
        '()
        Me.tbcCliente.TabPages.Insert(0, tbpNuevo)
        Me.tbcCliente.SelectedTab = tbpNuevo
        Me.tbcCliente.TabPages.Remove(tbpListar)
        Me.tbcCliente.TabPages.Remove(tbpDatosExtra)
        Controles_En_Nuevo()
        Me.ActiveControl = Me.txtNombreCompleto
    End Sub

    Sub Controles_En_Nuevo()
        ClearControls(grpDatos)
        cmbEstado.SelectedValue = enmEstado.Activo
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        ContenidoEnLoad()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        If Me.dgvCliente.Rows.Count > 0 And dgvCliente.CurrentRow IsNot Nothing Then
            If bolEnviar Then
                Me.DialogResult = Windows.Forms.DialogResult.OK

                '   MsgBox(dgvResultado.Rows.Count)

            End If
        End If
    End Sub

    Private Sub dgvCliente_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCliente.CellDoubleClick
        If bolEsModificar = False Then
            Me.btnSeleccionar.PerformClick()
        Else
            '' Me.btnModificar.PerformClick()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If bolEsModificar = True Then
            Dim Cliente As New clsClienteBUS

            If Cliente.fncValidaDocumento(Me.cmbTipoDocumentoIdentidad.SelectedValue, Me.txtNroDocumentoIdentidad.Text, Me.txtIdEmpleado.Text) = True Then
                Notificar("Este número de " & Me.cmbTipoDocumentoIdentidad.Text & vbCrLf & " ya está en uso.", "ERROR")
                Exit Sub
            End If

            Dim dtCliente As DataTable = Cliente.fncConsultarBUS(Me.txtIdEmpleado.Text)
            If fncValidaDataTable(dtCliente) Then
                With Cliente
                    .fncSetearBUS(dtCliente.Rows(0))
                    .IdTipoDocumentoIdentidad = cmbTipoDocumentoIdentidad.SelectedValue
                    .CLIruc = Me.txtNroDocumentoIdentidad.Text
                    .DocumentoIdentidad = Me.txtNroDocumentoIdentidad.Text
                    .CLItelefonofijo = Me.txtTelefonoFijo.Text
                    .CLItelefonomovil = Me.txtTelefonoMovil.Text
                    .CLIobservacion = Me.txtObservacion.Text
                    .CLInombre = Me.txtNombreCompleto.Text
                    .CLIdireccion = Me.txtDireccion.Text
                    .CLIemail = Me.txtEmail.Text
                    .FechaModifica = FechaHoraServidor()
                    .UsuarioModifica = My.Settings.Usuario
                    If .fncModificarBUS > 0 Then
                        Notificar("Modificado con éxito")
                        btnCancelar.PerformClick()
                    End If
                End With
            End If
        Else

            Dim ClienteValida As New clsClienteBUS
            If ClienteValida.fncValidaDocumento(Me.cmbTipoDocumentoIdentidad.SelectedValue, Me.txtNroDocumentoIdentidad.Text) = True Then
                Notificar("Este número de " & Me.cmbTipoDocumentoIdentidad.Text & vbCrLf & " ya está en uso.", "ERROR")
                Exit Sub
            End If

            Dim Cliente As New clsClienteBUS(Me.txtNroDocumentoIdentidad.Text _
                                             , Me.txtNombreCompleto.Text _
                                             , Me.txtDireccion.Text _
                                             , Me.txtTelefonoFijo.Text _
                                             , Me.txtTelefonoMovil.Text _
                                             , Me.txtEmail.Text _
                                             , FechaHoraServidor _
                                             , Me.txtObservacion.Text _
                                             , 0 _
                                             , enmEstado.Activo _
                                             , My.Settings.Usuario _
                                             , My.Settings.Usuario _
                                             , Me.cmbTipoDocumentoIdentidad.SelectedValue _
                                             , Me.txtNroDocumentoIdentidad.Text)
            If Cliente.fncRegistrarBUS() > 0 Then
                Notificar("Registrado con éxito")
                Me.btnCancelar.PerformClick()
            End If


        End If
    End Sub

    Private Sub btnExaminar_Click(sender As System.Object, e As System.EventArgs) Handles btnExaminar.Click

    End Sub

    Private Sub txtBusqueda_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            LlenaListaClientes(enmEstado.Activo, Me.txtBusqueda.Text)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        bolEsModificar = True
        Controles_En_Nuevo()
        If dgvCliente.CurrentRow IsNot Nothing Then
            Dim intIdCliente As Integer = Me.dgvCliente.CurrentRow.Cells("IdCliente").Value
            Me.tbcCliente.TabPages.Remove(tbpListar)
            Me.tbcCliente.TabPages.Remove(tbpNuevo)
            Me.tbcCliente.TabPages.Remove(tbpDatosExtra)
            Me.tbcCliente.TabPages.Insert(0, tbpNuevo)
            Me.tbcCliente.TabPages.Insert(1, tbpDatosExtra)
            LlenarDatosCliente(intIdCliente)

        End If
    End Sub

    Dim dtResultadoBase As New DataTable
    Private Sub btnGenerarHistorial_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerarHistorial.Click
        Me.dgvHistorialCompras.Rows.Clear()
        Dim Cliente As New clsClienteBUS
        dtResultadoBase = Cliente.fncReporteHistorialClienteBUS(intIdClienteGlobal, Me.dtpVentasDesde.Value, Me.dtpVentasHasta.Value)
        If fncValidaDataTable(dtResultadoBase) Then
            fncSetDataTableInDGV(dtResultadoBase, dgvHistorialCompras)
        End If
    End Sub

    Private Sub btnExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExcel.Click
        If fncValidaDataTable(dtResultadoBase) Then
            FncDataTable2Excel(dtResultadoBase, "Historial")
        End If
    End Sub

    Private Sub frmMantenimientoCliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub dtpVentasDesde_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpVentasDesde.ValueChanged

    End Sub

    Private Sub dtpVentasHasta_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpVentasHasta.ValueChanged

    End Sub
End Class