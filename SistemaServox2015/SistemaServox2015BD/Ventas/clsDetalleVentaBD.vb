﻿Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsDetalleVentaBD

    Inherits clsDetalleVentaBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_DetalleVenta")
            db.AddOutParameter(Comando, "@IdDetalleVenta", DbType.Int64, IdDetalleVenta)
            db.AddInParameter(Comando, "@IdVenta", DbType.Int64, IdVenta)
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
            IdDetalleVenta = db.GetParameterValue(Comando, "@IdDetalleVenta")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_DetalleVenta")
            db.AddInParameter(Comando, "@IdDetalleVenta", DbType.Int64, IdDetalleVenta)
            db.AddInParameter(Comando, "@IdVenta", DbType.Int64, IdVenta)
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
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_DetalleVenta")
            db.AddInParameter(Comando, "@IdDetalleVenta", DbType.Int64, IdDetalleVenta)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional IdDetalleVenta As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_DetalleVenta")
            db.AddInParameter(Comando, "@IdDetalleVenta", DbType.Int64, IdDetalleVenta)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_DetalleVenta"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function






#End Region


    Public Function fncusp_Srv_ListarDetallePorVentaBD( _
Optional ByVal IdVenta As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Srv_ListarDetallePorVenta")
            db.AddInParameter(Comando, "@IdVenta", DbType.Int64, IdVenta)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Srv_ListarDetallePorVenta"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



End Class
