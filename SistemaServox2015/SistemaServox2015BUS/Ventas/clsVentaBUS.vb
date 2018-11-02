Imports SistemaServox2015BD
Imports pryUtil.clsUtil

Public Class clsVentaBUS

    Inherits clsVentaBD

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
    Optional ByVal IdVenta As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdVenta _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(ByVal Registro As DataRow)
        Try
            IdVenta = ObtenerValorCelda(Registro, "IdVenta")
            IdModalidadPago = ObtenerValorCelda(Registro, "IdModalidadPago")
            IdTipoComprobante = ObtenerValorCelda(Registro, "IdTipoComprobante")
            Serie = ObtenerValorCelda(Registro, "Serie")
            Numero = ObtenerValorCelda(Registro, "Numero")
            Descripcion = ObtenerValorCelda(Registro, "Descripcion")
            Observacion = ObtenerValorCelda(Registro, "Observacion")
            IdCliente = ObtenerValorCelda(Registro, "IdCliente")
            Estado = ObtenerValorCelda(Registro, "Estado")
            FechaVenta = ObtenerValorCelda(Registro, "FechaVenta")
            FechaPago = ObtenerValorCelda(Registro, "FechaPago")
            IGV = ObtenerValorCelda(Registro, "IGV")
            Correlativo = ObtenerValorCelda(Registro, "Correlativo")
            FechaRegistra = ObtenerValorCelda(Registro, "FechaRegistra")
            FechaModifica = ObtenerValorCelda(Registro, "FechaModifica")
            UsuarioRegistra = ObtenerValorCelda(Registro, "UsuarioRegistra")
            UsuarioModifica = ObtenerValorCelda(Registro, "UsuarioModifica")
            IdTipoOperacion = ObtenerValorCelda(Registro, "IdTipoOperacion")
            EsBalance = ObtenerValorCelda(Registro, "EsBalance")
        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub

#End Region

#Region "Constructores"
    Public Sub New()

    End Sub

    Public Sub New(ByVal intIdVenta As Integer,
                ByVal intIdModalidadPago As Integer,
                ByVal intIdTipoComprobante As Integer,
                ByVal strSerie As String,
                ByVal strNumero As String,
                ByVal strDescripcion As String,
                ByVal strObservacion As String,
                ByVal intIdCliente As Integer,
                ByVal dateFechaVenta As Date,
                ByVal dateFechaPago As Date,
                ByVal decIGV As Decimal,
                ByVal strCorrelativo As String,
                ByVal dateFechaRegistra As Date,
                ByVal intUsuarioRegistra As Integer,
                ByVal intEsBalance As Integer)

        IdVenta = intIdVenta
        IdModalidadPago = intIdModalidadPago
        IdTipoComprobante = intIdTipoComprobante
        Serie = strSerie
        Numero = strNumero
        Descripcion = strDescripcion
        Observacion = strObservacion
        IdCliente = intIdCliente
        Estado = enmEstado.Activo
        FechaVenta = dateFechaVenta
        FechaPago = dateFechaPago
        IGV = decIGV
        Correlativo = fncCorrelativoVentaBUS(dateFechaVenta)
        FechaRegistra = dateFechaRegistra
        FechaModifica = dateFechaRegistra
        UsuarioRegistra = intUsuarioRegistra
        UsuarioModifica = intUsuarioRegistra
        IdTipoOperacion = enmTipoOperacion.Venta
        EsBalance = intEsBalance
    End Sub
