Imports SistemaServox2015BD
Imports pryUtil.clsUtil

Public Class clsTransporteBUS
    Inherits clsTransporteBD

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
    Optional IdTransporte As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdTransporte _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(Registro As DataRow)
        Try
            IdTransporte = ObtenerValorCelda(Registro, "IdTransporte")
            IdModalidadPago = ObtenerValorCelda(Registro, "IdModalidadPago")
            IdTipoComprobante = ObtenerValorCelda(Registro, "IdTipoComprobante")
            Serie = ObtenerValorCelda(Registro, "Serie")
            Numero = ObtenerValorCelda(Registro, "Numero")
            Descripcion = ObtenerValorCelda(Registro, "Descripcion")
            Observacion = ObtenerValorCelda(Registro, "Observacion")
            IdProveedor = ObtenerValorCelda(Registro, "IdProveedor")
            Estado = ObtenerValorCelda(Registro, "Estado")
            FechaTransporte = ObtenerValorCelda(Registro, "FechaTransporte")
            FechaPago = ObtenerValorCelda(Registro, "FechaPago")
            IGV = ObtenerValorCelda(Registro, "IGV")
            Correlativo = ObtenerValorCelda(Registro, "Correlativo")
            FechaRegistra = ObtenerValorCelda(Registro, "FechaRegistra")
            FechaModifica = ObtenerValorCelda(Registro, "FechaModifica")
            UsuarioRegistra = ObtenerValorCelda(Registro, "UsuarioRegistra")
            UsuarioModifica = ObtenerValorCelda(Registro, "UsuarioModifica")
            IdTipoOperacion = ObtenerValorCelda(Registro, "IdTipoOperacion")
            EstadoProceso = ObtenerValorCelda(Registro, "EstadoProceso")
            MontoTransporte = ObtenerValorCelda(Registro, "MontoTransporte")
        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub


#End Region

#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New(intIdTransporte As Integer,
                intIdTipoComprobante As Integer,
                strSerie As String,
                strNumero As String,
                strDescripcion As String,
                strObservacion As String,
                intIdProveedor As Integer,
                dateFechaTransporte As Date,
                dateFechaPago As Date,
                decIGV As Decimal,
                dateFechaRegistra As Date,
                intUsuarioRegistra As Integer,
                decMontoTransporte As Decimal)

        IdTransporte = intIdTransporte
        IdModalidadPago = enmModalidadPago.Contado
        IdTipoComprobante = intIdTipoComprobante
        Serie = strSerie
        Numero = strNumero
        Descripcion = strDescripcion
        Observacion = strObservacion
        IdProveedor = intIdProveedor
        Estado = enmEstado.Activo
        FechaTransporte = dateFechaTransporte
        FechaPago = dateFechaPago
        IGV = decIGV
        Correlativo = fncCorrelativoCompraBUS(dateFechaTransporte.Date)
        FechaRegistra = dateFechaRegistra
        FechaModifica = dateFechaRegistra
        UsuarioRegistra = intUsuarioRegistra
        UsuarioModifica = intUsuarioRegistra
        MontoTransporte = decMontoTransporte

    End Sub

