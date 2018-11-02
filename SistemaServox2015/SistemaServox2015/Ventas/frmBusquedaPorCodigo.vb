Imports SistemaServox2015BUS
Imports pryUtil.clsUtil
Imports System.Net

Public Class frmBusquedaPorCodigo

    Private Sub frmBusquedaPorCodigo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ActiveControl = Me.txtCodigo
    End Sub

    Function fncPreparaResultado(ByVal strCodigo As String, ByVal strDescripcion As String) As DataTable
        Dim Codigo As New clsCodUnidadVentaBUS
        Dim dtBuild As New DataTable
        dtBuild.Columns.Add("Codigo", GetType(String))
        dtBuild.Columns.Add("Descripcion", GetType(String))
        dtBuild.Columns.Add("Comprobante", GetType(String))
        dtBuild.Columns.Add("Fecha", GetType(String))
        dtBuild.Columns.Add("PrecioUnidad", GetType(Decimal))
        dtBuild.Columns.Add("Cantidad", GetType(Integer))
        dtBuild.Columns.Add("Producto", GetType(String))
        dtBuild.Columns.Add("Operacion", GetType(String))
        dtBuild.Columns.Add("OperacionDescripcion", GetType(String))
        dtBuild.Columns.Add("IdTipoComprobante", GetType(Integer))
        dtBuild.Columns.Add("IdOperacion", GetType(Integer))
        Dim dtResultado As DataTable = Codigo.fncBusquedaCodigoComprobanteBUS(strCodigo, strDescripcion)
        If fncValidaDataTable(dtResultado) Then
            For i As Integer = 0 To dtResultado.Rows.Count - 1
                dtBuild.Rows.Add()
                With dtBuild.Rows(i)
                    .Item("Codigo") = ObtenerValorCelda(dtResultado.Rows(i), "Codigo")
                    .Item("Descripcion") = ObtenerValorCelda(dtResultado.Rows(i), "Descripcion")
                    .Item("Comprobante") = ObtenerValorCelda(dtResultado.Rows(i), "Serie") & "-" & ObtenerValorCelda(dtResultado.Rows(i), "Numero")
                    .Item("Fecha") = ObtenerValorCelda(dtResultado.Rows(i), "Fecha")
                    .Item("PrecioUnidad") = ObtenerValorCelda(dtResultado.Rows(i), "Precio")
                    .Item("Cantidad") = ObtenerValorCelda(dtResultado.Rows(i), "Cantidad")
                    .Item("Producto") = ObtenerValorCelda(dtResultado.Rows(i), "PROdescripcion")
                    .Item("Operacion") = ObtenerValorCelda(dtResultado.Rows(i), "Operacion")
                    .Item("OperacionDescripcion") = ObtenerValorCelda(dtResultado.Rows(i), "OperacionDescripcion")
                    .Item("IdTipoComprobante") = ObtenerValorCelda(dtResultado.Rows(i), "IdTipoComprobante")
                    .Item("IdOperacion") = ObtenerValorCelda(dtResultado.Rows(i), "IdOperacion")
                End With
            Next
        End If

        Return dtBuild
    End Function

    Private Sub txtCodigo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodigo.TextChanged, txtDescripcion.TextChanged
        Dim dtBase As DataTable = fncPreparaResultado(Me.txtCodigo.Text, Me.txtDescripcion.Text)
        If fncValidaDataTable(dtBase) Then
            fncSetDataTableInDGV(dtBase, dgvComprobante)
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnVerOperacion_Click(sender As System.Object, e As System.EventArgs) Handles btnVerOperacion.Click
        If Me.dgvComprobante.Rows.Count > 0 AndAlso Me.dgvComprobante.CurrentRow IsNot Nothing Then

            Dim strOperacion As String = Me.dgvComprobante.CurrentRow.Cells("OperacionDescripcion").Value
            Dim intIdOperacion As Integer = fncForzarInteger(Me.dgvComprobante.CurrentRow.Cells("IdOperacion").Value)
            Dim intIdTipoComprobante As Integer = fncForzarInteger(Me.dgvComprobante.CurrentRow.Cells("IdTipoComprobante").Value)


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
End Class