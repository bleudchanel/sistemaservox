Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsTransporteBD
    Inherits clsTransporteBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_Transporte")
            db.AddOutParameter(Comando, "@IdTransporte", DbType.Int64, IdTransporte)
            db.AddInParameter(Comando, "@IdModalidadPago", DbType.Int64, IdModalidadPago)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Observacion", DbType.String, Observacion)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaTransporte", DbType.DateTime, FechaTransporte)
            db.AddInParameter(Comando, "@FechaPago", DbType.DateTime, FechaPago)
            db.AddInParameter(Comando, "@IGV", DbType.Double, IGV)
            db.AddInParameter(Comando, "@Correlativo", DbType.Int64, Correlativo)
            db.AddInParameter(Comando, "@FechaRegistra", DbType.DateTime, FechaRegistra)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            db.AddInParameter(Comando, "@IdTipoOperacion", DbType.Int64, IdTipoOperacion)
            db.AddInParameter(Comando, "@EstadoProceso", DbType.Int64, EstadoProceso)
            db.AddInParameter(Comando, "@MontoTransporte", DbType.Double, MontoTransporte)
            rs = db.ExecuteNonQuery(Comando)
            IdTransporte = db.GetParameterValue(Comando, "@IdTransporte")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_Transporte")
            db.AddInParameter(Comando, "@IdTransporte", DbType.Int64, IdTransporte)
            db.AddInParameter(Comando, "@IdModalidadPago", DbType.Int64, IdModalidadPago)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Observacion", DbType.String, Observacion)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaTransporte", DbType.DateTime, FechaTransporte)
            db.AddInParameter(Comando, "@FechaPago", DbType.DateTime, FechaPago)
            db.AddInParameter(Comando, "@IGV", DbType.Double, IGV)
            db.AddInParameter(Comando, "@Correlativo", DbType.Int64, Correlativo)
            db.AddInParameter(Comando, "@FechaRegistra", DbType.DateTime, FechaRegistra)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            db.AddInParameter(Comando, "@IdTipoOperacion", DbType.Int64, IdTipoOperacion)
            db.AddInParameter(Comando, "@EstadoProceso", DbType.Int64, EstadoProceso)
            db.AddInParameter(Comando, "@MontoTransporte", DbType.Double, MontoTransporte)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_Transporte")
            db.AddInParameter(Comando, "@IdTransporte", DbType.Int64, IdTransporte)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional IdTransporte As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_Transporte")
            db.AddInParameter(Comando, "@IdTransporte", DbType.Int64, IdTransporte)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_Transporte"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



#End Region


    Public Function fncusp_ValidaNumeroTransporteBD( _
Optional Serie As String = "" _
, Optional Numero As String = "" _
, Optional IdProveedor As Integer = -1 _
, Optional IdTipoComprobante As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_ValidaNumeroTransporte")
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_ValidaNumeroTransporte"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncusp_srv_CorrelativoTransporteBD( _
ByVal FechaTransporte As String _
) As Object
        Dim rs As Object = Nothing
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_CorrelativoTransporte")
            db.AddInParameter(Comando, "@FechaTransporte", DbType.DateTime, FechaTransporte)
            rs = db.ExecuteScalar(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_ValidaTransporteExistenteBD( _
Optional IdTransporte As Integer = -1 _
, Optional IdTipoComprobante As Integer = -1 _
, Optional Serie As String = "" _
, Optional Numero As String = "" _
, Optional IdProveedor As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_ValidaTransporteExistente")
            db.AddInParameter(Comando, "@IdTransporte", DbType.Int64, IdTransporte)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_ValidaTransporteExistente"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_Pln_TransportePorIdentificadorBD( _
    Optional IdTransporte As Integer = -1 _
    , Optional IdCompra As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_TransportePorIdentificador")
            db.AddInParameter(Comando, "@IdTransporte", DbType.Int64, IdTransporte)
            db.AddInParameter(Comando, "@IdCompra", DbType.Int64, IdCompra)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_TransportePorIdentificador"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



    Public Function fncusp_Pln_TransportePorPeriodoBD( _
Optional Anio As Integer = -1 _
, Optional Mes As Integer = -1 _
, Optional Estado As String = "" _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_TransportePorPeriodo")
            db.AddInParameter(Comando, "@Anio", DbType.Int64, Anio)
            db.AddInParameter(Comando, "@Mes", DbType.Int64, Mes)
            db.AddInParameter(Comando, "@Estado", DbType.String, Estado)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_TransportePorPeriodo"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncusp_srv_BusquedaTransporteBD( _
Optional Serie As String = "" _
, Optional Numero As String = "" _
, Optional Identificacion As String = "" _
, Optional RazonSocial As String = "" _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_BusquedaTransporte")
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@Identificacion", DbType.String, Identificacion)
            db.AddInParameter(Comando, "@RazonSocial", DbType.String, RazonSocial)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_BusquedaTransporte"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncusp_srv_ComprobantesPorTransporteBD( _
Optional IdTransporte As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ComprobantesPorTransporte")
            db.AddInParameter(Comando, "@IdTransporte", DbType.Int64, IdTransporte)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ComprobantesPorTransporte"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


End Class