#End Region


    Public Function fncValidaNumeroTransporteBUS( _
 Optional Serie As String = "" _
 , Optional Numero As String = "" _
 , Optional IdProveedor As Integer = -1 _
 , Optional IdTipoComprobante As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_ValidaNumeroTransporteBD( _
            Serie _
            , Numero _
            , IdProveedor _
            , IdTipoComprobante _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncCorrelativoCompraBUS( _
  ByVal FechaCompra As String _
  ) As Int64
        Dim rs As Object = Nothing
        Try
            rs = fncusp_srv_CorrelativoTransporteBD(FechaCompra)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return Convert.ToInt64(rs)
    End Function


    Public Function fncValidaTransporteExistenteBUS( _
 Optional IdTransporte As Integer = -1 _
 , Optional IdTipoComprobante As Integer = -1 _
 , Optional Serie As String = "" _
 , Optional Numero As String = "" _
 , Optional IdProveedor As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_ValidaTransporteExistenteBD( _
            IdTransporte _
            , IdTipoComprobante _
            , Serie _
            , Numero _
            , IdProveedor _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncTransportePorIdentificadorBUS( _
     Optional IdTransporte As Integer = -1 _
     , Optional IdCompra As Integer = -1 _
     ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_Pln_TransportePorIdentificadorBD( _
            IdTransporte _
            , IdCompra _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function





    Public Function fncTransportePorIdentificador(Optional ByVal intIdTransporte As Integer = -1 _
                                                  , Optional ByVal intIdCompra As Integer = -1) As DataTable()
        Dim dtCabecera As New DataTable


        Dim dtCompra As DataTable = fncTransportePorIdentificadorBUS(intIdTransporte, intIdCompra)
        If fncValidaDataTable(dtCompra) Then
            dtCabecera = dtCompra.Clone
            dtCabecera.ImportRow(dtCompra.Rows(0))

        End If

        Dim dtTransporte As New DataTable
        Dim RegularCost As New clsRegularCostBUS


        Return {dtCabecera}
    End Function


    Public Function fncTransportePorPeriodoBUS( _
 Optional Anio As Integer = -1 _
 , Optional Mes As Integer = -1 _
 , Optional Estado As String = "" _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_Pln_TransportePorPeriodoBD( _
            Anio _
            , Mes _
            , Estado _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncBusquedaTransporteBUS( _
 Optional Serie As String = "" _
 , Optional Numero As String = "" _
 , Optional Identificacion As String = "" _
 , Optional RazonSocial As String = "" _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_BusquedaTransporteBD( _
            Serie _
            , Numero _
            , Identificacion _
            , RazonSocial _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



    ''' <summary>
    ''' Cabecera y Detalle por Buscador
    ''' </summary>
    ''' <param name="intAnio"></param>
    ''' <param name="Mes"></param>
    ''' <param name="Estado"></param>
    ''' <param name="intOrden"></param>
    ''' <param name="intIdTransporteActual"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fncTransportesPorOrden(Optional ByVal intAnio As Integer = -1 _
                                        , Optional ByVal Mes As Integer = -1 _
                                        , Optional ByVal Estado As String = "" _
                                        , Optional ByVal intOrden As Integer = 1 _
                                        , Optional ByVal intIdTransporteActual As Integer = 0) As DataTable()
        Dim DetalleCompra As New clsDetalleCompraBUS
        Dim dtCabecera As New DataTable
        Dim dtDetalle As New DataTable
        Dim intIdCompraResultado As New Integer
        Dim dtComprasEnPeriodo As DataTable = fncTransportePorPeriodoBUS(intAnio, Mes, Estado)
        If fncValidaDataTable(dtComprasEnPeriodo) Then
            dtCabecera = dtComprasEnPeriodo.Clone
            Select Case intOrden
                Case enmOrden.Primero
                    dtCabecera.ImportRow(dtComprasEnPeriodo.Rows(0))
                    intIdCompraResultado = ObtenerValorCelda(dtComprasEnPeriodo.Rows(0), "IdTransporte")
                    dtDetalle = DetalleCompra.fncListarDetallePorCompraBUS(intIdCompraResultado)
                Case enmOrden.Atras
                    If intIdTransporteActual = 0 Then
                        dtCabecera.ImportRow(dtComprasEnPeriodo.Rows(0))
                        intIdCompraResultado = ObtenerValorCelda(dtComprasEnPeriodo.Rows(0), "IdTransporte")
                        dtDetalle = DetalleCompra.fncListarDetallePorCompraBUS(intIdCompraResultado)
                    Else
                        For i As Integer = 0 To dtComprasEnPeriodo.Rows.Count - 1
                            If ObtenerValorCelda(dtComprasEnPeriodo.Rows(i), "IdTransporte") = intIdTransporteActual Then
                                If i - 1 >= 0 Then
                                    dtCabecera.ImportRow(dtComprasEnPeriodo.Rows(i - 1))
                                    intIdCompraResultado = ObtenerValorCelda(dtComprasEnPeriodo.Rows(i - 1), "IdTransporte")
                                    dtDetalle = DetalleCompra.fncListarDetallePorCompraBUS(intIdCompraResultado)
                                End If
                            End If
                        Next
                    End If

                Case enmOrden.Siguiente
                    If intIdTransporteActual = 0 Then
                        dtCabecera.ImportRow(dtComprasEnPeriodo.Rows(dtComprasEnPeriodo.Rows.Count - 1))
                        intIdCompraResultado = ObtenerValorCelda(dtComprasEnPeriodo.Rows(dtComprasEnPeriodo.Rows.Count - 1), "IdTransporte")
                        dtDetalle = DetalleCompra.fncListarDetallePorCompraBUS(intIdCompraResultado)
                    Else
                        For i As Integer = 0 To dtComprasEnPeriodo.Rows.Count - 1
                            If ObtenerValorCelda(dtComprasEnPeriodo.Rows(i), "IdTransporte") = intIdTransporteActual Then
                                If i + 1 <= dtComprasEnPeriodo.Rows.Count - 1 Then
                                    dtCabecera.ImportRow(dtComprasEnPeriodo.Rows(i + 1))
                                    intIdCompraResultado = ObtenerValorCelda(dtComprasEnPeriodo.Rows(i + 1), "IdTransporte")
                                    dtDetalle = DetalleCompra.fncListarDetallePorCompraBUS(intIdCompraResultado)
                                End If
                            End If
                        Next
                    End If

                Case enmOrden.Ultimo
                    dtCabecera.ImportRow(dtComprasEnPeriodo.Rows(dtComprasEnPeriodo.Rows.Count - 1))
                    intIdCompraResultado = ObtenerValorCelda(dtComprasEnPeriodo.Rows(dtComprasEnPeriodo.Rows.Count - 1), "IdTransporte")
                    dtDetalle = DetalleCompra.fncListarDetallePorCompraBUS(intIdCompraResultado)
            End Select
        End If

     

        Return {dtCabecera, dtDetalle}

    End Function

    Public Function fncComprobantesPorTransporteBUS( _
 Optional IdTransporte As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ComprobantesPorTransporteBD( _
            IdTransporte _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


End Class
