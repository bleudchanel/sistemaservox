Imports SistemaServox2015BD
Imports pryUtil.clsUtil

Public Class clsGarantiaBUS
    Inherits clsGarantiaBD

#Region "Mantenimiento Básico"
    Function fncRegistrarBUS() As Integer
        Dim rs As Integer = -1
        Try
            Return fncRegistrarBD()
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBUS() As Integer
        Dim rs As Integer = -1
        Try
            Return fncModificarBD()
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBUS() As Integer
        Dim rs As Integer = -1
        Try
            Return fncEliminarBD()
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBUS( _
    Optional IdGarantia As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdGarantia _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(Registro As DataRow)
        Try
            IdGarantia = ObtenerValorCelda(Registro, "IdGarantia")
            IdModalidadPago = ObtenerValorCelda(Registro, "IdModalidadPago")
            IdTipoComprobante = ObtenerValorCelda(Registro, "IdTipoComprobante")
            Serie = ObtenerValorCelda(Registro, "Serie")
            Numero = ObtenerValorCelda(Registro, "Numero")
            Descripcion = ObtenerValorCelda(Registro, "Descripcion")
            Observacion = ObtenerValorCelda(Registro, "Observacion")
            IdProveedor = ObtenerValorCelda(Registro, "IdProveedor")
            Estado = ObtenerValorCelda(Registro, "Estado")
            FechaGarantia = ObtenerValorCelda(Registro, "FechaGarantia")
            FechaPago = ObtenerValorCelda(Registro, "FechaPago")
            IGV = ObtenerValorCelda(Registro, "IGV")
            Correlativo = ObtenerValorCelda(Registro, "Correlativo")
            FechaRegistra = ObtenerValorCelda(Registro, "FechaRegistra")
            FechaModifica = ObtenerValorCelda(Registro, "FechaModifica")
            UsuarioRegistra = ObtenerValorCelda(Registro, "UsuarioRegistra")
            UsuarioModifica = ObtenerValorCelda(Registro, "UsuarioModifica")
            IdTipoOperacion = ObtenerValorCelda(Registro, "IdTipoOperacion")
            EstadoProceso = ObtenerValorCelda(Registro, "EstadoProceso")
        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub
#End Region



#Region "Constructores"
    Public Sub New()

    End Sub

    Public Sub New(ByVal intIdGarantia As Integer,
                ByVal intIdModalidadPago As Integer,
                ByVal intIdTipoComprobante As Integer,
                ByVal strSerie As String,
                ByVal strNumero As String,
                ByVal strDescripcion As String,
                ByVal strObservacion As String,
                ByVal intIdProveedor As Integer,
                ByVal dateFechaGarantia As Date,
                ByVal dateFechaPago As Date,
                ByVal decIGV As Decimal,
                ByVal strCorrelativo As String,
                ByVal dateFechaRegistra As Date,
                ByVal intUsuarioRegistra As Integer,
                ByVal intEstadoGarantia As Integer)

        IdGarantia = intIdGarantia
        IdModalidadPago = intIdModalidadPago
        IdTipoComprobante = intIdTipoComprobante
        Serie = strSerie
        Numero = strNumero
        Descripcion = strDescripcion
        Observacion = strObservacion
        IdProveedor = intIdProveedor
        Estado = enmEstado.Activo
        FechaGarantia = dateFechaGarantia
        FechaPago = dateFechaPago
        IGV = decIGV
        Correlativo = fncCorrelativoGarantiaBUS(dateFechaGarantia)
        FechaRegistra = dateFechaRegistra
        FechaModifica = dateFechaRegistra
        UsuarioRegistra = intUsuarioRegistra
        UsuarioModifica = intUsuarioRegistra
        IdTipoOperacion = enmTipoOperacion.Venta
        EstadoProceso = intEstadoGarantia
    End Sub
#End Region

    Public Function fncCorrelativoGarantiaBUS( _
 FechaGarantia As String _
 ) As Object
        Dim rs As Object = Nothing
        Try
            rs = fncusp_srv_CorrelativoGarantiaBD(FechaGarantia)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncValidaNumeroGarantiaBUS( _
 Optional Serie As String = "" _
 , Optional Numero As String = "" _
 , Optional IdTipoComprobante As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_ValidaNumeroGarantiaBD( _
            Serie _
            , Numero _
            , IdTipoComprobante _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncGarantiasPorPeriodoBUS( _
 Optional Anio As Integer = -1 _
 , Optional Mes As Integer = -1 _
 , Optional Estado As String = "" _
 , Optional IdTipoComprobante As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_GarantiasPorPeriodoBD( _
            Anio _
            , Mes _
            , Estado _
            , IdTipoComprobante _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncGarantiasPorIdentificadorBUS( _
Optional IdGarantia As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_GarantiasPorIdentificadorBD( _
            IdGarantia _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncBusquedaGarantiasBUS( _
 Optional Serie As String = "" _
 , Optional Numero As String = "" _
 , Optional Identificacion As String = "" _
 , Optional RazonSocial As String = "" _
 , Optional IdTipoComprobante As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_BusquedaGarantiasBD( _
            Serie _
            , Numero _
            , Identificacion _
            , RazonSocial _
            , IdTipoComprobante _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncGarantiasPorIdentificador(ByVal intIdGarantia As Integer) As DataTable()
        Dim DetalleGarantia As New clsDetalleGarantiaBUS
        Dim dtCabecera As New DataTable
        Dim dtDetalle As New DataTable

        Dim dtVenta As DataTable = fncGarantiasPorIdentificadorBUS(intIdGarantia)
        If fncValidaDataTable(dtVenta) Then
            dtCabecera = dtVenta.Clone
            dtCabecera.ImportRow(dtVenta.Rows(0))
            dtDetalle = DetalleGarantia.fncListarDetallePorGarantiaBUS(intIdGarantia)
        End If

        Return {dtCabecera, dtDetalle}
    End Function

    Public Function fncValidaGarantiaExistenteBUS( _
Optional IdGarantia As Integer = -1 _
, Optional IdTipoComprobante As Integer = -1 _
, Optional Serie As String = "" _
, Optional Numero As String = "" _
) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ValidaGarantiaExistenteBD( _
            IdGarantia _
            , IdTipoComprobante _
            , Serie _
            , Numero _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncSeriePorComprobanteYNumeroGarantiaBUS( _
 IdTipoComprobante As Integer _
 , Serie As String _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_SeriePorComprobanteYNumeroGarantiaBD( _
            IdTipoComprobante _
            , Serie _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs

    End Function

    Public Function fncRetornaNumeroSiguientePorComprobanteYSerie(ByVal intIdTipoComprobante As Integer, ByVal strSerie As String) As String
        Dim strBase As String = "00000001"

        Dim dtBase As DataTable = fncSeriePorComprobanteYNumeroGarantiaBUS(intIdTipoComprobante, strSerie)
        If fncValidaDataTable(dtBase) Then

            Dim intNumeroActual As Long = fncForzarDecimal(ObtenerValorCelda(dtBase.Rows(0), "Numero"))
            intNumeroActual += 1

            Select Case intNumeroActual.ToString.Length
                Case 1
                    strBase = "0000000" & intNumeroActual.ToString
                Case 2
                    strBase = "000000" & intNumeroActual.ToString
                Case 3
                    strBase = "00000" & intNumeroActual.ToString
                Case 4
                    strBase = "0000" & intNumeroActual.ToString
                Case 5
                    strBase = "000" & intNumeroActual.ToString
                Case 6
                    strBase = "00" & intNumeroActual.ToString
                Case 7
                    strBase = "0" & intNumeroActual.ToString
                Case 8
                    strBase = intNumeroActual
            End Select

        End If

        Return strBase
    End Function



    ''' <summary>
    ''' Cabecera y Detalle por Buscador
    ''' </summary>
    ''' <param name="intAnio"></param>
    ''' <param name="Mes"></param>
    ''' <param name="Estado"></param>
    ''' <param name="intOrden"></param>
    ''' <param name="intIdGarantiaActual"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fncGarantiasPorOrden(Optional ByVal intAnio As Integer = -1 _
                                        , Optional ByVal Mes As Integer = -1 _
                                        , Optional ByVal Estado As String = "" _
                                        , Optional ByVal intOrden As Integer = 1 _
                                        , Optional ByVal intIdGarantiaActual As Integer = 0 _
                                        , Optional ByVal intIdTipoComprobante As Integer = -1) As DataTable()
        Dim DetalleGarantia As New clsDetalleGarantiaBUS
        Dim dtCabecera As New DataTable
        Dim dtDetalle As New DataTable
        Dim intIdVentaResultado As New Integer
        Dim dtVentasEnPeriodo As DataTable = fncGarantiasPorPeriodoBUS(intAnio, Mes, Estado, intIdTipoComprobante)
        If fncValidaDataTable(dtVentasEnPeriodo) Then
            dtCabecera = dtVentasEnPeriodo.Clone
            Select Case intOrden
                Case enmOrden.Primero
                    dtCabecera.ImportRow(dtVentasEnPeriodo.Rows(0))
                    intIdVentaResultado = ObtenerValorCelda(dtVentasEnPeriodo.Rows(0), "IdGarantia")
                    dtDetalle = DetalleGarantia.fncListarDetallePorGarantiaBUS(intIdVentaResultado)
                Case enmOrden.Atras
                    If intIdGarantiaActual = 0 Then
                        dtCabecera.ImportRow(dtVentasEnPeriodo.Rows(0))
                        intIdVentaResultado = ObtenerValorCelda(dtVentasEnPeriodo.Rows(0), "IdGarantia")
                        dtDetalle = DetalleGarantia.fncListarDetallePorGarantiaBUS(intIdVentaResultado)
                    Else
                        For i As Integer = 0 To dtVentasEnPeriodo.Rows.Count - 1
                            If ObtenerValorCelda(dtVentasEnPeriodo.Rows(i), "IdGarantia") = intIdGarantiaActual Then
                                If i - 1 >= 0 Then
                                    dtCabecera.ImportRow(dtVentasEnPeriodo.Rows(i - 1))
                                    intIdVentaResultado = ObtenerValorCelda(dtVentasEnPeriodo.Rows(i - 1), "IdGarantia")
                                    dtDetalle = DetalleGarantia.fncListarDetallePorGarantiaBUS(intIdVentaResultado)
                                End If
                            End If
                        Next
                    End If

                Case enmOrden.Siguiente
                    If intIdGarantiaActual = 0 Then
                        dtCabecera.ImportRow(dtVentasEnPeriodo.Rows(dtVentasEnPeriodo.Rows.Count - 1))
                        intIdVentaResultado = ObtenerValorCelda(dtVentasEnPeriodo.Rows(dtVentasEnPeriodo.Rows.Count - 1), "IdGarantia")
                        dtDetalle = DetalleGarantia.fncListarDetallePorGarantiaBUS(intIdVentaResultado)
                    Else
                        For i As Integer = 0 To dtVentasEnPeriodo.Rows.Count - 1
                            If ObtenerValorCelda(dtVentasEnPeriodo.Rows(i), "IdGarantia") = intIdGarantiaActual Then
                                If i + 1 <= dtVentasEnPeriodo.Rows.Count - 1 Then
                                    dtCabecera.ImportRow(dtVentasEnPeriodo.Rows(i + 1))
                                    intIdVentaResultado = ObtenerValorCelda(dtVentasEnPeriodo.Rows(i + 1), "IdGarantia")
                                    dtDetalle = DetalleGarantia.fncListarDetallePorGarantiaBUS(intIdVentaResultado)
                                End If
                            End If
                        Next
                    End If

                Case enmOrden.Ultimo
                    dtCabecera.ImportRow(dtVentasEnPeriodo.Rows(dtVentasEnPeriodo.Rows.Count - 1))
                    intIdVentaResultado = ObtenerValorCelda(dtVentasEnPeriodo.Rows(dtVentasEnPeriodo.Rows.Count - 1), "IdGarantia")
                    dtDetalle = DetalleGarantia.fncListarDetallePorGarantiaBUS(intIdVentaResultado)
            End Select
        End If

        Return {dtCabecera, dtDetalle}

    End Function


End Class
