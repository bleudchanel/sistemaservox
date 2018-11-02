Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsTipoComprobanteBD

    Inherits clsTipoComprobanteBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_TipoComprobante")
            db.AddOutParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            db.AddInParameter(Comando, "@CodigoSunat", DbType.String, CodigoSunat)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Abreviacion", DbType.String, Abreviacion)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@EnUso", DbType.Int64, EnUso)
            rs = db.ExecuteNonQuery(Comando)
            IdTipoComprobante = db.GetParameterValue(Comando, "@IdTipoComprobante")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_TipoComprobante")
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            db.AddInParameter(Comando, "@CodigoSunat", DbType.String, CodigoSunat)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Abreviacion", DbType.String, Abreviacion)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@EnUso", DbType.Int64, EnUso)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_TipoComprobante")
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional ByVal IdTipoComprobante As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_TipoComprobante")
            db.AddInParameter(Comando, "@IdTipoComprobante", DbType.Int64, IdTipoComprobante)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_TipoComprobante"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


#End Region

    Public Function fncusp_Srv_TipoComprobanteBD( _
Optional ByVal EnUso As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Srv_TipoComprobante")
            db.AddInParameter(Comando, "@EnUso", DbType.Int64, EnUso)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Srv_TipoComprobante"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



End Class
