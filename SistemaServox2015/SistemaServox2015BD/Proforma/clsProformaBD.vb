Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN


Public Class clsProformaBD
    Inherits clsProformaBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_Proforma")
            db.AddOutParameter(Comando, "@IdProforma", DbType.Int64, IdProforma)
            db.AddInParameter(Comando, "@IdModalidadPago", DbType.Int64, IdModalidadPago)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Observacion", DbType.String, Observacion)
            db.AddInParameter(Comando, "@IdCliente", DbType.Int64, IdCliente)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaVenta", DbType.DateTime, FechaVenta)
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
            IdProforma = db.GetParameterValue(Comando, "@IdProforma")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_Proforma")
            db.AddInParameter(Comando, "@IdProforma", DbType.Int64, IdProforma)
            db.AddInParameter(Comando, "@IdModalidadPago", DbType.Int64, IdModalidadPago)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Observacion", DbType.String, Observacion)
            db.AddInParameter(Comando, "@IdCliente", DbType.Int64, IdCliente)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaVenta", DbType.DateTime, FechaVenta)
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
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_Proforma")
            db.AddInParameter(Comando, "@IdProforma", DbType.Int64, IdProforma)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional IdProforma As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_Proforma")
            db.AddInParameter(Comando, "@IdProforma", DbType.Int64, IdProforma)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_Proforma"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function




#End Region


    Public Function fncusp_srv_CorrelativoProformaBD( _
FechaVenta As String _
) As Object
        Dim rs As Object = Nothing
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_CorrelativoProforma")
            db.AddInParameter(Comando, "@FechaVenta", DbType.DateTime, FechaVenta)
            rs = db.ExecuteScalar(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_ValidaNumeroProformaBD( _
Optional Serie As String = "" _
, Optional Numero As String = "" _
, Optional IdTipoComprobante As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_ValidaNumeroProforma")
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_ValidaNumeroProforma"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_Pln_ProformasPorPeriodoBD( _
Optional Anio As Integer = -1 _
, Optional Mes As Integer = -1 _
, Optional Estado As String = "" _
, Optional IdTipoComprobante As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_ProformasPorPeriodo")
            db.AddInParameter(Comando, "@Anio", DbType.Int64, Anio)
            db.AddInParameter(Comando, "@Mes", DbType.Int64, Mes)
            db.AddInParameter(Comando, "@Estado", DbType.String, Estado)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_ProformasPorPeriodo"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncusp_Pln_ProformasPorIdentificadorBD( _
Optional IdProforma As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_ProformasPorIdentificador")
            db.AddInParameter(Comando, "@IdProforma", DbType.Int64, IdProforma)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_ProformasPorIdentificador"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



    Public Function fncusp_SeriePorComprobanteYNumeroProformaBD( _
IdTipoComprobante As Integer _
, Serie As String _
) As DataTable

        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_SeriePorComprobanteYNumeroProforma")
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

    Public Function fncusp_srv_ProformasEntreDosFechasBD( _
Optional FechaDesde As String = "1900-01-01" _
, Optional FechaHasta As String = "1900-01-01" _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ProformasEntreDosFechas")
            db.AddInParameter(Comando, "@FechaDesde", DbType.DateTime, FechaDesde)
            db.AddInParameter(Comando, "@FechaHasta", DbType.DateTime, FechaHasta)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ProformasEntreDosFechas"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncusp_ValidaProformaExistenteBD( _
Optional IdVenta As Integer = -1 _
, Optional IdTipoComprobante As Integer = -1 _
, Optional Serie As String = "" _
, Optional Numero As String = "" _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_ValidaProformaExistente")
            db.AddInParameter(Comando, "@IdVenta", DbType.Int64, IdVenta)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_ValidaProformaExistente"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_srv_BusquedaProformaBD( _
    Optional Serie As String = "" _
    , Optional Numero As String = "" _
    , Optional Identificacion As String = "" _
    , Optional RazonSocial As String = "" _
    , Optional IdTipoComprobante As Integer = -1 _
    , Optional EstadoProceso As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_BusquedaProforma")
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@Identificacion", DbType.String, Identificacion)
            db.AddInParameter(Comando, "@RazonSocial", DbType.String, RazonSocial)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            db.AddInParameter(Comando, "@EstadoProceso", DbType.Int64, EstadoProceso)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_BusquedaProforma"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncusp_srv_ListarDatosProformaVentaPorIdProformaBD( _
Optional IdProforma As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ListarDatosProformaVentaPorIdProforma")
            db.AddInParameter(Comando, "@IdProforma", DbType.Int64, IdProforma)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ListarDatosProformaVentaPorIdProforma"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function




End Class
