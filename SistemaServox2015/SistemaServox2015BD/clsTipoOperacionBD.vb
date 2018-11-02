Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsTipoOperacionBD
    Inherits clsTipoOperacionBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_TipoOperacion")
            db.AddOutParameter(Comando, "@IdTipoOperacion", DbType.Int64, IdTipoOperacion)
            db.AddInParameter(Comando, "@CodigoOperacion", DbType.String, CodigoOperacion)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@Abreviatura", DbType.String, Abreviatura)
            rs = db.ExecuteNonQuery(Comando)
            IdTipoOperacion = db.GetParameterValue(Comando, "@IdTipoOperacion")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_TipoOperacion")
            db.AddInParameter(Comando, "@IdTipoOperacion", DbType.Int64, IdTipoOperacion)
            db.AddInParameter(Comando, "@CodigoOperacion", DbType.String, CodigoOperacion)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@Abreviatura", DbType.String, Abreviatura)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_TipoOperacion")
            db.AddInParameter(Comando, "@IdTipoOperacion", DbType.Int64, IdTipoOperacion)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional ByVal IdTipoOperacion As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_TipoOperacion")
            db.AddInParameter(Comando, "@IdTipoOperacion", DbType.Int64, IdTipoOperacion)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_TipoOperacion"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


#End Region
End Class
