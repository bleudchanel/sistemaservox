Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsProformaVentaBD
    Inherits clsProformaVentaBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_ProformaVenta")
            db.AddOutParameter(Comando, "@IdProformaVenta", DbType.Int64, IdProformaVenta)
            db.AddInParameter(Comando, "@IdVenta", DbType.Int64, IdVenta)
            db.AddInParameter(Comando, "@IdProforma", DbType.Int64, IdProforma)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaRegistra", DbType.DateTime, FechaRegistra)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            rs = db.ExecuteNonQuery(Comando)
            IdProformaVenta = db.GetParameterValue(Comando, "@IdProformaVenta")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_ProformaVenta")
            db.AddInParameter(Comando, "@IdProformaVenta", DbType.Int64, IdProformaVenta)
            db.AddInParameter(Comando, "@IdVenta", DbType.Int64, IdVenta)
            db.AddInParameter(Comando, "@IdProforma", DbType.Int64, IdProforma)
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
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_ProformaVenta")
            db.AddInParameter(Comando, "@IdProformaVenta", DbType.Int64, IdProformaVenta)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional IdProformaVenta As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_ProformaVenta")
            db.AddInParameter(Comando, "@IdProformaVenta", DbType.Int64, IdProformaVenta)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_ProformaVenta"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


#End Region


    Public Function fncusp_srv_ListarProformasPorVentaBD( _
Optional IdVenta As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ListarProformasPorVenta")
            db.AddInParameter(Comando, "@IdVenta", DbType.Int64, IdVenta)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ListarProformasPorVenta"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function




End Class
