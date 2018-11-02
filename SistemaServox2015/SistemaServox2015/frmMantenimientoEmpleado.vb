Imports SistemaServox2015BUS
Imports pryUtil.clsUtil
Imports System.Net

Public Class frmMantenimientoEmpleado

    Public bolEsModificar As Boolean = True
    Public bolEnviar As New Boolean

    Private Sub frmMantenimientoCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ContenidoEnLoad()
    End Sub

    Sub ContenidoEnLoad()
        LlenaListaEmpleados(If(chkEstado.Checked = True, -1, enmEstado.Activo))

        Me.tbcCliente.TabPages.Remove(tbpListar)
        Me.tbcCliente.TabPages.Remove(tbpNuevo)
        Me.tbcCliente.TabPages.Remove(tbpDatosExtra)
        Me.tbcCliente.TabPages.Insert(0, tbpListar)

        ProcComboBoxEstado(cmbEstado)
        Dim TipoDocumentoIdentidad As New clsTipoDocumentoIdentidadBUS
        '' SetComboBox(cmbTipoDocumentoIdentidad, TipoDocumentoIdentidad.fncListarDocumentoIdentidadCamposBUS(enmEstado.Activo), "Descripcion", "IdTipoDocumentoIdentidad")
        Me.dgvHistorialComisiones.Rows.Clear()
        Me.dgvHistorialComisiones.Refresh()
        '' fncSetDataTableInDGV(dtCliente, Me.dgvCliente)
        Me.ActiveControl = Me.txtBusqueda

    End Sub

    Dim intIdEmpleadoGlobal As Integer
    Sub LlenarDatosCliente(ByVal intIdEmpleado As Integer)
        intIdEmpleadoGlobal = intIdEmpleado
        dtResultadoBase = New DataTable
        Dim Empleado As New clsEmpleadoBUS
        Dim dtEmpleado = Empleado.fncListarEmpleadosPorCampoBUS(intIdEmpleado, , , )
        If fncValidaDataTable(dtEmpleado) Then
            Me.txtIdCliente.Text = ObtenerValorCelda(dtEmpleado.Rows(0), "IdEmpleado")
            Me.txtApellidos.Text = ObtenerValorCelda(dtEmpleado.Rows(0), "Apellidos").ToString.ToUpper
            Me.txtNombres.Text = ObtenerValorCelda(dtEmpleado.Rows(0), "Nombres").ToString.ToUpper
            '' Me.cmbTipoDocumentoIdentidad.SelectedValue = ObtenerValorCelda(dtCliente.Rows(0), "IdTipoDocumentoIdentidad")
            Me.txtNroDocumentoIdentidad.Text = ObtenerValorCelda(dtEmpleado.Rows(0), "NumeroDocumento")
        End If
    End Sub

    Sub LlenaListaEmpleados(ByVal intEstado As Integer, Optional ByVal strNombre As String = "")
        dgvEmpleado.Rows.Clear()
        Dim Empleado As New clsEmpleadoBUS
        Dim dtEmpleado = Empleado.fncListarEmpleadosPorCampoBUS(, strNombre, , intEstado)
        If fncValidaDataTable(dtEmpleado) Then

            For Each row In dtEmpleado.Rows
                dgvEmpleado.Rows.Add()
                With Me.dgvEmpleado.Rows(dgvEmpleado.Rows.Count - 1)

                    .Cells("Apellidos").Value = ObtenerValorCelda(row, "Apellidos").ToString.ToUpper
                    .Cells("Nombres").Value = ObtenerValorCelda(row, "Nombres").ToString.ToUpper
                    .Cells("DNI").Value = ObtenerValorCelda(row, "NumeroDocumento")
                    .Cells("IdEmpleado").Value = ObtenerValorCelda(row, "IdEmpleado")
                    .Cells("Estado").Value = If(ObtenerValorCelda(row, "Estado") = enmEstado.Activo, My.Resources.accept, My.Resources.cancel)
                End With
            Next
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
        BuscarEnDataGrid(dgvEmpleado, txtBusqueda.Text, {"DNI", "Apellidos", "Nombres"}, "DNI")
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        bolEsModificar = False
        '()
        Me.tbcCliente.TabPages.Insert(0, tbpNuevo)
        Me.tbcCliente.SelectedTab = tbpNuevo
        Me.tbcCliente.TabPages.Remove(tbpListar)
        Me.tbcCliente.TabPages.Remove(tbpDatosExtra)
        Controles_En_Nuevo()
        Me.ActiveControl = Me.txtApellidos
    End Sub

    Sub Controles_En_Nuevo()
        ClearControls(grpDatos)
        cmbEstado.SelectedValue = enmEstado.Activo
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        ContenidoEnLoad()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        If Me.dgvEmpleado.Rows.Count > 0 And dgvEmpleado.CurrentRow IsNot Nothing Then
            If bolEnviar Then
                Me.DialogResult = Windows.Forms.DialogResult.OK

                '   MsgBox(dgvResultado.Rows.Count)

            End If
        End If
    End Sub

    Private Sub dgvCliente_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmpleado.CellDoubleClick
        If bolEsModificar = False Then
            Me.btnSeleccionar.PerformClick()
        Else
            ''  Me.btnModificar.PerformClick()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If bolEsModificar = True Then
            Dim Empleado As New clsEmpleadoBUS

            'If Cliente.fncValidaDocumento(Me.cmbTipoDocumentoIdentidad.SelectedValue, Me.txtNroDocumentoIdentidad.Text, Me.txtIdCliente.Text) = True Then
            '    Notificar("Este número de " & Me.cmbTipoDocumentoIdentidad.Text & vbCrLf & " ya está en uso.", "ERROR")
            '    Exit Sub
            'End If

            Dim dtCliente As DataTable = Empleado.fncConsultarBUS(Me.txtIdCliente.Text)
            If fncValidaDataTable(dtCliente) Then
                With Empleado
                    .fncSetearBUS(dtCliente.Rows(0))
                    .NumeroDocumento = Me.txtNroDocumentoIdentidad.Text

                    .Apellidos = Me.txtApellidos.Text
                    .Nombres = Me.txtNombres.Text
                    .FechaModifica = FechaHoraServidor()
                    .UsuarioModifica = My.Settings.Usuario
                    If .fncModificarBUS > 0 Then
                        Notificar("Modificado con éxito")
                        btnCancelar.PerformClick()
                    End If
                End With
            End If
        Else

            'Dim ClienteValida As New clsClienteBUS
            'If ClienteValida.fncValidaDocumento(Me.cmbTipoDocumentoIdentidad.SelectedValue, Me.txtNroDocumentoIdentidad.Text) = True Then
            '    Notificar("Este número de " & Me.cmbTipoDocumentoIdentidad.Text & vbCrLf & " ya está en uso.", "ERROR")
            '    Exit Sub
            'End If

            Dim Empleado As New clsEmpleadoBUS(0, Me.txtApellidos.Text, Me.txtNombres.Text, Me.txtNroDocumentoIdentidad.Text, FechaHoraServidor, My.Settings.Usuario)
            If Empleado.fncRegistrarBUS() > 0 Then
                Notificar("Registrado con éxito")
                Me.btnCancelar.PerformClick()
            End If


        End If
    End Sub

    Private Sub btnExaminar_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub txtBusqueda_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            LlenaListaEmpleados(enmEstado.Activo, Me.txtBusqueda.Text)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        bolEsModificar = True
        Controles_En_Nuevo()
        If dgvEmpleado.CurrentRow IsNot Nothing Then
            Dim intIdEmpleado As Integer = Me.dgvEmpleado.CurrentRow.Cells("IdEmpleado").Value
            Me.tbcCliente.TabPages.Remove(tbpListar)
            Me.tbcCliente.TabPages.Remove(tbpNuevo)
            Me.tbcCliente.TabPages.Remove(tbpDatosExtra)
            Me.tbcCliente.TabPages.Insert(0, tbpNuevo)
            Me.tbcCliente.TabPages.Insert(1, tbpDatosExtra)
            LlenarDatosCliente(intIdEmpleado)

        End If
    End Sub

    Dim dtResultadoBase As New DataTable
    Private Sub btnGenerarHistorial_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerarHistorial.Click

        'Dim Empleado As New clsEmpleadoBUS
        'dtResultadoBase = Empleado.fncHistorialEmpleadoBUS(intIdEmpleadoGlobal, Me.dtpVentasDesde.Value, Me.dtpVentasHasta.Value)
        'If fncValidaDataTable(dtResultadoBase) Then
        '    fncSetDataTableInDGV(dtResultadoBase, dgvHistorialComisiones)
        'End If
        'Dim Cliente As New clsClienteBUS
        'dtResultadoBase = Cliente.fncReporteHistorialClienteBUS(intIdEmpleadoGlobal, Me.dtpVentasDesde.Value, Me.dtpVentasHasta.Value)
        'If fncValidaDataTable(dtResultadoBase) Then
        '    fncSetDataTableInDGV(dtResultadoBase, dgvHistorialComisiones)
        'End If
    End Sub

    Private Sub btnExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExcel.Click
        If fncValidaDataTable(dtResultadoBase) Then
            FncDataTable2Excel(dtResultadoBase, "Historial")
        End If
    End Sub


End Class