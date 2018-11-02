Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN


Public Class clsDetalleProformaBD
    Inherits clsDetalleProformaBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_DetalleProforma")
            db.AddOutParameter(Comando, "@IdDetalleProforma", DbType.Int64, IdDetalleProforma)
            db.AddInParameter(Comando, "@IdProforma", DbType.Int64, IdProforma)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            db.AddInParameter(Comando, "@Cantidad", DbType.Double, Cantidad)
            db.AddInParameter(Comando, "@PrecioUnidadSinIGV", DbType.Double, PrecioUnidadSinIGV)
            db.AddInParameter(Comando, "@UnidadIGV", DbType.Double, UnidadIGV)
            db.AddInParameter(Comando, "@PrecioUnidadConIGV", DbType.Double, PrecioUnidadConIGV)
            db.AddInParameter(Comando, "@PrecioTotalSinIGV", DbType.Double, PrecioTotalSinIGV)
            db.AddInParameter(Comando, "@TotalIGV", DbType.Double, TotalIGV)
            db.AddInParameter(Comando, "@PrecioTotalConIGV", DbType.Double, PrecioTotalConIGV)
            db.AddInParameter(Comando, "@FechaVentaDetalle", DbType.DateTime, FechaVentaDetalle)
            db.AddInParameter(Comando, "@FechaRegistra", DbType.DateTime, FechaRegistra)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            db.AddInParameter(Comando, "@PROnombre", DbType.String, PROnombre)
            db.AddInParameter(Comando, "@PROdescripcion", DbType.String, PROdescripcion)
            db.AddInParameter(Comando, "@IdUnidadMedida", DbType.Int64, IdUnidadMedida)
            rs = db.ExecuteNonQuery(Comando)
            IdDetalleProforma = db.GetParameterValue(Comando, "@IdDetalleProforma")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_DetalleProforma")
            db.AddInParameter(Comando, "@IdDetalleProforma", DbType.Int64, IdDetalleProforma)
            db.AddInParameter(Comando, "@IdProforma", DbType.Int64, IdProforma)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            db.AddInParameter(Comando, "@Cantidad", DbType.Double, Cantidad)
            db.AddInParameter(Comando, "@PrecioUnidadSinIGV", DbType.Double, PrecioUnidadSinIGV)
            db.AddInParameter(Comando, "@UnidadIGV", DbType.Double, UnidadIGV)
            db.AddInParameter(Comando, "@PrecioUnidadConIGV", DbType.Double, PrecioUnidadConIGV)
            db.AddInParameter(Comando, "@PrecioTotalSinIGV", DbType.Double, PrecioTotalSinIGV)
            db.AddInParameter(Comando, "@TotalIGV", DbType.Double, TotalIGV)
            db.AddInParameter(Comando, "@PrecioTotalConIGV", DbType.Double, PrecioTotalConIGV)
            db.AddInParameter(Comando, "@FechaVentaDetalle", DbType.DateTime, FechaVentaDetalle)
            db.AddInParameter(Comando, "@FechaRegistra", DbType.DateTime, FechaRegistra)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            db.AddInParameter(Comando, "@PROnombre", DbType.String, PROnombre)
            db.AddInParameter(Comando, "@PROdescripcion", DbType.String, PROdescripcion)
            db.AddInParameter(Comando, "@IdUnidadMedida", DbType.Int64, IdUnidadMedida)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_DetalleProforma")
            db.AddInParameter(Comando, "@IdDetalleProforma", DbType.Int64, IdDetalleProforma)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional IdDetalleProforma As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_DetalleProforma")
            db.AddInParameter(Comando, "@IdDetalleProforma", DbType.Int64, IdDetalleProforma)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_DetalleProforma"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


#End Region

    Public Function fncusp_Srv_ListarDetallePorProformaBD( _
Optional IdProforma As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Srv_ListarDetallePorProforma")
            db.AddInParameter(Comando, "@IdProforma", DbType.Int64, IdProforma)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Srv_ListarDetallePorProforma"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



End Class
