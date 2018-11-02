Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsDetalleCompraBD
    Inherits clsDetalleCompraBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"

    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_DetalleCompra")
            db.AddOutParameter(Comando, "@IdDetalleCompra", DbType.Int64, IdDetalleCompra)
            db.AddInParameter(Comando, "@IdCompra", DbType.Int64, IdCompra)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            db.AddInParameter(Comando, "@Cantidad", DbType.Double, Cantidad)
            db.AddInParameter(Comando, "@CostoUnidadSinIGV", DbType.Double, CostoUnidadSinIGV)
            db.AddInParameter(Comando, "@UnidadIGV", DbType.Double, UnidadIGV)
            db.AddInParameter(Comando, "@CostoUnidadConIGV", DbType.Double, CostoUnidadConIGV)
            db.AddInParameter(Comando, "@CostoTotalSinIGV", DbType.Double, CostoTotalSinIGV)
            db.AddInParameter(Comando, "@CostoIGV", DbType.Double, CostoIGV)
            db.AddInParameter(Comando, "@CostoTotalConIGV", DbType.Double, CostoTotalConIGV)
            db.AddInParameter(Comando, "@FechaCompraDetalle", DbType.DateTime, FechaCompraDetalle)
            db.AddInParameter(Comando, "@FechaRegistro", DbType.DateTime, FechaRegistro)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            db.AddInParameter(Comando, "@PROnombre", DbType.String, PROnombre)
            db.AddInParameter(Comando, "@PROdescripcion", DbType.String, PROdescripcion)
            db.AddInParameter(Comando, "@IdUnidadMedida", DbType.Int64, IdUnidadMedida)
            rs = db.ExecuteNonQuery(Comando)
            IdDetalleCompra = db.GetParameterValue(Comando, "@IdDetalleCompra")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_DetalleCompra")
            db.AddInParameter(Comando, "@IdDetalleCompra", DbType.Int64, IdDetalleCompra)
            db.AddInParameter(Comando, "@IdCompra", DbType.Int64, IdCompra)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            db.AddInParameter(Comando, "@Cantidad", DbType.Double, Cantidad)
            db.AddInParameter(Comando, "@CostoUnidadSinIGV", DbType.Double, CostoUnidadSinIGV)
            db.AddInParameter(Comando, "@UnidadIGV", DbType.Double, UnidadIGV)
            db.AddInParameter(Comando, "@CostoUnidadConIGV", DbType.Double, CostoUnidadConIGV)
            db.AddInParameter(Comando, "@CostoTotalSinIGV", DbType.Double, CostoTotalSinIGV)
            db.AddInParameter(Comando, "@CostoIGV", DbType.Double, CostoIGV)
            db.AddInParameter(Comando, "@CostoTotalConIGV", DbType.Double, CostoTotalConIGV)
            db.AddInParameter(Comando, "@FechaCompraDetalle", DbType.DateTime, FechaCompraDetalle)
            db.AddInParameter(Comando, "@FechaRegistro", DbType.DateTime, FechaRegistro)
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
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_DetalleCompra")
            db.AddInParameter(Comando, "@IdDetalleCompra", DbType.Int64, IdDetalleCompra)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional IdDetalleCompra As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_DetalleCompra")
            db.AddInParameter(Comando, "@IdDetalleCompra", DbType.Int64, IdDetalleCompra)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_DetalleCompra"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function




#End Region

    Public Function fncusp_Srv_ListarDetallePorCompraBD( _
Optional ByVal IdCompra As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Srv_ListarDetallePorCompra")
            db.AddInParameter(Comando, "@IdCompra", DbType.Int64, IdCompra)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Srv_ListarDetallePorCompra"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



End Class
