Imports SistemaServox2015BUS
Imports pryUtil.clsUtil
Imports System.Net

Public Class frmMantenimientoCodigosUnidad

    Public intIdVenta As Integer = -1
    Public intIdCompra As Integer = -1
    Public bolEsCodigosCompra As New Boolean
    Public intCantidadUnidad As New Integer
    Public dtProducto As New DataTable

    Public Sub ConstruyeProductos(ByVal dtDetalleProducto As DataTable)
        If fncValidaDataTable(dtDetalleProducto) Then
            Me.txtDescripcion.Items.Clear()
            SetComboBox(txtDescripcion, dtDetalleProducto, "Producto", "IdDetalle")
        End If
    End Sub


    Private Sub frmMantenimientoCodigosUnidad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ControlesIniciales()
    End Sub

    Sub ControlesIniciales()
        Me.txtCodigo.Enabled = False
        Me.txtDescripcion.Enabled = False
    End Sub

    Public Sub ListarCodigosBase()
        Dim Codigos As New clsCodUnidadVentaBUS
        Dim dtCodigos As DataTable = Codigos.fncListarCodigosPorDetalleBUS(intIdVenta, intIdCompra)
        fncSetDataTableInDGV(dtCodigos, dgvCodigoItem)

    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Me.txtCodigo.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.txtCodigo.Text = String.Empty
        ''Me.txtDescripcion.Text = String.Empty
        Me.txtIdCodigo.Text = 0
        'Me.txtMontoComision.Text = "0.00"
        'Me.txtIdEmpleado.Text = 0
        'Me.txtNombreEmpleado.Text = String.Empty
        Me.ActiveControl = txtCodigo




    End Sub

    Sub ControlesEnCompleto()
        Me.txtCodigo.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.txtIdCodigo.Text = 0
    End Sub
    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

        Dim strAlerta As String = "Alerta: " & vbCrLf
        Dim bolAlerta As New Boolean
        If Me.txtCodigo.Text.Trim.Length = 0 Then
            strAlerta &= "Debe ingresar un código válido." & vbCrLf
            bolAlerta = True
        ElseIf Me.txtIdCodigo.Text.Trim.Length = 0 Then
            strAlerta &= "La operación no puede completarse." & vbCrLf
            bolAlerta = True
        End If

        If dgvCodigoItem.Rows.Count > 1 Then
            For i As Integer = 0 To dgvCodigoItem.Rows.Count - 1
                Dim strCodigo As String = dgvCodigoItem.Rows(i).Cells("Codigo").Value
                Dim strIndex As String = dgvCodigoItem.Rows(i).Cells("Indice").Value
                If strCodigo = Me.txtCodigo.Text Then
                    strAlerta &= "Este código ya existe. Index : " & strIndex & vbCrLf
                    bolAlerta = True
                    Exit For
                End If
            Next
        End If

        Dim strDescripcion As String = Me.txtDescripcion.Text
        Dim intCantidadActual As New Integer
        If dgvCodigoItem.Rows.Count > 1 Then
            For i As Integer = 0 To dgvCodigoItem.Rows.Count - 1
                Dim strDescripcionGrid As String = dgvCodigoItem.Rows(i).Cells("Descripcion").Value
                If strDescripcion = strDescripcionGrid Then
                    intCantidadActual += 1
                End If
            Next
        End If


        Dim intCantidadPropioProducto As Integer = 0
        If fncValidaDataTable(dtProducto) Then
            For Each row In dtProducto.Rows
                If ObtenerValorCelda(row, "Producto") = strDescripcion Then
                    intCantidadPropioProducto = ObtenerValorCelda(row, "Cantidad")
                End If
            Next
        End If

        If intCantidadActual >= intCantidadPropioProducto Then
            strAlerta &= "No puede ingresar una cantidad de códigos superior a la cantidad de productos. Cantidad: " & intCantidadPropioProducto & vbCrLf
            bolAlerta = True
        End If

        If bolAlerta = True Then
            MsgBox(strAlerta, MsgBoxStyle.Critical)
            Exit Sub
        End If

        If CInt(Me.txtIdCodigo.Text) = 0 Then
            ' Nuevo
            Dim Codigo As New clsCodUnidadVentaBUS(0 _
                                                   , If(intIdVenta > 0, Me.txtDescripcion.SelectedValue, 0) _
                                                   , If(intIdCompra > 0, Me.txtDescripcion.SelectedValue, 0) _
                                                   , txtCodigo.Text _
                                                   , txtDescripcion.Text _
                                                   , FechaHoraServidor _
                                                   , My.Settings.IdUltimoUsuario _
                                                   , 0 _
                                                   , 0)
            If Codigo.fncRegistrarBUS() > 0 Then
                Notificar("Registrado con éxito", "SERVOX")
            End If
        Else
            ' Modifica
            Dim Codigo As New clsCodUnidadVentaBUS
            Dim dtCodigo As DataTable = Codigo.fncConsultarBUS(Me.txtIdCodigo.Text)
            If fncValidaDataTable(dtCodigo) Then
                Codigo.fncSetearBUS(dtCodigo.Rows(0))
                'Codigo.IdDetalleCompra = If(intIdCompra > 0, Me.txtDescripcion.ValueMember, 0)
                'Codigo.IdDetalleVenta = If(intIdVenta > 0, Me.txtDescripcion.ValueMember, 0)
                Codigo.Codigo = Me.txtCodigo.Text
                Codigo.Descripcion = Me.txtDescripcion.Text
                Codigo.IdEmpleado = DBNull.Value
                Codigo.MontoComision = 0
                Codigo.FechaRegistra = FechaHoraServidor()
                Codigo.UsuarioRegistra = My.Settings.IdUltimoUsuario
                If Codigo.fncModificarBUS() > 0 Then
                    Notificar("Modificado con éxito", "SERVOX")
                End If
            End If
        End If

        ListarCodigosBase()
        ControlesEnCompleto()
        Me.ActiveControl = btnNuevo
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If CInt(Me.txtIdCodigo.Text) = 0 Then
            Notificar("Este código aún no se ha registrado", "SERVOX")
        Else
            ' Modifica
            Dim Codigo As New clsCodUnidadVentaBUS
            Dim dtCodigo As DataTable = Codigo.fncConsultarBUS(Me.txtIdCodigo.Text)
            If fncValidaDataTable(dtCodigo) Then
                Codigo.fncSetearBUS(dtCodigo.Rows(0))
                Codigo.Estado = enmEstado.Inactivo
                If Codigo.fncModificarBUS() > 0 Then
                    Notificar("Desactivado con éxito", "SERVOX")
                End If
            End If

            ListarCodigosBase()
            ControlesEnCompleto()
        End If
    End Sub

    Private Sub dgvCodigoItem_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCodigoItem.CellClick
        If Me.dgvCodigoItem.CurrentRow IsNot Nothing Then
            Me.txtCodigo.Enabled = True
            Me.txtDescripcion.Enabled = True
            With Me.dgvCodigoItem.CurrentRow
                Me.txtCodigo.Text = .Cells("Codigo").Value
                Me.txtIdCodigo.Text = .Cells("IdCodigo").Value
                '' Me.txtDescripcion.Text = .Cells("Descripcion").Value
            End With
        End If
    End Sub

    'Private Sub btnBuscarEmpleado_Click(sender As System.Object, e As System.EventArgs)
    '    Dim ObjFrmHijo As New frmMantenimientoEmpleado
    '    'ObjFrmHijo.pFormularioPadrePTA = Me.Name
    '    'ObjFrmHijo.bolEsBusqueda = True
    '    'ObjFrmHijo.Owner = Me
    '    'ObjFrmHijo.ShowDialog()
    '    ObjFrmHijo.bolEnviar = True
    '    ObjFrmHijo.bolEsModificar = False
    '    If ObjFrmHijo.ShowDialog = Windows.Forms.DialogResult.OK Then


    '        With ObjFrmHijo.dgvEmpleado.CurrentRow
    '            ''    bolEsBusquedaAutomaticaCliente = False
    '            Me.txtIdEmpleado.Text = .Cells("IdEmpleado").Value
    '            Me.txtNombreEmpleado.Text = .Cells("Apellidos").Value + ", " + .Cells("Nombres").Value ' .Cells("Tipo").Value & " : " & .Cells("DocumentoIdentidad").Value

    '            ''   bolEsBusquedaAutomaticaCliente = True
    '            ''SeteaNodo(.Cells("IdPtaDependencia").Value)
    '        End With

    '        Me.ActiveControl = Me.txtMontoComision
    '    End If
    'End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub txtCodigo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.txtDescripcion
        End If
    End Sub

    Private Sub txtDescripcion_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.btnGuardar
        End If
    End Sub

    Private Sub txtMontoComision_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.btnGuardar.PerformClick()
        End If
    End Sub

    Private Sub txtDescripcion_KeyDown_1(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.btnGuardar
        End If
    End Sub
End Class