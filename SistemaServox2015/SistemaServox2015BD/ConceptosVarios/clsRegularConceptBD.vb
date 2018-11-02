Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsRegularConceptBD
    Inherits clsRegularConceptBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_RegularConcept")
            db.AddOutParameter(Comando, "@IdRegularConcept", DbType.Int64, IdRegularConcept)
            db.AddInParameter(Comando, "@ConceptCode", DbType.String, ConceptCode)
            db.AddInParameter(Comando, "@ConceptDescription", DbType.String, ConceptDescription)
            db.AddInParameter(Comando, "@ConceptStatus", DbType.Int64, ConceptStatus)
            db.AddInParameter(Comando, "@FechaRegistra", DbType.DateTime, FechaRegistra)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            rs = db.ExecuteNonQuery(Comando)
            IdRegularConcept = db.GetParameterValue(Comando, "@IdRegularConcept")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_RegularConcept")
            db.AddInParameter(Comando, "@IdRegularConcept", DbType.Int64, IdRegularConcept)
            db.AddInParameter(Comando, "@ConceptCode", DbType.String, ConceptCode)
            db.AddInParameter(Comando, "@ConceptDescription", DbType.String, ConceptDescription)
            db.AddInParameter(Comando, "@ConceptStatus", DbType.Int64, ConceptStatus)
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
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_RegularConcept")
            db.AddInParameter(Comando, "@IdRegularConcept", DbType.Int64, IdRegularConcept)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional IdRegularConcept As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_RegularConcept")
            db.AddInParameter(Comando, "@IdRegularConcept", DbType.Int64, IdRegularConcept)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_RegularConcept"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


#End Region

End Class
