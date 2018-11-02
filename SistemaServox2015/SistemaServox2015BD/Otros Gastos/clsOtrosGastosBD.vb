Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsOtrosGastosBD
    Inherits clsOtrosGastosBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_OtrosGastos")
            db.AddOutParameter(Comando, "@Id", DbType.Int64, Id)
            db.AddInParameter(Comando, "@ConceptoId", DbType.Int64, ConceptoId)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Mes", DbType.Int64, Mes)
            db.AddInParameter(Comando, "@Anio", DbType.Int64, Anio)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@ProveedorId", DbType.Int64, ProveedorId)
            db.AddInParameter(Comando, "@Proveedor", DbType.String, Proveedor)
            db.AddInParameter(Comando, "@Monto", DbType.Double, Monto)
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
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_OtrosGastos")
            db.AddInParameter(Comando, "@Id", DbType.Int64, Id)
            db.AddInParameter(Comando, "@ConceptoId", DbType.Int64, ConceptoId)
            db.AddInParameter(Comando, "@Descripcion", DbType.String, Descripcion)
            db.AddInParameter(Comando, "@Mes", DbType.Int64, Mes)
            db.AddInParameter(Comando, "@Anio", DbType.Int64, Anio)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@ProveedorId", DbType.Int64, ProveedorId)
            db.AddInParameter(Comando, "@Proveedor", DbType.String, Proveedor)
            db.AddInParameter(Comando, "@Monto", DbType.Double, Monto)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_OtrosGastos")
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
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_OtrosGastos")
            db.AddInParameter(Comando, "@Id", DbType.Int64, Id)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_OtrosGastos"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


#End Region


    Public Function fncusp_srv_ListarOtrosGastosPorPeriodoBD( _
Optional Mes As Integer = -1 _
, Optional Anio As Integer = -1 _
, Optional Id As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ListarOtrosGastosPorPeriodo")
            db.AddInParameter(Comando, "@Mes", DbType.Int64, Mes)
            db.AddInParameter(Comando, "@Anio", DbType.Int64, Anio)
            db.AddInParameter(Comando, "@Id", DbType.Int64, Id)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ListarOtrosGastosPorPeriodo"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_srv_ConceptosBusquedaListaBD( _
Optional Texto As String = "" _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ConceptosBusquedaLista")
            db.AddInParameter(Comando, "@Texto", DbType.String, Texto)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ConceptosBusquedaLista"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



End Class
