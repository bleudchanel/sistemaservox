Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsProveedorSecundarioBD
    Inherits clsProveedorSecundarioBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_ProveedorSecundario")
            db.AddOutParameter(Comando, "@IdProveedorSecundario", DbType.Int64, IdProveedorSecundario)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            rs = db.ExecuteNonQuery(Comando)
            IdProveedorSecundario = db.GetParameterValue(Comando, "@IdProveedorSecundario")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_ProveedorSecundario")
            db.AddInParameter(Comando, "@IdProveedorSecundario", DbType.Int64, IdProveedorSecundario)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_ProveedorSecundario")
            db.AddInParameter(Comando, "@IdProveedorSecundario", DbType.Int64, IdProveedorSecundario)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional IdProveedorSecundario As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_ProveedorSecundario")
            db.AddInParameter(Comando, "@IdProveedorSecundario", DbType.Int64, IdProveedorSecundario)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_ProveedorSecundario"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


#End Region


    Public Function fncusp_srv_ListarProveedoresSecundariosBD( _
Optional IdProducto As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ListarProveedoresSecundarios")
            db.AddInParameter(Comando, "@IdProducto", DbType.Int64, IdProducto)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ListarProveedoresSecundarios"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function




End Class
