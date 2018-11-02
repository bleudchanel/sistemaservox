Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsCodUnidadVentaBD


    Inherits clsCodUnidadVentaBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_CodigoUnidadVenta")
            db.AddOutParameter(Comando, "@IdCodigo", DbType.Int64, IdCodigo)
            db.AddInParameter(Comando, "@IdDetalleVenta", DbType.Int64, IdDetalleVenta)
            db.AddInParameter(Comando, "@IdDetalleCompra", DbType.Int64, IdDetalleCompra)
            db.AddInParameter(Comando, "@Codigo", DbType.String, Codigo)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaRegistra", DbType.DateTime, FechaRegistra)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@IdEmpleado", DbType.Int64, IdEmpleado)
            db.AddInParameter(Comando, "@MontoComision", DbType.Double, MontoComision)
            rs = db.ExecuteNonQuery(Comando)
            IdCodigo = db.GetParameterValue(Comando, "@IdCodigo")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_CodigoUnidadVenta")
            db.AddInParameter(Comando, "@IdCodigo", DbType.Int64, IdCodigo)
            db.AddInParameter(Comando, "@IdDetalleVenta", DbType.Int64, IdDetalleVenta)
            db.AddInParameter(Comando, "@IdDetalleCompra", DbType.Int64, IdDetalleCompra)
            db.AddInParameter(Comando, "@Codigo", DbType.String, Codigo)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaRegistra", DbType.DateTime, FechaRegistra)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@IdEmpleado", DbType.Int64, IdEmpleado)
            db.AddInParameter(Comando, "@MontoComision", DbType.Double, MontoComision)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_CodigoUnidadVenta")
            db.AddInParameter(Comando, "@IdCodigo", DbType.Int64, IdCodigo)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional IdCodigo As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_CodigoUnidadVenta")
            db.AddInParameter(Comando, "@IdCodigo", DbType.Int64, IdCodigo)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_CodigoUnidadVenta"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function





#End Region



    Public Function fncusp_srv_ListarCodigosPorDetalleBD( _
 Optional IdVenta As Integer = -1 _
 , Optional IdCompra As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ListarCodigosPorDetalle")
            db.AddInParameter(Comando, "@IdVenta", DbType.Int64, IdVenta)
            db.AddInParameter(Comando, "@IdCompra", DbType.Int64, IdCompra)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ListarCodigosPorDetalle"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function





    Public Function fncusp_srv_BusquedaCodigoComprobanteBD( _
Optional Codigo As String = "" _
, Optional Descripcion As String = "" _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_BusquedaCodigoComprobante")
            db.AddInParameter(Comando, "@Codigo", DbType.String, Codigo)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_BusquedaCodigoComprobante"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function




End Class
