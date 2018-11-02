Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsCompraBD
    Inherits clsCompraBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_Compra")
            db.AddOutParameter(Comando, "@IdCompra", DbType.Int64, IdCompra)
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Observacion", DbType.String, Observacion)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaCompra", DbType.DateTime, FechaCompra)
            db.AddInParameter(Comando, "@FechaPago", DbType.DateTime, FechaPago)
            db.AddInParameter(Comando, "@IdModalidadPago", DbType.Int64, IdModalidadPago)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            db.AddInParameter(Comando, "@FechaRegistra", DbType.DateTime, FechaRegistra)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            db.AddInParameter(Comando, "@Correlativo", DbType.Int64, Correlativo)
            db.AddInParameter(Comando, "@IGV", DbType.Double, IGV)
            db.AddInParameter(Comando, "@IdTipoOperacion", DbType.Int64, IdTipoOperacion)
            db.AddInParameter(Comando, "@IdTipoInterno", DbType.Int64, IdTipoInterno)
            db.AddInParameter(Comando, "@IdTransporte", DbType.Int64, IdTransporte)
            db.AddInParameter(Comando, "@CodigoMoneda", DbType.String, CodigoMoneda)
            rs = db.ExecuteNonQuery(Comando)
            IdCompra = db.GetParameterValue(Comando, "@IdCompra")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_Compra")
            db.AddInParameter(Comando, "@IdCompra", DbType.Int64, IdCompra)
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Observacion", DbType.String, Observacion)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaCompra", DbType.DateTime, FechaCompra)
            db.AddInParameter(Comando, "@FechaPago", DbType.DateTime, FechaPago)
            db.AddInParameter(Comando, "@IdModalidadPago", DbType.Int64, IdModalidadPago)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            db.AddInParameter(Comando, "@FechaRegistra", DbType.DateTime, FechaRegistra)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            db.AddInParameter(Comando, "@Correlativo", DbType.Int64, Correlativo)
            db.AddInParameter(Comando, "@IGV", DbType.Double, IGV)
            db.AddInParameter(Comando, "@IdTipoOperacion", DbType.Int64, IdTipoOperacion)
            db.AddInParameter(Comando, "@IdTipoInterno", DbType.Int64, IdTipoInterno)
            db.AddInParameter(Comando, "@IdTransporte", DbType.Int64, IdTransporte)
            db.AddInParameter(Comando, "@CodigoMoneda", DbType.String, CodigoMoneda)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_Compra")
            db.AddInParameter(Comando, "@IdCompra", DbType.Int64, IdCompra)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional IdCompra As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_Compra")
            db.AddInParameter(Comando, "@IdCompra", DbType.Int64, IdCompra)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_Compra"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function







#End Region


    Public Function fncusp_Pln_ComprasPorPeriodoBD( _
Optional Anio As Integer = -1 _
, Optional Mes As Integer = -1 _
, Optional Estado As String = "" _
, Optional TipoInterno As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_ComprasPorPeriodo")
            db.AddInParameter(Comando, "@Anio", DbType.Int64, Anio)
            db.AddInParameter(Comando, "@Mes", DbType.Int64, Mes)
            db.AddInParameter(Comando, "@Estado", DbType.String, Estado)
            db.AddInParameter(Comando, "@TipoInterno", DbType.Int64, TipoInterno)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_ComprasPorPeriodo"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



    Public Function fncusp_Pln_ComprasPorIdentificadorBD( _
Optional IdCompra As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_ComprasPorIdentificador")
            db.AddInParameter(Comando, "@IdCompra", DbType.Int64, IdCompra)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_ComprasPorIdentificador"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_srv_BusquedaComprasBD( _
 Optional Serie As String = "" _
 , Optional Numero As String = "" _
 , Optional Identificacion As String = "" _
 , Optional RazonSocial As String = "" _
 , Optional IdTipoInterno As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_BusquedaCompras")
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@Identificacion", DbType.String, Identificacion)
            db.AddInParameter(Comando, "@RazonSocial", DbType.String, RazonSocial)
            db.AddInParameter(Comando, "@IdTipoInterno", DbType.Int64, IdTipoInterno)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_BusquedaCompras"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



    Public Function fncusp_srv_ComprasEntreDosFechasBD( _
Optional FechaDesde As String = "1900-01-01" _
, Optional FechaHasta As String = "1900-01-01" _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ComprasEntreDosFechas")
            db.AddInParameter(Comando, "@FechaDesde", DbType.DateTime, FechaDesde)
            db.AddInParameter(Comando, "@FechaHasta", DbType.DateTime, FechaHasta)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ComprasEntreDosFechas"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function




    Public Function fncusp_ValidaNumeroCompraBD( _
    Optional Serie As String = "" _
    , Optional Numero As String = "" _
    , Optional IdProveedor As Integer = -1 _
    , Optional IdTipoComprobante As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_ValidaNumeroCompra")
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_ValidaNumeroCompra"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



    Public Function fncusp_ValidaCompraExistenteBD( _
Optional IdCompra As Integer = -1 _
, Optional IdTipoComprobante As Integer = -1 _
, Optional Serie As String = "" _
, Optional Numero As String = "" _
, Optional IdProveedor As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_ValidaCompraExistente")
            db.AddInParameter(Comando, "@IdCompra", DbType.Int64, IdCompra)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_ValidaCompraExistente"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncusp_BuscarTop1ProveedorBD( _
    Optional DocumentoIdentidadProveedor As String = "" _
    , Optional Tipo As String = "" _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_BuscarTop1Proveedor")
            db.AddInParameter(Comando, "@DocumentoIdentidadProveedor", DbType.String, DocumentoIdentidadProveedor)
            db.AddInParameter(Comando, "@Tipo", DbType.String, Tipo)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_BuscarTop1Proveedor"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function







    Public Function fncusp_srv_CorrelativoCompraBD( _
ByVal FechaCompra As String _
) As Object
        Dim rs As Object = Nothing
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_CorrelativoCompra")
            db.AddInParameter(Comando, "@FechaCompra", DbType.DateTime, FechaCompra)
            rs = db.ExecuteScalar(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



End Class
