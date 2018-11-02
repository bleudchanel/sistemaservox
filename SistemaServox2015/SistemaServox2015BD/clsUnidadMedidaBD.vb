Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN


Public Class clsUnidadMedidaBD
    Inherits clsUnidadMedidaBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_UnidadMedida")
            db.AddOutParameter(Comando, "@IdMedida", DbType.Int64, IdMedida)
            db.AddInParameter(Comando, "@CodigoSunat", DbType.String, CodigoSunat)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Abreviacion", DbType.String, Abreviacion)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@EnUso", DbType.Int64, EnUso)
            rs = db.ExecuteNonQuery(Comando)
            IdMedida = db.GetParameterValue(Comando, "@IdMedida")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_UnidadMedida")
            db.AddInParameter(Comando, "@IdMedida", DbType.Int64, IdMedida)
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
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_UnidadMedida")
            db.AddInParameter(Comando, "@IdMedida", DbType.Int64, IdMedida)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional ByVal IdMedida As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_UnidadMedida")
            db.AddInParameter(Comando, "@IdMedida", DbType.Int64, IdMedida)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_UnidadMedida"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


#End Region

    Public Function fncusp_Srv_ListarUnidadMedidaBD( _
Optional ByVal EnUso As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Srv_ListarUnidadMedida")
            db.AddInParameter(Comando, "@EnUso", DbType.Int64, EnUso)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Srv_ListarUnidadMedida"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



End Class
