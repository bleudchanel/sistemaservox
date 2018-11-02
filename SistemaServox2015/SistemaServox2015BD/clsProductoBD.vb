Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsProductoBD

    Inherits clsProductoBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
  	Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srvPROpProducto")
            db.AddInParameter(Comando, "@PROnombre", DbType.String, PROnombre)
            db.AddInParameter(Comando, "@PROunidad", DbType.String, PROunidad)
            db.AddInParameter(Comando, "@PROdescripcion", DbType.String, PROdescripcion)
            db.AddInParameter(Comando, "@PROstock", DbType.Int64, PROstock)
            db.AddInParameter(Comando, "@PROstockmin", DbType.Int64, PROstockmin)
            db.AddInParameter(Comando, "@PROprecioigv", DbType.Double, PROprecioigv)
            db.AddInParameter(Comando, "@PRVruc", DbType.String, PRVruc)
            db.AddOutParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            db.AddInParameter(Comando, "@FechaRegistro", DbType.DateTime, FechaRegistro)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@IdMedida", DbType.Int64, IdMedida)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@PrecioCoste", DbType.Double, PrecioCoste)
            db.AddInParameter(Comando, "@PorcentajeIGVCoste", DbType.Double, PorcentajeIGVCoste)
            db.AddInParameter(Comando, "@PrecioCosteConIGV", DbType.Double, PrecioCosteConIGV)
            db.AddInParameter(Comando, "@PrecioNetoSinIGV", DbType.Double, PrecioNetoSinIGV)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            db.AddInParameter(Comando, "@IdTipoDeExistencia", DbType.Int64, IdTipoDeExistencia)
            db.AddInParameter(Comando, "@PorcentajeIGVVenta", DbType.Double, PorcentajeIGVVenta)
            db.AddInParameter(Comando, "@PrecioNetoConIGV", DbType.Double, PrecioNetoConIGV)
            db.AddInParameter(Comando, "@IdEmpleadoComision", DbType.Int64, IdEmpleadoComision)
            db.AddInParameter(Comando, "@MontoComision", DbType.Double, MontoComision)
            db.AddInParameter(Comando, "@CodigoMonedaCompra", DbType.String, CodigoMonedaCompra)
            db.AddInParameter(Comando, "@CodigoMonedaVenta", DbType.String, CodigoMonedaVenta)
            rs = db.ExecuteNonQuery(Comando)
            IdProducto = db.GetParameterValue(Comando, "@IdProducto")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srvPROpProducto")
            db.AddInParameter(Comando, "@PROnombre", DbType.String, PROnombre)
            db.AddInParameter(Comando, "@PROunidad", DbType.String, PROunidad)
            db.AddInParameter(Comando, "@PROdescripcion", DbType.String, PROdescripcion)
            db.AddInParameter(Comando, "@PROstock", DbType.Int64, PROstock)
            db.AddInParameter(Comando, "@PROstockmin", DbType.Int64, PROstockmin)
            db.AddInParameter(Comando, "@PROprecioigv", DbType.Double, PROprecioigv)
            db.AddInParameter(Comando, "@PRVruc", DbType.String, PRVruc)
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            db.AddInParameter(Comando, "@FechaRegistro", DbType.DateTime, FechaRegistro)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@IdMedida", DbType.Int64, IdMedida)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@PrecioCoste", DbType.Double, PrecioCoste)
            db.AddInParameter(Comando, "@PorcentajeIGVCoste", DbType.Double, PorcentajeIGVCoste)
            db.AddInParameter(Comando, "@PrecioCosteConIGV", DbType.Double, PrecioCosteConIGV)
            db.AddInParameter(Comando, "@PrecioNetoSinIGV", DbType.Double, PrecioNetoSinIGV)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            db.AddInParameter(Comando, "@IdTipoDeExistencia", DbType.Int64, IdTipoDeExistencia)
            db.AddInParameter(Comando, "@PorcentajeIGVVenta", DbType.Double, PorcentajeIGVVenta)
            db.AddInParameter(Comando, "@PrecioNetoConIGV", DbType.Double, PrecioNetoConIGV)
            db.AddInParameter(Comando, "@IdEmpleadoComision", DbType.Int64, IdEmpleadoComision)
            db.AddInParameter(Comando, "@MontoComision", DbType.Double, MontoComision)
            db.AddInParameter(Comando, "@CodigoMonedaCompra", DbType.String, CodigoMonedaCompra)
            db.AddInParameter(Comando, "@CodigoMonedaVenta", DbType.String, CodigoMonedaVenta)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srvPROpProducto")
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional IdProducto As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srvPROpProducto")
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srvPROpProducto"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



