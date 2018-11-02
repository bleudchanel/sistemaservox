Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsGarantiaBD
    Inherits clsGarantiaBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_Garantia")
            db.AddOutParameter(Comando, "@IdGarantia", DbType.Int64, IdGarantia)
            db.AddInParameter(Comando, "@IdModalidadPago", DbType.Int64, IdModalidadPago)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Observacion", DbType.String, Observacion)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaGarantia", DbType.DateTime, FechaGarantia)
            db.AddInParameter(Comando, "@FechaPago", DbType.DateTime, FechaPago)
            db.AddInParameter(Comando, "@IGV", DbType.Double, IGV)
            db.AddInParameter(Comando, "@Correlativo", DbType.Int64, Correlativo)
            db.AddInParameter(Comando, "@FechaRegistra", DbType.DateTime, FechaRegistra)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            db.AddInParameter(Comando, "@IdTipoOperacion", DbType.Int64, IdTipoOperacion)
            db.AddInParameter(Comando, "@EstadoProceso", DbType.Int64, EstadoProceso)
            rs = db.ExecuteNonQuery(Comando)
            IdGarantia = db.GetParameterValue(Comando, "@IdGarantia")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_Garantia")
            db.AddInParameter(Comando, "@IdGarantia", DbType.Int64, IdGarantia)
            db.AddInParameter(Comando, "@IdModalidadPago", DbType.Int64, IdModalidadPago)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Observacion", DbType.String, Observacion)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaGarantia", DbType.DateTime, FechaGarantia)
            db.AddInParameter(Comando, "@FechaPago", DbType.DateTime, FechaPago)
            db.AddInParameter(Comando, "@IGV", DbType.Double, IGV)
            db.AddInParameter(Comando, "@Correlativo", DbType.Int64, Correlativo)
            db.AddInParameter(Comando, "@FechaRegistra", DbType.DateTime, FechaRegistra)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            db.AddInParameter(Comando, "@IdTipoOperacion", DbType.Int64, IdTipoOperacion)
            db.AddInParameter(Comando, "@EstadoProceso", DbType.Int64, EstadoProceso)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_Garantia")
            db.AddInParameter(Comando, "@IdGarantia", DbType.Int64, IdGarantia)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional IdGarantia As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_Garantia")
            db.AddInParameter(Comando, "@IdGarantia", DbType.Int64, IdGarantia)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_Garantia"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



#End Region


    Public Function fncusp_srv_CorrelativoGarantiaBD( _
FechaGarantia As String _
) As Object
        Dim rs As Object = Nothing
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_CorrelativoGarantia")
            db.AddInParameter(Comando, "@FechaGarantia", DbType.DateTime, FechaGarantia)
            rs = db.ExecuteScalar(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_ValidaNumeroGarantiaBD( _
Optional Serie As String = "" _
, Optional Numero As String = "" _
, Optional IdTipoComprobante As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_ValidaNumeroGarantia")
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_ValidaNumeroGarantia"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_srv_GarantiasPorPeriodoBD( _
Optional Anio As Integer = -1 _
, Optional Mes As Integer = -1 _
, Optional Estado As String = "" _
, Optional IdTipoComprobante As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_GarantiasPorPeriodo")
            db.AddInParameter(Comando, "@Anio", DbType.Int64, Anio)
            db.AddInParameter(Comando, "@Mes", DbType.Int64, Mes)
            db.AddInParameter(Comando, "@Estado", DbType.String, Estado)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_GarantiasPorPeriodo"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_srv_GarantiasPorIdentificadorBD( _
Optional IdGarantia As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_GarantiasPorIdentificador")
            db.AddInParameter(Comando, "@IdGarantia", DbType.Int64, IdGarantia)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_GarantiasPorIdentificador"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_srv_BusquedaGarantiasBD( _
Optional Serie As String = "" _
, Optional Numero As String = "" _
, Optional Identificacion As String = "" _
, Optional RazonSocial As String = "" _
, Optional IdTipoComprobante As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_BusquedaGarantias")
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@Identificacion", DbType.String, Identificacion)
            db.AddInParameter(Comando, "@RazonSocial", DbType.String, RazonSocial)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_BusquedaGarantias"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_srv_ValidaGarantiaExistenteBD( _
Optional IdGarantia As Integer = -1 _
, Optional IdTipoComprobante As Integer = -1 _
, Optional Serie As String = "" _
, Optional Numero As String = "" _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ValidaGarantiaExistente")
            db.AddInParameter(Comando, "@IdGarantia", DbType.Int64, IdGarantia)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ValidaGarantiaExistente"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_SeriePorComprobanteYNumeroGarantiaBD( _
    IdTipoComprobante As Integer _
    , Serie As String _
    ) As DataTable

        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_SeriePorComprobanteYNumeroGarantia")
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_SeriePorComprobanteYNumero"})
            rs = Consulta.Tables(0)
            ''rs = db.ExecuteScalar(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs

    End Function



End Class
