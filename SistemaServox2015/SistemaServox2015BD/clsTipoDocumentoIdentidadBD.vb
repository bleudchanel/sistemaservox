Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsTipoDocumentoIdentidadBD
    Inherits clsTipoDocumentoIdentidadBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_TipoDocumentoIdentidad")
            db.AddOutParameter(Comando, "@IdTipoDocumentoIdentidad", DbType.Int64, IdTipoDocumentoIdentidad)
            db.AddInParameter(Comando, "@CodigoSUNAT", DbType.String, CodigoSUNAT)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Abrev", DbType.String, Abrev)
            rs = db.ExecuteNonQuery(Comando)
            IdTipoDocumentoIdentidad = db.GetParameterValue(Comando, "@IdTipoDocumentoIdentidad")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_TipoDocumentoIdentidad")
            db.AddInParameter(Comando, "@IdTipoDocumentoIdentidad", DbType.Int64, IdTipoDocumentoIdentidad)
            db.AddInParameter(Comando, "@CodigoSUNAT", DbType.String, CodigoSUNAT)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Abrev", DbType.String, Abrev)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_TipoDocumentoIdentidad")
            db.AddInParameter(Comando, "@IdTipoDocumentoIdentidad", DbType.Int64, IdTipoDocumentoIdentidad)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional ByVal IdTipoDocumentoIdentidad As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_TipoDocumentoIdentidad")
            db.AddInParameter(Comando, "@IdTipoDocumentoIdentidad", DbType.Int64, IdTipoDocumentoIdentidad)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_TipoDocumentoIdentidad"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


#End Region

    Public Function fncusp_srv_ListarDocumentoIdentidadCamposBD( _
Optional ByVal Estado As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ListarDocumentoIdentidadCampos")
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ListarDocumentoIdentidadCampos"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



End Class
