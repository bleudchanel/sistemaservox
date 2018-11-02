Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsRegularCostBD
    Inherits clsRegularCostBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_RegularCost")
            db.AddOutParameter(Comando, "@IdRegularCost", DbType.Int64, IdRegularCost)
            db.AddInParameter(Comando, "@IdCompra", DbType.Int64, IdCompra)
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Number", DbType.String, Number)
            db.AddInParameter(Comando, "@IdRegularConcept", DbType.Int64, IdRegularConcept)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@Amount", DbType.Double, Amount)
            db.AddInParameter(Comando, "@CostDate", DbType.DateTime, CostDate)
            db.AddInParameter(Comando, "@CostStatus", DbType.Int64, CostStatus)
            db.AddInParameter(Comando, "@CostDescription", DbType.String, CostDescription)
            rs = db.ExecuteNonQuery(Comando)
            IdRegularCost = db.GetParameterValue(Comando, "@IdRegularCost")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_RegularCost")
            db.AddInParameter(Comando, "@IdRegularCost", DbType.Int64, IdRegularCost)
            db.AddInParameter(Comando, "@IdCompra", DbType.Int64, IdCompra)
            db.AddInParameter(Comando, "@Serie", DbType.String, Serie)
            db.AddInParameter(Comando, "@Number", DbType.String, Number)
            db.AddInParameter(Comando, "@IdRegularConcept", DbType.Int64, IdRegularConcept)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@Amount", DbType.Double, Amount)
            db.AddInParameter(Comando, "@CostDate", DbType.DateTime, CostDate)
            db.AddInParameter(Comando, "@CostStatus", DbType.Int64, CostStatus)
            db.AddInParameter(Comando, "@CostDescription", DbType.String, CostDescription)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_RegularCost")
            db.AddInParameter(Comando, "@IdRegularCost", DbType.Int64, IdRegularCost)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional IdRegularCost As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_RegularCost")
            db.AddInParameter(Comando, "@IdRegularCost", DbType.Int64, IdRegularCost)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_RegularCost"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


#End Region

    Public Function fncusp_srv_RegularCostPorIdCompraBD( _
Optional IdRegularConcept As Integer = -1 _
, Optional IdCompra As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_RegularCostPorIdCompra")
            db.AddInParameter(Comando, "@IdRegularConcept", DbType.Int64, IdRegularConcept)
            db.AddInParameter(Comando, "@IdCompra", DbType.Int64, IdCompra)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_RegularCostPorIdCompra"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



End Class
