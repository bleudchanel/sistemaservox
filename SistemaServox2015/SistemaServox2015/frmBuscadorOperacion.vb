Imports SistemaServox2015BUS
Imports pryUtil.clsUtil
Imports System.Net

Public Class frmBuscadorOperacion
    Public bolEnviar As New Boolean
    Public bolEsVenta As Boolean = False
    Public bolEsSoloFactura As New Boolean
    Public intIdIdentificador As New Integer
    '20: Venta, 1: Proforma, 2: Garantía, 10: Compra con IGV, 11: Compra Sin IGV
    Public intIdTipoInterno As New Integer
    Public intIdEstadoProcesoProforma As Integer = -1

    Private Sub frmBuscadorOperacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarSerieNumero_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarSerieNumero.Click
        Me.dgvOperacion.Rows.Clear()

        If bolEsVenta = True Then
            Dim Venta As New clsVentaBUS
            Dim dtVenta As DataTable = Venta.fncBusquedaVentasBUS(String.Empty, Me.txtNumero.Text, , , If(bolEsSoloFactura = True, enmTipoComprobante.Factura, enmTipoComprobante.Boleta))
            If fncValidaDataTable(dtVenta) Then
                For Each row In dtVenta.Rows
                    Me.dgvOperacion.Rows.Add()
                    With Me.dgvOperacion.Rows(Me.dgvOperacion.Rows.Count - 1)
                        .Cells("IdOperacion").Value = ObtenerValorCelda(row, "IdVenta")
                        .Cells("Serie").Value = ObtenerValorCelda(row, "Serie")
                        .Cells("Numero").Value = ObtenerValorCelda(row, "Numero")
                        .Cells("Fecha").Value = CDate(ObtenerValorCelda(row, "FechaVenta")).ToString("dd/MM/yyyy")
                        .Cells("FechaRegistra").Value = CDate(ObtenerValorCelda(row, "FechaRegistra")).ToString("dd/MM/yyyy")
                        .Cells("IdentificadorPersona").Value = ObtenerValorCelda(row, "DocumentoIdentidad")
                        .Cells("Persona").Value = ObtenerValorCelda(row, "CLInombre")
                        .Cells("Descripcion").Value = ObtenerValorCelda(row, "Observacion")
                    End With
                Next
            End If
        ElseIf bolEsVenta = False Then

            If intIdIdentificador <> enmTipoInterno.Garantía And intIdIdentificador <> enmTipoInterno.Proforma And intIdIdentificador <> enmTipoInterno.Transporte Then

                Dim Compra As New clsCompraBUS

                Dim dtCompra As DataTable = Compra.fncBusquedaComprasBUS(String.Empty, Me.txtNumero.Text, , , intIdTipoInterno)
                If fncValidaDataTable(dtCompra) Then
                    For Each row In dtCompra.Rows
                        Me.dgvOperacion.Rows.Add()
                        With Me.dgvOperacion.Rows(Me.dgvOperacion.Rows.Count - 1)
                            .Cells("IdOperacion").Value = ObtenerValorCelda(row, "IdCompra")
                            .Cells("Serie").Value = ObtenerValorCelda(row, "Serie")
                            .Cells("Numero").Value = ObtenerValorCelda(row, "Numero")
                            .Cells("Fecha").Value = CDate(ObtenerValorCelda(row, "FechaCompra")).ToString("dd/MM/yyyy")
                            .Cells("FechaRegistra").Value = CDate(ObtenerValorCelda(row, "FechaRegistra")).ToString("dd/MM/yyyy")
                            .Cells("IdentificadorPersona").Value = ObtenerValorCelda(row, "DocumentoIdentidad")
                            .Cells("Persona").Value = ObtenerValorCelda(row, "PRVnombre")
                            .Cells("Descripcion").Value = ObtenerValorCelda(row, "Observacion")
                        End With
                    Next
                End If
            Else
                ' Proformas y Garantias - Transporte
                If intIdIdentificador = enmTipoInterno.Garantía Then
                    Dim Garantia As New clsGarantiaBUS
                    Dim dtGarantia As DataTable = Garantia.fncBusquedaGarantiasBUS(String.Empty, Me.txtNumero.Text, , , )
                    If fncValidaDataTable(dtGarantia) Then
                        For Each row In dtGarantia.Rows
                            Me.dgvOperacion.Rows.Add()
                            With Me.dgvOperacion.Rows(Me.dgvOperacion.Rows.Count - 1)
                                .Cells("IdOperacion").Value = ObtenerValorCelda(row, "IdGarantia")
                                .Cells("Serie").Value = ObtenerValorCelda(row, "Serie")
                                .Cells("Numero").Value = ObtenerValorCelda(row, "Numero")
                                .Cells("Fecha").Value = CDate(ObtenerValorCelda(row, "FechaGarantia")).ToString("dd/MM/yyyy")
                                .Cells("FechaRegistra").Value = CDate(ObtenerValorCelda(row, "FechaRegistra")).ToString("dd/MM/yyyy")
                                .Cells("IdentificadorPersona").Value = ObtenerValorCelda(row, "DocumentoIdentidad")
                                .Cells("Persona").Value = ObtenerValorCelda(row, "PRVnombre")
                                .Cells("Descripcion").Value = ObtenerValorCelda(row, "Observacion")
                            End With
                        Next
                    End If
                ElseIf intIdIdentificador = enmTipoInterno.Proforma Then
                    Dim Proforma As New clsProformaBUS
                    Dim dtProforma As DataTable = Proforma.fncBusquedaProformaBUS(String.Empty, Me.txtNumero.Text, , , , intIdEstadoProcesoProforma)
                    If fncValidaDataTable(dtProforma) Then
                        For Each row In dtProforma.Rows
                            Me.dgvOperacion.Rows.Add()
                            With Me.dgvOperacion.Rows(Me.dgvOperacion.Rows.Count - 1)
                                .Cells("IdOperacion").Value = ObtenerValorCelda(row, "IdProforma")
                                .Cells("Serie").Value = ObtenerValorCelda(row, "Serie")
                                .Cells("Numero").Value = ObtenerValorCelda(row, "Numero")
                                .Cells("Fecha").Value = CDate(ObtenerValorCelda(row, "FechaVenta")).ToString("dd/MM/yyyy")
                                .Cells("FechaRegistra").Value = CDate(ObtenerValorCelda(row, "FechaRegistra")).ToString("dd/MM/yyyy")
                                .Cells("IdentificadorPersona").Value = ObtenerValorCelda(row, "DocumentoIdentidad")
                                .Cells("Persona").Value = ObtenerValorCelda(row, "CLInombre")
                                .Cells("Descripcion").Value = ObtenerValorCelda(row, "Observacion")
                            End With
                        Next
                    End If
                ElseIf intIdIdentificador = enmTipoInterno.Transporte Then
                    Dim Transporte As New clsTransporteBUS
                    Dim dtTransporte As DataTable = Transporte.fncBusquedaTransporteBUS(String.Empty, Me.txtNumero.Text, , )
                    If fncValidaDataTable(dtTransporte) Then
                        For Each row In dtTransporte.Rows
                            Me.dgvOperacion.Rows.Add()
                            With Me.dgvOperacion.Rows(Me.dgvOperacion.Rows.Count - 1)
                                .Cells("IdOperacion").Value = ObtenerValorCelda(row, "IdTransporte")
                                .Cells("Serie").Value = ObtenerValorCelda(row, "Serie")
                                .Cells("Numero").Value = ObtenerValorCelda(row, "Numero")
                                .Cells("Fecha").Value = CDate(ObtenerValorCelda(row, "FechaTransporte")).ToString("dd/MM/yyyy")
                                .Cells("FechaRegistra").Value = CDate(ObtenerValorCelda(row, "FechaRegistra")).ToString("dd/MM/yyyy")
                                .Cells("IdentificadorPersona").Value = ObtenerValorCelda(row, "DocumentoIdentidad")
                                .Cells("Persona").Value = ObtenerValorCelda(row, "PRVnombre")
                                .Cells("Descripcion").Value = ObtenerValorCelda(row, "Descripcion")
                            End With
                        Next
                    End If
                End If
            End If


         
        End If

        
    End Sub

    Private Sub btnBuscarPersona_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarPersona.Click
        Me.dgvOperacion.Rows.Clear()

        If bolEsVenta = True Then
            Dim Venta As New clsVentaBUS
            Dim dtVenta As DataTable = Venta.fncBusquedaVentasBUS(, , Me.txtNumeroIdentificacion.Text, String.Empty)
            If fncValidaDataTable(dtVenta) Then
                For Each row In dtVenta.Rows
                    Me.dgvOperacion.Rows.Add()
                    With Me.dgvOperacion.Rows(Me.dgvOperacion.Rows.Count - 1)
                        .Cells("IdOperacion").Value = ObtenerValorCelda(row, "IdVenta")
                        .Cells("Serie").Value = ObtenerValorCelda(row, "Serie")
                        .Cells("Numero").Value = ObtenerValorCelda(row, "Numero")
                        .Cells("Fecha").Value = ObtenerValorCelda(row, "FechaVenta")
                        .Cells("FechaRegistra").Value = ObtenerValorCelda(row, "FechaRegistra")
                        .Cells("IdentificadorPersona").Value = ObtenerValorCelda(row, "DocumentoIdentidad")
                        .Cells("Persona").Value = ObtenerValorCelda(row, "CLInombre")
                        .Cells("Descripcion").Value = ObtenerValorCelda(row, "Observacion")
                    End With
                Next
            End If
        ElseIf bolEsVenta = False Then
            If intIdIdentificador <> enmTipoInterno.Garantía And intIdIdentificador <> enmTipoInterno.Proforma And intIdIdentificador <> enmTipoInterno.Transporte Then
                Dim Compra As New clsCompraBUS
                Dim dtCompra As DataTable = Compra.fncBusquedaComprasBUS(, , Me.txtNumeroIdentificacion.Text, String.Empty, intIdTipoInterno)
                If fncValidaDataTable(dtCompra) Then
                    For Each row In dtCompra.Rows
                        Me.dgvOperacion.Rows.Add()
                        With Me.dgvOperacion.Rows(Me.dgvOperacion.Rows.Count - 1)
                            .Cells("IdOperacion").Value = ObtenerValorCelda(row, "IdCompra")
                            .Cells("Serie").Value = ObtenerValorCelda(row, "Serie")
                            .Cells("Numero").Value = ObtenerValorCelda(row, "Numero")
                            .Cells("Fecha").Value = ObtenerValorCelda(row, "FechaCompra")
                            .Cells("FechaRegistra").Value = ObtenerValorCelda(row, "FechaRegistra")
                            .Cells("IdentificadorPersona").Value = ObtenerValorCelda(row, "DocumentoIdentidad")
                            .Cells("Persona").Value = ObtenerValorCelda(row, "PRVnombre")
                            .Cells("Descripcion").Value = ObtenerValorCelda(row, "Observacion")
                        End With
                    Next
                End If
            Else
                ' Proformas y Garantias
                If intIdIdentificador = enmTipoInterno.Garantía Then
                    Dim Garantia As New clsGarantiaBUS
                    Dim dtGarantia As DataTable = Garantia.fncBusquedaGarantiasBUS(, , Me.txtNumeroIdentificacion.Text, String.Empty)
                    If fncValidaDataTable(dtGarantia) Then
                        For Each row In dtGarantia.Rows
                            Me.dgvOperacion.Rows.Add()
                            With Me.dgvOperacion.Rows(Me.dgvOperacion.Rows.Count - 1)
                                .Cells("IdOperacion").Value = ObtenerValorCelda(row, "IdGarantia")
                                .Cells("Serie").Value = ObtenerValorCelda(row, "Serie")
                                .Cells("Numero").Value = ObtenerValorCelda(row, "Numero")
                                .Cells("Fecha").Value = CDate(ObtenerValorCelda(row, "FechaGarantia")).ToString("dd/MM/yyyy")
                                .Cells("FechaRegistra").Value = CDate(ObtenerValorCelda(row, "FechaRegistra")).ToString("dd/MM/yyyy")
                                .Cells("IdentificadorPersona").Value = ObtenerValorCelda(row, "DocumentoIdentidad")
                                .Cells("Persona").Value = ObtenerValorCelda(row, "PRVnombre")
                                .Cells("Descripcion").Value = ObtenerValorCelda(row, "Observacion")
                            End With
                        Next
                    End If
                ElseIf intIdIdentificador = enmTipoInterno.Proforma Then
                    Dim Proforma As New clsProformaBUS
                    Dim dtProforma As DataTable = Proforma.fncBusquedaProformaBUS(, , Me.txtNumeroIdentificacion.Text, String.Empty, intIdEstadoProcesoProforma)
                    If fncValidaDataTable(dtProforma) Then
                        For Each row In dtProforma.Rows
                            Me.dgvOperacion.Rows.Add()
                            With Me.dgvOperacion.Rows(Me.dgvOperacion.Rows.Count - 1)
                                .Cells("IdOperacion").Value = ObtenerValorCelda(row, "IdProforma")
                                .Cells("Serie").Value = ObtenerValorCelda(row, "Serie")
                                .Cells("Numero").Value = ObtenerValorCelda(row, "Numero")
                                .Cells("Fecha").Value = CDate(ObtenerValorCelda(row, "FechaVenta")).ToString("dd/MM/yyyy")
                                .Cells("FechaRegistra").Value = CDate(ObtenerValorCelda(row, "FechaRegistra")).ToString("dd/MM/yyyy")
                                .Cells("IdentificadorPersona").Value = ObtenerValorCelda(row, "DocumentoIdentidad")
                                .Cells("Persona").Value = ObtenerValorCelda(row, "CLInombre")
                                .Cells("Descripcion").Value = ObtenerValorCelda(row, "Observacion")
                            End With
                        Next
                    End If
                ElseIf intIdIdentificador = enmTipoInterno.Transporte Then
                    Dim Transporte As New clsTransporteBUS
                    Dim dtTransporte As DataTable = Transporte.fncBusquedaTransporteBUS(, , Me.txtNumeroIdentificacion.Text, String.Empty)
                    If fncValidaDataTable(dtTransporte) Then
                        For Each row In dtTransporte.Rows
                            Me.dgvOperacion.Rows.Add()
                            With Me.dgvOperacion.Rows(Me.dgvOperacion.Rows.Count - 1)
                                .Cells("IdOperacion").Value = ObtenerValorCelda(row, "IdTransporte")
                                .Cells("Serie").Value = ObtenerValorCelda(row, "Serie")
                                .Cells("Numero").Value = ObtenerValorCelda(row, "Numero")
                                .Cells("Fecha").Value = CDate(ObtenerValorCelda(row, "FechaTransporte")).ToString("dd/MM/yyyy")
                                .Cells("FechaRegistra").Value = CDate(ObtenerValorCelda(row, "FechaRegistra")).ToString("dd/MM/yyyy")
                                .Cells("IdentificadorPersona").Value = ObtenerValorCelda(row, "DocumentoIdentidad")
                                .Cells("Persona").Value = ObtenerValorCelda(row, "PRVnombre")
                                .Cells("Descripcion").Value = ObtenerValorCelda(row, "Descripcion")
                            End With
                        Next
                    End If
                End If

            End If
            End If
            


        
    End Sub

    Private Sub dgvOperacion_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOperacion.CellClick
        If Me.dgvOperacion.CurrentRow IsNot Nothing AndAlso dgvOperacion.Rows.Count > 0 Then
            Me.txtIdOperacion.Text = Me.dgvOperacion.CurrentRow.Cells("IdOperacion").Value
            Me.txtDescripcionOperacion.Text = Me.dgvOperacion.CurrentRow.Cells("Serie").Value & "-" & Me.dgvOperacion.CurrentRow.Cells("Numero").Value & " || P: " & _
            Me.dgvOperacion.CurrentRow.Cells("Persona").Value
        End If

    End Sub

    Private Sub btnSeleccionar_Click(sender As System.Object, e As System.EventArgs) Handles btnSeleccionar.Click
        If Me.dgvOperacion.Rows.Count > 0 And dgvOperacion.CurrentRow IsNot Nothing Then
            Me.txtIdOperacion.Text = Me.dgvOperacion.CurrentRow.Cells("IdOperacion").Value
            Me.txtDescripcionOperacion.Text = Me.dgvOperacion.CurrentRow.Cells("Serie").Value & "-" & Me.dgvOperacion.CurrentRow.Cells("Numero").Value & " || P: " & _
            Me.dgvOperacion.CurrentRow.Cells("Persona").Value
            If bolEnviar Then
                Me.DialogResult = Windows.Forms.DialogResult.OK

                '   MsgBox(dgvResultado.Rows.Count)

            End If
        End If
    End Sub

    Private Sub dgvOperacion_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOperacion.CellDoubleClick

        If Me.dgvOperacion.CurrentRow IsNot Nothing AndAlso Me.dgvOperacion.Rows.Count > 0 Then
            Me.txtIdOperacion.Text = Me.dgvOperacion.CurrentRow.Cells("IdOperacion").Value
            Me.txtDescripcionOperacion.Text = Me.dgvOperacion.CurrentRow.Cells("Serie").Value & "-" & Me.dgvOperacion.CurrentRow.Cells("Numero").Value & " || P: " & _
            Me.dgvOperacion.CurrentRow.Cells("Persona").Value
            Me.btnSeleccionar.PerformClick()
        End If


    End Sub

    Private Sub txtNumeroIdentificacion_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumeroIdentificacion.TextChanged
        Me.btnBuscarPersona.PerformClick()

    End Sub

    Private Sub txtRazonSocial_TextChanged(sender As System.Object, e As System.EventArgs)
        Me.btnBuscarPersona.PerformClick()
    End Sub

    Private Sub txtSerie_TextChanged(sender As System.Object, e As System.EventArgs)
        Me.btnBuscarSerieNumero.PerformClick()

    End Sub

    Private Sub txtNumero_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumero.TextChanged
        Me.btnBuscarSerieNumero.PerformClick()
    End Sub

    Private Sub txtNumero_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNumero.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.dgvOperacion.CurrentRow IsNot Nothing AndAlso Me.dgvOperacion.Rows.Count > 0 Then
                Me.txtIdOperacion.Text = Me.dgvOperacion.CurrentRow.Cells("IdOperacion").Value
                Me.txtDescripcionOperacion.Text = Me.dgvOperacion.CurrentRow.Cells("Serie").Value & "-" & Me.dgvOperacion.CurrentRow.Cells("Numero").Value & " || P: " & _
                Me.dgvOperacion.CurrentRow.Cells("Persona").Value
                Me.btnSeleccionar.PerformClick()
            End If
            
        End If
    End Sub

    Private Sub txtNumeroIdentificacion_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNumeroIdentificacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.dgvOperacion.CurrentRow IsNot Nothing AndAlso Me.dgvOperacion.Rows.Count > 0 Then
                Me.txtIdOperacion.Text = Me.dgvOperacion.CurrentRow.Cells("IdOperacion").Value
                Me.txtDescripcionOperacion.Text = Me.dgvOperacion.CurrentRow.Cells("Serie").Value & "-" & Me.dgvOperacion.CurrentRow.Cells("Numero").Value & " || P: " & _
                Me.dgvOperacion.CurrentRow.Cells("Persona").Value
                Me.btnSeleccionar.PerformClick()
            End If

        End If
    End Sub
End Class