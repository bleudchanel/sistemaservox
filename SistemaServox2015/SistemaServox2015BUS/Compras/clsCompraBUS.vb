Imports SistemaServox2015BD
Imports pryUtil.clsUtil

Public Class clsCompraBUS
    Inherits clsCompraBD

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
    Optional ByVal IdCompra As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdCompra _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(ByVal Registro As DataRow)
        Try
            IdCompra = ObtenerValorCelda(Registro, "IdCompra")
            Serie = ObtenerValorCelda(Registro, "Serie")
            Numero = ObtenerValorCelda(Registro, "Numero")
            Descripcion = ObtenerValorCelda(Registro, "Descripcion")
            Observacion = ObtenerValorCelda(Registro, "Observacion")
            IdProveedor = ObtenerValorCelda(Registro, "IdProveedor")
            Estado = ObtenerValorCelda(Registro, "Estado")
            FechaCompra = ObtenerValorCelda(Registro, "FechaCompra")
            FechaPago = ObtenerValorCelda(Registro, "FechaPago")
            IdModalidadPago = ObtenerValorCelda(Registro, "IdModalidadPago")
            IdTipoComprobante = ObtenerValorCelda(Registro, "IdTipoComprobante")
            FechaRegistra = ObtenerValorCelda(Registro, "FechaRegistra")
            FechaModifica = ObtenerValorCelda(Registro, "FechaModifica")
            UsuarioRegistra = ObtenerValorCelda(Registro, "UsuarioRegistra")
            UsuarioModifica = ObtenerValorCelda(Registro, "UsuarioModifica")
            Correlativo = ObtenerValorCelda(Registro, "Correlativo")
            IGV = ObtenerValorCelda(Registro, "IGV")
            IdTipoOperacion = fncSiMenorIgualACeroEsDbNull(ObtenerValorCelda(Registro, "IdTipoOperacion"))
            IdTipoInterno = fncSiMenorIgualACeroEsDbNull(ObtenerValorCelda(Registro, "IdTipoInterno"))
            IdTransporte = fncSiMenorIgualACeroEsDbNull(ObtenerValorCelda(Registro, "IdTransporte"))
            CodigoMoneda = ObtenerValorCelda(Registro, "CodigoMoneda")
        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub


#End Region


#Region "Constructor"

    Public Sub New(ByVal intIdCompra As Integer,
                    ByVal strSerie As String,
                    ByVal strNumero As String,
                    ByVal strDescripcion As String,
                    ByVal strObservacion As String,
                    ByVal intIdProveedor As Integer,
                    ByVal dateFechaCompra As Date,
                    ByVal dateFechaPago As Date,
                    ByVal intIdModalidadPago As Integer,
                    ByVal intIdTipoComprobante As Integer,
                    ByVal intUsuario As Integer,
                    ByVal decIGV As Decimal,
                    ByVal intIdTipoInterno As Integer,
                    ByVal strCodigoMoneda As String)

        IdCompra = intIdCompra
        Serie = strSerie
        Numero = strNumero
        Descripcion = strDescripcion
        Observacion = strObservacion
        IdProveedor = intIdProveedor
        Estado = enmEstado.Activo
        FechaCompra = dateFechaCompra
        FechaPago = dateFechaPago
        IdModalidadPago = enmModalidadPago.Contado
        IdTipoComprobante = intIdTipoComprobante
        FechaRegistra = FechaHoraServidor()
        FechaModifica = FechaHoraServidor()
        UsuarioRegistra = intUsuario
        UsuarioModifica = intUsuario
        Correlativo = fncCorrelativoCompraBUS(dateFechaCompra.Date)
        IGV = decIGV
        IdTipoOperacion = enmTipoOperacion.Compra
        IdTipoInterno = intIdTipoInterno
        IdTransporte = DBNull.Value
        CodigoMoneda = strCodigoMoneda
    End Sub

    Public Sub New()

    End Sub

