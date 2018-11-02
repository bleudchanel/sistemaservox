Imports SistemaServox2015BD
Imports pryUtil.clsUtil

Public Class clsProductoBUS
    Inherits clsProductoBD


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
    Optional ByVal IdProducto As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdProducto _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(ByVal Registro As DataRow)
        Try
            PROnombre = ObtenerValorCelda(Registro, "PROnombre")
            PROunidad = ObtenerValorCelda(Registro, "PROunidad")
            PROdescripcion = ObtenerValorCelda(Registro, "PROdescripcion")
            PROstock = ObtenerValorCelda(Registro, "PROstock")
            PROstockmin = ObtenerValorCelda(Registro, "PROstockmin")
            PROprecioigv = ObtenerValorCelda(Registro, "PROprecioigv")
            PRVruc = ObtenerValorCelda(Registro, "PRVruc")
            IdProducto = ObtenerValorCelda(Registro, "IdProducto")
            FechaRegistro = ObtenerValorCelda(Registro, "FechaRegistro")
            FechaModifica = ObtenerValorCelda(Registro, "FechaModifica")
            IdMedida = ObtenerValorCelda(Registro, "IdMedida")
            IdProveedor = ObtenerValorCelda(Registro, "IdProveedor")
            PrecioCoste = ObtenerValorCelda(Registro, "PrecioCoste")
            PorcentajeIGVCoste = ObtenerValorCelda(Registro, "PorcentajeIGVCoste")
            PrecioCosteConIGV = ObtenerValorCelda(Registro, "PrecioCosteConIGV")
            PrecioNetoSinIGV = ObtenerValorCelda(Registro, "PrecioNetoSinIGV")
            Estado = ObtenerValorCelda(Registro, "Estado")
            UsuarioRegistra = ObtenerValorCelda(Registro, "UsuarioRegistra")
            UsuarioModifica = ObtenerValorCelda(Registro, "UsuarioModifica")
            IdTipoDeExistencia = ObtenerValorCelda(Registro, "IdTipoDeExistencia")
            PorcentajeIGVVenta = ObtenerValorCelda(Registro, "PorcentajeIGVVenta")
            PrecioNetoConIGV = ObtenerValorCelda(Registro, "PrecioNetoConIGV")
            IdEmpleadoComision = fncSiMenorIgualACeroEsDbNull(ObtenerValorCelda(Registro, "IdEmpleadoComision"))
            MontoComision = ObtenerValorCelda(Registro, "MontoComision")
            CodigoMonedaCompra = ObtenerValorCelda(Registro, "CodigoMonedaCompra")
            CodigoMonedaVenta = ObtenerValorCelda(Registro, "CodigoMonedaVenta")
        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub
#End Region

#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New(ByVal strPROnombre As String,
                    ByVal strUnidadMedida As String,
                    ByVal strPROdescripcion As String,
                    ByVal intPROstock As Integer,
                    ByVal intPROstockmin As Integer,
                    ByVal PROprecioigv As Decimal,
                    ByVal intIdProducto As Integer,
                    ByVal dateFechaRegistro As Date,
                    ByVal intIdMedida As Integer,
                    ByVal intIdProveedor As Integer,
                    ByVal decPrecioCoste As Decimal,
                    ByVal decPorcentajeIGVCoste As Decimal,
                    ByVal decPrecioCosteConIGV As Decimal,
                    ByVal decPrecioNetoSinIGV As Decimal,
                    ByVal intUsuarioRegistra As Integer,
                    ByVal decPorcentajeIGVVenta As Decimal,
                    ByVal decPrecioNetoConIGV As Decimal,
                    ByVal intIdEmpleadoComision As Integer,
                    ByVal decMontoComision As Decimal,
                    ByVal strCodigoMonedaCompra As String,
                    ByVal strCodigoMonedaVenta As String)
        Dim dtValidaExistente As DataTable = fncCodigoProductoUnicoBUS(strPROnombre)
        If fncValidaDataTable(dtValidaExistente) Then
            Notificar("Este producto ya existe")
            Exit Sub
        End If

        PROnombre = strPROnombre
        PROunidad = strUnidadMedida
        PROdescripcion = strPROdescripcion
        PROstock = intPROstock
        PROstockmin = intPROstockmin
        PROprecioigv = PROprecioigv
        PRVruc = "00000000000"
        IdProducto = intIdProducto
        FechaRegistro = dateFechaRegistro
        FechaModifica = dateFechaRegistro
        IdMedida = intIdMedida
        IdProveedor = intIdProveedor
        PrecioCoste = decPrecioCoste
        PorcentajeIGVCoste = decPorcentajeIGVCoste
        PrecioCosteConIGV = decPrecioCosteConIGV
        PrecioNetoSinIGV = decPrecioNetoSinIGV
        Estado = enmEstado.Activo
        UsuarioRegistra = intUsuarioRegistra
        UsuarioModifica = intUsuarioRegistra
        IdTipoDeExistencia = enmTipoExistencia.Mercadería
        PorcentajeIGVVenta = decPorcentajeIGVVenta
        PrecioNetoConIGV = decPrecioNetoConIGV
        IdEmpleadoComision = fncSiMenorIgualACeroEsDbNull(intIdEmpleadoComision)
        MontoComision = decMontoComision
        CodigoMonedaCompra = strCodigoMonedaCompra
        CodigoMonedaVenta = strCodigoMonedaVenta
    End Sub

