Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsVentaBD

    Inherits clsVentaBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_Venta")
            db.AddOutParameter(Comando, "@IdVenta", DbType.Int64, IdVenta)
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
            db.AddInParameter(Comando, "@EsBalance", DbType.Int64, EsBalance)
            rs = db.ExecuteNonQuery(Comando)
            IdVenta = db.GetParameterValue(Comando, "@IdVenta")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_Venta")
            db.AddInParameter(Comando, "@IdVenta", DbType.Int64, IdVenta)
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
            db.AddInParameter(Comando, "@EsBalance", DbType.Int64, EsBalance)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_Venta")
            db.AddInParameter(Comando, "@IdVenta", DbType.Int64, IdVenta)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional IdVenta As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_Venta")
            db.AddInParameter(Comando, "@IdVenta", DbType.Int64, IdVenta)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_Venta"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function






    Public Function fncusp_Pln_VentasPorPeriodoBD( _
 Optional Anio As Integer = -1 _
 , Optional Mes As Integer = -1 _
 , Optional Estado As String = "" _
 , Optional IdTipoComprobante As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_VentasPorPeriodo")
            db.AddInParameter(Comando, "@Anio", DbType.Int64, Anio)
            db.AddInParameter(Comando, "@Mes", DbType.Int64, Mes)
            db.AddInParameter(Comando, "@Estado", DbType.String, Estado)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_VentasPorPeriodo"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function





    Public Function fncusp_Pln_VentasPorIdentificadorBD( _
Optional IdVenta As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_VentasPorIdentificador")
            db.AddInParameter(Comando, "@IdVenta", DbType.Int64, IdVenta)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_VentasPorIdentificador"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function




#End Region


    Public Function fncusp_SeriePorComprobanteYNumeroBD( _
IdTipoComprobante As Integer _
, Serie As String _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_SeriePorComprobanteYNumero")
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



    Public Function fncusp_srv_CorrelativoVentaBD( _
ByVal FechaVenta As String _
) As Object
        Dim rs As Object = Nothing
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_CorrelativoVenta")
            db.AddInParameter(Comando, "@FechaVenta", DbType.DateTime, FechaVenta)
            rs = db.ExecuteScalar(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_ValidaNumeroVentaBD( _
 Optional Serie As String = "" _
 , Optional Numero As String = "" _
 , Optional IdTipoComprobante As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_ValidaNumeroVenta")
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_ValidaNumeroVenta"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



    Public Function fncusp_srv_BusquedaVentasBD( _
  Optional Serie As String = "" _
  , Optional Numero As String = "" _
  , Optional Identificacion As String = "" _
  , Optional RazonSocial As String = "" _
  , Optional IdTipoComprobante As Integer = -1 _
  ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_BusquedaVentas")
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            db.AddInParameter(Comando, "@Identificacion", DbType.String, Identificacion)
            db.AddInParameter(Comando, "@RazonSocial", DbType.String, RazonSocial)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_BusquedaVentas"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



    Public Function fncusp_srv_ReporteHistorialClienteBD( _
  Optional IdCliente As Integer = -1 _
  , Optional FechaDesde As String = "1900-01-01" _
  , Optional FechaHasta As String = "1900-01-01" _
  ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ReporteHistorialCliente")
            db.AddInParameter(Comando, "@IdCliente", DbType.Int64, IdCliente)
            db.AddInParameter(Comando, "@FechaDesde", DbType.DateTime, FechaDesde)
            db.AddInParameter(Comando, "@FechaHasta", DbType.DateTime, FechaHasta)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ReporteHistorialCliente"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



    Public Function fncusp_ValidaVentaExistenteBD( _
Optional IdVenta As Integer = -1 _
, Optional IdTipoComprobante As Integer = -1 _
, Optional Serie As String = "" _
, Optional Numero As String = "" _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_ValidaVentaExistente")
            db.AddInParameter(Comando, "@IdVenta", DbType.Int64, IdVenta)
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Numero", DbType.String, Numero)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_ValidaVentaExistente"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncusp_BuscarTop1ClienteBD( _
Optional DocumentoIdentidadCliente As String = "" _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_BuscarTop1Cliente")
            db.AddInParameter(Comando, "@DocumentoIdentidadCliente", DbType.String, DocumentoIdentidadCliente)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_BuscarTop1Cliente"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncusp_srv_VentasEntreDosFechasBD( _
Optional FechaDesde As String = "1900-01-01" _
, Optional FechaHasta As String = "1900-01-01" _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_VentasEntreDosFechas")
            db.AddInParameter(Comando, "@FechaDesde", DbType.DateTime, FechaDesde)
            db.AddInParameter(Comando, "@FechaHasta", DbType.DateTime, FechaHasta)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_VentasEntreDosFechas"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_srv_GananciasEntreDosFechasBD( _
Optional FechaDesde As String = "1900-01-01" _
, Optional FechaHasta As String = "1900-01-01" _
, Optional ValorDolar As Double = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_GananciasEntreDosFechas")
            db.AddInParameter(Comando, "@FechaDesde", DbType.DateTime, FechaDesde)
            db.AddInParameter(Comando, "@FechaHasta", DbType.DateTime, FechaHasta)
            db.AddInParameter(Comando, "@ValorDolar", DbType.Double, ValorDolar)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_GananciasEntreDosFechas"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function





#Region "Periodo"
    Public Function fncusp_Srv_ListaPeriodoPorOperacionBD( _
ByVal Operacion As Integer _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Srv_ListaPeriodoPorOperacion")
            db.AddInParameter(Comando, "@Operacion", DbType.Int64, Operacion)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Srv_ListaPeriodoPorOperacion"})
            rs = Consulta.Tables(0)
            ''rs = db.ExecuteScalar(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

#End Region

    


End Class
