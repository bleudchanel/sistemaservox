Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsVentaRapidaBD
    Inherits clsVentaRapidaBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_VentasRapidas")
            db.AddOutParameter(Comando, "@Id", DbType.Int64, Id)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            db.AddInParameter(Comando, "@FechaVenta", DbType.DateTime, FechaVenta)
            db.AddInParameter(Comando, "@IdCliente", DbType.Int64, IdCliente)
            db.AddInParameter(Comando, "@PrecioIndividual", DbType.Double, PrecioIndividual)
            db.AddInParameter(Comando, "@Cantidad", DbType.Int64, Cantidad)
            db.AddInParameter(Comando, "@PrecioTotal", DbType.Double, PrecioTotal)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaRegistra", DbType.DateTime, FechaRegistra)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            rs = db.ExecuteNonQuery(Comando)
            Id = db.GetParameterValue(Comando, "@Id")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_VentasRapidas")
            db.AddInParameter(Comando, "@Id", DbType.Int64, Id)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            db.AddInParameter(Comando, "@FechaVenta", DbType.DateTime, FechaVenta)
            db.AddInParameter(Comando, "@IdCliente", DbType.Int64, IdCliente)
            db.AddInParameter(Comando, "@PrecioIndividual", DbType.Double, PrecioIndividual)
            db.AddInParameter(Comando, "@Cantidad", DbType.Int64, Cantidad)
            db.AddInParameter(Comando, "@PrecioTotal", DbType.Double, PrecioTotal)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaRegistra", DbType.DateTime, FechaRegistra)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_VentasRapidas")
            db.AddInParameter(Comando, "@Id", DbType.Int64, Id)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional Id As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_VentasRapidas")
            db.AddInParameter(Comando, "@Id", DbType.Int64, Id)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_VentasRapidas"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



#End Region


    Public Function fncListarVentasRapidasPorPeriodoBD( _
Optional Mes As Integer = -1 _
, Optional Anio As Integer = -1 _
, Optional Id As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ListarVentasRapidasPorPeriodo")
            db.AddInParameter(Comando, "@Mes", DbType.Int64, Mes)
            db.AddInParameter(Comando, "@Anio", DbType.Int64, Anio)
            db.AddInParameter(Comando, "@Id", DbType.Int64, Id)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ListarVentasRapidasPorPeriodo"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



End Class