#End Region

    Public Function fncusp_srv_ListarProductoPorCamposBD( _
Optional PROnombre As String = "" _
, Optional PROdescripcion As String = "" _
, Optional Estado As Integer = -1 _
, Optional IdProducto As Integer = -1 _
, Optional TextoUnico As String = "" _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ListarProductoPorCampos")
            db.AddInParameter(Comando, "@PROnombre", DbType.String, PROnombre)
            db.AddInParameter(Comando, "@PROdescripcion", DbType.String, PROdescripcion)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            db.AddInParameter(Comando, "@TextoUnico", DbType.String, TextoUnico)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ListarProductoPorCampos"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



    Public Function fncusp_srv_ListarProductoPorCamposTop10BD( _
Optional PROnombre As String = "" _
, Optional PROdescripcion As String = "" _
, Optional Estado As Integer = -1 _
, Optional IdProducto As Integer = -1 _
, Optional TextoUnico As String = "" _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ListarProductoPorCamposTop10")
            db.AddInParameter(Comando, "@PROnombre", DbType.String, PROnombre)
            db.AddInParameter(Comando, "@PROdescripcion", DbType.String, PROdescripcion)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            db.AddInParameter(Comando, "@TextoUnico", DbType.String, TextoUnico)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ListarProductoPorCamposTop10"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_srv_ListaInventarioHastaFechaBD( _
   Optional FechaHasta As String = "1900-01-01" _
   , Optional SoloMayoresACero As Integer = -1 _
   , Optional IGVActual As Double = -1 _
   ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ListaInventarioHastaFecha")
            db.AddInParameter(Comando, "@FechaHasta", DbType.DateTime, FechaHasta)
            db.AddInParameter(Comando, "@SoloMayoresACero", DbType.Int64, SoloMayoresACero)
            db.AddInParameter(Comando, "@IGVActual", DbType.Double, IGVActual)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ListaInventarioHastaFecha"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function






    Public Function fncusp_srv_CodigoProductoUnicoBD( _
Optional ByVal CodigoProducto As String = "" _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_CodigoProductoUnico")
            db.AddInParameter(Comando, "@CodigoProducto", DbType.String, CodigoProducto)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_CodigoProductoUnico"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_srv_ResumenProductoBD( _
Optional ByVal IdProducto As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ResumenProducto")
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ResumenProducto"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_srv_ConsultaKardexBD( _
Optional ByVal CodigoProducto As String = "" _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ConsultaKardex")
            db.AddInParameter(Comando, "@CodigoProducto", DbType.String, CodigoProducto)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ConsultaKardex"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_BuscarProductoCodigoEspecificoBD( _
 Optional CodigoProducto As String = "" _
 , Optional IdProducto As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_BuscarProductoCodigoEspecifico")
            db.AddInParameter(Comando, "@CodigoProducto", DbType.String, CodigoProducto)
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_BuscarProductoCodigoEspecifico"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncusp_ObtenerStockActualBD( _
    Optional IdProducto As Integer = -1 _
    , Optional IdDetalleVenta As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_ObtenerStockActual")
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            db.AddInParameter(Comando, "@IdDetalleVenta", DbType.Int64, IdDetalleVenta)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_ObtenerStockActual"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_srv_ValidarUsoDeProductoBD( _
IdProducto As Integer _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ValidarUsoDeProducto")
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ValidarUsoDeProducto"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_srv_ReporteVentasPorPeriodoProductoBD( _
Optional Mes As Integer = -1 _
, Optional Anio As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ReporteVentasPorPeriodoProducto")
            db.AddInParameter(Comando, "@Mes", DbType.Int64, Mes)
            db.AddInParameter(Comando, "@Anio", DbType.Int64, Anio)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ReporteVentasPorPeriodoProducto"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_srv_ReporteVentasProductoPorPeriodoBD( _
    Optional Mes As Integer = -1 _
    , Optional Anio As Integer = -1 _
    , Optional IdProducto As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ReporteVentasProductoPorPeriodo")
            db.AddInParameter(Comando, "@Mes", DbType.Int64, Mes)
            db.AddInParameter(Comando, "@Anio", DbType.Int64, Anio)
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ReporteVentasProductoPorPeriodo"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncusp_srv_ReporteVentasProductoAgrupadoBD( _
Optional Mes As Integer = -1 _
, Optional Anio As Integer = -1 _
, Optional IdProducto As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ReporteVentasProductoAgrupado")
            db.AddInParameter(Comando, "@Mes", DbType.Int64, Mes)
            db.AddInParameter(Comando, "@Anio", DbType.Int64, Anio)
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ReporteVentasProductoAgrupado"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_srv_ReporteVentasProductoAgrupadoAnualBD( _
Optional Anio As Integer = -1 _
, Optional IdProducto As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ReporteVentasProductoAgrupadoAnual")
            db.AddInParameter(Comando, "@Anio", DbType.Int64, Anio)
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ReporteVentasProductoAgrupadoAnual"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncusp_srv_EliminaProductoDetallesBD(ByVal intIdProducto As Integer) As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_EliminaProductoDetalles")
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, intIdProducto)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



End Class