#End Region

    Public Function fncListarProductoPorCamposBUS( _
  Optional PROnombre As String = "" _
  , Optional PROdescripcion As String = "" _
  , Optional Estado As Integer = -1 _
  , Optional IdProducto As Integer = -1 _
  , Optional TextoUnico As String = "" _
  ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ListarProductoPorCamposBD( _
            PROnombre _
            , PROdescripcion _
            , Estado _
            , IdProducto _
            , TextoUnico _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncListarProductoPorCamposTop10BUS( _
Optional PROnombre As String = "" _
, Optional PROdescripcion As String = "" _
, Optional Estado As Integer = -1 _
, Optional IdProducto As Integer = -1 _
, Optional TextoUnico As String = "" _
) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ListarProductoPorCamposTop10BD( _
            PROnombre _
            , PROdescripcion _
            , Estado _
            , IdProducto _
            , TextoUnico _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncCodigoProductoUnicoBUS( _
 Optional ByVal CodigoProducto As String = "" _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_CodigoProductoUnicoBD( _
            CodigoProducto _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncListaInventarioHastaFechaBUS( _
  Optional FechaHasta As String = "1900-01-01" _
  , Optional SoloMayoresACero As Integer = -1 _
  , Optional IGVActual As Double = -1 _
  ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ListaInventarioHastaFechaBD( _
            FechaHasta _
            , SoloMayoresACero _
            , IGVActual _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function





    Private Function fncusp_srv_ResumenProductoBUS( _
 Optional ByVal IdProducto As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ResumenProductoBD( _
            IdProducto _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncObtenerPrecioCostoActualProducto(ByVal idProducto As Integer, ByVal bolEsSinIGV As Boolean) As DataTable
        Dim dtResultFinal As New DataTable
        dtResultFinal.Columns.Add("Precio", GetType(Decimal))
        dtResultFinal.Columns.Add("CodigoMonedaCompra", GetType(String))

        Dim decPrecio As New Decimal
        Dim strCodigoMoneda As String = String.Empty
        Dim dtResult As New DataTable
        dtResult = fncConsultarBUS(idProducto)
        If fncValidaDataTable(dtResult) Then
            strCodigoMoneda = ObtenerValorCelda(dtResult.Rows(0), "CodigoMonedaCompra")
            If bolEsSinIGV = True Then
                decPrecio = ObtenerValorCelda(dtResult.Rows(0), "PrecioCoste")
            Else
                decPrecio = ObtenerValorCelda(dtResult.Rows(0), "PrecioCosteConIGV")
            End If
        End If

        dtResultFinal.Rows.Add(decPrecio, strCodigoMoneda)

        Return dtResultFinal
    End Function

    Public Function fncBuscarProductoCodigoEspecificoBUS( _
 Optional CodigoProducto As String = "" _
 , Optional IdProducto As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_BuscarProductoCodigoEspecificoBD( _
            CodigoProducto _
            , IdProducto _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncObtenerStockActualBUS( _
  Optional IdProducto As Integer = -1 _
  , Optional IdDetalleVenta As Integer = -1 _
  ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_ObtenerStockActualBD( _
            IdProducto _
            , IdDetalleVenta _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



    Public Function fncObtenerStockActualPorProducto(ByVal intIdProducto As Integer, Optional ByVal intIdDetalleVenta As Integer = -1) As List(Of Integer)
        Dim Stock As New List(Of Integer)
        Dim intStock As New Integer
        Dim intStockMin As New Integer
        Dim dtBase As DataTable = fncObtenerStockActualBUS(intIdProducto, intIdDetalleVenta)
        If fncValidaDataTable(dtBase) Then
            intStock = ObtenerValorCelda(dtBase.Rows(0), "StockActual")
            intStockMin = ObtenerValorCelda(dtBase.Rows(0), "PROstockmin")
        End If

        Stock.Add(intStock)
        Stock.Add(intStockMin)

        Return Stock
    End Function


    Public Function fncValidaCodigoExistente(ByVal strCodigoProducto As String, Optional ByVal intIdProducto As Integer = -1) As Boolean
        Return fncValidaDataTable(fncBuscarProductoCodigoEspecificoBUS(strCodigoProducto, intIdProducto))
    End Function


    Public Function fncConstruyeResumenPorProducto(ByVal intIdProducto As Integer) As DataTable
        Dim dtResultado As New DataTable
        dtResultado.Columns.Add("Operacion", GetType(String))
        dtResultado.Columns.Add("Fecha", GetType(String))
        dtResultado.Columns.Add("PrecioUnidad", GetType(Decimal))
        dtResultado.Columns.Add("Compra", GetType(Integer))
        dtResultado.Columns.Add("Venta", GetType(Integer))
        dtResultado.Columns.Add("Saldo", GetType(Integer))
        dtResultado.Columns.Add("IdOperacion", GetType(Integer))
        dtResultado.Columns.Add("IdTipoComprobante", GetType(Integer))
        dtResultado.Columns.Add("TipoOperacion", GetType(String))


        Dim dtBase As DataTable = fncusp_srv_ResumenProductoBUS(intIdProducto)
        If fncValidaDataTable(dtBase) Then
            Dim intSaldo As New Integer
            For Each row In dtBase.Rows
                dtResultado.Rows.Add()
                With dtResultado.Rows(dtResultado.Rows.Count - 1)
                    Dim strOperacion As String = ObtenerValorCelda(row, "Operacion")
                    intSaldo += If(strOperacion = "Compra", ObtenerValorCelda(row, "Cantidad"), ObtenerValorCelda(row, "Cantidad") * (-1))
                    .Item("Operacion") = ObtenerValorCelda(row, "TipoComprobante") & " " & ObtenerValorCelda(row, "Comprobante")
                    .Item("Fecha") = CDate(ObtenerValorCelda(row, "Fecha")).ToString("dd/MM/yyyy")
                    .Item("PrecioUnidad") = FormatearNumero(ObtenerValorCelda(row, "PrecioUnidad"), 4)
                    .Item("Compra") = If(strOperacion = "Compra", ObtenerValorCelda(row, "Cantidad"), 0)
                    .Item("Venta") = If(strOperacion = "Venta", ObtenerValorCelda(row, "Cantidad"), 0)
                    .Item("Saldo") = intSaldo
                    .Item("IdOperacion") = ObtenerValorCelda(row, "IdOperacion")
                    .Item("IdTipoComprobante") = ObtenerValorCelda(row, "IdTipoComprobante")
                    .Item("TipoOperacion") = ObtenerValorCelda(row, "TipoOperacion")
                End With
            Next
        End If

        Return dtResultado
    End Function

    Private Function fncConsultaKardexBUS( _
 Optional ByVal CodigoProducto As String = "" _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ConsultaKardexBD( _
            CodigoProducto _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncValidarUsoDeProductoBUS( _
 IdProducto As Integer _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ValidarUsoDeProductoBD(IdProducto)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



    Public Function fncConstruirKardexValorado(ByVal strCodigoProducto As String) As DataTable
        Dim dtResultado As DataTable = fncEstructuraKardex()

        Dim dtConsultaBase As DataTable = fncConsultaKardexBUS(strCodigoProducto)
        If fncValidaDataTable(dtConsultaBase) Then
            Dim intSaldo As New Integer
            Dim decUltimoPrecioVenta As New Decimal
            Dim decPrecioActual As Decimal = ObtenerValorCelda(dtConsultaBase.Rows(0), "Precio")
            For Each row In dtConsultaBase.Rows
                Dim strCodigoOperacion As String = ObtenerValorCelda(row, "CodigoOperacion")
                intSaldo += If(strCodigoOperacion = "02", ObtenerValorCelda(row, "Cantidad"), ObtenerValorCelda(row, "Cantidad") * (-1))

                'Select Case strCodigoOperacion
                '    Case "01"
                '        '' VENTA
                fncIngresarEnEstructuraKardex(dtResultado _
                                              , ObtenerValorCelda(row, "IdOperacion") _
                                              , CDate(ObtenerValorCelda(row, "Fecha")).ToString("dd/MM/yyyy") _
                                              , ObtenerValorCelda(row, "CodigoComprobante") _
                                              , ObtenerValorCelda(row, "TipoComprobante") _
                                              , ObtenerValorCelda(row, "Serie") _
                                              , ObtenerValorCelda(row, "Numero") _
                                              , ObtenerValorCelda(row, "IdProducto") _
                                              , ObtenerValorCelda(row, "Producto") _
                                              , ObtenerValorCelda(row, "DescripcionProducto") _
                                              , ObtenerValorCelda(row, "CodigoOperacion") _
                                              , ObtenerValorCelda(row, "TipoOperacion") _
                                              , If(strCodigoOperacion = "02", ObtenerValorCelda(row, "Cantidad"), 0) _
                                              , If(strCodigoOperacion = "02", ObtenerValorCelda(row, "MontoUnidadConIGV"), 0) _
                                              , If(strCodigoOperacion = "02", ObtenerValorCelda(row, "MontoTotalConIGV"), 0) _
                                              , If(strCodigoOperacion = "01", ObtenerValorCelda(row, "Cantidad"), 0) _
                                              , If(strCodigoOperacion = "01", ObtenerValorCelda(row, "MontoUnidadConIGV"), 0) _
                                              , If(strCodigoOperacion = "01", ObtenerValorCelda(row, "MontoTotalConIGV"), 0) _
                                              , intSaldo _
                                              , decPrecioActual _
                                              , fncRound2(intSaldo * decPrecioActual))

                'Case "02"
                '    '' COMPRA
                '    '' VENTA
                '    fncIngresarEnEstructuraKardex(dtResultado _
                '                                  , ObtenerValorCelda(row, "IdOperacion") _
                '                                  , CDate(ObtenerValorCelda(row, "Fecha")).ToString("dd/MM/yyyy") _
                '                                  , ObtenerValorCelda(row, "CodigoComprobante") _
                '                                  , ObtenerValorCelda(row, "TipoComprobante") _
                '                                  , ObtenerValorCelda(row, "Serie") _
                '                                  , ObtenerValorCelda(row, "Numero") _
                '                                  , ObtenerValorCelda(row, "CodigoOperacion") _
                '                                  , ObtenerValorCelda(row, "TipoOperacion") _
                '                                  , 0 _
                '                                  , 0 _
                '                                  , 0 _
                '                                  , ObtenerValorCelda(row, "Cantidad") _
                '                                  , ObtenerValorCelda(row, "MontoUnidadConIGV") _
                '                                  , ObtenerValorCelda(row, "MontoTotalConIGV") _
                '                                  , intSaldo _
                '                                  , decPrecioActual _
                '        '                                  , fncRound2(intSaldo * decPrecioActual))
                'End Select
            Next
        End If

        Return dtResultado
    End Function


    Public Function fncReporteVentasPorPeriodoProductoBUS( _
 Optional Mes As Integer = -1 _
 , Optional Anio As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ReporteVentasPorPeriodoProductoBD( _
            Mes _
            , Anio _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncReporteVentasProductoPorPeriodoBUS( _
 Optional Mes As Integer = -1 _
 , Optional Anio As Integer = -1 _
 , Optional IdProducto As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ReporteVentasProductoPorPeriodoBD( _
            Mes _
            , Anio _
            , IdProducto _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncReporteVentasProductoAgrupadoBUS( _
 Optional Mes As Integer = -1 _
 , Optional Anio As Integer = -1 _
 , Optional IdProducto As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ReporteVentasProductoAgrupadoBD( _
            Mes _
            , Anio _
            , IdProducto _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncReporteVentasProductoAgrupadoAnualBUS( _
 Optional Anio As Integer = -1 _
 , Optional IdProducto As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ReporteVentasProductoAgrupadoAnualBD( _
            Anio _
            , IdProducto _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminaProductoDetallesBUS(ByVal intIdProducto As Integer) As Integer
        Dim rs As Integer = -1
        Try
            Return fncusp_srv_EliminaProductoDetallesBD(intIdProducto)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



End Class