#End Region

    Public Function fncCorrelativoCompraBUS( _
  ByVal FechaCompra As String _
  ) As Int64
        Dim rs As Object = Nothing
        Try
            rs = fncusp_srv_CorrelativoCompraBD(FechaCompra)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return Convert.ToInt64(rs)
    End Function


    Public Function fncValidaNumeroCompraBUS( _
  Optional Serie As String = "" _
  , Optional Numero As String = "" _
  , Optional IdProveedor As Integer = -1 _
  , Optional IdTipoComprobante As Integer = -1 _
  ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_ValidaNumeroCompraBD( _
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



    Public Function fncValidaCompraExistenteBUS( _
 Optional IdCompra As Integer = -1 _
 , Optional IdTipoComprobante As Integer = -1 _
 , Optional Serie As String = "" _
 , Optional Numero As String = "" _
 , Optional IdProveedor As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_ValidaCompraExistenteBD( _
            IdCompra _
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

    Public Function fncBuscarTop1ProveedorBUS( _
     Optional DocumentoIdentidadProveedor As String = "" _
     , Optional Tipo As String = "" _
     ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_BuscarTop1ProveedorBD( _
            DocumentoIdentidadProveedor _
            , Tipo _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function







    Public Function fncComprasPorPeriodoBUS( _
  Optional Anio As Integer = -1 _
  , Optional Mes As Integer = -1 _
  , Optional Estado As String = "" _
  , Optional TipoInterno As Integer = -1 _
  ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_Pln_ComprasPorPeriodoBD( _
            Anio _
            , Mes _
            , Estado _
            , TipoInterno _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



    Public Function fncComprasPorIdentificadorBUS( _
 Optional IdCompra As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_Pln_ComprasPorIdentificadorBD( _
            IdCompra _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncBusquedaComprasBUS( _
  Optional Serie As String = "" _
  , Optional Numero As String = "" _
  , Optional Identificacion As String = "" _
  , Optional RazonSocial As String = "" _
  , Optional IdTipoInterno As Integer = -1 _
  ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_BusquedaComprasBD( _
            Serie _
            , Numero _
            , Identificacion _
            , RazonSocial _
            , IdTipoInterno _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function






    Public Function fncComprasPorIdentificador(ByVal intIdCompra As Integer) As DataTable()
        Dim DetalleCompra As New clsDetalleCompraBUS
        Dim dtCabecera As New DataTable
        Dim dtDetalle As New DataTable


        Dim dtCompra As DataTable = fncComprasPorIdentificadorBUS(intIdCompra)
        If fncValidaDataTable(dtCompra) Then
            dtCabecera = dtCompra.Clone
            dtCabecera.ImportRow(dtCompra.Rows(0))
            dtDetalle = DetalleCompra.fncListarDetallePorCompraBUS(intIdCompra)
        End If

        Dim dtTransporte As New DataTable
        Dim Transporte As New clsTransporteBUS

        dtTransporte = Transporte.fncTransportePorIdentificador(, intIdCompra)(0)
        Return {dtCabecera, dtDetalle, dtTransporte}
    End Function


    Public Function fncComprasEntreDosFechasBUS( _
 Optional FechaDesde As String = "1900-01-01" _
 , Optional FechaHasta As String = "1900-01-01" _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ComprasEntreDosFechasBD( _
            FechaDesde _
            , FechaHasta _
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
    ''' <param name="intIdCompraActual"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fncComprasPorOrden(ByVal intIdTipoInterno As Integer _
                                        , Optional ByVal intAnio As Integer = -1 _
                                        , Optional ByVal Mes As Integer = -1 _
                                        , Optional ByVal Estado As String = "" _
                                        , Optional ByVal intOrden As Integer = 1 _
                                        , Optional ByVal intIdCompraActual As Integer = 0) As DataTable()
        Dim DetalleCompra As New clsDetalleCompraBUS
        Dim dtCabecera As New DataTable
        Dim dtDetalle As New DataTable
        Dim intIdCompraResultado As New Integer
        Dim dtComprasEnPeriodo As DataTable = fncComprasPorPeriodoBUS(intAnio, Mes, Estado, intIdTipoInterno)
        If fncValidaDataTable(dtComprasEnPeriodo) Then
            dtCabecera = dtComprasEnPeriodo.Clone
            Select Case intOrden
                Case enmOrden.Primero
                    dtCabecera.ImportRow(dtComprasEnPeriodo.Rows(0))
                    intIdCompraResultado = ObtenerValorCelda(dtComprasEnPeriodo.Rows(0), "IdCompra")
                    dtDetalle = DetalleCompra.fncListarDetallePorCompraBUS(intIdCompraResultado)
                Case enmOrden.Atras
                    If intIdCompraActual = 0 Then
                        dtCabecera.ImportRow(dtComprasEnPeriodo.Rows(0))
                        intIdCompraResultado = ObtenerValorCelda(dtComprasEnPeriodo.Rows(0), "IdCompra")
                        dtDetalle = DetalleCompra.fncListarDetallePorCompraBUS(intIdCompraResultado)
                    Else
                        For i As Integer = 0 To dtComprasEnPeriodo.Rows.Count - 1
                            If ObtenerValorCelda(dtComprasEnPeriodo.Rows(i), "IdCompra") = intIdCompraActual Then
                                If i - 1 >= 0 Then
                                    dtCabecera.ImportRow(dtComprasEnPeriodo.Rows(i - 1))
                                    intIdCompraResultado = ObtenerValorCelda(dtComprasEnPeriodo.Rows(i - 1), "IdCompra")
                                    dtDetalle = DetalleCompra.fncListarDetallePorCompraBUS(intIdCompraResultado)
                                End If
                            End If
                        Next
                    End If

                Case enmOrden.Siguiente
                    If intIdCompraActual = 0 Then
                        dtCabecera.ImportRow(dtComprasEnPeriodo.Rows(dtComprasEnPeriodo.Rows.Count - 1))
                        intIdCompraResultado = ObtenerValorCelda(dtComprasEnPeriodo.Rows(dtComprasEnPeriodo.Rows.Count - 1), "IdCompra")
                        dtDetalle = DetalleCompra.fncListarDetallePorCompraBUS(intIdCompraResultado)
                    Else
                        For i As Integer = 0 To dtComprasEnPeriodo.Rows.Count - 1
                            If ObtenerValorCelda(dtComprasEnPeriodo.Rows(i), "IdCompra") = intIdCompraActual Then
                                If i + 1 <= dtComprasEnPeriodo.Rows.Count - 1 Then
                                    dtCabecera.ImportRow(dtComprasEnPeriodo.Rows(i + 1))
                                    intIdCompraResultado = ObtenerValorCelda(dtComprasEnPeriodo.Rows(i + 1), "IdCompra")
                                    dtDetalle = DetalleCompra.fncListarDetallePorCompraBUS(intIdCompraResultado)
                                End If
                            End If
                        Next
                    End If

                Case enmOrden.Ultimo
                    dtCabecera.ImportRow(dtComprasEnPeriodo.Rows(dtComprasEnPeriodo.Rows.Count - 1))
                    intIdCompraResultado = ObtenerValorCelda(dtComprasEnPeriodo.Rows(dtComprasEnPeriodo.Rows.Count - 1), "IdCompra")
                    dtDetalle = DetalleCompra.fncListarDetallePorCompraBUS(intIdCompraResultado)
            End Select
        End If

        Dim dtTransporte() As DataTable
        Dim Transporte As New clsTransporteBUS

        dtTransporte = Transporte.fncTransportePorIdentificador(, intIdCompraResultado)
 

        Return {dtCabecera, dtDetalle, dtTransporte(0)}

    End Function



End Class