#End Region

    Public Function fncCorrelativoVentaBUS( _
 ByVal FechaVenta As String _
 ) As Int64
        Dim rs As Object = Nothing
        Try
            rs = fncusp_srv_CorrelativoVentaBD(FechaVenta)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return Convert.ToInt64(rs)
    End Function

    Public Function fncValidaNumeroVentaBUS( _
     Optional Serie As String = "" _
     , Optional Numero As String = "" _
     , Optional IdTipoComprobante As Integer = -1 _
     ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_ValidaNumeroVentaBD( _
            Serie _
            , Numero _
            , IdTipoComprobante _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function






    Public Function fncVentasPorPeriodoBUS( _
  Optional Anio As Integer = -1 _
  , Optional Mes As Integer = -1 _
  , Optional Estado As String = "" _
  , Optional IdTipoComprobante As Integer = -1 _
  ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_Pln_VentasPorPeriodoBD( _
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



    Public Function fncVentasPorIdentificadorBUS( _
 Optional IdVenta As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_Pln_VentasPorIdentificadorBD( _
            IdVenta _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



    Public Function fncBusquedaVentasBUS( _
   Optional Serie As String = "" _
   , Optional Numero As String = "" _
   , Optional Identificacion As String = "" _
   , Optional RazonSocial As String = "" _
   , Optional IdTipoComprobante As Integer = -1 _
   ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_BusquedaVentasBD( _
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



    Public Function fncVentasEntreDosFechasBUS( _
 Optional FechaDesde As String = "1900-01-01" _
 , Optional FechaHasta As String = "1900-01-01" _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_VentasEntreDosFechasBD( _
            FechaDesde _
            , FechaHasta _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncGananciasEntreDosFechasBUS( _
 Optional FechaDesde As String = "1900-01-01" _
 , Optional FechaHasta As String = "1900-01-01" _
 , Optional ValorDolar As Double = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_GananciasEntreDosFechasBD( _
            FechaDesde _
            , FechaHasta _
            , ValorDolar _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function




    Public Function fncVentasPorIdentificador(ByVal intIdVenta As Integer) As DataTable()
        Dim DetalleVenta As New clsDetalleVentaBUS
        Dim dtCabecera As New DataTable
        Dim dtDetalle As New DataTable

        Dim dtVenta As DataTable = fncVentasPorIdentificadorBUS(intIdVenta)
        If fncValidaDataTable(dtVenta) Then
            dtCabecera = dtVenta.Clone
            dtCabecera.ImportRow(dtVenta.Rows(0))
            dtDetalle = DetalleVenta.fncListarDetallePorVentaBUS(intIdVenta)
        End If

        Return {dtCabecera, dtDetalle}
    End Function


    Public Function fncValidaVentaExistenteBUS( _
 Optional IdVenta As Integer = -1 _
 , Optional IdTipoComprobante As Integer = -1 _
 , Optional Serie As String = "" _
 , Optional Numero As String = "" _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_ValidaVentaExistenteBD( _
            IdVenta _
            , IdTipoComprobante _
            , Serie _
            , Numero _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncBuscarTop1ClienteBUS( _
 Optional DocumentoIdentidadCliente As String = "" _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_BuscarTop1ClienteBD( _
            DocumentoIdentidadCliente _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_SeriePorComprobanteYNumeroBUS( _
 IdTipoComprobante As Integer _
 , Serie As String _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_SeriePorComprobanteYNumeroBD( _
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

        Dim dtBase As DataTable = fncusp_SeriePorComprobanteYNumeroBUS(intIdTipoComprobante, strSerie)
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
    ''' <param name="intIdVentaActual"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fncVentasPorOrden(Optional ByVal intAnio As Integer = -1 _
                                        , Optional ByVal Mes As Integer = -1 _
                                        , Optional ByVal Estado As String = "" _
                                        , Optional ByVal intOrden As Integer = 1 _
                                        , Optional ByVal intIdVentaActual As Integer = 0 _
                                        , Optional ByVal intIdTipoComprobante As Integer = -1) As DataTable()
        Dim DetalleVenta As New clsDetalleVentaBUS
        Dim dtCabecera As New DataTable
        Dim dtDetalle As New DataTable
        Dim intIdVentaResultado As New Integer
        Dim dtVentasEnPeriodo As DataTable = fncVentasPorPeriodoBUS(intAnio, Mes, Estado, intIdTipoComprobante)
        If fncValidaDataTable(dtVentasEnPeriodo) Then
            dtCabecera = dtVentasEnPeriodo.Clone
            Select Case intOrden
                Case enmOrden.Primero
                    dtCabecera.ImportRow(dtVentasEnPeriodo.Rows(0))
                    intIdVentaResultado = ObtenerValorCelda(dtVentasEnPeriodo.Rows(0), "IdVenta")
                    dtDetalle = DetalleVenta.fncListarDetallePorVentaBUS(intIdVentaResultado)
                Case enmOrden.Atras
                    If intIdVentaActual = 0 Then
                        dtCabecera.ImportRow(dtVentasEnPeriodo.Rows(0))
                        intIdVentaResultado = ObtenerValorCelda(dtVentasEnPeriodo.Rows(0), "IdVenta")
                        dtDetalle = DetalleVenta.fncListarDetallePorVentaBUS(intIdVentaResultado)
                    Else
                        For i As Integer = 0 To dtVentasEnPeriodo.Rows.Count - 1
                            If ObtenerValorCelda(dtVentasEnPeriodo.Rows(i), "IdVenta") = intIdVentaActual Then
                                If i - 1 >= 0 Then
                                    dtCabecera.ImportRow(dtVentasEnPeriodo.Rows(i - 1))
                                    intIdVentaResultado = ObtenerValorCelda(dtVentasEnPeriodo.Rows(i - 1), "IdVenta")
                                    dtDetalle = DetalleVenta.fncListarDetallePorVentaBUS(intIdVentaResultado)
                                End If
                            End If
                        Next
                    End If

                Case enmOrden.Siguiente
                    If intIdVentaActual = 0 Then
                        dtCabecera.ImportRow(dtVentasEnPeriodo.Rows(dtVentasEnPeriodo.Rows.Count - 1))
                        intIdVentaResultado = ObtenerValorCelda(dtVentasEnPeriodo.Rows(dtVentasEnPeriodo.Rows.Count - 1), "IdVenta")
                        dtDetalle = DetalleVenta.fncListarDetallePorVentaBUS(intIdVentaResultado)
                    Else
                        For i As Integer = 0 To dtVentasEnPeriodo.Rows.Count - 1
                            If ObtenerValorCelda(dtVentasEnPeriodo.Rows(i), "IdVenta") = intIdVentaActual Then
                                If i + 1 <= dtVentasEnPeriodo.Rows.Count - 1 Then
                                    dtCabecera.ImportRow(dtVentasEnPeriodo.Rows(i + 1))
                                    intIdVentaResultado = ObtenerValorCelda(dtVentasEnPeriodo.Rows(i + 1), "IdVenta")
                                    dtDetalle = DetalleVenta.fncListarDetallePorVentaBUS(intIdVentaResultado)
                                End If
                            End If
                        Next
                    End If

                Case enmOrden.Ultimo
                    dtCabecera.ImportRow(dtVentasEnPeriodo.Rows(dtVentasEnPeriodo.Rows.Count - 1))
                    intIdVentaResultado = ObtenerValorCelda(dtVentasEnPeriodo.Rows(dtVentasEnPeriodo.Rows.Count - 1), "IdVenta")
                    dtDetalle = DetalleVenta.fncListarDetallePorVentaBUS(intIdVentaResultado)
            End Select
        End If

        'Dim ProformaVenta As New clsProformaVentaBUS
        'Dim dtProformaV As New DataTable
        'dtProformaV = ProformaVenta.fncusp_srv_ListarProformasPorVentaBUS(intIdVentaResultado)


        Return {dtCabecera, dtDetalle}

    End Function


End Class
